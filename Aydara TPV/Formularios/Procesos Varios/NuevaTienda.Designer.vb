<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaTienda
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.cmbTipoTienda = New DevExpress.XtraEditors.ComboBoxEdit
        Me.bttContinuar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.cmbTipoTienda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Crear tienda:"
        '
        'cmbTipoTienda
        '
        Me.cmbTipoTienda.Location = New System.Drawing.Point(104, 20)
        Me.cmbTipoTienda.Name = "cmbTipoTienda"
        Me.cmbTipoTienda.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoTienda.Properties.Appearance.Options.UseFont = True
        Me.cmbTipoTienda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTipoTienda.Properties.Items.AddRange(New Object() {"Empresa vacía", "Empresa Demo Alimentación", "Empresa Demo Tallas y Colores"})
        Me.cmbTipoTienda.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbTipoTienda.Size = New System.Drawing.Size(228, 22)
        Me.cmbTipoTienda.TabIndex = 1
        '
        'bttContinuar
        '
        Me.bttContinuar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttContinuar.Image = Global.AydaraTPV.My.Resources.Resources.ok_32
        Me.bttContinuar.Location = New System.Drawing.Point(338, 14)
        Me.bttContinuar.Name = "bttContinuar"
        Me.bttContinuar.Size = New System.Drawing.Size(114, 36)
        Me.bttContinuar.TabIndex = 2
        Me.bttContinuar.Text = "Continuar"
        '
        'NuevaTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 62)
        Me.Controls.Add(Me.bttContinuar)
        Me.Controls.Add(Me.cmbTipoTienda)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NuevaTienda"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nueva Tienda"
        CType(Me.cmbTipoTienda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbTipoTienda As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents bttContinuar As DevExpress.XtraEditors.SimpleButton
End Class
