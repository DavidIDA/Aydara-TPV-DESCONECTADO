<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArticuloNuevo
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
        Me.lblTipoIVA = New DevExpress.XtraEditors.LabelControl
        Me.cmbTipoIVA = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtPrecioCoste = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrecioVenta = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txtDescripcionSubfamilia = New DevExpress.XtraEditors.TextEdit
        Me.txtDescripcionFamilia = New DevExpress.XtraEditors.TextEdit
        Me.txtCodigoSubfamilia = New DevExpress.XtraEditors.ButtonEdit
        Me.txtCodigoFamilia = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.lblTextoImpuesto = New DevExpress.XtraEditors.LabelControl
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodigoBarras = New DevExpress.XtraEditors.TextEdit
        Me.bttTeclado = New DevExpress.XtraEditors.SimpleButton
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit
        CType(Me.cmbTipoIVA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioCoste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionSubfamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoSubfamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoBarras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTipoIVA
        '
        Me.lblTipoIVA.Location = New System.Drawing.Point(298, 121)
        Me.lblTipoIVA.Name = "lblTipoIVA"
        Me.lblTipoIVA.Size = New System.Drawing.Size(24, 13)
        Me.lblTipoIVA.TabIndex = 101
        Me.lblTipoIVA.Text = "Tipo:"
        '
        'cmbTipoIVA
        '
        Me.cmbTipoIVA.EditValue = ""
        Me.cmbTipoIVA.EnterMoveNextControl = True
        Me.cmbTipoIVA.Location = New System.Drawing.Point(328, 118)
        Me.cmbTipoIVA.Name = "cmbTipoIVA"
        Me.cmbTipoIVA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTipoIVA.Properties.Items.AddRange(New Object() {"18", "8", "4", "0"})
        Me.cmbTipoIVA.Size = New System.Drawing.Size(44, 20)
        Me.cmbTipoIVA.TabIndex = 7
        '
        'txtPrecioCoste
        '
        Me.txtPrecioCoste.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecioCoste.EnterMoveNextControl = True
        Me.txtPrecioCoste.Location = New System.Drawing.Point(80, 118)
        Me.txtPrecioCoste.Name = "txtPrecioCoste"
        Me.txtPrecioCoste.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrecioCoste.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecioCoste.Properties.Mask.EditMask = "c2"
        Me.txtPrecioCoste.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioCoste.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioCoste.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecioCoste.TabIndex = 5
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(12, 121)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl16.TabIndex = 100
        Me.LabelControl16.Text = "Precio coste:"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtPrecioVenta.EnterMoveNextControl = True
        Me.txtPrecioVenta.Location = New System.Drawing.Point(224, 118)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrecioVenta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecioVenta.Properties.Mask.EditMask = "c2"
        Me.txtPrecioVenta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioVenta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioVenta.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecioVenta.TabIndex = 6
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(154, 121)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl15.TabIndex = 99
        Me.LabelControl15.Text = "Precio venta:"
        '
        'txtDescripcionSubfamilia
        '
        Me.txtDescripcionSubfamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionSubfamilia.EnterMoveNextControl = True
        Me.txtDescripcionSubfamilia.Location = New System.Drawing.Point(134, 38)
        Me.txtDescripcionSubfamilia.Name = "txtDescripcionSubfamilia"
        Me.txtDescripcionSubfamilia.Properties.MaxLength = 50
        Me.txtDescripcionSubfamilia.Properties.ReadOnly = True
        Me.txtDescripcionSubfamilia.Size = New System.Drawing.Size(327, 20)
        Me.txtDescripcionSubfamilia.TabIndex = 92
        Me.txtDescripcionSubfamilia.TabStop = False
        '
        'txtDescripcionFamilia
        '
        Me.txtDescripcionFamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionFamilia.EnterMoveNextControl = True
        Me.txtDescripcionFamilia.Location = New System.Drawing.Point(134, 12)
        Me.txtDescripcionFamilia.Name = "txtDescripcionFamilia"
        Me.txtDescripcionFamilia.Properties.MaxLength = 50
        Me.txtDescripcionFamilia.Properties.ReadOnly = True
        Me.txtDescripcionFamilia.Size = New System.Drawing.Size(327, 20)
        Me.txtDescripcionFamilia.TabIndex = 89
        Me.txtDescripcionFamilia.TabStop = False
        '
        'txtCodigoSubfamilia
        '
        Me.txtCodigoSubfamilia.EnterMoveNextControl = True
        Me.txtCodigoSubfamilia.Location = New System.Drawing.Point(80, 38)
        Me.txtCodigoSubfamilia.Name = "txtCodigoSubfamilia"
        Me.txtCodigoSubfamilia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoSubfamilia.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoSubfamilia.TabIndex = 1
        '
        'txtCodigoFamilia
        '
        Me.txtCodigoFamilia.EnterMoveNextControl = True
        Me.txtCodigoFamilia.Location = New System.Drawing.Point(80, 12)
        Me.txtCodigoFamilia.Name = "txtCodigoFamilia"
        Me.txtCodigoFamilia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoFamilia.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoFamilia.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 69)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 86
        Me.LabelControl1.Text = "Código:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.EnterMoveNextControl = True
        Me.txtDescripcion.Location = New System.Drawing.Point(80, 92)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.MaxLength = 40
        Me.txtDescripcion.Size = New System.Drawing.Size(381, 20)
        Me.txtDescripcion.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 95)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 88
        Me.LabelControl2.Text = "Descripción:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(11, 15)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 94
        Me.LabelControl3.Text = "Familia:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(11, 41)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl4.TabIndex = 95
        Me.LabelControl4.Text = "Subfamilia:"
        '
        'lblTextoImpuesto
        '
        Me.lblTextoImpuesto.Appearance.Options.UseTextOptions = True
        Me.lblTextoImpuesto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblTextoImpuesto.Location = New System.Drawing.Point(378, 121)
        Me.lblTextoImpuesto.Name = "lblTextoImpuesto"
        Me.lblTextoImpuesto.Size = New System.Drawing.Size(72, 13)
        Me.lblTextoImpuesto.TabIndex = 98
        Me.lblTextoImpuesto.Text = "texto impuesto"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(12, 163)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 55)
        Me.bttCancelar.TabIndex = 9
        Me.bttCancelar.Text = "Salir"
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.save
        Me.bttGuardar.Location = New System.Drawing.Point(355, 163)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(106, 55)
        Me.bttGuardar.TabIndex = 8
        Me.bttGuardar.Text = "Guardar"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(186, 69)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl5.TabIndex = 104
        Me.LabelControl5.Text = "Código de barras:"
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoBarras.EnterMoveNextControl = True
        Me.txtCodigoBarras.Location = New System.Drawing.Point(278, 66)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Properties.MaxLength = 13
        Me.txtCodigoBarras.Size = New System.Drawing.Size(183, 20)
        Me.txtCodigoBarras.TabIndex = 3
        '
        'bttTeclado
        '
        Me.bttTeclado.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.bttTeclado.Image = Global.AydaraTPV.My.Resources.Resources.keyboard
        Me.bttTeclado.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.bttTeclado.Location = New System.Drawing.Point(201, 163)
        Me.bttTeclado.Name = "bttTeclado"
        Me.bttTeclado.Size = New System.Drawing.Size(75, 55)
        Me.bttTeclado.TabIndex = 10
        Me.bttTeclado.TabStop = False
        Me.bttTeclado.Tag = "1"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.EnterMoveNextControl = True
        Me.txtCodigo.Location = New System.Drawing.Point(80, 66)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.MaxLength = 7
        Me.txtCodigo.Properties.NullValuePrompt = "xxxR"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 2
        Me.txtCodigo.ToolTip = "Búsqueda rápida (xxxR)"
        '
        'ArticuloNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 230)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.bttTeclado)
        Me.Controls.Add(Me.txtCodigoBarras)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttGuardar)
        Me.Controls.Add(Me.lblTipoIVA)
        Me.Controls.Add(Me.cmbTipoIVA)
        Me.Controls.Add(Me.txtPrecioCoste)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.txtDescripcionSubfamilia)
        Me.Controls.Add(Me.txtDescripcionFamilia)
        Me.Controls.Add(Me.txtCodigoSubfamilia)
        Me.Controls.Add(Me.txtCodigoFamilia)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.lblTextoImpuesto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ArticuloNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Artículo nuevo"
        CType(Me.cmbTipoIVA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioCoste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionSubfamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoSubfamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoBarras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTipoIVA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbTipoIVA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtPrecioCoste As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecioVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcionSubfamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcionFamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoSubfamilia As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCodigoFamilia As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTextoImpuesto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoBarras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttTeclado As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
End Class
