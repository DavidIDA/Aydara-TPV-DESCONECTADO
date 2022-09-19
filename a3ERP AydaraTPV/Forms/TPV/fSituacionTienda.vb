Public Class fSituacionTienda

    Dim regkey_Formulario As String

#Region "Eventos formulario"
    Private Sub fSituacionTienda_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub fSituacionTienda_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.F5 'Buscar
                    If Me.bttBuscar.Enabled Then Me.bttBuscar_Click(Me.bttBuscar, Nothing)
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub fSituacionTienda_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.regkey_Formulario = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name
            My.Computer.Registry.CurrentUser.CreateSubKey(Me.regkey_Formulario)

            'Valores por defecto
            Me.txtEjercicio.EditValue = Today.Year
            Me.txtMes.SelectedIndex = Today.Month - 1
            Me.rgFecha.EditValue = 1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fSituacionTienda_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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

#Region "bttImprimir_Click"
    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click
        Try
            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PageHeaderFooter = Informes.CabeceraInforme("Situación tienda", Nothing)

            Informe.Component = Me.dgSituacion

            Informe.PrintingSystem = ps

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia("Situación tienda", Informe)

        Catch ex As Exception
            MsgBox("Error al generar el informe", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try
            If Me.txtCODALM.EditValue = String.Empty Then
                MsgBox("Seleccione una tienda.", MsgBoxStyle.Information)
                Me.txtCODALM.Focus()
                Exit Try
            End If

            Me.Cursor = Cursors.WaitCursor

            Dim FechaInicio As Date, FechaFin As Date

            If IsDate(Me.txtFechaInicio.EditValue) Then FechaInicio = Me.txtFechaInicio.EditValue Else FechaInicio = "01/01/1900"
            If IsDate(Me.txtFechaFin.EditValue) Then FechaFin = Me.txtFechaFin.EditValue Else FechaFin = "31/12/9999"

            Me.IDA_CAJASTableAdapter.Situacion(Me.DsFacturacion.IDA_CAJAS, FechaInicio, FechaFin, Me.txtCODALM.EditValue)
            Me.IDA_CAJASTableAdapter.ClearBeforeFill = False
            Me.IDA_CAJASTableAdapter.SituacionTotales(Me.DsFacturacion.IDA_CAJAS, FechaInicio, FechaFin, Me.txtCODALM.EditValue)
            Me.IDA_CAJASTableAdapter.ClearBeforeFill = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

End Class