<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Promociones
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
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Promociones))
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.PROMOCIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPromociones = New AydaraTPV.dsPromociones()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFechaFinal = New DevExpress.XtraEditors.DateEdit()
        Me.COLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TALLASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.panelFechas = New DevExpress.XtraEditors.GroupControl()
        Me.PROMOCIONESTableAdapter = New AydaraTPV.dsPromocionesTableAdapters.PROMOCIONESTableAdapter()
        Me.COLORESTableAdapter = New AydaraTPV.dsPromocionesTableAdapters.COLORESTableAdapter()
        Me.dgPromociones = New DevExpress.XtraGrid.GridControl()
        Me.gvPromociones = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colId = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodigoTienda = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFechaInicio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFechaFinal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bttCodigoArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colDescripcionArticulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.gbColor = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colDescripcionColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodigoColor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.cmbColores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.gbTalla = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colDescripcionTalla = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodigoTalla = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.cmbTallas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.gridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colPrecioTarifa = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colUnidades = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.maskCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPrecioPromocion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCodigoArticuloRegalo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bttArticuloRegalo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colDescripcionArticuloRegalo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFraccionSinCargo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colUnidadesSinCargo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrecioArticuloRegalo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.panelImportarArticulos = New DevExpress.XtraEditors.GroupControl()
        Me.txtTipoRedondeo = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.bttImportarArticulos = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcionSubfamilia = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcionFamilia = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoSubfamilia = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtCodigoFamilia = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.panelDetalle = New DevExpress.XtraEditors.GroupControl()
        Me.NavLineas = New DevExpress.XtraEditors.DataNavigator()
        Me.bttImprimirEtiquetas = New DevExpress.XtraEditors.SimpleButton()
        Me.bttImprimirPromocion = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PROMOCIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPromociones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TALLASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelFechas.SuspendLayout()
        CType(Me.dgPromociones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPromociones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTallas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttArticuloRegalo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelImportarArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImportarArticulos.SuspendLayout()
        CType(Me.txtTipoRedondeo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionSubfamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoSubfamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDetalle.SuspendLayout()
        Me.SuspendLayout()
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.search
        Me.bttBuscar.Location = New System.Drawing.Point(236, 585)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(106, 45)
        Me.bttBuscar.TabIndex = 40
        Me.bttBuscar.TabStop = False
        Me.bttBuscar.Text = "Buscar"
        '
        'bttModificar
        '
        Me.bttModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttModificar.Enabled = False
        Me.bttModificar.Image = Global.AydaraTPV.My.Resources.Resources.menu_vales
        Me.bttModificar.Location = New System.Drawing.Point(124, 585)
        Me.bttModificar.Name = "bttModificar"
        Me.bttModificar.Size = New System.Drawing.Size(106, 45)
        Me.bttModificar.TabIndex = 39
        Me.bttModificar.TabStop = False
        Me.bttModificar.Text = "Modificar"
        '
        'bttNuevo
        '
        Me.bttNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttNuevo.Image = Global.AydaraTPV.My.Resources.Resources._new
        Me.bttNuevo.Location = New System.Drawing.Point(12, 585)
        Me.bttNuevo.Name = "bttNuevo"
        Me.bttNuevo.Size = New System.Drawing.Size(106, 45)
        Me.bttNuevo.TabIndex = 35
        Me.bttNuevo.TabStop = False
        Me.bttNuevo.Text = "Nueva"
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Enabled = False
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.save
        Me.bttGuardar.Location = New System.Drawing.Point(706, 585)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(106, 45)
        Me.bttGuardar.TabIndex = 36
        Me.bttGuardar.TabStop = False
        Me.bttGuardar.Text = "Guardar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(589, 585)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 37
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'bttEliminar
        '
        Me.bttEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttEliminar.Enabled = False
        Me.bttEliminar.Image = Global.AydaraTPV.My.Resources.Resources.delete2
        Me.bttEliminar.Location = New System.Drawing.Point(348, 585)
        Me.bttEliminar.Name = "bttEliminar"
        Me.bttEliminar.Size = New System.Drawing.Size(106, 45)
        Me.bttEliminar.TabIndex = 38
        Me.bttEliminar.TabStop = False
        Me.bttEliminar.Text = "Eliminar"
        '
        'PROMOCIONESBindingSource
        '
        Me.PROMOCIONESBindingSource.DataMember = "PROMOCIONES"
        Me.PROMOCIONESBindingSource.DataSource = Me.DsPromociones
        '
        'DsPromociones
        '
        Me.DsPromociones.DataSetName = "dsPromociones"
        Me.DsPromociones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(11, 35)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl9.TabIndex = 87
        Me.LabelControl9.Text = "Fecha de inicio:"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.EditValue = Nothing
        Me.txtFechaInicio.EnterMoveNextControl = True
        Me.txtFechaInicio.Location = New System.Drawing.Point(91, 32)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaInicio.Properties.Mask.EditMask = "g"
        Me.txtFechaInicio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFechaInicio.Properties.ReadOnly = True
        Me.txtFechaInicio.Size = New System.Drawing.Size(111, 20)
        Me.txtFechaInicio.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(208, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 89
        Me.LabelControl2.Text = "Fecha final:"
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.EditValue = Nothing
        Me.txtFechaFinal.EnterMoveNextControl = True
        Me.txtFechaFinal.Location = New System.Drawing.Point(270, 32)
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaFinal.Properties.Mask.EditMask = "g"
        Me.txtFechaFinal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFechaFinal.Properties.ReadOnly = True
        Me.txtFechaFinal.Size = New System.Drawing.Size(111, 20)
        Me.txtFechaFinal.TabIndex = 2
        '
        'COLORESBindingSource
        '
        Me.COLORESBindingSource.DataMember = "COLORES"
        Me.COLORESBindingSource.DataSource = Me.DsPromociones
        '
        'TALLASBindingSource
        '
        Me.TALLASBindingSource.DataMember = "TALLAS"
        Me.TALLASBindingSource.DataSource = Me.DsPromociones
        '
        'panelFechas
        '
        Me.panelFechas.Controls.Add(Me.txtFechaInicio)
        Me.panelFechas.Controls.Add(Me.LabelControl9)
        Me.panelFechas.Controls.Add(Me.LabelControl2)
        Me.panelFechas.Controls.Add(Me.txtFechaFinal)
        Me.panelFechas.Location = New System.Drawing.Point(12, 12)
        Me.panelFechas.Name = "panelFechas"
        Me.panelFechas.Size = New System.Drawing.Size(397, 66)
        Me.panelFechas.TabIndex = 0
        Me.panelFechas.Text = "FECHAS PROMOCIÓN"
        '
        'PROMOCIONESTableAdapter
        '
        Me.PROMOCIONESTableAdapter.ClearBeforeFill = True
        '
        'COLORESTableAdapter
        '
        Me.COLORESTableAdapter.ClearBeforeFill = True
        '
        'dgPromociones
        '
        Me.dgPromociones.DataSource = Me.PROMOCIONESBindingSource
        Me.dgPromociones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPromociones.EmbeddedNavigator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPromociones.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgPromociones.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgPromociones.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgPromociones.Location = New System.Drawing.Point(2, 21)
        Me.dgPromociones.MainView = Me.gvPromociones
        Me.dgPromociones.Name = "dgPromociones"
        Me.dgPromociones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.bttCodigoArticulo, Me.cmbColores, Me.cmbTallas, Me.bttArticuloRegalo, Me.maskPrecio, Me.maskCantidad})
        Me.dgPromociones.Size = New System.Drawing.Size(796, 417)
        Me.dgPromociones.TabIndex = 105
        Me.dgPromociones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPromociones})
        '
        'gvPromociones
        '
        Me.gvPromociones.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gbColor, Me.gbTalla, Me.gridBand5, Me.GridBand6})
        Me.gvPromociones.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colId, Me.colCodigoTienda, Me.colFechaInicio, Me.colFechaFinal, Me.colCodigoArticulo, Me.colDescripcionArticulo, Me.colCodigoColor, Me.colCodigoTalla, Me.colPrecioTarifa, Me.colUnidades, Me.colPrecioPromocion, Me.colCodigoArticuloRegalo, Me.colDescripcionArticuloRegalo, Me.colFraccionSinCargo, Me.colUnidadesSinCargo, Me.colDescripcionColor, Me.colDescripcionTalla, Me.colPrecioArticuloRegalo})
        Me.gvPromociones.CustomizationFormBounds = New System.Drawing.Rectangle(1685, 726, 225, 230)
        Me.gvPromociones.GridControl = Me.dgPromociones
        Me.gvPromociones.Name = "gvPromociones"
        Me.gvPromociones.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvPromociones.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvPromociones.OptionsCustomization.AllowGroup = False
        Me.gvPromociones.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvPromociones.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvPromociones.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Artículo"
        Me.GridBand1.Columns.Add(Me.colId)
        Me.GridBand1.Columns.Add(Me.colCodigoTienda)
        Me.GridBand1.Columns.Add(Me.colFechaInicio)
        Me.GridBand1.Columns.Add(Me.colFechaFinal)
        Me.GridBand1.Columns.Add(Me.colCodigoArticulo)
        Me.GridBand1.Columns.Add(Me.colDescripcionArticulo)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 160
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
        'colFechaInicio
        '
        Me.colFechaInicio.FieldName = "FechaInicio"
        Me.colFechaInicio.Name = "colFechaInicio"
        Me.colFechaInicio.OptionsColumn.ReadOnly = True
        '
        'colFechaFinal
        '
        Me.colFechaFinal.FieldName = "FechaFinal"
        Me.colFechaFinal.Name = "colFechaFinal"
        Me.colFechaFinal.OptionsColumn.ReadOnly = True
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.Caption = "Código"
        Me.colCodigoArticulo.ColumnEdit = Me.bttCodigoArticulo
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.MinWidth = 80
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.FixedWidth = True
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.Width = 80
        '
        'bttCodigoArticulo
        '
        Me.bttCodigoArticulo.AutoHeight = False
        Me.bttCodigoArticulo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.bttCodigoArticulo.MaxLength = 13
        Me.bttCodigoArticulo.Name = "bttCodigoArticulo"
        '
        'colDescripcionArticulo
        '
        Me.colDescripcionArticulo.Caption = "Descripción"
        Me.colDescripcionArticulo.FieldName = "DescripcionArticulo"
        Me.colDescripcionArticulo.MinWidth = 80
        Me.colDescripcionArticulo.Name = "colDescripcionArticulo"
        Me.colDescripcionArticulo.OptionsColumn.AllowEdit = False
        Me.colDescripcionArticulo.OptionsColumn.AllowFocus = False
        Me.colDescripcionArticulo.Visible = True
        Me.colDescripcionArticulo.Width = 80
        '
        'gbColor
        '
        Me.gbColor.Caption = "Color"
        Me.gbColor.Columns.Add(Me.colDescripcionColor)
        Me.gbColor.Columns.Add(Me.colCodigoColor)
        Me.gbColor.MinWidth = 80
        Me.gbColor.Name = "gbColor"
        Me.gbColor.OptionsBand.FixedWidth = True
        Me.gbColor.VisibleIndex = 1
        Me.gbColor.Width = 80
        '
        'colDescripcionColor
        '
        Me.colDescripcionColor.Caption = "Color"
        Me.colDescripcionColor.FieldName = "DescripcionColor"
        Me.colDescripcionColor.MinWidth = 40
        Me.colDescripcionColor.Name = "colDescripcionColor"
        Me.colDescripcionColor.OptionsColumn.AllowEdit = False
        Me.colDescripcionColor.OptionsColumn.AllowFocus = False
        Me.colDescripcionColor.OptionsColumn.FixedWidth = True
        Me.colDescripcionColor.Visible = True
        Me.colDescripcionColor.Width = 55
        '
        'colCodigoColor
        '
        Me.colCodigoColor.Caption = " "
        Me.colCodigoColor.ColumnEdit = Me.cmbColores
        Me.colCodigoColor.FieldName = "CodigoColor"
        Me.colCodigoColor.MinWidth = 25
        Me.colCodigoColor.Name = "colCodigoColor"
        Me.colCodigoColor.OptionsColumn.FixedWidth = True
        Me.colCodigoColor.OptionsColumn.ReadOnly = True
        Me.colCodigoColor.Visible = True
        Me.colCodigoColor.Width = 25
        '
        'cmbColores
        '
        Me.cmbColores.AutoHeight = False
        Me.cmbColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, False)})
        Me.cmbColores.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")})
        Me.cmbColores.DataSource = Me.COLORESBindingSource
        Me.cmbColores.DisplayMember = "Color"
        Me.cmbColores.Name = "cmbColores"
        Me.cmbColores.NullText = "-1"
        Me.cmbColores.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.cmbColores.ValueMember = "CodigoColor"
        '
        'gbTalla
        '
        Me.gbTalla.Caption = "Talla"
        Me.gbTalla.Columns.Add(Me.colDescripcionTalla)
        Me.gbTalla.Columns.Add(Me.colCodigoTalla)
        Me.gbTalla.MinWidth = 80
        Me.gbTalla.Name = "gbTalla"
        Me.gbTalla.OptionsBand.FixedWidth = True
        Me.gbTalla.VisibleIndex = 2
        Me.gbTalla.Width = 80
        '
        'colDescripcionTalla
        '
        Me.colDescripcionTalla.Caption = "Talla"
        Me.colDescripcionTalla.FieldName = "DescripcionTalla"
        Me.colDescripcionTalla.MinWidth = 40
        Me.colDescripcionTalla.Name = "colDescripcionTalla"
        Me.colDescripcionTalla.OptionsColumn.AllowEdit = False
        Me.colDescripcionTalla.OptionsColumn.AllowFocus = False
        Me.colDescripcionTalla.OptionsColumn.FixedWidth = True
        Me.colDescripcionTalla.Visible = True
        Me.colDescripcionTalla.Width = 55
        '
        'colCodigoTalla
        '
        Me.colCodigoTalla.Caption = " "
        Me.colCodigoTalla.ColumnEdit = Me.cmbTallas
        Me.colCodigoTalla.FieldName = "CodigoTalla"
        Me.colCodigoTalla.MinWidth = 25
        Me.colCodigoTalla.Name = "colCodigoTalla"
        Me.colCodigoTalla.OptionsColumn.FixedWidth = True
        Me.colCodigoTalla.OptionsColumn.ReadOnly = True
        Me.colCodigoTalla.Visible = True
        Me.colCodigoTalla.Width = 25
        '
        'cmbTallas
        '
        Me.cmbTallas.AutoHeight = False
        Me.cmbTallas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, False)})
        Me.cmbTallas.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Talla")})
        Me.cmbTallas.DataSource = Me.TALLASBindingSource
        Me.cmbTallas.DisplayMember = "Descripcion"
        Me.cmbTallas.Name = "cmbTallas"
        Me.cmbTallas.NullText = "-1"
        Me.cmbTallas.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.cmbTallas.ValueMember = "CodigoTalla"
        '
        'gridBand5
        '
        Me.gridBand5.Caption = "Precios"
        Me.gridBand5.Columns.Add(Me.colPrecioTarifa)
        Me.gridBand5.Columns.Add(Me.colUnidades)
        Me.gridBand5.Columns.Add(Me.colPrecioPromocion)
        Me.gridBand5.MinWidth = 20
        Me.gridBand5.Name = "gridBand5"
        Me.gridBand5.OptionsBand.FixedWidth = True
        Me.gridBand5.VisibleIndex = 3
        Me.gridBand5.Width = 215
        '
        'colPrecioTarifa
        '
        Me.colPrecioTarifa.Caption = "Tarifa"
        Me.colPrecioTarifa.ColumnEdit = Me.maskPrecio
        Me.colPrecioTarifa.FieldName = "PrecioTarifa"
        Me.colPrecioTarifa.MinWidth = 75
        Me.colPrecioTarifa.Name = "colPrecioTarifa"
        Me.colPrecioTarifa.OptionsColumn.AllowEdit = False
        Me.colPrecioTarifa.OptionsColumn.AllowFocus = False
        Me.colPrecioTarifa.OptionsColumn.FixedWidth = True
        Me.colPrecioTarifa.OptionsFilter.AllowAutoFilter = False
        Me.colPrecioTarifa.OptionsFilter.AllowFilter = False
        Me.colPrecioTarifa.Visible = True
        '
        'maskPrecio
        '
        Me.maskPrecio.AutoHeight = False
        Me.maskPrecio.Mask.EditMask = "c"
        Me.maskPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecio.Name = "maskPrecio"
        '
        'colUnidades
        '
        Me.colUnidades.Caption = "Unidades"
        Me.colUnidades.ColumnEdit = Me.maskCantidad
        Me.colUnidades.FieldName = "Unidades"
        Me.colUnidades.MinWidth = 60
        Me.colUnidades.Name = "colUnidades"
        Me.colUnidades.Visible = True
        Me.colUnidades.Width = 65
        '
        'maskCantidad
        '
        Me.maskCantidad.AutoHeight = False
        Me.maskCantidad.Mask.EditMask = "n0"
        Me.maskCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskCantidad.Mask.UseMaskAsDisplayFormat = True
        Me.maskCantidad.Name = "maskCantidad"
        '
        'colPrecioPromocion
        '
        Me.colPrecioPromocion.Caption = "Promoción"
        Me.colPrecioPromocion.ColumnEdit = Me.maskPrecio
        Me.colPrecioPromocion.FieldName = "PrecioPromocion"
        Me.colPrecioPromocion.MinWidth = 75
        Me.colPrecioPromocion.Name = "colPrecioPromocion"
        Me.colPrecioPromocion.OptionsColumn.FixedWidth = True
        Me.colPrecioPromocion.OptionsColumn.ReadOnly = True
        Me.colPrecioPromocion.Visible = True
        '
        'GridBand6
        '
        Me.GridBand6.Caption = "Artículo promoción"
        Me.GridBand6.Columns.Add(Me.colCodigoArticuloRegalo)
        Me.GridBand6.Columns.Add(Me.colDescripcionArticuloRegalo)
        Me.GridBand6.Columns.Add(Me.colFraccionSinCargo)
        Me.GridBand6.Columns.Add(Me.colUnidadesSinCargo)
        Me.GridBand6.Columns.Add(Me.colPrecioArticuloRegalo)
        Me.GridBand6.MinWidth = 20
        Me.GridBand6.Name = "GridBand6"
        Me.GridBand6.VisibleIndex = 4
        Me.GridBand6.Width = 360
        '
        'colCodigoArticuloRegalo
        '
        Me.colCodigoArticuloRegalo.Caption = "Código"
        Me.colCodigoArticuloRegalo.ColumnEdit = Me.bttArticuloRegalo
        Me.colCodigoArticuloRegalo.FieldName = "CodigoArticuloRegalo"
        Me.colCodigoArticuloRegalo.MinWidth = 80
        Me.colCodigoArticuloRegalo.Name = "colCodigoArticuloRegalo"
        Me.colCodigoArticuloRegalo.OptionsColumn.FixedWidth = True
        Me.colCodigoArticuloRegalo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticuloRegalo.Visible = True
        Me.colCodigoArticuloRegalo.Width = 80
        '
        'bttArticuloRegalo
        '
        Me.bttArticuloRegalo.AutoHeight = False
        Me.bttArticuloRegalo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, False)})
        Me.bttArticuloRegalo.MaxLength = 13
        Me.bttArticuloRegalo.Name = "bttArticuloRegalo"
        '
        'colDescripcionArticuloRegalo
        '
        Me.colDescripcionArticuloRegalo.Caption = "Descripción"
        Me.colDescripcionArticuloRegalo.FieldName = "DescripcionArticuloRegalo"
        Me.colDescripcionArticuloRegalo.MinWidth = 80
        Me.colDescripcionArticuloRegalo.Name = "colDescripcionArticuloRegalo"
        Me.colDescripcionArticuloRegalo.OptionsColumn.AllowEdit = False
        Me.colDescripcionArticuloRegalo.OptionsColumn.AllowFocus = False
        Me.colDescripcionArticuloRegalo.Visible = True
        Me.colDescripcionArticuloRegalo.Width = 80
        '
        'colFraccionSinCargo
        '
        Me.colFraccionSinCargo.Caption = "Cada"
        Me.colFraccionSinCargo.ColumnEdit = Me.maskCantidad
        Me.colFraccionSinCargo.FieldName = "FraccionSinCargo"
        Me.colFraccionSinCargo.MinWidth = 60
        Me.colFraccionSinCargo.Name = "colFraccionSinCargo"
        Me.colFraccionSinCargo.OptionsColumn.AllowEdit = False
        Me.colFraccionSinCargo.OptionsColumn.AllowFocus = False
        Me.colFraccionSinCargo.OptionsColumn.FixedWidth = True
        Me.colFraccionSinCargo.Visible = True
        Me.colFraccionSinCargo.Width = 60
        '
        'colUnidadesSinCargo
        '
        Me.colUnidadesSinCargo.Caption = "Promo"
        Me.colUnidadesSinCargo.ColumnEdit = Me.maskCantidad
        Me.colUnidadesSinCargo.FieldName = "UnidadesSinCargo"
        Me.colUnidadesSinCargo.MinWidth = 60
        Me.colUnidadesSinCargo.Name = "colUnidadesSinCargo"
        Me.colUnidadesSinCargo.OptionsColumn.AllowEdit = False
        Me.colUnidadesSinCargo.OptionsColumn.AllowFocus = False
        Me.colUnidadesSinCargo.OptionsColumn.FixedWidth = True
        Me.colUnidadesSinCargo.Visible = True
        Me.colUnidadesSinCargo.Width = 60
        '
        'colPrecioArticuloRegalo
        '
        Me.colPrecioArticuloRegalo.Caption = "Precio"
        Me.colPrecioArticuloRegalo.ColumnEdit = Me.maskPrecio
        Me.colPrecioArticuloRegalo.FieldName = "PrecioArticuloRegalo"
        Me.colPrecioArticuloRegalo.Name = "colPrecioArticuloRegalo"
        Me.colPrecioArticuloRegalo.OptionsColumn.FixedWidth = True
        Me.colPrecioArticuloRegalo.OptionsColumn.ReadOnly = True
        Me.colPrecioArticuloRegalo.Visible = True
        Me.colPrecioArticuloRegalo.Width = 80
        '
        'panelImportarArticulos
        '
        Me.panelImportarArticulos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelImportarArticulos.Controls.Add(Me.txtTipoRedondeo)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl5)
        Me.panelImportarArticulos.Controls.Add(Me.bttImportarArticulos)
        Me.panelImportarArticulos.Controls.Add(Me.txtDescuento)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl1)
        Me.panelImportarArticulos.Controls.Add(Me.txtDescripcionSubfamilia)
        Me.panelImportarArticulos.Controls.Add(Me.txtDescripcionFamilia)
        Me.panelImportarArticulos.Controls.Add(Me.txtCodigoSubfamilia)
        Me.panelImportarArticulos.Controls.Add(Me.txtCodigoFamilia)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl3)
        Me.panelImportarArticulos.Controls.Add(Me.LabelControl4)
        Me.panelImportarArticulos.Location = New System.Drawing.Point(439, 12)
        Me.panelImportarArticulos.Name = "panelImportarArticulos"
        Me.panelImportarArticulos.Size = New System.Drawing.Size(373, 102)
        Me.panelImportarArticulos.TabIndex = 106
        Me.panelImportarArticulos.Text = "AÑADIR ARTÍCULOS"
        '
        'txtTipoRedondeo
        '
        Me.txtTipoRedondeo.EditValue = "Ninguno"
        Me.txtTipoRedondeo.Location = New System.Drawing.Point(203, 75)
        Me.txtTipoRedondeo.Name = "txtTipoRedondeo"
        Me.txtTipoRedondeo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTipoRedondeo.Properties.Items.AddRange(New Object() {"Ninguno", "0.00 / 0.50", "0.00 / 0.05", "0.90 anterior"})
        Me.txtTipoRedondeo.Properties.ReadOnly = True
        Me.txtTipoRedondeo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtTipoRedondeo.Size = New System.Drawing.Size(89, 20)
        ToolTipTitleItem1.Appearance.Image = Global.AydaraTPV.My.Resources.Resources.menu_fondos
        ToolTipTitleItem1.Appearance.Options.UseImage = True
        ToolTipTitleItem1.Image = Global.AydaraTPV.My.Resources.Resources.menu_fondos
        ToolTipTitleItem1.Text = "Tipo de redondeo que se " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "aplicará al el precio calculado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = resources.GetString("ToolTipItem1.Text")
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.txtTipoRedondeo.SuperTip = SuperToolTip1
        Me.txtTipoRedondeo.TabIndex = 22
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(124, 78)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl5.TabIndex = 21
        Me.LabelControl5.Text = "Tipo redondeo:"
        '
        'bttImportarArticulos
        '
        Me.bttImportarArticulos.Location = New System.Drawing.Point(298, 74)
        Me.bttImportarArticulos.Name = "bttImportarArticulos"
        Me.bttImportarArticulos.Size = New System.Drawing.Size(70, 23)
        Me.bttImportarArticulos.TabIndex = 20
        Me.bttImportarArticulos.Text = "Importar"
        '
        'txtDescuento
        '
        Me.txtDescuento.EditValue = "0"
        Me.txtDescuento.EnterMoveNextControl = True
        Me.txtDescuento.Location = New System.Drawing.Point(63, 75)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDescuento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDescuento.Properties.Mask.EditMask = "P"
        Me.txtDescuento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDescuento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDescuento.Properties.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(55, 20)
        Me.txtDescuento.TabIndex = 19
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(5, 78)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl1.TabIndex = 18
        Me.LabelControl1.Text = "% Dto.:"
        '
        'txtDescripcionSubfamilia
        '
        Me.txtDescripcionSubfamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionSubfamilia.EnterMoveNextControl = True
        Me.txtDescripcionSubfamilia.Location = New System.Drawing.Point(117, 49)
        Me.txtDescripcionSubfamilia.Name = "txtDescripcionSubfamilia"
        Me.txtDescripcionSubfamilia.Properties.MaxLength = 50
        Me.txtDescripcionSubfamilia.Properties.ReadOnly = True
        Me.txtDescripcionSubfamilia.Size = New System.Drawing.Size(251, 20)
        Me.txtDescripcionSubfamilia.TabIndex = 14
        Me.txtDescripcionSubfamilia.TabStop = False
        '
        'txtDescripcionFamilia
        '
        Me.txtDescripcionFamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionFamilia.EnterMoveNextControl = True
        Me.txtDescripcionFamilia.Location = New System.Drawing.Point(117, 23)
        Me.txtDescripcionFamilia.Name = "txtDescripcionFamilia"
        Me.txtDescripcionFamilia.Properties.MaxLength = 50
        Me.txtDescripcionFamilia.Properties.ReadOnly = True
        Me.txtDescripcionFamilia.Size = New System.Drawing.Size(251, 20)
        Me.txtDescripcionFamilia.TabIndex = 12
        Me.txtDescripcionFamilia.TabStop = False
        '
        'txtCodigoSubfamilia
        '
        Me.txtCodigoSubfamilia.EnterMoveNextControl = True
        Me.txtCodigoSubfamilia.Location = New System.Drawing.Point(63, 49)
        Me.txtCodigoSubfamilia.Name = "txtCodigoSubfamilia"
        Me.txtCodigoSubfamilia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, False)})
        Me.txtCodigoSubfamilia.Properties.ReadOnly = True
        Me.txtCodigoSubfamilia.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoSubfamilia.TabIndex = 15
        '
        'txtCodigoFamilia
        '
        Me.txtCodigoFamilia.EnterMoveNextControl = True
        Me.txtCodigoFamilia.Location = New System.Drawing.Point(63, 23)
        Me.txtCodigoFamilia.Name = "txtCodigoFamilia"
        Me.txtCodigoFamilia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoFamilia.Properties.ReadOnly = True
        Me.txtCodigoFamilia.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoFamilia.TabIndex = 13
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 26)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "Familia:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(5, 52)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Subfamilia:"
        '
        'panelDetalle
        '
        Me.panelDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelDetalle.Controls.Add(Me.dgPromociones)
        Me.panelDetalle.Controls.Add(Me.NavLineas)
        Me.panelDetalle.Location = New System.Drawing.Point(12, 120)
        Me.panelDetalle.Name = "panelDetalle"
        Me.panelDetalle.Size = New System.Drawing.Size(800, 459)
        Me.panelDetalle.TabIndex = 107
        Me.panelDetalle.Text = "ARTÍCULOS PROMOCIÓN"
        '
        'NavLineas
        '
        Me.NavLineas.Buttons.Append.Enabled = False
        Me.NavLineas.Buttons.CancelEdit.Visible = False
        Me.NavLineas.Buttons.EndEdit.Visible = False
        Me.NavLineas.Buttons.Remove.Enabled = False
        Me.NavLineas.DataSource = Me.PROMOCIONESBindingSource
        Me.NavLineas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavLineas.Location = New System.Drawing.Point(2, 438)
        Me.NavLineas.Name = "NavLineas"
        Me.NavLineas.Size = New System.Drawing.Size(796, 19)
        Me.NavLineas.TabIndex = 106
        Me.NavLineas.Text = "Artículos"
        '
        'bttImprimirEtiquetas
        '
        Me.bttImprimirEtiquetas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttImprimirEtiquetas.Enabled = False
        Me.bttImprimirEtiquetas.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttImprimirEtiquetas.Location = New System.Drawing.Point(460, 585)
        Me.bttImprimirEtiquetas.Name = "bttImprimirEtiquetas"
        Me.bttImprimirEtiquetas.Size = New System.Drawing.Size(125, 45)
        Me.bttImprimirEtiquetas.TabIndex = 111
        Me.bttImprimirEtiquetas.Text = "Imprimir etiquetas"
        '
        'bttImprimirPromocion
        '
        Me.bttImprimirPromocion.Enabled = False
        Me.bttImprimirPromocion.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttImprimirPromocion.Location = New System.Drawing.Point(14, 84)
        Me.bttImprimirPromocion.Name = "bttImprimirPromocion"
        Me.bttImprimirPromocion.Size = New System.Drawing.Size(125, 31)
        Me.bttImprimirPromocion.TabIndex = 112
        Me.bttImprimirPromocion.Text = "Imprimir promoción"
        '
        'Promociones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 642)
        Me.Controls.Add(Me.bttImprimirPromocion)
        Me.Controls.Add(Me.bttImprimirEtiquetas)
        Me.Controls.Add(Me.panelDetalle)
        Me.Controls.Add(Me.panelImportarArticulos)
        Me.Controls.Add(Me.panelFechas)
        Me.Controls.Add(Me.bttBuscar)
        Me.Controls.Add(Me.bttModificar)
        Me.Controls.Add(Me.bttNuevo)
        Me.Controls.Add(Me.bttGuardar)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttEliminar)
        Me.KeyPreview = True
        Me.Name = "Promociones"
        Me.Text = "Promociones"
        CType(Me.PROMOCIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPromociones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFinal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TALLASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelFechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelFechas.ResumeLayout(False)
        Me.panelFechas.PerformLayout()
        CType(Me.dgPromociones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPromociones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTallas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttArticuloRegalo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelImportarArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImportarArticulos.ResumeLayout(False)
        Me.panelImportarArticulos.PerformLayout()
        CType(Me.txtTipoRedondeo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionSubfamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoSubfamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDetalle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents panelFechas As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DsPromociones As AydaraTPV.dsPromociones
    Friend WithEvents PROMOCIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROMOCIONESTableAdapter As AydaraTPV.dsPromocionesTableAdapters.PROMOCIONESTableAdapter
    Friend WithEvents COLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COLORESTableAdapter As AydaraTPV.dsPromocionesTableAdapters.COLORESTableAdapter
    Friend WithEvents TALLASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgPromociones As DevExpress.XtraGrid.GridControl
    Friend WithEvents bttCodigoArticulo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cmbColores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbTallas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bttArticuloRegalo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents maskPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents maskCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents panelImportarArticulos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcionSubfamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcionFamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoSubfamilia As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCodigoFamilia As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttImportarArticulos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panelDetalle As DevExpress.XtraEditors.GroupControl
    Friend WithEvents NavLineas As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents txtTipoRedondeo As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gvPromociones As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colId As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoTienda As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFechaInicio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFechaFinal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcionArticulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoTalla As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecioTarifa As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecioPromocion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoArticuloRegalo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcionArticuloRegalo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFraccionSinCargo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUnidadesSinCargo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcionColor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcionTalla As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gbColor As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gbTalla As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colPrecioArticuloRegalo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bttImprimirEtiquetas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttImprimirPromocion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colUnidades As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
