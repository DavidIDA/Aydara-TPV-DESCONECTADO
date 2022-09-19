<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TarifasEHLIS
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
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colVariacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.dgTarifas = New DevExpress.XtraGrid.GridControl
        Me.TarifasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEHLIS = New AydaraTPV.dsEHLIS
        Me.gvTarifas = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colFamilia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colReferencia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCodigo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colEAN = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colPrecioCoste = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPrecioCoste_Actual = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colPvpRecomendado = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPVR_Actual = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.bttActualizar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtIncrementoventa = New DevExpress.XtraEditors.TextEdit
        Me.checkActualizarVenta = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtIncrementoCoste = New DevExpress.XtraEditors.TextEdit
        Me.checkActualizarCostes = New DevExpress.XtraEditors.CheckEdit
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.txtNombreProveedor = New DevExpress.XtraEditors.TextEdit
        Me.txtCodigoProveedor = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.checkEtiquetas = New DevExpress.XtraEditors.CheckEdit
        Me.checkCodigosBarras = New DevExpress.XtraEditors.CheckEdit
        Me.checkReferenciados = New DevExpress.XtraEditors.CheckEdit
        CType(Me.dgTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TarifasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEHLIS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtIncrementoventa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkActualizarVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIncrementoCoste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkActualizarCostes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkEtiquetas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkCodigosBarras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkReferenciados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colVariacion
        '
        Me.colVariacion.Caption = "Variación"
        Me.colVariacion.FieldName = "Variacion"
        Me.colVariacion.Name = "colVariacion"
        '
        'dgTarifas
        '
        Me.dgTarifas.DataSource = Me.TarifasBindingSource
        Me.dgTarifas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTarifas.Location = New System.Drawing.Point(0, 67)
        Me.dgTarifas.MainView = Me.gvTarifas
        Me.dgTarifas.Name = "dgTarifas"
        Me.dgTarifas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskImporte})
        Me.dgTarifas.Size = New System.Drawing.Size(784, 413)
        Me.dgTarifas.TabIndex = 1
        Me.dgTarifas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTarifas})
        '
        'TarifasBindingSource
        '
        Me.TarifasBindingSource.DataMember = "Tarifas"
        Me.TarifasBindingSource.DataSource = Me.DsEHLIS
        Me.TarifasBindingSource.Sort = "Familia, Descripcion"
        '
        'DsEHLIS
        '
        Me.DsEHLIS.DataSetName = "dsEHLIS"
        Me.DsEHLIS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvTarifas
        '
        Me.gvTarifas.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand2, Me.GridBand3})
        Me.gvTarifas.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colFamilia, Me.colReferencia, Me.colCodigo, Me.colDescripcion, Me.colPrecioCoste, Me.colPvpRecomendado, Me.colEAN, Me.colPrecioCoste_Actual, Me.colPVR_Actual, Me.colVariacion})
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.colVariacion
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = 1
        StyleFormatCondition4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition4.Appearance.Options.UseBackColor = True
        StyleFormatCondition4.ApplyToRow = True
        StyleFormatCondition4.Column = Me.colVariacion
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition4.Value1 = 2
        Me.gvTarifas.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3, StyleFormatCondition4})
        Me.gvTarifas.GridControl = Me.dgTarifas
        Me.gvTarifas.Name = "gvTarifas"
        Me.gvTarifas.OptionsBehavior.Editable = False
        Me.gvTarifas.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvTarifas.OptionsDetail.ShowDetailTabs = False
        Me.gvTarifas.OptionsMenu.EnableColumnMenu = False
        Me.gvTarifas.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvTarifas.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvTarifas.OptionsView.EnableAppearanceEvenRow = True
        Me.gvTarifas.OptionsView.ShowAutoFilterRow = True
        Me.gvTarifas.OptionsView.ShowDetailButtons = False
        Me.gvTarifas.OptionsView.ShowFooter = True
        Me.gvTarifas.OptionsView.ShowGroupPanel = False
        Me.gvTarifas.ViewCaption = "Tickets por día"
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Datos artículo"
        Me.GridBand1.Columns.Add(Me.colFamilia)
        Me.GridBand1.Columns.Add(Me.colReferencia)
        Me.GridBand1.Columns.Add(Me.colCodigo)
        Me.GridBand1.Columns.Add(Me.colDescripcion)
        Me.GridBand1.Columns.Add(Me.colEAN)
        Me.GridBand1.Columns.Add(Me.colVariacion)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 713
        '
        'colFamilia
        '
        Me.colFamilia.Caption = "Familia"
        Me.colFamilia.FieldName = "Familia"
        Me.colFamilia.Name = "colFamilia"
        Me.colFamilia.Visible = True
        '
        'colReferencia
        '
        Me.colReferencia.FieldName = "Referencia"
        Me.colReferencia.Name = "colReferencia"
        Me.colReferencia.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.colReferencia.Visible = True
        Me.colReferencia.Width = 128
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.Width = 316
        '
        'colEAN
        '
        Me.colEAN.Caption = "Código EAN"
        Me.colEAN.FieldName = "EAN"
        Me.colEAN.Name = "colEAN"
        Me.colEAN.Visible = True
        Me.colEAN.Width = 119
        '
        'GridBand2
        '
        Me.GridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand2.Caption = "Precios coste"
        Me.GridBand2.Columns.Add(Me.colPrecioCoste)
        Me.GridBand2.Columns.Add(Me.colPrecioCoste_Actual)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 166
        '
        'colPrecioCoste
        '
        Me.colPrecioCoste.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrecioCoste.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrecioCoste.Caption = "Tarifa"
        Me.colPrecioCoste.DisplayFormat.FormatString = "{0:c3}"
        Me.colPrecioCoste.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecioCoste.FieldName = "PrecioCoste"
        Me.colPrecioCoste.Name = "colPrecioCoste"
        Me.colPrecioCoste.Visible = True
        Me.colPrecioCoste.Width = 91
        '
        'colPrecioCoste_Actual
        '
        Me.colPrecioCoste_Actual.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrecioCoste_Actual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrecioCoste_Actual.Caption = "Actual"
        Me.colPrecioCoste_Actual.DisplayFormat.FormatString = "{0:c3}"
        Me.colPrecioCoste_Actual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecioCoste_Actual.FieldName = "PrecioCoste_Actual"
        Me.colPrecioCoste_Actual.Name = "colPrecioCoste_Actual"
        Me.colPrecioCoste_Actual.Visible = True
        '
        'GridBand3
        '
        Me.GridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand3.Caption = "P.V.R."
        Me.GridBand3.Columns.Add(Me.colPvpRecomendado)
        Me.GridBand3.Columns.Add(Me.colPVR_Actual)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 184
        '
        'colPvpRecomendado
        '
        Me.colPvpRecomendado.AppearanceHeader.Options.UseTextOptions = True
        Me.colPvpRecomendado.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPvpRecomendado.Caption = "Tarifa"
        Me.colPvpRecomendado.DisplayFormat.FormatString = "{0:c3}"
        Me.colPvpRecomendado.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPvpRecomendado.FieldName = "PVR"
        Me.colPvpRecomendado.Name = "colPvpRecomendado"
        Me.colPvpRecomendado.Visible = True
        Me.colPvpRecomendado.Width = 109
        '
        'colPVR_Actual
        '
        Me.colPVR_Actual.AppearanceHeader.Options.UseTextOptions = True
        Me.colPVR_Actual.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPVR_Actual.Caption = "Actual"
        Me.colPVR_Actual.DisplayFormat.FormatString = "{0:c3}"
        Me.colPVR_Actual.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPVR_Actual.FieldName = "PVR_Actual"
        Me.colPVR_Actual.Name = "colPVR_Actual"
        Me.colPVR_Actual.Visible = True
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.checkReferenciados)
        Me.GroupControl1.Controls.Add(Me.checkCodigosBarras)
        Me.GroupControl1.Controls.Add(Me.checkEtiquetas)
        Me.GroupControl1.Controls.Add(Me.bttActualizar)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtIncrementoventa)
        Me.GroupControl1.Controls.Add(Me.checkActualizarVenta)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.txtIncrementoCoste)
        Me.GroupControl1.Controls.Add(Me.checkActualizarCostes)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 480)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(784, 82)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Actualización precios"
        '
        'bttActualizar
        '
        Me.bttActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttActualizar.Image = Global.AydaraTPV.My.Resources.Resources.ok_32
        Me.bttActualizar.Location = New System.Drawing.Point(668, 32)
        Me.bttActualizar.Name = "bttActualizar"
        Me.bttActualizar.Size = New System.Drawing.Size(104, 38)
        Me.bttActualizar.TabIndex = 6
        Me.bttActualizar.Text = "Actualizar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(420, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "de incremento"
        '
        'txtIncrementoventa
        '
        Me.txtIncrementoventa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIncrementoventa.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIncrementoventa.Location = New System.Drawing.Point(365, 55)
        Me.txtIncrementoventa.Name = "txtIncrementoventa"
        Me.txtIncrementoventa.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIncrementoventa.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIncrementoventa.Properties.Mask.EditMask = "P2"
        Me.txtIncrementoventa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIncrementoventa.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtIncrementoventa.Size = New System.Drawing.Size(49, 20)
        Me.txtIncrementoventa.TabIndex = 4
        '
        'checkActualizarVenta
        '
        Me.checkActualizarVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkActualizarVenta.Location = New System.Drawing.Point(260, 55)
        Me.checkActualizarVenta.Name = "checkActualizarVenta"
        Me.checkActualizarVenta.Properties.AutoWidth = True
        Me.checkActualizarVenta.Properties.Caption = "Actualizar venta:"
        Me.checkActualizarVenta.Size = New System.Drawing.Size(105, 19)
        Me.checkActualizarVenta.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(420, 33)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "de incremento"
        '
        'txtIncrementoCoste
        '
        Me.txtIncrementoCoste.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIncrementoCoste.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtIncrementoCoste.Location = New System.Drawing.Point(365, 30)
        Me.txtIncrementoCoste.Name = "txtIncrementoCoste"
        Me.txtIncrementoCoste.Properties.Appearance.Options.UseTextOptions = True
        Me.txtIncrementoCoste.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtIncrementoCoste.Properties.Mask.EditMask = "P2"
        Me.txtIncrementoCoste.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtIncrementoCoste.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtIncrementoCoste.Size = New System.Drawing.Size(49, 20)
        Me.txtIncrementoCoste.TabIndex = 1
        '
        'checkActualizarCostes
        '
        Me.checkActualizarCostes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkActualizarCostes.Location = New System.Drawing.Point(260, 30)
        Me.checkActualizarCostes.Name = "checkActualizarCostes"
        Me.checkActualizarCostes.Properties.AutoWidth = True
        Me.checkActualizarCostes.Properties.Caption = "Actualizar coste:"
        Me.checkActualizarCostes.Size = New System.Drawing.Size(103, 19)
        Me.checkActualizarCostes.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.bttBuscar)
        Me.GroupControl2.Controls.Add(Me.txtNombreProveedor)
        Me.GroupControl2.Controls.Add(Me.txtCodigoProveedor)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(784, 67)
        Me.GroupControl2.TabIndex = 0
        Me.GroupControl2.Text = "Actualización precios"
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.find
        Me.bttBuscar.Location = New System.Drawing.Point(697, 27)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(75, 28)
        Me.bttBuscar.TabIndex = 2
        Me.bttBuscar.Text = "Buscar"
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreProveedor.EnterMoveNextControl = True
        Me.txtNombreProveedor.Location = New System.Drawing.Point(185, 31)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Properties.MaxLength = 50
        Me.txtNombreProveedor.Properties.ReadOnly = True
        Me.txtNombreProveedor.Size = New System.Drawing.Size(506, 20)
        Me.txtNombreProveedor.TabIndex = 1
        Me.txtNombreProveedor.TabStop = False
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.EditValue = ""
        Me.txtCodigoProveedor.EnterMoveNextControl = True
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(103, 31)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoProveedor.Properties.DisplayFormat.FormatString = "00000"
        Me.txtCodigoProveedor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoProveedor.Properties.EditFormat.FormatString = "00000"
        Me.txtCodigoProveedor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoProveedor.Properties.ValidateOnEnterKey = True
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(83, 20)
        Me.txtCodigoProveedor.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 34)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Proveedor EHLIS:"
        '
        'checkEtiquetas
        '
        Me.checkEtiquetas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkEtiquetas.Location = New System.Drawing.Point(494, 55)
        Me.checkEtiquetas.Name = "checkEtiquetas"
        Me.checkEtiquetas.Properties.AutoWidth = True
        Me.checkEtiquetas.Properties.Caption = "Genera etiquetas"
        Me.checkEtiquetas.Size = New System.Drawing.Size(106, 19)
        Me.checkEtiquetas.TabIndex = 7
        '
        'checkCodigosBarras
        '
        Me.checkCodigosBarras.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkCodigosBarras.Location = New System.Drawing.Point(494, 30)
        Me.checkCodigosBarras.Name = "checkCodigosBarras"
        Me.checkCodigosBarras.Properties.AutoWidth = True
        Me.checkCodigosBarras.Properties.Caption = "Añadir códigios de barras"
        Me.checkCodigosBarras.Size = New System.Drawing.Size(144, 19)
        Me.checkCodigosBarras.TabIndex = 8
        '
        'checkReferenciados
        '
        Me.checkReferenciados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.checkReferenciados.Location = New System.Drawing.Point(12, 41)
        Me.checkReferenciados.Name = "checkReferenciados"
        Me.checkReferenciados.Properties.AutoWidth = True
        Me.checkReferenciados.Properties.Caption = "Ver sólo artículos referenciados"
        Me.checkReferenciados.Size = New System.Drawing.Size(173, 19)
        Me.checkReferenciados.TabIndex = 9
        '
        'TarifasEHLIS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgTarifas)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "TarifasEHLIS"
        Me.Text = "Tarifa EHLIS"
        CType(Me.dgTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TarifasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEHLIS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtIncrementoventa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkActualizarVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIncrementoCoste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkActualizarCostes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkEtiquetas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkCodigosBarras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkReferenciados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgTarifas As DevExpress.XtraGrid.GridControl
    Friend WithEvents TarifasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsEHLIS As AydaraTPV.dsEHLIS
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bttActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIncrementoventa As DevExpress.XtraEditors.TextEdit
    Friend WithEvents checkActualizarVenta As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIncrementoCoste As DevExpress.XtraEditors.TextEdit
    Friend WithEvents checkActualizarCostes As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoProveedor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gvTarifas As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colFamilia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colReferencia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecioCoste As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPvpRecomendado As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colEAN As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecioCoste_Actual As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPVR_Actual As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colVariacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents checkCodigosBarras As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkEtiquetas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkReferenciados As DevExpress.XtraEditors.CheckEdit
End Class
