<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.AydaraTPV.My.Resources.Resources.Logo_copia
        Me.PictureEdit1.Location = New System.Drawing.Point(62, 51)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.AllowFocused = False
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ReadOnly = True
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.ShowToolTips = False
        Me.PictureEdit1.Size = New System.Drawing.Size(283, 171)
        Me.PictureEdit1.TabIndex = 1
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AydaraTPV.My.Resources.Resources.incio
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.PictureEdit1)
        Me.DoubleBuffered = True
        Me.Name = "Inicio"
        Me.Size = New System.Drawing.Size(640, 480)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit

End Class
