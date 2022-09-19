Public Class fRecepcionTiendas

    Dim regkey_Formulario As String, regKey_Ventas As String, regKey_Pedidos As String, regKey_Traspasos As String, regKey_Inventarios As String

    Dim LOG As New dsTPVLog

#Region "Eventos formulario"
    Private Sub fRecepcionTiendas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If Me.MdiParent Is Nothing Then
                If Me.WindowState = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Normal
                My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("WindowState", CInt(Me.WindowState))
                If Me.WindowState = FormWindowState.Normal Then
                    My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("Left", Me.Left)
                    My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("Top", Me.Top)
                    My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("Width", Me.Width)
                    My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario, True).SetValue("Height", Me.Height)
                End If
            End If
            Me.gvVentas.SaveLayoutToRegistry(regKey_Ventas)
            Me.gvPedidos.SaveLayoutToRegistry(regKey_Pedidos)
            Me.gvTraspasos.SaveLayoutToRegistry(regKey_Traspasos)
            Me.gvInventarios.SaveLayoutToRegistry(regKey_Inventarios)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub fRecepcionTiendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.regkey_Formulario = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name
            My.Computer.Registry.CurrentUser.CreateSubKey(Me.regkey_Formulario)

            'Configuración grillas
            Me.regKey_Ventas = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\Ventas"
            Me.gvVentas.SaveLayoutToRegistry(regKey_Ventas & "\Default")
            Me.gvVentas.RestoreLayoutFromRegistry(Me.regKey_Ventas)
            Me.gvVentas.ActiveFilterString = String.Empty
            Me.gvVentas.FindFilterText = String.Empty

            Me.regKey_Pedidos = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\Pedidos"
            Me.gvPedidos.SaveLayoutToRegistry(regKey_Pedidos & "\Default")
            Me.gvPedidos.RestoreLayoutFromRegistry(Me.regKey_Pedidos)
            Me.gvPedidos.ActiveFilterString = String.Empty
            Me.gvPedidos.FindFilterText = String.Empty

            Me.regKey_Traspasos = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\Traspasos"
            Me.gvTraspasos.SaveLayoutToRegistry(regKey_Traspasos & "\Default")
            Me.gvTraspasos.RestoreLayoutFromRegistry(Me.regKey_Traspasos)
            Me.gvTraspasos.ActiveFilterString = String.Empty
            Me.gvTraspasos.FindFilterText = String.Empty

            Me.regKey_Inventarios = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\Inventarios"
            Me.gvInventarios.SaveLayoutToRegistry(regKey_Inventarios & "\Default")
            Me.gvInventarios.RestoreLayoutFromRegistry(Me.regKey_Inventarios)
            Me.gvInventarios.ActiveFilterString = String.Empty
            Me.gvInventarios.FindFilterText = String.Empty

            Me.DsTPVRecepcion.Recepcionar()

            Me.DsTPVRecepcion.LeerFicheros()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fRecepcionTiendas_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            'Ajustar tamaños de paneles
            Me.gcVentas.Height = (Me.Height - Me.gcOpciones.Height) / 3
            Me.gcPedidos.Height = (Me.Height - Me.gcOpciones.Height) / 3
            Me.gcTraspasos.Width = Me.Width / 2

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fRecepcionTiendas_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If Me.MdiParent Is Nothing Then
                'Posición y tamaño
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("WindowState", Nothing) Is Nothing Then Me.WindowState = CInt(My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("WindowState", Me.WindowState))
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Left", Nothing) Is Nothing Then Me.Left = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Left", Me.Left)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Top", Nothing) Is Nothing Then Me.Top = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Top", Me.Top)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Width", Nothing) Is Nothing Then Me.Width = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Width", Me.Width)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Height", Nothing) Is Nothing Then Me.Height = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Height", Me.Height)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            Me.TopMost = False
        End Try
    End Sub

#End Region

#Region "bttActualizar_Click"
    Private Sub bttActualizar_Click(sender As Object, e As EventArgs) Handles bttActualizar.Click
        Try
            Me.dgVentas.FocusedView.CloseEditor()
            Me.dgVentas.FocusedView.UpdateCurrentRow()

            Me.dgTraspasos.FocusedView.CloseEditor()
            Me.dgTraspasos.FocusedView.UpdateCurrentRow()

            Me.dgPedidos.FocusedView.CloseEditor()
            Me.dgPedidos.FocusedView.UpdateCurrentRow()

            Me.DsTPVRecepcion.ModoActualizacion = a3ERP_AydaraTPV.dsTPVRecepcion.TipoActualizacion.Manual
            Me.DsTPVRecepcion.Actualizar()

            MsgBox("Proceso de actualización finalizado", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Error al intentar importar datos." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            Me.DsTPVRecepcion.LeerFicheros()
        End Try
    End Sub
#End Region

#Region "Selección"
    Private Sub Grilla_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gvVentas.PopupMenuShowing, gvTraspasos.PopupMenuShowing, gvInventarios.PopupMenuShowing, gvPedidos.PopupMenuShowing
        Try
            If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Or e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.User Then
                Me.bttSeleccionarActual.Tag = DirectCast(sender, DevExpress.XtraGrid.Views.Grid.GridView).GetFocusedDataRow
                If Not Me.bttSeleccionarActual.Tag Is Nothing Then Me.PopupMenu.ShowPopup(MousePosition)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub PopupMenu_Popup(sender As Object, e As EventArgs) Handles PopupMenu.Popup
        Try
            If DirectCast(Me.bttSeleccionarActual.Tag, dsTPVRecepcion.RECEPCIONRow).IMPORTAR Then
                Me.bttSeleccionarActual.Caption = "Anular actual"
            Else
                Me.bttSeleccionarActual.Caption = "Seleccionar actual"
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttSeleccionarTodos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttSeleccionarTodos.ItemClick
        Me.SeleccionarTodos(True)
    End Sub

    Private Sub bttAnularTodos_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttAnularTodos.ItemClick
        Me.SeleccionarTodos(False)
    End Sub

    Private Sub bttSeleccionarActual_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttSeleccionarActual.ItemClick
        Me.SeleccionarActual()
    End Sub

    Private Sub SeleccionarActual()
        Try
            With DirectCast(Me.bttSeleccionarActual.Tag, dsTPVRecepcion.RECEPCIONRow)
                .IMPORTAR = IIf(.IMPORTAR, False, True)
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub SeleccionarTodos(Selecciona As Boolean)
        Try
            Dim Ficheros As DataRow()

            Ficheros = Me.DsTPVRecepcion.RECEPCION.Select("TIPO = '" & DirectCast(Me.bttSeleccionarActual.Tag, dsTPVRecepcion.RECEPCIONRow).TIPO & "'")

            For i As Integer = 0 To Ficheros.Length - 1
                With DirectCast(Ficheros(i), dsTPVRecepcion.RECEPCIONRow)
                    .IMPORTAR = Selecciona
                End With
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

End Class
