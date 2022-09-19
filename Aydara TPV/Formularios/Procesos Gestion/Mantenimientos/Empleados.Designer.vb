<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Me.txtNombreTicket = New DevExpress.XtraEditors.TextEdit
        Me.EMPLEADOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpleados = New AydaraTPV.dsEmpleados
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtTelefonos = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtPoblacion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtDireccion = New DevExpress.XtraEditors.TextEdit
        Me.bttEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtNombre = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodigo = New DevExpress.XtraEditors.ButtonEdit
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.bttModificar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.EMPLEADOSTableAdapter = New AydaraTPV.dsEmpleadosTableAdapters.OPERARIOSTableAdapter
        CType(Me.txtNombreTicket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTelefonos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPoblacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LabelControl11.Location = New System.Drawing.Point(20, 141)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl11.TabIndex = 25
        Me.LabelControl11.Text = "Nombre Ticket:"
        '
        'txtNombreTicket
        '
        Me.txtNombreTicket.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOSBindingSource, "NombreTicket", True))
        Me.txtNombreTicket.EnterMoveNextControl = True
        Me.txtNombreTicket.Location = New System.Drawing.Point(98, 138)
        Me.txtNombreTicket.Name = "txtNombreTicket"
        Me.txtNombreTicket.Properties.MaxLength = 20
        Me.txtNombreTicket.Properties.ReadOnly = True
        Me.txtNombreTicket.Size = New System.Drawing.Size(164, 20)
        Me.txtNombreTicket.TabIndex = 5
        '
        'EMPLEADOSBindingSource
        '
        Me.EMPLEADOSBindingSource.DataMember = "OPERARIOS"
        Me.EMPLEADOSBindingSource.DataSource = Me.DsEmpleados
        '
        'DsEmpleados
        '
        Me.DsEmpleados.DataSetName = "dsEmpleados"
        Me.DsEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(20, 115)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl8.TabIndex = 19
        Me.LabelControl8.Text = "Teléfonos:"
        '
        'txtTelefonos
        '
        Me.txtTelefonos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOSBindingSource, "Telefono", True))
        Me.txtTelefonos.EnterMoveNextControl = True
        Me.txtTelefonos.Location = New System.Drawing.Point(98, 112)
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.Properties.MaxLength = 30
        Me.txtTelefonos.Properties.ReadOnly = True
        Me.txtTelefonos.Size = New System.Drawing.Size(233, 20)
        Me.txtTelefonos.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(20, 89)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Población:"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOSBindingSource, "Poblacion", True))
        Me.txtPoblacion.EnterMoveNextControl = True
        Me.txtPoblacion.Location = New System.Drawing.Point(98, 86)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Properties.MaxLength = 30
        Me.txtPoblacion.Properties.ReadOnly = True
        Me.txtPoblacion.Size = New System.Drawing.Size(233, 20)
        Me.txtPoblacion.TabIndex = 3
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(20, 63)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Dirección:"
        '
        'txtDireccion
        '
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOSBindingSource, "Direccion", True))
        Me.txtDireccion.EnterMoveNextControl = True
        Me.txtDireccion.Location = New System.Drawing.Point(98, 60)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Properties.MaxLength = 50
        Me.txtDireccion.Properties.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(349, 20)
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
        Me.LabelControl2.Location = New System.Drawing.Point(20, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl2.TabIndex = 33
        Me.LabelControl2.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMPLEADOSBindingSource, "Nombre", True))
        Me.txtNombre.EnterMoveNextControl = True
        Me.txtNombre.Location = New System.Drawing.Point(98, 34)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Properties.MaxLength = 50
        Me.txtNombre.Properties.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(349, 20)
        Me.txtNombre.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Código:"
        '
        'txtCodigo
        '
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.EMPLEADOSBindingSource, "Codigo", True))
        Me.txtCodigo.EnterMoveNextControl = True
        Me.txtCodigo.Location = New System.Drawing.Point(55, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigo.Properties.Mask.EditMask = "00"
        Me.txtCodigo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCodigo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigo.Size = New System.Drawing.Size(62, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.search
        Me.bttBuscar.Location = New System.Drawing.Point(236, 509)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(106, 45)
        Me.bttBuscar.TabIndex = 37
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
        Me.bttModificar.TabIndex = 36
        Me.bttModificar.TabStop = False
        Me.bttModificar.Text = "Modificar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtNombre)
        Me.GroupControl1.Controls.Add(Me.txtDireccion)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txtPoblacion)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.txtNombreTicket)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txtTelefonos)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 54)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(469, 181)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "DATOS EMPLEADO"
        '
        'EMPLEADOSTableAdapter
        '
        Me.EMPLEADOSTableAdapter.ClearBeforeFill = True
        '
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.bttBuscar)
        Me.Controls.Add(Me.bttModificar)
        Me.Controls.Add(Me.bttNuevo)
        Me.Controls.Add(Me.bttGuardar)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttEliminar)
        Me.Controls.Add(Me.LabelControl1)
        Me.KeyPreview = True
        Me.Name = "Empleados"
        Me.Text = "Empleados"
        CType(Me.txtNombreTicket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMPLEADOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTelefonos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPoblacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDireccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPoblacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDireccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTelefonos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreTicket As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DsEmpleados As AydaraTPV.dsEmpleados
    Friend WithEvents EMPLEADOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EMPLEADOSTableAdapter As AydaraTPV.dsEmpleadosTableAdapters.OPERARIOSTableAdapter
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
