<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fIngresosTienda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fIngresosTienda))
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
        Me.bttImportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgIngresos = New DevExpress.XtraGrid.GridControl()
        Me.IDAINGRESOSTIENDASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTickets = New a3ERP_AydaraTPV.dsTickets()
        Me.gvIngresos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCODALM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colALMACEN_DESCALM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEFECTIVO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROPIA_BASE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPROPIA_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIENDA_BASE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIENDA_TOTAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colINGRESO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUMAPUNTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bttApunte = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colNUMAPUNTE_CAJA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bttApunteCaja = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
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
        CType(Me.dgIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDAINGRESOSTIENDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttApunte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttApunteCaja, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gcOpciones.Controls.Add(Me.bttImportar)
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
        'bttImportar
        '
        Me.bttImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttImportar.Image = CType(resources.GetObject("bttImportar.Image"), System.Drawing.Image)
        Me.bttImportar.Location = New System.Drawing.Point(135, 38)
        Me.bttImportar.Name = "bttImportar"
        Me.bttImportar.Size = New System.Drawing.Size(117, 28)
        Me.bttImportar.TabIndex = 93
        Me.bttImportar.Text = "Importar datos"
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
        'dgIngresos
        '
        Me.dgIngresos.DataSource = Me.IDAINGRESOSTIENDASBindingSource
        Me.dgIngresos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgIngresos.Location = New System.Drawing.Point(0, 126)
        Me.dgIngresos.MainView = Me.gvIngresos
        Me.dgIngresos.Name = "dgIngresos"
        Me.dgIngresos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskImporte, Me.bttApunte, Me.bttApunteCaja})
        Me.dgIngresos.Size = New System.Drawing.Size(784, 358)
        Me.dgIngresos.TabIndex = 4
        Me.dgIngresos.UseEmbeddedNavigator = True
        Me.dgIngresos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvIngresos})
        '
        'IDAINGRESOSTIENDASBindingSource
        '
        Me.IDAINGRESOSTIENDASBindingSource.DataMember = "IDA_INGRESOSTIENDAS"
        Me.IDAINGRESOSTIENDASBindingSource.DataSource = Me.DsTickets
        Me.IDAINGRESOSTIENDASBindingSource.Sort = "CODALM, FECHA"
        '
        'DsTickets
        '
        Me.DsTickets.DataSetName = "dsTickets"
        Me.DsTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvIngresos
        '
        Me.gvIngresos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODALM, Me.colALMACEN_DESCALM, Me.colFECHA, Me.colEFECTIVO, Me.colPROPIA_BASE, Me.colPROPIA_TOTAL, Me.colTIENDA_BASE, Me.colTIENDA_TOTAL, Me.colINGRESO, Me.colNUMAPUNTE, Me.colNUMAPUNTE_CAJA})
        Me.gvIngresos.GridControl = Me.dgIngresos
        Me.gvIngresos.Name = "gvIngresos"
        Me.gvIngresos.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvIngresos.OptionsView.ShowFooter = True
        Me.gvIngresos.OptionsView.ShowGroupPanel = False
        '
        'colCODALM
        '
        Me.colCODALM.Caption = "Tienda"
        Me.colCODALM.FieldName = "CODALM"
        Me.colCODALM.Name = "colCODALM"
        Me.colCODALM.Visible = True
        Me.colCODALM.VisibleIndex = 0
        Me.colCODALM.Width = 43
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
        Me.colALMACEN_DESCALM.Width = 140
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
        Me.colFECHA.Width = 62
        '
        'colEFECTIVO
        '
        Me.colEFECTIVO.AppearanceHeader.Options.UseTextOptions = True
        Me.colEFECTIVO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colEFECTIVO.Caption = "Efectivo"
        Me.colEFECTIVO.DisplayFormat.FormatString = "{0:c2}"
        Me.colEFECTIVO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEFECTIVO.FieldName = "EFECTIVO"
        Me.colEFECTIVO.Name = "colEFECTIVO"
        Me.colEFECTIVO.OptionsColumn.AllowEdit = False
        Me.colEFECTIVO.OptionsColumn.AllowFocus = False
        Me.colEFECTIVO.OptionsColumn.ReadOnly = True
        Me.colEFECTIVO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "EFECTIVO", "{0:c2}")})
        '
        'colPROPIA_BASE
        '
        Me.colPROPIA_BASE.AppearanceHeader.Options.UseTextOptions = True
        Me.colPROPIA_BASE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPROPIA_BASE.Caption = "B.Imp.Propia"
        Me.colPROPIA_BASE.ColumnEdit = Me.maskImporte
        Me.colPROPIA_BASE.FieldName = "PROPIA_BASE"
        Me.colPROPIA_BASE.Name = "colPROPIA_BASE"
        Me.colPROPIA_BASE.OptionsColumn.AllowEdit = False
        Me.colPROPIA_BASE.OptionsColumn.AllowFocus = False
        Me.colPROPIA_BASE.OptionsColumn.ReadOnly = True
        Me.colPROPIA_BASE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PROPIA_BASE", "{0:c2}")})
        Me.colPROPIA_BASE.Width = 70
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.EditMask = "c2"
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'colPROPIA_TOTAL
        '
        Me.colPROPIA_TOTAL.AppearanceHeader.Options.UseTextOptions = True
        Me.colPROPIA_TOTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPROPIA_TOTAL.Caption = "Venta propia"
        Me.colPROPIA_TOTAL.ColumnEdit = Me.maskImporte
        Me.colPROPIA_TOTAL.FieldName = "PROPIA_TOTAL"
        Me.colPROPIA_TOTAL.Name = "colPROPIA_TOTAL"
        Me.colPROPIA_TOTAL.OptionsColumn.AllowEdit = False
        Me.colPROPIA_TOTAL.OptionsColumn.AllowFocus = False
        Me.colPROPIA_TOTAL.OptionsColumn.ReadOnly = True
        Me.colPROPIA_TOTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PROPIA_TOTAL", "{0:c2}")})
        Me.colPROPIA_TOTAL.Width = 69
        '
        'colTIENDA_BASE
        '
        Me.colTIENDA_BASE.AppearanceHeader.Options.UseTextOptions = True
        Me.colTIENDA_BASE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTIENDA_BASE.Caption = "B.Imp.Tienda"
        Me.colTIENDA_BASE.ColumnEdit = Me.maskImporte
        Me.colTIENDA_BASE.FieldName = "TIENDA_BASE"
        Me.colTIENDA_BASE.Name = "colTIENDA_BASE"
        Me.colTIENDA_BASE.OptionsColumn.AllowEdit = False
        Me.colTIENDA_BASE.OptionsColumn.AllowFocus = False
        Me.colTIENDA_BASE.OptionsColumn.ReadOnly = True
        Me.colTIENDA_BASE.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TIENDA_BASE", "{0:c2}")})
        Me.colTIENDA_BASE.Width = 72
        '
        'colTIENDA_TOTAL
        '
        Me.colTIENDA_TOTAL.AppearanceHeader.Options.UseTextOptions = True
        Me.colTIENDA_TOTAL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTIENDA_TOTAL.Caption = "Venta tienda"
        Me.colTIENDA_TOTAL.ColumnEdit = Me.maskImporte
        Me.colTIENDA_TOTAL.FieldName = "TIENDA_TOTAL"
        Me.colTIENDA_TOTAL.Name = "colTIENDA_TOTAL"
        Me.colTIENDA_TOTAL.OptionsColumn.AllowEdit = False
        Me.colTIENDA_TOTAL.OptionsColumn.AllowFocus = False
        Me.colTIENDA_TOTAL.OptionsColumn.ReadOnly = True
        Me.colTIENDA_TOTAL.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TIENDA_TOTAL", "{0:c2}")})
        Me.colTIENDA_TOTAL.Width = 69
        '
        'colINGRESO
        '
        Me.colINGRESO.AppearanceHeader.Options.UseTextOptions = True
        Me.colINGRESO.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colINGRESO.Caption = "Ingreso"
        Me.colINGRESO.ColumnEdit = Me.maskImporte
        Me.colINGRESO.FieldName = "IMPORTE"
        Me.colINGRESO.Name = "colINGRESO"
        Me.colINGRESO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "IMPORTE", "{0:c2}")})
        Me.colINGRESO.Visible = True
        Me.colINGRESO.VisibleIndex = 3
        Me.colINGRESO.Width = 62
        '
        'colNUMAPUNTE
        '
        Me.colNUMAPUNTE.AppearanceHeader.Options.UseTextOptions = True
        Me.colNUMAPUNTE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colNUMAPUNTE.Caption = "Apunte Ingreso"
        Me.colNUMAPUNTE.ColumnEdit = Me.bttApunte
        Me.colNUMAPUNTE.FieldName = "NUMAPUNTE"
        Me.colNUMAPUNTE.Name = "colNUMAPUNTE"
        Me.colNUMAPUNTE.OptionsColumn.ReadOnly = True
        Me.colNUMAPUNTE.Visible = True
        Me.colNUMAPUNTE.VisibleIndex = 4
        '
        'bttApunte
        '
        Me.bttApunte.AutoHeight = False
        Me.bttApunte.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.bttApunte.Mask.EditMask = "n0"
        Me.bttApunte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.bttApunte.Mask.UseMaskAsDisplayFormat = True
        Me.bttApunte.Name = "bttApunte"
        Me.bttApunte.ReadOnly = True
        Me.bttApunte.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colNUMAPUNTE_CAJA
        '
        Me.colNUMAPUNTE_CAJA.AppearanceHeader.Options.UseTextOptions = True
        Me.colNUMAPUNTE_CAJA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colNUMAPUNTE_CAJA.Caption = "Apunte Caja"
        Me.colNUMAPUNTE_CAJA.ColumnEdit = Me.bttApunteCaja
        Me.colNUMAPUNTE_CAJA.FieldName = "NUMAPUNTE_CAJA"
        Me.colNUMAPUNTE_CAJA.Name = "colNUMAPUNTE_CAJA"
        Me.colNUMAPUNTE_CAJA.OptionsColumn.ReadOnly = True
        '
        'bttApunteCaja
        '
        Me.bttApunteCaja.AutoHeight = False
        Me.bttApunteCaja.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.bttApunteCaja.Mask.EditMask = "n0"
        Me.bttApunteCaja.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.bttApunteCaja.Mask.UseMaskAsDisplayFormat = True
        Me.bttApunteCaja.Name = "bttApunteCaja"
        '
        'fIngresosTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgIngresos)
        Me.Controls.Add(Me.gcOpciones)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "fIngresosTienda"
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
        CType(Me.dgIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDAINGRESOSTIENDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttApunte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttApunteCaja, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents dgIngresos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvIngresos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsTickets As a3ERP_AydaraTPV.dsTickets
    Friend WithEvents colCODALM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents IDAINGRESOSTIENDASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents bttApunte As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colNUMAPUNTE_CAJA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bttApunteCaja As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colEFECTIVO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bttImportar As DevExpress.XtraEditors.SimpleButton
End Class
