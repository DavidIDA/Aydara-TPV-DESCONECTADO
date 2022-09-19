<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CierreTienda
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
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.txtFechaCierre = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        CType(Me.txtFechaCierre.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaCierre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bttAceptar
        '
        Me.bttAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttAceptar.Appearance.Options.UseFont = True
        Me.bttAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttAceptar.Image = Global.AydaraTPV.My.Resources.Resources.ok_32
        Me.bttAceptar.Location = New System.Drawing.Point(199, 65)
        Me.bttAceptar.Name = "bttAceptar"
        Me.bttAceptar.Size = New System.Drawing.Size(157, 53)
        Me.bttAceptar.TabIndex = 32
        Me.bttAceptar.Text = "Aceptar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCancelar.Appearance.Options.UseFont = True
        Me.bttCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(12, 65)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(156, 53)
        Me.bttCancelar.TabIndex = 33
        Me.bttCancelar.Text = "Cancelar"
        '
        'txtFechaCierre
        '
        Me.txtFechaCierre.EditValue = Nothing
        Me.txtFechaCierre.Location = New System.Drawing.Point(172, 12)
        Me.txtFechaCierre.Name = "txtFechaCierre"
        Me.txtFechaCierre.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaCierre.Properties.Appearance.Options.UseFont = True
        Me.txtFechaCierre.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaCierre.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFechaCierre.Size = New System.Drawing.Size(184, 35)
        Me.txtFechaCierre.TabIndex = 34
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(154, 29)
        Me.LabelControl1.TabIndex = 35
        Me.LabelControl1.Text = "Fecha cierre:"
        '
        'CierreTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 130)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtFechaCierre)
        Me.Controls.Add(Me.bttAceptar)
        Me.Controls.Add(Me.bttCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CierreTienda"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cierre de tienda"
        CType(Me.txtFechaCierre.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaCierre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bttAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaCierre As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
