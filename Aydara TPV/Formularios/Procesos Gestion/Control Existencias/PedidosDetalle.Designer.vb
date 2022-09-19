<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PedidosDetalle
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
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Me.dgColores = New DevExpress.XtraGrid.GridControl
        Me.ARTICULOSCOLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New AydaraTPV.dsArticulos
        Me.gvColores = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colColores_Id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colColores_Articulo_Id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colColores_Color_Id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbColores_Id = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.COLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colColores_Color = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbColores = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.dgDetalleLineasPedido = New DevExpress.XtraGrid.GridControl
        Me.PEDIDOSLINEASDETALLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPedidos = New AydaraTPV.dsPedidos
        Me.gvDetalleLineasPedido = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLineaPedido_Id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoColor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoTalla = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcionTalla = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn
        Me.maskPrecio = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.maskCodigoBarrasTalla = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.ARTICULOS_COLORESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.ARTICULOS_COLORESTableAdapter
        Me.COLORESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter
        Me.PEDIDOS_LINEAS_DETALLETableAdapter = New AydaraTPV.dsPedidosTableAdapters.PEDIDOS_LINEAS_DETALLETableAdapter
        Me.bttAceptar = New DevExpress.XtraEditors.SimpleButton
        CType(Me.dgColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ARTICULOSCOLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores_Id, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetalleLineasPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PEDIDOSLINEASDETALLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDetalleLineasPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskCodigoBarrasTalla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgColores
        '
        Me.dgColores.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgColores.DataSource = Me.ARTICULOSCOLORESBindingSource
        Me.dgColores.Location = New System.Drawing.Point(12, 12)
        Me.dgColores.MainView = Me.gvColores
        Me.dgColores.Name = "dgColores"
        Me.dgColores.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbColores_Id, Me.cmbColores})
        Me.dgColores.Size = New System.Drawing.Size(280, 274)
        Me.dgColores.TabIndex = 49
        Me.dgColores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvColores})
        '
        'ARTICULOSCOLORESBindingSource
        '
        Me.ARTICULOSCOLORESBindingSource.DataMember = "ARTICULOS_COLORES"
        Me.ARTICULOSCOLORESBindingSource.DataSource = Me.DsArticulos
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "dsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvColores
        '
        Me.gvColores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colColores_Id, Me.colColores_Articulo_Id, Me.colColores_Color_Id, Me.colColores_Color})
        Me.gvColores.GridControl = Me.dgColores
        Me.gvColores.Name = "gvColores"
        Me.gvColores.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvColores.OptionsNavigation.UseTabKey = False
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
        Me.colColores_Color_Id.OptionsColumn.AllowEdit = False
        Me.colColores_Color_Id.OptionsColumn.AllowFocus = False
        Me.colColores_Color_Id.OptionsColumn.AllowMove = False
        Me.colColores_Color_Id.OptionsColumn.ReadOnly = True
        Me.colColores_Color_Id.OptionsColumn.TabStop = False
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
        'COLORESBindingSource
        '
        Me.COLORESBindingSource.DataMember = "COLORES"
        Me.COLORESBindingSource.DataSource = Me.DsArticulos
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
        Me.cmbColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, False, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing)})
        Me.cmbColores.DataSource = Me.COLORESBindingSource
        Me.cmbColores.DisplayMember = "Color"
        Me.cmbColores.Name = "cmbColores"
        Me.cmbColores.NullText = "-1"
        Me.cmbColores.ValueMember = "CodigoColor"
        '
        'dgDetalleLineasPedido
        '
        Me.dgDetalleLineasPedido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalleLineasPedido.DataSource = Me.PEDIDOSLINEASDETALLEBindingSource
        Me.dgDetalleLineasPedido.Location = New System.Drawing.Point(298, 12)
        Me.dgDetalleLineasPedido.MainView = Me.gvDetalleLineasPedido
        Me.dgDetalleLineasPedido.Name = "dgDetalleLineasPedido"
        Me.dgDetalleLineasPedido.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskPrecio, Me.maskCodigoBarrasTalla})
        Me.dgDetalleLineasPedido.Size = New System.Drawing.Size(150, 274)
        Me.dgDetalleLineasPedido.TabIndex = 52
        Me.dgDetalleLineasPedido.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvDetalleLineasPedido})
        '
        'PEDIDOSLINEASDETALLEBindingSource
        '
        Me.PEDIDOSLINEASDETALLEBindingSource.DataMember = "PEDIDOS_LINEAS_DETALLE"
        Me.PEDIDOSLINEASDETALLEBindingSource.DataSource = Me.DsPedidos
        '
        'DsPedidos
        '
        Me.DsPedidos.DataSetName = "dsPedidos"
        Me.DsPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvDetalleLineasPedido
        '
        Me.gvDetalleLineasPedido.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colLineaPedido_Id, Me.colCodigoColor, Me.colCodigoTalla, Me.colDescripcionTalla, Me.colCantidad})
        Me.gvDetalleLineasPedido.GridControl = Me.dgDetalleLineasPedido
        Me.gvDetalleLineasPedido.Name = "gvDetalleLineasPedido"
        Me.gvDetalleLineasPedido.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvDetalleLineasPedido.OptionsNavigation.UseTabKey = False
        Me.gvDetalleLineasPedido.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvDetalleLineasPedido.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvDetalleLineasPedido.OptionsSelection.EnableAppearanceHideSelection = False
        Me.gvDetalleLineasPedido.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.gvDetalleLineasPedido.OptionsView.ShowGroupPanel = False
        Me.gvDetalleLineasPedido.OptionsView.ShowIndicator = False
        '
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.OptionsColumn.ReadOnly = True
        '
        'colLineaPedido_Id
        '
        Me.colLineaPedido_Id.FieldName = "LineaPedido_Id"
        Me.colLineaPedido_Id.Name = "colLineaPedido_Id"
        '
        'colCodigoColor
        '
        Me.colCodigoColor.FieldName = "CodigoColor"
        Me.colCodigoColor.Name = "colCodigoColor"
        '
        'colCodigoTalla
        '
        Me.colCodigoTalla.FieldName = "CodigoTalla"
        Me.colCodigoTalla.Name = "colCodigoTalla"
        '
        'colDescripcionTalla
        '
        Me.colDescripcionTalla.Caption = "Talla"
        Me.colDescripcionTalla.FieldName = "DescripcionTalla"
        Me.colDescripcionTalla.Name = "colDescripcionTalla"
        Me.colDescripcionTalla.OptionsColumn.AllowEdit = False
        Me.colDescripcionTalla.OptionsColumn.AllowFocus = False
        Me.colDescripcionTalla.OptionsColumn.FixedWidth = True
        Me.colDescripcionTalla.OptionsColumn.ReadOnly = True
        Me.colDescripcionTalla.OptionsColumn.TabStop = False
        Me.colDescripcionTalla.Visible = True
        Me.colDescripcionTalla.VisibleIndex = 0
        '
        'colCantidad
        '
        Me.colCantidad.FieldName = "Cantidad"
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Visible = True
        Me.colCantidad.VisibleIndex = 1
        '
        'maskPrecio
        '
        Me.maskPrecio.AutoHeight = False
        Me.maskPrecio.Mask.EditMask = "0"
        Me.maskPrecio.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrecio.Mask.UseMaskAsDisplayFormat = True
        Me.maskPrecio.Name = "maskPrecio"
        '
        'maskCodigoBarrasTalla
        '
        Me.maskCodigoBarrasTalla.AutoHeight = False
        Me.maskCodigoBarrasTalla.MaxLength = 13
        Me.maskCodigoBarrasTalla.Name = "maskCodigoBarrasTalla"
        '
        'ARTICULOS_COLORESTableAdapter
        '
        Me.ARTICULOS_COLORESTableAdapter.ClearBeforeFill = True
        '
        'COLORESTableAdapter
        '
        Me.COLORESTableAdapter.ClearBeforeFill = True
        '
        'PEDIDOS_LINEAS_DETALLETableAdapter
        '
        Me.PEDIDOS_LINEAS_DETALLETableAdapter.ClearBeforeFill = True
        '
        'bttAceptar
        '
        Me.bttAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttAceptar.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bttAceptar.Appearance.Options.UseFont = True
        Me.bttAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttAceptar.Enabled = False
        Me.bttAceptar.Image = Global.AydaraTPV.My.Resources.Resources.ok_32
        Me.bttAceptar.Location = New System.Drawing.Point(296, 292)
        Me.bttAceptar.Name = "bttAceptar"
        Me.bttAceptar.Size = New System.Drawing.Size(152, 34)
        Me.bttAceptar.TabIndex = 53
        Me.bttAceptar.Text = "Aceptar"
        '
        'PedidosDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 338)
        Me.Controls.Add(Me.bttAceptar)
        Me.Controls.Add(Me.dgDetalleLineasPedido)
        Me.Controls.Add(Me.dgColores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PedidosDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Color - Talla"
        CType(Me.dgColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ARTICULOSCOLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores_Id, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetalleLineasPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PEDIDOSLINEASDETALLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDetalleLineasPedido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrecio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskCodigoBarrasTalla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgColores As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvColores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colColores_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColores_Articulo_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColores_Color_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbColores_Id As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colColores_Color As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbColores As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents dgDetalleLineasPedido As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetalleLineasPedido As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents maskPrecio As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents maskCodigoBarrasTalla As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DsArticulos As AydaraTPV.dsArticulos
    Friend WithEvents ARTICULOSCOLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ARTICULOS_COLORESTableAdapter As AydaraTPV.dsArticulosTableAdapters.ARTICULOS_COLORESTableAdapter
    Friend WithEvents COLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COLORESTableAdapter As AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter
    Friend WithEvents DsPedidos As AydaraTPV.dsPedidos
    Friend WithEvents PEDIDOSLINEASDETALLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PEDIDOS_LINEAS_DETALLETableAdapter As AydaraTPV.dsPedidosTableAdapters.PEDIDOS_LINEAS_DETALLETableAdapter
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLineaPedido_Id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bttAceptar As DevExpress.XtraEditors.SimpleButton
End Class
