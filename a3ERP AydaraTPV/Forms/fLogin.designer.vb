<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fLogin
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUsuario = New DevExpress.XtraEditors.TextEdit()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.bttAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbSkins = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSkins.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(13, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Usuario:"
        '
        'txtUsuario
        '
        Me.txtUsuario.EnterMoveNextControl = True
        Me.txtUsuario.Location = New System.Drawing.Point(79, 9)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Properties.AllowFocused = False
        Me.txtUsuario.Size = New System.Drawing.Size(188, 20)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.EnterMoveNextControl = True
        Me.txtPassword.Location = New System.Drawing.Point(79, 35)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(188, 20)
        Me.txtPassword.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(13, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Contraseña:"
        '
        'bttAceptar
        '
        Me.bttAceptar.Location = New System.Drawing.Point(111, 61)
        Me.bttAceptar.Name = "bttAceptar"
        Me.bttAceptar.Size = New System.Drawing.Size(75, 23)
        Me.bttAceptar.TabIndex = 4
        Me.bttAceptar.Text = "Aceptar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Location = New System.Drawing.Point(192, 61)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(75, 23)
        Me.bttCancelar.TabIndex = 5
        Me.bttCancelar.Text = "Cancelar"
        '
        'cmbSkins
        '
        Me.cmbSkins.Location = New System.Drawing.Point(12, 64)
        Me.cmbSkins.Name = "cmbSkins"
        Me.cmbSkins.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSkins.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.cmbSkins.Size = New System.Drawing.Size(21, 18)
        Me.cmbSkins.TabIndex = 6
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 94)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbSkins)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttAceptar)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        CType(Me.txtUsuario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSkins.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUsuario As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbSkins As DevExpress.XtraEditors.ComboBoxEdit
End Class
