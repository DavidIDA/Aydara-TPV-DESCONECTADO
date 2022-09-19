<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TPV_Tactil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TPV_Tactil))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colFamiliaSeleccionada = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colFamiliaSeleccionada = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colSubfamiliaSeleccionada = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn4 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.lblFecha = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.bttSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.icOpciones = New DevExpress.Utils.ImageCollection(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarraEstado = New DevExpress.XtraBars.Bar()
        Me.txtCodigoEmpleado = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtNombreTicket = New DevExpress.XtraBars.BarStaticItem()
        Me.txtEstado = New DevExpress.XtraBars.BarStaticItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.icMenu = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.txtTotal = New DevExpress.XtraEditors.TextEdit()
        Me.txtFecha = New DevExpress.XtraEditors.TextEdit()
        Me.TICKETSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTickets = New AydaraTPV.dsTickets()
        Me.txtHora = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoCaja = New DevExpress.XtraEditors.TextEdit()
        Me.TimerHora = New System.Windows.Forms.Timer(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.txtNombreCliente = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoCliente = New DevExpress.XtraEditors.ButtonEdit()
        Me.dgLineasTicket = New DevExpress.XtraGrid.GridControl()
        Me.TICKETSLINEASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvLineasTicket = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTicket_Id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPromocion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecioManual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoEmleado = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescripcionArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnidadStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescuentoLinea = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPorcentajeIVA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroTalla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigocolor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecioSinIva = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TICKETS_LINEASTableAdapter = New AydaraTPV.dsTicketsTableAdapters.TICKETS_LINEASTableAdapter()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.txtCodigoArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.ImgPromocion = New DevExpress.XtraEditors.PictureEdit()
        Me.PanelOpciones = New DevExpress.XtraEditors.PanelControl()
        Me.bttCanjearPuntos = New DevExpress.XtraEditors.SimpleButton()
        Me.bttTicketEspera = New DevExpress.XtraEditors.SimpleButton()
        Me.bttBorrarTicket = New DevExpress.XtraEditors.SimpleButton()
        Me.bttConsultaTicket = New DevExpress.XtraEditors.SimpleButton()
        Me.bttAbreCajon = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCambioVendedor = New DevExpress.XtraEditors.SimpleButton()
        Me.bttModificarLinea = New DevExpress.XtraEditors.SimpleButton()
        Me.bttBorraLinea = New DevExpress.XtraEditors.SimpleButton()
        Me.bttDescuentoLinea = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCantidadManual = New DevExpress.XtraEditors.SimpleButton()
        Me.bttPrecioManual = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCobroTicket = New DevExpress.XtraEditors.SimpleButton()
        Me.bttConsultaArticulos = New DevExpress.XtraEditors.SimpleButton()
        Me.dgFamilias = New DevExpress.XtraGrid.GridControl()
        Me.FAMILIASARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New AydaraTPV.dsArticulos()
        Me.lvFamilias = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colIdFamilia = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colIdFamilia = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colImagen = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.imgFoto = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.layoutViewField_colImagen = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colEtiqueta = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_colEtiqueta = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.FAMILIASARTICULOSTableAdapter = New AydaraTPV.dsArticulosTableAdapters.FAMILIASARTICULOSTableAdapter()
        Me.dgArticulos = New DevExpress.XtraGrid.GridControl()
        Me.ARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lvArticulos = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colImagenArticulo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.imgFotoArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.LayoutViewField1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colEtiquetaArticulo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.memoEtiqueta = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.Item2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colArticulos_CodigoArticulo = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn1_2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.ARTICULOSTableAdapter = New AydaraTPV.dsArticulosTableAdapters.ARTICULOSTableAdapter()
        Me.PanelTeclado = New DevExpress.XtraEditors.PanelControl()
        Me.bttCajas = New DevExpress.XtraEditors.SimpleButton()
        Me.bttMas = New DevExpress.XtraEditors.SimpleButton()
        Me.bttIntro = New DevExpress.XtraEditors.SimpleButton()
        Me.bttBorrar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttMenos = New DevExpress.XtraEditors.SimpleButton()
        Me.btt0 = New DevExpress.XtraEditors.SimpleButton()
        Me.btt3 = New DevExpress.XtraEditors.SimpleButton()
        Me.btt2 = New DevExpress.XtraEditors.SimpleButton()
        Me.btt1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btt6 = New DevExpress.XtraEditors.SimpleButton()
        Me.btt5 = New DevExpress.XtraEditors.SimpleButton()
        Me.btt4 = New DevExpress.XtraEditors.SimpleButton()
        Me.btt9 = New DevExpress.XtraEditors.SimpleButton()
        Me.btt8 = New DevExpress.XtraEditors.SimpleButton()
        Me.btt7 = New DevExpress.XtraEditors.SimpleButton()
        Me.TICKETSTableAdapter = New AydaraTPV.dsTicketsTableAdapters.TICKETSTableAdapter()
        Me.txtInfoArticulo = New DevExpress.XtraEditors.MemoEdit()
        Me.txtInfoPromocion = New DevExpress.XtraEditors.TextEdit()
        Me.dgSubfamilias = New DevExpress.XtraGrid.GridControl()
        Me.SUBFAMILIASARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lvSubfamilias = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.colSubfamiliaId = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.layoutViewField_LayoutViewColumn1_3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colSubfamiliaImagen = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.layoutViewField_LayoutViewColumn2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.colSubfamiliaDescripcion = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.layoutViewField_LayoutViewColumn3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
        Me.LayoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
        Me.SUBFAMILIASARTICULOSTableAdapter = New AydaraTPV.dsArticulosTableAdapters.SUBFAMILIASARTICULOSTableAdapter()
        Me.ControlNavigator1 = New DevExpress.XtraEditors.ControlNavigator()
        Me.navArticulos = New DevExpress.XtraEditors.ControlNavigator()
        CType(Me.layoutViewField_colFamiliaSeleccionada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtNombreCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoCliente.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgLineasTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETSLINEASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLineasTicket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgPromocion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelOpciones.SuspendLayout()
        CType(Me.dgFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FAMILIASARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvFamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colIdFamilia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_colEtiqueta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFotoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewField1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.memoEtiqueta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Item2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelTeclado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTeclado.SuspendLayout()
        CType(Me.txtInfoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInfoPromocion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgSubfamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUBFAMILIASARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lvSubfamilias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn1_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutViewField_LayoutViewColumn3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colFamiliaSeleccionada
        '
        Me.colFamiliaSeleccionada.Caption = "Seleccionada"
        Me.colFamiliaSeleccionada.FieldName = "DescuentoTarjeta"
        Me.colFamiliaSeleccionada.LayoutViewField = Me.layoutViewField_colFamiliaSeleccionada
        Me.colFamiliaSeleccionada.Name = "colFamiliaSeleccionada"
        '
        'layoutViewField_colFamiliaSeleccionada
        '
        Me.layoutViewField_colFamiliaSeleccionada.EditorPreferredWidth = -20
        Me.layoutViewField_colFamiliaSeleccionada.Location = New System.Drawing.Point(0, 78)
        Me.layoutViewField_colFamiliaSeleccionada.Name = "layoutViewField_colFamiliaSeleccionada"
        Me.layoutViewField_colFamiliaSeleccionada.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colFamiliaSeleccionada.Size = New System.Drawing.Size(80, 26)
        Me.layoutViewField_colFamiliaSeleccionada.TextSize = New System.Drawing.Size(100, 20)
        Me.layoutViewField_colFamiliaSeleccionada.TextToControlDistance = 0
        '
        'colSubfamiliaSeleccionada
        '
        Me.colSubfamiliaSeleccionada.Caption = "Seleccionada"
        Me.colSubfamiliaSeleccionada.FieldName = "DescuentoTarjeta"
        Me.colSubfamiliaSeleccionada.LayoutViewField = Me.layoutViewField_LayoutViewColumn4
        Me.colSubfamiliaSeleccionada.Name = "colSubfamiliaSeleccionada"
        '
        'layoutViewField_LayoutViewColumn4
        '
        Me.layoutViewField_LayoutViewColumn4.EditorPreferredWidth = -20
        Me.layoutViewField_LayoutViewColumn4.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn4.Name = "layoutViewField_LayoutViewColumn4"
        Me.layoutViewField_LayoutViewColumn4.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_LayoutViewColumn4.Size = New System.Drawing.Size(80, 71)
        Me.layoutViewField_LayoutViewColumn4.TextSize = New System.Drawing.Size(100, 13)
        Me.layoutViewField_LayoutViewColumn4.TextToControlDistance = 5
        '
        'lblFecha
        '
        Me.lblFecha.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(85, 10)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(42, 16)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Fecha:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(5, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(33, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Caja:"
        '
        'bttSalir
        '
        Me.bttSalir.AllowFocus = False
        Me.bttSalir.ImageIndex = 12
        Me.bttSalir.ImageList = Me.icOpciones
        Me.bttSalir.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttSalir.Location = New System.Drawing.Point(337, 177)
        Me.bttSalir.Name = "bttSalir"
        Me.bttSalir.Size = New System.Drawing.Size(90, 70)
        Me.bttSalir.TabIndex = 14
        Me.bttSalir.TabStop = False
        Me.bttSalir.Text = "(ESC) SALIR"
        '
        'icOpciones
        '
        Me.icOpciones.ImageSize = New System.Drawing.Size(32, 32)
        Me.icOpciones.ImageStream = CType(resources.GetObject("icOpciones.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.icOpciones.Images.SetKeyName(0, "32package.png")
        Me.icOpciones.Images.SetKeyName(1, "32money2.png")
        Me.icOpciones.Images.SetKeyName(2, "32gnome_edit_delete.png")
        Me.icOpciones.Images.SetKeyName(3, "basket.png")
        Me.icOpciones.Images.SetKeyName(4, "32money1.png")
        Me.icOpciones.Images.SetKeyName(5, "32currency_euro_yellow.png")
        Me.icOpciones.Images.SetKeyName(6, "delete2.png")
        Me.icOpciones.Images.SetKeyName(7, "update.png")
        Me.icOpciones.Images.SetKeyName(8, "32administrator.png")
        Me.icOpciones.Images.SetKeyName(9, "32cash_register.png")
        Me.icOpciones.Images.SetKeyName(10, "search.png")
        Me.icOpciones.Images.SetKeyName(11, "32ticket.png")
        Me.icOpciones.Images.SetKeyName(12, "Exit.png")
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.BarraEstado})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.icMenu
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.txtCodigoEmpleado, Me.txtNombreTicket, Me.txtEstado})
        Me.BarManager1.MaxItemId = 15
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemTextEdit5, Me.RepositoryItemTextEdit6, Me.RepositoryItemTextEdit7})
        Me.BarManager1.StatusBar = Me.BarraEstado
        '
        'BarraEstado
        '
        Me.BarraEstado.BarName = "Status bar"
        Me.BarraEstado.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.BarraEstado.DockCol = 0
        Me.BarraEstado.DockRow = 0
        Me.BarraEstado.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.BarraEstado.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.txtCodigoEmpleado, "", False, True, True, 25), New DevExpress.XtraBars.LinkPersistInfo(Me.txtNombreTicket), New DevExpress.XtraBars.LinkPersistInfo(Me.txtEstado)})
        Me.BarraEstado.OptionsBar.AllowQuickCustomization = False
        Me.BarraEstado.OptionsBar.DrawDragBorder = False
        Me.BarraEstado.OptionsBar.UseWholeRow = True
        Me.BarraEstado.Text = "Status bar"
        '
        'txtCodigoEmpleado
        '
        Me.txtCodigoEmpleado.Caption = "Empleado:"
        Me.txtCodigoEmpleado.Edit = Me.RepositoryItemTextEdit4
        Me.txtCodigoEmpleado.Id = 6
        Me.txtCodigoEmpleado.Name = "txtCodigoEmpleado"
        Me.txtCodigoEmpleado.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AllowFocused = False
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Mask.EditMask = "00"
        Me.RepositoryItemTextEdit4.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit4.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        Me.RepositoryItemTextEdit4.ReadOnly = True
        '
        'txtNombreTicket
        '
        Me.txtNombreTicket.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
        Me.txtNombreTicket.Border = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtNombreTicket.Id = 9
        Me.txtNombreTicket.Name = "txtNombreTicket"
        Me.txtNombreTicket.TextAlignment = System.Drawing.StringAlignment.Near
        Me.txtNombreTicket.Width = 170
        '
        'txtEstado
        '
        Me.txtEstado.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
        Me.txtEstado.Id = 14
        Me.txtEstado.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Maroon
        Me.txtEstado.ItemAppearance.Normal.Options.UseForeColor = True
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.TextAlignment = System.Drawing.StringAlignment.Far
        Me.txtEstado.Width = 200
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1004, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 657)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1004, 25)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 657)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1004, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 657)
        '
        'icMenu
        '
        Me.icMenu.ImageStream = CType(resources.GetObject("icMenu.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.icMenu.Images.SetKeyName(0, "keyboard.png")
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit5
        '
        Me.RepositoryItemTextEdit5.AutoHeight = False
        Me.RepositoryItemTextEdit5.Name = "RepositoryItemTextEdit5"
        '
        'RepositoryItemTextEdit6
        '
        Me.RepositoryItemTextEdit6.AutoHeight = False
        Me.RepositoryItemTextEdit6.Name = "RepositoryItemTextEdit6"
        '
        'RepositoryItemTextEdit7
        '
        Me.RepositoryItemTextEdit7.AutoHeight = False
        Me.RepositoryItemTextEdit7.Name = "RepositoryItemTextEdit7"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.EditValue = "0,0000"
        Me.txtTotal.Location = New System.Drawing.Point(713, 12)
        Me.txtTotal.MenuManager = Me.BarManager1
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtTotal.Properties.Appearance.Font = New System.Drawing.Font("Arial Black", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtTotal.Properties.Appearance.Options.UseBackColor = True
        Me.txtTotal.Properties.Appearance.Options.UseFont = True
        Me.txtTotal.Properties.Appearance.Options.UseForeColor = True
        Me.txtTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtTotal.Properties.AutoHeight = False
        Me.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtTotal.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtTotal.Properties.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(279, 63)
        Me.txtTotal.TabIndex = 7
        Me.txtTotal.TabStop = False
        '
        'txtFecha
        '
        Me.txtFecha.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TICKETSBindingSource, "FechaTicket", True))
        Me.txtFecha.Location = New System.Drawing.Point(133, 9)
        Me.txtFecha.MenuManager = Me.BarManager1
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Properties.Appearance.Options.UseTextOptions = True
        Me.txtFecha.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtFecha.Properties.Mask.EditMask = "d"
        Me.txtFecha.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.txtFecha.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtFecha.Properties.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(72, 20)
        Me.txtFecha.TabIndex = 8
        Me.txtFecha.TabStop = False
        '
        'TICKETSBindingSource
        '
        Me.TICKETSBindingSource.DataMember = "TICKETS"
        Me.TICKETSBindingSource.DataSource = Me.DsTickets
        '
        'DsTickets
        '
        Me.DsTickets.DataSetName = "dsTickets"
        Me.DsTickets.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtHora
        '
        Me.txtHora.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TICKETSBindingSource, "HoraTicket", True))
        Me.txtHora.Location = New System.Drawing.Point(44, 32)
        Me.txtHora.MenuManager = Me.BarManager1
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHora.Properties.Appearance.Options.UseFont = True
        Me.txtHora.Properties.Appearance.Options.UseTextOptions = True
        Me.txtHora.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtHora.Properties.Mask.EditMask = "T"
        Me.txtHora.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.txtHora.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtHora.Properties.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(161, 26)
        Me.txtHora.TabIndex = 9
        Me.txtHora.TabStop = False
        '
        'txtCodigoCaja
        '
        Me.txtCodigoCaja.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TICKETSBindingSource, "CodigoCaja", True))
        Me.txtCodigoCaja.Location = New System.Drawing.Point(44, 9)
        Me.txtCodigoCaja.MenuManager = Me.BarManager1
        Me.txtCodigoCaja.Name = "txtCodigoCaja"
        Me.txtCodigoCaja.Properties.Appearance.Options.UseTextOptions = True
        Me.txtCodigoCaja.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtCodigoCaja.Properties.Mask.EditMask = "00"
        Me.txtCodigoCaja.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCodigoCaja.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigoCaja.Properties.ReadOnly = True
        Me.txtCodigoCaja.Size = New System.Drawing.Size(32, 20)
        Me.txtCodigoCaja.TabIndex = 10
        Me.txtCodigoCaja.TabStop = False
        '
        'TimerHora
        '
        Me.TimerHora.Enabled = True
        Me.TimerHora.Interval = 1000
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.lblFecha)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtCodigoCaja)
        Me.PanelControl1.Controls.Add(Me.txtHora)
        Me.PanelControl1.Controls.Add(Me.txtFecha)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 12)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(211, 63)
        Me.PanelControl1.TabIndex = 13
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(5, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl2.TabIndex = 11
        Me.LabelControl2.Text = "Hora:"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.txtNombreCliente)
        Me.PanelControl2.Controls.Add(Me.LabelControl5)
        Me.PanelControl2.Controls.Add(Me.txtCodigoCliente)
        Me.PanelControl2.Location = New System.Drawing.Point(229, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(478, 63)
        Me.PanelControl2.TabIndex = 14
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreCliente.Location = New System.Drawing.Point(191, 8)
        Me.txtNombreCliente.MenuManager = Me.BarManager1
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCliente.Properties.Appearance.Options.UseFont = True
        Me.txtNombreCliente.Properties.AutoHeight = False
        Me.txtNombreCliente.Properties.ReadOnly = True
        Me.txtNombreCliente.Size = New System.Drawing.Size(280, 46)
        Me.txtNombreCliente.TabIndex = 17
        Me.txtNombreCliente.TabStop = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(6, 22)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Cliente:"
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.TICKETSBindingSource, "CodigoCliente", True))
        Me.txtCodigoCliente.EnterMoveNextControl = True
        Me.txtCodigoCliente.Location = New System.Drawing.Point(61, 8)
        Me.txtCodigoCliente.MenuManager = Me.BarManager1
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCliente.Properties.Appearance.Options.UseFont = True
        Me.txtCodigoCliente.Properties.AutoHeight = False
        SerializableAppearanceObject1.Image = Global.AydaraTPV.My.Resources.Resources.find
        SerializableAppearanceObject1.Options.UseImage = True
        Me.txtCodigoCliente.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Global.AydaraTPV.My.Resources.Resources.find, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.txtCodigoCliente.Properties.Mask.EditMask = "00000000"
        Me.txtCodigoCliente.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtCodigoCliente.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigoCliente.Properties.ValidateOnEnterKey = True
        Me.txtCodigoCliente.Size = New System.Drawing.Size(131, 46)
        Me.txtCodigoCliente.TabIndex = 1
        Me.txtCodigoCliente.TabStop = False
        '
        'dgLineasTicket
        '
        Me.dgLineasTicket.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgLineasTicket.DataSource = Me.TICKETSLINEASBindingSource
        Me.dgLineasTicket.Location = New System.Drawing.Point(12, 81)
        Me.dgLineasTicket.MainView = Me.gvLineasTicket
        Me.dgLineasTicket.MenuManager = Me.BarManager1
        Me.dgLineasTicket.Name = "dgLineasTicket"
        Me.dgLineasTicket.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskPrecio, Me.maskImporte})
        Me.dgLineasTicket.Size = New System.Drawing.Size(501, 135)
        Me.dgLineasTicket.TabIndex = 15
        Me.dgLineasTicket.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLineasTicket})
        '
        'TICKETSLINEASBindingSource
        '
        Me.TICKETSLINEASBindingSource.DataMember = "TICKETS_LINEAS"
        Me.TICKETSLINEASBindingSource.DataSource = Me.DsTickets
        '
        'gvLineasTicket
        '
        Me.gvLineasTicket.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gvLineasTicket.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gvLineasTicket.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colTicket_Id, Me.colCodigoArticulo, Me.colPromocion, Me.colPrecioManual, Me.colCodigoEmleado, Me.colDescripcionArticulo, Me.colUnidadStock, Me.colCantidad, Me.colPrecio, Me.colDescuentoLinea, Me.colImporte, Me.colPorcentajeIVA, Me.colNumeroTalla, Me.colCodigocolor, Me.colPrecioSinIva})
        Me.gvLineasTicket.GridControl = Me.dgLineasTicket
        Me.gvLineasTicket.Name = "gvLineasTicket"
        Me.gvLineasTicket.OptionsCustomization.AllowColumnMoving = False
        Me.gvLineasTicket.OptionsCustomization.AllowColumnResizing = False
        Me.gvLineasTicket.OptionsCustomization.AllowFilter = False
        Me.gvLineasTicket.OptionsCustomization.AllowGroup = False
        Me.gvLineasTicket.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvLineasTicket.OptionsCustomization.AllowSort = False
        Me.gvLineasTicket.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvLineasTicket.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvLineasTicket.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvLineasTicket.OptionsSelection.EnableAppearanceHideSelection = False
        Me.gvLineasTicket.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.gvLineasTicket.OptionsView.RowAutoHeight = True
        Me.gvLineasTicket.OptionsView.ShowFooter = True
        Me.gvLineasTicket.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.ReadOnly = True
        '
        'colTicket_Id
        '
        Me.colTicket_Id.FieldName = "Ticket_Id"
        Me.colTicket_Id.Name = "colTicket_Id"
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.Caption = "ARTÍCULO"
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.OptionsColumn.AllowFocus = False
        Me.colCodigoArticulo.OptionsColumn.ReadOnly = True
        Me.colCodigoArticulo.Width = 101
        '
        'colPromocion
        '
        Me.colPromocion.FieldName = "Promocion"
        Me.colPromocion.Name = "colPromocion"
        '
        'colPrecioManual
        '
        Me.colPrecioManual.FieldName = "PrecioManual"
        Me.colPrecioManual.Name = "colPrecioManual"
        '
        'colCodigoEmleado
        '
        Me.colCodigoEmleado.FieldName = "CodigoEmleado"
        Me.colCodigoEmleado.Name = "colCodigoEmleado"
        '
        'colDescripcionArticulo
        '
        Me.colDescripcionArticulo.Caption = "Descripción"
        Me.colDescripcionArticulo.FieldName = "DescripcionArticulo"
        Me.colDescripcionArticulo.Name = "colDescripcionArticulo"
        Me.colDescripcionArticulo.OptionsColumn.AllowEdit = False
        Me.colDescripcionArticulo.OptionsColumn.AllowFocus = False
        Me.colDescripcionArticulo.OptionsColumn.ReadOnly = True
        Me.colDescripcionArticulo.Visible = True
        Me.colDescripcionArticulo.VisibleIndex = 0
        Me.colDescripcionArticulo.Width = 263
        '
        'colUnidadStock
        '
        Me.colUnidadStock.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnidadStock.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUnidadStock.Caption = "Cant."
        Me.colUnidadStock.FieldName = "UnidadStock"
        Me.colUnidadStock.MaxWidth = 45
        Me.colUnidadStock.MinWidth = 45
        Me.colUnidadStock.Name = "colUnidadStock"
        Me.colUnidadStock.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colUnidadStock.Visible = True
        Me.colUnidadStock.VisibleIndex = 1
        Me.colUnidadStock.Width = 45
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Peso"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.MaxWidth = 60
        Me.colCantidad.MinWidth = 60
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowEdit = False
        Me.colCantidad.OptionsColumn.AllowFocus = False
        Me.colCantidad.Width = 60
        '
        'colPrecio
        '
        Me.colPrecio.Caption = "Precio"
        Me.colPrecio.ColumnEdit = Me.maskPrecio
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.MaxWidth = 75
        Me.colPrecio.MinWidth = 75
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.OptionsColumn.AllowEdit = False
        Me.colPrecio.OptionsColumn.AllowFocus = False
        '
        'maskPrecio
        '
        Me.maskPrecio.AutoHeight = False
        Me.maskPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecio.Name = "maskPrecio"
        '
        'colDescuentoLinea
        '
        Me.colDescuentoLinea.AppearanceHeader.Options.UseTextOptions = True
        Me.colDescuentoLinea.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDescuentoLinea.Caption = "Dto."
        Me.colDescuentoLinea.DisplayFormat.FormatString = "{0:n2}%"
        Me.colDescuentoLinea.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDescuentoLinea.FieldName = "DescuentoLinea"
        Me.colDescuentoLinea.MaxWidth = 52
        Me.colDescuentoLinea.MinWidth = 52
        Me.colDescuentoLinea.Name = "colDescuentoLinea"
        Me.colDescuentoLinea.OptionsColumn.AllowEdit = False
        Me.colDescuentoLinea.OptionsColumn.AllowFocus = False
        Me.colDescuentoLinea.Visible = True
        Me.colDescuentoLinea.VisibleIndex = 3
        Me.colDescuentoLinea.Width = 52
        '
        'colImporte
        '
        Me.colImporte.AppearanceHeader.Options.UseTextOptions = True
        Me.colImporte.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colImporte.Caption = "Importe"
        Me.colImporte.ColumnEdit = Me.maskImporte
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.MaxWidth = 65
        Me.colImporte.MinWidth = 65
        Me.colImporte.Name = "colImporte"
        Me.colImporte.OptionsColumn.AllowEdit = False
        Me.colImporte.OptionsColumn.AllowFocus = False
        Me.colImporte.OptionsColumn.ReadOnly = True
        Me.colImporte.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:c2}")})
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 4
        Me.colImporte.Width = 65
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'colPorcentajeIVA
        '
        Me.colPorcentajeIVA.FieldName = "PorcentajeIVA"
        Me.colPorcentajeIVA.Name = "colPorcentajeIVA"
        '
        'colNumeroTalla
        '
        Me.colNumeroTalla.FieldName = "NumeroTalla"
        Me.colNumeroTalla.Name = "colNumeroTalla"
        '
        'colCodigocolor
        '
        Me.colCodigocolor.Caption = "Color"
        Me.colCodigocolor.FieldName = "CodigoColor"
        Me.colCodigocolor.Name = "colCodigocolor"
        '
        'colPrecioSinIva
        '
        Me.colPrecioSinIva.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrecioSinIva.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPrecioSinIva.Caption = "Precio/Uni"
        Me.colPrecioSinIva.ColumnEdit = Me.maskPrecio
        Me.colPrecioSinIva.FieldName = "PrecioUniSinIva"
        Me.colPrecioSinIva.MaxWidth = 65
        Me.colPrecioSinIva.MinWidth = 65
        Me.colPrecioSinIva.Name = "colPrecioSinIva"
        Me.colPrecioSinIva.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteSinIva", "{0:c2}")})
        Me.colPrecioSinIva.Visible = True
        Me.colPrecioSinIva.VisibleIndex = 2
        Me.colPrecioSinIva.Width = 65
        '
        'TICKETS_LINEASTableAdapter
        '
        Me.TICKETS_LINEASTableAdapter.ClearBeforeFill = True
        '
        'PanelControl3
        '
        Me.PanelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelControl3.Controls.Add(Me.txtCodigoArticulo)
        Me.PanelControl3.Controls.Add(Me.LabelControl6)
        Me.PanelControl3.Location = New System.Drawing.Point(12, 217)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(501, 36)
        Me.PanelControl3.TabIndex = 16
        '
        'txtCodigoArticulo
        '
        Me.txtCodigoArticulo.EnterMoveNextControl = True
        Me.txtCodigoArticulo.Location = New System.Drawing.Point(103, 7)
        Me.txtCodigoArticulo.MenuManager = Me.BarManager1
        Me.txtCodigoArticulo.Name = "txtCodigoArticulo"
        Me.txtCodigoArticulo.Properties.MaxLength = 15
        Me.txtCodigoArticulo.Properties.ValidateOnEnterKey = True
        Me.txtCodigoArticulo.Size = New System.Drawing.Size(385, 20)
        Me.txtCodigoArticulo.TabIndex = 17
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(5, 8)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(92, 19)
        Me.LabelControl6.TabIndex = 14
        Me.LabelControl6.Text = "ARTÍCULO:"
        '
        'ImgPromocion
        '
        Me.ImgPromocion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ImgPromocion.EditValue = Global.AydaraTPV.My.Resources.Resources.promocion
        Me.ImgPromocion.Location = New System.Drawing.Point(458, 268)
        Me.ImgPromocion.MenuManager = Me.BarManager1
        Me.ImgPromocion.Name = "ImgPromocion"
        Me.ImgPromocion.Properties.AllowFocused = False
        Me.ImgPromocion.Properties.ReadOnly = True
        Me.ImgPromocion.Properties.ShowMenu = False
        Me.ImgPromocion.Size = New System.Drawing.Size(55, 36)
        Me.ImgPromocion.TabIndex = 29
        Me.ImgPromocion.Visible = False
        '
        'PanelOpciones
        '
        Me.PanelOpciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelOpciones.Controls.Add(Me.bttCanjearPuntos)
        Me.PanelOpciones.Controls.Add(Me.bttTicketEspera)
        Me.PanelOpciones.Controls.Add(Me.bttBorrarTicket)
        Me.PanelOpciones.Controls.Add(Me.bttConsultaTicket)
        Me.PanelOpciones.Controls.Add(Me.bttAbreCajon)
        Me.PanelOpciones.Controls.Add(Me.bttCambioVendedor)
        Me.PanelOpciones.Controls.Add(Me.bttModificarLinea)
        Me.PanelOpciones.Controls.Add(Me.bttBorraLinea)
        Me.PanelOpciones.Controls.Add(Me.bttDescuentoLinea)
        Me.PanelOpciones.Controls.Add(Me.bttCantidadManual)
        Me.PanelOpciones.Controls.Add(Me.bttPrecioManual)
        Me.PanelOpciones.Location = New System.Drawing.Point(12, 572)
        Me.PanelOpciones.Name = "PanelOpciones"
        Me.PanelOpciones.Size = New System.Drawing.Size(980, 79)
        Me.PanelOpciones.TabIndex = 17
        '
        'bttCanjearPuntos
        '
        Me.bttCanjearPuntos.AllowFocus = False
        Me.bttCanjearPuntos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCanjearPuntos.Appearance.Options.UseTextOptions = True
        Me.bttCanjearPuntos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttCanjearPuntos.Image = CType(resources.GetObject("bttCanjearPuntos.Image"), System.Drawing.Image)
        Me.bttCanjearPuntos.ImageIndex = 2
        Me.bttCanjearPuntos.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttCanjearPuntos.Location = New System.Drawing.Point(886, 4)
        Me.bttCanjearPuntos.Name = "bttCanjearPuntos"
        Me.bttCanjearPuntos.Size = New System.Drawing.Size(90, 70)
        Me.bttCanjearPuntos.TabIndex = 18
        Me.bttCanjearPuntos.TabStop = False
        Me.bttCanjearPuntos.Text = "(F12) CANJEAR PUNTOS"
        Me.bttCanjearPuntos.Visible = False
        '
        'bttTicketEspera
        '
        Me.bttTicketEspera.AllowFocus = False
        Me.bttTicketEspera.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bttTicketEspera.Appearance.Image = Global.AydaraTPV.My.Resources.Resources.vales
        Me.bttTicketEspera.Appearance.Options.UseImage = True
        Me.bttTicketEspera.Appearance.Options.UseTextOptions = True
        Me.bttTicketEspera.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttTicketEspera.ImageIndex = 11
        Me.bttTicketEspera.ImageList = Me.icOpciones
        Me.bttTicketEspera.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttTicketEspera.Location = New System.Drawing.Point(792, 4)
        Me.bttTicketEspera.Name = "bttTicketEspera"
        Me.bttTicketEspera.Size = New System.Drawing.Size(90, 70)
        Me.bttTicketEspera.TabIndex = 13
        Me.bttTicketEspera.TabStop = False
        Me.bttTicketEspera.Text = "(F9) TICKET EN ESPERA"
        '
        'bttBorrarTicket
        '
        Me.bttBorrarTicket.AllowFocus = False
        Me.bttBorrarTicket.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttBorrarTicket.Appearance.Options.UseTextOptions = True
        Me.bttBorrarTicket.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttBorrarTicket.ImageIndex = 2
        Me.bttBorrarTicket.ImageList = Me.icOpciones
        Me.bttBorrarTicket.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttBorrarTicket.Location = New System.Drawing.Point(886, 5)
        Me.bttBorrarTicket.Name = "bttBorrarTicket"
        Me.bttBorrarTicket.Size = New System.Drawing.Size(90, 70)
        Me.bttBorrarTicket.TabIndex = 4
        Me.bttBorrarTicket.TabStop = False
        Me.bttBorrarTicket.Text = "(F12) BORRAR TICKET"
        '
        'bttConsultaTicket
        '
        Me.bttConsultaTicket.AllowFocus = False
        Me.bttConsultaTicket.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bttConsultaTicket.Appearance.Options.UseTextOptions = True
        Me.bttConsultaTicket.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttConsultaTicket.ImageIndex = 10
        Me.bttConsultaTicket.ImageList = Me.icOpciones
        Me.bttConsultaTicket.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttConsultaTicket.Location = New System.Drawing.Point(696, 5)
        Me.bttConsultaTicket.Name = "bttConsultaTicket"
        Me.bttConsultaTicket.Size = New System.Drawing.Size(90, 70)
        Me.bttConsultaTicket.TabIndex = 12
        Me.bttConsultaTicket.TabStop = False
        Me.bttConsultaTicket.Text = "(F8) CONSULTA TICKETS"
        '
        'bttAbreCajon
        '
        Me.bttAbreCajon.AllowFocus = False
        Me.bttAbreCajon.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bttAbreCajon.Appearance.Options.UseTextOptions = True
        Me.bttAbreCajon.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttAbreCajon.ImageIndex = 9
        Me.bttAbreCajon.ImageList = Me.icOpciones
        Me.bttAbreCajon.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttAbreCajon.Location = New System.Drawing.Point(600, 5)
        Me.bttAbreCajon.Name = "bttAbreCajon"
        Me.bttAbreCajon.Size = New System.Drawing.Size(90, 70)
        Me.bttAbreCajon.TabIndex = 11
        Me.bttAbreCajon.TabStop = False
        Me.bttAbreCajon.Text = "(F7) ABRIR CAJÓN"
        '
        'bttCambioVendedor
        '
        Me.bttCambioVendedor.AllowFocus = False
        Me.bttCambioVendedor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bttCambioVendedor.Appearance.Options.UseTextOptions = True
        Me.bttCambioVendedor.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttCambioVendedor.ImageIndex = 8
        Me.bttCambioVendedor.ImageList = Me.icOpciones
        Me.bttCambioVendedor.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttCambioVendedor.Location = New System.Drawing.Point(504, 5)
        Me.bttCambioVendedor.Name = "bttCambioVendedor"
        Me.bttCambioVendedor.Size = New System.Drawing.Size(90, 70)
        Me.bttCambioVendedor.TabIndex = 10
        Me.bttCambioVendedor.TabStop = False
        Me.bttCambioVendedor.Text = "(F6) CAMBIO VENDEDOR"
        '
        'bttModificarLinea
        '
        Me.bttModificarLinea.AllowFocus = False
        Me.bttModificarLinea.Appearance.Options.UseTextOptions = True
        Me.bttModificarLinea.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttModificarLinea.ImageIndex = 7
        Me.bttModificarLinea.ImageList = Me.icOpciones
        Me.bttModificarLinea.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttModificarLinea.Location = New System.Drawing.Point(398, 5)
        Me.bttModificarLinea.Name = "bttModificarLinea"
        Me.bttModificarLinea.Size = New System.Drawing.Size(90, 70)
        Me.bttModificarLinea.TabIndex = 9
        Me.bttModificarLinea.TabStop = False
        Me.bttModificarLinea.Text = "(F5) MODIF. LINEA"
        '
        'bttBorraLinea
        '
        Me.bttBorraLinea.AllowFocus = False
        Me.bttBorraLinea.Appearance.Options.UseTextOptions = True
        Me.bttBorraLinea.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttBorraLinea.ImageIndex = 6
        Me.bttBorraLinea.ImageList = Me.icOpciones
        Me.bttBorraLinea.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttBorraLinea.Location = New System.Drawing.Point(302, 5)
        Me.bttBorraLinea.Name = "bttBorraLinea"
        Me.bttBorraLinea.Size = New System.Drawing.Size(90, 70)
        Me.bttBorraLinea.TabIndex = 8
        Me.bttBorraLinea.TabStop = False
        Me.bttBorraLinea.Text = "(F4) BORRAR LINEA"
        '
        'bttDescuentoLinea
        '
        Me.bttDescuentoLinea.AllowFocus = False
        Me.bttDescuentoLinea.Appearance.Options.UseTextOptions = True
        Me.bttDescuentoLinea.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttDescuentoLinea.ImageIndex = 5
        Me.bttDescuentoLinea.ImageList = Me.icOpciones
        Me.bttDescuentoLinea.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttDescuentoLinea.Location = New System.Drawing.Point(206, 5)
        Me.bttDescuentoLinea.Name = "bttDescuentoLinea"
        Me.bttDescuentoLinea.Size = New System.Drawing.Size(90, 70)
        Me.bttDescuentoLinea.TabIndex = 7
        Me.bttDescuentoLinea.TabStop = False
        Me.bttDescuentoLinea.Text = "(F3) DTO. DE LINEA"
        '
        'bttCantidadManual
        '
        Me.bttCantidadManual.AllowFocus = False
        Me.bttCantidadManual.Appearance.Options.UseTextOptions = True
        Me.bttCantidadManual.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttCantidadManual.ImageIndex = 3
        Me.bttCantidadManual.ImageList = Me.icOpciones
        Me.bttCantidadManual.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttCantidadManual.Location = New System.Drawing.Point(14, 5)
        Me.bttCantidadManual.Name = "bttCantidadManual"
        Me.bttCantidadManual.Size = New System.Drawing.Size(90, 70)
        Me.bttCantidadManual.TabIndex = 6
        Me.bttCantidadManual.TabStop = False
        Me.bttCantidadManual.Text = "(F1) CANT. MANUAL"
        '
        'bttPrecioManual
        '
        Me.bttPrecioManual.AllowFocus = False
        Me.bttPrecioManual.Appearance.Options.UseTextOptions = True
        Me.bttPrecioManual.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttPrecioManual.ImageIndex = 4
        Me.bttPrecioManual.ImageList = Me.icOpciones
        Me.bttPrecioManual.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttPrecioManual.Location = New System.Drawing.Point(110, 5)
        Me.bttPrecioManual.Name = "bttPrecioManual"
        Me.bttPrecioManual.Size = New System.Drawing.Size(90, 70)
        Me.bttPrecioManual.TabIndex = 5
        Me.bttPrecioManual.TabStop = False
        Me.bttPrecioManual.Text = "(F2) PRECIO MANUAL"
        '
        'bttCobroTicket
        '
        Me.bttCobroTicket.AllowFocus = False
        Me.bttCobroTicket.Appearance.Options.UseTextOptions = True
        Me.bttCobroTicket.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttCobroTicket.ImageIndex = 1
        Me.bttCobroTicket.ImageList = Me.icOpciones
        Me.bttCobroTicket.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttCobroTicket.Location = New System.Drawing.Point(337, 94)
        Me.bttCobroTicket.Name = "bttCobroTicket"
        Me.bttCobroTicket.Size = New System.Drawing.Size(90, 70)
        Me.bttCobroTicket.TabIndex = 3
        Me.bttCobroTicket.TabStop = False
        Me.bttCobroTicket.Text = "(F11) COBRO DE TICKET"
        '
        'bttConsultaArticulos
        '
        Me.bttConsultaArticulos.AllowFocus = False
        Me.bttConsultaArticulos.Appearance.Options.UseTextOptions = True
        Me.bttConsultaArticulos.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttConsultaArticulos.ImageIndex = 0
        Me.bttConsultaArticulos.ImageList = Me.icOpciones
        Me.bttConsultaArticulos.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
        Me.bttConsultaArticulos.Location = New System.Drawing.Point(337, 9)
        Me.bttConsultaArticulos.Name = "bttConsultaArticulos"
        Me.bttConsultaArticulos.Size = New System.Drawing.Size(90, 70)
        Me.bttConsultaArticulos.TabIndex = 2
        Me.bttConsultaArticulos.TabStop = False
        Me.bttConsultaArticulos.Text = "(F10) BUSCAR ARTÍCULOS"
        '
        'dgFamilias
        '
        Me.dgFamilias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgFamilias.DataSource = Me.FAMILIASARTICULOSBindingSource
        Me.dgFamilias.Location = New System.Drawing.Point(519, 81)
        Me.dgFamilias.MainView = Me.lvFamilias
        Me.dgFamilias.MenuManager = Me.BarManager1
        Me.dgFamilias.Name = "dgFamilias"
        Me.dgFamilias.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.imgFoto})
        Me.dgFamilias.Size = New System.Drawing.Size(474, 135)
        Me.dgFamilias.TabIndex = 18
        Me.dgFamilias.TabStop = False
        Me.dgFamilias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.lvFamilias})
        '
        'FAMILIASARTICULOSBindingSource
        '
        Me.FAMILIASARTICULOSBindingSource.DataMember = "FAMILIASARTICULOS"
        Me.FAMILIASARTICULOSBindingSource.DataSource = Me.DsArticulos
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "dsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lvFamilias
        '
        Me.lvFamilias.ActiveFilterEnabled = False
        Me.lvFamilias.CardHorzInterval = 0
        Me.lvFamilias.CardMinSize = New System.Drawing.Size(80, 91)
        Me.lvFamilias.CardVertInterval = 0
        Me.lvFamilias.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colIdFamilia, Me.colImagen, Me.colEtiqueta, Me.colFamiliaSeleccionada})
        StyleFormatCondition2.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseFont = True
        StyleFormatCondition2.Appearance.Options.UseForeColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colFamiliaSeleccionada
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "1"
        Me.lvFamilias.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.lvFamilias.GridControl = Me.dgFamilias
        Me.lvFamilias.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colIdFamilia, Me.layoutViewField_colFamiliaSeleccionada})
        Me.lvFamilias.Name = "lvFamilias"
        Me.lvFamilias.OptionsBehavior.AllowExpandCollapse = False
        Me.lvFamilias.OptionsBehavior.Editable = False
        Me.lvFamilias.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.lvFamilias.OptionsCustomization.AllowFilter = False
        Me.lvFamilias.OptionsCustomization.AllowSort = False
        Me.lvFamilias.OptionsItemText.TextToControlDistance = 0
        Me.lvFamilias.OptionsPrint.PrintCardCaption = False
        Me.lvFamilias.OptionsView.PartialCardWrapThreshold = 0
        Me.lvFamilias.OptionsView.ShowCardCaption = False
        Me.lvFamilias.OptionsView.ShowCardExpandButton = False
        Me.lvFamilias.OptionsView.ShowHeaderPanel = False
        Me.lvFamilias.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
        Me.lvFamilias.TemplateCard = Me.LayoutViewCard3
        '
        'colIdFamilia
        '
        Me.colIdFamilia.Caption = "LayoutViewColumn1"
        Me.colIdFamilia.FieldName = "Id"
        Me.colIdFamilia.LayoutViewField = Me.layoutViewField_colIdFamilia
        Me.colIdFamilia.Name = "colIdFamilia"
        '
        'layoutViewField_colIdFamilia
        '
        Me.layoutViewField_colIdFamilia.EditorPreferredWidth = -20
        Me.layoutViewField_colIdFamilia.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colIdFamilia.Name = "layoutViewField_colIdFamilia"
        Me.layoutViewField_colIdFamilia.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colIdFamilia.Size = New System.Drawing.Size(80, 26)
        Me.layoutViewField_colIdFamilia.TextSize = New System.Drawing.Size(100, 20)
        Me.layoutViewField_colIdFamilia.TextToControlDistance = 0
        '
        'colImagen
        '
        Me.colImagen.ColumnEdit = Me.imgFoto
        Me.colImagen.FieldName = "Imagen"
        Me.colImagen.LayoutViewField = Me.layoutViewField_colImagen
        Me.colImagen.MaxWidth = 150
        Me.colImagen.MinWidth = 150
        Me.colImagen.Name = "colImagen"
        Me.colImagen.OptionsColumn.AllowFocus = False
        Me.colImagen.OptionsColumn.FixedWidth = True
        Me.colImagen.Width = 150
        '
        'imgFoto
        '
        Me.imgFoto.CustomHeight = 70
        Me.imgFoto.Name = "imgFoto"
        Me.imgFoto.NullText = " "
        Me.imgFoto.ReadOnly = True
        Me.imgFoto.ShowMenu = False
        Me.imgFoto.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'layoutViewField_colImagen
        '
        Me.layoutViewField_colImagen.EditorPreferredWidth = 80
        Me.layoutViewField_colImagen.ImageToTextDistance = 0
        Me.layoutViewField_colImagen.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_colImagen.MaxSize = New System.Drawing.Size(80, 70)
        Me.layoutViewField_colImagen.MinSize = New System.Drawing.Size(80, 70)
        Me.layoutViewField_colImagen.Name = "layoutViewField_colImagen"
        Me.layoutViewField_colImagen.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colImagen.Size = New System.Drawing.Size(80, 52)
        Me.layoutViewField_colImagen.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.layoutViewField_colImagen.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colImagen.TextToControlDistance = 0
        Me.layoutViewField_colImagen.TextVisible = False
        '
        'colEtiqueta
        '
        Me.colEtiqueta.AppearanceCell.Options.UseFont = True
        Me.colEtiqueta.AppearanceCell.Options.UseTextOptions = True
        Me.colEtiqueta.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEtiqueta.FieldName = "Etiqueta"
        Me.colEtiqueta.LayoutViewField = Me.layoutViewField_colEtiqueta
        Me.colEtiqueta.Name = "colEtiqueta"
        Me.colEtiqueta.OptionsColumn.AllowFocus = False
        Me.colEtiqueta.OptionsColumn.ReadOnly = True
        '
        'layoutViewField_colEtiqueta
        '
        Me.layoutViewField_colEtiqueta.EditorPreferredWidth = 80
        Me.layoutViewField_colEtiqueta.ImageToTextDistance = 0
        Me.layoutViewField_colEtiqueta.Location = New System.Drawing.Point(0, 52)
        Me.layoutViewField_colEtiqueta.Name = "layoutViewField_colEtiqueta"
        Me.layoutViewField_colEtiqueta.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_colEtiqueta.Size = New System.Drawing.Size(80, 52)
        Me.layoutViewField_colEtiqueta.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_colEtiqueta.TextToControlDistance = 0
        Me.layoutViewField_colEtiqueta.TextVisible = False
        '
        'LayoutViewCard3
        '
        Me.LayoutViewCard3.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard3.GroupBordersVisible = False
        Me.LayoutViewCard3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colImagen, Me.layoutViewField_colEtiqueta})
        Me.LayoutViewCard3.Name = "LayoutViewCard3"
        '
        'FAMILIASARTICULOSTableAdapter
        '
        Me.FAMILIASARTICULOSTableAdapter.ClearBeforeFill = True
        '
        'dgArticulos
        '
        Me.dgArticulos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgArticulos.DataSource = Me.ARTICULOSBindingSource
        Me.dgArticulos.Location = New System.Drawing.Point(518, 81)
        Me.dgArticulos.MainView = Me.lvArticulos
        Me.dgArticulos.MenuManager = Me.BarManager1
        Me.dgArticulos.Name = "dgArticulos"
        Me.dgArticulos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.imgFotoArticulo, Me.memoEtiqueta})
        Me.dgArticulos.Size = New System.Drawing.Size(474, 445)
        Me.dgArticulos.TabIndex = 19
        Me.dgArticulos.TabStop = False
        Me.dgArticulos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.lvArticulos})
        '
        'ARTICULOSBindingSource
        '
        Me.ARTICULOSBindingSource.DataMember = "ARTICULOS"
        Me.ARTICULOSBindingSource.DataSource = Me.DsArticulos
        '
        'lvArticulos
        '
        Me.lvArticulos.CardHorzInterval = 0
        Me.lvArticulos.CardMinSize = New System.Drawing.Size(100, 110)
        Me.lvArticulos.CardVertInterval = 0
        Me.lvArticulos.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colImagenArticulo, Me.colEtiquetaArticulo, Me.colArticulos_CodigoArticulo})
        Me.lvArticulos.GridControl = Me.dgArticulos
        Me.lvArticulos.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn1_2})
        Me.lvArticulos.Name = "lvArticulos"
        Me.lvArticulos.OptionsBehavior.Editable = False
        Me.lvArticulos.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.lvArticulos.OptionsCustomization.AllowFilter = False
        Me.lvArticulos.OptionsCustomization.AllowSort = False
        Me.lvArticulos.OptionsItemText.TextToControlDistance = 0
        Me.lvArticulos.OptionsView.PartialCardWrapThreshold = 0
        Me.lvArticulos.OptionsView.ShowCardCaption = False
        Me.lvArticulos.OptionsView.ShowCardExpandButton = False
        Me.lvArticulos.OptionsView.ShowHeaderPanel = False
        Me.lvArticulos.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
        Me.lvArticulos.TemplateCard = Me.LayoutViewCard2
        '
        'colImagenArticulo
        '
        Me.colImagenArticulo.ColumnEdit = Me.imgFotoArticulo
        Me.colImagenArticulo.FieldName = "Imagen"
        Me.colImagenArticulo.LayoutViewField = Me.LayoutViewField1
        Me.colImagenArticulo.Name = "colImagenArticulo"
        Me.colImagenArticulo.OptionsColumn.AllowFocus = False
        '
        'imgFotoArticulo
        '
        Me.imgFotoArticulo.CustomHeight = 50
        Me.imgFotoArticulo.Name = "imgFotoArticulo"
        Me.imgFotoArticulo.NullText = " "
        Me.imgFotoArticulo.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'LayoutViewField1
        '
        Me.LayoutViewField1.EditorPreferredWidth = 90
        Me.LayoutViewField1.ImageToTextDistance = 0
        Me.LayoutViewField1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutViewField1.MaxSize = New System.Drawing.Size(80, 70)
        Me.LayoutViewField1.MinSize = New System.Drawing.Size(80, 60)
        Me.LayoutViewField1.Name = "LayoutViewField1"
        Me.LayoutViewField1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutViewField1.Size = New System.Drawing.Size(90, 61)
        Me.LayoutViewField1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutViewField1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutViewField1.TextToControlDistance = 0
        Me.LayoutViewField1.TextVisible = False
        '
        'colEtiquetaArticulo
        '
        Me.colEtiquetaArticulo.AppearanceCell.Options.UseFont = True
        Me.colEtiquetaArticulo.AppearanceCell.Options.UseTextOptions = True
        Me.colEtiquetaArticulo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEtiquetaArticulo.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colEtiquetaArticulo.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colEtiquetaArticulo.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 6.0!)
        Me.colEtiquetaArticulo.AppearanceHeader.Options.UseFont = True
        Me.colEtiquetaArticulo.AppearanceHeader.Options.UseTextOptions = True
        Me.colEtiquetaArticulo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colEtiquetaArticulo.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colEtiquetaArticulo.ColumnEdit = Me.memoEtiqueta
        Me.colEtiquetaArticulo.FieldName = "Descripcion"
        Me.colEtiquetaArticulo.LayoutViewField = Me.Item2
        Me.colEtiquetaArticulo.Name = "colEtiquetaArticulo"
        Me.colEtiquetaArticulo.OptionsColumn.AllowFocus = False
        '
        'memoEtiqueta
        '
        Me.memoEtiqueta.Appearance.Font = New System.Drawing.Font("Tahoma", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.memoEtiqueta.Appearance.Options.UseFont = True
        Me.memoEtiqueta.Appearance.Options.UseTextOptions = True
        Me.memoEtiqueta.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.memoEtiqueta.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.memoEtiqueta.AppearanceReadOnly.Options.UseTextOptions = True
        Me.memoEtiqueta.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.memoEtiqueta.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.memoEtiqueta.LinesCount = 2
        Me.memoEtiqueta.Name = "memoEtiqueta"
        '
        'Item2
        '
        Me.Item2.EditorPreferredWidth = 90
        Me.Item2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.Item2.ImageToTextDistance = 0
        Me.Item2.Location = New System.Drawing.Point(0, 61)
        Me.Item2.Name = "Item2"
        Me.Item2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.Item2.Size = New System.Drawing.Size(90, 39)
        Me.Item2.TextSize = New System.Drawing.Size(0, 0)
        Me.Item2.TextToControlDistance = 0
        Me.Item2.TextVisible = False
        '
        'colArticulos_CodigoArticulo
        '
        Me.colArticulos_CodigoArticulo.Caption = "LayoutViewColumn1"
        Me.colArticulos_CodigoArticulo.FieldName = "Codigo"
        Me.colArticulos_CodigoArticulo.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_2
        Me.colArticulos_CodigoArticulo.Name = "colArticulos_CodigoArticulo"
        '
        'layoutViewField_LayoutViewColumn1_2
        '
        Me.layoutViewField_LayoutViewColumn1_2.EditorPreferredWidth = 10
        Me.layoutViewField_LayoutViewColumn1_2.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn1_2.Name = "layoutViewField_LayoutViewColumn1_2"
        Me.layoutViewField_LayoutViewColumn1_2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_LayoutViewColumn1_2.Size = New System.Drawing.Size(90, 100)
        Me.layoutViewField_LayoutViewColumn1_2.TextSize = New System.Drawing.Size(44, 20)
        Me.layoutViewField_LayoutViewColumn1_2.TextToControlDistance = 5
        '
        'LayoutViewCard2
        '
        Me.LayoutViewCard2.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard2.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard2.GroupBordersVisible = False
        Me.LayoutViewCard2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.Item2, Me.LayoutViewField1})
        Me.LayoutViewCard2.Name = "LayoutViewCard2"
        Me.LayoutViewCard2.OptionsItemText.TextToControlDistance = 0
        Me.LayoutViewCard2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutViewCard2.Text = "TemplateCard"
        '
        'ARTICULOSTableAdapter
        '
        Me.ARTICULOSTableAdapter.ClearBeforeFill = True
        '
        'PanelTeclado
        '
        Me.PanelTeclado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelTeclado.Controls.Add(Me.bttCajas)
        Me.PanelTeclado.Controls.Add(Me.bttMas)
        Me.PanelTeclado.Controls.Add(Me.bttIntro)
        Me.PanelTeclado.Controls.Add(Me.bttCobroTicket)
        Me.PanelTeclado.Controls.Add(Me.bttBorrar)
        Me.PanelTeclado.Controls.Add(Me.bttConsultaArticulos)
        Me.PanelTeclado.Controls.Add(Me.bttMenos)
        Me.PanelTeclado.Controls.Add(Me.bttSalir)
        Me.PanelTeclado.Controls.Add(Me.btt0)
        Me.PanelTeclado.Controls.Add(Me.btt3)
        Me.PanelTeclado.Controls.Add(Me.btt2)
        Me.PanelTeclado.Controls.Add(Me.btt1)
        Me.PanelTeclado.Controls.Add(Me.btt6)
        Me.PanelTeclado.Controls.Add(Me.btt5)
        Me.PanelTeclado.Controls.Add(Me.btt4)
        Me.PanelTeclado.Controls.Add(Me.btt9)
        Me.PanelTeclado.Controls.Add(Me.btt8)
        Me.PanelTeclado.Controls.Add(Me.btt7)
        Me.PanelTeclado.Location = New System.Drawing.Point(12, 310)
        Me.PanelTeclado.Name = "PanelTeclado"
        Me.PanelTeclado.Size = New System.Drawing.Size(501, 256)
        Me.PanelTeclado.TabIndex = 22
        '
        'bttCajas
        '
        Me.bttCajas.AllowFocus = False
        Me.bttCajas.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttCajas.Appearance.Options.UseFont = True
        Me.bttCajas.Appearance.Options.UseTextOptions = True
        Me.bttCajas.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttCajas.Location = New System.Drawing.Point(14, 192)
        Me.bttCajas.Name = "bttCajas"
        Me.bttCajas.Size = New System.Drawing.Size(65, 55)
        Me.bttCajas.TabIndex = 17
        Me.bttCajas.TabStop = False
        Me.bttCajas.Text = "VTA. CAJA"
        '
        'bttMas
        '
        Me.bttMas.AllowFocus = False
        Me.bttMas.Appearance.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttMas.Appearance.Options.UseFont = True
        Me.bttMas.Location = New System.Drawing.Point(227, 70)
        Me.bttMas.Name = "bttMas"
        Me.bttMas.Size = New System.Drawing.Size(65, 55)
        Me.bttMas.TabIndex = 16
        Me.bttMas.TabStop = False
        Me.bttMas.Text = "+"
        '
        'bttIntro
        '
        Me.bttIntro.AllowFocus = False
        Me.bttIntro.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttIntro.Appearance.Options.UseFont = True
        Me.bttIntro.Location = New System.Drawing.Point(227, 131)
        Me.bttIntro.Name = "bttIntro"
        Me.bttIntro.Size = New System.Drawing.Size(65, 116)
        Me.bttIntro.TabIndex = 15
        Me.bttIntro.TabStop = False
        Me.bttIntro.Text = "Intro"
        '
        'bttBorrar
        '
        Me.bttBorrar.AllowFocus = False
        Me.bttBorrar.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttBorrar.Appearance.Options.UseFont = True
        Me.bttBorrar.Location = New System.Drawing.Point(156, 192)
        Me.bttBorrar.Name = "bttBorrar"
        Me.bttBorrar.Size = New System.Drawing.Size(65, 55)
        Me.bttBorrar.TabIndex = 14
        Me.bttBorrar.TabStop = False
        Me.bttBorrar.Text = "Borrar"
        '
        'bttMenos
        '
        Me.bttMenos.AllowFocus = False
        Me.bttMenos.Appearance.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttMenos.Appearance.Options.UseFont = True
        Me.bttMenos.Location = New System.Drawing.Point(227, 9)
        Me.bttMenos.Name = "bttMenos"
        Me.bttMenos.Size = New System.Drawing.Size(65, 55)
        Me.bttMenos.TabIndex = 13
        Me.bttMenos.TabStop = False
        Me.bttMenos.Text = "-"
        '
        'btt0
        '
        Me.btt0.AllowFocus = False
        Me.btt0.Appearance.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt0.Appearance.Options.UseFont = True
        Me.btt0.Location = New System.Drawing.Point(85, 192)
        Me.btt0.Name = "btt0"
        Me.btt0.Size = New System.Drawing.Size(65, 55)
        Me.btt0.TabIndex = 11
        Me.btt0.TabStop = False
        Me.btt0.Text = "0"
        '
        'btt3
        '
        Me.btt3.AllowFocus = False
        Me.btt3.Appearance.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt3.Appearance.Options.UseFont = True
        Me.btt3.Location = New System.Drawing.Point(156, 131)
        Me.btt3.Name = "btt3"
        Me.btt3.Size = New System.Drawing.Size(65, 55)
        Me.btt3.TabIndex = 4
        Me.btt3.TabStop = False
        Me.btt3.Text = "3"
        '
        'btt2
        '
        Me.btt2.AllowFocus = False
        Me.btt2.Appearance.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt2.Appearance.Options.UseFont = True
        Me.btt2.Location = New System.Drawing.Point(85, 131)
        Me.btt2.Name = "btt2"
        Me.btt2.Size = New System.Drawing.Size(65, 55)
        Me.btt2.TabIndex = 3
        Me.btt2.TabStop = False
        Me.btt2.Text = "2"
        '
        'btt1
        '
        Me.btt1.AllowFocus = False
        Me.btt1.Appearance.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt1.Appearance.Options.UseFont = True
        Me.btt1.Location = New System.Drawing.Point(14, 131)
        Me.btt1.Name = "btt1"
        Me.btt1.Size = New System.Drawing.Size(65, 55)
        Me.btt1.TabIndex = 2
        Me.btt1.TabStop = False
        Me.btt1.Text = "1"
        '
        'btt6
        '
        Me.btt6.AllowFocus = False
        Me.btt6.Appearance.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt6.Appearance.Options.UseFont = True
        Me.btt6.Location = New System.Drawing.Point(156, 70)
        Me.btt6.Name = "btt6"
        Me.btt6.Size = New System.Drawing.Size(65, 55)
        Me.btt6.TabIndex = 7
        Me.btt6.TabStop = False
        Me.btt6.Text = "6"
        '
        'btt5
        '
        Me.btt5.AllowFocus = False
        Me.btt5.Appearance.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt5.Appearance.Options.UseFont = True
        Me.btt5.Location = New System.Drawing.Point(85, 70)
        Me.btt5.Name = "btt5"
        Me.btt5.Size = New System.Drawing.Size(65, 55)
        Me.btt5.TabIndex = 6
        Me.btt5.TabStop = False
        Me.btt5.Text = "5"
        '
        'btt4
        '
        Me.btt4.AllowFocus = False
        Me.btt4.Appearance.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt4.Appearance.Options.UseFont = True
        Me.btt4.Location = New System.Drawing.Point(14, 70)
        Me.btt4.Name = "btt4"
        Me.btt4.Size = New System.Drawing.Size(65, 55)
        Me.btt4.TabIndex = 5
        Me.btt4.TabStop = False
        Me.btt4.Text = "4"
        '
        'btt9
        '
        Me.btt9.AllowFocus = False
        Me.btt9.Appearance.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt9.Appearance.Options.UseFont = True
        Me.btt9.Location = New System.Drawing.Point(156, 9)
        Me.btt9.Name = "btt9"
        Me.btt9.Size = New System.Drawing.Size(65, 55)
        Me.btt9.TabIndex = 10
        Me.btt9.TabStop = False
        Me.btt9.Text = "9"
        '
        'btt8
        '
        Me.btt8.AllowFocus = False
        Me.btt8.Appearance.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt8.Appearance.Options.UseFont = True
        Me.btt8.Location = New System.Drawing.Point(85, 9)
        Me.btt8.Name = "btt8"
        Me.btt8.Size = New System.Drawing.Size(65, 55)
        Me.btt8.TabIndex = 9
        Me.btt8.TabStop = False
        Me.btt8.Text = "8"
        '
        'btt7
        '
        Me.btt7.AllowFocus = False
        Me.btt7.Appearance.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btt7.Appearance.Options.UseFont = True
        Me.btt7.Location = New System.Drawing.Point(14, 9)
        Me.btt7.Name = "btt7"
        Me.btt7.Size = New System.Drawing.Size(65, 55)
        Me.btt7.TabIndex = 8
        Me.btt7.TabStop = False
        Me.btt7.Text = "7"
        '
        'TICKETSTableAdapter
        '
        Me.TICKETSTableAdapter.ClearBeforeFill = True
        '
        'txtInfoArticulo
        '
        Me.txtInfoArticulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtInfoArticulo.Location = New System.Drawing.Point(12, 259)
        Me.txtInfoArticulo.MenuManager = Me.BarManager1
        Me.txtInfoArticulo.Name = "txtInfoArticulo"
        Me.txtInfoArticulo.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfoArticulo.Properties.Appearance.Options.UseFont = True
        Me.txtInfoArticulo.Properties.ReadOnly = True
        Me.txtInfoArticulo.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInfoArticulo.Size = New System.Drawing.Size(501, 45)
        Me.txtInfoArticulo.TabIndex = 28
        Me.txtInfoArticulo.TabStop = False
        Me.txtInfoArticulo.UseOptimizedRendering = True
        '
        'txtInfoPromocion
        '
        Me.txtInfoPromocion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtInfoPromocion.EditValue = ""
        Me.txtInfoPromocion.Location = New System.Drawing.Point(17, 282)
        Me.txtInfoPromocion.MenuManager = Me.BarManager1
        Me.txtInfoPromocion.Name = "txtInfoPromocion"
        Me.txtInfoPromocion.Properties.Appearance.ForeColor = System.Drawing.Color.Green
        Me.txtInfoPromocion.Properties.Appearance.Options.UseForeColor = True
        Me.txtInfoPromocion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtInfoPromocion.Properties.ReadOnly = True
        Me.txtInfoPromocion.Size = New System.Drawing.Size(432, 18)
        Me.txtInfoPromocion.TabIndex = 31
        '
        'dgSubfamilias
        '
        Me.dgSubfamilias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgSubfamilias.DataSource = Me.SUBFAMILIASARTICULOSBindingSource
        Me.dgSubfamilias.Location = New System.Drawing.Point(519, 252)
        Me.dgSubfamilias.MainView = Me.lvSubfamilias
        Me.dgSubfamilias.MenuManager = Me.BarManager1
        Me.dgSubfamilias.Name = "dgSubfamilias"
        Me.dgSubfamilias.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPictureEdit1, Me.RepositoryItemMemoEdit1})
        Me.dgSubfamilias.Size = New System.Drawing.Size(474, 274)
        Me.dgSubfamilias.TabIndex = 36
        Me.dgSubfamilias.TabStop = False
        Me.dgSubfamilias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.lvSubfamilias})
        '
        'SUBFAMILIASARTICULOSBindingSource
        '
        Me.SUBFAMILIASARTICULOSBindingSource.DataMember = "SUBFAMILIASARTICULOS"
        Me.SUBFAMILIASARTICULOSBindingSource.DataSource = Me.DsArticulos
        '
        'lvSubfamilias
        '
        Me.lvSubfamilias.ActiveFilterEnabled = False
        Me.lvSubfamilias.CardHorzInterval = 0
        Me.lvSubfamilias.CardMinSize = New System.Drawing.Size(80, 91)
        Me.lvSubfamilias.CardVertInterval = 0
        Me.lvSubfamilias.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colSubfamiliaId, Me.colSubfamiliaImagen, Me.colSubfamiliaDescripcion, Me.colSubfamiliaSeleccionada})
        StyleFormatCondition1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseFont = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colSubfamiliaSeleccionada
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "1"
        Me.lvSubfamilias.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.lvSubfamilias.GridControl = Me.dgSubfamilias
        Me.lvSubfamilias.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn1_3, Me.layoutViewField_LayoutViewColumn2, Me.layoutViewField_LayoutViewColumn4})
        Me.lvSubfamilias.Name = "lvSubfamilias"
        Me.lvSubfamilias.OptionsBehavior.AllowExpandCollapse = False
        Me.lvSubfamilias.OptionsBehavior.Editable = False
        Me.lvSubfamilias.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.lvSubfamilias.OptionsCustomization.AllowFilter = False
        Me.lvSubfamilias.OptionsCustomization.AllowSort = False
        Me.lvSubfamilias.OptionsItemText.TextToControlDistance = 0
        Me.lvSubfamilias.OptionsPrint.PrintCardCaption = False
        Me.lvSubfamilias.OptionsView.PartialCardWrapThreshold = 0
        Me.lvSubfamilias.OptionsView.ShowCardCaption = False
        Me.lvSubfamilias.OptionsView.ShowCardExpandButton = False
        Me.lvSubfamilias.OptionsView.ShowHeaderPanel = False
        Me.lvSubfamilias.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
        Me.lvSubfamilias.TemplateCard = Me.LayoutViewCard1
        '
        'colSubfamiliaId
        '
        Me.colSubfamiliaId.Caption = "LayoutViewColumn1"
        Me.colSubfamiliaId.FieldName = "Id"
        Me.colSubfamiliaId.LayoutViewField = Me.layoutViewField_LayoutViewColumn1_3
        Me.colSubfamiliaId.Name = "colSubfamiliaId"
        '
        'layoutViewField_LayoutViewColumn1_3
        '
        Me.layoutViewField_LayoutViewColumn1_3.EditorPreferredWidth = -20
        Me.layoutViewField_LayoutViewColumn1_3.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn1_3.Name = "layoutViewField_LayoutViewColumn1_3"
        Me.layoutViewField_LayoutViewColumn1_3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_LayoutViewColumn1_3.Size = New System.Drawing.Size(80, 71)
        Me.layoutViewField_LayoutViewColumn1_3.TextSize = New System.Drawing.Size(100, 13)
        Me.layoutViewField_LayoutViewColumn1_3.TextToControlDistance = 5
        '
        'colSubfamiliaImagen
        '
        Me.colSubfamiliaImagen.ColumnEdit = Me.RepositoryItemPictureEdit1
        Me.colSubfamiliaImagen.FieldName = "Imagen"
        Me.colSubfamiliaImagen.LayoutViewField = Me.layoutViewField_LayoutViewColumn2
        Me.colSubfamiliaImagen.MaxWidth = 150
        Me.colSubfamiliaImagen.MinWidth = 150
        Me.colSubfamiliaImagen.Name = "colSubfamiliaImagen"
        Me.colSubfamiliaImagen.OptionsColumn.AllowFocus = False
        Me.colSubfamiliaImagen.OptionsColumn.FixedWidth = True
        Me.colSubfamiliaImagen.Width = 150
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.CustomHeight = 70
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.NullText = " "
        Me.RepositoryItemPictureEdit1.ReadOnly = True
        Me.RepositoryItemPictureEdit1.ShowMenu = False
        Me.RepositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        '
        'layoutViewField_LayoutViewColumn2
        '
        Me.layoutViewField_LayoutViewColumn2.EditorPreferredWidth = 80
        Me.layoutViewField_LayoutViewColumn2.ImageToTextDistance = 0
        Me.layoutViewField_LayoutViewColumn2.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn2.MaxSize = New System.Drawing.Size(80, 70)
        Me.layoutViewField_LayoutViewColumn2.MinSize = New System.Drawing.Size(80, 70)
        Me.layoutViewField_LayoutViewColumn2.Name = "layoutViewField_LayoutViewColumn2"
        Me.layoutViewField_LayoutViewColumn2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_LayoutViewColumn2.Size = New System.Drawing.Size(80, 71)
        Me.layoutViewField_LayoutViewColumn2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.layoutViewField_LayoutViewColumn2.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn2.TextToControlDistance = 0
        Me.layoutViewField_LayoutViewColumn2.TextVisible = False
        '
        'colSubfamiliaDescripcion
        '
        Me.colSubfamiliaDescripcion.AppearanceCell.Options.UseFont = True
        Me.colSubfamiliaDescripcion.AppearanceCell.Options.UseTextOptions = True
        Me.colSubfamiliaDescripcion.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSubfamiliaDescripcion.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.colSubfamiliaDescripcion.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colSubfamiliaDescripcion.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colSubfamiliaDescripcion.FieldName = "Descripcion"
        Me.colSubfamiliaDescripcion.LayoutViewField = Me.layoutViewField_LayoutViewColumn3
        Me.colSubfamiliaDescripcion.Name = "colSubfamiliaDescripcion"
        Me.colSubfamiliaDescripcion.OptionsColumn.AllowFocus = False
        Me.colSubfamiliaDescripcion.OptionsColumn.ReadOnly = True
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.RepositoryItemMemoEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'layoutViewField_LayoutViewColumn3
        '
        Me.layoutViewField_LayoutViewColumn3.EditorPreferredWidth = 80
        Me.layoutViewField_LayoutViewColumn3.ImageToTextDistance = 0
        Me.layoutViewField_LayoutViewColumn3.Location = New System.Drawing.Point(0, 0)
        Me.layoutViewField_LayoutViewColumn3.Name = "layoutViewField_LayoutViewColumn3"
        Me.layoutViewField_LayoutViewColumn3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.layoutViewField_LayoutViewColumn3.Size = New System.Drawing.Size(80, 71)
        Me.layoutViewField_LayoutViewColumn3.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutViewField_LayoutViewColumn3.TextToControlDistance = 0
        Me.layoutViewField_LayoutViewColumn3.TextVisible = False
        '
        'LayoutViewCard1
        '
        Me.LayoutViewCard1.CustomizationFormText = "TemplateCard"
        Me.LayoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
        Me.LayoutViewCard1.GroupBordersVisible = False
        Me.LayoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_LayoutViewColumn3})
        Me.LayoutViewCard1.Name = "LayoutViewCard1"
        Me.LayoutViewCard1.OptionsItemText.TextToControlDistance = 0
        Me.LayoutViewCard1.Text = "TemplateCard"
        '
        'SUBFAMILIASARTICULOSTableAdapter
        '
        Me.SUBFAMILIASARTICULOSTableAdapter.ClearBeforeFill = True
        '
        'ControlNavigator1
        '
        Me.ControlNavigator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlNavigator1.Buttons.Append.Visible = False
        Me.ControlNavigator1.Buttons.CancelEdit.Visible = False
        Me.ControlNavigator1.Buttons.Edit.Visible = False
        Me.ControlNavigator1.Buttons.EndEdit.Visible = False
        Me.ControlNavigator1.Buttons.Next.Visible = False
        Me.ControlNavigator1.Buttons.Prev.Visible = False
        Me.ControlNavigator1.Buttons.Remove.Visible = False
        Me.ControlNavigator1.Location = New System.Drawing.Point(519, 216)
        Me.ControlNavigator1.Name = "ControlNavigator1"
        Me.ControlNavigator1.NavigatableControl = Me.dgFamilias
        Me.ControlNavigator1.Size = New System.Drawing.Size(474, 40)
        Me.ControlNavigator1.TabIndex = 41
        Me.ControlNavigator1.Text = "ControlNavigator1"
        '
        'navArticulos
        '
        Me.navArticulos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.navArticulos.Buttons.Append.Visible = False
        Me.navArticulos.Buttons.CancelEdit.Visible = False
        Me.navArticulos.Buttons.Edit.Visible = False
        Me.navArticulos.Buttons.EndEdit.Visible = False
        Me.navArticulos.Buttons.Next.Visible = False
        Me.navArticulos.Buttons.Prev.Visible = False
        Me.navArticulos.Buttons.Remove.Visible = False
        Me.navArticulos.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(0, 10)})
        Me.navArticulos.Location = New System.Drawing.Point(518, 526)
        Me.navArticulos.Name = "navArticulos"
        Me.navArticulos.NavigatableControl = Me.dgSubfamilias
        Me.navArticulos.Size = New System.Drawing.Size(475, 40)
        Me.navArticulos.TabIndex = 42
        Me.navArticulos.Text = "ControlNavigator2"
        '
        'TPV_Tactil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 682)
        Me.Controls.Add(Me.dgSubfamilias)
        Me.Controls.Add(Me.navArticulos)
        Me.Controls.Add(Me.ControlNavigator1)
        Me.Controls.Add(Me.dgFamilias)
        Me.Controls.Add(Me.dgLineasTicket)
        Me.Controls.Add(Me.PanelTeclado)
        Me.Controls.Add(Me.PanelOpciones)
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.ImgPromocion)
        Me.Controls.Add(Me.txtInfoPromocion)
        Me.Controls.Add(Me.txtInfoArticulo)
        Me.Controls.Add(Me.dgArticulos)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "TPV_Tactil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.layoutViewField_colFamiliaSeleccionada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFecha.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHora.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtNombreCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoCliente.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgLineasTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETSLINEASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLineasTicket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.txtCodigoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgPromocion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelOpciones.ResumeLayout(False)
        CType(Me.dgFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FAMILIASARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvFamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colIdFamilia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_colEtiqueta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFotoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewField1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.memoEtiqueta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Item2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelTeclado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTeclado.ResumeLayout(False)
        CType(Me.txtInfoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInfoPromocion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgSubfamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUBFAMILIASARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lvSubfamilias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn1_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutViewField_LayoutViewColumn3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblFecha As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents BarraEstado As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents txtTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoCaja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHora As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFecha As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TimerHora As System.Windows.Forms.Timer
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoCliente As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtNombreCliente As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dgLineasTicket As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvLineasTicket As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsTickets As AydaraTPV.dsTickets
    Friend WithEvents TICKETSLINEASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TICKETS_LINEASTableAdapter As AydaraTPV.dsTicketsTableAdapters.TICKETS_LINEASTableAdapter
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTicket_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPromocion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecioManual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoEmleado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescuentoLinea As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPorcentajeIVA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents maskPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtCodigoArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelOpciones As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttBorraLinea As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttDescuentoLinea As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCantidadManual As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttPrecioManual As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttConsultaArticulos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttConsultaTicket As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttAbreCajon As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCambioVendedor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgFamilias As DevExpress.XtraGrid.GridControl
    Friend WithEvents DsArticulos As AydaraTPV.dsArticulos
    Friend WithEvents FAMILIASARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FAMILIASARTICULOSTableAdapter As AydaraTPV.dsArticulosTableAdapters.FAMILIASARTICULOSTableAdapter
    Friend WithEvents imgFoto As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents dgArticulos As DevExpress.XtraGrid.GridControl
    Friend WithEvents ARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARTICULOSTableAdapter As AydaraTPV.dsArticulosTableAdapters.ARTICULOSTableAdapter
    Friend WithEvents imgFotoArticulo As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents lvArticulos As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents colImagenArticulo As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colEtiquetaArticulo As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents lvFamilias As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents colImagen As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colEtiqueta As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents bttBorrarTicket As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCobroTicket As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PanelTeclado As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btt0 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btt3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btt2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btt1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btt6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btt5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btt4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btt9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btt8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btt7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttIntro As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttBorrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttMenos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents bttModificarLinea As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttTicketEspera As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtCodigoEmpleado As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtNombreTicket As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents RepositoryItemTextEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colIdFamilia As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colFamiliaSeleccionada As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents TICKETSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TICKETSTableAdapter As AydaraTPV.dsTicketsTableAdapters.TICKETSTableAdapter
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colArticulos_CodigoArticulo As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colCodigocolor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtInfoArticulo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ImgPromocion As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents bttMas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RepositoryItemTextEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtInfoPromocion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents icOpciones As DevExpress.Utils.ImageCollection
    Friend WithEvents bttCajas As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents icMenu As DevExpress.Utils.ImageCollection
    Friend WithEvents memoEtiqueta As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents layoutViewField_LayoutViewColumn1_1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents Item3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents Item4 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents txtEstado As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bttCanjearPuntos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colUnidadStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dgSubfamilias As DevExpress.XtraGrid.GridControl
    Friend WithEvents lvSubfamilias As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents colSubfamiliaId As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colSubfamiliaImagen As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents RepositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents colSubfamiliaDescripcion As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents colSubfamiliaSeleccionada As DevExpress.XtraGrid.Columns.LayoutViewColumn
    Friend WithEvents SUBFAMILIASARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SUBFAMILIASARTICULOSTableAdapter As AydaraTPV.dsArticulosTableAdapters.SUBFAMILIASARTICULOSTableAdapter
    Friend WithEvents layoutViewField_colFamiliaSeleccionada As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colIdFamilia As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colImagen As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_colEtiqueta As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard3 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents navArticulos As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents ControlNavigator1 As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents layoutViewField_LayoutViewColumn4 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1_3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents layoutViewField_LayoutViewColumn3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
    Friend WithEvents colPrecioSinIva As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutViewField1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents Item2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents layoutViewField_LayoutViewColumn1_2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
    Friend WithEvents LayoutViewCard2 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
End Class
