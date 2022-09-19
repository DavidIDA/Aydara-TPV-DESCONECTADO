<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescuentoTarjeta = New DevExpress.XtraEditors.TextEdit()
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsClientes = New AydaraTPV.dsClientes()
        Me.txtCaducidadTarjeta = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckControlBaja = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMovil = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTelefonos = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNIF = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProvincia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPoblacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoPostal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreFiscal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.bttModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCodigo = New DevExpress.XtraEditors.ButtonEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEmail = New DevExpress.XtraEditors.TextEdit()
        Me.gcTarjeta = New DevExpress.XtraEditors.GroupControl()
        Me.txtSaldoPuntos = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.checkTieneTarjeta = New DevExpress.XtraEditors.CheckEdit()
        Me.CLIENTESTableAdapter = New AydaraTPV.dsClientesTableAdapters.CLIENTESTableAdapter()
        Me.dgPendientesCobro = New DevExpress.XtraGrid.GridControl()
        Me.PENDIENTESCOBROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvPendientesCobro = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoTienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoCaja = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoTicket = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporteTicket = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colImporteCobrado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPendientesCobro = New DevExpress.XtraEditors.GroupControl()
        Me.PENDIENTES_COBROTableAdapter = New AydaraTPV.dsClientesTableAdapters.PENDIENTES_COBROTableAdapter()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.xtpPendiente = New DevExpress.XtraTab.XtraTabPage()
        Me.xtpObservaciones = New DevExpress.XtraTab.XtraTabPage()
        Me.txtObservaciones = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtClienteCredito = New DevExpress.XtraEditors.HyperLinkEdit()
        Me.bttTarjeta = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txtDescuentoTarjeta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaducidadTarjeta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCaducidadTarjeta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckControlBaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMovil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNIF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProvincia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPoblacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoPostal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreFiscal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcTarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcTarjeta.SuspendLayout()
        CType(Me.txtSaldoPuntos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkTieneTarjeta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPendientesCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PENDIENTESCOBROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPendientesCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPendientesCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcPendientesCobro.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.xtpPendiente.SuspendLayout()
        Me.xtpObservaciones.SuspendLayout()
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtClienteCredito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(18, 63)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl13.TabIndex = 32
        Me.LabelControl13.Text = "Descuento Tarjeta:"
        '
        'txtDescuentoTarjeta
        '
        Me.txtDescuentoTarjeta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTESBindingSource, "DescuentoTarjeta", True))
        Me.txtDescuentoTarjeta.EnterMoveNextControl = True
        Me.txtDescuentoTarjeta.Location = New System.Drawing.Point(117, 60)
        Me.txtDescuentoTarjeta.Name = "txtDescuentoTarjeta"
        Me.txtDescuentoTarjeta.Properties.Mask.EditMask = "P2"
        Me.txtDescuentoTarjeta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDescuentoTarjeta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDescuentoTarjeta.Properties.ReadOnly = True
        Me.txtDescuentoTarjeta.Size = New System.Drawing.Size(62, 20)
        Me.txtDescuentoTarjeta.TabIndex = 2
        '
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource.DataSource = Me.DsClientes
        '
        'DsClientes
        '
        Me.DsClientes.DataSetName = "dsClientes"
        Me.DsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtCaducidadTarjeta
        '
        Me.txtCaducidadTarjeta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTESBindingSource, "CaducidadTarjeta", True))
        Me.txtCaducidadTarjeta.EditValue = Nothing
        Me.txtCaducidadTarjeta.EnterMoveNextControl = True
        Me.txtCaducidadTarjeta.Location = New System.Drawing.Point(117, 34)
        Me.txtCaducidadTarjeta.Name = "txtCaducidadTarjeta"
        Me.txtCaducidadTarjeta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCaducidadTarjeta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCaducidadTarjeta.Properties.Mask.EditMask = "MM/yy"
        Me.txtCaducidadTarjeta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCaducidadTarjeta.Properties.ReadOnly = True
        Me.txtCaducidadTarjeta.Size = New System.Drawing.Size(80, 20)
        Me.txtCaducidadTarjeta.TabIndex = 1
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(18, 37)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl12.TabIndex = 29
        Me.LabelControl12.Text = "Caducidad Tarjeta:"
        '
        'CheckControlBaja
        '
        Me.CheckControlBaja.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTESBindingSource, "ControlBaja", True))
        Me.CheckControlBaja.Location = New System.Drawing.Point(556, 185)
        Me.CheckControlBaja.Name = "CheckControlBaja"
        Me.CheckControlBaja.Properties.AutoWidth = True
        Me.CheckControlBaja.Properties.Caption = "Control de baja:"
        Me.CheckControlBaja.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckControlBaja.Properties.ReadOnly = True
        Me.CheckControlBaja.Size = New System.Drawing.Size(100, 19)
        Me.CheckControlBaja.TabIndex = 5
        Me.CheckControlBaja.TabStop = False
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(317, 141)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl9.TabIndex = 21
        Me.LabelControl9.Text = "Móvil:"
        '
        'txtMovil
        '
        Me.txtMovil.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "TelMovil", True))
        Me.txtMovil.EnterMoveNextControl = True
        Me.txtMovil.Location = New System.Drawing.Point(351, 138)
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.Properties.MaxLength = 150
        Me.txtMovil.Properties.ReadOnly = True
        Me.txtMovil.Size = New System.Drawing.Size(132, 20)
        Me.txtMovil.TabIndex = 7
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(13, 141)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl8.TabIndex = 19
        Me.LabelControl8.Text = "Teléfonos:"
        '
        'txtTelefonos
        '
        Me.txtTelefonos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "TelParticular", True))
        Me.txtTelefonos.EnterMoveNextControl = True
        Me.txtTelefonos.Location = New System.Drawing.Point(88, 138)
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.Properties.MaxLength = 150
        Me.txtTelefonos.Properties.ReadOnly = True
        Me.txtTelefonos.Size = New System.Drawing.Size(223, 20)
        Me.txtTelefonos.TabIndex = 6
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(13, 167)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl7.TabIndex = 17
        Me.LabelControl7.Text = "N.I.F.:"
        '
        'txtNIF
        '
        Me.txtNIF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "CIF", True))
        Me.txtNIF.EnterMoveNextControl = True
        Me.txtNIF.Location = New System.Drawing.Point(88, 164)
        Me.txtNIF.Name = "txtNIF"
        Me.txtNIF.Properties.MaxLength = 15
        Me.txtNIF.Properties.ReadOnly = True
        Me.txtNIF.Size = New System.Drawing.Size(97, 20)
        Me.txtNIF.TabIndex = 8
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(13, 115)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl6.TabIndex = 15
        Me.LabelControl6.Text = "Provincia:"
        '
        'txtProvincia
        '
        Me.txtProvincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "Provincia", True))
        Me.txtProvincia.EnterMoveNextControl = True
        Me.txtProvincia.Location = New System.Drawing.Point(88, 112)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Properties.MaxLength = 150
        Me.txtProvincia.Properties.ReadOnly = True
        Me.txtProvincia.Size = New System.Drawing.Size(223, 20)
        Me.txtProvincia.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(158, 89)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Población:"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "Poblacion", True))
        Me.txtPoblacion.EnterMoveNextControl = True
        Me.txtPoblacion.Location = New System.Drawing.Point(213, 86)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Properties.MaxLength = 150
        Me.txtPoblacion.Properties.ReadOnly = True
        Me.txtPoblacion.Size = New System.Drawing.Size(270, 20)
        Me.txtPoblacion.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(13, 89)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Código Postal:"
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "CodigoPostal", True))
        Me.txtCodigoPostal.EnterMoveNextControl = True
        Me.txtCodigoPostal.Location = New System.Drawing.Point(88, 86)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Properties.MaxLength = 10
        Me.txtCodigoPostal.Properties.ReadOnly = True
        Me.txtCodigoPostal.Size = New System.Drawing.Size(62, 20)
        Me.txtCodigoPostal.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(13, 63)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Dirección:"
        '
        'txtDireccion
        '
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "Direccion", True))
        Me.txtDireccion.EnterMoveNextControl = True
        Me.txtDireccion.Location = New System.Drawing.Point(88, 60)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.MaxLength = 150
        Me.txtDireccion.Properties.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(395, 20)
        Me.txtDireccion.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(13, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Nombre:"
        '
        'txtNombreFiscal
        '
        Me.txtNombreFiscal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "NombreFiscal", True))
        Me.txtNombreFiscal.EnterMoveNextControl = True
        Me.txtNombreFiscal.Location = New System.Drawing.Point(88, 34)
        Me.txtNombreFiscal.Name = "txtNombreFiscal"
        Me.txtNombreFiscal.Properties.MaxLength = 150
        Me.txtNombreFiscal.Properties.ReadOnly = True
        Me.txtNombreFiscal.Size = New System.Drawing.Size(395, 20)
        Me.txtNombreFiscal.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(25, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Código:"
        '
        'bttModificar
        '
        Me.bttModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttModificar.Enabled = False
        Me.bttModificar.Image = Global.AydaraTPV.My.Resources.Resources.menu_vales
        Me.bttModificar.Location = New System.Drawing.Point(124, 509)
        Me.bttModificar.Name = "bttModificar"
        Me.bttModificar.Size = New System.Drawing.Size(106, 45)
        Me.bttModificar.TabIndex = 33
        Me.bttModificar.TabStop = False
        Me.bttModificar.Text = "Modificar"
        '
        'bttNuevo
        '
        Me.bttNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttNuevo.Image = Global.AydaraTPV.My.Resources.Resources._new
        Me.bttNuevo.Location = New System.Drawing.Point(12, 509)
        Me.bttNuevo.Name = "bttNuevo"
        Me.bttNuevo.Size = New System.Drawing.Size(106, 45)
        Me.bttNuevo.TabIndex = 8
        Me.bttNuevo.TabStop = False
        Me.bttNuevo.Text = "Nuevo"
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Enabled = False
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.save
        Me.bttGuardar.Location = New System.Drawing.Point(890, 509)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(106, 45)
        Me.bttGuardar.TabIndex = 30
        Me.bttGuardar.TabStop = False
        Me.bttGuardar.Text = "Guardar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(773, 509)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 31
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'bttEliminar
        '
        Me.bttEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttEliminar.Enabled = False
        Me.bttEliminar.Image = Global.AydaraTPV.My.Resources.Resources.delete2
        Me.bttEliminar.Location = New System.Drawing.Point(348, 509)
        Me.bttEliminar.Name = "bttEliminar"
        Me.bttEliminar.Size = New System.Drawing.Size(106, 45)
        Me.bttEliminar.TabIndex = 32
        Me.bttEliminar.TabStop = False
        Me.bttEliminar.Text = "Eliminar"
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.search
        Me.bttBuscar.Location = New System.Drawing.Point(236, 509)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(106, 45)
        Me.bttBuscar.TabIndex = 34
        Me.bttBuscar.TabStop = False
        Me.bttBuscar.Text = "Buscar"
        '
        'txtCodigo
        '
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "Codigo", True))
        Me.txtCodigo.EnterMoveNextControl = True
        Me.txtCodigo.Location = New System.Drawing.Point(68, 9)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigo.Properties.Mask.EditMask = "n0"
        Me.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCodigo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigo.Properties.MaxLength = 8
        Me.txtCodigo.Size = New System.Drawing.Size(108, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.txtEmail)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtProvincia)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtNIF)
        Me.GroupControl1.Controls.Add(Me.txtPoblacion)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtTelefonos)
        Me.GroupControl1.Controls.Add(Me.txtCodigoPostal)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtMovil)
        Me.GroupControl1.Controls.Add(Me.txtNombreFiscal)
        Me.GroupControl1.Controls.Add(Me.txtDireccion)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 35)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(502, 205)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "DATOS CLIENTE"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(191, 167)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl10.TabIndex = 23
        Me.LabelControl10.Text = "E-mail:"
        '
        'txtEmail
        '
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "Email", True))
        Me.txtEmail.EnterMoveNextControl = True
        Me.txtEmail.Location = New System.Drawing.Point(229, 164)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Properties.MaxLength = 150
        Me.txtEmail.Properties.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(254, 20)
        Me.txtEmail.TabIndex = 22
        '
        'gcTarjeta
        '
        Me.gcTarjeta.Controls.Add(Me.txtSaldoPuntos)
        Me.gcTarjeta.Controls.Add(Me.LabelControl11)
        Me.gcTarjeta.Controls.Add(Me.checkTieneTarjeta)
        Me.gcTarjeta.Controls.Add(Me.txtCaducidadTarjeta)
        Me.gcTarjeta.Controls.Add(Me.LabelControl12)
        Me.gcTarjeta.Controls.Add(Me.txtDescuentoTarjeta)
        Me.gcTarjeta.Controls.Add(Me.LabelControl13)
        Me.gcTarjeta.Location = New System.Drawing.Point(533, 35)
        Me.gcTarjeta.Name = "gcTarjeta"
        Me.gcTarjeta.Size = New System.Drawing.Size(213, 118)
        Me.gcTarjeta.TabIndex = 3
        Me.gcTarjeta.Text = "TARJETA"
        '
        'txtSaldoPuntos
        '
        Me.txtSaldoPuntos.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTESBindingSource, "SaldoPuntos", True))
        Me.txtSaldoPuntos.EnterMoveNextControl = True
        Me.txtSaldoPuntos.Location = New System.Drawing.Point(117, 86)
        Me.txtSaldoPuntos.Name = "txtSaldoPuntos"
        Me.txtSaldoPuntos.Properties.Mask.EditMask = "n2"
        Me.txtSaldoPuntos.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtSaldoPuntos.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtSaldoPuntos.Properties.ReadOnly = True
        Me.txtSaldoPuntos.Size = New System.Drawing.Size(62, 20)
        Me.txtSaldoPuntos.TabIndex = 36
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(43, 89)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl11.TabIndex = 37
        Me.LabelControl11.Text = "Saldo Tarjeta:"
        '
        'checkTieneTarjeta
        '
        Me.checkTieneTarjeta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTESBindingSource, "TieneTarjeta", True))
        Me.checkTieneTarjeta.Location = New System.Drawing.Point(55, 1)
        Me.checkTieneTarjeta.Name = "checkTieneTarjeta"
        Me.checkTieneTarjeta.Properties.Caption = ""
        Me.checkTieneTarjeta.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.checkTieneTarjeta.Properties.ReadOnly = True
        Me.checkTieneTarjeta.Size = New System.Drawing.Size(23, 19)
        Me.checkTieneTarjeta.TabIndex = 35
        Me.checkTieneTarjeta.TabStop = False
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'dgPendientesCobro
        '
        Me.dgPendientesCobro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPendientesCobro.DataSource = Me.PENDIENTESCOBROBindingSource
        Me.dgPendientesCobro.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgPendientesCobro.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgPendientesCobro.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgPendientesCobro.Location = New System.Drawing.Point(5, 4)
        Me.dgPendientesCobro.MainView = Me.gvPendientesCobro
        Me.dgPendientesCobro.Name = "dgPendientesCobro"
        Me.dgPendientesCobro.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskImporte})
        Me.dgPendientesCobro.Size = New System.Drawing.Size(963, 220)
        Me.dgPendientesCobro.TabIndex = 36
        Me.dgPendientesCobro.UseEmbeddedNavigator = True
        Me.dgPendientesCobro.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPendientesCobro})
        '
        'PENDIENTESCOBROBindingSource
        '
        Me.PENDIENTESCOBROBindingSource.DataMember = "PENDIENTES_COBRO"
        Me.PENDIENTESCOBROBindingSource.DataSource = Me.DsClientes
        '
        'gvPendientesCobro
        '
        Me.gvPendientesCobro.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoTienda, Me.colCodigoCliente, Me.colNombre, Me.colCodigoCaja, Me.colCodigoTicket, Me.colFecha, Me.colImporteTicket, Me.colImporteCobrado})
        Me.gvPendientesCobro.GridControl = Me.dgPendientesCobro
        Me.gvPendientesCobro.Name = "gvPendientesCobro"
        Me.gvPendientesCobro.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvPendientesCobro.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvPendientesCobro.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvPendientesCobro.OptionsView.ShowGroupPanel = False
        '
        'colCodigoTienda
        '
        Me.colCodigoTienda.Caption = "Código Tienda"
        Me.colCodigoTienda.FieldName = "CodigoTienda"
        Me.colCodigoTienda.Name = "colCodigoTienda"
        Me.colCodigoTienda.OptionsColumn.ReadOnly = True
        Me.colCodigoTienda.Width = 98
        '
        'colCodigoCliente
        '
        Me.colCodigoCliente.FieldName = "CodigoCliente"
        Me.colCodigoCliente.Name = "colCodigoCliente"
        Me.colCodigoCliente.OptionsColumn.ReadOnly = True
        Me.colCodigoCliente.Width = 89
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 0
        Me.colNombre.Width = 118
        '
        'colCodigoCaja
        '
        Me.colCodigoCaja.Caption = "Código Caja"
        Me.colCodigoCaja.FieldName = "CodigoCaja"
        Me.colCodigoCaja.MaxWidth = 80
        Me.colCodigoCaja.MinWidth = 80
        Me.colCodigoCaja.Name = "colCodigoCaja"
        Me.colCodigoCaja.OptionsColumn.AllowSize = False
        Me.colCodigoCaja.OptionsColumn.ReadOnly = True
        Me.colCodigoCaja.Visible = True
        Me.colCodigoCaja.VisibleIndex = 1
        Me.colCodigoCaja.Width = 80
        '
        'colCodigoTicket
        '
        Me.colCodigoTicket.Caption = "Número de Ticket"
        Me.colCodigoTicket.FieldName = "CodigoTicket"
        Me.colCodigoTicket.MaxWidth = 110
        Me.colCodigoTicket.MinWidth = 110
        Me.colCodigoTicket.Name = "colCodigoTicket"
        Me.colCodigoTicket.OptionsColumn.AllowSize = False
        Me.colCodigoTicket.OptionsColumn.ReadOnly = True
        Me.colCodigoTicket.Visible = True
        Me.colCodigoTicket.VisibleIndex = 2
        Me.colCodigoTicket.Width = 110
        '
        'colFecha
        '
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.MaxWidth = 100
        Me.colFecha.MinWidth = 100
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowSize = False
        Me.colFecha.OptionsColumn.ReadOnly = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 3
        Me.colFecha.Width = 100
        '
        'colImporteTicket
        '
        Me.colImporteTicket.ColumnEdit = Me.maskImporte
        Me.colImporteTicket.FieldName = "ImporteTicket"
        Me.colImporteTicket.MaxWidth = 110
        Me.colImporteTicket.MinWidth = 110
        Me.colImporteTicket.Name = "colImporteTicket"
        Me.colImporteTicket.OptionsColumn.AllowSize = False
        Me.colImporteTicket.OptionsColumn.ReadOnly = True
        Me.colImporteTicket.Visible = True
        Me.colImporteTicket.VisibleIndex = 4
        Me.colImporteTicket.Width = 110
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'colImporteCobrado
        '
        Me.colImporteCobrado.ColumnEdit = Me.maskImporte
        Me.colImporteCobrado.FieldName = "ImporteCobrado"
        Me.colImporteCobrado.MaxWidth = 110
        Me.colImporteCobrado.MinWidth = 110
        Me.colImporteCobrado.Name = "colImporteCobrado"
        Me.colImporteCobrado.OptionsColumn.AllowSize = False
        Me.colImporteCobrado.OptionsColumn.ReadOnly = True
        Me.colImporteCobrado.Visible = True
        Me.colImporteCobrado.VisibleIndex = 5
        Me.colImporteCobrado.Width = 110
        '
        'gcPendientesCobro
        '
        Me.gcPendientesCobro.Controls.Add(Me.dgPendientesCobro)
        Me.gcPendientesCobro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPendientesCobro.Location = New System.Drawing.Point(0, 0)
        Me.gcPendientesCobro.Name = "gcPendientesCobro"
        Me.gcPendientesCobro.ShowCaption = False
        Me.gcPendientesCobro.Size = New System.Drawing.Size(973, 229)
        Me.gcPendientesCobro.TabIndex = 36
        Me.gcPendientesCobro.Text = "PENDIENTE DE COBRO"
        '
        'PENDIENTES_COBROTableAdapter
        '
        Me.PENDIENTES_COBROTableAdapter.ClearBeforeFill = True
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 246)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.xtpPendiente
        Me.XtraTabControl1.Size = New System.Drawing.Size(979, 257)
        Me.XtraTabControl1.TabIndex = 4
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.xtpPendiente, Me.xtpObservaciones})
        '
        'xtpPendiente
        '
        Me.xtpPendiente.Controls.Add(Me.gcPendientesCobro)
        Me.xtpPendiente.Name = "xtpPendiente"
        Me.xtpPendiente.Size = New System.Drawing.Size(973, 229)
        Me.xtpPendiente.Text = "Pendiente de Cobro"
        '
        'xtpObservaciones
        '
        Me.xtpObservaciones.Controls.Add(Me.txtObservaciones)
        Me.xtpObservaciones.Name = "xtpObservaciones"
        Me.xtpObservaciones.Size = New System.Drawing.Size(973, 229)
        Me.xtpObservaciones.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "Observaciones", True))
        Me.txtObservaciones.Location = New System.Drawing.Point(3, 3)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Properties.ReadOnly = True
        Me.txtObservaciones.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtObservaciones.Size = New System.Drawing.Size(748, 203)
        Me.txtObservaciones.TabIndex = 0
        Me.txtObservaciones.UseOptimizedRendering = True
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(559, 214)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl14.TabIndex = 39
        Me.LabelControl14.Text = "Cliente crédito:"
        '
        'txtClienteCredito
        '
        Me.txtClienteCredito.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTESBindingSource, "ClienteCredito", True))
        Me.txtClienteCredito.Location = New System.Drawing.Point(639, 210)
        Me.txtClienteCredito.Name = "txtClienteCredito"
        Me.txtClienteCredito.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtClienteCredito.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", "Buscar", Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtClienteCredito.Properties.Buttons1"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", "Nuevo", Nothing, True)})
        Me.txtClienteCredito.Size = New System.Drawing.Size(111, 20)
        Me.txtClienteCredito.TabIndex = 6
        '
        'bttTarjeta
        '
        Me.bttTarjeta.Enabled = False
        Me.bttTarjeta.Image = Global.AydaraTPV.My.Resources.Resources.cobrosCliente
        Me.bttTarjeta.Location = New System.Drawing.Point(773, 35)
        Me.bttTarjeta.Name = "bttTarjeta"
        Me.bttTarjeta.Size = New System.Drawing.Size(151, 45)
        Me.bttTarjeta.TabIndex = 40
        Me.bttTarjeta.TabStop = False
        Me.bttTarjeta.Text = "Asignar tarjeta"
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 566)
        Me.Controls.Add(Me.bttTarjeta)
        Me.Controls.Add(Me.txtClienteCredito)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.gcTarjeta)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.bttBuscar)
        Me.Controls.Add(Me.bttModificar)
        Me.Controls.Add(Me.bttNuevo)
        Me.Controls.Add(Me.bttGuardar)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttEliminar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.CheckControlBaja)
        Me.KeyPreview = True
        Me.Name = "Clientes"
        Me.Text = "Tarjetas"
        CType(Me.txtDescuentoTarjeta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaducidadTarjeta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCaducidadTarjeta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckControlBaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMovil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNIF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProvincia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPoblacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoPostal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreFiscal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtEmail.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcTarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcTarjeta.ResumeLayout(False)
        Me.gcTarjeta.PerformLayout()
        CType(Me.txtSaldoPuntos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkTieneTarjeta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPendientesCobro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PENDIENTESCOBROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPendientesCobro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPendientesCobro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcPendientesCobro.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.xtpPendiente.ResumeLayout(False)
        Me.xtpObservaciones.ResumeLayout(False)
        CType(Me.txtObservaciones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtClienteCredito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsClientes As AydaraTPV.dsClientes
    Friend WithEvents CLIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTESTableAdapter As AydaraTPV.dsClientesTableAdapters.CLIENTESTableAdapter
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreFiscal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProvincia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPoblacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoPostal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMovil As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefonos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNIF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckControlBaja As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescuentoTarjeta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCaducidadTarjeta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents bttNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcTarjeta As DevExpress.XtraEditors.GroupControl
    Friend WithEvents checkTieneTarjeta As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents dgPendientesCobro As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPendientesCobro As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoTienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCaja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoTicket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporteTicket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporteCobrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcPendientesCobro As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PENDIENTESCOBROBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PENDIENTES_COBROTableAdapter As AydaraTPV.dsClientesTableAdapters.PENDIENTES_COBROTableAdapter
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents xtpPendiente As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents xtpObservaciones As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEmail As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtObservaciones As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtSaldoPuntos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtClienteCredito As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents bttTarjeta As DevExpress.XtraEditors.SimpleButton
End Class
