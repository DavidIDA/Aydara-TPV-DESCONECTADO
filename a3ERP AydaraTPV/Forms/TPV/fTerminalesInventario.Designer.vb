<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fTerminalesInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fTerminalesInventario))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.DsInventarios = New a3ERP_AydaraTPV.dsInventarios()
        Me.txtFechaInventario = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txtCODALM = New DevExpress.XtraEditors.ButtonEdit()
        Me.txtDESCALM = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton()
        Me.dgInventario = New DevExpress.XtraGrid.GridControl()
        Me.IDAINVENTARIOTERMINALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvInventario = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCODART = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bttCODART = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colDESCART = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cmbTiposIVA = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCAJAS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUNIDADES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskUnidades = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.colSTOCK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDIFERENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcOpciones = New DevExpress.XtraEditors.PanelControl()
        Me.bttDescargar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.txtFechaRegularizacion = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.bttActualizar = New DevExpress.XtraEditors.SimpleButton()
        Me.rgInventarioGeneral = New DevExpress.XtraEditors.RadioGroup()
        Me.bttDiferencias = New DevExpress.XtraEditors.SimpleButton()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bttBorrarInventario = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.DsInventarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInventario.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaInventario.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCODALM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDESCALM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDAINVENTARIOTERMINALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttCODART, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTiposIVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcOpciones.SuspendLayout()
        CType(Me.txtFechaRegularizacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaRegularizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rgInventarioGeneral.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.txtFechaInventario)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.txtCODALM)
        Me.PanelControl1.Controls.Add(Me.txtDESCALM)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.bttBuscar)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(784, 52)
        Me.PanelControl1.TabIndex = 1
        '
        'DsInventarios
        '
        Me.DsInventarios.DataSetName = "dsInventarios"
        Me.DsInventarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtFechaInventario
        '
        Me.txtFechaInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFechaInventario.EditValue = Nothing
        Me.txtFechaInventario.Location = New System.Drawing.Point(585, 16)
        Me.txtFechaInventario.Name = "txtFechaInventario"
        Me.txtFechaInventario.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaInventario.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaInventario.Size = New System.Drawing.Size(85, 20)
        Me.txtFechaInventario.TabIndex = 68
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Location = New System.Drawing.Point(495, 19)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl6.TabIndex = 67
        Me.LabelControl6.Text = "Fecha inventario:"
        '
        'txtCODALM
        '
        Me.txtCODALM.EditValue = ""
        Me.txtCODALM.EnterMoveNextControl = True
        Me.txtCODALM.Location = New System.Drawing.Point(62, 16)
        Me.txtCODALM.Name = "txtCODALM"
        Me.txtCODALM.Properties.AutoHeight = False
        Me.txtCODALM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtCODALM.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.txtCODALM.Size = New System.Drawing.Size(74, 20)
        Me.txtCODALM.TabIndex = 0
        '
        'txtDESCALM
        '
        Me.txtDESCALM.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDESCALM.Location = New System.Drawing.Point(135, 16)
        Me.txtDESCALM.Name = "txtDESCALM"
        Me.txtDESCALM.Properties.ReadOnly = True
        Me.txtDESCALM.Size = New System.Drawing.Size(354, 20)
        Me.txtDESCALM.TabIndex = 1
        Me.txtDESCALM.TabStop = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 19)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Almacén:"
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = CType(resources.GetObject("bttBuscar.Image"), System.Drawing.Image)
        Me.bttBuscar.Location = New System.Drawing.Point(682, 12)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(90, 28)
        Me.bttBuscar.TabIndex = 4
        Me.bttBuscar.Text = "(F5) Buscar"
        '
        'dgInventario
        '
        Me.dgInventario.DataSource = Me.IDAINVENTARIOTERMINALBindingSource
        Me.dgInventario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgInventario.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.dgInventario.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgInventario.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgInventario.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgInventario.EmbeddedNavigator.TextStringFormat = "Artículo {0} de {1}"
        Me.dgInventario.Location = New System.Drawing.Point(0, 52)
        Me.dgInventario.MainView = Me.gvInventario
        Me.dgInventario.Name = "dgInventario"
        Me.dgInventario.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskUnidades, Me.bttCODART, Me.cmbTiposIVA})
        Me.dgInventario.Size = New System.Drawing.Size(784, 422)
        Me.dgInventario.TabIndex = 2
        Me.dgInventario.UseEmbeddedNavigator = True
        Me.dgInventario.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvInventario})
        '
        'IDAINVENTARIOTERMINALBindingSource
        '
        Me.IDAINVENTARIOTERMINALBindingSource.DataMember = "IDA_INVENTARIOTERMINAL"
        Me.IDAINVENTARIOTERMINALBindingSource.DataSource = Me.DsInventarios
        '
        'gvInventario
        '
        Me.gvInventario.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODART, Me.colDESCART, Me.colCAJAS, Me.colUNIDADES, Me.colSTOCK, Me.colDIFERENCIA})
        Me.gvInventario.GridControl = Me.dgInventario
        Me.gvInventario.Name = "gvInventario"
        Me.gvInventario.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvInventario.OptionsView.ShowFooter = True
        Me.gvInventario.OptionsView.ShowGroupPanel = False
        '
        'colCODART
        '
        Me.colCODART.Caption = "Artículo"
        Me.colCODART.ColumnEdit = Me.bttCODART
        Me.colCODART.FieldName = "CODART"
        Me.colCODART.Name = "colCODART"
        Me.colCODART.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colCODART.Visible = True
        Me.colCODART.VisibleIndex = 0
        Me.colCODART.Width = 101
        '
        'bttCODART
        '
        Me.bttCODART.AutoHeight = False
        Me.bttCODART.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.bttCODART.Name = "bttCODART"
        '
        'colDESCART
        '
        Me.colDESCART.Caption = "Descripción"
        Me.colDESCART.FieldName = "DESCART"
        Me.colDESCART.Name = "colDESCART"
        Me.colDESCART.OptionsColumn.AllowEdit = False
        Me.colDESCART.OptionsColumn.AllowFocus = False
        Me.colDESCART.OptionsColumn.ReadOnly = True
        Me.colDESCART.OptionsColumn.TabStop = False
        Me.colDESCART.Visible = True
        Me.colDESCART.VisibleIndex = 1
        Me.colDESCART.Width = 383
        '
        'cmbTiposIVA
        '
        Me.cmbTiposIVA.AutoHeight = False
        Me.cmbTiposIVA.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbTiposIVA.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TIPIVA", "Tipo", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOMTIVA", "Descripción", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbTiposIVA.DisplayMember = "NOMTIVA"
        Me.cmbTiposIVA.Name = "cmbTiposIVA"
        Me.cmbTiposIVA.NullText = ""
        Me.cmbTiposIVA.ValueMember = "TIPIVA"
        '
        'colCAJAS
        '
        Me.colCAJAS.Caption = "Cajas"
        Me.colCAJAS.FieldName = "CAJAS"
        Me.colCAJAS.Name = "colCAJAS"
        Me.colCAJAS.Visible = True
        Me.colCAJAS.VisibleIndex = 3
        '
        'colUNIDADES
        '
        Me.colUNIDADES.AppearanceHeader.Options.UseTextOptions = True
        Me.colUNIDADES.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colUNIDADES.Caption = "Unidades"
        Me.colUNIDADES.ColumnEdit = Me.maskUnidades
        Me.colUNIDADES.FieldName = "UNIDADES"
        Me.colUNIDADES.Name = "colUNIDADES"
        Me.colUNIDADES.Visible = True
        Me.colUNIDADES.VisibleIndex = 3
        Me.colUNIDADES.Width = 77
        '
        'maskUnidades
        '
        Me.maskUnidades.AutoHeight = False
        Me.maskUnidades.Mask.EditMask = "n2"
        Me.maskUnidades.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskUnidades.Mask.UseMaskAsDisplayFormat = True
        Me.maskUnidades.Name = "maskUnidades"
        '
        'colSTOCK
        '
        Me.colSTOCK.AppearanceHeader.Options.UseTextOptions = True
        Me.colSTOCK.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSTOCK.Caption = "Stock"
        Me.colSTOCK.DisplayFormat.FormatString = "{0:n2}"
        Me.colSTOCK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSTOCK.FieldName = "STOCK"
        Me.colSTOCK.Name = "colSTOCK"
        Me.colSTOCK.OptionsColumn.AllowEdit = False
        Me.colSTOCK.OptionsColumn.AllowFocus = False
        Me.colSTOCK.OptionsColumn.ReadOnly = True
        Me.colSTOCK.OptionsColumn.TabStop = False
        Me.colSTOCK.Visible = True
        Me.colSTOCK.VisibleIndex = 5
        Me.colSTOCK.Width = 86
        '
        'colDIFERENCIA
        '
        Me.colDIFERENCIA.AppearanceHeader.Options.UseTextOptions = True
        Me.colDIFERENCIA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDIFERENCIA.Caption = "Diferencia"
        Me.colDIFERENCIA.DisplayFormat.FormatString = "{0:n2}"
        Me.colDIFERENCIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDIFERENCIA.FieldName = "DIFERENCIA"
        Me.colDIFERENCIA.Name = "colDIFERENCIA"
        Me.colDIFERENCIA.OptionsColumn.AllowEdit = False
        Me.colDIFERENCIA.OptionsColumn.AllowFocus = False
        Me.colDIFERENCIA.OptionsColumn.ReadOnly = True
        Me.colDIFERENCIA.OptionsColumn.TabStop = False
        Me.colDIFERENCIA.Visible = True
        Me.colDIFERENCIA.VisibleIndex = 6
        '
        'gcOpciones
        '
        Me.gcOpciones.Controls.Add(Me.bttDescargar)
        Me.gcOpciones.Controls.Add(Me.bttGuardar)
        Me.gcOpciones.Controls.Add(Me.bttCancelar)
        Me.gcOpciones.Controls.Add(Me.txtFechaRegularizacion)
        Me.gcOpciones.Controls.Add(Me.LabelControl1)
        Me.gcOpciones.Controls.Add(Me.bttActualizar)
        Me.gcOpciones.Controls.Add(Me.rgInventarioGeneral)
        Me.gcOpciones.Controls.Add(Me.bttDiferencias)
        Me.gcOpciones.Controls.Add(Me.bttImprimir)
        Me.gcOpciones.Controls.Add(Me.bttBorrarInventario)
        Me.gcOpciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gcOpciones.Location = New System.Drawing.Point(0, 474)
        Me.gcOpciones.Name = "gcOpciones"
        Me.gcOpciones.Size = New System.Drawing.Size(784, 88)
        Me.gcOpciones.TabIndex = 3
        '
        'bttDescargar
        '
        Me.bttDescargar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttDescargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttDescargar.Image = CType(resources.GetObject("bttDescargar.Image"), System.Drawing.Image)
        Me.bttDescargar.Location = New System.Drawing.Point(345, 14)
        Me.bttDescargar.Name = "bttDescargar"
        Me.bttDescargar.Size = New System.Drawing.Size(85, 28)
        Me.bttDescargar.TabIndex = 73
        Me.bttDescargar.Text = "&Descargar"
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttGuardar.Image = CType(resources.GetObject("bttGuardar.Image"), System.Drawing.Image)
        Me.bttGuardar.Location = New System.Drawing.Point(676, 14)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(96, 28)
        Me.bttGuardar.TabIndex = 71
        Me.bttGuardar.Text = "(F3) &Guardar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttCancelar.Image = CType(resources.GetObject("bttCancelar.Image"), System.Drawing.Image)
        Me.bttCancelar.Location = New System.Drawing.Point(544, 14)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(126, 28)
        Me.bttCancelar.TabIndex = 72
        Me.bttCancelar.Text = "(ALT+F3) &Cancelar"
        '
        'txtFechaRegularizacion
        '
        Me.txtFechaRegularizacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtFechaRegularizacion.EditValue = Nothing
        Me.txtFechaRegularizacion.Location = New System.Drawing.Point(93, 52)
        Me.txtFechaRegularizacion.Name = "txtFechaRegularizacion"
        Me.txtFechaRegularizacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaRegularizacion.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaRegularizacion.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaRegularizacion.TabIndex = 70
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(14, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 69
        Me.LabelControl1.Text = "Regularización:"
        '
        'bttActualizar
        '
        Me.bttActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttActualizar.Image = CType(resources.GetObject("bttActualizar.Image"), System.Drawing.Image)
        Me.bttActualizar.Location = New System.Drawing.Point(345, 48)
        Me.bttActualizar.Name = "bttActualizar"
        Me.bttActualizar.Size = New System.Drawing.Size(85, 28)
        Me.bttActualizar.TabIndex = 13
        Me.bttActualizar.Text = "&Actualizar"
        '
        'rgInventarioGeneral
        '
        Me.rgInventarioGeneral.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.rgInventarioGeneral.Location = New System.Drawing.Point(199, 48)
        Me.rgInventarioGeneral.Name = "rgInventarioGeneral"
        Me.rgInventarioGeneral.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "General"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Parcial")})
        Me.rgInventarioGeneral.Size = New System.Drawing.Size(140, 28)
        Me.rgInventarioGeneral.TabIndex = 8
        '
        'bttDiferencias
        '
        Me.bttDiferencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttDiferencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttDiferencias.Image = CType(resources.GetObject("bttDiferencias.Image"), System.Drawing.Image)
        Me.bttDiferencias.Location = New System.Drawing.Point(228, 14)
        Me.bttDiferencias.Name = "bttDiferencias"
        Me.bttDiferencias.Size = New System.Drawing.Size(111, 28)
        Me.bttDiferencias.TabIndex = 7
        Me.bttDiferencias.Text = "&Ver diferencias"
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttImprimir.Image = CType(resources.GetObject("bttImprimir.Image"), System.Drawing.Image)
        Me.bttImprimir.Location = New System.Drawing.Point(138, 14)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(84, 28)
        Me.bttImprimir.TabIndex = 6
        Me.bttImprimir.Text = "&Imprimir"
        '
        'bttBorrarInventario
        '
        Me.bttBorrarInventario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttBorrarInventario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttBorrarInventario.Image = CType(resources.GetObject("bttBorrarInventario.Image"), System.Drawing.Image)
        Me.bttBorrarInventario.Location = New System.Drawing.Point(12, 14)
        Me.bttBorrarInventario.Name = "bttBorrarInventario"
        Me.bttBorrarInventario.Size = New System.Drawing.Size(120, 28)
        Me.bttBorrarInventario.TabIndex = 5
        Me.bttBorrarInventario.Text = "&Borrar inventario"
        '
        'fTerminalesInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgInventario)
        Me.Controls.Add(Me.gcOpciones)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "fTerminalesInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventario terminales"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.DsInventarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInventario.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaInventario.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCODALM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDESCALM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDAINVENTARIOTERMINALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttCODART, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTiposIVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcOpciones.ResumeLayout(False)
        Me.gcOpciones.PerformLayout()
        CType(Me.txtFechaRegularizacion.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaRegularizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rgInventarioGeneral.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtCODALM As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents txtDESCALM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgInventario As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvInventario As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcOpciones As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txtFechaInventario As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DsInventarios As a3ERP_AydaraTPV.dsInventarios
    Friend WithEvents IDAINVENTARIOTERMINALBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCODART As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCART As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNIDADES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOCK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bttBorrarInventario As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttDiferencias As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents rgInventarioGeneral As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents txtFechaRegularizacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents maskUnidades As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents colDIFERENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bttCODART As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents cmbTiposIVA As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttDescargar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCAJAS As DevExpress.XtraGrid.Columns.GridColumn
End Class
