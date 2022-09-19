<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fTicket
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fTicket))
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.txtTITULO = New DevExpress.XtraEditors.LabelControl()
        Me.IDATICKETSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTickets = New a3ERP_AydaraTPV.dsTickets()
        Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.bttGuardar = New DevExpress.XtraBars.BarButtonItem()
        Me.bttCancelar = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.bttNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bttImprimir = New DevExpress.XtraBars.BarButtonItem()
        Me.bttPlantilla = New DevExpress.XtraBars.BarButtonItem()
        Me.bttServir = New DevExpress.XtraBars.BarButtonItem()
        Me.bttFichaCliente = New DevExpress.XtraBars.BarButtonItem()
        Me.bttCartera = New DevExpress.XtraBars.BarButtonItem()
        Me.bttEstadisticasComparativas = New DevExpress.XtraBars.BarButtonItem()
        Me.bttEstadisticasAnalitica = New DevExpress.XtraBars.BarButtonItem()
        Me.bttSuministros = New DevExpress.XtraBars.BarButtonItem()
        Me.bttSituacionPedidos = New DevExpress.XtraBars.BarButtonItem()
        Me.bttSituacionAlbaranes = New DevExpress.XtraBars.BarButtonItem()
        Me.bttPromociones = New DevExpress.XtraBars.BarButtonItem()
        Me.bttClienteNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bttClienteEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bttClienteTodos = New DevExpress.XtraBars.BarButtonItem()
        Me.bttClienteBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.bttEnvases = New DevExpress.XtraBars.BarButtonItem()
        Me.gcCabecera = New DevExpress.XtraEditors.GroupControl()
        Me.txtNOMCLI = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCODCLI = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFECHA = New DevExpress.XtraEditors.DateEdit()
        Me.txtNUMDOC = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCODALM = New DevExpress.XtraEditors.LookUpEdit()
        Me.ALMACENBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsAlmacenes = New a3ERP_AydaraTPV.dsAlmacenes()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.gcLineas = New DevExpress.XtraEditors.GroupControl()
        Me.dgLineas = New DevExpress.XtraGrid.GridControl()
        Me.IDATICKETSLINEASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvLineas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCANTIDAD = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODART = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODPER = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCLIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUMLINEA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRCMANUAL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRECIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROMO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPIVA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTOTLIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskObservaciones = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.bttCODART = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.maskUNIDADES = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.maskPRECIO = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.maskDESC = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.bttREFERENCIA = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.bttCODPRO = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.cmbTipoIVA = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
        Me.RepositoryItemGridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ControlNavigator = New DevExpress.XtraEditors.ControlNavigator()
        CType(Me.IDATICKETSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcCabecera.SuspendLayout()
        CType(Me.txtNOMCLI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCODCLI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFECHA.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFECHA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNUMDOC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCODALM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALMACENBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcLineas.SuspendLayout()
        CType(Me.dgLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDATICKETSLINEASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttCODART, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskUNIDADES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPRECIO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskDESC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttREFERENCIA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttCODPRO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoIVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTITULO
        '
        Me.txtTITULO.Appearance.BackColor = System.Drawing.Color.SteelBlue
        Me.txtTITULO.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTITULO.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtTITULO.Appearance.Image = CType(resources.GetObject("txtTITULO.Appearance.Image"), System.Drawing.Image)
        Me.txtTITULO.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtTITULO.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.txtTITULO.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtTITULO.Location = New System.Drawing.Point(0, 0)
        Me.txtTITULO.Name = "txtTITULO"
        Me.txtTITULO.Padding = New System.Windows.Forms.Padding(3)
        Me.txtTITULO.Size = New System.Drawing.Size(784, 35)
        Me.txtTITULO.TabIndex = 96
        Me.txtTITULO.Text = "      Ticket de venta"
        '
        'IDATICKETSBindingSource
        '
        Me.IDATICKETSBindingSource.DataMember = "IDA_TICKETS"
        Me.IDATICKETSBindingSource.DataSource = Me.DsTickets
        '
        'DsTickets
        '
        Me.DsTickets.DataSetName = "dsTickets"
        Me.DsTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BarManager
        '
        Me.BarManager.AutoSaveInRegistry = True
        Me.BarManager.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3})
        Me.BarManager.DockControls.Add(Me.barDockControlTop)
        Me.BarManager.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager.DockControls.Add(Me.barDockControlRight)
        Me.BarManager.Form = Me
        Me.BarManager.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bttGuardar, Me.bttCancelar, Me.bttNuevo, Me.bttImprimir, Me.bttPlantilla, Me.bttServir, Me.bttFichaCliente, Me.bttCartera, Me.bttEstadisticasComparativas, Me.bttEstadisticasAnalitica, Me.bttSuministros, Me.bttSituacionPedidos, Me.bttSituacionAlbaranes, Me.bttPromociones, Me.bttClienteNuevo, Me.bttClienteEditar, Me.bttClienteTodos, Me.bttClienteBuscar, Me.bttEnvases})
        Me.BarManager.MaxItemId = 26
        Me.BarManager.StatusBar = Me.Bar3
        '
        'Bar3
        '
        Me.Bar3.BarName = "Barra de estado"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bttGuardar), New DevExpress.XtraBars.LinkPersistInfo(Me.bttCancelar)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Barra de estado"
        '
        'bttGuardar
        '
        Me.bttGuardar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bttGuardar.Caption = "Guardar"
        Me.bttGuardar.Enabled = False
        Me.bttGuardar.Glyph = CType(resources.GetObject("bttGuardar.Glyph"), System.Drawing.Image)
        Me.bttGuardar.Id = 3
        Me.bttGuardar.LargeGlyph = CType(resources.GetObject("bttGuardar.LargeGlyph"), System.Drawing.Image)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bttCancelar
        '
        Me.bttCancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bttCancelar.Caption = "Cancelar"
        Me.bttCancelar.Enabled = False
        Me.bttCancelar.Glyph = CType(resources.GetObject("bttCancelar.Glyph"), System.Drawing.Image)
        Me.bttCancelar.Id = 5
        Me.bttCancelar.LargeGlyph = CType(resources.GetObject("bttCancelar.LargeGlyph"), System.Drawing.Image)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 535)
        Me.barDockControlBottom.Size = New System.Drawing.Size(784, 27)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 535)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(784, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 535)
        '
        'bttNuevo
        '
        Me.bttNuevo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bttNuevo.Caption = "Nuevo"
        Me.bttNuevo.Glyph = CType(resources.GetObject("bttNuevo.Glyph"), System.Drawing.Image)
        Me.bttNuevo.Id = 8
        Me.bttNuevo.LargeGlyph = CType(resources.GetObject("bttNuevo.LargeGlyph"), System.Drawing.Image)
        Me.bttNuevo.Name = "bttNuevo"
        Me.bttNuevo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bttImprimir
        '
        Me.bttImprimir.Caption = "Imprimir"
        Me.bttImprimir.Glyph = CType(resources.GetObject("bttImprimir.Glyph"), System.Drawing.Image)
        Me.bttImprimir.Id = 9
        Me.bttImprimir.LargeGlyph = CType(resources.GetObject("bttImprimir.LargeGlyph"), System.Drawing.Image)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bttPlantilla
        '
        Me.bttPlantilla.Caption = "Plantilla"
        Me.bttPlantilla.Glyph = CType(resources.GetObject("bttPlantilla.Glyph"), System.Drawing.Image)
        Me.bttPlantilla.Id = 10
        Me.bttPlantilla.LargeGlyph = CType(resources.GetObject("bttPlantilla.LargeGlyph"), System.Drawing.Image)
        Me.bttPlantilla.Name = "bttPlantilla"
        Me.bttPlantilla.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bttServir
        '
        Me.bttServir.Caption = "Servir pedidos"
        Me.bttServir.Glyph = CType(resources.GetObject("bttServir.Glyph"), System.Drawing.Image)
        Me.bttServir.Id = 11
        Me.bttServir.LargeGlyph = CType(resources.GetObject("bttServir.LargeGlyph"), System.Drawing.Image)
        Me.bttServir.Name = "bttServir"
        Me.bttServir.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bttFichaCliente
        '
        Me.bttFichaCliente.Caption = "Ficha cliente"
        Me.bttFichaCliente.Glyph = CType(resources.GetObject("bttFichaCliente.Glyph"), System.Drawing.Image)
        Me.bttFichaCliente.Id = 12
        Me.bttFichaCliente.LargeGlyph = CType(resources.GetObject("bttFichaCliente.LargeGlyph"), System.Drawing.Image)
        Me.bttFichaCliente.Name = "bttFichaCliente"
        '
        'bttCartera
        '
        Me.bttCartera.Caption = "Cartera"
        Me.bttCartera.Glyph = CType(resources.GetObject("bttCartera.Glyph"), System.Drawing.Image)
        Me.bttCartera.Id = 13
        Me.bttCartera.LargeGlyph = CType(resources.GetObject("bttCartera.LargeGlyph"), System.Drawing.Image)
        Me.bttCartera.Name = "bttCartera"
        '
        'bttEstadisticasComparativas
        '
        Me.bttEstadisticasComparativas.Caption = "Estadísticas comparativas"
        Me.bttEstadisticasComparativas.Glyph = CType(resources.GetObject("bttEstadisticasComparativas.Glyph"), System.Drawing.Image)
        Me.bttEstadisticasComparativas.Id = 14
        Me.bttEstadisticasComparativas.LargeGlyph = CType(resources.GetObject("bttEstadisticasComparativas.LargeGlyph"), System.Drawing.Image)
        Me.bttEstadisticasComparativas.Name = "bttEstadisticasComparativas"
        '
        'bttEstadisticasAnalitica
        '
        Me.bttEstadisticasAnalitica.Caption = "Estadísticas analítica"
        Me.bttEstadisticasAnalitica.Glyph = CType(resources.GetObject("bttEstadisticasAnalitica.Glyph"), System.Drawing.Image)
        Me.bttEstadisticasAnalitica.Id = 15
        Me.bttEstadisticasAnalitica.LargeGlyph = CType(resources.GetObject("bttEstadisticasAnalitica.LargeGlyph"), System.Drawing.Image)
        Me.bttEstadisticasAnalitica.Name = "bttEstadisticasAnalitica"
        '
        'bttSuministros
        '
        Me.bttSuministros.Caption = "Suministros"
        Me.bttSuministros.Glyph = CType(resources.GetObject("bttSuministros.Glyph"), System.Drawing.Image)
        Me.bttSuministros.Id = 16
        Me.bttSuministros.LargeGlyph = CType(resources.GetObject("bttSuministros.LargeGlyph"), System.Drawing.Image)
        Me.bttSuministros.Name = "bttSuministros"
        '
        'bttSituacionPedidos
        '
        Me.bttSituacionPedidos.Caption = "Situación de pedidos"
        Me.bttSituacionPedidos.Glyph = CType(resources.GetObject("bttSituacionPedidos.Glyph"), System.Drawing.Image)
        Me.bttSituacionPedidos.Id = 17
        Me.bttSituacionPedidos.LargeGlyph = CType(resources.GetObject("bttSituacionPedidos.LargeGlyph"), System.Drawing.Image)
        Me.bttSituacionPedidos.Name = "bttSituacionPedidos"
        '
        'bttSituacionAlbaranes
        '
        Me.bttSituacionAlbaranes.Caption = "Situación albaranes"
        Me.bttSituacionAlbaranes.Glyph = CType(resources.GetObject("bttSituacionAlbaranes.Glyph"), System.Drawing.Image)
        Me.bttSituacionAlbaranes.Id = 18
        Me.bttSituacionAlbaranes.LargeGlyph = CType(resources.GetObject("bttSituacionAlbaranes.LargeGlyph"), System.Drawing.Image)
        Me.bttSituacionAlbaranes.Name = "bttSituacionAlbaranes"
        '
        'bttPromociones
        '
        Me.bttPromociones.Caption = "Promociones"
        Me.bttPromociones.Glyph = CType(resources.GetObject("bttPromociones.Glyph"), System.Drawing.Image)
        Me.bttPromociones.Id = 20
        Me.bttPromociones.LargeGlyph = CType(resources.GetObject("bttPromociones.LargeGlyph"), System.Drawing.Image)
        Me.bttPromociones.Name = "bttPromociones"
        Me.bttPromociones.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bttClienteNuevo
        '
        Me.bttClienteNuevo.Caption = "Mantenimiento <registro nuevo>"
        Me.bttClienteNuevo.Glyph = CType(resources.GetObject("bttClienteNuevo.Glyph"), System.Drawing.Image)
        Me.bttClienteNuevo.Id = 21
        Me.bttClienteNuevo.LargeGlyph = CType(resources.GetObject("bttClienteNuevo.LargeGlyph"), System.Drawing.Image)
        Me.bttClienteNuevo.Name = "bttClienteNuevo"
        '
        'bttClienteEditar
        '
        Me.bttClienteEditar.Caption = "Mantenimiento <registro actual>"
        Me.bttClienteEditar.Glyph = CType(resources.GetObject("bttClienteEditar.Glyph"), System.Drawing.Image)
        Me.bttClienteEditar.Id = 22
        Me.bttClienteEditar.LargeGlyph = CType(resources.GetObject("bttClienteEditar.LargeGlyph"), System.Drawing.Image)
        Me.bttClienteEditar.Name = "bttClienteEditar"
        '
        'bttClienteTodos
        '
        Me.bttClienteTodos.Caption = "Mantenimiento <todos registros>"
        Me.bttClienteTodos.Glyph = CType(resources.GetObject("bttClienteTodos.Glyph"), System.Drawing.Image)
        Me.bttClienteTodos.Id = 23
        Me.bttClienteTodos.LargeGlyph = CType(resources.GetObject("bttClienteTodos.LargeGlyph"), System.Drawing.Image)
        Me.bttClienteTodos.Name = "bttClienteTodos"
        '
        'bttClienteBuscar
        '
        Me.bttClienteBuscar.Caption = "Selección (F12)"
        Me.bttClienteBuscar.Glyph = CType(resources.GetObject("bttClienteBuscar.Glyph"), System.Drawing.Image)
        Me.bttClienteBuscar.Id = 24
        Me.bttClienteBuscar.LargeGlyph = CType(resources.GetObject("bttClienteBuscar.LargeGlyph"), System.Drawing.Image)
        Me.bttClienteBuscar.Name = "bttClienteBuscar"
        '
        'bttEnvases
        '
        Me.bttEnvases.Caption = "Envases"
        Me.bttEnvases.Glyph = CType(resources.GetObject("bttEnvases.Glyph"), System.Drawing.Image)
        Me.bttEnvases.Id = 25
        Me.bttEnvases.LargeGlyph = CType(resources.GetObject("bttEnvases.LargeGlyph"), System.Drawing.Image)
        Me.bttEnvases.Name = "bttEnvases"
        Me.bttEnvases.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'gcCabecera
        '
        Me.gcCabecera.ContentImageAlignment = System.Drawing.ContentAlignment.TopRight
        Me.gcCabecera.Controls.Add(Me.txtNOMCLI)
        Me.gcCabecera.Controls.Add(Me.LabelControl1)
        Me.gcCabecera.Controls.Add(Me.txtCODCLI)
        Me.gcCabecera.Controls.Add(Me.LabelControl2)
        Me.gcCabecera.Controls.Add(Me.txtFECHA)
        Me.gcCabecera.Controls.Add(Me.txtNUMDOC)
        Me.gcCabecera.Controls.Add(Me.LabelControl4)
        Me.gcCabecera.Controls.Add(Me.txtCODALM)
        Me.gcCabecera.Controls.Add(Me.LabelControl8)
        Me.gcCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.gcCabecera.Location = New System.Drawing.Point(0, 35)
        Me.gcCabecera.Name = "gcCabecera"
        Me.gcCabecera.ShowCaption = False
        Me.gcCabecera.Size = New System.Drawing.Size(784, 112)
        Me.gcCabecera.TabIndex = 97
        Me.gcCabecera.Text = "Cabecera"
        '
        'txtNOMCLI
        '
        Me.txtNOMCLI.EnterMoveNextControl = True
        Me.txtNOMCLI.Location = New System.Drawing.Point(155, 43)
        Me.txtNOMCLI.Name = "txtNOMCLI"
        Me.txtNOMCLI.Properties.AutoHeight = False
        Me.txtNOMCLI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtNOMCLI.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, True)})
        Me.txtNOMCLI.Properties.MaxLength = 8
        Me.txtNOMCLI.Properties.ReadOnly = True
        Me.txtNOMCLI.Size = New System.Drawing.Size(354, 20)
        Me.txtNOMCLI.TabIndex = 72
        Me.txtNOMCLI.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 46)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Cliente:"
        '
        'txtCODCLI
        '
        Me.txtCODCLI.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDATICKETSBindingSource, "CODCLI", True))
        Me.txtCODCLI.EnterMoveNextControl = True
        Me.txtCODCLI.Location = New System.Drawing.Point(57, 43)
        Me.txtCODCLI.Name = "txtCODCLI"
        Me.txtCODCLI.Properties.AutoHeight = False
        Me.txtCODCLI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtCODCLI.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject6, "", Nothing, Nothing, True)})
        Me.txtCODCLI.Properties.MaxLength = 8
        Me.txtCODCLI.Size = New System.Drawing.Size(100, 20)
        Me.txtCODCLI.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(18, 72)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Fecha:"
        '
        'txtFECHA
        '
        Me.txtFECHA.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.IDATICKETSBindingSource, "FECHA", True))
        Me.txtFECHA.EditValue = Nothing
        Me.txtFECHA.EnterMoveNextControl = True
        Me.txtFECHA.Location = New System.Drawing.Point(57, 69)
        Me.txtFECHA.Name = "txtFECHA"
        Me.txtFECHA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFECHA.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFECHA.Size = New System.Drawing.Size(100, 20)
        Me.txtFECHA.TabIndex = 3
        Me.txtFECHA.TabStop = False
        '
        'txtNUMDOC
        '
        Me.txtNUMDOC.EnterMoveNextControl = True
        Me.txtNUMDOC.Location = New System.Drawing.Point(210, 69)
        Me.txtNUMDOC.MenuManager = Me.BarManager
        Me.txtNUMDOC.Name = "txtNUMDOC"
        Me.txtNUMDOC.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNUMDOC.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNUMDOC.Properties.Mask.EditMask = "n0"
        Me.txtNUMDOC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtNUMDOC.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtNUMDOC.Size = New System.Drawing.Size(72, 20)
        Me.txtNUMDOC.TabIndex = 19
        Me.txtNUMDOC.TabStop = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(163, 72)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl4.TabIndex = 20
        Me.LabelControl4.Text = "Nùmero:"
        '
        'txtCODALM
        '
        Me.txtCODALM.EnterMoveNextControl = True
        Me.txtCODALM.Location = New System.Drawing.Point(57, 17)
        Me.txtCODALM.MenuManager = Me.BarManager
        Me.txtCODALM.Name = "txtCODALM"
        Me.txtCODALM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCODALM.Properties.DataSource = Me.ALMACENBindingSource
        Me.txtCODALM.Properties.DisplayMember = "DESCALM"
        Me.txtCODALM.Properties.NullText = ""
        Me.txtCODALM.Properties.ValueMember = "CODALM"
        Me.txtCODALM.Size = New System.Drawing.Size(170, 20)
        Me.txtCODALM.TabIndex = 37
        Me.txtCODALM.TabStop = False
        '
        'ALMACENBindingSource
        '
        Me.ALMACENBindingSource.DataMember = "ALMACEN"
        Me.ALMACENBindingSource.DataSource = Me.DsAlmacenes
        '
        'DsAlmacenes
        '
        Me.DsAlmacenes.DataSetName = "dsAlmacenes"
        Me.DsAlmacenes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(15, 20)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl8.TabIndex = 38
        Me.LabelControl8.Text = "Tienda:"
        '
        'gcLineas
        '
        Me.gcLineas.Controls.Add(Me.dgLineas)
        Me.gcLineas.Controls.Add(Me.ControlNavigator)
        Me.gcLineas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLineas.Location = New System.Drawing.Point(0, 147)
        Me.gcLineas.Name = "gcLineas"
        Me.gcLineas.Size = New System.Drawing.Size(784, 388)
        Me.gcLineas.TabIndex = 98
        Me.gcLineas.Text = "Líneas"
        '
        'dgLineas
        '
        Me.dgLineas.DataSource = Me.IDATICKETSLINEASBindingSource
        Me.dgLineas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLineas.Location = New System.Drawing.Point(2, 21)
        Me.dgLineas.MainView = Me.gvLineas
        Me.dgLineas.Name = "dgLineas"
        Me.dgLineas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskObservaciones, Me.bttCODART, Me.maskUNIDADES, Me.maskPRECIO, Me.maskDESC, Me.bttREFERENCIA, Me.bttCODPRO, Me.maskImporte, Me.cmbTipoIVA})
        Me.dgLineas.Size = New System.Drawing.Size(780, 341)
        Me.dgLineas.TabIndex = 4
        Me.dgLineas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLineas})
        '
        'IDATICKETSLINEASBindingSource
        '
        Me.IDATICKETSLINEASBindingSource.DataMember = "IDA_TICKETSLINEAS"
        Me.IDATICKETSLINEASBindingSource.DataSource = Me.DsTickets
        '
        'gvLineas
        '
        Me.gvLineas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCANTIDAD, Me.colCODART, Me.colCODPER, Me.colDESC, Me.colDESCLIN, Me.colNUMLINEA, Me.colPRCMANUAL, Me.colPRECIO, Me.colPROMO, Me.colTIPIVA, Me.colTOTLIN})
        Me.gvLineas.GridControl = Me.dgLineas
        Me.gvLineas.Name = "gvLineas"
        Me.gvLineas.OptionsLayout.Columns.StoreAllOptions = True
        Me.gvLineas.OptionsLayout.Columns.StoreAppearance = True
        Me.gvLineas.OptionsLayout.StoreAllOptions = True
        Me.gvLineas.OptionsLayout.StoreAppearance = True
        Me.gvLineas.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvLineas.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvLineas.OptionsView.ShowFooter = True
        Me.gvLineas.OptionsView.ShowGroupPanel = False
        '
        'colCANTIDAD
        '
        Me.colCANTIDAD.FieldName = "CANTIDAD"
        Me.colCANTIDAD.Name = "colCANTIDAD"
        Me.colCANTIDAD.Visible = True
        Me.colCANTIDAD.VisibleIndex = 4
        '
        'colCODART
        '
        Me.colCODART.FieldName = "CODART"
        Me.colCODART.Name = "colCODART"
        Me.colCODART.Visible = True
        Me.colCODART.VisibleIndex = 1
        '
        'colCODPER
        '
        Me.colCODPER.FieldName = "CODPER"
        Me.colCODPER.Name = "colCODPER"
        Me.colCODPER.Visible = True
        Me.colCODPER.VisibleIndex = 7
        '
        'colDESC
        '
        Me.colDESC.FieldName = "DESC"
        Me.colDESC.Name = "colDESC"
        Me.colDESC.Visible = True
        Me.colDESC.VisibleIndex = 8
        '
        'colDESCLIN
        '
        Me.colDESCLIN.FieldName = "DESCLIN"
        Me.colDESCLIN.Name = "colDESCLIN"
        Me.colDESCLIN.Visible = True
        Me.colDESCLIN.VisibleIndex = 2
        '
        'colNUMLINEA
        '
        Me.colNUMLINEA.FieldName = "NUMLINEA"
        Me.colNUMLINEA.Name = "colNUMLINEA"
        Me.colNUMLINEA.Visible = True
        Me.colNUMLINEA.VisibleIndex = 0
        '
        'colPRCMANUAL
        '
        Me.colPRCMANUAL.FieldName = "PRCMANUAL"
        Me.colPRCMANUAL.Name = "colPRCMANUAL"
        Me.colPRCMANUAL.Visible = True
        Me.colPRCMANUAL.VisibleIndex = 9
        '
        'colPRECIO
        '
        Me.colPRECIO.FieldName = "PRECIO"
        Me.colPRECIO.Name = "colPRECIO"
        Me.colPRECIO.Visible = True
        Me.colPRECIO.VisibleIndex = 5
        '
        'colPROMO
        '
        Me.colPROMO.FieldName = "PROMO"
        Me.colPROMO.Name = "colPROMO"
        Me.colPROMO.Visible = True
        Me.colPROMO.VisibleIndex = 10
        '
        'colTIPIVA
        '
        Me.colTIPIVA.FieldName = "TIPIVA"
        Me.colTIPIVA.Name = "colTIPIVA"
        Me.colTIPIVA.Visible = True
        Me.colTIPIVA.VisibleIndex = 3
        '
        'colTOTLIN
        '
        Me.colTOTLIN.FieldName = "TOTLIN"
        Me.colTOTLIN.Name = "colTOTLIN"
        Me.colTOTLIN.Visible = True
        Me.colTOTLIN.VisibleIndex = 6
        '
        'maskObservaciones
        '
        Me.maskObservaciones.AutoHeight = False
        Me.maskObservaciones.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.maskObservaciones.Name = "maskObservaciones"
        '
        'bttCODART
        '
        Me.bttCODART.AutoHeight = False
        Me.bttCODART.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("bttCODART.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", "H", Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("bttCODART.Buttons1"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", "T", Nothing, True)})
        Me.bttCODART.Name = "bttCODART"
        '
        'maskUNIDADES
        '
        Me.maskUNIDADES.AutoHeight = False
        Me.maskUNIDADES.Mask.EditMask = "n2"
        Me.maskUNIDADES.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskUNIDADES.Mask.UseMaskAsDisplayFormat = True
        Me.maskUNIDADES.Name = "maskUNIDADES"
        '
        'maskPRECIO
        '
        Me.maskPRECIO.AutoHeight = False
        Me.maskPRECIO.Mask.EditMask = "c2"
        Me.maskPRECIO.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPRECIO.Mask.UseMaskAsDisplayFormat = True
        Me.maskPRECIO.Name = "maskPRECIO"
        '
        'maskDESC
        '
        Me.maskDESC.AutoHeight = False
        Me.maskDESC.Mask.EditMask = "P2"
        Me.maskDESC.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskDESC.Mask.UseMaskAsDisplayFormat = True
        Me.maskDESC.Name = "maskDESC"
        '
        'bttREFERENCIA
        '
        Me.bttREFERENCIA.AutoHeight = False
        Me.bttREFERENCIA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("bttREFERENCIA.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, True)})
        Me.bttREFERENCIA.Name = "bttREFERENCIA"
        '
        'bttCODPRO
        '
        Me.bttCODPRO.AutoHeight = False
        Me.bttCODPRO.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("bttCODPRO.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, True)})
        Me.bttCODPRO.Name = "bttCODPRO"
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.EditMask = "c2"
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'cmbTipoIVA
        '
        Me.cmbTipoIVA.AutoHeight = False
        Me.cmbTipoIVA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTipoIVA.DisplayMember = "NOMTIVA"
        Me.cmbTipoIVA.Name = "cmbTipoIVA"
        Me.cmbTipoIVA.ValueMember = "TIPIVA"
        Me.cmbTipoIVA.View = Me.RepositoryItemGridLookUpEdit1View
        '
        'RepositoryItemGridLookUpEdit1View
        '
        Me.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View"
        Me.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'ControlNavigator
        '
        Me.ControlNavigator.Buttons.Append.ImageIndex = 1
        Me.ControlNavigator.Buttons.CancelEdit.Visible = False
        Me.ControlNavigator.Buttons.Edit.Visible = False
        Me.ControlNavigator.Buttons.EndEdit.Visible = False
        Me.ControlNavigator.Buttons.Remove.ImageIndex = 2
        Me.ControlNavigator.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(-1, 0, True, True, "", "Detalle")})
        Me.ControlNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlNavigator.Location = New System.Drawing.Point(2, 362)
        Me.ControlNavigator.Name = "ControlNavigator"
        Me.ControlNavigator.NavigatableControl = Me.dgLineas
        Me.ControlNavigator.Size = New System.Drawing.Size(780, 24)
        Me.ControlNavigator.TabIndex = 72
        Me.ControlNavigator.Text = "ControlNavigator"
        Me.ControlNavigator.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
        Me.ControlNavigator.TextStringFormat = "Línea {0} de {1}"
        '
        'fTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.gcLineas)
        Me.Controls.Add(Me.gcCabecera)
        Me.Controls.Add(Me.txtTITULO)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "fTicket"
        Me.ShowIcon = False
        Me.Text = "Ticket"
        CType(Me.IDATICKETSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcCabecera.ResumeLayout(False)
        Me.gcCabecera.PerformLayout()
        CType(Me.txtNOMCLI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCODCLI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFECHA.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFECHA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNUMDOC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCODALM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALMACENBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcLineas.ResumeLayout(False)
        CType(Me.dgLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDATICKETSLINEASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttCODART, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskUNIDADES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPRECIO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskDESC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttREFERENCIA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttCODPRO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoIVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemGridLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtTITULO As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsTickets As a3ERP_AydaraTPV.dsTickets
    Friend WithEvents IDATICKETSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BarManager As DevExpress.XtraBars.BarManager
    Friend WithEvents bttFichaCliente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttCartera As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttEstadisticasComparativas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttEstadisticasAnalitica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttSuministros As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttSituacionPedidos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttSituacionAlbaranes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents bttImprimir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttPlantilla As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttPromociones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttServir As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttEnvases As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttGuardar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttCancelar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bttClienteNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttClienteEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttClienteTodos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttClienteBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gcCabecera As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtNOMCLI As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCODCLI As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFECHA As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNUMDOC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCODALM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcLineas As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgLineas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLineas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bttCODART As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents maskDESC As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents maskPRECIO As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents maskObservaciones As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents cmbTipoIVA As DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit
    Friend WithEvents RepositoryItemGridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents maskUNIDADES As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bttREFERENCIA As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents bttCODPRO As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ControlNavigator As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents IDATICKETSLINEASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCANTIDAD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODART As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODPER As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCLIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUMLINEA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRCMANUAL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRECIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROMO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTOTLIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsAlmacenes As a3ERP_AydaraTPV.dsAlmacenes
    Friend WithEvents ALMACENBindingSource As System.Windows.Forms.BindingSource
End Class
