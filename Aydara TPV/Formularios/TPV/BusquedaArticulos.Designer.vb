<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BusquedaArticulos
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusquedaArticulos))
        Me.dgArticulos = New DevExpress.XtraGrid.GridControl()
        Me.ARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New AydaraTPV.dsArticulos()
        Me.gvArticulos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIdArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTotalExistencias = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPromocion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoTallaArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgExistencias = New DevExpress.XtraGrid.GridControl()
        Me.EXISTENCIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvExistencias = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbColores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.COLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colCodigoTalla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExistenciaActual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecioVenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskPrecioVenta = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescripcionTalla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPromocionExistencias = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.checkControlBaja = New DevExpress.XtraEditors.CheckButton()
        Me.bttSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bttSeleccionar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttTeclado = New DevExpress.XtraEditors.SimpleButton()
        Me.lblTallasColores = New DevExpress.XtraEditors.LabelControl()
        Me.ARTICULOSTableAdapter = New AydaraTPV.dsArticulosTableAdapters.ARTICULOSTableAdapter()
        Me.EXISTENCIASTableAdapter = New AydaraTPV.dsArticulosTableAdapters.EXISTENCIASTableAdapter()
        Me.ARTICULOSCOLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ARTICULOS_COLORESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.ARTICULOS_COLORESTableAdapter()
        Me.COLORESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgExistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvExistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecioVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.ARTICULOSCOLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgArticulos
        '
        Me.dgArticulos.DataSource = Me.ARTICULOSBindingSource
        Me.dgArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgArticulos.Location = New System.Drawing.Point(0, 0)
        Me.dgArticulos.MainView = Me.gvArticulos
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskPrecio})
        Me.dgArticulos.Size = New System.Drawing.Size(784, 275)
        Me.dgArticulos.TabIndex = 1
        Me.dgArticulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArticulos})
        '
        'ARTICULOSBindingSource
        '
        Me.ARTICULOSBindingSource.DataMember = "ARTICULOS"
        Me.ARTICULOSBindingSource.DataSource = Me.DsArticulos
        Me.ARTICULOSBindingSource.Filter = "ControlBaja = 0"
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "dsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvArticulos
        '
        Me.gvArticulos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIdArticulo, Me.colCodigo, Me.colDescripcion, Me.colPrecio, Me.colTotalExistencias, Me.colPromocion, Me.colCodigoTallaArticulo})
        Me.gvArticulos.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gvArticulos.GridControl = Me.dgArticulos
        Me.gvArticulos.Name = "gvArticulos"
        Me.gvArticulos.OptionsBehavior.Editable = False
        Me.gvArticulos.OptionsDetail.ShowDetailTabs = False
        Me.gvArticulos.OptionsFind.AlwaysVisible = True
        Me.gvArticulos.OptionsMenu.EnableColumnMenu = False
        Me.gvArticulos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvArticulos.OptionsView.EnableAppearanceEvenRow = True
        Me.gvArticulos.OptionsView.ShowGroupPanel = False
        Me.gvArticulos.RowHeight = 35
        '
        'colIdArticulo
        '
        Me.colIdArticulo.FieldName = "Id"
        Me.colIdArticulo.Name = "colIdArticulo"
        Me.colIdArticulo.OptionsColumn.ReadOnly = True
        '
        'colCodigo
        '
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 112
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 335
        '
        'colPrecio
        '
        Me.colPrecio.ColumnEdit = Me.maskPrecio
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.MaxWidth = 80
        Me.colPrecio.MinWidth = 80
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.Visible = True
        Me.colPrecio.VisibleIndex = 2
        Me.colPrecio.Width = 80
        '
        'maskPrecio
        '
        Me.maskPrecio.AutoHeight = False
        Me.maskPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecio.Name = "maskPrecio"
        '
        'colTotalExistencias
        '
        Me.colTotalExistencias.Caption = "Existencias"
        Me.colTotalExistencias.FieldName = "Descuento"
        Me.colTotalExistencias.MaxWidth = 80
        Me.colTotalExistencias.MinWidth = 80
        Me.colTotalExistencias.Name = "colTotalExistencias"
        Me.colTotalExistencias.Visible = True
        Me.colTotalExistencias.VisibleIndex = 3
        Me.colTotalExistencias.Width = 80
        '
        'colPromocion
        '
        Me.colPromocion.Caption = "Promocion"
        Me.colPromocion.FieldName = "CantidadVariable"
        Me.colPromocion.Name = "colPromocion"
        '
        'colCodigoTallaArticulo
        '
        Me.colCodigoTallaArticulo.Caption = "GridColumn1"
        Me.colCodigoTallaArticulo.FieldName = "CodigoTalla"
        Me.colCodigoTallaArticulo.Name = "colCodigoTallaArticulo"
        '
        'dgExistencias
        '
        Me.dgExistencias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgExistencias.DataSource = Me.EXISTENCIASBindingSource
        Me.dgExistencias.Location = New System.Drawing.Point(467, 0)
        Me.dgExistencias.MainView = Me.gvExistencias
        Me.dgExistencias.Name = "dgExistencias"
        Me.dgExistencias.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskPrecioVenta, Me.cmbColores})
        Me.dgExistencias.Size = New System.Drawing.Size(317, 211)
        Me.dgExistencias.TabIndex = 3
        Me.dgExistencias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvExistencias})
        '
        'EXISTENCIASBindingSource
        '
        Me.EXISTENCIASBindingSource.DataMember = "EXISTENCIAS"
        Me.EXISTENCIASBindingSource.DataSource = Me.DsArticulos
        '
        'gvExistencias
        '
        Me.gvExistencias.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoColor, Me.colCodigoTalla, Me.colExistenciaActual, Me.colPrecioVenta, Me.colDescripcionTalla, Me.colPromocionExistencias})
        Me.gvExistencias.GridControl = Me.dgExistencias
        Me.gvExistencias.Name = "gvExistencias"
        Me.gvExistencias.OptionsBehavior.Editable = False
        Me.gvExistencias.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvExistencias.OptionsView.ShowAutoFilterRow = True
        Me.gvExistencias.OptionsView.ShowGroupPanel = False
        Me.gvExistencias.RowHeight = 35
        '
        'colCodigoColor
        '
        Me.colCodigoColor.Caption = "Color"
        Me.colCodigoColor.ColumnEdit = Me.cmbColores
        Me.colCodigoColor.FieldName = "CodigoColor"
        Me.colCodigoColor.MaxWidth = 60
        Me.colCodigoColor.MinWidth = 60
        Me.colCodigoColor.Name = "colCodigoColor"
        Me.colCodigoColor.Visible = True
        Me.colCodigoColor.VisibleIndex = 0
        Me.colCodigoColor.Width = 60
        '
        'cmbColores
        '
        Me.cmbColores.AutoHeight = False
        Me.cmbColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbColores.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripcion", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
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
        'colCodigoTalla
        '
        Me.colCodigoTalla.FieldName = "CodigoTalla"
        Me.colCodigoTalla.Name = "colCodigoTalla"
        '
        'colExistenciaActual
        '
        Me.colExistenciaActual.Caption = "Existencias"
        Me.colExistenciaActual.FieldName = "ExistenciaActual"
        Me.colExistenciaActual.MaxWidth = 80
        Me.colExistenciaActual.MinWidth = 80
        Me.colExistenciaActual.Name = "colExistenciaActual"
        Me.colExistenciaActual.Visible = True
        Me.colExistenciaActual.VisibleIndex = 3
        Me.colExistenciaActual.Width = 80
        '
        'colPrecioVenta
        '
        Me.colPrecioVenta.Caption = "Precio"
        Me.colPrecioVenta.ColumnEdit = Me.maskPrecioVenta
        Me.colPrecioVenta.FieldName = "PrecioVenta"
        Me.colPrecioVenta.MaxWidth = 80
        Me.colPrecioVenta.MinWidth = 80
        Me.colPrecioVenta.Name = "colPrecioVenta"
        Me.colPrecioVenta.Visible = True
        Me.colPrecioVenta.VisibleIndex = 2
        Me.colPrecioVenta.Width = 80
        '
        'maskPrecioVenta
        '
        Me.maskPrecioVenta.AutoHeight = False
        Me.maskPrecioVenta.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecioVenta.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecioVenta.Name = "maskPrecioVenta"
        '
        'colDescripcionTalla
        '
        Me.colDescripcionTalla.Caption = "Talla"
        Me.colDescripcionTalla.FieldName = "DescripcionTalla"
        Me.colDescripcionTalla.MaxWidth = 60
        Me.colDescripcionTalla.MinWidth = 60
        Me.colDescripcionTalla.Name = "colDescripcionTalla"
        Me.colDescripcionTalla.Visible = True
        Me.colDescripcionTalla.VisibleIndex = 1
        Me.colDescripcionTalla.Width = 60
        '
        'colPromocionExistencias
        '
        Me.colPromocionExistencias.Caption = "GridColumn1"
        Me.colPromocionExistencias.FieldName = "Promocion"
        Me.colPromocionExistencias.Name = "colPromocionExistencias"
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Horizontal = False
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.dgArticulos)
        Me.SplitContainerControl1.Panel1.MinSize = 130
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.checkControlBaja)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.bttSalir)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.bttSeleccionar)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.bttTeclado)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.lblTallasColores)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.dgExistencias)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(784, 562)
        Me.SplitContainerControl1.SplitterPosition = 275
        Me.SplitContainerControl1.TabIndex = 4
        '
        'checkControlBaja
        '
        Me.checkControlBaja.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.checkControlBaja.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkControlBaja.Appearance.Options.UseFont = True
        Me.checkControlBaja.Appearance.Options.UseTextOptions = True
        Me.checkControlBaja.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.checkControlBaja.Location = New System.Drawing.Point(165, 217)
        Me.checkControlBaja.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003
        Me.checkControlBaja.LookAndFeel.UseDefaultLookAndFeel = False
        Me.checkControlBaja.Name = "checkControlBaja"
        Me.checkControlBaja.Size = New System.Drawing.Size(161, 65)
        Me.checkControlBaja.TabIndex = 8
        Me.checkControlBaja.Text = "Ver artículos obsoletos"
        '
        'bttSalir
        '
        Me.bttSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttSalir.Appearance.Options.UseFont = True
        Me.bttSalir.Image = CType(resources.GetObject("bttSalir.Image"), System.Drawing.Image)
        Me.bttSalir.Location = New System.Drawing.Point(0, 217)
        Me.bttSalir.Name = "bttSalir"
        Me.bttSalir.Size = New System.Drawing.Size(131, 65)
        Me.bttSalir.TabIndex = 7
        Me.bttSalir.Text = "Cancelar"
        '
        'bttSeleccionar
        '
        Me.bttSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttSeleccionar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttSeleccionar.Appearance.Options.UseFont = True
        Me.bttSeleccionar.Image = Global.AydaraTPV.My.Resources.Resources.ok_32
        Me.bttSeleccionar.Location = New System.Drawing.Point(653, 217)
        Me.bttSeleccionar.Name = "bttSeleccionar"
        Me.bttSeleccionar.Size = New System.Drawing.Size(131, 65)
        Me.bttSeleccionar.TabIndex = 6
        Me.bttSeleccionar.Text = "Seleccionar"
        '
        'bttTeclado
        '
        Me.bttTeclado.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bttTeclado.Image = Global.AydaraTPV.My.Resources.Resources.keyboard
        Me.bttTeclado.Location = New System.Drawing.Point(354, 217)
        Me.bttTeclado.Name = "bttTeclado"
        Me.bttTeclado.Size = New System.Drawing.Size(75, 65)
        Me.bttTeclado.TabIndex = 5
        Me.bttTeclado.TabStop = False
        Me.bttTeclado.Tag = "1"
        Me.bttTeclado.Text = "Teclado"
        '
        'lblTallasColores
        '
        Me.lblTallasColores.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTallasColores.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTallasColores.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblTallasColores.Location = New System.Drawing.Point(195, 9)
        Me.lblTallasColores.Name = "lblTallasColores"
        Me.lblTallasColores.Size = New System.Drawing.Size(266, 72)
        Me.lblTallasColores.TabIndex = 4
        Me.lblTallasColores.Text = "Tallas y Colores del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "artículo seleccionado"
        '
        'ARTICULOSTableAdapter
        '
        Me.ARTICULOSTableAdapter.ClearBeforeFill = True
        '
        'EXISTENCIASTableAdapter
        '
        Me.EXISTENCIASTableAdapter.ClearBeforeFill = True
        '
        'ARTICULOSCOLORESBindingSource
        '
        Me.ARTICULOSCOLORESBindingSource.DataMember = "ARTICULOS_COLORES"
        Me.ARTICULOSCOLORESBindingSource.DataSource = Me.DsArticulos
        '
        'ARTICULOS_COLORESTableAdapter
        '
        Me.ARTICULOS_COLORESTableAdapter.ClearBeforeFill = True
        '
        'COLORESTableAdapter
        '
        Me.COLORESTableAdapter.ClearBeforeFill = True
        '
        'BusquedaArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.KeyPreview = True
        Me.Name = "BusquedaArticulos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Búsqueda de Artículos"
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgExistencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvExistencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecioVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.ARTICULOSCOLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgArticulos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvArticulos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dgExistencias As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvExistencias As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents maskPrecioVenta As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DsArticulos As AydaraTPV.dsArticulos
    Friend WithEvents ARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARTICULOSTableAdapter As AydaraTPV.dsArticulosTableAdapters.ARTICULOSTableAdapter
    Friend WithEvents EXISTENCIASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EXISTENCIASTableAdapter As AydaraTPV.dsArticulosTableAdapters.EXISTENCIASTableAdapter
    Friend WithEvents colIdArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalExistencias As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExistenciaActual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioVenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPromocion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoTallaArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbColores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ARTICULOSCOLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARTICULOS_COLORESTableAdapter As AydaraTPV.dsArticulosTableAdapters.ARTICULOS_COLORESTableAdapter
    Friend WithEvents COLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COLORESTableAdapter As AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter
    Friend WithEvents colPromocionExistencias As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTallasColores As DevExpress.XtraEditors.LabelControl
    Friend WithEvents maskPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bttTeclado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttSeleccionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents checkControlBaja As DevExpress.XtraEditors.CheckButton
End Class
