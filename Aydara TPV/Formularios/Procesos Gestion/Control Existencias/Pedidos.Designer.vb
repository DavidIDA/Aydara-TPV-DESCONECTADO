<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.gvDetalleLineasPedido = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetalleCodigoColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbColores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.COLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New AydaraTPV.dsArticulos()
        Me.colDetalleDescripcionTalla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetalleCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.dgLineasPedido = New DevExpress.XtraGrid.GridControl()
        Me.PEDIDOSLINEASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPedidos = New AydaraTPV.dsPedidos()
        Me.gvLineasPedido = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPedido_Id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bttCodigoArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCajas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.linkCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.txtCodigoProveedor = New DevExpress.XtraEditors.ButtonEdit()
        Me.PEDIDOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.bttEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumeroPedido = New DevExpress.XtraEditors.TextEdit()
        Me.txtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.PEDIDOSTableAdapter = New AydaraTPV.dsPedidosTableAdapters.PEDIDOSTableAdapter()
        Me.PEDIDOS_LINEASTableAdapter = New AydaraTPV.dsPedidosTableAdapters.PEDIDOS_LINEASTableAdapter()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalPedido = New DevExpress.XtraEditors.TextEdit()
        Me.COLORESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter()
        Me.txtFechaEntrega = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.PEDIDOSLINEASDETALLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PEDIDOS_LINEAS_DETALLETableAdapter = New AydaraTPV.dsPedidosTableAdapters.PEDIDOS_LINEAS_DETALLETableAdapter()
        Me.bttGenerarPedido = New DevExpress.XtraEditors.SimpleButton()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.lblInfoArticulo = New DevExpress.XtraEditors.LabelControl()
        Me.gcGeneracionAutomatica = New DevExpress.XtraEditors.GroupControl()
        Me.checkRedondearCajas = New DevExpress.XtraEditors.CheckEdit()
        Me.checkPedirStockMaximo = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.gvDetalleLineasPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLineasPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEDIDOSLINEASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLineasPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEDIDOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalPedido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaEntrega.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaEntrega.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEDIDOSLINEASDETALLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcGeneracionAutomatica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcGeneracionAutomatica.SuspendLayout()
        CType(Me.checkRedondearCajas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkPedirStockMaximo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvDetalleLineasPedido
        '
        Me.gvDetalleLineasPedido.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetalleCodigoColor, Me.colDetalleDescripcionTalla, Me.colDetalleCantidad})
        Me.gvDetalleLineasPedido.GridControl = Me.dgLineasPedido
        Me.gvDetalleLineasPedido.Name = "gvDetalleLineasPedido"
        Me.gvDetalleLineasPedido.OptionsBehavior.Editable = False
        Me.gvDetalleLineasPedido.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvDetalleLineasPedido.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvDetalleLineasPedido.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvDetalleLineasPedido.OptionsView.ShowGroupPanel = False
        Me.gvDetalleLineasPedido.ViewCaption = "Color-Talla"
        '
        'colDetalleCodigoColor
        '
        Me.colDetalleCodigoColor.Caption = "Color"
        Me.colDetalleCodigoColor.ColumnEdit = Me.cmbColores
        Me.colDetalleCodigoColor.FieldName = "CodigoColor"
        Me.colDetalleCodigoColor.MaxWidth = 80
        Me.colDetalleCodigoColor.MinWidth = 80
        Me.colDetalleCodigoColor.Name = "colDetalleCodigoColor"
        Me.colDetalleCodigoColor.Visible = True
        Me.colDetalleCodigoColor.VisibleIndex = 0
        '
        'cmbColores
        '
        Me.cmbColores.AutoHeight = False
        Me.cmbColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbColores.DataSource = Me.COLORESBindingSource
        Me.cmbColores.DisplayMember = "Color"
        Me.cmbColores.Name = "cmbColores"
        Me.cmbColores.NullText = ""
        Me.cmbColores.ValueMember = "CodigoColor"
        '
        'COLORESBindingSource
        '
        Me.COLORESBindingSource.DataMember = "COLORES"
        Me.COLORESBindingSource.DataSource = Me.DsArticulos
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "dsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colDetalleDescripcionTalla
        '
        Me.colDetalleDescripcionTalla.Caption = "Talla"
        Me.colDetalleDescripcionTalla.FieldName = "DescripcionTalla"
        Me.colDetalleDescripcionTalla.MaxWidth = 80
        Me.colDetalleDescripcionTalla.MinWidth = 80
        Me.colDetalleDescripcionTalla.Name = "colDetalleDescripcionTalla"
        Me.colDetalleDescripcionTalla.Visible = True
        Me.colDetalleDescripcionTalla.VisibleIndex = 1
        '
        'colDetalleCantidad
        '
        Me.colDetalleCantidad.Caption = "Cantidad"
        Me.colDetalleCantidad.ColumnEdit = Me.maskCantidad
        Me.colDetalleCantidad.FieldName = "Cantidad"
        Me.colDetalleCantidad.MaxWidth = 80
        Me.colDetalleCantidad.MinWidth = 80
        Me.colDetalleCantidad.Name = "colDetalleCantidad"
        Me.colDetalleCantidad.Visible = True
        Me.colDetalleCantidad.VisibleIndex = 2
        '
        'maskCantidad
        '
        Me.maskCantidad.AutoHeight = False
        Me.maskCantidad.Mask.EditMask = "n3"
        Me.maskCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.maskCantidad.Name = "maskCantidad"
        Me.maskCantidad.NullText = "0"
        '
        'dgLineasPedido
        '
        Me.dgLineasPedido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLineasPedido.DataSource = Me.PEDIDOSLINEASBindingSource
        Me.dgLineasPedido.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgLineasPedido.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgLineasPedido.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgLineasPedido.EmbeddedNavigator.TextStringFormat = "Línea {0} de {1}"
        GridLevelNode1.LevelTemplate = Me.gvDetalleLineasPedido
        GridLevelNode1.RelationName = "Level1"
        Me.dgLineasPedido.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.dgLineasPedido.Location = New System.Drawing.Point(12, 114)
        Me.dgLineasPedido.MainView = Me.gvLineasPedido
        Me.dgLineasPedido.Name = "dgLineasPedido"
        Me.dgLineasPedido.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.bttCodigoArticulo, Me.maskDescuento, Me.maskPrecio, Me.maskImporte, Me.cmbColores, Me.maskCantidad, Me.linkCantidad})
        Me.dgLineasPedido.Size = New System.Drawing.Size(760, 359)
        Me.dgLineasPedido.TabIndex = 92
        Me.dgLineasPedido.UseEmbeddedNavigator = True
        Me.dgLineasPedido.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLineasPedido, Me.gvDetalleLineasPedido})
        '
        'PEDIDOSLINEASBindingSource
        '
        Me.PEDIDOSLINEASBindingSource.DataMember = "PEDIDOS_LINEAS"
        Me.PEDIDOSLINEASBindingSource.DataSource = Me.DsPedidos
        '
        'DsPedidos
        '
        Me.DsPedidos.DataSetName = "dsPedidos"
        Me.DsPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvLineasPedido
        '
        Me.gvLineasPedido.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colPedido_Id, Me.colCodigoArticulo, Me.colDescripcion, Me.colCajas, Me.colCantidad, Me.colPrecio, Me.colDescuento, Me.colTotal, Me.colObservaciones})
        Me.gvLineasPedido.GridControl = Me.dgLineasPedido
        Me.gvLineasPedido.Name = "gvLineasPedido"
        Me.gvLineasPedido.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvLineasPedido.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvLineasPedido.OptionsCustomization.AllowColumnMoving = False
        Me.gvLineasPedido.OptionsCustomization.AllowFilter = False
        Me.gvLineasPedido.OptionsCustomization.AllowGroup = False
        Me.gvLineasPedido.OptionsCustomization.AllowSort = False
        Me.gvLineasPedido.OptionsDetail.ShowDetailTabs = False
        Me.gvLineasPedido.OptionsMenu.EnableColumnMenu = False
        Me.gvLineasPedido.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvLineasPedido.OptionsView.ShowDetailButtons = False
        Me.gvLineasPedido.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.ReadOnly = True
        '
        'colPedido_Id
        '
        Me.colPedido_Id.FieldName = "Pedido_Id"
        Me.colPedido_Id.Name = "colPedido_Id"
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.ColumnEdit = Me.bttCodigoArticulo
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.MaxWidth = 100
        Me.colCodigoArticulo.MinWidth = 100
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 0
        Me.colCodigoArticulo.Width = 100
        '
        'bttCodigoArticulo
        '
        Me.bttCodigoArticulo.AutoHeight = False
        Me.bttCodigoArticulo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.bttCodigoArticulo.MaxLength = 15
        Me.bttCodigoArticulo.Name = "bttCodigoArticulo"
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 124
        '
        'colCajas
        '
        Me.colCajas.Caption = "Envases"
        Me.colCajas.FieldName = "Cajas"
        Me.colCajas.MaxWidth = 60
        Me.colCajas.MinWidth = 60
        Me.colCajas.Name = "colCajas"
        Me.colCajas.Visible = True
        Me.colCajas.VisibleIndex = 2
        Me.colCajas.Width = 60
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Unidades"
        Me.colCantidad.ColumnEdit = Me.maskCantidad
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.MaxWidth = 60
        Me.colCantidad.MinWidth = 60
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.ReadOnly = True
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 3
        Me.colCantidad.Width = 60
        '
        'colPrecio
        '
        Me.colPrecio.ColumnEdit = Me.maskPrecio
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.MaxWidth = 80
        Me.colPrecio.MinWidth = 80
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.OptionsColumn.ReadOnly = True
        Me.colPrecio.Visible = True
        Me.colPrecio.VisibleIndex = 4
        Me.colPrecio.Width = 80
        '
        'maskPrecio
        '
        Me.maskPrecio.AutoHeight = False
        Me.maskPrecio.Mask.EditMask = "c"
        Me.maskPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecio.Name = "maskPrecio"
        '
        'colDescuento
        '
        Me.colDescuento.Caption = "Dto."
        Me.colDescuento.ColumnEdit = Me.maskDescuento
        Me.colDescuento.FieldName = "Descuento"
        Me.colDescuento.MaxWidth = 60
        Me.colDescuento.MinWidth = 60
        Me.colDescuento.Name = "colDescuento"
        Me.colDescuento.OptionsColumn.ReadOnly = True
        Me.colDescuento.Visible = True
        Me.colDescuento.VisibleIndex = 5
        Me.colDescuento.Width = 60
        '
        'maskDescuento
        '
        Me.maskDescuento.AutoHeight = False
        Me.maskDescuento.Mask.EditMask = "P0"
        Me.maskDescuento.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskDescuento.Mask.UseMaskAsDisplayFormat = True
        Me.maskDescuento.Name = "maskDescuento"
        '
        'colTotal
        '
        Me.colTotal.ColumnEdit = Me.maskImporte
        Me.colTotal.FieldName = "Total"
        Me.colTotal.MaxWidth = 80
        Me.colTotal.MinWidth = 80
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.ReadOnly = True
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 6
        Me.colTotal.Width = 80
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.EditMask = "c"
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'colObservaciones
        '
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.OptionsColumn.ReadOnly = True
        Me.colObservaciones.Visible = True
        Me.colObservaciones.VisibleIndex = 7
        Me.colObservaciones.Width = 156
        '
        'linkCantidad
        '
        Me.linkCantidad.AutoHeight = False
        Me.linkCantidad.Mask.EditMask = "n0"
        Me.linkCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.linkCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.linkCantidad.Name = "linkCantidad"
        Me.linkCantidad.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PEDIDOSBindingSource, "CodigoProveedor", True))
        Me.txtCodigoProveedor.EnterMoveNextControl = True
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(298, 13)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.txtCodigoProveedor.Properties.Mask.EditMask = "00000"
        Me.txtCodigoProveedor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCodigoProveedor.Properties.ReadOnly = True
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(62, 20)
        Me.txtCodigoProveedor.TabIndex = 3
        '
        'PEDIDOSBindingSource
        '
        Me.PEDIDOSBindingSource.DataMember = "PEDIDOS"
        Me.PEDIDOSBindingSource.DataSource = Me.DsPedidos
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(238, 16)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 38
        Me.LabelControl1.Text = "Proveedor:"
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreProveedor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PEDIDOSBindingSource, "NombreProveedor", True))
        Me.txtNombreProveedor.EnterMoveNextControl = True
        Me.txtNombreProveedor.Location = New System.Drawing.Point(359, 13)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Properties.MaxLength = 50
        Me.txtNombreProveedor.Properties.ReadOnly = True
        Me.txtNombreProveedor.Size = New System.Drawing.Size(247, 20)
        Me.txtNombreProveedor.TabIndex = 4
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.search
        Me.bttBuscar.Location = New System.Drawing.Point(236, 505)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(106, 45)
        Me.bttBuscar.TabIndex = 46
        Me.bttBuscar.TabStop = False
        Me.bttBuscar.Text = "Buscar"
        '
        'bttModificar
        '
        Me.bttModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttModificar.Enabled = False
        Me.bttModificar.Image = Global.AydaraTPV.My.Resources.Resources.menu_vales
        Me.bttModificar.Location = New System.Drawing.Point(124, 505)
        Me.bttModificar.Name = "bttModificar"
        Me.bttModificar.Size = New System.Drawing.Size(106, 45)
        Me.bttModificar.TabIndex = 45
        Me.bttModificar.TabStop = False
        Me.bttModificar.Text = "Modificar"
        '
        'bttNuevo
        '
        Me.bttNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttNuevo.Image = Global.AydaraTPV.My.Resources.Resources._new
        Me.bttNuevo.Location = New System.Drawing.Point(12, 505)
        Me.bttNuevo.Name = "bttNuevo"
        Me.bttNuevo.Size = New System.Drawing.Size(106, 45)
        Me.bttNuevo.TabIndex = 41
        Me.bttNuevo.TabStop = False
        Me.bttNuevo.Text = "Nuevo"
        '
        'bttEliminar
        '
        Me.bttEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttEliminar.Enabled = False
        Me.bttEliminar.Image = Global.AydaraTPV.My.Resources.Resources.delete2
        Me.bttEliminar.Location = New System.Drawing.Point(348, 505)
        Me.bttEliminar.Name = "bttEliminar"
        Me.bttEliminar.Size = New System.Drawing.Size(106, 45)
        Me.bttEliminar.TabIndex = 44
        Me.bttEliminar.TabStop = False
        Me.bttEliminar.Text = "Eliminar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(554, 505)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 43
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Enabled = False
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.save
        Me.bttGuardar.Location = New System.Drawing.Point(666, 505)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(106, 45)
        Me.bttGuardar.TabIndex = 42
        Me.bttGuardar.TabStop = False
        Me.bttGuardar.Text = "Guardar"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(12, 16)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl13.TabIndex = 48
        Me.LabelControl13.Text = "Número pedido:"
        '
        'txtNumeroPedido
        '
        Me.txtNumeroPedido.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PEDIDOSBindingSource, "NumeroPedido", True))
        Me.txtNumeroPedido.EnterMoveNextControl = True
        Me.txtNumeroPedido.Location = New System.Drawing.Point(92, 13)
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.Properties.MaxLength = 6
        Me.txtNumeroPedido.Properties.ReadOnly = True
        Me.txtNumeroPedido.Size = New System.Drawing.Size(111, 20)
        Me.txtNumeroPedido.TabIndex = 0
        '
        'txtFecha
        '
        Me.txtFecha.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PEDIDOSBindingSource, "Fecha", True))
        Me.txtFecha.EditValue = Nothing
        Me.txtFecha.EnterMoveNextControl = True
        Me.txtFecha.Location = New System.Drawing.Point(92, 38)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFecha.Properties.Mask.EditMask = "g"
        Me.txtFecha.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFecha.Properties.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(111, 20)
        Me.txtFecha.TabIndex = 1
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(12, 41)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl9.TabIndex = 89
        Me.LabelControl9.Text = "Fecha pedido:"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(217, 41)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl16.TabIndex = 91
        Me.LabelControl16.Text = "Observaciones:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PEDIDOSBindingSource, "Observaciones", True))
        Me.txtObservaciones.Location = New System.Drawing.Point(298, 39)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Properties.ReadOnly = True
        Me.txtObservaciones.Size = New System.Drawing.Size(308, 64)
        Me.txtObservaciones.TabIndex = 5
        Me.txtObservaciones.TabStop = False
        Me.txtObservaciones.UseOptimizedRendering = True
        '
        'PEDIDOSTableAdapter
        '
        Me.PEDIDOSTableAdapter.ClearBeforeFill = True
        '
        'PEDIDOS_LINEASTableAdapter
        '
        Me.PEDIDOS_LINEASTableAdapter.ClearBeforeFill = True
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(592, 482)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 94
        Me.LabelControl2.Text = "Total pedido:"
        '
        'txtTotalPedido
        '
        Me.txtTotalPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPedido.EditValue = "0"
        Me.txtTotalPedido.EnterMoveNextControl = True
        Me.txtTotalPedido.Location = New System.Drawing.Point(661, 479)
        Me.txtTotalPedido.Name = "txtTotalPedido"
        Me.txtTotalPedido.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalPedido.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalPedido.Properties.Mask.EditMask = "c"
        Me.txtTotalPedido.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalPedido.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalPedido.Properties.MaxLength = 6
        Me.txtTotalPedido.Properties.ReadOnly = True
        Me.txtTotalPedido.Size = New System.Drawing.Size(111, 20)
        Me.txtTotalPedido.TabIndex = 93
        Me.txtTotalPedido.TabStop = False
        '
        'COLORESTableAdapter
        '
        Me.COLORESTableAdapter.ClearBeforeFill = True
        '
        'txtFechaEntrega
        '
        Me.txtFechaEntrega.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.PEDIDOSBindingSource, "FechaEntrega", True))
        Me.txtFechaEntrega.EditValue = Nothing
        Me.txtFechaEntrega.EnterMoveNextControl = True
        Me.txtFechaEntrega.Location = New System.Drawing.Point(92, 64)
        Me.txtFechaEntrega.Name = "txtFechaEntrega"
        Me.txtFechaEntrega.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaEntrega.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaEntrega.Properties.Mask.EditMask = "g"
        Me.txtFechaEntrega.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFechaEntrega.Properties.ReadOnly = True
        Me.txtFechaEntrega.Size = New System.Drawing.Size(111, 20)
        Me.txtFechaEntrega.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 67)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl3.TabIndex = 96
        Me.LabelControl3.Text = "Fecha entrega:"
        '
        'PEDIDOSLINEASDETALLEBindingSource
        '
        Me.PEDIDOSLINEASDETALLEBindingSource.DataMember = "PEDIDOS_LINEAS_DETALLE"
        Me.PEDIDOSLINEASDETALLEBindingSource.DataSource = Me.DsPedidos
        '
        'PEDIDOS_LINEAS_DETALLETableAdapter
        '
        Me.PEDIDOS_LINEAS_DETALLETableAdapter.ClearBeforeFill = True
        '
        'bttGenerarPedido
        '
        Me.bttGenerarPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGenerarPedido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttGenerarPedido.Enabled = False
        Me.bttGenerarPedido.Location = New System.Drawing.Point(17, 69)
        Me.bttGenerarPedido.Name = "bttGenerarPedido"
        Me.bttGenerarPedido.Size = New System.Drawing.Size(127, 22)
        Me.bttGenerarPedido.TabIndex = 97
        Me.bttGenerarPedido.Text = "Generar pedido"
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Enabled = False
        Me.bttImprimir.Image = Global.AydaraTPV.My.Resources.Resources.tickets
        Me.bttImprimir.Location = New System.Drawing.Point(460, 505)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(106, 45)
        Me.bttImprimir.TabIndex = 98
        Me.bttImprimir.TabStop = False
        Me.bttImprimir.Text = "Imprimir"
        '
        'lblInfoArticulo
        '
        Me.lblInfoArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfoArticulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblInfoArticulo.Location = New System.Drawing.Point(12, 482)
        Me.lblInfoArticulo.Name = "lblInfoArticulo"
        Me.lblInfoArticulo.Size = New System.Drawing.Size(574, 13)
        Me.lblInfoArticulo.TabIndex = 99
        '
        'gcGeneracionAutomatica
        '
        Me.gcGeneracionAutomatica.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gcGeneracionAutomatica.Controls.Add(Me.checkRedondearCajas)
        Me.gcGeneracionAutomatica.Controls.Add(Me.checkPedirStockMaximo)
        Me.gcGeneracionAutomatica.Controls.Add(Me.bttGenerarPedido)
        Me.gcGeneracionAutomatica.Location = New System.Drawing.Point(612, 12)
        Me.gcGeneracionAutomatica.Name = "gcGeneracionAutomatica"
        Me.gcGeneracionAutomatica.Size = New System.Drawing.Size(160, 96)
        Me.gcGeneracionAutomatica.TabIndex = 100
        Me.gcGeneracionAutomatica.Text = "Generación automática"
        '
        'checkRedondearCajas
        '
        Me.checkRedondearCajas.Location = New System.Drawing.Point(17, 44)
        Me.checkRedondearCajas.Name = "checkRedondearCajas"
        Me.checkRedondearCajas.Properties.Caption = "Redondear a Cajas"
        Me.checkRedondearCajas.Size = New System.Drawing.Size(127, 19)
        Me.checkRedondearCajas.TabIndex = 99
        '
        'checkPedirStockMaximo
        '
        Me.checkPedirStockMaximo.EditValue = True
        Me.checkPedirStockMaximo.Location = New System.Drawing.Point(17, 23)
        Me.checkPedirStockMaximo.Name = "checkPedirStockMaximo"
        Me.checkPedirStockMaximo.Properties.Caption = "Pedir Stock Máximo"
        Me.checkPedirStockMaximo.Size = New System.Drawing.Size(127, 19)
        Me.checkPedirStockMaximo.TabIndex = 98
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gcGeneracionAutomatica)
        Me.Controls.Add(Me.lblInfoArticulo)
        Me.Controls.Add(Me.bttImprimir)
        Me.Controls.Add(Me.txtFechaEntrega)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtTotalPedido)
        Me.Controls.Add(Me.dgLineasPedido)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtNumeroPedido)
        Me.Controls.Add(Me.bttBuscar)
        Me.Controls.Add(Me.bttModificar)
        Me.Controls.Add(Me.bttNuevo)
        Me.Controls.Add(Me.bttEliminar)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttGuardar)
        Me.Controls.Add(Me.txtNombreProveedor)
        Me.Controls.Add(Me.txtCodigoProveedor)
        Me.Controls.Add(Me.LabelControl1)
        Me.KeyPreview = True
        Me.Name = "Pedidos"
        Me.Text = "Pedidos"
        CType(Me.gvDetalleLineasPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLineasPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEDIDOSLINEASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLineasPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEDIDOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalPedido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaEntrega.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaEntrega.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEDIDOSLINEASDETALLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcGeneracionAutomatica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcGeneracionAutomatica.ResumeLayout(False)
        CType(Me.checkRedondearCajas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkPedirStockMaximo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodigoProveedor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumeroPedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents DsPedidos As AydaraTPV.dsPedidos
    Friend WithEvents PEDIDOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PEDIDOSTableAdapter As AydaraTPV.dsPedidosTableAdapters.PEDIDOSTableAdapter
    Friend WithEvents dgLineasPedido As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLineasPedido As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PEDIDOSLINEASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PEDIDOS_LINEASTableAdapter As AydaraTPV.dsPedidosTableAdapters.PEDIDOS_LINEASTableAdapter
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPedido_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bttCodigoArticulo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents maskDescuento As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents maskPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalPedido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gvDetalleLineasPedido As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetalleCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetalleCodigoColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetalleDescripcionTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbColores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsArticulos As AydaraTPV.dsArticulos
    Friend WithEvents COLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COLORESTableAdapter As AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter
    Friend WithEvents txtFechaEntrega As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PEDIDOSLINEASDETALLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PEDIDOS_LINEAS_DETALLETableAdapter As AydaraTPV.dsPedidosTableAdapters.PEDIDOS_LINEAS_DETALLETableAdapter
    Friend WithEvents maskCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents linkCantidad As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents bttGenerarPedido As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCajas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblInfoArticulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcGeneracionAutomatica As DevExpress.XtraEditors.GroupControl
    Friend WithEvents checkPedirStockMaximo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkRedondearCajas As DevExpress.XtraEditors.CheckEdit
End Class
