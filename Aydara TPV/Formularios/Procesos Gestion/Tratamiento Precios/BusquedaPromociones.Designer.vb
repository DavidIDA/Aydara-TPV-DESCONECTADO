<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaPromociones
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
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.colFechaFinal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFraccionSinCargo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.dgPromociones = New DevExpress.XtraGrid.GridControl
        Me.FECHASPROMOCIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPromociones = New AydaraTPV.dsPromociones
        Me.gvPromociones = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colFechaInicio = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PROMOCIONESTableAdapter = New AydaraTPV.dsPromocionesTableAdapters.PROMOCIONESTableAdapter
        Me.FECHAS_PROMOCIONESTableAdapter = New AydaraTPV.dsPromocionesTableAdapters.FECHAS_PROMOCIONESTableAdapter
        Me.dgDetallePromocion = New DevExpress.XtraGrid.GridControl
        Me.PROMOCIONESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvDetallePromocion = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcionColor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcionTalla = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrecioTarifa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colPrecioPromocion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colUnidadesSinCargo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoArticuloRegalo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtFechaInicio = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtFechaFinal = New DevExpress.XtraEditors.DateEdit
        Me.bttActalizarFechas = New DevExpress.XtraEditors.SimpleButton
        Me.bttEliminarPromocion = New DevExpress.XtraEditors.SimpleButton
        Me.colUnidades = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.dgPromociones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FECHASPROMOCIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPromociones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPromociones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetallePromocion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROMOCIONESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetallePromocion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colFechaFinal
        '
        Me.colFechaFinal.DisplayFormat.FormatString = "g"
        Me.colFechaFinal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaFinal.FieldName = "FechaFinal"
        Me.colFechaFinal.Name = "colFechaFinal"
        Me.colFechaFinal.Visible = True
        Me.colFechaFinal.VisibleIndex = 1
        '
        'colFraccionSinCargo
        '
        Me.colFraccionSinCargo.Caption = "S.C."
        Me.colFraccionSinCargo.DisplayFormat.FormatString = "0"
        Me.colFraccionSinCargo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFraccionSinCargo.FieldName = "FraccionSinCargo"
        Me.colFraccionSinCargo.Name = "colFraccionSinCargo"
        Me.colFraccionSinCargo.Visible = True
        Me.colFraccionSinCargo.VisibleIndex = 7
        Me.colFraccionSinCargo.Width = 50
        '
        'dgPromociones
        '
        Me.dgPromociones.DataSource = Me.FECHASPROMOCIONESBindingSource
        Me.dgPromociones.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgPromociones.Location = New System.Drawing.Point(0, 0)
        Me.dgPromociones.MainView = Me.gvPromociones
        Me.dgPromociones.Name = "dgPromociones"
        Me.dgPromociones.Size = New System.Drawing.Size(286, 130)
        Me.dgPromociones.TabIndex = 1
        Me.dgPromociones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPromociones})
        '
        'FECHASPROMOCIONESBindingSource
        '
        Me.FECHASPROMOCIONESBindingSource.DataMember = "FECHAS_PROMOCIONES"
        Me.FECHASPROMOCIONESBindingSource.DataSource = Me.DsPromociones
        '
        'DsPromociones
        '
        Me.DsPromociones.DataSetName = "dsPromociones"
        Me.DsPromociones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvPromociones
        '
        Me.gvPromociones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFechaInicio, Me.colFechaFinal})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colFechaFinal
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Less
        Me.gvPromociones.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gvPromociones.GridControl = Me.dgPromociones
        Me.gvPromociones.Name = "gvPromociones"
        Me.gvPromociones.OptionsBehavior.Editable = False
        Me.gvPromociones.OptionsDetail.ShowDetailTabs = False
        Me.gvPromociones.OptionsMenu.EnableColumnMenu = False
        Me.gvPromociones.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvPromociones.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvPromociones.OptionsView.EnableAppearanceEvenRow = True
        Me.gvPromociones.OptionsView.ShowGroupPanel = False
        '
        'colFechaInicio
        '
        Me.colFechaInicio.DisplayFormat.FormatString = "g"
        Me.colFechaInicio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFechaInicio.FieldName = "FechaInicio"
        Me.colFechaInicio.Name = "colFechaInicio"
        Me.colFechaInicio.Visible = True
        Me.colFechaInicio.VisibleIndex = 0
        '
        'PROMOCIONESTableAdapter
        '
        Me.PROMOCIONESTableAdapter.ClearBeforeFill = True
        '
        'FECHAS_PROMOCIONESTableAdapter
        '
        Me.FECHAS_PROMOCIONESTableAdapter.ClearBeforeFill = True
        '
        'dgDetallePromocion
        '
        Me.dgDetallePromocion.DataSource = Me.PROMOCIONESBindingSource
        Me.dgDetallePromocion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetallePromocion.Location = New System.Drawing.Point(0, 0)
        Me.dgDetallePromocion.MainView = Me.gvDetallePromocion
        Me.dgDetallePromocion.Name = "dgDetallePromocion"
        Me.dgDetallePromocion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskPrecio})
        Me.dgDetallePromocion.Size = New System.Drawing.Size(624, 306)
        Me.dgDetallePromocion.TabIndex = 3
        Me.dgDetallePromocion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetallePromocion})
        '
        'PROMOCIONESBindingSource
        '
        Me.PROMOCIONESBindingSource.DataMember = "PROMOCIONES"
        Me.PROMOCIONESBindingSource.DataSource = Me.DsPromociones
        '
        'gvDetallePromocion
        '
        Me.gvDetallePromocion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colCodigoArticulo, Me.colDescripcion, Me.colDescripcionColor, Me.colDescripcionTalla, Me.colPrecioTarifa, Me.colUnidades, Me.colPrecioPromocion, Me.colFraccionSinCargo, Me.colUnidadesSinCargo, Me.colCodigoArticuloRegalo})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.colFraccionSinCargo
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Greater
        StyleFormatCondition2.Value1 = "0"
        Me.gvDetallePromocion.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.gvDetallePromocion.GridControl = Me.dgDetallePromocion
        Me.gvDetallePromocion.Name = "gvDetallePromocion"
        Me.gvDetallePromocion.OptionsBehavior.Editable = False
        Me.gvDetallePromocion.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvDetallePromocion.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvDetallePromocion.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.ReadOnly = True
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.Caption = "Artículo"
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 0
        Me.colCodigoArticulo.Width = 72
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "DescripcionArticulo"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 144
        '
        'colDescripcionColor
        '
        Me.colDescripcionColor.Caption = "Color"
        Me.colDescripcionColor.FieldName = "DescripcionColor"
        Me.colDescripcionColor.Name = "colDescripcionColor"
        Me.colDescripcionColor.Visible = True
        Me.colDescripcionColor.VisibleIndex = 2
        Me.colDescripcionColor.Width = 59
        '
        'colDescripcionTalla
        '
        Me.colDescripcionTalla.Caption = "Talla"
        Me.colDescripcionTalla.FieldName = "DescripcionTalla"
        Me.colDescripcionTalla.Name = "colDescripcionTalla"
        Me.colDescripcionTalla.Visible = True
        Me.colDescripcionTalla.VisibleIndex = 3
        Me.colDescripcionTalla.Width = 59
        '
        'colPrecioTarifa
        '
        Me.colPrecioTarifa.Caption = "P.Tarifa"
        Me.colPrecioTarifa.ColumnEdit = Me.maskPrecio
        Me.colPrecioTarifa.FieldName = "PrecioTarifa"
        Me.colPrecioTarifa.Name = "colPrecioTarifa"
        Me.colPrecioTarifa.Visible = True
        Me.colPrecioTarifa.VisibleIndex = 4
        '
        'maskPrecio
        '
        Me.maskPrecio.AutoHeight = False
        Me.maskPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecio.Name = "maskPrecio"
        '
        'colPrecioPromocion
        '
        Me.colPrecioPromocion.Caption = "P.Promoción"
        Me.colPrecioPromocion.ColumnEdit = Me.maskPrecio
        Me.colPrecioPromocion.FieldName = "PrecioPromocion"
        Me.colPrecioPromocion.Name = "colPrecioPromocion"
        Me.colPrecioPromocion.Visible = True
        Me.colPrecioPromocion.VisibleIndex = 6
        '
        'colUnidadesSinCargo
        '
        Me.colUnidadesSinCargo.FieldName = "UnidadesSinCargo"
        Me.colUnidadesSinCargo.Name = "colUnidadesSinCargo"
        Me.colUnidadesSinCargo.Width = 55
        '
        'colCodigoArticuloRegalo
        '
        Me.colCodigoArticuloRegalo.FieldName = "CodigoArticuloRegalo"
        Me.colCodigoArticuloRegalo.Name = "colCodigoArticuloRegalo"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.GroupControl1)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.dgPromociones)
        Me.SplitContainerControl1.Panel1.MinSize = 130
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.dgDetallePromocion)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(624, 442)
        Me.SplitContainerControl1.SplitterPosition = 130
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtFechaInicio)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtFechaFinal)
        Me.GroupControl1.Controls.Add(Me.bttActalizarFechas)
        Me.GroupControl1.Controls.Add(Me.bttEliminarPromocion)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupControl1.Location = New System.Drawing.Point(295, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(329, 130)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "PROMOCIÓN SELECCIONADA"
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.EditValue = Nothing
        Me.txtFechaInicio.EnterMoveNextControl = True
        Me.txtFechaInicio.Location = New System.Drawing.Point(46, 34)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaInicio.Properties.Mask.EditMask = "g"
        Me.txtFechaInicio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFechaInicio.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFechaInicio.Size = New System.Drawing.Size(111, 20)
        Me.txtFechaInicio.TabIndex = 90
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(6, 37)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl9.TabIndex = 92
        Me.LabelControl9.Text = "Desde:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(163, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl2.TabIndex = 93
        Me.LabelControl2.Text = "hasta:"
        '
        'txtFechaFinal
        '
        Me.txtFechaFinal.EditValue = Nothing
        Me.txtFechaFinal.EnterMoveNextControl = True
        Me.txtFechaFinal.Location = New System.Drawing.Point(200, 34)
        Me.txtFechaFinal.Name = "txtFechaFinal"
        Me.txtFechaFinal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaFinal.Properties.Mask.EditMask = "g"
        Me.txtFechaFinal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFechaFinal.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFechaFinal.Size = New System.Drawing.Size(111, 20)
        Me.txtFechaFinal.TabIndex = 91
        '
        'bttActalizarFechas
        '
        Me.bttActalizarFechas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttActalizarFechas.Image = Global.AydaraTPV.My.Resources.Resources.update
        Me.bttActalizarFechas.Location = New System.Drawing.Point(174, 74)
        Me.bttActalizarFechas.Name = "bttActalizarFechas"
        Me.bttActalizarFechas.Size = New System.Drawing.Size(137, 41)
        Me.bttActalizarFechas.TabIndex = 41
        Me.bttActalizarFechas.TabStop = False
        Me.bttActalizarFechas.Text = "Actualizar fechas"
        '
        'bttEliminarPromocion
        '
        Me.bttEliminarPromocion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttEliminarPromocion.Image = Global.AydaraTPV.My.Resources.Resources.delete2
        Me.bttEliminarPromocion.Location = New System.Drawing.Point(20, 74)
        Me.bttEliminarPromocion.Name = "bttEliminarPromocion"
        Me.bttEliminarPromocion.Size = New System.Drawing.Size(137, 41)
        Me.bttEliminarPromocion.TabIndex = 40
        Me.bttEliminarPromocion.TabStop = False
        Me.bttEliminarPromocion.Text = "Eliminar promoción"
        '
        'colUnidades
        '
        Me.colUnidades.Caption = "Unidades"
        Me.colUnidades.FieldName = "Unidades"
        Me.colUnidades.Name = "colUnidades"
        Me.colUnidades.Visible = True
        Me.colUnidades.VisibleIndex = 5
        Me.colUnidades.Width = 69
        '
        'BusquedaPromociones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.KeyPreview = True
        Me.Name = "BusquedaPromociones"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Búsqueda de Promociones"
        CType(Me.dgPromociones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FECHASPROMOCIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPromociones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPromociones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetallePromocion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROMOCIONESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetallePromocion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtFechaInicio.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFinal.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFinal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgPromociones As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPromociones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsPromociones As AydaraTPV.dsPromociones
    Friend WithEvents PROMOCIONESTableAdapter As AydaraTPV.dsPromocionesTableAdapters.PROMOCIONESTableAdapter
    Friend WithEvents FECHAS_PROMOCIONESTableAdapter As AydaraTPV.dsPromocionesTableAdapters.FECHAS_PROMOCIONESTableAdapter
    Friend WithEvents colFechaInicio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaFinal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FECHASPROMOCIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgDetallePromocion As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetallePromocion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents PROMOCIONESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticuloRegalo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioPromocion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFraccionSinCargo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadesSinCargo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioTarifa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bttEliminarPromocion As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttActalizarFechas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaFinal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents maskPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colUnidades As DevExpress.XtraGrid.Columns.GridColumn
End Class
