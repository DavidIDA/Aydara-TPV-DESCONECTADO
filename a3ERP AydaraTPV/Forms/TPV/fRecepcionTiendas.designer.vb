<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fRecepcionTiendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fRecepcionTiendas))
        Me.colESTADO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgVentas = New DevExpress.XtraGrid.GridControl()
        Me.VENTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTPVRecepcion = New a3ERP_AydaraTPV.dsTPVRecepcion()
        Me.gvVentas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colIMPORTAR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODALM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCALM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFICHERO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVENTAS_LOG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskLog = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colTOTALTICKETS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOTALLINEAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPOTIENDA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcVentas = New DevExpress.XtraEditors.GroupControl()
        Me.gcTraspasos = New DevExpress.XtraEditors.GroupControl()
        Me.dgTraspasos = New DevExpress.XtraGrid.GridControl()
        Me.TRASPASOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvTraspasos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colImportarTRA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTRASPASOS_LOG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcPedidos = New DevExpress.XtraEditors.GroupControl()
        Me.dgPedidos = New DevExpress.XtraGrid.GridControl()
        Me.PEDIDOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvPedidos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colImportarPED = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPEDIDO_LOG = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPEDIDO_FECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPEDIDO_FECHAVALOR = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcOpciones = New DevExpress.XtraEditors.GroupControl()
        Me.bttActualizarSegundoPlano = New DevExpress.XtraEditors.SimpleButton()
        Me.bttActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.gcInventarios = New DevExpress.XtraEditors.GroupControl()
        Me.dgInventarios = New DevExpress.XtraGrid.GridControl()
        Me.INVENTARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvInventarios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colImportarINV = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.bttSeleccionarTodos = New DevExpress.XtraBars.BarButtonItem()
        Me.bttAnularTodos = New DevExpress.XtraBars.BarButtonItem()
        Me.bttSeleccionarActual = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTPVRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcVentas.SuspendLayout()
        CType(Me.gcTraspasos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcTraspasos.SuspendLayout()
        CType(Me.dgTraspasos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRASPASOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTraspasos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcPedidos.SuspendLayout()
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEDIDOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcOpciones.SuspendLayout()
        CType(Me.gcInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcInventarios.SuspendLayout()
        CType(Me.dgInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colESTADO
        '
        Me.colESTADO.Caption = "Estado"
        Me.colESTADO.FieldName = "ESTADO"
        Me.colESTADO.Name = "colESTADO"
        Me.colESTADO.OptionsColumn.AllowEdit = False
        Me.colESTADO.OptionsColumn.AllowFocus = False
        '
        'dgVentas
        '
        Me.dgVentas.DataSource = Me.VENTASBindingSource
        Me.dgVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVentas.Location = New System.Drawing.Point(2, 21)
        Me.dgVentas.MainView = Me.gvVentas
        Me.dgVentas.Name = "dgVentas"
        Me.dgVentas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskLog})
        Me.dgVentas.Size = New System.Drawing.Size(840, 139)
        Me.dgVentas.TabIndex = 5
        Me.dgVentas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVentas})
        '
        'VENTASBindingSource
        '
        Me.VENTASBindingSource.DataMember = "RECEPCION"
        Me.VENTASBindingSource.DataSource = Me.DsTPVRecepcion
        Me.VENTASBindingSource.Filter = "TIPO='V'"
        Me.VENTASBindingSource.Sort = "CODALM"
        '
        'DsTPVRecepcion
        '
        Me.DsTPVRecepcion.DataSetName = "dsTPVRecepcion"
        Me.DsTPVRecepcion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvVentas
        '
        Me.gvVentas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIMPORTAR, Me.colCODALM, Me.colDESCALM, Me.colFICHERO, Me.colDESCRIPCION, Me.colVENTAS_LOG, Me.colESTADO, Me.colTOTALTICKETS, Me.colTOTALLINEAS, Me.colTIPOTIENDA})
        Me.gvVentas.CustomizationFormBounds = New System.Drawing.Rectangle(879, 152, 210, 179)
        Me.gvVentas.GridControl = Me.dgVentas
        Me.gvVentas.GroupCount = 1
        Me.gvVentas.Name = "gvVentas"
        Me.gvVentas.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvVentas.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvVentas.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvVentas.OptionsSelection.EnableAppearanceHideSelection = False
        Me.gvVentas.OptionsView.RowAutoHeight = True
        Me.gvVentas.OptionsView.ShowGroupPanel = False
        Me.gvVentas.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colTIPOTIENDA, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colIMPORTAR
        '
        Me.colIMPORTAR.Caption = " "
        Me.colIMPORTAR.FieldName = "IMPORTAR"
        Me.colIMPORTAR.MaxWidth = 30
        Me.colIMPORTAR.MinWidth = 30
        Me.colIMPORTAR.Name = "colIMPORTAR"
        Me.colIMPORTAR.OptionsColumn.AllowShowHide = False
        Me.colIMPORTAR.Visible = True
        Me.colIMPORTAR.VisibleIndex = 0
        Me.colIMPORTAR.Width = 51
        '
        'colCODALM
        '
        Me.colCODALM.Caption = "Tienda"
        Me.colCODALM.FieldName = "CODALM"
        Me.colCODALM.Name = "colCODALM"
        Me.colCODALM.OptionsColumn.AllowEdit = False
        Me.colCODALM.OptionsColumn.AllowFocus = False
        Me.colCODALM.Visible = True
        Me.colCODALM.VisibleIndex = 1
        Me.colCODALM.Width = 45
        '
        'colDESCALM
        '
        Me.colDESCALM.Caption = "Nombre tienda"
        Me.colDESCALM.FieldName = "DESCALM"
        Me.colDESCALM.Name = "colDESCALM"
        Me.colDESCALM.Visible = True
        Me.colDESCALM.VisibleIndex = 2
        '
        'colFICHERO
        '
        Me.colFICHERO.Caption = "Fichero"
        Me.colFICHERO.FieldName = "FICHERO"
        Me.colFICHERO.Name = "colFICHERO"
        Me.colFICHERO.OptionsColumn.AllowEdit = False
        Me.colFICHERO.OptionsColumn.AllowFocus = False
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.Caption = "Descripción"
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.OptionsColumn.AllowEdit = False
        Me.colDESCRIPCION.OptionsColumn.AllowFocus = False
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 3
        Me.colDESCRIPCION.Width = 150
        '
        'colVENTAS_LOG
        '
        Me.colVENTAS_LOG.Caption = "Log"
        Me.colVENTAS_LOG.ColumnEdit = Me.maskLog
        Me.colVENTAS_LOG.FieldName = "LOG"
        Me.colVENTAS_LOG.Name = "colVENTAS_LOG"
        Me.colVENTAS_LOG.OptionsColumn.AllowEdit = False
        Me.colVENTAS_LOG.OptionsColumn.AllowFocus = False
        Me.colVENTAS_LOG.Width = 46
        '
        'maskLog
        '
        Me.maskLog.Name = "maskLog"
        '
        'colTOTALTICKETS
        '
        Me.colTOTALTICKETS.Caption = "Nº Tickets"
        Me.colTOTALTICKETS.FieldName = "TOTALTICKETS"
        Me.colTOTALTICKETS.Name = "colTOTALTICKETS"
        Me.colTOTALTICKETS.OptionsColumn.AllowEdit = False
        Me.colTOTALTICKETS.OptionsColumn.AllowFocus = False
        Me.colTOTALTICKETS.Visible = True
        Me.colTOTALTICKETS.VisibleIndex = 4
        '
        'colTOTALLINEAS
        '
        Me.colTOTALLINEAS.Caption = "Nº Líneas"
        Me.colTOTALLINEAS.FieldName = "TOTALLINEAS"
        Me.colTOTALLINEAS.Name = "colTOTALLINEAS"
        Me.colTOTALLINEAS.OptionsColumn.AllowEdit = False
        Me.colTOTALLINEAS.OptionsColumn.AllowFocus = False
        Me.colTOTALLINEAS.Visible = True
        Me.colTOTALLINEAS.VisibleIndex = 5
        '
        'colTIPOTIENDA
        '
        Me.colTIPOTIENDA.Caption = "Tipo de tienda"
        Me.colTIPOTIENDA.FieldName = "TIPOTIENDA"
        Me.colTIPOTIENDA.Name = "colTIPOTIENDA"
        Me.colTIPOTIENDA.Visible = True
        Me.colTIPOTIENDA.VisibleIndex = 6
        '
        'gcVentas
        '
        Me.gcVentas.Controls.Add(Me.dgVentas)
        Me.gcVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.gcVentas.Location = New System.Drawing.Point(0, 0)
        Me.gcVentas.Name = "gcVentas"
        Me.gcVentas.Size = New System.Drawing.Size(844, 162)
        Me.gcVentas.TabIndex = 6
        Me.gcVentas.Text = "VENTAS"
        '
        'gcTraspasos
        '
        Me.gcTraspasos.Controls.Add(Me.dgTraspasos)
        Me.gcTraspasos.Dock = System.Windows.Forms.DockStyle.Left
        Me.gcTraspasos.Location = New System.Drawing.Point(0, 162)
        Me.gcTraspasos.Name = "gcTraspasos"
        Me.gcTraspasos.Size = New System.Drawing.Size(386, 186)
        Me.gcTraspasos.TabIndex = 7
        Me.gcTraspasos.Text = "TRASPASOS"
        '
        'dgTraspasos
        '
        Me.dgTraspasos.DataSource = Me.TRASPASOSBindingSource
        Me.dgTraspasos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTraspasos.Location = New System.Drawing.Point(2, 21)
        Me.dgTraspasos.MainView = Me.gvTraspasos
        Me.dgTraspasos.Name = "dgTraspasos"
        Me.dgTraspasos.Size = New System.Drawing.Size(382, 163)
        Me.dgTraspasos.TabIndex = 5
        Me.dgTraspasos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTraspasos})
        '
        'TRASPASOSBindingSource
        '
        Me.TRASPASOSBindingSource.DataMember = "RECEPCION"
        Me.TRASPASOSBindingSource.DataSource = Me.DsTPVRecepcion
        Me.TRASPASOSBindingSource.Filter = "TIPO='T'"
        Me.TRASPASOSBindingSource.Sort = "CODALM"
        '
        'gvTraspasos
        '
        Me.gvTraspasos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colImportarTRA, Me.GridColumn3, Me.GridColumn13, Me.GridColumn4, Me.GridColumn5, Me.colTRASPASOS_LOG})
        Me.gvTraspasos.GridControl = Me.dgTraspasos
        Me.gvTraspasos.Name = "gvTraspasos"
        Me.gvTraspasos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvTraspasos.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvTraspasos.OptionsView.ShowGroupPanel = False
        '
        'colImportarTRA
        '
        Me.colImportarTRA.Caption = " "
        Me.colImportarTRA.FieldName = "IMPORTAR"
        Me.colImportarTRA.Name = "colImportarTRA"
        Me.colImportarTRA.Visible = True
        Me.colImportarTRA.VisibleIndex = 0
        Me.colImportarTRA.Width = 40
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Tienda"
        Me.GridColumn3.FieldName = "CODALM"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.AllowFocus = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 74
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Nombre tienda"
        Me.GridColumn13.FieldName = "DESCALM"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.AllowEdit = False
        Me.GridColumn13.OptionsColumn.AllowFocus = False
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 2
        Me.GridColumn13.Width = 174
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fichero"
        Me.GridColumn4.FieldName = "FICHERO"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.AllowFocus = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 174
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Descripción"
        Me.GridColumn5.FieldName = "DESCRIPCION"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.OptionsColumn.AllowFocus = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 174
        '
        'colTRASPASOS_LOG
        '
        Me.colTRASPASOS_LOG.Caption = "Log"
        Me.colTRASPASOS_LOG.FieldName = "LOG"
        Me.colTRASPASOS_LOG.Name = "colTRASPASOS_LOG"
        Me.colTRASPASOS_LOG.OptionsColumn.AllowEdit = False
        Me.colTRASPASOS_LOG.OptionsColumn.AllowFocus = False
        Me.colTRASPASOS_LOG.Width = 180
        '
        'gcPedidos
        '
        Me.gcPedidos.Controls.Add(Me.dgPedidos)
        Me.gcPedidos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gcPedidos.Location = New System.Drawing.Point(0, 348)
        Me.gcPedidos.Name = "gcPedidos"
        Me.gcPedidos.Size = New System.Drawing.Size(844, 161)
        Me.gcPedidos.TabIndex = 8
        Me.gcPedidos.Text = "PEDIDOS"
        '
        'dgPedidos
        '
        Me.dgPedidos.DataSource = Me.PEDIDOSBindingSource
        Me.dgPedidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPedidos.Location = New System.Drawing.Point(2, 21)
        Me.dgPedidos.MainView = Me.gvPedidos
        Me.dgPedidos.Name = "dgPedidos"
        Me.dgPedidos.Size = New System.Drawing.Size(840, 138)
        Me.dgPedidos.TabIndex = 5
        Me.dgPedidos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPedidos})
        '
        'PEDIDOSBindingSource
        '
        Me.PEDIDOSBindingSource.DataMember = "RECEPCION"
        Me.PEDIDOSBindingSource.DataSource = Me.DsTPVRecepcion
        Me.PEDIDOSBindingSource.Filter = "TIPO='P'"
        Me.PEDIDOSBindingSource.Sort = "CODALM"
        '
        'gvPedidos
        '
        Me.gvPedidos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colImportarPED, Me.GridColumn9, Me.GridColumn14, Me.GridColumn10, Me.GridColumn11, Me.colPEDIDO_LOG, Me.colPEDIDO_FECHA, Me.colPEDIDO_FECHAVALOR})
        Me.gvPedidos.GridControl = Me.dgPedidos
        Me.gvPedidos.Name = "gvPedidos"
        Me.gvPedidos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvPedidos.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvPedidos.OptionsView.ShowGroupPanel = False
        '
        'colImportarPED
        '
        Me.colImportarPED.Caption = " "
        Me.colImportarPED.FieldName = "IMPORTAR"
        Me.colImportarPED.Name = "colImportarPED"
        Me.colImportarPED.Visible = True
        Me.colImportarPED.VisibleIndex = 0
        Me.colImportarPED.Width = 40
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Tienda"
        Me.GridColumn9.FieldName = "CODALM"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.AllowFocus = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 60
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Nombre tienda"
        Me.GridColumn14.FieldName = "DESCALM"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.AllowEdit = False
        Me.GridColumn14.OptionsColumn.AllowFocus = False
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 2
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Fichero"
        Me.GridColumn10.FieldName = "FICHERO"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.OptionsColumn.AllowFocus = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 3
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Descripción"
        Me.GridColumn11.FieldName = "DESCRIPCION"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.AllowEdit = False
        Me.GridColumn11.OptionsColumn.AllowFocus = False
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 4
        '
        'colPEDIDO_LOG
        '
        Me.colPEDIDO_LOG.Caption = "Log"
        Me.colPEDIDO_LOG.FieldName = "LOG"
        Me.colPEDIDO_LOG.Name = "colPEDIDO_LOG"
        Me.colPEDIDO_LOG.OptionsColumn.AllowEdit = False
        Me.colPEDIDO_LOG.OptionsColumn.AllowFocus = False
        '
        'colPEDIDO_FECHA
        '
        Me.colPEDIDO_FECHA.Caption = "Fecha pedido"
        Me.colPEDIDO_FECHA.FieldName = "PEDIDO_FECHA"
        Me.colPEDIDO_FECHA.Name = "colPEDIDO_FECHA"
        Me.colPEDIDO_FECHA.Visible = True
        Me.colPEDIDO_FECHA.VisibleIndex = 5
        '
        'colPEDIDO_FECHAVALOR
        '
        Me.colPEDIDO_FECHAVALOR.Caption = "Fecha valor"
        Me.colPEDIDO_FECHAVALOR.FieldName = "PEDIDO_FECHAVALOR"
        Me.colPEDIDO_FECHAVALOR.Name = "colPEDIDO_FECHAVALOR"
        Me.colPEDIDO_FECHAVALOR.Visible = True
        Me.colPEDIDO_FECHAVALOR.VisibleIndex = 6
        '
        'gcOpciones
        '
        Me.gcOpciones.Controls.Add(Me.bttActualizarSegundoPlano)
        Me.gcOpciones.Controls.Add(Me.bttActualizar)
        Me.gcOpciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gcOpciones.Location = New System.Drawing.Point(0, 509)
        Me.gcOpciones.Name = "gcOpciones"
        Me.gcOpciones.Size = New System.Drawing.Size(844, 67)
        Me.gcOpciones.TabIndex = 13
        Me.gcOpciones.Text = "Opciones"
        '
        'bttActualizarSegundoPlano
        '
        Me.bttActualizarSegundoPlano.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttActualizarSegundoPlano.Image = CType(resources.GetObject("bttActualizarSegundoPlano.Image"), System.Drawing.Image)
        Me.bttActualizarSegundoPlano.Location = New System.Drawing.Point(571, 27)
        Me.bttActualizarSegundoPlano.Name = "bttActualizarSegundoPlano"
        Me.bttActualizarSegundoPlano.Size = New System.Drawing.Size(172, 28)
        Me.bttActualizarSegundoPlano.TabIndex = 2
        Me.bttActualizarSegundoPlano.Text = "Actualizar en segundo plano"
        Me.bttActualizarSegundoPlano.Visible = False
        '
        'bttActualizar
        '
        Me.bttActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttActualizar.Image = CType(resources.GetObject("bttActualizar.Image"), System.Drawing.Image)
        Me.bttActualizar.Location = New System.Drawing.Point(749, 27)
        Me.bttActualizar.Name = "bttActualizar"
        Me.bttActualizar.Size = New System.Drawing.Size(83, 28)
        Me.bttActualizar.TabIndex = 1
        Me.bttActualizar.Text = "Actualizar"
        '
        'gcInventarios
        '
        Me.gcInventarios.Controls.Add(Me.dgInventarios)
        Me.gcInventarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcInventarios.Location = New System.Drawing.Point(386, 162)
        Me.gcInventarios.Name = "gcInventarios"
        Me.gcInventarios.Size = New System.Drawing.Size(458, 186)
        Me.gcInventarios.TabIndex = 14
        Me.gcInventarios.Text = "INVENTARIOS"
        '
        'dgInventarios
        '
        Me.dgInventarios.DataSource = Me.INVENTARIOSBindingSource
        Me.dgInventarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgInventarios.Location = New System.Drawing.Point(2, 21)
        Me.dgInventarios.MainView = Me.gvInventarios
        Me.dgInventarios.Name = "dgInventarios"
        Me.dgInventarios.Size = New System.Drawing.Size(454, 163)
        Me.dgInventarios.TabIndex = 5
        Me.dgInventarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvInventarios})
        '
        'INVENTARIOSBindingSource
        '
        Me.INVENTARIOSBindingSource.DataMember = "RECEPCION"
        Me.INVENTARIOSBindingSource.DataSource = Me.DsTPVRecepcion
        Me.INVENTARIOSBindingSource.Filter = "TIPO='I' OR TIPO = 'IN'"
        Me.INVENTARIOSBindingSource.Sort = "CODALM"
        '
        'gvInventarios
        '
        Me.gvInventarios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colImportarINV, Me.GridColumn2, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.gvInventarios.GridControl = Me.dgInventarios
        Me.gvInventarios.Name = "gvInventarios"
        Me.gvInventarios.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvInventarios.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvInventarios.OptionsView.ShowGroupPanel = False
        '
        'colImportarINV
        '
        Me.colImportarINV.Caption = " "
        Me.colImportarINV.FieldName = "IMPORTAR"
        Me.colImportarINV.Name = "colImportarINV"
        Me.colImportarINV.Visible = True
        Me.colImportarINV.VisibleIndex = 0
        Me.colImportarINV.Width = 40
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tienda"
        Me.GridColumn2.FieldName = "CODALM"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.OptionsColumn.AllowFocus = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 74
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Nombre tienda"
        Me.GridColumn6.FieldName = "DESCALM"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.OptionsColumn.AllowFocus = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 2
        Me.GridColumn6.Width = 174
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Fichero"
        Me.GridColumn7.FieldName = "FICHERO"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.AllowFocus = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 174
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Descripción"
        Me.GridColumn8.FieldName = "DESCRIPCION"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.OptionsColumn.AllowFocus = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        Me.GridColumn8.Width = 174
        '
        'PopupMenu
        '
        Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bttSeleccionarTodos), New DevExpress.XtraBars.LinkPersistInfo(Me.bttAnularTodos), New DevExpress.XtraBars.LinkPersistInfo(Me.bttSeleccionarActual)})
        Me.PopupMenu.Manager = Me.BarManager
        Me.PopupMenu.Name = "PopupMenu"
        '
        'bttSeleccionarTodos
        '
        Me.bttSeleccionarTodos.Caption = "Seleccionar todos"
        Me.bttSeleccionarTodos.Glyph = CType(resources.GetObject("bttSeleccionarTodos.Glyph"), System.Drawing.Image)
        Me.bttSeleccionarTodos.Id = 0
        Me.bttSeleccionarTodos.LargeGlyph = CType(resources.GetObject("bttSeleccionarTodos.LargeGlyph"), System.Drawing.Image)
        Me.bttSeleccionarTodos.Name = "bttSeleccionarTodos"
        '
        'bttAnularTodos
        '
        Me.bttAnularTodos.Caption = "Anular todos"
        Me.bttAnularTodos.Glyph = CType(resources.GetObject("bttAnularTodos.Glyph"), System.Drawing.Image)
        Me.bttAnularTodos.Id = 1
        Me.bttAnularTodos.LargeGlyph = CType(resources.GetObject("bttAnularTodos.LargeGlyph"), System.Drawing.Image)
        Me.bttAnularTodos.Name = "bttAnularTodos"
        '
        'bttSeleccionarActual
        '
        Me.bttSeleccionarActual.Caption = "Seleccionar actual"
        Me.bttSeleccionarActual.Glyph = CType(resources.GetObject("bttSeleccionarActual.Glyph"), System.Drawing.Image)
        Me.bttSeleccionarActual.Id = 2
        Me.bttSeleccionarActual.LargeGlyph = CType(resources.GetObject("bttSeleccionarActual.LargeGlyph"), System.Drawing.Image)
        Me.bttSeleccionarActual.Name = "bttSeleccionarActual"
        '
        'BarManager
        '
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bttSeleccionarTodos, Me.bttAnularTodos, Me.bttSeleccionarActual})
        Me.BarManager.MaxItemId = 3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(844, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 576)
        Me.barDockControlBottom.Size = New System.Drawing.Size(844, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 576)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(844, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 576)
        '
        'fRecepcionTiendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 576)
        Me.Controls.Add(Me.gcInventarios)
        Me.Controls.Add(Me.gcTraspasos)
        Me.Controls.Add(Me.gcPedidos)
        Me.Controls.Add(Me.gcVentas)
        Me.Controls.Add(Me.gcOpciones)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fRecepcionTiendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Recepción tiendas"
        Me.TopMost = True
        CType(Me.dgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTPVRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcVentas.ResumeLayout(False)
        CType(Me.gcTraspasos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcTraspasos.ResumeLayout(False)
        CType(Me.dgTraspasos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRASPASOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTraspasos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcPedidos.ResumeLayout(False)
        CType(Me.dgPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEDIDOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcOpciones.ResumeLayout(False)
        CType(Me.gcInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcInventarios.ResumeLayout(False)
        CType(Me.dgInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgVentas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVentas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents VENTASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colIMPORTAR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODALM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFICHERO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVENTAS_LOG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcTraspasos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgTraspasos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTraspasos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colImportarTRA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTRASPASOS_LOG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcVentas As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcPedidos As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgPedidos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPedidos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colImportarPED As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPEDIDO_LOG As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TRASPASOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PEDIDOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents maskLog As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents colESTADO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bttActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colTOTALTICKETS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOTALLINEAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPOTIENDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCALM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsTPVRecepcion As a3ERP_AydaraTPV.dsTPVRecepcion
    Friend WithEvents colPEDIDO_FECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bttActualizarSegundoPlano As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colPEDIDO_FECHAVALOR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcInventarios As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgInventarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvInventarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colImportarINV As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents INVENTARIOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents bttSeleccionarTodos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttAnularTodos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttSeleccionarActual As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
