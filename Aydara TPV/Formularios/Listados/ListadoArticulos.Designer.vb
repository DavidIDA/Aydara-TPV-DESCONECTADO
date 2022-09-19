<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoArticulos
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoInicio = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtCodigoFin = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtDescripcionInicio = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcionFin = New DevExpress.XtraEditors.TextEdit()
        Me.checkControlBaja = New DevExpress.XtraEditors.CheckEdit()
        Me.checkAgruparFamilia = New DevExpress.XtraEditors.CheckEdit()
        Me.gcOpciones = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.rgValorado = New DevExpress.XtraEditors.RadioGroup()
        Me.txtDescripcionFamiliaInicio = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoFamiliaInicio = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcionFamiliaFin = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoFamiliaFin = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoProveedor = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dgBusqueda = New DevExpress.XtraGrid.GridControl()
        Me.ListadoArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsListadoArticulos = New AydaraTPV.dsListadoArticulos()
        Me.gvBusqueda = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDescripcionFamilia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcionSubFamilia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoFamilia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoSubFamilia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoIva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidadCaja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecioCoste = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPrecioVenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExistencias = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.panelImprimir = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTituloListado = New DevExpress.XtraEditors.TextEdit()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtCodigoInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkControlBaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkAgruparFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcOpciones.SuspendLayout()
        CType(Me.rgValorado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionFamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionFamiliaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFamiliaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListadoArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImprimir.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtTituloListado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Desde:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Hasta:"
        '
        'txtCodigoInicio
        '
        Me.txtCodigoInicio.EnterMoveNextControl = True
        Me.txtCodigoInicio.Location = New System.Drawing.Point(52, 9)
        Me.txtCodigoInicio.Name = "txtCodigoInicio"
        Me.txtCodigoInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoInicio.Properties.MaxLength = 15
        Me.txtCodigoInicio.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigoInicio.TabIndex = 0
        '
        'txtCodigoFin
        '
        Me.txtCodigoFin.EnterMoveNextControl = True
        Me.txtCodigoFin.Location = New System.Drawing.Point(52, 35)
        Me.txtCodigoFin.Name = "txtCodigoFin"
        Me.txtCodigoFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoFin.Properties.MaxLength = 15
        Me.txtCodigoFin.Size = New System.Drawing.Size(120, 20)
        Me.txtCodigoFin.TabIndex = 1
        '
        'txtDescripcionInicio
        '
        Me.txtDescripcionInicio.Location = New System.Drawing.Point(171, 9)
        Me.txtDescripcionInicio.Name = "txtDescripcionInicio"
        Me.txtDescripcionInicio.Properties.ReadOnly = True
        Me.txtDescripcionInicio.Size = New System.Drawing.Size(326, 20)
        Me.txtDescripcionInicio.TabIndex = 4
        Me.txtDescripcionInicio.TabStop = False
        '
        'txtDescripcionFin
        '
        Me.txtDescripcionFin.Location = New System.Drawing.Point(171, 35)
        Me.txtDescripcionFin.Name = "txtDescripcionFin"
        Me.txtDescripcionFin.Properties.ReadOnly = True
        Me.txtDescripcionFin.Size = New System.Drawing.Size(327, 20)
        Me.txtDescripcionFin.TabIndex = 5
        Me.txtDescripcionFin.TabStop = False
        '
        'checkControlBaja
        '
        Me.checkControlBaja.Location = New System.Drawing.Point(5, 48)
        Me.checkControlBaja.Name = "checkControlBaja"
        Me.checkControlBaja.Properties.Caption = "Control de Baja"
        Me.checkControlBaja.Size = New System.Drawing.Size(99, 19)
        Me.checkControlBaja.TabIndex = 1
        Me.checkControlBaja.TabStop = False
        '
        'checkAgruparFamilia
        '
        Me.checkAgruparFamilia.EditValue = True
        Me.checkAgruparFamilia.Location = New System.Drawing.Point(110, 48)
        Me.checkAgruparFamilia.Name = "checkAgruparFamilia"
        Me.checkAgruparFamilia.Properties.Caption = "Agrupar por familias"
        Me.checkAgruparFamilia.Size = New System.Drawing.Size(113, 19)
        Me.checkAgruparFamilia.TabIndex = 2
        Me.checkAgruparFamilia.TabStop = False
        '
        'gcOpciones
        '
        Me.gcOpciones.Controls.Add(Me.LabelControl7)
        Me.gcOpciones.Controls.Add(Me.rgValorado)
        Me.gcOpciones.Controls.Add(Me.checkControlBaja)
        Me.gcOpciones.Controls.Add(Me.checkAgruparFamilia)
        Me.gcOpciones.Location = New System.Drawing.Point(504, 9)
        Me.gcOpciones.Name = "gcOpciones"
        Me.gcOpciones.Size = New System.Drawing.Size(270, 77)
        Me.gcOpciones.TabIndex = 4
        Me.gcOpciones.Text = "Opciones"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(7, 25)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl7.TabIndex = 33
        Me.LabelControl7.Text = "Imprimir precio de:"
        '
        'rgValorado
        '
        Me.rgValorado.EditValue = 0
        Me.rgValorado.Location = New System.Drawing.Point(102, 23)
        Me.rgValorado.Name = "rgValorado"
        Me.rgValorado.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgValorado.Properties.Appearance.Options.UseBackColor = True
        Me.rgValorado.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Coste"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Venta"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Ambos")})
        Me.rgValorado.Size = New System.Drawing.Size(163, 19)
        Me.rgValorado.TabIndex = 0
        '
        'txtDescripcionFamiliaInicio
        '
        Me.txtDescripcionFamiliaInicio.Location = New System.Drawing.Point(122, 24)
        Me.txtDescripcionFamiliaInicio.Name = "txtDescripcionFamiliaInicio"
        Me.txtDescripcionFamiliaInicio.Properties.ReadOnly = True
        Me.txtDescripcionFamiliaInicio.Size = New System.Drawing.Size(359, 20)
        Me.txtDescripcionFamiliaInicio.TabIndex = 24
        Me.txtDescripcionFamiliaInicio.TabStop = False
        '
        'txtCodigoFamiliaInicio
        '
        Me.txtCodigoFamiliaInicio.EnterMoveNextControl = True
        Me.txtCodigoFamiliaInicio.Location = New System.Drawing.Point(45, 24)
        Me.txtCodigoFamiliaInicio.Name = "txtCodigoFamiliaInicio"
        Me.txtCodigoFamiliaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoFamiliaInicio.Properties.MaxLength = 7
        Me.txtCodigoFamiliaInicio.Size = New System.Drawing.Size(78, 20)
        Me.txtCodigoFamiliaInicio.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 27)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl3.TabIndex = 22
        Me.LabelControl3.Text = "Desde:"
        '
        'txtDescripcionFamiliaFin
        '
        Me.txtDescripcionFamiliaFin.Location = New System.Drawing.Point(122, 50)
        Me.txtDescripcionFamiliaFin.Name = "txtDescripcionFamiliaFin"
        Me.txtDescripcionFamiliaFin.Properties.ReadOnly = True
        Me.txtDescripcionFamiliaFin.Size = New System.Drawing.Size(359, 20)
        Me.txtDescripcionFamiliaFin.TabIndex = 27
        Me.txtDescripcionFamiliaFin.TabStop = False
        '
        'txtCodigoFamiliaFin
        '
        Me.txtCodigoFamiliaFin.EnterMoveNextControl = True
        Me.txtCodigoFamiliaFin.Location = New System.Drawing.Point(45, 50)
        Me.txtCodigoFamiliaFin.Name = "txtCodigoFamiliaFin"
        Me.txtCodigoFamiliaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoFamiliaFin.Properties.MaxLength = 7
        Me.txtCodigoFamiliaFin.Size = New System.Drawing.Size(78, 20)
        Me.txtCodigoFamiliaFin.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(5, 53)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl4.TabIndex = 25
        Me.LabelControl4.Text = "Hasta:"
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Location = New System.Drawing.Point(134, 145)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Properties.ReadOnly = True
        Me.txtNombreProveedor.Size = New System.Drawing.Size(364, 20)
        Me.txtNombreProveedor.TabIndex = 30
        Me.txtNombreProveedor.TabStop = False
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.EnterMoveNextControl = True
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(72, 145)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoProveedor.Properties.MaxLength = 7
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(63, 20)
        Me.txtCodigoProveedor.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 148)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl5.TabIndex = 28
        Me.LabelControl5.Text = "Proveedor:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtCodigoFamiliaInicio)
        Me.GroupControl1.Controls.Add(Me.txtDescripcionFamiliaInicio)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtDescripcionFamiliaFin)
        Me.GroupControl1.Controls.Add(Me.txtCodigoFamiliaFin)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 61)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(486, 78)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Familias"
        '
        'bttBuscar
        '
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.find
        Me.bttBuscar.Location = New System.Drawing.Point(511, 120)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(117, 45)
        Me.bttBuscar.TabIndex = 35
        Me.bttBuscar.Text = "Buscar"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.bttBuscar)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.txtCodigoInicio)
        Me.PanelControl1.Controls.Add(Me.txtNombreProveedor)
        Me.PanelControl1.Controls.Add(Me.txtCodigoFin)
        Me.PanelControl1.Controls.Add(Me.txtCodigoProveedor)
        Me.PanelControl1.Controls.Add(Me.txtDescripcionInicio)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtDescripcionFin)
        Me.PanelControl1.Controls.Add(Me.gcOpciones)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(784, 178)
        Me.PanelControl1.TabIndex = 36
        '
        'dgBusqueda
        '
        Me.dgBusqueda.DataSource = Me.ListadoArticulosBindingSource
        Me.dgBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBusqueda.Location = New System.Drawing.Point(0, 178)
        Me.dgBusqueda.MainView = Me.gvBusqueda
        Me.dgBusqueda.Name = "dgBusqueda"
        Me.dgBusqueda.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskPrecio})
        Me.dgBusqueda.Size = New System.Drawing.Size(784, 314)
        Me.dgBusqueda.TabIndex = 38
        Me.dgBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBusqueda})
        '
        'ListadoArticulosBindingSource
        '
        Me.ListadoArticulosBindingSource.DataMember = "ListadoArticulos"
        Me.ListadoArticulosBindingSource.DataSource = Me.DsListadoArticulos
        '
        'DsListadoArticulos
        '
        Me.DsListadoArticulos.DataSetName = "dsListadoArticulos"
        Me.DsListadoArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvBusqueda
        '
        Me.gvBusqueda.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvBusqueda.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvBusqueda.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescripcionFamilia, Me.colDescripcionSubFamilia, Me.colCodigo, Me.colDescripcion, Me.colCodigoFamilia, Me.colCodigoSubFamilia, Me.colTipoIva, Me.colUnidadCaja, Me.colPrecioCoste, Me.colPrecioVenta, Me.colCodigoProveedor, Me.colExistencias})
        Me.gvBusqueda.GridControl = Me.dgBusqueda
        Me.gvBusqueda.GroupCount = 2
        Me.gvBusqueda.GroupPanelText = "Arrastre una columna para agrupar por esa columna"
        Me.gvBusqueda.Name = "gvBusqueda"
        Me.gvBusqueda.OptionsBehavior.Editable = False
        Me.gvBusqueda.OptionsMenu.EnableColumnMenu = False
        Me.gvBusqueda.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvBusqueda.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvBusqueda.OptionsView.EnableAppearanceEvenRow = True
        Me.gvBusqueda.OptionsView.ShowAutoFilterRow = True
        Me.gvBusqueda.OptionsView.ShowDetailButtons = False
        Me.gvBusqueda.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDescripcionFamilia, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDescripcionSubFamilia, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colDescripcionFamilia
        '
        Me.colDescripcionFamilia.FieldName = "DescripcionFamilia"
        Me.colDescripcionFamilia.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
        Me.colDescripcionFamilia.Name = "colDescripcionFamilia"
        '
        'colDescripcionSubFamilia
        '
        Me.colDescripcionSubFamilia.FieldName = "DescripcionSubFamilia"
        Me.colDescripcionSubFamilia.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value
        Me.colDescripcionSubFamilia.Name = "colDescripcionSubFamilia"
        '
        'colCodigo
        '
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.FixedWidth = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 120
        '
        'colDescripcion
        '
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 196
        '
        'colCodigoFamilia
        '
        Me.colCodigoFamilia.FieldName = "CodigoFamilia"
        Me.colCodigoFamilia.Name = "colCodigoFamilia"
        '
        'colCodigoSubFamilia
        '
        Me.colCodigoSubFamilia.FieldName = "CodigoSubFamilia"
        Me.colCodigoSubFamilia.Name = "colCodigoSubFamilia"
        '
        'colTipoIva
        '
        Me.colTipoIva.FieldName = "TipoIva"
        Me.colTipoIva.Name = "colTipoIva"
        '
        'colUnidadCaja
        '
        Me.colUnidadCaja.FieldName = "UnidadCaja"
        Me.colUnidadCaja.Name = "colUnidadCaja"
        Me.colUnidadCaja.OptionsColumn.FixedWidth = True
        Me.colUnidadCaja.Visible = True
        Me.colUnidadCaja.VisibleIndex = 2
        Me.colUnidadCaja.Width = 80
        '
        'colPrecioCoste
        '
        Me.colPrecioCoste.ColumnEdit = Me.maskPrecio
        Me.colPrecioCoste.FieldName = "PrecioCoste"
        Me.colPrecioCoste.Name = "colPrecioCoste"
        Me.colPrecioCoste.OptionsColumn.FixedWidth = True
        Me.colPrecioCoste.Visible = True
        Me.colPrecioCoste.VisibleIndex = 3
        Me.colPrecioCoste.Width = 100
        '
        'maskPrecio
        '
        Me.maskPrecio.AutoHeight = False
        Me.maskPrecio.Name = "maskPrecio"
        '
        'colPrecioVenta
        '
        Me.colPrecioVenta.ColumnEdit = Me.maskPrecio
        Me.colPrecioVenta.FieldName = "PrecioVenta"
        Me.colPrecioVenta.Name = "colPrecioVenta"
        Me.colPrecioVenta.OptionsColumn.FixedWidth = True
        Me.colPrecioVenta.Visible = True
        Me.colPrecioVenta.VisibleIndex = 4
        Me.colPrecioVenta.Width = 100
        '
        'colCodigoProveedor
        '
        Me.colCodigoProveedor.Caption = "Proveedor"
        Me.colCodigoProveedor.FieldName = "CodigoProveedor"
        Me.colCodigoProveedor.Name = "colCodigoProveedor"
        Me.colCodigoProveedor.OptionsColumn.FixedWidth = True
        Me.colCodigoProveedor.Visible = True
        Me.colCodigoProveedor.VisibleIndex = 6
        Me.colCodigoProveedor.Width = 89
        '
        'colExistencias
        '
        Me.colExistencias.Caption = "Stock actual"
        Me.colExistencias.DisplayFormat.FormatString = "{0:n3}"
        Me.colExistencias.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colExistencias.FieldName = "Existencias"
        Me.colExistencias.Name = "colExistencias"
        Me.colExistencias.Visible = True
        Me.colExistencias.VisibleIndex = 5
        Me.colExistencias.Width = 78
        '
        'panelImprimir
        '
        Me.panelImprimir.Controls.Add(Me.PanelControl2)
        Me.panelImprimir.Controls.Add(Me.bttCancelar)
        Me.panelImprimir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelImprimir.Location = New System.Drawing.Point(0, 492)
        Me.panelImprimir.Name = "panelImprimir"
        Me.panelImprimir.Size = New System.Drawing.Size(784, 70)
        Me.panelImprimir.TabIndex = 37
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PanelControl2.Controls.Add(Me.bttImprimir)
        Me.PanelControl2.Controls.Add(Me.LabelControl8)
        Me.PanelControl2.Controls.Add(Me.txtTituloListado)
        Me.PanelControl2.Location = New System.Drawing.Point(391, 13)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(383, 45)
        Me.PanelControl2.TabIndex = 123
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttImprimir.Location = New System.Drawing.Point(266, 0)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(117, 45)
        Me.bttImprimir.TabIndex = 0
        Me.bttImprimir.Text = "Imprimir listado"
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl8.TabIndex = 3
        Me.LabelControl8.Text = "Título del listado:"
        '
        'txtTituloListado
        '
        Me.txtTituloListado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTituloListado.Location = New System.Drawing.Point(5, 20)
        Me.txtTituloListado.Name = "txtTituloListado"
        Me.txtTituloListado.Size = New System.Drawing.Size(255, 20)
        Me.txtTituloListado.TabIndex = 4
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(12, 13)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 122
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'ListadoArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgBusqueda)
        Me.Controls.Add(Me.panelImprimir)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "ListadoArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado de artículos"
        CType(Me.txtCodigoInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkControlBaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkAgruparFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcOpciones.ResumeLayout(False)
        Me.gcOpciones.PerformLayout()
        CType(Me.rgValorado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionFamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionFamiliaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFamiliaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListadoArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImprimir.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtTituloListado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoInicio As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCodigoFin As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtDescripcionInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcionFin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents checkControlBaja As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkAgruparFamilia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gcOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDescripcionFamiliaInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoFamiliaInicio As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcionFamiliaFin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoFamiliaFin As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoProveedor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgValorado As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents panelImprimir As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTituloListado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gvBusqueda As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoFamilia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionFamilia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoSubFamilia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionSubFamilia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoIva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnidadCaja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioCoste As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioVenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ListadoArticulosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsListadoArticulos As AydaraTPV.dsListadoArticulos
    Friend WithEvents maskPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colExistencias As DevExpress.XtraGrid.Columns.GridColumn
End Class
