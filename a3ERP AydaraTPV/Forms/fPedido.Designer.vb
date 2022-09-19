<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fPedido))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.bttTraspaso = New DevExpress.XtraEditors.SimpleButton()
        Me.dgLineas = New DevExpress.XtraGrid.GridControl()
        Me.LINEPEDIBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPedidos = New a3ERP_AydaraTPV.dsPedidos()
        Me.gvLineas = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCODART = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCLIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUNIDADES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSTOCK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUNISERVIDA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnEliminarLineasSinStock = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRellenarCantServir = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LINEPEDIBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnRellenarCantServir)
        Me.PanelControl1.Controls.Add(Me.btnEliminarLineasSinStock)
        Me.PanelControl1.Controls.Add(Me.bttTraspaso)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 500)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(784, 62)
        Me.PanelControl1.TabIndex = 0
        '
        'bttTraspaso
        '
        Me.bttTraspaso.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttTraspaso.Image = CType(resources.GetObject("bttTraspaso.Image"), System.Drawing.Image)
        Me.bttTraspaso.Location = New System.Drawing.Point(655, 13)
        Me.bttTraspaso.Name = "bttTraspaso"
        Me.bttTraspaso.Size = New System.Drawing.Size(117, 37)
        Me.bttTraspaso.TabIndex = 0
        Me.bttTraspaso.Text = "Generar traspaso"
        '
        'dgLineas
        '
        Me.dgLineas.DataSource = Me.LINEPEDIBindingSource
        Me.dgLineas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLineas.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.dgLineas.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgLineas.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgLineas.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgLineas.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.dgLineas.Location = New System.Drawing.Point(0, 0)
        Me.dgLineas.MainView = Me.gvLineas
        Me.dgLineas.Name = "dgLineas"
        Me.dgLineas.Size = New System.Drawing.Size(784, 500)
        Me.dgLineas.TabIndex = 1
        Me.dgLineas.UseEmbeddedNavigator = True
        Me.dgLineas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvLineas})
        '
        'LINEPEDIBindingSource
        '
        Me.LINEPEDIBindingSource.DataMember = "LINEPEDI"
        Me.LINEPEDIBindingSource.DataSource = Me.DsPedidos
        '
        'DsPedidos
        '
        Me.DsPedidos.DataSetName = "dsPedidos"
        Me.DsPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvLineas
        '
        Me.gvLineas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODART, Me.colDESCLIN, Me.colUNIDADES, Me.colSTOCK, Me.colUNISERVIDA})
        Me.gvLineas.GridControl = Me.dgLineas
        Me.gvLineas.Name = "gvLineas"
        Me.gvLineas.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvLineas.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvLineas.OptionsView.ShowGroupPanel = False
        '
        'colCODART
        '
        Me.colCODART.Caption = "Artículo"
        Me.colCODART.FieldName = "CODART"
        Me.colCODART.Name = "colCODART"
        Me.colCODART.OptionsColumn.AllowEdit = False
        Me.colCODART.OptionsColumn.AllowFocus = False
        Me.colCODART.Visible = True
        Me.colCODART.VisibleIndex = 0
        Me.colCODART.Width = 115
        '
        'colDESCLIN
        '
        Me.colDESCLIN.Caption = "Descripción"
        Me.colDESCLIN.FieldName = "DESCLIN"
        Me.colDESCLIN.Name = "colDESCLIN"
        Me.colDESCLIN.OptionsColumn.AllowEdit = False
        Me.colDESCLIN.OptionsColumn.AllowFocus = False
        Me.colDESCLIN.Visible = True
        Me.colDESCLIN.VisibleIndex = 1
        Me.colDESCLIN.Width = 360
        '
        'colUNIDADES
        '
        Me.colUNIDADES.Caption = "Unidades"
        Me.colUNIDADES.FieldName = "UNIDADES"
        Me.colUNIDADES.Name = "colUNIDADES"
        Me.colUNIDADES.OptionsColumn.AllowEdit = False
        Me.colUNIDADES.OptionsColumn.AllowFocus = False
        Me.colUNIDADES.Visible = True
        Me.colUNIDADES.VisibleIndex = 2
        Me.colUNIDADES.Width = 70
        '
        'colSTOCK
        '
        Me.colSTOCK.Caption = "Stock"
        Me.colSTOCK.FieldName = "STOCK"
        Me.colSTOCK.Name = "colSTOCK"
        Me.colSTOCK.OptionsColumn.AllowEdit = False
        Me.colSTOCK.OptionsColumn.AllowFocus = False
        Me.colSTOCK.OptionsColumn.ReadOnly = True
        Me.colSTOCK.Visible = True
        Me.colSTOCK.VisibleIndex = 3
        Me.colSTOCK.Width = 70
        '
        'colUNISERVIDA
        '
        Me.colUNISERVIDA.Caption = "Servir"
        Me.colUNISERVIDA.FieldName = "UNISERVIDA"
        Me.colUNISERVIDA.Name = "colUNISERVIDA"
        Me.colUNISERVIDA.Visible = True
        Me.colUNISERVIDA.VisibleIndex = 4
        Me.colUNISERVIDA.Width = 81
        '
        'btnEliminarLineasSinStock
        '
        Me.btnEliminarLineasSinStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminarLineasSinStock.Image = CType(resources.GetObject("btnEliminarLineasSinStock.Image"), System.Drawing.Image)
        Me.btnEliminarLineasSinStock.Location = New System.Drawing.Point(326, 13)
        Me.btnEliminarLineasSinStock.Name = "btnEliminarLineasSinStock"
        Me.btnEliminarLineasSinStock.Size = New System.Drawing.Size(154, 37)
        Me.btnEliminarLineasSinStock.TabIndex = 1
        Me.btnEliminarLineasSinStock.Text = "Eliminar Lineas Sin Stock"
        '
        'btnRellenarCantServir
        '
        Me.btnRellenarCantServir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRellenarCantServir.Image = CType(resources.GetObject("btnRellenarCantServir.Image"), System.Drawing.Image)
        Me.btnRellenarCantServir.Location = New System.Drawing.Point(492, 13)
        Me.btnRellenarCantServir.Name = "btnRellenarCantServir"
        Me.btnRellenarCantServir.Size = New System.Drawing.Size(150, 37)
        Me.btnRellenarCantServir.TabIndex = 2
        Me.btnRellenarCantServir.Text = "Rellenar Cant. a Servir"
        '
        'fPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgLineas)
        Me.Controls.Add(Me.PanelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fPedido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pedido tienda"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.dgLineas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LINEPEDIBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgLineas As DevExpress.XtraGrid.GridControl
    Friend WithEvents LINEPEDIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPedidos As a3ERP_AydaraTPV.dsPedidos
    Friend WithEvents gvLineas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODART As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCLIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNIDADES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSTOCK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNISERVIDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bttTraspaso As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRellenarCantServir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEliminarLineasSinStock As DevExpress.XtraEditors.SimpleButton
End Class
