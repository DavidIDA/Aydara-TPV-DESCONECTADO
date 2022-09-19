<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DameCaja
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodigoCaja = New DevExpress.XtraEditors.ButtonEdit
        Me.TecladoNumerico = New AydaraTPV.TecladoNumerico
        CType(Me.txtCodigoCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(188, 29)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Código de Caja:"
        '
        'txtCodigoCaja
        '
        Me.txtCodigoCaja.Location = New System.Drawing.Point(206, 10)
        Me.txtCodigoCaja.Name = "txtCodigoCaja"
        Me.txtCodigoCaja.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCaja.Properties.Appearance.Options.UseFont = True
        Me.txtCodigoCaja.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodigoCaja.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodigoCaja.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.AydaraTPV.My.Resources.Resources._Exit, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing)})
        Me.txtCodigoCaja.Properties.MaxLength = 2
        Me.txtCodigoCaja.Properties.ValidateOnEnterKey = True
        Me.txtCodigoCaja.Size = New System.Drawing.Size(82, 38)
        Me.txtCodigoCaja.TabIndex = 2
        '
        'TecladoNumerico
        '
        Me.TecladoNumerico.fPadre = Nothing
        Me.TecladoNumerico.Location = New System.Drawing.Point(9, 55)
        Me.TecladoNumerico.Name = "TecladoNumerico"
        Me.TecladoNumerico.Size = New System.Drawing.Size(285, 247)
        Me.TecladoNumerico.TabIndex = 3
        '
        'DameCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 308)
        Me.Controls.Add(Me.TecladoNumerico)
        Me.Controls.Add(Me.txtCodigoCaja)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DameCaja"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Código Caja"
        CType(Me.txtCodigoCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoCaja As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TecladoNumerico As AydaraTPV.TecladoNumerico
End Class
