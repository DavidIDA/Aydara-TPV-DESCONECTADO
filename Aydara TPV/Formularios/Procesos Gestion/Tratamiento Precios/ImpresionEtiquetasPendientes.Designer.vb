<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImpresionEtiquetasPendientes
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.bttCodigoArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.cmbColores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.COLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEtiquetas = New AydaraTPV.dsEtiquetas()
        Me.cmbTallas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TALLASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.dgArticulos = New DevExpress.XtraGrid.GridControl()
        Me.ETIQUETASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvArticulos = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colFechaVigor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colStock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gbColor = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colDescripcionColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodigoColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gbTalla = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colDescripcionTalla = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodigoTalla = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colPrecioActual = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colEtiquetas = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colImprimir = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.panelDetalle = New DevExpress.XtraEditors.GroupControl()
        Me.checkFidelizacion = New DevExpress.XtraEditors.CheckEdit()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bttEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.ETIQUETASTableAdapter = New AydaraTPV.dsEtiquetasTableAdapters.ETIQUETASTableAdapter()
        Me.COLORESTableAdapter = New AydaraTPV.dsEtiquetasTableAdapters.COLORESTableAdapter()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCodigosBarras = New DevExpress.XtraEditors.SimpleButton()
        Me.panelImportarArticulos = New DevExpress.XtraEditors.GroupControl()
        Me.txtCodigoArticulo_Hasta = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoArticulo_Desde = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoProveedor = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.bttImportarArticulos = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescripcionSubfamilia = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcionFamilia = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoSubfamilia = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtCodigoFamilia = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.bttEtiquetaIndividual = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEtiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTallas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TALLASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ETIQUETASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDetalle.SuspendLayout()
        CType(Me.checkFidelizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelImportarArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImportarArticulos.SuspendLayout()
        CType(Me.txtCodigoArticulo_Hasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoArticulo_Desde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionSubfamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoSubfamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttCodigoArticulo
        '
        Me.bttCodigoArticulo.AutoHeight = False
        Me.bttCodigoArticulo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.bttCodigoArticulo.MaxLength = 13
        Me.bttCodigoArticulo.Name = "bttCodigoArticulo"
        '
        'cmbColores
        '
        Me.cmbColores.AutoHeight = False
        Me.cmbColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbColores.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")})
        Me.cmbColores.DataSource = Me.COLORESBindingSource
        Me.cmbColores.DisplayMember = "Color"
        Me.cmbColores.Name = "cmbColores"
        Me.cmbColores.NullText = ""
        Me.cmbColores.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.cmbColores.ValueMember = "CodigoColor"
        '
        'COLORESBindingSource
        '
        Me.COLORESBindingSource.DataMember = "COLORES"
        Me.COLORESBindingSource.DataSource = Me.DsEtiquetas
        '
        'DsEtiquetas
        '
        Me.DsEtiquetas.DataSetName = "dsEtiquetas"
        Me.DsEtiquetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbTallas
        '
        Me.cmbTallas.AutoHeight = False
        Me.cmbTallas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTallas.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Talla")})
        Me.cmbTallas.DataSource = Me.TALLASBindingSource
        Me.cmbTallas.DisplayMember = "Descripcion"
        Me.cmbTallas.Name = "cmbTallas"
        Me.cmbTallas.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.cmbTallas.ValueMember = "CodigoTalla"
        '
        'TALLASBindingSource
        '
        Me.TALLASBindingSource.DataMember = "TALLAS"
        Me.TALLASBindingSource.DataSource = Me.DsEtiquetas
        '
        'maskPrecio
        '
        Me.maskPrecio.AutoHeight = False
        Me.maskPrecio.Mask.EditMask = "c2"
        Me.maskPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecio.Name = "maskPrecio"
        '
        'dgArticulos
        '
        Me.dgArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgArticulos.DataSource = Me.ETIQUETASBindingSource
        Me.dgArticulos.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgArticulos.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgArticulos.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgArticulos.EmbeddedNavigator.TextStringFormat = "Línea {0} de {1}"
        Me.dgArticulos.Location = New System.Drawing.Point(5, 23)
        Me.dgArticulos.MainView = Me.gvArticulos
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.dgArticulos.Size = New System.Drawing.Size(750, 346)
        Me.dgArticulos.TabIndex = 0
        Me.dgArticulos.UseEmbeddedNavigator = True
        Me.dgArticulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArticulos})
        '
        'ETIQUETASBindingSource
        '
        Me.ETIQUETASBindingSource.DataMember = "ETIQUETAS"
        Me.ETIQUETASBindingSource.DataSource = Me.DsEtiquetas
        '
        'gvArticulos
        '
        Me.gvArticulos.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gbColor, Me.gbTalla, Me.gridBand3, Me.gridBand5})
        Me.gvArticulos.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colFechaVigor, Me.colCodigoArticulo, Me.colDescripcion, Me.colCodigoColor, Me.colCodigoTalla, Me.colPrecioActual, Me.colEtiquetas, Me.colImprimir, Me.colDescripcionColor, Me.colDescripcionTalla, Me.colStock})
        Me.gvArticulos.GridControl = Me.dgArticulos
        Me.gvArticulos.Name = "gvArticulos"
        Me.gvArticulos.OptionsCustomization.AllowBandMoving = False
        Me.gvArticulos.OptionsCustomization.AllowBandResizing = False
        Me.gvArticulos.OptionsCustomization.AllowColumnMoving = False
        Me.gvArticulos.OptionsCustomization.AllowFilter = False
        Me.gvArticulos.OptionsCustomization.AllowGroup = False
        Me.gvArticulos.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvArticulos.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvArticulos.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvArticulos.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Artículo"
        Me.GridBand1.Columns.Add(Me.colFechaVigor)
        Me.GridBand1.Columns.Add(Me.colCodigoArticulo)
        Me.GridBand1.Columns.Add(Me.colDescripcion)
        Me.GridBand1.Columns.Add(Me.colStock)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 385
        '
        'colFechaVigor
        '
        Me.colFechaVigor.FieldName = "FechaVigor"
        Me.colFechaVigor.Name = "colFechaVigor"
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
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.AllowFocus = False
        Me.colDescripcion.Visible = True
        Me.colDescripcion.Width = 235
        '
        'colStock
        '
        Me.colStock.Caption = "Stock"
        Me.colStock.DisplayFormat.FormatString = "n2"
        Me.colStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colStock.FieldName = "Stock"
        Me.colStock.Name = "colStock"
        Me.colStock.OptionsColumn.AllowEdit = False
        Me.colStock.OptionsColumn.AllowFocus = False
        Me.colStock.OptionsColumn.FixedWidth = True
        Me.colStock.Visible = True
        Me.colStock.Width = 70
        '
        'gbColor
        '
        Me.gbColor.Caption = "Color"
        Me.gbColor.Columns.Add(Me.colDescripcionColor)
        Me.gbColor.Columns.Add(Me.colCodigoColor)
        Me.gbColor.Name = "gbColor"
        Me.gbColor.OptionsBand.FixedWidth = True
        Me.gbColor.VisibleIndex = 1
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
        'gbTalla
        '
        Me.gbTalla.Caption = "Talla"
        Me.gbTalla.Columns.Add(Me.colDescripcionTalla)
        Me.gbTalla.Columns.Add(Me.colCodigoTalla)
        Me.gbTalla.Name = "gbTalla"
        Me.gbTalla.OptionsBand.FixedWidth = True
        Me.gbTalla.VisibleIndex = 2
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
        'gridBand3
        '
        Me.gridBand3.Caption = "Precios"
        Me.gridBand3.Columns.Add(Me.colPrecioActual)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.OptionsBand.FixedWidth = True
        Me.gridBand3.VisibleIndex = 3
        Me.gridBand3.Width = 80
        '
        'colPrecioActual
        '
        Me.colPrecioActual.AppearanceCell.Options.UseTextOptions = True
        Me.colPrecioActual.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPrecioActual.Caption = "Precio Actual"
        Me.colPrecioActual.ColumnEdit = Me.maskPrecio
        Me.colPrecioActual.FieldName = "Precio"
        Me.colPrecioActual.MinWidth = 80
        Me.colPrecioActual.Name = "colPrecioActual"
        Me.colPrecioActual.OptionsColumn.AllowEdit = False
        Me.colPrecioActual.OptionsColumn.AllowFocus = False
        Me.colPrecioActual.Visible = True
        Me.colPrecioActual.Width = 80
        '
        'gridBand5
        '
        Me.gridBand5.Caption = "Imprimir"
        Me.gridBand5.Columns.Add(Me.colEtiquetas)
        Me.gridBand5.Columns.Add(Me.colImprimir)
        Me.gridBand5.MinWidth = 50
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.OptionsBand.FixedWidth = True
        Me.gridBand5.VisibleIndex = 4
        Me.gridBand5.Width = 114
        '
        'colEtiquetas
        '
        Me.colEtiquetas.Caption = "Etiquetas"
        Me.colEtiquetas.FieldName = "Etiquetas"
        Me.colEtiquetas.Name = "colEtiquetas"
        Me.colEtiquetas.OptionsColumn.FixedWidth = True
        Me.colEtiquetas.Visible = True
        Me.colEtiquetas.Width = 60
        '
        'colImprimir
        '
        Me.colImprimir.AppearanceHeader.Options.UseTextOptions = True
        Me.colImprimir.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colImprimir.Caption = "Sí/No"
        Me.colImprimir.FieldName = "Imprimir"
        Me.colImprimir.MinWidth = 50
        Me.colImprimir.Name = "colImprimir"
        Me.colImprimir.Visible = True
        Me.colImprimir.Width = 54
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'panelDetalle
        '
        Me.panelDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelDetalle.Controls.Add(Me.checkFidelizacion)
        Me.panelDetalle.Controls.Add(Me.dgArticulos)
        Me.panelDetalle.Location = New System.Drawing.Point(12, 125)
        Me.panelDetalle.Name = "panelDetalle"
        Me.panelDetalle.Size = New System.Drawing.Size(760, 374)
        Me.panelDetalle.TabIndex = 1
        Me.panelDetalle.Text = "ARTÍCULOS"
        '
        'checkFidelizacion
        '
        Me.checkFidelizacion.Location = New System.Drawing.Point(84, 1)
        Me.checkFidelizacion.Name = "checkFidelizacion"
        Me.checkFidelizacion.Properties.AutoWidth = True
        Me.checkFidelizacion.Properties.Caption = "Sólo fidelización"
        Me.checkFidelizacion.Size = New System.Drawing.Size(97, 19)
        Me.checkFidelizacion.TabIndex = 6
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttImprimir.Location = New System.Drawing.Point(647, 505)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(125, 45)
        Me.bttImprimir.TabIndex = 2
        Me.bttImprimir.Text = "Imprimir etiquetas"
        '
        'bttEliminar
        '
        Me.bttEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttEliminar.Image = Global.AydaraTPV.My.Resources.Resources._1321518972_close
        Me.bttEliminar.Location = New System.Drawing.Point(124, 505)
        Me.bttEliminar.Name = "bttEliminar"
        Me.bttEliminar.Size = New System.Drawing.Size(138, 45)
        Me.bttEliminar.TabIndex = 4
        Me.bttEliminar.TabStop = False
        Me.bttEliminar.Text = "Eliminar pendientes"
        '
        'ETIQUETASTableAdapter
        '
        Me.ETIQUETASTableAdapter.ClearBeforeFill = True
        '
        'COLORESTableAdapter
        '
        Me.COLORESTableAdapter.ClearBeforeFill = True
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(12, 505)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 5
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'bttCodigosBarras
        '
        Me.bttCodigosBarras.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCodigosBarras.Appearance.Options.UseTextOptions = True
        Me.bttCodigosBarras.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttCodigosBarras.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttCodigosBarras.Location = New System.Drawing.Point(516, 505)
        Me.bttCodigosBarras.Name = "bttCodigosBarras"
        Me.bttCodigosBarras.Size = New System.Drawing.Size(125, 45)
        Me.bttCodigosBarras.TabIndex = 3
        Me.bttCodigosBarras.Text = "Imprimir códigos de barras"
        Me.bttCodigosBarras.Visible = False
        '
        'panelImportarArticulos
        '
        Me.panelImportarArticulos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelImportarArticulos.Controls.Add(Me.txtCodigoArticulo_Hasta)
        Me.panelImportarArticulos.Controls.Add(Me.txtCodigoArticulo_Desde)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl2)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl1)
        Me.panelImportarArticulos.Controls.Add(Me.txtNombreProveedor)
        Me.panelImportarArticulos.Controls.Add(Me.txtCodigoProveedor)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl8)
        Me.panelImportarArticulos.Controls.Add(Me.bttImportarArticulos)
        Me.panelImportarArticulos.Controls.Add(Me.txtDescripcionSubfamilia)
        Me.panelImportarArticulos.Controls.Add(Me.txtDescripcionFamilia)
        Me.panelImportarArticulos.Controls.Add(Me.txtCodigoSubfamilia)
        Me.panelImportarArticulos.Controls.Add(Me.txtCodigoFamilia)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl3)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl4)
        Me.panelImportarArticulos.Location = New System.Drawing.Point(12, 12)
        Me.panelImportarArticulos.Name = "panelImportarArticulos"
        Me.panelImportarArticulos.Size = New System.Drawing.Size(760, 107)
        Me.panelImportarArticulos.TabIndex = 0
        Me.panelImportarArticulos.Text = "AÑADIR ARTÍCULOS"
        '
        'txtCodigoArticulo_Hasta
        '
        Me.txtCodigoArticulo_Hasta.EnterMoveNextControl = True
        Me.txtCodigoArticulo_Hasta.Location = New System.Drawing.Point(204, 75)
        Me.txtCodigoArticulo_Hasta.Name = "txtCodigoArticulo_Hasta"
        Me.txtCodigoArticulo_Hasta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigoArticulo_Hasta.Size = New System.Drawing.Size(75, 20)
        Me.txtCodigoArticulo_Hasta.TabIndex = 7
        '
        'txtCodigoArticulo_Desde
        '
        Me.txtCodigoArticulo_Desde.EnterMoveNextControl = True
        Me.txtCodigoArticulo_Desde.Location = New System.Drawing.Point(86, 75)
        Me.txtCodigoArticulo_Desde.Name = "txtCodigoArticulo_Desde"
        Me.txtCodigoArticulo_Desde.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigoArticulo_Desde.Size = New System.Drawing.Size(75, 20)
        Me.txtCodigoArticulo_Desde.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(167, 78)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl2.TabIndex = 31
        Me.LabelControl2.Text = "hasta:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 78)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl1.TabIndex = 28
        Me.LabelControl1.Text = "Desde artículo:"
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreProveedor.EnterMoveNextControl = True
        Me.txtNombreProveedor.Location = New System.Drawing.Point(160, 23)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Properties.MaxLength = 50
        Me.txtNombreProveedor.Properties.ReadOnly = True
        Me.txtNombreProveedor.Size = New System.Drawing.Size(595, 20)
        Me.txtNombreProveedor.TabIndex = 1
        Me.txtNombreProveedor.TabStop = False
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.EditValue = ""
        Me.txtCodigoProveedor.EnterMoveNextControl = True
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(86, 23)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(75, 20)
        Me.txtCodigoProveedor.TabIndex = 0
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(7, 26)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl8.TabIndex = 25
        Me.LabelControl8.Text = "Proveedor:"
        '
        'bttImportarArticulos
        '
        Me.bttImportarArticulos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttImportarArticulos.Location = New System.Drawing.Point(685, 75)
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
        Me.txtDescripcionSubfamilia.Location = New System.Drawing.Point(492, 49)
        Me.txtDescripcionSubfamilia.Name = "txtDescripcionSubfamilia"
        Me.txtDescripcionSubfamilia.Properties.MaxLength = 50
        Me.txtDescripcionSubfamilia.Properties.ReadOnly = True
        Me.txtDescripcionSubfamilia.Size = New System.Drawing.Size(263, 20)
        Me.txtDescripcionSubfamilia.TabIndex = 5
        Me.txtDescripcionSubfamilia.TabStop = False
        '
        'txtDescripcionFamilia
        '
        Me.txtDescripcionFamilia.EnterMoveNextControl = True
        Me.txtDescripcionFamilia.Location = New System.Drawing.Point(140, 49)
        Me.txtDescripcionFamilia.Name = "txtDescripcionFamilia"
        Me.txtDescripcionFamilia.Properties.MaxLength = 50
        Me.txtDescripcionFamilia.Properties.ReadOnly = True
        Me.txtDescripcionFamilia.Size = New System.Drawing.Size(233, 20)
        Me.txtDescripcionFamilia.TabIndex = 3
        Me.txtDescripcionFamilia.TabStop = False
        '
        'txtCodigoSubfamilia
        '
        Me.txtCodigoSubfamilia.EnterMoveNextControl = True
        Me.txtCodigoSubfamilia.Location = New System.Drawing.Point(438, 49)
        Me.txtCodigoSubfamilia.Name = "txtCodigoSubfamilia"
        Me.txtCodigoSubfamilia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.txtCodigoSubfamilia.Properties.ReadOnly = True
        Me.txtCodigoSubfamilia.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoSubfamilia.TabIndex = 4
        '
        'txtCodigoFamilia
        '
        Me.txtCodigoFamilia.EnterMoveNextControl = True
        Me.txtCodigoFamilia.Location = New System.Drawing.Point(86, 49)
        Me.txtCodigoFamilia.Name = "txtCodigoFamilia"
        Me.txtCodigoFamilia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoFamilia.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoFamilia.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(8, 52)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "Familia:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(379, 52)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Subfamilia:"
        '
        'bttEtiquetaIndividual
        '
        Me.bttEtiquetaIndividual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttEtiquetaIndividual.Appearance.Options.UseTextOptions = True
        Me.bttEtiquetaIndividual.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttEtiquetaIndividual.Image = Global.AydaraTPV.My.Resources.Resources.menu_vales
        Me.bttEtiquetaIndividual.Location = New System.Drawing.Point(385, 505)
        Me.bttEtiquetaIndividual.Name = "bttEtiquetaIndividual"
        Me.bttEtiquetaIndividual.Size = New System.Drawing.Size(125, 45)
        Me.bttEtiquetaIndividual.TabIndex = 7
        Me.bttEtiquetaIndividual.Text = "Etiqueta individual"
        Me.bttEtiquetaIndividual.Visible = False
        '
        'ImpresionEtiquetasPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.bttEtiquetaIndividual)
        Me.Controls.Add(Me.panelImportarArticulos)
        Me.Controls.Add(Me.bttCodigosBarras)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttEliminar)
        Me.Controls.Add(Me.bttImprimir)
        Me.Controls.Add(Me.panelDetalle)
        Me.KeyPreview = True
        Me.Name = "ImpresionEtiquetasPendientes"
        Me.Text = "Impresión de etiquetas"
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEtiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTallas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TALLASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ETIQUETASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDetalle.ResumeLayout(False)
        CType(Me.checkFidelizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelImportarArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImportarArticulos.ResumeLayout(False)
        Me.panelImportarArticulos.PerformLayout()
        CType(Me.txtCodigoArticulo_Hasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoArticulo_Desde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionSubfamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoSubfamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgArticulos As DevExpress.XtraGrid.GridControl
    Friend WithEvents panelDetalle As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gvArticulos As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colFechaVigor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoTalla As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecioActual As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colImprimir As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gbColor As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gbTalla As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colDescripcionColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcionTalla As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bttEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DsEtiquetas As AydaraTPV.dsEtiquetas
    Friend WithEvents ETIQUETASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ETIQUETASTableAdapter As AydaraTPV.dsEtiquetasTableAdapters.ETIQUETASTableAdapter
    Friend WithEvents COLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COLORESTableAdapter As AydaraTPV.dsEtiquetasTableAdapters.COLORESTableAdapter
    Friend WithEvents TALLASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colEtiquetas As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCodigoArticulo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cmbColores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbTallas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents maskPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bttCodigosBarras As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colStock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents panelImportarArticulos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNombreProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoProveedor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttImportarArticulos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescripcionSubfamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcionFamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoSubfamilia As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCodigoFamilia As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoArticulo_Hasta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoArticulo_Desde As DevExpress.XtraEditors.TextEdit
    Friend WithEvents checkFidelizacion As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents bttEtiquetaIndividual As DevExpress.XtraEditors.SimpleButton
End Class
