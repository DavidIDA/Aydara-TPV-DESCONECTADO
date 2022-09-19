<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TraspasoAlmacenes
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TRASPASOALMACENESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTraspasoAlmacenes = New AydaraTPV.dsTraspasoAlmacenes()
        Me.TRASPASO_ALMACENESTableAdapter = New AydaraTPV.dsTraspasoAlmacenesTableAdapters.TRASPASO_ALMACENESTableAdapter()
        Me.dgLineasTraspaso = New DevExpress.XtraGrid.GridControl()
        Me.gvLineasTraspaso = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAlmacenDestino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bttCodigoArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCajas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCantidadAnterior = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskDescuento = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cmbColores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.linkCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.gvDetalleLineasPedido = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDetalleCodigoColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetalleDescripcionTalla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDetalleCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblInfoArticulo = New DevExpress.XtraEditors.LabelControl()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.bttEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtNumeroalmacen = New DevExpress.XtraEditors.ButtonEdit()
        Me.NavTraspasoAlmacenes = New DevExpress.XtraEditors.DataNavigator()
        CType(Me.TRASPASOALMACENESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTraspasoAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLineasTraspaso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLineasTraspaso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalleLineasPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroalmacen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Almacén de destino:"
        '
        'TRASPASOALMACENESBindingSource
        '
        Me.TRASPASOALMACENESBindingSource.DataMember = "TRASPASO_ALMACENES"
        Me.TRASPASOALMACENESBindingSource.DataSource = Me.DsTraspasoAlmacenes
        '
        'DsTraspasoAlmacenes
        '
        Me.DsTraspasoAlmacenes.DataSetName = "dsTraspasoAlmacenes"
        Me.DsTraspasoAlmacenes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TRASPASO_ALMACENESTableAdapter
        '
        Me.TRASPASO_ALMACENESTableAdapter.ClearBeforeFill = True
        '
        'dgLineasTraspaso
        '
        Me.dgLineasTraspaso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgLineasTraspaso.DataSource = Me.TRASPASOALMACENESBindingSource
        Me.dgLineasTraspaso.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgLineasTraspaso.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgLineasTraspaso.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgLineasTraspaso.EmbeddedNavigator.TextStringFormat = "Línea {0} de {1}"
        Me.dgLineasTraspaso.Location = New System.Drawing.Point(12, 38)
        Me.dgLineasTraspaso.MainView = Me.gvLineasTraspaso
        Me.dgLineasTraspaso.Name = "dgLineasTraspaso"
        Me.dgLineasTraspaso.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.bttCodigoArticulo, Me.maskDescuento, Me.maskPrecio, Me.maskImporte, Me.cmbColores, Me.maskCantidad, Me.linkCantidad})
        Me.dgLineasTraspaso.Size = New System.Drawing.Size(760, 421)
        Me.dgLineasTraspaso.TabIndex = 93
        Me.dgLineasTraspaso.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLineasTraspaso, Me.gvDetalleLineasPedido})
        '
        'gvLineasTraspaso
        '
        Me.gvLineasTraspaso.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colAlmacenDestino, Me.colCodigoArticulo, Me.colDescripcion, Me.colCajas, Me.colCantidad, Me.colCantidadAnterior})
        Me.gvLineasTraspaso.GridControl = Me.dgLineasTraspaso
        Me.gvLineasTraspaso.Name = "gvLineasTraspaso"
        Me.gvLineasTraspaso.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvLineasTraspaso.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvLineasTraspaso.OptionsCustomization.AllowColumnMoving = False
        Me.gvLineasTraspaso.OptionsCustomization.AllowFilter = False
        Me.gvLineasTraspaso.OptionsCustomization.AllowGroup = False
        Me.gvLineasTraspaso.OptionsCustomization.AllowSort = False
        Me.gvLineasTraspaso.OptionsDetail.ShowDetailTabs = False
        Me.gvLineasTraspaso.OptionsMenu.EnableColumnMenu = False
        Me.gvLineasTraspaso.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvLineasTraspaso.OptionsView.ShowDetailButtons = False
        Me.gvLineasTraspaso.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.ReadOnly = True
        '
        'colAlmacenDestino
        '
        Me.colAlmacenDestino.FieldName = "AlmacenDestino"
        Me.colAlmacenDestino.Name = "colAlmacenDestino"
        Me.colAlmacenDestino.OptionsColumn.ReadOnly = True
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.Caption = "Artículo"
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
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 124
        '
        'colCajas
        '
        Me.colCajas.Caption = "Cajas"
        Me.colCajas.FieldName = "Cajas"
        Me.colCajas.MaxWidth = 60
        Me.colCajas.MinWidth = 60
        Me.colCajas.Name = "colCajas"
        Me.colCajas.OptionsColumn.ReadOnly = True
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
        'maskCantidad
        '
        Me.maskCantidad.AutoHeight = False
        Me.maskCantidad.Mask.EditMask = "n0"
        Me.maskCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.maskCantidad.Name = "maskCantidad"
        Me.maskCantidad.NullText = "0"
        '
        'colCantidadAnterior
        '
        Me.colCantidadAnterior.FieldName = "CantidadAnterior"
        Me.colCantidadAnterior.Name = "colCantidadAnterior"
        '
        'maskDescuento
        '
        Me.maskDescuento.AutoHeight = False
        Me.maskDescuento.Mask.EditMask = "P0"
        Me.maskDescuento.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskDescuento.Mask.UseMaskAsDisplayFormat = True
        Me.maskDescuento.Name = "maskDescuento"
        '
        'maskPrecio
        '
        Me.maskPrecio.AutoHeight = False
        Me.maskPrecio.Mask.EditMask = "c"
        Me.maskPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecio.Name = "maskPrecio"
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.EditMask = "c"
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'cmbColores
        '
        Me.cmbColores.AutoHeight = False
        Me.cmbColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbColores.DisplayMember = "Color"
        Me.cmbColores.Name = "cmbColores"
        Me.cmbColores.NullText = ""
        Me.cmbColores.ValueMember = "CodigoColor"
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
        'gvDetalleLineasPedido
        '
        Me.gvDetalleLineasPedido.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDetalleCodigoColor, Me.colDetalleDescripcionTalla, Me.colDetalleCantidad})
        Me.gvDetalleLineasPedido.GridControl = Me.dgLineasTraspaso
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
        'lblInfoArticulo
        '
        Me.lblInfoArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfoArticulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblInfoArticulo.Location = New System.Drawing.Point(12, 486)
        Me.lblInfoArticulo.Name = "lblInfoArticulo"
        Me.lblInfoArticulo.Size = New System.Drawing.Size(760, 13)
        Me.lblInfoArticulo.TabIndex = 103
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Enabled = False
        Me.bttImprimir.Image = Global.AydaraTPV.My.Resources.Resources.tickets
        Me.bttImprimir.Location = New System.Drawing.Point(460, 505)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(106, 45)
        Me.bttImprimir.TabIndex = 102
        Me.bttImprimir.TabStop = False
        Me.bttImprimir.Text = "Imprimir"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(554, 505)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 101
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
        Me.bttGuardar.TabIndex = 100
        Me.bttGuardar.TabStop = False
        Me.bttGuardar.Text = "Guardar"
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.search
        Me.bttBuscar.Location = New System.Drawing.Point(236, 505)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(106, 45)
        Me.bttBuscar.TabIndex = 107
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
        Me.bttModificar.TabIndex = 106
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
        Me.bttNuevo.TabIndex = 104
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
        Me.bttEliminar.TabIndex = 105
        Me.bttEliminar.TabStop = False
        Me.bttEliminar.Text = "Eliminar"
        '
        'txtNumeroalmacen
        '
        Me.txtNumeroalmacen.EnterMoveNextControl = True
        Me.txtNumeroalmacen.Location = New System.Drawing.Point(115, 12)
        Me.txtNumeroalmacen.Name = "txtNumeroalmacen"
        Me.txtNumeroalmacen.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtNumeroalmacen.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNumeroalmacen.Properties.MaxLength = 2
        Me.txtNumeroalmacen.Size = New System.Drawing.Size(46, 20)
        Me.txtNumeroalmacen.TabIndex = 108
        '
        'NavTraspasoAlmacenes
        '
        Me.NavTraspasoAlmacenes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NavTraspasoAlmacenes.Buttons.Append.Enabled = False
        Me.NavTraspasoAlmacenes.Buttons.CancelEdit.Visible = False
        Me.NavTraspasoAlmacenes.Buttons.EndEdit.Visible = False
        Me.NavTraspasoAlmacenes.Buttons.NextPage.Visible = False
        Me.NavTraspasoAlmacenes.Buttons.PrevPage.Visible = False
        Me.NavTraspasoAlmacenes.Buttons.Remove.Enabled = False
        Me.NavTraspasoAlmacenes.DataSource = Me.TRASPASOALMACENESBindingSource
        Me.NavTraspasoAlmacenes.Location = New System.Drawing.Point(12, 459)
        Me.NavTraspasoAlmacenes.Name = "NavTraspasoAlmacenes"
        Me.NavTraspasoAlmacenes.Size = New System.Drawing.Size(442, 21)
        Me.NavTraspasoAlmacenes.TabIndex = 109
        Me.NavTraspasoAlmacenes.TextStringFormat = "Línea {0} de {1}"
        '
        'TraspasoAlmacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.NavTraspasoAlmacenes)
        Me.Controls.Add(Me.txtNumeroalmacen)
        Me.Controls.Add(Me.bttBuscar)
        Me.Controls.Add(Me.bttModificar)
        Me.Controls.Add(Me.bttNuevo)
        Me.Controls.Add(Me.bttEliminar)
        Me.Controls.Add(Me.lblInfoArticulo)
        Me.Controls.Add(Me.bttImprimir)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttGuardar)
        Me.Controls.Add(Me.dgLineasTraspaso)
        Me.Controls.Add(Me.LabelControl1)
        Me.KeyPreview = True
        Me.Name = "TraspasoAlmacenes"
        Me.Text = "Traspaso entre almacenes"
        CType(Me.TRASPASOALMACENESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTraspasoAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLineasTraspaso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLineasTraspaso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalleLineasPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroalmacen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsTraspasoAlmacenes As AydaraTPV.dsTraspasoAlmacenes
    Friend WithEvents TRASPASOALMACENESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TRASPASO_ALMACENESTableAdapter As AydaraTPV.dsTraspasoAlmacenesTableAdapters.TRASPASO_ALMACENESTableAdapter
    Friend WithEvents dgLineasTraspaso As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLineasTraspaso As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAlmacenDestino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bttCodigoArticulo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCajas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents maskCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents maskPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents maskDescuento As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents cmbColores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents linkCantidad As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents gvDetalleLineasPedido As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDetalleCodigoColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetalleDescripcionTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDetalleCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblInfoArticulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNumeroalmacen As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents colCantidadAnterior As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NavTraspasoAlmacenes As DevExpress.XtraEditors.DataNavigator
End Class
