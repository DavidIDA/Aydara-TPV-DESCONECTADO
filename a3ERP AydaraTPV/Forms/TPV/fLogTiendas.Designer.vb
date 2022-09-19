<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fLogTiendas
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
        Dim StyleFormatCondition5 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition6 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition7 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition8 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fLogTiendas))
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgLog = New DevExpress.XtraGrid.GridControl()
        Me.IDALOGTIENDASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTPVLog = New a3ERP_AydaraTPV.dsTPVLog()
        Me.gvLog = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCODALM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.txtEstado = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txtTipoTienda = New DevExpress.XtraEditors.LookUpEdit()
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
        Me.DsTiendas = New a3ERP_AydaraTPV.dsTiendas()
        Me.IDATIPOSTIENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDALOGTIENDASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTPVLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtTipoTienda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.DsTiendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDATIPOSTIENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colESTADO
        '
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.OptionsColumn.AllowFocus = False
        '
        'dgLog
        '
        Me.dgLog.DataSource = Me.IDALOGTIENDASBindingSource
        Me.dgLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLog.Location = New System.Drawing.Point(0, 126)
        Me.dgLog.MainView = Me.gvLog
        Me.dgLog.Name = "dgLog"
        Me.dgLog.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.dgLog.Size = New System.Drawing.Size(784, 411)
        Me.dgLog.TabIndex = 1
        Me.dgLog.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLog})
        '
        'IDALOGTIENDASBindingSource
        '
        Me.IDALOGTIENDASBindingSource.DataMember = "IDA_LOGTIENDAS"
        Me.IDALOGTIENDASBindingSource.DataSource = Me.DsTPVLog
        Me.IDALOGTIENDASBindingSource.Sort = "FECHA DESC"
        '
        'DsTPVLog
        '
        Me.DsTPVLog.DataSetName = "dsTPVLog"
        Me.DsTPVLog.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvLog
        '
        Me.gvLog.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODALM, Me.colDESCRIPCION, Me.colESTADO, Me.colFECHA})
        StyleFormatCondition5.Appearance.ForeColor = System.Drawing.Color.Navy
        StyleFormatCondition5.Appearance.Options.UseForeColor = True
        StyleFormatCondition5.ApplyToRow = True
        StyleFormatCondition5.Column = Me.colESTADO
        StyleFormatCondition5.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition5.Value1 = "E"
        StyleFormatCondition6.Appearance.ForeColor = System.Drawing.Color.Navy
        StyleFormatCondition6.Appearance.Options.UseForeColor = True
        StyleFormatCondition6.ApplyToRow = True
        StyleFormatCondition6.Column = Me.colESTADO
        StyleFormatCondition6.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition6.Value1 = "R"
        StyleFormatCondition7.Appearance.ForeColor = System.Drawing.Color.DarkGreen
        StyleFormatCondition7.Appearance.Options.UseForeColor = True
        StyleFormatCondition7.ApplyToRow = True
        StyleFormatCondition7.Column = Me.colESTADO
        StyleFormatCondition7.Value1 = "A"
        StyleFormatCondition8.Appearance.ForeColor = System.Drawing.Color.DarkRed
        StyleFormatCondition8.Appearance.Options.UseForeColor = True
        StyleFormatCondition8.ApplyToRow = True
        StyleFormatCondition8.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition8.Value1 = "X"
        Me.gvLog.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition5, StyleFormatCondition6, StyleFormatCondition7, StyleFormatCondition8})
        Me.gvLog.GridControl = Me.dgLog
        Me.gvLog.Name = "gvLog"
        Me.gvLog.OptionsBehavior.Editable = False
        Me.gvLog.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvLog.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvLog.OptionsSelection.EnableAppearanceHideSelection = False
        Me.gvLog.OptionsView.RowAutoHeight = True
        '
        'colCODALM
        '
        Me.colCODALM.Caption = "Tienda"
        Me.colCODALM.FieldName = "CODALM"
        Me.colCODALM.Name = "colCODALM"
        Me.colCODALM.OptionsColumn.AllowFocus = False
        Me.colCODALM.Visible = True
        Me.colCODALM.VisibleIndex = 1
        Me.colCODALM.Width = 76
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Descripción"
        Me.colDESCRIPCION.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.OptionsColumn.AllowFocus = False
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 2
        Me.colDESCRIPCION.Width = 559
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colFECHA
        '
        Me.colFECHA.Caption = "Fecha"
        Me.colFECHA.DisplayFormat.FormatString = "g"
        Me.colFECHA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFECHA.FieldName = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.OptionsColumn.AllowFocus = False
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 0
        Me.colFECHA.Width = 131
        '
        'BarManager
        '
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.txtEstado})
        Me.BarManager.MaxItemId = 1
        Me.BarManager.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Barra de estado"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.txtEstado)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Barra de estado"
        '
        'txtEstado
        '
        Me.txtEstado.Id = 0
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(784, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 537)
        Me.barDockControlBottom.Size = New System.Drawing.Size(784, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 537)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(784, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 537)
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
        Me.PanelControl1.TabIndex = 0
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
        Me.txtCODALM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtCODALM.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
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
        'DsTiendas
        '
        Me.DsTiendas.DataSetName = "dsTiendas"
        Me.DsTiendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDATIPOSTIENDABindingSource
        '
        Me.IDATIPOSTIENDABindingSource.DataMember = "IDA_TIPOSTIENDA"
        Me.IDATIPOSTIENDABindingSource.DataSource = Me.DsTiendas
        '
        'fLogTiendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgLog)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "fLogTiendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log comunicación tiendas"
        CType(Me.dgLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDALOGTIENDASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTPVLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtTipoTienda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.DsTiendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDATIPOSTIENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgLog As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLog As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsTPVLog As a3ERP_AydaraTPV.dsTPVLog
    Friend WithEvents IDALOGTIENDASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCODALM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents txtEstado As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtTipoTienda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents DsTiendas As a3ERP_AydaraTPV.dsTiendas
    Friend WithEvents IDATIPOSTIENDABindingSource As System.Windows.Forms.BindingSource
End Class
