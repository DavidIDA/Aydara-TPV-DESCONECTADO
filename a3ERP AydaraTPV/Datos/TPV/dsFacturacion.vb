Partial Class dsFacturacion

    Dim LOG As New dsTPVLog

#Region "TiposFacturacion"
    Public Sub TiposFacturacion()
        Try
            Dim taTiposFacturacion As New dsFacturacionTableAdapters.IDA_TIPOSFACTURACIONTableAdapter

            taTiposFacturacion.Fill(Me.IDA_TIPOSFACTURACION)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "BuscarAlbaranes"
    Public Sub BuscarAlbaranes(filtro As String)
        Try
            Dim taAlbaranes As New dsFacturacionTableAdapters.CABEALBVTableAdapter

            taAlbaranes.daAlbaranes.SelectCommand.CommandText &= filtro & " ORDER BY CABEALBV.CODCLI, CABEALBV.FECHA"

            taAlbaranes.Fill(Me.CABEALBV)

        Catch ex As Exception
            Throw ex
        End Try

    End Sub
#End Region

#Region "Buscar tickets"
    Public Sub BuscarTickets(filtro As String)
        Try
            Dim taTickets As New dsFacturacionTableAdapters.TICKETSTableAdapter
            Dim taLineas As New dsFacturacionTableAdapters.LINEASTICKETSTableAdapter
            Dim taCierres As New dsFacturacionTableAdapters.CIERRESTableAdapter
            Dim taLineasCierre As New dsFacturacionTableAdapters.LINEASCIERRETableAdapter
            Dim taTotales As New dsFacturacionTableAdapters.TOTALESTableAdapter

            taTickets.daTickets.SelectCommand.CommandText &= filtro
            taLineas.daLineas.SelectCommand.CommandText &= filtro
            taCierres.daCierres.SelectCommand.CommandText &= filtro
            taLineasCierre.daLineas.SelectCommand.CommandText &= filtro
            taTotales.daTotales.SelectCommand.CommandText &= filtro

            Aydara.Estado("Buscando tickets pendientes")
            taTickets.Fill(Me.TICKETS)
            taLineas.Fill(Me.LINEASTICKETS)

            Aydara.Estado("Calculando totales por artículo")
            taCierres.Fill(Me.CIERRES)
            taLineasCierre.Fill(Me.LINEASCIERRE)
            taTotales.Fill(Me.TOTALES)

        Catch ex As Exception
            Throw ex
        Finally
            Me.CalculaTotales()
        End Try
    End Sub
#End Region

#Region "FacturarTickets"
    Public Sub FacturarTickets(Optional FechaFactura As Date = Nothing, Optional SegundoPlano As Boolean = False)

        Dim a3ERPFactura As New a3ERPActiveX.Factura
        Dim IdFactura As Integer

        Dim CODCLI As String
        Dim Seleccionados As DataRow() = Me.TICKETS.Select("SELECCIONAR = 1", "FECHA, CODALM")

        Dim ArticuloPropioDesde As String = Aydara.SentenciaSQL("SELECT CODARTMIN FROM IDA_AYDARATPV")
        Dim ArticuloPropioHasta As String = Aydara.SentenciaSQL("SELECT CODARTMAX FROM IDA_AYDARATPV")

        For i As Integer = 0 To Seleccionados.Length - 1
            With DirectCast(Seleccionados(i), dsFacturacion.TICKETSRow)
                Try
                    If .IsIDALBVNull Or Not .IsFACTURANull Then Continue For

                    If Not SegundoPlano Then Aydara.Estado("Creando factura de " & .DESCALM & ", " & .FECHA)

                    a3ERPFactura.Iniciar()

                    a3ERPFactura.ValidarPrecios = False
                    a3ERPFactura.ValidarArtBloqueado = False
                    a3ERPFactura.OmitirMensajes = True

                    'Cabecera factura
                    CODCLI = Aydara.SentenciaSQL("SELECT IDA_CODCLI FROM ALMACEN WHERE CODALM = '" & .CODALM & "'")
                    If CODCLI = String.Empty Then Continue For

                    Select Case .IDA_TIPOTIENDA

                        Case "Propia"
                            a3ERPFactura.Nuevo(CDate(.FECHA).ToShortDateString, CODCLI, False, True, True, False)
                            a3ERPFactura.AsStringCab("IVAINCLUIDO") = "T"
                            a3ERPFactura.AsStringCab("SERIE") = "T"

                        Case "Depósito"
                            a3ERPFactura.Nuevo(FechaFactura.ToShortDateString, CODCLI, False, True, True, False)
                            a3ERPFactura.AsStringCab("IVAINCLUIDO") = "F"
                            a3ERPFactura.AsStringCab("SERIE") = "D"

                        Case Else
                            Continue For

                    End Select

                    a3ERPFactura.AsStringCab("CODALM") = .CODALM
                    If Not .IsIDA_DESCDEPOSITONull Then
                        a3ERPFactura.AsFloatCab("PORPRONTO") = .IDA_DESCDEPOSITO
                    End If

                    'Líneas de fatura
                    Dim lineas As DataRow()

                    Select Case .IDA_TIPOTIENDA

                        Case "Propia"

                            lineas = Me.TOTALES.Select("CODALM = '" & .CODALM & "' AND FECCIERRE = '" & .FECHA & "'")

                            For linea As Integer = 0 To lineas.Length - 1
                                With DirectCast(lineas(linea), dsFacturacion.TOTALESRow)

                                    a3ERPFactura.NuevaLinea()
                                    a3ERPFactura.AsStringLin("DESCLIN") = "Total " & .NOMTIVA
                                    a3ERPFactura.AsStringLin("TIPIVA") = .TIPIVA
                                    a3ERPFactura.AsFloatLin("PRCMONEDAMASIVA") = .TOTAL
                                    a3ERPFactura.AnadirLinea()

                                End With
                            Next

                        Case "Depósito"

                            lineas = Me.LINEASTICKETS.Select("CODALM = '" & .CODALM & "' AND FECHA = '" & .FECHA & "'")

                            For linea As Integer = 0 To lineas.Length - 1
                                With DirectCast(lineas(linea), dsFacturacion.LINEASTICKETSRow)

                                    If .ARTICULODIRECTO = "T" Then
                                        Continue For
                                    End If

                                    If Trim(.CODART) >= ArticuloPropioDesde And Trim(.CODART) <= ArticuloPropioHasta Then
                                        Continue For
                                    End If

                                    a3ERPFactura.NuevaLinea()
                                    a3ERPFactura.AsStringLin("DESCLIN") = .DESCLIN
                                    a3ERPFactura.AsStringLin("TIPIVA") = .TIPIVA
                                    a3ERPFactura.AsFloatLin("UNIDADES") = .UNIDADES

                                    If DirectCast(Seleccionados(i), dsFacturacion.TICKETSRow).APLIIVA = "T" And DirectCast(Seleccionados(i), dsFacturacion.TICKETSRow).APLIREC = "T" Then
                                        .PRECIO /= (1 + .PORIVA / 100 + .PORREC / 100)
                                    ElseIf DirectCast(Seleccionados(i), dsFacturacion.TICKETSRow).APLIIVA = "T" Then
                                        .PRECIO /= (1 + .PORIVA / 100)
                                    ElseIf DirectCast(Seleccionados(i), dsFacturacion.TICKETSRow).APLIREC = "T" Then
                                        .PRECIO /= (1 + .PORREC / 100)
                                    End If
                                    a3ERPFactura.AsFloatLin("PRCMONEDA") = .PRECIO

                                    a3ERPFactura.AnadirLinea()

                                End With
                            Next

                    End Select

                    a3ERPFactura.AsStringCab("OBSERVACIONES") = "Ventas tienda desde nº ticket " & .TICKETDESDE & " hasta " & .TICKETHASTA

                    If Not SegundoPlano Then Aydara.Estado("Guardando factura")
                    IdFactura = a3ERPFactura.Anade

                    'Actulizar id de factura en ticket
                    Aydara.SentenciaSQL("UPDATE IDA_TICKETS SET IDFACV = " & IdFactura & " WHERE CODALM = '" & .CODALM & "' AND CASE '" & .IDA_TIPOTIENDA & "' WHEN 'Depósito' THEN DATENAME(month, FECCIERRE) + ' ' + CONVERT(VARCHAR, YEAR(FECCIERRE)) ELSE CONVERT(VARCHAR, FECCIERRE, 103) END = '" & .FECHA & "'")

                    '.FACTURA = Aydara.SentenciaSQL("SELECT SERIE + '/' + CONVERT(VARCHAR,CONVERT(INT,NUMDOC)) FROM CABEFACV WHERE IDFACV = " & IdFactura)
                    .FACTURA = a3ERPFactura.AsStringCab("SERIE") & "/" & CInt(a3ERPFactura.AsCurrencyCab("NUMDOC"))

                    LOG.Nuevo("A", "Factura de venta " & a3ERPFactura.AsStringCab("SERIE") & "/" & CInt(a3ERPFactura.AsCurrencyCab("NUMDOC")) & " de " & .FECHA, .CODALM)

                Catch ex As Exception
                    Throw ex
                    LOG.Nuevo("X", "Error al generar factura de venta de " & .FECHA, .CODALM)
                Finally
                    a3ERPFactura.Acabar()
                    Aydara.Estado()
                End Try

            End With
        Next

    End Sub
#End Region



#Region "GenerarAsientosCobro"
    Private Sub GenerarAsientosCobro()

        Dim a3ERPAsiento As New a3ERPActiveX.Asiento
        Dim Totales As New dsFacturacionTableAdapters.IDA_CAJASTableAdapter

        Try
            Dim TIPOCONT As String = Aydara.SentenciaSQL("SELECT TIPOCONT FROM DATOSCONFIG")
            Dim CODMON As String = Aydara.SentenciaSQL("SELECT CODMON FROM DATOSCONFIG")

            a3ERPAsiento.Iniciar()

            'Leer totales de caja pendientes
            Totales.PendientesAsiento(Me.IDA_CAJAS)

            For i As Integer = 0 To Me.IDA_CAJAS.Count - 1
                With Me.IDA_CAJAS(i)

                    Aydara.Estado("Generando asientos de cobros")

                    Dim Almacen As New dsAlmacenes

                    Almacen.Cargar(.CODALM)

                    a3ERPAsiento.Nuevo(.FECHA.ToShortDateString, TIPOCONT, "N")

                    'Efectivo
                    'a3ERPAsiento.AApunte(CODMON, )

                    a3ERPAsiento.Anade()

                End With

            Next

        Catch ex As Exception
            Throw ex
        Finally
            a3ERPAsiento.Acabar()
            Aydara.Estado()
        End Try

    End Sub

#End Region



#Region "CalculaTotales"
    Private Sub CalculaTotales()
        Try
            For i As Integer = 0 To Me.CIERRES.Count - 1
                With DirectCast(Me.CIERRES(i), dsFacturacion.CIERRESRow)

                    Dim Lineas As DataRow() = Me.LINEASCIERRE.Select("CODALM = '" & .CODALM & "' AND FECCIERRE = '" & .FECCIERRE & "'")
                    Dim Total_Propios As Decimal = 0
                    Dim Total_Almacen As Decimal = 0
                    Dim Base_Propios As Decimal = 0
                    Dim Base_Almacen As Decimal = 0
                    Dim IVA_Propios As Decimal = 0
                    Dim IVA_Almacen As Decimal = 0

                    For lin As Integer = 0 To Lineas.Count - 1
                        With DirectCast(Lineas(lin), dsFacturacion.LINEASCIERRERow)

                            Dim BaseLinea As Decimal = 0

                            If DirectCast(Me.CIERRES(i), dsFacturacion.CIERRESRow).APLIIVA = "T" And DirectCast(Me.CIERRES(i), dsFacturacion.CIERRESRow).APLIREC = "T" Then
                                BaseLinea = .IMPORTE / (1 + .PORIVA / 100 + .PORREC / 100)
                            ElseIf DirectCast(Me.CIERRES(i), dsFacturacion.CIERRESRow).APLIIVA = "T" Then
                                BaseLinea = .IMPORTE / (1 + .PORIVA / 100)
                            ElseIf DirectCast(Me.CIERRES(i), dsFacturacion.CIERRESRow).APLIREC = "T" Then
                                BaseLinea = .IMPORTE / (1 + .PORREC / 100)
                            End If

                            If DirectCast(Me.CIERRES(i), dsFacturacion.CIERRESRow).INTEXT = "F" And .ARTICULODIRECTO = "T" Then
                                Total_Propios += .IMPORTE
                                Base_Propios += BaseLinea
                                IVA_Propios += .IMPORTE - BaseLinea
                            Else
                                Total_Almacen += .IMPORTE
                                Base_Almacen += BaseLinea
                                IVA_Almacen += .IMPORTE - BaseLinea
                            End If

                        End With
                    Next

                    Dim Diferencia As Decimal = .TOTAL - Total_Propios - Total_Almacen

                    .PROPIOS_BASE = Base_Propios
                    .PROPIOS_IVA = IVA_Propios
                    .PROPIOS_TOTAL = Total_Propios

                    .ALMACEN_BASE = Base_Almacen
                    .ALMACEN_IVA = IVA_Almacen
                    .ALMACEN_TOTAL = Total_Almacen

                    .TOTAL_BASE = .PROPIOS_BASE + .ALMACEN_BASE
                    .TOTAL_IVA = .PROPIOS_IVA + .ALMACEN_IVA

                End With
            Next

        Catch ex As Exception
            Throw ex
        Finally
            Aydara.Estado()
        End Try
    End Sub
#End Region

#Region "ActualizarTicketsSeleccionados"
    Public Sub ActualizarTicketsSeleccionados(Facturar As Boolean, Optional FechaFactura As Date = Nothing)
        Try
            Dim Seleccionados As DataRow() = Me.TICKETS.Select("SELECCIONAR = 1")

            For i As Integer = 0 To Seleccionados.Length - 1
                With DirectCast(Seleccionados(i), dsFacturacion.TICKETSRow)
                    'Me.GenerarAlbaran("CODALM = '" & .CODALM & "' AND FECHA = '" & .FECHA & "'", Facturar, FechaFactura)
                End With
            Next

        Catch ex As Exception
            Throw ex
        Finally
            Aydara.Estado()
        End Try
    End Sub
#End Region

#Region "GenerarFacturaContado"
    Public Sub GenerarFacturaContado(Filtro As String)

        Dim a3ERPFactura As New a3ERPActiveX.Factura
        Dim IdFactura As Double
        Dim CODCLI As String

        Dim dsTiendas As New dsTiendas
        Dim CierresTienda As DataRow() = Me.CIERRES.Select(Filtro)

        For i As Integer = 0 To CierresTienda.Length - 1
            With DirectCast(CierresTienda(i), dsFacturacion.CIERRESRow)

                Try
                    If Not .IsIDFACVNull Then Continue For

                    Aydara.Estado("Creando factura", .DESCALM & ", " & .FECCIERRE)

                    a3ERPFactura.Iniciar()

                    a3ERPFactura.ValidarPrecios = False
                    a3ERPFactura.ValidarArtBloqueado = False
                    a3ERPFactura.OmitirMensajes = True
                    a3ERPFactura.ActivarAlarmaCab = False
                    a3ERPFactura.ActivarAlarmaLin = False

                    'Cabecera factura
                    CODCLI = Aydara.SentenciaSQL("SELECT IDA_CODCLI FROM ALMACEN WHERE CODALM = '" & .CODALM & "'")
                    If CODCLI = String.Empty Then Continue For
                    a3ERPFactura.Nuevo(.FECCIERRE.ToShortDateString, CODCLI, False, False, (.CONREPER = "T"), (.CONVENCIM = "T"))
                    If Not .IsTIPOCONTFACTURANull Then a3ERPFactura.AsStringCab("TIPOCONT") = .TIPOCONTFACTURA
                    If Not .IsSERIEFACTURANull Then a3ERPFactura.AsStringCab("SERIE") = .SERIEFACTURA
                    a3ERPFactura.AsStringCab("CODALM") = .CODALM
                    a3ERPFactura.AsStringCab("IVAINCLUIDO") = .IVAINCLUIDO
                    a3ERPFactura.AsStringCab("SIMPLIFICADA") = "T"
                    a3ERPFactura.AsStringCab("CENTROCOSTE") = "3"
                    'Comprobar si está pagada
                    If .TOTEFECTIVO + .TOTTARJETA <> 0 Then
                        a3ERPFactura.AsStringCab("FORPAG") = "C"
                        a3ERPFactura.AsStringCab("DOCPAG") = IIf(.TOTTARJETA <> 0, "5", "E")
                    End If

                    'Líneas de factura
                    Dim FiltroLineas As String = "CODALM = '" & .CODALM & "' AND FECCIERRE = '" & .FECCIERRE & "'"

                    Dim lineas As DataRow() = Me.LINEASCIERRE.Select(FiltroLineas)

                    For linea As Integer = 0 To lineas.Length - 1
                        With DirectCast(lineas(linea), dsFacturacion.LINEASCIERRERow)

                            a3ERP.fWaitForm.SetCaption("Añadiendo línea " & (linea + 1) & " de " & lineas.Length & vbCrLf & "(" & CInt((linea + 1) / lineas.Length * 100) & "%)")

                            a3ERPFactura.NuevaLinea()
                            Try
                                a3ERPFactura.AsStringLin("CODART") = .CODART
                            Catch ex As Exception
                                LOG.Nuevo("X", ex.Message, .CODALM)
                            End Try
                            a3ERPFactura.AsStringLin("DESCLIN") = .DESCLIN
                            a3ERPFactura.AsStringLin("TIPIVA") = .TIPIVA
                            a3ERPFactura.AsFloatLin("UNIDADES") = .UNIDADES

                            'Datos trazabilidad
                            If Aydara.SentenciaSQL("SELECT HAYLOTES FROM ARTICULO WHERE CODART = '" & a3ERPFactura.AsStringLin("CODART") & "'") = "T" Then
                                a3ERPFactura.AnadirDetalle(.UNIDADES, String.Empty, "TIENDA", String.Empty, String.Empty)
                            End If

                            'Precio sin IVA si no es tienda propia
                            If a3ERPFactura.AsStringCab("IVAINCLUIDO") = "F" Then
                                If Me.CIERRES(i).APLIIVA = "T" And Me.CIERRES(i).APLIREC = "T" Then
                                    .PRECIO /= (1 + .PORIVA / 100 + .PORREC / 100)
                                ElseIf Me.CIERRES(i).APLIIVA = "T" Then
                                    .PRECIO /= (1 + .PORIVA / 100)
                                ElseIf Me.CIERRES(i).APLIREC = "T" Then
                                    .PRECIO /= (1 + .PORREC / 100)
                                End If
                                a3ERPFactura.AsFloatLin("PRCMONEDA") = .PRECIO
                            Else
                                a3ERPFactura.AsFloatLin("PRCMONEDAMASIVA") = .PRECIO
                            End If

                            a3ERPFactura.AnadirLinea()

                        End With
                    Next

                    Dim Tickets As DataRow() = Me.TICKETS.Select(Filtro)
                    If Tickets.Length > 0 Then
                        With CType(Tickets(0), dsFacturacion.TICKETSRow)
                            a3ERPFactura.AsStringCab("OBSERVACIONES") = "Ventas tienda desde nº ticket " & .TICKETDESDE & " hasta " & .TICKETHASTA
                        End With
                    End If

                    a3ERP.fWaitForm.SetCaption("Guardando factura")
                    IdFactura = a3ERPFactura.Anade

                    'Actulizar id de la factura en ticket
                    Aydara.SentenciaSQL("UPDATE IDA_TICKETS SET IDFACV = " & IdFactura & " WHERE IDFACV IS NULL AND CREDITO = 0 AND CODALM = '" & .CODALM & "' AND FECCIERRE = '" & .FECCIERRE & "'")

                    .IDFACV = IdFactura
                    .ALBARAN_NUMDOC = a3ERPFactura.AsStringCab("SERIE") & "/" & CInt(a3ERPFactura.AsCurrencyCab("NUMDOC"))

                    LOG.Nuevo("F", "Factura de venta " & a3ERPFactura.AsStringCab("SERIE") & "/" & CInt(a3ERPFactura.AsCurrencyCab("NUMDOC")) & " del día " & .FECCIERRE.ToShortDateString, .CODALM)

                    'Comprobar si está pagada
                    If .TOTEFECTIVO + .TOTTARJETA <> 0 Then

                        Dim naxCartera As New a3ERPActiveX.Cartera

                        Try
                            naxCartera.Iniciar()
                            Dim NumCartera As Integer = naxCartera.ObtenerNumCartera(True, IdFactura)
                            Dim NumVen As Integer = 0
                            If NumCartera <> 0 Then
                                If .TOTEFECTIVO <> 0 Then
                                    NumVen = Aydara.SentenciaSQL("SELECT NUMVEN FROM CARTERA WHERE NUMCARTERA = " & NumCartera & " AND PAGADO = 'F'")
                                    naxCartera.Editar(NumCartera)
                                    naxCartera.EditarVencimiento(NumVen)
                                    naxCartera.VAsString("DOCPAG") = "E"
                                    NumCartera = naxCartera.Anade
                                    Dim Operacion As New a3ERPActiveX.OperacionesCartera
                                    Operacion.Cobrar(NumCartera, NumVen, True, False, "", "", .FECCIERRE.ToShortDateString, "")
                                End If
                                If .TOTTARJETA <> 0 Then
                                    NumVen = Aydara.SentenciaSQL("SELECT NUMVEN FROM CARTERA WHERE NUMCARTERA = " & NumCartera & " AND PAGADO = 'F'")
                                    naxCartera.Editar(NumCartera)
                                    naxCartera.EditarVencimiento(NumVen)
                                    naxCartera.VAsString("DOCPAG") = "5"
                                    NumCartera = naxCartera.Anade
                                    Dim Operacion As New a3ERPActiveX.OperacionesCartera
                                    Operacion.Cobrar(NumCartera, NumVen, True, False, "", "", .FECCIERRE.ToShortDateString, "")
                                End If
                            End If
                        Catch ex As Exception
                            LOG.Nuevo("X", "Error al procesar cobro factura." & vbCrLf & ex.Message, .CODALM)
                        Finally
                            naxCartera.Acabar()
                        End Try
                    End If

                Catch ex As Exception
                    LOG.Nuevo("X", "Error al generar factura de venta del día " & .FECCIERRE.ToShortDateString & vbCrLf & ex.Message, .CODALM)
                Finally
                    a3ERPFactura.Acabar()
                    Aydara.Estado()
                End Try

            End With

        Next

    End Sub
#End Region

#Region "GenerarFactura"
    Public Sub GenerarFactura(Tickets As dsFacturacion.TICKETSRow, Optional FechaFactura As Date = Nothing)

        Dim a3ERPFactura As New a3ERPActiveX.Factura
        Dim dsTiendas As New dsTiendas

        With Tickets
            Try
                If Not .IsFACTURANull Then Exit Try
                If Me.CIERRES.Select("CODALM = '" & Tickets.CODALM & "' AND FECHA = '" & Tickets.FECHA & "' AND IDALBV IS NULL").Length > 0 Then Exit Try

                'Datos tienda
                dsTiendas.Cargar(.CODALM)
                If dsTiendas.TIENDAS.Count = 0 Then Exit Try
                Dim Tienda As dsTiendas.TIENDASRow = dsTiendas.TIENDAS(0)

                If Tienda.GENERAFACTURA = "F" Then Exit Try

                Aydara.Estado("Creando factura", .DESCALM & ", " & .FECHA)

                a3ERPFactura.Iniciar()

                a3ERPFactura.ValidarPrecios = False
                a3ERPFactura.ValidarArtBloqueado = False
                a3ERPFactura.OmitirMensajes = True
                a3ERPFactura.ActivarAlarmaCab = False
                a3ERPFactura.ActivarAlarmaLin = False

                'Cabecera factura
                Dim CODCLI As String = Aydara.SentenciaSQL("SELECT IDA_CODCLI FROM ALMACEN WHERE CODALM = '" & .CODALM & "'")
                If CODCLI = String.Empty Then Exit Try

                Dim FECHA As Date
                If Tienda.FACTURADIARIA = "T" Then
                    FECHA = .FECHA
                Else
                    FECHA = FechaFactura
                End If

                a3ERPFactura.Nuevo(FECHA.ToShortDateString, CODCLI, False, True, (Tienda.CONREPER = "T"), (Tienda.CONVENCIM = "T"))
                If Not Tienda.IsTIPOCONTFACTURANull Then a3ERPFactura.AsStringCab("TIPOCONT") = Tienda.TIPOCONTFACTURA
                If Not Tienda.IsSERIEFACTURANull Then a3ERPFactura.AsStringCab("SERIE") = Tienda.SERIEFACTURA
                a3ERPFactura.AsStringCab("IVAINCLUIDO") = Tienda.IVAINCLUIDO
                a3ERPFactura.AsStringCab("CODALM") = .CODALM
                a3ERPFactura.AsStringCab("SIMPLIFICADA") = "T"

                If a3ERP.Empresa = a3ERP.FormatoEmpresa.Molina Then
                    If a3ERPFactura.AsStringCab("TIPOCONT").Trim = "2" Then
                        a3ERPFactura.AsStringCab("FORPAG") = "T"
                    End If
                End If

                'Líneas de fatura
                Dim lineas As DataRow()

                If Tienda.FACTURADIARIA = "T" Then

                    Dim FiltroLineas As String = "CODALM = '" & .CODALM & "' AND FECCIERRE = '" & .FECHA & "'"

                    lineas = Me.TOTALES.Select(FiltroLineas)

                    For linea As Integer = 0 To lineas.Length - 1
                        With DirectCast(lineas(linea), dsFacturacion.TOTALESRow)

                            a3ERP.fWaitForm.SetCaption("Añadiendo líneas")

                            a3ERPFactura.NuevaLinea()
                            a3ERPFactura.AsStringLin("DESCLIN") = "Total " & .NOMTIVA
                            a3ERPFactura.AsStringLin("TIPIVA") = .TIPIVA
                            a3ERPFactura.AsFloatLin("PRCMONEDAMASIVA") = .TOTAL
                            a3ERPFactura.AnadirLinea()

                        End With
                    Next

                Else

                    Dim FiltroLineas As String = "CODALM = '" & .CODALM & "' AND FECHA = '" & .FECHA & "'"
                    If Tienda.INTEXT = "F" Then FiltroLineas &= " AND ARTICULODIRECTO <> 'T'"

                    lineas = Me.LINEASTICKETS.Select(FiltroLineas)

                    For linea As Integer = 0 To lineas.Length - 1
                        With DirectCast(lineas(linea), dsFacturacion.LINEASTICKETSRow)

                            a3ERP.fWaitForm.SetCaption("Añadiendo línea " & (linea + 1) & " de " & lineas.Length & " (" & CInt((linea + 1) / lineas.Length * 100) & "%)")

                            a3ERPFactura.NuevaLinea()
                            a3ERPFactura.AsStringLin("DESCLIN") = .DESCLIN
                            a3ERPFactura.AsStringLin("TIPIVA") = .TIPIVA

                            If a3ERPFactura.AsStringCab("IVAINCLUIDO") = "T" Then
                                a3ERPFactura.AsFloatLin("PRCMONEDAMASIVA") = .IMPORTE
                            Else
                                If Tickets.APLIIVA = "T" And Tickets.APLIREC = "T" Then
                                    .PRECIO /= (1 + .PORIVA / 100 + .PORREC / 100)
                                ElseIf Tickets.APLIIVA = "T" Then
                                    .PRECIO /= (1 + .PORIVA / 100)
                                ElseIf Tickets.APLIREC = "T" Then
                                    .PRECIO /= (1 + .PORREC / 100)
                                End If
                                a3ERPFactura.AsFloatLin("PRCMONEDA") = .UNIDADES * .PRECIO
                            End If

                            If Not Tickets.IsIDA_DESCDEPOSITONull Then
                                a3ERPFactura.AsFloatLin("DESC1") = Tickets.IDA_DESCDEPOSITO
                            End If

                            a3ERPFactura.AsStringLin("PARAM1") = .CODART
                            a3ERPFactura.AsStringLin("PARAM2") = Math.Round(.UNIDADES, a3ERP.DatosConfig.NUMDECUNI, MidpointRounding.AwayFromZero)

                            a3ERPFactura.AnadirLinea()

                        End With
                    Next

                End If

                a3ERPFactura.AsStringCab("OBSERVACIONES") = "Ventas tienda desde nº ticket " & .TICKETDESDE & " hasta " & .TICKETHASTA
                'a3ERPFactura.AsStringCab("NUMEROINICIAL") = .TICKETDESDE
                'a3ERPFactura.AsStringCab("NUMEROFINAL") = .TICKETHASTA

                a3ERP.fWaitForm.SetCaption("Guardando factura")
                .IDFACV = a3ERPFactura.Anade

                'Actulizar id de factura en ticket
                Dim taTickets As New dsFacturacionTableAdapters.TICKETSTableAdapter
                taTickets.ActualizaTicketsFacturados(.IDFACV, .CODALM, .FECHA)

                .FACTURA = a3ERPFactura.AsStringCab("SERIE") & "/" & CInt(a3ERPFactura.AsCurrencyCab("NUMDOC"))

                LOG.Nuevo("A", "Factura de venta " & a3ERPFactura.AsStringCab("SERIE") & "/" & CInt(a3ERPFactura.AsCurrencyCab("NUMDOC")) & " de " & .FECHA, .CODALM)

            Catch ex As Exception
                LOG.Nuevo("X", "Error al generar factura de venta de " & .FECHA & vbCrLf & ex.Message, .CODALM)
            Finally
                a3ERPFactura.Acabar()
            End Try
        End With

    End Sub
#End Region

End Class

Namespace dsFacturacionTableAdapters
    Partial Public Class CABEALBVTableAdapter
        Public ReadOnly Property daAlbaranes() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class

    Partial Public Class TICKETSTableAdapter
        Public ReadOnly Property daTickets() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class

    Partial Public Class LINEASTICKETSTableAdapter
        Public ReadOnly Property daLineas() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class

    Partial Public Class CIERRESTableAdapter
        Public ReadOnly Property daCierres() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class

    Partial Public Class LINEASCIERRETableAdapter
        Public ReadOnly Property daLineas() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class

    Partial Public Class TOTALESTableAdapter
        Public ReadOnly Property daTotales() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class

End Namespace