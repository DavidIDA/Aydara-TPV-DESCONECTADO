<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fExportaralbaranes
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.txtFechaFin = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtFechaInicio = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.chkSoloPendientes = New DevExpress.XtraEditors.CheckEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.panelImprimir = New DevExpress.XtraEditors.PanelControl
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.dgTickets = New DevExpress.XtraGrid.GridControl
        Me.bsTickets = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsHistorico1 = New AydaraTPV.dsHistorico
        Me.gvTickets = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoTienda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoCaja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroAlbaran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaTicket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoCobro = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTempCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImporteTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaCierre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExportado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        CType(Me.txtFechaFin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSoloPendientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImprimir.SuspendLayout()
        CType(Me.dgTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHistorico1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFechaFin
        '
        Me.txtFechaFin.EditValue = Nothing
        Me.txtFechaFin.EnterMoveNextControl = True
        Me.txtFechaFin.Location = New System.Drawing.Point(209, 14)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaFin.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFechaFin.Size = New System.Drawing.Size(84, 20)
        Me.txtFechaFin.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(172, 17)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl4.TabIndex = 30
        Me.LabelControl4.Text = "hasta:"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.EditValue = Nothing
        Me.txtFechaInicio.EnterMoveNextControl = True
        Me.txtFechaInicio.Location = New System.Drawing.Point(82, 14)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaInicio.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFechaInicio.Size = New System.Drawing.Size(84, 20)
        Me.txtFechaInicio.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(11, 17)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 28
        Me.LabelControl3.Text = "Fecha desde:"
        '
        'chkSoloPendientes
        '
        Me.chkSoloPendientes.EditValue = True
        Me.chkSoloPendientes.Location = New System.Drawing.Point(319, 14)
        Me.chkSoloPendientes.Name = "chkSoloPendientes"
        Me.chkSoloPendientes.Properties.Caption = "Exportar solo los Pendientes"
        Me.chkSoloPendientes.Size = New System.Drawing.Size(175, 19)
        Me.chkSoloPendientes.TabIndex = 2
        Me.chkSoloPendientes.TabStop = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.bttBuscar)
        Me.PanelControl1.Controls.Add(Me.chkSoloPendientes)
        Me.PanelControl1.Controls.Add(Me.txtFechaInicio)
        Me.PanelControl1.Controls.Add(Me.txtFechaFin)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(786, 48)
        Me.PanelControl1.TabIndex = 0
        '
        'bttBuscar
        '
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.find
        Me.bttBuscar.Location = New System.Drawing.Point(500, 8)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(90, 31)
        Me.bttBuscar.TabIndex = 3
        Me.bttBuscar.Text = "Buscar"
        '
        'panelImprimir
        '
        Me.panelImprimir.Controls.Add(Me.bttGuardar)
        Me.panelImprimir.Controls.Add(Me.bttCancelar)
        Me.panelImprimir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelImprimir.Location = New System.Drawing.Point(0, 502)
        Me.panelImprimir.Name = "panelImprimir"
        Me.panelImprimir.Size = New System.Drawing.Size(786, 70)
        Me.panelImprimir.TabIndex = 2
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.save
        Me.bttGuardar.Location = New System.Drawing.Point(668, 13)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(106, 45)
        Me.bttGuardar.TabIndex = 0
        Me.bttGuardar.TabStop = False
        Me.bttGuardar.Text = "Exportar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(11, 13)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 1
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'dgTickets
        '
        Me.dgTickets.DataSource = Me.bsTickets
        Me.dgTickets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTickets.Location = New System.Drawing.Point(0, 48)
        Me.dgTickets.MainView = Me.gvTickets
        Me.dgTickets.Name = "dgTickets"
        Me.dgTickets.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskImporte})
        Me.dgTickets.Size = New System.Drawing.Size(786, 454)
        Me.dgTickets.TabIndex = 1
        Me.dgTickets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTickets})
        '
        'bsTickets
        '
        Me.bsTickets.DataMember = "HISTORICO_TICKETS"
        Me.bsTickets.DataSource = Me.DsHistorico1
        Me.bsTickets.Sort = "CodigoTienda, CodigoCaja, NumeroTicket"
        '
        'DsHistorico1
        '
        Me.DsHistorico1.DataSetName = "dsHistorico"
        Me.DsHistorico1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvTickets
        '
        Me.gvTickets.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvTickets.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvTickets.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoTienda, Me.colCodigoCaja, Me.colNumeroAlbaran, Me.colFechaTicket, Me.colTipoCobro, Me.colCodigoCliente, Me.colTempCliente, Me.colImporteTotal, Me.colFechaCierre, Me.colExportado})
        Me.gvTickets.GridControl = Me.dgTickets
        Me.gvTickets.GroupPanelText = "Arrastre una columna para agrupar por esa columna"
        Me.gvTickets.Name = "gvTickets"
        Me.gvTickets.OptionsBehavior.Editable = False
        Me.gvTickets.OptionsMenu.EnableColumnMenu = False
        Me.gvTickets.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvTickets.OptionsPrint.UsePrintStyles = True
        Me.gvTickets.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvTickets.OptionsView.EnableAppearanceEvenRow = True
        Me.gvTickets.OptionsView.ShowAutoFilterRow = True
        Me.gvTickets.OptionsView.ShowDetailButtons = False
        Me.gvTickets.OptionsView.ShowFooter = True
        Me.gvTickets.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.gvTickets.OptionsView.ShowGroupPanel = False
        '
        'colCodigoTienda
        '
        Me.colCodigoTienda.Caption = "Tienda"
        Me.colCodigoTienda.FieldName = "CodigoTienda"
        Me.colCodigoTienda.Name = "colCodigoTienda"
        Me.colCodigoTienda.OptionsColumn.FixedWidth = True
        Me.colCodigoTienda.Width = 60
        '
        'colCodigoCaja
        '
        Me.colCodigoCaja.Caption = "Caja"
        Me.colCodigoCaja.FieldName = "CodigoCaja"
        Me.colCodigoCaja.Name = "colCodigoCaja"
        Me.colCodigoCaja.OptionsColumn.FixedWidth = True
        Me.colCodigoCaja.Visible = True
        Me.colCodigoCaja.VisibleIndex = 0
        Me.colCodigoCaja.Width = 50
        '
        'colNumeroAlbaran
        '
        Me.colNumeroAlbaran.Caption = "Nº Albarán"
        Me.colNumeroAlbaran.FieldName = "NumeroAlbaran"
        Me.colNumeroAlbaran.Name = "colNumeroAlbaran"
        Me.colNumeroAlbaran.OptionsColumn.FixedWidth = True
        Me.colNumeroAlbaran.Visible = True
        Me.colNumeroAlbaran.VisibleIndex = 1
        '
        'colFechaTicket
        '
        Me.colFechaTicket.Caption = "Fecha"
        Me.colFechaTicket.FieldName = "FechaTicket"
        Me.colFechaTicket.Name = "colFechaTicket"
        Me.colFechaTicket.OptionsColumn.FixedWidth = True
        Me.colFechaTicket.Visible = True
        Me.colFechaTicket.VisibleIndex = 2
        '
        'colTipoCobro
        '
        Me.colTipoCobro.Caption = "Tipo Cobro"
        Me.colTipoCobro.FieldName = "TipoCobro"
        Me.colTipoCobro.Name = "colTipoCobro"
        Me.colTipoCobro.OptionsColumn.FixedWidth = True
        '
        'colCodigoCliente
        '
        Me.colCodigoCliente.Caption = "Código"
        Me.colCodigoCliente.FieldName = "CodigoCliente"
        Me.colCodigoCliente.Name = "colCodigoCliente"
        Me.colCodigoCliente.OptionsColumn.FixedWidth = True
        Me.colCodigoCliente.Visible = True
        Me.colCodigoCliente.VisibleIndex = 3
        '
        'colTempCliente
        '
        Me.colTempCliente.Caption = "Cliente"
        Me.colTempCliente.FieldName = "TempCliente"
        Me.colTempCliente.Name = "colTempCliente"
        Me.colTempCliente.Visible = True
        Me.colTempCliente.VisibleIndex = 4
        Me.colTempCliente.Width = 56
        '
        'colImporteTotal
        '
        Me.colImporteTotal.Caption = "Importe"
        Me.colImporteTotal.DisplayFormat.FormatString = "{0:c2}"
        Me.colImporteTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImporteTotal.FieldName = "ImporteTotal"
        Me.colImporteTotal.Name = "colImporteTotal"
        Me.colImporteTotal.OptionsColumn.FixedWidth = True
        Me.colImporteTotal.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colImporteTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colImporteTotal.Visible = True
        Me.colImporteTotal.VisibleIndex = 5
        '
        'colFechaCierre
        '
        Me.colFechaCierre.Caption = "Fecha Cierre"
        Me.colFechaCierre.FieldName = "FechaCierre"
        Me.colFechaCierre.Name = "colFechaCierre"
        Me.colFechaCierre.OptionsColumn.FixedWidth = True
        Me.colFechaCierre.Visible = True
        Me.colFechaCierre.VisibleIndex = 6
        Me.colFechaCierre.Width = 83
        '
        'colExportado
        '
        Me.colExportado.FieldName = "Exportado"
        Me.colExportado.Name = "colExportado"
        Me.colExportado.OptionsColumn.FixedWidth = True
        Me.colExportado.Visible = True
        Me.colExportado.VisibleIndex = 7
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.EditMask = "c2"
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'fExportaralbaranes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 572)
        Me.Controls.Add(Me.dgTickets)
        Me.Controls.Add(Me.panelImprimir)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fExportaralbaranes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exportar Albaranes"
        CType(Me.txtFechaFin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSoloPendientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImprimir.ResumeLayout(False)
        CType(Me.dgTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHistorico1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSoloPendientes As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panelImprimir As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgTickets As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTickets As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DsHistorico1 As AydaraTPV.dsHistorico
    Friend WithEvents bsTickets As System.Windows.Forms.BindingSource
    Friend WithEvents colCodigoTienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCaja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroAlbaran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaTicket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoCobro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporteTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaCierre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExportado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTempCliente As DevExpress.XtraGrid.Columns.GridColumn
End Class
