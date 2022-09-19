<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.lblNumeroSerie = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodigoActivacion = New DevExpress.XtraEditors.TextEdit
        Me.lblDíasRestantes = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit
        Me.PictureEdit3 = New DevExpress.XtraEditors.PictureEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.bttContinuar = New DevExpress.XtraEditors.SimpleButton
        Me.imgIconos = New DevExpress.Utils.ImageCollection(Me.components)
        Me.bttActivar = New DevExpress.XtraEditors.SimpleButton
        Me.bttWeb = New DevExpress.XtraEditors.SimpleButton
        Me.bttMail = New DevExpress.XtraEditors.SimpleButton
        CType(Me.txtCodigoActivacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgIconos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 205)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(140, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Número de serie:"
        '
        'lblNumeroSerie
        '
        Me.lblNumeroSerie.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroSerie.Appearance.ForeColor = System.Drawing.Color.Maroon
        Me.lblNumeroSerie.Appearance.Options.UseFont = True
        Me.lblNumeroSerie.Appearance.Options.UseForeColor = True
        Me.lblNumeroSerie.Location = New System.Drawing.Point(167, 205)
        Me.lblNumeroSerie.Name = "lblNumeroSerie"
        Me.lblNumeroSerie.Size = New System.Drawing.Size(114, 19)
        Me.lblNumeroSerie.TabIndex = 1
        Me.lblNumeroSerie.Text = "LabelControl2"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 245)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(149, 19)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Código activación:"
        '
        'txtCodigoActivacion
        '
        Me.txtCodigoActivacion.EnterMoveNextControl = True
        Me.txtCodigoActivacion.Location = New System.Drawing.Point(167, 240)
        Me.txtCodigoActivacion.Name = "txtCodigoActivacion"
        Me.txtCodigoActivacion.Properties.Appearance.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoActivacion.Properties.Appearance.Options.UseFont = True
        Me.txtCodigoActivacion.Properties.Mask.EditMask = "....-....-...."
        Me.txtCodigoActivacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.txtCodigoActivacion.Properties.Mask.SaveLiteral = False
        Me.txtCodigoActivacion.Size = New System.Drawing.Size(168, 28)
        Me.txtCodigoActivacion.TabIndex = 0
        '
        'lblDíasRestantes
        '
        Me.lblDíasRestantes.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDíasRestantes.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lblDíasRestantes.Appearance.Options.UseFont = True
        Me.lblDíasRestantes.Appearance.Options.UseForeColor = True
        Me.lblDíasRestantes.Location = New System.Drawing.Point(12, 165)
        Me.lblDíasRestantes.Name = "lblDíasRestantes"
        Me.lblDíasRestantes.Size = New System.Drawing.Size(123, 19)
        Me.lblDíasRestantes.TabIndex = 4
        Me.lblDíasRestantes.Text = "Días restantes:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(297, 78)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(149, 48)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "C\ Isla Menorca 1, Local 2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Edificio Estrella" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "50014 Zaragoza" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureEdit2
        '
        Me.PictureEdit2.EditValue = Global.AydaraTPV.My.Resources.Resources.Logo_copia
        Me.PictureEdit2.Location = New System.Drawing.Point(12, 12)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.AllowFocused = False
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Properties.ReadOnly = True
        Me.PictureEdit2.Properties.ShowMenu = False
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit2.ShowToolTips = False
        Me.PictureEdit2.Size = New System.Drawing.Size(161, 80)
        Me.PictureEdit2.TabIndex = 9
        '
        'PictureEdit3
        '
        Me.PictureEdit3.EditValue = Global.AydaraTPV.My.Resources.Resources.LogoIda
        Me.PictureEdit3.Location = New System.Drawing.Point(297, 17)
        Me.PictureEdit3.Name = "PictureEdit3"
        Me.PictureEdit3.Properties.AllowFocused = False
        Me.PictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit3.Properties.ReadOnly = True
        Me.PictureEdit3.Properties.ShowMenu = False
        Me.PictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit3.ShowToolTips = False
        Me.PictureEdit3.Size = New System.Drawing.Size(126, 55)
        Me.PictureEdit3.TabIndex = 10
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Bookman Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(429, 17)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(146, 57)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Integración y " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Desarrollo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Aplicaciones, S.L."
        '
        'bttContinuar
        '
        Me.bttContinuar.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttContinuar.Appearance.Options.UseFont = True
        Me.bttContinuar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttContinuar.ImageIndex = 3
        Me.bttContinuar.ImageList = Me.imgIconos
        Me.bttContinuar.Location = New System.Drawing.Point(475, 241)
        Me.bttContinuar.Name = "bttContinuar"
        Me.bttContinuar.Size = New System.Drawing.Size(100, 27)
        Me.bttContinuar.TabIndex = 2
        Me.bttContinuar.Text = "Continuar"
        '
        'imgIconos
        '
        Me.imgIconos.ImageSize = New System.Drawing.Size(21, 16)
        Me.imgIconos.ImageStream = CType(resources.GetObject("imgIconos.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.imgIconos.Images.SetKeyName(0, "glyphicons_010_envelope.png")
        Me.imgIconos.Images.SetKeyName(1, "glyphicons_195_circle_info.png")
        Me.imgIconos.Images.SetKeyName(2, "glyphicons_204_unlock.png")
        Me.imgIconos.Images.SetKeyName(3, "glyphicons_206_ok_2.png")
        '
        'bttActivar
        '
        Me.bttActivar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttActivar.ImageIndex = 2
        Me.bttActivar.ImageList = Me.imgIconos
        Me.bttActivar.Location = New System.Drawing.Point(335, 241)
        Me.bttActivar.Name = "bttActivar"
        Me.bttActivar.Size = New System.Drawing.Size(93, 27)
        Me.bttActivar.TabIndex = 1
        Me.bttActivar.Text = "Activar"
        '
        'bttWeb
        '
        Me.bttWeb.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttWeb.Appearance.Options.UseFont = True
        Me.bttWeb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttWeb.ImageIndex = 1
        Me.bttWeb.ImageList = Me.imgIconos
        Me.bttWeb.Location = New System.Drawing.Point(466, 78)
        Me.bttWeb.Name = "bttWeb"
        Me.bttWeb.Size = New System.Drawing.Size(109, 27)
        Me.bttWeb.TabIndex = 14
        Me.bttWeb.Text = "www.ida.es"
        '
        'bttMail
        '
        Me.bttMail.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttMail.Appearance.Options.UseFont = True
        Me.bttMail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttMail.ImageIndex = 0
        Me.bttMail.ImageList = Me.imgIconos
        Me.bttMail.Location = New System.Drawing.Point(466, 111)
        Me.bttMail.Name = "bttMail"
        Me.bttMail.Size = New System.Drawing.Size(109, 27)
        Me.bttMail.TabIndex = 15
        Me.bttMail.TabStop = False
        Me.bttMail.Text = "ida@ida.es"
        '
        'Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch
        Me.BackgroundImageStore = Global.AydaraTPV.My.Resources.Resources.activacion
        Me.ClientSize = New System.Drawing.Size(590, 288)
        Me.Controls.Add(Me.bttMail)
        Me.Controls.Add(Me.bttWeb)
        Me.Controls.Add(Me.bttActivar)
        Me.Controls.Add(Me.bttContinuar)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.PictureEdit3)
        Me.Controls.Add(Me.PictureEdit2)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.lblDíasRestantes)
        Me.Controls.Add(Me.txtCodigoActivacion)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.lblNumeroSerie)
        Me.Controls.Add(Me.LabelControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Info"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aydara TPV"
        CType(Me.txtCodigoActivacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgIconos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNumeroSerie As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoActivacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDíasRestantes As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEdit3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttContinuar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttActivar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttWeb As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imgIconos As DevExpress.Utils.ImageCollection
    Friend WithEvents bttMail As DevExpress.XtraEditors.SimpleButton
End Class
