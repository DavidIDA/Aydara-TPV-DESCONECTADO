<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DameCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DameCliente))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.txtCodigoCliente = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.TecladoNumerico = New AydaraTPV.TecladoNumerico()
        CType(Me.txtCodigoCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.EditValue = ""
        Me.txtCodigoCliente.Location = New System.Drawing.Point(103, 8)
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCliente.Properties.Appearance.Options.UseFont = True
        Me.txtCodigoCliente.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodigoCliente.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodigoCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtCodigoCliente.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.txtCodigoCliente.Properties.Mask.EditMask = "n0"
        Me.txtCodigoCliente.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigoCliente.Properties.MaxLength = 8
        Me.txtCodigoCliente.Properties.ValidateOnEnterKey = True
        Me.txtCodigoCliente.Size = New System.Drawing.Size(185, 38)
        Me.txtCodigoCliente.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(85, 25)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Tarjeta:"
        '
        'TecladoNumerico
        '
        Me.TecladoNumerico.fPadre = Nothing
        Me.TecladoNumerico.Location = New System.Drawing.Point(9, 55)
        Me.TecladoNumerico.Name = "TecladoNumerico"
        Me.TecladoNumerico.Size = New System.Drawing.Size(285, 247)
        Me.TecladoNumerico.TabIndex = 5
        '
        'DameCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 308)
        Me.Controls.Add(Me.TecladoNumerico)
        Me.Controls.Add(Me.txtCodigoCliente)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DameCliente"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Código Cliente"
        CType(Me.txtCodigoCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodigoCliente As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TecladoNumerico As AydaraTPV.TecladoNumerico
End Class
