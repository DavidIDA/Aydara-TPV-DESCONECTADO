<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoInventario
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodigoInicio = New DevExpress.XtraEditors.ButtonEdit
        Me.txtCodigoFin = New DevExpress.XtraEditors.ButtonEdit
        Me.txtDescripcionInicio = New DevExpress.XtraEditors.TextEdit
        Me.txtDescripcionFin = New DevExpress.XtraEditors.TextEdit
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.checkControlBaja = New DevExpress.XtraEditors.CheckEdit
        Me.checkAgruparFamilia = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtOrden = New DevExpress.XtraEditors.ComboBoxEdit
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.gcOpciones = New DevExpress.XtraEditors.GroupControl
        Me.rgValorado = New DevExpress.XtraEditors.RadioGroup
        Me.checkBajoMinimo = New DevExpress.XtraEditors.CheckEdit
        Me.checkExistencia0 = New DevExpress.XtraEditors.CheckEdit
        Me.checkValorado = New DevExpress.XtraEditors.CheckEdit
        Me.txtTipoOrden = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtDescripcionFamiliaInicio = New DevExpress.XtraEditors.TextEdit
        Me.txtCodigoFamiliaInicio = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtDescripcionFamiliaFin = New DevExpress.XtraEditors.TextEdit
        Me.txtCodigoFamiliaFin = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtNombreProveedor = New DevExpress.XtraEditors.TextEdit
        Me.txtCodigoProveedor = New DevExpress.XtraEditors.ButtonEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        CType(Me.txtCodigoInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkControlBaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkAgruparFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcOpciones.SuspendLayout()
        CType(Me.rgValorado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkBajoMinimo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkExistencia0.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkValorado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoOrden.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionFamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionFamiliaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFamiliaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Desde:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 41)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Hasta:"
        '
        'txtCodigoInicio
        '
        Me.txtCodigoInicio.EnterMoveNextControl = True
        Me.txtCodigoInicio.Location = New System.Drawing.Point(52, 12)
        Me.txtCodigoInicio.Name = "txtCodigoInicio"
        Me.txtCodigoInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoInicio.Properties.MaxLength = 7
        Me.txtCodigoInicio.Size = New System.Drawing.Size(83, 20)
        Me.txtCodigoInicio.TabIndex = 0
        '
        'txtCodigoFin
        '
        Me.txtCodigoFin.EnterMoveNextControl = True
        Me.txtCodigoFin.Location = New System.Drawing.Point(52, 38)
        Me.txtCodigoFin.Name = "txtCodigoFin"
        Me.txtCodigoFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoFin.Properties.MaxLength = 7
        Me.txtCodigoFin.Size = New System.Drawing.Size(83, 20)
        Me.txtCodigoFin.TabIndex = 1
        '
        'txtDescripcionInicio
        '
        Me.txtDescripcionInicio.Location = New System.Drawing.Point(134, 12)
        Me.txtDescripcionInicio.Name = "txtDescripcionInicio"
        Me.txtDescripcionInicio.Properties.ReadOnly = True
        Me.txtDescripcionInicio.Size = New System.Drawing.Size(364, 20)
        Me.txtDescripcionInicio.TabIndex = 4
        Me.txtDescripcionInicio.TabStop = False
        '
        'txtDescripcionFin
        '
        Me.txtDescripcionFin.Location = New System.Drawing.Point(134, 38)
        Me.txtDescripcionFin.Name = "txtDescripcionFin"
        Me.txtDescripcionFin.Properties.ReadOnly = True
        Me.txtDescripcionFin.Size = New System.Drawing.Size(364, 20)
        Me.txtDescripcionFin.TabIndex = 5
        Me.txtDescripcionFin.TabStop = False
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttImprimir.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttImprimir.Location = New System.Drawing.Point(411, 303)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(87, 25)
        Me.bttImprimir.TabIndex = 10
        Me.bttImprimir.Text = "Imprimir"
        '
        'checkControlBaja
        '
        Me.checkControlBaja.Location = New System.Drawing.Point(5, 98)
        Me.checkControlBaja.Name = "checkControlBaja"
        Me.checkControlBaja.Properties.Caption = "Control de Baja"
        Me.checkControlBaja.Size = New System.Drawing.Size(99, 19)
        Me.checkControlBaja.TabIndex = 5
        Me.checkControlBaja.TabStop = False
        '
        'checkAgruparFamilia
        '
        Me.checkAgruparFamilia.EditValue = True
        Me.checkAgruparFamilia.Location = New System.Drawing.Point(110, 98)
        Me.checkAgruparFamilia.Name = "checkAgruparFamilia"
        Me.checkAgruparFamilia.Properties.Caption = "Agrupar por familias"
        Me.checkAgruparFamilia.Size = New System.Drawing.Size(113, 19)
        Me.checkAgruparFamilia.TabIndex = 6
        Me.checkAgruparFamilia.TabStop = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(7, 126)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl6.TabIndex = 19
        Me.LabelControl6.Text = "Ordenar por:"
        '
        'txtOrden
        '
        Me.txtOrden.EditValue = "Código"
        Me.txtOrden.Location = New System.Drawing.Point(76, 123)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtOrden.Properties.Items.AddRange(New Object() {"Código", "Descripción", "Proveedor"})
        Me.txtOrden.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtOrden.Size = New System.Drawing.Size(95, 20)
        Me.txtOrden.TabIndex = 7
        Me.txtOrden.TabStop = False
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources._1321518972_close
        Me.bttCancelar.Location = New System.Drawing.Point(318, 303)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(87, 25)
        Me.bttCancelar.TabIndex = 11
        Me.bttCancelar.Text = "Cancelar"
        '
        'gcOpciones
        '
        Me.gcOpciones.Controls.Add(Me.rgValorado)
        Me.gcOpciones.Controls.Add(Me.checkBajoMinimo)
        Me.gcOpciones.Controls.Add(Me.checkExistencia0)
        Me.gcOpciones.Controls.Add(Me.checkValorado)
        Me.gcOpciones.Controls.Add(Me.checkControlBaja)
        Me.gcOpciones.Controls.Add(Me.checkAgruparFamilia)
        Me.gcOpciones.Controls.Add(Me.txtTipoOrden)
        Me.gcOpciones.Controls.Add(Me.LabelControl6)
        Me.gcOpciones.Controls.Add(Me.txtOrden)
        Me.gcOpciones.Location = New System.Drawing.Point(12, 174)
        Me.gcOpciones.Name = "gcOpciones"
        Me.gcOpciones.Size = New System.Drawing.Size(270, 154)
        Me.gcOpciones.TabIndex = 4
        Me.gcOpciones.Text = "Opciones"
        '
        'rgValorado
        '
        Me.rgValorado.EditValue = "Coste"
        Me.rgValorado.Location = New System.Drawing.Point(112, 23)
        Me.rgValorado.Name = "rgValorado"
        Me.rgValorado.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.rgValorado.Properties.Appearance.Options.UseBackColor = True
        Me.rgValorado.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Coste", "Coste"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Venta", "Venta")})
        Me.rgValorado.Size = New System.Drawing.Size(117, 19)
        Me.rgValorado.TabIndex = 31
        Me.rgValorado.Visible = False
        '
        'checkBajoMinimo
        '
        Me.checkBajoMinimo.Location = New System.Drawing.Point(5, 73)
        Me.checkBajoMinimo.Name = "checkBajoMinimo"
        Me.checkBajoMinimo.Properties.Caption = "Mostrar artículos sólo bajo mínimo"
        Me.checkBajoMinimo.Size = New System.Drawing.Size(215, 19)
        Me.checkBajoMinimo.TabIndex = 2
        Me.checkBajoMinimo.TabStop = False
        '
        'checkExistencia0
        '
        Me.checkExistencia0.Location = New System.Drawing.Point(5, 48)
        Me.checkExistencia0.Name = "checkExistencia0"
        Me.checkExistencia0.Properties.Caption = "Mostrar artículos con existencia 0"
        Me.checkExistencia0.Size = New System.Drawing.Size(215, 19)
        Me.checkExistencia0.TabIndex = 1
        Me.checkExistencia0.TabStop = False
        '
        'checkValorado
        '
        Me.checkValorado.Location = New System.Drawing.Point(5, 23)
        Me.checkValorado.Name = "checkValorado"
        Me.checkValorado.Properties.Caption = "Informe valorado"
        Me.checkValorado.Size = New System.Drawing.Size(118, 19)
        Me.checkValorado.TabIndex = 0
        Me.checkValorado.TabStop = False
        '
        'txtTipoOrden
        '
        Me.txtTipoOrden.EditValue = "Ascendente"
        Me.txtTipoOrden.Location = New System.Drawing.Point(170, 123)
        Me.txtTipoOrden.Name = "txtTipoOrden"
        Me.txtTipoOrden.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtTipoOrden.Properties.Items.AddRange(New Object() {"Ascendente", "Descendente"})
        Me.txtTipoOrden.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtTipoOrden.Size = New System.Drawing.Size(89, 20)
        Me.txtTipoOrden.TabIndex = 21
        Me.txtTipoOrden.TabStop = False
        '
        'txtDescripcionFamiliaInicio
        '
        Me.txtDescripcionFamiliaInicio.Location = New System.Drawing.Point(122, 24)
        Me.txtDescripcionFamiliaInicio.Name = "txtDescripcionFamiliaInicio"
        Me.txtDescripcionFamiliaInicio.Properties.ReadOnly = True
        Me.txtDescripcionFamiliaInicio.Size = New System.Drawing.Size(359, 20)
        Me.txtDescripcionFamiliaInicio.TabIndex = 24
        Me.txtDescripcionFamiliaInicio.TabStop = False
        '
        'txtCodigoFamiliaInicio
        '
        Me.txtCodigoFamiliaInicio.EnterMoveNextControl = True
        Me.txtCodigoFamiliaInicio.Location = New System.Drawing.Point(45, 24)
        Me.txtCodigoFamiliaInicio.Name = "txtCodigoFamiliaInicio"
        Me.txtCodigoFamiliaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoFamiliaInicio.Properties.MaxLength = 7
        Me.txtCodigoFamiliaInicio.Size = New System.Drawing.Size(78, 20)
        Me.txtCodigoFamiliaInicio.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(5, 27)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl3.TabIndex = 22
        Me.LabelControl3.Text = "Desde:"
        '
        'txtDescripcionFamiliaFin
        '
        Me.txtDescripcionFamiliaFin.Location = New System.Drawing.Point(122, 50)
        Me.txtDescripcionFamiliaFin.Name = "txtDescripcionFamiliaFin"
        Me.txtDescripcionFamiliaFin.Properties.ReadOnly = True
        Me.txtDescripcionFamiliaFin.Size = New System.Drawing.Size(359, 20)
        Me.txtDescripcionFamiliaFin.TabIndex = 27
        Me.txtDescripcionFamiliaFin.TabStop = False
        '
        'txtCodigoFamiliaFin
        '
        Me.txtCodigoFamiliaFin.EnterMoveNextControl = True
        Me.txtCodigoFamiliaFin.Location = New System.Drawing.Point(45, 50)
        Me.txtCodigoFamiliaFin.Name = "txtCodigoFamiliaFin"
        Me.txtCodigoFamiliaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoFamiliaFin.Properties.MaxLength = 7
        Me.txtCodigoFamiliaFin.Size = New System.Drawing.Size(78, 20)
        Me.txtCodigoFamiliaFin.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(5, 53)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl4.TabIndex = 25
        Me.LabelControl4.Text = "Hasta:"
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Location = New System.Drawing.Point(134, 148)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Properties.ReadOnly = True
        Me.txtNombreProveedor.Size = New System.Drawing.Size(364, 20)
        Me.txtNombreProveedor.TabIndex = 30
        Me.txtNombreProveedor.TabStop = False
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.EnterMoveNextControl = True
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(72, 148)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoProveedor.Properties.MaxLength = 7
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(63, 20)
        Me.txtCodigoProveedor.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 151)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl5.TabIndex = 28
        Me.LabelControl5.Text = "Proveedor:"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtCodigoFamiliaInicio)
        Me.GroupControl1.Controls.Add(Me.txtDescripcionFamiliaInicio)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.txtDescripcionFamiliaFin)
        Me.GroupControl1.Controls.Add(Me.txtCodigoFamiliaFin)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 64)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(486, 78)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Familias"
        '
        'ListadoInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.bttCancelar
        Me.ClientSize = New System.Drawing.Size(510, 340)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.txtNombreProveedor)
        Me.Controls.Add(Me.txtCodigoProveedor)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.gcOpciones)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttImprimir)
        Me.Controls.Add(Me.txtDescripcionFin)
        Me.Controls.Add(Me.txtDescripcionInicio)
        Me.Controls.Add(Me.txtCodigoFin)
        Me.Controls.Add(Me.txtCodigoInicio)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "ListadoInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado inventario de artículos"
        CType(Me.txtCodigoInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkControlBaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkAgruparFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcOpciones.ResumeLayout(False)
        Me.gcOpciones.PerformLayout()
        CType(Me.rgValorado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkBajoMinimo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkExistencia0.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkValorado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoOrden.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionFamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFamiliaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionFamiliaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFamiliaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoInicio As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCodigoFin As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtDescripcionInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcionFin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents checkControlBaja As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkAgruparFamilia As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtOrden As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtTipoOrden As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtDescripcionFamiliaInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoFamiliaInicio As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcionFamiliaFin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoFamiliaFin As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoProveedor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents checkBajoMinimo As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkExistencia0 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkValorado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents rgValorado As DevExpress.XtraEditors.RadioGroup
End Class
