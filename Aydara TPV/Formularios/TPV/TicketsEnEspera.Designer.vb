<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketsEnEspera
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicketsEnEspera))
        Me.gvLineas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrecio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgTickets = New DevExpress.XtraGrid.GridControl()
        Me.TICKETSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTickets = New AydaraTPV.dsTickets()
        Me.gvTickets = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaTicket = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoraTicket = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCliente_Nombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumeroLineas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporteTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TICKETSTableAdapter = New AydaraTPV.dsTicketsTableAdapters.TICKETSTableAdapter()
        Me.TICKETSLINEASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TICKETS_LINEASTableAdapter = New AydaraTPV.dsTicketsTableAdapters.TICKETS_LINEASTableAdapter()
        Me.panelImprimir = New DevExpress.XtraEditors.PanelControl()
        Me.bttSalir = New DevExpress.XtraEditors.SimpleButton()
        Me.bttSeleccionar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttImprimirFactura = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.gvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TICKETSLINEASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImprimir.SuspendLayout()
        Me.SuspendLayout()
        '
        'gvLineas
        '
        Me.gvLineas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescripcion, Me.colCantidad, Me.colPrecio, Me.colImporte})
        Me.gvLineas.GridControl = Me.dgTickets
        Me.gvLineas.Name = "gvLineas"
        Me.gvLineas.OptionsBehavior.Editable = False
        Me.gvLineas.OptionsCustomization.AllowColumnMoving = False
        Me.gvLineas.OptionsCustomization.AllowColumnResizing = False
        Me.gvLineas.OptionsCustomization.AllowFilter = False
        Me.gvLineas.OptionsCustomization.AllowGroup = False
        Me.gvLineas.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvLineas.OptionsCustomization.AllowSort = False
        Me.gvLineas.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvLineas.OptionsView.ShowGroupPanel = False
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "DescripcionArticulo"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowFocus = False
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 0
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Cantidad"
        Me.colCantidad.DisplayFormat.FormatString = "{0:n2}"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.MaxWidth = 80
        Me.colCantidad.MinWidth = 80
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowFocus = False
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 1
        '
        'colPrecio
        '
        Me.colPrecio.Caption = "Precio"
        Me.colPrecio.DisplayFormat.FormatString = "{0:c2}"
        Me.colPrecio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecio.FieldName = "Precio"
        Me.colPrecio.MaxWidth = 100
        Me.colPrecio.MinWidth = 100
        Me.colPrecio.Name = "colPrecio"
        Me.colPrecio.OptionsColumn.AllowFocus = False
        Me.colPrecio.Visible = True
        Me.colPrecio.VisibleIndex = 2
        '
        'colImporte
        '
        Me.colImporte.Caption = "Importe"
        Me.colImporte.DisplayFormat.FormatString = "{0:c2}"
        Me.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.MaxWidth = 100
        Me.colImporte.MinWidth = 100
        Me.colImporte.Name = "colImporte"
        Me.colImporte.OptionsColumn.AllowFocus = False
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 3
        '
        'dgTickets
        '
        Me.dgTickets.DataSource = Me.TICKETSBindingSource
        Me.dgTickets.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode2.LevelTemplate = Me.gvLineas
        GridLevelNode2.RelationName = "Level1"
        Me.dgTickets.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.dgTickets.Location = New System.Drawing.Point(0, 0)
        Me.dgTickets.MainView = Me.gvTickets
        Me.dgTickets.Name = "dgTickets"
        Me.dgTickets.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskImporte})
        Me.dgTickets.Size = New System.Drawing.Size(784, 496)
        Me.dgTickets.TabIndex = 1
        Me.dgTickets.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTickets, Me.gvLineas})
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
        'gvTickets
        '
        Me.gvTickets.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colFechaTicket, Me.colHoraTicket, Me.colCodigoCliente, Me.colCliente_Nombre, Me.colNumeroLineas, Me.colImporteTotal})
        Me.gvTickets.GridControl = Me.dgTickets
        Me.gvTickets.Name = "gvTickets"
        Me.gvTickets.OptionsBehavior.Editable = False
        Me.gvTickets.OptionsCustomization.AllowFilter = False
        Me.gvTickets.OptionsCustomization.AllowGroup = False
        Me.gvTickets.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvTickets.OptionsDetail.ShowDetailTabs = False
        Me.gvTickets.OptionsMenu.EnableColumnMenu = False
        Me.gvTickets.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvTickets.OptionsView.EnableAppearanceEvenRow = True
        Me.gvTickets.OptionsView.ShowGroupPanel = False
        Me.gvTickets.RowHeight = 35
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.ReadOnly = True
        '
        'colFechaTicket
        '
        Me.colFechaTicket.FieldName = "FechaTicket"
        Me.colFechaTicket.Name = "colFechaTicket"
        Me.colFechaTicket.OptionsColumn.AllowFocus = False
        '
        'colHoraTicket
        '
        Me.colHoraTicket.Caption = "Fecha"
        Me.colHoraTicket.DisplayFormat.FormatString = "g"
        Me.colHoraTicket.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colHoraTicket.FieldName = "HoraTicket"
        Me.colHoraTicket.Name = "colHoraTicket"
        Me.colHoraTicket.OptionsColumn.AllowFocus = False
        Me.colHoraTicket.Visible = True
        Me.colHoraTicket.VisibleIndex = 0
        Me.colHoraTicket.Width = 163
        '
        'colCodigoCliente
        '
        Me.colCodigoCliente.Caption = "Cliente"
        Me.colCodigoCliente.FieldName = "CodigoCliente"
        Me.colCodigoCliente.Name = "colCodigoCliente"
        Me.colCodigoCliente.OptionsColumn.AllowFocus = False
        Me.colCodigoCliente.Visible = True
        Me.colCodigoCliente.VisibleIndex = 1
        Me.colCodigoCliente.Width = 87
        '
        'colCliente_Nombre
        '
        Me.colCliente_Nombre.Caption = "Nombre"
        Me.colCliente_Nombre.FieldName = "Cliente_Nombre"
        Me.colCliente_Nombre.Name = "colCliente_Nombre"
        Me.colCliente_Nombre.Visible = True
        Me.colCliente_Nombre.VisibleIndex = 2
        Me.colCliente_Nombre.Width = 348
        '
        'colNumeroLineas
        '
        Me.colNumeroLineas.AppearanceHeader.Options.UseTextOptions = True
        Me.colNumeroLineas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colNumeroLineas.Caption = "Nº Líneas"
        Me.colNumeroLineas.DisplayFormat.FormatString = "{0:n0}"
        Me.colNumeroLineas.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNumeroLineas.FieldName = "NumeroLineas"
        Me.colNumeroLineas.Name = "colNumeroLineas"
        Me.colNumeroLineas.OptionsColumn.AllowFocus = False
        Me.colNumeroLineas.Visible = True
        Me.colNumeroLineas.VisibleIndex = 3
        Me.colNumeroLineas.Width = 64
        '
        'colImporteTotal
        '
        Me.colImporteTotal.AppearanceHeader.Options.UseTextOptions = True
        Me.colImporteTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colImporteTotal.ColumnEdit = Me.maskImporte
        Me.colImporteTotal.DisplayFormat.FormatString = "{0:c2}"
        Me.colImporteTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImporteTotal.FieldName = "ImporteTotal"
        Me.colImporteTotal.Name = "colImporteTotal"
        Me.colImporteTotal.OptionsColumn.AllowFocus = False
        Me.colImporteTotal.Visible = True
        Me.colImporteTotal.VisibleIndex = 4
        Me.colImporteTotal.Width = 104
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'TICKETSTableAdapter
        '
        Me.TICKETSTableAdapter.ClearBeforeFill = True
        '
        'TICKETSLINEASBindingSource
        '
        Me.TICKETSLINEASBindingSource.DataMember = "TICKETS_LINEAS"
        Me.TICKETSLINEASBindingSource.DataSource = Me.DsTickets
        '
        'TICKETS_LINEASTableAdapter
        '
        Me.TICKETS_LINEASTableAdapter.ClearBeforeFill = True
        '
        'panelImprimir
        '
        Me.panelImprimir.Controls.Add(Me.bttImprimirFactura)
        Me.panelImprimir.Controls.Add(Me.bttSalir)
        Me.panelImprimir.Controls.Add(Me.bttSeleccionar)
        Me.panelImprimir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelImprimir.Location = New System.Drawing.Point(0, 496)
        Me.panelImprimir.Name = "panelImprimir"
        Me.panelImprimir.Size = New System.Drawing.Size(784, 66)
        Me.panelImprimir.TabIndex = 2
        '
        'bttSalir
        '
        Me.bttSalir.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttSalir.Appearance.Options.UseFont = True
        Me.bttSalir.Dock = System.Windows.Forms.DockStyle.Left
        Me.bttSalir.Image = CType(resources.GetObject("bttSalir.Image"), System.Drawing.Image)
        Me.bttSalir.Location = New System.Drawing.Point(2, 2)
        Me.bttSalir.Name = "bttSalir"
        Me.bttSalir.Size = New System.Drawing.Size(131, 62)
        Me.bttSalir.TabIndex = 8
        Me.bttSalir.Text = "Cancelar"
        '
        'bttSeleccionar
        '
        Me.bttSeleccionar.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttSeleccionar.Appearance.Options.UseFont = True
        Me.bttSeleccionar.Dock = System.Windows.Forms.DockStyle.Right
        Me.bttSeleccionar.Image = Global.AydaraTPV.My.Resources.Resources.ok_32
        Me.bttSeleccionar.Location = New System.Drawing.Point(651, 2)
        Me.bttSeleccionar.Name = "bttSeleccionar"
        Me.bttSeleccionar.Size = New System.Drawing.Size(131, 62)
        Me.bttSeleccionar.TabIndex = 0
        Me.bttSeleccionar.Text = "Seleccionar"
        '
        'bttImprimirFactura
        '
        Me.bttImprimirFactura.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.bttImprimirFactura.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttImprimirFactura.Location = New System.Drawing.Point(330, 0)
        Me.bttImprimirFactura.Name = "bttImprimirFactura"
        Me.bttImprimirFactura.Size = New System.Drawing.Size(125, 66)
        Me.bttImprimirFactura.TabIndex = 11
        Me.bttImprimirFactura.Text = "Imprimir Factura"
        '
        'TicketsEnEspera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgTickets)
        Me.Controls.Add(Me.panelImprimir)
        Me.KeyPreview = True
        Me.Name = "TicketsEnEspera"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tickets en espera"
        CType(Me.gvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TICKETSLINEASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImprimir.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgTickets As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTickets As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsTickets As AydaraTPV.dsTickets
    Friend WithEvents TICKETSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TICKETSTableAdapter As AydaraTPV.dsTicketsTableAdapters.TICKETSTableAdapter
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaTicket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoraTicket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumeroLineas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporteTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvLineas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrecio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TICKETSLINEASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TICKETS_LINEASTableAdapter As AydaraTPV.dsTicketsTableAdapters.TICKETS_LINEASTableAdapter
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents panelImprimir As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttSalir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttSeleccionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCliente_Nombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bttImprimirFactura As DevExpress.XtraEditors.SimpleButton
End Class
