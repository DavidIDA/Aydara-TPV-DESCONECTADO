<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FicheroVales
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
        Me.VALESTIENDABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsValesTienda = New AydaraTPV.dsValesTienda
        Me.dgVales = New DevExpress.XtraGrid.GridControl
        Me.gvVales = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoTienda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoVale = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFechaVale = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNombre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colConcepto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImporte = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSeleccionado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.VALES_TIENDATableAdapter = New AydaraTPV.dsValesTiendaTableAdapters.VALES_TIENDATableAdapter
        Me.NavValesTienda = New DevExpress.XtraEditors.ControlNavigator
        CType(Me.VALESTIENDABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsValesTienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgVales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvVales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VALESTIENDABindingSource
        '
        Me.VALESTIENDABindingSource.DataMember = "VALES_TIENDA"
        Me.VALESTIENDABindingSource.DataSource = Me.DsValesTienda
        '
        'DsValesTienda
        '
        Me.DsValesTienda.DataSetName = "dsValesTienda"
        Me.DsValesTienda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgVales
        '
        Me.dgVales.DataSource = Me.VALESTIENDABindingSource
        Me.dgVales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgVales.Location = New System.Drawing.Point(0, 0)
        Me.dgVales.MainView = Me.gvVales
        Me.dgVales.Name = "dgVales"
        Me.dgVales.Size = New System.Drawing.Size(792, 515)
        Me.dgVales.TabIndex = 1
        Me.dgVales.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvVales})
        '
        'gvVales
        '
        Me.gvVales.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoTienda, Me.colCodigoVale, Me.colFechaVale, Me.colNombre, Me.colConcepto, Me.colImporte, Me.colSeleccionado})
        Me.gvVales.GridControl = Me.dgVales
        Me.gvVales.Name = "gvVales"
        Me.gvVales.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvVales.OptionsView.ShowAutoFilterRow = True
        Me.gvVales.OptionsView.ShowGroupPanel = False
        '
        'colCodigoTienda
        '
        Me.colCodigoTienda.Caption = "Tienda"
        Me.colCodigoTienda.FieldName = "CodigoTienda"
        Me.colCodigoTienda.MaxWidth = 60
        Me.colCodigoTienda.MinWidth = 60
        Me.colCodigoTienda.Name = "colCodigoTienda"
        Me.colCodigoTienda.OptionsColumn.AllowEdit = False
        Me.colCodigoTienda.OptionsColumn.AllowFocus = False
        Me.colCodigoTienda.Width = 60
        '
        'colCodigoVale
        '
        Me.colCodigoVale.Caption = "Número"
        Me.colCodigoVale.FieldName = "CodigoVale"
        Me.colCodigoVale.MaxWidth = 100
        Me.colCodigoVale.MinWidth = 100
        Me.colCodigoVale.Name = "colCodigoVale"
        Me.colCodigoVale.OptionsColumn.AllowEdit = False
        Me.colCodigoVale.OptionsColumn.AllowFocus = False
        Me.colCodigoVale.Visible = True
        Me.colCodigoVale.VisibleIndex = 0
        Me.colCodigoVale.Width = 100
        '
        'colFechaVale
        '
        Me.colFechaVale.Caption = "Fecha"
        Me.colFechaVale.FieldName = "FechaVale"
        Me.colFechaVale.MaxWidth = 80
        Me.colFechaVale.MinWidth = 80
        Me.colFechaVale.Name = "colFechaVale"
        Me.colFechaVale.OptionsColumn.AllowEdit = False
        Me.colFechaVale.OptionsColumn.AllowFocus = False
        Me.colFechaVale.Visible = True
        Me.colFechaVale.VisibleIndex = 1
        Me.colFechaVale.Width = 80
        '
        'colNombre
        '
        Me.colNombre.FieldName = "Nombre"
        Me.colNombre.Name = "colNombre"
        Me.colNombre.OptionsColumn.AllowEdit = False
        Me.colNombre.OptionsColumn.AllowFocus = False
        Me.colNombre.Visible = True
        Me.colNombre.VisibleIndex = 2
        '
        'colConcepto
        '
        Me.colConcepto.FieldName = "Concepto"
        Me.colConcepto.Name = "colConcepto"
        Me.colConcepto.OptionsColumn.AllowEdit = False
        Me.colConcepto.OptionsColumn.AllowFocus = False
        Me.colConcepto.Visible = True
        Me.colConcepto.VisibleIndex = 3
        '
        'colImporte
        '
        Me.colImporte.DisplayFormat.FormatString = "{0:c2}"
        Me.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImporte.FieldName = "Importe"
        Me.colImporte.MaxWidth = 90
        Me.colImporte.MinWidth = 90
        Me.colImporte.Name = "colImporte"
        Me.colImporte.OptionsColumn.AllowEdit = False
        Me.colImporte.OptionsColumn.AllowFocus = False
        Me.colImporte.Visible = True
        Me.colImporte.VisibleIndex = 4
        Me.colImporte.Width = 90
        '
        'colSeleccionado
        '
        Me.colSeleccionado.Caption = " "
        Me.colSeleccionado.FieldName = "Seleccionado"
        Me.colSeleccionado.MaxWidth = 40
        Me.colSeleccionado.MinWidth = 40
        Me.colSeleccionado.Name = "colSeleccionado"
        Me.colSeleccionado.Visible = True
        Me.colSeleccionado.VisibleIndex = 5
        Me.colSeleccionado.Width = 40
        '
        'VALES_TIENDATableAdapter
        '
        Me.VALES_TIENDATableAdapter.ClearBeforeFill = True
        '
        'NavValesTienda
        '
        Me.NavValesTienda.Buttons.Append.Visible = False
        Me.NavValesTienda.Buttons.CancelEdit.Visible = False
        Me.NavValesTienda.Buttons.Edit.Visible = False
        Me.NavValesTienda.Buttons.EndEdit.Visible = False
        Me.NavValesTienda.Buttons.Remove.Visible = False
        Me.NavValesTienda.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() {New DevExpress.XtraEditors.NavigatorCustomButton(9)})
        Me.NavValesTienda.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavValesTienda.Location = New System.Drawing.Point(0, 515)
        Me.NavValesTienda.Name = "NavValesTienda"
        Me.NavValesTienda.NavigatableControl = Me.dgVales
        Me.NavValesTienda.Size = New System.Drawing.Size(792, 51)
        Me.NavValesTienda.TabIndex = 19
        Me.NavValesTienda.Text = "ControlNavigator1"
        '
        'FicheroVales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.dgVales)
        Me.Controls.Add(Me.NavValesTienda)
        Me.KeyPreview = True
        Me.Name = "FicheroVales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vales"
        CType(Me.VALESTIENDABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsValesTienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgVales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvVales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgVales As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvVales As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DsValesTienda As AydaraTPV.dsValesTienda
    Friend WithEvents VALESTIENDABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VALES_TIENDATableAdapter As AydaraTPV.dsValesTiendaTableAdapters.VALES_TIENDATableAdapter
    Friend WithEvents colCodigoTienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoVale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFechaVale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNombre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConcepto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSeleccionado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NavValesTienda As DevExpress.XtraEditors.ControlNavigator
End Class
