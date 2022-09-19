<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Me.cmbApariencia = New DevExpress.XtraEditors.ComboBoxEdit
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.cmbApariencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbApariencia
        '
        Me.cmbApariencia.EditValue = "Seleccione su tema"
        Me.cmbApariencia.Location = New System.Drawing.Point(48, 33)
        Me.cmbApariencia.Name = "cmbApariencia"
        Me.cmbApariencia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbApariencia.Properties.Items.AddRange(New Object() {"Caramel", "Money Twins", "Lilian", "The Asphalt World", "iMaginary", "Black", "Blue", "-------------------", "Office 2010 Blue", "Office 2010 Black", "Office 2010 Silver", "Office 2007 Blue", "Office 2007 Black", "Office 2007 Silver", "Office 2007 Pink", "Office 2007 Green", "-------------------", "Seven", "Seven Classic", "-------------------", "VS 2010", "-------------------", "DevExpress", "DevExpress Dark", "Sharp", "Sharp+", "Foggy", "Darkroom", "High Contrast", "Springtime", "Pumpkin", "Summer", "Xmas", "McSkin", "Valentine", "Dark Side", "Blueprint", "Whiteprint", "Coffee", "Glass Oceans", "Stardust", "Liquid Sky", "London Liquid Sky"})
        Me.cmbApariencia.Size = New System.Drawing.Size(124, 20)
        Me.cmbApariencia.TabIndex = 12
        '
        'bttGuardar
        '
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.save
        Me.bttGuardar.Location = New System.Drawing.Point(210, 26)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(98, 42)
        Me.bttGuardar.TabIndex = 11
        Me.bttGuardar.Text = "Guardar"
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 94)
        Me.Controls.Add(Me.cmbApariencia)
        Me.Controls.Add(Me.bttGuardar)
        Me.KeyPreview = True
        Me.Name = "Configuracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Selector de Tema"
        CType(Me.cmbApariencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbApariencia As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
End Class
