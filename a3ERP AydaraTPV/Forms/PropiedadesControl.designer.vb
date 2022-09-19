<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropiedadesControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PropiedadesControl))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PropertyGridControl = New DevExpress.XtraVerticalGrid.PropertyGridControl()
        Me.gcOpciones = New DevExpress.XtraEditors.GroupControl()
        Me.PropertyDescriptionControl = New DevExpress.XtraVerticalGrid.PropertyDescriptionControl()
        Me.bttDefault = New DevExpress.XtraEditors.SimpleButton()
        Me.gcColumnas = New DevExpress.XtraEditors.GroupControl()
        Me.cmbColumnas = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PropertyGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcOpciones.SuspendLayout()
        CType(Me.gcColumnas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcColumnas.SuspendLayout()
        CType(Me.cmbColumnas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PropertyGridControl
        '
        Me.PropertyGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGridControl.Location = New System.Drawing.Point(0, 69)
        Me.PropertyGridControl.Name = "PropertyGridControl"
        Me.PropertyGridControl.ShowButtonMode = DevExpress.XtraVerticalGrid.ShowButtonModeEnum.ShowAlways
        Me.PropertyGridControl.Size = New System.Drawing.Size(464, 430)
        Me.PropertyGridControl.TabIndex = 0
        '
        'gcOpciones
        '
        Me.gcOpciones.Controls.Add(Me.PropertyDescriptionControl)
        Me.gcOpciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gcOpciones.Location = New System.Drawing.Point(0, 499)
        Me.gcOpciones.Name = "gcOpciones"
        Me.gcOpciones.Size = New System.Drawing.Size(464, 103)
        Me.gcOpciones.TabIndex = 1
        Me.gcOpciones.Text = "Opciones"
        '
        'PropertyDescriptionControl
        '
        Me.PropertyDescriptionControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyDescriptionControl.Location = New System.Drawing.Point(2, 21)
        Me.PropertyDescriptionControl.Name = "PropertyDescriptionControl"
        Me.PropertyDescriptionControl.PropertyGrid = Me.PropertyGridControl
        Me.PropertyDescriptionControl.Size = New System.Drawing.Size(460, 80)
        Me.PropertyDescriptionControl.TabIndex = 2
        Me.PropertyDescriptionControl.TabStop = False
        '
        'bttDefault
        '
        Me.bttDefault.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttDefault.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttDefault.Image = CType(resources.GetObject("bttDefault.Image"), System.Drawing.Image)
        Me.bttDefault.Location = New System.Drawing.Point(341, 29)
        Me.bttDefault.Name = "bttDefault"
        Me.bttDefault.Size = New System.Drawing.Size(111, 28)
        Me.bttDefault.TabIndex = 6
        Me.bttDefault.Text = "&Diseño original"
        '
        'gcColumnas
        '
        Me.gcColumnas.Controls.Add(Me.cmbColumnas)
        Me.gcColumnas.Controls.Add(Me.bttDefault)
        Me.gcColumnas.Controls.Add(Me.Label1)
        Me.gcColumnas.Dock = System.Windows.Forms.DockStyle.Top
        Me.gcColumnas.Location = New System.Drawing.Point(0, 0)
        Me.gcColumnas.Name = "gcColumnas"
        Me.gcColumnas.Size = New System.Drawing.Size(464, 69)
        Me.gcColumnas.TabIndex = 2
        Me.gcColumnas.Text = "Columnas"
        '
        'cmbColumnas
        '
        Me.cmbColumnas.Location = New System.Drawing.Point(75, 31)
        Me.cmbColumnas.Name = "cmbColumnas"
        Me.cmbColumnas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("cmbColumnas.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.cmbColumnas.Properties.Sorted = True
        Me.cmbColumnas.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbColumnas.Size = New System.Drawing.Size(175, 22)
        Me.cmbColumnas.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Columnas:"
        '
        'PropiedadesControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 602)
        Me.Controls.Add(Me.PropertyGridControl)
        Me.Controls.Add(Me.gcColumnas)
        Me.Controls.Add(Me.gcOpciones)
        Me.MinimizeBox = False
        Me.Name = "PropiedadesControl"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Propiedades control"
        CType(Me.PropertyGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcOpciones.ResumeLayout(False)
        CType(Me.gcColumnas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcColumnas.ResumeLayout(False)
        Me.gcColumnas.PerformLayout()
        CType(Me.cmbColumnas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PropertyGridControl As DevExpress.XtraVerticalGrid.PropertyGridControl
    Friend WithEvents gcOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bttDefault As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PropertyDescriptionControl As DevExpress.XtraVerticalGrid.PropertyDescriptionControl
    Friend WithEvents gcColumnas As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbColumnas As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
