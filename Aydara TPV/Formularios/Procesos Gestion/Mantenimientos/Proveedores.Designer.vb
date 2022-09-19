<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Me.bttNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.txtPersonaContacto = New DevExpress.XtraEditors.TextEdit
        Me.PROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProveedores = New AydaraTPV.dsProveedores
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtFax = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtMovil = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtTelefonos = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.txtNIF = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtProvincia = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtPoblacion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodigoPostal = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit
        Me.bttEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtNombreFiscal = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.bttModificar = New DevExpress.XtraEditors.SimpleButton
        Me.txtCodigo = New DevExpress.XtraEditors.ButtonEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.PROVEEDORESTableAdapter = New AydaraTPV.dsProveedoresTableAdapters.PROVEEDORESTableAdapter
        CType(Me.txtPersonaContacto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SuspendLayout()
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
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(14, 193)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl11.TabIndex = 25
        Me.LabelControl11.Text = "Persona de contacto:"
        '
        'txtPersonaContacto
        '
        Me.txtPersonaContacto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "Contacto", True))
        Me.txtPersonaContacto.EnterMoveNextControl = True
        Me.txtPersonaContacto.Location = New System.Drawing.Point(121, 190)
        Me.txtPersonaContacto.Name = "txtPersonaContacto"
        Me.txtPersonaContacto.Properties.MaxLength = 50
        Me.txtPersonaContacto.Properties.ReadOnly = True
        Me.txtPersonaContacto.Size = New System.Drawing.Size(409, 20)
        Me.txtPersonaContacto.TabIndex = 10
        '
        'PROVEEDORESBindingSource
        '
        Me.PROVEEDORESBindingSource.DataMember = "PROVEEDORES"
        Me.PROVEEDORESBindingSource.DataSource = Me.DsProveedores
        '
        'DsProveedores
        '
        Me.DsProveedores.DataSetName = "dsProveedores"
        Me.DsProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(508, 167)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl10.TabIndex = 23
        Me.LabelControl10.Text = "Fax:"
        '
        'txtFax
        '
        Me.txtFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "Fax", True))
        Me.txtFax.EnterMoveNextControl = True
        Me.txtFax.Location = New System.Drawing.Point(536, 164)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Properties.MaxLength = 30
        Me.txtFax.Properties.ReadOnly = True
        Me.txtFax.Size = New System.Drawing.Size(103, 20)
        Me.txtFax.TabIndex = 9
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(360, 167)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl9.TabIndex = 21
        Me.LabelControl9.Text = "Móvil:"
        '
        'txtMovil
        '
        Me.txtMovil.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "TelMovil", True))
        Me.txtMovil.EnterMoveNextControl = True
        Me.txtMovil.Location = New System.Drawing.Point(394, 164)
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.Properties.MaxLength = 30
        Me.txtMovil.Properties.ReadOnly = True
        Me.txtMovil.Size = New System.Drawing.Size(108, 20)
        Me.txtMovil.TabIndex = 8
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(14, 167)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl8.TabIndex = 19
        Me.LabelControl8.Text = "Teléfonos:"
        '
        'txtTelefonos
        '
        Me.txtTelefonos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "Telefono", True))
        Me.txtTelefonos.EnterMoveNextControl = True
        Me.txtTelefonos.Location = New System.Drawing.Point(121, 164)
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.Properties.MaxLength = 30
        Me.txtTelefonos.Properties.ReadOnly = True
        Me.txtTelefonos.Size = New System.Drawing.Size(233, 20)
        Me.txtTelefonos.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(14, 141)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl7.TabIndex = 17
        Me.LabelControl7.Text = "N.I.F.:"
        '
        'txtNIF
        '
        Me.txtNIF.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "CIF", True))
        Me.txtNIF.EnterMoveNextControl = True
        Me.txtNIF.Location = New System.Drawing.Point(121, 138)
        Me.txtNIF.Name = "txtNIF"
        Me.txtNIF.Properties.MaxLength = 15
        Me.txtNIF.Properties.ReadOnly = True
        Me.txtNIF.Size = New System.Drawing.Size(97, 20)
        Me.txtNIF.TabIndex = 6
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(14, 115)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl6.TabIndex = 15
        Me.LabelControl6.Text = "Provincia:"
        '
        'txtProvincia
        '
        Me.txtProvincia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "Provincia", True))
        Me.txtProvincia.EnterMoveNextControl = True
        Me.txtProvincia.Location = New System.Drawing.Point(121, 112)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Properties.MaxLength = 30
        Me.txtProvincia.Properties.ReadOnly = True
        Me.txtProvincia.Size = New System.Drawing.Size(223, 20)
        Me.txtProvincia.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(189, 89)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Población:"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "Poblacion", True))
        Me.txtPoblacion.EnterMoveNextControl = True
        Me.txtPoblacion.Location = New System.Drawing.Point(244, 86)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Properties.MaxLength = 30
        Me.txtPoblacion.Properties.ReadOnly = True
        Me.txtPoblacion.Size = New System.Drawing.Size(286, 20)
        Me.txtPoblacion.TabIndex = 4
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(14, 89)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Código Postal:"
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "CodigoPostal", True))
        Me.txtCodigoPostal.EnterMoveNextControl = True
        Me.txtCodigoPostal.Location = New System.Drawing.Point(121, 86)
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Properties.MaxLength = 5
        Me.txtCodigoPostal.Properties.ReadOnly = True
        Me.txtCodigoPostal.Size = New System.Drawing.Size(62, 20)
        Me.txtCodigoPostal.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(14, 63)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Dirección:"
        '
        'txtDireccion
        '
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "Direccion", True))
        Me.txtDireccion.EnterMoveNextControl = True
        Me.txtDireccion.Location = New System.Drawing.Point(121, 60)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.MaxLength = 50
        Me.txtDireccion.Properties.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(409, 20)
        Me.txtDireccion.TabIndex = 2
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
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(562, 509)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 31
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Enabled = False
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.save
        Me.bttGuardar.Location = New System.Drawing.Point(674, 509)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(106, 45)
        Me.bttGuardar.TabIndex = 30
        Me.bttGuardar.TabStop = False
        Me.bttGuardar.Text = "Guardar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Nombre fiscal:"
        '
        'txtNombreFiscal
        '
        Me.txtNombreFiscal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "Nombre", True))
        Me.txtNombreFiscal.EnterMoveNextControl = True
        Me.txtNombreFiscal.Location = New System.Drawing.Point(121, 34)
        Me.txtNombreFiscal.Name = "txtNombreFiscal"
        Me.txtNombreFiscal.Properties.MaxLength = 50
        Me.txtNombreFiscal.Properties.ReadOnly = True
        Me.txtNombreFiscal.Size = New System.Drawing.Size(409, 20)
        Me.txtNombreFiscal.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Código:"
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.search
        Me.bttBuscar.Location = New System.Drawing.Point(236, 509)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(106, 45)
        Me.bttBuscar.TabIndex = 36
        Me.bttBuscar.TabStop = False
        Me.bttBuscar.Text = "Buscar"
        '
        'bttModificar
        '
        Me.bttModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttModificar.Enabled = False
        Me.bttModificar.Image = Global.AydaraTPV.My.Resources.Resources.menu_vales
        Me.bttModificar.Location = New System.Drawing.Point(124, 509)
        Me.bttModificar.Name = "bttModificar"
        Me.bttModificar.Size = New System.Drawing.Size(106, 45)
        Me.bttModificar.TabIndex = 35
        Me.bttModificar.TabStop = False
        Me.bttModificar.Text = "Modificar"
        '
        'txtCodigo
        '
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PROVEEDORESBindingSource, "Codigo", True))
        Me.txtCodigo.EnterMoveNextControl = True
        Me.txtCodigo.Location = New System.Drawing.Point(55, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigo.Properties.Mask.EditMask = "00000"
        Me.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCodigo.Size = New System.Drawing.Size(62, 20)
        Me.txtCodigo.TabIndex = 37
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtNombreFiscal)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtDireccion)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txtPoblacion)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtPersonaContacto)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.txtNIF)
        Me.GroupControl1.Controls.Add(Me.txtCodigoPostal)
        Me.GroupControl1.Controls.Add(Me.txtProvincia)
        Me.GroupControl1.Controls.Add(Me.txtFax)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txtTelefonos)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txtMovil)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 52)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(667, 229)
        Me.GroupControl1.TabIndex = 38
        Me.GroupControl1.Text = "DATOS PROVEEDOR"
        '
        'PROVEEDORESTableAdapter
        '
        Me.PROVEEDORESTableAdapter.ClearBeforeFill = True
        '
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.bttBuscar)
        Me.Controls.Add(Me.bttModificar)
        Me.Controls.Add(Me.bttNuevo)
        Me.Controls.Add(Me.bttEliminar)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttGuardar)
        Me.Controls.Add(Me.LabelControl1)
        Me.KeyPreview = True
        Me.Name = "Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Proveedores"
        CType(Me.txtPersonaContacto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMovil As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefonos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNIF As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPersonaContacto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DsProveedores As AydaraTPV.dsProveedores
    Friend WithEvents PROVEEDORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROVEEDORESTableAdapter As AydaraTPV.dsProveedoresTableAdapters.PROVEEDORESTableAdapter
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
