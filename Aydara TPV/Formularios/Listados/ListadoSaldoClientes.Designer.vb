<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoSaldoClientes
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
        Me.txtCodigoInicio = New DevExpress.XtraEditors.ButtonEdit
        Me.txtCodigoFin = New DevExpress.XtraEditors.ButtonEdit
        Me.txtNombreInicio = New DevExpress.XtraEditors.TextEdit
        Me.txtNombreFin = New DevExpress.XtraEditors.TextEdit
        Me.gcOpciones = New DevExpress.XtraEditors.GroupControl
        Me.checkDetallado = New DevExpress.XtraEditors.CheckEdit
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.PENDIENTESCOBROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsClientes = New AydaraTPV.dsClientes
        Me.panelImprimir = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtTituloListado = New DevExpress.XtraEditors.TextEdit
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.PENDIENTES_COBROTableAdapter = New AydaraTPV.dsClientesTableAdapters.PENDIENTES_COBROTableAdapter
        Me.dgBusqueda = New DevExpress.XtraGrid.GridControl
        Me.gvBusqueda = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoTienda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoCaja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoTicket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImporteTicket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colImporteCobrado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImportePendiente = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.txtCodigoInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcOpciones.SuspendLayout()
        CType(Me.checkDetallado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PENDIENTESCOBROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImprimir.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtTituloListado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Cliente desde:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(49, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Hasta:"
        '
        'txtCodigoInicio
        '
        Me.txtCodigoInicio.EnterMoveNextControl = True
        Me.txtCodigoInicio.Location = New System.Drawing.Point(87, 9)
        Me.txtCodigoInicio.Name = "txtCodigoInicio"
        Me.txtCodigoInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoInicio.Properties.MaxLength = 8
        Me.txtCodigoInicio.Size = New System.Drawing.Size(80, 20)
        Me.txtCodigoInicio.TabIndex = 0
        '
        'txtCodigoFin
        '
        Me.txtCodigoFin.EnterMoveNextControl = True
        Me.txtCodigoFin.Location = New System.Drawing.Point(87, 35)
        Me.txtCodigoFin.Name = "txtCodigoFin"
        Me.txtCodigoFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoFin.Properties.MaxLength = 8
        Me.txtCodigoFin.Size = New System.Drawing.Size(80, 20)
        Me.txtCodigoFin.TabIndex = 1
        '
        'txtNombreInicio
        '
        Me.txtNombreInicio.Location = New System.Drawing.Point(166, 9)
        Me.txtNombreInicio.Name = "txtNombreInicio"
        Me.txtNombreInicio.Properties.ReadOnly = True
        Me.txtNombreInicio.Size = New System.Drawing.Size(284, 20)
        Me.txtNombreInicio.TabIndex = 4
        Me.txtNombreInicio.TabStop = False
        '
        'txtNombreFin
        '
        Me.txtNombreFin.Location = New System.Drawing.Point(166, 35)
        Me.txtNombreFin.Name = "txtNombreFin"
        Me.txtNombreFin.Properties.ReadOnly = True
        Me.txtNombreFin.Size = New System.Drawing.Size(284, 20)
        Me.txtNombreFin.TabIndex = 5
        Me.txtNombreFin.TabStop = False
        '
        'gcOpciones
        '
        Me.gcOpciones.Controls.Add(Me.checkDetallado)
        Me.gcOpciones.Location = New System.Drawing.Point(456, 9)
        Me.gcOpciones.Name = "gcOpciones"
        Me.gcOpciones.Size = New System.Drawing.Size(94, 48)
        Me.gcOpciones.TabIndex = 21
        Me.gcOpciones.Text = "Opciones"
        '
        'checkDetallado
        '
        Me.checkDetallado.Location = New System.Drawing.Point(5, 23)
        Me.checkDetallado.Name = "checkDetallado"
        Me.checkDetallado.Properties.Caption = "Detallado"
        Me.checkDetallado.Size = New System.Drawing.Size(75, 19)
        Me.checkDetallado.TabIndex = 6
        Me.checkDetallado.TabStop = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.bttBuscar)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.gcOpciones)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtNombreFin)
        Me.PanelControl1.Controls.Add(Me.txtCodigoInicio)
        Me.PanelControl1.Controls.Add(Me.txtNombreInicio)
        Me.PanelControl1.Controls.Add(Me.txtCodigoFin)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(784, 70)
        Me.PanelControl1.TabIndex = 22
        '
        'bttBuscar
        '
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.find
        Me.bttBuscar.Location = New System.Drawing.Point(556, 25)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(117, 32)
        Me.bttBuscar.TabIndex = 36
        Me.bttBuscar.Text = "Buscar"
        '
        'PENDIENTESCOBROBindingSource
        '
        Me.PENDIENTESCOBROBindingSource.DataMember = "PENDIENTES_COBRO"
        Me.PENDIENTESCOBROBindingSource.DataSource = Me.DsClientes
        '
        'DsClientes
        '
        Me.DsClientes.DataSetName = "dsClientes"
        Me.DsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'panelImprimir
        '
        Me.panelImprimir.Controls.Add(Me.PanelControl2)
        Me.panelImprimir.Controls.Add(Me.bttCancelar)
        Me.panelImprimir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelImprimir.Location = New System.Drawing.Point(0, 492)
        Me.panelImprimir.Name = "panelImprimir"
        Me.panelImprimir.Size = New System.Drawing.Size(784, 70)
        Me.panelImprimir.TabIndex = 39
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
        'PENDIENTES_COBROTableAdapter
        '
        Me.PENDIENTES_COBROTableAdapter.ClearBeforeFill = True
        '
        'dgBusqueda
        '
        Me.dgBusqueda.DataSource = Me.PENDIENTESCOBROBindingSource
        Me.dgBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBusqueda.Location = New System.Drawing.Point(0, 70)
        Me.dgBusqueda.MainView = Me.gvBusqueda
        Me.dgBusqueda.Name = "dgBusqueda"
        Me.dgBusqueda.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskImporte})
        Me.dgBusqueda.Size = New System.Drawing.Size(784, 422)
        Me.dgBusqueda.TabIndex = 40
        Me.dgBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBusqueda})
        '
        'gvBusqueda
        '
        Me.gvBusqueda.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvBusqueda.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvBusqueda.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoTienda, Me.colCodigoCaja, Me.colCodigoCliente, Me.colNombre, Me.colCodigoTicket, Me.colFecha, Me.colImporteTicket, Me.colImporteCobrado, Me.colImportePendiente})
        Me.gvBusqueda.GridControl = Me.dgBusqueda
        Me.gvBusqueda.GroupPanelText = "Arrastre una columna para agrupar por esa columna"
        Me.gvBusqueda.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteTicket", Me.colImporteTicket, "{0:c2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteCobrado", Me.colImporteCobrado, "{0:c2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImportePendiente", Me.colImportePendiente, "{0:c2}")})
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
        Me.gvBusqueda.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colNombre, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colCodigoTienda
        '
        Me.colCodigoTienda.FieldName = "CodigoTienda"
        Me.colCodigoTienda.Name = "colCodigoTienda"
        '
        'colCodigoCaja
        '
        Me.colCodigoCaja.FieldName = "CodigoCaja"
        Me.colCodigoCaja.Name = "colCodigoCaja"
        '
        'colCodigoCliente
        '
        Me.colCodigoCliente.Caption = "Cliente"
        Me.colCodigoCliente.FieldName = "CodigoCliente"
        Me.colCodigoCliente.Name = "colCodigoCliente"
        Me.colCodigoCliente.OptionsColumn.FixedWidth = True
        Me.colCodigoCliente.Visible = True
        Me.colCodigoCliente.VisibleIndex = 0
        Me.colCodigoCliente.Width = 80
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 1
        Me.colNombre.Width = 247
        '
        'colCodigoTicket
        '
        Me.colCodigoTicket.FieldName = "CodigoTicket"
        Me.colCodigoTicket.Name = "colCodigoTicket"
        Me.colCodigoTicket.OptionsColumn.FixedWidth = True
        Me.colCodigoTicket.Visible = True
        Me.colCodigoTicket.VisibleIndex = 2
        Me.colCodigoTicket.Width = 100
        '
        'colFecha
        '
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.FixedWidth = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 3
        Me.colFecha.Width = 100
        '
        'colImporteTicket
        '
        Me.colImporteTicket.ColumnEdit = Me.maskImporte
        Me.colImporteTicket.FieldName = "ImporteTicket"
        Me.colImporteTicket.Name = "colImporteTicket"
        Me.colImporteTicket.OptionsColumn.FixedWidth = True
        Me.colImporteTicket.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colImporteTicket.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colImporteTicket.Visible = True
        Me.colImporteTicket.VisibleIndex = 4
        Me.colImporteTicket.Width = 100
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.EditMask = "c2"
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'colImporteCobrado
        '
        Me.colImporteCobrado.Caption = "Imp. Cobrado"
        Me.colImporteCobrado.ColumnEdit = Me.maskImporte
        Me.colImporteCobrado.FieldName = "ImporteCobrado"
        Me.colImporteCobrado.Name = "colImporteCobrado"
        Me.colImporteCobrado.OptionsColumn.FixedWidth = True
        Me.colImporteCobrado.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colImporteCobrado.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colImporteCobrado.Visible = True
        Me.colImporteCobrado.VisibleIndex = 5
        Me.colImporteCobrado.Width = 100
        '
        'colImportePendiente
        '
        Me.colImportePendiente.Caption = "Imp. Pendiente"
        Me.colImportePendiente.ColumnEdit = Me.maskImporte
        Me.colImportePendiente.FieldName = "ImportePendiente"
        Me.colImportePendiente.Name = "colImportePendiente"
        Me.colImportePendiente.OptionsColumn.FixedWidth = True
        Me.colImportePendiente.SummaryItem.DisplayFormat = "{0:c2}"
        Me.colImportePendiente.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colImportePendiente.Visible = True
        Me.colImportePendiente.VisibleIndex = 6
        Me.colImportePendiente.Width = 100
        '
        'ListadoSaldoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgBusqueda)
        Me.Controls.Add(Me.panelImprimir)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "ListadoSaldoClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado saldo de clientes"
        CType(Me.txtCodigoInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcOpciones.ResumeLayout(False)
        CType(Me.checkDetallado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PENDIENTESCOBROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImprimir.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtTituloListado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoInicio As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCodigoFin As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtNombreInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreFin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents checkDetallado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panelImprimir As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DsClientes As AydaraTPV.dsClientes
    Friend WithEvents PENDIENTESCOBROBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PENDIENTES_COBROTableAdapter As AydaraTPV.dsClientesTableAdapters.PENDIENTES_COBROTableAdapter
    Friend WithEvents dgBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBusqueda As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoTienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCaja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoTicket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporteTicket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporteCobrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImportePendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTituloListado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
End Class
