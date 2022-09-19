Public Class RecepcionTelxon

    Dim Formula As Formula.Formula
    Dim Terminal As Formula.Term

#Region "RecepcionTelxon_KeyUp"
    Private Sub RecepcionTelxon_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "bttIniciar_Click"
    Private Sub bttIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttIniciar.Click

        Me.DsComunicaciones.TELXON.Clear()

        'Dim Terminal As Formula.Term

        ''Formula.Load(My.Application.Info.DirectoryPath & "\")

        'Formula.DataEventEnabled = True

        'AddHandler Formula.DataEvent, AddressOf Formula_DataEvent
        'AddHandler Formula.ErrorEvent, AddressOf Formula_ErrorEvent
        'AddHandler Formula.OutputCompleteEvent, AddressOf Formula_OutputCompleteEvent
        'AddHandler Formula.StatusUpdateEvent, AddressOf Formula_StatusUpdateEvent

        'Formula.DataEventEnabled = True

        'If Formula.Terminals(1) Is Nothing Then
        '    Formula.Action()
        'End If

        'If Formula.Terminals(1) Is Nothing Then Exit Sub

        'Terminal = Formula.Terminals(1)
        'If Not IO.File.Exists(Terminal.FileName) Then IO.File.Create(Terminal.FileName)

        ''MsgBox(Terminal.DeviceName & " - " & Terminal.DeviceEnabled)
        'MsgBox(Formula.Open())
        'Formula.Close()

        ''Terminal = Formula.Terminals(1)

        ''Terminal.FileWrite(Terminal.FileName)

        ''Terminal.Initiate()

        If Comunicaciones_Terminales <> String.Empty Then

            Dim Prefijo As String = String.Empty

            Select Case Me.Tag
                Case 0 'Etiquetas
                    Comunicacion.DescargaFicherosTerminales(Comunicacion.TipoFicheroTerminal.Etiquetas)
                    Prefijo = "TERETI"
                Case 1 'Pedidos
                    Comunicacion.DescargaFicherosTerminales(Comunicacion.TipoFicheroTerminal.Pedido)
                    Prefijo = "TERPED"
                Case 2 'Inventario
                    Comunicacion.DescargaFicherosTerminales(Comunicacion.TipoFicheroTerminal.Inventario)
                    Prefijo = "TERINV"
            End Select

            'Importar entradas de almacén
            Dim tFiles() As String
            tFiles = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00"))

            If tFiles.Length > 0 Then

                For i As Integer = 0 To tFiles.Length - 1

                    Dim NombreFichero As String = Mid(tFiles(i), Len(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\") + 1)

                    If UCase(Mid(NombreFichero, 1, 6)) = Prefijo And Mid(NombreFichero, 7, 2) = Format(General.NumeroAlmacen, "00") Then

                        Me.LeerFicheroFTP(tFiles(i), NombreFichero)

                    End If

                Next

            End If

        Else
            Formula = New Formula.Formula

            Dim pInfo As ProcessStartInfo = New ProcessStartInfo()
            pInfo.FileName = My.Application.Info.DirectoryPath & "\Telxon\Formula_IDA.exe"

            Dim proceso As Process = Process.Start(pInfo)
            proceso.WaitForInputIdle()
            proceso.WaitForExit()

            Formula.Load(My.Application.Info.DirectoryPath & "\Telxon\")

            If Formula.Terminals(1) Is Nothing Then Exit Sub

            Terminal = Formula.Terminals(1)
            Me.LeerFichero(Terminal.FileName)

        End If

    End Sub
#End Region

#Region "bttContinuar_Click"
    Private Sub bttContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttContinuar.Click

        Me.Cursor = Cursors.WaitCursor

        Select Case Me.Tag

            Case 0 'Etiquetas

                Dim i As Integer

                Dim dsEtiquetas As New dsEtiquetas
                Dim tEtiquetas As New dsEtiquetasTableAdapters.ETIQUETASTableAdapter
                Dim rEtiqueta As dsEtiquetas.ETIQUETASRow

                Dim rTelxon As dsComunicaciones.TELXONRow

                Try
                    For i = 0 To Me.DsComunicaciones.TELXON.Rows.Count - 1

                        rTelxon = Me.DsComunicaciones.TELXON.Rows(i)

                        If rTelxon.Codigo <> String.Empty And Not Me.ExisteEtiqueta(rTelxon.Codigo) Then
                            rEtiqueta = dsEtiquetas.ETIQUETAS.NewETIQUETASRow
                            rEtiqueta.CodigoArticulo = rTelxon.Codigo
                            'rEtiqueta.Etiquetas = Int(rTelxon.Cajas * Almacen.DameUnidadesCajaArticulo(rTelxon.Codigo)) + rTelxon.Unidades
                            dsEtiquetas.ETIQUETAS.AddETIQUETASRow(rEtiqueta)
                        End If

                    Next

                    tEtiquetas.Update(dsEtiquetas.ETIQUETAS)

                Catch ex As Exception
                    MsgBox("Error al generar etiquetas." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
                    Exit Sub
                End Try

            Case 1 'Pedidos

                Dim i As Integer, linea As Integer

                Dim dsPedidos As New dsPedidos

                Dim tLineasPedido As New dsPedidosTableAdapters.PEDIDOS_LINEASTableAdapter

                Dim rCabeceraPedido As dsPedidos.PEDIDOSRow
                Dim rLineaPedido As dsPedidos.PEDIDOS_LINEASRow

                Dim rTelxon As dsComunicaciones.TELXONRow

                'Obtener datos del pedido nuevo o existente
                dsPedidos = Me.DamePedido

                If dsPedidos.PEDIDOS.Rows.Count > 0 Then
                    rCabeceraPedido = dsPedidos.PEDIDOS.Rows(0)
                Else
                    MsgBox("Error al obtener datos del pedido", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                Try
                    For i = 0 To Me.DsComunicaciones.TELXON.Rows.Count - 1

                        rTelxon = Me.DsComunicaciones.TELXON.Rows(i)

                        If rTelxon.Codigo <> String.Empty Then

                            Try
                                'Comprobar si existe el artículo
                                For linea = 0 To dsPedidos.PEDIDOS_LINEAS.Rows.Count - 1
                                    rLineaPedido = dsPedidos.PEDIDOS_LINEAS.Rows(linea)
                                    If rLineaPedido.CodigoArticulo = rTelxon.Codigo Then
                                        rLineaPedido.Cantidad += Int(rTelxon.Cajas * Almacen.DameUnidadesCajaArticulo(rTelxon.Codigo)) + rTelxon.Unidades
                                        rLineaPedido.Total = rLineaPedido.Cantidad * rLineaPedido.Precio - (rLineaPedido.Cantidad * rLineaPedido.Precio * rLineaPedido.Descuento / 100)
                                        Exit Try
                                    End If
                                Next

                                'Si no existe el artículo crea nueva línea de pedido
                                rLineaPedido = dsPedidos.PEDIDOS_LINEAS.NewPEDIDOS_LINEASRow
                                rLineaPedido.Pedido_Id = rCabeceraPedido.Id
                                rLineaPedido.CodigoArticulo = rTelxon.Codigo
                                rLineaPedido.Descripcion = Almacen.DameDescripcionArticulo(rLineaPedido.CodigoArticulo)
                                rLineaPedido.Cantidad = Int(rTelxon.Cajas * Almacen.DameUnidadesCajaArticulo(rTelxon.Codigo)) + rTelxon.Unidades
                                rLineaPedido.Precio = Almacen.DamePrecioCosteArticulo(rLineaPedido.CodigoArticulo)
                                rLineaPedido.Total = rLineaPedido.Cantidad * rLineaPedido.Precio - (rLineaPedido.Cantidad * rLineaPedido.Precio * rLineaPedido.Descuento / 100)
                                dsPedidos.PEDIDOS_LINEAS.AddPEDIDOS_LINEASRow(rLineaPedido)

                            Catch ex As Exception
                                MsgBox("Error al actualizar una línea del pedido." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
                                Exit Sub
                            End Try

                        End If

                    Next

                    tLineasPedido.Update(dsPedidos.PEDIDOS_LINEAS)

                Catch ex As Exception
                    MsgBox("Error al generar el pedido." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
                    Exit Sub
                End Try

            Case 2 'Inventario

                Dim i As Integer, linea As Integer

                Dim dsInventario As New dsInventario
                Dim tInventario As New dsInventarioTableAdapters.INVENTARIOTableAdapter
                Dim rInventario As dsInventario.INVENTARIORow

                Dim rTelxon As dsComunicaciones.TELXONRow

                'Cargar datos actuales del inventario
                tInventario.Fill(dsInventario.INVENTARIO)
                dsInventario.AcceptChanges()


                Try
                    For i = 0 To Me.DsComunicaciones.TELXON.Rows.Count - 1

                        rTelxon = Me.DsComunicaciones.TELXON.Rows(i)

                        If rTelxon.Codigo <> String.Empty Then

                            Try
                                'Comprobar si existe el artículo
                                For linea = 0 To dsInventario.INVENTARIO.Rows.Count - 1
                                    rInventario = dsInventario.INVENTARIO.Rows(linea)
                                    If rInventario.CodigoArticulo = rTelxon.Codigo Then
                                        rInventario.Cantidad += Int(rTelxon.Cajas * Almacen.DameUnidadesCajaArticulo(rTelxon.Codigo)) + rTelxon.Unidades
                                        Exit Try
                                    End If
                                Next

                                'Si no existe el artículo crea nueva línea de inventario
                                rInventario = dsInventario.INVENTARIO.NewINVENTARIORow
                                rInventario.CodigoArticulo = rTelxon.Codigo
                                rInventario.Cantidad = Int(rTelxon.Cajas * Almacen.DameUnidadesCajaArticulo(rTelxon.Codigo)) + rTelxon.Unidades
                                dsInventario.INVENTARIO.AddINVENTARIORow(rInventario)

                            Catch ex As Exception
                                MsgBox("Error al actualizar una artículo del inventario." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
                                Exit Sub
                            End Try

                        End If

                    Next

                    tInventario.Update(dsInventario.INVENTARIO)

                    AbrirFormulario(Inventario, "Inventario")

                Catch ex As Exception
                    MsgBox("Error al actualizar inventario." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
                    Exit Sub
                End Try

        End Select

        Me.Cursor = Cursors.Default

        MsgBox("Proceso de actualización finalizado", MsgBoxStyle.Information)

        Try
            If Comunicaciones_Terminales <> String.Empty Then

                Dim Prefijo As String = String.Empty

                Select Case Me.Tag
                    Case 0 'Etiquetas
                        Comunicacion.DescargaFicherosTerminales(Comunicacion.TipoFicheroTerminal.Etiquetas)
                        Prefijo = "TERETI"
                    Case 1 'Pedidos
                        Comunicacion.DescargaFicherosTerminales(Comunicacion.TipoFicheroTerminal.Pedido)
                        Prefijo = "TERPED"
                    Case 2 'Inventario
                        Comunicacion.DescargaFicherosTerminales(Comunicacion.TipoFicheroTerminal.Inventario)
                        Prefijo = "TERINV"
                End Select

                'Importar entradas de almacén
                Dim tFiles() As String
                tFiles = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00"))

                If tFiles.Length > 0 Then
                    For i As Integer = 0 To tFiles.Length - 1
                        If IO.File.Exists(tFiles(i)) Then
                            IO.File.Delete(tFiles(i))
                        End If
                    Next
                End If

            Else

                If IO.File.Exists(Terminal.FileName) Then
                    IO.File.Copy(Terminal.FileName, IO.Path.GetDirectoryName(Terminal.FileName) & "\TELXON_ULTIMO.DAT", True)
                    IO.File.Delete(Terminal.FileName)
                End If

            End If

        Catch ex As Exception
            MsgBox("No se ha podido eliminar el fichero " & Terminal.FileName & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try

        Me.Close()

    End Sub
#End Region

#Region "LeerFichero"
    Private Sub LeerFichero(ByVal RutaFichero As String)

        If IO.File.Exists(RutaFichero) Then

            Dim sr As New System.IO.StreamReader(RutaFichero, System.Text.Encoding.Default, True)
            Dim rTelxon As dsComunicaciones.TELXONRow

            Try
                Me.Cursor = Cursors.WaitCursor

                While sr.Peek() <> -1

                    Dim s As String = sr.ReadLine()

                    If String.IsNullOrEmpty(s) Then
                        Continue While
                    End If

                    Dim Linea() As String

                    Linea = Split(s, Chr(Terminal.FieldSeparator))

                    If Trim(Linea(2)) <> String.Empty Then
                        rTelxon = Me.DsComunicaciones.TELXON.NewTELXONRow
                        rTelxon.Fecha = Trim(Linea(0)) & " " & Trim(Linea(1))
                        rTelxon.CodigoBarras = Trim(Linea(2))
                        rTelxon.Codigo = Me.DameCodigoArticulo(rTelxon.CodigoBarras)
                        rTelxon.Descripcion = Almacen.DameDescripcionArticulo(rTelxon.Codigo)
                        If IsNumeric(Trim(Linea(3))) Then rTelxon.Cajas = Trim(Linea(3))
                        If IsNumeric(Trim(Linea(4))) Then rTelxon.Unidades = Trim(Linea(4))
                        Me.DsComunicaciones.TELXON.AddTELXONRow(rTelxon)
                    End If

                End While

            Catch ex As Exception
                MsgBox("Error al leer el fichero", MsgBoxStyle.Exclamation)
            Finally
                sr.Close()
                Me.Cursor = Cursors.Default
            End Try

        Else
            MsgBox("No existe ningún fichero pendiente de actualizar", MsgBoxStyle.Information)
        End If

    End Sub
#End Region

#Region "LeerFicheroFTP"
    Private Sub LeerFicheroFTP(ByVal RutaFichero As String, ByVal NombreFichero As String)

        If IO.File.Exists(RutaFichero) Then

            Dim sr As New System.IO.StreamReader(RutaFichero, System.Text.Encoding.Default, True)
            Dim rTelxon As dsComunicaciones.TELXONRow

            Try
                Me.Cursor = Cursors.WaitCursor

                Dim Fecha As New Date(Mid(NombreFichero, 14, 4), Mid(NombreFichero, 12, 2), Mid(NombreFichero, 10, 2), Mid(NombreFichero, 18, 2), Mid(NombreFichero, 20, 2), Mid(NombreFichero, 22, 2))

                While sr.Peek() <> -1

                    Dim s As String = sr.ReadLine()

                    If String.IsNullOrEmpty(s) Then
                        Continue While
                    End If

                    If Mid(s, 1, 7) <> String.Empty Then
                        rTelxon = Me.DsComunicaciones.TELXON.NewTELXONRow
                        rTelxon.Fecha = Fecha
                        'rTelxon.CodigoBarras = Trim(Linea(2))
                        rTelxon.Codigo = Mid(s, 1, 7)
                        rTelxon.Descripcion = Almacen.DameDescripcionArticulo(rTelxon.Codigo)
                        If IsNumeric(Mid(s, 8, 10)) Then rTelxon.Cajas = CInt(Mid(s, 8, 10)) / 100
                        If IsNumeric(Mid(s, 18, 10)) Then rTelxon.Unidades = CInt(Mid(s, 18, 10)) / 100
                        Me.DsComunicaciones.TELXON.AddTELXONRow(rTelxon)
                    End If

                End While

            Catch ex As Exception
                MsgBox("Error al leer el fichero", MsgBoxStyle.Exclamation)
            Finally
                sr.Close()
                Me.Cursor = Cursors.Default
            End Try

        Else
            MsgBox("No existe ningún fichero pendiente de actualizar", MsgBoxStyle.Information)
        End If

    End Sub
#End Region

#Region "DameCodigoArticulo"
    Private Function DameCodigoArticulo(ByVal Codigo As String)

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            'Comprobar si es un código de barras
            If Len(Codigo) > 7 Then

                'Comprobar si es etiqueta tienda
                If Len(Codigo) = 13 And IsNumeric(Mid(Codigo, 8)) And Mid(Codigo, 1, 2) = PrefijoEtiqueta Then
                    Codigo = Mid(Codigo, 3, 7)
                Else
                    'Buscar código de barras
                    cmd.CommandText = "SELECT ISNULL(Codigo,'') FROM ARTICULOS " & _
                                      "INNER JOIN Codigo_Barras on ARTICULOS.Id=Codigo_Barras.Articulo_Id " & _
                                      "WHERE Codigo_Barras.CodigoBarras='" & Codigo & "'"
                    Codigo = cmd.ExecuteScalar
                End If
            Else
                If IsNumeric(Codigo) Then Codigo = Format(CInt(Codigo), "0000000")
            End If

            If Codigo Is Nothing Then Codigo = String.Empty

        Catch ex As Exception
            Codigo = String.Empty
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

        Return Codigo

    End Function
#End Region

#Region "ExisteEtiqueta"
    Private Function ExisteEtiqueta(ByVal Codigo As String)

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Dim Existe As Boolean

        Try
            cmd.CommandText = "SELECT COUNT(CodigoArticulo) FROM ETIQUETAS WHERE CodigoArticulo='" & Codigo & "'"
            Existe = (cmd.ExecuteScalar > 0)

        Catch ex As Exception
            'Error al comprobar si existe etiqueta
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

        Return Existe

    End Function
#End Region

#Region "DamePedido"
    Private Function DamePedido() As dsPedidos

        Dim dsPedidos As New dsPedidos
        Dim tPedido As New dsPedidosTableAdapters.PEDIDOSTableAdapter
        Dim rPedido As dsPedidos.PEDIDOSRow

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            'Cabecera pedido
            cmd.CommandText = "SELECT * FROM PEDIDOS " & _
                              "WHERE CodigoTienda=" & CodigoTienda & " AND CodigoProveedor=1 AND FechaEnvio IS NULL"

            dsPedidos.PEDIDOS.Load(cmd.ExecuteReader)

            If dsPedidos.PEDIDOS.Count = 0 Then

                rPedido = dsPedidos.PEDIDOS.NewPEDIDOSRow
                rPedido.CodigoTienda = 1
                rPedido.Fecha = Date.Today
                rPedido.CodigoProveedor = 1
                rPedido.NombreProveedor = "Pedido Telxon"

                'Contador nº pedido de tienda
                cmd.CommandText = "UPDATE TIENDAS SET NumeroPedido=NumeroPedido+1 WHERE CodigoTienda=" & CodigoTienda
                cmd.ExecuteNonQuery()
                cmd.CommandText = "SELECT NumeroPedido FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
                rPedido.NumeroPedido = cmd.ExecuteScalar

                dsPedidos.PEDIDOS.AddPEDIDOSRow(rPedido)

                tPedido.Update(dsPedidos.PEDIDOS)

            Else
                'Si existe pedido, cargar líneas
                rPedido = dsPedidos.PEDIDOS.Rows(0)
                cmd.CommandText = "SELECT * FROM PEDIDOS_LINEAS WHERE Pedido_Id=" & rPedido.Id
                dsPedidos.PEDIDOS_LINEAS.Load(cmd.ExecuteReader)
            End If

        Catch ex As Exception
            'Error al comprobar si existe etiqueta
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

        Return dsPedidos

    End Function
#End Region

#Region "ExisteArticulo"
    Private Function ExisteArticulo(ByVal tLineasPedido As dsPedidos.PEDIDOS_LINEASDataTable, ByVal Codigo As String, ByVal Cantidad As Decimal)

        Dim Existe As Boolean

        Dim rLineaPedido As dsPedidos.PEDIDOS_LINEASRow
        Dim i As Integer

        Try
            For i = 0 To tLineasPedido.Rows.Count - 1
                rLineaPedido = tLineasPedido.Rows(i)
                If rLineaPedido.CodigoArticulo = Codigo Then
                    rLineaPedido.Cantidad += Cantidad
                End If
            Next

        Catch ex As Exception
            'Error al comprobar si existe etiqueta
        End Try

        Return Existe

    End Function
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.Close()
    End Sub
#End Region

    '' Data Event coming from control
    ''
    'Private Sub Formula_DataEvent(ByVal OutputID As Short)
    '    On Error Resume Next
    '    'ListData.AddItem(CStr(OutputID) & "  " & Formula.DeviceData)
    '    'ListData.Selected(ListData.SelCount) = True
    'End Sub

    ''
    '' Data Event coming from control
    ''
    'Private Sub Formula_OutputCompleteEvent(ByVal OutputID As Short)
    '    'MsgBox "Data succesfully downloaded", vbExclamation
    '    MsgBox("Datos descargados correctamente", vbExclamation)
    'End Sub

    'Private Sub Formula_ErrorEvent(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByRef d As Integer)
    '    'MsgBox "Data succesfully downloaded", vbExclamation
    '    MsgBox("Datos descargados correctamente", vbExclamation)
    'End Sub

    'Private Sub Formula_StatusUpdateEvent(ByVal OutputID As Short)
    '    'MsgBox "Data succesfully downloaded", vbExclamation
    '    MsgBox("Datos descargados correctamente", vbExclamation)
    'End Sub

    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click
        Try
            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PageHeaderFooter = Informes.CabeceraInforme(Me.Text, Nothing)

            Informe.Component = Me.dgTelxon

            Informe.PrintingSystem = ps

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia(Me.Text, Informe)

        Catch ex As Exception
            MsgBox("Error al generar el informe", MsgBoxStyle.Exclamation)
        End Try
    End Sub

End Class