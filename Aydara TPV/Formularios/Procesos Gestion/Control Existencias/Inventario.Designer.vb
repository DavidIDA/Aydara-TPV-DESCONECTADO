<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Me.dgInventario = New DevExpress.XtraGrid.GridControl
        Me.INVENTARIOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsInventario = New AydaraTPV.dsInventario
        Me.gvInventario = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoArticulo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bttCodigoArticulo = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCajas = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn
        Me.maskUnidades = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colExistenciaActual = New DevExpress.XtraGrid.Columns.GridColumn
        Me.INVENTARIOTableAdapter = New AydaraTPV.dsInventarioTableAdapters.INVENTARIOTableAdapter
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.bttBuscar = New DevExpress.XtraEditors.SimpleButton
        Me.bttEnviar = New DevExpress.XtraEditors.SimpleButton
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.rgTipoactualizacion = New DevExpress.XtraEditors.RadioGroup
        Me.txtFechaActualizacion = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.bttActualizar = New DevExpress.XtraEditors.SimpleButton
        Me.bttEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.lblInfoArticulo = New DevExpress.XtraEditors.LabelControl
        CType(Me.dgInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INVENTARIOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.rgTipoactualizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaActualizacion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFechaActualizacion.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgInventario
        '
        Me.dgInventario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgInventario.DataSource = Me.INVENTARIOBindingSource
        Me.dgInventario.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgInventario.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgInventario.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgInventario.EmbeddedNavigator.TextStringFormat = "Línea {0} de {1}"
        Me.dgInventario.Location = New System.Drawing.Point(12, 12)
        Me.dgInventario.MainView = Me.gvInventario
        Me.dgInventario.Name = "dgInventario"
        Me.dgInventario.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.bttCodigoArticulo, Me.maskUnidades})
        Me.dgInventario.Size = New System.Drawing.Size(984, 455)
        Me.dgInventario.TabIndex = 0
        Me.dgInventario.UseEmbeddedNavigator = True
        Me.dgInventario.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvInventario})
        '
        'INVENTARIOBindingSource
        '
        Me.INVENTARIOBindingSource.DataMember = "INVENTARIO"
        Me.INVENTARIOBindingSource.DataSource = Me.DsInventario
        Me.INVENTARIOBindingSource.Sort = "CodigoArticulo"
        '
        'DsInventario
        '
        Me.DsInventario.DataSetName = "dsInventario"
        Me.DsInventario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvInventario
        '
        Me.gvInventario.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colCodigoArticulo, Me.colDescripcion, Me.colCajas, Me.colCantidad, Me.colExistenciaActual})
        Me.gvInventario.GridControl = Me.dgInventario
        Me.gvInventario.Name = "gvInventario"
        Me.gvInventario.OptionsCustomization.AllowColumnMoving = False
        Me.gvInventario.OptionsCustomization.AllowColumnResizing = False
        Me.gvInventario.OptionsCustomization.AllowFilter = False
        Me.gvInventario.OptionsCustomization.AllowGroup = False
        Me.gvInventario.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvInventario.OptionsCustomization.AllowSort = False
        Me.gvInventario.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvInventario.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvInventario.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvInventario.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvInventario.OptionsView.ShowGroupPanel = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'colCodigoArticulo
        '
        Me.colCodigoArticulo.Caption = "Artículo"
        Me.colCodigoArticulo.ColumnEdit = Me.bttCodigoArticulo
        Me.colCodigoArticulo.FieldName = "CodigoArticulo"
        Me.colCodigoArticulo.MaxWidth = 80
        Me.colCodigoArticulo.MinWidth = 80
        Me.colCodigoArticulo.Name = "colCodigoArticulo"
        Me.colCodigoArticulo.Visible = True
        Me.colCodigoArticulo.VisibleIndex = 0
        Me.colCodigoArticulo.Width = 80
        '
        'bttCodigoArticulo
        '
        Me.bttCodigoArticulo.AutoHeight = False
        Me.bttCodigoArticulo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.bttCodigoArticulo.Name = "bttCodigoArticulo"
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.OptionsColumn.AllowEdit = False
        Me.colDescripcion.OptionsColumn.AllowFocus = False
        Me.colDescripcion.OptionsColumn.ReadOnly = True
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 303
        '
        'colCajas
        '
        Me.colCajas.FieldName = "Cajas"
        Me.colCajas.MaxWidth = 60
        Me.colCajas.MinWidth = 60
        Me.colCajas.Name = "colCajas"
        Me.colCajas.Visible = True
        Me.colCajas.VisibleIndex = 2
        Me.colCajas.Width = 60
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Unidades"
        Me.colCantidad.ColumnEdit = Me.maskUnidades
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.MaxWidth = 70
        Me.colCantidad.MinWidth = 70
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 3
        Me.colCantidad.Width = 70
        '
        'maskUnidades
        '
        Me.maskUnidades.AutoHeight = False
        Me.maskUnidades.Mask.EditMask = "f2"
        Me.maskUnidades.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskUnidades.Mask.UseMaskAsDisplayFormat = True
        Me.maskUnidades.Name = "maskUnidades"
        '
        'colExistenciaActual
        '
        Me.colExistenciaActual.Caption = "Existencia"
        Me.colExistenciaActual.ColumnEdit = Me.maskUnidades
        Me.colExistenciaActual.FieldName = "ExistenciaActual"
        Me.colExistenciaActual.MaxWidth = 70
        Me.colExistenciaActual.MinWidth = 70
        Me.colExistenciaActual.Name = "colExistenciaActual"
        Me.colExistenciaActual.OptionsColumn.AllowEdit = False
        Me.colExistenciaActual.OptionsColumn.AllowFocus = False
        Me.colExistenciaActual.OptionsColumn.ReadOnly = True
        Me.colExistenciaActual.Visible = True
        Me.colExistenciaActual.VisibleIndex = 4
        Me.colExistenciaActual.Width = 70
        '
        'INVENTARIOTableAdapter
        '
        Me.INVENTARIOTableAdapter.ClearBeforeFill = True
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.bttBuscar)
        Me.PanelControl1.Controls.Add(Me.bttEnviar)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.bttEliminar)
        Me.PanelControl1.Controls.Add(Me.bttImprimir)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 492)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1008, 70)
        Me.PanelControl1.TabIndex = 3
        '
        'bttBuscar
        '
        Me.bttBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttBuscar.Image = Global.AydaraTPV.My.Resources.Resources.search
        Me.bttBuscar.Location = New System.Drawing.Point(236, 15)
        Me.bttBuscar.Name = "bttBuscar"
        Me.bttBuscar.Size = New System.Drawing.Size(106, 45)
        Me.bttBuscar.TabIndex = 3
        Me.bttBuscar.TabStop = False
        Me.bttBuscar.Text = "Diferencias"
        '
        'bttEnviar
        '
        Me.bttEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttEnviar.Image = Global.AydaraTPV.My.Resources.Resources.save
        Me.bttEnviar.Location = New System.Drawing.Point(348, 17)
        Me.bttEnviar.Name = "bttEnviar"
        Me.bttEnviar.Size = New System.Drawing.Size(106, 43)
        Me.bttEnviar.TabIndex = 4
        Me.bttEnviar.TabStop = False
        Me.bttEnviar.Text = "Enviar"
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.rgTipoactualizacion)
        Me.PanelControl2.Controls.Add(Me.txtFechaActualizacion)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.bttActualizar)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl2.Location = New System.Drawing.Point(635, 2)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(371, 66)
        Me.PanelControl2.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Location = New System.Drawing.Point(116, 13)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(99, 13)
        Me.LabelControl2.TabIndex = 111
        Me.LabelControl2.Text = "Tipo de actualización"
        '
        'rgTipoactualizacion
        '
        Me.rgTipoactualizacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rgTipoactualizacion.Location = New System.Drawing.Point(116, 32)
        Me.rgTipoactualizacion.Name = "rgTipoactualizacion"
        Me.rgTipoactualizacion.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "General"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Parcial")})
        Me.rgTipoactualizacion.Size = New System.Drawing.Size(126, 21)
        Me.rgTipoactualizacion.TabIndex = 2
        '
        'txtFechaActualizacion
        '
        Me.txtFechaActualizacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFechaActualizacion.EditValue = Nothing
        Me.txtFechaActualizacion.Location = New System.Drawing.Point(15, 33)
        Me.txtFechaActualizacion.Name = "txtFechaActualizacion"
        Me.txtFechaActualizacion.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFechaActualizacion.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtFechaActualizacion.Size = New System.Drawing.Size(95, 20)
        Me.txtFechaActualizacion.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(15, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl1.TabIndex = 109
        Me.LabelControl1.Text = "Fecha inventario"
        '
        'bttActualizar
        '
        Me.bttActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttActualizar.Image = Global.AydaraTPV.My.Resources.Resources.ok_32
        Me.bttActualizar.Location = New System.Drawing.Point(255, 11)
        Me.bttActualizar.Name = "bttActualizar"
        Me.bttActualizar.Size = New System.Drawing.Size(106, 45)
        Me.bttActualizar.TabIndex = 3
        Me.bttActualizar.TabStop = False
        Me.bttActualizar.Text = "Actualizar"
        '
        'bttEliminar
        '
        Me.bttEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttEliminar.Appearance.Options.UseTextOptions = True
        Me.bttEliminar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.bttEliminar.Image = Global.AydaraTPV.My.Resources.Resources.delete2
        Me.bttEliminar.Location = New System.Drawing.Point(12, 13)
        Me.bttEliminar.Name = "bttEliminar"
        Me.bttEliminar.Size = New System.Drawing.Size(106, 45)
        Me.bttEliminar.TabIndex = 1
        Me.bttEliminar.TabStop = False
        Me.bttEliminar.Text = "Borrar Inventario"
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Image = Global.AydaraTPV.My.Resources.Resources.tickets
        Me.bttImprimir.Location = New System.Drawing.Point(124, 13)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(106, 45)
        Me.bttImprimir.TabIndex = 2
        Me.bttImprimir.TabStop = False
        Me.bttImprimir.Text = "Imprimir"
        '
        'lblInfoArticulo
        '
        Me.lblInfoArticulo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfoArticulo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblInfoArticulo.Location = New System.Drawing.Point(12, 473)
        Me.lblInfoArticulo.Name = "lblInfoArticulo"
        Me.lblInfoArticulo.Size = New System.Drawing.Size(984, 13)
        Me.lblInfoArticulo.TabIndex = 104
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 562)
        Me.Controls.Add(Me.lblInfoArticulo)
        Me.Controls.Add(Me.dgInventario)
        Me.Controls.Add(Me.PanelControl1)
        Me.KeyPreview = True
        Me.Name = "Inventario"
        Me.Text = "Inventario"
        CType(Me.dgInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INVENTARIOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvInventario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttCodigoArticulo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.rgTipoactualizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaActualizacion.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFechaActualizacion.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgInventario As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvInventario As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigoArticulo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCajas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsInventario As AydaraTPV.dsInventario
    Friend WithEvents INVENTARIOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INVENTARIOTableAdapter As AydaraTPV.dsInventarioTableAdapters.INVENTARIOTableAdapter
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExistenciaActual As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttActualizar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bttCodigoArticulo As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents lblInfoArticulo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFechaActualizacion As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rgTipoactualizacion As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bttEnviar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttBuscar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents maskUnidades As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
