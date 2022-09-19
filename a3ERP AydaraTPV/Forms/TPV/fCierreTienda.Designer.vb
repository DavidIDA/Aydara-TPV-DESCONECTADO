<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCierreTienda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fCierreTienda))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.txtCODALM = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtDESCALM = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCODCLI = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtNOMCLI = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtSERIE = New DevExpress.XtraEditors.LookUpEdit()
        Me.SERIESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSeries = New a3ERP_AydaraTPV.dsSeries()
        Me.txtTARIFA = New DevExpress.XtraEditors.LookUpEdit()
        Me.TARIFASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarifas = New a3ERP_AydaraTPV.dsTarifas()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.bttAceptar = New DevExpress.XtraEditors.SimpleButton()
        Me.checkAbonar = New DevExpress.XtraEditors.CheckEdit()
        Me.checkTraspaso = New DevExpress.XtraEditors.CheckEdit()
        Me.txtFecha = New DevExpress.XtraEditors.DateEdit()
        CType(Me.txtCODALM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDESCALM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCODCLI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNOMCLI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSERIE.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERIESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSeries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTARIFA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TARIFASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkAbonar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkTraspaso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCODALM
        '
        Me.txtCODALM.EditValue = ""
        Me.txtCODALM.EnterMoveNextControl = True
        Me.txtCODALM.Location = New System.Drawing.Point(58, 12)
        Me.txtCODALM.Name = "txtCODALM"
        Me.txtCODALM.Properties.AutoHeight = False
        Me.txtCODALM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtCODALM.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtCODALM.Size = New System.Drawing.Size(100, 20)
        Me.txtCODALM.TabIndex = 0
        '
        'txtDESCALM
        '
        Me.txtDESCALM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDESCALM.Location = New System.Drawing.Point(157, 12)
        Me.txtDESCALM.Name = "txtDESCALM"
        Me.txtDESCALM.Properties.ReadOnly = True
        Me.txtDESCALM.Size = New System.Drawing.Size(446, 20)
        Me.txtDESCALM.TabIndex = 1
        Me.txtDESCALM.TabStop = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl5.TabIndex = 17
        Me.LabelControl5.Text = "Tienda:"
        '
        'txtCODCLI
        '
        Me.txtCODCLI.EditValue = ""
        Me.txtCODCLI.EnterMoveNextControl = True
        Me.txtCODCLI.Location = New System.Drawing.Point(58, 38)
        Me.txtCODCLI.Name = "txtCODCLI"
        Me.txtCODCLI.Properties.AutoHeight = False
        Me.txtCODCLI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtCODCLI.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.txtCODCLI.Properties.Mask.EditMask = "f0"
        Me.txtCODCLI.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCODCLI.Size = New System.Drawing.Size(100, 20)
        Me.txtCODCLI.TabIndex = 2
        '
        'txtNOMCLI
        '
        Me.txtNOMCLI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNOMCLI.Location = New System.Drawing.Point(157, 38)
        Me.txtNOMCLI.Name = "txtNOMCLI"
        Me.txtNOMCLI.Properties.ReadOnly = True
        Me.txtNOMCLI.Size = New System.Drawing.Size(446, 20)
        Me.txtNOMCLI.TabIndex = 3
        Me.txtNOMCLI.TabStop = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 41)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 16
        Me.LabelControl3.Text = "Cliente:"
        '
        'txtSERIE
        '
        Me.txtSERIE.EnterMoveNextControl = True
        Me.txtSERIE.Location = New System.Drawing.Point(58, 90)
        Me.txtSERIE.Name = "txtSERIE"
        Me.txtSERIE.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSERIE.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SERIE", "Serie", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMSERIE", "Descripción", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.txtSERIE.Properties.DataSource = Me.SERIESBindingSource
        Me.txtSERIE.Properties.DisplayMember = "NOMSERIE"
        Me.txtSERIE.Properties.NullText = ""
        Me.txtSERIE.Properties.ValueMember = "SERIE"
        Me.txtSERIE.Size = New System.Drawing.Size(165, 20)
        Me.txtSERIE.TabIndex = 5
        '
        'SERIESBindingSource
        '
        Me.SERIESBindingSource.DataMember = "SERIES"
        Me.SERIESBindingSource.DataSource = Me.DsSeries
        '
        'DsSeries
        '
        Me.DsSeries.DataSetName = "dsSeries"
        Me.DsSeries.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtTARIFA
        '
        Me.txtTARIFA.EnterMoveNextControl = True
        Me.txtTARIFA.Location = New System.Drawing.Point(58, 64)
        Me.txtTARIFA.Name = "txtTARIFA"
        Me.txtTARIFA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTARIFA.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TARIFA", "Tarifa", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCTARIFA", "Descripción", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.txtTARIFA.Properties.DataSource = Me.TARIFASBindingSource
        Me.txtTARIFA.Properties.DisplayMember = "DESCTARIFA"
        Me.txtTARIFA.Properties.NullText = ""
        Me.txtTARIFA.Properties.ValueMember = "TARIFA"
        Me.txtTARIFA.Size = New System.Drawing.Size(165, 20)
        Me.txtTARIFA.TabIndex = 4
        '
        'TARIFASBindingSource
        '
        Me.TARIFASBindingSource.DataMember = "TARIFAS"
        Me.TARIFASBindingSource.DataSource = Me.DsTarifas
        '
        'DsTarifas
        '
        Me.DsTarifas.DataSetName = "dsTarifas"
        Me.DsTarifas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(20, 67)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl10.TabIndex = 44
        Me.LabelControl10.Text = "Tarifa:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(24, 93)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl1.TabIndex = 45
        Me.LabelControl1.Text = "Serie:"
        '
        'bttAceptar
        '
        Me.bttAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttAceptar.Image = CType(resources.GetObject("bttAceptar.Image"), System.Drawing.Image)
        Me.bttAceptar.Location = New System.Drawing.Point(508, 82)
        Me.bttAceptar.Name = "bttAceptar"
        Me.bttAceptar.Size = New System.Drawing.Size(95, 28)
        Me.bttAceptar.TabIndex = 9
        Me.bttAceptar.Text = "(F3) &Aceptar"
        '
        'checkAbonar
        '
        Me.checkAbonar.Location = New System.Drawing.Point(229, 90)
        Me.checkAbonar.Name = "checkAbonar"
        Me.checkAbonar.Properties.AutoWidth = True
        Me.checkAbonar.Properties.Caption = "Abonar existencias a fecha"
        Me.checkAbonar.Size = New System.Drawing.Size(152, 19)
        Me.checkAbonar.TabIndex = 7
        '
        'checkTraspaso
        '
        Me.checkTraspaso.Location = New System.Drawing.Point(229, 64)
        Me.checkTraspaso.Name = "checkTraspaso"
        Me.checkTraspaso.Properties.AutoWidth = True
        Me.checkTraspaso.Properties.Caption = "Traspaso a almacén"
        Me.checkTraspaso.Size = New System.Drawing.Size(117, 19)
        Me.checkTraspaso.TabIndex = 6
        '
        'txtFecha
        '
        Me.txtFecha.EditValue = Nothing
        Me.txtFecha.Location = New System.Drawing.Point(387, 90)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 8
        '
        'fCierreTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 122)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.checkTraspaso)
        Me.Controls.Add(Me.checkAbonar)
        Me.Controls.Add(Me.bttAceptar)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtSERIE)
        Me.Controls.Add(Me.txtTARIFA)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txtCODALM)
        Me.Controls.Add(Me.txtDESCALM)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtCODCLI)
        Me.Controls.Add(Me.txtNOMCLI)
        Me.Controls.Add(Me.LabelControl3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fCierreTienda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Cierre de tienda"
        CType(Me.txtCODALM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDESCALM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCODCLI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNOMCLI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSERIE.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERIESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSeries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTARIFA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TARIFASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkAbonar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkTraspaso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCODALM As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtDESCALM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCODCLI As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtNOMCLI As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSERIE As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtTARIFA As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TARIFASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTarifas As a3ERP_AydaraTPV.dsTarifas
    Friend WithEvents DsSeries As a3ERP_AydaraTPV.dsSeries
    Friend WithEvents SERIESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents checkAbonar As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkTraspaso As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFecha As DevExpress.XtraEditors.DateEdit
End Class
