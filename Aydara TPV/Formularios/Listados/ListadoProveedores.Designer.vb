<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoProveedores
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
        Me.components = New System.ComponentModel.Container
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodigoInicio = New DevExpress.XtraEditors.ButtonEdit
        Me.txtCodigoFin = New DevExpress.XtraEditors.ButtonEdit
        Me.txtNombreInicio = New DevExpress.XtraEditors.TextEdit
        Me.txtNombreFin = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodigoPostalInicio = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtCodigoPostalFin = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtPoblacion = New DevExpress.XtraEditors.TextEdit
        Me.checkDetallado = New DevExpress.XtraEditors.CheckEdit
        Me.gcOpciones = New DevExpress.XtraEditors.GroupControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.dgBusqueda = New DevExpress.XtraGrid.GridControl
        Me.PROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProveedores = New AydaraTPV.dsProveedores
        Me.gvBusqueda = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colCodigo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colNombre = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colProvincia = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colTelefono = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colTelMovil = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colFax = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colContacto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDireccion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCodigoPostal = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPoblacion = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCIF = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.panelImprimir = New DevExpress.XtraEditors.PanelControl
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtTituloListado = New DevExpress.XtraEditors.TextEdit
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.PROVEEDORESTableAdapter = New AydaraTPV.dsProveedoresTableAdapters.PROVEEDORESTableAdapter
        CType(Me.txtCodigoInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNombreFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoPostalInicio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCodigoPostalFin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPoblacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkDetallado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcOpciones.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImprimir.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.txtTituloListado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Desde:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 38)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Hasta:"
        '
        'txtCodigoInicio
        '
        Me.txtCodigoInicio.EnterMoveNextControl = True
        Me.txtCodigoInicio.Location = New System.Drawing.Point(52, 9)
        Me.txtCodigoInicio.Name = "txtCodigoInicio"
        Me.txtCodigoInicio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoInicio.Properties.MaxLength = 5
        Me.txtCodigoInicio.Size = New System.Drawing.Size(60, 20)
        Me.txtCodigoInicio.TabIndex = 0
        '
        'txtCodigoFin
        '
        Me.txtCodigoFin.EnterMoveNextControl = True
        Me.txtCodigoFin.Location = New System.Drawing.Point(52, 35)
        Me.txtCodigoFin.Name = "txtCodigoFin"
        Me.txtCodigoFin.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCodigoFin.Properties.MaxLength = 5
        Me.txtCodigoFin.Size = New System.Drawing.Size(60, 20)
        Me.txtCodigoFin.TabIndex = 1
        '
        'txtNombreInicio
        '
        Me.txtNombreInicio.Location = New System.Drawing.Point(111, 9)
        Me.txtNombreInicio.Name = "txtNombreInicio"
        Me.txtNombreInicio.Properties.ReadOnly = True
        Me.txtNombreInicio.Size = New System.Drawing.Size(339, 20)
        Me.txtNombreInicio.TabIndex = 4
        Me.txtNombreInicio.TabStop = False
        '
        'txtNombreFin
        '
        Me.txtNombreFin.Location = New System.Drawing.Point(111, 35)
        Me.txtNombreFin.Name = "txtNombreFin"
        Me.txtNombreFin.Properties.ReadOnly = True
        Me.txtNombreFin.Size = New System.Drawing.Size(339, 20)
        Me.txtNombreFin.TabIndex = 5
        Me.txtNombreFin.TabStop = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 64)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl3.TabIndex = 11
        Me.LabelControl3.Text = "Código postal desde"
        '
        'txtCodigoPostalInicio
        '
        Me.txtCodigoPostalInicio.EnterMoveNextControl = True
        Me.txtCodigoPostalInicio.Location = New System.Drawing.Point(115, 61)
        Me.txtCodigoPostalInicio.Name = "txtCodigoPostalInicio"
        Me.txtCodigoPostalInicio.Properties.MaxLength = 5
        Me.txtCodigoPostalInicio.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoPostalInicio.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(176, 64)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl4.TabIndex = 13
        Me.LabelControl4.Text = "hasta"
        '
        'txtCodigoPostalFin
        '
        Me.txtCodigoPostalFin.EnterMoveNextControl = True
        Me.txtCodigoPostalFin.Location = New System.Drawing.Point(209, 61)
        Me.txtCodigoPostalFin.Name = "txtCodigoPostalFin"
        Me.txtCodigoPostalFin.Properties.MaxLength = 5
        Me.txtCodigoPostalFin.Size = New System.Drawing.Size(55, 20)
        Me.txtCodigoPostalFin.TabIndex = 3
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 92)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Población:"
        '
        'txtPoblacion
        '
        Me.txtPoblacion.EnterMoveNextControl = True
        Me.txtPoblacion.Location = New System.Drawing.Point(67, 89)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Properties.MaxLength = 50
        Me.txtPoblacion.Size = New System.Drawing.Size(197, 20)
        Me.txtPoblacion.TabIndex = 4
        '
        'checkDetallado
        '
        Me.checkDetallado.Location = New System.Drawing.Point(5, 23)
        Me.checkDetallado.Name = "checkDetallado"
        Me.checkDetallado.Properties.Caption = "Detallado"
        Me.checkDetallado.Size = New System.Drawing.Size(75, 19)
        Me.checkDetallado.TabIndex = 6
        Me.checkDetallado.TabStop = False
        '
        'gcOpciones
        '
        Me.gcOpciones.Controls.Add(Me.checkDetallado)
        Me.gcOpciones.Location = New System.Drawing.Point(270, 61)
        Me.gcOpciones.Name = "gcOpciones"
        Me.gcOpciones.Size = New System.Drawing.Size(180, 48)
        Me.gcOpciones.TabIndex = 20
        Me.gcOpciones.Text = "Opciones"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.bttBuscar)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.gcOpciones)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtPoblacion)
        Me.PanelControl1.Controls.Add(Me.txtCodigoInicio)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtCodigoFin)
        Me.PanelControl1.Controls.Add(Me.txtCodigoPostalFin)
        Me.PanelControl1.Controls.Add(Me.txtNombreInicio)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtNombreFin)
        Me.PanelControl1.Controls.Add(Me.txtCodigoPostalInicio)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(784, 126)
        Me.PanelControl1.TabIndex = 21
        '
        'bttBuscar
        '
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.find
        Me.bttBuscar.Location = New System.Drawing.Point(456, 64)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(117, 45)
        Me.bttBuscar.TabIndex = 35
        Me.bttBuscar.Text = "Buscar"
        '
        'dgBusqueda
        '
        Me.dgBusqueda.DataSource = Me.PROVEEDORESBindingSource
        Me.dgBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBusqueda.Location = New System.Drawing.Point(0, 126)
        Me.dgBusqueda.MainView = Me.gvBusqueda
        Me.dgBusqueda.Name = "dgBusqueda"
        Me.dgBusqueda.Size = New System.Drawing.Size(784, 366)
        Me.dgBusqueda.TabIndex = 25
        Me.dgBusqueda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBusqueda})
        '
        'PROVEEDORESBindingSource
        '
        Me.PROVEEDORESBindingSource.DataMember = "PROVEEDORES"
        Me.PROVEEDORESBindingSource.DataSource = Me.DsProveedores
        '
        'DsProveedores
        '
        Me.DsProveedores.DataSetName = "dsProveedores"
        Me.DsProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvBusqueda
        '
        Me.gvBusqueda.AppearancePrint.BandPanel.Options.UseTextOptions = True
        Me.gvBusqueda.AppearancePrint.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvBusqueda.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvBusqueda.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvBusqueda.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.gvBusqueda.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colCodigo, Me.colNombre, Me.colDireccion, Me.colCodigoPostal, Me.colPoblacion, Me.colProvincia, Me.colCIF, Me.colTelefono, Me.colTelMovil, Me.colFax, Me.colContacto})
        Me.gvBusqueda.GridControl = Me.dgBusqueda
        Me.gvBusqueda.GroupPanelText = "Arrastre una columna para agrupar por esa columna"
        Me.gvBusqueda.Name = "gvBusqueda"
        Me.gvBusqueda.OptionsBehavior.Editable = False
        Me.gvBusqueda.OptionsMenu.EnableColumnMenu = False
        Me.gvBusqueda.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvBusqueda.OptionsPrint.UsePrintStyles = True
        Me.gvBusqueda.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvBusqueda.OptionsView.ColumnAutoWidth = True
        Me.gvBusqueda.OptionsView.EnableAppearanceEvenRow = True
        Me.gvBusqueda.OptionsView.ShowAutoFilterRow = True
        Me.gvBusqueda.OptionsView.ShowDetailButtons = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Datos del cliente"
        Me.GridBand1.Columns.Add(Me.colCodigo)
        Me.GridBand1.Columns.Add(Me.colNombre)
        Me.GridBand1.Columns.Add(Me.colProvincia)
        Me.GridBand1.Columns.Add(Me.colTelefono)
        Me.GridBand1.Columns.Add(Me.colTelMovil)
        Me.GridBand1.Columns.Add(Me.colFax)
        Me.GridBand1.Columns.Add(Me.colContacto)
        Me.GridBand1.Columns.Add(Me.colDireccion)
        Me.GridBand1.Columns.Add(Me.colCodigoPostal)
        Me.GridBand1.Columns.Add(Me.colPoblacion)
        Me.GridBand1.Columns.Add(Me.colCIF)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 763
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
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.Width = 383
        '
        'colProvincia
        '
        Me.colProvincia.FieldName = "Provincia"
        Me.colProvincia.Name = "colProvincia"
        Me.colProvincia.Width = 33
        '
        'colTelefono
        '
        Me.colTelefono.FieldName = "Telefono"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.OptionsColumn.FixedWidth = True
        Me.colTelefono.Visible = True
        Me.colTelefono.Width = 100
        '
        'colTelMovil
        '
        Me.colTelMovil.FieldName = "TelMovil"
        Me.colTelMovil.Name = "colTelMovil"
        Me.colTelMovil.OptionsColumn.FixedWidth = True
        Me.colTelMovil.Visible = True
        Me.colTelMovil.Width = 100
        '
        'colFax
        '
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        Me.colFax.OptionsColumn.FixedWidth = True
        Me.colFax.Visible = True
        Me.colFax.Width = 100
        '
        'colContacto
        '
        Me.colContacto.FieldName = "Contacto"
        Me.colContacto.Name = "colContacto"
        Me.colContacto.Width = 20
        '
        'colDireccion
        '
        Me.colDireccion.FieldName = "Direccion"
        Me.colDireccion.Name = "colDireccion"
        Me.colDireccion.RowIndex = 1
        Me.colDireccion.Visible = True
        Me.colDireccion.Width = 383
        '
        'colCodigoPostal
        '
        Me.colCodigoPostal.Caption = "C.P."
        Me.colCodigoPostal.FieldName = "CodigoPostal"
        Me.colCodigoPostal.Name = "colCodigoPostal"
        Me.colCodigoPostal.OptionsColumn.FixedWidth = True
        Me.colCodigoPostal.RowIndex = 1
        Me.colCodigoPostal.Visible = True
        Me.colCodigoPostal.Width = 80
        '
        'colPoblacion
        '
        Me.colPoblacion.Caption = "Población"
        Me.colPoblacion.FieldName = "Poblacion"
        Me.colPoblacion.Name = "colPoblacion"
        Me.colPoblacion.OptionsColumn.FixedWidth = True
        Me.colPoblacion.RowIndex = 1
        Me.colPoblacion.Visible = True
        Me.colPoblacion.Width = 200
        '
        'colCIF
        '
        Me.colCIF.FieldName = "CIF"
        Me.colCIF.Name = "colCIF"
        Me.colCIF.OptionsColumn.FixedWidth = True
        Me.colCIF.RowIndex = 1
        Me.colCIF.Visible = True
        Me.colCIF.Width = 100
        '
        'panelImprimir
        '
        Me.panelImprimir.Controls.Add(Me.PanelControl2)
        Me.panelImprimir.Controls.Add(Me.bttCancelar)
        Me.panelImprimir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelImprimir.Location = New System.Drawing.Point(0, 492)
        Me.panelImprimir.Name = "panelImprimir"
        Me.panelImprimir.Size = New System.Drawing.Size(784, 70)
        Me.panelImprimir.TabIndex = 24
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
        Me.PanelControl2.TabIndex = 127
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
        Me.bttCancelar.TabIndex = 126
        Me.bttCancelar.TabStop = False
        Me.bttCancelar.Text = "Salir"
        '
        'PROVEEDORESTableAdapter
        '
        Me.PROVEEDORESTableAdapter.ClearBeforeFill = True
        '
        'ListadoProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgBusqueda)
        Me.Controls.Add(Me.panelImprimir)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "ListadoProveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Listado de proveedores"
        CType(Me.txtCodigoInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNombreFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoPostalInicio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCodigoPostalFin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPoblacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkDetallado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcOpciones.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.dgBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProveedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImprimir.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.txtTituloListado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoInicio As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtCodigoFin As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtNombreInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNombreFin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoPostalInicio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCodigoPostalFin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPoblacion As DevExpress.XtraEditors.TextEdit
    Friend WithEvents checkDetallado As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents gcOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgBusqueda As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBusqueda As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents panelImprimir As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DsProveedores As AydaraTPV.dsProveedores
    Friend WithEvents PROVEEDORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PROVEEDORESTableAdapter As AydaraTPV.dsProveedoresTableAdapters.PROVEEDORESTableAdapter
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProvincia As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTelefono As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTelMovil As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFax As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colContacto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDireccion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCodigoPostal As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPoblacion As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCIF As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTituloListado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
End Class
