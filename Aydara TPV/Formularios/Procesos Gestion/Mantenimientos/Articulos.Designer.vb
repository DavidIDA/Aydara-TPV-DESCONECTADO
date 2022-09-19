<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Articulos
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Articulos))
        Me.ARTICULOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New AydaraTPV.dsArticulos()
        Me.CODIGOBARRASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CheckCantidadVariable = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckControlEtiquetas = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.CheckControlBaja = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lblTextoImpuesto = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.bttEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescripcion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ARTICULOSTableAdapter = New AydaraTPV.dsArticulosTableAdapters.ARTICULOSTableAdapter()
        Me.CODIGO_BARRASTableAdapter = New AydaraTPV.dsArticulosTableAdapters.CODIGO_BARRASTableAdapter()
        Me.bttNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttModificar = New DevExpress.XtraEditors.SimpleButton()
        Me.NavListadoCodigoBarras = New DevExpress.XtraEditors.DataNavigator()
        Me.dgCodigoBarras = New DevExpress.XtraGrid.GridControl()
        Me.gvCodigoBarras = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colArticulo_Id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoBarras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskCodigoBarras = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colDescripcionColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoBarras_Color = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbCodigoBarrasColores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.COLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colDescripciontalla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoBarras_Talla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbCodigoBarrasTallas = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TALLASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtCodigo = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtCodigoFamilia = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtCodigoSubfamilia = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtCodigoProveedor = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtDescripcionFamilia = New DevExpress.XtraEditors.TextEdit()
        Me.txtDescripcionSubfamilia = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreProveedor = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoEnvase = New DevExpress.XtraEditors.ButtonEdit()
        Me.dgExistencias = New DevExpress.XtraGrid.GridControl()
        Me.EXISTENCIASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvExistencias = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colExistenciasCodigoTalla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExistenciasTalla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExistenciasExistenciaInicial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExistenciasExistenciaActual = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExistenciasStockMinimo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExistenciasStockMaximo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExistenciasPrecioVenta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colExistenciasCodigoBarras = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskCodigoBarrasTalla = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.lblCodigoTalla = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoTalla = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtFechaAlta = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txtUnidadCaja = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinimoVenta = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txtMinimoCompra = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPesoUnidad = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txtDescuento = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrecioVenta = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPrecioCoste = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExistenciaInicial = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txtExistenciasActual = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStockMinimo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txtStockMaximo = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.panelExistencias = New DevExpress.XtraEditors.GroupControl()
        Me.cmbTipoIVA = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtDescripcionEnvase = New DevExpress.XtraEditors.TextEdit()
        Me.colCodigoTalla = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabArticulo = New DevExpress.XtraTab.XtraTabControl()
        Me.TabTallasColores = New DevExpress.XtraTab.XtraTabPage()
        Me.lblColorSeleccionado = New DevExpress.XtraEditors.LabelControl()
        Me.lblEtiquetaColor = New DevExpress.XtraEditors.LabelControl()
        Me.NavListadoColores = New DevExpress.XtraEditors.DataNavigator()
        Me.ARTICULOSCOLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgColores = New DevExpress.XtraGrid.GridControl()
        Me.gvColores = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colColores_Id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColores_Articulo_Id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColores_Color_Id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbColores_Id = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colColores_Color = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbColores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.TabCodigoBarras = New DevExpress.XtraTab.XtraTabPage()
        Me.gcEtiquetaElectronica = New DevExpress.XtraEditors.GroupControl()
        Me.txtEE_Formato = New DevExpress.XtraEditors.LookUpEdit()
        Me.FORMATOSEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbCodigosBarras = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEE_Calibre = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEE_Categoria = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEE_Origen = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEE_CodigoBarras = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.xtpMovimientos = New DevExpress.XtraTab.XtraTabPage()
        Me.dgMovimientos = New DevExpress.XtraGrid.GridControl()
        Me.bsMovimientos = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvMovimientos = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEntrada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalida = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.bttExportarMovimientos = New DevExpress.XtraEditors.SimpleButton()
        Me.bttBuscarMovimientos = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaHasta = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFechaDesde = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.TabReferencias = New DevExpress.XtraTab.XtraTabPage()
        Me.dgProveedores = New DevExpress.XtraGrid.GridControl()
        Me.REFERENCIASPROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvProveedores = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCodigoProveedor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bttProveedor = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colNombreProveedor = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colReferencia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPrecioCoste = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.maskPrecioCoste_Proveedor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colPrecioVenta = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.maskPrecio_Proveedor = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colUnidadesCaja = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.colCompra_Albaran = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCompra_Fecha = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCompra_Unidades = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCompra_Precio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.TabInventarios = New DevExpress.XtraTab.XtraTabPage()
        Me.dgInventarios = New DevExpress.XtraGrid.GridControl()
        Me.HISTORICOINVENTARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsInventario = New AydaraTPV.dsInventario()
        Me.gvInventarios = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFecha1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.mskCantidad = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.COLORESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter()
        Me.EXISTENCIASTableAdapter = New AydaraTPV.dsArticulosTableAdapters.EXISTENCIASTableAdapter()
        Me.ARTICULOS_COLORESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.ARTICULOS_COLORESTableAdapter()
        Me.imgImagen = New DevExpress.XtraEditors.PictureEdit()
        Me.txtEtiqueta = New DevExpress.XtraEditors.TextEdit()
        Me.lblTipoIVA = New DevExpress.XtraEditors.LabelControl()
        Me.gcPromocion = New DevExpress.XtraEditors.GroupControl()
        Me.ImgPromocion = New DevExpress.XtraEditors.PictureEdit()
        Me.lblPrecioPromocion = New DevExpress.XtraEditors.LabelControl()
        Me.lblValidezPromocion = New DevExpress.XtraEditors.LabelControl()
        Me.bttAnterior = New DevExpress.XtraEditors.SimpleButton()
        Me.bttSiguiente = New DevExpress.XtraEditors.SimpleButton()
        Me.cmbTipoUnidad = New DevExpress.XtraEditors.LookUpEdit()
        Me.TIPOSUNIDADESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TIPOS_UNIDADESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.TIPOS_UNIDADESTableAdapter()
        Me.checkArticuloPeso = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTipoArticulo = New DevExpress.XtraEditors.TextEdit()
        Me.bttEliminarImagen = New DevExpress.XtraEditors.SimpleButton()
        Me.bttNuevaImagen = New DevExpress.XtraEditors.SimpleButton()
        Me.TALLASTableAdapter = New AydaraTPV.dsArticulosTableAdapters.TALLASTableAdapter()
        Me.checkTpvTactil = New DevExpress.XtraEditors.CheckEdit()
        Me.REFERENCIAS_PROVEEDORESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.REFERENCIAS_PROVEEDORESTableAdapter()
        Me.HISTORICO_INVENTARIOTableAdapter = New AydaraTPV.dsInventarioTableAdapters.HISTORICO_INVENTARIOTableAdapter()
        Me.txtDtoFidelizacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoBascula = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txtPLU = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.txtImporteEcoraee = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.txtEquivalencia = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.bttImprimirEtiqueta = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CODIGOBARRASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckCantidadVariable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckControlEtiquetas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckControlBaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCodigoBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCodigoBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskCodigoBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCodigoBarrasColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCodigoBarrasTallas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TALLASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoSubfamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionFamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionSubfamilia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoEnvase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgExistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EXISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvExistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskCodigoBarrasTalla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoTalla.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaAlta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaAlta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUnidadCaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinimoVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinimoCompra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPesoUnidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrecioCoste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistenciaInicial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExistenciasActual.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockMinimo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStockMaximo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelExistencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelExistencias.SuspendLayout()
        CType(Me.cmbTipoIVA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescripcionEnvase.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabArticulo.SuspendLayout()
        Me.TabTallasColores.SuspendLayout()
        CType(Me.ARTICULOSCOLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores_Id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCodigoBarras.SuspendLayout()
        CType(Me.gcEtiquetaElectronica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcEtiquetaElectronica.SuspendLayout()
        CType(Me.txtEE_Formato.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FORMATOSEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCodigosBarras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEE_Calibre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEE_Categoria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEE_Origen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEE_CodigoBarras.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xtpMovimientos.SuspendLayout()
        CType(Me.dgMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabReferencias.SuspendLayout()
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.REFERENCIASPROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecioCoste_Proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio_Proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabInventarios.SuspendLayout()
        CType(Me.dgInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HISTORICOINVENTARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mskCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgImagen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEtiqueta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcPromocion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcPromocion.SuspendLayout()
        CType(Me.ImgPromocion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTipoUnidad.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPOSUNIDADESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkArticuloPeso.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTipoArticulo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkTpvTactil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDtoFidelizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoBascula.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPLU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImporteEcoraee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEquivalencia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ARTICULOSBindingSource
        '
        Me.ARTICULOSBindingSource.DataMember = "ARTICULOS"
        Me.ARTICULOSBindingSource.DataSource = Me.DsArticulos
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "dsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CODIGOBARRASBindingSource
        '
        Me.CODIGOBARRASBindingSource.DataMember = "CODIGO_BARRAS"
        Me.CODIGOBARRASBindingSource.DataSource = Me.DsArticulos
        '
        'CheckCantidadVariable
        '
        Me.CheckCantidadVariable.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "CantidadVariable", True))
        Me.CheckCantidadVariable.Location = New System.Drawing.Point(322, 164)
        Me.CheckCantidadVariable.Name = "CheckCantidadVariable"
        Me.CheckCantidadVariable.Properties.Caption = "Cantidad variable:"
        Me.CheckCantidadVariable.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckCantidadVariable.Properties.ReadOnly = True
        Me.CheckCantidadVariable.Size = New System.Drawing.Size(110, 19)
        Me.CheckCantidadVariable.TabIndex = 10
        Me.CheckCantidadVariable.TabStop = False
        '
        'CheckControlEtiquetas
        '
        Me.CheckControlEtiquetas.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "ControlEtiquetas", True))
        Me.CheckControlEtiquetas.Location = New System.Drawing.Point(192, 164)
        Me.CheckControlEtiquetas.Name = "CheckControlEtiquetas"
        Me.CheckControlEtiquetas.Properties.Caption = "Control de etiquetas:"
        Me.CheckControlEtiquetas.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckControlEtiquetas.Properties.ReadOnly = True
        Me.CheckControlEtiquetas.Size = New System.Drawing.Size(124, 19)
        Me.CheckControlEtiquetas.TabIndex = 9
        Me.CheckControlEtiquetas.TabStop = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 142)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl5.TabIndex = 41
        Me.LabelControl5.Text = "Código envase:"
        '
        'CheckControlBaja
        '
        Me.CheckControlBaja.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "ControlBaja", True))
        Me.CheckControlBaja.Location = New System.Drawing.Point(438, 164)
        Me.CheckControlBaja.Name = "CheckControlBaja"
        Me.CheckControlBaja.Properties.Caption = "Control de baja"
        Me.CheckControlBaja.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckControlBaja.Properties.ReadOnly = True
        Me.CheckControlBaja.Size = New System.Drawing.Size(104, 19)
        Me.CheckControlBaja.TabIndex = 11
        Me.CheckControlBaja.TabStop = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(12, 116)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl8.TabIndex = 19
        Me.LabelControl8.Text = "Proveedor:"
        '
        'lblTextoImpuesto
        '
        Me.lblTextoImpuesto.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lblTextoImpuesto.Location = New System.Drawing.Point(582, 12)
        Me.lblTextoImpuesto.Name = "lblTextoImpuesto"
        Me.lblTextoImpuesto.Size = New System.Drawing.Size(72, 13)
        Me.lblTextoImpuesto.TabIndex = 17
        Me.lblTextoImpuesto.Text = "texto impuesto"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(12, 90)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Subfamilia:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 64)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl3.TabIndex = 9
        Me.LabelControl3.Text = "Familia:"
        '
        'bttEliminar
        '
        Me.bttEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttEliminar.Enabled = False
        Me.bttEliminar.Image = Global.AydaraTPV.My.Resources.Resources.delete2
        Me.bttEliminar.Location = New System.Drawing.Point(348, 509)
        Me.bttEliminar.Name = "bttEliminar"
        Me.bttEliminar.Size = New System.Drawing.Size(106, 45)
        Me.bttEliminar.TabIndex = 32
        Me.bttEliminar.TabStop = False
        Me.bttEliminar.Text = "Eliminar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(562, 509)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 31
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Enabled = False
        Me.bttGuardar.Image = Global.AydaraTPV.My.Resources.Resources.save
        Me.bttGuardar.Location = New System.Drawing.Point(674, 509)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(106, 45)
        Me.bttGuardar.TabIndex = 30
        Me.bttGuardar.TabStop = False
        Me.bttGuardar.Text = "Guardar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Descripción:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOSBindingSource, "Descripcion", True))
        Me.txtDescripcion.EnterMoveNextControl = True
        Me.txtDescripcion.Location = New System.Drawing.Point(93, 35)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Properties.MaxLength = 40
        Me.txtDescripcion.Properties.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(539, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Código:"
        '
        'ARTICULOSTableAdapter
        '
        Me.ARTICULOSTableAdapter.ClearBeforeFill = True
        '
        'CODIGO_BARRASTableAdapter
        '
        Me.CODIGO_BARRASTableAdapter.ClearBeforeFill = True
        '
        'bttNuevo
        '
        Me.bttNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttNuevo.Image = Global.AydaraTPV.My.Resources.Resources._new
        Me.bttNuevo.Location = New System.Drawing.Point(12, 509)
        Me.bttNuevo.Name = "bttNuevo"
        Me.bttNuevo.Size = New System.Drawing.Size(106, 45)
        Me.bttNuevo.TabIndex = 8
        Me.bttNuevo.TabStop = False
        Me.bttNuevo.Text = "Nuevo"
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.search
        Me.bttBuscar.Location = New System.Drawing.Point(236, 509)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(106, 45)
        Me.bttBuscar.TabIndex = 44
        Me.bttBuscar.TabStop = False
        Me.bttBuscar.Text = "Buscar"
        '
        'bttModificar
        '
        Me.bttModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttModificar.Enabled = False
        Me.bttModificar.Image = Global.AydaraTPV.My.Resources.Resources.menu_vales
        Me.bttModificar.Location = New System.Drawing.Point(124, 509)
        Me.bttModificar.Name = "bttModificar"
        Me.bttModificar.Size = New System.Drawing.Size(106, 45)
        Me.bttModificar.TabIndex = 43
        Me.bttModificar.TabStop = False
        Me.bttModificar.Text = "Modificar"
        '
        'NavListadoCodigoBarras
        '
        Me.NavListadoCodigoBarras.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NavListadoCodigoBarras.Buttons.Append.Enabled = False
        Me.NavListadoCodigoBarras.Buttons.CancelEdit.Visible = False
        Me.NavListadoCodigoBarras.Buttons.EndEdit.Visible = False
        Me.NavListadoCodigoBarras.Buttons.Remove.Enabled = False
        Me.NavListadoCodigoBarras.DataSource = Me.CODIGOBARRASBindingSource
        Me.NavListadoCodigoBarras.Location = New System.Drawing.Point(3, 139)
        Me.NavListadoCodigoBarras.Name = "NavListadoCodigoBarras"
        Me.NavListadoCodigoBarras.Size = New System.Drawing.Size(339, 19)
        Me.NavListadoCodigoBarras.TabIndex = 46
        Me.NavListadoCodigoBarras.Text = "Familias"
        '
        'dgCodigoBarras
        '
        Me.dgCodigoBarras.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgCodigoBarras.DataSource = Me.CODIGOBARRASBindingSource
        Me.dgCodigoBarras.Location = New System.Drawing.Point(3, 3)
        Me.dgCodigoBarras.MainView = Me.gvCodigoBarras
        Me.dgCodigoBarras.Name = "dgCodigoBarras"
        Me.dgCodigoBarras.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskCodigoBarras, Me.cmbCodigoBarrasColores, Me.cmbCodigoBarrasTallas})
        Me.dgCodigoBarras.Size = New System.Drawing.Size(339, 137)
        Me.dgCodigoBarras.TabIndex = 45
        Me.dgCodigoBarras.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCodigoBarras})
        '
        'gvCodigoBarras
        '
        Me.gvCodigoBarras.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colArticulo_Id, Me.colCodigoBarras, Me.colDescripcionColor, Me.colCodigoBarras_Color, Me.colDescripciontalla, Me.colCodigoBarras_Talla})
        Me.gvCodigoBarras.GridControl = Me.dgCodigoBarras
        Me.gvCodigoBarras.Name = "gvCodigoBarras"
        Me.gvCodigoBarras.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvCodigoBarras.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvCodigoBarras.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvCodigoBarras.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvCodigoBarras.OptionsView.ShowGroupPanel = False
        Me.gvCodigoBarras.OptionsView.ShowIndicator = False
        '
        'colArticulo_Id
        '
        Me.colArticulo_Id.FieldName = "Articulo_Id"
        Me.colArticulo_Id.Name = "colArticulo_Id"
        '
        'colCodigoBarras
        '
        Me.colCodigoBarras.Caption = "Códigos de barras"
        Me.colCodigoBarras.ColumnEdit = Me.maskCodigoBarras
        Me.colCodigoBarras.FieldName = "CodigoBarras"
        Me.colCodigoBarras.Name = "colCodigoBarras"
        Me.colCodigoBarras.OptionsColumn.ReadOnly = True
        Me.colCodigoBarras.Visible = True
        Me.colCodigoBarras.VisibleIndex = 0
        Me.colCodigoBarras.Width = 165
        '
        'maskCodigoBarras
        '
        Me.maskCodigoBarras.AutoHeight = False
        Me.maskCodigoBarras.MaxLength = 13
        Me.maskCodigoBarras.Name = "maskCodigoBarras"
        '
        'colDescripcionColor
        '
        Me.colDescripcionColor.Caption = "Color"
        Me.colDescripcionColor.FieldName = "DescripcionColor"
        Me.colDescripcionColor.MaxWidth = 50
        Me.colDescripcionColor.MinWidth = 50
        Me.colDescripcionColor.Name = "colDescripcionColor"
        Me.colDescripcionColor.OptionsColumn.AllowEdit = False
        Me.colDescripcionColor.OptionsColumn.AllowFocus = False
        Me.colDescripcionColor.Visible = True
        Me.colDescripcionColor.VisibleIndex = 1
        Me.colDescripcionColor.Width = 50
        '
        'colCodigoBarras_Color
        '
        Me.colCodigoBarras_Color.Caption = " "
        Me.colCodigoBarras_Color.ColumnEdit = Me.cmbCodigoBarrasColores
        Me.colCodigoBarras_Color.FieldName = "CodigoColor"
        Me.colCodigoBarras_Color.MaxWidth = 20
        Me.colCodigoBarras_Color.Name = "colCodigoBarras_Color"
        Me.colCodigoBarras_Color.OptionsColumn.ReadOnly = True
        Me.colCodigoBarras_Color.Visible = True
        Me.colCodigoBarras_Color.VisibleIndex = 2
        Me.colCodigoBarras_Color.Width = 20
        '
        'cmbCodigoBarrasColores
        '
        Me.cmbCodigoBarrasColores.AutoHeight = False
        Me.cmbCodigoBarrasColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCodigoBarrasColores.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")})
        Me.cmbCodigoBarrasColores.DataSource = Me.COLORESBindingSource
        Me.cmbCodigoBarrasColores.DisplayMember = "Color"
        Me.cmbCodigoBarrasColores.Name = "cmbCodigoBarrasColores"
        Me.cmbCodigoBarrasColores.NullText = ""
        Me.cmbCodigoBarrasColores.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.cmbCodigoBarrasColores.ValueMember = "CodigoColor"
        '
        'COLORESBindingSource
        '
        Me.COLORESBindingSource.DataMember = "COLORES"
        Me.COLORESBindingSource.DataSource = Me.DsArticulos
        '
        'colDescripciontalla
        '
        Me.colDescripciontalla.Caption = "Talla"
        Me.colDescripciontalla.FieldName = "DescripcionTalla"
        Me.colDescripciontalla.MaxWidth = 50
        Me.colDescripciontalla.MinWidth = 50
        Me.colDescripciontalla.Name = "colDescripciontalla"
        Me.colDescripciontalla.OptionsColumn.AllowEdit = False
        Me.colDescripciontalla.OptionsColumn.AllowFocus = False
        Me.colDescripciontalla.Visible = True
        Me.colDescripciontalla.VisibleIndex = 3
        Me.colDescripciontalla.Width = 50
        '
        'colCodigoBarras_Talla
        '
        Me.colCodigoBarras_Talla.Caption = " "
        Me.colCodigoBarras_Talla.ColumnEdit = Me.cmbCodigoBarrasTallas
        Me.colCodigoBarras_Talla.FieldName = "CodigoTalla"
        Me.colCodigoBarras_Talla.MaxWidth = 20
        Me.colCodigoBarras_Talla.Name = "colCodigoBarras_Talla"
        Me.colCodigoBarras_Talla.OptionsColumn.ReadOnly = True
        Me.colCodigoBarras_Talla.Visible = True
        Me.colCodigoBarras_Talla.VisibleIndex = 4
        Me.colCodigoBarras_Talla.Width = 20
        '
        'cmbCodigoBarrasTallas
        '
        Me.cmbCodigoBarrasTallas.AutoHeight = False
        Me.cmbCodigoBarrasTallas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbCodigoBarrasTallas.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Talla")})
        Me.cmbCodigoBarrasTallas.DataSource = Me.TALLASBindingSource
        Me.cmbCodigoBarrasTallas.DisplayMember = "Descripcion"
        Me.cmbCodigoBarrasTallas.Name = "cmbCodigoBarrasTallas"
        Me.cmbCodigoBarrasTallas.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.cmbCodigoBarrasTallas.ValueMember = "CodigoTalla"
        '
        'TALLASBindingSource
        '
        Me.TALLASBindingSource.DataMember = "TALLAS"
        Me.TALLASBindingSource.DataSource = Me.DsArticulos
        '
        'txtCodigo
        '
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOSBindingSource, "Codigo", True))
        Me.txtCodigo.EnterMoveNextControl = True
        Me.txtCodigo.Location = New System.Drawing.Point(93, 9)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigo.Properties.MaxLength = 15
        Me.txtCodigo.Size = New System.Drawing.Size(115, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'txtCodigoFamilia
        '
        Me.txtCodigoFamilia.EnterMoveNextControl = True
        Me.txtCodigoFamilia.Location = New System.Drawing.Point(93, 61)
        Me.txtCodigoFamilia.Name = "txtCodigoFamilia"
        Me.txtCodigoFamilia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.txtCodigoFamilia.Properties.ReadOnly = True
        Me.txtCodigoFamilia.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoFamilia.TabIndex = 4
        '
        'txtCodigoSubfamilia
        '
        Me.txtCodigoSubfamilia.EnterMoveNextControl = True
        Me.txtCodigoSubfamilia.Location = New System.Drawing.Point(93, 87)
        Me.txtCodigoSubfamilia.Name = "txtCodigoSubfamilia"
        Me.txtCodigoSubfamilia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, False)})
        Me.txtCodigoSubfamilia.Properties.ReadOnly = True
        Me.txtCodigoSubfamilia.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoSubfamilia.TabIndex = 5
        '
        'txtCodigoProveedor
        '
        Me.txtCodigoProveedor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "CodigoProveedor", True))
        Me.txtCodigoProveedor.EditValue = ""
        Me.txtCodigoProveedor.EnterMoveNextControl = True
        Me.txtCodigoProveedor.Location = New System.Drawing.Point(93, 113)
        Me.txtCodigoProveedor.Name = "txtCodigoProveedor"
        Me.txtCodigoProveedor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject3, "", Nothing, Nothing, False)})
        Me.txtCodigoProveedor.Properties.DisplayFormat.FormatString = "00000"
        Me.txtCodigoProveedor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoProveedor.Properties.EditFormat.FormatString = "00000"
        Me.txtCodigoProveedor.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoProveedor.Properties.ReadOnly = True
        Me.txtCodigoProveedor.Properties.ValidateOnEnterKey = True
        Me.txtCodigoProveedor.Size = New System.Drawing.Size(83, 20)
        Me.txtCodigoProveedor.TabIndex = 6
        '
        'txtDescripcionFamilia
        '
        Me.txtDescripcionFamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionFamilia.EnterMoveNextControl = True
        Me.txtDescripcionFamilia.Location = New System.Drawing.Point(147, 61)
        Me.txtDescripcionFamilia.Name = "txtDescripcionFamilia"
        Me.txtDescripcionFamilia.Properties.MaxLength = 50
        Me.txtDescripcionFamilia.Properties.ReadOnly = True
        Me.txtDescripcionFamilia.Size = New System.Drawing.Size(485, 20)
        Me.txtDescripcionFamilia.TabIndex = 3
        Me.txtDescripcionFamilia.TabStop = False
        '
        'txtDescripcionSubfamilia
        '
        Me.txtDescripcionSubfamilia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionSubfamilia.EnterMoveNextControl = True
        Me.txtDescripcionSubfamilia.Location = New System.Drawing.Point(147, 87)
        Me.txtDescripcionSubfamilia.Name = "txtDescripcionSubfamilia"
        Me.txtDescripcionSubfamilia.Properties.MaxLength = 50
        Me.txtDescripcionSubfamilia.Properties.ReadOnly = True
        Me.txtDescripcionSubfamilia.Size = New System.Drawing.Size(485, 20)
        Me.txtDescripcionSubfamilia.TabIndex = 4
        Me.txtDescripcionSubfamilia.TabStop = False
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreProveedor.EnterMoveNextControl = True
        Me.txtNombreProveedor.Location = New System.Drawing.Point(175, 113)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Properties.MaxLength = 50
        Me.txtNombreProveedor.Properties.ReadOnly = True
        Me.txtNombreProveedor.Size = New System.Drawing.Size(457, 20)
        Me.txtNombreProveedor.TabIndex = 5
        Me.txtNombreProveedor.TabStop = False
        '
        'txtCodigoEnvase
        '
        Me.txtCodigoEnvase.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "CodigoEnvase", True))
        Me.txtCodigoEnvase.EnterMoveNextControl = True
        Me.txtCodigoEnvase.Location = New System.Drawing.Point(93, 138)
        Me.txtCodigoEnvase.Name = "txtCodigoEnvase"
        Me.txtCodigoEnvase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject4, "", Nothing, Nothing, False)})
        Me.txtCodigoEnvase.Properties.MaxLength = 7
        Me.txtCodigoEnvase.Properties.ReadOnly = True
        Me.txtCodigoEnvase.Size = New System.Drawing.Size(113, 20)
        Me.txtCodigoEnvase.TabIndex = 7
        '
        'dgExistencias
        '
        Me.dgExistencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgExistencias.DataSource = Me.EXISTENCIASBindingSource
        Me.dgExistencias.Location = New System.Drawing.Point(289, 3)
        Me.dgExistencias.MainView = Me.gvExistencias
        Me.dgExistencias.Name = "dgExistencias"
        Me.dgExistencias.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskPrecio, Me.maskCodigoBarrasTalla})
        Me.dgExistencias.Size = New System.Drawing.Size(474, 138)
        Me.dgExistencias.TabIndex = 47
        Me.dgExistencias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvExistencias})
        '
        'EXISTENCIASBindingSource
        '
        Me.EXISTENCIASBindingSource.DataMember = "EXISTENCIAS"
        Me.EXISTENCIASBindingSource.DataSource = Me.DsArticulos
        '
        'gvExistencias
        '
        Me.gvExistencias.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colExistenciasCodigoTalla, Me.colExistenciasTalla, Me.colExistenciasExistenciaInicial, Me.colExistenciasExistenciaActual, Me.colExistenciasStockMinimo, Me.colExistenciasStockMaximo, Me.colExistenciasPrecioVenta, Me.colExistenciasCodigoBarras})
        Me.gvExistencias.GridControl = Me.dgExistencias
        Me.gvExistencias.Name = "gvExistencias"
        Me.gvExistencias.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvExistencias.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvExistencias.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvExistencias.OptionsSelection.EnableAppearanceHideSelection = False
        Me.gvExistencias.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvExistencias.OptionsView.ShowGroupPanel = False
        Me.gvExistencias.OptionsView.ShowIndicator = False
        '
        'colExistenciasCodigoTalla
        '
        Me.colExistenciasCodigoTalla.Caption = "GridColumn1"
        Me.colExistenciasCodigoTalla.FieldName = "CodigoTalla"
        Me.colExistenciasCodigoTalla.Name = "colExistenciasCodigoTalla"
        '
        'colExistenciasTalla
        '
        Me.colExistenciasTalla.Caption = "Talla"
        Me.colExistenciasTalla.FieldName = "DescripcionTalla"
        Me.colExistenciasTalla.MaxWidth = 50
        Me.colExistenciasTalla.MinWidth = 50
        Me.colExistenciasTalla.Name = "colExistenciasTalla"
        Me.colExistenciasTalla.OptionsColumn.AllowFocus = False
        Me.colExistenciasTalla.OptionsColumn.ReadOnly = True
        Me.colExistenciasTalla.Visible = True
        Me.colExistenciasTalla.VisibleIndex = 0
        Me.colExistenciasTalla.Width = 50
        '
        'colExistenciasExistenciaInicial
        '
        Me.colExistenciasExistenciaInicial.Caption = "Inicial"
        Me.colExistenciasExistenciaInicial.FieldName = "ExistenciaInicial"
        Me.colExistenciasExistenciaInicial.MaxWidth = 55
        Me.colExistenciasExistenciaInicial.MinWidth = 55
        Me.colExistenciasExistenciaInicial.Name = "colExistenciasExistenciaInicial"
        Me.colExistenciasExistenciaInicial.OptionsColumn.ReadOnly = True
        Me.colExistenciasExistenciaInicial.Visible = True
        Me.colExistenciasExistenciaInicial.VisibleIndex = 1
        Me.colExistenciasExistenciaInicial.Width = 55
        '
        'colExistenciasExistenciaActual
        '
        Me.colExistenciasExistenciaActual.Caption = "Existencia"
        Me.colExistenciasExistenciaActual.FieldName = "ExistenciaActual"
        Me.colExistenciasExistenciaActual.MaxWidth = 70
        Me.colExistenciasExistenciaActual.MinWidth = 70
        Me.colExistenciasExistenciaActual.Name = "colExistenciasExistenciaActual"
        Me.colExistenciasExistenciaActual.OptionsColumn.ReadOnly = True
        Me.colExistenciasExistenciaActual.Visible = True
        Me.colExistenciasExistenciaActual.VisibleIndex = 2
        Me.colExistenciasExistenciaActual.Width = 70
        '
        'colExistenciasStockMinimo
        '
        Me.colExistenciasStockMinimo.Caption = "Mínimo"
        Me.colExistenciasStockMinimo.FieldName = "StockMinimo"
        Me.colExistenciasStockMinimo.MaxWidth = 60
        Me.colExistenciasStockMinimo.MinWidth = 60
        Me.colExistenciasStockMinimo.Name = "colExistenciasStockMinimo"
        Me.colExistenciasStockMinimo.OptionsColumn.ReadOnly = True
        Me.colExistenciasStockMinimo.Visible = True
        Me.colExistenciasStockMinimo.VisibleIndex = 3
        Me.colExistenciasStockMinimo.Width = 60
        '
        'colExistenciasStockMaximo
        '
        Me.colExistenciasStockMaximo.Caption = "Máximo"
        Me.colExistenciasStockMaximo.FieldName = "StockMaximo"
        Me.colExistenciasStockMaximo.MaxWidth = 60
        Me.colExistenciasStockMaximo.MinWidth = 60
        Me.colExistenciasStockMaximo.Name = "colExistenciasStockMaximo"
        Me.colExistenciasStockMaximo.OptionsColumn.ReadOnly = True
        Me.colExistenciasStockMaximo.Visible = True
        Me.colExistenciasStockMaximo.VisibleIndex = 4
        Me.colExistenciasStockMaximo.Width = 60
        '
        'colExistenciasPrecioVenta
        '
        Me.colExistenciasPrecioVenta.Caption = "Precio"
        Me.colExistenciasPrecioVenta.ColumnEdit = Me.maskPrecio
        Me.colExistenciasPrecioVenta.FieldName = "PrecioVenta"
        Me.colExistenciasPrecioVenta.MaxWidth = 70
        Me.colExistenciasPrecioVenta.MinWidth = 70
        Me.colExistenciasPrecioVenta.Name = "colExistenciasPrecioVenta"
        Me.colExistenciasPrecioVenta.OptionsColumn.ReadOnly = True
        Me.colExistenciasPrecioVenta.Visible = True
        Me.colExistenciasPrecioVenta.VisibleIndex = 5
        Me.colExistenciasPrecioVenta.Width = 70
        '
        'maskPrecio
        '
        Me.maskPrecio.AutoHeight = False
        Me.maskPrecio.Mask.EditMask = "0"
        Me.maskPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecio.Name = "maskPrecio"
        '
        'colExistenciasCodigoBarras
        '
        Me.colExistenciasCodigoBarras.Caption = "Código de barras"
        Me.colExistenciasCodigoBarras.ColumnEdit = Me.maskCodigoBarrasTalla
        Me.colExistenciasCodigoBarras.FieldName = "CodigoBarras"
        Me.colExistenciasCodigoBarras.MaxWidth = 120
        Me.colExistenciasCodigoBarras.Name = "colExistenciasCodigoBarras"
        Me.colExistenciasCodigoBarras.OptionsColumn.ReadOnly = True
        Me.colExistenciasCodigoBarras.Visible = True
        Me.colExistenciasCodigoBarras.VisibleIndex = 6
        Me.colExistenciasCodigoBarras.Width = 105
        '
        'maskCodigoBarrasTalla
        '
        Me.maskCodigoBarrasTalla.AutoHeight = False
        Me.maskCodigoBarrasTalla.MaxLength = 13
        Me.maskCodigoBarrasTalla.Name = "maskCodigoBarrasTalla"
        '
        'lblCodigoTalla
        '
        Me.lblCodigoTalla.Location = New System.Drawing.Point(363, 12)
        Me.lblCodigoTalla.Name = "lblCodigoTalla"
        Me.lblCodigoTalla.Size = New System.Drawing.Size(69, 13)
        Me.lblCodigoTalla.TabIndex = 50
        Me.lblCodigoTalla.Text = "Código tallaje:"
        '
        'txtCodigoTalla
        '
        Me.txtCodigoTalla.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "CodigoTalla", True))
        Me.txtCodigoTalla.EnterMoveNextControl = True
        Me.txtCodigoTalla.Location = New System.Drawing.Point(438, 9)
        Me.txtCodigoTalla.Name = "txtCodigoTalla"
        Me.txtCodigoTalla.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, False, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, "", Nothing, Nothing, False)})
        Me.txtCodigoTalla.Properties.DisplayFormat.FormatString = "00"
        Me.txtCodigoTalla.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoTalla.Properties.EditFormat.FormatString = "00"
        Me.txtCodigoTalla.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCodigoTalla.Properties.ReadOnly = True
        Me.txtCodigoTalla.Size = New System.Drawing.Size(62, 20)
        Me.txtCodigoTalla.TabIndex = 1
        '
        'txtFechaAlta
        '
        Me.txtFechaAlta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "FechaAlta", True))
        Me.txtFechaAlta.EditValue = Nothing
        Me.txtFechaAlta.EnterMoveNextControl = True
        Me.txtFechaAlta.Location = New System.Drawing.Point(93, 164)
        Me.txtFechaAlta.Name = "txtFechaAlta"
        Me.txtFechaAlta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaAlta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaAlta.Properties.ReadOnly = True
        Me.txtFechaAlta.Size = New System.Drawing.Size(94, 20)
        Me.txtFechaAlta.TabIndex = 8
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(11, 167)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl9.TabIndex = 53
        Me.LabelControl9.Text = "Fecha de alta:"
        '
        'txtUnidadCaja
        '
        Me.txtUnidadCaja.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "UnidadCaja", True))
        Me.txtUnidadCaja.EnterMoveNextControl = True
        Me.txtUnidadCaja.Location = New System.Drawing.Point(93, 199)
        Me.txtUnidadCaja.Name = "txtUnidadCaja"
        Me.txtUnidadCaja.Properties.Appearance.Options.UseTextOptions = True
        Me.txtUnidadCaja.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtUnidadCaja.Properties.ReadOnly = True
        Me.txtUnidadCaja.Size = New System.Drawing.Size(55, 20)
        Me.txtUnidadCaja.TabIndex = 9
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(12, 202)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl10.TabIndex = 55
        Me.LabelControl10.Text = "Unidades caja:"
        '
        'txtMinimoVenta
        '
        Me.txtMinimoVenta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "MinimoVenta", True))
        Me.txtMinimoVenta.EnterMoveNextControl = True
        Me.txtMinimoVenta.Location = New System.Drawing.Point(228, 199)
        Me.txtMinimoVenta.Name = "txtMinimoVenta"
        Me.txtMinimoVenta.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMinimoVenta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMinimoVenta.Properties.ReadOnly = True
        Me.txtMinimoVenta.Size = New System.Drawing.Size(47, 20)
        Me.txtMinimoVenta.TabIndex = 10
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(155, 202)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl11.TabIndex = 57
        Me.LabelControl11.Text = "Mínimo venta:"
        '
        'txtMinimoCompra
        '
        Me.txtMinimoCompra.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "MinimoCompra", True))
        Me.txtMinimoCompra.EnterMoveNextControl = True
        Me.txtMinimoCompra.Location = New System.Drawing.Point(374, 199)
        Me.txtMinimoCompra.Name = "txtMinimoCompra"
        Me.txtMinimoCompra.Properties.Appearance.Options.UseTextOptions = True
        Me.txtMinimoCompra.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtMinimoCompra.Properties.ReadOnly = True
        Me.txtMinimoCompra.Size = New System.Drawing.Size(47, 20)
        Me.txtMinimoCompra.TabIndex = 11
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(294, 202)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl12.TabIndex = 59
        Me.LabelControl12.Text = "Mínimo compra:"
        '
        'txtPesoUnidad
        '
        Me.txtPesoUnidad.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "PesoUnidad", True))
        Me.txtPesoUnidad.EnterMoveNextControl = True
        Me.txtPesoUnidad.Location = New System.Drawing.Point(93, 225)
        Me.txtPesoUnidad.Name = "txtPesoUnidad"
        Me.txtPesoUnidad.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPesoUnidad.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPesoUnidad.Properties.ReadOnly = True
        Me.txtPesoUnidad.Size = New System.Drawing.Size(55, 20)
        Me.txtPesoUnidad.TabIndex = 14
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(12, 228)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl13.TabIndex = 61
        Me.LabelControl13.Text = "Peso unidad:"
        '
        'txtDescuento
        '
        Me.txtDescuento.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "Descuento", True))
        Me.txtDescuento.EnterMoveNextControl = True
        Me.txtDescuento.Location = New System.Drawing.Point(228, 225)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDescuento.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDescuento.Properties.Mask.EditMask = "P2"
        Me.txtDescuento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDescuento.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDescuento.Properties.ReadOnly = True
        Me.txtDescuento.Size = New System.Drawing.Size(60, 20)
        Me.txtDescuento.TabIndex = 16
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(197, 228)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(25, 13)
        Me.LabelControl14.TabIndex = 63
        Me.LabelControl14.Text = "Dto.:"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "Precio", True))
        Me.txtPrecioVenta.EnterMoveNextControl = True
        Me.txtPrecioVenta.Location = New System.Drawing.Point(518, 225)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrecioVenta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecioVenta.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioVenta.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioVenta.Properties.ReadOnly = True
        Me.txtPrecioVenta.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecioVenta.TabIndex = 18
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(448, 228)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl15.TabIndex = 65
        Me.LabelControl15.Text = "Precio venta:"
        '
        'txtPrecioCoste
        '
        Me.txtPrecioCoste.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "PrecioCoste", True))
        Me.txtPrecioCoste.EnterMoveNextControl = True
        Me.txtPrecioCoste.Location = New System.Drawing.Point(374, 225)
        Me.txtPrecioCoste.Name = "txtPrecioCoste"
        Me.txtPrecioCoste.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPrecioCoste.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPrecioCoste.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPrecioCoste.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPrecioCoste.Properties.ReadOnly = True
        Me.txtPrecioCoste.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecioCoste.TabIndex = 17
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(306, 228)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl16.TabIndex = 67
        Me.LabelControl16.Text = "Precio coste:"
        '
        'txtExistenciaInicial
        '
        Me.txtExistenciaInicial.EnterMoveNextControl = True
        Me.txtExistenciaInicial.Location = New System.Drawing.Point(42, 28)
        Me.txtExistenciaInicial.Name = "txtExistenciaInicial"
        Me.txtExistenciaInicial.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExistenciaInicial.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExistenciaInicial.Properties.Mask.EditMask = "n"
        Me.txtExistenciaInicial.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExistenciaInicial.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExistenciaInicial.Properties.ReadOnly = True
        Me.txtExistenciaInicial.Size = New System.Drawing.Size(47, 20)
        Me.txtExistenciaInicial.TabIndex = 1
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(5, 31)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl17.TabIndex = 69
        Me.LabelControl17.Text = "Inicial:"
        '
        'txtExistenciasActual
        '
        Me.txtExistenciasActual.EnterMoveNextControl = True
        Me.txtExistenciasActual.Location = New System.Drawing.Point(153, 28)
        Me.txtExistenciasActual.Name = "txtExistenciasActual"
        Me.txtExistenciasActual.Properties.Appearance.Options.UseTextOptions = True
        Me.txtExistenciasActual.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtExistenciasActual.Properties.Mask.EditMask = "n3"
        Me.txtExistenciasActual.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtExistenciasActual.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtExistenciasActual.Properties.ReadOnly = True
        Me.txtExistenciasActual.Size = New System.Drawing.Size(56, 20)
        Me.txtExistenciasActual.TabIndex = 2
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(95, 31)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl18.TabIndex = 71
        Me.LabelControl18.Text = "Existencia:"
        '
        'txtStockMinimo
        '
        Me.txtStockMinimo.EnterMoveNextControl = True
        Me.txtStockMinimo.Location = New System.Drawing.Point(257, 28)
        Me.txtStockMinimo.Name = "txtStockMinimo"
        Me.txtStockMinimo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStockMinimo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStockMinimo.Properties.Mask.EditMask = "n"
        Me.txtStockMinimo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtStockMinimo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtStockMinimo.Properties.ReadOnly = True
        Me.txtStockMinimo.Size = New System.Drawing.Size(56, 20)
        Me.txtStockMinimo.TabIndex = 3
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(215, 31)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl19.TabIndex = 73
        Me.LabelControl19.Text = "Mínimo:"
        '
        'txtStockMaximo
        '
        Me.txtStockMaximo.EnterMoveNextControl = True
        Me.txtStockMaximo.Location = New System.Drawing.Point(365, 28)
        Me.txtStockMaximo.Name = "txtStockMaximo"
        Me.txtStockMaximo.Properties.Appearance.Options.UseTextOptions = True
        Me.txtStockMaximo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtStockMaximo.Properties.Mask.EditMask = "n"
        Me.txtStockMaximo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtStockMaximo.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtStockMaximo.Properties.ReadOnly = True
        Me.txtStockMaximo.Size = New System.Drawing.Size(56, 20)
        Me.txtStockMaximo.TabIndex = 4
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(319, 31)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl20.TabIndex = 75
        Me.LabelControl20.Text = "Máximo:"
        '
        'panelExistencias
        '
        Me.panelExistencias.Controls.Add(Me.txtStockMaximo)
        Me.panelExistencias.Controls.Add(Me.LabelControl20)
        Me.panelExistencias.Controls.Add(Me.LabelControl18)
        Me.panelExistencias.Controls.Add(Me.txtStockMinimo)
        Me.panelExistencias.Controls.Add(Me.txtExistenciasActual)
        Me.panelExistencias.Controls.Add(Me.LabelControl19)
        Me.panelExistencias.Controls.Add(Me.LabelControl17)
        Me.panelExistencias.Controls.Add(Me.txtExistenciaInicial)
        Me.panelExistencias.Location = New System.Drawing.Point(11, 251)
        Me.panelExistencias.Name = "panelExistencias"
        Me.panelExistencias.Size = New System.Drawing.Size(432, 57)
        Me.panelExistencias.TabIndex = 21
        Me.panelExistencias.Text = "EXISTENCIAS"
        '
        'cmbTipoIVA
        '
        Me.cmbTipoIVA.EditValue = ""
        Me.cmbTipoIVA.EnterMoveNextControl = True
        Me.cmbTipoIVA.Location = New System.Drawing.Point(532, 9)
        Me.cmbTipoIVA.Name = "cmbTipoIVA"
        Me.cmbTipoIVA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTipoIVA.Properties.Items.AddRange(New Object() {"18", "8", "4", "0"})
        Me.cmbTipoIVA.Properties.ReadOnly = True
        Me.cmbTipoIVA.Size = New System.Drawing.Size(44, 20)
        Me.cmbTipoIVA.TabIndex = 2
        '
        'txtDescripcionEnvase
        '
        Me.txtDescripcionEnvase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionEnvase.EnterMoveNextControl = True
        Me.txtDescripcionEnvase.Location = New System.Drawing.Point(205, 138)
        Me.txtDescripcionEnvase.Name = "txtDescripcionEnvase"
        Me.txtDescripcionEnvase.Properties.MaxLength = 50
        Me.txtDescripcionEnvase.Properties.ReadOnly = True
        Me.txtDescripcionEnvase.Size = New System.Drawing.Size(427, 20)
        Me.txtDescripcionEnvase.TabIndex = 79
        Me.txtDescripcionEnvase.TabStop = False
        '
        'colCodigoTalla
        '
        Me.colCodigoTalla.Caption = "Talla"
        Me.colCodigoTalla.Name = "colCodigoTalla"
        Me.colCodigoTalla.Visible = True
        Me.colCodigoTalla.VisibleIndex = 100000
        '
        'TabArticulo
        '
        Me.TabArticulo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabArticulo.Location = New System.Drawing.Point(11, 314)
        Me.TabArticulo.Name = "TabArticulo"
        Me.TabArticulo.SelectedTabPage = Me.TabTallasColores
        Me.TabArticulo.Size = New System.Drawing.Size(768, 193)
        Me.TabArticulo.TabIndex = 23
        Me.TabArticulo.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabTallasColores, Me.TabCodigoBarras, Me.xtpMovimientos, Me.TabReferencias, Me.TabInventarios})
        '
        'TabTallasColores
        '
        Me.TabTallasColores.Controls.Add(Me.lblColorSeleccionado)
        Me.TabTallasColores.Controls.Add(Me.lblEtiquetaColor)
        Me.TabTallasColores.Controls.Add(Me.NavListadoColores)
        Me.TabTallasColores.Controls.Add(Me.dgColores)
        Me.TabTallasColores.Controls.Add(Me.dgExistencias)
        Me.TabTallasColores.Name = "TabTallasColores"
        Me.TabTallasColores.Size = New System.Drawing.Size(762, 165)
        Me.TabTallasColores.Text = "Tallas y colores"
        '
        'lblColorSeleccionado
        '
        Me.lblColorSeleccionado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblColorSeleccionado.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblColorSeleccionado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblColorSeleccionado.Location = New System.Drawing.Point(388, 146)
        Me.lblColorSeleccionado.Name = "lblColorSeleccionado"
        Me.lblColorSeleccionado.Size = New System.Drawing.Size(32, 13)
        Me.lblColorSeleccionado.TabIndex = 51
        '
        'lblEtiquetaColor
        '
        Me.lblEtiquetaColor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblEtiquetaColor.Location = New System.Drawing.Point(289, 146)
        Me.lblEtiquetaColor.Name = "lblEtiquetaColor"
        Me.lblEtiquetaColor.Size = New System.Drawing.Size(93, 13)
        Me.lblEtiquetaColor.TabIndex = 50
        Me.lblEtiquetaColor.Text = "Color seleccionado:"
        '
        'NavListadoColores
        '
        Me.NavListadoColores.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NavListadoColores.Buttons.Append.Enabled = False
        Me.NavListadoColores.Buttons.CancelEdit.Visible = False
        Me.NavListadoColores.Buttons.EndEdit.Visible = False
        Me.NavListadoColores.Buttons.Remove.Enabled = False
        Me.NavListadoColores.DataSource = Me.ARTICULOSCOLORESBindingSource
        Me.NavListadoColores.Location = New System.Drawing.Point(3, 140)
        Me.NavListadoColores.Name = "NavListadoColores"
        Me.NavListadoColores.Size = New System.Drawing.Size(280, 19)
        Me.NavListadoColores.TabIndex = 49
        Me.NavListadoColores.Text = "Familias"
        '
        'ARTICULOSCOLORESBindingSource
        '
        Me.ARTICULOSCOLORESBindingSource.DataMember = "ARTICULOS_COLORES"
        Me.ARTICULOSCOLORESBindingSource.DataSource = Me.DsArticulos
        '
        'dgColores
        '
        Me.dgColores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgColores.DataSource = Me.ARTICULOSCOLORESBindingSource
        Me.dgColores.Location = New System.Drawing.Point(3, 3)
        Me.dgColores.MainView = Me.gvColores
        Me.dgColores.Name = "dgColores"
        Me.dgColores.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbColores_Id, Me.cmbColores})
        Me.dgColores.Size = New System.Drawing.Size(280, 138)
        Me.dgColores.TabIndex = 48
        Me.dgColores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvColores})
        '
        'gvColores
        '
        Me.gvColores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colColores_Id, Me.colColores_Articulo_Id, Me.colColores_Color_Id, Me.colColores_Color})
        Me.gvColores.GridControl = Me.dgColores
        Me.gvColores.Name = "gvColores"
        Me.gvColores.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvColores.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvColores.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvColores.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvColores.OptionsView.ShowGroupPanel = False
        Me.gvColores.OptionsView.ShowIndicator = False
        '
        'colColores_Id
        '
        Me.colColores_Id.FieldName = "Id"
        Me.colColores_Id.Name = "colColores_Id"
        Me.colColores_Id.OptionsColumn.ReadOnly = True
        '
        'colColores_Articulo_Id
        '
        Me.colColores_Articulo_Id.FieldName = "Articulo_Id"
        Me.colColores_Articulo_Id.Name = "colColores_Articulo_Id"
        '
        'colColores_Color_Id
        '
        Me.colColores_Color_Id.Caption = "Colores"
        Me.colColores_Color_Id.ColumnEdit = Me.cmbColores_Id
        Me.colColores_Color_Id.FieldName = "Color_Id"
        Me.colColores_Color_Id.Name = "colColores_Color_Id"
        Me.colColores_Color_Id.Visible = True
        Me.colColores_Color_Id.VisibleIndex = 0
        Me.colColores_Color_Id.Width = 201
        '
        'cmbColores_Id
        '
        Me.cmbColores_Id.AutoHeight = False
        Me.cmbColores_Id.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbColores_Id.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Color")})
        Me.cmbColores_Id.DataSource = Me.COLORESBindingSource
        Me.cmbColores_Id.DisplayMember = "Descripcion"
        Me.cmbColores_Id.Name = "cmbColores_Id"
        Me.cmbColores_Id.NullText = ""
        Me.cmbColores_Id.ValueMember = "CodigoColor"
        '
        'colColores_Color
        '
        Me.colColores_Color.Caption = " "
        Me.colColores_Color.ColumnEdit = Me.cmbColores
        Me.colColores_Color.FieldName = "Color_Id"
        Me.colColores_Color.MaxWidth = 60
        Me.colColores_Color.Name = "colColores_Color"
        Me.colColores_Color.OptionsColumn.AllowEdit = False
        Me.colColores_Color.OptionsColumn.AllowFocus = False
        Me.colColores_Color.OptionsColumn.AllowMove = False
        Me.colColores_Color.OptionsColumn.ReadOnly = True
        Me.colColores_Color.OptionsColumn.TabStop = False
        Me.colColores_Color.Visible = True
        Me.colColores_Color.VisibleIndex = 1
        Me.colColores_Color.Width = 45
        '
        'cmbColores
        '
        Me.cmbColores.AutoHeight = False
        Me.cmbColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbColores.DataSource = Me.COLORESBindingSource
        Me.cmbColores.DisplayMember = "Color"
        Me.cmbColores.Name = "cmbColores"
        Me.cmbColores.NullText = "-1"
        Me.cmbColores.ValueMember = "CodigoColor"
        '
        'TabCodigoBarras
        '
        Me.TabCodigoBarras.Controls.Add(Me.gcEtiquetaElectronica)
        Me.TabCodigoBarras.Controls.Add(Me.dgCodigoBarras)
        Me.TabCodigoBarras.Controls.Add(Me.NavListadoCodigoBarras)
        Me.TabCodigoBarras.Name = "TabCodigoBarras"
        Me.TabCodigoBarras.Size = New System.Drawing.Size(762, 165)
        Me.TabCodigoBarras.Text = "Códigos de barras"
        '
        'gcEtiquetaElectronica
        '
        Me.gcEtiquetaElectronica.Controls.Add(Me.txtEE_Formato)
        Me.gcEtiquetaElectronica.Controls.Add(Me.cmbCodigosBarras)
        Me.gcEtiquetaElectronica.Controls.Add(Me.LabelControl27)
        Me.gcEtiquetaElectronica.Controls.Add(Me.txtEE_Calibre)
        Me.gcEtiquetaElectronica.Controls.Add(Me.LabelControl26)
        Me.gcEtiquetaElectronica.Controls.Add(Me.txtEE_Categoria)
        Me.gcEtiquetaElectronica.Controls.Add(Me.LabelControl25)
        Me.gcEtiquetaElectronica.Controls.Add(Me.txtEE_Origen)
        Me.gcEtiquetaElectronica.Controls.Add(Me.LabelControl23)
        Me.gcEtiquetaElectronica.Controls.Add(Me.txtEE_CodigoBarras)
        Me.gcEtiquetaElectronica.Controls.Add(Me.LabelControl22)
        Me.gcEtiquetaElectronica.Location = New System.Drawing.Point(362, 15)
        Me.gcEtiquetaElectronica.Name = "gcEtiquetaElectronica"
        Me.gcEtiquetaElectronica.Size = New System.Drawing.Size(383, 143)
        Me.gcEtiquetaElectronica.TabIndex = 47
        Me.gcEtiquetaElectronica.Text = "Etiqueta electrónica"
        '
        'txtEE_Formato
        '
        Me.txtEE_Formato.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "EE_Formato", True))
        Me.txtEE_Formato.Location = New System.Drawing.Point(279, 113)
        Me.txtEE_Formato.Name = "txtEE_Formato"
        Me.txtEE_Formato.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtEE_Formato.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Formato", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.txtEE_Formato.Properties.DataSource = Me.FORMATOSEEBindingSource
        Me.txtEE_Formato.Properties.DisplayMember = "Descripcion"
        Me.txtEE_Formato.Properties.NullText = ""
        Me.txtEE_Formato.Properties.ValueMember = "Codigo"
        Me.txtEE_Formato.Size = New System.Drawing.Size(90, 20)
        Me.txtEE_Formato.TabIndex = 105
        '
        'FORMATOSEEBindingSource
        '
        Me.FORMATOSEEBindingSource.DataMember = "FORMATOS_EE"
        Me.FORMATOSEEBindingSource.DataSource = Me.DsArticulos
        '
        'cmbCodigosBarras
        '
        Me.cmbCodigosBarras.Location = New System.Drawing.Point(222, 35)
        Me.cmbCodigosBarras.Name = "cmbCodigosBarras"
        Me.cmbCodigosBarras.Properties.AutoHeight = False
        Me.cmbCodigosBarras.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.cmbCodigosBarras.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodigoBarras", "Código Barras", 90, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbCodigosBarras.Properties.DataSource = Me.CODIGOBARRASBindingSource
        Me.cmbCodigosBarras.Properties.DisplayMember = "CodigoBarras"
        Me.cmbCodigosBarras.Properties.NullText = ""
        Me.cmbCodigosBarras.Properties.ReadOnly = True
        Me.cmbCodigosBarras.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.cmbCodigosBarras.Properties.ValueMember = "CodigoBarras"
        Me.cmbCodigosBarras.Size = New System.Drawing.Size(56, 20)
        Me.cmbCodigosBarras.TabIndex = 104
        '
        'LabelControl27
        '
        Me.LabelControl27.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl27.Location = New System.Drawing.Point(229, 116)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl27.TabIndex = 103
        Me.LabelControl27.Text = "Formato:"
        '
        'txtEE_Calibre
        '
        Me.txtEE_Calibre.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "EE_Calibre", True))
        Me.txtEE_Calibre.EnterMoveNextControl = True
        Me.txtEE_Calibre.Location = New System.Drawing.Point(106, 113)
        Me.txtEE_Calibre.Name = "txtEE_Calibre"
        Me.txtEE_Calibre.Properties.MaxLength = 5
        Me.txtEE_Calibre.Properties.ReadOnly = True
        Me.txtEE_Calibre.Size = New System.Drawing.Size(62, 20)
        Me.txtEE_Calibre.TabIndex = 99
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(63, 116)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl26.TabIndex = 100
        Me.LabelControl26.Text = "Calibre:"
        '
        'txtEE_Categoria
        '
        Me.txtEE_Categoria.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "EE_Categoria", True))
        Me.txtEE_Categoria.EnterMoveNextControl = True
        Me.txtEE_Categoria.Location = New System.Drawing.Point(106, 87)
        Me.txtEE_Categoria.Name = "txtEE_Categoria"
        Me.txtEE_Categoria.Properties.MaxLength = 10
        Me.txtEE_Categoria.Properties.ReadOnly = True
        Me.txtEE_Categoria.Size = New System.Drawing.Size(86, 20)
        Me.txtEE_Categoria.TabIndex = 97
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(49, 90)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(51, 13)
        Me.LabelControl25.TabIndex = 98
        Me.LabelControl25.Text = "Categoría:"
        '
        'txtEE_Origen
        '
        Me.txtEE_Origen.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "EE_Origen", True))
        Me.txtEE_Origen.EnterMoveNextControl = True
        Me.txtEE_Origen.Location = New System.Drawing.Point(106, 61)
        Me.txtEE_Origen.Name = "txtEE_Origen"
        Me.txtEE_Origen.Properties.MaxLength = 15
        Me.txtEE_Origen.Properties.ReadOnly = True
        Me.txtEE_Origen.Size = New System.Drawing.Size(117, 20)
        Me.txtEE_Origen.TabIndex = 95
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(64, 64)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(36, 13)
        Me.LabelControl23.TabIndex = 96
        Me.LabelControl23.Text = "Origen:"
        '
        'txtEE_CodigoBarras
        '
        Me.txtEE_CodigoBarras.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "EE_CodigoBarras", True))
        Me.txtEE_CodigoBarras.EnterMoveNextControl = True
        Me.txtEE_CodigoBarras.Location = New System.Drawing.Point(106, 35)
        Me.txtEE_CodigoBarras.Name = "txtEE_CodigoBarras"
        Me.txtEE_CodigoBarras.Properties.MaxLength = 13
        Me.txtEE_CodigoBarras.Properties.ReadOnly = True
        Me.txtEE_CodigoBarras.Size = New System.Drawing.Size(117, 20)
        Me.txtEE_CodigoBarras.TabIndex = 93
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(14, 38)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl22.TabIndex = 94
        Me.LabelControl22.Text = "Código de barras:"
        '
        'xtpMovimientos
        '
        Me.xtpMovimientos.Controls.Add(Me.dgMovimientos)
        Me.xtpMovimientos.Controls.Add(Me.GroupControl1)
        Me.xtpMovimientos.Name = "xtpMovimientos"
        Me.xtpMovimientos.Size = New System.Drawing.Size(762, 165)
        Me.xtpMovimientos.Text = "Movimientos"
        '
        'dgMovimientos
        '
        Me.dgMovimientos.DataSource = Me.bsMovimientos
        Me.dgMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMovimientos.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.dgMovimientos.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgMovimientos.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgMovimientos.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgMovimientos.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.dgMovimientos.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.dgMovimientos.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.dgMovimientos.Location = New System.Drawing.Point(0, 38)
        Me.dgMovimientos.MainView = Me.gvMovimientos
        Me.dgMovimientos.Name = "dgMovimientos"
        Me.dgMovimientos.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1})
        Me.dgMovimientos.Size = New System.Drawing.Size(762, 127)
        Me.dgMovimientos.TabIndex = 46
        Me.dgMovimientos.UseEmbeddedNavigator = True
        Me.dgMovimientos.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvMovimientos})
        '
        'bsMovimientos
        '
        Me.bsMovimientos.DataMember = "Movimientos"
        Me.bsMovimientos.DataSource = Me.DsArticulos
        '
        'gvMovimientos
        '
        Me.gvMovimientos.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvMovimientos.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvMovimientos.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFecha, Me.colDocumento, Me.colCodigo, Me.colNombre, Me.colEntrada, Me.colSalida, Me.colPrecio, Me.colImporte, Me.colStock})
        Me.gvMovimientos.GridControl = Me.dgMovimientos
        Me.gvMovimientos.GroupPanelText = "Arrastre una columna para agrupar por esa columna"
        Me.gvMovimientos.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteTicket", Nothing, "{0:c2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteCobrado", Nothing, "{0:c2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImportePendiente", Nothing, "{0:c2}")})
        Me.gvMovimientos.Name = "gvMovimientos"
        Me.gvMovimientos.OptionsBehavior.Editable = False
        Me.gvMovimientos.OptionsMenu.EnableColumnMenu = False
        Me.gvMovimientos.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvMovimientos.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvMovimientos.OptionsView.EnableAppearanceEvenRow = True
        Me.gvMovimientos.OptionsView.ShowAutoFilterRow = True
        Me.gvMovimientos.OptionsView.ShowDetailButtons = False
        Me.gvMovimientos.OptionsView.ShowFooter = True
        Me.gvMovimientos.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.gvMovimientos.OptionsView.ShowGroupPanel = False
        Me.gvMovimientos.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFecha, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colFecha
        '
        Me.colFecha.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colFecha.DisplayFormat.FormatString = "g"
        Me.colFecha.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.ReadOnly = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 0
        Me.colFecha.Width = 90
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.Mask.EditMask = "G"
        Me.RepositoryItemDateEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'colDocumento
        '
        Me.colDocumento.FieldName = "Documento"
        Me.colDocumento.Name = "colDocumento"
        Me.colDocumento.OptionsColumn.ReadOnly = True
        Me.colDocumento.Visible = True
        Me.colDocumento.VisibleIndex = 1
        Me.colDocumento.Width = 79
        '
        'colCodigo
        '
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.ReadOnly = True
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 2
        Me.colCodigo.Width = 72
        '
        'colNombre
        '
        Me.colNombre.Caption = "Nombre"
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 3
        Me.colNombre.Width = 254
        '
        'colEntrada
        '
        Me.colEntrada.DisplayFormat.FormatString = "n3"
        Me.colEntrada.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEntrada.FieldName = "Entrada"
        Me.colEntrada.Name = "colEntrada"
        Me.colEntrada.OptionsColumn.ReadOnly = True
        Me.colEntrada.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Entrada", "{0:n2}")})
        Me.colEntrada.Visible = True
        Me.colEntrada.VisibleIndex = 4
        Me.colEntrada.Width = 54
        '
        'colSalida
        '
        Me.colSalida.DisplayFormat.FormatString = "n3"
        Me.colSalida.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSalida.FieldName = "Salida"
        Me.colSalida.Name = "colSalida"
        Me.colSalida.OptionsColumn.ReadOnly = True
        Me.colSalida.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Salida", "{0:n2}")})
        Me.colSalida.Visible = True
        Me.colSalida.VisibleIndex = 5
        Me.colSalida.Width = 54
        '
        'colPrecio
        '
        Me.colPrecio.DisplayFormat.FormatString = "c3"
        Me.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.OptionsColumn.ReadOnly = True
        Me.colPrecio.Visible = True
        Me.colPrecio.VisibleIndex = 6
        Me.colPrecio.Width = 54
        '
        'colImporte
        '
        Me.colImporte.DisplayFormat.FormatString = "c2"
        Me.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.OptionsColumn.ReadOnly = True
        Me.colImporte.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Importe", "{0:c2}")})
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 7
        Me.colImporte.Width = 64
        '
        'colStock
        '
        Me.colStock.DisplayFormat.FormatString = "n"
        Me.colStock.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colStock.FieldName = "Stock"
        Me.colStock.Name = "colStock"
        Me.colStock.OptionsColumn.ReadOnly = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.bttExportarMovimientos)
        Me.GroupControl1.Controls.Add(Me.bttBuscarMovimientos)
        Me.GroupControl1.Controls.Add(Me.txtFechaHasta)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txtFechaDesde)
        Me.GroupControl1.Controls.Add(Me.LabelControl24)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(762, 38)
        Me.GroupControl1.TabIndex = 47
        Me.GroupControl1.Text = "FILTRO"
        '
        'bttExportarMovimientos
        '
        Me.bttExportarMovimientos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttExportarMovimientos.Image = CType(resources.GetObject("bttExportarMovimientos.Image"), System.Drawing.Image)
        Me.bttExportarMovimientos.Location = New System.Drawing.Point(680, 7)
        Me.bttExportarMovimientos.Name = "bttExportarMovimientos"
        Me.bttExportarMovimientos.Size = New System.Drawing.Size(77, 25)
        Me.bttExportarMovimientos.TabIndex = 74
        Me.bttExportarMovimientos.Text = "Exportar"
        '
        'bttBuscarMovimientos
        '
        Me.bttBuscarMovimientos.Image = Global.AydaraTPV.My.Resources.Resources.find
        Me.bttBuscarMovimientos.Location = New System.Drawing.Point(316, 7)
        Me.bttBuscarMovimientos.Name = "bttBuscarMovimientos"
        Me.bttBuscarMovimientos.Size = New System.Drawing.Size(77, 25)
        Me.bttBuscarMovimientos.TabIndex = 73
        Me.bttBuscarMovimientos.Text = "Buscar"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.EditValue = Nothing
        Me.txtFechaHasta.EnterMoveNextControl = True
        Me.txtFechaHasta.Location = New System.Drawing.Point(213, 10)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaHasta.Size = New System.Drawing.Size(94, 20)
        Me.txtFechaHasta.TabIndex = 72
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(176, 13)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl6.TabIndex = 71
        Me.LabelControl6.Text = "hasta:"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.EditValue = Nothing
        Me.txtFechaDesde.EnterMoveNextControl = True
        Me.txtFechaDesde.Location = New System.Drawing.Point(76, 10)
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaDesde.Size = New System.Drawing.Size(94, 20)
        Me.txtFechaDesde.TabIndex = 70
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(5, 13)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl24.TabIndex = 69
        Me.LabelControl24.Text = "Fecha desde:"
        '
        'TabReferencias
        '
        Me.TabReferencias.Controls.Add(Me.dgProveedores)
        Me.TabReferencias.Name = "TabReferencias"
        Me.TabReferencias.Size = New System.Drawing.Size(762, 165)
        Me.TabReferencias.Text = "Proveedores"
        '
        'dgProveedores
        '
        Me.dgProveedores.DataSource = Me.REFERENCIASPROVEEDORESBindingSource
        Me.dgProveedores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProveedores.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgProveedores.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgProveedores.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgProveedores.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.dgProveedores.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.dgProveedores.Location = New System.Drawing.Point(0, 0)
        Me.dgProveedores.MainView = Me.gvProveedores
        Me.dgProveedores.Name = "dgProveedores"
        Me.dgProveedores.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit2, Me.maskPrecio_Proveedor, Me.bttProveedor, Me.maskPrecioCoste_Proveedor})
        Me.dgProveedores.Size = New System.Drawing.Size(762, 165)
        Me.dgProveedores.TabIndex = 47
        Me.dgProveedores.UseEmbeddedNavigator = True
        Me.dgProveedores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvProveedores})
        '
        'REFERENCIASPROVEEDORESBindingSource
        '
        Me.REFERENCIASPROVEEDORESBindingSource.DataMember = "REFERENCIAS_PROVEEDORES"
        Me.REFERENCIASPROVEEDORESBindingSource.DataSource = Me.DsArticulos
        '
        'gvProveedores
        '
        Me.gvProveedores.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvProveedores.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvProveedores.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand2})
        Me.gvProveedores.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colCodigoProveedor, Me.colNombreProveedor, Me.colReferencia, Me.colPrecioCoste, Me.colPrecioVenta, Me.colUnidadesCaja, Me.colCompra_Albaran, Me.colCompra_Fecha, Me.colCompra_Unidades, Me.colCompra_Precio})
        Me.gvProveedores.GridControl = Me.dgProveedores
        Me.gvProveedores.GroupPanelText = "Arrastre una columna para agrupar por esa columna"
        Me.gvProveedores.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteTicket", Nothing, "{0:c2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteCobrado", Nothing, "{0:c2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImportePendiente", Nothing, "{0:c2}")})
        Me.gvProveedores.Name = "gvProveedores"
        Me.gvProveedores.OptionsBehavior.Editable = False
        Me.gvProveedores.OptionsMenu.EnableColumnMenu = False
        Me.gvProveedores.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvProveedores.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvProveedores.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvProveedores.OptionsView.EnableAppearanceEvenRow = True
        Me.gvProveedores.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvProveedores.OptionsView.ShowDetailButtons = False
        Me.gvProveedores.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.gvProveedores.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Datos proveedor"
        Me.GridBand1.Columns.Add(Me.colCodigoProveedor)
        Me.GridBand1.Columns.Add(Me.colNombreProveedor)
        Me.GridBand1.Columns.Add(Me.colReferencia)
        Me.GridBand1.Columns.Add(Me.colPrecioCoste)
        Me.GridBand1.Columns.Add(Me.colPrecioVenta)
        Me.GridBand1.Columns.Add(Me.colUnidadesCaja)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 738
        '
        'colCodigoProveedor
        '
        Me.colCodigoProveedor.Caption = "Proveedor"
        Me.colCodigoProveedor.ColumnEdit = Me.bttProveedor
        Me.colCodigoProveedor.FieldName = "CodigoProveedor"
        Me.colCodigoProveedor.Name = "colCodigoProveedor"
        Me.colCodigoProveedor.Visible = True
        Me.colCodigoProveedor.Width = 74
        '
        'bttProveedor
        '
        Me.bttProveedor.AutoHeight = False
        Me.bttProveedor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.bttProveedor.Name = "bttProveedor"
        '
        'colNombreProveedor
        '
        Me.colNombreProveedor.Caption = "Nombre"
        Me.colNombreProveedor.FieldName = "NombreProveedor"
        Me.colNombreProveedor.Name = "colNombreProveedor"
        Me.colNombreProveedor.OptionsColumn.AllowEdit = False
        Me.colNombreProveedor.OptionsColumn.AllowFocus = False
        Me.colNombreProveedor.Visible = True
        Me.colNombreProveedor.Width = 288
        '
        'colReferencia
        '
        Me.colReferencia.Caption = "Referencia"
        Me.colReferencia.FieldName = "Referencia"
        Me.colReferencia.Name = "colReferencia"
        Me.colReferencia.Visible = True
        Me.colReferencia.Width = 159
        '
        'colPrecioCoste
        '
        Me.colPrecioCoste.Caption = "P.Coste"
        Me.colPrecioCoste.ColumnEdit = Me.maskPrecioCoste_Proveedor
        Me.colPrecioCoste.FieldName = "PrecioCoste"
        Me.colPrecioCoste.Name = "colPrecioCoste"
        Me.colPrecioCoste.Visible = True
        Me.colPrecioCoste.Width = 70
        '
        'maskPrecioCoste_Proveedor
        '
        Me.maskPrecioCoste_Proveedor.AutoHeight = False
        Me.maskPrecioCoste_Proveedor.Mask.EditMask = "c3"
        Me.maskPrecioCoste_Proveedor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecioCoste_Proveedor.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecioCoste_Proveedor.Name = "maskPrecioCoste_Proveedor"
        '
        'colPrecioVenta
        '
        Me.colPrecioVenta.Caption = "P.V.R."
        Me.colPrecioVenta.ColumnEdit = Me.maskPrecio_Proveedor
        Me.colPrecioVenta.FieldName = "PrecioVenta"
        Me.colPrecioVenta.Name = "colPrecioVenta"
        Me.colPrecioVenta.Visible = True
        Me.colPrecioVenta.Width = 70
        '
        'maskPrecio_Proveedor
        '
        Me.maskPrecio_Proveedor.AutoHeight = False
        Me.maskPrecio_Proveedor.Mask.EditMask = "c2"
        Me.maskPrecio_Proveedor.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecio_Proveedor.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecio_Proveedor.Name = "maskPrecio_Proveedor"
        '
        'colUnidadesCaja
        '
        Me.colUnidadesCaja.Caption = "Uds/Caja"
        Me.colUnidadesCaja.FieldName = "UnidadesCaja"
        Me.colUnidadesCaja.Name = "colUnidadesCaja"
        Me.colUnidadesCaja.Visible = True
        Me.colUnidadesCaja.Width = 77
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "Última compra"
        Me.GridBand2.Columns.Add(Me.colCompra_Albaran)
        Me.GridBand2.Columns.Add(Me.colCompra_Fecha)
        Me.GridBand2.Columns.Add(Me.colCompra_Unidades)
        Me.GridBand2.Columns.Add(Me.colCompra_Precio)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.VisibleIndex = 1
        Me.GridBand2.Width = 300
        '
        'colCompra_Albaran
        '
        Me.colCompra_Albaran.Caption = "Albarán"
        Me.colCompra_Albaran.FieldName = "Compra_Albaran"
        Me.colCompra_Albaran.Name = "colCompra_Albaran"
        Me.colCompra_Albaran.OptionsColumn.AllowEdit = False
        Me.colCompra_Albaran.OptionsColumn.AllowFocus = False
        Me.colCompra_Albaran.Visible = True
        '
        'colCompra_Fecha
        '
        Me.colCompra_Fecha.Caption = "Fecha"
        Me.colCompra_Fecha.FieldName = "Compra_Fecha"
        Me.colCompra_Fecha.Name = "colCompra_Fecha"
        Me.colCompra_Fecha.OptionsColumn.AllowEdit = False
        Me.colCompra_Fecha.OptionsColumn.AllowFocus = False
        Me.colCompra_Fecha.Visible = True
        '
        'colCompra_Unidades
        '
        Me.colCompra_Unidades.Caption = "Cantidad"
        Me.colCompra_Unidades.DisplayFormat.FormatString = "n3"
        Me.colCompra_Unidades.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCompra_Unidades.FieldName = "Compra_Unidades"
        Me.colCompra_Unidades.Name = "colCompra_Unidades"
        Me.colCompra_Unidades.OptionsColumn.AllowEdit = False
        Me.colCompra_Unidades.OptionsColumn.AllowFocus = False
        Me.colCompra_Unidades.Visible = True
        '
        'colCompra_Precio
        '
        Me.colCompra_Precio.Caption = "Precio"
        Me.colCompra_Precio.DisplayFormat.FormatString = "c3"
        Me.colCompra_Precio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCompra_Precio.FieldName = "Compra_Precio"
        Me.colCompra_Precio.Name = "colCompra_Precio"
        Me.colCompra_Precio.OptionsColumn.AllowEdit = False
        Me.colCompra_Precio.OptionsColumn.AllowFocus = False
        Me.colCompra_Precio.Visible = True
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit2.Mask.EditMask = "G"
        Me.RepositoryItemDateEdit2.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'TabInventarios
        '
        Me.TabInventarios.Controls.Add(Me.dgInventarios)
        Me.TabInventarios.Name = "TabInventarios"
        Me.TabInventarios.Size = New System.Drawing.Size(762, 165)
        Me.TabInventarios.Text = "Inventarios"
        '
        'dgInventarios
        '
        Me.dgInventarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgInventarios.DataSource = Me.HISTORICOINVENTARIOBindingSource
        Me.dgInventarios.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgInventarios.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgInventarios.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgInventarios.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.dgInventarios.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.dgInventarios.Location = New System.Drawing.Point(0, 0)
        Me.dgInventarios.MainView = Me.gvInventarios
        Me.dgInventarios.Name = "dgInventarios"
        Me.dgInventarios.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit3, Me.mskCantidad})
        Me.dgInventarios.Size = New System.Drawing.Size(280, 162)
        Me.dgInventarios.TabIndex = 47
        Me.dgInventarios.UseEmbeddedNavigator = True
        Me.dgInventarios.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvInventarios})
        '
        'HISTORICOINVENTARIOBindingSource
        '
        Me.HISTORICOINVENTARIOBindingSource.DataMember = "HISTORICO_INVENTARIO"
        Me.HISTORICOINVENTARIOBindingSource.DataSource = Me.DsInventario
        '
        'DsInventario
        '
        Me.DsInventario.DataSetName = "dsInventario"
        Me.DsInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvInventarios
        '
        Me.gvInventarios.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvInventarios.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvInventarios.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFecha1, Me.colCantidad})
        Me.gvInventarios.GridControl = Me.dgInventarios
        Me.gvInventarios.GroupPanelText = "Arrastre una columna para agrupar por esa columna"
        Me.gvInventarios.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteTicket", Nothing, "{0:c2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteCobrado", Nothing, "{0:c2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImportePendiente", Nothing, "{0:c2}")})
        Me.gvInventarios.Name = "gvInventarios"
        Me.gvInventarios.OptionsBehavior.Editable = False
        Me.gvInventarios.OptionsMenu.EnableColumnMenu = False
        Me.gvInventarios.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvInventarios.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvInventarios.OptionsView.EnableAppearanceEvenRow = True
        Me.gvInventarios.OptionsView.ShowDetailButtons = False
        Me.gvInventarios.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.gvInventarios.OptionsView.ShowGroupPanel = False
        '
        'colFecha1
        '
        Me.colFecha1.Caption = "Fecha"
        Me.colFecha1.FieldName = "Fecha"
        Me.colFecha1.Name = "colFecha1"
        Me.colFecha1.Visible = True
        Me.colFecha1.VisibleIndex = 0
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.ColumnEdit = Me.mskCantidad
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 1
        '
        'mskCantidad
        '
        Me.mskCantidad.AutoHeight = False
        Me.mskCantidad.Mask.EditMask = "n3"
        Me.mskCantidad.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.mskCantidad.Name = "mskCantidad"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit3.Mask.EditMask = "G"
        Me.RepositoryItemDateEdit3.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'COLORESTableAdapter
        '
        Me.COLORESTableAdapter.ClearBeforeFill = True
        '
        'EXISTENCIASTableAdapter
        '
        Me.EXISTENCIASTableAdapter.ClearBeforeFill = True
        '
        'ARTICULOS_COLORESTableAdapter
        '
        Me.ARTICULOS_COLORESTableAdapter.ClearBeforeFill = True
        '
        'imgImagen
        '
        Me.imgImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgImagen.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "Imagen", True))
        Me.imgImagen.Location = New System.Drawing.Point(666, 12)
        Me.imgImagen.Name = "imgImagen"
        Me.imgImagen.Properties.NullText = "Sin imagen"
        Me.imgImagen.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.imgImagen.Properties.ReadOnly = True
        Me.imgImagen.Properties.ShowMenu = False
        Me.imgImagen.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.imgImagen.Size = New System.Drawing.Size(114, 128)
        Me.imgImagen.TabIndex = 81
        '
        'txtEtiqueta
        '
        Me.txtEtiqueta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEtiqueta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOSBindingSource, "Etiqueta", True))
        Me.txtEtiqueta.EnterMoveNextControl = True
        Me.txtEtiqueta.Location = New System.Drawing.Point(666, 139)
        Me.txtEtiqueta.Name = "txtEtiqueta"
        Me.txtEtiqueta.Properties.Appearance.Options.UseTextOptions = True
        Me.txtEtiqueta.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtEtiqueta.Properties.MaxLength = 20
        Me.txtEtiqueta.Properties.ReadOnly = True
        Me.txtEtiqueta.Size = New System.Drawing.Size(114, 20)
        Me.txtEtiqueta.TabIndex = 18
        Me.txtEtiqueta.TabStop = False
        '
        'lblTipoIVA
        '
        Me.lblTipoIVA.Location = New System.Drawing.Point(506, 12)
        Me.lblTipoIVA.Name = "lblTipoIVA"
        Me.lblTipoIVA.Size = New System.Drawing.Size(20, 13)
        Me.lblTipoIVA.TabIndex = 84
        Me.lblTipoIVA.Text = "Tipo"
        '
        'gcPromocion
        '
        Me.gcPromocion.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.gcPromocion.Appearance.Options.UseBackColor = True
        Me.gcPromocion.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gcPromocion.AppearanceCaption.ForeColor = System.Drawing.Color.Green
        Me.gcPromocion.AppearanceCaption.Options.UseFont = True
        Me.gcPromocion.AppearanceCaption.Options.UseForeColor = True
        Me.gcPromocion.Controls.Add(Me.ImgPromocion)
        Me.gcPromocion.Controls.Add(Me.lblPrecioPromocion)
        Me.gcPromocion.Controls.Add(Me.lblValidezPromocion)
        Me.gcPromocion.Location = New System.Drawing.Point(597, 251)
        Me.gcPromocion.Name = "gcPromocion"
        Me.gcPromocion.ShowCaption = False
        Me.gcPromocion.Size = New System.Drawing.Size(183, 55)
        Me.gcPromocion.TabIndex = 87
        Me.gcPromocion.Text = "Promoción"
        Me.gcPromocion.Visible = False
        '
        'ImgPromocion
        '
        Me.ImgPromocion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ImgPromocion.EditValue = Global.AydaraTPV.My.Resources.Resources.promocion
        Me.ImgPromocion.Location = New System.Drawing.Point(0, 0)
        Me.ImgPromocion.Name = "ImgPromocion"
        Me.ImgPromocion.Properties.AllowFocused = False
        Me.ImgPromocion.Properties.ReadOnly = True
        Me.ImgPromocion.Properties.ShowMenu = False
        Me.ImgPromocion.Size = New System.Drawing.Size(55, 36)
        Me.ImgPromocion.TabIndex = 88
        '
        'lblPrecioPromocion
        '
        Me.lblPrecioPromocion.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioPromocion.Appearance.ForeColor = System.Drawing.Color.Green
        Me.lblPrecioPromocion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lblPrecioPromocion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblPrecioPromocion.Location = New System.Drawing.Point(55, 0)
        Me.lblPrecioPromocion.Name = "lblPrecioPromocion"
        Me.lblPrecioPromocion.Size = New System.Drawing.Size(111, 42)
        Me.lblPrecioPromocion.TabIndex = 89
        Me.lblPrecioPromocion.Text = "99,999"
        '
        'lblValidezPromocion
        '
        Me.lblValidezPromocion.Location = New System.Drawing.Point(1, 39)
        Me.lblValidezPromocion.Name = "lblValidezPromocion"
        Me.lblValidezPromocion.Size = New System.Drawing.Size(58, 13)
        Me.lblValidezPromocion.TabIndex = 88
        Me.lblValidezPromocion.Text = "Valido hasta"
        '
        'bttAnterior
        '
        Me.bttAnterior.Enabled = False
        Me.bttAnterior.Image = CType(resources.GetObject("bttAnterior.Image"), System.Drawing.Image)
        Me.bttAnterior.Location = New System.Drawing.Point(209, 6)
        Me.bttAnterior.Name = "bttAnterior"
        Me.bttAnterior.Size = New System.Drawing.Size(70, 25)
        Me.bttAnterior.TabIndex = 88
        Me.bttAnterior.TabStop = False
        Me.bttAnterior.Text = "Anterior"
        '
        'bttSiguiente
        '
        Me.bttSiguiente.Enabled = False
        Me.bttSiguiente.Image = CType(resources.GetObject("bttSiguiente.Image"), System.Drawing.Image)
        Me.bttSiguiente.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.bttSiguiente.Location = New System.Drawing.Point(279, 6)
        Me.bttSiguiente.Name = "bttSiguiente"
        Me.bttSiguiente.Size = New System.Drawing.Size(70, 25)
        Me.bttSiguiente.TabIndex = 89
        Me.bttSiguiente.TabStop = False
        Me.bttSiguiente.Text = "Siguiente"
        '
        'cmbTipoUnidad
        '
        Me.cmbTipoUnidad.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "TipoUnidad_Id", True))
        Me.cmbTipoUnidad.Location = New System.Drawing.Point(147, 225)
        Me.cmbTipoUnidad.Name = "cmbTipoUnidad"
        Me.cmbTipoUnidad.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTipoUnidad.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Codigo", "Código"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", 80, "Descripción")})
        Me.cmbTipoUnidad.Properties.DataSource = Me.TIPOSUNIDADESBindingSource
        Me.cmbTipoUnidad.Properties.DisplayMember = "Codigo"
        Me.cmbTipoUnidad.Properties.NullText = ""
        Me.cmbTipoUnidad.Properties.ReadOnly = True
        Me.cmbTipoUnidad.Properties.ValueMember = "Id"
        Me.cmbTipoUnidad.Size = New System.Drawing.Size(46, 20)
        Me.cmbTipoUnidad.TabIndex = 15
        '
        'TIPOSUNIDADESBindingSource
        '
        Me.TIPOSUNIDADESBindingSource.DataMember = "TIPOS_UNIDADES"
        Me.TIPOSUNIDADESBindingSource.DataSource = Me.DsArticulos
        '
        'TIPOS_UNIDADESTableAdapter
        '
        Me.TIPOS_UNIDADESTableAdapter.ClearBeforeFill = True
        '
        'checkArticuloPeso
        '
        Me.checkArticuloPeso.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "ArticuloPeso", True))
        Me.checkArticuloPeso.Location = New System.Drawing.Point(548, 164)
        Me.checkArticuloPeso.Name = "checkArticuloPeso"
        Me.checkArticuloPeso.Properties.Caption = "Artículo de peso:"
        Me.checkArticuloPeso.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.checkArticuloPeso.Properties.ReadOnly = True
        Me.checkArticuloPeso.Size = New System.Drawing.Size(104, 19)
        Me.checkArticuloPeso.TabIndex = 12
        Me.checkArticuloPeso.TabStop = False
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(435, 202)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl7.TabIndex = 90
        Me.LabelControl7.Text = "Tipo de artículo:"
        '
        'txtTipoArticulo
        '
        Me.txtTipoArticulo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOSBindingSource, "TipoArticulo", True))
        Me.txtTipoArticulo.EnterMoveNextControl = True
        Me.txtTipoArticulo.Location = New System.Drawing.Point(518, 199)
        Me.txtTipoArticulo.Name = "txtTipoArticulo"
        Me.txtTipoArticulo.Properties.MaxLength = 1
        Me.txtTipoArticulo.Properties.ReadOnly = True
        Me.txtTipoArticulo.Size = New System.Drawing.Size(24, 20)
        Me.txtTipoArticulo.TabIndex = 12
        '
        'bttEliminarImagen
        '
        Me.bttEliminarImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttEliminarImagen.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.bttEliminarImagen.Appearance.Options.UseBackColor = True
        Me.bttEliminarImagen.BackgroundImage = Global.AydaraTPV.My.Resources.Resources._1321518972_close
        Me.bttEliminarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bttEliminarImagen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.bttEliminarImagen.Enabled = False
        Me.bttEliminarImagen.Location = New System.Drawing.Point(636, 37)
        Me.bttEliminarImagen.Name = "bttEliminarImagen"
        Me.bttEliminarImagen.Size = New System.Drawing.Size(31, 28)
        Me.bttEliminarImagen.TabIndex = 93
        Me.bttEliminarImagen.TabStop = False
        '
        'bttNuevaImagen
        '
        Me.bttNuevaImagen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttNuevaImagen.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.bttNuevaImagen.Appearance.Options.UseBackColor = True
        Me.bttNuevaImagen.BackgroundImage = Global.AydaraTPV.My.Resources.Resources.find
        Me.bttNuevaImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.bttNuevaImagen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.bttNuevaImagen.Enabled = False
        Me.bttNuevaImagen.Location = New System.Drawing.Point(636, 12)
        Me.bttNuevaImagen.Name = "bttNuevaImagen"
        Me.bttNuevaImagen.Size = New System.Drawing.Size(31, 28)
        Me.bttNuevaImagen.TabIndex = 92
        Me.bttNuevaImagen.TabStop = False
        '
        'TALLASTableAdapter
        '
        Me.TALLASTableAdapter.ClearBeforeFill = True
        '
        'checkTpvTactil
        '
        Me.checkTpvTactil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkTpvTactil.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "TpvTactil", True))
        Me.checkTpvTactil.Location = New System.Drawing.Point(673, 165)
        Me.checkTpvTactil.Name = "checkTpvTactil"
        Me.checkTpvTactil.Properties.AutoWidth = True
        Me.checkTpvTactil.Properties.Caption = "Mostrar en TPV:"
        Me.checkTpvTactil.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.checkTpvTactil.Properties.ReadOnly = True
        Me.checkTpvTactil.Size = New System.Drawing.Size(99, 19)
        Me.checkTpvTactil.TabIndex = 94
        Me.checkTpvTactil.TabStop = False
        '
        'REFERENCIAS_PROVEEDORESTableAdapter
        '
        Me.REFERENCIAS_PROVEEDORESTableAdapter.ClearBeforeFill = True
        '
        'HISTORICO_INVENTARIOTableAdapter
        '
        Me.HISTORICO_INVENTARIOTableAdapter.ClearBeforeFill = True
        '
        'txtDtoFidelizacion
        '
        Me.txtDtoFidelizacion.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "DtoFidelizacion", True))
        Me.txtDtoFidelizacion.EnterMoveNextControl = True
        Me.txtDtoFidelizacion.Location = New System.Drawing.Point(661, 199)
        Me.txtDtoFidelizacion.Name = "txtDtoFidelizacion"
        Me.txtDtoFidelizacion.Properties.Appearance.Options.UseTextOptions = True
        Me.txtDtoFidelizacion.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtDtoFidelizacion.Properties.Mask.EditMask = "P2"
        Me.txtDtoFidelizacion.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtDtoFidelizacion.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtDtoFidelizacion.Properties.ReadOnly = True
        Me.txtDtoFidelizacion.Size = New System.Drawing.Size(66, 20)
        Me.txtDtoFidelizacion.TabIndex = 13
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(583, 202)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl28.TabIndex = 101
        Me.LabelControl28.Text = "% Fidelización:"
        '
        'txtCodigoBascula
        '
        Me.txtCodigoBascula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOSBindingSource, "CodigoBascula", True))
        Me.txtCodigoBascula.EnterMoveNextControl = True
        Me.txtCodigoBascula.Location = New System.Drawing.Point(492, 277)
        Me.txtCodigoBascula.Name = "txtCodigoBascula"
        Me.txtCodigoBascula.Properties.MaxLength = 1
        Me.txtCodigoBascula.Properties.ReadOnly = True
        Me.txtCodigoBascula.Size = New System.Drawing.Size(24, 20)
        Me.txtCodigoBascula.TabIndex = 21
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(449, 280)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl21.TabIndex = 103
        Me.LabelControl21.Text = "Báscula:"
        '
        'txtPLU
        '
        Me.txtPLU.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ARTICULOSBindingSource, "PLU", True))
        Me.txtPLU.EnterMoveNextControl = True
        Me.txtPLU.Location = New System.Drawing.Point(550, 277)
        Me.txtPLU.Name = "txtPLU"
        Me.txtPLU.Properties.Mask.EditMask = "n0"
        Me.txtPLU.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPLU.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtPLU.Properties.MaxLength = 1
        Me.txtPLU.Properties.ReadOnly = True
        Me.txtPLU.Size = New System.Drawing.Size(36, 20)
        Me.txtPLU.TabIndex = 22
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(522, 280)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl29.TabIndex = 105
        Me.LabelControl29.Text = "PLU:"
        '
        'txtImporteEcoraee
        '
        Me.txtImporteEcoraee.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "ImporteEcoraee", True))
        Me.txtImporteEcoraee.EnterMoveNextControl = True
        Me.txtImporteEcoraee.Location = New System.Drawing.Point(518, 251)
        Me.txtImporteEcoraee.Name = "txtImporteEcoraee"
        Me.txtImporteEcoraee.Properties.Appearance.Options.UseTextOptions = True
        Me.txtImporteEcoraee.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtImporteEcoraee.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtImporteEcoraee.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtImporteEcoraee.Properties.ReadOnly = True
        Me.txtImporteEcoraee.Size = New System.Drawing.Size(68, 20)
        Me.txtImporteEcoraee.TabIndex = 20
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(477, 254)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl30.TabIndex = 107
        Me.LabelControl30.Text = "Sigaus:"
        '
        'txtEquivalencia
        '
        Me.txtEquivalencia.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.ARTICULOSBindingSource, "Equivalencia", True))
        Me.txtEquivalencia.EnterMoveNextControl = True
        Me.txtEquivalencia.Location = New System.Drawing.Point(661, 225)
        Me.txtEquivalencia.Name = "txtEquivalencia"
        Me.txtEquivalencia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtEquivalencia.Properties.ReadOnly = True
        Me.txtEquivalencia.Size = New System.Drawing.Size(119, 20)
        Me.txtEquivalencia.TabIndex = 19
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(592, 228)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl31.TabIndex = 109
        Me.LabelControl31.Text = "Equivalencia:"
        '
        'bttImprimirEtiqueta
        '
        Me.bttImprimirEtiqueta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttImprimirEtiqueta.Enabled = False
        Me.bttImprimirEtiqueta.Image = Global.AydaraTPV.My.Resources.Resources.tickets
        Me.bttImprimirEtiqueta.Location = New System.Drawing.Point(460, 509)
        Me.bttImprimirEtiqueta.Name = "bttImprimirEtiqueta"
        Me.bttImprimirEtiqueta.Size = New System.Drawing.Size(106, 45)
        Me.bttImprimirEtiqueta.TabIndex = 110
        Me.bttImprimirEtiqueta.TabStop = False
        Me.bttImprimirEtiqueta.Text = "Etiqueta"
        '
        'Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.bttImprimirEtiqueta)
        Me.Controls.Add(Me.txtEquivalencia)
        Me.Controls.Add(Me.LabelControl31)
        Me.Controls.Add(Me.txtImporteEcoraee)
        Me.Controls.Add(Me.LabelControl30)
        Me.Controls.Add(Me.LabelControl29)
        Me.Controls.Add(Me.txtPLU)
        Me.Controls.Add(Me.txtCodigoBascula)
        Me.Controls.Add(Me.LabelControl21)
        Me.Controls.Add(Me.txtDtoFidelizacion)
        Me.Controls.Add(Me.LabelControl28)
        Me.Controls.Add(Me.imgImagen)
        Me.Controls.Add(Me.checkTpvTactil)
        Me.Controls.Add(Me.bttEliminarImagen)
        Me.Controls.Add(Me.bttNuevaImagen)
        Me.Controls.Add(Me.txtTipoArticulo)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.checkArticuloPeso)
        Me.Controls.Add(Me.cmbTipoUnidad)
        Me.Controls.Add(Me.bttSiguiente)
        Me.Controls.Add(Me.bttAnterior)
        Me.Controls.Add(Me.gcPromocion)
        Me.Controls.Add(Me.lblTipoIVA)
        Me.Controls.Add(Me.txtEtiqueta)
        Me.Controls.Add(Me.TabArticulo)
        Me.Controls.Add(Me.txtDescripcionEnvase)
        Me.Controls.Add(Me.cmbTipoIVA)
        Me.Controls.Add(Me.panelExistencias)
        Me.Controls.Add(Me.txtPrecioCoste)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.txtPesoUnidad)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.txtMinimoCompra)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.txtMinimoVenta)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txtUnidadCaja)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txtFechaAlta)
        Me.Controls.Add(Me.txtCodigoTalla)
        Me.Controls.Add(Me.lblCodigoTalla)
        Me.Controls.Add(Me.txtCodigoEnvase)
        Me.Controls.Add(Me.txtNombreProveedor)
        Me.Controls.Add(Me.txtDescripcionSubfamilia)
        Me.Controls.Add(Me.txtDescripcionFamilia)
        Me.Controls.Add(Me.txtCodigoProveedor)
        Me.Controls.Add(Me.txtCodigoSubfamilia)
        Me.Controls.Add(Me.txtCodigoFamilia)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.bttBuscar)
        Me.Controls.Add(Me.bttModificar)
        Me.Controls.Add(Me.bttNuevo)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.bttEliminar)
        Me.Controls.Add(Me.CheckCantidadVariable)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.bttGuardar)
        Me.Controls.Add(Me.CheckControlEtiquetas)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.lblTextoImpuesto)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.CheckControlBaja)
        Me.KeyPreview = True
        Me.Name = "Articulos"
        Me.Text = "Artículos"
        CType(Me.ARTICULOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CODIGOBARRASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckCantidadVariable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckControlEtiquetas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckControlBaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCodigoBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCodigoBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskCodigoBarras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCodigoBarrasColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCodigoBarrasTallas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TALLASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoSubfamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionFamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionSubfamilia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreProveedor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoEnvase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgExistencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EXISTENCIASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvExistencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskCodigoBarrasTalla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoTalla.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaAlta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaAlta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUnidadCaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinimoVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinimoCompra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPesoUnidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescuento.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrecioCoste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistenciaInicial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExistenciasActual.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockMinimo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStockMaximo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelExistencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelExistencias.ResumeLayout(False)
        Me.panelExistencias.PerformLayout()
        CType(Me.cmbTipoIVA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescripcionEnvase.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabArticulo.ResumeLayout(False)
        Me.TabTallasColores.ResumeLayout(False)
        Me.TabTallasColores.PerformLayout()
        CType(Me.ARTICULOSCOLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores_Id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCodigoBarras.ResumeLayout(False)
        CType(Me.gcEtiquetaElectronica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcEtiquetaElectronica.ResumeLayout(False)
        Me.gcEtiquetaElectronica.PerformLayout()
        CType(Me.txtEE_Formato.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FORMATOSEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCodigosBarras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEE_Calibre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEE_Categoria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEE_Origen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEE_CodigoBarras.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xtpMovimientos.ResumeLayout(False)
        CType(Me.dgMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabReferencias.ResumeLayout(False)
        CType(Me.dgProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.REFERENCIASPROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecioCoste_Proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio_Proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabInventarios.ResumeLayout(False)
        CType(Me.dgInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HISTORICOINVENTARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mskCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgImagen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEtiqueta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcPromocion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcPromocion.ResumeLayout(False)
        Me.gcPromocion.PerformLayout()
        CType(Me.ImgPromocion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTipoUnidad.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPOSUNIDADESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkArticuloPeso.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTipoArticulo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkTpvTactil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDtoFidelizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoBascula.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPLU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImporteEcoraee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEquivalencia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckControlBaja As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTextoImpuesto As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescripcion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsArticulos As AydaraTPV.dsArticulos
    Friend WithEvents ARTICULOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARTICULOSTableAdapter As AydaraTPV.dsArticulosTableAdapters.ARTICULOSTableAdapter
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckCantidadVariable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckControlEtiquetas As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CODIGOBARRASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CODIGO_BARRASTableAdapter As AydaraTPV.dsArticulosTableAdapters.CODIGO_BARRASTableAdapter
    Friend WithEvents bttNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttModificar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NavListadoCodigoBarras As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents dgCodigoBarras As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCodigoBarras As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoBarras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colArticulo_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCodigoFamilia As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCodigoSubfamilia As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCodigoProveedor As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtDescripcionFamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcionSubfamilia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreProveedor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoEnvase As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents dgExistencias As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvExistencias As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblCodigoTalla As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoTalla As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtFechaAlta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtUnidadCaja As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinimoVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinimoCompra As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPesoUnidad As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescuento As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecioVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrecioCoste As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExistenciaInicial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtExistenciasActual As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStockMinimo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStockMaximo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents panelExistencias As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbTipoIVA As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txtDescripcionEnvase As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colCodigoTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabArticulo As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabCodigoBarras As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabTallasColores As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgColores As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvColores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents COLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COLORESTableAdapter As AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter
    Friend WithEvents EXISTENCIASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EXISTENCIASTableAdapter As AydaraTPV.dsArticulosTableAdapters.EXISTENCIASTableAdapter
    Friend WithEvents colExistenciasTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExistenciasExistenciaInicial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExistenciasExistenciaActual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExistenciasStockMinimo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExistenciasStockMaximo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExistenciasPrecioVenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NavListadoColores As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents ARTICULOSCOLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARTICULOS_COLORESTableAdapter As AydaraTPV.dsArticulosTableAdapters.ARTICULOS_COLORESTableAdapter
    Friend WithEvents colColores_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColores_Articulo_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColores_Color_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents imgImagen As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cmbColores_Id As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbColores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colColores_Color As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExistenciasCodigoTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExistenciasCodigoBarras As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblColorSeleccionado As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEtiquetaColor As DevExpress.XtraEditors.LabelControl
    Friend WithEvents maskPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents maskCodigoBarras As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents maskCodigoBarrasTalla As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtEtiqueta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colCodigoBarras_Color As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoBarras_Talla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbCodigoBarrasColores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colDescripciontalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTipoIVA As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcPromocion As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblValidezPromocion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblPrecioPromocion As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ImgPromocion As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents bttAnterior As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttSiguiente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbTipoUnidad As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TIPOSUNIDADESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TIPOS_UNIDADESTableAdapter As AydaraTPV.dsArticulosTableAdapters.TIPOS_UNIDADESTableAdapter
    Friend WithEvents checkArticuloPeso As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTipoArticulo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttEliminarImagen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttNuevaImagen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbCodigoBarrasTallas As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TALLASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TALLASTableAdapter As AydaraTPV.dsArticulosTableAdapters.TALLASTableAdapter
    Friend WithEvents colDescripcionColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents checkTpvTactil As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents xtpMovimientos As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents bsMovimientos As System.Windows.Forms.BindingSource
    Friend WithEvents dgMovimientos As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvMovimientos As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntrada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalida As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents bttBuscarMovimientos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TabReferencias As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgProveedores As DevExpress.XtraGrid.GridControl
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents REFERENCIASPROVEEDORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents REFERENCIAS_PROVEEDORESTableAdapter As AydaraTPV.dsArticulosTableAdapters.REFERENCIAS_PROVEEDORESTableAdapter
    Friend WithEvents bttProveedor As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents maskPrecio_Proveedor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents gvProveedores As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCodigoProveedor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNombreProveedor As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colReferencia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecioCoste As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPrecioVenta As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colUnidadesCaja As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCompra_Albaran As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCompra_Fecha As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCompra_Unidades As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCompra_Precio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents maskPrecioCoste_Proveedor As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TabInventarios As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents dgInventarios As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvInventarios As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents DsInventario As AydaraTPV.dsInventario
    Friend WithEvents HISTORICOINVENTARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HISTORICO_INVENTARIOTableAdapter As AydaraTPV.dsInventarioTableAdapters.HISTORICO_INVENTARIOTableAdapter
    Friend WithEvents colFecha1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mskCantidad As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents txtDtoFidelizacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoBascula As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPLU As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents gcEtiquetaElectronica As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEE_Calibre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEE_Categoria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEE_Origen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEE_CodigoBarras As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEE_Formato As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbCodigosBarras As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bttExportarMovimientos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents FORMATOSEEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtImporteEcoraee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEquivalencia As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttImprimirEtiqueta As DevExpress.XtraEditors.SimpleButton
End Class
