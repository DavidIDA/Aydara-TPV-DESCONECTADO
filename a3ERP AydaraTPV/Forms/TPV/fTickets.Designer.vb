<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fTickets
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fTickets))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.gvLineas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNUMLINEA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODPER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODART = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCLIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRECIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskDESC = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colTOTLIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRCMANUAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPIVA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgTickets = New DevExpress.XtraGrid.GridControl()
        Me.TiendasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTickets = New a3ERP_AydaraTPV.dsTickets()
        Me.gvTickets = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colALMACEN_TIPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODALM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colALMACEN_DESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTickets_NUMDOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTickets_FECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECCIERRE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTickets_CODCLI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCLIENTE_NOMCLI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTickets_NUMLINEAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTickets_Total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOTPUNTOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colALALBARAN_NUMDOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.linkAlbaran = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colFACTURA_NUMDOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.linkFactura = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.gcVentas = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.txtTipoTienda = New DevExpress.XtraEditors.LookUpEdit()
        Me.IDATIPOSTIENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTiendas = New a3ERP_AydaraTPV.dsTiendas()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEstado = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.checkFechaVenta = New DevExpress.XtraEditors.CheckEdit()
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.bttEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bttBorrar = New DevExpress.XtraBars.BarButtonItem()
        Me.bttGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bttNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bttImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.bttFacturar = New DevExpress.XtraBars.BarButtonItem()
        Me.txtFechaFin = New DevExpress.XtraEditors.DateEdit()
        Me.txtFechaInicio = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEjercicio = New DevExpress.XtraEditors.SpinEdit()
        Me.txtMes = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.rgFecha = New DevExpress.XtraEditors.RadioGroup()
        Me.txtDESCALM = New DevExpress.XtraEditors.TextEdit()
        Me.txtCODALM = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.bttAplicar = New DevExpress.XtraEditors.SimpleButton()
        Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.gvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskDESC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TiendasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkAlbaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linkFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcVentas.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtTipoTienda.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDATIPOSTIENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTiendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.checkFechaVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEjercicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDESCALM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCODALM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvLineas
        '
        Me.gvLineas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNUMLINEA, Me.colCODPER, Me.colCODART, Me.colDESCLIN, Me.colCANTIDAD, Me.colPRECIO, Me.colDESC, Me.colTOTLIN, Me.colPRCMANUAL, Me.colPROMO, Me.colTIPIVA})
        Me.gvLineas.GridControl = Me.dgTickets
        Me.gvLineas.Name = "gvLineas"
        Me.gvLineas.OptionsSelection.MultiSelect = True
        Me.gvLineas.OptionsView.ShowFooter = True
        Me.gvLineas.OptionsView.ShowGroupPanel = False
        Me.gvLineas.ViewCaption = "Líneas de tickets"
        '
        'colNUMLINEA
        '
        Me.colNUMLINEA.Caption = "Nº línea"
        Me.colNUMLINEA.FieldName = "NUMLINEA"
        Me.colNUMLINEA.Name = "colNUMLINEA"
        Me.colNUMLINEA.Visible = True
        Me.colNUMLINEA.VisibleIndex = 0
        '
        'colCODPER
        '
        Me.colCODPER.Caption = "Empleado"
        Me.colCODPER.FieldName = "CODPER"
        Me.colCODPER.Name = "colCODPER"
        '
        'colCODART
        '
        Me.colCODART.Caption = "Artículo"
        Me.colCODART.FieldName = "CODART"
        Me.colCODART.Name = "colCODART"
        Me.colCODART.Visible = True
        Me.colCODART.VisibleIndex = 1
        '
        'colDESCLIN
        '
        Me.colDESCLIN.Caption = "Descripción"
        Me.colDESCLIN.FieldName = "DESCLIN"
        Me.colDESCLIN.Name = "colDESCLIN"
        Me.colDESCLIN.Visible = True
        Me.colDESCLIN.VisibleIndex = 2
        '
        'colCANTIDAD
        '
        Me.colCANTIDAD.Caption = "Cantidad"
        Me.colCANTIDAD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCANTIDAD.FieldName = "CANTIDAD"
        Me.colCANTIDAD.Name = "colCANTIDAD"
        Me.colCANTIDAD.Visible = True
        Me.colCANTIDAD.VisibleIndex = 3
        '
        'colPRECIO
        '
        Me.colPRECIO.Caption = "Precio"
        Me.colPRECIO.DisplayFormat.FormatString = "{0:c2}"
        Me.colPRECIO.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPRECIO.FieldName = "PRECIO"
        Me.colPRECIO.Name = "colPRECIO"
        Me.colPRECIO.Visible = True
        Me.colPRECIO.VisibleIndex = 4
        '
        'colDESC
        '
        Me.colDESC.Caption = "Dto."
        Me.colDESC.ColumnEdit = Me.maskDESC
        Me.colDESC.FieldName = "DESC"
        Me.colDESC.Name = "colDESC"
        Me.colDESC.Visible = True
        Me.colDESC.VisibleIndex = 5
        '
        'maskDESC
        '
        Me.maskDESC.AutoHeight = False
        Me.maskDESC.Mask.EditMask = "P"
        Me.maskDESC.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskDESC.Mask.UseMaskAsDisplayFormat = True
        Me.maskDESC.Name = "maskDESC"
        '
        'colTOTLIN
        '
        Me.colTOTLIN.Caption = "Total"
        Me.colTOTLIN.DisplayFormat.FormatString = "{0:c2}"
        Me.colTOTLIN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOTLIN.FieldName = "TOTLIN"
        Me.colTOTLIN.Name = "colTOTLIN"
        Me.colTOTLIN.Visible = True
        Me.colTOTLIN.VisibleIndex = 6
        '
        'colPRCMANUAL
        '
        Me.colPRCMANUAL.Caption = "Precio manual"
        Me.colPRCMANUAL.FieldName = "PRCMANUAL"
        Me.colPRCMANUAL.Name = "colPRCMANUAL"
        '
        'colPROMO
        '
        Me.colPROMO.Caption = "Promoción"
        Me.colPROMO.FieldName = "PROMO"
        Me.colPROMO.Name = "colPROMO"
        '
        'colTIPIVA
        '
        Me.colTIPIVA.Caption = "Tipo IVA"
        Me.colTIPIVA.FieldName = "TIPIVA"
        Me.colTIPIVA.Name = "colTIPIVA"
        '
        'dgTickets
        '
        Me.dgTickets.DataSource = Me.TiendasBindingSource
        Me.dgTickets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTickets.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.dgTickets.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgTickets.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgTickets.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        GridLevelNode1.LevelTemplate = Me.gvLineas
        GridLevelNode1.RelationName = "FK_IDA_TICKETSLINEAS_IDA_TICKETS_IDTICKET"
        Me.dgTickets.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.dgTickets.Location = New System.Drawing.Point(2, 21)
        Me.dgTickets.MainView = Me.gvTickets
        Me.dgTickets.Name = "dgTickets"
        Me.dgTickets.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.linkAlbaran, Me.linkFactura, Me.maskDESC})
        Me.dgTickets.Size = New System.Drawing.Size(980, 325)
        Me.dgTickets.TabIndex = 7
        Me.dgTickets.UseEmbeddedNavigator = True
        Me.dgTickets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTickets, Me.gvLineas})
        '
        'TiendasBindingSource
        '
        Me.TiendasBindingSource.DataMember = "IDA_TICKETS"
        Me.TiendasBindingSource.DataSource = Me.DsTickets
        '
        'DsTickets
        '
        Me.DsTickets.DataSetName = "dsTickets"
        Me.DsTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvTickets
        '
        Me.gvTickets.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colALMACEN_TIPO, Me.colCODALM, Me.colALMACEN_DESC, Me.colTickets_NUMDOC, Me.colTickets_FECHA, Me.colFECCIERRE, Me.colTickets_CODCLI, Me.colCLIENTE_NOMCLI, Me.colTickets_NUMLINEAS, Me.colTickets_Total, Me.colTOTPUNTOS, Me.colALALBARAN_NUMDOC, Me.colFACTURA_NUMDOC})
        Me.gvTickets.GridControl = Me.dgTickets
        Me.gvTickets.GroupCount = 1
        Me.gvTickets.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTDOC", Nothing, "{0:c2}")})
        Me.gvTickets.Name = "gvTickets"
        Me.gvTickets.OptionsBehavior.AutoExpandAllGroups = True
        Me.gvTickets.OptionsSelection.MultiSelect = True
        Me.gvTickets.OptionsView.ShowFooter = True
        Me.gvTickets.OptionsView.ShowGroupPanel = False
        Me.gvTickets.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colALMACEN_TIPO, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.gvTickets.ViewCaption = "Cabecera de tickets"
        '
        'colALMACEN_TIPO
        '
        Me.colALMACEN_TIPO.Caption = "Tipo tienda"
        Me.colALMACEN_TIPO.FieldName = "ALMACEN_TIPO"
        Me.colALMACEN_TIPO.Name = "colALMACEN_TIPO"
        Me.colALMACEN_TIPO.OptionsColumn.AllowEdit = False
        Me.colALMACEN_TIPO.OptionsColumn.AllowFocus = False
        Me.colALMACEN_TIPO.OptionsColumn.ReadOnly = True
        Me.colALMACEN_TIPO.Visible = True
        Me.colALMACEN_TIPO.VisibleIndex = 0
        '
        'colCODALM
        '
        Me.colCODALM.Caption = "Tienda"
        Me.colCODALM.FieldName = "CODALM"
        Me.colCODALM.Name = "colCODALM"
        Me.colCODALM.OptionsColumn.AllowEdit = False
        Me.colCODALM.OptionsColumn.AllowFocus = False
        Me.colCODALM.OptionsColumn.ReadOnly = True
        Me.colCODALM.Width = 70
        '
        'colALMACEN_DESC
        '
        Me.colALMACEN_DESC.Caption = "Nombre tienda"
        Me.colALMACEN_DESC.FieldName = "ALMACEN_DESC"
        Me.colALMACEN_DESC.Name = "colALMACEN_DESC"
        Me.colALMACEN_DESC.OptionsColumn.AllowEdit = False
        Me.colALMACEN_DESC.OptionsColumn.AllowFocus = False
        Me.colALMACEN_DESC.OptionsColumn.ReadOnly = True
        Me.colALMACEN_DESC.Visible = True
        Me.colALMACEN_DESC.VisibleIndex = 0
        Me.colALMACEN_DESC.Width = 164
        '
        'colTickets_NUMDOC
        '
        Me.colTickets_NUMDOC.Caption = "Nº ticket"
        Me.colTickets_NUMDOC.FieldName = "NUMDOC"
        Me.colTickets_NUMDOC.Name = "colTickets_NUMDOC"
        Me.colTickets_NUMDOC.OptionsColumn.AllowEdit = False
        Me.colTickets_NUMDOC.OptionsColumn.AllowFocus = False
        Me.colTickets_NUMDOC.OptionsColumn.ReadOnly = True
        Me.colTickets_NUMDOC.Visible = True
        Me.colTickets_NUMDOC.VisibleIndex = 1
        Me.colTickets_NUMDOC.Width = 73
        '
        'colTickets_FECHA
        '
        Me.colTickets_FECHA.Caption = "Fecha"
        Me.colTickets_FECHA.DisplayFormat.FormatString = "g"
        Me.colTickets_FECHA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTickets_FECHA.FieldName = "FECHA"
        Me.colTickets_FECHA.Name = "colTickets_FECHA"
        Me.colTickets_FECHA.OptionsColumn.AllowEdit = False
        Me.colTickets_FECHA.OptionsColumn.AllowFocus = False
        Me.colTickets_FECHA.OptionsColumn.ReadOnly = True
        Me.colTickets_FECHA.Visible = True
        Me.colTickets_FECHA.VisibleIndex = 2
        Me.colTickets_FECHA.Width = 73
        '
        'colFECCIERRE
        '
        Me.colFECCIERRE.Caption = "F.Cierre"
        Me.colFECCIERRE.FieldName = "FECCIERRE"
        Me.colFECCIERRE.Name = "colFECCIERRE"
        '
        'colTickets_CODCLI
        '
        Me.colTickets_CODCLI.Caption = "Cliente"
        Me.colTickets_CODCLI.FieldName = "CODCLI"
        Me.colTickets_CODCLI.Name = "colTickets_CODCLI"
        Me.colTickets_CODCLI.OptionsColumn.AllowEdit = False
        Me.colTickets_CODCLI.OptionsColumn.AllowFocus = False
        Me.colTickets_CODCLI.OptionsColumn.ReadOnly = True
        Me.colTickets_CODCLI.Visible = True
        Me.colTickets_CODCLI.VisibleIndex = 3
        Me.colTickets_CODCLI.Width = 68
        '
        'colCLIENTE_NOMCLI
        '
        Me.colCLIENTE_NOMCLI.Caption = "Nombre cliente"
        Me.colCLIENTE_NOMCLI.FieldName = "CLIENTE_NOMCLI"
        Me.colCLIENTE_NOMCLI.Name = "colCLIENTE_NOMCLI"
        Me.colCLIENTE_NOMCLI.OptionsColumn.AllowEdit = False
        Me.colCLIENTE_NOMCLI.OptionsColumn.AllowFocus = False
        Me.colCLIENTE_NOMCLI.OptionsColumn.ReadOnly = True
        Me.colCLIENTE_NOMCLI.Visible = True
        Me.colCLIENTE_NOMCLI.VisibleIndex = 4
        Me.colCLIENTE_NOMCLI.Width = 431
        '
        'colTickets_NUMLINEAS
        '
        Me.colTickets_NUMLINEAS.Caption = "Nº líneas"
        Me.colTickets_NUMLINEAS.FieldName = "NUMLINEAS"
        Me.colTickets_NUMLINEAS.Name = "colTickets_NUMLINEAS"
        Me.colTickets_NUMLINEAS.OptionsColumn.AllowEdit = False
        Me.colTickets_NUMLINEAS.OptionsColumn.AllowFocus = False
        Me.colTickets_NUMLINEAS.OptionsColumn.ReadOnly = True
        Me.colTickets_NUMLINEAS.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "NUMLINEAS", "{0:n0}")})
        Me.colTickets_NUMLINEAS.Visible = True
        Me.colTickets_NUMLINEAS.VisibleIndex = 5
        Me.colTickets_NUMLINEAS.Width = 67
        '
        'colTickets_Total
        '
        Me.colTickets_Total.Caption = "Total"
        Me.colTickets_Total.DisplayFormat.FormatString = "{0:c2}"
        Me.colTickets_Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTickets_Total.FieldName = "TOTDOC"
        Me.colTickets_Total.Name = "colTickets_Total"
        Me.colTickets_Total.OptionsColumn.AllowEdit = False
        Me.colTickets_Total.OptionsColumn.AllowFocus = False
        Me.colTickets_Total.OptionsColumn.ReadOnly = True
        Me.colTickets_Total.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TOTDOC", "{0:c2}")})
        Me.colTickets_Total.Visible = True
        Me.colTickets_Total.VisibleIndex = 6
        Me.colTickets_Total.Width = 88
        '
        'colTOTPUNTOS
        '
        Me.colTOTPUNTOS.Caption = "Puntos"
        Me.colTOTPUNTOS.FieldName = "TOTPUNTOS"
        Me.colTOTPUNTOS.Name = "colTOTPUNTOS"
        '
        'colALALBARAN_NUMDOC
        '
        Me.colALALBARAN_NUMDOC.Caption = "Albarán"
        Me.colALALBARAN_NUMDOC.ColumnEdit = Me.linkAlbaran
        Me.colALALBARAN_NUMDOC.FieldName = "ALBARAN_NUMDOC"
        Me.colALALBARAN_NUMDOC.Name = "colALALBARAN_NUMDOC"
        Me.colALALBARAN_NUMDOC.OptionsColumn.ReadOnly = True
        Me.colALALBARAN_NUMDOC.Visible = True
        Me.colALALBARAN_NUMDOC.VisibleIndex = 7
        '
        'linkAlbaran
        '
        Me.linkAlbaran.AutoHeight = False
        Me.linkAlbaran.Name = "linkAlbaran"
        '
        'colFACTURA_NUMDOC
        '
        Me.colFACTURA_NUMDOC.Caption = "Factura"
        Me.colFACTURA_NUMDOC.ColumnEdit = Me.linkFactura
        Me.colFACTURA_NUMDOC.FieldName = "FACTURA_NUMDOC"
        Me.colFACTURA_NUMDOC.Name = "colFACTURA_NUMDOC"
        Me.colFACTURA_NUMDOC.OptionsColumn.ReadOnly = True
        Me.colFACTURA_NUMDOC.Visible = True
        Me.colFACTURA_NUMDOC.VisibleIndex = 8
        '
        'linkFactura
        '
        Me.linkFactura.AutoHeight = False
        Me.linkFactura.Name = "linkFactura"
        '
        'gcVentas
        '
        Me.gcVentas.Controls.Add(Me.dgTickets)
        Me.gcVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcVentas.Location = New System.Drawing.Point(0, 191)
        Me.gcVentas.Name = "gcVentas"
        Me.gcVentas.Size = New System.Drawing.Size(984, 348)
        Me.gcVentas.TabIndex = 14
        Me.gcVentas.Text = "Ventas"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.txtTipoTienda)
        Me.GroupControl2.Controls.Add(Me.LabelControl8)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.txtEstado)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.GroupControl3)
        Me.GroupControl2.Controls.Add(Me.txtDESCALM)
        Me.GroupControl2.Controls.Add(Me.txtCODALM)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Controls.Add(Me.bttAplicar)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 31)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.ShowCaption = False
        Me.GroupControl2.Size = New System.Drawing.Size(984, 160)
        Me.GroupControl2.TabIndex = 17
        Me.GroupControl2.Text = "Filtros"
        '
        'txtTipoTienda
        '
        Me.txtTipoTienda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoTienda.Location = New System.Drawing.Point(761, 130)
        Me.txtTipoTienda.Name = "txtTipoTienda"
        Me.txtTipoTienda.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Close)})
        Me.txtTipoTienda.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CODIGO", 50, "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESCRIPCION", 150, "Descripción")})
        Me.txtTipoTienda.Properties.DataSource = Me.IDATIPOSTIENDABindingSource
        Me.txtTipoTienda.Properties.DisplayMember = "DESCRIPCION"
        Me.txtTipoTienda.Properties.NullText = "Todas"
        Me.txtTipoTienda.Properties.ValueMember = "CODIGO"
        Me.txtTipoTienda.Size = New System.Drawing.Size(111, 20)
        Me.txtTipoTienda.TabIndex = 84
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
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Location = New System.Drawing.Point(698, 133)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl8.TabIndex = 79
        Me.LabelControl8.Text = "Tipo tienda:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = System.Drawing.Color.SteelBlue
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Image = CType(resources.GetObject("LabelControl2.Appearance.Image"), System.Drawing.Image)
        Me.LabelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl2.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelControl2.Size = New System.Drawing.Size(980, 35)
        Me.LabelControl2.TabIndex = 78
        Me.LabelControl2.Text = "      Tickets tiendas"
        '
        'txtEstado
        '
        Me.txtEstado.EditValue = "Todos"
        Me.txtEstado.Location = New System.Drawing.Point(562, 51)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEstado.Properties.Items.AddRange(New Object() {"Todos", "Pendientes", "Facturados"})
        Me.txtEstado.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtEstado.Size = New System.Drawing.Size(100, 20)
        Me.txtEstado.TabIndex = 61
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(519, 54)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 60
        Me.LabelControl3.Text = "Estado:"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.checkFechaVenta)
        Me.GroupControl3.Controls.Add(Me.txtFechaFin)
        Me.GroupControl3.Controls.Add(Me.txtFechaInicio)
        Me.GroupControl3.Controls.Add(Me.LabelControl7)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.txtEjercicio)
        Me.GroupControl3.Controls.Add(Me.txtMes)
        Me.GroupControl3.Controls.Add(Me.LabelControl5)
        Me.GroupControl3.Controls.Add(Me.LabelControl4)
        Me.GroupControl3.Controls.Add(Me.rgFecha)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 77)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(650, 73)
        Me.GroupControl3.TabIndex = 59
        Me.GroupControl3.Text = "Selección de fecha"
        '
        'checkFechaVenta
        '
        Me.checkFechaVenta.Location = New System.Drawing.Point(109, 1)
        Me.checkFechaVenta.MenuManager = Me.BarManager
        Me.checkFechaVenta.Name = "checkFechaVenta"
        Me.checkFechaVenta.Properties.AutoWidth = True
        Me.checkFechaVenta.Properties.Caption = "Fecha venta"
        Me.checkFechaVenta.Size = New System.Drawing.Size(82, 19)
        Me.checkFechaVenta.TabIndex = 85
        '
        'BarManager
        '
        Me.BarManager.AutoSaveInRegistry = True
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar3})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bttNuevo, Me.bttEditar, Me.bttBorrar, Me.bttImprimir, Me.bttFacturar, Me.bttGuardar})
        Me.BarManager.MaxItemId = 6
        Me.BarManager.StatusBar = Me.Bar3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Herramientas"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(40, 130)
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bttEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bttBorrar), New DevExpress.XtraBars.LinkPersistInfo(Me.bttGuardar)})
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Herramientas"
        '
        'bttEditar
        '
        Me.bttEditar.Caption = "Editar"
        Me.bttEditar.Glyph = CType(resources.GetObject("bttEditar.Glyph"), System.Drawing.Image)
        Me.bttEditar.Id = 1
        Me.bttEditar.LargeGlyph = CType(resources.GetObject("bttEditar.LargeGlyph"), System.Drawing.Image)
        Me.bttEditar.Name = "bttEditar"
        Me.bttEditar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.bttEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bttBorrar
        '
        Me.bttBorrar.Caption = "Borrar"
        Me.bttBorrar.Glyph = CType(resources.GetObject("bttBorrar.Glyph"), System.Drawing.Image)
        Me.bttBorrar.Id = 2
        Me.bttBorrar.LargeGlyph = CType(resources.GetObject("bttBorrar.LargeGlyph"), System.Drawing.Image)
        Me.bttBorrar.Name = "bttBorrar"
        Me.bttBorrar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.bttBorrar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bttGuardar
        '
        Me.bttGuardar.Caption = "Guardar"
        Me.bttGuardar.Glyph = CType(resources.GetObject("bttGuardar.Glyph"), System.Drawing.Image)
        Me.bttGuardar.Id = 5
        Me.bttGuardar.LargeGlyph = CType(resources.GetObject("bttGuardar.LargeGlyph"), System.Drawing.Image)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'Bar3
        '
        Me.Bar3.BarName = "Barra de estado"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Barra de estado"
        Me.Bar3.Visible = False
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(984, 31)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 539)
        Me.barDockControlBottom.Size = New System.Drawing.Size(984, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 31)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 508)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(984, 31)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 508)
        '
        'bttNuevo
        '
        Me.bttNuevo.Caption = "Nuevo"
        Me.bttNuevo.Glyph = CType(resources.GetObject("bttNuevo.Glyph"), System.Drawing.Image)
        Me.bttNuevo.Id = 0
        Me.bttNuevo.LargeGlyph = CType(resources.GetObject("bttNuevo.LargeGlyph"), System.Drawing.Image)
        Me.bttNuevo.Name = "bttNuevo"
        Me.bttNuevo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bttImprimir
        '
        Me.bttImprimir.Caption = "Imprimir"
        Me.bttImprimir.Glyph = CType(resources.GetObject("bttImprimir.Glyph"), System.Drawing.Image)
        Me.bttImprimir.Id = 3
        Me.bttImprimir.LargeGlyph = CType(resources.GetObject("bttImprimir.LargeGlyph"), System.Drawing.Image)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bttFacturar
        '
        Me.bttFacturar.Caption = "Facturar"
        Me.bttFacturar.Glyph = CType(resources.GetObject("bttFacturar.Glyph"), System.Drawing.Image)
        Me.bttFacturar.Id = 4
        Me.bttFacturar.LargeGlyph = CType(resources.GetObject("bttFacturar.LargeGlyph"), System.Drawing.Image)
        Me.bttFacturar.Name = "bttFacturar"
        Me.bttFacturar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
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
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(386, 50)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl5.TabIndex = 57
        Me.LabelControl5.Text = "Año:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(339, 27)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl4.TabIndex = 56
        Me.LabelControl4.Text = "Mes:"
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
        'txtDESCALM
        '
        Me.txtDESCALM.Location = New System.Drawing.Point(154, 51)
        Me.txtDESCALM.Name = "txtDESCALM"
        Me.txtDESCALM.Properties.ReadOnly = True
        Me.txtDESCALM.Size = New System.Drawing.Size(359, 20)
        Me.txtDESCALM.TabIndex = 57
        Me.txtDESCALM.TabStop = False
        '
        'txtCODALM
        '
        Me.txtCODALM.EditValue = ""
        Me.txtCODALM.EnterMoveNextControl = True
        Me.txtCODALM.Location = New System.Drawing.Point(55, 51)
        Me.txtCODALM.Name = "txtCODALM"
        Me.txtCODALM.Properties.AutoHeight = False
        Me.txtCODALM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtCODALM.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtCODALM.Size = New System.Drawing.Size(100, 20)
        Me.txtCODALM.TabIndex = 56
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 54)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl1.TabIndex = 55
        Me.LabelControl1.Text = "Tienda:"
        '
        'bttAplicar
        '
        Me.bttAplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttAplicar.Image = CType(resources.GetObject("bttAplicar.Image"), System.Drawing.Image)
        Me.bttAplicar.Location = New System.Drawing.Point(882, 126)
        Me.bttAplicar.Name = "bttAplicar"
        Me.bttAplicar.Size = New System.Drawing.Size(90, 28)
        Me.bttAplicar.TabIndex = 0
        Me.bttAplicar.Text = "(F5) Buscar"
        '
        'PopupMenu
        '
        Me.PopupMenu.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bttNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bttEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bttBorrar), New DevExpress.XtraBars.LinkPersistInfo(Me.bttImprimir)})
        Me.PopupMenu.Manager = Me.BarManager
        Me.PopupMenu.Name = "PopupMenu"
        '
        'fTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.gcVentas)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fTickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tickets tiendas"
        CType(Me.gvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskDESC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TiendasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkAlbaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linkFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcVentas.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtTipoTienda.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDATIPOSTIENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTiendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEstado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.checkFechaVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEjercicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDESCALM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCODALM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcVentas As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgTickets As DevExpress.XtraGrid.GridControl
    Friend WithEvents DsTickets As a3ERP_AydaraTPV.dsTickets
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEstado As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtFechaFin As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFechaInicio As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEjercicio As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtMes As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgFecha As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtDESCALM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCODALM As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttAplicar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TiendasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gvTickets As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTickets_NUMDOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTickets_FECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvLineas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTickets_CODCLI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTickets_NUMLINEAS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTickets_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents bttNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttBorrar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttFacturar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents colCODALM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCLIENTE_NOMCLI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALMACEN_TIPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALMACEN_DESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colALALBARAN_NUMDOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents linkAlbaran As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents colFACTURA_NUMDOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents linkFactura As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents colNUMLINEA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODPER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODART As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCLIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOTLIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRCMANUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROMO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents maskDESC As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents bttGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtTipoTienda As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents IDATIPOSTIENDABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTiendas As a3ERP_AydaraTPV.dsTiendas
    Friend WithEvents colFECCIERRE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents checkFechaVenta As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents colTOTPUNTOS As DevExpress.XtraGrid.Columns.GridColumn
End Class
