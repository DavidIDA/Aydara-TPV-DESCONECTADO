<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fNuevaIncidencia
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
        Me.lblCambio = New DevExpress.XtraEditors.LabelControl
        Me.cboTipo = New DevExpress.XtraEditors.LookUpEdit
        Me.bsTipos = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsIncidenciasTipos1 = New AydaraTPV.dsIncidenciasTipos
        Me.cboEmpleado = New DevExpress.XtraEditors.LookUpEdit
        Me.bsEmpleados = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpleados1 = New AydaraTPV.dsEmpleados
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.dtFecha = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.btnArticulo = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtComentarios = New DevExpress.XtraEditors.MemoEdit
        Me.lblArticulo = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.chkAfectaStock = New DevExpress.XtraEditors.CheckEdit
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.cboES = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtCantidad = New DevExpress.XtraEditors.TextEdit
        CType(Me.cboTipo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsIncidenciasTipos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpleados1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.chkAfectaStock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.cboES.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCambio
        '
        Me.lblCambio.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambio.Appearance.Options.UseFont = True
        Me.lblCambio.Appearance.Options.UseTextOptions = True
        Me.lblCambio.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblCambio.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCambio.Location = New System.Drawing.Point(23, 24)
        Me.lblCambio.Name = "lblCambio"
        Me.lblCambio.Size = New System.Drawing.Size(115, 29)
        Me.lblCambio.TabIndex = 63
        Me.lblCambio.Text = "Tipo :"
        '
        'cboTipo
        '
        Me.cboTipo.Location = New System.Drawing.Point(144, 23)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.Properties.Appearance.Options.UseFont = True
        Me.cboTipo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboTipo.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción", 117, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboTipo.Properties.DataSource = Me.bsTipos
        Me.cboTipo.Properties.DisplayMember = "Descripcion"
        Me.cboTipo.Properties.NullText = ""
        Me.cboTipo.Properties.ValueMember = "IDTipo"
        Me.cboTipo.Size = New System.Drawing.Size(258, 32)
        Me.cboTipo.TabIndex = 64
        '
        'bsTipos
        '
        Me.bsTipos.DataMember = "INCIDENCIAS_TIPOS"
        Me.bsTipos.DataSource = Me.DsIncidenciasTipos1
        '
        'DsIncidenciasTipos1
        '
        Me.DsIncidenciasTipos1.DataSetName = "dsIncidenciasTipos"
        Me.DsIncidenciasTipos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboEmpleado
        '
        Me.cboEmpleado.Location = New System.Drawing.Point(144, 71)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpleado.Properties.Appearance.Options.UseFont = True
        Me.cboEmpleado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboEmpleado.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Empleado", 84, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cboEmpleado.Properties.DataSource = Me.bsEmpleados
        Me.cboEmpleado.Properties.DisplayMember = "Nombre"
        Me.cboEmpleado.Properties.NullText = ""
        Me.cboEmpleado.Properties.ValueMember = "Codigo"
        Me.cboEmpleado.Size = New System.Drawing.Size(258, 32)
        Me.cboEmpleado.TabIndex = 66
        '
        'bsEmpleados
        '
        Me.bsEmpleados.DataMember = "OPERARIOS"
        Me.bsEmpleados.DataSource = Me.DsEmpleados1
        '
        'DsEmpleados1
        '
        Me.DsEmpleados1.DataSetName = "dsEmpleados"
        Me.DsEmpleados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(23, 72)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(115, 29)
        Me.LabelControl1.TabIndex = 65
        Me.LabelControl1.Text = "Empleado :"
        '
        'dtFecha
        '
        Me.dtFecha.EditValue = Nothing
        Me.dtFecha.Location = New System.Drawing.Point(533, 23)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtFecha.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Properties.Appearance.Options.UseFont = True
        Me.dtFecha.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtFecha.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtFecha.Size = New System.Drawing.Size(304, 32)
        Me.dtFecha.TabIndex = 67
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Location = New System.Drawing.Point(414, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(113, 29)
        Me.LabelControl2.TabIndex = 68
        Me.LabelControl2.Text = "Fecha :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(414, 70)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(113, 29)
        Me.LabelControl3.TabIndex = 69
        Me.LabelControl3.Text = "Cantidad :"
        '
        'btnArticulo
        '
        Me.btnArticulo.EnterMoveNextControl = True
        Me.btnArticulo.Location = New System.Drawing.Point(144, 23)
        Me.btnArticulo.Name = "btnArticulo"
        Me.btnArticulo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArticulo.Properties.Appearance.Options.UseFont = True
        Me.btnArticulo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.btnArticulo.Size = New System.Drawing.Size(129, 32)
        Me.btnArticulo.TabIndex = 70
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(5, 23)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(133, 29)
        Me.LabelControl4.TabIndex = 71
        Me.LabelControl4.Text = "Artículo :"
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(144, 61)
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentarios.Properties.Appearance.Options.UseFont = True
        Me.txtComentarios.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtComentarios.Size = New System.Drawing.Size(534, 105)
        Me.txtComentarios.TabIndex = 72
        '
        'lblArticulo
        '
        Me.lblArticulo.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArticulo.Appearance.Options.UseFont = True
        Me.lblArticulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblArticulo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lblArticulo.Location = New System.Drawing.Point(279, 24)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.lblArticulo.Size = New System.Drawing.Size(399, 29)
        Me.lblArticulo.TabIndex = 74
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.chkAfectaStock)
        Me.GroupControl1.Controls.Add(Me.bttGuardar)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.lblArticulo)
        Me.GroupControl1.Controls.Add(Me.btnArticulo)
        Me.GroupControl1.Controls.Add(Me.txtComentarios)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 145)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(854, 178)
        Me.GroupControl1.TabIndex = 75
        Me.GroupControl1.Text = "Material"
        '
        'chkAfectaStock
        '
        Me.chkAfectaStock.EditValue = True
        Me.chkAfectaStock.Location = New System.Drawing.Point(684, 25)
        Me.chkAfectaStock.Name = "chkAfectaStock"
        Me.chkAfectaStock.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.chkAfectaStock.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAfectaStock.Properties.Appearance.Options.UseFont = True
        Me.chkAfectaStock.Properties.Appearance.Options.UseTextOptions = True
        Me.chkAfectaStock.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.chkAfectaStock.Properties.Caption = "Afecta a Stock"
        Me.chkAfectaStock.Size = New System.Drawing.Size(165, 30)
        Me.chkAfectaStock.TabIndex = 129
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.ok_32
        Me.bttGuardar.Location = New System.Drawing.Point(704, 121)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(133, 45)
        Me.bttGuardar.TabIndex = 128
        Me.bttGuardar.TabStop = False
        Me.bttGuardar.Text = "Añadir incidencia"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(5, 63)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(133, 29)
        Me.LabelControl6.TabIndex = 75
        Me.LabelControl6.Text = "Comentarios :"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.cboES)
        Me.GroupControl2.Controls.Add(Me.txtCantidad)
        Me.GroupControl2.Controls.Add(Me.cboTipo)
        Me.GroupControl2.Controls.Add(Me.lblCambio)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.cboEmpleado)
        Me.GroupControl2.Controls.Add(Me.dtFecha)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(854, 127)
        Me.GroupControl2.TabIndex = 76
        Me.GroupControl2.Text = "Incidencia"
        '
        'cboES
        '
        Me.cboES.EditValue = "Salida"
        Me.cboES.Location = New System.Drawing.Point(704, 69)
        Me.cboES.Name = "cboES"
        Me.cboES.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboES.Properties.Appearance.Options.UseFont = True
        Me.cboES.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboES.Properties.Items.AddRange(New Object() {"Entrada", "Salida"})
        Me.cboES.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cboES.Size = New System.Drawing.Size(133, 32)
        Me.cboES.TabIndex = 71
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(533, 69)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Properties.Appearance.Options.UseFont = True
        Me.txtCantidad.Properties.Mask.EditMask = "n2"
        Me.txtCantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCantidad.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCantidad.Size = New System.Drawing.Size(145, 32)
        Me.txtCantidad.TabIndex = 70
        '
        'fNuevaIncidencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 335)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "fNuevaIncidencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Incidencia"
        CType(Me.cboTipo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsIncidenciasTipos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpleados1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComentarios.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.chkAfectaStock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.cboES.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCambio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboTipo As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DsIncidenciasTipos1 As AydaraTPV.dsIncidenciasTipos
    Friend WithEvents bsTipos As System.Windows.Forms.BindingSource
    Friend WithEvents cboEmpleado As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtFecha As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnArticulo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComentarios As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblArticulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCantidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DsEmpleados1 As AydaraTPV.dsEmpleados
    Friend WithEvents bsEmpleados As System.Windows.Forms.BindingSource
    Friend WithEvents chkAfectaStock As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cboES As DevExpress.XtraEditors.ComboBoxEdit
End Class
