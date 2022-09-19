<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cajas
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
        Me.colActivaCorteTicket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bttNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.CAJASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsCajas = New AydaraTPV.dsCajas
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.Acti = New DevExpress.XtraEditors.LabelControl
        Me.txtCorteTicket = New DevExpress.XtraEditors.TextEdit
        Me.txtAbreCajon = New DevExpress.XtraEditors.TextEdit
        Me.txtDesactivaExpandido = New DevExpress.XtraEditors.TextEdit
        Me.txtActivaExpandido = New DevExpress.XtraEditors.TextEdit
        Me.txtDesactivaVisor = New DevExpress.XtraEditors.TextEdit
        Me.txtActivaVisor = New DevExpress.XtraEditors.TextEdit
        Me.checkVisor = New DevExpress.XtraEditors.CheckEdit
        Me.checkCorteTicket = New DevExpress.XtraEditors.CheckEdit
        Me.checkAperturaCajon = New DevExpress.XtraEditors.CheckEdit
        Me.checkCajaCerrada = New DevExpress.XtraEditors.CheckEdit
        Me.txtTopeEfectivoCaja = New DevExpress.XtraEditors.TextEdit
        Me.txtNumeroTicket2 = New DevExpress.XtraEditors.TextEdit
        Me.txtNumeroTicket = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.bttEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.CAJASTableAdapter = New AydaraTPV.dsCajasTableAdapters.CAJASTableAdapter
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.bttModificar = New DevExpress.XtraEditors.SimpleButton
        Me.cmbImprimeTicket = New DevExpress.XtraEditors.ComboBoxEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodigoCaja = New DevExpress.XtraEditors.ButtonEdit
        CType(Me.CAJASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorteTicket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAbreCajon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesactivaExpandido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivaExpandido.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDesactivaVisor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivaVisor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkVisor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkCorteTicket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkAperturaCajon.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkCajaCerrada.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTopeEfectivoCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroTicket2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNumeroTicket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbImprimeTicket.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtCodigoCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colActivaCorteTicket
        '
        Me.colActivaCorteTicket.FieldName = "ActivaCorteTicket"
        Me.colActivaCorteTicket.Name = "colActivaCorteTicket"
        Me.colActivaCorteTicket.Visible = True
        Me.colActivaCorteTicket.VisibleIndex = 30
        Me.colActivaCorteTicket.Width = 34
        '
        'bttNuevo
        '
        Me.bttNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttNuevo.Image = Global.AydaraTPV.My.Resources.Resources._new
        Me.bttNuevo.Location = New System.Drawing.Point(12, 509)
        Me.bttNuevo.Name = "bttNuevo"
        Me.bttNuevo.Size = New System.Drawing.Size(106, 45)
        Me.bttNuevo.TabIndex = 2
        Me.bttNuevo.TabStop = False
        Me.bttNuevo.Text = "Nuevo"
        '
        'CAJASBindingSource
        '
        Me.CAJASBindingSource.DataMember = "CAJAS"
        Me.CAJASBindingSource.DataSource = Me.DsCajas
        '
        'DsCajas
        '
        Me.DsCajas.DataSetName = "dsCajas"
        Me.DsCajas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(19, 33)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl6.TabIndex = 34
        Me.LabelControl6.Text = "Imprime Tickect:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(99, 197)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl9.TabIndex = 9
        Me.LabelControl9.Text = "Desactiva Expandido:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(116, 171)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl8.TabIndex = 9
        Me.LabelControl8.Text = "Activa Expandido:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(152, 145)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl7.TabIndex = 9
        Me.LabelControl7.Text = "Desactiva:"
        '
        'Acti
        '
        Me.Acti.Location = New System.Drawing.Point(169, 119)
        Me.Acti.Name = "Acti"
        Me.Acti.Size = New System.Drawing.Size(34, 13)
        Me.Acti.TabIndex = 9
        Me.Acti.Text = "Activa:"
        '
        'txtCorteTicket
        '
        Me.txtCorteTicket.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CAJASBindingSource, "TextoCorteTicket", True))
        Me.txtCorteTicket.EnterMoveNextControl = True
        Me.txtCorteTicket.Location = New System.Drawing.Point(209, 87)
        Me.txtCorteTicket.Name = "txtCorteTicket"
        Me.txtCorteTicket.Properties.MaxLength = 30
        Me.txtCorteTicket.Properties.ReadOnly = True
        Me.txtCorteTicket.Size = New System.Drawing.Size(188, 20)
        Me.txtCorteTicket.TabIndex = 3
        '
        'txtAbreCajon
        '
        Me.txtAbreCajon.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CAJASBindingSource, "AbreCajon", True))
        Me.txtAbreCajon.EnterMoveNextControl = True
        Me.txtAbreCajon.Location = New System.Drawing.Point(209, 61)
        Me.txtAbreCajon.Name = "txtAbreCajon"
        Me.txtAbreCajon.Properties.MaxLength = 30
        Me.txtAbreCajon.Properties.ReadOnly = True
        Me.txtAbreCajon.Size = New System.Drawing.Size(188, 20)
        Me.txtAbreCajon.TabIndex = 2
        '
        'txtDesactivaExpandido
        '
        Me.txtDesactivaExpandido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CAJASBindingSource, "DesactivaExpandido", True))
        Me.txtDesactivaExpandido.EnterMoveNextControl = True
        Me.txtDesactivaExpandido.Location = New System.Drawing.Point(209, 194)
        Me.txtDesactivaExpandido.Name = "txtDesactivaExpandido"
        Me.txtDesactivaExpandido.Properties.MaxLength = 30
        Me.txtDesactivaExpandido.Properties.ReadOnly = True
        Me.txtDesactivaExpandido.Size = New System.Drawing.Size(188, 20)
        Me.txtDesactivaExpandido.TabIndex = 7
        '
        'txtActivaExpandido
        '
        Me.txtActivaExpandido.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CAJASBindingSource, "ActivaExpandido", True))
        Me.txtActivaExpandido.EnterMoveNextControl = True
        Me.txtActivaExpandido.Location = New System.Drawing.Point(209, 168)
        Me.txtActivaExpandido.Name = "txtActivaExpandido"
        Me.txtActivaExpandido.Properties.MaxLength = 30
        Me.txtActivaExpandido.Properties.ReadOnly = True
        Me.txtActivaExpandido.Size = New System.Drawing.Size(188, 20)
        Me.txtActivaExpandido.TabIndex = 6
        '
        'txtDesactivaVisor
        '
        Me.txtDesactivaVisor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CAJASBindingSource, "DesactivaVisor", True))
        Me.txtDesactivaVisor.EnterMoveNextControl = True
        Me.txtDesactivaVisor.Location = New System.Drawing.Point(209, 142)
        Me.txtDesactivaVisor.Name = "txtDesactivaVisor"
        Me.txtDesactivaVisor.Properties.MaxLength = 30
        Me.txtDesactivaVisor.Properties.ReadOnly = True
        Me.txtDesactivaVisor.Size = New System.Drawing.Size(188, 20)
        Me.txtDesactivaVisor.TabIndex = 5
        '
        'txtActivaVisor
        '
        Me.txtActivaVisor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CAJASBindingSource, "ActivaVisor", True))
        Me.txtActivaVisor.EnterMoveNextControl = True
        Me.txtActivaVisor.Location = New System.Drawing.Point(209, 116)
        Me.txtActivaVisor.Name = "txtActivaVisor"
        Me.txtActivaVisor.Properties.MaxLength = 30
        Me.txtActivaVisor.Properties.ReadOnly = True
        Me.txtActivaVisor.Size = New System.Drawing.Size(188, 20)
        Me.txtActivaVisor.TabIndex = 4
        '
        'checkVisor
        '
        Me.checkVisor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CAJASBindingSource, "Visor", True))
        Me.checkVisor.Location = New System.Drawing.Point(17, 118)
        Me.checkVisor.Name = "checkVisor"
        Me.checkVisor.Properties.Caption = "Visor"
        Me.checkVisor.Properties.ReadOnly = True
        Me.checkVisor.Size = New System.Drawing.Size(48, 19)
        Me.checkVisor.TabIndex = 11
        Me.checkVisor.TabStop = False
        '
        'checkCorteTicket
        '
        Me.checkCorteTicket.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CAJASBindingSource, "CorteTicket", True))
        Me.checkCorteTicket.Location = New System.Drawing.Point(17, 89)
        Me.checkCorteTicket.Name = "checkCorteTicket"
        Me.checkCorteTicket.Properties.Caption = "Corte Ticket"
        Me.checkCorteTicket.Properties.ReadOnly = True
        Me.checkCorteTicket.Size = New System.Drawing.Size(88, 19)
        Me.checkCorteTicket.TabIndex = 10
        Me.checkCorteTicket.TabStop = False
        '
        'checkAperturaCajon
        '
        Me.checkAperturaCajon.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CAJASBindingSource, "AperturaCajon", True))
        Me.checkAperturaCajon.Location = New System.Drawing.Point(17, 61)
        Me.checkAperturaCajon.Name = "checkAperturaCajon"
        Me.checkAperturaCajon.Properties.Caption = "Apertura Cajón"
        Me.checkAperturaCajon.Properties.ReadOnly = True
        Me.checkAperturaCajon.Size = New System.Drawing.Size(95, 19)
        Me.checkAperturaCajon.TabIndex = 9
        Me.checkAperturaCajon.TabStop = False
        '
        'checkCajaCerrada
        '
        Me.checkCajaCerrada.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.CAJASBindingSource, "CajaCerrada", True))
        Me.checkCajaCerrada.Location = New System.Drawing.Point(160, 12)
        Me.checkCajaCerrada.Name = "checkCajaCerrada"
        Me.checkCajaCerrada.Properties.Caption = "Caja Cerrada"
        Me.checkCajaCerrada.Properties.ReadOnly = True
        Me.checkCajaCerrada.Size = New System.Drawing.Size(88, 19)
        Me.checkCajaCerrada.TabIndex = 7
        Me.checkCajaCerrada.TabStop = False
        '
        'txtTopeEfectivoCaja
        '
        Me.txtTopeEfectivoCaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CAJASBindingSource, "TopeEfectivoEnCaja", True))
        Me.txtTopeEfectivoCaja.EnterMoveNextControl = True
        Me.txtTopeEfectivoCaja.Location = New System.Drawing.Point(128, 59)
        Me.txtTopeEfectivoCaja.Name = "txtTopeEfectivoCaja"
        Me.txtTopeEfectivoCaja.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTopeEfectivoCaja.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTopeEfectivoCaja.Properties.ReadOnly = True
        Me.txtTopeEfectivoCaja.Size = New System.Drawing.Size(86, 20)
        Me.txtTopeEfectivoCaja.TabIndex = 2
        '
        'txtNumeroTicket2
        '
        Me.txtNumeroTicket2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CAJASBindingSource, "NumeroTicket_2", True))
        Me.txtNumeroTicket2.EnterMoveNextControl = True
        Me.txtNumeroTicket2.Location = New System.Drawing.Point(733, 12)
        Me.txtNumeroTicket2.Name = "txtNumeroTicket2"
        Me.txtNumeroTicket2.Properties.MaxLength = 6
        Me.txtNumeroTicket2.Properties.ReadOnly = True
        Me.txtNumeroTicket2.Size = New System.Drawing.Size(47, 20)
        Me.txtNumeroTicket2.TabIndex = 5
        Me.txtNumeroTicket2.Visible = False
        '
        'txtNumeroTicket
        '
        Me.txtNumeroTicket.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CAJASBindingSource, "NumeroTicket", True))
        Me.txtNumeroTicket.EnterMoveNextControl = True
        Me.txtNumeroTicket.Location = New System.Drawing.Point(128, 33)
        Me.txtNumeroTicket.Name = "txtNumeroTicket"
        Me.txtNumeroTicket.Properties.MaxLength = 6
        Me.txtNumeroTicket.Properties.ReadOnly = True
        Me.txtNumeroTicket.Size = New System.Drawing.Size(47, 20)
        Me.txtNumeroTicket.TabIndex = 1
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 62)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "Tope Efectivo en Caja:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(641, 15)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Contador Ticket 2:"
        Me.LabelControl4.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 36)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Contador Tickets:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(16, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Código Caja:"
        '
        'bttEliminar
        '
        Me.bttEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttEliminar.Enabled = False
        Me.bttEliminar.Image = Global.AydaraTPV.My.Resources.Resources.delete2
        Me.bttEliminar.Location = New System.Drawing.Point(348, 509)
        Me.bttEliminar.Name = "bttEliminar"
        Me.bttEliminar.Size = New System.Drawing.Size(106, 45)
        Me.bttEliminar.TabIndex = 32
        Me.bttEliminar.TabStop = False
        Me.bttEliminar.Text = "Eliminar"
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Enabled = False
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.save
        Me.bttGuardar.Location = New System.Drawing.Point(674, 509)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(106, 45)
        Me.bttGuardar.TabIndex = 30
        Me.bttGuardar.TabStop = False
        Me.bttGuardar.Text = "Guardar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(562, 509)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 31
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'CAJASTableAdapter
        '
        Me.CAJASTableAdapter.ClearBeforeFill = True
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.search
        Me.bttBuscar.Location = New System.Drawing.Point(236, 509)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(106, 45)
        Me.bttBuscar.TabIndex = 53
        Me.bttBuscar.TabStop = False
        Me.bttBuscar.Text = "Buscar"
        '
        'bttModificar
        '
        Me.bttModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttModificar.Enabled = False
        Me.bttModificar.Image = Global.AydaraTPV.My.Resources.Resources.update
        Me.bttModificar.Location = New System.Drawing.Point(124, 509)
        Me.bttModificar.Name = "bttModificar"
        Me.bttModificar.Size = New System.Drawing.Size(106, 45)
        Me.bttModificar.TabIndex = 54
        Me.bttModificar.TabStop = False
        Me.bttModificar.Text = "Modificar"
        '
        'cmbImprimeTicket
        '
        Me.cmbImprimeTicket.EditValue = ""
        Me.cmbImprimeTicket.EnterMoveNextControl = True
        Me.cmbImprimeTicket.Location = New System.Drawing.Point(103, 30)
        Me.cmbImprimeTicket.Name = "cmbImprimeTicket"
        Me.cmbImprimeTicket.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbImprimeTicket.Properties.Items.AddRange(New Object() {"Sí", "No", "Conformidad"})
        Me.cmbImprimeTicket.Properties.ReadOnly = True
        Me.cmbImprimeTicket.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbImprimeTicket.Size = New System.Drawing.Size(111, 20)
        Me.cmbImprimeTicket.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txtNumeroTicket)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.txtTopeEfectivoCaja)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Location = New System.Drawing.Point(16, 47)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(222, 98)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "DATOS CAJA"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.LabelControl12)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.checkAperturaCajon)
        Me.GroupControl2.Controls.Add(Me.checkCorteTicket)
        Me.GroupControl2.Controls.Add(Me.cmbImprimeTicket)
        Me.GroupControl2.Controls.Add(Me.checkVisor)
        Me.GroupControl2.Controls.Add(Me.txtAbreCajon)
        Me.GroupControl2.Controls.Add(Me.txtCorteTicket)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.txtActivaVisor)
        Me.GroupControl2.Controls.Add(Me.Acti)
        Me.GroupControl2.Controls.Add(Me.txtDesactivaVisor)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.txtActivaExpandido)
        Me.GroupControl2.Controls.Add(Me.txtDesactivaExpandido)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Location = New System.Drawing.Point(16, 151)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(764, 237)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "PARÁMETROS"
        '
        'LabelControl12
        '
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.Location = New System.Drawing.Point(427, 58)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(332, 156)
        Me.LabelControl12.TabIndex = 59
        Me.LabelControl12.Text = "Los controles de impresión deberán ir separados por el signo +" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ejemplo: 127+105"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(176, 64)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl11.TabIndex = 58
        Me.LabelControl11.Text = "Abrir:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(172, 90)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl10.TabIndex = 57
        Me.LabelControl10.Text = "Corte:"
        '
        'txtCodigoCaja
        '
        Me.txtCodigoCaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CAJASBindingSource, "CodigoCaja", True))
        Me.txtCodigoCaja.EnterMoveNextControl = True
        Me.txtCodigoCaja.Location = New System.Drawing.Point(84, 12)
        Me.txtCodigoCaja.Name = "txtCodigoCaja"
        Me.txtCodigoCaja.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoCaja.Properties.Mask.EditMask = "00"
        Me.txtCodigoCaja.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCodigoCaja.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigoCaja.Size = New System.Drawing.Size(54, 20)
        Me.txtCodigoCaja.TabIndex = 1
        '
        'Cajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.txtCodigoCaja)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.bttBuscar)
        Me.Controls.Add(Me.bttModificar)
        Me.Controls.Add(Me.bttNuevo)
        Me.Controls.Add(Me.bttEliminar)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttGuardar)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtNumeroTicket2)
        Me.Controls.Add(Me.checkCajaCerrada)
        Me.KeyPreview = True
        Me.Name = "Cajas"
        Me.Text = "Cajas"
        CType(Me.CAJASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorteTicket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAbreCajon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesactivaExpandido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivaExpandido.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDesactivaVisor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivaVisor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkVisor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkCorteTicket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkAperturaCajon.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkCajaCerrada.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTopeEfectivoCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroTicket2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNumeroTicket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbImprimeTicket.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtCodigoCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents colActivaCorteTicket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsCajas As AydaraTPV.dsCajas
    Friend WithEvents CAJASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CAJASTableAdapter As AydaraTPV.dsCajasTableAdapters.CAJASTableAdapter
    Friend WithEvents bttNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNumeroTicket As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNumeroTicket2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTopeEfectivoCaja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents checkCajaCerrada As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtActivaVisor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents checkVisor As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkCorteTicket As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkAperturaCajon As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Acti As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCorteTicket As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtAbreCajon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDesactivaExpandido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtActivaExpandido As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDesactivaVisor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbImprimeTicket As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoCaja As DevExpress.XtraEditors.ButtonEdit
End Class
