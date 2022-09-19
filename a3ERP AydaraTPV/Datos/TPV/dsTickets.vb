Partial Class dsTickets

    Dim taTickets As New dsTicketsTableAdapters.IDA_TICKETSTableAdapter
    Dim taLineas As New dsTicketsTableAdapters.IDA_TICKETSLINEASTableAdapter
    Dim taCajas As New dsTicketsTableAdapters.IDA_CAJASTableAdapter
    Dim taIngresos As New dsTicketsTableAdapters.IDA_INGRESOSTIENDASTableAdapter

    Dim LOG As New dsTPVLog

    Public Event ActualizaDatos()

    Public Sub AddEvents()
        AddHandler Me.IDA_TICKETS.ColumnChanged, AddressOf Me.IDA_TICKETS.IDA_TICKETSDataTable_ColumnChanged
        AddHandler Me.IDA_TICKETSLINEAS.ColumnChanged, AddressOf Me.IDA_TICKETSLINEAS.IDA_TICKETSLINEASDataTable_ColumnChanged
        AddHandler Me.IDA_CAJAS.ColumnChanged, AddressOf Me.IDA_CAJAS.IDA_CAJASDataTable_ColumnChanged
        AddHandler Me.IDA_INGRESOSTIENDAS.ColumnChanged, AddressOf Me.IDA_INGRESOSTIENDAS.IDA_INGRESOSTIENDASDataTable_ColumnChanged
    End Sub

    Public Sub RemoveEvents()
        RemoveHandler Me.IDA_TICKETS.ColumnChanged, AddressOf Me.IDA_TICKETS.IDA_TICKETSDataTable_ColumnChanged
        RemoveHandler Me.IDA_TICKETSLINEAS.ColumnChanged, AddressOf Me.IDA_TICKETSLINEAS.IDA_TICKETSLINEASDataTable_ColumnChanged
        RemoveHandler Me.IDA_CAJAS.ColumnChanged, AddressOf Me.IDA_CAJAS.IDA_CAJASDataTable_ColumnChanged
        RemoveHandler Me.IDA_INGRESOSTIENDAS.ColumnChanged, AddressOf Me.IDA_INGRESOSTIENDAS.IDA_INGRESOSTIENDASDataTable_ColumnChanged
    End Sub

#Region "Eventos cabeceras tickets"
    Partial Class IDA_TICKETSDataTable
        Public Sub IDA_TICKETSDataTable_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanged
            DirectCast(Me.DataSet, dsTickets).onActualizaDatos()
        End Sub
    End Class
#End Region

#Region "Eventos líneas tickets"
    Partial Class IDA_TICKETSLINEASDataTable
        Public Sub IDA_TICKETSLINEASDataTable_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanged
            DirectCast(Me.DataSet, dsTickets).onActualizaDatos()
        End Sub
    End Class
#End Region

#Region "Eventos cajas"
    Partial Class IDA_CAJASDataTable
        Public Sub IDA_CAJASDataTable_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanged
            DirectCast(Me.DataSet, dsTickets).onActualizaDatos()
        End Sub

        Private Sub IDA_CAJASDataTable_RowDeleted(sender As Object, e As DataRowChangeEventArgs) Handles Me.RowDeleted
            DirectCast(Me.DataSet, dsTickets).onActualizaDatos()
        End Sub
    End Class
#End Region

#Region "Eventos ingresos"
    Partial Class IDA_INGRESOSTIENDASDataTable
        Public Sub IDA_INGRESOSTIENDASDataTable_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanged
            DirectCast(Me.DataSet, dsTickets).onActualizaDatos()
        End Sub

        Private Sub IDA_INGRESOSTIENDASDataTable_RowDeleted(sender As Object, e As DataRowChangeEventArgs) Handles Me.RowDeleted
            DirectCast(Me.DataSet, dsTickets).onActualizaDatos()
        End Sub
    End Class
#End Region

#Region "Eventos Dataset"
    Public Sub onActualizaDatos()
        RaiseEvent ActualizaDatos()
    End Sub
#End Region

#Region "Funciones"
    Public Sub Buscar(filtro As String)
        Try
            Aydara.Estado("Buscando tickets de venta")

            Me.Clear()

            Dim taCabeceras As New dsTicketsTableAdapters.IDA_TICKETSTableAdapter
            Dim taLineas As New dsTicketsTableAdapters.IDA_TICKETSLINEASTableAdapter

            taCabeceras.daTickets.SelectCommand.CommandTimeout = 600000
            taLineas.daLineas.SelectCommand.CommandTimeout = 600000

            'Tickets
            taCabeceras.daTickets.SelectCommand.CommandText = "SELECT IDA_TICKETS.*, ALMACEN.DESCALM AS ALMACEN_DESC, ALMACEN.IDA_TIPOTIENDA AS ALMACEN_TIPO, ISNULL(IDA_TARJETAS.NOMCLI, 'VENTA CONTADO') AS CLIENTE_NOMCLI, " & _
                                                              "CABEALBV.SERIE + '/' + CONVERT(VARCHAR,CONVERT(INT,CABEALBV.NUMDOC)) AS ALBARAN_NUMDOC, CABEFACV.SERIE + '/' + CONVERT(VARCHAR,CONVERT(INT,CABEFACV.NUMDOC)) AS FACTURA_NUMDOC " & _
                                                              "FROM IDA_TICKETS INNER JOIN ALMACEN ON IDA_TICKETS.CODALM = ALMACEN.CODALM " & _
                                                              "LEFT JOIN IDA_TARJETAS ON IDA_TICKETS.NUMTARJETA = IDA_TARJETAS.NUMTARJETA " & _
                                                              "LEFT JOIN CABEALBV ON IDA_TICKETS.IDALBV = CABEALBV.IDALBV " & _
                                                              "LEFT JOIN CABEFACV ON IDA_TICKETS.IDFACV = CABEFACV.IDFACV " & _
                                                              filtro
            taCabeceras.Fill(Me.IDA_TICKETS)

            'Líneas tickets
            taLineas.daLineas.SelectCommand.CommandText = "SELECT IDA_TICKETSLINEAS.* " & _
                                                          "FROM IDA_TICKETS INNER JOIN ALMACEN ON IDA_TICKETS.CODALM = ALMACEN.CODALM " & _
                                                          "INNER JOIN IDA_TICKETSLINEAS ON IDA_TICKETS.IDTICKET = IDA_TICKETSLINEAS.IDTICKET " & _
                                                          filtro
            taLineas.Fill(Me.IDA_TICKETSLINEAS)

        Catch ex As Exception
            Throw ex
        Finally
            Aydara.Estado()
        End Try
    End Sub

    Public Sub TotalesCaja(filtro As String)
        Try
            Aydara.Estado("Buscando totales de caja")

            Me.Clear()

            Dim taCajas As New dsTicketsTableAdapters.IDA_CAJASTableAdapter

            taCajas.daCajas.SelectCommand.CommandTimeout = 600000

            'Líneas tickets
            taCajas.daCajas.SelectCommand.CommandText = "SELECT ALMACEN.DESCALM AS ALMACEN_DESCALM, IDA_CAJAS.*, " & _
                                                        "ISNULL((SELECT ISNULL(SUM(L.TOTLIN / (1+(I.PORIVA/100))),0) " & _
                                                        "FROM IDA_TICKETS AS T INNER JOIN IDA_TICKETSLINEAS AS L ON T.IDTICKET = L.IDTICKET INNER JOIN ARTICULO AS A ON L.CODART = A.CODART INNER JOIN TIPOIVA AS I ON L.TIPIVA = I.TIPIVA " & _
                                                        "WHERE T.CODALM = IDA_CAJAS.CODALM AND T.FECCIERRE = IDA_CAJAS.FECHA AND ISNULL(L.ARTICULODIRECTO,A.IDA_ARTICULODIRECTO) <> 'T'),0) AS PROPIA_BASE, " & _
                                                        "ISNULL((SELECT ISNULL(SUM(L.TOTLIN),0) " & _
                                                        "FROM IDA_TICKETS AS T INNER JOIN IDA_TICKETSLINEAS AS L ON T.IDTICKET = L.IDTICKET INNER JOIN ARTICULO AS A ON L.CODART = A.CODART " & _
                                                        "WHERE T.CODALM = IDA_CAJAS.CODALM AND T.FECCIERRE = IDA_CAJAS.FECHA AND ISNULL(L.ARTICULODIRECTO,A.IDA_ARTICULODIRECTO) <> 'T'),0) AS PROPIA_TOTAL, " & _
                                                        "ISNULL((SELECT ISNULL(SUM(L.TOTLIN / (1+(I.PORIVA/100))),0) " & _
                                                        "FROM IDA_TICKETS AS T INNER JOIN IDA_TICKETSLINEAS AS L ON T.IDTICKET = L.IDTICKET INNER JOIN ARTICULO AS A ON L.CODART = A.CODART INNER JOIN TIPOIVA AS I ON L.TIPIVA = I.TIPIVA " & _
                                                        "WHERE T.CODALM = IDA_CAJAS.CODALM AND T.FECCIERRE = IDA_CAJAS.FECHA),0) AS TIENDA_BASE, " & _
                                                        "ISNULL((SELECT ISNULL(SUM(C.VENTA),0) " & _
                                                        "FROM IDA_CAJAS AS C " & _
                                                        "WHERE C.CODALM = IDA_CAJAS.CODALM AND C.FECHA = IDA_CAJAS.FECHA),0) AS TIENDA_TOTAL " & _
                                                        "FROM IDA_CAJAS INNER JOIN ALMACEN ON IDA_CAJAS.CODALM = ALMACEN.CODALM " & _
                                                        filtro
            taCajas.Fill(Me.IDA_CAJAS)

        Catch ex As Exception
            Throw ex
        Finally
            Aydara.Estado()
        End Try
    End Sub

    Public Sub IngresosTienda(filtro As String)
        Try
            Aydara.Estado("Buscando totales de tienda")

            Me.Clear()

            Dim taIngresos As New dsTicketsTableAdapters.IDA_INGRESOSTIENDASTableAdapter

            taIngresos.daIngresos.SelectCommand.CommandTimeout = 600000

            'Totales tienda
            taIngresos.daIngresos.SelectCommand.CommandText = "SELECT ALMACEN.DESCALM AS ALMACEN_DESCALM, IDA_INGRESOSTIENDAS.*, " & _
                                                        "ISNULL((SELECT ISNULL(SUM(L.TOTLIN / (1+(I.PORIVA/100))),0) " & _
                                                        "FROM IDA_TICKETS AS T INNER JOIN IDA_TICKETSLINEAS AS L ON T.IDTICKET = L.IDTICKET INNER JOIN ARTICULO AS A ON L.CODART = A.CODART INNER JOIN TIPOIVA AS I ON L.TIPIVA = I.TIPIVA " & _
                                                        "WHERE T.CODALM = IDA_INGRESOSTIENDAS.CODALM AND T.FECCIERRE = IDA_INGRESOSTIENDAS.FECHA AND ISNULL(L.ARTICULODIRECTO,A.IDA_ARTICULODIRECTO) <> 'T'),0) AS PROPIA_BASE, " & _
                                                        "ISNULL((SELECT ISNULL(SUM(L.TOTLIN),0) " & _
                                                        "FROM IDA_TICKETS AS T INNER JOIN IDA_TICKETSLINEAS AS L ON T.IDTICKET = L.IDTICKET INNER JOIN ARTICULO AS A ON L.CODART = A.CODART " & _
                                                        "WHERE T.CODALM = IDA_INGRESOSTIENDAS.CODALM AND T.FECCIERRE = IDA_INGRESOSTIENDAS.FECHA AND ISNULL(L.ARTICULODIRECTO,A.IDA_ARTICULODIRECTO) <> 'T'),0) AS PROPIA_TOTAL, " & _
                                                        "ISNULL((SELECT ISNULL(SUM(L.TOTLIN / (1+(I.PORIVA/100))),0) " & _
                                                        "FROM IDA_TICKETS AS T INNER JOIN IDA_TICKETSLINEAS AS L ON T.IDTICKET = L.IDTICKET INNER JOIN ARTICULO AS A ON L.CODART = A.CODART INNER JOIN TIPOIVA AS I ON L.TIPIVA = I.TIPIVA " & _
                                                        "WHERE T.CODALM = IDA_INGRESOSTIENDAS.CODALM AND T.FECCIERRE = IDA_INGRESOSTIENDAS.FECHA),0) AS TIENDA_BASE, " & _
                                                        "ISNULL((SELECT ISNULL(SUM(L.TOTLIN),0) " & _
                                                        "FROM IDA_TICKETS AS T INNER JOIN IDA_TICKETSLINEAS AS L ON T.IDTICKET = L.IDTICKET INNER JOIN ARTICULO AS A ON L.CODART = A.CODART " & _
                                                        "WHERE T.CODALM = IDA_INGRESOSTIENDAS.CODALM AND T.FECCIERRE = IDA_INGRESOSTIENDAS.FECHA),0) AS TIENDA_TOTAL, " & _
                                                        "ISNULL((SELECT ISNULL(SUM(EFECTIVO + RETIRADAFONDOS - ENTRADACAMBIOS),0) " & _
                                                        "FROM IDA_CAJAS AS C " & _
                                                        "WHERE C.CODALM = IDA_INGRESOSTIENDAS.CODALM AND C.FECHA = IDA_INGRESOSTIENDAS.FECHA),0) AS EFECTIVO " & _
                                                        "FROM IDA_INGRESOSTIENDAS INNER JOIN ALMACEN ON IDA_INGRESOSTIENDAS.CODALM = ALMACEN.CODALM " & _
                                                        filtro
            taIngresos.Fill(Me.IDA_INGRESOSTIENDAS)

            If a3ERP.Empresa = a3ERP.FormatoEmpresa.Calavia Then

                Dim Valtierra As DataRow() = Me.IDA_INGRESOSTIENDAS.Select("TRIM(CODALM) = '4'")

                For i As Integer = 0 To Valtierra.Length - 1
                    With CType(Valtierra(i), dsTickets.IDA_INGRESOSTIENDASRow)
                        .EFECTIVO = .PROPIA_TOTAL
                    End With
                Next

            End If

        Catch ex As Exception
            Throw ex
        Finally
            Aydara.Estado()
        End Try
    End Sub

    Public Sub Nuevo()

    End Sub

    Public Sub Cargar(Optional IDTICKET As Integer = 0)
        Try
            Me.Clear()

            If IDTICKET = 0 Then
                Me.taTickets.Fill(Me.IDA_TICKETS)
                Me.taLineas.Fill(Me.IDA_TICKETSLINEAS)
            Else
                Me.taTickets.FillBy(Me.IDA_TICKETS, IDTICKET)
                Me.taLineas.FillBy(Me.IDA_TICKETSLINEAS, IDTICKET)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub VentaCredito(TIPDOC As Integer)
        Try
            Me.taTickets.VentaCredito(Me.IDA_TICKETS, TIPDOC)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Guardar()
        Try
            Aydara.Estado("", "Actualizando tickets")

            'Eliminar líneas de tickets
            Dim Eliminadas As DataRow() = Me.IDA_TICKETSLINEAS.Select("", "", DataViewRowState.Deleted)
            If Eliminadas.Length > 0 Then
                a3ERP.fWaitForm.SetCaption("Eliminando líneas de tickets")
                taLineas.Update(Eliminadas)
            End If

            a3ERP.fWaitForm.SetCaption("Guardando cabeceras de tickets")
            taTickets.Update(Me.IDA_TICKETS)

            a3ERP.fWaitForm.SetCaption("Guardando líneas de tickets")
            taLineas.Update(Me.IDA_TICKETSLINEAS)

            a3ERP.fWaitForm.SetCaption("Guardando totales por caja")
            taCajas.Update(Me.IDA_CAJAS)

            a3ERP.fWaitForm.SetCaption("Guardando ingresos tienda")
            taIngresos.Update(Me.IDA_INGRESOSTIENDAS)

        Catch ex As Exception
            Throw ex
        Finally
            Aydara.Estado()
        End Try
    End Sub

    Public Sub Cancelar()
        Me.RejectChanges()
    End Sub

#End Region

#Region "ImportarFicheroCajas"
    Public Sub ImportarFicheroCajas(ByVal RutaFichero As String)

        Dim sr As New IO.StreamReader(RutaFichero, System.Text.Encoding.Default)
        Dim linea() As String
        Dim TipoLinea As String = String.Empty

        Dim rCaja As dsTickets.IDA_CAJASRow

        Dim configActual As Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture

        Try
            Aydara.Estado("Leyendo fichero de cajas")

            Me.RemoveEvents()

            'Configuración punto decimal
            Dim r As New Globalization.CultureInfo("es-ES")
            r.NumberFormat.CurrencyDecimalSeparator = ","
            r.NumberFormat.NumberDecimalSeparator = ","
            System.Threading.Thread.CurrentThread.CurrentCulture = r

            While Not sr.EndOfStream

                linea = Split(sr.ReadLine, vbTab)

                If linea.Length = 0 Then Continue While
                If Not IsNumeric(linea(0)) Then Continue While

                rCaja = Me.IDA_CAJAS.NewIDA_CAJASRow
                With rCaja
                    .CODALM = String.Format("{0,8}", CInt(linea(0)))
                    .FECHA = linea(1)
                    .CAJA = CInt(linea(2))
                    .TICKETS = CInt(linea(3))
                    .LINEAS = CInt(linea(4))
                    .EFECTIVO = CDec(linea(5))
                    .TALON = CDec(linea(6))
                    .NUMFACTURAS = CDec(linea(7))
                    .TARJETA = CDec(linea(8))
                    .VALESEMITIDOS = CDec(linea(9))
                    .VALESPROVEEDOR = CDec(linea(10))
                    .ENVASES = CDec(linea(11))
                    .VENTA = CDec(linea(12))
                    .COBROSCLIENTE = CDec(linea(13))
                    .PAGOSPROVEEDOR = CDec(linea(14))
                    .ENTRADACAMBIOS = CDec(linea(15))
                    .RETIRADAFONDOS = CDec(linea(16))
                    .NUMFACTURAS = CDec(linea(17))
                    .PENDIENTECOBRO = CDec(linea(18))
                    .REPARTODOMICILIO = CDec(linea(21))
                    .VALESEMITIDOS = CDec(linea(22))
                    .TOTFACTURAS = CDec(linea(23))
                End With
                Me.IDA_CAJAS.AddIDA_CAJASRow(rCaja)

                'Eliminar totales de caja existentes
                Aydara.SentenciaSQL("DELETE FROM IDA_CAJAS WHERE CODALM = '" & rCaja.CODALM & "' AND FECHA = '" & rCaja.FECHA & "' AND CAJA = " & rCaja.CAJA & " AND TICKETS = " & rCaja.TICKETS & " AND LINEAS = " & rCaja.LINEAS)

            End While

            'Guardar datos importados
            a3ERP.fWaitForm.SetCaption("Guardando datos importados...")
            Me.taCajas.Update(Me.IDA_CAJAS)

        Catch ex As Exception
            Throw ex
        Finally
            System.Threading.Thread.CurrentThread.CurrentCulture = configActual
            sr.Close()
            Me.AddEvents()
        End Try

    End Sub
#End Region

End Class

#Region "TableAdapters"
Namespace dsTicketsTableAdapters
    Partial Public Class IDA_TICKETSTableAdapter
        Public ReadOnly Property daTickets() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class

    Partial Public Class IDA_TICKETSLINEASTableAdapter
        Public ReadOnly Property daLineas() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class

    Partial Public Class IDA_CAJASTableAdapter
        Public ReadOnly Property daCajas() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class

    Partial Public Class IDA_INGRESOSTIENDASTableAdapter
        Public ReadOnly Property daIngresos() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class
End Namespace
#End Region
