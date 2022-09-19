<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParametrosBascula
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
        Me.dgParametrosBascula = New DevExpress.XtraGrid.GridControl
        Me.PARAMETROSBASCULABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTiendas = New AydaraTPV.dsTiendas
        Me.gvParametrosBascula = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colPrefijo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colPosInicial_Articulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.maskPosicion = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.colPosFinal_Articulo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colPosInicial_Peso = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPosFinal_Peso = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colPosInicial_Importe = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colPosFinal_Importe = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.maskPrefijo = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.NavListadoParametrosBascula = New DevExpress.XtraEditors.DataNavigator
        Me.PARAMETROS_BASCULATableAdapter = New AydaraTPV.dsTiendasTableAdapters.PARAMETROS_BASCULATableAdapter
        CType(Me.dgParametrosBascula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PARAMETROSBASCULABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTiendas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvParametrosBascula, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPosicion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskPrefijo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgParametrosBascula
        '
        Me.dgParametrosBascula.DataSource = Me.PARAMETROSBASCULABindingSource
        Me.dgParametrosBascula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgParametrosBascula.Location = New System.Drawing.Point(0, 0)
        Me.dgParametrosBascula.MainView = Me.gvParametrosBascula
        Me.dgParametrosBascula.Name = "dgParametrosBascula"
        Me.dgParametrosBascula.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskPrefijo, Me.maskPosicion})
        Me.dgParametrosBascula.Size = New System.Drawing.Size(624, 403)
        Me.dgParametrosBascula.TabIndex = 0
        Me.dgParametrosBascula.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvParametrosBascula})
        '
        'PARAMETROSBASCULABindingSource
        '
        Me.PARAMETROSBASCULABindingSource.DataMember = "PARAMETROS_BASCULA"
        Me.PARAMETROSBASCULABindingSource.DataSource = Me.DsTiendas
        '
        'DsTiendas
        '
        Me.DsTiendas.DataSetName = "dsTiendas"
        Me.DsTiendas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvParametrosBascula
        '
        Me.gvParametrosBascula.Appearance.BandPanel.Options.UseTextOptions = True
        Me.gvParametrosBascula.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvParametrosBascula.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gvParametrosBascula.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvParametrosBascula.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.gvParametrosBascula.Appearance.Row.Options.UseFont = True
        Me.gvParametrosBascula.Appearance.Row.Options.UseTextOptions = True
        Me.gvParametrosBascula.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gvParametrosBascula.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand2, Me.GridBand3, Me.GridBand4})
        Me.gvParametrosBascula.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colPrefijo, Me.colPosInicial_Articulo, Me.colPosFinal_Articulo, Me.colPosInicial_Peso, Me.colPosFinal_Peso, Me.colPosInicial_Importe, Me.colPosFinal_Importe})
        Me.gvParametrosBascula.GridControl = Me.dgParametrosBascula
        Me.gvParametrosBascula.Name = "gvParametrosBascula"
        Me.gvParametrosBascula.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvParametrosBascula.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvParametrosBascula.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvParametrosBascula.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.gvParametrosBascula.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Columns.Add(Me.colPrefijo)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 75
        '
        'colPrefijo
        '
        Me.colPrefijo.FieldName = "Prefijo"
        Me.colPrefijo.Name = "colPrefijo"
        Me.colPrefijo.Visible = True
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "Código Artículo"
        Me.GridBand2.Columns.Add(Me.colPosInicial_Articulo)
        Me.GridBand2.Columns.Add(Me.colPosFinal_Articulo)
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 150
        '
        'colPosInicial_Articulo
        '
        Me.colPosInicial_Articulo.Caption = "Pos. Inicial"
        Me.colPosInicial_Articulo.ColumnEdit = Me.maskPosicion
        Me.colPosInicial_Articulo.FieldName = "PosInicial_Articulo"
        Me.colPosInicial_Articulo.Name = "colPosInicial_Articulo"
        Me.colPosInicial_Articulo.Visible = True
        '
        'maskPosicion
        '
        Me.maskPosicion.AutoHeight = False
        Me.maskPosicion.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.maskPosicion.Mask.EditMask = "00"
        Me.maskPosicion.Mask.UseMaskAsDisplayFormat = True
        Me.maskPosicion.MaxValue = New Decimal(New Integer() {13, 0, 0, 0})
        Me.maskPosicion.Name = "maskPosicion"
        '
        'colPosFinal_Articulo
        '
        Me.colPosFinal_Articulo.Caption = "Pos. Final"
        Me.colPosFinal_Articulo.ColumnEdit = Me.maskPosicion
        Me.colPosFinal_Articulo.FieldName = "PosFinal_Articulo"
        Me.colPosFinal_Articulo.Name = "colPosFinal_Articulo"
        Me.colPosFinal_Articulo.Visible = True
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "Peso"
        Me.GridBand3.Columns.Add(Me.colPosInicial_Peso)
        Me.GridBand3.Columns.Add(Me.colPosFinal_Peso)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 150
        '
        'colPosInicial_Peso
        '
        Me.colPosInicial_Peso.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colPosInicial_Peso.AppearanceCell.Options.UseForeColor = True
        Me.colPosInicial_Peso.Caption = "Pos. Inicial"
        Me.colPosInicial_Peso.ColumnEdit = Me.maskPosicion
        Me.colPosInicial_Peso.FieldName = "PosInicial_Peso"
        Me.colPosInicial_Peso.Name = "colPosInicial_Peso"
        Me.colPosInicial_Peso.Visible = True
        '
        'colPosFinal_Peso
        '
        Me.colPosFinal_Peso.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.colPosFinal_Peso.AppearanceCell.Options.UseForeColor = True
        Me.colPosFinal_Peso.Caption = "Pos. Final"
        Me.colPosFinal_Peso.ColumnEdit = Me.maskPosicion
        Me.colPosFinal_Peso.FieldName = "PosFinal_Peso"
        Me.colPosFinal_Peso.Name = "colPosFinal_Peso"
        Me.colPosFinal_Peso.Visible = True
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "Importe"
        Me.GridBand4.Columns.Add(Me.colPosInicial_Importe)
        Me.GridBand4.Columns.Add(Me.colPosFinal_Importe)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 150
        '
        'colPosInicial_Importe
        '
        Me.colPosInicial_Importe.AppearanceCell.ForeColor = System.Drawing.Color.Green
        Me.colPosInicial_Importe.AppearanceCell.Options.UseForeColor = True
        Me.colPosInicial_Importe.Caption = "Pos. Inicial"
        Me.colPosInicial_Importe.ColumnEdit = Me.maskPosicion
        Me.colPosInicial_Importe.FieldName = "PosInicial_Importe"
        Me.colPosInicial_Importe.Name = "colPosInicial_Importe"
        Me.colPosInicial_Importe.Visible = True
        '
        'colPosFinal_Importe
        '
        Me.colPosFinal_Importe.AppearanceCell.ForeColor = System.Drawing.Color.Green
        Me.colPosFinal_Importe.AppearanceCell.Options.UseForeColor = True
        Me.colPosFinal_Importe.Caption = "Pos. Final"
        Me.colPosFinal_Importe.ColumnEdit = Me.maskPosicion
        Me.colPosFinal_Importe.FieldName = "PosFinal_Importe"
        Me.colPosFinal_Importe.Name = "colPosFinal_Importe"
        Me.colPosFinal_Importe.Visible = True
        '
        'maskPrefijo
        '
        Me.maskPrefijo.AutoHeight = False
        Me.maskPrefijo.Mask.EditMask = "00"
        Me.maskPrefijo.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskPrefijo.MaxLength = 2
        Me.maskPrefijo.Name = "maskPrefijo"
        '
        'NavListadoParametrosBascula
        '
        Me.NavListadoParametrosBascula.Buttons.Append.Hint = "Añadir registro"
        Me.NavListadoParametrosBascula.Buttons.CancelEdit.Hint = "Deshacer cambios"
        Me.NavListadoParametrosBascula.Buttons.EndEdit.Hint = "Guardar cambios"
        Me.NavListadoParametrosBascula.Buttons.NextPage.Visible = False
        Me.NavListadoParametrosBascula.Buttons.PrevPage.Visible = False
        Me.NavListadoParametrosBascula.Buttons.Remove.Hint = "Eliminar registro"
        Me.NavListadoParametrosBascula.DataSource = Me.PARAMETROSBASCULABindingSource
        Me.NavListadoParametrosBascula.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavListadoParametrosBascula.Location = New System.Drawing.Point(0, 403)
        Me.NavListadoParametrosBascula.Name = "NavListadoParametrosBascula"
        Me.NavListadoParametrosBascula.Size = New System.Drawing.Size(624, 39)
        Me.NavListadoParametrosBascula.TabIndex = 3
        Me.NavListadoParametrosBascula.Text = "Prefijos"
        Me.NavListadoParametrosBascula.TextStringFormat = "Registro {0} de {1}"
        '
        'PARAMETROS_BASCULATableAdapter
        '
        Me.PARAMETROS_BASCULATableAdapter.ClearBeforeFill = True
        '
        'ParametrosBascula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 442)
        Me.Controls.Add(Me.dgParametrosBascula)
        Me.Controls.Add(Me.NavListadoParametrosBascula)
        Me.KeyPreview = True
        Me.Name = "ParametrosBascula"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Parámetros Tickets Báscula"
        CType(Me.dgParametrosBascula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PARAMETROSBASCULABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTiendas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvParametrosBascula, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPosicion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskPrefijo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgParametrosBascula As DevExpress.XtraGrid.GridControl
    Friend WithEvents maskPrefijo As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents NavListadoParametrosBascula As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents DsTiendas As AydaraTPV.dsTiendas
    Friend WithEvents PARAMETROSBASCULABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PARAMETROS_BASCULATableAdapter As AydaraTPV.dsTiendasTableAdapters.PARAMETROS_BASCULATableAdapter
    Friend WithEvents gvParametrosBascula As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colPrefijo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colPosInicial_Articulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPosFinal_Articulo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colPosInicial_Peso As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPosFinal_Peso As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colPosInicial_Importe As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPosFinal_Importe As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents maskPosicion As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
