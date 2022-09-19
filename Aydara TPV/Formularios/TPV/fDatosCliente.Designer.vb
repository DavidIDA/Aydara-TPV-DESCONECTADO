<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fDatosCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fDatosCliente))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProvincia = New DevExpress.XtraEditors.TextEdit()
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsClientes = New AydaraTPV.dsClientes()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNIF = New DevExpress.XtraEditors.TextEdit()
        Me.txtPoblacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoPostal = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreFiscal = New DevExpress.XtraEditors.TextEdit()
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit()
        Me.bttAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttTeclado = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CLIENTESTableAdapter = New AydaraTPV.dsClientesTableAdapters.CLIENTESTableAdapter()
        CType(Me.txtProvincia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNIF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPoblacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoPostal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreFiscal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(13, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl2.TabIndex = 26
        Me.LabelControl2.Text = "Nombre fiscal:"
        '
        'txtProvincia
        '
        Me.txtProvincia.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTESBindingSource, "Provincia", True))
        Me.txtProvincia.EnterMoveNextControl = True
        Me.txtProvincia.Location = New System.Drawing.Point(87, 111)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Properties.MaxLength = 30
        Me.txtProvincia.Size = New System.Drawing.Size(223, 20)
        Me.txtProvincia.TabIndex = 4
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
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(13, 114)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl6.TabIndex = 36
        Me.LabelControl6.Text = "Provincia:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(157, 88)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl5.TabIndex = 35
        Me.LabelControl5.Text = "Población:"
        '
        'txtNIF
        '
        Me.txtNIF.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTESBindingSource, "CIF", True))
        Me.txtNIF.EnterMoveNextControl = True
        Me.txtNIF.Location = New System.Drawing.Point(352, 111)
        Me.txtNIF.Name = "txtNIF"
        Me.txtNIF.Properties.MaxLength = 15
        Me.txtNIF.Size = New System.Drawing.Size(108, 20)
        Me.txtNIF.TabIndex = 5
        '
        'txtPoblacion
        '
        Me.txtPoblacion.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTESBindingSource, "Poblacion", True))
        Me.txtPoblacion.EnterMoveNextControl = True
        Me.txtPoblacion.Location = New System.Drawing.Point(212, 85)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Properties.MaxLength = 50
        Me.txtPoblacion.Size = New System.Drawing.Size(248, 20)
        Me.txtPoblacion.TabIndex = 3
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(316, 114)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl7.TabIndex = 37
        Me.LabelControl7.Text = "N.I.F.:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(13, 88)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl4.TabIndex = 34
        Me.LabelControl4.Text = "Código Postal:"
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTESBindingSource, "CodigoPostal", True))
        Me.txtCodigoPostal.EnterMoveNextControl = True
        Me.txtCodigoPostal.Location = New System.Drawing.Point(87, 85)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Properties.MaxLength = 5
        Me.txtCodigoPostal.Size = New System.Drawing.Size(62, 20)
        Me.txtCodigoPostal.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(13, 62)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 33
        Me.LabelControl3.Text = "Dirección:"
        '
        'txtNombreFiscal
        '
        Me.txtNombreFiscal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTESBindingSource, "NombreFiscal", True))
        Me.txtNombreFiscal.EnterMoveNextControl = True
        Me.txtNombreFiscal.Location = New System.Drawing.Point(87, 33)
        Me.txtNombreFiscal.Name = "txtNombreFiscal"
        Me.txtNombreFiscal.Properties.MaxLength = 50
        Me.txtNombreFiscal.Size = New System.Drawing.Size(373, 20)
        Me.txtNombreFiscal.TabIndex = 0
        '
        'txtDireccion
        '
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLIENTESBindingSource, "Direccion", True))
        Me.txtDireccion.EnterMoveNextControl = True
        Me.txtDireccion.Location = New System.Drawing.Point(87, 59)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.MaxLength = 50
        Me.txtDireccion.Size = New System.Drawing.Size(373, 20)
        Me.txtDireccion.TabIndex = 1
        '
        'bttAceptar
        '
        Me.bttAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttAceptar.Appearance.Options.UseFont = True
        Me.bttAceptar.Image = CType(resources.GetObject("bttAceptar.Image"), System.Drawing.Image)
        Me.bttAceptar.Location = New System.Drawing.Point(364, 173)
        Me.bttAceptar.Name = "bttAceptar"
        Me.bttAceptar.Size = New System.Drawing.Size(124, 65)
        Me.bttAceptar.TabIndex = 2
        Me.bttAceptar.TabStop = False
        Me.bttAceptar.Text = "Aceptar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCancelar.Appearance.Options.UseFont = True
        Me.bttCancelar.Image = CType(resources.GetObject("bttCancelar.Image"), System.Drawing.Image)
        Me.bttCancelar.Location = New System.Drawing.Point(12, 173)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(121, 65)
        Me.bttCancelar.TabIndex = 3
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Cancelar"
        '
        'bttTeclado
        '
        Me.bttTeclado.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bttTeclado.Image = Global.AydaraTPV.My.Resources.Resources.keyboard
        Me.bttTeclado.Location = New System.Drawing.Point(221, 173)
        Me.bttTeclado.Name = "bttTeclado"
        Me.bttTeclado.Size = New System.Drawing.Size(75, 65)
        Me.bttTeclado.TabIndex = 4
        Me.bttTeclado.TabStop = False
        Me.bttTeclado.Tag = "1"
        Me.bttTeclado.Text = "Teclado"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtDireccion)
        Me.GroupControl1.Controls.Add(Me.txtNombreFiscal)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtCodigoPostal)
        Me.GroupControl1.Controls.Add(Me.txtProvincia)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtPoblacion)
        Me.GroupControl1.Controls.Add(Me.txtNIF)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(476, 143)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Datos cliente"
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'fDatosCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 250)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.bttTeclado)
        Me.Controls.Add(Me.bttAceptar)
        Me.Controls.Add(Me.bttCancelar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fDatosCliente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Datos cliente"
        CType(Me.txtProvincia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNIF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPoblacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoPostal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreFiscal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProvincia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNIF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPoblacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoPostal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreFiscal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttTeclado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents DsClientes As AydaraTPV.dsClientes
    Friend WithEvents CLIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTESTableAdapter As AydaraTPV.dsClientesTableAdapters.CLIENTESTableAdapter
End Class
