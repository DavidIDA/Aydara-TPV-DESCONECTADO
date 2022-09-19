<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiposIncidencia
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
        Me.dgTiposIncidencia = New DevExpress.XtraGrid.GridControl
        Me.INCIDENCIASTIPOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsIncidenciasTipos = New AydaraTPV.dsIncidenciasTipos
        Me.gvTiposIncidencia = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.maskDescripcion = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.NavListadoTiposIncidencia = New DevExpress.XtraEditors.DataNavigator
        Me.INCIDENCIAS_TIPOSTableAdapter = New AydaraTPV.dsIncidenciasTiposTableAdapters.INCIDENCIAS_TIPOSTableAdapter
        CType(Me.dgTiposIncidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INCIDENCIASTIPOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsIncidenciasTipos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTiposIncidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgTiposIncidencia
        '
        Me.dgTiposIncidencia.DataSource = Me.INCIDENCIASTIPOSBindingSource
        Me.dgTiposIncidencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTiposIncidencia.Location = New System.Drawing.Point(0, 0)
        Me.dgTiposIncidencia.MainView = Me.gvTiposIncidencia
        Me.dgTiposIncidencia.Name = "dgTiposIncidencia"
        Me.dgTiposIncidencia.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskDescripcion})
        Me.dgTiposIncidencia.Size = New System.Drawing.Size(792, 527)
        Me.dgTiposIncidencia.TabIndex = 0
        Me.dgTiposIncidencia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTiposIncidencia})
        '
        'INCIDENCIASTIPOSBindingSource
        '
        Me.INCIDENCIASTIPOSBindingSource.DataMember = "INCIDENCIAS_TIPOS"
        Me.INCIDENCIASTIPOSBindingSource.DataSource = Me.DsIncidenciasTipos
        '
        'DsIncidenciasTipos
        '
        Me.DsIncidenciasTipos.DataSetName = "dsIncidenciasTipos"
        Me.DsIncidenciasTipos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvTiposIncidencia
        '
        Me.gvTiposIncidencia.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion})
        Me.gvTiposIncidencia.GridControl = Me.dgTiposIncidencia
        Me.gvTiposIncidencia.Name = "gvTiposIncidencia"
        Me.gvTiposIncidencia.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvTiposIncidencia.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvTiposIncidencia.OptionsView.ShowAutoFilterRow = True
        Me.gvTiposIncidencia.OptionsView.ShowGroupPanel = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Código"
        Me.colCodigo.FieldName = "IDTipo"
        Me.colCodigo.MaxWidth = 60
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Visible = True
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 60
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
        Me.maskDescripcion.MaxLength = 50
        Me.maskDescripcion.Name = "maskDescripcion"
        '
        'NavListadoTiposIncidencia
        '
        Me.NavListadoTiposIncidencia.Buttons.Append.Hint = "Añadir registro"
        Me.NavListadoTiposIncidencia.Buttons.CancelEdit.Hint = "Deshacer cambios"
        Me.NavListadoTiposIncidencia.Buttons.EndEdit.Hint = "Guardar cambios"
        Me.NavListadoTiposIncidencia.Buttons.Remove.Hint = "Eliminar registro"
        Me.NavListadoTiposIncidencia.DataSource = Me.INCIDENCIASTIPOSBindingSource
        Me.NavListadoTiposIncidencia.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavListadoTiposIncidencia.Location = New System.Drawing.Point(0, 527)
        Me.NavListadoTiposIncidencia.Name = "NavListadoTiposIncidencia"
        Me.NavListadoTiposIncidencia.Size = New System.Drawing.Size(792, 39)
        Me.NavListadoTiposIncidencia.TabIndex = 3
        Me.NavListadoTiposIncidencia.Text = "Tipos unidades"
        '
        'INCIDENCIAS_TIPOSTableAdapter
        '
        Me.INCIDENCIAS_TIPOSTableAdapter.ClearBeforeFill = True
        '
        'TiposIncidencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.dgTiposIncidencia)
        Me.Controls.Add(Me.NavListadoTiposIncidencia)
        Me.KeyPreview = True
        Me.Name = "TiposIncidencia"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tipos Incidencia"
        CType(Me.dgTiposIncidencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INCIDENCIASTIPOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsIncidenciasTipos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTiposIncidencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgTiposIncidencia As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvTiposIncidencia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NavListadoTiposIncidencia As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents maskDescripcion As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DsIncidenciasTipos As AydaraTPV.dsIncidenciasTipos
    Friend WithEvents INCIDENCIASTIPOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents INCIDENCIAS_TIPOSTableAdapter As AydaraTPV.dsIncidenciasTiposTableAdapters.INCIDENCIAS_TIPOSTableAdapter
End Class
