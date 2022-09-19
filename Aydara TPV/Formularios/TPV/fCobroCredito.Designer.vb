<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCobroCredito
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fCobroCredito))
        Me.icOpciones = New DevExpress.Utils.ImageCollection(Me.components)
        Me.bttPendienteFactura = New DevExpress.XtraEditors.CheckButton()
        Me.bttTarjetaFactura = New DevExpress.XtraEditors.CheckButton()
        Me.bttEfectivoFactura = New DevExpress.XtraEditors.CheckButton()
        CType(Me.icOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'icOpciones
        '
        Me.icOpciones.ImageSize = New System.Drawing.Size(48, 48)
        Me.icOpciones.ImageStream = CType(resources.GetObject("icOpciones.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.icOpciones.Images.SetKeyName(0, "1-EFECTIVO2.png")
        Me.icOpciones.Images.SetKeyName(1, "1-EMISION-VALES.png")
        Me.icOpciones.Images.SetKeyName(2, "1-PTE.COBRO.png")
        Me.icOpciones.Images.SetKeyName(3, "1-TARJETA.png")
        Me.icOpciones.Images.SetKeyName(4, "1-VARIOS.png")
        '
        'bttPendienteFactura
        '
        Me.bttPendienteFactura.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttPendienteFactura.Appearance.Options.UseFont = True
        Me.bttPendienteFactura.Appearance.Options.UseTextOptions = True
        Me.bttPendienteFactura.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bttPendienteFactura.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttPendienteFactura.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.bttPendienteFactura.ImageIndex = 2
        Me.bttPendienteFactura.ImageList = Me.icOpciones
        Me.bttPendienteFactura.Location = New System.Drawing.Point(308, 12)
        Me.bttPendienteFactura.Name = "bttPendienteFactura"
        Me.bttPendienteFactura.Size = New System.Drawing.Size(139, 76)
        Me.bttPendienteFactura.TabIndex = 64
        Me.bttPendienteFactura.TabStop = False
        Me.bttPendienteFactura.Tag = "P"
        Me.bttPendienteFactura.Text = "(F4) PTE.COBRO"
        '
        'bttTarjetaFactura
        '
        Me.bttTarjetaFactura.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttTarjetaFactura.Appearance.Options.UseFont = True
        Me.bttTarjetaFactura.Appearance.Options.UseTextOptions = True
        Me.bttTarjetaFactura.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bttTarjetaFactura.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttTarjetaFactura.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.bttTarjetaFactura.ImageIndex = 3
        Me.bttTarjetaFactura.ImageList = Me.icOpciones
        Me.bttTarjetaFactura.Location = New System.Drawing.Point(159, 12)
        Me.bttTarjetaFactura.Name = "bttTarjetaFactura"
        Me.bttTarjetaFactura.Size = New System.Drawing.Size(143, 76)
        Me.bttTarjetaFactura.TabIndex = 63
        Me.bttTarjetaFactura.TabStop = False
        Me.bttTarjetaFactura.Tag = "T"
        Me.bttTarjetaFactura.Text = "(F2) TARJETA"
        '
        'bttEfectivoFactura
        '
        Me.bttEfectivoFactura.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttEfectivoFactura.Appearance.Options.UseFont = True
        Me.bttEfectivoFactura.Appearance.Options.UseTextOptions = True
        Me.bttEfectivoFactura.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.bttEfectivoFactura.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttEfectivoFactura.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.bttEfectivoFactura.ImageIndex = 0
        Me.bttEfectivoFactura.ImageList = Me.icOpciones
        Me.bttEfectivoFactura.Location = New System.Drawing.Point(12, 12)
        Me.bttEfectivoFactura.Name = "bttEfectivoFactura"
        Me.bttEfectivoFactura.Size = New System.Drawing.Size(139, 76)
        Me.bttEfectivoFactura.TabIndex = 62
        Me.bttEfectivoFactura.TabStop = False
        Me.bttEfectivoFactura.Tag = "E"
        Me.bttEfectivoFactura.Text = "(F1) EFECTIVO"
        '
        'fCobroCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 100)
        Me.Controls.Add(Me.bttPendienteFactura)
        Me.Controls.Add(Me.bttTarjetaFactura)
        Me.Controls.Add(Me.bttEfectivoFactura)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fCobroCredito"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Forma cobro venta crédito"
        CType(Me.icOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents icOpciones As DevExpress.Utils.ImageCollection
    Friend WithEvents bttPendienteFactura As DevExpress.XtraEditors.CheckButton
    Friend WithEvents bttTarjetaFactura As DevExpress.XtraEditors.CheckButton
    Friend WithEvents bttEfectivoFactura As DevExpress.XtraEditors.CheckButton
End Class
