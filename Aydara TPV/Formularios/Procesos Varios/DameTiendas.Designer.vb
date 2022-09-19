<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DameTiendas
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
        Me.bttAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.lstTiendas = New DevExpress.XtraEditors.CheckedListBoxControl
        CType(Me.lstTiendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttAceptar
        '
        Me.bttAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttAceptar.Image = Global.AydaraTPV.My.Resources.Resources.ok_32
        Me.bttAceptar.Location = New System.Drawing.Point(13, 159)
        Me.bttAceptar.Name = "bttAceptar"
        Me.bttAceptar.Size = New System.Drawing.Size(122, 45)
        Me.bttAceptar.TabIndex = 46
        Me.bttAceptar.Text = "Aceptar"
        '
        'lstTiendas
        '
        Me.lstTiendas.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTiendas.Appearance.Options.UseFont = True
        Me.lstTiendas.CheckOnClick = True
        Me.lstTiendas.Location = New System.Drawing.Point(12, 12)
        Me.lstTiendas.Name = "lstTiendas"
        Me.lstTiendas.Size = New System.Drawing.Size(123, 141)
        Me.lstTiendas.TabIndex = 48
        '
        'DameTiendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(147, 216)
        Me.Controls.Add(Me.lstTiendas)
        Me.Controls.Add(Me.bttAceptar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DameTiendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tiendas"
        CType(Me.lstTiendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lstTiendas As DevExpress.XtraEditors.CheckedListBoxControl
End Class
