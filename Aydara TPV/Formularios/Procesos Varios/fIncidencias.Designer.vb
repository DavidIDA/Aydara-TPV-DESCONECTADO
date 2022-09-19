<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fIncidencias
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
        Me.bttPendiente = New DevExpress.XtraEditors.SimpleButton()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.btnEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.btnAñadir = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgIncidencias = New DevExpress.XtraGrid.GridControl()
        Me.bsIncidencias = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsIncidencias1 = New AydaraTPV.dsIncidencias()
        Me.gvIncidencias = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.colComentario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAfectaStock = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTempOperario = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsEmpleados = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsEmpleados1 = New AydaraTPV.dsEmpleados()
        Me.colTempCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colTempArticulo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsTipos = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsIncidenciasTipos1 = New AydaraTPV.dsIncidenciasTipos()
        Me.colPrecioCoste = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaCierre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.bttBuscarMovimientos = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaHasta = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtFechaDesde = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelImprimir.SuspendLayout()
        CType(Me.dgIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsIncidencias1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvIncidencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsEmpleados1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsIncidenciasTipos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaHasta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaDesde.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelImprimir
        '
        Me.panelImprimir.Controls.Add(Me.bttPendiente)
        Me.panelImprimir.Controls.Add(Me.bttImprimir)
        Me.panelImprimir.Controls.Add(Me.btnEliminar)
        Me.panelImprimir.Controls.Add(Me.btnAñadir)
        Me.panelImprimir.Controls.Add(Me.bttCancelar)
        Me.panelImprimir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelImprimir.Location = New System.Drawing.Point(0, 496)
        Me.panelImprimir.Name = "panelImprimir"
        Me.panelImprimir.Size = New System.Drawing.Size(792, 70)
        Me.panelImprimir.TabIndex = 43
        '
        'bttPendiente
        '
        Me.bttPendiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttPendiente.Image = Global.AydaraTPV.My.Resources.Resources._32package
        Me.bttPendiente.Location = New System.Drawing.Point(246, 13)
        Me.bttPendiente.Name = "bttPendiente"
        Me.bttPendiente.Size = New System.Drawing.Size(106, 45)
        Me.bttPendiente.TabIndex = 126
        Me.bttPendiente.Text = "Reenviar"
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Image = Global.AydaraTPV.My.Resources.Resources.menu_tickets
        Me.bttImprimir.Location = New System.Drawing.Point(123, 13)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(117, 45)
        Me.bttImprimir.TabIndex = 130
        Me.bttImprimir.Text = "Imprimir listado"
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Image = Global.AydaraTPV.My.Resources.Resources._1321518972_close
        Me.btnEliminar.Location = New System.Drawing.Point(681, 13)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(106, 45)
        Me.btnEliminar.TabIndex = 129
        Me.btnEliminar.TabStop = False
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnAñadir
        '
        Me.btnAñadir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAñadir.Image = Global.AydaraTPV.My.Resources.Resources._new
        Me.btnAñadir.Location = New System.Drawing.Point(569, 13)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(106, 45)
        Me.btnAñadir.TabIndex = 128
        Me.btnAñadir.TabStop = False
        Me.btnAñadir.Text = "Añadir"
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
        'dgIncidencias
        '
        Me.dgIncidencias.DataSource = Me.bsIncidencias
        Me.dgIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgIncidencias.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.dgIncidencias.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgIncidencias.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgIncidencias.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgIncidencias.EmbeddedNavigator.Buttons.NextPage.Visible = False
        Me.dgIncidencias.EmbeddedNavigator.Buttons.PrevPage.Visible = False
        Me.dgIncidencias.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.dgIncidencias.Location = New System.Drawing.Point(0, 52)
        Me.dgIncidencias.MainView = Me.gvIncidencias
        Me.dgIncidencias.Name = "dgIncidencias"
        Me.dgIncidencias.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemButtonEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemMemoExEdit1, Me.RepositoryItemDateEdit1})
        Me.dgIncidencias.Size = New System.Drawing.Size(792, 444)
        Me.dgIncidencias.TabIndex = 45
        Me.dgIncidencias.UseEmbeddedNavigator = True
        Me.dgIncidencias.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvIncidencias})
        '
        'bsIncidencias
        '
        Me.bsIncidencias.AllowNew = False
        Me.bsIncidencias.DataMember = "INCIDENCIAS"
        Me.bsIncidencias.DataSource = Me.DsIncidencias1
        '
        'DsIncidencias1
        '
        Me.DsIncidencias1.DataSetName = "dsIncidencias"
        Me.DsIncidencias1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvIncidencias
        '
        Me.gvIncidencias.AppearancePrint.HeaderPanel.Options.UseTextOptions = True
        Me.gvIncidencias.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.gvIncidencias.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFecha, Me.colComentario, Me.colCantidad, Me.colAfectaStock, Me.colTempOperario, Me.colTempCodigo, Me.colTempArticulo, Me.colTipoID, Me.colPrecioCoste, Me.colImporte, Me.colFechaCierre})
        Me.gvIncidencias.GridControl = Me.dgIncidencias
        Me.gvIncidencias.GroupPanelText = "Arrastre una columna para agrupar por esa columna"
        Me.gvIncidencias.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteTicket", Nothing, "{0:c2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImporteCobrado", Nothing, "{0:c2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ImportePendiente", Nothing, "{0:c2}")})
        Me.gvIncidencias.Name = "gvIncidencias"
        Me.gvIncidencias.OptionsMenu.EnableColumnMenu = False
        Me.gvIncidencias.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvIncidencias.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvIncidencias.OptionsSelection.MultiSelect = True
        Me.gvIncidencias.OptionsView.EnableAppearanceEvenRow = True
        Me.gvIncidencias.OptionsView.ShowAutoFilterRow = True
        Me.gvIncidencias.OptionsView.ShowDetailButtons = False
        Me.gvIncidencias.OptionsView.ShowFooter = True
        Me.gvIncidencias.OptionsView.ShowGroupExpandCollapseButtons = False
        Me.gvIncidencias.OptionsView.ShowGroupPanel = False
        Me.gvIncidencias.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFecha, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colFecha
        '
        Me.colFecha.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.OptionsColumn.AllowEdit = False
        Me.colFecha.OptionsColumn.FixedWidth = True
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 1
        Me.colFecha.Width = 110
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
        'colComentario
        '
        Me.colComentario.ColumnEdit = Me.RepositoryItemMemoExEdit1
        Me.colComentario.FieldName = "Comentario"
        Me.colComentario.Name = "colComentario"
        Me.colComentario.OptionsColumn.ReadOnly = True
        Me.colComentario.Visible = True
        Me.colComentario.VisibleIndex = 8
        Me.colComentario.Width = 36
        '
        'RepositoryItemMemoExEdit1
        '
        Me.RepositoryItemMemoExEdit1.AutoHeight = False
        Me.RepositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemMemoExEdit1.Name = "RepositoryItemMemoExEdit1"
        Me.RepositoryItemMemoExEdit1.ShowIcon = False
        '
        'colCantidad
        '
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.OptionsColumn.AllowEdit = False
        Me.colCantidad.OptionsColumn.FixedWidth = True
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 4
        Me.colCantidad.Width = 65
        '
        'colAfectaStock
        '
        Me.colAfectaStock.Caption = "Afecta a Stock"
        Me.colAfectaStock.FieldName = "AfectaStock"
        Me.colAfectaStock.Name = "colAfectaStock"
        Me.colAfectaStock.OptionsColumn.AllowEdit = False
        Me.colAfectaStock.OptionsColumn.FixedWidth = True
        Me.colAfectaStock.Visible = True
        Me.colAfectaStock.VisibleIndex = 9
        Me.colAfectaStock.Width = 90
        '
        'colTempOperario
        '
        Me.colTempOperario.Caption = "Empleado"
        Me.colTempOperario.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colTempOperario.FieldName = "OperarioID"
        Me.colTempOperario.Name = "colTempOperario"
        Me.colTempOperario.OptionsColumn.AllowEdit = False
        Me.colTempOperario.OptionsColumn.FixedWidth = True
        Me.colTempOperario.Visible = True
        Me.colTempOperario.VisibleIndex = 7
        Me.colTempOperario.Width = 115
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Empleado", 47, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.bsEmpleados
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Nombre"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ValueMember = "Codigo"
        '
        'bsEmpleados
        '
        Me.bsEmpleados.DataMember = "OPERARIOS"
        Me.bsEmpleados.DataSource = Me.DsEmpleados1
        '
        'DsEmpleados1
        '
        Me.DsEmpleados1.DataSetName = "dsEmpleados"
        Me.DsEmpleados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colTempCodigo
        '
        Me.colTempCodigo.Caption = "Código"
        Me.colTempCodigo.ColumnEdit = Me.RepositoryItemButtonEdit1
        Me.colTempCodigo.FieldName = "TempCodigo"
        Me.colTempCodigo.Name = "colTempCodigo"
        Me.colTempCodigo.OptionsColumn.AllowEdit = False
        Me.colTempCodigo.OptionsColumn.FixedWidth = True
        Me.colTempCodigo.Visible = True
        Me.colTempCodigo.VisibleIndex = 2
        Me.colTempCodigo.Width = 60
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'colTempArticulo
        '
        Me.colTempArticulo.Caption = "Artículo"
        Me.colTempArticulo.FieldName = "TempArticulo"
        Me.colTempArticulo.Name = "colTempArticulo"
        Me.colTempArticulo.OptionsColumn.AllowEdit = False
        Me.colTempArticulo.Visible = True
        Me.colTempArticulo.VisibleIndex = 3
        Me.colTempArticulo.Width = 60
        '
        'colTipoID
        '
        Me.colTipoID.Caption = "Tipo"
        Me.colTipoID.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colTipoID.FieldName = "TipoID"
        Me.colTipoID.Name = "colTipoID"
        Me.colTipoID.OptionsColumn.AllowEdit = False
        Me.colTipoID.OptionsColumn.FixedWidth = True
        Me.colTipoID.Visible = True
        Me.colTipoID.VisibleIndex = 0
        Me.colTipoID.Width = 85
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.bsTipos
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Descripcion"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "IDTipo"
        '
        'bsTipos
        '
        Me.bsTipos.DataMember = "INCIDENCIAS_TIPOS"
        Me.bsTipos.DataSource = Me.DsIncidenciasTipos1
        '
        'DsIncidenciasTipos1
        '
        Me.DsIncidenciasTipos1.DataSetName = "dsIncidenciasTipos"
        Me.DsIncidenciasTipos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'colPrecioCoste
        '
        Me.colPrecioCoste.Caption = "P.Coste"
        Me.colPrecioCoste.DisplayFormat.FormatString = "{0:c3}"
        Me.colPrecioCoste.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrecioCoste.FieldName = "PrecioCoste"
        Me.colPrecioCoste.Name = "colPrecioCoste"
        Me.colPrecioCoste.OptionsColumn.FixedWidth = True
        Me.colPrecioCoste.Visible = True
        Me.colPrecioCoste.VisibleIndex = 5
        Me.colPrecioCoste.Width = 65
        '
        'colImporte
        '
        Me.colImporte.Caption = "Importe"
        Me.colImporte.DisplayFormat.FormatString = "{0:c2}"
        Me.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.OptionsColumn.FixedWidth = True
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 6
        Me.colImporte.Width = 65
        '
        'colFechaCierre
        '
        Me.colFechaCierre.Caption = "F.Cierre"
        Me.colFechaCierre.FieldName = "FechaCierre"
        Me.colFechaCierre.Name = "colFechaCierre"
        Me.colFechaCierre.Visible = True
        Me.colFechaCierre.VisibleIndex = 10
        Me.colFechaCierre.Width = 63
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.bttBuscarMovimientos)
        Me.GroupControl1.Controls.Add(Me.txtFechaHasta)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.txtFechaDesde)
        Me.GroupControl1.Controls.Add(Me.LabelControl24)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.ShowCaption = False
        Me.GroupControl1.Size = New System.Drawing.Size(792, 52)
        Me.GroupControl1.TabIndex = 48
        Me.GroupControl1.Text = "FILTRO"
        '
        'bttBuscarMovimientos
        '
        Me.bttBuscarMovimientos.Image = Global.AydaraTPV.My.Resources.Resources.find
        Me.bttBuscarMovimientos.Location = New System.Drawing.Point(323, 15)
        Me.bttBuscarMovimientos.Name = "bttBuscarMovimientos"
        Me.bttBuscarMovimientos.Size = New System.Drawing.Size(77, 25)
        Me.bttBuscarMovimientos.TabIndex = 73
        Me.bttBuscarMovimientos.Text = "Buscar"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.EditValue = Nothing
        Me.txtFechaHasta.EnterMoveNextControl = True
        Me.txtFechaHasta.Location = New System.Drawing.Point(220, 18)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaHasta.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaHasta.Size = New System.Drawing.Size(94, 20)
        Me.txtFechaHasta.TabIndex = 72
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(183, 21)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl6.TabIndex = 71
        Me.LabelControl6.Text = "hasta:"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.EditValue = Nothing
        Me.txtFechaDesde.EnterMoveNextControl = True
        Me.txtFechaDesde.Location = New System.Drawing.Point(83, 18)
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaDesde.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.txtFechaDesde.Size = New System.Drawing.Size(94, 20)
        Me.txtFechaDesde.TabIndex = 70
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(12, 21)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl24.TabIndex = 69
        Me.LabelControl24.Text = "Fecha desde:"
        '
        'fIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.dgIncidencias)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.panelImprimir)
        Me.Name = "fIncidencias"
        Me.Text = "fIncidencias"
        CType(Me.panelImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelImprimir.ResumeLayout(False)
        CType(Me.dgIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsIncidencias1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvIncidencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoExEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsEmpleados1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsIncidenciasTipos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtFechaHasta.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaHasta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaDesde.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaDesde.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panelImprimir As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgIncidencias As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvIncidencias As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsIncidencias1 As AydaraTPV.dsIncidencias
    Friend WithEvents bsIncidencias As System.Windows.Forms.BindingSource
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComentario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAfectaStock As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTempOperario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTempCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTempArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAñadir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colTipoID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents DsIncidenciasTipos1 As AydaraTPV.dsIncidenciasTipos
    Friend WithEvents bsTipos As System.Windows.Forms.BindingSource
    Friend WithEvents bsEmpleados As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents DsEmpleados1 As AydaraTPV.dsEmpleados
    Friend WithEvents RepositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bttBuscarMovimientos As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtFechaHasta As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaDesde As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colPrecioCoste As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bttPendiente As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colFechaCierre As DevExpress.XtraGrid.Columns.GridColumn
End Class
