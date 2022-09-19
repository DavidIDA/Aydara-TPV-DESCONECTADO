<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiposUnidades
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
        Me.dgTiposUnidades = New DevExpress.XtraGrid.GridControl
        Me.TIPOSUNIDADESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsArticulos = New AydaraTPV.dsArticulos
        Me.gvTiposUnidades = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.maskCodigo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.maskDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.NavListadoTiposUnidades = New DevExpress.XtraEditors.DataNavigator
        Me.TIPOS_UNIDADESTableAdapter = New AydaraTPV.dsArticulosTableAdapters.TIPOS_UNIDADESTableAdapter
        CType(Me.dgTiposUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TIPOSUNIDADESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTiposUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgTiposUnidades
        '
        Me.dgTiposUnidades.DataSource = Me.TIPOSUNIDADESBindingSource
        Me.dgTiposUnidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTiposUnidades.Location = New System.Drawing.Point(0, 0)
        Me.dgTiposUnidades.MainView = Me.gvTiposUnidades
        Me.dgTiposUnidades.Name = "dgTiposUnidades"
        Me.dgTiposUnidades.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskCodigo, Me.maskDescripcion})
        Me.dgTiposUnidades.Size = New System.Drawing.Size(792, 527)
        Me.dgTiposUnidades.TabIndex = 0
        Me.dgTiposUnidades.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTiposUnidades})
        '
        'TIPOSUNIDADESBindingSource
        '
        Me.TIPOSUNIDADESBindingSource.DataMember = "TIPOS_UNIDADES"
        Me.TIPOSUNIDADESBindingSource.DataSource = Me.DsArticulos
        '
        'DsArticulos
        '
        Me.DsArticulos.DataSetName = "dsArticulos"
        Me.DsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvTiposUnidades
        '
        Me.gvTiposUnidades.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion})
        Me.gvTiposUnidades.GridControl = Me.dgTiposUnidades
        Me.gvTiposUnidades.Name = "gvTiposUnidades"
        Me.gvTiposUnidades.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvTiposUnidades.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvTiposUnidades.OptionsView.ShowAutoFilterRow = True
        Me.gvTiposUnidades.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.ColumnEdit = Me.maskCodigo
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.MaxWidth = 60
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 60
        '
        'maskCodigo
        '
        Me.maskCodigo.AutoHeight = False
        Me.maskCodigo.Mask.EditMask = "00"
        Me.maskCodigo.MaxLength = 2
        Me.maskCodigo.Name = "maskCodigo"
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripción"
        Me.colDescripcion.ColumnEdit = Me.maskDescripcion
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Visible = True
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 611
        '
        'maskDescripcion
        '
        Me.maskDescripcion.AutoHeight = False
        Me.maskDescripcion.MaxLength = 10
        Me.maskDescripcion.Name = "maskDescripcion"
        '
        'NavListadoTiposUnidades
        '
        Me.NavListadoTiposUnidades.Buttons.Append.Hint = "Añadir registro"
        Me.NavListadoTiposUnidades.Buttons.CancelEdit.Hint = "Deshacer cambios"
        Me.NavListadoTiposUnidades.Buttons.EndEdit.Hint = "Guardar cambios"
        Me.NavListadoTiposUnidades.Buttons.Remove.Hint = "Eliminar registro"
        Me.NavListadoTiposUnidades.DataSource = Me.TIPOSUNIDADESBindingSource
        Me.NavListadoTiposUnidades.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavListadoTiposUnidades.Location = New System.Drawing.Point(0, 527)
        Me.NavListadoTiposUnidades.Name = "NavListadoTiposUnidades"
        Me.NavListadoTiposUnidades.Size = New System.Drawing.Size(792, 39)
        Me.NavListadoTiposUnidades.TabIndex = 3
        Me.NavListadoTiposUnidades.Text = "Tipos unidades"
        '
        'TIPOS_UNIDADESTableAdapter
        '
        Me.TIPOS_UNIDADESTableAdapter.ClearBeforeFill = True
        '
        'TiposUnidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.dgTiposUnidades)
        Me.Controls.Add(Me.NavListadoTiposUnidades)
        Me.KeyPreview = True
        Me.Name = "TiposUnidades"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tipos Unidades Artículos"
        CType(Me.dgTiposUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TIPOSUNIDADESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTiposUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgTiposUnidades As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTiposUnidades As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsArticulos As AydaraTPV.dsArticulos
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents maskCodigo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents NavListadoTiposUnidades As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents TIPOSUNIDADESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TIPOS_UNIDADESTableAdapter As AydaraTPV.dsArticulosTableAdapters.TIPOS_UNIDADESTableAdapter
    Friend WithEvents maskDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
