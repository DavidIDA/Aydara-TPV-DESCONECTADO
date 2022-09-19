<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PendientesCobro
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
        Me.dgPendientesCobro = New DevExpress.XtraGrid.GridControl
        Me.PENDIENTESCOBROBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPendientesCobro = New AydaraTPV.dsPendientesCobro
        Me.gvPendientesCobro = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigoCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoTienda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoCaja = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodigoTicket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImporteTicket = New DevExpress.XtraGrid.Columns.GridColumn
        Me.maskImporte = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
        Me.colImporteCobrado = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NombreCliente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NavListadoPendientesCobro = New DevExpress.XtraEditors.DataNavigator
        Me.PENDIENTES_COBROTableAdapter = New AydaraTPV.dsPendientesCobroTableAdapters.PENDIENTES_COBROTableAdapter
        CType(Me.dgPendientesCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PENDIENTESCOBROBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPendientesCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvPendientesCobro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgPendientesCobro
        '
        Me.dgPendientesCobro.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPendientesCobro.DataSource = Me.PENDIENTESCOBROBindingSource
        Me.dgPendientesCobro.Location = New System.Drawing.Point(0, 0)
        Me.dgPendientesCobro.MainView = Me.gvPendientesCobro
        Me.dgPendientesCobro.Name = "dgPendientesCobro"
        Me.dgPendientesCobro.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.maskImporte})
        Me.dgPendientesCobro.Size = New System.Drawing.Size(792, 527)
        Me.dgPendientesCobro.TabIndex = 0
        Me.dgPendientesCobro.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvPendientesCobro})
        '
        'PENDIENTESCOBROBindingSource
        '
        Me.PENDIENTESCOBROBindingSource.DataMember = "PENDIENTES_COBRO"
        Me.PENDIENTESCOBROBindingSource.DataSource = Me.DsPendientesCobro
        '
        'DsPendientesCobro
        '
        Me.DsPendientesCobro.DataSetName = "dsPendientesCobro"
        Me.DsPendientesCobro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvPendientesCobro
        '
        Me.gvPendientesCobro.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigoCliente, Me.colCodigoTienda, Me.colCodigoCaja, Me.colCodigoTicket, Me.colFecha, Me.colImporteTicket, Me.colImporteCobrado, Me.NombreCliente})
        Me.gvPendientesCobro.GridControl = Me.dgPendientesCobro
        Me.gvPendientesCobro.Name = "gvPendientesCobro"
        Me.gvPendientesCobro.OptionsCustomization.AllowQuickHideColumns = False
        Me.gvPendientesCobro.OptionsView.ShowAutoFilterRow = True
        Me.gvPendientesCobro.OptionsView.ShowGroupPanel = False
        '
        'colCodigoCliente
        '
        Me.colCodigoCliente.FieldName = "CodigoCliente"
        Me.colCodigoCliente.Name = "colCodigoCliente"
        Me.colCodigoCliente.Visible = True
        Me.colCodigoCliente.VisibleIndex = 0
        Me.colCodigoCliente.Width = 89
        '
        'colCodigoTienda
        '
        Me.colCodigoTienda.FieldName = "CodigoTienda"
        Me.colCodigoTienda.Name = "colCodigoTienda"
        Me.colCodigoTienda.Visible = True
        Me.colCodigoTienda.VisibleIndex = 3
        Me.colCodigoTienda.Width = 98
        '
        'colCodigoCaja
        '
        Me.colCodigoCaja.FieldName = "CodigoCaja"
        Me.colCodigoCaja.Name = "colCodigoCaja"
        Me.colCodigoCaja.Visible = True
        Me.colCodigoCaja.VisibleIndex = 2
        Me.colCodigoCaja.Width = 106
        '
        'colCodigoTicket
        '
        Me.colCodigoTicket.Caption = "Numero de Ticket"
        Me.colCodigoTicket.FieldName = "CodigoTicket"
        Me.colCodigoTicket.Name = "colCodigoTicket"
        Me.colCodigoTicket.Visible = True
        Me.colCodigoTicket.VisibleIndex = 4
        Me.colCodigoTicket.Width = 108
        '
        'colFecha
        '
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Visible = True
        Me.colFecha.VisibleIndex = 5
        Me.colFecha.Width = 64
        '
        'colImporteTicket
        '
        Me.colImporteTicket.ColumnEdit = Me.maskImporte
        Me.colImporteTicket.FieldName = "ImporteTicket"
        Me.colImporteTicket.Name = "colImporteTicket"
        Me.colImporteTicket.Visible = True
        Me.colImporteTicket.VisibleIndex = 6
        Me.colImporteTicket.Width = 90
        '
        'maskImporte
        '
        Me.maskImporte.AutoHeight = False
        Me.maskImporte.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.maskImporte.Mask.UseMaskAsDisplayFormat = True
        Me.maskImporte.Name = "maskImporte"
        '
        'colImporteCobrado
        '
        Me.colImporteCobrado.ColumnEdit = Me.maskImporte
        Me.colImporteCobrado.FieldName = "ImporteCobrado"
        Me.colImporteCobrado.Name = "colImporteCobrado"
        Me.colImporteCobrado.Visible = True
        Me.colImporteCobrado.VisibleIndex = 7
        Me.colImporteCobrado.Width = 121
        '
        'NombreCliente
        '
        Me.NombreCliente.Caption = "Nombre Cliente"
        Me.NombreCliente.Name = "NombreCliente"
        Me.NombreCliente.Visible = True
        Me.NombreCliente.VisibleIndex = 1
        Me.NombreCliente.Width = 95
        '
        'NavListadoPendientesCobro
        '
        Me.NavListadoPendientesCobro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NavListadoPendientesCobro.Buttons.Append.Visible = False
        Me.NavListadoPendientesCobro.DataSource = Me.PENDIENTESCOBROBindingSource
        Me.NavListadoPendientesCobro.Location = New System.Drawing.Point(0, 527)
        Me.NavListadoPendientesCobro.Name = "NavListadoPendientesCobro"
        Me.NavListadoPendientesCobro.Size = New System.Drawing.Size(792, 39)
        Me.NavListadoPendientesCobro.TabIndex = 1
        Me.NavListadoPendientesCobro.Text = "DataNavigator1"
        '
        'PENDIENTES_COBROTableAdapter
        '
        Me.PENDIENTES_COBROTableAdapter.ClearBeforeFill = True
        '
        'PendientesCobro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.NavListadoPendientesCobro)
        Me.Controls.Add(Me.dgPendientesCobro)
        Me.KeyPreview = True
        Me.Name = "PendientesCobro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PendientesCobro"
        CType(Me.dgPendientesCobro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PENDIENTESCOBROBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPendientesCobro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvPendientesCobro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maskImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgPendientesCobro As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvPendientesCobro As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NavListadoPendientesCobro As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents DsPendientesCobro As AydaraTPV.dsPendientesCobro
    Friend WithEvents PENDIENTESCOBROBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PENDIENTES_COBROTableAdapter As AydaraTPV.dsPendientesCobroTableAdapters.PENDIENTES_COBROTableAdapter
    Friend WithEvents colCodigoCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoTienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoCaja As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodigoTicket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporteTicket As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporteCobrado As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NombreCliente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents maskImporte As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
End Class
