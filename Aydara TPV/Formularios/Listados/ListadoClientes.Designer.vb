<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoClientes
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
        Me.panelImprimir = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txtTituloListado = New DevExpress.XtraEditors.TextEdit()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgBusqueda = New DevExpress.XtraGrid.GridControl()
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsClientes = New AydaraTPV.dsClientes()
        Me.gvBusqueda = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.colCodigo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colNombreFiscal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTelParticular = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTelMovil = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colSaldoPuntos = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDireccion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCodigoPostal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPoblacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCIF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colProvincia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colControlBaja = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCaducidadTarjeta = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDescuentoTarjeta = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTieneTarjeta = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.gcOpciones = New DevExpress.XtraEditors.GroupControl()
        Me.checkControlBaja = New DevExpress.XtraEditors.CheckEdit()
        Me.checkDetallado = New DevExpress.XtraEditors.CheckEdit()
        Me.txtPoblacion = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoPostalFin = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCodigoPostalInicio = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtNombreFin = New DevExpress.XtraEditors.TextEdit()
        Me.txtNombreInicio = New DevExpress.XtraEditors.TextEdit()
        Me.txtCodigoFin = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtCodigoInicio = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.CLIENTESTableAdapter = New AydaraTPV.dsClientesTableAdapters.CLIENTESTableAdapter()
        Me.colClienteCredito = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImprimir.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtTituloListado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcOpciones.SuspendLayout()
        CType(Me.checkControlBaja.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkDetallado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPoblacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoPostalFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoPostalInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelImprimir
        '
        Me.panelImprimir.Controls.Add(Me.PanelControl2)
        Me.panelImprimir.Controls.Add(Me.bttCancelar)
        Me.panelImprimir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelImprimir.Location = New System.Drawing.Point(0, 492)
        Me.panelImprimir.Name = "panelImprimir"
        Me.panelImprimir.Size = New System.Drawing.Size(784, 70)
        Me.panelImprimir.TabIndex = 22
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PanelControl2.Controls.Add(Me.bttImprimir)
        Me.PanelControl2.Controls.Add(Me.LabelControl8)
        Me.PanelControl2.Controls.Add(Me.txtTituloListado)
        Me.PanelControl2.Location = New System.Drawing.Point(390, 12)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(383, 45)
        Me.PanelControl2.TabIndex = 125
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttImprimir.Location = New System.Drawing.Point(266, 0)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(117, 45)
        Me.bttImprimir.TabIndex = 0
        Me.bttImprimir.Text = "Imprimir listado"
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl8.TabIndex = 3
        Me.LabelControl8.Text = "Título del listado:"
        '
        'txtTituloListado
        '
        Me.txtTituloListado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTituloListado.Location = New System.Drawing.Point(5, 20)
        Me.txtTituloListado.Name = "txtTituloListado"
        Me.txtTituloListado.Size = New System.Drawing.Size(255, 20)
        Me.txtTituloListado.TabIndex = 4
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Image = Global.AydaraTPV.My.Resources.Resources.cancel
        Me.bttCancelar.Location = New System.Drawing.Point(11, 13)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(106, 45)
        Me.bttCancelar.TabIndex = 124
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'dgBusqueda
        '
        Me.dgBusqueda.DataSource = Me.CLIENTESBindingSource
        Me.dgBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBusqueda.Location = New System.Drawing.Point(0, 120)
        Me.dgBusqueda.MainView = Me.gvBusqueda
        Me.dgBusqueda.Name = "dgBusqueda"
        Me.dgBusqueda.Size = New System.Drawing.Size(784, 372)
        Me.dgBusqueda.TabIndex = 23
        Me.dgBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBusqueda})
        '
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource.DataSource = Me.DsClientes
        '
        'DsClientes
        '
        Me.DsClientes.DataSetName = "dsClientes"
        Me.DsClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvBusqueda
        '
        Me.gvBusqueda.AppearancePrint.BandPanel.Options.UseTextOptions = True
        Me.gvBusqueda.AppearancePrint.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvBusqueda.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvBusqueda.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvBusqueda.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.gvBusqueda.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colCodigo, Me.colNombreFiscal, Me.colCIF, Me.colDireccion, Me.colCodigoPostal, Me.colPoblacion, Me.colProvincia, Me.colTelParticular, Me.colTelMovil, Me.colControlBaja, Me.colCaducidadTarjeta, Me.colDescuentoTarjeta, Me.colTieneTarjeta, Me.colSaldoPuntos, Me.colClienteCredito})
        Me.gvBusqueda.GridControl = Me.dgBusqueda
        Me.gvBusqueda.GroupPanelText = "Arrastre una columna para agrupar por esa columna"
        Me.gvBusqueda.Name = "gvBusqueda"
        Me.gvBusqueda.OptionsBehavior.Editable = False
        Me.gvBusqueda.OptionsMenu.EnableColumnMenu = False
        Me.gvBusqueda.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvBusqueda.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvBusqueda.OptionsView.ColumnAutoWidth = True
        Me.gvBusqueda.OptionsView.EnableAppearanceEvenRow = True
        Me.gvBusqueda.OptionsView.ShowAutoFilterRow = True
        Me.gvBusqueda.OptionsView.ShowDetailButtons = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.OptionsColumn.FixedWidth = True
        Me.colCodigo.Visible = True
        Me.colCodigo.Width = 80
        '
        'colNombreFiscal
        '
        Me.colNombreFiscal.FieldName = "NombreFiscal"
        Me.colNombreFiscal.Name = "colNombreFiscal"
        Me.colNombreFiscal.Visible = True
        Me.colNombreFiscal.Width = 354
        '
        'colTelParticular
        '
        Me.colTelParticular.FieldName = "TelParticular"
        Me.colTelParticular.Name = "colTelParticular"
        Me.colTelParticular.OptionsColumn.FixedWidth = True
        Me.colTelParticular.Visible = True
        Me.colTelParticular.Width = 100
        '
        'colTelMovil
        '
        Me.colTelMovil.FieldName = "TelMovil"
        Me.colTelMovil.Name = "colTelMovil"
        Me.colTelMovil.OptionsColumn.FixedWidth = True
        Me.colTelMovil.Visible = True
        Me.colTelMovil.Width = 89
        '
        'colSaldoPuntos
        '
        Me.colSaldoPuntos.Caption = "Saldo puntos"
        Me.colSaldoPuntos.DisplayFormat.FormatString = "{0:n2}"
        Me.colSaldoPuntos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSaldoPuntos.FieldName = "SaldoPuntos"
        Me.colSaldoPuntos.Name = "colSaldoPuntos"
        Me.colSaldoPuntos.Visible = True
        Me.colSaldoPuntos.Width = 73
        '
        'colDireccion
        '
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.RowIndex = 1
        Me.colDireccion.Width = 383
        '
        'colCodigoPostal
        '
        Me.colCodigoPostal.Caption = "C.P."
        Me.colCodigoPostal.FieldName = "CodigoPostal"
        Me.colCodigoPostal.Name = "colCodigoPostal"
        Me.colCodigoPostal.OptionsColumn.FixedWidth = True
        Me.colCodigoPostal.RowIndex = 1
        Me.colCodigoPostal.Width = 80
        '
        'colPoblacion
        '
        Me.colPoblacion.FieldName = "Poblacion"
        Me.colPoblacion.Name = "colPoblacion"
        Me.colPoblacion.OptionsColumn.FixedWidth = True
        Me.colPoblacion.RowIndex = 1
        Me.colPoblacion.Width = 200
        '
        'colCIF
        '
        Me.colCIF.FieldName = "CIF"
        Me.colCIF.Name = "colCIF"
        Me.colCIF.OptionsColumn.FixedWidth = True
        Me.colCIF.RowIndex = 1
        Me.colCIF.Width = 100
        '
        'colProvincia
        '
        Me.colProvincia.FieldName = "Provincia"
        Me.colProvincia.Name = "colProvincia"
        Me.colProvincia.Visible = True
        '
        'colControlBaja
        '
        Me.colControlBaja.FieldName = "ControlBaja"
        Me.colControlBaja.Name = "colControlBaja"
        Me.colControlBaja.Visible = True
        '
        'colCaducidadTarjeta
        '
        Me.colCaducidadTarjeta.FieldName = "CaducidadTarjeta"
        Me.colCaducidadTarjeta.Name = "colCaducidadTarjeta"
        Me.colCaducidadTarjeta.Visible = True
        '
        'colDescuentoTarjeta
        '
        Me.colDescuentoTarjeta.FieldName = "DescuentoTarjeta"
        Me.colDescuentoTarjeta.Name = "colDescuentoTarjeta"
        Me.colDescuentoTarjeta.Visible = True
        '
        'colTieneTarjeta
        '
        Me.colTieneTarjeta.FieldName = "TieneTarjeta"
        Me.colTieneTarjeta.Name = "colTieneTarjeta"
        Me.colTieneTarjeta.Visible = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.bttBuscar)
        Me.PanelControl1.Controls.Add(Me.gcOpciones)
        Me.PanelControl1.Controls.Add(Me.txtPoblacion)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtCodigoPostalFin)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtCodigoPostalInicio)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txtNombreFin)
        Me.PanelControl1.Controls.Add(Me.txtNombreInicio)
        Me.PanelControl1.Controls.Add(Me.txtCodigoFin)
        Me.PanelControl1.Controls.Add(Me.txtCodigoInicio)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(784, 120)
        Me.PanelControl1.TabIndex = 24
        '
        'bttBuscar
        '
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.find
        Me.bttBuscar.Location = New System.Drawing.Point(461, 77)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(117, 32)
        Me.bttBuscar.TabIndex = 34
        Me.bttBuscar.Text = "Buscar"
        '
        'gcOpciones
        '
        Me.gcOpciones.Controls.Add(Me.checkControlBaja)
        Me.gcOpciones.Controls.Add(Me.checkDetallado)
        Me.gcOpciones.Location = New System.Drawing.Point(270, 61)
        Me.gcOpciones.Name = "gcOpciones"
        Me.gcOpciones.Size = New System.Drawing.Size(180, 48)
        Me.gcOpciones.TabIndex = 33
        Me.gcOpciones.Text = "Opciones"
        '
        'checkControlBaja
        '
        Me.checkControlBaja.Location = New System.Drawing.Point(5, 23)
        Me.checkControlBaja.Name = "checkControlBaja"
        Me.checkControlBaja.Properties.Caption = "Control de Baja"
        Me.checkControlBaja.Size = New System.Drawing.Size(99, 19)
        Me.checkControlBaja.TabIndex = 5
        Me.checkControlBaja.TabStop = False
        '
        'checkDetallado
        '
        Me.checkDetallado.Location = New System.Drawing.Point(110, 23)
        Me.checkDetallado.Name = "checkDetallado"
        Me.checkDetallado.Properties.Caption = "Detallado"
        Me.checkDetallado.Size = New System.Drawing.Size(75, 19)
        Me.checkDetallado.TabIndex = 6
        Me.checkDetallado.TabStop = False
        '
        'txtPoblacion
        '
        Me.txtPoblacion.EnterMoveNextControl = True
        Me.txtPoblacion.Location = New System.Drawing.Point(67, 89)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Properties.MaxLength = 50
        Me.txtPoblacion.Size = New System.Drawing.Size(197, 20)
        Me.txtPoblacion.TabIndex = 28
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 92)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl5.TabIndex = 32
        Me.LabelControl5.Text = "Población:"
        '
        'txtCodigoPostalFin
        '
        Me.txtCodigoPostalFin.EnterMoveNextControl = True
        Me.txtCodigoPostalFin.Location = New System.Drawing.Point(209, 61)
        Me.txtCodigoPostalFin.Name = "txtCodigoPostalFin"
        Me.txtCodigoPostalFin.Properties.MaxLength = 5
        Me.txtCodigoPostalFin.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoPostalFin.TabIndex = 26
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(176, 64)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl4.TabIndex = 31
        Me.LabelControl4.Text = "hasta"
        '
        'txtCodigoPostalInicio
        '
        Me.txtCodigoPostalInicio.EnterMoveNextControl = True
        Me.txtCodigoPostalInicio.Location = New System.Drawing.Point(115, 61)
        Me.txtCodigoPostalInicio.Name = "txtCodigoPostalInicio"
        Me.txtCodigoPostalInicio.Properties.MaxLength = 5
        Me.txtCodigoPostalInicio.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoPostalInicio.TabIndex = 25
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 64)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl3.TabIndex = 30
        Me.LabelControl3.Text = "Código postal desde"
        '
        'txtNombreFin
        '
        Me.txtNombreFin.Location = New System.Drawing.Point(133, 35)
        Me.txtNombreFin.Name = "txtNombreFin"
        Me.txtNombreFin.Properties.ReadOnly = True
        Me.txtNombreFin.Size = New System.Drawing.Size(317, 20)
        Me.txtNombreFin.TabIndex = 29
        Me.txtNombreFin.TabStop = False
        '
        'txtNombreInicio
        '
        Me.txtNombreInicio.Location = New System.Drawing.Point(133, 9)
        Me.txtNombreInicio.Name = "txtNombreInicio"
        Me.txtNombreInicio.Properties.ReadOnly = True
        Me.txtNombreInicio.Size = New System.Drawing.Size(317, 20)
        Me.txtNombreInicio.TabIndex = 27
        Me.txtNombreInicio.TabStop = False
        '
        'txtCodigoFin
        '
        Me.txtCodigoFin.EnterMoveNextControl = True
        Me.txtCodigoFin.Location = New System.Drawing.Point(52, 35)
        Me.txtCodigoFin.Name = "txtCodigoFin"
        Me.txtCodigoFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoFin.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigoFin.Properties.MaxLength = 8
        Me.txtCodigoFin.Size = New System.Drawing.Size(82, 20)
        Me.txtCodigoFin.TabIndex = 23
        '
        'txtCodigoInicio
        '
        Me.txtCodigoInicio.EnterMoveNextControl = True
        Me.txtCodigoInicio.Location = New System.Drawing.Point(52, 9)
        Me.txtCodigoInicio.Name = "txtCodigoInicio"
        Me.txtCodigoInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtCodigoInicio.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.txtCodigoInicio.Properties.MaxLength = 8
        Me.txtCodigoInicio.Size = New System.Drawing.Size(82, 20)
        Me.txtCodigoInicio.TabIndex = 21
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 24
        Me.LabelControl2.Text = "Hasta:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 22
        Me.LabelControl1.Text = "Desde:"
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'colClienteCredito
        '
        Me.colClienteCredito.Caption = "Código A3"
        Me.colClienteCredito.FieldName = "ClienteCredito"
        Me.colClienteCredito.Name = "colClienteCredito"
        Me.colClienteCredito.Visible = True
        Me.colClienteCredito.Width = 70
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Datos del cliente"
        Me.GridBand1.Columns.Add(Me.colCodigo)
        Me.GridBand1.Columns.Add(Me.colClienteCredito)
        Me.GridBand1.Columns.Add(Me.colNombreFiscal)
        Me.GridBand1.Columns.Add(Me.colTelParticular)
        Me.GridBand1.Columns.Add(Me.colTelMovil)
        Me.GridBand1.Columns.Add(Me.colSaldoPuntos)
        Me.GridBand1.Columns.Add(Me.colDireccion)
        Me.GridBand1.Columns.Add(Me.colCodigoPostal)
        Me.GridBand1.Columns.Add(Me.colPoblacion)
        Me.GridBand1.Columns.Add(Me.colCIF)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 766
        '
        'ListadoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgBusqueda)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.panelImprimir)
        Me.KeyPreview = True
        Me.Name = "ListadoClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado de clientes"
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImprimir.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtTituloListado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcOpciones.ResumeLayout(False)
        CType(Me.checkControlBaja.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkDetallado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPoblacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoPostalFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoPostalInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelImprimir As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents checkControlBaja As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents checkDetallado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtPoblacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoPostalFin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoPostalInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNombreFin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigoFin As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCodigoInicio As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DsClientes As AydaraTPV.dsClientes
    Friend WithEvents CLIENTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLIENTESTableAdapter As AydaraTPV.dsClientesTableAdapters.CLIENTESTableAdapter
    Friend WithEvents gvBusqueda As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNombreFiscal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCIF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoPostal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPoblacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProvincia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTelParticular As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTelMovil As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colControlBaja As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCaducidadTarjeta As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDescuentoTarjeta As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTieneTarjeta As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTituloListado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colSaldoPuntos As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colClienteCredito As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
End Class
