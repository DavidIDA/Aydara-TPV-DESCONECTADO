<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.Main = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        Me.icMenuSuperior = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.MenuLateral = New DevExpress.XtraNavBar.NavBarControl()
        Me.bttPorcesosCaja = New DevExpress.XtraNavBar.NavBarGroup()
        Me.bttEmisionTikets = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttMovimientosCaja = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttCierreCaja = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttCierreTienda = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttSituacionTienda = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttProcesosGestion = New DevExpress.XtraNavBar.NavBarGroup()
        Me.bttArticulos = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttFamilias = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttPedidos = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttEntradasMercancia = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttTratamientoPromociones = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttModificacionPrecios = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttHistoricoTickets = New DevExpress.XtraNavBar.NavBarGroup()
        Me.bttConsultasHistoricoTicket = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttRelacionTicketDia = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttCubosEstadisticos = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttHerramientas = New DevExpress.XtraNavBar.NavBarGroup()
        Me.bttComunicaciones = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttCopiasSeguridad = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttConfiguracion = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttClientes = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttProveedores = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttEmpleados = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttCajas = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttTiendas = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttMantenimientoVales = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttResumenVentasHoras = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttGeneracionAsientoContable = New DevExpress.XtraNavBar.NavBarItem()
        Me.bttGeneracionFicheroAlbaranes = New DevExpress.XtraNavBar.NavBarItem()
        Me.icMenuLateral = New DevExpress.Utils.ImageCollection(Me.components)
        Me.bttProcesoCaja = New DevExpress.XtraNavBar.NavBarGroup()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.txtVersion = New DevExpress.XtraBars.BarStaticItem()
        Me.NavProcesosCaja = New DevExpress.XtraBars.BarSubItem()
        Me.menuEmisionTickets = New DevExpress.XtraBars.BarButtonItem()
        Me.menuMovimientosCaja = New DevExpress.XtraBars.BarButtonItem()
        Me.menuCierreCaja = New DevExpress.XtraBars.BarButtonItem()
        Me.menuCierreTienda = New DevExpress.XtraBars.BarButtonItem()
        Me.menuSituacionTienda = New DevExpress.XtraBars.BarButtonItem()
        Me.menuProcesoGestion = New DevExpress.XtraBars.BarSubItem()
        Me.NavMantenimiento = New DevExpress.XtraBars.BarSubItem()
        Me.menuArticulos = New DevExpress.XtraBars.BarButtonItem()
        Me.menuFamilias = New DevExpress.XtraBars.BarButtonItem()
        Me.menuColores = New DevExpress.XtraBars.BarButtonItem()
        Me.menuTallas = New DevExpress.XtraBars.BarButtonItem()
        Me.menuClientes = New DevExpress.XtraBars.BarButtonItem()
        Me.menuProveedores = New DevExpress.XtraBars.BarButtonItem()
        Me.menuEmpleados = New DevExpress.XtraBars.BarButtonItem()
        Me.menuCajas = New DevExpress.XtraBars.BarButtonItem()
        Me.menuTiendas = New DevExpress.XtraBars.BarButtonItem()
        Me.menuTiposUnidades = New DevExpress.XtraBars.BarButtonItem()
        Me.menuMantenimientoVales = New DevExpress.XtraBars.BarButtonItem()
        Me.bttTiposIncidencias = New DevExpress.XtraBars.BarButtonItem()
        Me.menuUtilidades = New DevExpress.XtraBars.BarSubItem()
        Me.menuModificacionTarifasPrecios = New DevExpress.XtraBars.BarButtonItem()
        Me.menuPromociones = New DevExpress.XtraBars.BarButtonItem()
        Me.menuListadoTarifasPrecios = New DevExpress.XtraBars.BarButtonItem()
        Me.menuListadoEtiquetas = New DevExpress.XtraBars.BarButtonItem()
        Me.menuPreciosBasculas = New DevExpress.XtraBars.BarButtonItem()
        Me.menuActualizarEtiquetasElectronicas = New DevExpress.XtraBars.BarButtonItem()
        Me.menuListadosConsultas = New DevExpress.XtraBars.BarSubItem()
        Me.menuListadoFicheroArticulos = New DevExpress.XtraBars.BarButtonItem()
        Me.menuListadoFicheroClientes = New DevExpress.XtraBars.BarButtonItem()
        Me.menuListadoFicheroProveedores = New DevExpress.XtraBars.BarButtonItem()
        Me.menuConsultaSaldosClientes = New DevExpress.XtraBars.BarButtonItem()
        Me.menuConsultaValesPendientes = New DevExpress.XtraBars.BarButtonItem()
        Me.menuControlExistencias = New DevExpress.XtraBars.BarSubItem()
        Me.menuListadoInventarioTienda = New DevExpress.XtraBars.BarButtonItem()
        Me.menuCargaManualPedidosAlmacen = New DevExpress.XtraBars.BarButtonItem()
        Me.menuListadoPedidosProveedor = New DevExpress.XtraBars.BarButtonItem()
        Me.menuEntradasMercancia = New DevExpress.XtraBars.BarButtonItem()
        Me.menuTraspasoAlmacenes = New DevExpress.XtraBars.BarButtonItem()
        Me.menuStockMinimoMaximo = New DevExpress.XtraBars.BarButtonItem()
        Me.menuIncidencias = New DevExpress.XtraBars.BarButtonItem()
        Me.NavHistoricoTickets = New DevExpress.XtraBars.BarSubItem()
        Me.menuConsultaHistoricoTicket = New DevExpress.XtraBars.BarButtonItem()
        Me.menuRelacionTicketDia = New DevExpress.XtraBars.BarButtonItem()
        Me.menuCubosEstadisticos = New DevExpress.XtraBars.BarButtonItem()
        Me.menuProcesosVarios = New DevExpress.XtraBars.BarSubItem()
        Me.menuCopiasSeguridad = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.menuComunicaciones = New DevExpress.XtraBars.BarButtonItem()
        Me.menuRecepcion = New DevExpress.XtraBars.BarButtonItem()
        Me.menuEnvio = New DevExpress.XtraBars.BarButtonItem()
        Me.bttRedimensionarImagenes = New DevExpress.XtraBars.BarButtonItem()
        Me.bttExportarImagenes = New DevExpress.XtraBars.BarButtonItem()
        Me.bttImportarImagenes = New DevExpress.XtraBars.BarButtonItem()
        Me.bttExportarPromociones = New DevExpress.XtraBars.BarButtonItem()
        Me.bttReenviarVentas = New DevExpress.XtraBars.BarButtonItem()
        Me.menuSorteos = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem2 = New DevExpress.XtraBars.BarSubItem()
        Me.menuPuertoLector = New DevExpress.XtraBars.BarEditItem()
        Me.cmbPuertosLector = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.menuRecepcionEtiquetas = New DevExpress.XtraBars.BarButtonItem()
        Me.menuRecepcionPedidos = New DevExpress.XtraBars.BarButtonItem()
        Me.menuRecepcionInventario = New DevExpress.XtraBars.BarButtonItem()
        Me.menuComprobacionInventario = New DevExpress.XtraBars.BarButtonItem()
        Me.bttEnviarDatosTerminal = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.menuPuertoBascula = New DevExpress.XtraBars.BarEditItem()
        Me.cmbPuertosBascula = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.menuTiempoEspera = New DevExpress.XtraBars.BarEditItem()
        Me.txtTiempoEspera = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar()
        Me.bttDirectorioComunicacion = New DevExpress.XtraBars.BarButtonItem()
        Me.bttReiniciarComunicacionBascula = New DevExpress.XtraBars.BarButtonItem()
        Me.menuGeneracionVales = New DevExpress.XtraBars.BarButtonItem()
        Me.menuExportarContabilidad = New DevExpress.XtraBars.BarButtonItem()
        Me.menuExportarAlbaranes = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.bttEHLIS_Tarifas = New DevExpress.XtraBars.BarButtonItem()
        Me.bttEHLIS_Albaranes = New DevExpress.XtraBars.BarButtonItem()
        Me.bttEHLIS_Promociones = New DevExpress.XtraBars.BarButtonItem()
        Me.menuConfiguracion = New DevExpress.XtraBars.BarSubItem()
        Me.bttActualizarAplicacion = New DevExpress.XtraBars.BarButtonItem()
        Me.menuTema = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.menuConexion = New DevExpress.XtraBars.BarButtonItem()
        Me.menuInfo = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar4 = New DevExpress.XtraBars.Bar()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.bttImpresora = New DevExpress.XtraBars.BarButtonItem()
        Me.bttTeclado = New DevExpress.XtraBars.BarButtonItem()
        Me.bttCerrarNavegador = New DevExpress.XtraBars.BarButtonItem()
        Me.bttPaginaAnterior = New DevExpress.XtraBars.BarButtonItem()
        Me.bttPaginaSiguiente = New DevExpress.XtraBars.BarButtonItem()
        Me.bttWebIda = New DevExpress.XtraBars.BarButtonItem()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.BarListItem1 = New DevExpress.XtraBars.BarListItem()
        Me.NavProcesosEspeciales = New DevExpress.XtraBars.BarSubItem()
        Me.bttComunicaTexlon = New DevExpress.XtraBars.BarButtonItem()
        Me.bttRecuperaTickets = New DevExpress.XtraBars.BarButtonItem()
        Me.bttComunicaProveedor = New DevExpress.XtraBars.BarButtonItem()
        Me.menuEntradaCambios = New DevExpress.XtraBars.BarButtonItem()
        Me.menuRetiradaFondos = New DevExpress.XtraBars.BarButtonItem()
        Me.menuPagosPorCaja = New DevExpress.XtraBars.BarButtonItem()
        Me.menuCobrosCliente = New DevExpress.XtraBars.BarButtonItem()
        Me.menuEmisionVales = New DevExpress.XtraBars.BarButtonItem()
        Me.menuTratamientoPromociones = New DevExpress.XtraBars.BarButtonItem()
        Me.menuListadoIncidencias = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.bttDirectorioBascula = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.panelInicio = New DevExpress.XtraEditors.PanelControl()
        Me.panelDatosIDA = New DevExpress.XtraEditors.PanelControl()
        Me.Inicio1 = New AydaraTPV.Inicio()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.Main, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icMenuSuperior, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuLateral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icMenuLateral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPuertosLector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPuertosBascula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTiempoEspera, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttDirectorioBascula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInicio.SuspendLayout()
        CType(Me.panelDatosIDA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelDatosIDA.SuspendLayout()
        Me.SuspendLayout()
        '
        'Main
        '
        Me.Main.AppearancePage.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main.AppearancePage.Header.Options.UseFont = True
        Me.Main.MdiParent = Me
        '
        'icMenuSuperior
        '
        Me.icMenuSuperior.ImageStream = CType(resources.GetObject("icMenuSuperior.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.icMenuSuperior.Images.SetKeyName(0, "1.0.0-PROCESOSCAJA.png")
        Me.icMenuSuperior.Images.SetKeyName(1, "1.1.0-TPV.png")
        Me.icMenuSuperior.Images.SetKeyName(2, "1.2.0-MVTOS.CAJA.png")
        Me.icMenuSuperior.Images.SetKeyName(3, "1.2.1-CAMBIOS.png")
        Me.icMenuSuperior.Images.SetKeyName(4, "1.2.2-RETIRADA.png")
        Me.icMenuSuperior.Images.SetKeyName(5, "1.2.3-PAGOS.png")
        Me.icMenuSuperior.Images.SetKeyName(6, "1.2.4-COBROS.jpg")
        Me.icMenuSuperior.Images.SetKeyName(7, "1.2.5-VALES.png")
        Me.icMenuSuperior.Images.SetKeyName(8, "1.3.0-CIERRE-CAJA.png")
        Me.icMenuSuperior.Images.SetKeyName(9, "1.4.0-CIERRE-TDA.png")
        Me.icMenuSuperior.Images.SetKeyName(10, "1.5.0-SITUACION-TDA.png")
        Me.icMenuSuperior.Images.SetKeyName(11, "1-EFECTIVO.png")
        Me.icMenuSuperior.Images.SetKeyName(12, "1-EFECTIVO2.png")
        Me.icMenuSuperior.Images.SetKeyName(13, "1-EMISION-VALES.png")
        Me.icMenuSuperior.Images.SetKeyName(14, "1-PTE.COBRO.png")
        Me.icMenuSuperior.Images.SetKeyName(15, "1-TARJETA.png")
        Me.icMenuSuperior.Images.SetKeyName(16, "1-VARIOS.png")
        Me.icMenuSuperior.Images.SetKeyName(17, "2.0.0-MANTENIMIENTOS.png")
        Me.icMenuSuperior.Images.SetKeyName(18, "2.1.1-MANT.ARTICULOS.png")
        Me.icMenuSuperior.Images.SetKeyName(19, "2.1.2-MANT.FAMILIAS.jpg")
        Me.icMenuSuperior.Images.SetKeyName(20, "2.1.3-MANT.-COLORES.png")
        Me.icMenuSuperior.Images.SetKeyName(21, "2.1.4-MANT.-TALLAS.png")
        Me.icMenuSuperior.Images.SetKeyName(22, "2.1.5-MANT.CLIENTES.bmp")
        Me.icMenuSuperior.Images.SetKeyName(23, "2.1.6-MANT.PROVE.png")
        Me.icMenuSuperior.Images.SetKeyName(24, "2.1.7-MANT.-EMPLEADOS.png")
        Me.icMenuSuperior.Images.SetKeyName(25, "2.1.8-MANT.CAJAS.png")
        Me.icMenuSuperior.Images.SetKeyName(26, "2.1.9-MANT.-TDAS.png")
        Me.icMenuSuperior.Images.SetKeyName(27, "2.1.11-MANT.VALES.png")
        Me.icMenuSuperior.Images.SetKeyName(28, "2.2.0-TRAT.PRECIOS.png")
        Me.icMenuSuperior.Images.SetKeyName(29, "2.2.1-CAMBIOPRECIO.png")
        Me.icMenuSuperior.Images.SetKeyName(30, "2.2.2-PROMOCIONES.jpg")
        Me.icMenuSuperior.Images.SetKeyName(31, "2.2.3-LIST.TFAS.png")
        Me.icMenuSuperior.Images.SetKeyName(32, "2.2.4-ETIQUETAS.png")
        Me.icMenuSuperior.Images.SetKeyName(33, "2.3.0-INFORMES.png")
        Me.icMenuSuperior.Images.SetKeyName(34, "2.4.0-EXISTENCIAS.png")
        Me.icMenuSuperior.Images.SetKeyName(35, "2.4.1-INVENTARIO.png")
        Me.icMenuSuperior.Images.SetKeyName(36, "2.4.2-PEDIDOS.png")
        Me.icMenuSuperior.Images.SetKeyName(37, "2.4.3-ENTRADAS.png")
        Me.icMenuSuperior.Images.SetKeyName(38, "3.0.0-HIST.VENTAS.png")
        Me.icMenuSuperior.Images.SetKeyName(39, "3.1.0-HISTORICO.png")
        Me.icMenuSuperior.Images.SetKeyName(40, "3.1.2-ESTADISTICA.png")
        Me.icMenuSuperior.Images.SetKeyName(41, "4.0.0-VARIOS.png")
        Me.icMenuSuperior.Images.SetKeyName(42, "4.1.0-COMUNICACIONES.png")
        Me.icMenuSuperior.Images.SetKeyName(43, "4.2.0-COPIAS.png")
        Me.icMenuSuperior.Images.SetKeyName(44, "menu_tickets.png")
        Me.icMenuSuperior.Images.SetKeyName(45, "flecha_izquierda.gif")
        Me.icMenuSuperior.Images.SetKeyName(46, "flecha_derecha.gif")
        Me.icMenuSuperior.Images.SetKeyName(47, "LogoIdaReducido.jpg")
        Me.icMenuSuperior.Images.SetKeyName(48, "1321518972_close.png")
        Me.icMenuSuperior.Images.SetKeyName(49, "keyboard.png")
        Me.icMenuSuperior.Images.SetKeyName(50, "Vista (221).png")
        Me.icMenuSuperior.Images.SetKeyName(51, "user-info.png")
        '
        'Bar1
        '
        Me.Bar1.BarAppearance.Normal.BackColor = System.Drawing.Color.Yellow
        Me.Bar1.BarAppearance.Normal.BackColor2 = System.Drawing.Color.Black
        Me.Bar1.BarAppearance.Normal.BorderColor = System.Drawing.Color.Red
        Me.Bar1.BarAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Bar1.BarAppearance.Normal.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Bar1.BarAppearance.Normal.Options.UseBackColor = True
        Me.Bar1.BarAppearance.Normal.Options.UseBorderColor = True
        Me.Bar1.BarAppearance.Normal.Options.UseFont = True
        Me.Bar1.BarAppearance.Normal.Options.UseForeColor = True
        Me.Bar1.BarAppearance.Normal.Options.UseImage = True
        Me.Bar1.BarAppearance.Normal.Options.UseTextOptions = True
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.RotateWhenVertical = False
        Me.Bar1.Text = "Tools"
        '
        'MenuLateral
        '
        Me.MenuLateral.ActiveGroup = Me.bttPorcesosCaja
        Me.MenuLateral.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MenuLateral.ContentButtonHint = Nothing
        Me.MenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuLateral.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.bttPorcesosCaja, Me.bttProcesosGestion, Me.bttHistoricoTickets, Me.bttHerramientas})
        Me.MenuLateral.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.bttClientes, Me.bttArticulos, Me.bttFamilias, Me.bttProveedores, Me.bttEmpleados, Me.bttCajas, Me.bttTiendas, Me.bttConfiguracion, Me.bttCierreCaja, Me.bttCierreTienda, Me.bttEmisionTikets, Me.bttMovimientosCaja, Me.bttConsultasHistoricoTicket, Me.bttRelacionTicketDia, Me.bttMantenimientoVales, Me.bttResumenVentasHoras, Me.bttGeneracionAsientoContable, Me.bttGeneracionFicheroAlbaranes, Me.bttSituacionTienda, Me.bttComunicaciones, Me.bttCopiasSeguridad, Me.bttModificacionPrecios, Me.bttTratamientoPromociones, Me.bttEntradasMercancia, Me.bttPedidos, Me.bttCubosEstadisticos})
        Me.MenuLateral.Location = New System.Drawing.Point(0, 24)
        Me.MenuLateral.Name = "MenuLateral"
        Me.MenuLateral.OptionsNavPane.ExpandedWidth = 175
        Me.MenuLateral.OptionsNavPane.ShowOverflowPanel = False
        Me.MenuLateral.Size = New System.Drawing.Size(175, 619)
        Me.MenuLateral.SmallImages = Me.icMenuLateral
        Me.MenuLateral.TabIndex = 1
        Me.MenuLateral.Text = "MenuLateral"
        Me.MenuLateral.View = New DevExpress.XtraNavBar.ViewInfo.SkinNavigationPaneViewInfoRegistrator()
        '
        'bttPorcesosCaja
        '
        Me.bttPorcesosCaja.Caption = "Procesos de Caja"
        Me.bttPorcesosCaja.Expanded = True
        Me.bttPorcesosCaja.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.bttEmisionTikets), New DevExpress.XtraNavBar.NavBarItemLink(Me.bttMovimientosCaja), New DevExpress.XtraNavBar.NavBarItemLink(Me.bttCierreCaja), New DevExpress.XtraNavBar.NavBarItemLink(Me.bttCierreTienda), New DevExpress.XtraNavBar.NavBarItemLink(Me.bttSituacionTienda)})
        Me.bttPorcesosCaja.Name = "bttPorcesosCaja"
        Me.bttPorcesosCaja.SmallImageIndex = 0
        '
        'bttEmisionTikets
        '
        Me.bttEmisionTikets.Caption = "T.P.V."
        Me.bttEmisionTikets.Name = "bttEmisionTikets"
        Me.bttEmisionTikets.SmallImageIndex = 1
        '
        'bttMovimientosCaja
        '
        Me.bttMovimientosCaja.Caption = "Movimientos de Caja"
        Me.bttMovimientosCaja.Name = "bttMovimientosCaja"
        Me.bttMovimientosCaja.SmallImageIndex = 2
        '
        'bttCierreCaja
        '
        Me.bttCierreCaja.Caption = "Cierre de Caja"
        Me.bttCierreCaja.Name = "bttCierreCaja"
        Me.bttCierreCaja.SmallImageIndex = 8
        '
        'bttCierreTienda
        '
        Me.bttCierreTienda.Caption = "Cierre de Tienda"
        Me.bttCierreTienda.Name = "bttCierreTienda"
        Me.bttCierreTienda.SmallImageIndex = 9
        '
        'bttSituacionTienda
        '
        Me.bttSituacionTienda.Caption = "Situación Tienda"
        Me.bttSituacionTienda.Name = "bttSituacionTienda"
        Me.bttSituacionTienda.SmallImageIndex = 10
        '
        'bttProcesosGestion
        '
        Me.bttProcesosGestion.Caption = "Procesos de Gestión"
        Me.bttProcesosGestion.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.bttArticulos), New DevExpress.XtraNavBar.NavBarItemLink(Me.bttFamilias), New DevExpress.XtraNavBar.NavBarItemLink(Me.bttPedidos), New DevExpress.XtraNavBar.NavBarItemLink(Me.bttEntradasMercancia), New DevExpress.XtraNavBar.NavBarItemLink(Me.bttTratamientoPromociones), New DevExpress.XtraNavBar.NavBarItemLink(Me.bttModificacionPrecios)})
        Me.bttProcesosGestion.Name = "bttProcesosGestion"
        Me.bttProcesosGestion.SmallImageIndex = 17
        '
        'bttArticulos
        '
        Me.bttArticulos.Caption = "Artículos"
        Me.bttArticulos.Name = "bttArticulos"
        Me.bttArticulos.SmallImageIndex = 18
        '
        'bttFamilias
        '
        Me.bttFamilias.Caption = "Familias-Subfamilias"
        Me.bttFamilias.Name = "bttFamilias"
        Me.bttFamilias.SmallImageIndex = 19
        '
        'bttPedidos
        '
        Me.bttPedidos.Caption = "Pedidos"
        Me.bttPedidos.Name = "bttPedidos"
        Me.bttPedidos.SmallImageIndex = 36
        '
        'bttEntradasMercancia
        '
        Me.bttEntradasMercancia.Caption = "Entradas Mercancía"
        Me.bttEntradasMercancia.Name = "bttEntradasMercancia"
        Me.bttEntradasMercancia.SmallImageIndex = 38
        '
        'bttTratamientoPromociones
        '
        Me.bttTratamientoPromociones.Caption = "Promociones"
        Me.bttTratamientoPromociones.Name = "bttTratamientoPromociones"
        Me.bttTratamientoPromociones.SmallImageIndex = 30
        '
        'bttModificacionPrecios
        '
        Me.bttModificacionPrecios.Caption = "Modificación Precios"
        Me.bttModificacionPrecios.Name = "bttModificacionPrecios"
        Me.bttModificacionPrecios.SmallImageIndex = 29
        '
        'bttHistoricoTickets
        '
        Me.bttHistoricoTickets.Caption = "Histórico de Ventas"
        Me.bttHistoricoTickets.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.bttConsultasHistoricoTicket), New DevExpress.XtraNavBar.NavBarItemLink(Me.bttRelacionTicketDia), New DevExpress.XtraNavBar.NavBarItemLink(Me.bttCubosEstadisticos)})
        Me.bttHistoricoTickets.Name = "bttHistoricoTickets"
        Me.bttHistoricoTickets.SmallImageIndex = 38
        '
        'bttConsultasHistoricoTicket
        '
        Me.bttConsultasHistoricoTicket.Caption = "Consulta Histórico de Ticket"
        Me.bttConsultasHistoricoTicket.Name = "bttConsultasHistoricoTicket"
        Me.bttConsultasHistoricoTicket.SmallImageIndex = 39
        '
        'bttRelacionTicketDia
        '
        Me.bttRelacionTicketDia.Caption = "Estadísticas de Ventas"
        Me.bttRelacionTicketDia.Name = "bttRelacionTicketDia"
        Me.bttRelacionTicketDia.SmallImageIndex = 40
        '
        'bttCubosEstadisticos
        '
        Me.bttCubosEstadisticos.Caption = "Cubos Estadísticos"
        Me.bttCubosEstadisticos.Name = "bttCubosEstadisticos"
        Me.bttCubosEstadisticos.SmallImageIndex = 44
        '
        'bttHerramientas
        '
        Me.bttHerramientas.Caption = "Procesos Varios"
        Me.bttHerramientas.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.bttComunicaciones), New DevExpress.XtraNavBar.NavBarItemLink(Me.bttCopiasSeguridad), New DevExpress.XtraNavBar.NavBarItemLink(Me.bttConfiguracion)})
        Me.bttHerramientas.Name = "bttHerramientas"
        Me.bttHerramientas.SmallImageIndex = 41
        '
        'bttComunicaciones
        '
        Me.bttComunicaciones.Caption = "Comunicaciones"
        Me.bttComunicaciones.Name = "bttComunicaciones"
        Me.bttComunicaciones.SmallImageIndex = 42
        '
        'bttCopiasSeguridad
        '
        Me.bttCopiasSeguridad.Caption = "Copias de Seguridad"
        Me.bttCopiasSeguridad.Name = "bttCopiasSeguridad"
        Me.bttCopiasSeguridad.SmallImageIndex = 43
        '
        'bttConfiguracion
        '
        Me.bttConfiguracion.Caption = "Tema"
        Me.bttConfiguracion.Name = "bttConfiguracion"
        Me.bttConfiguracion.Visible = False
        '
        'bttClientes
        '
        Me.bttClientes.Caption = "Clientes"
        Me.bttClientes.Name = "bttClientes"
        Me.bttClientes.SmallImage = Global.AydaraTPV.My.Resources.Resources.clients
        '
        'bttProveedores
        '
        Me.bttProveedores.Caption = "Proveedores"
        Me.bttProveedores.Name = "bttProveedores"
        Me.bttProveedores.SmallImage = Global.AydaraTPV.My.Resources.Resources.provider
        '
        'bttEmpleados
        '
        Me.bttEmpleados.Caption = "Empleados"
        Me.bttEmpleados.Name = "bttEmpleados"
        Me.bttEmpleados.SmallImage = Global.AydaraTPV.My.Resources.Resources.employee
        '
        'bttCajas
        '
        Me.bttCajas.Caption = "Cajas"
        Me.bttCajas.Name = "bttCajas"
        Me.bttCajas.SmallImage = Global.AydaraTPV.My.Resources.Resources.box1
        '
        'bttTiendas
        '
        Me.bttTiendas.Caption = "Tiendas"
        Me.bttTiendas.Name = "bttTiendas"
        Me.bttTiendas.SmallImage = Global.AydaraTPV.My.Resources.Resources.shopping_cart2
        '
        'bttMantenimientoVales
        '
        Me.bttMantenimientoVales.Caption = "Mantenimiento Vales"
        Me.bttMantenimientoVales.Name = "bttMantenimientoVales"
        Me.bttMantenimientoVales.SmallImageIndex = 7
        '
        'bttResumenVentasHoras
        '
        Me.bttResumenVentasHoras.Caption = "Resumen de Ventas por Horas"
        Me.bttResumenVentasHoras.Name = "bttResumenVentasHoras"
        '
        'bttGeneracionAsientoContable
        '
        Me.bttGeneracionAsientoContable.Caption = "Generación de Asiento Contable"
        Me.bttGeneracionAsientoContable.Name = "bttGeneracionAsientoContable"
        '
        'bttGeneracionFicheroAlbaranes
        '
        Me.bttGeneracionFicheroAlbaranes.Caption = "Generación de Fichero Albaranes"
        Me.bttGeneracionFicheroAlbaranes.Name = "bttGeneracionFicheroAlbaranes"
        '
        'icMenuLateral
        '
        Me.icMenuLateral.ImageSize = New System.Drawing.Size(48, 48)
        Me.icMenuLateral.ImageStream = CType(resources.GetObject("icMenuLateral.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.icMenuLateral.Images.SetKeyName(0, "1.0.0-PROCESOSCAJA.png")
        Me.icMenuLateral.Images.SetKeyName(1, "1.1.0-TPV.png")
        Me.icMenuLateral.Images.SetKeyName(2, "1.2.0-MVTOS.CAJA.png")
        Me.icMenuLateral.Images.SetKeyName(3, "1.2.1-CAMBIOS.png")
        Me.icMenuLateral.Images.SetKeyName(4, "1.2.2-RETIRADA.png")
        Me.icMenuLateral.Images.SetKeyName(5, "1.2.3-PAGOS.png")
        Me.icMenuLateral.Images.SetKeyName(6, "1.2.4-COBROS.jpg")
        Me.icMenuLateral.Images.SetKeyName(7, "1.2.5-VALES.png")
        Me.icMenuLateral.Images.SetKeyName(8, "1.3.0-CIERRE-CAJA.png")
        Me.icMenuLateral.Images.SetKeyName(9, "1.4.0-CIERRE-TDA.png")
        Me.icMenuLateral.Images.SetKeyName(10, "1.5.0-SITUACION-TDA.png")
        Me.icMenuLateral.Images.SetKeyName(11, "1-EFECTIVO.png")
        Me.icMenuLateral.Images.SetKeyName(12, "1-EFECTIVO2.png")
        Me.icMenuLateral.Images.SetKeyName(13, "1-EMISION-VALES.png")
        Me.icMenuLateral.Images.SetKeyName(14, "1-PTE.COBRO.png")
        Me.icMenuLateral.Images.SetKeyName(15, "1-TARJETA.png")
        Me.icMenuLateral.Images.SetKeyName(16, "1-VARIOS.png")
        Me.icMenuLateral.Images.SetKeyName(17, "2.0.0-MANTENIMIENTOS.png")
        Me.icMenuLateral.Images.SetKeyName(18, "2.1.1-MANT.ARTICULOS.png")
        Me.icMenuLateral.Images.SetKeyName(19, "2.1.2-MANT.FAMILIAS.jpg")
        Me.icMenuLateral.Images.SetKeyName(20, "2.1.3-MANT.-COLORES.png")
        Me.icMenuLateral.Images.SetKeyName(21, "2.1.4-MANT.-TALLAS.png")
        Me.icMenuLateral.Images.SetKeyName(22, "2.1.5-MANT.CLIENTES.bmp")
        Me.icMenuLateral.Images.SetKeyName(23, "2.1.6-MANT.PROVE.png")
        Me.icMenuLateral.Images.SetKeyName(24, "2.1.7-MANT.-EMPLEADOS.png")
        Me.icMenuLateral.Images.SetKeyName(25, "2.1.8-MANT.CAJAS.png")
        Me.icMenuLateral.Images.SetKeyName(26, "2.1.9-MANT.-TDAS.png")
        Me.icMenuLateral.Images.SetKeyName(27, "2.1.11-MANT.VALES.png")
        Me.icMenuLateral.Images.SetKeyName(28, "2.2.0-TRAT.PRECIOS.png")
        Me.icMenuLateral.Images.SetKeyName(29, "2.2.1-CAMBIOPRECIO.png")
        Me.icMenuLateral.Images.SetKeyName(30, "2.2.2-PROMOCIONES.jpg")
        Me.icMenuLateral.Images.SetKeyName(31, "2.2.3-LIST.TFAS.png")
        Me.icMenuLateral.Images.SetKeyName(32, "2.2.4-ETIQUETAS.png")
        Me.icMenuLateral.Images.SetKeyName(33, "2.3.0-INFORMES.png")
        Me.icMenuLateral.Images.SetKeyName(34, "2.4.0-EXISTENCIAS.png")
        Me.icMenuLateral.Images.SetKeyName(35, "2.4.1-INVENTARIO.png")
        Me.icMenuLateral.Images.SetKeyName(36, "2.4.2-PEDIDOS.png")
        Me.icMenuLateral.Images.SetKeyName(37, "2.4.3-ENTRADAS.png")
        Me.icMenuLateral.Images.SetKeyName(38, "3.0.0-HIST.VENTAS.png")
        Me.icMenuLateral.Images.SetKeyName(39, "3.1.0-HISTORICO.png")
        Me.icMenuLateral.Images.SetKeyName(40, "3.1.2-ESTADISTICA.png")
        Me.icMenuLateral.Images.SetKeyName(41, "4.0.0-VARIOS.png")
        Me.icMenuLateral.Images.SetKeyName(42, "4.1.0-COMUNICACIONES.png")
        Me.icMenuLateral.Images.SetKeyName(43, "4.2.0-COPIAS.png")
        Me.icMenuLateral.Images.SetKeyName(44, "Vista (221).png")
        '
        'bttProcesoCaja
        '
        Me.bttProcesoCaja.Caption = "Proceso de Caja"
        Me.bttProcesoCaja.Expanded = True
        Me.bttProcesoCaja.LargeImage = Global.AydaraTPV.My.Resources.Resources.cashbox
        Me.bttProcesoCaja.Name = "bttProcesoCaja"
        Me.bttProcesoCaja.TopVisibleLinkIndex = 3
        '
        'BarManager1
        '
        Me.BarManager1.AllowCustomization = False
        Me.BarManager1.AllowQuickCustomization = False
        Me.BarManager1.AllowShowToolbarsPopup = False
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar3, Me.Bar4})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Images = Me.icMenuSuperior
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.txtVersion, Me.NavMantenimiento, Me.menuClientes, Me.menuArticulos, Me.menuFamilias, Me.menuProveedores, Me.menuEmpleados, Me.menuCajas, Me.menuTiendas, Me.BarListItem1, Me.NavProcesosCaja, Me.NavProcesosEspeciales, Me.menuProcesoGestion, Me.menuEntradaCambios, Me.menuRetiradaFondos, Me.menuPagosPorCaja, Me.menuCobrosCliente, Me.menuEmisionVales, Me.NavHistoricoTickets, Me.bttComunicaTexlon, Me.bttRecuperaTickets, Me.bttComunicaProveedor, Me.menuListadosConsultas, Me.menuControlExistencias, Me.menuUtilidades, Me.menuListadoFicheroArticulos, Me.menuListadoFicheroClientes, Me.menuListadoFicheroProveedores, Me.menuListadoTarifasPrecios, Me.menuConsultaSaldosClientes, Me.menuConsultaValesPendientes, Me.menuListadoEtiquetas, Me.menuEntradasMercancia, Me.menuCargaManualPedidosAlmacen, Me.menuListadoPedidosProveedor, Me.menuListadoInventarioTienda, Me.menuModificacionTarifasPrecios, Me.menuTratamientoPromociones, Me.BarStaticItem2, Me.bttWebIda, Me.bttPaginaAnterior, Me.bttPaginaSiguiente, Me.bttCerrarNavegador, Me.menuTallas, Me.menuColores, Me.bttImpresora, Me.menuMovimientosCaja, Me.menuEmisionTickets, Me.menuCierreCaja, Me.menuCierreTienda, Me.menuProcesosVarios, Me.menuPromociones, Me.bttTeclado, Me.menuSituacionTienda, Me.menuConsultaHistoricoTicket, Me.menuRelacionTicketDia, Me.menuMantenimientoVales, Me.menuComunicaciones, Me.menuCopiasSeguridad, Me.menuTiposUnidades, Me.menuTema, Me.menuCubosEstadisticos, Me.BarSubItem1, Me.menuRecepcion, Me.menuEnvio, Me.menuSorteos, Me.menuTraspasoAlmacenes, Me.BarSubItem2, Me.menuRecepcionEtiquetas, Me.menuRecepcionPedidos, Me.menuRecepcionInventario, Me.menuComprobacionInventario, Me.bttActualizarAplicacion, Me.menuConfiguracion, Me.menuConexion, Me.menuStockMinimoMaximo, Me.menuPuertoLector, Me.BarSubItem3, Me.menuPuertoBascula, Me.menuTiempoEspera, Me.bttExportarImagenes, Me.bttImportarImagenes, Me.bttExportarPromociones, Me.bttReenviarVentas, Me.menuInfo, Me.bttRedimensionarImagenes, Me.bttReiniciarComunicacionBascula, Me.bttDirectorioComunicacion, Me.menuGeneracionVales, Me.menuExportarContabilidad, Me.menuIncidencias, Me.menuListadoIncidencias, Me.menuExportarAlbaranes, Me.bttTiposIncidencias, Me.BarSubItem4, Me.bttEHLIS_Tarifas, Me.bttEHLIS_Albaranes, Me.BarSubItem5, Me.bttEHLIS_Promociones, Me.bttEnviarDatosTerminal, Me.menuPreciosBasculas, Me.menuActualizarEtiquetasElectronicas})
        Me.BarManager1.MainMenu = Me.Bar3
        Me.BarManager1.MaxItemId = 160
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepositoryItemTextEdit1, Me.cmbPuertosLector, Me.cmbPuertosBascula, Me.txtTiempoEspera, Me.bttDirectorioBascula})
        Me.BarManager1.StatusBar = Me.Bar4
        Me.BarManager1.UseAltKeyForMenu = False
        Me.BarManager1.UseF10KeyForMenu = False
        '
        'Bar3
        '
        Me.Bar3.BarAppearance.Normal.BackColor = System.Drawing.Color.PowderBlue
        Me.Bar3.BarAppearance.Normal.BackColor2 = System.Drawing.Color.Navy
        Me.Bar3.BarAppearance.Normal.Options.UseBackColor = True
        Me.Bar3.BarName = "Main menu"
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.txtVersion), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.NavProcesosCaja, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.menuProcesoGestion, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.NavHistoricoTickets, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.menuProcesosVarios, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.menuConfiguracion)})
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Main menu"
        '
        'txtVersion
        '
        Me.txtVersion.AutoSize = DevExpress.XtraBars.BarStaticItemSize.None
        Me.txtVersion.Caption = "Aydara T.P.V."
        Me.txtVersion.Id = 0
        Me.txtVersion.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVersion.ItemAppearance.Normal.Options.UseFont = True
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.TextAlignment = System.Drawing.StringAlignment.Center
        Me.txtVersion.Width = 155
        '
        'NavProcesosCaja
        '
        Me.NavProcesosCaja.Caption = "Procesos de Caja"
        Me.NavProcesosCaja.Id = 11
        Me.NavProcesosCaja.ImageIndex = 0
        Me.NavProcesosCaja.ImageIndexDisabled = 0
        Me.NavProcesosCaja.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.menuEmisionTickets), New DevExpress.XtraBars.LinkPersistInfo(Me.menuMovimientosCaja), New DevExpress.XtraBars.LinkPersistInfo(Me.menuCierreCaja), New DevExpress.XtraBars.LinkPersistInfo(Me.menuCierreTienda), New DevExpress.XtraBars.LinkPersistInfo(Me.menuSituacionTienda)})
        Me.NavProcesosCaja.Name = "NavProcesosCaja"
        '
        'menuEmisionTickets
        '
        Me.menuEmisionTickets.Caption = "Ticket de Venta"
        Me.menuEmisionTickets.Id = 90
        Me.menuEmisionTickets.ImageIndex = 1
        Me.menuEmisionTickets.Name = "menuEmisionTickets"
        '
        'menuMovimientosCaja
        '
        Me.menuMovimientosCaja.Caption = "Movimientos de Caja"
        Me.menuMovimientosCaja.Id = 89
        Me.menuMovimientosCaja.ImageIndex = 2
        Me.menuMovimientosCaja.Name = "menuMovimientosCaja"
        '
        'menuCierreCaja
        '
        Me.menuCierreCaja.Caption = "Cierre de Caja"
        Me.menuCierreCaja.Id = 91
        Me.menuCierreCaja.ImageIndex = 8
        Me.menuCierreCaja.Name = "menuCierreCaja"
        '
        'menuCierreTienda
        '
        Me.menuCierreTienda.Caption = "Cierre de Tienda"
        Me.menuCierreTienda.Id = 92
        Me.menuCierreTienda.ImageIndex = 9
        Me.menuCierreTienda.Name = "menuCierreTienda"
        '
        'menuSituacionTienda
        '
        Me.menuSituacionTienda.Caption = "Situación Tienda"
        Me.menuSituacionTienda.Id = 97
        Me.menuSituacionTienda.ImageIndex = 10
        Me.menuSituacionTienda.Name = "menuSituacionTienda"
        '
        'menuProcesoGestion
        '
        Me.menuProcesoGestion.Caption = "Procesos de Gestión"
        Me.menuProcesoGestion.Id = 14
        Me.menuProcesoGestion.ImageIndex = 17
        Me.menuProcesoGestion.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.NavMantenimiento, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.menuUtilidades), New DevExpress.XtraBars.LinkPersistInfo(Me.menuListadosConsultas), New DevExpress.XtraBars.LinkPersistInfo(Me.menuControlExistencias)})
        Me.menuProcesoGestion.Name = "menuProcesoGestion"
        '
        'NavMantenimiento
        '
        Me.NavMantenimiento.Caption = "Mantenimientos"
        Me.NavMantenimiento.Id = 1
        Me.NavMantenimiento.ImageIndex = 17
        Me.NavMantenimiento.LargeImageIndex = 10
        Me.NavMantenimiento.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.menuArticulos, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.menuFamilias, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.menuColores), New DevExpress.XtraBars.LinkPersistInfo(Me.menuTallas), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.menuClientes, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.menuProveedores, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.menuEmpleados, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.menuCajas, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.menuTiendas, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.menuTiposUnidades), New DevExpress.XtraBars.LinkPersistInfo(Me.menuMantenimientoVales), New DevExpress.XtraBars.LinkPersistInfo(Me.bttTiposIncidencias)})
        Me.NavMantenimiento.Name = "NavMantenimiento"
        '
        'menuArticulos
        '
        Me.menuArticulos.Caption = "Artículos"
        Me.menuArticulos.Id = 3
        Me.menuArticulos.ImageIndex = 18
        Me.menuArticulos.Name = "menuArticulos"
        '
        'menuFamilias
        '
        Me.menuFamilias.Caption = "Familias-Subfamilias"
        Me.menuFamilias.Id = 4
        Me.menuFamilias.ImageIndex = 19
        Me.menuFamilias.Name = "menuFamilias"
        '
        'menuColores
        '
        Me.menuColores.Caption = "Colores"
        Me.menuColores.Id = 85
        Me.menuColores.ImageIndex = 20
        Me.menuColores.Name = "menuColores"
        '
        'menuTallas
        '
        Me.menuTallas.Caption = "Tallas"
        Me.menuTallas.Id = 84
        Me.menuTallas.ImageIndex = 21
        Me.menuTallas.Name = "menuTallas"
        '
        'menuClientes
        '
        Me.menuClientes.Caption = "Clientes"
        Me.menuClientes.Id = 2
        Me.menuClientes.ImageIndex = 22
        Me.menuClientes.Name = "menuClientes"
        '
        'menuProveedores
        '
        Me.menuProveedores.Caption = "Proveedores"
        Me.menuProveedores.Id = 6
        Me.menuProveedores.ImageIndex = 23
        Me.menuProveedores.Name = "menuProveedores"
        '
        'menuEmpleados
        '
        Me.menuEmpleados.Caption = "Empleados"
        Me.menuEmpleados.Id = 7
        Me.menuEmpleados.ImageIndex = 24
        Me.menuEmpleados.Name = "menuEmpleados"
        '
        'menuCajas
        '
        Me.menuCajas.Caption = "Cajas"
        Me.menuCajas.Id = 8
        Me.menuCajas.ImageIndex = 25
        Me.menuCajas.Name = "menuCajas"
        '
        'menuTiendas
        '
        Me.menuTiendas.Caption = "Tiendas"
        Me.menuTiendas.Id = 9
        Me.menuTiendas.ImageIndex = 26
        Me.menuTiendas.Name = "menuTiendas"
        '
        'menuTiposUnidades
        '
        Me.menuTiposUnidades.Caption = "Tipos Unidades"
        Me.menuTiposUnidades.Id = 108
        Me.menuTiposUnidades.ImageIndex = 32
        Me.menuTiposUnidades.Name = "menuTiposUnidades"
        '
        'menuMantenimientoVales
        '
        Me.menuMantenimientoVales.Caption = "Vales Propios"
        Me.menuMantenimientoVales.Id = 104
        Me.menuMantenimientoVales.ImageIndex = 27
        Me.menuMantenimientoVales.Name = "menuMantenimientoVales"
        '
        'bttTiposIncidencias
        '
        Me.bttTiposIncidencias.Caption = "Tipos de incidencias"
        Me.bttTiposIncidencias.Id = 151
        Me.bttTiposIncidencias.Name = "bttTiposIncidencias"
        '
        'menuUtilidades
        '
        Me.menuUtilidades.Caption = "Tratamiento de Precios"
        Me.menuUtilidades.Id = 40
        Me.menuUtilidades.ImageIndex = 28
        Me.menuUtilidades.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.menuModificacionTarifasPrecios), New DevExpress.XtraBars.LinkPersistInfo(Me.menuPromociones), New DevExpress.XtraBars.LinkPersistInfo(Me.menuListadoTarifasPrecios), New DevExpress.XtraBars.LinkPersistInfo(Me.menuListadoEtiquetas), New DevExpress.XtraBars.LinkPersistInfo(Me.menuPreciosBasculas), New DevExpress.XtraBars.LinkPersistInfo(Me.menuActualizarEtiquetasElectronicas)})
        Me.menuUtilidades.Name = "menuUtilidades"
        '
        'menuModificacionTarifasPrecios
        '
        Me.menuModificacionTarifasPrecios.Caption = "Modificación de Precios"
        Me.menuModificacionTarifasPrecios.Id = 65
        Me.menuModificacionTarifasPrecios.ImageIndex = 29
        Me.menuModificacionTarifasPrecios.Name = "menuModificacionTarifasPrecios"
        '
        'menuPromociones
        '
        Me.menuPromociones.Caption = "Tratamiento de Promociones"
        Me.menuPromociones.Id = 95
        Me.menuPromociones.ImageIndex = 30
        Me.menuPromociones.Name = "menuPromociones"
        '
        'menuListadoTarifasPrecios
        '
        Me.menuListadoTarifasPrecios.Caption = "Listado Tarifas de Precios"
        Me.menuListadoTarifasPrecios.Id = 48
        Me.menuListadoTarifasPrecios.ImageIndex = 31
        Me.menuListadoTarifasPrecios.Name = "menuListadoTarifasPrecios"
        '
        'menuListadoEtiquetas
        '
        Me.menuListadoEtiquetas.Caption = "Listado de Etiquetas"
        Me.menuListadoEtiquetas.Id = 53
        Me.menuListadoEtiquetas.ImageIndex = 32
        Me.menuListadoEtiquetas.Name = "menuListadoEtiquetas"
        '
        'menuPreciosBasculas
        '
        Me.menuPreciosBasculas.Caption = "Cambio precio básculas"
        Me.menuPreciosBasculas.Id = 158
        Me.menuPreciosBasculas.Name = "menuPreciosBasculas"
        '
        'menuActualizarEtiquetasElectronicas
        '
        Me.menuActualizarEtiquetasElectronicas.Caption = "Actualizar etiquetas electrónicas"
        Me.menuActualizarEtiquetasElectronicas.Id = 159
        Me.menuActualizarEtiquetasElectronicas.Name = "menuActualizarEtiquetasElectronicas"
        '
        'menuListadosConsultas
        '
        Me.menuListadosConsultas.Caption = "Informes"
        Me.menuListadosConsultas.Id = 37
        Me.menuListadosConsultas.ImageIndex = 33
        Me.menuListadosConsultas.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.menuListadoFicheroArticulos), New DevExpress.XtraBars.LinkPersistInfo(Me.menuListadoFicheroClientes), New DevExpress.XtraBars.LinkPersistInfo(Me.menuListadoFicheroProveedores), New DevExpress.XtraBars.LinkPersistInfo(Me.menuConsultaSaldosClientes), New DevExpress.XtraBars.LinkPersistInfo(Me.menuConsultaValesPendientes)})
        Me.menuListadosConsultas.Name = "menuListadosConsultas"
        '
        'menuListadoFicheroArticulos
        '
        Me.menuListadoFicheroArticulos.Caption = "Listado de Artículos"
        Me.menuListadoFicheroArticulos.Id = 41
        Me.menuListadoFicheroArticulos.ImageIndex = 33
        Me.menuListadoFicheroArticulos.Name = "menuListadoFicheroArticulos"
        '
        'menuListadoFicheroClientes
        '
        Me.menuListadoFicheroClientes.Caption = "Listado de Clientes"
        Me.menuListadoFicheroClientes.Id = 45
        Me.menuListadoFicheroClientes.ImageIndex = 33
        Me.menuListadoFicheroClientes.Name = "menuListadoFicheroClientes"
        '
        'menuListadoFicheroProveedores
        '
        Me.menuListadoFicheroProveedores.Caption = "Listado de Proveedores"
        Me.menuListadoFicheroProveedores.Id = 46
        Me.menuListadoFicheroProveedores.ImageIndex = 33
        Me.menuListadoFicheroProveedores.Name = "menuListadoFicheroProveedores"
        '
        'menuConsultaSaldosClientes
        '
        Me.menuConsultaSaldosClientes.Caption = "Listado Saldos de Clientes"
        Me.menuConsultaSaldosClientes.Id = 50
        Me.menuConsultaSaldosClientes.ImageIndex = 33
        Me.menuConsultaSaldosClientes.Name = "menuConsultaSaldosClientes"
        '
        'menuConsultaValesPendientes
        '
        Me.menuConsultaValesPendientes.Caption = "Listado de Vales Pendientes"
        Me.menuConsultaValesPendientes.Id = 52
        Me.menuConsultaValesPendientes.ImageIndex = 33
        Me.menuConsultaValesPendientes.Name = "menuConsultaValesPendientes"
        '
        'menuControlExistencias
        '
        Me.menuControlExistencias.Caption = "Control Existencias"
        Me.menuControlExistencias.Id = 38
        Me.menuControlExistencias.ImageIndex = 34
        Me.menuControlExistencias.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.menuListadoInventarioTienda), New DevExpress.XtraBars.LinkPersistInfo(Me.menuCargaManualPedidosAlmacen), New DevExpress.XtraBars.LinkPersistInfo(Me.menuListadoPedidosProveedor), New DevExpress.XtraBars.LinkPersistInfo(Me.menuEntradasMercancia), New DevExpress.XtraBars.LinkPersistInfo(Me.menuTraspasoAlmacenes), New DevExpress.XtraBars.LinkPersistInfo(Me.menuStockMinimoMaximo), New DevExpress.XtraBars.LinkPersistInfo(Me.menuIncidencias)})
        Me.menuControlExistencias.Name = "menuControlExistencias"
        '
        'menuListadoInventarioTienda
        '
        Me.menuListadoInventarioTienda.Caption = "Listado de Inventario"
        Me.menuListadoInventarioTienda.Id = 63
        Me.menuListadoInventarioTienda.ImageIndex = 35
        Me.menuListadoInventarioTienda.Name = "menuListadoInventarioTienda"
        '
        'menuCargaManualPedidosAlmacen
        '
        Me.menuCargaManualPedidosAlmacen.Caption = "Carga Pedidos a Proveedores"
        Me.menuCargaManualPedidosAlmacen.Id = 58
        Me.menuCargaManualPedidosAlmacen.ImageIndex = 36
        Me.menuCargaManualPedidosAlmacen.Name = "menuCargaManualPedidosAlmacen"
        '
        'menuListadoPedidosProveedor
        '
        Me.menuListadoPedidosProveedor.Caption = "Listado de Pedidos Proveedor"
        Me.menuListadoPedidosProveedor.Id = 61
        Me.menuListadoPedidosProveedor.ImageIndex = 33
        Me.menuListadoPedidosProveedor.Name = "menuListadoPedidosProveedor"
        Me.menuListadoPedidosProveedor.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'menuEntradasMercancia
        '
        Me.menuEntradasMercancia.Caption = "Entradas de Mercancía"
        Me.menuEntradasMercancia.Id = 54
        Me.menuEntradasMercancia.ImageIndex = 37
        Me.menuEntradasMercancia.Name = "menuEntradasMercancia"
        '
        'menuTraspasoAlmacenes
        '
        Me.menuTraspasoAlmacenes.Caption = "Traspaso entre Almacenes"
        Me.menuTraspasoAlmacenes.Id = 116
        Me.menuTraspasoAlmacenes.ImageIndex = 43
        Me.menuTraspasoAlmacenes.Name = "menuTraspasoAlmacenes"
        '
        'menuStockMinimoMaximo
        '
        Me.menuStockMinimoMaximo.Caption = "Mantenimiento Mínimo Máximo"
        Me.menuStockMinimoMaximo.Id = 127
        Me.menuStockMinimoMaximo.ImageIndex = 50
        Me.menuStockMinimoMaximo.Name = "menuStockMinimoMaximo"
        '
        'menuIncidencias
        '
        Me.menuIncidencias.Caption = "Incidencias"
        Me.menuIncidencias.Id = 147
        Me.menuIncidencias.Name = "menuIncidencias"
        '
        'NavHistoricoTickets
        '
        Me.NavHistoricoTickets.Caption = "Histórico de Ventas"
        Me.NavHistoricoTickets.Id = 24
        Me.NavHistoricoTickets.ImageIndex = 38
        Me.NavHistoricoTickets.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.menuConsultaHistoricoTicket), New DevExpress.XtraBars.LinkPersistInfo(Me.menuRelacionTicketDia), New DevExpress.XtraBars.LinkPersistInfo(Me.menuCubosEstadisticos)})
        Me.NavHistoricoTickets.Name = "NavHistoricoTickets"
        '
        'menuConsultaHistoricoTicket
        '
        Me.menuConsultaHistoricoTicket.Caption = "Consulta Histórico de Ticket "
        Me.menuConsultaHistoricoTicket.Id = 99
        Me.menuConsultaHistoricoTicket.ImageIndex = 39
        Me.menuConsultaHistoricoTicket.Name = "menuConsultaHistoricoTicket"
        '
        'menuRelacionTicketDia
        '
        Me.menuRelacionTicketDia.Caption = "Estadísticas de Ventas"
        Me.menuRelacionTicketDia.Id = 100
        Me.menuRelacionTicketDia.ImageIndex = 40
        Me.menuRelacionTicketDia.Name = "menuRelacionTicketDia"
        '
        'menuCubosEstadisticos
        '
        Me.menuCubosEstadisticos.Caption = "Cubos Estadísticos"
        Me.menuCubosEstadisticos.Id = 110
        Me.menuCubosEstadisticos.ImageIndex = 50
        Me.menuCubosEstadisticos.Name = "menuCubosEstadisticos"
        '
        'menuProcesosVarios
        '
        Me.menuProcesosVarios.Caption = "Procesos Varios"
        Me.menuProcesosVarios.Id = 93
        Me.menuProcesosVarios.ImageIndex = 41
        Me.menuProcesosVarios.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.menuCopiasSeguridad), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.menuSorteos), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem2), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.menuGeneracionVales), New DevExpress.XtraBars.LinkPersistInfo(Me.menuExportarContabilidad), New DevExpress.XtraBars.LinkPersistInfo(Me.menuExportarAlbaranes), New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem4)})
        Me.menuProcesosVarios.Name = "menuProcesosVarios"
        '
        'menuCopiasSeguridad
        '
        Me.menuCopiasSeguridad.Caption = "Copias de Seguridad"
        Me.menuCopiasSeguridad.Id = 107
        Me.menuCopiasSeguridad.ImageIndex = 43
        Me.menuCopiasSeguridad.Name = "menuCopiasSeguridad"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "Comunicaciones"
        Me.BarSubItem1.Id = 111
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.menuComunicaciones), New DevExpress.XtraBars.LinkPersistInfo(Me.menuRecepcion), New DevExpress.XtraBars.LinkPersistInfo(Me.menuEnvio), New DevExpress.XtraBars.LinkPersistInfo(Me.bttRedimensionarImagenes, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bttExportarImagenes), New DevExpress.XtraBars.LinkPersistInfo(Me.bttImportarImagenes), New DevExpress.XtraBars.LinkPersistInfo(Me.bttExportarPromociones, True), New DevExpress.XtraBars.LinkPersistInfo(Me.bttReenviarVentas, True)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'menuComunicaciones
        '
        Me.menuComunicaciones.Caption = "Comunicaciones"
        Me.menuComunicaciones.Id = 106
        Me.menuComunicaciones.ImageIndex = 42
        Me.menuComunicaciones.Name = "menuComunicaciones"
        '
        'menuRecepcion
        '
        Me.menuRecepcion.Caption = "Recepción"
        Me.menuRecepcion.Id = 112
        Me.menuRecepcion.Name = "menuRecepcion"
        '
        'menuEnvio
        '
        Me.menuEnvio.Caption = "Envío"
        Me.menuEnvio.Id = 113
        Me.menuEnvio.Name = "menuEnvio"
        '
        'bttRedimensionarImagenes
        '
        Me.bttRedimensionarImagenes.Caption = "Redimensionar imágenes"
        Me.bttRedimensionarImagenes.Id = 140
        Me.bttRedimensionarImagenes.Name = "bttRedimensionarImagenes"
        '
        'bttExportarImagenes
        '
        Me.bttExportarImagenes.Caption = "Exportar imágenes"
        Me.bttExportarImagenes.Id = 135
        Me.bttExportarImagenes.Name = "bttExportarImagenes"
        '
        'bttImportarImagenes
        '
        Me.bttImportarImagenes.Caption = "Importar imágenes"
        Me.bttImportarImagenes.Id = 136
        Me.bttImportarImagenes.Name = "bttImportarImagenes"
        '
        'bttExportarPromociones
        '
        Me.bttExportarPromociones.Caption = "Exportar promociones"
        Me.bttExportarPromociones.Id = 137
        Me.bttExportarPromociones.Name = "bttExportarPromociones"
        '
        'bttReenviarVentas
        '
        Me.bttReenviarVentas.Caption = "Reenviar ventas"
        Me.bttReenviarVentas.Id = 138
        Me.bttReenviarVentas.Name = "bttReenviarVentas"
        '
        'menuSorteos
        '
        Me.menuSorteos.Caption = "Fidelización"
        Me.menuSorteos.Id = 114
        Me.menuSorteos.Name = "menuSorteos"
        '
        'BarSubItem2
        '
        Me.BarSubItem2.Caption = "Terminales"
        Me.BarSubItem2.Id = 118
        Me.BarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.menuPuertoLector), New DevExpress.XtraBars.LinkPersistInfo(Me.menuRecepcionEtiquetas), New DevExpress.XtraBars.LinkPersistInfo(Me.menuRecepcionPedidos), New DevExpress.XtraBars.LinkPersistInfo(Me.menuRecepcionInventario), New DevExpress.XtraBars.LinkPersistInfo(Me.menuComprobacionInventario), New DevExpress.XtraBars.LinkPersistInfo(Me.bttEnviarDatosTerminal)})
        Me.BarSubItem2.Name = "BarSubItem2"
        '
        'menuPuertoLector
        '
        Me.menuPuertoLector.Caption = "Puerto Lector Terminal"
        Me.menuPuertoLector.Edit = Me.cmbPuertosLector
        Me.menuPuertoLector.Id = 130
        Me.menuPuertoLector.Name = "menuPuertoLector"
        '
        'cmbPuertosLector
        '
        Me.cmbPuertosLector.AutoHeight = False
        Me.cmbPuertosLector.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPuertosLector.Items.AddRange(New Object() {""})
        Me.cmbPuertosLector.Name = "cmbPuertosLector"
        Me.cmbPuertosLector.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'menuRecepcionEtiquetas
        '
        Me.menuRecepcionEtiquetas.Caption = "Recepción de Etiquetas"
        Me.menuRecepcionEtiquetas.Id = 119
        Me.menuRecepcionEtiquetas.Name = "menuRecepcionEtiquetas"
        '
        'menuRecepcionPedidos
        '
        Me.menuRecepcionPedidos.Caption = "Recepción de Pedidos"
        Me.menuRecepcionPedidos.Id = 120
        Me.menuRecepcionPedidos.Name = "menuRecepcionPedidos"
        '
        'menuRecepcionInventario
        '
        Me.menuRecepcionInventario.Caption = "Recepción de Inventario"
        Me.menuRecepcionInventario.Id = 121
        Me.menuRecepcionInventario.Name = "menuRecepcionInventario"
        '
        'menuComprobacionInventario
        '
        Me.menuComprobacionInventario.Caption = "Comprobación de Inventario"
        Me.menuComprobacionInventario.Id = 122
        Me.menuComprobacionInventario.Name = "menuComprobacionInventario"
        '
        'bttEnviarDatosTerminal
        '
        Me.bttEnviarDatosTerminal.Caption = "Enviar Datos a Terminal"
        Me.bttEnviarDatosTerminal.Id = 157
        Me.bttEnviarDatosTerminal.Name = "bttEnviarDatosTerminal"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Báscula"
        Me.BarSubItem3.Id = 132
        Me.BarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.menuPuertoBascula), New DevExpress.XtraBars.LinkPersistInfo(Me.menuTiempoEspera), New DevExpress.XtraBars.LinkPersistInfo(Me.bttDirectorioComunicacion), New DevExpress.XtraBars.LinkPersistInfo(Me.bttReiniciarComunicacionBascula)})
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'menuPuertoBascula
        '
        Me.menuPuertoBascula.Caption = "Puerto Báscula Pesaje"
        Me.menuPuertoBascula.Edit = Me.cmbPuertosBascula
        Me.menuPuertoBascula.Id = 133
        Me.menuPuertoBascula.Name = "menuPuertoBascula"
        '
        'cmbPuertosBascula
        '
        Me.cmbPuertosBascula.AutoHeight = False
        Me.cmbPuertosBascula.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbPuertosBascula.Items.AddRange(New Object() {""})
        Me.cmbPuertosBascula.Name = "cmbPuertosBascula"
        Me.cmbPuertosBascula.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'menuTiempoEspera
        '
        Me.menuTiempoEspera.Caption = "Tiempo Espera"
        Me.menuTiempoEspera.Edit = Me.txtTiempoEspera
        Me.menuTiempoEspera.EditValue = "50"
        Me.menuTiempoEspera.Id = 134
        Me.menuTiempoEspera.Name = "menuTiempoEspera"
        Me.menuTiempoEspera.Width = 100
        '
        'txtTiempoEspera
        '
        Me.txtTiempoEspera.Alignment = DevExpress.Utils.VertAlignment.Bottom
        Me.txtTiempoEspera.Maximum = 100
        Me.txtTiempoEspera.Name = "txtTiempoEspera"
        Me.txtTiempoEspera.TickFrequency = 5
        '
        'bttDirectorioComunicacion
        '
        Me.bttDirectorioComunicacion.Caption = "Directorio Comunicación"
        Me.bttDirectorioComunicacion.Id = 143
        Me.bttDirectorioComunicacion.Name = "bttDirectorioComunicacion"
        '
        'bttReiniciarComunicacionBascula
        '
        Me.bttReiniciarComunicacionBascula.Caption = "Reiniciar Comunicación"
        Me.bttReiniciarComunicacionBascula.Id = 142
        Me.bttReiniciarComunicacionBascula.Name = "bttReiniciarComunicacionBascula"
        '
        'menuGeneracionVales
        '
        Me.menuGeneracionVales.Caption = "Generación de Vales de Clientes"
        Me.menuGeneracionVales.Id = 144
        Me.menuGeneracionVales.Name = "menuGeneracionVales"
        '
        'menuExportarContabilidad
        '
        Me.menuExportarContabilidad.Caption = "Exportar a Contabilidad"
        Me.menuExportarContabilidad.Id = 146
        Me.menuExportarContabilidad.Name = "menuExportarContabilidad"
        '
        'menuExportarAlbaranes
        '
        Me.menuExportarAlbaranes.Caption = "Exportar Albaranes"
        Me.menuExportarAlbaranes.Id = 150
        Me.menuExportarAlbaranes.Name = "menuExportarAlbaranes"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "Comunicación proveedores"
        Me.BarSubItem4.Id = 152
        Me.BarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarSubItem5)})
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "EHLIS"
        Me.BarSubItem5.Id = 155
        Me.BarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bttEHLIS_Tarifas), New DevExpress.XtraBars.LinkPersistInfo(Me.bttEHLIS_Albaranes), New DevExpress.XtraBars.LinkPersistInfo(Me.bttEHLIS_Promociones)})
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'bttEHLIS_Tarifas
        '
        Me.bttEHLIS_Tarifas.Caption = "Tarifas"
        Me.bttEHLIS_Tarifas.Id = 153
        Me.bttEHLIS_Tarifas.Name = "bttEHLIS_Tarifas"
        '
        'bttEHLIS_Albaranes
        '
        Me.bttEHLIS_Albaranes.Caption = "Albaranes"
        Me.bttEHLIS_Albaranes.Id = 154
        Me.bttEHLIS_Albaranes.Name = "bttEHLIS_Albaranes"
        '
        'bttEHLIS_Promociones
        '
        Me.bttEHLIS_Promociones.Caption = "Promociones"
        Me.bttEHLIS_Promociones.Id = 156
        Me.bttEHLIS_Promociones.Name = "bttEHLIS_Promociones"
        '
        'menuConfiguracion
        '
        Me.menuConfiguracion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.menuConfiguracion.Caption = "Configuración"
        Me.menuConfiguracion.Id = 124
        Me.menuConfiguracion.ImageIndex = 17
        Me.menuConfiguracion.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bttActualizarAplicacion), New DevExpress.XtraBars.LinkPersistInfo(Me.menuTema), New DevExpress.XtraBars.LinkPersistInfo(Me.menuConexion), New DevExpress.XtraBars.LinkPersistInfo(Me.menuInfo)})
        Me.menuConfiguracion.Name = "menuConfiguracion"
        Me.menuConfiguracion.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'bttActualizarAplicacion
        '
        Me.bttActualizarAplicacion.Caption = "Actualizar"
        Me.bttActualizarAplicacion.Id = 123
        Me.bttActualizarAplicacion.ImageIndex = 47
        Me.bttActualizarAplicacion.Name = "bttActualizarAplicacion"
        '
        'menuTema
        '
        Me.menuTema.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.menuTema.Caption = "Apariencia"
        Me.menuTema.Edit = Me.RepositoryItemComboBox1
        Me.menuTema.Id = 109
        Me.menuTema.ImageIndex = 36
        Me.menuTema.Name = "menuTema"
        Me.menuTema.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        Me.menuTema.Width = 40
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Caramel", "Money Twins", "Lilian", "The Asphalt World", "iMaginary", "Black", "Blue", "-------------------", "Office 2010 Blue", "Office 2010 Black", "Office 2010 Silver", "Office 2007 Blue", "Office 2007 Black", "Office 2007 Silver", "Office 2007 Pink", "Office 2007 Green", "-------------------", "Seven", "Seven Classic", "-------------------", "VS 2010", "-------------------", "DevExpress", "DevExpress Dark", "Sharp", "Sharp+", "Foggy", "Darkroom", "High Contrast", "Springtime", "Pumpkin", "Summer", "Xmas", "McSkin", "Valentine", "Dark Side", "Blueprint", "Whiteprint", "Coffee", "Glass Oceans", "Stardust", "Liquid Sky", "London Liquid Sky"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        Me.RepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'menuConexion
        '
        Me.menuConexion.Caption = "Conexión"
        Me.menuConexion.Id = 125
        Me.menuConexion.ImageIndex = 42
        Me.menuConexion.Name = "menuConexion"
        '
        'menuInfo
        '
        Me.menuInfo.Caption = "Información"
        Me.menuInfo.Id = 139
        Me.menuInfo.ImageIndex = 51
        Me.menuInfo.Name = "menuInfo"
        '
        'Bar4
        '
        Me.Bar4.BarName = "Status bar"
        Me.Bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar4.DockCol = 0
        Me.Bar4.DockRow = 0
        Me.Bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem2), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bttImpresora, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bttTeclado, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bttCerrarNavegador, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bttPaginaAnterior, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bttPaginaSiguiente, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.bttWebIda, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)})
        Me.Bar4.OptionsBar.AllowQuickCustomization = False
        Me.Bar4.OptionsBar.DrawDragBorder = False
        Me.Bar4.OptionsBar.UseWholeRow = True
        Me.Bar4.Text = "Status bar"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "Impresora de Tickets:"
        Me.BarStaticItem2.Id = 76
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bttImpresora
        '
        Me.bttImpresora.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left
        Me.bttImpresora.Caption = "No Impresora"
        Me.bttImpresora.Id = 86
        Me.bttImpresora.ImageIndex = 44
        Me.bttImpresora.Name = "bttImpresora"
        '
        'bttTeclado
        '
        Me.bttTeclado.Caption = "Teclado"
        Me.bttTeclado.Description = "Teclado virtual"
        Me.bttTeclado.Id = 96
        Me.bttTeclado.ImageIndex = 49
        Me.bttTeclado.Name = "bttTeclado"
        '
        'bttCerrarNavegador
        '
        Me.bttCerrarNavegador.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bttCerrarNavegador.Caption = "Cerrar"
        Me.bttCerrarNavegador.Id = 82
        Me.bttCerrarNavegador.ImageIndex = 48
        Me.bttCerrarNavegador.Name = "bttCerrarNavegador"
        Me.bttCerrarNavegador.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bttPaginaAnterior
        '
        Me.bttPaginaAnterior.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bttPaginaAnterior.Id = 80
        Me.bttPaginaAnterior.ImageIndex = 45
        Me.bttPaginaAnterior.Name = "bttPaginaAnterior"
        Me.bttPaginaAnterior.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bttPaginaSiguiente
        '
        Me.bttPaginaSiguiente.Id = 81
        Me.bttPaginaSiguiente.ImageIndex = 46
        Me.bttPaginaSiguiente.Name = "bttPaginaSiguiente"
        Me.bttPaginaSiguiente.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'bttWebIda
        '
        Me.bttWebIda.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.bttWebIda.Caption = "Integración y Desarrollo de Aplicaciones, S.L."
        Me.bttWebIda.Id = 78
        Me.bttWebIda.ImageIndex = 47
        Me.bttWebIda.Name = "bttWebIda"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1008, 24)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 643)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1008, 27)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 619)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1008, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 619)
        '
        'BarListItem1
        '
        Me.BarListItem1.Caption = "BarListItem1"
        Me.BarListItem1.Id = 10
        Me.BarListItem1.Name = "BarListItem1"
        '
        'NavProcesosEspeciales
        '
        Me.NavProcesosEspeciales.Caption = "Procesos Especiales"
        Me.NavProcesosEspeciales.Id = 13
        Me.NavProcesosEspeciales.ImageIndex = 19
        Me.NavProcesosEspeciales.ImageIndexDisabled = 19
        Me.NavProcesosEspeciales.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bttComunicaTexlon), New DevExpress.XtraBars.LinkPersistInfo(Me.bttRecuperaTickets), New DevExpress.XtraBars.LinkPersistInfo(Me.bttComunicaProveedor)})
        Me.NavProcesosEspeciales.Name = "NavProcesosEspeciales"
        '
        'bttComunicaTexlon
        '
        Me.bttComunicaTexlon.Caption = "Comunica TELXON"
        Me.bttComunicaTexlon.Id = 25
        Me.bttComunicaTexlon.Name = "bttComunicaTexlon"
        '
        'bttRecuperaTickets
        '
        Me.bttRecuperaTickets.Caption = "Recupera Tickect"
        Me.bttRecuperaTickets.Id = 26
        Me.bttRecuperaTickets.Name = "bttRecuperaTickets"
        '
        'bttComunicaProveedor
        '
        Me.bttComunicaProveedor.Caption = "Comunica Proveedor"
        Me.bttComunicaProveedor.Id = 27
        Me.bttComunicaProveedor.Name = "bttComunicaProveedor"
        '
        'menuEntradaCambios
        '
        Me.menuEntradaCambios.Caption = "Entrada de Cambios"
        Me.menuEntradaCambios.Id = 17
        Me.menuEntradaCambios.ImageIndex = 2
        Me.menuEntradaCambios.Name = "menuEntradaCambios"
        '
        'menuRetiradaFondos
        '
        Me.menuRetiradaFondos.Caption = "Retirada de Fondos"
        Me.menuRetiradaFondos.Id = 18
        Me.menuRetiradaFondos.ImageIndex = 3
        Me.menuRetiradaFondos.Name = "menuRetiradaFondos"
        '
        'menuPagosPorCaja
        '
        Me.menuPagosPorCaja.Caption = "Pagos por Caja"
        Me.menuPagosPorCaja.Id = 19
        Me.menuPagosPorCaja.ImageIndex = 4
        Me.menuPagosPorCaja.Name = "menuPagosPorCaja"
        '
        'menuCobrosCliente
        '
        Me.menuCobrosCliente.Caption = "Cobros de Cliente"
        Me.menuCobrosCliente.Id = 20
        Me.menuCobrosCliente.ImageIndex = 5
        Me.menuCobrosCliente.Name = "menuCobrosCliente"
        '
        'menuEmisionVales
        '
        Me.menuEmisionVales.Caption = "Emisión de Vales"
        Me.menuEmisionVales.Id = 21
        Me.menuEmisionVales.ImageIndex = 6
        Me.menuEmisionVales.Name = "menuEmisionVales"
        '
        'menuTratamientoPromociones
        '
        Me.menuTratamientoPromociones.Id = 66
        Me.menuTratamientoPromociones.Name = "menuTratamientoPromociones"
        '
        'menuListadoIncidencias
        '
        Me.menuListadoIncidencias.Caption = "Listado de Incidencias"
        Me.menuListadoIncidencias.Id = 148
        Me.menuListadoIncidencias.ImageIndex = 33
        Me.menuListadoIncidencias.Name = "menuListadoIncidencias"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'bttDirectorioBascula
        '
        Me.bttDirectorioBascula.AutoHeight = False
        Me.bttDirectorioBascula.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.bttDirectorioBascula.Name = "bttDirectorioBascula"
        Me.bttDirectorioBascula.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'panelInicio
        '
        Me.panelInicio.Appearance.BackColor = System.Drawing.Color.White
        Me.panelInicio.Appearance.Options.UseBackColor = True
        Me.panelInicio.Controls.Add(Me.panelDatosIDA)
        Me.panelInicio.Controls.Add(Me.WebBrowser1)
        Me.panelInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelInicio.Location = New System.Drawing.Point(175, 24)
        Me.panelInicio.Name = "panelInicio"
        Me.panelInicio.Size = New System.Drawing.Size(833, 619)
        Me.panelInicio.TabIndex = 5
        '
        'panelDatosIDA
        '
        Me.panelDatosIDA.Controls.Add(Me.Inicio1)
        Me.panelDatosIDA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDatosIDA.Location = New System.Drawing.Point(2, 2)
        Me.panelDatosIDA.Name = "panelDatosIDA"
        Me.panelDatosIDA.Size = New System.Drawing.Size(829, 615)
        Me.panelDatosIDA.TabIndex = 7
        '
        'Inicio1
        '
        Me.Inicio1.BackgroundImage = CType(resources.GetObject("Inicio1.BackgroundImage"), System.Drawing.Image)
        Me.Inicio1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Inicio1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Inicio1.Location = New System.Drawing.Point(2, 2)
        Me.Inicio1.Name = "Inicio1"
        Me.Inicio1.Size = New System.Drawing.Size(825, 611)
        Me.Inicio1.TabIndex = 0
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(2, 2)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(829, 615)
        Me.WebBrowser1.TabIndex = 6
        Me.WebBrowser1.Url = New System.Uri("", System.UriKind.Relative)
        Me.WebBrowser1.Visible = False
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Generación de Vales de Clientes"
        Me.BarButtonItem1.Id = 144
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'Principal
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 670)
        Me.Controls.Add(Me.panelInicio)
        Me.Controls.Add(Me.MenuLateral)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Principal"
        Me.Text = "Aydara TPV"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Main, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icMenuSuperior, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuLateral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icMenuLateral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPuertosLector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPuertosBascula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTiempoEspera, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttDirectorioBascula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInicio.ResumeLayout(False)
        CType(Me.panelDatosIDA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelDatosIDA.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Main As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents MenuLateral As DevExpress.XtraNavBar.NavBarControl
    Friend WithEvents bttClientes As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttArticulos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttFamilias As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents txtVersion As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Bar4 As DevExpress.XtraBars.Bar
    Friend WithEvents NavMantenimiento As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menuClientes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuArticulos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuFamilias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttProveedores As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents menuProveedores As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuEmpleados As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttEmpleados As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttCajas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents menuCajas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttTiendas As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents menuTiendas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttHerramientas As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents bttConfiguracion As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents icMenuSuperior As DevExpress.Utils.ImageCollection
    Friend WithEvents bttHistoricoTickets As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents bttProcesosGestion As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents BarListItem1 As DevExpress.XtraBars.BarListItem
    Friend WithEvents NavProcesosCaja As DevExpress.XtraBars.BarSubItem
    Friend WithEvents NavProcesosEspeciales As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menuProcesoGestion As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menuEntradaCambios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuRetiradaFondos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuPagosPorCaja As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuCobrosCliente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuEmisionVales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents NavHistoricoTickets As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bttComunicaTexlon As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttRecuperaTickets As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttComunicaProveedor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuListadosConsultas As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menuControlExistencias As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menuUtilidades As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menuListadoFicheroArticulos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuListadoFicheroClientes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuListadoFicheroProveedores As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuListadoTarifasPrecios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuConsultaSaldosClientes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuConsultaValesPendientes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuListadoEtiquetas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuEntradasMercancia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuCargaManualPedidosAlmacen As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuListadoPedidosProveedor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuListadoInventarioTienda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuModificacionTarifasPrecios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuTratamientoPromociones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents panelInicio As DevExpress.XtraEditors.PanelControl
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bttWebIda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttPaginaAnterior As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttPaginaSiguiente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttCerrarNavegador As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttCierreCaja As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttCierreTienda As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttEmisionTikets As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttMovimientosCaja As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttProcesoCaja As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents bttPorcesosCaja As DevExpress.XtraNavBar.NavBarGroup
    Friend WithEvents bttConsultasHistoricoTicket As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttRelacionTicketDia As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttMantenimientoVales As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttResumenVentasHoras As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttGeneracionAsientoContable As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttGeneracionFicheroAlbaranes As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents menuTallas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuColores As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttImpresora As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents menuMovimientosCaja As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuEmisionTickets As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuCierreCaja As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuCierreTienda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuProcesosVarios As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menuPromociones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttTeclado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuSituacionTienda As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuConsultaHistoricoTicket As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuRelacionTicketDia As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuMantenimientoVales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuComunicaciones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuCopiasSeguridad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttSituacionTienda As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttComunicaciones As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttCopiasSeguridad As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttModificacionPrecios As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttTratamientoPromociones As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttEntradasMercancia As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents bttPedidos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents panelDatosIDA As DevExpress.XtraEditors.PanelControl
    Friend WithEvents menuTiposUnidades As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Inicio1 As AydaraTPV.Inicio
    Friend WithEvents icMenuLateral As DevExpress.Utils.ImageCollection
    Friend WithEvents menuTema As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents menuCubosEstadisticos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttCubosEstadisticos As DevExpress.XtraNavBar.NavBarItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menuRecepcion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuEnvio As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuSorteos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuTraspasoAlmacenes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem2 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menuRecepcionEtiquetas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuRecepcionPedidos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuRecepcionInventario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuComprobacionInventario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttActualizarAplicacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuConfiguracion As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menuConexion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuStockMinimoMaximo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuPuertoLector As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cmbPuertosLector As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menuPuertoBascula As DevExpress.XtraBars.BarEditItem
    Friend WithEvents cmbPuertosBascula As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents menuTiempoEspera As DevExpress.XtraBars.BarEditItem
    Friend WithEvents txtTiempoEspera As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
    Friend WithEvents bttExportarImagenes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttImportarImagenes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttExportarPromociones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttReenviarVentas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuInfo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttRedimensionarImagenes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttDirectorioBascula As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents bttReiniciarComunicacionBascula As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttDirectorioComunicacion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuGeneracionVales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuExportarContabilidad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuIncidencias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuListadoIncidencias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuExportarAlbaranes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttTiposIncidencias As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bttEHLIS_Tarifas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttEHLIS_Albaranes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents bttEHLIS_Promociones As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttEnviarDatosTerminal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuPreciosBasculas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menuActualizarEtiquetasElectronicas As DevExpress.XtraBars.BarButtonItem
End Class
