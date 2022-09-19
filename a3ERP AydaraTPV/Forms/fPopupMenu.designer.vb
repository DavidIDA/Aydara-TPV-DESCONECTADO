<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fPopupMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fPopupMenu))
        Me.BarManagerArticulo = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.bttArticuloEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bttPreciosEspeciales = New DevExpress.XtraBars.BarButtonItem()
        Me.bttArticuloNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bttArticuloTodos = New DevExpress.XtraBars.BarButtonItem()
        Me.bttArticuloBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.bttHistorico = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenuArticulo = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.PopupMenuProveedor = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.bttProveedorEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bttProveedorNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bttProveedorTodos = New DevExpress.XtraBars.BarButtonItem()
        Me.bttProveedorBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManagerProveedor = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl5 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl6 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl7 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl8 = New DevExpress.XtraBars.BarDockControl()
        Me.bttFichaProveedor = New DevExpress.XtraBars.BarButtonItem()
        Me.bttCartera = New DevExpress.XtraBars.BarButtonItem()
        Me.bttEstadisticasComparativas = New DevExpress.XtraBars.BarButtonItem()
        Me.bttEstadisticasAnalitica = New DevExpress.XtraBars.BarButtonItem()
        Me.bttSuministros = New DevExpress.XtraBars.BarButtonItem()
        Me.bttSituacionPedidos = New DevExpress.XtraBars.BarButtonItem()
        Me.bttSituacionAlbaranes = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenuCliente = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.bttClienteEditar = New DevExpress.XtraBars.BarButtonItem()
        Me.bttClienteNuevo = New DevExpress.XtraBars.BarButtonItem()
        Me.bttClienteTodos = New DevExpress.XtraBars.BarButtonItem()
        Me.bttClienteBuscar = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManagerCliente = New DevExpress.XtraBars.BarManager(Me.components)
        Me.BarDockControl9 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl10 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl11 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl12 = New DevExpress.XtraBars.BarDockControl()
        Me.bttFichaCliente = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.BarManagerArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManagerProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManagerCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManagerArticulo
        '
        Me.BarManagerArticulo.DockControls.Add(Me.BarDockControl1)
        Me.BarManagerArticulo.DockControls.Add(Me.BarDockControl2)
        Me.BarManagerArticulo.DockControls.Add(Me.BarDockControl3)
        Me.BarManagerArticulo.DockControls.Add(Me.BarDockControl4)
        Me.BarManagerArticulo.Form = Me
        Me.BarManagerArticulo.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bttArticuloEditar, Me.bttPreciosEspeciales, Me.bttArticuloNuevo, Me.bttArticuloTodos, Me.bttArticuloBuscar, Me.bttHistorico})
        Me.BarManagerArticulo.MaxItemId = 7
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl1.Size = New System.Drawing.Size(284, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 262)
        Me.BarDockControl2.Size = New System.Drawing.Size(284, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 262)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(284, 0)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 262)
        '
        'bttArticuloEditar
        '
        Me.bttArticuloEditar.Caption = "Mantenimiento <registro actual>"
        Me.bttArticuloEditar.Glyph = CType(resources.GetObject("bttArticuloEditar.Glyph"), System.Drawing.Image)
        Me.bttArticuloEditar.Id = 0
        Me.bttArticuloEditar.LargeGlyph = CType(resources.GetObject("bttArticuloEditar.LargeGlyph"), System.Drawing.Image)
        Me.bttArticuloEditar.Name = "bttArticuloEditar"
        '
        'bttPreciosEspeciales
        '
        Me.bttPreciosEspeciales.Caption = "Precios especiales"
        Me.bttPreciosEspeciales.Glyph = CType(resources.GetObject("bttPreciosEspeciales.Glyph"), System.Drawing.Image)
        Me.bttPreciosEspeciales.Id = 1
        Me.bttPreciosEspeciales.LargeGlyph = CType(resources.GetObject("bttPreciosEspeciales.LargeGlyph"), System.Drawing.Image)
        Me.bttPreciosEspeciales.Name = "bttPreciosEspeciales"
        '
        'bttArticuloNuevo
        '
        Me.bttArticuloNuevo.Caption = "Mantenimiento <registro nuevo>"
        Me.bttArticuloNuevo.Glyph = CType(resources.GetObject("bttArticuloNuevo.Glyph"), System.Drawing.Image)
        Me.bttArticuloNuevo.Id = 3
        Me.bttArticuloNuevo.LargeGlyph = CType(resources.GetObject("bttArticuloNuevo.LargeGlyph"), System.Drawing.Image)
        Me.bttArticuloNuevo.Name = "bttArticuloNuevo"
        '
        'bttArticuloTodos
        '
        Me.bttArticuloTodos.Caption = "Mantenmiento <todos registros>"
        Me.bttArticuloTodos.Glyph = CType(resources.GetObject("bttArticuloTodos.Glyph"), System.Drawing.Image)
        Me.bttArticuloTodos.Id = 4
        Me.bttArticuloTodos.LargeGlyph = CType(resources.GetObject("bttArticuloTodos.LargeGlyph"), System.Drawing.Image)
        Me.bttArticuloTodos.LargeGlyphDisabled = CType(resources.GetObject("bttArticuloTodos.LargeGlyphDisabled"), System.Drawing.Image)
        Me.bttArticuloTodos.Name = "bttArticuloTodos"
        '
        'bttArticuloBuscar
        '
        Me.bttArticuloBuscar.Caption = "Selección"
        Me.bttArticuloBuscar.Glyph = CType(resources.GetObject("bttArticuloBuscar.Glyph"), System.Drawing.Image)
        Me.bttArticuloBuscar.Id = 5
        Me.bttArticuloBuscar.LargeGlyph = CType(resources.GetObject("bttArticuloBuscar.LargeGlyph"), System.Drawing.Image)
        Me.bttArticuloBuscar.Name = "bttArticuloBuscar"
        '
        'bttHistorico
        '
        Me.bttHistorico.Caption = "Histórico"
        Me.bttHistorico.Glyph = CType(resources.GetObject("bttHistorico.Glyph"), System.Drawing.Image)
        Me.bttHistorico.Id = 6
        Me.bttHistorico.LargeGlyph = CType(resources.GetObject("bttHistorico.LargeGlyph"), System.Drawing.Image)
        Me.bttHistorico.Name = "bttHistorico"
        '
        'PopupMenuArticulo
        '
        Me.PopupMenuArticulo.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bttArticuloEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bttArticuloNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bttArticuloTodos), New DevExpress.XtraBars.LinkPersistInfo(Me.bttArticuloBuscar)})
        Me.PopupMenuArticulo.Manager = Me.BarManagerArticulo
        Me.PopupMenuArticulo.Name = "PopupMenuArticulo"
        '
        'PopupMenuProveedor
        '
        Me.PopupMenuProveedor.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bttProveedorEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bttProveedorNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bttProveedorTodos), New DevExpress.XtraBars.LinkPersistInfo(Me.bttProveedorBuscar)})
        Me.PopupMenuProveedor.Manager = Me.BarManagerProveedor
        Me.PopupMenuProveedor.Name = "PopupMenuProveedor"
        '
        'bttProveedorEditar
        '
        Me.bttProveedorEditar.Caption = "Mantenimiento <registro actual>"
        Me.bttProveedorEditar.Glyph = CType(resources.GetObject("bttProveedorEditar.Glyph"), System.Drawing.Image)
        Me.bttProveedorEditar.Id = 22
        Me.bttProveedorEditar.LargeGlyph = CType(resources.GetObject("bttProveedorEditar.LargeGlyph"), System.Drawing.Image)
        Me.bttProveedorEditar.Name = "bttProveedorEditar"
        '
        'bttProveedorNuevo
        '
        Me.bttProveedorNuevo.Caption = "Mantenimiento <registro nuevo>"
        Me.bttProveedorNuevo.Glyph = CType(resources.GetObject("bttProveedorNuevo.Glyph"), System.Drawing.Image)
        Me.bttProveedorNuevo.Id = 21
        Me.bttProveedorNuevo.LargeGlyph = CType(resources.GetObject("bttProveedorNuevo.LargeGlyph"), System.Drawing.Image)
        Me.bttProveedorNuevo.Name = "bttProveedorNuevo"
        '
        'bttProveedorTodos
        '
        Me.bttProveedorTodos.Caption = "Mantenimiento <todos registros>"
        Me.bttProveedorTodos.Glyph = CType(resources.GetObject("bttProveedorTodos.Glyph"), System.Drawing.Image)
        Me.bttProveedorTodos.Id = 23
        Me.bttProveedorTodos.LargeGlyph = CType(resources.GetObject("bttProveedorTodos.LargeGlyph"), System.Drawing.Image)
        Me.bttProveedorTodos.Name = "bttProveedorTodos"
        '
        'bttProveedorBuscar
        '
        Me.bttProveedorBuscar.Caption = "Selección (F12)"
        Me.bttProveedorBuscar.Glyph = CType(resources.GetObject("bttProveedorBuscar.Glyph"), System.Drawing.Image)
        Me.bttProveedorBuscar.Id = 24
        Me.bttProveedorBuscar.LargeGlyph = CType(resources.GetObject("bttProveedorBuscar.LargeGlyph"), System.Drawing.Image)
        Me.bttProveedorBuscar.Name = "bttProveedorBuscar"
        '
        'BarManagerProveedor
        '
        Me.BarManagerProveedor.AutoSaveInRegistry = True
        Me.BarManagerProveedor.DockControls.Add(Me.BarDockControl5)
        Me.BarManagerProveedor.DockControls.Add(Me.BarDockControl6)
        Me.BarManagerProveedor.DockControls.Add(Me.BarDockControl7)
        Me.BarManagerProveedor.DockControls.Add(Me.BarDockControl8)
        Me.BarManagerProveedor.Form = Me
        Me.BarManagerProveedor.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bttFichaProveedor, Me.bttCartera, Me.bttEstadisticasComparativas, Me.bttEstadisticasAnalitica, Me.bttSuministros, Me.bttSituacionPedidos, Me.bttSituacionAlbaranes, Me.bttProveedorNuevo, Me.bttProveedorEditar, Me.bttProveedorTodos, Me.bttProveedorBuscar, Me.BarButtonItem1, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5})
        Me.BarManagerProveedor.MaxItemId = 31
        '
        'BarDockControl5
        '
        Me.BarDockControl5.CausesValidation = False
        Me.BarDockControl5.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl5.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl5.Size = New System.Drawing.Size(284, 0)
        '
        'BarDockControl6
        '
        Me.BarDockControl6.CausesValidation = False
        Me.BarDockControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl6.Location = New System.Drawing.Point(0, 262)
        Me.BarDockControl6.Size = New System.Drawing.Size(284, 0)
        '
        'BarDockControl7
        '
        Me.BarDockControl7.CausesValidation = False
        Me.BarDockControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl7.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl7.Size = New System.Drawing.Size(0, 262)
        '
        'BarDockControl8
        '
        Me.BarDockControl8.CausesValidation = False
        Me.BarDockControl8.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl8.Location = New System.Drawing.Point(284, 0)
        Me.BarDockControl8.Size = New System.Drawing.Size(0, 262)
        '
        'bttFichaProveedor
        '
        Me.bttFichaProveedor.Caption = "Ficha proveedor"
        Me.bttFichaProveedor.Glyph = CType(resources.GetObject("bttFichaProveedor.Glyph"), System.Drawing.Image)
        Me.bttFichaProveedor.Id = 12
        Me.bttFichaProveedor.LargeGlyph = CType(resources.GetObject("bttFichaProveedor.LargeGlyph"), System.Drawing.Image)
        Me.bttFichaProveedor.Name = "bttFichaProveedor"
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
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Mantenimiento <registro actual>"
        Me.BarButtonItem1.Glyph = CType(resources.GetObject("BarButtonItem1.Glyph"), System.Drawing.Image)
        Me.BarButtonItem1.Id = 26
        Me.BarButtonItem1.LargeGlyph = CType(resources.GetObject("BarButtonItem1.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Mantenimiento <registro nuevo>"
        Me.BarButtonItem2.Id = 27
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem2"
        Me.BarButtonItem3.Id = 28
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "BarButtonItem3"
        Me.BarButtonItem4.Id = 29
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "BarButtonItem4"
        Me.BarButtonItem5.Id = 30
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'PopupMenuCliente
        '
        Me.PopupMenuCliente.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bttClienteEditar), New DevExpress.XtraBars.LinkPersistInfo(Me.bttClienteNuevo), New DevExpress.XtraBars.LinkPersistInfo(Me.bttClienteTodos), New DevExpress.XtraBars.LinkPersistInfo(Me.bttClienteBuscar)})
        Me.PopupMenuCliente.Manager = Me.BarManagerCliente
        Me.PopupMenuCliente.Name = "PopupMenuCliente"
        '
        'bttClienteEditar
        '
        Me.bttClienteEditar.Caption = "Mantenimiento <registro actual>"
        Me.bttClienteEditar.Glyph = CType(resources.GetObject("bttClienteEditar.Glyph"), System.Drawing.Image)
        Me.bttClienteEditar.Id = 22
        Me.bttClienteEditar.LargeGlyph = CType(resources.GetObject("bttClienteEditar.LargeGlyph"), System.Drawing.Image)
        Me.bttClienteEditar.Name = "bttClienteEditar"
        '
        'bttClienteNuevo
        '
        Me.bttClienteNuevo.Caption = "Mantenimiento <registro nuevo>"
        Me.bttClienteNuevo.Glyph = CType(resources.GetObject("bttClienteNuevo.Glyph"), System.Drawing.Image)
        Me.bttClienteNuevo.Id = 21
        Me.bttClienteNuevo.LargeGlyph = CType(resources.GetObject("bttClienteNuevo.LargeGlyph"), System.Drawing.Image)
        Me.bttClienteNuevo.Name = "bttClienteNuevo"
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
        'BarManagerCliente
        '
        Me.BarManagerCliente.AutoSaveInRegistry = True
        Me.BarManagerCliente.DockControls.Add(Me.BarDockControl9)
        Me.BarManagerCliente.DockControls.Add(Me.BarDockControl10)
        Me.BarManagerCliente.DockControls.Add(Me.BarDockControl11)
        Me.BarManagerCliente.DockControls.Add(Me.BarDockControl12)
        Me.BarManagerCliente.Form = Me
        Me.BarManagerCliente.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bttFichaCliente, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BarButtonItem11, Me.bttClienteNuevo, Me.bttClienteEditar, Me.bttClienteTodos, Me.bttClienteBuscar})
        Me.BarManagerCliente.MaxItemId = 26
        '
        'BarDockControl9
        '
        Me.BarDockControl9.CausesValidation = False
        Me.BarDockControl9.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl9.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl9.Size = New System.Drawing.Size(284, 0)
        '
        'BarDockControl10
        '
        Me.BarDockControl10.CausesValidation = False
        Me.BarDockControl10.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl10.Location = New System.Drawing.Point(0, 262)
        Me.BarDockControl10.Size = New System.Drawing.Size(284, 0)
        '
        'BarDockControl11
        '
        Me.BarDockControl11.CausesValidation = False
        Me.BarDockControl11.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl11.Location = New System.Drawing.Point(0, 0)
        Me.BarDockControl11.Size = New System.Drawing.Size(0, 262)
        '
        'BarDockControl12
        '
        Me.BarDockControl12.CausesValidation = False
        Me.BarDockControl12.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl12.Location = New System.Drawing.Point(284, 0)
        Me.BarDockControl12.Size = New System.Drawing.Size(0, 262)
        '
        'bttFichaCliente
        '
        Me.bttFichaCliente.Caption = "Ficha cliente"
        Me.bttFichaCliente.Glyph = CType(resources.GetObject("bttFichaCliente.Glyph"), System.Drawing.Image)
        Me.bttFichaCliente.Id = 12
        Me.bttFichaCliente.LargeGlyph = CType(resources.GetObject("bttFichaCliente.LargeGlyph"), System.Drawing.Image)
        Me.bttFichaCliente.Name = "bttFichaCliente"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Cartera"
        Me.BarButtonItem6.Glyph = CType(resources.GetObject("BarButtonItem6.Glyph"), System.Drawing.Image)
        Me.BarButtonItem6.Id = 13
        Me.BarButtonItem6.LargeGlyph = CType(resources.GetObject("BarButtonItem6.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Estadísticas comparativas"
        Me.BarButtonItem7.Glyph = CType(resources.GetObject("BarButtonItem7.Glyph"), System.Drawing.Image)
        Me.BarButtonItem7.Id = 14
        Me.BarButtonItem7.LargeGlyph = CType(resources.GetObject("BarButtonItem7.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Estadísticas analítica"
        Me.BarButtonItem8.Glyph = CType(resources.GetObject("BarButtonItem8.Glyph"), System.Drawing.Image)
        Me.BarButtonItem8.Id = 15
        Me.BarButtonItem8.LargeGlyph = CType(resources.GetObject("BarButtonItem8.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Suministros"
        Me.BarButtonItem9.Glyph = CType(resources.GetObject("BarButtonItem9.Glyph"), System.Drawing.Image)
        Me.BarButtonItem9.Id = 16
        Me.BarButtonItem9.LargeGlyph = CType(resources.GetObject("BarButtonItem9.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Situación de pedidos"
        Me.BarButtonItem10.Glyph = CType(resources.GetObject("BarButtonItem10.Glyph"), System.Drawing.Image)
        Me.BarButtonItem10.Id = 17
        Me.BarButtonItem10.LargeGlyph = CType(resources.GetObject("BarButtonItem10.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Situación albaranes"
        Me.BarButtonItem11.Glyph = CType(resources.GetObject("BarButtonItem11.Glyph"), System.Drawing.Image)
        Me.BarButtonItem11.Id = 18
        Me.BarButtonItem11.LargeGlyph = CType(resources.GetObject("BarButtonItem11.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'fPopupMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.BarDockControl7)
        Me.Controls.Add(Me.BarDockControl8)
        Me.Controls.Add(Me.BarDockControl6)
        Me.Controls.Add(Me.BarDockControl5)
        Me.Controls.Add(Me.BarDockControl11)
        Me.Controls.Add(Me.BarDockControl12)
        Me.Controls.Add(Me.BarDockControl10)
        Me.Controls.Add(Me.BarDockControl9)
        Me.Name = "fPopupMenu"
        Me.Text = "fPopupMenu"
        CType(Me.BarManagerArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManagerProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManagerCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManagerArticulo As DevExpress.XtraBars.BarManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl7 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl8 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl6 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl5 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl11 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl12 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl10 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl9 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents bttArticuloEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttPreciosEspeciales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttArticuloNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttArticuloTodos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttArticuloBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttHistorico As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttProveedorEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttProveedorNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttProveedorTodos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttProveedorBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManagerProveedor As DevExpress.XtraBars.BarManager
    Friend WithEvents bttFichaProveedor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttCartera As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttEstadisticasComparativas As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttEstadisticasAnalitica As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttSuministros As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttSituacionPedidos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttSituacionAlbaranes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttClienteEditar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttClienteNuevo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttClienteTodos As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bttClienteBuscar As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManagerCliente As DevExpress.XtraBars.BarManager
    Friend WithEvents bttFichaCliente As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenuArticulo As DevExpress.XtraBars.PopupMenu
    Friend WithEvents PopupMenuProveedor As DevExpress.XtraBars.PopupMenu
    Friend WithEvents PopupMenuCliente As DevExpress.XtraBars.PopupMenu
End Class
