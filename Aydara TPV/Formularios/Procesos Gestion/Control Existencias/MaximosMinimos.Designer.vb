<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MaximosMinimos
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
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.panelImportarArticulos = New DevExpress.XtraEditors.GroupControl
        Me.bttImportarArticulos = New DevExpress.XtraEditors.SimpleButton
        Me.txtDescripcionSubfamilia = New DevExpress.XtraEditors.TextEdit
        Me.txtDescripcionFamilia = New DevExpress.XtraEditors.TextEdit
        Me.txtCodigoSubfamilia = New DevExpress.XtraEditors.ButtonEdit
        Me.txtCodigoFamilia = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.dgArticulos = New DevExpress.XtraGrid.GridControl
        Me.EXISTENCIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsInventario = New AydaraTPV.dsInventario
        Me.gvArticulos = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colExistencias_Id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.bttCodigoArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colDescripcion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gbColor = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colDescripcionColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCodigoColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbColores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.gbTalla = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colDescripcionTalla = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCodigoTalla = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbTallas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.TALLASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colUnidadesCaja = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colStockMinimo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colStockMaximo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colExistenciaInicial = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colExistenciaActual = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPrecioVenta = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.panelDetalle = New DevExpress.XtraEditors.GroupControl
        Me.bttActualizar = New DevExpress.XtraEditors.SimpleButton
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.EXISTENCIASTableAdapter = New AydaraTPV.dsInventarioTableAdapters.EXISTENCIASTableAdapter
        Me.COLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COLORESTableAdapter = New AydaraTPV.dsInventarioTableAdapters.COLORESTableAdapter
        CType(Me.panelImportarArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImportarArticulos.SuspendLayout()
        CType(Me.txtDescripcionSubfamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoSubfamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTallas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TALLASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDetalle.SuspendLayout()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelImportarArticulos
        '
        Me.panelImportarArticulos.Controls.Add(Me.bttImportarArticulos)
        Me.panelImportarArticulos.Controls.Add(Me.txtDescripcionSubfamilia)
        Me.panelImportarArticulos.Controls.Add(Me.txtDescripcionFamilia)
        Me.panelImportarArticulos.Controls.Add(Me.txtCodigoSubfamilia)
        Me.panelImportarArticulos.Controls.Add(Me.txtCodigoFamilia)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl3)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl4)
        Me.panelImportarArticulos.Location = New System.Drawing.Point(12, 12)
        Me.panelImportarArticulos.Name = "panelImportarArticulos"
        Me.panelImportarArticulos.Size = New System.Drawing.Size(760, 93)
        Me.panelImportarArticulos.TabIndex = 107
        Me.panelImportarArticulos.Text = "AÑADIR ARTÍCULOS"
        '
        'bttImportarArticulos
        '
        Me.bttImportarArticulos.Location = New System.Drawing.Point(685, 55)
        Me.bttImportarArticulos.Name = "bttImportarArticulos"
        Me.bttImportarArticulos.Size = New System.Drawing.Size(70, 23)
        Me.bttImportarArticulos.TabIndex = 8
        Me.bttImportarArticulos.Text = "Importar"
        '
        'txtDescripcionSubfamilia
        '
        Me.txtDescripcionSubfamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionSubfamilia.EnterMoveNextControl = True
        Me.txtDescripcionSubfamilia.Location = New System.Drawing.Point(121, 58)
        Me.txtDescripcionSubfamilia.Name = "txtDescripcionSubfamilia"
        Me.txtDescripcionSubfamilia.Properties.MaxLength = 50
        Me.txtDescripcionSubfamilia.Properties.ReadOnly = True
        Me.txtDescripcionSubfamilia.Size = New System.Drawing.Size(558, 20)
        Me.txtDescripcionSubfamilia.TabIndex = 14
        Me.txtDescripcionSubfamilia.TabStop = False
        '
        'txtDescripcionFamilia
        '
        Me.txtDescripcionFamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionFamilia.EnterMoveNextControl = True
        Me.txtDescripcionFamilia.Location = New System.Drawing.Point(121, 32)
        Me.txtDescripcionFamilia.Name = "txtDescripcionFamilia"
        Me.txtDescripcionFamilia.Properties.MaxLength = 50
        Me.txtDescripcionFamilia.Properties.ReadOnly = True
        Me.txtDescripcionFamilia.Size = New System.Drawing.Size(558, 20)
        Me.txtDescripcionFamilia.TabIndex = 12
        Me.txtDescripcionFamilia.TabStop = False
        '
        'txtCodigoSubfamilia
        '
        Me.txtCodigoSubfamilia.EnterMoveNextControl = True
        Me.txtCodigoSubfamilia.Location = New System.Drawing.Point(67, 58)
        Me.txtCodigoSubfamilia.Name = "txtCodigoSubfamilia"
        Me.txtCodigoSubfamilia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing)})
        Me.txtCodigoSubfamilia.Properties.ReadOnly = True
        Me.txtCodigoSubfamilia.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoSubfamilia.TabIndex = 2
        '
        'txtCodigoFamilia
        '
        Me.txtCodigoFamilia.EnterMoveNextControl = True
        Me.txtCodigoFamilia.Location = New System.Drawing.Point(67, 32)
        Me.txtCodigoFamilia.Name = "txtCodigoFamilia"
        Me.txtCodigoFamilia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoFamilia.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoFamilia.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 35)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "Familia:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(8, 61)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Subfamilia:"
        '
        'dgArticulos
        '
        Me.dgArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgArticulos.DataSource = Me.EXISTENCIASBindingSource
        Me.dgArticulos.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgArticulos.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgArticulos.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgArticulos.EmbeddedNavigator.TextStringFormat = "Línea {0} de {1}"
        Me.dgArticulos.Location = New System.Drawing.Point(5, 23)
        Me.dgArticulos.MainView = Me.gvArticulos
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskPrecio, Me.cmbColores, Me.cmbTallas, Me.bttCodigoArticulo})
        Me.dgArticulos.Size = New System.Drawing.Size(750, 360)
        Me.dgArticulos.TabIndex = 108
        Me.dgArticulos.UseEmbeddedNavigator = True
        Me.dgArticulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArticulos})
        '
        'EXISTENCIASBindingSource
        '
        Me.EXISTENCIASBindingSource.DataMember = "EXISTENCIAS"
        Me.EXISTENCIASBindingSource.DataSource = Me.DsInventario
        '
        'DsInventario
        '
        Me.DsInventario.DataSetName = "dsInventario"
        Me.DsInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvArticulos
        '
        Me.gvArticulos.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gbColor, Me.gbTalla, Me.gridBand3})
        Me.gvArticulos.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colExistencias_Id, Me.colCodigoArticulo, Me.colDescripcion, Me.colCodigoColor, Me.colCodigoTalla, Me.colDescripcionColor, Me.colDescripcionTalla, Me.colUnidadesCaja, Me.colStockMinimo, Me.colStockMaximo, Me.colExistenciaInicial, Me.colExistenciaActual, Me.colPrecioVenta})
        Me.gvArticulos.GridControl = Me.dgArticulos
        Me.gvArticulos.Name = "gvArticulos"
        Me.gvArticulos.OptionsCustomization.AllowBandMoving = False
        Me.gvArticulos.OptionsCustomization.AllowBandResizing = False
        Me.gvArticulos.OptionsCustomization.AllowColumnMoving = False
        Me.gvArticulos.OptionsCustomization.AllowFilter = False
        Me.gvArticulos.OptionsCustomization.AllowGroup = False
        Me.gvArticulos.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvArticulos.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvArticulos.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvArticulos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvArticulos.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Artículo"
        Me.GridBand1.Columns.Add(Me.colExistencias_Id)
        Me.GridBand1.Columns.Add(Me.colCodigoArticulo)
        Me.GridBand1.Columns.Add(Me.colDescripcion)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 365
        '
        'colExistencias_Id
        '
        Me.colExistencias_Id.FieldName = "Id"
        Me.colExistencias_Id.Name = "colExistencias_Id"
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.Caption = "Código"
        Me.colCodigoArticulo.ColumnEdit = Me.bttCodigoArticulo
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.MinWidth = 80
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.FixedWidth = True
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.Width = 80
        '
        'bttCodigoArticulo
        '
        Me.bttCodigoArticulo.AutoHeight = False
        Me.bttCodigoArticulo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.bttCodigoArticulo.MaxLength = 13
        Me.bttCodigoArticulo.Name = "bttCodigoArticulo"
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.AllowFocus = False
        Me.colDescripcion.Visible = True
        Me.colDescripcion.Width = 285
        '
        'gbColor
        '
        Me.gbColor.Caption = "Color"
        Me.gbColor.Columns.Add(Me.colDescripcionColor)
        Me.gbColor.Columns.Add(Me.colCodigoColor)
        Me.gbColor.Name = "gbColor"
        Me.gbColor.OptionsBand.FixedWidth = True
        Me.gbColor.Width = 75
        '
        'colDescripcionColor
        '
        Me.colDescripcionColor.Caption = "Color"
        Me.colDescripcionColor.FieldName = "DescripcionColor"
        Me.colDescripcionColor.MinWidth = 50
        Me.colDescripcionColor.Name = "colDescripcionColor"
        Me.colDescripcionColor.OptionsColumn.AllowEdit = False
        Me.colDescripcionColor.OptionsColumn.AllowFocus = False
        Me.colDescripcionColor.Visible = True
        Me.colDescripcionColor.Width = 50
        '
        'colCodigoColor
        '
        Me.colCodigoColor.Caption = "Color"
        Me.colCodigoColor.ColumnEdit = Me.cmbColores
        Me.colCodigoColor.FieldName = "CodigoColor"
        Me.colCodigoColor.Name = "colCodigoColor"
        Me.colCodigoColor.OptionsColumn.FixedWidth = True
        Me.colCodigoColor.Visible = True
        Me.colCodigoColor.Width = 25
        '
        'cmbColores
        '
        Me.cmbColores.AutoHeight = False
        Me.cmbColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbColores.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")})
        Me.cmbColores.DisplayMember = "Color"
        Me.cmbColores.Name = "cmbColores"
        Me.cmbColores.NullText = ""
        Me.cmbColores.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.cmbColores.ValueMember = "CodigoColor"
        '
        'gbTalla
        '
        Me.gbTalla.Caption = "Talla"
        Me.gbTalla.Columns.Add(Me.colDescripcionTalla)
        Me.gbTalla.Columns.Add(Me.colCodigoTalla)
        Me.gbTalla.Name = "gbTalla"
        Me.gbTalla.OptionsBand.FixedWidth = True
        Me.gbTalla.Width = 75
        '
        'colDescripcionTalla
        '
        Me.colDescripcionTalla.Caption = "Talla"
        Me.colDescripcionTalla.FieldName = "DescripcionTalla"
        Me.colDescripcionTalla.MinWidth = 50
        Me.colDescripcionTalla.Name = "colDescripcionTalla"
        Me.colDescripcionTalla.OptionsColumn.AllowEdit = False
        Me.colDescripcionTalla.OptionsColumn.AllowFocus = False
        Me.colDescripcionTalla.Visible = True
        Me.colDescripcionTalla.Width = 50
        '
        'colCodigoTalla
        '
        Me.colCodigoTalla.Caption = "Talla"
        Me.colCodigoTalla.ColumnEdit = Me.cmbTallas
        Me.colCodigoTalla.FieldName = "CodigoTalla"
        Me.colCodigoTalla.MinWidth = 25
        Me.colCodigoTalla.Name = "colCodigoTalla"
        Me.colCodigoTalla.OptionsColumn.FixedWidth = True
        Me.colCodigoTalla.Visible = True
        Me.colCodigoTalla.Width = 25
        '
        'cmbTallas
        '
        Me.cmbTallas.AutoHeight = False
        Me.cmbTallas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTallas.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Talla")})
        Me.cmbTallas.DataSource = Me.TALLASBindingSource
        Me.cmbTallas.DisplayMember = "Descripcion"
        Me.cmbTallas.Name = "cmbTallas"
        Me.cmbTallas.NullText = ""
        Me.cmbTallas.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.cmbTallas.ValueMember = "CodigoTalla"
        '
        'TALLASBindingSource
        '
        Me.TALLASBindingSource.DataMember = "TALLAS"
        Me.TALLASBindingSource.DataSource = Me.DsInventario
        '
        'gridBand3
        '
        Me.gridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand3.Caption = "Existencias"
        Me.gridBand3.Columns.Add(Me.colUnidadesCaja)
        Me.gridBand3.Columns.Add(Me.colStockMinimo)
        Me.gridBand3.Columns.Add(Me.colStockMaximo)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.OptionsBand.FixedWidth = True
        Me.gridBand3.Width = 225
        '
        'colUnidadesCaja
        '
        Me.colUnidadesCaja.Caption = "Unid. Caja"
        Me.colUnidadesCaja.FieldName = "UnidadCaja"
        Me.colUnidadesCaja.Name = "colUnidadesCaja"
        Me.colUnidadesCaja.OptionsColumn.AllowEdit = False
        Me.colUnidadesCaja.OptionsColumn.AllowFocus = False
        Me.colUnidadesCaja.Visible = True
        '
        'colStockMinimo
        '
        Me.colStockMinimo.Caption = "Mínimo"
        Me.colStockMinimo.FieldName = "StockMinimo"
        Me.colStockMinimo.Name = "colStockMinimo"
        Me.colStockMinimo.Visible = True
        '
        'colStockMaximo
        '
        Me.colStockMaximo.Caption = "Máximo"
        Me.colStockMaximo.FieldName = "StockMaximo"
        Me.colStockMaximo.Name = "colStockMaximo"
        Me.colStockMaximo.Visible = True
        '
        'colExistenciaInicial
        '
        Me.colExistenciaInicial.Caption = "ExistenciaInicial"
        Me.colExistenciaInicial.FieldName = "ExistenciaInicial"
        Me.colExistenciaInicial.Name = "colExistenciaInicial"
        '
        'colExistenciaActual
        '
        Me.colExistenciaActual.Caption = "ExistenciaActual"
        Me.colExistenciaActual.FieldName = "ExistenciaActual"
        Me.colExistenciaActual.Name = "colExistenciaActual"
        '
        'colPrecioVenta
        '
        Me.colPrecioVenta.Caption = "PrecioVenta"
        Me.colPrecioVenta.FieldName = "PrecioVenta"
        Me.colPrecioVenta.Name = "colPrecioVenta"
        '
        'maskPrecio
        '
        Me.maskPrecio.AutoHeight = False
        Me.maskPrecio.Mask.EditMask = "c2"
        Me.maskPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecio.Name = "maskPrecio"
        '
        'panelDetalle
        '
        Me.panelDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelDetalle.Controls.Add(Me.dgArticulos)
        Me.panelDetalle.Location = New System.Drawing.Point(12, 111)
        Me.panelDetalle.Name = "panelDetalle"
        Me.panelDetalle.Size = New System.Drawing.Size(760, 388)
        Me.panelDetalle.TabIndex = 109
        Me.panelDetalle.Text = "ARTÍCULOS"
        '
        'bttActualizar
        '
        Me.bttActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttActualizar.Image = Global.AydaraTPV.My.Resources.Resources.menu_articles
        Me.bttActualizar.Location = New System.Drawing.Point(666, 505)
        Me.bttActualizar.Name = "bttActualizar"
        Me.bttActualizar.Size = New System.Drawing.Size(106, 45)
        Me.bttActualizar.TabIndex = 110
        Me.bttActualizar.Text = "Actualizar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(12, 505)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 113
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'EXISTENCIASTableAdapter
        '
        Me.EXISTENCIASTableAdapter.ClearBeforeFill = True
        '
        'COLORESBindingSource
        '
        Me.COLORESBindingSource.DataMember = "COLORES"
        Me.COLORESBindingSource.DataSource = Me.DsInventario
        '
        'COLORESTableAdapter
        '
        Me.COLORESTableAdapter.ClearBeforeFill = True
        '
        'MaximosMinimos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttActualizar)
        Me.Controls.Add(Me.panelDetalle)
        Me.Controls.Add(Me.panelImportarArticulos)
        Me.KeyPreview = True
        Me.Name = "MaximosMinimos"
        Me.Text = "Inventario"
        CType(Me.panelImportarArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImportarArticulos.ResumeLayout(False)
        Me.panelImportarArticulos.PerformLayout()
        CType(Me.txtDescripcionSubfamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoSubfamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTallas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TALLASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDetalle.ResumeLayout(False)
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelImportarArticulos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bttImportarArticulos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescripcionSubfamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcionFamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoSubfamilia As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCodigoFamilia As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dgArticulos As DevExpress.XtraGrid.GridControl
    Friend WithEvents panelDetalle As DevExpress.XtraEditors.GroupControl
    Friend WithEvents maskPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bttActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbColores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbTallas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TALLASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bttCodigoArticulo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents gvArticulos As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoTalla As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gbColor As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gbTalla As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colDescripcionColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcionTalla As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DsInventario As AydaraTPV.dsInventario
    Friend WithEvents EXISTENCIASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EXISTENCIASTableAdapter As AydaraTPV.dsInventarioTableAdapters.EXISTENCIASTableAdapter
    Friend WithEvents colExistencias_Id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStockMinimo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStockMaximo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents COLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COLORESTableAdapter As AydaraTPV.dsInventarioTableAdapters.COLORESTableAdapter
    Friend WithEvents colExistenciaInicial As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExistenciaActual As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecioVenta As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUnidadesCaja As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
