<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValesTienda
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition()
        Me.colConsumido = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bttEliminar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttNuevo = New DevExpress.XtraEditors.SimpleButton()
        Me.VALESTIENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsValesTienda = New AydaraTPV.dsValesTienda()
        Me.dgValesTienda = New DevExpress.XtraGrid.GridControl()
        Me.gvValesTienda = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodigoTienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoVale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaVale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFechaCaducidad = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodigoCliente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.VALES_TIENDATableAdapter = New AydaraTPV.dsValesTiendaTableAdapters.VALES_TIENDATableAdapter()
        Me.NavValesTienda = New DevExpress.XtraEditors.ControlNavigator()
        CType(Me.VALESTIENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsValesTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgValesTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvValesTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colConsumido
        '
        Me.colConsumido.Caption = "Consumido"
        Me.colConsumido.FieldName = "Consumido"
        Me.colConsumido.Name = "colConsumido"
        Me.colConsumido.Visible = True
        Me.colConsumido.VisibleIndex = 7
        '
        'bttEliminar
        '
        Me.bttEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttEliminar.Image = Global.AydaraTPV.My.Resources.Resources.delete2
        Me.bttEliminar.Location = New System.Drawing.Point(12, 519)
        Me.bttEliminar.Name = "bttEliminar"
        Me.bttEliminar.Size = New System.Drawing.Size(85, 45)
        Me.bttEliminar.TabIndex = 17
        Me.bttEliminar.Text = "Eliminar"
        '
        'bttNuevo
        '
        Me.bttNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttNuevo.Image = Global.AydaraTPV.My.Resources.Resources._new
        Me.bttNuevo.Location = New System.Drawing.Point(704, 519)
        Me.bttNuevo.Name = "bttNuevo"
        Me.bttNuevo.Size = New System.Drawing.Size(76, 45)
        Me.bttNuevo.TabIndex = 15
        Me.bttNuevo.Text = "Nuevo"
        '
        'VALESTIENDABindingSource
        '
        Me.VALESTIENDABindingSource.DataMember = "VALES_TIENDA"
        Me.VALESTIENDABindingSource.DataSource = Me.DsValesTienda
        Me.VALESTIENDABindingSource.Filter = ""
        '
        'DsValesTienda
        '
        Me.DsValesTienda.DataSetName = "dsValesTienda"
        Me.DsValesTienda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgValesTienda
        '
        Me.dgValesTienda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgValesTienda.DataSource = Me.VALESTIENDABindingSource
        Me.dgValesTienda.Location = New System.Drawing.Point(0, 3)
        Me.dgValesTienda.MainView = Me.gvValesTienda
        Me.dgValesTienda.Name = "dgValesTienda"
        Me.dgValesTienda.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskImporte})
        Me.dgValesTienda.Size = New System.Drawing.Size(792, 510)
        Me.dgValesTienda.TabIndex = 13
        Me.dgValesTienda.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvValesTienda})
        '
        'gvValesTienda
        '
        Me.gvValesTienda.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoTienda, Me.colCodigoVale, Me.colFechaVale, Me.colFechaCaducidad, Me.colCodigoCliente, Me.colNombre, Me.colConcepto, Me.colImporte, Me.colConsumido})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[FechaCaducidad]<Today()"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.colConsumido
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = True
        Me.gvValesTienda.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.gvValesTienda.GridControl = Me.dgValesTienda
        Me.gvValesTienda.Name = "gvValesTienda"
        Me.gvValesTienda.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvValesTienda.OptionsFind.AlwaysVisible = True
        Me.gvValesTienda.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvValesTienda.OptionsView.ShowAutoFilterRow = True
        Me.gvValesTienda.OptionsView.ShowGroupPanel = False
        '
        'colCodigoTienda
        '
        Me.colCodigoTienda.FieldName = "CodigoTienda"
        Me.colCodigoTienda.MaxWidth = 100
        Me.colCodigoTienda.MinWidth = 100
        Me.colCodigoTienda.Name = "colCodigoTienda"
        Me.colCodigoTienda.Width = 100
        '
        'colCodigoVale
        '
        Me.colCodigoVale.FieldName = "CodigoVale"
        Me.colCodigoVale.Name = "colCodigoVale"
        Me.colCodigoVale.Visible = True
        Me.colCodigoVale.VisibleIndex = 0
        Me.colCodigoVale.Width = 100
        '
        'colFechaVale
        '
        Me.colFechaVale.FieldName = "FechaVale"
        Me.colFechaVale.Name = "colFechaVale"
        Me.colFechaVale.Visible = True
        Me.colFechaVale.VisibleIndex = 1
        Me.colFechaVale.Width = 80
        '
        'colFechaCaducidad
        '
        Me.colFechaCaducidad.Caption = "Caducidad"
        Me.colFechaCaducidad.FieldName = "FechaCaducidad"
        Me.colFechaCaducidad.Name = "colFechaCaducidad"
        Me.colFechaCaducidad.Visible = True
        Me.colFechaCaducidad.VisibleIndex = 2
        '
        'colCodigoCliente
        '
        Me.colCodigoCliente.Caption = "Cliente"
        Me.colCodigoCliente.FieldName = "CodigoCliente"
        Me.colCodigoCliente.Name = "colCodigoCliente"
        Me.colCodigoCliente.Visible = True
        Me.colCodigoCliente.VisibleIndex = 3
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 4
        Me.colNombre.Width = 215
        '
        'colConcepto
        '
        Me.colConcepto.FieldName = "Concepto"
        Me.colConcepto.Name = "colConcepto"
        Me.colConcepto.Visible = True
        Me.colConcepto.VisibleIndex = 5
        Me.colConcepto.Width = 216
        '
        'colImporte
        '
        Me.colImporte.ColumnEdit = Me.maskImporte
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 6
        Me.colImporte.Width = 73
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.EditMask = "c2"
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'VALES_TIENDATableAdapter
        '
        Me.VALES_TIENDATableAdapter.ClearBeforeFill = True
        '
        'NavValesTienda
        '
        Me.NavValesTienda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NavValesTienda.Buttons.Append.Visible = False
        Me.NavValesTienda.Buttons.CancelEdit.Visible = False
        Me.NavValesTienda.Buttons.Edit.Visible = False
        Me.NavValesTienda.Buttons.EndEdit.Visible = False
        Me.NavValesTienda.Buttons.Remove.Visible = False
        Me.NavValesTienda.Location = New System.Drawing.Point(103, 519)
        Me.NavValesTienda.Name = "NavValesTienda"
        Me.NavValesTienda.NavigatableControl = Me.dgValesTienda
        Me.NavValesTienda.Size = New System.Drawing.Size(595, 45)
        Me.NavValesTienda.TabIndex = 18
        Me.NavValesTienda.Text = "ControlNavigator1"
        '
        'ValesTienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.NavValesTienda)
        Me.Controls.Add(Me.bttEliminar)
        Me.Controls.Add(Me.bttNuevo)
        Me.Controls.Add(Me.dgValesTienda)
        Me.KeyPreview = True
        Me.Name = "ValesTienda"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de vales"
        CType(Me.VALESTIENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsValesTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgValesTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvValesTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bttEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dgValesTienda As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvValesTienda As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsValesTienda As AydaraTPV.dsValesTienda
    Friend WithEvents VALESTIENDABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VALES_TIENDATableAdapter As AydaraTPV.dsValesTiendaTableAdapters.VALES_TIENDATableAdapter
    Friend WithEvents colCodigoTienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoVale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaVale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents NavValesTienda As DevExpress.XtraEditors.ControlNavigator
    Friend WithEvents colConsumido As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaCaducidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCliente As DevExpress.XtraGrid.Columns.GridColumn
End Class
