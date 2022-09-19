<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoVales
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtNumeroInicio = New DevExpress.XtraEditors.TextEdit
        Me.txtNumeroFin = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtFechaInicio = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtFechaFin = New DevExpress.XtraEditors.DateEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.dgBusqueda = New DevExpress.XtraGrid.GridControl
        Me.VALESTIENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsValesTienda = New AydaraTPV.dsValesTienda
        Me.gvBusqueda = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoTienda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoVale = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaVale = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colSeleccionado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.panelImprimir = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtTituloListado = New DevExpress.XtraEditors.TextEdit
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.VALES_TIENDATableAdapter = New AydaraTPV.dsValesTiendaTableAdapters.VALES_TIENDATableAdapter
        CType(Me.txtNumeroInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VALESTIENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsValesTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImprimir.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtTituloListado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Número desde:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(180, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "hasta"
        '
        'txtNumeroInicio
        '
        Me.txtNumeroInicio.Location = New System.Drawing.Point(91, 9)
        Me.txtNumeroInicio.Name = "txtNumeroInicio"
        Me.txtNumeroInicio.Size = New System.Drawing.Size(83, 20)
        Me.txtNumeroInicio.TabIndex = 22
        '
        'txtNumeroFin
        '
        Me.txtNumeroFin.Location = New System.Drawing.Point(213, 9)
        Me.txtNumeroFin.Name = "txtNumeroFin"
        Me.txtNumeroFin.Size = New System.Drawing.Size(85, 20)
        Me.txtNumeroFin.TabIndex = 23
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl3.TabIndex = 24
        Me.LabelControl3.Text = "Fecha desde:"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.EditValue = Nothing
        Me.txtFechaInicio.Location = New System.Drawing.Point(91, 38)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaInicio.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFechaInicio.Size = New System.Drawing.Size(84, 20)
        Me.txtFechaInicio.TabIndex = 25
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(181, 41)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl4.TabIndex = 26
        Me.LabelControl4.Text = "hasta"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.EditValue = Nothing
        Me.txtFechaFin.Location = New System.Drawing.Point(214, 38)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaFin.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFechaFin.Size = New System.Drawing.Size(84, 20)
        Me.txtFechaFin.TabIndex = 27
        '
        'PanelControl1
        '
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
        Me.PanelControl1.Size = New System.Drawing.Size(784, 71)
        Me.PanelControl1.TabIndex = 28
        '
        'bttBuscar
        '
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.find
        Me.bttBuscar.Location = New System.Drawing.Point(315, 26)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(117, 32)
        Me.bttBuscar.TabIndex = 36
        Me.bttBuscar.Text = "Buscar"
        '
        'dgBusqueda
        '
        Me.dgBusqueda.DataSource = Me.VALESTIENDABindingSource
        Me.dgBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBusqueda.Location = New System.Drawing.Point(0, 71)
        Me.dgBusqueda.MainView = Me.gvBusqueda
        Me.dgBusqueda.Name = "dgBusqueda"
        Me.dgBusqueda.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskImporte})
        Me.dgBusqueda.Size = New System.Drawing.Size(784, 421)
        Me.dgBusqueda.TabIndex = 42
        Me.dgBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBusqueda})
        '
        'VALESTIENDABindingSource
        '
        Me.VALESTIENDABindingSource.DataMember = "VALES_TIENDA"
        Me.VALESTIENDABindingSource.DataSource = Me.DsValesTienda
        '
        'DsValesTienda
        '
        Me.DsValesTienda.DataSetName = "dsValesTienda"
        Me.DsValesTienda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvBusqueda
        '
        Me.gvBusqueda.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvBusqueda.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvBusqueda.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoTienda, Me.colCodigoVale, Me.colFechaVale, Me.colNombre, Me.colConcepto, Me.colImporte, Me.colSeleccionado})
        Me.gvBusqueda.GridControl = Me.dgBusqueda
        Me.gvBusqueda.GroupPanelText = "Arrastre una columna para agrupar por esa columna"
        Me.gvBusqueda.Name = "gvBusqueda"
        Me.gvBusqueda.OptionsBehavior.Editable = False
        Me.gvBusqueda.OptionsMenu.EnableColumnMenu = False
        Me.gvBusqueda.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvBusqueda.OptionsPrint.UsePrintStyles = True
        Me.gvBusqueda.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvBusqueda.OptionsView.EnableAppearanceEvenRow = True
        Me.gvBusqueda.OptionsView.ShowAutoFilterRow = True
        Me.gvBusqueda.OptionsView.ShowDetailButtons = False
        Me.gvBusqueda.OptionsView.ShowFooter = True
        Me.gvBusqueda.OptionsView.ShowGroupExpandCollapseButtons = False
        '
        'colCodigoTienda
        '
        Me.colCodigoTienda.FieldName = "CodigoTienda"
        Me.colCodigoTienda.Name = "colCodigoTienda"
        '
        'colCodigoVale
        '
        Me.colCodigoVale.FieldName = "CodigoVale"
        Me.colCodigoVale.Name = "colCodigoVale"
        Me.colCodigoVale.OptionsColumn.FixedWidth = True
        Me.colCodigoVale.Visible = True
        Me.colCodigoVale.VisibleIndex = 0
        Me.colCodigoVale.Width = 100
        '
        'colFechaVale
        '
        Me.colFechaVale.FieldName = "FechaVale"
        Me.colFechaVale.Name = "colFechaVale"
        Me.colFechaVale.OptionsColumn.FixedWidth = True
        Me.colFechaVale.Visible = True
        Me.colFechaVale.VisibleIndex = 1
        Me.colFechaVale.Width = 100
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 2
        Me.colNombre.Width = 243
        '
        'colConcepto
        '
        Me.colConcepto.FieldName = "Concepto"
        Me.colConcepto.Name = "colConcepto"
        Me.colConcepto.Visible = True
        Me.colConcepto.VisibleIndex = 3
        Me.colConcepto.Width = 245
        '
        'colImporte
        '
        Me.colImporte.ColumnEdit = Me.maskImporte
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.OptionsColumn.FixedWidth = True
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 4
        Me.colImporte.Width = 100
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.EditMask = "c2"
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'colSeleccionado
        '
        Me.colSeleccionado.FieldName = "Seleccionado"
        Me.colSeleccionado.Name = "colSeleccionado"
        '
        'panelImprimir
        '
        Me.panelImprimir.Controls.Add(Me.PanelControl2)
        Me.panelImprimir.Controls.Add(Me.bttCancelar)
        Me.panelImprimir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelImprimir.Location = New System.Drawing.Point(0, 492)
        Me.panelImprimir.Name = "panelImprimir"
        Me.panelImprimir.Size = New System.Drawing.Size(784, 70)
        Me.panelImprimir.TabIndex = 41
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PanelControl2.Controls.Add(Me.bttImprimir)
        Me.PanelControl2.Controls.Add(Me.LabelControl8)
        Me.PanelControl2.Controls.Add(Me.txtTituloListado)
        Me.PanelControl2.Location = New System.Drawing.Point(390, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(383, 45)
        Me.PanelControl2.TabIndex = 127
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttImprimir.Location = New System.Drawing.Point(266, 0)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(117, 45)
        Me.bttImprimir.TabIndex = 0
        Me.bttImprimir.Text = "Imprimir listado"
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl8.TabIndex = 3
        Me.LabelControl8.Text = "Título del listado:"
        '
        'txtTituloListado
        '
        Me.txtTituloListado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTituloListado.Location = New System.Drawing.Point(5, 20)
        Me.txtTituloListado.Name = "txtTituloListado"
        Me.txtTituloListado.Size = New System.Drawing.Size(255, 20)
        Me.txtTituloListado.TabIndex = 4
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(11, 13)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 126
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'VALES_TIENDATableAdapter
        '
        Me.VALES_TIENDATableAdapter.ClearBeforeFill = True
        '
        'ListadoVales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgBusqueda)
        Me.Controls.Add(Me.panelImprimir)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "ListadoVales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado de vales"
        CType(Me.txtNumeroInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFin.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VALESTIENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsValesTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImprimir.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtTituloListado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumeroInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumeroFin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBusqueda As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents panelImprimir As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DsValesTienda As AydaraTPV.dsValesTienda
    Friend WithEvents VALESTIENDABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VALES_TIENDATableAdapter As AydaraTPV.dsValesTiendaTableAdapters.VALES_TIENDATableAdapter
    Friend WithEvents colCodigoTienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoVale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaVale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeleccionado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTituloListado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
End Class
