<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CierreCaja
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
        Me.txtCodigoCaja = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.checkArqueo = New DevExpress.XtraEditors.CheckButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.checkDefinitivo = New DevExpress.XtraEditors.CheckButton
        Me.bttAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.rgCierreDia = New DevExpress.XtraEditors.RadioGroup
        CType(Me.txtCodigoCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.rgCierreDia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigoCaja
        '
        Me.txtCodigoCaja.EnterMoveNextControl = True
        Me.txtCodigoCaja.Location = New System.Drawing.Point(178, 12)
        Me.txtCodigoCaja.Name = "txtCodigoCaja"
        Me.txtCodigoCaja.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCaja.Properties.Appearance.Options.UseFont = True
        Me.txtCodigoCaja.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodigoCaja.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        SerializableAppearanceObject1.Image = Global.AydaraTPV.My.Resources.Resources.search
        SerializableAppearanceObject1.Options.UseImage = True
        Me.txtCodigoCaja.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, False, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.AydaraTPV.My.Resources.Resources.find, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing)})
        Me.txtCodigoCaja.Properties.ReadOnly = True
        Me.txtCodigoCaja.Size = New System.Drawing.Size(50, 32)
        Me.txtCodigoCaja.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(93, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(79, 25)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Nº Caja:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(56, 81)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(151, 25)
        Me.LabelControl11.TabIndex = 8
        Me.LabelControl11.Text = "Arqueo de caja:"
        '
        'checkArqueo
        '
        Me.checkArqueo.AllowFocus = False
        Me.checkArqueo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkArqueo.Appearance.Options.UseFont = True
        Me.checkArqueo.Location = New System.Drawing.Point(218, 81)
        Me.checkArqueo.Name = "checkArqueo"
        Me.checkArqueo.Size = New System.Drawing.Size(35, 28)
        Me.checkArqueo.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(56, 115)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(156, 25)
        Me.LabelControl2.TabIndex = 10
        Me.LabelControl2.Text = "Cierre definitivo:"
        '
        'checkDefinitivo
        '
        Me.checkDefinitivo.AllowFocus = False
        Me.checkDefinitivo.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkDefinitivo.Appearance.Options.UseFont = True
        Me.checkDefinitivo.Location = New System.Drawing.Point(218, 115)
        Me.checkDefinitivo.Name = "checkDefinitivo"
        Me.checkDefinitivo.Size = New System.Drawing.Size(35, 28)
        Me.checkDefinitivo.TabIndex = 2
        '
        'bttAceptar
        '
        Me.bttAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttAceptar.Appearance.Options.UseFont = True
        Me.bttAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttAceptar.Image = Global.AydaraTPV.My.Resources.Resources.ok_32
        Me.bttAceptar.Location = New System.Drawing.Point(178, 224)
        Me.bttAceptar.Name = "bttAceptar"
        Me.bttAceptar.Size = New System.Drawing.Size(157, 53)
        Me.bttAceptar.TabIndex = 2
        Me.bttAceptar.Text = "Aceptar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCancelar.Appearance.Options.UseFont = True
        Me.bttCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(16, 224)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(156, 53)
        Me.bttCancelar.TabIndex = 3
        Me.bttCancelar.Text = "Cancelar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.rgCierreDia)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.checkArqueo)
        Me.GroupControl1.Controls.Add(Me.checkDefinitivo)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(16, 50)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(319, 158)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Opciones cierre"
        '
        'rgCierreDia
        '
        Me.rgCierreDia.EditValue = True
        Me.rgCierreDia.Location = New System.Drawing.Point(56, 32)
        Me.rgCierreDia.Name = "rgCierreDia"
        Me.rgCierreDia.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rgCierreDia.Properties.Appearance.Options.UseFont = True
        Me.rgCierreDia.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Día"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Turno")})
        Me.rgCierreDia.Size = New System.Drawing.Size(197, 33)
        Me.rgCierreDia.TabIndex = 0
        '
        'CierreCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 289)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.bttAceptar)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.txtCodigoCaja)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CierreCaja"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cierre de caja"
        CType(Me.txtCodigoCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.rgCierreDia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCodigoCaja As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents checkArqueo As DevExpress.XtraEditors.CheckButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents checkDefinitivo As DevExpress.XtraEditors.CheckButton
    Friend WithEvents bttAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rgCierreDia As DevExpress.XtraEditors.RadioGroup
End Class
