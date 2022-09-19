<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fGeneracionVales
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
        Me.components = New System.ComponentModel.Container()
        Me.panelImprimir = New DevExpress.XtraEditors.PanelControl()
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtFechaCaducidad = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumVale = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPorcentaje = New DevExpress.XtraEditors.TextEdit()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumeroInicio = New DevExpress.XtraEditors.TextEdit()
        Me.txtFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.txtNumeroFin = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.DsValesTienda1 = New AydaraTPV.dsValesTienda()
        Me.bsVales = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgVales = New DevExpress.XtraGrid.GridControl()
        Me.gvVales = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoTienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoVale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaVale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaCaducidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSeleccionado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImprimir.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtFechaCaducidad.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaCaducidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumVale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcentaje.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsValesTienda1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelImprimir
        '
        Me.panelImprimir.Controls.Add(Me.bttGuardar)
        Me.panelImprimir.Controls.Add(Me.bttCancelar)
        Me.panelImprimir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelImprimir.Location = New System.Drawing.Point(0, 492)
        Me.panelImprimir.Name = "panelImprimir"
        Me.panelImprimir.Size = New System.Drawing.Size(784, 70)
        Me.panelImprimir.TabIndex = 2
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.save
        Me.bttGuardar.Location = New System.Drawing.Point(666, 13)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(106, 45)
        Me.bttGuardar.TabIndex = 0
        Me.bttGuardar.TabStop = False
        Me.bttGuardar.Text = "Guardar"
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtFechaCaducidad)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.txtNumVale)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtPorcentaje)
        Me.PanelControl1.Controls.Add(Me.bttBuscar)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtFechaFin)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtNumeroInicio)
        Me.PanelControl1.Controls.Add(Me.txtFechaInicio)
        Me.PanelControl1.Controls.Add(Me.txtNumeroFin)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(784, 77)
        Me.PanelControl1.TabIndex = 0
        '
        'txtFechaCaducidad
        '
        Me.txtFechaCaducidad.EditValue = Nothing
        Me.txtFechaCaducidad.EnterMoveNextControl = True
        Me.txtFechaCaducidad.Location = New System.Drawing.Point(515, 38)
        Me.txtFechaCaducidad.Name = "txtFechaCaducidad"
        Me.txtFechaCaducidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaCaducidad.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaCaducidad.Size = New System.Drawing.Size(84, 20)
        Me.txtFechaCaducidad.TabIndex = 6
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(425, 41)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl7.TabIndex = 41
        Me.LabelControl7.Text = "Fecha caducidad:"
        '
        'txtNumVale
        '
        Me.txtNumVale.EnterMoveNextControl = True
        Me.txtNumVale.Location = New System.Drawing.Point(409, 9)
        Me.txtNumVale.Name = "txtNumVale"
        Me.txtNumVale.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNumVale.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNumVale.Properties.Mask.EditMask = "n0"
        Me.txtNumVale.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumVale.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNumVale.Size = New System.Drawing.Size(61, 20)
        Me.txtNumVale.TabIndex = 4
        Me.txtNumVale.TabStop = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(331, 12)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl6.TabIndex = 39
        Me.LabelControl6.Text = "Primer Nº Vale:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(476, 12)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl5.TabIndex = 37
        Me.LabelControl5.Text = "Porcentaje:"
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.EnterMoveNextControl = True
        Me.txtPorcentaje.Location = New System.Drawing.Point(538, 9)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPorcentaje.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPorcentaje.Properties.Mask.EditMask = "P2"
        Me.txtPorcentaje.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPorcentaje.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPorcentaje.Size = New System.Drawing.Size(61, 20)
        Me.txtPorcentaje.TabIndex = 5
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.find
        Me.bttBuscar.Location = New System.Drawing.Point(655, 26)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(117, 32)
        Me.bttBuscar.TabIndex = 7
        Me.bttBuscar.Text = "Generar"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Número desde:"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.EditValue = Nothing
        Me.txtFechaFin.EnterMoveNextControl = True
        Me.txtFechaFin.Location = New System.Drawing.Point(214, 38)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaFin.Size = New System.Drawing.Size(84, 20)
        Me.txtFechaFin.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(180, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "hasta"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(181, 41)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl4.TabIndex = 26
        Me.LabelControl4.Text = "hasta"
        '
        'txtNumeroInicio
        '
        Me.txtNumeroInicio.EnterMoveNextControl = True
        Me.txtNumeroInicio.Location = New System.Drawing.Point(91, 9)
        Me.txtNumeroInicio.Name = "txtNumeroInicio"
        Me.txtNumeroInicio.Size = New System.Drawing.Size(83, 20)
        Me.txtNumeroInicio.TabIndex = 0
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.EditValue = Nothing
        Me.txtFechaInicio.EnterMoveNextControl = True
        Me.txtFechaInicio.Location = New System.Drawing.Point(91, 38)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaInicio.Size = New System.Drawing.Size(84, 20)
        Me.txtFechaInicio.TabIndex = 2
        '
        'txtNumeroFin
        '
        Me.txtNumeroFin.EnterMoveNextControl = True
        Me.txtNumeroFin.Location = New System.Drawing.Point(213, 9)
        Me.txtNumeroFin.Name = "txtNumeroFin"
        Me.txtNumeroFin.Size = New System.Drawing.Size(85, 20)
        Me.txtNumeroFin.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 24
        Me.LabelControl3.Text = "Fecha desde:"
        '
        'DsValesTienda1
        '
        Me.DsValesTienda1.DataSetName = "dsValesTienda"
        Me.DsValesTienda1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsVales
        '
        Me.bsVales.DataMember = "VALES_TIENDA"
        Me.bsVales.DataSource = Me.DsValesTienda1
        '
        'dgVales
        '
        Me.dgVales.DataSource = Me.bsVales
        Me.dgVales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVales.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgVales.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgVales.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgVales.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.dgVales.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.dgVales.Location = New System.Drawing.Point(0, 77)
        Me.dgVales.MainView = Me.gvVales
        Me.dgVales.Name = "dgVales"
        Me.dgVales.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskImporte})
        Me.dgVales.Size = New System.Drawing.Size(784, 415)
        Me.dgVales.TabIndex = 1
        Me.dgVales.UseEmbeddedNavigator = True
        Me.dgVales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVales})
        '
        'gvVales
        '
        Me.gvVales.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvVales.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvVales.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoTienda, Me.colCodigoVale, Me.colFechaVale, Me.colFechaCaducidad, Me.colCodigoCliente, Me.colNombre, Me.colConcepto, Me.colImporte, Me.colSeleccionado})
        Me.gvVales.GridControl = Me.dgVales
        Me.gvVales.GroupPanelText = "Arrastre una columna para agrupar por esa columna"
        Me.gvVales.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteTicket", Nothing, "{0:c2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteCobrado", Nothing, "{0:c2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImportePendiente", Nothing, "{0:c2}")})
        Me.gvVales.Name = "gvVales"
        Me.gvVales.OptionsMenu.EnableColumnMenu = False
        Me.gvVales.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvVales.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvVales.OptionsView.EnableAppearanceEvenRow = True
        Me.gvVales.OptionsView.ShowAutoFilterRow = True
        Me.gvVales.OptionsView.ShowDetailButtons = False
        Me.gvVales.OptionsView.ShowFooter = True
        Me.gvVales.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.gvVales.OptionsView.ShowGroupPanel = False
        '
        'colCodigoTienda
        '
        Me.colCodigoTienda.FieldName = "CodigoTienda"
        Me.colCodigoTienda.Name = "colCodigoTienda"
        Me.colCodigoTienda.OptionsColumn.FixedWidth = True
        Me.colCodigoTienda.Width = 99
        '
        'colCodigoVale
        '
        Me.colCodigoVale.FieldName = "CodigoVale"
        Me.colCodigoVale.Name = "colCodigoVale"
        Me.colCodigoVale.OptionsColumn.FixedWidth = True
        Me.colCodigoVale.Visible = True
        Me.colCodigoVale.VisibleIndex = 0
        Me.colCodigoVale.Width = 82
        '
        'colFechaVale
        '
        Me.colFechaVale.FieldName = "FechaVale"
        Me.colFechaVale.Name = "colFechaVale"
        Me.colFechaVale.OptionsColumn.FixedWidth = True
        Me.colFechaVale.Visible = True
        Me.colFechaVale.VisibleIndex = 1
        '
        'colFechaCaducidad
        '
        Me.colFechaCaducidad.Caption = "Caducidad"
        Me.colFechaCaducidad.FieldName = "FechaCaducidad"
        Me.colFechaCaducidad.Name = "colFechaCaducidad"
        Me.colFechaCaducidad.Visible = True
        Me.colFechaCaducidad.VisibleIndex = 2
        '
        'colCodigoCliente
        '
        Me.colCodigoCliente.Caption = "Cliente"
        Me.colCodigoCliente.FieldName = "CodigoCliente"
        Me.colCodigoCliente.Name = "colCodigoCliente"
        Me.colCodigoCliente.Visible = True
        Me.colCodigoCliente.VisibleIndex = 3
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 4
        Me.colNombre.Width = 215
        '
        'colConcepto
        '
        Me.colConcepto.FieldName = "Concepto"
        Me.colConcepto.Name = "colConcepto"
        Me.colConcepto.Visible = True
        Me.colConcepto.VisibleIndex = 5
        Me.colConcepto.Width = 217
        '
        'colImporte
        '
        Me.colImporte.DisplayFormat.FormatString = "{0:c2}"
        Me.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.OptionsColumn.FixedWidth = True
        Me.colImporte.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:c2}")})
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 6
        '
        'colSeleccionado
        '
        Me.colSeleccionado.FieldName = "Seleccionado"
        Me.colSeleccionado.Name = "colSeleccionado"
        Me.colSeleccionado.Width = 151
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.EditMask = "c2"
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'fGeneracionVales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgVales)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.panelImprimir)
        Me.Name = "fGeneracionVales"
        Me.Text = "fGeneracionVales"
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImprimir.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtFechaCaducidad.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaCaducidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumVale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcentaje.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsValesTienda1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelImprimir As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPorcentaje As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumeroInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNumeroFin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumVale As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DsValesTienda1 As AydaraTPV.dsValesTienda
    Friend WithEvents bsVales As System.Windows.Forms.BindingSource
    Friend WithEvents dgVales As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVales As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colCodigoTienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoVale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaVale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeleccionado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtFechaCaducidad As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colFechaCaducidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCliente As DevExpress.XtraGrid.Columns.GridColumn
End Class
