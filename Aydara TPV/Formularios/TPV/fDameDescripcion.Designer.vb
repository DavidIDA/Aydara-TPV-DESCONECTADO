<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fDameDescripcion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fDameDescripcion))
        Me.bttTeclado = New DevExpress.XtraEditors.SimpleButton()
        Me.bttAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescripcion = New DevExpress.XtraEditors.MemoEdit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttTeclado
        '
        Me.bttTeclado.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bttTeclado.Image = Global.AydaraTPV.My.Resources.Resources.keyboard
        Me.bttTeclado.Location = New System.Drawing.Point(255, 185)
        Me.bttTeclado.Name = "bttTeclado"
        Me.bttTeclado.Size = New System.Drawing.Size(75, 65)
        Me.bttTeclado.TabIndex = 3
        Me.bttTeclado.TabStop = False
        Me.bttTeclado.Tag = "1"
        Me.bttTeclado.Text = "Teclado"
        '
        'bttAceptar
        '
        Me.bttAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttAceptar.Appearance.Options.UseFont = True
        Me.bttAceptar.Image = CType(resources.GetObject("bttAceptar.Image"), System.Drawing.Image)
        Me.bttAceptar.Location = New System.Drawing.Point(448, 185)
        Me.bttAceptar.Name = "bttAceptar"
        Me.bttAceptar.Size = New System.Drawing.Size(124, 65)
        Me.bttAceptar.TabIndex = 1
        Me.bttAceptar.Text = "Aceptar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCancelar.Appearance.Options.UseFont = True
        Me.bttCancelar.Image = CType(resources.GetObject("bttCancelar.Image"), System.Drawing.Image)
        Me.bttCancelar.Location = New System.Drawing.Point(12, 185)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(121, 65)
        Me.bttCancelar.TabIndex = 2
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Cancelar"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.EditValue = ""
        Me.txtDescripcion.EnterMoveNextControl = True
        Me.txtDescripcion.Location = New System.Drawing.Point(12, 12)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Properties.Appearance.Options.UseFont = True
        Me.txtDescripcion.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDescripcion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtDescripcion.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txtDescripcion.Properties.MaxLength = 150
        Me.txtDescripcion.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.Properties.ValidateOnEnterKey = True
        Me.txtDescripcion.Size = New System.Drawing.Size(560, 167)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.UseOptimizedRendering = True
        '
        'fDameDescripcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 262)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.bttTeclado)
        Me.Controls.Add(Me.bttAceptar)
        Me.Controls.Add(Me.bttCancelar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fDameDescripcion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Descripción"
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttTeclado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.MemoEdit
End Class
