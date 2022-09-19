<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificacionPrecios
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
        Dim SuperToolTip2 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem2 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem2 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificacionPrecios))
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.panelImportarArticulos = New DevExpress.XtraEditors.GroupControl
        Me.txtFechaVigor = New DevExpress.XtraEditors.DateEdit
        Me.checkActualizacionDirecta = New DevExpress.XtraEditors.CheckEdit
        Me.checkConformidad = New DevExpress.XtraEditors.CheckEdit
        Me.txtNombreProveedor = New DevExpress.XtraEditors.TextEdit
        Me.txtCodigoProveedor = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtTipoRedondeo = New DevExpress.XtraEditors.ComboBoxEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.bttImportarArticulos = New DevExpress.XtraEditors.SimpleButton
        Me.txtIncremento = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtDescripcionSubfamilia = New DevExpress.XtraEditors.TextEdit
        Me.txtDescripcionFamilia = New DevExpress.XtraEditors.TextEdit
        Me.txtCodigoSubfamilia = New DevExpress.XtraEditors.ButtonEdit
        Me.txtCodigoFamilia = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.dgArticulos = New DevExpress.XtraGrid.GridControl
        Me.MODIFICACIONESPENDIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsModificacionesPendientes = New AydaraTPV.dsModificacionesPendientes
        Me.gvArticulos = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colFechaVigor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.bttCodigoArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colDescripcion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gbColor = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colDescripcionColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCodigoColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbColores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.COLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gbTalla = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colDescripcionTalla = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCodigoTalla = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbTallas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.TALLASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colPrecioActual = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colPrecioTarifa = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colActualiza = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.panelDetalle = New DevExpress.XtraEditors.GroupControl
        Me.MODIFICACIONES_PENDIENTESTableAdapter = New AydaraTPV.dsModificacionesPendientesTableAdapters.MODIFICACIONES_PENDIENTESTableAdapter
        Me.bttActualizar = New DevExpress.XtraEditors.SimpleButton
        Me.COLORESTableAdapter = New AydaraTPV.dsModificacionesPendientesTableAdapters.COLORESTableAdapter
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.panelImportarArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImportarArticulos.SuspendLayout()
        CType(Me.txtFechaVigor.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaVigor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkActualizacionDirecta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkConformidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoRedondeo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIncremento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionSubfamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoSubfamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MODIFICACIONESPENDIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsModificacionesPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTallas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TALLASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelImportarArticulos
        '
        Me.panelImportarArticulos.Controls.Add(Me.txtFechaVigor)
        Me.panelImportarArticulos.Controls.Add(Me.checkActualizacionDirecta)
        Me.panelImportarArticulos.Controls.Add(Me.checkConformidad)
        Me.panelImportarArticulos.Controls.Add(Me.txtNombreProveedor)
        Me.panelImportarArticulos.Controls.Add(Me.txtCodigoProveedor)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl8)
        Me.panelImportarArticulos.Controls.Add(Me.txtTipoRedondeo)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl5)
        Me.panelImportarArticulos.Controls.Add(Me.bttImportarArticulos)
        Me.panelImportarArticulos.Controls.Add(Me.txtIncremento)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl1)
        Me.panelImportarArticulos.Controls.Add(Me.txtDescripcionSubfamilia)
        Me.panelImportarArticulos.Controls.Add(Me.txtDescripcionFamilia)
        Me.panelImportarArticulos.Controls.Add(Me.txtCodigoSubfamilia)
        Me.panelImportarArticulos.Controls.Add(Me.txtCodigoFamilia)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl3)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl4)
        Me.panelImportarArticulos.Location = New System.Drawing.Point(12, 12)
        Me.panelImportarArticulos.Name = "panelImportarArticulos"
        Me.panelImportarArticulos.Size = New System.Drawing.Size(760, 132)
        Me.panelImportarArticulos.TabIndex = 107
        Me.panelImportarArticulos.Text = "AÑADIR ARTÍCULOS"
        '
        'txtFechaVigor
        '
        Me.txtFechaVigor.EditValue = Nothing
        Me.txtFechaVigor.Location = New System.Drawing.Point(572, 101)
        Me.txtFechaVigor.Name = "txtFechaVigor"
        Me.txtFechaVigor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaVigor.Properties.ReadOnly = True
        Me.txtFechaVigor.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFechaVigor.Size = New System.Drawing.Size(82, 20)
        Me.txtFechaVigor.TabIndex = 7
        '
        'checkActualizacionDirecta
        '
        Me.checkActualizacionDirecta.EditValue = True
        Me.checkActualizacionDirecta.Location = New System.Drawing.Point(441, 102)
        Me.checkActualizacionDirecta.Name = "checkActualizacionDirecta"
        Me.checkActualizacionDirecta.Properties.AutoWidth = True
        Me.checkActualizacionDirecta.Properties.Caption = "Actualización directa:"
        Me.checkActualizacionDirecta.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.checkActualizacionDirecta.Size = New System.Drawing.Size(125, 19)
        Me.checkActualizacionDirecta.TabIndex = 6
        '
        'checkConformidad
        '
        Me.checkConformidad.Location = New System.Drawing.Point(322, 102)
        Me.checkConformidad.Name = "checkConformidad"
        Me.checkConformidad.Properties.AutoWidth = True
        Me.checkConformidad.Properties.Caption = "Pedir conformidad:"
        Me.checkConformidad.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.checkConformidad.Size = New System.Drawing.Size(113, 19)
        Me.checkConformidad.TabIndex = 5
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreProveedor.EnterMoveNextControl = True
        Me.txtNombreProveedor.Location = New System.Drawing.Point(141, 23)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Properties.MaxLength = 50
        Me.txtNombreProveedor.Properties.ReadOnly = True
        Me.txtNombreProveedor.Size = New System.Drawing.Size(614, 20)
        Me.txtNombreProveedor.TabIndex = 23
        Me.txtNombreProveedor.TabStop = False
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.EditValue = ""
        Me.txtCodigoProveedor.EnterMoveNextControl = True
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(67, 23)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
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
        'txtTipoRedondeo
        '
        Me.txtTipoRedondeo.EditValue = "Ninguno"
        Me.txtTipoRedondeo.Location = New System.Drawing.Point(227, 101)
        Me.txtTipoRedondeo.Name = "txtTipoRedondeo"
        Me.txtTipoRedondeo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTipoRedondeo.Properties.Items.AddRange(New Object() {"Ninguno", "0.00 / 0.50", "0.00 / 0.05", "0.90 anterior"})
        Me.txtTipoRedondeo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtTipoRedondeo.Size = New System.Drawing.Size(89, 20)
        ToolTipTitleItem2.Appearance.Image = Global.AydaraTPV.My.Resources.Resources.menu_fondos
        ToolTipTitleItem2.Appearance.Options.UseImage = True
        ToolTipTitleItem2.Image = Global.AydaraTPV.My.Resources.Resources.menu_fondos
        ToolTipTitleItem2.Text = "Tipo de redondeo que se " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aplicará al el precio calculado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipItem2.LeftIndent = 6
        ToolTipItem2.Text = resources.GetString("ToolTipItem2.Text")
        SuperToolTip2.Items.Add(ToolTipTitleItem2)
        SuperToolTip2.Items.Add(ToolTipItem2)
        Me.txtTipoRedondeo.SuperTip = SuperToolTip2
        Me.txtTipoRedondeo.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(148, 104)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "Tipo redondeo:"
        '
        'bttImportarArticulos
        '
        Me.bttImportarArticulos.Location = New System.Drawing.Point(685, 101)
        Me.bttImportarArticulos.Name = "bttImportarArticulos"
        Me.bttImportarArticulos.Size = New System.Drawing.Size(70, 23)
        Me.bttImportarArticulos.TabIndex = 8
        Me.bttImportarArticulos.Text = "Importar"
        '
        'txtIncremento
        '
        Me.txtIncremento.EditValue = "0"
        Me.txtIncremento.EnterMoveNextControl = True
        Me.txtIncremento.Location = New System.Drawing.Point(87, 101)
        Me.txtIncremento.Name = "txtIncremento"
        Me.txtIncremento.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIncremento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIncremento.Properties.Mask.EditMask = "P"
        Me.txtIncremento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIncremento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtIncremento.Size = New System.Drawing.Size(55, 20)
        Me.txtIncremento.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(8, 104)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "% Incremento:"
        '
        'txtDescripcionSubfamilia
        '
        Me.txtDescripcionSubfamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionSubfamilia.EnterMoveNextControl = True
        Me.txtDescripcionSubfamilia.Location = New System.Drawing.Point(121, 75)
        Me.txtDescripcionSubfamilia.Name = "txtDescripcionSubfamilia"
        Me.txtDescripcionSubfamilia.Properties.MaxLength = 50
        Me.txtDescripcionSubfamilia.Properties.ReadOnly = True
        Me.txtDescripcionSubfamilia.Size = New System.Drawing.Size(634, 20)
        Me.txtDescripcionSubfamilia.TabIndex = 14
        Me.txtDescripcionSubfamilia.TabStop = False
        '
        'txtDescripcionFamilia
        '
        Me.txtDescripcionFamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionFamilia.EnterMoveNextControl = True
        Me.txtDescripcionFamilia.Location = New System.Drawing.Point(121, 49)
        Me.txtDescripcionFamilia.Name = "txtDescripcionFamilia"
        Me.txtDescripcionFamilia.Properties.MaxLength = 50
        Me.txtDescripcionFamilia.Properties.ReadOnly = True
        Me.txtDescripcionFamilia.Size = New System.Drawing.Size(634, 20)
        Me.txtDescripcionFamilia.TabIndex = 12
        Me.txtDescripcionFamilia.TabStop = False
        '
        'txtCodigoSubfamilia
        '
        Me.txtCodigoSubfamilia.EnterMoveNextControl = True
        Me.txtCodigoSubfamilia.Location = New System.Drawing.Point(67, 75)
        Me.txtCodigoSubfamilia.Name = "txtCodigoSubfamilia"
        Me.txtCodigoSubfamilia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing)})
        Me.txtCodigoSubfamilia.Properties.ReadOnly = True
        Me.txtCodigoSubfamilia.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoSubfamilia.TabIndex = 2
        '
        'txtCodigoFamilia
        '
        Me.txtCodigoFamilia.EnterMoveNextControl = True
        Me.txtCodigoFamilia.Location = New System.Drawing.Point(67, 49)
        Me.txtCodigoFamilia.Name = "txtCodigoFamilia"
        Me.txtCodigoFamilia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoFamilia.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoFamilia.TabIndex = 1
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
        Me.LabelControl4.Location = New System.Drawing.Point(8, 78)
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
        Me.dgArticulos.DataSource = Me.MODIFICACIONESPENDIENTESBindingSource
        Me.dgArticulos.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgArticulos.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgArticulos.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgArticulos.EmbeddedNavigator.TextStringFormat = "Línea {0} de {1}"
        Me.dgArticulos.Location = New System.Drawing.Point(5, 23)
        Me.dgArticulos.MainView = Me.gvArticulos
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskPrecio, Me.cmbColores, Me.cmbTallas, Me.bttCodigoArticulo})
        Me.dgArticulos.Size = New System.Drawing.Size(750, 321)
        Me.dgArticulos.TabIndex = 108
        Me.dgArticulos.UseEmbeddedNavigator = True
        Me.dgArticulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArticulos})
        '
        'MODIFICACIONESPENDIENTESBindingSource
        '
        Me.MODIFICACIONESPENDIENTESBindingSource.DataMember = "MODIFICACIONES_PENDIENTES"
        Me.MODIFICACIONESPENDIENTESBindingSource.DataSource = Me.DsModificacionesPendientes
        '
        'DsModificacionesPendientes
        '
        Me.DsModificacionesPendientes.DataSetName = "dsModificacionesPendientes"
        Me.DsModificacionesPendientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvArticulos
        '
        Me.gvArticulos.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gbColor, Me.gbTalla, Me.gridBand3, Me.gridBand5})
        Me.gvArticulos.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colFechaVigor, Me.colCodigoArticulo, Me.colDescripcion, Me.colCodigoColor, Me.colCodigoTalla, Me.colPrecioActual, Me.colPrecioTarifa, Me.colActualiza, Me.colDescripcionColor, Me.colDescripcionTalla})
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
        Me.GridBand1.Columns.Add(Me.colFechaVigor)
        Me.GridBand1.Columns.Add(Me.colCodigoArticulo)
        Me.GridBand1.Columns.Add(Me.colDescripcion)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 365
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
        Me.COLORESBindingSource.DataSource = Me.DsModificacionesPendientes
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
        Me.TALLASBindingSource.DataSource = Me.DsModificacionesPendientes
        '
        'gridBand3
        '
        Me.gridBand3.Caption = "Precios"
        Me.gridBand3.Columns.Add(Me.colPrecioActual)
        Me.gridBand3.Columns.Add(Me.colPrecioTarifa)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.OptionsBand.FixedWidth = True
        Me.gridBand3.Width = 160
        '
        'colPrecioActual
        '
        Me.colPrecioActual.ColumnEdit = Me.maskPrecio
        Me.colPrecioActual.FieldName = "PrecioActual"
        Me.colPrecioActual.MinWidth = 80
        Me.colPrecioActual.Name = "colPrecioActual"
        Me.colPrecioActual.OptionsColumn.AllowEdit = False
        Me.colPrecioActual.OptionsColumn.AllowFocus = False
        Me.colPrecioActual.Visible = True
        Me.colPrecioActual.Width = 80
        '
        'maskPrecio
        '
        Me.maskPrecio.AutoHeight = False
        Me.maskPrecio.Mask.EditMask = "c2"
        Me.maskPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecio.Name = "maskPrecio"
        '
        'colPrecioTarifa
        '
        Me.colPrecioTarifa.Caption = "Precio Nuevo"
        Me.colPrecioTarifa.ColumnEdit = Me.maskPrecio
        Me.colPrecioTarifa.FieldName = "PrecioTarifa"
        Me.colPrecioTarifa.MinWidth = 80
        Me.colPrecioTarifa.Name = "colPrecioTarifa"
        Me.colPrecioTarifa.Visible = True
        Me.colPrecioTarifa.Width = 80
        '
        'gridBand5
        '
        Me.gridBand5.Caption = "Actualiza"
        Me.gridBand5.Columns.Add(Me.colActualiza)
        Me.gridBand5.MinWidth = 50
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.OptionsBand.FixedWidth = True
        Me.gridBand5.Width = 54
        '
        'colActualiza
        '
        Me.colActualiza.AppearanceHeader.Options.UseTextOptions = True
        Me.colActualiza.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colActualiza.Caption = "Sí/No"
        Me.colActualiza.FieldName = "Actualiza"
        Me.colActualiza.MinWidth = 50
        Me.colActualiza.Name = "colActualiza"
        Me.colActualiza.Visible = True
        Me.colActualiza.Width = 54
        '
        'panelDetalle
        '
        Me.panelDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelDetalle.Controls.Add(Me.dgArticulos)
        Me.panelDetalle.Location = New System.Drawing.Point(12, 150)
        Me.panelDetalle.Name = "panelDetalle"
        Me.panelDetalle.Size = New System.Drawing.Size(760, 349)
        Me.panelDetalle.TabIndex = 109
        Me.panelDetalle.Text = "ARTÍCULOS"
        '
        'MODIFICACIONES_PENDIENTESTableAdapter
        '
        Me.MODIFICACIONES_PENDIENTESTableAdapter.ClearBeforeFill = True
        '
        'bttActualizar
        '
        Me.bttActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttActualizar.Image = Global.AydaraTPV.My.Resources.Resources.menu_fondos
        Me.bttActualizar.Location = New System.Drawing.Point(647, 505)
        Me.bttActualizar.Name = "bttActualizar"
        Me.bttActualizar.Size = New System.Drawing.Size(125, 45)
        Me.bttActualizar.TabIndex = 110
        Me.bttActualizar.Text = "Actualiza precios"
        '
        'COLORESTableAdapter
        '
        Me.COLORESTableAdapter.ClearBeforeFill = True
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.search
        Me.bttBuscar.Location = New System.Drawing.Point(124, 505)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(179, 45)
        Me.bttBuscar.TabIndex = 111
        Me.bttBuscar.TabStop = False
        Me.bttBuscar.Text = "Modificaciones pendientes"
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
        'ModificacionPrecios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttBuscar)
        Me.Controls.Add(Me.bttActualizar)
        Me.Controls.Add(Me.panelDetalle)
        Me.Controls.Add(Me.panelImportarArticulos)
        Me.KeyPreview = True
        Me.Name = "ModificacionPrecios"
        Me.Text = "Modificación precios"
        CType(Me.panelImportarArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImportarArticulos.ResumeLayout(False)
        Me.panelImportarArticulos.PerformLayout()
        CType(Me.txtFechaVigor.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaVigor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkActualizacionDirecta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkConformidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoRedondeo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIncremento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionSubfamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoSubfamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MODIFICACIONESPENDIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsModificacionesPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTallas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TALLASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDetalle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelImportarArticulos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTipoRedondeo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttImportarArticulos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtIncremento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcionSubfamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcionFamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoSubfamilia As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCodigoFamilia As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dgArticulos As DevExpress.XtraGrid.GridControl
    Friend WithEvents panelDetalle As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DsModificacionesPendientes As AydaraTPV.dsModificacionesPendientes
    Friend WithEvents MODIFICACIONESPENDIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MODIFICACIONES_PENDIENTESTableAdapter As AydaraTPV.dsModificacionesPendientesTableAdapters.MODIFICACIONES_PENDIENTESTableAdapter
    Friend WithEvents txtNombreProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoProveedor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents maskPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents checkConformidad As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkActualizacionDirecta As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFechaVigor As DevExpress.XtraEditors.DateEdit
    Friend WithEvents bttActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbColores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents COLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COLORESTableAdapter As AydaraTPV.dsModificacionesPendientesTableAdapters.COLORESTableAdapter
    Friend WithEvents cmbTallas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TALLASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bttCodigoArticulo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents gvArticulos As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colFechaVigor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoTalla As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecioActual As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecioTarifa As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colActualiza As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gbColor As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gbTalla As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colDescripcionColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcionTalla As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
End Class
