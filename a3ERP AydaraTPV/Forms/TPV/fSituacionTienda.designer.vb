<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fSituacionTienda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fSituacionTienda))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.dgSituacion = New DevExpress.XtraGrid.GridControl()
        Me.IDACAJASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsFacturacion = New a3ERP_AydaraTPV.dsFacturacion()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colCodigoCaja = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colTickets = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colLineas = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colEfectivo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colTalon = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colTarjeta = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colValesEmitidos = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colValesCobrados = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colValesProveedor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colEnvases = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colPendienteCobro = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colCobrosCliente = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colPagosProveedor = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colNUMALBARANES = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colTOTALBARANES = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colEntradaCambios = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colRetiradaFondos = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colRepartoDomicilio = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colVENTATICKETS = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colVenta = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.panelImprimir = New DevExpress.XtraEditors.PanelControl()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.IDA_CAJASTableAdapter = New a3ERP_AydaraTPV.dsFacturacionTableAdapters.IDA_CAJASTableAdapter()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDESCALM = New DevExpress.XtraEditors.TextEdit()
        Me.txtCODALM = New DevExpress.XtraEditors.ButtonEdit()
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
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.colTOTFACTURAS = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.colNUMFACTURAS = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.layoutViewField_colCodigoCaja = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colTickets = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colLineas = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colEfectivo = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colTalon = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colTarjeta = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colValesEmitidos = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colValesCobrados = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colValesProveedor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colEnvases = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colPendienteCobro = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colCobrosCliente = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colPagosProveedor = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colEntradaCambios = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colRetiradaFondos = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_colVenta = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.item1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.item2 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.layoutViewField_LayoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_LayoutViewColumn1_1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_LayoutViewColumn1_2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_LayoutViewColumn1_3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_LayoutViewColumn2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.layoutViewField_LayoutViewColumn1_4 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        CType(Me.dgSituacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDACAJASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsFacturacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImprimir.SuspendLayout()
        CType(Me.txtDESCALM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCODALM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtFechaFin.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEjercicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colCodigoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colEfectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colTalon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colTarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colValesEmitidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colValesCobrados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colValesProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colEnvases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPendienteCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colCobrosCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colPagosProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colEntradaCambios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colRetiradaFondos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.item2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgSituacion
        '
        Me.dgSituacion.DataSource = Me.IDACAJASBindingSource
        Me.dgSituacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgSituacion.Location = New System.Drawing.Point(0, 126)
        Me.dgSituacion.MainView = Me.LayoutView1
        Me.dgSituacion.Name = "dgSituacion"
        Me.dgSituacion.Size = New System.Drawing.Size(784, 418)
        Me.dgSituacion.TabIndex = 0
        Me.dgSituacion.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.LayoutView1})
        '
        'IDACAJASBindingSource
        '
        Me.IDACAJASBindingSource.DataMember = "IDA_CAJAS"
        Me.IDACAJASBindingSource.DataSource = Me.DsFacturacion
        '
        'DsFacturacion
        '
        Me.DsFacturacion.DataSetName = "dsFacturacion"
        Me.DsFacturacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LayoutView1
        '
        Me.LayoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colCodigoCaja, Me.colTickets, Me.colLineas, Me.colEfectivo, Me.colTalon, Me.colTarjeta, Me.colValesEmitidos, Me.colValesCobrados, Me.colValesProveedor, Me.colEnvases, Me.colPendienteCobro, Me.colCobrosCliente, Me.colPagosProveedor, Me.colNUMALBARANES, Me.colTOTALBARANES, Me.colNUMFACTURAS, Me.colTOTFACTURAS, Me.colEntradaCambios, Me.colRetiradaFondos, Me.colRepartoDomicilio, Me.colVENTATICKETS, Me.colVenta})
        Me.LayoutView1.GridControl = Me.dgSituacion
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.OptionsBehavior.Editable = False
        Me.LayoutView1.OptionsCustomization.AllowFilter = False
        Me.LayoutView1.OptionsCustomization.AllowSort = False
        Me.LayoutView1.OptionsPrint.PrintCardCaption = False
        Me.LayoutView1.OptionsView.ShowCardCaption = False
        Me.LayoutView1.OptionsView.ShowCardExpandButton = False
        Me.LayoutView1.OptionsView.ShowHeaderPanel = False
        Me.LayoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
        Me.LayoutView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCodigoCaja, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.LayoutView1.TemplateCard = Me.LayoutViewCard1
        '
        'colCodigoCaja
        '
        Me.colCodigoCaja.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.colCodigoCaja.AppearanceCell.Options.UseFont = True
        Me.colCodigoCaja.AppearanceCell.Options.UseTextOptions = True
        Me.colCodigoCaja.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCodigoCaja.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.colCodigoCaja.AppearanceHeader.Options.UseFont = True
        Me.colCodigoCaja.Caption = "Caja"
        Me.colCodigoCaja.FieldName = "CAJA"
        Me.colCodigoCaja.LayoutViewField = Me.layoutViewField_colCodigoCaja
        Me.colCodigoCaja.Name = "colCodigoCaja"
        '
        'colTickets
        '
        Me.colTickets.Caption = "Tickets"
        Me.colTickets.FieldName = "TICKETS"
        Me.colTickets.LayoutViewField = Me.layoutViewField_colTickets
        Me.colTickets.Name = "colTickets"
        '
        'colLineas
        '
        Me.colLineas.Caption = "Líneas"
        Me.colLineas.FieldName = "LINEAS"
        Me.colLineas.LayoutViewField = Me.layoutViewField_colLineas
        Me.colLineas.Name = "colLineas"
        '
        'colEfectivo
        '
        Me.colEfectivo.Caption = "Efectivo"
        Me.colEfectivo.DisplayFormat.FormatString = "{0:c2}"
        Me.colEfectivo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEfectivo.FieldName = "EFECTIVO"
        Me.colEfectivo.LayoutViewField = Me.layoutViewField_colEfectivo
        Me.colEfectivo.Name = "colEfectivo"
        '
        'colTalon
        '
        Me.colTalon.Caption = "Talón"
        Me.colTalon.DisplayFormat.FormatString = "{0:c2}"
        Me.colTalon.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTalon.FieldName = "TALON"
        Me.colTalon.LayoutViewField = Me.layoutViewField_colTalon
        Me.colTalon.Name = "colTalon"
        '
        'colTarjeta
        '
        Me.colTarjeta.Caption = "Tarjeta"
        Me.colTarjeta.DisplayFormat.FormatString = "{0:c2}"
        Me.colTarjeta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTarjeta.FieldName = "TARJETA"
        Me.colTarjeta.LayoutViewField = Me.layoutViewField_colTarjeta
        Me.colTarjeta.Name = "colTarjeta"
        '
        'colValesEmitidos
        '
        Me.colValesEmitidos.Caption = "Vales propios"
        Me.colValesEmitidos.DisplayFormat.FormatString = "{0:c2}"
        Me.colValesEmitidos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValesEmitidos.FieldName = "VALESEMITIDOS"
        Me.colValesEmitidos.LayoutViewField = Me.layoutViewField_colValesEmitidos
        Me.colValesEmitidos.Name = "colValesEmitidos"
        '
        'colValesCobrados
        '
        Me.colValesCobrados.Caption = "Vales cobrados"
        Me.colValesCobrados.DisplayFormat.FormatString = "{0:c2}"
        Me.colValesCobrados.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValesCobrados.FieldName = "VALESCOBRADOS"
        Me.colValesCobrados.LayoutViewField = Me.layoutViewField_colValesCobrados
        Me.colValesCobrados.Name = "colValesCobrados"
        '
        'colValesProveedor
        '
        Me.colValesProveedor.Caption = "Vales proveedor"
        Me.colValesProveedor.DisplayFormat.FormatString = "{0:c2}"
        Me.colValesProveedor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colValesProveedor.FieldName = "VALESPROVEEDOR"
        Me.colValesProveedor.LayoutViewField = Me.layoutViewField_colValesProveedor
        Me.colValesProveedor.Name = "colValesProveedor"
        '
        'colEnvases
        '
        Me.colEnvases.Caption = "Envases"
        Me.colEnvases.DisplayFormat.FormatString = "{0:c2}"
        Me.colEnvases.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEnvases.FieldName = "ENVASES"
        Me.colEnvases.LayoutViewField = Me.layoutViewField_colEnvases
        Me.colEnvases.Name = "colEnvases"
        '
        'colPendienteCobro
        '
        Me.colPendienteCobro.Caption = "Pendiente de cobro"
        Me.colPendienteCobro.DisplayFormat.FormatString = "{0:c2}"
        Me.colPendienteCobro.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPendienteCobro.FieldName = "PENDIENTECOBRO"
        Me.colPendienteCobro.LayoutViewField = Me.layoutViewField_colPendienteCobro
        Me.colPendienteCobro.Name = "colPendienteCobro"
        '
        'colCobrosCliente
        '
        Me.colCobrosCliente.Caption = "Cobros a cliente"
        Me.colCobrosCliente.DisplayFormat.FormatString = "{0:c2}"
        Me.colCobrosCliente.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCobrosCliente.FieldName = "COBROSCLIENTE"
        Me.colCobrosCliente.LayoutViewField = Me.layoutViewField_colCobrosCliente
        Me.colCobrosCliente.Name = "colCobrosCliente"
        '
        'colPagosProveedor
        '
        Me.colPagosProveedor.Caption = "Pagos a proveedor"
        Me.colPagosProveedor.DisplayFormat.FormatString = "{0:c2}"
        Me.colPagosProveedor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPagosProveedor.FieldName = "PAGOSPROVEEDOR"
        Me.colPagosProveedor.LayoutViewField = Me.layoutViewField_colPagosProveedor
        Me.colPagosProveedor.Name = "colPagosProveedor"
        '
        'colNUMALBARANES
        '
        Me.colNUMALBARANES.Caption = "Nº de albaranes"
        Me.colNUMALBARANES.FieldName = "NUMALBARANES"
        Me.colNUMALBARANES.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_1
        Me.colNUMALBARANES.Name = "colNUMALBARANES"
        '
        'colTOTALBARANES
        '
        Me.colTOTALBARANES.Caption = "Total albaranes"
        Me.colTOTALBARANES.DisplayFormat.FormatString = "{0:c2}"
        Me.colTOTALBARANES.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOTALBARANES.FieldName = "TOTALBARANES"
        Me.colTOTALBARANES.LayoutViewField = Me.layoutViewField_LayoutViewColumn1
        Me.colTOTALBARANES.Name = "colTOTALBARANES"
        '
        'colEntradaCambios
        '
        Me.colEntradaCambios.Caption = "Entrada de cambios"
        Me.colEntradaCambios.DisplayFormat.FormatString = "{0:c2}"
        Me.colEntradaCambios.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEntradaCambios.FieldName = "ENTRADACAMBIOS"
        Me.colEntradaCambios.LayoutViewField = Me.layoutViewField_colEntradaCambios
        Me.colEntradaCambios.Name = "colEntradaCambios"
        '
        'colRetiradaFondos
        '
        Me.colRetiradaFondos.Caption = "Retirada de fondos"
        Me.colRetiradaFondos.DisplayFormat.FormatString = "{0:c2}"
        Me.colRetiradaFondos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRetiradaFondos.FieldName = "RETIRADAFONDOS"
        Me.colRetiradaFondos.LayoutViewField = Me.layoutViewField_colRetiradaFondos
        Me.colRetiradaFondos.Name = "colRetiradaFondos"
        '
        'colRepartoDomicilio
        '
        Me.colRepartoDomicilio.Caption = "Reparto a domicilio"
        Me.colRepartoDomicilio.FieldName = "REPARTODOMICILIO"
        Me.colRepartoDomicilio.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_2
        Me.colRepartoDomicilio.Name = "colRepartoDomicilio"
        '
        'colVENTATICKETS
        '
        Me.colVENTATICKETS.Caption = "Venta tickets"
        Me.colVENTATICKETS.DisplayFormat.FormatString = "{0:c2}"
        Me.colVENTATICKETS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVENTATICKETS.FieldName = "VENTATICKETS"
        Me.colVENTATICKETS.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_3
        Me.colVENTATICKETS.Name = "colVENTATICKETS"
        '
        'colVenta
        '
        Me.colVenta.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.colVenta.AppearanceCell.Options.UseFont = True
        Me.colVenta.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.colVenta.AppearanceHeader.Options.UseFont = True
        Me.colVenta.Caption = "Venta"
        Me.colVenta.DisplayFormat.FormatString = "{0:c2}"
        Me.colVenta.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVenta.FieldName = "VENTA"
        Me.colVenta.LayoutViewField = Me.layoutViewField_colVenta
        Me.colVenta.Name = "colVenta"
        '
        'panelImprimir
        '
        Me.panelImprimir.Controls.Add(Me.bttImprimir)
        Me.panelImprimir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelImprimir.Location = New System.Drawing.Point(0, 544)
        Me.panelImprimir.Name = "panelImprimir"
        Me.panelImprimir.Size = New System.Drawing.Size(784, 58)
        Me.panelImprimir.TabIndex = 2
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Image = CType(resources.GetObject("bttImprimir.Image"), System.Drawing.Image)
        Me.bttImprimir.Location = New System.Drawing.Point(655, 15)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(117, 31)
        Me.bttImprimir.TabIndex = 0
        Me.bttImprimir.Text = "Imprimir listado"
        '
        'IDA_CAJASTableAdapter
        '
        Me.IDA_CAJASTableAdapter.ClearBeforeFill = True
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
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Tienda:"
        '
        'txtDESCALM
        '
        Me.txtDESCALM.Location = New System.Drawing.Point(178, 12)
        Me.txtDESCALM.Name = "txtDESCALM"
        Me.txtDESCALM.Properties.ReadOnly = True
        Me.txtDESCALM.Size = New System.Drawing.Size(302, 20)
        Me.txtDESCALM.TabIndex = 1
        Me.txtDESCALM.TabStop = False
        '
        'txtCODALM
        '
        Me.txtCODALM.EnterMoveNextControl = True
        Me.txtCODALM.Location = New System.Drawing.Point(79, 12)
        Me.txtCODALM.Name = "txtCODALM"
        Me.txtCODALM.Properties.AutoHeight = False
        Me.txtCODALM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtCODALM.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtCODALM.Size = New System.Drawing.Size(100, 20)
        Me.txtCODALM.TabIndex = 0
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
        'PanelControl1
        '
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
        'colTOTFACTURAS
        '
        Me.colTOTFACTURAS.Caption = "Total facturas"
        Me.colTOTFACTURAS.DisplayFormat.FormatString = "{0:c2}"
        Me.colTOTFACTURAS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTOTFACTURAS.FieldName = "TOTFACTURAS"
        Me.colTOTFACTURAS.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_4
        Me.colTOTFACTURAS.Name = "colTOTFACTURAS"
        '
        'colNUMFACTURAS
        '
        Me.colNUMFACTURAS.Caption = "Nº de facturas"
        Me.colNUMFACTURAS.FieldName = "NUMFACTURAS"
        Me.colNUMFACTURAS.LayoutViewField = Me.layoutViewField_LayoutViewColumn2
        Me.colNUMFACTURAS.Name = "colNUMFACTURAS"
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.GroupBordersVisible = False
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colCodigoCaja, Me.layoutViewField_colTickets, Me.layoutViewField_colLineas, Me.layoutViewField_colEfectivo, Me.layoutViewField_colTalon, Me.layoutViewField_colTarjeta, Me.layoutViewField_colValesEmitidos, Me.layoutViewField_colValesCobrados, Me.layoutViewField_colValesProveedor, Me.layoutViewField_colEnvases, Me.layoutViewField_colPendienteCobro, Me.layoutViewField_colCobrosCliente, Me.layoutViewField_colPagosProveedor, Me.layoutViewField_colEntradaCambios, Me.layoutViewField_colRetiradaFondos, Me.layoutViewField_colVenta, Me.item1, Me.item2, Me.layoutViewField_LayoutViewColumn1, Me.layoutViewField_LayoutViewColumn1_1, Me.layoutViewField_LayoutViewColumn1_2, Me.layoutViewField_LayoutViewColumn1_3, Me.layoutViewField_LayoutViewColumn2, Me.layoutViewField_LayoutViewColumn1_4})
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 5
        Me.LayoutViewCard1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'layoutViewField_colCodigoCaja
        '
        Me.layoutViewField_colCodigoCaja.EditorPreferredWidth = 203
        Me.layoutViewField_colCodigoCaja.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colCodigoCaja.Name = "layoutViewField_colCodigoCaja"
        Me.layoutViewField_colCodigoCaja.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colCodigoCaja.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colCodigoCaja.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colCodigoCaja.TextToControlDistance = 0
        Me.layoutViewField_colCodigoCaja.TextVisible = False
        '
        'layoutViewField_colTickets
        '
        Me.layoutViewField_colTickets.EditorPreferredWidth = 100
        Me.layoutViewField_colTickets.Location = New System.Drawing.Point(0, 34)
        Me.layoutViewField_colTickets.Name = "layoutViewField_colTickets"
        Me.layoutViewField_colTickets.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colTickets.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colTickets.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colTickets.TextToControlDistance = 5
        '
        'layoutViewField_colLineas
        '
        Me.layoutViewField_colLineas.EditorPreferredWidth = 100
        Me.layoutViewField_colLineas.Location = New System.Drawing.Point(0, 62)
        Me.layoutViewField_colLineas.Name = "layoutViewField_colLineas"
        Me.layoutViewField_colLineas.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colLineas.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colLineas.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colLineas.TextToControlDistance = 5
        '
        'layoutViewField_colEfectivo
        '
        Me.layoutViewField_colEfectivo.EditorPreferredWidth = 100
        Me.layoutViewField_colEfectivo.Location = New System.Drawing.Point(0, 90)
        Me.layoutViewField_colEfectivo.Name = "layoutViewField_colEfectivo"
        Me.layoutViewField_colEfectivo.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colEfectivo.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colEfectivo.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colEfectivo.TextToControlDistance = 5
        '
        'layoutViewField_colTalon
        '
        Me.layoutViewField_colTalon.EditorPreferredWidth = 100
        Me.layoutViewField_colTalon.Location = New System.Drawing.Point(0, 118)
        Me.layoutViewField_colTalon.Name = "layoutViewField_colTalon"
        Me.layoutViewField_colTalon.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colTalon.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colTalon.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colTalon.TextToControlDistance = 5
        '
        'layoutViewField_colTarjeta
        '
        Me.layoutViewField_colTarjeta.EditorPreferredWidth = 100
        Me.layoutViewField_colTarjeta.Location = New System.Drawing.Point(0, 146)
        Me.layoutViewField_colTarjeta.Name = "layoutViewField_colTarjeta"
        Me.layoutViewField_colTarjeta.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colTarjeta.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colTarjeta.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colTarjeta.TextToControlDistance = 5
        '
        'layoutViewField_colValesEmitidos
        '
        Me.layoutViewField_colValesEmitidos.EditorPreferredWidth = 100
        Me.layoutViewField_colValesEmitidos.Location = New System.Drawing.Point(0, 174)
        Me.layoutViewField_colValesEmitidos.Name = "layoutViewField_colValesEmitidos"
        Me.layoutViewField_colValesEmitidos.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colValesEmitidos.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colValesEmitidos.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colValesEmitidos.TextToControlDistance = 5
        '
        'layoutViewField_colValesCobrados
        '
        Me.layoutViewField_colValesCobrados.EditorPreferredWidth = 100
        Me.layoutViewField_colValesCobrados.Location = New System.Drawing.Point(0, 202)
        Me.layoutViewField_colValesCobrados.Name = "layoutViewField_colValesCobrados"
        Me.layoutViewField_colValesCobrados.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colValesCobrados.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colValesCobrados.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colValesCobrados.TextToControlDistance = 5
        '
        'layoutViewField_colValesProveedor
        '
        Me.layoutViewField_colValesProveedor.EditorPreferredWidth = 100
        Me.layoutViewField_colValesProveedor.Location = New System.Drawing.Point(0, 230)
        Me.layoutViewField_colValesProveedor.Name = "layoutViewField_colValesProveedor"
        Me.layoutViewField_colValesProveedor.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colValesProveedor.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colValesProveedor.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colValesProveedor.TextToControlDistance = 5
        '
        'layoutViewField_colEnvases
        '
        Me.layoutViewField_colEnvases.EditorPreferredWidth = 100
        Me.layoutViewField_colEnvases.Location = New System.Drawing.Point(0, 258)
        Me.layoutViewField_colEnvases.Name = "layoutViewField_colEnvases"
        Me.layoutViewField_colEnvases.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colEnvases.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colEnvases.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colEnvases.TextToControlDistance = 5
        '
        'layoutViewField_colPendienteCobro
        '
        Me.layoutViewField_colPendienteCobro.EditorPreferredWidth = 100
        Me.layoutViewField_colPendienteCobro.Location = New System.Drawing.Point(0, 286)
        Me.layoutViewField_colPendienteCobro.Name = "layoutViewField_colPendienteCobro"
        Me.layoutViewField_colPendienteCobro.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colPendienteCobro.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colPendienteCobro.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colPendienteCobro.TextToControlDistance = 5
        '
        'layoutViewField_colCobrosCliente
        '
        Me.layoutViewField_colCobrosCliente.EditorPreferredWidth = 100
        Me.layoutViewField_colCobrosCliente.Location = New System.Drawing.Point(0, 314)
        Me.layoutViewField_colCobrosCliente.Name = "layoutViewField_colCobrosCliente"
        Me.layoutViewField_colCobrosCliente.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colCobrosCliente.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colCobrosCliente.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colCobrosCliente.TextToControlDistance = 5
        '
        'layoutViewField_colPagosProveedor
        '
        Me.layoutViewField_colPagosProveedor.EditorPreferredWidth = 100
        Me.layoutViewField_colPagosProveedor.Location = New System.Drawing.Point(0, 342)
        Me.layoutViewField_colPagosProveedor.Name = "layoutViewField_colPagosProveedor"
        Me.layoutViewField_colPagosProveedor.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colPagosProveedor.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colPagosProveedor.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colPagosProveedor.TextToControlDistance = 5
        '
        'layoutViewField_colEntradaCambios
        '
        Me.layoutViewField_colEntradaCambios.EditorPreferredWidth = 100
        Me.layoutViewField_colEntradaCambios.Location = New System.Drawing.Point(0, 466)
        Me.layoutViewField_colEntradaCambios.Name = "layoutViewField_colEntradaCambios"
        Me.layoutViewField_colEntradaCambios.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colEntradaCambios.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colEntradaCambios.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colEntradaCambios.TextToControlDistance = 5
        '
        'layoutViewField_colRetiradaFondos
        '
        Me.layoutViewField_colRetiradaFondos.EditorPreferredWidth = 100
        Me.layoutViewField_colRetiradaFondos.Location = New System.Drawing.Point(0, 494)
        Me.layoutViewField_colRetiradaFondos.Name = "layoutViewField_colRetiradaFondos"
        Me.layoutViewField_colRetiradaFondos.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colRetiradaFondos.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colRetiradaFondos.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colRetiradaFondos.TextToControlDistance = 5
        '
        'layoutViewField_colVenta
        '
        Me.layoutViewField_colVenta.EditorPreferredWidth = 100
        Me.layoutViewField_colVenta.Location = New System.Drawing.Point(0, 576)
        Me.layoutViewField_colVenta.Name = "layoutViewField_colVenta"
        Me.layoutViewField_colVenta.Size = New System.Drawing.Size(211, 28)
        Me.layoutViewField_colVenta.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.layoutViewField_colVenta.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_colVenta.TextToControlDistance = 5
        '
        'item1
        '
        Me.item1.AllowHotTrack = False
        Me.item1.CustomizationFormText = "item1"
        Me.item1.Location = New System.Drawing.Point(0, 28)
        Me.item1.Name = "item1"
        Me.item1.Size = New System.Drawing.Size(211, 6)
        Me.item1.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.item1.Text = "item1"
        '
        'item2
        '
        Me.item2.AllowHotTrack = False
        Me.item2.CustomizationFormText = "item2"
        Me.item2.Location = New System.Drawing.Point(0, 546)
        Me.item2.Name = "item2"
        Me.item2.Size = New System.Drawing.Size(211, 6)
        Me.item2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.item2.Text = "item2"
        '
        'layoutViewField_LayoutViewColumn1
        '
        Me.layoutViewField_LayoutViewColumn1.EditorPreferredWidth = 104
        Me.layoutViewField_LayoutViewColumn1.Location = New System.Drawing.Point(0, 394)
        Me.layoutViewField_LayoutViewColumn1.Name = "layoutViewField_LayoutViewColumn1"
        Me.layoutViewField_LayoutViewColumn1.Size = New System.Drawing.Size(211, 24)
        Me.layoutViewField_LayoutViewColumn1.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_LayoutViewColumn1.TextToControlDistance = 5
        '
        'layoutViewField_LayoutViewColumn1_1
        '
        Me.layoutViewField_LayoutViewColumn1_1.EditorPreferredWidth = 104
        Me.layoutViewField_LayoutViewColumn1_1.Location = New System.Drawing.Point(0, 370)
        Me.layoutViewField_LayoutViewColumn1_1.Name = "layoutViewField_LayoutViewColumn1_1"
        Me.layoutViewField_LayoutViewColumn1_1.Size = New System.Drawing.Size(211, 24)
        Me.layoutViewField_LayoutViewColumn1_1.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_LayoutViewColumn1_1.TextToControlDistance = 5
        '
        'layoutViewField_LayoutViewColumn1_2
        '
        Me.layoutViewField_LayoutViewColumn1_2.EditorPreferredWidth = 104
        Me.layoutViewField_LayoutViewColumn1_2.Location = New System.Drawing.Point(0, 522)
        Me.layoutViewField_LayoutViewColumn1_2.Name = "layoutViewField_LayoutViewColumn1_2"
        Me.layoutViewField_LayoutViewColumn1_2.Size = New System.Drawing.Size(211, 24)
        Me.layoutViewField_LayoutViewColumn1_2.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_LayoutViewColumn1_2.TextToControlDistance = 5
        '
        'layoutViewField_LayoutViewColumn1_3
        '
        Me.layoutViewField_LayoutViewColumn1_3.EditorPreferredWidth = 104
        Me.layoutViewField_LayoutViewColumn1_3.Location = New System.Drawing.Point(0, 552)
        Me.layoutViewField_LayoutViewColumn1_3.Name = "layoutViewField_LayoutViewColumn1_3"
        Me.layoutViewField_LayoutViewColumn1_3.Size = New System.Drawing.Size(211, 24)
        Me.layoutViewField_LayoutViewColumn1_3.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_LayoutViewColumn1_3.TextToControlDistance = 5
        '
        'layoutViewField_LayoutViewColumn2
        '
        Me.layoutViewField_LayoutViewColumn2.EditorPreferredWidth = 104
        Me.layoutViewField_LayoutViewColumn2.Location = New System.Drawing.Point(0, 418)
        Me.layoutViewField_LayoutViewColumn2.Name = "layoutViewField_LayoutViewColumn2"
        Me.layoutViewField_LayoutViewColumn2.Size = New System.Drawing.Size(211, 24)
        Me.layoutViewField_LayoutViewColumn2.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_LayoutViewColumn2.TextToControlDistance = 5
        '
        'layoutViewField_LayoutViewColumn1_4
        '
        Me.layoutViewField_LayoutViewColumn1_4.EditorPreferredWidth = 104
        Me.layoutViewField_LayoutViewColumn1_4.Location = New System.Drawing.Point(0, 442)
        Me.layoutViewField_LayoutViewColumn1_4.Name = "layoutViewField_LayoutViewColumn1_4"
        Me.layoutViewField_LayoutViewColumn1_4.Size = New System.Drawing.Size(211, 24)
        Me.layoutViewField_LayoutViewColumn1_4.TextSize = New System.Drawing.Size(98, 13)
        Me.layoutViewField_LayoutViewColumn1_4.TextToControlDistance = 5
        '
        'fSituacionTienda
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 602)
        Me.Controls.Add(Me.dgSituacion)
        Me.Controls.Add(Me.panelImprimir)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "fSituacionTienda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Situación de la tienda"
        CType(Me.dgSituacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDACAJASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsFacturacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImprimir.ResumeLayout(False)
        CType(Me.txtDESCALM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCODALM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colCodigoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colEfectivo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colTalon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colTarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colValesEmitidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colValesCobrados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colValesProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colEnvases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPendienteCobro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colCobrosCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colPagosProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colEntradaCambios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colRetiradaFondos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.item2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgSituacion As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents colCodigoCaja As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colTickets As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colLineas As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colEfectivo As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colTalon As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colTarjeta As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colValesEmitidos As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colValesCobrados As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colValesProveedor As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colEnvases As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPendienteCobro As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colCobrosCliente As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colPagosProveedor As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colEntradaCambios As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colRetiradaFondos As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colVenta As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colTOTALBARANES As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents panelImprimir As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colNUMALBARANES As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colRepartoDomicilio As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colVENTATICKETS As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents IDACAJASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsFacturacion As a3ERP_AydaraTPV.dsFacturacion
    Friend WithEvents IDA_CAJASTableAdapter As a3ERP_AydaraTPV.dsFacturacionTableAdapters.IDA_CAJASTableAdapter
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDESCALM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCODALM As DevExpress.XtraEditors.ButtonEdit
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
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colNUMFACTURAS As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colTOTFACTURAS As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents layoutViewField_colCodigoCaja As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colTickets As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colLineas As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colEfectivo As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colTalon As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colTarjeta As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colValesEmitidos As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colValesCobrados As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colValesProveedor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colEnvases As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPendienteCobro As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colCobrosCliente As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colPagosProveedor As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1_1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1_4 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colEntradaCambios As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colRetiradaFondos As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1_2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1_3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colVenta As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents item1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents item2 As DevExpress.XtraLayout.SimpleSeparator
End Class
