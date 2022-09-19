<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DameColorTalla
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colArticulo_Id = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.layoutViewField_colArticulo_Id = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.colCodigoColor = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.PanelColor = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.layoutViewField_LayoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.colDescripcionColor = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.cmbDescripcionColores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.COLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New AydaraTPV.dsArticulos
        Me.layoutViewField_LayoutViewColumn1_1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.colColor_Id = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.cmbColores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.layoutViewField_colColor_Id = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.bttPaginaAnteriorFamilias = New DevExpress.XtraEditors.DataNavigator
        Me.ARTICULOSCOLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.dgColores = New DevExpress.XtraGrid.GridControl
        Me.lvColores = New DevExpress.XtraGrid.Views.Layout.LayoutView
        Me.colId = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.layoutViewField_colId = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.LayoutViewCard2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard
        Me.bttPaginaSiguienteFamilias = New DevExpress.XtraEditors.DataNavigator
        Me.ARTICULOS_COLORESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.ARTICULOS_COLORESTableAdapter
        Me.COLORESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter
        Me.lblTallas = New DevExpress.XtraEditors.LabelControl
        Me.dgTallas = New DevExpress.XtraGrid.GridControl
        Me.TALLASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lvTallas = New DevExpress.XtraGrid.Views.Layout.LayoutView
        Me.colCodigoTalla = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.layoutViewField_colCodigoTalla = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.colDescripcionTalla = New DevExpress.XtraGrid.Columns.LayoutViewColumn
        Me.layoutViewField_colDescripcionTalla = New DevExpress.XtraGrid.Views.Layout.LayoutViewField
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.PanelColores = New DevExpress.XtraEditors.PanelControl
        Me.PanelTallas = New DevExpress.XtraEditors.PanelControl
        Me.TALLASTableAdapter = New AydaraTPV.dsArticulosTableAdapters.TALLASTableAdapter
        CType(Me.layoutViewField_colArticulo_Id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDescripcionColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colColor_Id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOSCOLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTallas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TALLASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvTallas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colCodigoTalla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colDescripcionTalla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelColores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelColores.SuspendLayout()
        CType(Me.PanelTallas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTallas.SuspendLayout()
        Me.SuspendLayout()
        '
        'colArticulo_Id
        '
        Me.colArticulo_Id.FieldName = "Articulo_Id"
        Me.colArticulo_Id.LayoutViewField = Me.layoutViewField_colArticulo_Id
        Me.colArticulo_Id.Name = "colArticulo_Id"
        Me.colArticulo_Id.OptionsColumn.AllowFocus = False
        '
        'layoutViewField_colArticulo_Id
        '
        Me.layoutViewField_colArticulo_Id.EditorPreferredWidth = 135
        Me.layoutViewField_colArticulo_Id.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colArticulo_Id.Name = "layoutViewField_colArticulo_Id"
        Me.layoutViewField_colArticulo_Id.Size = New System.Drawing.Size(207, 54)
        Me.layoutViewField_colArticulo_Id.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colArticulo_Id.TextSize = New System.Drawing.Size(56, 20)
        '
        'colCodigoColor
        '
        Me.colCodigoColor.Caption = "Color"
        Me.colCodigoColor.ColumnEdit = Me.PanelColor
        Me.colCodigoColor.FieldName = "Color_Id"
        Me.colCodigoColor.LayoutViewField = Me.layoutViewField_LayoutViewColumn1
        Me.colCodigoColor.Name = "colCodigoColor"
        Me.colCodigoColor.OptionsColumn.AllowFocus = False
        Me.colCodigoColor.OptionsColumn.FixedWidth = True
        '
        'PanelColor
        '
        Me.PanelColor.Name = "PanelColor"
        '
        'layoutViewField_LayoutViewColumn1
        '
        Me.layoutViewField_LayoutViewColumn1.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn1.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn1.Name = "layoutViewField_LayoutViewColumn1"
        Me.layoutViewField_LayoutViewColumn1.Size = New System.Drawing.Size(50, 27)
        Me.layoutViewField_LayoutViewColumn1.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_LayoutViewColumn1.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn1.TextToControlDistance = 0
        Me.layoutViewField_LayoutViewColumn1.TextVisible = False
        '
        'colDescripcionColor
        '
        Me.colDescripcionColor.ColumnEdit = Me.cmbDescripcionColores
        Me.colDescripcionColor.FieldName = "Color_Id"
        Me.colDescripcionColor.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_1
        Me.colDescripcionColor.Name = "colDescripcionColor"
        '
        'cmbDescripcionColores
        '
        Me.cmbDescripcionColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDescripcionColores.DataSource = Me.COLORESBindingSource
        Me.cmbDescripcionColores.DisplayMember = "Descripcion"
        Me.cmbDescripcionColores.Name = "cmbDescripcionColores"
        Me.cmbDescripcionColores.ValueMember = "CodigoColor"
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
        'layoutViewField_LayoutViewColumn1_1
        '
        Me.layoutViewField_LayoutViewColumn1_1.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn1_1.Location = New System.Drawing.Point(0, 27)
        Me.layoutViewField_LayoutViewColumn1_1.Name = "layoutViewField_LayoutViewColumn1_1"
        Me.layoutViewField_LayoutViewColumn1_1.Size = New System.Drawing.Size(50, 27)
        Me.layoutViewField_LayoutViewColumn1_1.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_LayoutViewColumn1_1.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn1_1.TextToControlDistance = 0
        Me.layoutViewField_LayoutViewColumn1_1.TextVisible = False
        '
        'colColor_Id
        '
        Me.colColor_Id.ColumnEdit = Me.cmbColores
        Me.colColor_Id.FieldName = "Color_Id"
        Me.colColor_Id.LayoutViewField = Me.layoutViewField_colColor_Id
        Me.colColor_Id.Name = "colColor_Id"
        Me.colColor_Id.OptionsColumn.AllowFocus = False
        Me.colColor_Id.OptionsColumn.FixedWidth = True
        '
        'cmbColores
        '
        Me.cmbColores.AutoHeight = False
        Me.cmbColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbColores.DataSource = Me.COLORESBindingSource
        Me.cmbColores.DisplayMember = "Color"
        Me.cmbColores.Name = "cmbColores"
        Me.cmbColores.NullText = "0"
        Me.cmbColores.ValueMember = "CodigoColor"
        '
        'layoutViewField_colColor_Id
        '
        Me.layoutViewField_colColor_Id.EditorPreferredWidth = 90
        Me.layoutViewField_colColor_Id.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colColor_Id.Name = "layoutViewField_colColor_Id"
        Me.layoutViewField_colColor_Id.Size = New System.Drawing.Size(101, 27)
        Me.layoutViewField_colColor_Id.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colColor_Id.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colColor_Id.TextToControlDistance = 0
        Me.layoutViewField_colColor_Id.TextVisible = False
        '
        'bttPaginaAnteriorFamilias
        '
        Me.bttPaginaAnteriorFamilias.Buttons.Append.Visible = False
        Me.bttPaginaAnteriorFamilias.Buttons.CancelEdit.Visible = False
        Me.bttPaginaAnteriorFamilias.Buttons.EndEdit.Visible = False
        Me.bttPaginaAnteriorFamilias.Buttons.First.Visible = False
        Me.bttPaginaAnteriorFamilias.Buttons.Last.Visible = False
        Me.bttPaginaAnteriorFamilias.Buttons.Next.Visible = False
        Me.bttPaginaAnteriorFamilias.Buttons.NextPage.Visible = False
        Me.bttPaginaAnteriorFamilias.Buttons.Prev.Visible = False
        Me.bttPaginaAnteriorFamilias.Buttons.Remove.Visible = False
        Me.bttPaginaAnteriorFamilias.DataSource = Me.ARTICULOSCOLORESBindingSource
        Me.bttPaginaAnteriorFamilias.Location = New System.Drawing.Point(1, 0)
        Me.bttPaginaAnteriorFamilias.Name = "bttPaginaAnteriorFamilias"
        Me.bttPaginaAnteriorFamilias.Size = New System.Drawing.Size(74, 32)
        Me.bttPaginaAnteriorFamilias.TabIndex = 26
        Me.bttPaginaAnteriorFamilias.Text = "Página Anterior"
        '
        'ARTICULOSCOLORESBindingSource
        '
        Me.ARTICULOSCOLORESBindingSource.DataMember = "ARTICULOS_COLORES"
        Me.ARTICULOSCOLORESBindingSource.DataSource = Me.DsArticulos
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.Options.UseBackColor = True
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl7.Location = New System.Drawing.Point(2, 0)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(598, 32)
        Me.LabelControl7.TabIndex = 25
        Me.LabelControl7.Text = "COLORES"
        '
        'dgColores
        '
        Me.dgColores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgColores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgColores.DataSource = Me.ARTICULOSCOLORESBindingSource
        Me.dgColores.Location = New System.Drawing.Point(1, 31)
        Me.dgColores.MainView = Me.lvColores
        Me.dgColores.Name = "dgColores"
        Me.dgColores.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbColores, Me.cmbDescripcionColores, Me.PanelColor})
        Me.dgColores.Size = New System.Drawing.Size(599, 159)
        Me.dgColores.TabIndex = 24
        Me.dgColores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.lvColores})
        '
        'lvColores
        '
        Me.lvColores.ActiveFilterEnabled = False
        Me.lvColores.CardHorzInterval = 0
        Me.lvColores.CardMinSize = New System.Drawing.Size(90, 70)
        Me.lvColores.CardVertInterval = 0
        Me.lvColores.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colId, Me.colArticulo_Id, Me.colColor_Id, Me.colCodigoColor, Me.colDescripcionColor})
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colArticulo_Id
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "1"
        Me.lvColores.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.lvColores.GridControl = Me.dgColores
        Me.lvColores.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colId, Me.layoutViewField_colArticulo_Id, Me.layoutViewField_colColor_Id})
        Me.lvColores.Name = "lvColores"
        Me.lvColores.OptionsBehavior.AllowExpandCollapse = False
        Me.lvColores.OptionsBehavior.Editable = False
        Me.lvColores.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.lvColores.OptionsCustomization.AllowFilter = False
        Me.lvColores.OptionsCustomization.AllowSort = False
        Me.lvColores.OptionsPrint.PrintCardCaption = False
        Me.lvColores.OptionsView.PartialCardWrapThreshold = 0
        Me.lvColores.OptionsView.ShowCardCaption = False
        Me.lvColores.OptionsView.ShowCardExpandButton = False
        Me.lvColores.OptionsView.ShowHeaderPanel = False
        Me.lvColores.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn
        Me.lvColores.TemplateCard = Me.LayoutViewCard2
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.LayoutViewField = Me.layoutViewField_colId
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.AllowFocus = False
        Me.colId.OptionsColumn.ReadOnly = True
        '
        'layoutViewField_colId
        '
        Me.layoutViewField_colId.EditorPreferredWidth = 135
        Me.layoutViewField_colId.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colId.Name = "layoutViewField_colId"
        Me.layoutViewField_colId.Size = New System.Drawing.Size(207, 27)
        Me.layoutViewField_colId.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colId.TextSize = New System.Drawing.Size(56, 20)
        '
        'LayoutViewCard2
        '
        Me.LayoutViewCard2.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard2.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard2.GroupBordersVisible = False
        Me.LayoutViewCard2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn1, Me.layoutViewField_LayoutViewColumn1_1})
        Me.LayoutViewCard2.Name = "LayoutViewCard2"
        Me.LayoutViewCard2.Text = "TemplateCard"
        Me.LayoutViewCard2.TextVisible = False
        '
        'bttPaginaSiguienteFamilias
        '
        Me.bttPaginaSiguienteFamilias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttPaginaSiguienteFamilias.Buttons.Append.Visible = False
        Me.bttPaginaSiguienteFamilias.Buttons.CancelEdit.Visible = False
        Me.bttPaginaSiguienteFamilias.Buttons.EndEdit.Visible = False
        Me.bttPaginaSiguienteFamilias.Buttons.First.Visible = False
        Me.bttPaginaSiguienteFamilias.Buttons.Last.Visible = False
        Me.bttPaginaSiguienteFamilias.Buttons.Next.Visible = False
        Me.bttPaginaSiguienteFamilias.Buttons.Prev.Visible = False
        Me.bttPaginaSiguienteFamilias.Buttons.PrevPage.Visible = False
        Me.bttPaginaSiguienteFamilias.Buttons.Remove.Visible = False
        Me.bttPaginaSiguienteFamilias.DataSource = Me.ARTICULOSCOLORESBindingSource
        Me.bttPaginaSiguienteFamilias.Location = New System.Drawing.Point(526, 0)
        Me.bttPaginaSiguienteFamilias.Name = "bttPaginaSiguienteFamilias"
        Me.bttPaginaSiguienteFamilias.Size = New System.Drawing.Size(74, 32)
        Me.bttPaginaSiguienteFamilias.TabIndex = 27
        Me.bttPaginaSiguienteFamilias.Text = "Página Siguiente"
        '
        'ARTICULOS_COLORESTableAdapter
        '
        Me.ARTICULOS_COLORESTableAdapter.ClearBeforeFill = True
        '
        'COLORESTableAdapter
        '
        Me.COLORESTableAdapter.ClearBeforeFill = True
        '
        'lblTallas
        '
        Me.lblTallas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTallas.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallas.Appearance.Options.UseFont = True
        Me.lblTallas.Appearance.Options.UseTextOptions = True
        Me.lblTallas.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblTallas.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTallas.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lblTallas.Location = New System.Drawing.Point(0, 0)
        Me.lblTallas.Name = "lblTallas"
        Me.lblTallas.Size = New System.Drawing.Size(600, 31)
        Me.lblTallas.TabIndex = 29
        Me.lblTallas.Text = "TALLAS"
        '
        'dgTallas
        '
        Me.dgTallas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTallas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgTallas.DataSource = Me.TALLASBindingSource
        Me.dgTallas.Location = New System.Drawing.Point(0, 31)
        Me.dgTallas.MainView = Me.lvTallas
        Me.dgTallas.Name = "dgTallas"
        Me.dgTallas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.dgTallas.Size = New System.Drawing.Size(600, 189)
        Me.dgTallas.TabIndex = 28
        Me.dgTallas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.lvTallas})
        '
        'TALLASBindingSource
        '
        Me.TALLASBindingSource.DataMember = "TALLAS"
        Me.TALLASBindingSource.DataSource = Me.DsArticulos
        '
        'lvTallas
        '
        Me.lvTallas.ActiveFilterEnabled = False
        Me.lvTallas.CardHorzInterval = 0
        Me.lvTallas.CardMinSize = New System.Drawing.Size(85, 50)
        Me.lvTallas.CardVertInterval = 0
        Me.lvTallas.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colCodigoTalla, Me.colDescripcionTalla})
        Me.lvTallas.GridControl = Me.dgTallas
        Me.lvTallas.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colCodigoTalla})
        Me.lvTallas.Name = "lvTallas"
        Me.lvTallas.OptionsBehavior.AllowExpandCollapse = False
        Me.lvTallas.OptionsBehavior.Editable = False
        Me.lvTallas.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.lvTallas.OptionsCustomization.AllowFilter = False
        Me.lvTallas.OptionsCustomization.AllowSort = False
        Me.lvTallas.OptionsPrint.PrintCardCaption = False
        Me.lvTallas.OptionsView.PartialCardWrapThreshold = 0
        Me.lvTallas.OptionsView.ShowCardBorderIfCaptionHidden = False
        Me.lvTallas.OptionsView.ShowCardCaption = False
        Me.lvTallas.OptionsView.ShowCardExpandButton = False
        Me.lvTallas.OptionsView.ShowHeaderPanel = False
        Me.lvTallas.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn
        Me.lvTallas.TemplateCard = Me.LayoutViewCard1
        '
        'colCodigoTalla
        '
        Me.colCodigoTalla.FieldName = "CodigoTalla"
        Me.colCodigoTalla.LayoutViewField = Me.layoutViewField_colCodigoTalla
        Me.colCodigoTalla.Name = "colCodigoTalla"
        Me.colCodigoTalla.OptionsColumn.AllowFocus = False
        '
        'layoutViewField_colCodigoTalla
        '
        Me.layoutViewField_colCodigoTalla.EditorPreferredWidth = 106
        Me.layoutViewField_colCodigoTalla.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colCodigoTalla.Name = "layoutViewField_colCodigoTalla"
        Me.layoutViewField_colCodigoTalla.Size = New System.Drawing.Size(60, 20)
        Me.layoutViewField_colCodigoTalla.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colCodigoTalla.TextSize = New System.Drawing.Size(85, 20)
        '
        'colDescripcionTalla
        '
        Me.colDescripcionTalla.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDescripcionTalla.AppearanceCell.Options.UseFont = True
        Me.colDescripcionTalla.AppearanceCell.Options.UseTextOptions = True
        Me.colDescripcionTalla.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDescripcionTalla.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colDescripcionTalla.FieldName = "Descripcion"
        Me.colDescripcionTalla.LayoutViewField = Me.layoutViewField_colDescripcionTalla
        Me.colDescripcionTalla.Name = "colDescripcionTalla"
        Me.colDescripcionTalla.OptionsColumn.AllowEdit = False
        Me.colDescripcionTalla.OptionsColumn.FixedWidth = True
        Me.colDescripcionTalla.OptionsColumn.ShowCaption = False
        '
        'layoutViewField_colDescripcionTalla
        '
        Me.layoutViewField_colDescripcionTalla.EditorPreferredWidth = 0
        Me.layoutViewField_colDescripcionTalla.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colDescripcionTalla.Name = "layoutViewField_colDescripcionTalla"
        Me.layoutViewField_colDescripcionTalla.Size = New System.Drawing.Size(50, 27)
        Me.layoutViewField_colDescripcionTalla.TextLocation = DevExpress.Utils.Locations.Left
        Me.layoutViewField_colDescripcionTalla.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colDescripcionTalla.TextToControlDistance = 0
        Me.layoutViewField_colDescripcionTalla.TextVisible = False
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.GroupBordersVisible = False
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colDescripcionTalla})
        Me.LayoutViewCard1.Name = "LayoutViewCard2"
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.COLORESBindingSource
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Color"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "CodigoColor"
        '
        'PanelColores
        '
        Me.PanelColores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelColores.Controls.Add(Me.bttPaginaSiguienteFamilias)
        Me.PanelColores.Controls.Add(Me.bttPaginaAnteriorFamilias)
        Me.PanelColores.Controls.Add(Me.dgColores)
        Me.PanelColores.Controls.Add(Me.LabelControl7)
        Me.PanelColores.Location = New System.Drawing.Point(12, 12)
        Me.PanelColores.Name = "PanelColores"
        Me.PanelColores.Size = New System.Drawing.Size(600, 190)
        Me.PanelColores.TabIndex = 32
        '
        'PanelTallas
        '
        Me.PanelTallas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelTallas.Controls.Add(Me.dgTallas)
        Me.PanelTallas.Controls.Add(Me.lblTallas)
        Me.PanelTallas.Location = New System.Drawing.Point(12, 210)
        Me.PanelTallas.Name = "PanelTallas"
        Me.PanelTallas.Size = New System.Drawing.Size(600, 220)
        Me.PanelTallas.TabIndex = 33
        '
        'TALLASTableAdapter
        '
        Me.TALLASTableAdapter.ClearBeforeFill = True
        '
        'DameColorTalla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelTallas)
        Me.Controls.Add(Me.PanelColores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "DameColorTalla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Color - Talla"
        CType(Me.layoutViewField_colArticulo_Id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDescripcionColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colColor_Id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOSCOLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTallas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TALLASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvTallas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colCodigoTalla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colDescripcionTalla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelColores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelColores.ResumeLayout(False)
        CType(Me.PanelTallas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTallas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttPaginaAnteriorFamilias As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dgColores As DevExpress.XtraGrid.GridControl
    Friend WithEvents lvColores As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents LayoutViewCard2 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents bttPaginaSiguienteFamilias As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents DsArticulos As AydaraTPV.dsArticulos
    Friend WithEvents ARTICULOSCOLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARTICULOS_COLORESTableAdapter As AydaraTPV.dsArticulosTableAdapters.ARTICULOS_COLORESTableAdapter
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colId As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents colArticulo_Id As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colArticulo_Id As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents colColor_Id As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colColor_Id As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents cmbColores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents COLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COLORESTableAdapter As AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter
    Friend WithEvents lblTallas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dgTallas As DevExpress.XtraGrid.GridControl
    Friend WithEvents lvTallas As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents PanelColores As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelTallas As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colCodigoColor As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents cmbDescripcionColores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCodigoTalla As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colCodigoTalla As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents colDescripcionTalla As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colDescripcionTalla As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents colDescripcionColor As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_LayoutViewColumn1_1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents PanelColor As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents TALLASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TALLASTableAdapter As AydaraTPV.dsArticulosTableAdapters.TALLASTableAdapter
End Class
