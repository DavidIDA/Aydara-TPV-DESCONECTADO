Public Class fTickets

    Dim regkey_Formulario As String, regkey_Cabeceras As String, regkey_Lineas As String

#Region "Eventos formulario"
    Private Sub fTickets_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
            Me.gvTickets.SaveLayoutToRegistry(Me.regkey_Cabeceras)
            Me.gvLineas.SaveLayoutToRegistry(Me.regkey_Lineas)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub fTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.regkey_Formulario = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name
            My.Computer.Registry.CurrentUser.CreateSubKey(Me.regkey_Formulario)
            Me.BarManager.RegistryPath = Me.regkey_Formulario

            'Configuración grillas
            Me.regkey_Cabeceras = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\Cabeceras"
            Me.gvTickets.SaveLayoutToRegistry(regkey_Cabeceras & "\Default")
            Me.gvTickets.RestoreLayoutFromRegistry(Me.regkey_Cabeceras)
            Me.gvTickets.ActiveFilterString = String.Empty
            Me.gvTickets.FindFilterText = String.Empty

            Me.regkey_Lineas = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\Lineas"
            Me.gvLineas.SaveLayoutToRegistry(regkey_Lineas & "\Default")
            Me.gvLineas.RestoreLayoutFromRegistry(Me.regkey_Lineas)
            Me.gvLineas.ActiveFilterString = String.Empty
            Me.gvLineas.FindFilterText = String.Empty

            'Datos
            Me.DsTiendas.TiposTienda()
            Me.txtEjercicio.EditValue = Today.Year
            Me.txtMes.SelectedIndex = Today.Month - 1
            Me.rgFecha.EditValue = 6

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub fTickets_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            If Me.MdiParent Is Nothing Then
                'Posición y tamaño
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("WindowState", Nothing) Is Nothing Then Me.WindowState = CInt(My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("WindowState", Me.WindowState))
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Left", Nothing) Is Nothing Then Me.Left = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Left", Me.Left)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Top", Nothing) Is Nothing Then Me.Top = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Top", Me.Top)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Width", Nothing) Is Nothing Then Me.Width = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Width", Me.Width)
                If Not My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Height", Nothing) Is Nothing Then Me.Height = My.Computer.Registry.CurrentUser.OpenSubKey(regkey_Formulario).GetValue("Height", Me.Height)
            End If

            Me.txtCODALM.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

#Region "Eventos txtCODALM"
    Private Sub txtCODALM_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCODALM.ButtonClick

        Dim NaxMaestro As New a3ERPActiveX.Maestro

        Try
            NaxMaestro.Iniciar("ALMACEN")

            Dim Codigo As String = NaxMaestro.Seleccionar
            If Not Codigo Is Nothing Then Me.txtCODALM.EditValue = Codigo : Me.txtCODALM.DoValidate()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtCODALM_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCODALM.Validated
        Try
            If Not Me.txtCODALM.IsModified Then Exit Try

            Me.txtCODALM.EditValue = Aydara.SentenciaSQL("SELECT CODALM FROM ALMACEN WHERE LTRIM(CODALM) = '" & Trim(Me.txtCODALM.EditValue) & "'")
            Me.txtDESCALM.EditValue = Aydara.SentenciaSQL("SELECT DESCALM FROM ALMACEN WHERE CODALM = '" & Me.txtCODALM.EditValue & "'")

        Catch ex As Exception
            MsgBox("Error al buscar la tienda", MsgBoxStyle.Information)
        End Try

    End Sub

#End Region

#Region "Eventos fechas"
    Private Sub rgFecha_EditValueChanged(sender As Object, e As EventArgs) Handles rgFecha.EditValueChanged

        Me.txtMes.Properties.ReadOnly = (CInt(Me.rgFecha.EditValue) <> 3)
        Me.txtEjercicio.Properties.ReadOnly = (CInt(Me.rgFecha.EditValue) <> 3 And CInt(Me.rgFecha.EditValue) <> 5)

        Select Case CInt(Me.rgFecha.EditValue)
            Case 1
                Me.txtFechaInicio.EditValue = Date.Today
                Me.txtFechaFin.EditValue = Date.Today
            Case 2
                Me.txtFechaInicio.EditValue = DateAdd(DateInterval.WeekOfYear, -1, Date.Today)
                Me.txtFechaFin.EditValue = Date.Today
            Case 3
                Me.txtMes.Focus()
                Me.txtMes_EditValueChanged(Nothing, Nothing)
            Case 4
                Me.txtFechaInicio.EditValue = DateAdd(DateInterval.Month, -1, Date.Today)
                Me.txtFechaFin.EditValue = Date.Today
            Case 5
                Me.txtEjercicio.Focus()
                Me.txtEjercicio_EditValueChanged(Nothing, Nothing)
            Case 6
                Me.txtFechaInicio.EditValue = System.DBNull.Value
                Me.txtFechaFin.EditValue = System.DBNull.Value
        End Select

    End Sub

    Private Sub txtMes_EditValueChanged(sender As Object, e As EventArgs) Handles txtMes.EditValueChanged
        Dim Fecha As Date = New Date(CInt(Me.txtEjercicio.EditValue), Me.txtMes.SelectedIndex + 1, 1)
        Me.txtFechaInicio.EditValue = Fecha
        Me.txtFechaFin.EditValue = DateAdd(DateInterval.Month, 1, Fecha).AddDays(-1)
    End Sub

    Private Sub txtEjercicio_EditValueChanged(sender As Object, e As EventArgs) Handles txtEjercicio.EditValueChanged
        Dim Fecha As Date = New Date(CInt(Me.txtEjercicio.EditValue), 1, 1)
        Me.txtFechaInicio.EditValue = Fecha
        Me.txtFechaFin.EditValue = DateAdd(DateInterval.Year, 1, Fecha).AddDays(-1)
        If Not Me.txtMes.Properties.ReadOnly Then Me.txtMes_EditValueChanged(Nothing, Nothing)
    End Sub
#End Region

#Region "txtTipoTienda_ButtonClick"
    Private Sub txtTipoTienda_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtTipoTienda.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Close Then
            Me.txtTipoTienda.EditValue = Nothing
        End If
    End Sub
#End Region

#Region "bttAplicar_Click"
    Private Sub bttAplicar_Click(sender As Object, e As EventArgs) Handles bttAplicar.Click
        Try
            Dim sql_Where As New System.Text.StringBuilder

            sql_Where.Append("WHERE IDA_TICKETS.CREDITO = 0 ")

            Select Case Me.txtEstado.EditValue.ToString
                Case "Pendientes"
                    sql_Where.Append(" AND IDA_TICKETS.IDFACV IS NULL")
                Case "Facturados"
                    sql_Where.Append(" AND IDA_TICKETS.IDFACV IS NOT NULL")
            End Select

            If Me.txtCODALM.EditValue.ToString <> String.Empty Then
                sql_Where.Append(" AND IDA_TICKETS.CODALM = '" & Me.txtCODALM.EditValue.ToString & "'")
            End If

            If IsDate(Me.txtFechaInicio.EditValue) Then
                sql_Where.Append(" AND " & IIf(Me.checkFechaVenta.Checked, "IDA_TICKETS.FECHA", "IDA_TICKETS.FECCIERRE") & " >= '" & CDate(Me.txtFechaInicio.EditValue).ToShortDateString & "'")
            End If

            If IsDate(Me.txtFechaFin.EditValue) Then
                sql_Where.Append(" AND " & IIf(Me.checkFechaVenta.Checked, "IDA_TICKETS.FECHA", "IDA_TICKETS.FECCIERRE") & " <= '" & CDate(Me.txtFechaFin.EditValue).ToShortDateString & "'")
            End If

            If Not Me.txtTipoTienda.EditValue Is Nothing Then
                sql_Where.Append(" AND ALMACEN.IDA_TIPOTIENDA = '" & Me.txtTipoTienda.EditValue & "'")
            End If

            Me.DsTickets.Buscar(sql_Where.ToString)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "Eventos grilla"
    Private Sub gvTickets_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles gvTickets.PopupMenuShowing
        If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Row Then
            Me.PopupMenu.ShowPopup(MousePosition)
        End If
    End Sub

#End Region

#Region "bttGuardar_ItemClick"
    Private Sub bttGuardar_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttGuardar.ItemClick
        Try
            Me.dgTickets.FocusedView.CloseEditor()
            Me.dgTickets.FocusedView.UpdateCurrentRow()

            Me.DsTickets.Guardar()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

End Class