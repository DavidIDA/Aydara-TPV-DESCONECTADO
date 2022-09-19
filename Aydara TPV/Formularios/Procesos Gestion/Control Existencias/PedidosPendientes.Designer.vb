<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosPendientes
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Me.gvLineasPedidos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colLineaPedido_Id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCantidadPendiente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.maskCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colCantidadAlbaran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colDescuento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.maskDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTraspasarLinea = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dgPedidos = New DevExpress.XtraGrid.GridControl
        Me.PEDIDOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPedidos = New AydaraTPV.dsPedidos
        Me.gvDetalleLineasPedidos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDescripcionTalla = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoColor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbColores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.COLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New AydaraTPV.dsArticulos
        Me.colCantidadPendienteDetalle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCantidadAlbaranDetalle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTraspasarLineaDetalle = New DevExpress.XtraGrid.Columns.GridColumn
        Me.gvPedidos = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoTienda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNumeroPedido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoProveedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombreProveedor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colObservaciones = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaEntrega = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTraspasarPedido = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PEDIDOSTableAdapter = New AydaraTPV.dsPedidosTableAdapters.PEDIDOSTableAdapter
        Me.bttAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.COLORESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter
        CType(Me.gvLineasPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEDIDOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalleLineasPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvLineasPedidos
        '
        Me.gvLineasPedidos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLineaPedido_Id, Me.colCodigoArticulo, Me.colDescripcion, Me.colCantidadPendiente, Me.colCantidadAlbaran, Me.colPrecio, Me.colDescuento, Me.colTotal, Me.colTraspasarLinea})
        Me.gvLineasPedidos.GridControl = Me.dgPedidos
        Me.gvLineasPedidos.Name = "gvLineasPedidos"
        Me.gvLineasPedidos.OptionsDetail.ShowDetailTabs = False
        Me.gvLineasPedidos.OptionsDetail.SmartDetailExpand = False
        Me.gvLineasPedidos.OptionsView.ShowGroupPanel = False
        '
        'colLineaPedido_Id
        '
        Me.colLineaPedido_Id.Caption = "Id"
        Me.colLineaPedido_Id.FieldName = "Id"
        Me.colLineaPedido_Id.Name = "colLineaPedido_Id"
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.Caption = "Artículo"
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.MaxWidth = 80
        Me.colCodigoArticulo.MinWidth = 80
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.AllowEdit = False
        Me.colCodigoArticulo.OptionsColumn.AllowFocus = False
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 0
        Me.colCodigoArticulo.Width = 80
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.AllowFocus = False
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 85
        '
        'colCantidadPendiente
        '
        Me.colCantidadPendiente.Caption = "Pendiente"
        Me.colCantidadPendiente.ColumnEdit = Me.maskCantidad
        Me.colCantidadPendiente.FieldName = "CantidadPendiente"
        Me.colCantidadPendiente.MaxWidth = 65
        Me.colCantidadPendiente.MinWidth = 65
        Me.colCantidadPendiente.Name = "colCantidadPendiente"
        Me.colCantidadPendiente.OptionsColumn.AllowEdit = False
        Me.colCantidadPendiente.OptionsColumn.AllowFocus = False
        Me.colCantidadPendiente.Visible = True
        Me.colCantidadPendiente.VisibleIndex = 2
        Me.colCantidadPendiente.Width = 65
        '
        'maskCantidad
        '
        Me.maskCantidad.AutoHeight = False
        Me.maskCantidad.Name = "maskCantidad"
        Me.maskCantidad.NullText = "0"
        '
        'colCantidadAlbaran
        '
        Me.colCantidadAlbaran.Caption = "Cantidad"
        Me.colCantidadAlbaran.ColumnEdit = Me.maskCantidad
        Me.colCantidadAlbaran.FieldName = "CantidadAlbaran"
        Me.colCantidadAlbaran.MaxWidth = 65
        Me.colCantidadAlbaran.MinWidth = 65
        Me.colCantidadAlbaran.Name = "colCantidadAlbaran"
        Me.colCantidadAlbaran.Visible = True
        Me.colCantidadAlbaran.VisibleIndex = 3
        Me.colCantidadAlbaran.Width = 65
        '
        'colPrecio
        '
        Me.colPrecio.Caption = "Precio"
        Me.colPrecio.ColumnEdit = Me.maskImporte
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.MaxWidth = 75
        Me.colPrecio.MinWidth = 75
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.OptionsColumn.AllowEdit = False
        Me.colPrecio.OptionsColumn.AllowFocus = False
        Me.colPrecio.Visible = True
        Me.colPrecio.VisibleIndex = 4
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Name = "maskImporte"
        Me.maskImporte.NullText = "0"
        '
        'colDescuento
        '
        Me.colDescuento.Caption = "Dto."
        Me.colDescuento.ColumnEdit = Me.maskDescuento
        Me.colDescuento.FieldName = "Descuento"
        Me.colDescuento.MaxWidth = 40
        Me.colDescuento.MinWidth = 40
        Me.colDescuento.Name = "colDescuento"
        Me.colDescuento.OptionsColumn.AllowEdit = False
        Me.colDescuento.OptionsColumn.AllowFocus = False
        Me.colDescuento.Visible = True
        Me.colDescuento.VisibleIndex = 5
        Me.colDescuento.Width = 40
        '
        'maskDescuento
        '
        Me.maskDescuento.AutoHeight = False
        Me.maskDescuento.Mask.EditMask = "P0"
        Me.maskDescuento.Name = "maskDescuento"
        '
        'colTotal
        '
        Me.colTotal.Caption = "Total"
        Me.colTotal.ColumnEdit = Me.maskImporte
        Me.colTotal.FieldName = "Total"
        Me.colTotal.MaxWidth = 75
        Me.colTotal.MinWidth = 75
        Me.colTotal.Name = "colTotal"
        Me.colTotal.OptionsColumn.AllowEdit = False
        Me.colTotal.OptionsColumn.AllowFocus = False
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 6
        '
        'colTraspasarLinea
        '
        Me.colTraspasarLinea.Caption = " "
        Me.colTraspasarLinea.FieldName = "Traspasar"
        Me.colTraspasarLinea.MaxWidth = 30
        Me.colTraspasarLinea.MinWidth = 30
        Me.colTraspasarLinea.Name = "colTraspasarLinea"
        Me.colTraspasarLinea.Visible = True
        Me.colTraspasarLinea.VisibleIndex = 7
        Me.colTraspasarLinea.Width = 30
        '
        'dgPedidos
        '
        Me.dgPedidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPedidos.DataSource = Me.PEDIDOSBindingSource
        GridLevelNode1.LevelTemplate = Me.gvLineasPedidos
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.LevelTemplate = Me.gvDetalleLineasPedidos
        GridLevelNode2.RelationName = "Level2"
        Me.dgPedidos.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.dgPedidos.Location = New System.Drawing.Point(12, 12)
        Me.dgPedidos.MainView = Me.gvPedidos
        Me.dgPedidos.Name = "dgPedidos"
        Me.dgPedidos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskCantidad, Me.maskImporte, Me.cmbColores, Me.maskDescuento})
        Me.dgPedidos.Size = New System.Drawing.Size(610, 388)
        Me.dgPedidos.TabIndex = 0
        Me.dgPedidos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalleLineasPedidos, Me.gvPedidos, Me.gvLineasPedidos})
        '
        'PEDIDOSBindingSource
        '
        Me.PEDIDOSBindingSource.DataMember = "PEDIDOS"
        Me.PEDIDOSBindingSource.DataSource = Me.DsPedidos
        '
        'DsPedidos
        '
        Me.DsPedidos.DataSetName = "dsPedidos"
        Me.DsPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvDetalleLineasPedidos
        '
        Me.gvDetalleLineasPedidos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescripcionTalla, Me.colCodigoColor, Me.colCantidadPendienteDetalle, Me.colCantidadAlbaranDetalle, Me.colTraspasarLineaDetalle})
        Me.gvDetalleLineasPedidos.GridControl = Me.dgPedidos
        Me.gvDetalleLineasPedidos.Name = "gvDetalleLineasPedidos"
        Me.gvDetalleLineasPedidos.OptionsView.ShowGroupPanel = False
        '
        'colDescripcionTalla
        '
        Me.colDescripcionTalla.Caption = "Talla"
        Me.colDescripcionTalla.FieldName = "DescripcionTalla"
        Me.colDescripcionTalla.MaxWidth = 65
        Me.colDescripcionTalla.MinWidth = 65
        Me.colDescripcionTalla.Name = "colDescripcionTalla"
        Me.colDescripcionTalla.OptionsColumn.AllowEdit = False
        Me.colDescripcionTalla.OptionsColumn.AllowFocus = False
        Me.colDescripcionTalla.Visible = True
        Me.colDescripcionTalla.VisibleIndex = 0
        Me.colDescripcionTalla.Width = 65
        '
        'colCodigoColor
        '
        Me.colCodigoColor.Caption = "Color"
        Me.colCodigoColor.ColumnEdit = Me.cmbColores
        Me.colCodigoColor.FieldName = "CodigoColor"
        Me.colCodigoColor.MaxWidth = 65
        Me.colCodigoColor.MinWidth = 65
        Me.colCodigoColor.Name = "colCodigoColor"
        Me.colCodigoColor.OptionsColumn.AllowEdit = False
        Me.colCodigoColor.OptionsColumn.AllowFocus = False
        Me.colCodigoColor.Visible = True
        Me.colCodigoColor.VisibleIndex = 1
        Me.colCodigoColor.Width = 65
        '
        'cmbColores
        '
        Me.cmbColores.AutoHeight = False
        Me.cmbColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbColores.DataSource = Me.COLORESBindingSource
        Me.cmbColores.DisplayMember = "Color"
        Me.cmbColores.Name = "cmbColores"
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
        'colCantidadPendienteDetalle
        '
        Me.colCantidadPendienteDetalle.Caption = "Pendiente"
        Me.colCantidadPendienteDetalle.ColumnEdit = Me.maskCantidad
        Me.colCantidadPendienteDetalle.FieldName = "CantidadPendiente"
        Me.colCantidadPendienteDetalle.MaxWidth = 65
        Me.colCantidadPendienteDetalle.MinWidth = 65
        Me.colCantidadPendienteDetalle.Name = "colCantidadPendienteDetalle"
        Me.colCantidadPendienteDetalle.OptionsColumn.AllowEdit = False
        Me.colCantidadPendienteDetalle.OptionsColumn.AllowFocus = False
        Me.colCantidadPendienteDetalle.Visible = True
        Me.colCantidadPendienteDetalle.VisibleIndex = 2
        Me.colCantidadPendienteDetalle.Width = 65
        '
        'colCantidadAlbaranDetalle
        '
        Me.colCantidadAlbaranDetalle.Caption = "Cantidad"
        Me.colCantidadAlbaranDetalle.ColumnEdit = Me.maskCantidad
        Me.colCantidadAlbaranDetalle.FieldName = "CantidadAlbaran"
        Me.colCantidadAlbaranDetalle.MaxWidth = 65
        Me.colCantidadAlbaranDetalle.MinWidth = 65
        Me.colCantidadAlbaranDetalle.Name = "colCantidadAlbaranDetalle"
        Me.colCantidadAlbaranDetalle.Visible = True
        Me.colCantidadAlbaranDetalle.VisibleIndex = 3
        Me.colCantidadAlbaranDetalle.Width = 65
        '
        'colTraspasarLineaDetalle
        '
        Me.colTraspasarLineaDetalle.Caption = " "
        Me.colTraspasarLineaDetalle.FieldName = "Traspasar"
        Me.colTraspasarLineaDetalle.MaxWidth = 30
        Me.colTraspasarLineaDetalle.MinWidth = 30
        Me.colTraspasarLineaDetalle.Name = "colTraspasarLineaDetalle"
        Me.colTraspasarLineaDetalle.Visible = True
        Me.colTraspasarLineaDetalle.VisibleIndex = 4
        Me.colTraspasarLineaDetalle.Width = 30
        '
        'gvPedidos
        '
        Me.gvPedidos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colCodigoTienda, Me.colNumeroPedido, Me.colFecha, Me.colCodigoProveedor, Me.colNombreProveedor, Me.colObservaciones, Me.colFechaEntrega, Me.colTraspasarPedido})
        Me.gvPedidos.GridControl = Me.dgPedidos
        Me.gvPedidos.Name = "gvPedidos"
        Me.gvPedidos.OptionsDetail.ShowDetailTabs = False
        Me.gvPedidos.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.ReadOnly = True
        '
        'colCodigoTienda
        '
        Me.colCodigoTienda.FieldName = "CodigoTienda"
        Me.colCodigoTienda.Name = "colCodigoTienda"
        '
        'colNumeroPedido
        '
        Me.colNumeroPedido.Caption = "Nº Pedido"
        Me.colNumeroPedido.FieldName = "NumeroPedido"
        Me.colNumeroPedido.MaxWidth = 60
        Me.colNumeroPedido.MinWidth = 60
        Me.colNumeroPedido.Name = "colNumeroPedido"
        Me.colNumeroPedido.OptionsColumn.AllowEdit = False
        Me.colNumeroPedido.OptionsColumn.AllowFocus = False
        Me.colNumeroPedido.Visible = True
        Me.colNumeroPedido.VisibleIndex = 0
        Me.colNumeroPedido.Width = 71
        '
        'colFecha
        '
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.MaxWidth = 65
        Me.colFecha.MinWidth = 65
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.OptionsColumn.AllowFocus = False
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 1
        Me.colFecha.Width = 65
        '
        'colCodigoProveedor
        '
        Me.colCodigoProveedor.Caption = "Proveedor"
        Me.colCodigoProveedor.FieldName = "CodigoProveedor"
        Me.colCodigoProveedor.MaxWidth = 70
        Me.colCodigoProveedor.MinWidth = 70
        Me.colCodigoProveedor.Name = "colCodigoProveedor"
        Me.colCodigoProveedor.OptionsColumn.AllowEdit = False
        Me.colCodigoProveedor.OptionsColumn.AllowFocus = False
        Me.colCodigoProveedor.Visible = True
        Me.colCodigoProveedor.VisibleIndex = 2
        Me.colCodigoProveedor.Width = 70
        '
        'colNombreProveedor
        '
        Me.colNombreProveedor.Caption = "Nombre"
        Me.colNombreProveedor.FieldName = "NombreProveedor"
        Me.colNombreProveedor.Name = "colNombreProveedor"
        Me.colNombreProveedor.OptionsColumn.AllowEdit = False
        Me.colNombreProveedor.OptionsColumn.AllowFocus = False
        Me.colNombreProveedor.Visible = True
        Me.colNombreProveedor.VisibleIndex = 3
        Me.colNombreProveedor.Width = 142
        '
        'colObservaciones
        '
        Me.colObservaciones.FieldName = "Observaciones"
        Me.colObservaciones.Name = "colObservaciones"
        Me.colObservaciones.OptionsColumn.AllowEdit = False
        Me.colObservaciones.OptionsColumn.AllowFocus = False
        Me.colObservaciones.Visible = True
        Me.colObservaciones.VisibleIndex = 4
        Me.colObservaciones.Width = 120
        '
        'colFechaEntrega
        '
        Me.colFechaEntrega.Caption = "Entrega"
        Me.colFechaEntrega.FieldName = "FechaEntrega"
        Me.colFechaEntrega.MaxWidth = 65
        Me.colFechaEntrega.MinWidth = 65
        Me.colFechaEntrega.Name = "colFechaEntrega"
        Me.colFechaEntrega.OptionsColumn.AllowEdit = False
        Me.colFechaEntrega.OptionsColumn.AllowFocus = False
        Me.colFechaEntrega.Visible = True
        Me.colFechaEntrega.VisibleIndex = 5
        Me.colFechaEntrega.Width = 65
        '
        'colTraspasarPedido
        '
        Me.colTraspasarPedido.Caption = " "
        Me.colTraspasarPedido.FieldName = "Traspasar"
        Me.colTraspasarPedido.MaxWidth = 30
        Me.colTraspasarPedido.MinWidth = 30
        Me.colTraspasarPedido.Name = "colTraspasarPedido"
        Me.colTraspasarPedido.Visible = True
        Me.colTraspasarPedido.VisibleIndex = 6
        Me.colTraspasarPedido.Width = 30
        '
        'PEDIDOSTableAdapter
        '
        Me.PEDIDOSTableAdapter.ClearBeforeFill = True
        '
        'bttAceptar
        '
        Me.bttAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttAceptar.Appearance.Options.UseFont = True
        Me.bttAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttAceptar.Image = Global.AydaraTPV.My.Resources.Resources.ok_32
        Me.bttAceptar.Location = New System.Drawing.Point(497, 406)
        Me.bttAceptar.Name = "bttAceptar"
        Me.bttAceptar.Size = New System.Drawing.Size(125, 34)
        Me.bttAceptar.TabIndex = 54
        Me.bttAceptar.Text = "Aceptar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCancelar.Appearance.Options.UseFont = True
        Me.bttCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources._1321518972_close
        Me.bttCancelar.Location = New System.Drawing.Point(12, 406)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(125, 34)
        Me.bttCancelar.TabIndex = 55
        Me.bttCancelar.Text = "Cancelar"
        '
        'COLORESTableAdapter
        '
        Me.COLORESTableAdapter.ClearBeforeFill = True
        '
        'PedidosPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 452)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttAceptar)
        Me.Controls.Add(Me.dgPedidos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "PedidosPendientes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pedidos pendientes"
        Me.TopMost = True
        CType(Me.gvLineasPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEDIDOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalleLineasPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgPedidos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLineasPedidos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gvPedidos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoTienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombreProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObservaciones As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaEntrega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsPedidos As AydaraTPV.dsPedidos
    Friend WithEvents PEDIDOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PEDIDOSTableAdapter As AydaraTPV.dsPedidosTableAdapters.PEDIDOSTableAdapter
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadPendiente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadAlbaran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bttAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvDetalleLineasPedidos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDescripcionTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadPendienteDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidadAlbaranDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTraspasarLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTraspasarLineaDetalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTraspasarPedido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents maskCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cmbColores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsArticulos As AydaraTPV.dsArticulos
    Friend WithEvents COLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COLORESTableAdapter As AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter
    Friend WithEvents maskDescuento As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colLineaPedido_Id As DevExpress.XtraGrid.Columns.GridColumn
End Class
