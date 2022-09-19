Partial Class dsInventarios

    Public FECHA As Date

    Public Event ActualizaDatos()

    Public Sub onActualizaDatos()
        RaiseEvent ActualizaDatos()
    End Sub

    Public Sub AddEvents()
        AddHandler Me.IDA_INVENTARIOTERMINAL.RowChanged, AddressOf Me.IDA_INVENTARIOTERMINAL.IDA_INVENTARIOTERMINALDataTable_RowChanged
    End Sub

    Public Sub RemoveEvents()
        RemoveHandler Me.IDA_INVENTARIOTERMINAL.RowChanged, AddressOf Me.IDA_INVENTARIOTERMINAL.IDA_INVENTARIOTERMINALDataTable_RowChanged
    End Sub

#Region "Eventos líneas"
    Partial Class IDA_INVENTARIOTERMINALDataTable
        Public Sub IDA_INVENTARIOTERMINALDataTable_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanged
            Try
                RemoveHandler Me.ColumnChanged, AddressOf IDA_INVENTARIOTERMINALDataTable_ColumnChanged

                If e.Column Is Me.CODARTColumn Then

                    With DirectCast(e.Row, dsInventarios.IDA_INVENTARIOTERMINALRow)

                        .CODART = Aydara.SentenciaSQL("SELECT CODART FROM ARTICULO WHERE LTRIM(CODART) = '" & Trim(e.ProposedValue) & "' AND AFESTOCK = 'T'")

                        If .CODART = String.Empty Then Me.CancelaFila(e.Row) : Exit Try

                        If e.Row.RowState = DataRowState.Detached Or e.Row.RowState = DataRowState.Added Then
                            'Comprobar que no exista el artículo
                            If CInt(Aydara.SentenciaSQL("SELECT COUNT(*) FROM IDA_INVENTARIOTERMINAL WHERE CODALM = '" & .CODALM & "' AND CODART = '" & .CODART & "'")) > 0 Then
                                MsgBox("Ya existe el artículo en el inventario del almacén.", MsgBoxStyle.Information)
                                Me.CancelaFila(e.Row)
                                Exit Try
                            End If
                        End If

                        Dim Articulo As New dsArticulos

                        Articulo.InfoArticulo(False, String.Empty, .CODALM, .CODART)

                        If Articulo.INFOART.Count > 0 Then

                            Dim rArticulo As dsArticulos.INFOARTRow = Articulo.INFOART(0)
                            .DESCART = rArticulo.DESCART
                            .UNIPAQV = rArticulo.UNIPAQV

                            'Stock fecha inventario
                            .STOCK = DirectCast(Me.DataSet, dsInventarios).StockArticulo(.CODALM, .CODART, DirectCast(Me.DataSet, dsInventarios).FECHA)

                        End If

                    End With

                End If

                If e.Column Is Me.columnCAJAS Then

                    With DirectCast(e.Row, dsInventarios.IDA_INVENTARIOTERMINALRow)
                        .UNIDADES = .UNIPAQV * e.ProposedValue
                    End With

                End If

                e.Row.EndEdit()

            Catch ex As Exception
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Finally
                AddHandler Me.ColumnChanged, AddressOf IDA_INVENTARIOTERMINALDataTable_ColumnChanged
            End Try
        End Sub

        Public Sub IDA_INVENTARIOTERMINALDataTable_RowChanged(sender As Object, e As DataRowChangeEventArgs) Handles Me.RowChanged
            DirectCast(Me.DataSet, dsInventarios).onActualizaDatos()
        End Sub

        Private Sub CancelaFila(Fila As dsInventarios.IDA_INVENTARIOTERMINALRow)
            If Fila.RowState = DataRowState.Detached Then Fila.BeginEdit()
            Fila.CancelEdit()
        End Sub

    End Class
#End Region

#Region "Funciones"
    Public Sub Cargar(Optional CODALM As String = "")

        Dim taInventario As New dsInventariosTableAdapters.IDA_INVENTARIOTERMINALTableAdapter

        Try
            Me.RemoveEvents()

            If CODALM <> String.Empty Then
                taInventario.daInventario.SelectCommand.CommandText &= " WHERE CODALM = '" & CODALM & "'"
            End If

            taInventario.Fill(Me.IDA_INVENTARIOTERMINAL)

        Catch ex As Exception
            Throw ex
        Finally
            Me.AddEvents()
        End Try

    End Sub

    Public Sub Cargar(CODALM As String, FECHA As Date)

        Dim taInventario As New dsInventariosTableAdapters.IDA_INVENTARIOTERMINALTableAdapter

        Try
            Aydara.Estado("Cargando inventario")

            Me.Cargar(CODALM)

            If Me.IDA_INVENTARIOTERMINAL.Count > 0 Then

                Try
                    Me.RemoveEvents()

                    a3ERP.fWaitForm.SetCaption("Calculando stock")

                    taInventario.TiempoConexion(600)

                    taInventario.FillBy(Me.IDA_INVENTARIOTERMINAL, CODALM, FECHA)

                Catch ex As Exception
                    Throw ex
                Finally
                    Me.AddEvents()
                End Try

            End If

        Catch ex As Exception
            Throw ex
        Finally
            Aydara.Estado()
        End Try

    End Sub

    Public Function StockArticulo(CODALM As String, CODART As String, FECHA As Date) As Double

        Dim taInventario As New dsInventariosTableAdapters.IDA_INVENTARIOTERMINALTableAdapter

        Try
            Return taInventario.StockArticulo(CODALM, CODART, FECHA)

        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Sub Nuevo(CODALM As String, CODART As String, CAJAS As Double, UNIDADES As Double)
        Try
            Me.RemoveEvents()
            RemoveHandler IDA_INVENTARIOTERMINAL.ColumnChanged, AddressOf IDA_INVENTARIOTERMINAL.IDA_INVENTARIOTERMINALDataTable_ColumnChanged

            CODART = Aydara.SentenciaSQL("SELECT CODART FROM ARTICULO WHERE LTRIM(CODART) = '" & Trim(CODART) & "'")
            If CODART = String.Empty Then Exit Try

            UNIDADES += CAJAS * CInt(Aydara.SentenciaSQL("SELECT UNIPAQT FROM ARTICULO WHERE CODART = '" & CODART & "'"))

            Dim rLinea As dsInventarios.IDA_INVENTARIOTERMINALRow
            Dim Articulo As DataRow()

            Articulo = Me.IDA_INVENTARIOTERMINAL.Select("CODALM = '" & CODALM & "' AND CODART = '" & CODART & "'")

            If Articulo.Length > 0 Then
                DirectCast(Articulo(0), dsInventarios.IDA_INVENTARIOTERMINALRow).UNIDADES += UNIDADES
            Else
                rLinea = Me.IDA_INVENTARIOTERMINAL.NewIDA_INVENTARIOTERMINALRow
                rLinea.CODALM = CODALM
                rLinea.CODART = CODART
                rLinea.UNIDADES = UNIDADES
                Me.IDA_INVENTARIOTERMINAL.AddIDA_INVENTARIOTERMINALRow(rLinea)
            End If

        Catch ex As Exception
            Throw ex
        Finally
            AddHandler IDA_INVENTARIOTERMINAL.ColumnChanged, AddressOf IDA_INVENTARIOTERMINAL.IDA_INVENTARIOTERMINALDataTable_ColumnChanged
            Me.AddEvents()
        End Try
    End Sub

    Public Sub Guardar()

        Dim taInventario As New dsInventariosTableAdapters.IDA_INVENTARIOTERMINALTableAdapter

        Try
            Me.RemoveEvents()

            Aydara.Estado("Guardando inventario")

            taInventario.Update(Me.IDA_INVENTARIOTERMINAL)

        Catch ex As Exception
            Throw ex
        Finally
            Me.AddEvents()
            Aydara.Estado()
        End Try
    End Sub

    Public Sub Cancelar()
        Try
            Me.RemoveEvents()

            Aydara.Estado("Deshaciendo cambios")

            Me.RejectChanges()

        Catch ex As Exception
            Throw ex
        Finally
            Me.AddEvents()
            Aydara.Estado()
        End Try
    End Sub

    Public Sub Eliminar()
        Try
            Me.RemoveEvents()

            Aydara.Estado("Eliminando inventario")

            Dim Inventario As DataRow() = Me.IDA_INVENTARIOTERMINAL.Select()

            For i As Integer = 0 To Inventario.Length - 1
                DirectCast(Inventario(i), dsInventarios.IDA_INVENTARIOTERMINALRow).Delete()
            Next

            Me.Guardar()

        Catch ex As Exception
            Throw ex
        Finally
            Me.AddEvents()
            Aydara.Estado()
        End Try
    End Sub

    Public Sub Actualizar(CODALM As String, FechaInventario As Date, FechaRegularizaion As Date, General As Boolean)

        Dim a3ERPRegularizacion As New a3ERPActiveX.Regularizacion

        Try
            Me.RemoveEvents()

            Aydara.Estado("", "Regularizando existencias")

            If General Then

                a3ERP.fWaitForm.SetCaption("Añadiendo artículos sin inventariar")

                Dim taInventario As New dsInventariosTableAdapters.IDA_INVENTARIOTERMINALTableAdapter

                taInventario.ClearBeforeFill = False
                taInventario.TiempoConexion(600)
                taInventario.SinInventariar(Me.IDA_INVENTARIOTERMINAL, CODALM, FechaInventario)

            End If

            Dim Articulos As DataRow() = Me.IDA_INVENTARIOTERMINAL.Select("UNIDADES <> STOCK")
            If Articulos.Length > 0 Then

                a3ERP.fWaitForm.SetCaption("Creando regularización")

                a3ERPRegularizacion.Iniciar()
                a3ERPRegularizacion.OmitirMensajes = True

                a3ERPRegularizacion.Nuevo(FechaRegularizaion.ToShortDateString, CODALM)
                a3ERPRegularizacion.AsStringCab("MOTIVO") = "Inventario a fecha " & FechaInventario.ToShortDateString

                For i As Integer = 0 To Articulos.Length - 1
                    With DirectCast(Articulos(i), dsInventarios.IDA_INVENTARIOTERMINALRow)


                        a3ERP.fWaitForm.SetCaption("Añadiendo artículo " & i + 1 & " de " & Articulos.Length)

                        a3ERPRegularizacion.NuevaLinea()
                        a3ERPRegularizacion.AsStringLin("CODART") = .CODART
                        a3ERPRegularizacion.AsFloatLin("UNIDADES") = .UNIDADES - .STOCK
                        a3ERPRegularizacion.AsStringLin("PARAM1") = .UNIDADES
                        a3ERPRegularizacion.AsStringLin("PARAM2") = .STOCK

                        'Datos trazabilidad
                        If Aydara.SentenciaSQL("SELECT HAYLOTES FROM ARTICULO WHERE CODART = '" & a3ERPRegularizacion.AsStringLin("CODART") & "'") = "T" Then
                            a3ERPRegularizacion.AnadirDetalle(a3ERPRegularizacion.AsFloatLin("UNIDADES"), String.Empty, "TIENDA", String.Empty, String.Empty)
                        End If

                        If a3ERPRegularizacion.AsFloatLin("UNIDADES") <> 0 Then
                            a3ERPRegularizacion.AnadirLinea()
                        Else
                            a3ERPRegularizacion.CancelaLin()
                        End If

                    End With
                Next

                a3ERP.fWaitForm.SetCaption("Guardando regularización")

                a3ERPRegularizacion.Anade()

            End If

        Catch ex As Exception
            Throw ex
        Finally
            a3ERPRegularizacion.Acabar()
            Me.AddEvents()
            Aydara.Estado()
        End Try
    End Sub

    Public Sub DescargarTerminales(CODALM As String)
        Try
            Me.RemoveEvents()

            Aydara.Estado("Descargando ficheros terminales")

            Dim FTP As New Ftp
            Dim ConfigTPV As New dsTPVConfiguracion

            ConfigTPV.Cargar()

            If ConfigTPV.IDA_AYDARATPV.Count > 0 Then
                With ConfigTPV.IDA_AYDARATPV(0)

                    Dim DirectorioFicheros As String = .DIRECTORIO & "\Terminales"

                    'Comprobar directorio de ficheros
                    If .DIRECTORIO = String.Empty Then
                        MsgBox("Seleccione un directorio para los ficheros en la configuración", MsgBoxStyle.Exclamation)
                        Exit Try
                    Else
                        If Not IO.Directory.Exists(DirectorioFicheros) Then
                            IO.Directory.CreateDirectory(DirectorioFicheros)
                        End If

                        FTP.host = .TERMINALES
                        FTP.DameFicheros(DirectorioFicheros, True)

                    End If

                    a3ERP.fWaitForm.SetCaption("Cargando inventario actual del almacén")
                    Me.Cargar(CODALM)

                    a3ERP.fWaitForm.SetCaption("Leyendo ficheros")

                    Dim folder As New IO.DirectoryInfo(DirectorioFicheros)

                    For Each file As IO.FileInfo In folder.GetFiles()

                        If UCase(Mid(file.Name, 1, 6)) = "TERINV" And IsNumeric(Mid(file.Name, 7, 2)) Then

                            Dim CODALM_Fichero = Aydara.SentenciaSQL("SELECT CODALM FROM ALMACEN WHERE LTRIM(CODALM) = '" & CInt(Mid(file.Name, 7, 2)) & "'")

                            If CODALM <> CODALM_Fichero Then Continue For

                            Dim sr As New System.IO.StreamReader(file.FullName, System.Text.Encoding.Default, True)
                            Dim Linea As String

                            Try
                                While Not sr.EndOfStream

                                    Linea = sr.ReadLine

                                    If Linea = String.Empty Then Continue While

                                    Me.Nuevo(CODALM, CInt(Mid(Linea, 1, 7)), CInt(Mid(Linea, 8, 10)) / 100, CInt(Mid(Linea, 18, 10)) / 100)

                                End While

                                Me.Guardar()

                            Catch ex As Exception
                                Throw ex
                            Finally
                                sr.Close()
                                If IO.File.Exists(file.FullName) Then IO.File.Delete(file.FullName)
                            End Try

                        End If

                    Next

                End With
            End If

        Catch ex As Exception
            Throw ex
        Finally
            Me.AddEvents()
            Aydara.Estado()
        End Try
    End Sub

#End Region

End Class

#Region "TableAdapters"
Namespace dsInventariosTableAdapters
    Partial Public Class IDA_INVENTARIOTERMINALTableAdapter
        Public ReadOnly Property daInventario() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
        Public Sub TiempoConexion(Segundos As Integer)
            For i As Integer = 0 To Me.CommandCollection.Count - 1
                Me.CommandCollection(i).CommandTimeout = Segundos
            Next
        End Sub
    End Class
End Namespace
#End Region
