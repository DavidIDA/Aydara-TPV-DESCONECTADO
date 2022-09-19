Public Class fLogTiendas

    Dim regkey_Formulario As String, regKey_Log As String

#Region "Eventos formulario"
    Private Sub fLogTiendas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
            Me.gvLog.SaveLayoutToRegistry(regKey_Log)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub fLogTiendas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.regkey_Formulario = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name
            My.Computer.Registry.CurrentUser.CreateSubKey(Me.regkey_Formulario)

            'Configuración grillas
            Me.regKey_Log = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name
            Me.gvLog.SaveLayoutToRegistry(regKey_Log & "\Default")
            Me.gvLog.RestoreLayoutFromRegistry(Me.regKey_Log)
            Me.gvLog.ActiveFilterString = String.Empty
            Me.gvLog.FindFilterText = String.Empty

            'Datos
            Me.DsTiendas.TiposTienda()
            Me.txtEjercicio.EditValue = Today.Year
            Me.txtMes.SelectedIndex = Today.Month - 1
            Me.rgFecha.EditValue = 1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fLogTiendas_Shown(sender As Object, e As EventArgs) Handles Me.Shown
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
        End Try
    End Sub

    Private Sub fLogTiendas_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp, gvLog.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.F5 'Buscar
                    If Me.bttBuscar.Enabled Then Me.bttBuscar_Click(Me.bttBuscar, Nothing)
                Case Keys.G
                    If e.Control Then Aydara.ConfigurarGrilla(Me.gvLog, Me.regKey_Log & "\Default")
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

#Region "Eventos Dataset"
    Private Sub DsTPVLog_ActualizaEstado(Texto As String) Handles DsTPVLog.ActualizaEstado
        Me.txtEstado.Caption = Texto
        Me.txtEstado.Refresh()
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

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(sender As Object, e As EventArgs) Handles bttBuscar.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim sql_Where As New System.Text.StringBuilder

            If Me.txtCODALM.EditValue.ToString <> String.Empty Then
                sql_Where.Append(IIf(sql_Where.Length = 0, " WHERE ", " AND "))
                sql_Where.Append("IDA_LOGTIENDAS.CODALM = '" & Me.txtCODALM.EditValue & "'")
            End If

            If IsDate(Me.txtFechaInicio.EditValue) Then
                sql_Where.Append(IIf(sql_Where.Length = 0, " WHERE ", " AND "))
                sql_Where.Append("IDA_LOGTIENDAS.FECHA >= '" & CDate(Me.txtFechaInicio.EditValue).ToShortDateString & "'")
            End If

            If IsDate(Me.txtFechaFin.EditValue) Then
                sql_Where.Append(IIf(sql_Where.Length = 0, " WHERE ", " AND "))
                sql_Where.Append("IDA_LOGTIENDAS.FECHA < '" & CDate(Me.txtFechaFin.EditValue).AddDays(1).ToShortDateString & "'")
            End If

            If Not Me.txtTipoTienda.EditValue Is Nothing Then
                sql_Where.Append(IIf(sql_Where.Length = 0, " WHERE ", " AND "))
                sql_Where.Append("ALMACEN.IDA_TIPOTIENDA = '" & Me.txtTipoTienda.EditValue & "'")
            End If

            Me.DsTPVLog.Cargar(sql_Where.ToString)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

End Class