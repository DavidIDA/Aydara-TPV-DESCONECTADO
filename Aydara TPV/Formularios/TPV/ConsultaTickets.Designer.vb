<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaTickets
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.gvLineas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colVendedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescuentoLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.dgTickets = New DevExpress.XtraGrid.GridControl()
        Me.TICKETSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsConsultaTickets = New AydaraTPV.dsConsultaTickets()
        Me.gvTickets = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoraTicket = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombreFiscal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroLineas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporteTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoCobro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NavListadoTickets = New DevExpress.XtraEditors.DataNavigator()
        Me.bttReimprimirTicket = New DevExpress.XtraEditors.SimpleButton()
        Me.TICKETSLINEASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.CheckVerAnulados = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCodigoCliente = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtDescripcionArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoArticulo = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreCliente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.bttModificarCobro = New DevExpress.XtraEditors.SimpleButton()
        Me.bttImprimirFactura = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsConsultaTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETSLINEASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.CheckVerAnulados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvLineas
        '
        Me.gvLineas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVendedor, Me.colCodigoArticulo, Me.colDescripcion, Me.colCantidad, Me.colPrecio, Me.colDescuentoLinea, Me.colImporte})
        Me.gvLineas.GridControl = Me.dgTickets
        Me.gvLineas.Name = "gvLineas"
        Me.gvLineas.OptionsBehavior.Editable = False
        Me.gvLineas.OptionsCustomization.AllowColumnMoving = False
        Me.gvLineas.OptionsCustomization.AllowColumnResizing = False
        Me.gvLineas.OptionsCustomization.AllowFilter = False
        Me.gvLineas.OptionsCustomization.AllowGroup = False
        Me.gvLineas.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvLineas.OptionsCustomization.AllowSort = False
        Me.gvLineas.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvLineas.OptionsView.ShowGroupPanel = False
        '
        'colVendedor
        '
        Me.colVendedor.Caption = "Vendedor"
        Me.colVendedor.FieldName = "CodigoEmleado"
        Me.colVendedor.MaxWidth = 60
        Me.colVendedor.MinWidth = 60
        Me.colVendedor.Name = "colVendedor"
        Me.colVendedor.Visible = True
        Me.colVendedor.VisibleIndex = 0
        Me.colVendedor.Width = 60
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.Caption = "Artículo"
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.MaxWidth = 150
        Me.colCodigoArticulo.MinWidth = 150
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 1
        Me.colCodigoArticulo.Width = 150
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "DescripcionArticulo"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowFocus = False
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 2
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.ColumnEdit = Me.maskCantidad
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.MaxWidth = 70
        Me.colCantidad.MinWidth = 70
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowFocus = False
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 3
        Me.colCantidad.Width = 70
        '
        'maskCantidad
        '
        Me.maskCantidad.AutoHeight = False
        Me.maskCantidad.Mask.EditMask = "n2"
        Me.maskCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.maskCantidad.Name = "maskCantidad"
        '
        'colPrecio
        '
        Me.colPrecio.Caption = "Precio"
        Me.colPrecio.ColumnEdit = Me.maskPrecio
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.MaxWidth = 80
        Me.colPrecio.MinWidth = 80
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.OptionsColumn.AllowFocus = False
        Me.colPrecio.Visible = True
        Me.colPrecio.VisibleIndex = 4
        Me.colPrecio.Width = 80
        '
        'maskPrecio
        '
        Me.maskPrecio.AutoHeight = False
        Me.maskPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecio.Name = "maskPrecio"
        '
        'colDescuentoLinea
        '
        Me.colDescuentoLinea.Caption = "Dto."
        Me.colDescuentoLinea.DisplayFormat.FormatString = "{0:n2}%"
        Me.colDescuentoLinea.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDescuentoLinea.FieldName = "DescuentoLinea"
        Me.colDescuentoLinea.MaxWidth = 60
        Me.colDescuentoLinea.MinWidth = 60
        Me.colDescuentoLinea.Name = "colDescuentoLinea"
        Me.colDescuentoLinea.Visible = True
        Me.colDescuentoLinea.VisibleIndex = 5
        Me.colDescuentoLinea.Width = 60
        '
        'colImporte
        '
        Me.colImporte.Caption = "Importe"
        Me.colImporte.ColumnEdit = Me.maskImporte
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.MaxWidth = 80
        Me.colImporte.MinWidth = 80
        Me.colImporte.Name = "colImporte"
        Me.colImporte.OptionsColumn.AllowFocus = False
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 6
        Me.colImporte.Width = 80
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'dgTickets
        '
        Me.dgTickets.DataSource = Me.TICKETSBindingSource
        Me.dgTickets.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvLineas
        GridLevelNode1.RelationName = "TICKETS_TICKETS_LINEAS"
        Me.dgTickets.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.dgTickets.Location = New System.Drawing.Point(0, 99)
        Me.dgTickets.MainView = Me.gvTickets
        Me.dgTickets.Name = "dgTickets"
        Me.dgTickets.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskImporte, Me.maskPrecio, Me.maskCantidad})
        Me.dgTickets.Size = New System.Drawing.Size(784, 422)
        Me.dgTickets.TabIndex = 7
        Me.dgTickets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTickets, Me.gvLineas})
        '
        'TICKETSBindingSource
        '
        Me.TICKETSBindingSource.DataMember = "TICKETS"
        Me.TICKETSBindingSource.DataSource = Me.DsConsultaTickets
        '
        'DsConsultaTickets
        '
        Me.DsConsultaTickets.DataSetName = "dsConsultaTickets"
        Me.DsConsultaTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvTickets
        '
        Me.gvTickets.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvTickets.Appearance.Row.Options.UseFont = True
        Me.gvTickets.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colNumeroDocumento, Me.colHoraTicket, Me.colNombreFiscal, Me.colNumeroLineas, Me.colImporteTotal, Me.colTipoCobro})
        Me.gvTickets.GridControl = Me.dgTickets
        Me.gvTickets.Name = "gvTickets"
        Me.gvTickets.OptionsBehavior.Editable = False
        Me.gvTickets.OptionsCustomization.AllowColumnMoving = False
        Me.gvTickets.OptionsCustomization.AllowColumnResizing = False
        Me.gvTickets.OptionsCustomization.AllowFilter = False
        Me.gvTickets.OptionsCustomization.AllowGroup = False
        Me.gvTickets.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvTickets.OptionsDetail.ShowDetailTabs = False
        Me.gvTickets.OptionsMenu.EnableColumnMenu = False
        Me.gvTickets.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvTickets.OptionsView.EnableAppearanceEvenRow = True
        Me.gvTickets.OptionsView.ShowGroupPanel = False
        Me.gvTickets.RowHeight = 35
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.ReadOnly = True
        '
        'colNumeroDocumento
        '
        Me.colNumeroDocumento.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumeroDocumento.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNumeroDocumento.Caption = "Nº Documento"
        Me.colNumeroDocumento.FieldName = "NumeroDocumento"
        Me.colNumeroDocumento.MaxWidth = 80
        Me.colNumeroDocumento.MinWidth = 80
        Me.colNumeroDocumento.Name = "colNumeroDocumento"
        Me.colNumeroDocumento.Visible = True
        Me.colNumeroDocumento.VisibleIndex = 0
        Me.colNumeroDocumento.Width = 93
        '
        'colHoraTicket
        '
        Me.colHoraTicket.AppearanceCell.Options.UseTextOptions = True
        Me.colHoraTicket.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHoraTicket.AppearanceHeader.Options.UseTextOptions = True
        Me.colHoraTicket.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colHoraTicket.Caption = "Fecha"
        Me.colHoraTicket.DisplayFormat.FormatString = "g"
        Me.colHoraTicket.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colHoraTicket.FieldName = "FechaTicket"
        Me.colHoraTicket.MaxWidth = 140
        Me.colHoraTicket.MinWidth = 140
        Me.colHoraTicket.Name = "colHoraTicket"
        Me.colHoraTicket.OptionsColumn.AllowFocus = False
        Me.colHoraTicket.Visible = True
        Me.colHoraTicket.VisibleIndex = 1
        Me.colHoraTicket.Width = 140
        '
        'colNombreFiscal
        '
        Me.colNombreFiscal.Caption = "Cliente"
        Me.colNombreFiscal.FieldName = "NombreFiscal"
        Me.colNombreFiscal.Name = "colNombreFiscal"
        Me.colNombreFiscal.OptionsColumn.AllowFocus = False
        Me.colNombreFiscal.Visible = True
        Me.colNombreFiscal.VisibleIndex = 2
        Me.colNombreFiscal.Width = 332
        '
        'colNumeroLineas
        '
        Me.colNumeroLineas.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumeroLineas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colNumeroLineas.Caption = "Nº Líneas"
        Me.colNumeroLineas.FieldName = "NumeroLineas"
        Me.colNumeroLineas.MaxWidth = 80
        Me.colNumeroLineas.MinWidth = 80
        Me.colNumeroLineas.Name = "colNumeroLineas"
        Me.colNumeroLineas.OptionsColumn.AllowFocus = False
        Me.colNumeroLineas.Visible = True
        Me.colNumeroLineas.VisibleIndex = 3
        Me.colNumeroLineas.Width = 80
        '
        'colImporteTotal
        '
        Me.colImporteTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colImporteTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colImporteTotal.ColumnEdit = Me.maskImporte
        Me.colImporteTotal.FieldName = "ImporteTotal"
        Me.colImporteTotal.MaxWidth = 100
        Me.colImporteTotal.MinWidth = 100
        Me.colImporteTotal.Name = "colImporteTotal"
        Me.colImporteTotal.OptionsColumn.AllowFocus = False
        Me.colImporteTotal.Visible = True
        Me.colImporteTotal.VisibleIndex = 4
        Me.colImporteTotal.Width = 100
        '
        'colTipoCobro
        '
        Me.colTipoCobro.Caption = "Tipo Cobro"
        Me.colTipoCobro.FieldName = "TipoCobro"
        Me.colTipoCobro.Name = "colTipoCobro"
        '
        'NavListadoTickets
        '
        Me.NavListadoTickets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NavListadoTickets.Buttons.Append.Hint = "Añadir registro"
        Me.NavListadoTickets.Buttons.Append.Visible = False
        Me.NavListadoTickets.Buttons.CancelEdit.Hint = "Deshacer cambios"
        Me.NavListadoTickets.Buttons.CancelEdit.Visible = False
        Me.NavListadoTickets.Buttons.EndEdit.Hint = "Guardar cambios"
        Me.NavListadoTickets.Buttons.EndEdit.Visible = False
        Me.NavListadoTickets.Buttons.Remove.Hint = "Eliminar registro"
        Me.NavListadoTickets.Buttons.Remove.Visible = False
        Me.NavListadoTickets.Location = New System.Drawing.Point(0, 0)
        Me.NavListadoTickets.Name = "NavListadoTickets"
        Me.NavListadoTickets.Size = New System.Drawing.Size(410, 39)
        Me.NavListadoTickets.TabIndex = 8
        Me.NavListadoTickets.Text = "Tickets"
        Me.NavListadoTickets.TextStringFormat = "Ticket {0} de {1}"
        '
        'bttReimprimirTicket
        '
        Me.bttReimprimirTicket.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttReimprimirTicket.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttReimprimirTicket.Location = New System.Drawing.Point(659, 0)
        Me.bttReimprimirTicket.Name = "bttReimprimirTicket"
        Me.bttReimprimirTicket.Size = New System.Drawing.Size(125, 39)
        Me.bttReimprimirTicket.TabIndex = 9
        Me.bttReimprimirTicket.Text = "Reimprimir ticket"
        '
        'TICKETSLINEASBindingSource
        '
        Me.TICKETSLINEASBindingSource.DataMember = "TICKETS_LINEAS"
        Me.TICKETSLINEASBindingSource.DataSource = Me.DsConsultaTickets
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.CheckVerAnulados)
        Me.PanelControl1.Controls.Add(Me.txtCodigoCliente)
        Me.PanelControl1.Controls.Add(Me.txtDescripcionArticulo)
        Me.PanelControl1.Controls.Add(Me.txtCodigoArticulo)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtNombreCliente)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtFechaFin)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtFechaInicio)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.bttBuscar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(784, 99)
        Me.PanelControl1.TabIndex = 113
        '
        'CheckVerAnulados
        '
        Me.CheckVerAnulados.Location = New System.Drawing.Point(648, 12)
        Me.CheckVerAnulados.Name = "CheckVerAnulados"
        Me.CheckVerAnulados.Properties.Caption = ""
        Me.CheckVerAnulados.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckVerAnulados.Size = New System.Drawing.Size(124, 19)
        Me.CheckVerAnulados.TabIndex = 10
        Me.CheckVerAnulados.TabStop = False
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.EnterMoveNextControl = True
        Me.txtCodigoCliente.Location = New System.Drawing.Point(79, 38)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoCliente.TabIndex = 2
        '
        'txtDescripcionArticulo
        '
        Me.txtDescripcionArticulo.Location = New System.Drawing.Point(223, 64)
        Me.txtDescripcionArticulo.Name = "txtDescripcionArticulo"
        Me.txtDescripcionArticulo.Properties.ReadOnly = True
        Me.txtDescripcionArticulo.Size = New System.Drawing.Size(308, 20)
        Me.txtDescripcionArticulo.TabIndex = 5
        Me.txtDescripcionArticulo.TabStop = False
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.EnterMoveNextControl = True
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(79, 64)
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(145, 20)
        Me.txtCodigoArticulo.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 67)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Artículo:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(178, 38)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Properties.ReadOnly = True
        Me.txtNombreCliente.Size = New System.Drawing.Size(353, 20)
        Me.txtNombreCliente.TabIndex = 3
        Me.txtNombreCliente.TabStop = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Cliente:"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.EditValue = Nothing
        Me.txtFechaFin.EnterMoveNextControl = True
        Me.txtFechaFin.Location = New System.Drawing.Point(218, 12)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaFin.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(185, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "hasta"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.EditValue = Nothing
        Me.txtFechaInicio.EnterMoveNextControl = True
        Me.txtFechaInicio.Location = New System.Drawing.Point(79, 12)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaInicio.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaInicio.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Fecha desde"
        '
        'bttBuscar
        '
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.find
        Me.bttBuscar.Location = New System.Drawing.Point(537, 41)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(75, 43)
        Me.bttBuscar.TabIndex = 6
        Me.bttBuscar.Text = "Buscar"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.bttModificarCobro)
        Me.PanelControl2.Controls.Add(Me.bttImprimirFactura)
        Me.PanelControl2.Controls.Add(Me.bttReimprimirTicket)
        Me.PanelControl2.Controls.Add(Me.NavListadoTickets)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 521)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(784, 41)
        Me.PanelControl2.TabIndex = 114
        '
        'bttModificarCobro
        '
        Me.bttModificarCobro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttModificarCobro.Image = Global.AydaraTPV.My.Resources.Resources.menu_fondos
        Me.bttModificarCobro.Location = New System.Drawing.Point(410, 1)
        Me.bttModificarCobro.Name = "bttModificarCobro"
        Me.bttModificarCobro.Size = New System.Drawing.Size(125, 39)
        Me.bttModificarCobro.TabIndex = 11
        Me.bttModificarCobro.Text = "Modificar Cobro"
        '
        'bttImprimirFactura
        '
        Me.bttImprimirFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttImprimirFactura.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttImprimirFactura.Location = New System.Drawing.Point(535, 0)
        Me.bttImprimirFactura.Name = "bttImprimirFactura"
        Me.bttImprimirFactura.Size = New System.Drawing.Size(125, 39)
        Me.bttImprimirFactura.TabIndex = 10
        Me.bttImprimirFactura.Text = "Imprimir Factura"
        '
        'ConsultaTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgTickets)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "ConsultaTickets"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consulta tickets"
        CType(Me.gvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsConsultaTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETSLINEASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.CheckVerAnulados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NavListadoTickets As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents bttReimprimirTicket As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TICKETSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsConsultaTickets As AydaraTPV.dsConsultaTickets
    Friend WithEvents TICKETSLINEASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents gvLineas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgTickets As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTickets As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoraTicket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreFiscal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroLineas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporteTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNombreCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcionArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoArticulo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoCliente As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents colNumeroDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents maskPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bttImprimirFactura As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents maskCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bttModificarCobro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colTipoCobro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckVerAnulados As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colVendedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuentoLinea As DevExpress.XtraGrid.Columns.GridColumn
End Class
