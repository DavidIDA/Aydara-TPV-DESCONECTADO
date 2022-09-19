<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fConfiguracionTPV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fConfiguracionTPV))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.txtDireccionTerminales = New DevExpress.XtraEditors.TextEdit()
        Me.IDAAYDARATPVBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTPVConfiguracion = New a3ERP_AydaraTPV.dsTPVConfiguracion()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDireccionRecepcion = New DevExpress.XtraEditors.TextEdit()
        Me.txtDireccionEnvio = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTIPIVA1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.TIPOIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTiposIVA = New a3ERP_AydaraTPV.dsTiposIVA()
        Me.IDA_AYDARATPVTableAdapter = New a3ERP_AydaraTPV.dsTPVConfiguracionTableAdapters.IDA_AYDARATPVTableAdapter()
        Me.txtTIPIVA2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtTIPIVA3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtDirectorioFicheros = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.txtEMAIL = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.bttAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCODCLIDESGLOSE = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.gcDesglosePedidos = New DevExpress.XtraEditors.GroupControl()
        Me.txtTIPIVADESGLOSE = New DevExpress.XtraEditors.LookUpEdit()
        Me.txtREGIVADESGLOSE = New DevExpress.XtraEditors.LookUpEdit()
        Me.REGIVABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTiposOperacion = New a3ERP_AydaraTPV.dsTiposOperacion()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSERIEDESGLOSE = New DevExpress.XtraEditors.LookUpEdit()
        Me.SERIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSeries = New a3ERP_AydaraTPV.dsSeries()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtDireccionTerminales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDAAYDARATPVBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTPVConfiguracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccionRecepcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccionEnvio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIPIVA1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPOIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTiposIVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIPIVA2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTIPIVA3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDirectorioFicheros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtEMAIL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCODCLIDESGLOSE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcDesglosePedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcDesglosePedidos.SuspendLayout()
        CType(Me.txtTIPIVADESGLOSE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtREGIVADESGLOSE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REGIVABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTiposOperacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSERIEDESGLOSE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtDireccionTerminales)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.txtDireccionRecepcion)
        Me.GroupControl1.Controls.Add(Me.txtDireccionEnvio)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtPassword)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtUsuario)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(454, 148)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Conexión FTP"
        '
        'txtDireccionTerminales
        '
        Me.txtDireccionTerminales.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDAAYDARATPVBindingSource, "TERMINALES", True))
        Me.txtDireccionTerminales.Location = New System.Drawing.Point(119, 120)
        Me.txtDireccionTerminales.Name = "txtDireccionTerminales"
        Me.txtDireccionTerminales.Size = New System.Drawing.Size(321, 20)
        Me.txtDireccionTerminales.TabIndex = 4
        '
        'IDAAYDARATPVBindingSource
        '
        Me.IDAAYDARATPVBindingSource.DataMember = "IDA_AYDARATPV"
        Me.IDAAYDARATPVBindingSource.DataSource = Me.DsTPVConfiguracion
        '
        'DsTPVConfiguracion
        '
        Me.DsTPVConfiguracion.DataSetName = "dsTPVConfiguracion"
        Me.DsTPVConfiguracion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(14, 123)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl13.TabIndex = 7
        Me.LabelControl13.Text = "Dirección terminales:"
        '
        'txtDireccionRecepcion
        '
        Me.txtDireccionRecepcion.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDAAYDARATPVBindingSource, "RECEPCION", True))
        Me.txtDireccionRecepcion.Location = New System.Drawing.Point(119, 94)
        Me.txtDireccionRecepcion.Name = "txtDireccionRecepcion"
        Me.txtDireccionRecepcion.Size = New System.Drawing.Size(321, 20)
        Me.txtDireccionRecepcion.TabIndex = 3
        '
        'txtDireccionEnvio
        '
        Me.txtDireccionEnvio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDAAYDARATPVBindingSource, "ENVIO", True))
        Me.txtDireccionEnvio.Location = New System.Drawing.Point(119, 66)
        Me.txtDireccionEnvio.Name = "txtDireccionEnvio"
        Me.txtDireccionEnvio.Size = New System.Drawing.Size(321, 20)
        Me.txtDireccionEnvio.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(14, 97)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(96, 13)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Dirección recepción:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(14, 69)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Dirección envío:"
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDAAYDARATPVBindingSource, "PASSWORD", True))
        Me.txtPassword.Location = New System.Drawing.Point(265, 36)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(175, 20)
        Me.txtPassword.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(209, 39)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Password:"
        '
        'txtUsuario
        '
        Me.txtUsuario.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDAAYDARATPVBindingSource, "USUARIO", True))
        Me.txtUsuario.Location = New System.Drawing.Point(60, 36)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(143, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Usuario:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(13, 34)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl5.TabIndex = 1
        Me.LabelControl5.Text = "Tipo IVA 1:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(13, 60)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl6.TabIndex = 2
        Me.LabelControl6.Text = "Tipo IVA 2:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(13, 86)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl7.TabIndex = 3
        Me.LabelControl7.Text = "Tipo IVA 3:"
        '
        'txtTIPIVA1
        '
        Me.txtTIPIVA1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDAAYDARATPVBindingSource, "TIPIVA1", True))
        Me.txtTIPIVA1.EnterMoveNextControl = True
        Me.txtTIPIVA1.Location = New System.Drawing.Point(72, 31)
        Me.txtTIPIVA1.Name = "txtTIPIVA1"
        Me.txtTIPIVA1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTIPIVA1.Properties.DataSource = Me.TIPOIVABindingSource
        Me.txtTIPIVA1.Properties.DisplayMember = "NOMTIVA"
        Me.txtTIPIVA1.Properties.NullText = ""
        Me.txtTIPIVA1.Properties.ValueMember = "TIPIVA"
        Me.txtTIPIVA1.Size = New System.Drawing.Size(368, 20)
        Me.txtTIPIVA1.TabIndex = 0
        Me.txtTIPIVA1.TabStop = False
        '
        'TIPOIVABindingSource
        '
        Me.TIPOIVABindingSource.DataMember = "TIPOIVA"
        Me.TIPOIVABindingSource.DataSource = Me.DsTiposIVA
        '
        'DsTiposIVA
        '
        Me.DsTiposIVA.DataSetName = "dsTiposIVA"
        Me.DsTiposIVA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDA_AYDARATPVTableAdapter
        '
        Me.IDA_AYDARATPVTableAdapter.ClearBeforeFill = True
        '
        'txtTIPIVA2
        '
        Me.txtTIPIVA2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDAAYDARATPVBindingSource, "TIPIVA2", True))
        Me.txtTIPIVA2.EnterMoveNextControl = True
        Me.txtTIPIVA2.Location = New System.Drawing.Point(72, 57)
        Me.txtTIPIVA2.Name = "txtTIPIVA2"
        Me.txtTIPIVA2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTIPIVA2.Properties.DataSource = Me.TIPOIVABindingSource
        Me.txtTIPIVA2.Properties.DisplayMember = "NOMTIVA"
        Me.txtTIPIVA2.Properties.NullText = ""
        Me.txtTIPIVA2.Properties.ValueMember = "TIPIVA"
        Me.txtTIPIVA2.Size = New System.Drawing.Size(368, 20)
        Me.txtTIPIVA2.TabIndex = 1
        Me.txtTIPIVA2.TabStop = False
        '
        'txtTIPIVA3
        '
        Me.txtTIPIVA3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDAAYDARATPVBindingSource, "TIPIVA3", True))
        Me.txtTIPIVA3.EnterMoveNextControl = True
        Me.txtTIPIVA3.Location = New System.Drawing.Point(72, 83)
        Me.txtTIPIVA3.Name = "txtTIPIVA3"
        Me.txtTIPIVA3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTIPIVA3.Properties.DataSource = Me.TIPOIVABindingSource
        Me.txtTIPIVA3.Properties.DisplayMember = "NOMTIVA"
        Me.txtTIPIVA3.Properties.NullText = ""
        Me.txtTIPIVA3.Properties.ValueMember = "TIPIVA"
        Me.txtTIPIVA3.Size = New System.Drawing.Size(368, 20)
        Me.txtTIPIVA3.TabIndex = 2
        Me.txtTIPIVA3.TabStop = False
        '
        'txtDirectorioFicheros
        '
        Me.txtDirectorioFicheros.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDAAYDARATPVBindingSource, "DIRECTORIO", True))
        Me.txtDirectorioFicheros.Location = New System.Drawing.Point(128, 294)
        Me.txtDirectorioFicheros.Name = "txtDirectorioFicheros"
        Me.txtDirectorioFicheros.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtDirectorioFicheros.Size = New System.Drawing.Size(324, 20)
        Me.txtDirectorioFicheros.TabIndex = 2
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(26, 297)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl10.TabIndex = 50
        Me.LabelControl10.Text = "Directorio ficheros:"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.LabelControl5)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.LabelControl7)
        Me.GroupControl3.Controls.Add(Me.txtTIPIVA1)
        Me.GroupControl3.Controls.Add(Me.txtTIPIVA2)
        Me.GroupControl3.Controls.Add(Me.txtTIPIVA3)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 166)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(454, 114)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Tipos de IVA tiendas"
        '
        'txtEMAIL
        '
        Me.txtEMAIL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDAAYDARATPVBindingSource, "EMAIL", True))
        Me.txtEMAIL.Location = New System.Drawing.Point(128, 320)
        Me.txtEMAIL.Name = "txtEMAIL"
        Me.txtEMAIL.Size = New System.Drawing.Size(324, 20)
        Me.txtEMAIL.TabIndex = 3
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(26, 323)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl20.TabIndex = 58
        Me.LabelControl20.Text = "E-Mail de contacto:"
        '
        'bttAceptar
        '
        Me.bttAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttAceptar.Image = CType(resources.GetObject("bttAceptar.Image"), System.Drawing.Image)
        Me.bttAceptar.Location = New System.Drawing.Point(370, 462)
        Me.bttAceptar.Name = "bttAceptar"
        Me.bttAceptar.Size = New System.Drawing.Size(96, 28)
        Me.bttAceptar.TabIndex = 5
        Me.bttAceptar.Text = "(F3) &Guardar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttCancelar.Image = CType(resources.GetObject("bttCancelar.Image"), System.Drawing.Image)
        Me.bttCancelar.Location = New System.Drawing.Point(12, 462)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(126, 28)
        Me.bttCancelar.TabIndex = 6
        Me.bttCancelar.Text = "(ALT+F3) &Cancelar"
        '
        'txtCODCLIDESGLOSE
        '
        Me.txtCODCLIDESGLOSE.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDAAYDARATPVBindingSource, "CODCLIDESGLOSE", True))
        Me.txtCODCLIDESGLOSE.Location = New System.Drawing.Point(57, 29)
        Me.txtCODCLIDESGLOSE.Name = "txtCODCLIDESGLOSE"
        Me.txtCODCLIDESGLOSE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCODCLIDESGLOSE.Size = New System.Drawing.Size(87, 20)
        Me.txtCODCLIDESGLOSE.TabIndex = 0
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(14, 32)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl8.TabIndex = 60
        Me.LabelControl8.Text = "Cliente:"
        '
        'gcDesglosePedidos
        '
        Me.gcDesglosePedidos.Controls.Add(Me.txtTIPIVADESGLOSE)
        Me.gcDesglosePedidos.Controls.Add(Me.txtREGIVADESGLOSE)
        Me.gcDesglosePedidos.Controls.Add(Me.LabelControl12)
        Me.gcDesglosePedidos.Controls.Add(Me.LabelControl11)
        Me.gcDesglosePedidos.Controls.Add(Me.LabelControl9)
        Me.gcDesglosePedidos.Controls.Add(Me.txtSERIEDESGLOSE)
        Me.gcDesglosePedidos.Controls.Add(Me.LabelControl8)
        Me.gcDesglosePedidos.Controls.Add(Me.txtCODCLIDESGLOSE)
        Me.gcDesglosePedidos.Location = New System.Drawing.Point(12, 357)
        Me.gcDesglosePedidos.Name = "gcDesglosePedidos"
        Me.gcDesglosePedidos.Size = New System.Drawing.Size(454, 85)
        Me.gcDesglosePedidos.TabIndex = 2
        Me.gcDesglosePedidos.Text = "Opciones desglose pedidos"
        '
        'txtTIPIVADESGLOSE
        '
        Me.txtTIPIVADESGLOSE.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDAAYDARATPVBindingSource, "TIPIVADESGLOSE", True))
        Me.txtTIPIVADESGLOSE.EnterMoveNextControl = True
        Me.txtTIPIVADESGLOSE.Location = New System.Drawing.Point(245, 55)
        Me.txtTIPIVADESGLOSE.Name = "txtTIPIVADESGLOSE"
        Me.txtTIPIVADESGLOSE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTIPIVADESGLOSE.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TIPIVA", "Tipo", 52, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMTIVA", "Descripción", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.txtTIPIVADESGLOSE.Properties.DataSource = Me.TIPOIVABindingSource
        Me.txtTIPIVADESGLOSE.Properties.DisplayMember = "NOMTIVA"
        Me.txtTIPIVADESGLOSE.Properties.NullText = ""
        Me.txtTIPIVADESGLOSE.Properties.ValueMember = "TIPIVA"
        Me.txtTIPIVADESGLOSE.Size = New System.Drawing.Size(195, 20)
        Me.txtTIPIVADESGLOSE.TabIndex = 3
        Me.txtTIPIVADESGLOSE.TabStop = False
        '
        'txtREGIVADESGLOSE
        '
        Me.txtREGIVADESGLOSE.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDAAYDARATPVBindingSource, "REGIVADESGLOSE", True))
        Me.txtREGIVADESGLOSE.EnterMoveNextControl = True
        Me.txtREGIVADESGLOSE.Location = New System.Drawing.Point(245, 29)
        Me.txtREGIVADESGLOSE.Name = "txtREGIVADESGLOSE"
        Me.txtREGIVADESGLOSE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtREGIVADESGLOSE.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("REGIVA", "Tipo", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMRIVA", "Descripción", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.txtREGIVADESGLOSE.Properties.DataSource = Me.REGIVABindingSource
        Me.txtREGIVADESGLOSE.Properties.DisplayMember = "NOMRIVA"
        Me.txtREGIVADESGLOSE.Properties.NullText = ""
        Me.txtREGIVADESGLOSE.Properties.ValueMember = "REGIVA"
        Me.txtREGIVADESGLOSE.Size = New System.Drawing.Size(195, 20)
        Me.txtREGIVADESGLOSE.TabIndex = 2
        Me.txtREGIVADESGLOSE.TabStop = False
        '
        'REGIVABindingSource
        '
        Me.REGIVABindingSource.DataMember = "REGIVA"
        Me.REGIVABindingSource.DataSource = Me.DsTiposOperacion
        '
        'DsTiposOperacion
        '
        Me.DsTiposOperacion.DataSetName = "dsTiposOperacion"
        Me.DsTiposOperacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(150, 58)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl12.TabIndex = 64
        Me.LabelControl12.Text = "Tipo de IVA/IGIC:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(150, 32)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl11.TabIndex = 63
        Me.LabelControl11.Text = "Tipo de operación:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(14, 58)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl9.TabIndex = 62
        Me.LabelControl9.Text = "Serie:"
        '
        'txtSERIEDESGLOSE
        '
        Me.txtSERIEDESGLOSE.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDAAYDARATPVBindingSource, "SERIEDESGLOSE", True))
        Me.txtSERIEDESGLOSE.EnterMoveNextControl = True
        Me.txtSERIEDESGLOSE.Location = New System.Drawing.Point(57, 55)
        Me.txtSERIEDESGLOSE.Name = "txtSERIEDESGLOSE"
        Me.txtSERIEDESGLOSE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSERIEDESGLOSE.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SERIE", "SERIE", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMSERIE", "NOMSERIE", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.txtSERIEDESGLOSE.Properties.DataSource = Me.SERIESBindingSource
        Me.txtSERIEDESGLOSE.Properties.DisplayMember = "SERIE"
        Me.txtSERIEDESGLOSE.Properties.NullText = ""
        Me.txtSERIEDESGLOSE.Properties.ValueMember = "SERIE"
        Me.txtSERIEDESGLOSE.Size = New System.Drawing.Size(87, 20)
        Me.txtSERIEDESGLOSE.TabIndex = 1
        Me.txtSERIEDESGLOSE.TabStop = False
        '
        'SERIESBindingSource
        '
        Me.SERIESBindingSource.DataMember = "SERIES"
        Me.SERIESBindingSource.DataSource = Me.DsSeries
        '
        'DsSeries
        '
        Me.DsSeries.DataSetName = "dsSeries"
        Me.DsSeries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fConfiguracionTPV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 502)
        Me.Controls.Add(Me.gcDesglosePedidos)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttAceptar)
        Me.Controls.Add(Me.txtEMAIL)
        Me.Controls.Add(Me.LabelControl20)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.txtDirectorioFicheros)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fConfiguracionTPV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración conexión TPV"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtDireccionTerminales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDAAYDARATPVBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTPVConfiguracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccionRecepcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccionEnvio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIPIVA1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPOIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTiposIVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIPIVA2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTIPIVA3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDirectorioFicheros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtEMAIL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCODCLIDESGLOSE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcDesglosePedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcDesglosePedidos.ResumeLayout(False)
        Me.gcDesglosePedidos.PerformLayout()
        CType(Me.txtTIPIVADESGLOSE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtREGIVADESGLOSE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REGIVABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTiposOperacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSERIEDESGLOSE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSeries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDireccionRecepcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDireccionEnvio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTIPIVA1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DsTiposIVA As a3ERP_AydaraTPV.dsTiposIVA
    Friend WithEvents TIPOIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTPVConfiguracion As a3ERP_AydaraTPV.dsTPVConfiguracion
    Friend WithEvents IDAAYDARATPVBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IDA_AYDARATPVTableAdapter As a3ERP_AydaraTPV.dsTPVConfiguracionTableAdapters.IDA_AYDARATPVTableAdapter
    Friend WithEvents txtTIPIVA2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTIPIVA3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDirectorioFicheros As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtEMAIL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCODCLIDESGLOSE As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcDesglosePedidos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSERIEDESGLOSE As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTIPIVADESGLOSE As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtREGIVADESGLOSE As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsSeries As a3ERP_AydaraTPV.dsSeries
    Friend WithEvents SERIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTiposOperacion As a3ERP_AydaraTPV.dsTiposOperacion
    Friend WithEvents REGIVABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtDireccionTerminales As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
End Class
