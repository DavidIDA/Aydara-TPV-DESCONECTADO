<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tallas
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tallas))
        Me.dgTallas = New DevExpress.XtraGrid.GridControl
        Me.TALLASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New AydaraTPV.dsArticulos
        Me.gvTallas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoTalla = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colTalla_1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_12 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_13 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_14 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_16 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_17 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTalla_18 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NavListadoTallas = New DevExpress.XtraEditors.DataNavigator
        Me.ImagenesMenu = New DevExpress.Utils.ImageCollection(Me.components)
        Me.TALLASTableAdapter = New AydaraTPV.dsArticulosTableAdapters.TALLASTableAdapter
        CType(Me.dgTallas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TALLASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTallas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenesMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgTallas
        '
        Me.dgTallas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTallas.DataSource = Me.TALLASBindingSource
        Me.dgTallas.Location = New System.Drawing.Point(0, 0)
        Me.dgTallas.MainView = Me.gvTallas
        Me.dgTallas.Name = "dgTallas"
        Me.dgTallas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.dgTallas.Size = New System.Drawing.Size(792, 526)
        Me.dgTallas.TabIndex = 0
        Me.dgTallas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTallas})
        '
        'TALLASBindingSource
        '
        Me.TALLASBindingSource.DataMember = "TALLAS"
        Me.TALLASBindingSource.DataSource = Me.DsArticulos
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "dsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvTallas
        '
        Me.gvTallas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoTalla, Me.colTalla_1, Me.colTalla_2, Me.colTalla_3, Me.colTalla_4, Me.colTalla_5, Me.colTalla_6, Me.colTalla_7, Me.colTalla_8, Me.colTalla_9, Me.colTalla_10, Me.colTalla_11, Me.colTalla_12, Me.colTalla_13, Me.colTalla_14, Me.colTalla_15, Me.colTalla_16, Me.colTalla_17, Me.colTalla_18})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colCodigoTalla
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "01"
        Me.gvTallas.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gvTallas.GridControl = Me.dgTallas
        Me.gvTallas.Name = "gvTallas"
        Me.gvTallas.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvTallas.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvTallas.OptionsView.ShowAutoFilterRow = True
        Me.gvTallas.OptionsView.ShowGroupPanel = False
        '
        'colCodigoTalla
        '
        Me.colCodigoTalla.Caption = "Código"
        Me.colCodigoTalla.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCodigoTalla.FieldName = "CodigoTalla"
        Me.colCodigoTalla.Name = "colCodigoTalla"
        Me.colCodigoTalla.Visible = True
        Me.colCodigoTalla.VisibleIndex = 0
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "00"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colTalla_1
        '
        Me.colTalla_1.Caption = "T_1"
        Me.colTalla_1.FieldName = "Talla_1"
        Me.colTalla_1.Name = "colTalla_1"
        Me.colTalla_1.Visible = True
        Me.colTalla_1.VisibleIndex = 1
        '
        'colTalla_2
        '
        Me.colTalla_2.Caption = "T_2"
        Me.colTalla_2.FieldName = "Talla_2"
        Me.colTalla_2.Name = "colTalla_2"
        Me.colTalla_2.Visible = True
        Me.colTalla_2.VisibleIndex = 2
        '
        'colTalla_3
        '
        Me.colTalla_3.Caption = "T_3"
        Me.colTalla_3.FieldName = "Talla_3"
        Me.colTalla_3.Name = "colTalla_3"
        Me.colTalla_3.Visible = True
        Me.colTalla_3.VisibleIndex = 3
        '
        'colTalla_4
        '
        Me.colTalla_4.Caption = "T_4"
        Me.colTalla_4.FieldName = "Talla_4"
        Me.colTalla_4.Name = "colTalla_4"
        Me.colTalla_4.Visible = True
        Me.colTalla_4.VisibleIndex = 4
        '
        'colTalla_5
        '
        Me.colTalla_5.Caption = "T_5"
        Me.colTalla_5.FieldName = "Talla_5"
        Me.colTalla_5.Name = "colTalla_5"
        Me.colTalla_5.Visible = True
        Me.colTalla_5.VisibleIndex = 5
        '
        'colTalla_6
        '
        Me.colTalla_6.Caption = "T_6"
        Me.colTalla_6.FieldName = "Talla_6"
        Me.colTalla_6.Name = "colTalla_6"
        Me.colTalla_6.Visible = True
        Me.colTalla_6.VisibleIndex = 6
        '
        'colTalla_7
        '
        Me.colTalla_7.Caption = "T_7"
        Me.colTalla_7.FieldName = "Talla_7"
        Me.colTalla_7.Name = "colTalla_7"
        Me.colTalla_7.Visible = True
        Me.colTalla_7.VisibleIndex = 7
        '
        'colTalla_8
        '
        Me.colTalla_8.Caption = "T_8"
        Me.colTalla_8.FieldName = "Talla_8"
        Me.colTalla_8.Name = "colTalla_8"
        Me.colTalla_8.Visible = True
        Me.colTalla_8.VisibleIndex = 8
        '
        'colTalla_9
        '
        Me.colTalla_9.Caption = "T_9"
        Me.colTalla_9.FieldName = "Talla_9"
        Me.colTalla_9.Name = "colTalla_9"
        Me.colTalla_9.Visible = True
        Me.colTalla_9.VisibleIndex = 9
        '
        'colTalla_10
        '
        Me.colTalla_10.Caption = "T_10"
        Me.colTalla_10.FieldName = "Talla_10"
        Me.colTalla_10.Name = "colTalla_10"
        Me.colTalla_10.Visible = True
        Me.colTalla_10.VisibleIndex = 10
        '
        'colTalla_11
        '
        Me.colTalla_11.Caption = "T_11"
        Me.colTalla_11.FieldName = "Talla_11"
        Me.colTalla_11.Name = "colTalla_11"
        Me.colTalla_11.Visible = True
        Me.colTalla_11.VisibleIndex = 11
        '
        'colTalla_12
        '
        Me.colTalla_12.Caption = "T_12"
        Me.colTalla_12.FieldName = "Talla_12"
        Me.colTalla_12.Name = "colTalla_12"
        Me.colTalla_12.Visible = True
        Me.colTalla_12.VisibleIndex = 12
        '
        'colTalla_13
        '
        Me.colTalla_13.Caption = "T_13"
        Me.colTalla_13.FieldName = "Talla_13"
        Me.colTalla_13.Name = "colTalla_13"
        Me.colTalla_13.Visible = True
        Me.colTalla_13.VisibleIndex = 13
        '
        'colTalla_14
        '
        Me.colTalla_14.Caption = "T_14"
        Me.colTalla_14.FieldName = "Talla_14"
        Me.colTalla_14.Name = "colTalla_14"
        Me.colTalla_14.Visible = True
        Me.colTalla_14.VisibleIndex = 14
        '
        'colTalla_15
        '
        Me.colTalla_15.Caption = "T_15"
        Me.colTalla_15.FieldName = "Talla_15"
        Me.colTalla_15.Name = "colTalla_15"
        Me.colTalla_15.Visible = True
        Me.colTalla_15.VisibleIndex = 15
        '
        'colTalla_16
        '
        Me.colTalla_16.Caption = "T_16"
        Me.colTalla_16.FieldName = "Talla_16"
        Me.colTalla_16.Name = "colTalla_16"
        Me.colTalla_16.Visible = True
        Me.colTalla_16.VisibleIndex = 16
        '
        'colTalla_17
        '
        Me.colTalla_17.Caption = "T_17"
        Me.colTalla_17.FieldName = "Talla_17"
        Me.colTalla_17.Name = "colTalla_17"
        Me.colTalla_17.Visible = True
        Me.colTalla_17.VisibleIndex = 17
        '
        'colTalla_18
        '
        Me.colTalla_18.Caption = "T_18"
        Me.colTalla_18.FieldName = "Talla_18"
        Me.colTalla_18.Name = "colTalla_18"
        Me.colTalla_18.Visible = True
        Me.colTalla_18.VisibleIndex = 18
        '
        'NavListadoTallas
        '
        Me.NavListadoTallas.Buttons.Append.Hint = "Añadir registro"
        Me.NavListadoTallas.Buttons.CancelEdit.Hint = "Deshacer cambios"
        Me.NavListadoTallas.Buttons.EndEdit.Hint = "Guardar cambios"
        Me.NavListadoTallas.Buttons.ImageList = Me.ImagenesMenu
        Me.NavListadoTallas.Buttons.Remove.Hint = "Eliminar registro"
        Me.NavListadoTallas.DataSource = Me.TALLASBindingSource
        Me.NavListadoTallas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavListadoTallas.Location = New System.Drawing.Point(0, 527)
        Me.NavListadoTallas.Name = "NavListadoTallas"
        Me.NavListadoTallas.Size = New System.Drawing.Size(792, 39)
        Me.NavListadoTallas.TabIndex = 2
        Me.NavListadoTallas.Text = "Familias"
        '
        'ImagenesMenu
        '
        Me.ImagenesMenu.ImageStream = CType(resources.GetObject("ImagenesMenu.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'TALLASTableAdapter
        '
        Me.TALLASTableAdapter.ClearBeforeFill = True
        '
        'Tallas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.NavListadoTallas)
        Me.Controls.Add(Me.dgTallas)
        Me.KeyPreview = True
        Me.Name = "Tallas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tallas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgTallas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TALLASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTallas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenesMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgTallas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTallas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NavListadoTallas As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents DsArticulos As AydaraTPV.dsArticulos
    Friend WithEvents TALLASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TALLASTableAdapter As AydaraTPV.dsArticulosTableAdapters.TALLASTableAdapter
    Friend WithEvents colCodigoTalla As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTalla_18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents ImagenesMenu As DevExpress.Utils.ImageCollection
End Class
