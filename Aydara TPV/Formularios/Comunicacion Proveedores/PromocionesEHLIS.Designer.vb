<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PromocionesEHLIS
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.txtNombreProveedor = New DevExpress.XtraEditors.TextEdit
        Me.txtCodigoProveedor = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.bttImportarFichero = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(784, 490)
        Me.WebBrowser1.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtNombreProveedor)
        Me.GroupControl1.Controls.Add(Me.txtCodigoProveedor)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.bttImportarFichero)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 490)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(784, 72)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Opciones promociones"
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreProveedor.EnterMoveNextControl = True
        Me.txtNombreProveedor.Location = New System.Drawing.Point(185, 41)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Properties.MaxLength = 50
        Me.txtNombreProveedor.Properties.ReadOnly = True
        Me.txtNombreProveedor.Size = New System.Drawing.Size(456, 20)
        Me.txtNombreProveedor.TabIndex = 9
        Me.txtNombreProveedor.TabStop = False
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.EditValue = ""
        Me.txtCodigoProveedor.EnterMoveNextControl = True
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(103, 41)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoProveedor.Properties.DisplayFormat.FormatString = "00000"
        Me.txtCodigoProveedor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoProveedor.Properties.EditFormat.FormatString = "00000"
        Me.txtCodigoProveedor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoProveedor.Properties.ValidateOnEnterKey = True
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(83, 20)
        Me.txtCodigoProveedor.TabIndex = 8
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 44)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Proveedor EHLIS:"
        '
        'bttImportarFichero
        '
        Me.bttImportarFichero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttImportarFichero.Image = Global.AydaraTPV.My.Resources.Resources.menu_change
        Me.bttImportarFichero.Location = New System.Drawing.Point(647, 37)
        Me.bttImportarFichero.Name = "bttImportarFichero"
        Me.bttImportarFichero.Size = New System.Drawing.Size(125, 30)
        Me.bttImportarFichero.TabIndex = 7
        Me.bttImportarFichero.Text = "Importar fichero"
        '
        'PromocionesEHLIS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "PromocionesEHLIS"
        Me.Text = "Promociones EHLIS"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bttImportarFichero As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtNombreProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoProveedor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
