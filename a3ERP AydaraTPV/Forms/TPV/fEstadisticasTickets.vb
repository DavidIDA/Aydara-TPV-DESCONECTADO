Public Class fEstadisticasTickets

    Dim regkey_Formulario As String
    Dim regkey_TicketsDia As String, regkey_TicketsHora As String, regkey_TicketsArticulos As String, regkey_TicketsArticulosDetalle As String, regkey_TicketsFamilia As String, regkey_TicketsVendedor As String, regkey_ListadoContable As String

    Dim WithEvents PopupMenuCliente As fPopupMenu
    Dim WithEvents PopupMenuArticulo As fPopupMenu

#Region "Eventos formulario"
    Private Sub fEstadisticasTickets_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
            Me.gvTickets.SaveLayoutToRegistry(regkey_TicketsDia)
            Me.gvTicketsHora.SaveLayoutToRegistry(regkey_TicketsHora)
            Me.gvArticulos.SaveLayoutToRegistry(regkey_TicketsArticulos)
            Me.gvArticulos_Tickets.SaveLayoutToRegistry(regkey_TicketsArticulosDetalle)
            Me.gvTicketsFamilia.SaveLayoutToRegistry(regkey_TicketsFamilia)
            Me.gvTicketsVendedor.SaveLayoutToRegistry(regkey_TicketsVendedor)
            Me.gvListadoContable.SaveLayoutToRegistry(regkey_ListadoContable)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub fEstadisticasTickets_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.regkey_Formulario = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name
            My.Computer.Registry.CurrentUser.CreateSubKey(Me.regkey_Formulario)

            'Valores por defecto
            Me.txtEjercicio.EditValue = Today.Year
            Me.txtMes.SelectedIndex = Today.Month - 1
            Me.rgFecha.EditValue = 1

            'Configuración empresa
            With a3ERP.DatosConfig
                Me.colPRECIO_ArticulosDetalle.DisplayFormat.FormatString = "{0:c" & .NUMDECPRC & "}"
                Me.maskImporte.Mask.EditMask = "c" & .NUMDECPRC
                Me.maskImporte_Hora.Mask.EditMask = "c" & .NUMDECPRC
                Me.maskImporte_Familia.Mask.EditMask = "c" & .NUMDECPRC
                Me.maskImporte_Contabilidad.Mask.EditMask = "c" & .NUMDECPRC
                Me.maskImporte_IVA.Mask.EditMask = "c" & .NUMDECPRC
                Me.maskImporte_Vendedor.Mask.EditMask = "c" & .NUMDECPRC
            End With

            'Configuración grillas
            Me.regkey_TicketsDia = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\TicketsDia"
            Me.gvTickets.SaveLayoutToRegistry(regkey_TicketsDia & "\Default")
            Me.gvTickets.RestoreLayoutFromRegistry(Me.regkey_TicketsDia)
            Me.gvTickets.ActiveFilterString = String.Empty
            Me.gvTickets.FindFilterText = String.Empty

            Me.regkey_TicketsHora = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\TicketsHora"
            Me.gvTicketsHora.SaveLayoutToRegistry(regkey_TicketsHora & "\Default")
            Me.gvTicketsHora.RestoreLayoutFromRegistry(Me.regkey_TicketsHora)
            Me.gvTicketsHora.ActiveFilterString = String.Empty
            Me.gvTicketsHora.FindFilterText = String.Empty

            Me.regkey_TicketsArticulos = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\TicketsArticulos"
            Me.gvArticulos.SaveLayoutToRegistry(regkey_TicketsArticulos & "\Default")
            Me.gvArticulos.RestoreLayoutFromRegistry(Me.regkey_TicketsArticulos)
            Me.gvArticulos.ActiveFilterString = String.Empty
            Me.gvArticulos.FindFilterText = String.Empty

            Me.regkey_TicketsArticulosDetalle = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\TicketsArticulosDetalle"
            Me.gvArticulos_Tickets.SaveLayoutToRegistry(regkey_TicketsArticulosDetalle & "\Default")
            Me.gvArticulos_Tickets.RestoreLayoutFromRegistry(Me.regkey_TicketsArticulosDetalle)
            Me.gvArticulos_Tickets.ActiveFilterString = String.Empty
            Me.gvArticulos_Tickets.FindFilterText = String.Empty

            Me.regkey_TicketsFamilia = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\TicketsFamilia"
            Me.gvTicketsFamilia.SaveLayoutToRegistry(regkey_TicketsFamilia & "\Default")
            Me.gvTicketsFamilia.RestoreLayoutFromRegistry(Me.regkey_TicketsFamilia)
            Me.gvTicketsFamilia.ActiveFilterString = String.Empty
            Me.gvTicketsFamilia.FindFilterText = String.Empty

            Me.regkey_TicketsVendedor = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\TicketsVendedor"
            Me.gvTicketsVendedor.SaveLayoutToRegistry(regkey_TicketsVendedor & "\Default")
            Me.gvTicketsVendedor.RestoreLayoutFromRegistry(Me.regkey_TicketsVendedor)
            Me.gvTicketsVendedor.ActiveFilterString = String.Empty
            Me.gvTicketsVendedor.FindFilterText = String.Empty

            Me.regkey_ListadoContable = My.Application.Info.CompanyName & "\" & My.Application.Info.ProductName & "\" & Me.Name & "\ListadoContable"
            Me.gvListadoContable.SaveLayoutToRegistry(regkey_ListadoContable & "\Default")
            Me.gvListadoContable.RestoreLayoutFromRegistry(Me.regkey_ListadoContable)
            Me.gvListadoContable.ActiveFilterString = String.Empty
            Me.gvListadoContable.FindFilterText = String.Empty

            'Menús contextuales
            Me.PopupMenuCliente = New fPopupMenu(fPopupMenu.TipoMenu.Cliente, Me, Me.txtCODCLI)
            Me.PopupMenuArticulo = New fPopupMenu(fPopupMenu.TipoMenu.Articulo, Me, Me.txtCODART)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub fEstadisticasTickets_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
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

    Private Sub fEstadisticasTickets_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.F5
                Me.bttBuscar_Click(Me.bttBuscar, Nothing)
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

#End Region

#Region "Eventos Dataset"
    Private Sub DsConsultaTickets_ActualizaEstado(Texto As String) Handles DsConsultaTickets.ActualizaEstado
        Me.txtEstado.Caption = Texto
        Me.txtEstado.Refresh()
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            If Me.txtCODALM.EditValue = String.Empty Then Exit Try

            Dim TipoListado As dsConsultaTickets.Listado

            Select Case Me.TabInformes.SelectedTabPage.Name
                Case Me.TabPagTicketsDia.Name
                    TipoListado = a3ERP_AydaraTPV.dsConsultaTickets.Listado.TicketsDia
                Case Me.TabPagTicketsHora.Name
                    TipoListado = a3ERP_AydaraTPV.dsConsultaTickets.Listado.TicketsHora
                Case Me.TabArticulos.Name
                    TipoListado = a3ERP_AydaraTPV.dsConsultaTickets.Listado.TicketsArticulo
                Case Me.TabFamilias.Name
                    TipoListado = a3ERP_AydaraTPV.dsConsultaTickets.Listado.TicketsFamilia
                Case Me.TabVendedor.Name
                    TipoListado = a3ERP_AydaraTPV.dsConsultaTickets.Listado.TicketsVendedor
                Case Me.TabContabilidad.Name
                    TipoListado = a3ERP_AydaraTPV.dsConsultaTickets.Listado.Contable
            End Select

            'Filtros
            Dim Filtros As New dsConsultaTickets.Filtros
            Filtros.CODALM = Me.txtCODALM.EditValue
            Filtros.FECHAVENTA = Me.checkFechaVenta.Checked
            If IsDate(Me.txtFechaInicio.EditValue) Then Filtros.FECINI = Me.txtFechaInicio.EditValue
            If IsDate(Me.txtFechaFin.EditValue) Then Filtros.FECFIN = CDate(Me.txtFechaFin.EditValue).AddDays(1).AddSeconds(-1)
            Filtros.CODCLI = IIf(IsDBNull(Me.txtCODCLI.EditValue), String.Empty, Me.txtCODCLI.EditValue)
            Filtros.CODART = Me.txtCODART.EditValue
            Filtros.REPARTODOMICILIO = Me.checkRepartoDomicilio.Checked
            Filtros.LINEAS_PRECIOMANUAL = Me.checkPrecioManual.Checked
            Filtros.LINEAS_NEGATIVAS = Me.checkLineasNegativas.Checked
            Filtros.LINEAS_DTO = Me.checkLineasDto.Checked

            Me.DsConsultaTickets.Buscar(TipoListado, Filtros)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
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

#Region "Eventos txtCODCLI"
    Private Sub txtCODCLI_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCODCLI.ButtonClick

        Dim Seleccion As New a3ERPActiveX.Seleccion

        Try
            Seleccion.Tabla = "IDA_TARJETAS"
            Seleccion.CampoResultado = "NUMTARJETA"

            Dim Codigo As String = Seleccion.Ejecutar
            If Not Codigo Is Nothing Then Me.txtCODCLI.EditValue = Codigo

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub

    Private Sub txtCODCLI_Validated(sender As Object, e As EventArgs) Handles txtCODCLI.Validated
        Try
            If Not Me.txtCODCLI.IsModified Then Exit Try

            Dim NumTarjeta As String = Aydara.SentenciaSQL("SELECT NUMTARJETA FROM IDA_TARJETAS WHERE NUMTARJETA = " & Me.txtCODCLI.EditValue)

            If IsNumeric(NumTarjeta) Then
                Me.txtCODCLI.EditValue = NumTarjeta
                Me.txtNOMCLI.EditValue = Aydara.SentenciaSQL("SELECT NOMCLI FROM IDA_TARJETAS WHERE NUMTARJETA = " & NumTarjeta)
            Else
                Me.txtCODCLI.EditValue = System.DBNull.Value
                Me.txtNOMCLI.EditValue = String.Empty
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "Eventos txtCODART"
    Private Sub txtCODART_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCODART.ButtonClick

        Dim Articulo As New dsArticulos

        Try
            Dim Codigo As String = Articulo.Seleccionar
            If Not Codigo Is Nothing Then Me.txtCODART.EditValue = Codigo

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try

    End Sub

    Private Sub txtCODART_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCODART.Validated
        Try
            If Not Me.txtCODART.IsModified Then Exit Try

            Me.txtCODART.EditValue = Aydara.SentenciaSQL("SELECT CODART FROM ARTICULO WHERE LTRIM(CODART) = '" & Trim(Me.txtCODART.EditValue) & "'")
            Me.txtDESCART.EditValue = Aydara.SentenciaSQL("SELECT DESCART FROM ARTICULO WHERE CODART = '" & Me.txtCODART.EditValue & "'")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
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

#Region "TabInformes_SelectedPageChanged"
    Private Sub TabInformes_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles TabInformes.SelectedPageChanged
        Try
            Me.gcFiltroLineas.Visible = (e.Page Is Me.TabArticulos)
            Me.bttBuscar_Click(Me.bttBuscar, Nothing)
            Me.gvTicketsFamilia.ExpandAllGroups()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
#End Region

#Region "bttImprimir_Click"
    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Select Case Me.TabInformes.SelectedTabPage.Name

                Case Me.TabPagTicketsDia.Name
                    Informe.PaperName = "Tickets día"
                    Informe.PageHeaderFooter = Informes.CabeceraInforme("Tickets día", Nothing)
                    Informe.Component = Me.dgTicketsDia

                Case Me.TabPagTicketsHora.Name
                    Informe.PaperName = "Tickets hora"
                    Informe.PageHeaderFooter = Informes.CabeceraInforme("Tickets hora", Nothing)
                    Informe.Component = Me.dgTicketsHora

                Case Me.TabFamilias.Name
                    Informe.PaperName = "Tickets familia"
                    Informe.PageHeaderFooter = Informes.CabeceraInforme("Tickets familia", Nothing)
                    Informe.Component = Me.dgTicketsFamilia

                Case Me.TabVendedor.Name
                    Informe.PaperName = "Tickets vendedor"
                    Informe.PageHeaderFooter = Informes.CabeceraInforme("Tickets vendedor", Nothing)
                    Informe.Component = Me.dgTicketsVendedor

                Case Me.TabContabilidad.Name

                    Dim InfContable As New InfContable
                    InfContable.DataSource = Me.DsConsultaTickets

                    Dim InfContable_Totales As New InfContable_Totales
                    InfContable_Totales.DataSource = Me.DsConsultaTickets

                    Dim InfContable_IVA As New InfContable_IVA
                    InfContable_IVA.DataSource = Me.DsConsultaTickets

                    InfContable.subTotales.ReportSource = InfContable_Totales
                    InfContable.subIVA.ReportSource = InfContable_IVA

                    InfContable.PaperName = "Listado contable"
                    InfContable.txtTitulo.Text = "Listado contable"
                    If IsDate(Me.txtFechaInicio.EditValue) Then InfContable.txtTitulo.Text &= " desde " & Me.txtFechaInicio.EditValue
                    If IsDate(Me.txtFechaFin.EditValue) Then InfContable.txtTitulo.Text &= " hasta " & Me.txtFechaFin.EditValue

                    InfContable.CreateDocument()

                    Dim f As New PreImpreso
                    f.Informe.PrintingSystem = InfContable.PrintingSystem
                    f.Show()
                    Exit Try

            End Select

            Informe.PrintingSystem = ps
            Informe.PaperKind = Printing.PaperKind.A4

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia(Informe.PaperName, Informe)

        Catch ex As Exception
            MsgBox("Error al generar el informe." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "Popup menu"
    Private Sub PopupMenuCliente_BeforePopup() Handles PopupMenuCliente.BeforePopup
        Me.PopupMenuCliente.EsCompras = False
        Me.PopupMenuCliente.CODIGO = Me.txtCODCLI.EditValue
    End Sub

    Private Sub PopupMenuArticulo_BeforePopup() Handles PopupMenuArticulo.BeforePopup
        Me.PopupMenuArticulo.CODIGO = Me.txtCODART.EditValue
    End Sub

    Private Sub PopupMenuCliente_Seleccionar(CODIGO As String) Handles PopupMenuCliente.Seleccionar
        Try
            If CODIGO <> String.Empty Then
                Me.txtCODCLI.EditValue = CODIGO
                Me.txtCODCLI.IsModified = True
                Me.txtCODCLI_Validated(Me.txtCODCLI, Nothing)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub PopupMenuArticulo_Seleccionar(CODIGO As String) Handles PopupMenuArticulo.Seleccionar
        Try
            If CODIGO <> String.Empty Then
                Me.txtCODART.EditValue = CODIGO
                Me.txtCODART.IsModified = True
                Me.txtCODART_Validated(Me.txtCODART, Nothing)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

#End Region

End Class