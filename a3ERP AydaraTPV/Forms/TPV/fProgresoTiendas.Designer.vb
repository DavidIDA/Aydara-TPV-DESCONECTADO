<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fProgresoTiendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fProgresoTiendas))
        Me.gcVentas = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.pbTicketsVentas = New DevExpress.XtraEditors.ProgressBarControl()
        Me.pbAlbaranes = New DevExpress.XtraEditors.ProgressBarControl()
        Me.lblProceso1 = New DevExpress.XtraEditors.LabelControl()
        Me.pbPedidos = New DevExpress.XtraEditors.ProgressBarControl()
        Me.pbTraspasos = New DevExpress.XtraEditors.ProgressBarControl()
        Me.bwVentas = New System.ComponentModel.BackgroundWorker()
        Me.bwAlbaranes = New System.ComponentModel.BackgroundWorker()
        Me.bwTraspasos = New System.ComponentModel.BackgroundWorker()
        Me.bwPedidos = New System.ComponentModel.BackgroundWorker()
        Me.bwTicketsVentas = New System.ComponentModel.BackgroundWorker()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DsTPVRecepcion = New a3ERP_AydaraTPV.dsTPVRecepcion()
        Me.RECEPCIONBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colTIPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCODALM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCRIPCION = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCALM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROGRESO = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gcVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcVentas.SuspendLayout()
        CType(Me.pbTicketsVentas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAlbaranes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPedidos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbTraspasos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTPVRecepcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RECEPCIONBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gcVentas
        '
        Me.gcVentas.Controls.Add(Me.LabelControl1)
        Me.gcVentas.Controls.Add(Me.pbTicketsVentas)
        Me.gcVentas.Controls.Add(Me.pbAlbaranes)
        Me.gcVentas.Controls.Add(Me.lblProceso1)
        Me.gcVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.gcVentas.Location = New System.Drawing.Point(0, 0)
        Me.gcVentas.Name = "gcVentas"
        Me.gcVentas.Size = New System.Drawing.Size(414, 237)
        Me.gcVentas.TabIndex = 0
        Me.gcVentas.Text = "Ventas"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 77)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Albaranes de venta"
        '
        'pbTicketsVentas
        '
        Me.pbTicketsVentas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbTicketsVentas.Location = New System.Drawing.Point(12, 53)
        Me.pbTicketsVentas.Name = "pbTicketsVentas"
        Me.pbTicketsVentas.Properties.ReadOnly = True
        Me.pbTicketsVentas.Properties.ShowTitle = True
        Me.pbTicketsVentas.ShowProgressInTaskBar = True
        Me.pbTicketsVentas.Size = New System.Drawing.Size(390, 18)
        Me.pbTicketsVentas.TabIndex = 5
        '
        'pbAlbaranes
        '
        Me.pbAlbaranes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbAlbaranes.Location = New System.Drawing.Point(12, 96)
        Me.pbAlbaranes.Name = "pbAlbaranes"
        Me.pbAlbaranes.Properties.ReadOnly = True
        Me.pbAlbaranes.Properties.ShowTitle = True
        Me.pbAlbaranes.ShowProgressInTaskBar = True
        Me.pbAlbaranes.Size = New System.Drawing.Size(390, 18)
        Me.pbAlbaranes.TabIndex = 2
        '
        'lblProceso1
        '
        Me.lblProceso1.Location = New System.Drawing.Point(12, 34)
        Me.lblProceso1.Name = "lblProceso1"
        Me.lblProceso1.Size = New System.Drawing.Size(71, 13)
        Me.lblProceso1.TabIndex = 0
        Me.lblProceso1.Text = "Ventas tiendas"
        '
        'pbPedidos
        '
        Me.pbPedidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbPedidos.Location = New System.Drawing.Point(12, 24)
        Me.pbPedidos.Name = "pbPedidos"
        Me.pbPedidos.Properties.ReadOnly = True
        Me.pbPedidos.Properties.ShowTitle = True
        Me.pbPedidos.ShowProgressInTaskBar = True
        Me.pbPedidos.Size = New System.Drawing.Size(390, 18)
        Me.pbPedidos.TabIndex = 4
        '
        'pbTraspasos
        '
        Me.pbTraspasos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbTraspasos.Location = New System.Drawing.Point(12, 24)
        Me.pbTraspasos.Name = "pbTraspasos"
        Me.pbTraspasos.Properties.ReadOnly = True
        Me.pbTraspasos.Properties.ShowTitle = True
        Me.pbTraspasos.ShowProgressInTaskBar = True
        Me.pbTraspasos.Size = New System.Drawing.Size(390, 18)
        Me.pbTraspasos.TabIndex = 3
        '
        'bwVentas
        '
        Me.bwVentas.WorkerReportsProgress = True
        Me.bwVentas.WorkerSupportsCancellation = True
        '
        'bwAlbaranes
        '
        Me.bwAlbaranes.WorkerReportsProgress = True
        Me.bwAlbaranes.WorkerSupportsCancellation = True
        '
        'bwTraspasos
        '
        Me.bwTraspasos.WorkerReportsProgress = True
        Me.bwTraspasos.WorkerSupportsCancellation = True
        '
        'bwPedidos
        '
        Me.bwPedidos.WorkerReportsProgress = True
        Me.bwPedidos.WorkerSupportsCancellation = True
        '
        'bwTicketsVentas
        '
        Me.bwTicketsVentas.WorkerReportsProgress = True
        Me.bwTicketsVentas.WorkerSupportsCancellation = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.pbPedidos)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 183)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(414, 54)
        Me.GroupControl1.TabIndex = 5
        Me.GroupControl1.Text = "Pedidos"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.pbTraspasos)
        Me.GroupControl2.Location = New System.Drawing.Point(0, 126)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(414, 57)
        Me.GroupControl2.TabIndex = 6
        Me.GroupControl2.Text = "Traspasos"
        '
        'bttCancelar
        '
        Me.bttCancelar.Image = CType(resources.GetObject("bttCancelar.Image"), System.Drawing.Image)
        Me.bttCancelar.Location = New System.Drawing.Point(317, 243)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(85, 28)
        Me.bttCancelar.TabIndex = 7
        Me.bttCancelar.Text = "Cancelar"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.RECEPCIONBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(12, 277)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(390, 164)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTIPO, Me.colCODALM, Me.colDESCRIPCION, Me.colDESCALM, Me.colPROGRESO})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'DsTPVRecepcion
        '
        Me.DsTPVRecepcion.DataSetName = "dsTPVRecepcion"
        Me.DsTPVRecepcion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RECEPCIONBindingSource
        '
        Me.RECEPCIONBindingSource.DataMember = "RECEPCION"
        Me.RECEPCIONBindingSource.DataSource = Me.DsTPVRecepcion
        Me.RECEPCIONBindingSource.Filter = "IMPORTAR = 1"
        '
        'colTIPO
        '
        Me.colTIPO.FieldName = "TIPO"
        Me.colTIPO.Name = "colTIPO"
        Me.colTIPO.Visible = True
        Me.colTIPO.VisibleIndex = 0
        '
        'colCODALM
        '
        Me.colCODALM.FieldName = "CODALM"
        Me.colCODALM.Name = "colCODALM"
        Me.colCODALM.Visible = True
        Me.colCODALM.VisibleIndex = 1
        '
        'colDESCRIPCION
        '
        Me.colDESCRIPCION.FieldName = "DESCRIPCION"
        Me.colDESCRIPCION.Name = "colDESCRIPCION"
        Me.colDESCRIPCION.Visible = True
        Me.colDESCRIPCION.VisibleIndex = 2
        '
        'colDESCALM
        '
        Me.colDESCALM.FieldName = "DESCALM"
        Me.colDESCALM.Name = "colDESCALM"
        Me.colDESCALM.Visible = True
        Me.colDESCALM.VisibleIndex = 3
        '
        'colPROGRESO
        '
        Me.colPROGRESO.FieldName = "PROGRESO"
        Me.colPROGRESO.Name = "colPROGRESO"
        Me.colPROGRESO.Visible = True
        Me.colPROGRESO.VisibleIndex = 4
        '
        'fProgresoTiendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 453)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.bttCancelar)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.gcVentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fProgresoTiendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Progreso actualización tiendas"
        CType(Me.gcVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcVentas.ResumeLayout(False)
        Me.gcVentas.PerformLayout()
        CType(Me.pbTicketsVentas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAlbaranes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPedidos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbTraspasos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTPVRecepcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RECEPCIONBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcVentas As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblProceso1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bwVentas As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbTicketsVentas As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents pbPedidos As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents pbTraspasos As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents pbAlbaranes As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents bwAlbaranes As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwTraspasos As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwPedidos As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwTicketsVentas As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents RECEPCIONBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsTPVRecepcion As a3ERP_AydaraTPV.dsTPVRecepcion
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colTIPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCODALM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCRIPCION As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCALM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROGRESO As DevExpress.XtraGrid.Columns.GridColumn
End Class
