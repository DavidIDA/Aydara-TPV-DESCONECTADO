<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fTotalesCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fTotalesCaja))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTipoTienda = New DevExpress.XtraEditors.LookUpEdit()
        Me.IDATIPOSTIENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTiendas = New a3ERP_AydaraTPV.dsTiendas()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.txtFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEjercicio = New DevExpress.XtraEditors.SpinEdit()
        Me.txtMes = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.rgFecha = New DevExpress.XtraEditors.RadioGroup()
        Me.txtCODALM = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtDESCALM = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.gcOpciones = New DevExpress.XtraEditors.GroupControl()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgCajas = New DevExpress.XtraGrid.GridControl()
        Me.IDACAJASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTickets = New a3ERP_AydaraTPV.dsTickets()
        Me.gvCajas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCODALM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colALMACEN_DESCALM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCAJA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colALBARANES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colALBARANCREDITO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colCOBROSCLIENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEFECTIVO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colENTRADACAMBIOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colENVASES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLINEAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPAGOSPROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPENDIENTECOBRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colREPARTODOMICILIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRETIRADAFONDOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTALON = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTARJETA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTICKETS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALESCOBRADOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALESEMITIDOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVALESPROVEEDOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROPIA_BASE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROPIA_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIENDA_BASE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIENDA_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVENTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUMAPUNTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colINGRESO = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTipoTienda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDATIPOSTIENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTiendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEjercicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCODALM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDESCALM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcOpciones.SuspendLayout()
        CType(Me.dgCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDACAJASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCajas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtTipoTienda)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Controls.Add(Me.txtCODALM)
        Me.PanelControl1.Controls.Add(Me.txtDESCALM)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.bttBuscar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(784, 126)
        Me.PanelControl1.TabIndex = 1
        '
        'txtTipoTienda
        '
        Me.txtTipoTienda.Location = New System.Drawing.Point(551, 12)
        Me.txtTipoTienda.Name = "txtTipoTienda"
        Me.txtTipoTienda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close)})
        Me.txtTipoTienda.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO", 50, "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", 150, "Descripción")})
        Me.txtTipoTienda.Properties.DataSource = Me.IDATIPOSTIENDABindingSource
        Me.txtTipoTienda.Properties.DisplayMember = "DESCRIPCION"
        Me.txtTipoTienda.Properties.NullText = "Todas"
        Me.txtTipoTienda.Properties.ValueMember = "CODIGO"
        Me.txtTipoTienda.Size = New System.Drawing.Size(111, 20)
        Me.txtTipoTienda.TabIndex = 83
        '
        'IDATIPOSTIENDABindingSource
        '
        Me.IDATIPOSTIENDABindingSource.DataMember = "IDA_TIPOSTIENDA"
        Me.IDATIPOSTIENDABindingSource.DataSource = Me.DsTiendas
        '
        'DsTiendas
        '
        Me.DsTiendas.DataSetName = "dsTiendas"
        Me.DsTiendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(488, 15)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl8.TabIndex = 81
        Me.LabelControl8.Text = "Tipo tienda:"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtFechaFin)
        Me.GroupControl2.Controls.Add(Me.txtFechaInicio)
        Me.GroupControl2.Controls.Add(Me.LabelControl7)
        Me.GroupControl2.Controls.Add(Me.LabelControl6)
        Me.GroupControl2.Controls.Add(Me.txtEjercicio)
        Me.GroupControl2.Controls.Add(Me.txtMes)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.rgFecha)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 38)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(650, 73)
        Me.GroupControl2.TabIndex = 61
        Me.GroupControl2.TabStop = True
        Me.GroupControl2.Text = "Selección de fecha"
        '
        'txtFechaFin
        '
        Me.txtFechaFin.EditValue = Nothing
        Me.txtFechaFin.Location = New System.Drawing.Point(539, 47)
        Me.txtFechaFin.Name = "txtFechaFin"
        Me.txtFechaFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaFin.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaFin.TabIndex = 67
        '
        'txtFechaInicio
        '
        Me.txtFechaInicio.EditValue = Nothing
        Me.txtFechaInicio.Location = New System.Drawing.Point(539, 24)
        Me.txtFechaInicio.Name = "txtFechaInicio"
        Me.txtFechaInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaInicio.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaInicio.TabIndex = 66
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(485, 50)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl7.TabIndex = 65
        Me.LabelControl7.Text = "Fecha fin:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(474, 27)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl6.TabIndex = 64
        Me.LabelControl6.Text = "Fecha inicio:"
        '
        'txtEjercicio
        '
        Me.txtEjercicio.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtEjercicio.Location = New System.Drawing.Point(415, 47)
        Me.txtEjercicio.Name = "txtEjercicio"
        Me.txtEjercicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEjercicio.Properties.Mask.EditMask = "n0"
        Me.txtEjercicio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtEjercicio.Properties.ReadOnly = True
        Me.txtEjercicio.Size = New System.Drawing.Size(53, 20)
        Me.txtEjercicio.TabIndex = 63
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(368, 24)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMes.Properties.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.txtMes.Properties.ReadOnly = True
        Me.txtMes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 62
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(386, 50)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl1.TabIndex = 57
        Me.LabelControl1.Text = "Año:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(339, 27)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl2.TabIndex = 56
        Me.LabelControl2.Text = "Mes:"
        '
        'rgFecha
        '
        Me.rgFecha.Dock = System.Windows.Forms.DockStyle.Left
        Me.rgFecha.Location = New System.Drawing.Point(2, 21)
        Me.rgFecha.Name = "rgFecha"
        Me.rgFecha.Properties.Appearance.Options.UseTextOptions = True
        Me.rgFecha.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.rgFecha.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Hoy"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Última semana"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Mes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Último mes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(5, "Año"), New DevExpress.XtraEditors.Controls.RadioGroupItem(6, "Todo")})
        Me.rgFecha.Size = New System.Drawing.Size(322, 50)
        Me.rgFecha.TabIndex = 0
        '
        'txtCODALM
        '
        Me.txtCODALM.EditValue = ""
        Me.txtCODALM.EnterMoveNextControl = True
        Me.txtCODALM.Location = New System.Drawing.Point(79, 12)
        Me.txtCODALM.Name = "txtCODALM"
        Me.txtCODALM.Properties.AutoHeight = False
        Me.txtCODALM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtCODALM.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtCODALM.Size = New System.Drawing.Size(100, 20)
        Me.txtCODALM.TabIndex = 0
        '
        'txtDESCALM
        '
        Me.txtDESCALM.Location = New System.Drawing.Point(178, 12)
        Me.txtDESCALM.Name = "txtDESCALM"
        Me.txtDESCALM.Properties.ReadOnly = True
        Me.txtDESCALM.Size = New System.Drawing.Size(304, 20)
        Me.txtDESCALM.TabIndex = 1
        Me.txtDESCALM.TabStop = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Tienda:"
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = CType(resources.GetObject("bttBuscar.Image"), System.Drawing.Image)
        Me.bttBuscar.Location = New System.Drawing.Point(682, 83)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(90, 28)
        Me.bttBuscar.TabIndex = 4
        Me.bttBuscar.Text = "(F5) Buscar"
        '
        'gcOpciones
        '
        Me.gcOpciones.Controls.Add(Me.bttImprimir)
        Me.gcOpciones.Controls.Add(Me.bttGuardar)
        Me.gcOpciones.Controls.Add(Me.bttCancelar)
        Me.gcOpciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gcOpciones.Location = New System.Drawing.Point(0, 484)
        Me.gcOpciones.Name = "gcOpciones"
        Me.gcOpciones.Size = New System.Drawing.Size(784, 78)
        Me.gcOpciones.TabIndex = 3
        Me.gcOpciones.Text = "Opciones"
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Image = CType(resources.GetObject("bttImprimir.Image"), System.Drawing.Image)
        Me.bttImprimir.Location = New System.Drawing.Point(12, 38)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(117, 28)
        Me.bttImprimir.TabIndex = 2
        Me.bttImprimir.Text = "Imprimir listado"
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttGuardar.Enabled = False
        Me.bttGuardar.Image = CType(resources.GetObject("bttGuardar.Image"), System.Drawing.Image)
        Me.bttGuardar.Location = New System.Drawing.Point(676, 38)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(96, 28)
        Me.bttGuardar.TabIndex = 0
        Me.bttGuardar.Text = "(F3) &Guardar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttCancelar.Enabled = False
        Me.bttCancelar.Image = CType(resources.GetObject("bttCancelar.Image"), System.Drawing.Image)
        Me.bttCancelar.Location = New System.Drawing.Point(544, 38)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(126, 28)
        Me.bttCancelar.TabIndex = 1
        Me.bttCancelar.Text = "(ALT+F3) &Cancelar"
        '
        'dgCajas
        '
        Me.dgCajas.DataSource = Me.IDACAJASBindingSource
        Me.dgCajas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCajas.Location = New System.Drawing.Point(0, 126)
        Me.dgCajas.MainView = Me.gvCajas
        Me.dgCajas.Name = "dgCajas"
        Me.dgCajas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskImporte})
        Me.dgCajas.Size = New System.Drawing.Size(784, 358)
        Me.dgCajas.TabIndex = 4
        Me.dgCajas.UseEmbeddedNavigator = True
        Me.dgCajas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCajas})
        '
        'IDACAJASBindingSource
        '
        Me.IDACAJASBindingSource.DataMember = "IDA_CAJAS"
        Me.IDACAJASBindingSource.DataSource = Me.DsTickets
        Me.IDACAJASBindingSource.Sort = "CODALM, FECHA, CAJA"
        '
        'DsTickets
        '
        Me.DsTickets.DataSetName = "dsTickets"
        Me.DsTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvCajas
        '
        Me.gvCajas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODALM, Me.colALMACEN_DESCALM, Me.colCAJA, Me.colFECHA, Me.colALBARANES, Me.colALBARANCREDITO, Me.colCOBROSCLIENTE, Me.colEFECTIVO, Me.colENTRADACAMBIOS, Me.colENVASES, Me.colLINEAS, Me.colPAGOSPROVEEDOR, Me.colPENDIENTECOBRO, Me.colREPARTODOMICILIO, Me.colRETIRADAFONDOS, Me.colTALON, Me.colTARJETA, Me.colTICKETS, Me.colVALESCOBRADOS, Me.colVALESEMITIDOS, Me.colVALESPROVEEDOR, Me.colPROPIA_BASE, Me.colPROPIA_TOTAL, Me.colTIENDA_BASE, Me.colTIENDA_TOTAL, Me.colVENTA, Me.colNUMAPUNTE, Me.colINGRESO})
        Me.gvCajas.GridControl = Me.dgCajas
        Me.gvCajas.Name = "gvCajas"
        Me.gvCajas.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvCajas.OptionsView.ShowFooter = True
        Me.gvCajas.OptionsView.ShowGroupPanel = False
        '
        'colCODALM
        '
        Me.colCODALM.Caption = "Tienda"
        Me.colCODALM.FieldName = "CODALM"
        Me.colCODALM.Name = "colCODALM"
        Me.colCODALM.Visible = True
        Me.colCODALM.VisibleIndex = 0
        Me.colCODALM.Width = 80
        '
        'colALMACEN_DESCALM
        '
        Me.colALMACEN_DESCALM.Caption = "Nombre tienda"
        Me.colALMACEN_DESCALM.FieldName = "ALMACEN_DESCALM"
        Me.colALMACEN_DESCALM.Name = "colALMACEN_DESCALM"
        Me.colALMACEN_DESCALM.OptionsColumn.AllowEdit = False
        Me.colALMACEN_DESCALM.OptionsColumn.AllowFocus = False
        Me.colALMACEN_DESCALM.Visible = True
        Me.colALMACEN_DESCALM.VisibleIndex = 1
        Me.colALMACEN_DESCALM.Width = 436
        '
        'colCAJA
        '
        Me.colCAJA.AppearanceHeader.Options.UseTextOptions = True
        Me.colCAJA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCAJA.Caption = "Caja"
        Me.colCAJA.FieldName = "CAJA"
        Me.colCAJA.Name = "colCAJA"
        Me.colCAJA.Width = 61
        '
        'colFECHA
        '
        Me.colFECHA.AppearanceCell.Options.UseTextOptions = True
        Me.colFECHA.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFECHA.AppearanceHeader.Options.UseTextOptions = True
        Me.colFECHA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFECHA.Caption = "Fecha"
        Me.colFECHA.FieldName = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 2
        Me.colFECHA.Width = 90
        '
        'colALBARANES
        '
        Me.colALBARANES.AppearanceHeader.Options.UseTextOptions = True
        Me.colALBARANES.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colALBARANES.Caption = "NºAlbaranes"
        Me.colALBARANES.FieldName = "ALBARANES"
        Me.colALBARANES.Name = "colALBARANES"
        Me.colALBARANES.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        '
        'colALBARANCREDITO
        '
        Me.colALBARANCREDITO.AppearanceHeader.Options.UseTextOptions = True
        Me.colALBARANCREDITO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colALBARANCREDITO.Caption = "Alb.Crédito"
        Me.colALBARANCREDITO.ColumnEdit = Me.maskImporte
        Me.colALBARANCREDITO.FieldName = "ALBARANCREDITO"
        Me.colALBARANCREDITO.Name = "colALBARANCREDITO"
        Me.colALBARANCREDITO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ALBARANCREDITO", "{0:c2}")})
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.EditMask = "c2"
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'colCOBROSCLIENTE
        '
        Me.colCOBROSCLIENTE.AppearanceHeader.Options.UseTextOptions = True
        Me.colCOBROSCLIENTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colCOBROSCLIENTE.Caption = "Cobros cliente"
        Me.colCOBROSCLIENTE.ColumnEdit = Me.maskImporte
        Me.colCOBROSCLIENTE.FieldName = "COBROSCLIENTE"
        Me.colCOBROSCLIENTE.Name = "colCOBROSCLIENTE"
        Me.colCOBROSCLIENTE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "COBROSCLIENTE", "{0:c2}")})
        '
        'colEFECTIVO
        '
        Me.colEFECTIVO.AppearanceHeader.Options.UseTextOptions = True
        Me.colEFECTIVO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colEFECTIVO.Caption = "Efectivo"
        Me.colEFECTIVO.ColumnEdit = Me.maskImporte
        Me.colEFECTIVO.FieldName = "EFECTIVO"
        Me.colEFECTIVO.Name = "colEFECTIVO"
        Me.colEFECTIVO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EFECTIVO", "{0:c2}")})
        '
        'colENTRADACAMBIOS
        '
        Me.colENTRADACAMBIOS.AppearanceHeader.Options.UseTextOptions = True
        Me.colENTRADACAMBIOS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colENTRADACAMBIOS.Caption = "Entrada cambios"
        Me.colENTRADACAMBIOS.ColumnEdit = Me.maskImporte
        Me.colENTRADACAMBIOS.FieldName = "ENTRADACAMBIOS"
        Me.colENTRADACAMBIOS.Name = "colENTRADACAMBIOS"
        Me.colENTRADACAMBIOS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ENTRADACAMBIOS", "{0:c2}")})
        '
        'colENVASES
        '
        Me.colENVASES.AppearanceHeader.Options.UseTextOptions = True
        Me.colENVASES.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colENVASES.Caption = "Envases"
        Me.colENVASES.ColumnEdit = Me.maskImporte
        Me.colENVASES.FieldName = "ENVASES"
        Me.colENVASES.Name = "colENVASES"
        Me.colENVASES.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ENVASES", "{0:c2}")})
        '
        'colLINEAS
        '
        Me.colLINEAS.AppearanceHeader.Options.UseTextOptions = True
        Me.colLINEAS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colLINEAS.Caption = "Líneas tickets"
        Me.colLINEAS.FieldName = "LINEAS"
        Me.colLINEAS.Name = "colLINEAS"
        Me.colLINEAS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        '
        'colPAGOSPROVEEDOR
        '
        Me.colPAGOSPROVEEDOR.AppearanceHeader.Options.UseTextOptions = True
        Me.colPAGOSPROVEEDOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPAGOSPROVEEDOR.Caption = "Pagos proveedor"
        Me.colPAGOSPROVEEDOR.ColumnEdit = Me.maskImporte
        Me.colPAGOSPROVEEDOR.FieldName = "PAGOSPROVEEDOR"
        Me.colPAGOSPROVEEDOR.Name = "colPAGOSPROVEEDOR"
        Me.colPAGOSPROVEEDOR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PAGOSPROVEEDOR", "{0:c2}")})
        '
        'colPENDIENTECOBRO
        '
        Me.colPENDIENTECOBRO.AppearanceHeader.Options.UseTextOptions = True
        Me.colPENDIENTECOBRO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPENDIENTECOBRO.Caption = "Pte.Cobro"
        Me.colPENDIENTECOBRO.ColumnEdit = Me.maskImporte
        Me.colPENDIENTECOBRO.FieldName = "PENDIENTECOBRO"
        Me.colPENDIENTECOBRO.Name = "colPENDIENTECOBRO"
        Me.colPENDIENTECOBRO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PENDIENTECOBRO", "{0:c2}")})
        '
        'colREPARTODOMICILIO
        '
        Me.colREPARTODOMICILIO.AppearanceHeader.Options.UseTextOptions = True
        Me.colREPARTODOMICILIO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colREPARTODOMICILIO.Caption = "Reparto domicilio"
        Me.colREPARTODOMICILIO.FieldName = "REPARTODOMICILIO"
        Me.colREPARTODOMICILIO.Name = "colREPARTODOMICILIO"
        Me.colREPARTODOMICILIO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        '
        'colRETIRADAFONDOS
        '
        Me.colRETIRADAFONDOS.AppearanceHeader.Options.UseTextOptions = True
        Me.colRETIRADAFONDOS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colRETIRADAFONDOS.Caption = "Retirada fondos"
        Me.colRETIRADAFONDOS.ColumnEdit = Me.maskImporte
        Me.colRETIRADAFONDOS.FieldName = "RETIRADAFONDOS"
        Me.colRETIRADAFONDOS.Name = "colRETIRADAFONDOS"
        Me.colRETIRADAFONDOS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "RETIRADAFONDOS", "{0:c2}")})
        '
        'colTALON
        '
        Me.colTALON.AppearanceHeader.Options.UseTextOptions = True
        Me.colTALON.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTALON.Caption = "Talón"
        Me.colTALON.ColumnEdit = Me.maskImporte
        Me.colTALON.FieldName = "TALON"
        Me.colTALON.Name = "colTALON"
        Me.colTALON.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TALON", "{0:c2}")})
        '
        'colTARJETA
        '
        Me.colTARJETA.AppearanceHeader.Options.UseTextOptions = True
        Me.colTARJETA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTARJETA.Caption = "Tarjeta"
        Me.colTARJETA.ColumnEdit = Me.maskImporte
        Me.colTARJETA.FieldName = "TARJETA"
        Me.colTARJETA.Name = "colTARJETA"
        Me.colTARJETA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TARJETA", "{0:c2}")})
        '
        'colTICKETS
        '
        Me.colTICKETS.AppearanceHeader.Options.UseTextOptions = True
        Me.colTICKETS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTICKETS.Caption = "Nº Tickets"
        Me.colTICKETS.FieldName = "TICKETS"
        Me.colTICKETS.Name = "colTICKETS"
        Me.colTICKETS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        '
        'colVALESCOBRADOS
        '
        Me.colVALESCOBRADOS.AppearanceHeader.Options.UseTextOptions = True
        Me.colVALESCOBRADOS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVALESCOBRADOS.Caption = "Vales cobrados"
        Me.colVALESCOBRADOS.ColumnEdit = Me.maskImporte
        Me.colVALESCOBRADOS.FieldName = "VALESCOBRADOS"
        Me.colVALESCOBRADOS.Name = "colVALESCOBRADOS"
        Me.colVALESCOBRADOS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALESCOBRADOS", "{0:c2}")})
        '
        'colVALESEMITIDOS
        '
        Me.colVALESEMITIDOS.AppearanceHeader.Options.UseTextOptions = True
        Me.colVALESEMITIDOS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVALESEMITIDOS.Caption = "Vales emitidos"
        Me.colVALESEMITIDOS.ColumnEdit = Me.maskImporte
        Me.colVALESEMITIDOS.FieldName = "VALESEMITIDOS"
        Me.colVALESEMITIDOS.Name = "colVALESEMITIDOS"
        Me.colVALESEMITIDOS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALESEMITIDOS", "{0:c2}")})
        '
        'colVALESPROVEEDOR
        '
        Me.colVALESPROVEEDOR.AppearanceHeader.Options.UseTextOptions = True
        Me.colVALESPROVEEDOR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVALESPROVEEDOR.Caption = "Vales proveedor"
        Me.colVALESPROVEEDOR.ColumnEdit = Me.maskImporte
        Me.colVALESPROVEEDOR.FieldName = "VALESPROVEEDOR"
        Me.colVALESPROVEEDOR.Name = "colVALESPROVEEDOR"
        Me.colVALESPROVEEDOR.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VALESPROVEEDOR", "{0:c2}")})
        '
        'colPROPIA_BASE
        '
        Me.colPROPIA_BASE.AppearanceHeader.Options.UseTextOptions = True
        Me.colPROPIA_BASE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPROPIA_BASE.Caption = "B.Imp.Propia"
        Me.colPROPIA_BASE.ColumnEdit = Me.maskImporte
        Me.colPROPIA_BASE.FieldName = "PROPIA_BASE"
        Me.colPROPIA_BASE.Name = "colPROPIA_BASE"
        Me.colPROPIA_BASE.OptionsColumn.ReadOnly = True
        Me.colPROPIA_BASE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PROPIA_BASE", "{0:c2}")})
        '
        'colPROPIA_TOTAL
        '
        Me.colPROPIA_TOTAL.AppearanceHeader.Options.UseTextOptions = True
        Me.colPROPIA_TOTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPROPIA_TOTAL.Caption = "Venta propia"
        Me.colPROPIA_TOTAL.ColumnEdit = Me.maskImporte
        Me.colPROPIA_TOTAL.FieldName = "PROPIA_TOTAL"
        Me.colPROPIA_TOTAL.Name = "colPROPIA_TOTAL"
        Me.colPROPIA_TOTAL.OptionsColumn.ReadOnly = True
        Me.colPROPIA_TOTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PROPIA_TOTAL", "{0:c2}")})
        '
        'colTIENDA_BASE
        '
        Me.colTIENDA_BASE.AppearanceHeader.Options.UseTextOptions = True
        Me.colTIENDA_BASE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTIENDA_BASE.Caption = "B.Imp.Tienda"
        Me.colTIENDA_BASE.ColumnEdit = Me.maskImporte
        Me.colTIENDA_BASE.FieldName = "TIENDA_BASE"
        Me.colTIENDA_BASE.Name = "colTIENDA_BASE"
        Me.colTIENDA_BASE.OptionsColumn.ReadOnly = True
        Me.colTIENDA_BASE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TIENDA_BASE", "{0:c2}")})
        '
        'colTIENDA_TOTAL
        '
        Me.colTIENDA_TOTAL.AppearanceHeader.Options.UseTextOptions = True
        Me.colTIENDA_TOTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTIENDA_TOTAL.Caption = "Venta tienda"
        Me.colTIENDA_TOTAL.ColumnEdit = Me.maskImporte
        Me.colTIENDA_TOTAL.FieldName = "TIENDA_TOTAL"
        Me.colTIENDA_TOTAL.Name = "colTIENDA_TOTAL"
        Me.colTIENDA_TOTAL.OptionsColumn.ReadOnly = True
        Me.colTIENDA_TOTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TIENDA_TOTAL", "{0:c2}")})
        Me.colTIENDA_TOTAL.Visible = True
        Me.colTIENDA_TOTAL.VisibleIndex = 4
        Me.colTIENDA_TOTAL.Width = 90
        '
        'colVENTA
        '
        Me.colVENTA.AppearanceHeader.Options.UseTextOptions = True
        Me.colVENTA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVENTA.Caption = "Venta caja"
        Me.colVENTA.ColumnEdit = Me.maskImporte
        Me.colVENTA.FieldName = "VENTA"
        Me.colVENTA.Name = "colVENTA"
        Me.colVENTA.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "VENTA", "{0:c2}")})
        Me.colVENTA.Width = 99
        '
        'colNUMAPUNTE
        '
        Me.colNUMAPUNTE.AppearanceHeader.Options.UseTextOptions = True
        Me.colNUMAPUNTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colNUMAPUNTE.Caption = "Nº Apunte"
        Me.colNUMAPUNTE.FieldName = "NUMAPUNTE"
        Me.colNUMAPUNTE.Name = "colNUMAPUNTE"
        '
        'colINGRESO
        '
        Me.colINGRESO.AppearanceHeader.Options.UseTextOptions = True
        Me.colINGRESO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colINGRESO.Caption = "Ingreso"
        Me.colINGRESO.ColumnEdit = Me.maskImporte
        Me.colINGRESO.FieldName = "INGRESO"
        Me.colINGRESO.Name = "colINGRESO"
        Me.colINGRESO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "INGRESO", "{0:c2}")})
        Me.colINGRESO.Visible = True
        Me.colINGRESO.VisibleIndex = 3
        Me.colINGRESO.Width = 90
        '
        'fTotalesCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgCajas)
        Me.Controls.Add(Me.gcOpciones)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "fTotalesCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Ingresos tiendas"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTipoTienda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDATIPOSTIENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTiendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEjercicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCODALM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDESCALM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcOpciones.ResumeLayout(False)
        CType(Me.dgCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDACAJASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCajas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEjercicio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtMes As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgFecha As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtCODALM As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtDESCALM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents gcOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgCajas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCajas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsTickets As a3ERP_AydaraTPV.dsTickets
    Friend WithEvents IDACAJASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colALBARANCREDITO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALBARANES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCAJA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOBROSCLIENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODALM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEFECTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colENTRADACAMBIOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colENVASES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLINEAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAGOSPROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPENDIENTECOBRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREPARTODOMICILIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRETIRADAFONDOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTALON As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTARJETA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTICKETS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALESCOBRADOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALESEMITIDOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVALESPROVEEDOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVENTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUMAPUNTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colINGRESO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALMACEN_DESCALM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTipoTienda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DsTiendas As a3ERP_AydaraTPV.dsTiendas
    Friend WithEvents IDATIPOSTIENDABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colPROPIA_BASE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROPIA_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIENDA_BASE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIENDA_TOTAL As DevExpress.XtraGrid.Columns.GridColumn
End Class
