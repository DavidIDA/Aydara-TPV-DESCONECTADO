<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Colores
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
        Me.dgColores = New DevExpress.XtraGrid.GridControl
        Me.COLORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New AydaraTPV.dsArticulos
        Me.gvColores = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoColor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbColores = New DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
        Me.COLORESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter
        Me.NavListadoColores = New DevExpress.XtraEditors.DataNavigator
        CType(Me.dgColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvColores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgColores
        '
        Me.dgColores.DataSource = Me.COLORESBindingSource
        Me.dgColores.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgColores.Location = New System.Drawing.Point(0, 0)
        Me.dgColores.MainView = Me.gvColores
        Me.dgColores.Name = "dgColores"
        Me.dgColores.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbColores, Me.RepositoryItemTextEdit1})
        Me.dgColores.Size = New System.Drawing.Size(792, 527)
        Me.dgColores.TabIndex = 0
        Me.dgColores.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvColores})
        '
        'COLORESBindingSource
        '
        Me.COLORESBindingSource.DataMember = "COLORES"
        Me.COLORESBindingSource.DataSource = Me.DsArticulos
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "dsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvColores
        '
        Me.gvColores.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoColor, Me.colDescripcion, Me.colColor})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.colCodigoColor
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = 0
        Me.gvColores.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gvColores.GridControl = Me.dgColores
        Me.gvColores.Name = "gvColores"
        Me.gvColores.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvColores.OptionsView.ShowAutoFilterRow = True
        Me.gvColores.OptionsView.ShowGroupPanel = False
        '
        'colCodigoColor
        '
        Me.colCodigoColor.Caption = "Código"
        Me.colCodigoColor.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colCodigoColor.FieldName = "CodigoColor"
        Me.colCodigoColor.MaxWidth = 60
        Me.colCodigoColor.Name = "colCodigoColor"
        Me.colCodigoColor.Visible = True
        Me.colCodigoColor.VisibleIndex = 0
        Me.colCodigoColor.Width = 60
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "00"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 611
        '
        'colColor
        '
        Me.colColor.Caption = "Color"
        Me.colColor.ColumnEdit = Me.cmbColores
        Me.colColor.FieldName = "Color"
        Me.colColor.MaxWidth = 150
        Me.colColor.Name = "colColor"
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 2
        Me.colColor.Width = 150
        '
        'cmbColores
        '
        Me.cmbColores.AutoHeight = False
        Me.cmbColores.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbColores.Mask.UseMaskAsDisplayFormat = True
        Me.cmbColores.Name = "cmbColores"
        Me.cmbColores.StoreColorAsInteger = True
        '
        'COLORESTableAdapter
        '
        Me.COLORESTableAdapter.ClearBeforeFill = True
        '
        'NavListadoColores
        '
        Me.NavListadoColores.Buttons.Append.Hint = "Añadir registro"
        Me.NavListadoColores.Buttons.CancelEdit.Hint = "Deshacer cambios"
        Me.NavListadoColores.Buttons.EndEdit.Hint = "Guardar cambios"
        Me.NavListadoColores.Buttons.Remove.Hint = "Eliminar registro"
        Me.NavListadoColores.DataSource = Me.COLORESBindingSource
        Me.NavListadoColores.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavListadoColores.Location = New System.Drawing.Point(0, 527)
        Me.NavListadoColores.Name = "NavListadoColores"
        Me.NavListadoColores.Size = New System.Drawing.Size(792, 39)
        Me.NavListadoColores.TabIndex = 3
        Me.NavListadoColores.Text = "Familias"
        '
        'Colores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.NavListadoColores)
        Me.Controls.Add(Me.dgColores)
        Me.KeyPreview = True
        Me.Name = "Colores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Colores"
        CType(Me.dgColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COLORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvColores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbColores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgColores As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvColores As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsArticulos As AydaraTPV.dsArticulos
    Friend WithEvents COLORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COLORESTableAdapter As AydaraTPV.dsArticulosTableAdapters.COLORESTableAdapter
    Friend WithEvents colCodigoColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbColores As DevExpress.XtraEditors.Repository.RepositoryItemColorEdit
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents NavListadoColores As DevExpress.XtraEditors.DataNavigator
End Class
