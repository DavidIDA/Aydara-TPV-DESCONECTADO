<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fListadoExterno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fListadoExterno))
        Me.checkVistaPrevia = New DevExpress.XtraEditors.CheckEdit()
        Me.bttDefinir = New DevExpress.XtraEditors.SimpleButton()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cmbImpresoras = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cmbListados = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCopias = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.checkVistaPrevia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbImpresoras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbListados.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCopias.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'checkVistaPrevia
        '
        Me.checkVistaPrevia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkVistaPrevia.Location = New System.Drawing.Point(327, 39)
        Me.checkVistaPrevia.Name = "checkVistaPrevia"
        Me.checkVistaPrevia.Properties.AutoWidth = True
        Me.checkVistaPrevia.Properties.Caption = "Vista previa"
        Me.checkVistaPrevia.Size = New System.Drawing.Size(78, 19)
        Me.checkVistaPrevia.TabIndex = 0
        '
        'bttDefinir
        '
        Me.bttDefinir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttDefinir.Image = CType(resources.GetObject("bttDefinir.Image"), System.Drawing.Image)
        Me.bttDefinir.Location = New System.Drawing.Point(329, 12)
        Me.bttDefinir.Name = "bttDefinir"
        Me.bttDefinir.Size = New System.Drawing.Size(76, 20)
        Me.bttDefinir.TabIndex = 1
        Me.bttDefinir.Text = "Definir"
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Image = CType(resources.GetObject("bttImprimir.Image"), System.Drawing.Image)
        Me.bttImprimir.Location = New System.Drawing.Point(411, 12)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(101, 46)
        Me.bttImprimir.TabIndex = 2
        Me.bttImprimir.Text = "Imprimir"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Impresora:"
        '
        'cmbImpresoras
        '
        Me.cmbImpresoras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbImpresoras.Location = New System.Drawing.Point(70, 38)
        Me.cmbImpresoras.Name = "cmbImpresoras"
        Me.cmbImpresoras.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbImpresoras.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbImpresoras.Size = New System.Drawing.Size(154, 20)
        Me.cmbImpresoras.TabIndex = 4
        '
        'cmbListados
        '
        Me.cmbListados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbListados.Location = New System.Drawing.Point(90, 12)
        Me.cmbListados.Name = "cmbListados"
        Me.cmbListados.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbListados.Properties.NullText = "Original"
        Me.cmbListados.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbListados.Size = New System.Drawing.Size(231, 20)
        Me.cmbListados.TabIndex = 6
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Tipo de listado:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Location = New System.Drawing.Point(230, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Nº Copias:"
        '
        'txtCopias
        '
        Me.txtCopias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCopias.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCopias.Location = New System.Drawing.Point(287, 38)
        Me.txtCopias.Name = "txtCopias"
        Me.txtCopias.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCopias.Properties.Mask.EditMask = "n0"
        Me.txtCopias.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCopias.Size = New System.Drawing.Size(34, 20)
        Me.txtCopias.TabIndex = 8
        '
        'fListadoExterno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 70)
        Me.Controls.Add(Me.txtCopias)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cmbListados)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.cmbImpresoras)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.bttImprimir)
        Me.Controls.Add(Me.bttDefinir)
        Me.Controls.Add(Me.checkVistaPrevia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fListadoExterno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado"
        CType(Me.checkVistaPrevia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbImpresoras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbListados.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCopias.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents checkVistaPrevia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents bttDefinir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbImpresoras As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cmbListados As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCopias As DevExpress.XtraEditors.SpinEdit
End Class
