<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizandoTienda
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
        Me.bttSalir = New DevExpress.XtraEditors.SimpleButton
        Me.imgAbrirTienda = New DevExpress.XtraEditors.PictureEdit
        CType(Me.imgAbrirTienda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(374, 52)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Los datos de la tienda están siendo actualizados. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Espere mientras finalice el p" & _
            "roceso o vuelva a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "entrar más tarde."
        '
        'bttSalir
        '
        Me.bttSalir.AllowFocus = False
        Me.bttSalir.Image = Global.AydaraTPV.My.Resources.Resources._Exit
        Me.bttSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttSalir.Location = New System.Drawing.Point(392, 12)
        Me.bttSalir.Name = "bttSalir"
        Me.bttSalir.Size = New System.Drawing.Size(90, 70)
        Me.bttSalir.TabIndex = 15
        Me.bttSalir.TabStop = False
        Me.bttSalir.Text = "(ESC) SALIR"
        '
        'imgAbrirTienda
        '
        Me.imgAbrirTienda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.imgAbrirTienda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgAbrirTienda.EditValue = Global.AydaraTPV.My.Resources.Resources.menu_cierreDia
        Me.imgAbrirTienda.Location = New System.Drawing.Point(0, 65)
        Me.imgAbrirTienda.Name = "imgAbrirTienda"
        Me.imgAbrirTienda.Properties.AllowFocused = False
        Me.imgAbrirTienda.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.imgAbrirTienda.Properties.Appearance.Options.UseBackColor = True
        Me.imgAbrirTienda.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.imgAbrirTienda.Properties.ReadOnly = True
        Me.imgAbrirTienda.Properties.ShowMenu = False
        Me.imgAbrirTienda.Size = New System.Drawing.Size(28, 30)
        Me.imgAbrirTienda.TabIndex = 16
        '
        'ActualizandoTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 94)
        Me.ControlBox = False
        Me.Controls.Add(Me.imgAbrirTienda)
        Me.Controls.Add(Me.bttSalir)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ActualizandoTienda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Actualizando tienda..."
        CType(Me.imgAbrirTienda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imgAbrirTienda As DevExpress.XtraEditors.PictureEdit
End Class
