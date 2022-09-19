<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlbaranesCompras
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
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.gvDetalleLineasAlbaran = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetalleCodigoColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbColores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.COLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New AydaraTPV.dsArticulos()
        Me.colDetalleDescripcionTalla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetalleCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetalleCantidadAnterior = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetalleCodigoTalla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgLineasAlbaran = New DevExpress.XtraGrid.GridControl()
        Me.ALBARANESCOMPRASLINEASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAlbaranesCompras = New AydaraTPV.dsAlbaranesCompras()
        Me.gvLineasAlbaran = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlbaranCompra_Id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bttCodigoArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescuento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidadAnterior = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.linkCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.ALBARANESCOMPRASLINEASDETALLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCodigoProveedor = New DevExpress.XtraEditors.ButtonEdit()
        Me.ALBARANESCOMPRASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.bttEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumeroAlbaran = New DevExpress.XtraEditors.TextEdit()
        Me.txtFecha = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTotalAlbaran = New DevExpress.XtraEditors.TextEdit()
        Me.COLORESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter()
        Me.bttPedidosPendientes = New DevExpress.XtraEditors.SimpleButton()
        Me.ALBARANES_COMPRASTableAdapter = New AydaraTPV.dsAlbaranesComprasTableAdapters.ALBARANES_COMPRASTableAdapter()
        Me.ALBARANES_COMPRAS_LINEAS_DETALLETableAdapter = New AydaraTPV.dsAlbaranesComprasTableAdapters.ALBARANES_COMPRAS_LINEAS_DETALLETableAdapter()
        Me.ALBARANES_COMPRAS_LINEASTableAdapter = New AydaraTPV.dsAlbaranesComprasTableAdapters.ALBARANES_COMPRAS_LINEASTableAdapter()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.INFOARTICULOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnidadCaja = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinimoVenta = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinimoCompra = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.bttFichaArticulo = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExistenciasActual = New DevExpress.XtraEditors.TextEdit()
        Me.txtPrecioCoste = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrecioVenta = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrecioCosteProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.gvDetalleLineasAlbaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLineasAlbaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALBARANESCOMPRASLINEASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAlbaranesCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLineasAlbaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALBARANESCOMPRASLINEASDETALLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALBARANESCOMPRASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroAlbaran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalAlbaran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INFOARTICULOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnidadCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinimoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinimoCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtExistenciasActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioCoste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioCosteProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvDetalleLineasAlbaran
        '
        Me.gvDetalleLineasAlbaran.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetalleCodigoColor, Me.colDetalleDescripcionTalla, Me.colDetalleCantidad, Me.colDetalleCantidadAnterior, Me.colDetalleCodigoTalla})
        Me.gvDetalleLineasAlbaran.GridControl = Me.dgLineasAlbaran
        Me.gvDetalleLineasAlbaran.Name = "gvDetalleLineasAlbaran"
        Me.gvDetalleLineasAlbaran.OptionsBehavior.Editable = False
        Me.gvDetalleLineasAlbaran.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvDetalleLineasAlbaran.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvDetalleLineasAlbaran.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvDetalleLineasAlbaran.OptionsView.ShowGroupPanel = False
        Me.gvDetalleLineasAlbaran.ViewCaption = "Color-Talla"
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
        Me.colDetalleCantidad.FieldName = "Cantidad"
        Me.colDetalleCantidad.MaxWidth = 80
        Me.colDetalleCantidad.MinWidth = 80
        Me.colDetalleCantidad.Name = "colDetalleCantidad"
        Me.colDetalleCantidad.Visible = True
        Me.colDetalleCantidad.VisibleIndex = 2
        '
        'colDetalleCantidadAnterior
        '
        Me.colDetalleCantidadAnterior.Caption = "Cantidad anterior"
        Me.colDetalleCantidadAnterior.FieldName = "CantidadAnterior"
        Me.colDetalleCantidadAnterior.Name = "colDetalleCantidadAnterior"
        '
        'colDetalleCodigoTalla
        '
        Me.colDetalleCodigoTalla.Caption = "Codigo talla"
        Me.colDetalleCodigoTalla.FieldName = "CodigoTalla"
        Me.colDetalleCodigoTalla.Name = "colDetalleCodigoTalla"
        '
        'dgLineasAlbaran
        '
        Me.dgLineasAlbaran.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLineasAlbaran.DataSource = Me.ALBARANESCOMPRASLINEASBindingSource
        Me.dgLineasAlbaran.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgLineasAlbaran.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgLineasAlbaran.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgLineasAlbaran.EmbeddedNavigator.TextStringFormat = "Línea {0} de {1}"
        GridLevelNode1.LevelTemplate = Me.gvDetalleLineasAlbaran
        GridLevelNode1.RelationName = "Level1"
        Me.dgLineasAlbaran.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.dgLineasAlbaran.Location = New System.Drawing.Point(12, 94)
        Me.dgLineasAlbaran.MainView = Me.gvLineasAlbaran
        Me.dgLineasAlbaran.Name = "dgLineasAlbaran"
        Me.dgLineasAlbaran.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.bttCodigoArticulo, Me.maskDescuento, Me.maskPrecio, Me.maskImporte, Me.cmbColores, Me.maskCantidad, Me.linkCantidad})
        Me.dgLineasAlbaran.Size = New System.Drawing.Size(760, 254)
        Me.dgLineasAlbaran.TabIndex = 92
        Me.dgLineasAlbaran.UseEmbeddedNavigator = True
        Me.dgLineasAlbaran.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLineasAlbaran, Me.gvDetalleLineasAlbaran})
        '
        'ALBARANESCOMPRASLINEASBindingSource
        '
        Me.ALBARANESCOMPRASLINEASBindingSource.DataMember = "ALBARANES_COMPRAS_LINEAS"
        Me.ALBARANESCOMPRASLINEASBindingSource.DataSource = Me.DsAlbaranesCompras
        '
        'DsAlbaranesCompras
        '
        Me.DsAlbaranesCompras.DataSetName = "dsAlbaranesCompras"
        Me.DsAlbaranesCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvLineasAlbaran
        '
        Me.gvLineasAlbaran.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colAlbaranCompra_Id, Me.colCodigoArticulo, Me.colDescripcion, Me.colCantidad, Me.colPrecio, Me.colDescuento, Me.colTotal, Me.colObservaciones, Me.colCantidadAnterior})
        Me.gvLineasAlbaran.GridControl = Me.dgLineasAlbaran
        Me.gvLineasAlbaran.Name = "gvLineasAlbaran"
        Me.gvLineasAlbaran.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvLineasAlbaran.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvLineasAlbaran.OptionsCustomization.AllowColumnMoving = False
        Me.gvLineasAlbaran.OptionsCustomization.AllowFilter = False
        Me.gvLineasAlbaran.OptionsCustomization.AllowGroup = False
        Me.gvLineasAlbaran.OptionsCustomization.AllowSort = False
        Me.gvLineasAlbaran.OptionsDetail.ShowDetailTabs = False
        Me.gvLineasAlbaran.OptionsMenu.EnableColumnMenu = False
        Me.gvLineasAlbaran.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvLineasAlbaran.OptionsView.ShowDetailButtons = False
        Me.gvLineasAlbaran.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.ReadOnly = True
        '
        'colAlbaranCompra_Id
        '
        Me.colAlbaranCompra_Id.FieldName = "AlbaranCompra_Id"
        Me.colAlbaranCompra_Id.Name = "colAlbaranCompra_Id"
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
        Me.bttCodigoArticulo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
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
        'colCantidad
        '
        Me.colCantidad.ColumnEdit = Me.maskCantidad
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.MaxWidth = 60
        Me.colCantidad.MinWidth = 60
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.ReadOnly = True
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 2
        Me.colCantidad.Width = 60
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
        'colPrecio
        '
        Me.colPrecio.ColumnEdit = Me.maskPrecio
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.MaxWidth = 80
        Me.colPrecio.MinWidth = 80
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.OptionsColumn.ReadOnly = True
        Me.colPrecio.Visible = True
        Me.colPrecio.VisibleIndex = 3
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
        Me.colDescuento.VisibleIndex = 4
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
        Me.colTotal.VisibleIndex = 5
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
        Me.colObservaciones.VisibleIndex = 6
        Me.colObservaciones.Width = 156
        '
        'colCantidadAnterior
        '
        Me.colCantidadAnterior.Caption = "Cantidad anterior"
        Me.colCantidadAnterior.FieldName = "CantidadAnterior"
        Me.colCantidadAnterior.Name = "colCantidadAnterior"
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
        'ALBARANESCOMPRASLINEASDETALLEBindingSource
        '
        Me.ALBARANESCOMPRASLINEASDETALLEBindingSource.DataMember = "ALBARANES_COMPRAS_LINEAS_DETALLE"
        Me.ALBARANESCOMPRASLINEASDETALLEBindingSource.DataSource = Me.DsAlbaranesCompras
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ALBARANESCOMPRASBindingSource, "CodigoProveedor", True))
        Me.txtCodigoProveedor.EnterMoveNextControl = True
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(298, 13)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, False)})
        Me.txtCodigoProveedor.Properties.Mask.EditMask = "00000"
        Me.txtCodigoProveedor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCodigoProveedor.Properties.ReadOnly = True
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(62, 20)
        Me.txtCodigoProveedor.TabIndex = 3
        '
        'ALBARANESCOMPRASBindingSource
        '
        Me.ALBARANESCOMPRASBindingSource.DataMember = "ALBARANES_COMPRAS"
        Me.ALBARANESCOMPRASBindingSource.DataSource = Me.DsAlbaranesCompras
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
        Me.txtNombreProveedor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ALBARANESCOMPRASBindingSource, "NombreProveedor", True))
        Me.txtNombreProveedor.EnterMoveNextControl = True
        Me.txtNombreProveedor.Location = New System.Drawing.Point(359, 13)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Properties.MaxLength = 50
        Me.txtNombreProveedor.Properties.ReadOnly = True
        Me.txtNombreProveedor.Size = New System.Drawing.Size(280, 20)
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
        Me.LabelControl13.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl13.TabIndex = 48
        Me.LabelControl13.Text = "Número albarán:"
        '
        'txtNumeroAlbaran
        '
        Me.txtNumeroAlbaran.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ALBARANESCOMPRASBindingSource, "NumeroAlbaran", True))
        Me.txtNumeroAlbaran.EnterMoveNextControl = True
        Me.txtNumeroAlbaran.Location = New System.Drawing.Point(98, 13)
        Me.txtNumeroAlbaran.Name = "txtNumeroAlbaran"
        Me.txtNumeroAlbaran.Properties.MaxLength = 10
        Me.txtNumeroAlbaran.Properties.ReadOnly = True
        Me.txtNumeroAlbaran.Size = New System.Drawing.Size(113, 20)
        Me.txtNumeroAlbaran.TabIndex = 0
        '
        'txtFecha
        '
        Me.txtFecha.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ALBARANESCOMPRASBindingSource, "Fecha", True))
        Me.txtFecha.EditValue = Nothing
        Me.txtFecha.EnterMoveNextControl = True
        Me.txtFecha.Location = New System.Drawing.Point(98, 38)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFecha.Properties.Mask.EditMask = "g"
        Me.txtFecha.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFecha.Properties.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(113, 20)
        Me.txtFecha.TabIndex = 1
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(12, 41)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl9.TabIndex = 89
        Me.LabelControl9.Text = "Fecha albarán:"
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
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ALBARANESCOMPRASBindingSource, "Observaciones", True))
        Me.txtObservaciones.Location = New System.Drawing.Point(298, 39)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Properties.ReadOnly = True
        Me.txtObservaciones.Size = New System.Drawing.Size(474, 45)
        Me.txtObservaciones.TabIndex = 5
        Me.txtObservaciones.TabStop = False
        Me.txtObservaciones.UseOptimizedRendering = True
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(592, 357)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl2.TabIndex = 94
        Me.LabelControl2.Text = "Total albarán:"
        '
        'txtTotalAlbaran
        '
        Me.txtTotalAlbaran.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalAlbaran.EditValue = "0"
        Me.txtTotalAlbaran.EnterMoveNextControl = True
        Me.txtTotalAlbaran.Location = New System.Drawing.Point(661, 354)
        Me.txtTotalAlbaran.Name = "txtTotalAlbaran"
        Me.txtTotalAlbaran.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotalAlbaran.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotalAlbaran.Properties.Mask.EditMask = "c"
        Me.txtTotalAlbaran.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotalAlbaran.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotalAlbaran.Properties.MaxLength = 6
        Me.txtTotalAlbaran.Properties.ReadOnly = True
        Me.txtTotalAlbaran.Size = New System.Drawing.Size(111, 20)
        Me.txtTotalAlbaran.TabIndex = 93
        Me.txtTotalAlbaran.TabStop = False
        '
        'COLORESTableAdapter
        '
        Me.COLORESTableAdapter.ClearBeforeFill = True
        '
        'bttPedidosPendientes
        '
        Me.bttPedidosPendientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttPedidosPendientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttPedidosPendientes.Enabled = False
        Me.bttPedidosPendientes.Location = New System.Drawing.Point(645, 11)
        Me.bttPedidosPendientes.Name = "bttPedidosPendientes"
        Me.bttPedidosPendientes.Size = New System.Drawing.Size(127, 22)
        Me.bttPedidosPendientes.TabIndex = 97
        Me.bttPedidosPendientes.Text = "Pedidos pendientes"
        '
        'ALBARANES_COMPRASTableAdapter
        '
        Me.ALBARANES_COMPRASTableAdapter.ClearBeforeFill = True
        '
        'ALBARANES_COMPRAS_LINEAS_DETALLETableAdapter
        '
        Me.ALBARANES_COMPRAS_LINEAS_DETALLETableAdapter.ClearBeforeFill = True
        '
        'ALBARANES_COMPRAS_LINEASTableAdapter
        '
        Me.ALBARANES_COMPRAS_LINEASTableAdapter.ClearBeforeFill = True
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Enabled = False
        Me.bttImprimir.Image = Global.AydaraTPV.My.Resources.Resources.tickets
        Me.bttImprimir.Location = New System.Drawing.Point(460, 505)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(106, 45)
        Me.bttImprimir.TabIndex = 99
        Me.bttImprimir.TabStop = False
        Me.bttImprimir.Text = "Imprimir"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 35)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INFOARTICULOBindingSource, "Descripcion", True))
        Me.txtDescripcion.EnterMoveNextControl = True
        Me.txtDescripcion.Location = New System.Drawing.Point(86, 32)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.MaxLength = 40
        Me.txtDescripcion.Properties.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(332, 20)
        Me.txtDescripcion.TabIndex = 5
        '
        'INFOARTICULOBindingSource
        '
        Me.INFOARTICULOBindingSource.DataMember = "INFO_ARTICULO"
        Me.INFOARTICULOBindingSource.DataSource = Me.DsAlbaranesCompras
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(5, 61)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl10.TabIndex = 63
        Me.LabelControl10.Text = "Unidades caja:"
        '
        'txtUnidadCaja
        '
        Me.txtUnidadCaja.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INFOARTICULOBindingSource, "UnidadCaja", True))
        Me.txtUnidadCaja.EnterMoveNextControl = True
        Me.txtUnidadCaja.Location = New System.Drawing.Point(86, 58)
        Me.txtUnidadCaja.Name = "txtUnidadCaja"
        Me.txtUnidadCaja.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnidadCaja.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUnidadCaja.Properties.ReadOnly = True
        Me.txtUnidadCaja.Size = New System.Drawing.Size(65, 20)
        Me.txtUnidadCaja.TabIndex = 60
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(157, 61)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl11.TabIndex = 64
        Me.LabelControl11.Text = "Mínimo venta:"
        '
        'txtMinimoVenta
        '
        Me.txtMinimoVenta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INFOARTICULOBindingSource, "MinimoVenta", True))
        Me.txtMinimoVenta.EnterMoveNextControl = True
        Me.txtMinimoVenta.Location = New System.Drawing.Point(230, 58)
        Me.txtMinimoVenta.Name = "txtMinimoVenta"
        Me.txtMinimoVenta.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMinimoVenta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMinimoVenta.Properties.ReadOnly = True
        Me.txtMinimoVenta.Size = New System.Drawing.Size(47, 20)
        Me.txtMinimoVenta.TabIndex = 61
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(287, 61)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl12.TabIndex = 65
        Me.LabelControl12.Text = "Mínimo compra:"
        '
        'txtMinimoCompra
        '
        Me.txtMinimoCompra.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INFOARTICULOBindingSource, "MinimoCompra", True))
        Me.txtMinimoCompra.EnterMoveNextControl = True
        Me.txtMinimoCompra.Location = New System.Drawing.Point(367, 58)
        Me.txtMinimoCompra.Name = "txtMinimoCompra"
        Me.txtMinimoCompra.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMinimoCompra.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMinimoCompra.Properties.ReadOnly = True
        Me.txtMinimoCompra.Size = New System.Drawing.Size(51, 20)
        Me.txtMinimoCompra.TabIndex = 62
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.bttFichaArticulo)
        Me.GroupControl1.Controls.Add(Me.LabelControl18)
        Me.GroupControl1.Controls.Add(Me.txtExistenciasActual)
        Me.GroupControl1.Controls.Add(Me.txtPrecioCoste)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtPrecioVenta)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.txtMinimoCompra)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.txtMinimoVenta)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txtUnidadCaja)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.txtDescripcion)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 380)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(442, 118)
        Me.GroupControl1.TabIndex = 100
        Me.GroupControl1.Text = "Datos artículo"
        '
        'bttFichaArticulo
        '
        Me.bttFichaArticulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttFichaArticulo.Image = Global.AydaraTPV.My.Resources.Resources.menu_vales
        Me.bttFichaArticulo.Location = New System.Drawing.Point(341, 0)
        Me.bttFichaArticulo.Name = "bttFichaArticulo"
        Me.bttFichaArticulo.Size = New System.Drawing.Size(101, 26)
        Me.bttFichaArticulo.TabIndex = 102
        Me.bttFichaArticulo.Text = "Ficha artículo"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(304, 87)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl18.TabIndex = 73
        Me.LabelControl18.Text = "Existencia:"
        '
        'txtExistenciasActual
        '
        Me.txtExistenciasActual.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INFOARTICULOBindingSource, "Existencias", True))
        Me.txtExistenciasActual.EnterMoveNextControl = True
        Me.txtExistenciasActual.Location = New System.Drawing.Point(362, 84)
        Me.txtExistenciasActual.Name = "txtExistenciasActual"
        Me.txtExistenciasActual.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExistenciasActual.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExistenciasActual.Properties.Mask.EditMask = "n3"
        Me.txtExistenciasActual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExistenciasActual.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExistenciasActual.Properties.ReadOnly = True
        Me.txtExistenciasActual.Size = New System.Drawing.Size(56, 20)
        Me.txtExistenciasActual.TabIndex = 72
        '
        'txtPrecioCoste
        '
        Me.txtPrecioCoste.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INFOARTICULOBindingSource, "PrecioCoste", True))
        Me.txtPrecioCoste.EnterMoveNextControl = True
        Me.txtPrecioCoste.Location = New System.Drawing.Point(86, 84)
        Me.txtPrecioCoste.Name = "txtPrecioCoste"
        Me.txtPrecioCoste.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrecioCoste.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecioCoste.Properties.Mask.EditMask = "c3"
        Me.txtPrecioCoste.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioCoste.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioCoste.Properties.ReadOnly = True
        Me.txtPrecioCoste.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecioCoste.TabIndex = 68
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(5, 87)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl4.TabIndex = 71
        Me.LabelControl4.Text = "Precio coste:"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INFOARTICULOBindingSource, "Precio", True))
        Me.txtPrecioVenta.EnterMoveNextControl = True
        Me.txtPrecioVenta.Location = New System.Drawing.Point(230, 84)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrecioVenta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecioVenta.Properties.Mask.EditMask = "c2"
        Me.txtPrecioVenta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioVenta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioVenta.Properties.ReadOnly = True
        Me.txtPrecioVenta.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecioVenta.TabIndex = 69
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(160, 87)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl15.TabIndex = 70
        Me.LabelControl15.Text = "Precio venta:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.PanelControl1)
        Me.GroupControl2.Controls.Add(Me.txtPrecioCosteProveedor)
        Me.GroupControl2.Controls.Add(Me.LabelControl17)
        Me.GroupControl2.Controls.Add(Me.TextEdit1)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Location = New System.Drawing.Point(460, 380)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(295, 118)
        Me.GroupControl2.TabIndex = 101
        Me.GroupControl2.Text = "Datos proveedor / Última compra"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.TextEdit4)
        Me.PanelControl1.Controls.Add(Me.TextEdit5)
        Me.PanelControl1.Controls.Add(Me.LabelControl14)
        Me.PanelControl1.Controls.Add(Me.TextEdit3)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.TextEdit2)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(2, 58)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(291, 58)
        Me.PanelControl1.TabIndex = 80
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(7, 34)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl8.TabIndex = 85
        Me.LabelControl8.Text = "Cantidad:"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INFOARTICULOBindingSource, "Compra_Unidades", True))
        Me.TextEdit4.EnterMoveNextControl = True
        Me.TextEdit4.Location = New System.Drawing.Point(65, 31)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit4.Properties.Mask.EditMask = "n3"
        Me.TextEdit4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit4.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(85, 20)
        Me.TextEdit4.TabIndex = 84
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INFOARTICULOBindingSource, "Compra_Precio", True))
        Me.TextEdit5.EnterMoveNextControl = True
        Me.TextEdit5.Location = New System.Drawing.Point(195, 31)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit5.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TextEdit5.Properties.Mask.EditMask = "c3"
        Me.TextEdit5.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TextEdit5.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Size = New System.Drawing.Size(85, 20)
        Me.TextEdit5.TabIndex = 82
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(156, 34)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl14.TabIndex = 83
        Me.LabelControl14.Text = "Precio:"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INFOARTICULOBindingSource, "Compra_Fecha", True))
        Me.TextEdit3.EnterMoveNextControl = True
        Me.TextEdit3.Location = New System.Drawing.Point(195, 5)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.DisplayFormat.FormatString = "d"
        Me.TextEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TextEdit3.Properties.MaxLength = 40
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(85, 20)
        Me.TextEdit3.TabIndex = 81
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(156, 8)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl7.TabIndex = 80
        Me.LabelControl7.Text = "Fecha:"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INFOARTICULOBindingSource, "Compra_Albaran", True))
        Me.TextEdit2.EnterMoveNextControl = True
        Me.TextEdit2.Location = New System.Drawing.Point(65, 5)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.MaxLength = 40
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(85, 20)
        Me.TextEdit2.TabIndex = 79
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(3, 8)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl6.TabIndex = 78
        Me.LabelControl6.Text = "Nº albarán:"
        '
        'txtPrecioCosteProveedor
        '
        Me.txtPrecioCosteProveedor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INFOARTICULOBindingSource, "PrecioCosteProveedor", True))
        Me.txtPrecioCosteProveedor.EnterMoveNextControl = True
        Me.txtPrecioCosteProveedor.Location = New System.Drawing.Point(197, 32)
        Me.txtPrecioCosteProveedor.Name = "txtPrecioCosteProveedor"
        Me.txtPrecioCosteProveedor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrecioCosteProveedor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecioCosteProveedor.Properties.Mask.EditMask = "c3"
        Me.txtPrecioCosteProveedor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioCosteProveedor.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioCosteProveedor.Properties.ReadOnly = True
        Me.txtPrecioCosteProveedor.Size = New System.Drawing.Size(85, 20)
        Me.txtPrecioCosteProveedor.TabIndex = 79
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(158, 35)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl17.TabIndex = 78
        Me.LabelControl17.Text = "Coste:"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.INFOARTICULOBindingSource, "Referencia", True))
        Me.TextEdit1.EnterMoveNextControl = True
        Me.TextEdit1.Location = New System.Drawing.Point(67, 32)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.MaxLength = 40
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(85, 20)
        Me.TextEdit1.TabIndex = 7
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(5, 35)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "Referencia:"
        '
        'AlbaranesCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.bttImprimir)
        Me.Controls.Add(Me.bttPedidosPendientes)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtTotalAlbaran)
        Me.Controls.Add(Me.dgLineasAlbaran)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtNumeroAlbaran)
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
        Me.Name = "AlbaranesCompras"
        Me.Text = "Albaranes de compra"
        CType(Me.gvDetalleLineasAlbaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLineasAlbaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALBARANESCOMPRASLINEASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAlbaranesCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLineasAlbaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALBARANESCOMPRASLINEASDETALLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALBARANESCOMPRASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroAlbaran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalAlbaran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INFOARTICULOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnidadCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinimoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinimoCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtExistenciasActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioCoste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioCosteProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtNumeroAlbaran As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents dgLineasAlbaran As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLineasAlbaran As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlbaranCompra_Id As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents txtTotalAlbaran As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gvDetalleLineasAlbaran As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetalleCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetalleCodigoColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetalleDescripcionTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbColores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsArticulos As AydaraTPV.dsArticulos
    Friend WithEvents COLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COLORESTableAdapter As AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter
    Friend WithEvents maskCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents linkCantidad As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents bttPedidosPendientes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DsAlbaranesCompras As AydaraTPV.dsAlbaranesCompras
    Friend WithEvents ALBARANESCOMPRASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALBARANES_COMPRASTableAdapter As AydaraTPV.dsAlbaranesComprasTableAdapters.ALBARANES_COMPRASTableAdapter
    Friend WithEvents ALBARANESCOMPRASLINEASDETALLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALBARANES_COMPRAS_LINEAS_DETALLETableAdapter As AydaraTPV.dsAlbaranesComprasTableAdapters.ALBARANES_COMPRAS_LINEAS_DETALLETableAdapter
    Friend WithEvents ALBARANESCOMPRASLINEASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALBARANES_COMPRAS_LINEASTableAdapter As AydaraTPV.dsAlbaranesComprasTableAdapters.ALBARANES_COMPRAS_LINEASTableAdapter
    Friend WithEvents colCantidadAnterior As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetalleCantidadAnterior As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetalleCodigoTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnidadCaja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinimoVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinimoCompra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtPrecioCoste As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecioVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExistenciasActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents INFOARTICULOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtPrecioCosteProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttFichaArticulo As DevExpress.XtraEditors.SimpleButton
End Class
