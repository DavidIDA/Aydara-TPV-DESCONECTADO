<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fClienteCredito
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtProvincia = New DevExpress.XtraEditors.TextEdit()
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
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreComercial = New DevExpress.XtraEditors.TextEdit()
        Me.txtDtoFidelizacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckControlBaja = New DevExpress.XtraEditors.CheckEdit()
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtCuentaExt = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.CLICREDIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsClientes = New AydaraTPV.dsClientes()
        Me.CLICREDITableAdapter = New AydaraTPV.dsClientesTableAdapters.CLICREDITableAdapter()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescCar1 = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txtProvincia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNIF.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPoblacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoPostal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreFiscal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreComercial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDtoFidelizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckControlBaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaExt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLICREDIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescCar1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl2.TabIndex = 26
        Me.LabelControl2.Text = "Nombre fiscal:"
        '
        'txtProvincia
        '
        Me.txtProvincia.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLICREDIBindingSource, "Provincia", True))
        Me.txtProvincia.EnterMoveNextControl = True
        Me.txtProvincia.Location = New System.Drawing.Point(86, 142)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Properties.MaxLength = 30
        Me.txtProvincia.Size = New System.Drawing.Size(223, 20)
        Me.txtProvincia.TabIndex = 6
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(12, 145)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl6.TabIndex = 36
        Me.LabelControl6.Text = "Provincia:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(156, 119)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl5.TabIndex = 35
        Me.LabelControl5.Text = "Población:"
        '
        'txtNIF
        '
        Me.txtNIF.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLICREDIBindingSource, "Nif", True))
        Me.txtNIF.EnterMoveNextControl = True
        Me.txtNIF.Location = New System.Drawing.Point(354, 142)
        Me.txtNIF.Name = "txtNIF"
        Me.txtNIF.Properties.MaxLength = 15
        Me.txtNIF.Size = New System.Drawing.Size(134, 20)
        Me.txtNIF.TabIndex = 7
        '
        'txtPoblacion
        '
        Me.txtPoblacion.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLICREDIBindingSource, "Poblacion", True))
        Me.txtPoblacion.EnterMoveNextControl = True
        Me.txtPoblacion.Location = New System.Drawing.Point(211, 116)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Properties.MaxLength = 50
        Me.txtPoblacion.Size = New System.Drawing.Size(277, 20)
        Me.txtPoblacion.TabIndex = 5
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(315, 145)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl7.TabIndex = 37
        Me.LabelControl7.Text = "N.I.F.:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 119)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl4.TabIndex = 34
        Me.LabelControl4.Text = "Código Postal:"
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLICREDIBindingSource, "CodigoPostal", True))
        Me.txtCodigoPostal.EnterMoveNextControl = True
        Me.txtCodigoPostal.Location = New System.Drawing.Point(86, 116)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Properties.MaxLength = 5
        Me.txtCodigoPostal.Size = New System.Drawing.Size(62, 20)
        Me.txtCodigoPostal.TabIndex = 4
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 93)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 33
        Me.LabelControl3.Text = "Dirección:"
        '
        'txtNombreFiscal
        '
        Me.txtNombreFiscal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLICREDIBindingSource, "NombreFiscal", True))
        Me.txtNombreFiscal.EnterMoveNextControl = True
        Me.txtNombreFiscal.Location = New System.Drawing.Point(86, 38)
        Me.txtNombreFiscal.Name = "txtNombreFiscal"
        Me.txtNombreFiscal.Properties.MaxLength = 50
        Me.txtNombreFiscal.Size = New System.Drawing.Size(402, 20)
        Me.txtNombreFiscal.TabIndex = 1
        '
        'txtDireccion
        '
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLICREDIBindingSource, "Direccion", True))
        Me.txtDireccion.EnterMoveNextControl = True
        Me.txtDireccion.Location = New System.Drawing.Point(86, 90)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.MaxLength = 50
        Me.txtDireccion.Size = New System.Drawing.Size(402, 20)
        Me.txtDireccion.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLICREDIBindingSource, "Codigo", True))
        Me.txtCodigo.EnterMoveNextControl = True
        Me.txtCodigo.Location = New System.Drawing.Point(86, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.MaxLength = 15
        Me.txtCodigo.Properties.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(97, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 43
        Me.LabelControl1.Text = "Código:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(12, 67)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl11.TabIndex = 45
        Me.LabelControl11.Text = "Nombre Cial:"
        '
        'txtNombreComercial
        '
        Me.txtNombreComercial.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLICREDIBindingSource, "NombreComercial", True))
        Me.txtNombreComercial.EnterMoveNextControl = True
        Me.txtNombreComercial.Location = New System.Drawing.Point(86, 64)
        Me.txtNombreComercial.Name = "txtNombreComercial"
        Me.txtNombreComercial.Properties.MaxLength = 50
        Me.txtNombreComercial.Size = New System.Drawing.Size(402, 20)
        Me.txtNombreComercial.TabIndex = 2
        '
        'txtDtoFidelizacion
        '
        Me.txtDtoFidelizacion.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLICREDIBindingSource, "DescuentoPP", True))
        Me.txtDtoFidelizacion.EnterMoveNextControl = True
        Me.txtDtoFidelizacion.Location = New System.Drawing.Point(86, 194)
        Me.txtDtoFidelizacion.Name = "txtDtoFidelizacion"
        Me.txtDtoFidelizacion.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDtoFidelizacion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDtoFidelizacion.Properties.Mask.EditMask = "P2"
        Me.txtDtoFidelizacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDtoFidelizacion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDtoFidelizacion.Size = New System.Drawing.Size(60, 20)
        Me.txtDtoFidelizacion.TabIndex = 10
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(12, 197)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl28.TabIndex = 103
        Me.LabelControl28.Text = "Descuento PP:"
        '
        'CheckControlBaja
        '
        Me.CheckControlBaja.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLICREDIBindingSource, "RecargoEquivalencia", True))
        Me.CheckControlBaja.Location = New System.Drawing.Point(152, 195)
        Me.CheckControlBaja.Name = "CheckControlBaja"
        Me.CheckControlBaja.Properties.AutoWidth = True
        Me.CheckControlBaja.Properties.Caption = "Recargo de equivalencia"
        Me.CheckControlBaja.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckControlBaja.Size = New System.Drawing.Size(139, 19)
        Me.CheckControlBaja.TabIndex = 11
        Me.CheckControlBaja.TabStop = False
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.save
        Me.bttGuardar.Location = New System.Drawing.Point(382, 241)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(106, 45)
        Me.bttGuardar.TabIndex = 12
        Me.bttGuardar.TabStop = False
        Me.bttGuardar.Text = "Guardar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(12, 241)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 13
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'txtCuentaExt
        '
        Me.txtCuentaExt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLICREDIBindingSource, "CuentaExt", True))
        Me.txtCuentaExt.EnterMoveNextControl = True
        Me.txtCuentaExt.Location = New System.Drawing.Point(86, 168)
        Me.txtCuentaExt.Name = "txtCuentaExt"
        Me.txtCuentaExt.Properties.MaxLength = 30
        Me.txtCuentaExt.Size = New System.Drawing.Size(223, 20)
        Me.txtCuentaExt.TabIndex = 8
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(12, 171)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl8.TabIndex = 105
        Me.LabelControl8.Text = "Cuenta Cte.:"
        '
        'CLICREDIBindingSource
        '
        Me.CLICREDIBindingSource.DataMember = "CLICREDI"
        Me.CLICREDIBindingSource.DataSource = Me.DsClientes
        '
        'DsClientes
        '
        Me.DsClientes.DataSetName = "dsClientes"
        Me.DsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLICREDITableAdapter
        '
        Me.CLICREDITableAdapter.ClearBeforeFill = True
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(315, 171)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl9.TabIndex = 106
        Me.LabelControl9.Text = "Cliente CND:"
        '
        'txtDescCar1
        '
        Me.txtDescCar1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CLICREDIBindingSource, "DescCar1", True))
        Me.txtDescCar1.EnterMoveNextControl = True
        Me.txtDescCar1.Location = New System.Drawing.Point(382, 168)
        Me.txtDescCar1.Name = "txtDescCar1"
        Me.txtDescCar1.Properties.MaxLength = 15
        Me.txtDescCar1.Size = New System.Drawing.Size(106, 20)
        Me.txtDescCar1.TabIndex = 9
        '
        'fClienteCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 298)
        Me.Controls.Add(Me.txtDescCar1)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtCuentaExt)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.bttGuardar)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.CheckControlBaja)
        Me.Controls.Add(Me.txtDtoFidelizacion)
        Me.Controls.Add(Me.LabelControl28)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtNombreComercial)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtProvincia)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtNIF)
        Me.Controls.Add(Me.txtPoblacion)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtCodigoPostal)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtNombreFiscal)
        Me.Controls.Add(Me.txtDireccion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fClienteCredito"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cliente crédito"
        CType(Me.txtProvincia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNIF.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPoblacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoPostal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreFiscal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreComercial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDtoFidelizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckControlBaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaExt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLICREDIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescCar1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsClientes As AydaraTPV.dsClientes
    Friend WithEvents CLICREDIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLICREDITableAdapter As AydaraTPV.dsClientesTableAdapters.CLICREDITableAdapter
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreComercial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDtoFidelizacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckControlBaja As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCuentaExt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescCar1 As DevExpress.XtraEditors.TextEdit
End Class
