<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sorteos
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
        Me.txtFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.SORTEOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsSorteos = New AydaraTPV.dsSorteos()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SORTEOSTableAdapter = New AydaraTPV.dsSorteosTableAdapters.SORTEOSTableAdapter()
        Me.txtFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFechaSorteo = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.panelLoteria = New DevExpress.XtraEditors.GroupControl()
        Me.txtDepositadoEn = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNumero = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFraccion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtParticipacion = New DevExpress.XtraEditors.TextEdit()
        Me.rgTipoSorteo = New DevExpress.XtraEditors.RadioGroup()
        Me.checkSoloTarjetas = New DevExpress.XtraEditors.CheckEdit()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.checkAplicaPromociones = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.txtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SORTEOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSorteos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaSorteo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaSorteo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelLoteria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLoteria.SuspendLayout()
        CType(Me.txtDepositadoEn.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFraccion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtParticipacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgTipoSorteo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkSoloTarjetas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.checkAplicaPromociones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SORTEOSBindingSource, "FechaInicio", True))
        Me.txtFechaInicio.EditValue = Nothing
        Me.txtFechaInicio.EnterMoveNextControl = True
        Me.txtFechaInicio.Location = New System.Drawing.Point(54, 34)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaInicio.Properties.ReadOnly = True
        Me.txtFechaInicio.Size = New System.Drawing.Size(80, 20)
        Me.txtFechaInicio.TabIndex = 0
        '
        'SORTEOSBindingSource
        '
        Me.SORTEOSBindingSource.DataMember = "SORTEOS"
        Me.SORTEOSBindingSource.DataSource = Me.DsSorteos
        '
        'DsSorteos
        '
        Me.DsSorteos.DataSetName = "dsSorteos"
        Me.DsSorteos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 37)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Desde:"
        '
        'SORTEOSTableAdapter
        '
        Me.SORTEOSTableAdapter.ClearBeforeFill = True
        '
        'txtFechaFin
        '
        Me.txtFechaFin.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SORTEOSBindingSource, "FechaFin", True))
        Me.txtFechaFin.EditValue = Nothing
        Me.txtFechaFin.EnterMoveNextControl = True
        Me.txtFechaFin.Location = New System.Drawing.Point(177, 34)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaFin.Properties.ReadOnly = True
        Me.txtFechaFin.Size = New System.Drawing.Size(80, 20)
        Me.txtFechaFin.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(140, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "hasta:"
        '
        'txtFechaSorteo
        '
        Me.txtFechaSorteo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SORTEOSBindingSource, "FechaSorteo", True))
        Me.txtFechaSorteo.EditValue = Nothing
        Me.txtFechaSorteo.EnterMoveNextControl = True
        Me.txtFechaSorteo.Location = New System.Drawing.Point(113, 39)
        Me.txtFechaSorteo.Name = "txtFechaSorteo"
        Me.txtFechaSorteo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaSorteo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaSorteo.Properties.ReadOnly = True
        Me.txtFechaSorteo.Size = New System.Drawing.Size(80, 20)
        Me.txtFechaSorteo.TabIndex = 0
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(23, 42)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Fecha del sorteo:"
        '
        'panelLoteria
        '
        Me.panelLoteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelLoteria.Controls.Add(Me.txtDepositadoEn)
        Me.panelLoteria.Controls.Add(Me.LabelControl5)
        Me.panelLoteria.Controls.Add(Me.txtNumero)
        Me.panelLoteria.Controls.Add(Me.LabelControl9)
        Me.panelLoteria.Controls.Add(Me.txtFraccion)
        Me.panelLoteria.Controls.Add(Me.LabelControl6)
        Me.panelLoteria.Controls.Add(Me.LabelControl7)
        Me.panelLoteria.Controls.Add(Me.txtParticipacion)
        Me.panelLoteria.Controls.Add(Me.txtFechaSorteo)
        Me.panelLoteria.Controls.Add(Me.LabelControl3)
        Me.panelLoteria.Location = New System.Drawing.Point(314, 89)
        Me.panelLoteria.Name = "panelLoteria"
        Me.panelLoteria.Size = New System.Drawing.Size(401, 182)
        Me.panelLoteria.TabIndex = 3
        Me.panelLoteria.TabStop = True
        Me.panelLoteria.Text = "Datos lotería"
        '
        'txtDepositadoEn
        '
        Me.txtDepositadoEn.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SORTEOSBindingSource, "DepositadoEn", True))
        Me.txtDepositadoEn.Location = New System.Drawing.Point(113, 90)
        Me.txtDepositadoEn.Name = "txtDepositadoEn"
        Me.txtDepositadoEn.Properties.MaxLength = 40
        Me.txtDepositadoEn.Properties.ReadOnly = True
        Me.txtDepositadoEn.Size = New System.Drawing.Size(272, 20)
        Me.txtDepositadoEn.TabIndex = 2
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(34, 94)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl5.TabIndex = 20
        Me.LabelControl5.Text = "Depositado en:"
        '
        'txtNumero
        '
        Me.txtNumero.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SORTEOSBindingSource, "Numero", True))
        Me.txtNumero.EnterMoveNextControl = True
        Me.txtNumero.Location = New System.Drawing.Point(113, 65)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Properties.Mask.EditMask = "n0"
        Me.txtNumero.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNumero.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNumero.Properties.MaxLength = 6
        Me.txtNumero.Properties.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(80, 20)
        Me.txtNumero.TabIndex = 1
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(66, 68)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Número:"
        '
        'txtFraccion
        '
        Me.txtFraccion.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SORTEOSBindingSource, "Fraccion", True))
        Me.txtFraccion.EnterMoveNextControl = True
        Me.txtFraccion.Location = New System.Drawing.Point(113, 116)
        Me.txtFraccion.Name = "txtFraccion"
        Me.txtFraccion.Properties.Mask.EditMask = "n0"
        Me.txtFraccion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtFraccion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFraccion.Properties.MaxLength = 6
        Me.txtFraccion.Properties.ReadOnly = True
        Me.txtFraccion.Size = New System.Drawing.Size(62, 20)
        Me.txtFraccion.TabIndex = 3
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(63, 119)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl6.TabIndex = 20
        Me.LabelControl6.Text = "Fracción:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(43, 145)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl7.TabIndex = 22
        Me.LabelControl7.Text = "Participación:"
        '
        'txtParticipacion
        '
        Me.txtParticipacion.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SORTEOSBindingSource, "Participacion", True))
        Me.txtParticipacion.EnterMoveNextControl = True
        Me.txtParticipacion.Location = New System.Drawing.Point(113, 142)
        Me.txtParticipacion.Name = "txtParticipacion"
        Me.txtParticipacion.Properties.Mask.EditMask = "n0"
        Me.txtParticipacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtParticipacion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtParticipacion.Properties.MaxLength = 6
        Me.txtParticipacion.Properties.ReadOnly = True
        Me.txtParticipacion.Size = New System.Drawing.Size(82, 20)
        Me.txtParticipacion.TabIndex = 4
        '
        'rgTipoSorteo
        '
        Me.rgTipoSorteo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SORTEOSBindingSource, "Tipo", True))
        Me.rgTipoSorteo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rgTipoSorteo.Location = New System.Drawing.Point(2, 21)
        Me.rgTipoSorteo.Name = "rgTipoSorteo"
        Me.rgTipoSorteo.Properties.Columns = 2
        Me.rgTipoSorteo.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Lotería"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Puntos"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Vale de compra"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Descuento directo")})
        Me.rgTipoSorteo.Properties.ReadOnly = True
        Me.rgTipoSorteo.Size = New System.Drawing.Size(278, 79)
        Me.rgTipoSorteo.TabIndex = 0
        Me.rgTipoSorteo.ToolTipTitle = "Tipo de tienda"
        '
        'checkSoloTarjetas
        '
        Me.checkSoloTarjetas.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SORTEOSBindingSource, "SoloTarjetas", True))
        Me.checkSoloTarjetas.Location = New System.Drawing.Point(12, 24)
        Me.checkSoloTarjetas.Name = "checkSoloTarjetas"
        Me.checkSoloTarjetas.Properties.AutoWidth = True
        Me.checkSoloTarjetas.Properties.Caption = "Afecta sólo a tarjetas"
        Me.checkSoloTarjetas.Properties.ReadOnly = True
        Me.checkSoloTarjetas.Size = New System.Drawing.Size(126, 19)
        Me.checkSoloTarjetas.TabIndex = 0
        '
        'bttBuscar
        '
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.search
        Me.bttBuscar.Location = New System.Drawing.Point(538, 21)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(106, 45)
        Me.bttBuscar.TabIndex = 40
        Me.bttBuscar.TabStop = False
        Me.bttBuscar.Text = "Buscar"
        Me.bttBuscar.Visible = False
        '
        'bttModificar
        '
        Me.bttModificar.Enabled = False
        Me.bttModificar.Image = Global.AydaraTPV.My.Resources.Resources.menu_vales
        Me.bttModificar.Location = New System.Drawing.Point(426, 21)
        Me.bttModificar.Name = "bttModificar"
        Me.bttModificar.Size = New System.Drawing.Size(106, 45)
        Me.bttModificar.TabIndex = 39
        Me.bttModificar.TabStop = False
        Me.bttModificar.Text = "Modificar"
        Me.bttModificar.Visible = False
        '
        'bttNuevo
        '
        Me.bttNuevo.Image = Global.AydaraTPV.My.Resources.Resources._new
        Me.bttNuevo.Location = New System.Drawing.Point(314, 21)
        Me.bttNuevo.Name = "bttNuevo"
        Me.bttNuevo.Size = New System.Drawing.Size(106, 45)
        Me.bttNuevo.TabIndex = 35
        Me.bttNuevo.TabStop = False
        Me.bttNuevo.Text = "Nuevo"
        Me.bttNuevo.Visible = False
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.save
        Me.bttGuardar.Location = New System.Drawing.Point(609, 294)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(106, 45)
        Me.bttGuardar.TabIndex = 36
        Me.bttGuardar.TabStop = False
        Me.bttGuardar.Text = "Guardar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(12, 294)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 37
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'bttEliminar
        '
        Me.bttEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttEliminar.Image = Global.AydaraTPV.My.Resources.Resources.delete2
        Me.bttEliminar.Location = New System.Drawing.Point(497, 294)
        Me.bttEliminar.Name = "bttEliminar"
        Me.bttEliminar.Size = New System.Drawing.Size(106, 45)
        Me.bttEliminar.TabIndex = 38
        Me.bttEliminar.TabStop = False
        Me.bttEliminar.Text = "Eliminar"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtFechaInicio)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.txtFechaFin)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(282, 71)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Fechas"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.rgTipoSorteo)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 89)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(282, 102)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Tipo de fidelización"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.checkAplicaPromociones)
        Me.GroupControl3.Controls.Add(Me.checkSoloTarjetas)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 197)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(282, 74)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Opciones fidelización"
        '
        'checkAplicaPromociones
        '
        Me.checkAplicaPromociones.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.SORTEOSBindingSource, "AplicaPromociones", True))
        Me.checkAplicaPromociones.Location = New System.Drawing.Point(12, 49)
        Me.checkAplicaPromociones.Name = "checkAplicaPromociones"
        Me.checkAplicaPromociones.Properties.AutoWidth = True
        Me.checkAplicaPromociones.Properties.Caption = "Aplicar en artículos en promoción"
        Me.checkAplicaPromociones.Properties.ReadOnly = True
        Me.checkAplicaPromociones.Size = New System.Drawing.Size(179, 19)
        Me.checkAplicaPromociones.TabIndex = 1
        '
        'Sorteos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 351)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.bttBuscar)
        Me.Controls.Add(Me.bttModificar)
        Me.Controls.Add(Me.bttNuevo)
        Me.Controls.Add(Me.bttGuardar)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttEliminar)
        Me.Controls.Add(Me.panelLoteria)
        Me.Name = "Sorteos"
        Me.Text = "Fidelización"
        CType(Me.txtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SORTEOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSorteos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaSorteo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaSorteo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelLoteria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLoteria.ResumeLayout(False)
        Me.panelLoteria.PerformLayout()
        CType(Me.txtDepositadoEn.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumero.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFraccion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtParticipacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgTipoSorteo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkSoloTarjetas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.checkAplicaPromociones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsSorteos As AydaraTPV.dsSorteos
    Friend WithEvents SORTEOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SORTEOSTableAdapter As AydaraTPV.dsSorteosTableAdapters.SORTEOSTableAdapter
    Friend WithEvents txtFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaSorteo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents panelLoteria As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDepositadoEn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumero As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgTipoSorteo As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents checkSoloTarjetas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtFraccion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtParticipacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents checkAplicaPromociones As DevExpress.XtraEditors.CheckEdit
End Class
