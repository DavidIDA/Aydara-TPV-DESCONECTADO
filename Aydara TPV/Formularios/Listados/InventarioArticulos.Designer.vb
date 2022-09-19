<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventarioArticulos
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtFechaHasta = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoFin = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoSubfamiliaInicio = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtCodigoInicio = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcionSubfamiliaInicio = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcionSubfamiliaFin = New DevExpress.XtraEditors.TextEdit()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCodigoSubfamiliaFin = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoFamiliaInicio = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtNombreProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcionFamiliaInicio = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoProveedor = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcionFamiliaFin = New DevExpress.XtraEditors.TextEdit()
        Me.gcOpciones = New DevExpress.XtraEditors.GroupControl()
        Me.checkExistencia0 = New DevExpress.XtraEditors.CheckEdit()
        Me.checkExistenciaNegativa = New DevExpress.XtraEditors.CheckEdit()
        Me.checkExistenciaPositiva = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.rgValorado = New DevExpress.XtraEditors.RadioGroup()
        Me.checkBajoMinimo = New DevExpress.XtraEditors.CheckEdit()
        Me.checkValorado = New DevExpress.XtraEditors.CheckEdit()
        Me.checkControlBaja = New DevExpress.XtraEditors.CheckEdit()
        Me.checkAgruparFamilia = New DevExpress.XtraEditors.CheckEdit()
        Me.txtCodigoFamiliaFin = New DevExpress.XtraEditors.ButtonEdit()
        Me.dgArticulos = New DevExpress.XtraGrid.GridControl()
        Me.ListadoInventarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsListadoArticulos = New AydaraTPV.dsListadoArticulos()
        Me.gvArticulos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoFamilia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcionFamilia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoSubFamilia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcionSubFamilia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoProveedor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExistencias = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttReiniciar = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoSubfamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionSubfamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionSubfamiliaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoSubfamiliaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionFamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionFamiliaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcOpciones.SuspendLayout()
        CType(Me.checkExistencia0.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkExistenciaNegativa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkExistenciaPositiva.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgValorado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBajoMinimo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkValorado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkControlBaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkAgruparFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFamiliaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListadoInventarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListadoArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtFechaHasta)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.txtCodigoFin)
        Me.PanelControl1.Controls.Add(Me.txtCodigoSubfamiliaInicio)
        Me.PanelControl1.Controls.Add(Me.txtCodigoInicio)
        Me.PanelControl1.Controls.Add(Me.txtDescripcionSubfamiliaInicio)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtDescripcionSubfamiliaFin)
        Me.PanelControl1.Controls.Add(Me.bttBuscar)
        Me.PanelControl1.Controls.Add(Me.txtCodigoSubfamiliaFin)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtCodigoFamiliaInicio)
        Me.PanelControl1.Controls.Add(Me.txtNombreProveedor)
        Me.PanelControl1.Controls.Add(Me.txtDescripcionFamiliaInicio)
        Me.PanelControl1.Controls.Add(Me.txtCodigoProveedor)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtDescripcionFamiliaFin)
        Me.PanelControl1.Controls.Add(Me.gcOpciones)
        Me.PanelControl1.Controls.Add(Me.txtCodigoFamiliaFin)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(784, 182)
        Me.PanelControl1.TabIndex = 0
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.EditValue = Nothing
        Me.txtFechaHasta.EnterMoveNextControl = True
        Me.txtFechaHasta.Location = New System.Drawing.Point(388, 142)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaHasta.Size = New System.Drawing.Size(81, 20)
        Me.txtFechaHasta.TabIndex = 47
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(299, 145)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl9.TabIndex = 48
        Me.LabelControl9.Text = "Existencias a día:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 67)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl6.TabIndex = 30
        Me.LabelControl6.Text = "Subfamilia desde:"
        '
        'txtCodigoFin
        '
        Me.txtCodigoFin.EnterMoveNextControl = True
        Me.txtCodigoFin.Location = New System.Drawing.Point(218, 142)
        Me.txtCodigoFin.Name = "txtCodigoFin"
        Me.txtCodigoFin.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigoFin.Size = New System.Drawing.Size(75, 20)
        Me.txtCodigoFin.TabIndex = 11
        '
        'txtCodigoSubfamiliaInicio
        '
        Me.txtCodigoSubfamiliaInicio.EnterMoveNextControl = True
        Me.txtCodigoSubfamiliaInicio.Location = New System.Drawing.Point(100, 64)
        Me.txtCodigoSubfamiliaInicio.Name = "txtCodigoSubfamiliaInicio"
        Me.txtCodigoSubfamiliaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoSubfamiliaInicio.Properties.MaxLength = 7
        Me.txtCodigoSubfamiliaInicio.Properties.ReadOnly = True
        Me.txtCodigoSubfamiliaInicio.Size = New System.Drawing.Size(78, 20)
        Me.txtCodigoSubfamiliaInicio.TabIndex = 4
        '
        'txtCodigoInicio
        '
        Me.txtCodigoInicio.EnterMoveNextControl = True
        Me.txtCodigoInicio.Location = New System.Drawing.Point(100, 142)
        Me.txtCodigoInicio.Name = "txtCodigoInicio"
        Me.txtCodigoInicio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigoInicio.Size = New System.Drawing.Size(75, 20)
        Me.txtCodigoInicio.TabIndex = 10
        '
        'txtDescripcionSubfamiliaInicio
        '
        Me.txtDescripcionSubfamiliaInicio.Location = New System.Drawing.Point(177, 64)
        Me.txtDescripcionSubfamiliaInicio.Name = "txtDescripcionSubfamiliaInicio"
        Me.txtDescripcionSubfamiliaInicio.Properties.ReadOnly = True
        Me.txtDescripcionSubfamiliaInicio.Size = New System.Drawing.Size(292, 20)
        Me.txtDescripcionSubfamiliaInicio.TabIndex = 5
        Me.txtDescripcionSubfamiliaInicio.TabStop = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(181, 145)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl2.TabIndex = 46
        Me.LabelControl2.Text = "hasta:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(12, 93)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl7.TabIndex = 32
        Me.LabelControl7.Text = "Subfamilia hasta:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 145)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl1.TabIndex = 45
        Me.LabelControl1.Text = "Desde artículo:"
        '
        'txtDescripcionSubfamiliaFin
        '
        Me.txtDescripcionSubfamiliaFin.Location = New System.Drawing.Point(177, 90)
        Me.txtDescripcionSubfamiliaFin.Name = "txtDescripcionSubfamiliaFin"
        Me.txtDescripcionSubfamiliaFin.Properties.ReadOnly = True
        Me.txtDescripcionSubfamiliaFin.Size = New System.Drawing.Size(292, 20)
        Me.txtDescripcionSubfamiliaFin.TabIndex = 7
        Me.txtDescripcionSubfamiliaFin.TabStop = False
        '
        'bttBuscar
        '
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.find
        Me.bttBuscar.Location = New System.Drawing.Point(504, 140)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(268, 28)
        Me.bttBuscar.TabIndex = 13
        Me.bttBuscar.Text = "Buscar"
        '
        'txtCodigoSubfamiliaFin
        '
        Me.txtCodigoSubfamiliaFin.EnterMoveNextControl = True
        Me.txtCodigoSubfamiliaFin.Location = New System.Drawing.Point(100, 90)
        Me.txtCodigoSubfamiliaFin.Name = "txtCodigoSubfamiliaFin"
        Me.txtCodigoSubfamiliaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoSubfamiliaFin.Properties.MaxLength = 7
        Me.txtCodigoSubfamiliaFin.Properties.ReadOnly = True
        Me.txtCodigoSubfamiliaFin.Size = New System.Drawing.Size(78, 20)
        Me.txtCodigoSubfamiliaFin.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl3.TabIndex = 22
        Me.LabelControl3.Text = "Familia desde:"
        '
        'txtCodigoFamiliaInicio
        '
        Me.txtCodigoFamiliaInicio.EnterMoveNextControl = True
        Me.txtCodigoFamiliaInicio.Location = New System.Drawing.Point(100, 12)
        Me.txtCodigoFamiliaInicio.Name = "txtCodigoFamiliaInicio"
        Me.txtCodigoFamiliaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoFamiliaInicio.Properties.MaxLength = 7
        Me.txtCodigoFamiliaInicio.Size = New System.Drawing.Size(78, 20)
        Me.txtCodigoFamiliaInicio.TabIndex = 0
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Location = New System.Drawing.Point(162, 116)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Properties.ReadOnly = True
        Me.txtNombreProveedor.Size = New System.Drawing.Size(307, 20)
        Me.txtNombreProveedor.TabIndex = 9
        Me.txtNombreProveedor.TabStop = False
        '
        'txtDescripcionFamiliaInicio
        '
        Me.txtDescripcionFamiliaInicio.Location = New System.Drawing.Point(177, 12)
        Me.txtDescripcionFamiliaInicio.Name = "txtDescripcionFamiliaInicio"
        Me.txtDescripcionFamiliaInicio.Properties.ReadOnly = True
        Me.txtDescripcionFamiliaInicio.Size = New System.Drawing.Size(292, 20)
        Me.txtDescripcionFamiliaInicio.TabIndex = 1
        Me.txtDescripcionFamiliaInicio.TabStop = False
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.EnterMoveNextControl = True
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(100, 116)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoProveedor.Properties.MaxLength = 7
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(63, 20)
        Me.txtCodigoProveedor.TabIndex = 8
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 41)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl4.TabIndex = 25
        Me.LabelControl4.Text = "Familia hasta:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 119)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl5.TabIndex = 40
        Me.LabelControl5.Text = "Proveedor:"
        '
        'txtDescripcionFamiliaFin
        '
        Me.txtDescripcionFamiliaFin.Location = New System.Drawing.Point(177, 38)
        Me.txtDescripcionFamiliaFin.Name = "txtDescripcionFamiliaFin"
        Me.txtDescripcionFamiliaFin.Properties.ReadOnly = True
        Me.txtDescripcionFamiliaFin.Size = New System.Drawing.Size(292, 20)
        Me.txtDescripcionFamiliaFin.TabIndex = 3
        Me.txtDescripcionFamiliaFin.TabStop = False
        '
        'gcOpciones
        '
        Me.gcOpciones.Controls.Add(Me.checkExistencia0)
        Me.gcOpciones.Controls.Add(Me.checkExistenciaNegativa)
        Me.gcOpciones.Controls.Add(Me.checkExistenciaPositiva)
        Me.gcOpciones.Controls.Add(Me.LabelControl8)
        Me.gcOpciones.Controls.Add(Me.rgValorado)
        Me.gcOpciones.Controls.Add(Me.checkBajoMinimo)
        Me.gcOpciones.Controls.Add(Me.checkValorado)
        Me.gcOpciones.Controls.Add(Me.checkControlBaja)
        Me.gcOpciones.Controls.Add(Me.checkAgruparFamilia)
        Me.gcOpciones.Location = New System.Drawing.Point(482, 10)
        Me.gcOpciones.Name = "gcOpciones"
        Me.gcOpciones.Size = New System.Drawing.Size(290, 126)
        Me.gcOpciones.TabIndex = 12
        Me.gcOpciones.Text = "Opciones"
        '
        'checkExistencia0
        '
        Me.checkExistencia0.Location = New System.Drawing.Point(201, 48)
        Me.checkExistencia0.Name = "checkExistencia0"
        Me.checkExistencia0.Properties.AutoWidth = True
        Me.checkExistencia0.Properties.Caption = "0"
        Me.checkExistencia0.Size = New System.Drawing.Size(28, 19)
        Me.checkExistencia0.TabIndex = 26
        Me.checkExistencia0.TabStop = False
        '
        'checkExistenciaNegativa
        '
        Me.checkExistenciaNegativa.Location = New System.Drawing.Point(129, 48)
        Me.checkExistenciaNegativa.Name = "checkExistenciaNegativa"
        Me.checkExistenciaNegativa.Properties.AutoWidth = True
        Me.checkExistenciaNegativa.Properties.Caption = "Negativa"
        Me.checkExistenciaNegativa.Size = New System.Drawing.Size(65, 19)
        Me.checkExistenciaNegativa.TabIndex = 25
        Me.checkExistenciaNegativa.TabStop = False
        '
        'checkExistenciaPositiva
        '
        Me.checkExistenciaPositiva.Location = New System.Drawing.Point(63, 48)
        Me.checkExistenciaPositiva.Name = "checkExistenciaPositiva"
        Me.checkExistenciaPositiva.Properties.AutoWidth = True
        Me.checkExistenciaPositiva.Properties.Caption = "Positiva"
        Me.checkExistenciaPositiva.Size = New System.Drawing.Size(59, 19)
        Me.checkExistenciaPositiva.TabIndex = 24
        Me.checkExistenciaPositiva.TabStop = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(5, 50)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl8.TabIndex = 23
        Me.LabelControl8.Text = "Existencia:"
        '
        'rgValorado
        '
        Me.rgValorado.EditValue = "Coste"
        Me.rgValorado.Location = New System.Drawing.Point(112, 20)
        Me.rgValorado.Name = "rgValorado"
        Me.rgValorado.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgValorado.Properties.Appearance.Options.UseBackColor = True
        Me.rgValorado.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Coste", "Coste"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Compra", "Compra"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Venta", "Venta")})
        Me.rgValorado.Size = New System.Drawing.Size(185, 26)
        Me.rgValorado.TabIndex = 1
        Me.rgValorado.Visible = False
        '
        'checkBajoMinimo
        '
        Me.checkBajoMinimo.Location = New System.Drawing.Point(5, 73)
        Me.checkBajoMinimo.Name = "checkBajoMinimo"
        Me.checkBajoMinimo.Properties.Caption = "Mostrar artículos sólo bajo mínimo"
        Me.checkBajoMinimo.Size = New System.Drawing.Size(215, 19)
        Me.checkBajoMinimo.TabIndex = 3
        Me.checkBajoMinimo.TabStop = False
        '
        'checkValorado
        '
        Me.checkValorado.Location = New System.Drawing.Point(5, 23)
        Me.checkValorado.Name = "checkValorado"
        Me.checkValorado.Properties.Caption = "Informe valorado"
        Me.checkValorado.Size = New System.Drawing.Size(118, 19)
        Me.checkValorado.TabIndex = 0
        Me.checkValorado.TabStop = False
        '
        'checkControlBaja
        '
        Me.checkControlBaja.Location = New System.Drawing.Point(5, 98)
        Me.checkControlBaja.Name = "checkControlBaja"
        Me.checkControlBaja.Properties.Caption = "Control de Baja"
        Me.checkControlBaja.Size = New System.Drawing.Size(99, 19)
        Me.checkControlBaja.TabIndex = 4
        Me.checkControlBaja.TabStop = False
        '
        'checkAgruparFamilia
        '
        Me.checkAgruparFamilia.EditValue = True
        Me.checkAgruparFamilia.Location = New System.Drawing.Point(110, 98)
        Me.checkAgruparFamilia.Name = "checkAgruparFamilia"
        Me.checkAgruparFamilia.Properties.Caption = "Agrupar por familias"
        Me.checkAgruparFamilia.Size = New System.Drawing.Size(113, 19)
        Me.checkAgruparFamilia.TabIndex = 5
        Me.checkAgruparFamilia.TabStop = False
        '
        'txtCodigoFamiliaFin
        '
        Me.txtCodigoFamiliaFin.EnterMoveNextControl = True
        Me.txtCodigoFamiliaFin.Location = New System.Drawing.Point(100, 38)
        Me.txtCodigoFamiliaFin.Name = "txtCodigoFamiliaFin"
        Me.txtCodigoFamiliaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoFamiliaFin.Properties.MaxLength = 7
        Me.txtCodigoFamiliaFin.Size = New System.Drawing.Size(78, 20)
        Me.txtCodigoFamiliaFin.TabIndex = 2
        '
        'dgArticulos
        '
        Me.dgArticulos.DataSource = Me.ListadoInventarioBindingSource
        Me.dgArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgArticulos.Location = New System.Drawing.Point(0, 182)
        Me.dgArticulos.MainView = Me.gvArticulos
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskImporte, Me.maskPrecio})
        Me.dgArticulos.Size = New System.Drawing.Size(784, 313)
        Me.dgArticulos.TabIndex = 1
        Me.dgArticulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvArticulos})
        '
        'ListadoInventarioBindingSource
        '
        Me.ListadoInventarioBindingSource.DataMember = "ListadoInventario"
        Me.ListadoInventarioBindingSource.DataSource = Me.DsListadoArticulos
        '
        'DsListadoArticulos
        '
        Me.DsListadoArticulos.DataSetName = "dsListadoArticulos"
        Me.DsListadoArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvArticulos
        '
        Me.gvArticulos.AppearancePrint.FooterPanel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvArticulos.AppearancePrint.FooterPanel.Options.UseFont = True
        Me.gvArticulos.AppearancePrint.GroupFooter.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvArticulos.AppearancePrint.GroupFooter.Options.UseFont = True
        Me.gvArticulos.AppearancePrint.GroupRow.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gvArticulos.AppearancePrint.GroupRow.Options.UseFont = True
        Me.gvArticulos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colCodigoFamilia, Me.colDescripcionFamilia, Me.colCodigoSubFamilia, Me.colDescripcionSubFamilia, Me.colCodigoProveedor, Me.colExistencias, Me.colPrecio, Me.colImporte})
        Me.gvArticulos.GridControl = Me.dgArticulos
        Me.gvArticulos.Name = "gvArticulos"
        Me.gvArticulos.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.gvArticulos.OptionsView.ShowDetailButtons = False
        Me.gvArticulos.OptionsView.ShowFooter = True
        Me.gvArticulos.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 1
        Me.colCodigo.Width = 102
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 2
        Me.colDescripcion.Width = 322
        '
        'colCodigoFamilia
        '
        Me.colCodigoFamilia.FieldName = "CodigoFamilia"
        Me.colCodigoFamilia.Name = "colCodigoFamilia"
        '
        'colDescripcionFamilia
        '
        Me.colDescripcionFamilia.FieldName = "DescripcionFamilia"
        Me.colDescripcionFamilia.Name = "colDescripcionFamilia"
        Me.colDescripcionFamilia.Visible = True
        Me.colDescripcionFamilia.VisibleIndex = 0
        Me.colDescripcionFamilia.Width = 102
        '
        'colCodigoSubFamilia
        '
        Me.colCodigoSubFamilia.FieldName = "CodigoSubFamilia"
        Me.colCodigoSubFamilia.Name = "colCodigoSubFamilia"
        '
        'colDescripcionSubFamilia
        '
        Me.colDescripcionSubFamilia.FieldName = "DescripcionSubFamilia"
        Me.colDescripcionSubFamilia.Name = "colDescripcionSubFamilia"
        '
        'colCodigoProveedor
        '
        Me.colCodigoProveedor.FieldName = "CodigoProveedor"
        Me.colCodigoProveedor.Name = "colCodigoProveedor"
        '
        'colExistencias
        '
        Me.colExistencias.AppearanceHeader.Options.UseTextOptions = True
        Me.colExistencias.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExistencias.FieldName = "Existencias"
        Me.colExistencias.MaxWidth = 80
        Me.colExistencias.MinWidth = 80
        Me.colExistencias.Name = "colExistencias"
        Me.colExistencias.Visible = True
        Me.colExistencias.VisibleIndex = 3
        Me.colExistencias.Width = 80
        '
        'colPrecio
        '
        Me.colPrecio.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrecio.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrecio.ColumnEdit = Me.maskPrecio
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.MaxWidth = 80
        Me.colPrecio.MinWidth = 80
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.Visible = True
        Me.colPrecio.VisibleIndex = 4
        Me.colPrecio.Width = 80
        '
        'maskPrecio
        '
        Me.maskPrecio.AutoHeight = False
        Me.maskPrecio.Mask.EditMask = "c3"
        Me.maskPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecio.Name = "maskPrecio"
        '
        'colImporte
        '
        Me.colImporte.AppearanceHeader.Options.UseTextOptions = True
        Me.colImporte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colImporte.Caption = "Importe"
        Me.colImporte.ColumnEdit = Me.maskImporte
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.MaxWidth = 80
        Me.colImporte.MinWidth = 80
        Me.colImporte.Name = "colImporte"
        Me.colImporte.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:c2}")})
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 5
        Me.colImporte.Width = 80
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.EditMask = "c"
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttImprimir.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttImprimir.Location = New System.Drawing.Point(637, 10)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(135, 45)
        Me.bttImprimir.TabIndex = 0
        Me.bttImprimir.Text = "Imprimir listado"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.bttCancelar)
        Me.PanelControl2.Controls.Add(Me.bttReiniciar)
        Me.PanelControl2.Controls.Add(Me.bttImprimir)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl2.Location = New System.Drawing.Point(0, 495)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(784, 67)
        Me.PanelControl2.TabIndex = 2
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(12, 10)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 2
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'bttReiniciar
        '
        Me.bttReiniciar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttReiniciar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttReiniciar.Image = Global.AydaraTPV.My.Resources.Resources._1321518972_close
        Me.bttReiniciar.Location = New System.Drawing.Point(496, 10)
        Me.bttReiniciar.Name = "bttReiniciar"
        Me.bttReiniciar.Size = New System.Drawing.Size(135, 45)
        Me.bttReiniciar.TabIndex = 1
        Me.bttReiniciar.Text = "Reiniciar búsqueda"
        '
        'InventarioArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgArticulos)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Name = "InventarioArticulos"
        Me.Text = "Listado inventario de artículos"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoSubfamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionSubfamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionSubfamiliaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoSubfamiliaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionFamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionFamiliaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcOpciones.ResumeLayout(False)
        Me.gcOpciones.PerformLayout()
        CType(Me.checkExistencia0.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkExistenciaNegativa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkExistenciaPositiva.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgValorado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBajoMinimo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkValorado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkControlBaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkAgruparFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFamiliaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListadoInventarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListadoArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoFamiliaInicio As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtDescripcionFamiliaInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcionFamiliaFin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoFamiliaFin As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtNombreProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoProveedor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rgValorado As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents checkBajoMinimo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkValorado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkControlBaja As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkAgruparFamilia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dgArticulos As DevExpress.XtraGrid.GridControl
    Friend WithEvents ListadoInventarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsListadoArticulos As AydaraTPV.dsListadoArticulos
    Friend WithEvents gvArticulos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoFamilia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionFamilia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoSubFamilia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionSubFamilia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoProveedor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExistencias As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bttReiniciar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents maskPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodigoFin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoSubfamiliaInicio As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtDescripcionSubfamiliaInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcionSubfamiliaFin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoSubfamiliaFin As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents checkExistencia0 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkExistenciaNegativa As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkExistenciaPositiva As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
End Class
