<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fHistorico
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.gvDetalle = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colFECHA1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSERIE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNUMDOC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colREFERENCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBULTOS_Detalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPAQUETES_Detalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUNIDADES_Detalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRCMONEDA_Detalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESC1_Detalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESC2_Detalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESC3_Detalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESC4_Detalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBASE_Detalle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dgHistorico = New DevExpress.XtraGrid.GridControl()
        Me.VENTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsHistorico = New dsHistorico()
        Me.gvHistorico = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCODART = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCLIN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFECHA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBULTOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPAQUETES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUNIDADES = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPRCMONEDA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESC1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESC2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESC3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESC4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBASE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDESCLIN_Detalle = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VENTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvHistorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvDetalle
        '
        Me.gvDetalle.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colFECHA1, Me.colSERIE, Me.colNUMDOC, Me.colREFERENCIA, Me.colDESCLIN_Detalle, Me.colBULTOS_Detalle, Me.colPAQUETES_Detalle, Me.colUNIDADES_Detalle, Me.colPRCMONEDA_Detalle, Me.colDESC1_Detalle, Me.colDESC2_Detalle, Me.colDESC3_Detalle, Me.colDESC4_Detalle, Me.colBASE_Detalle})
        Me.gvDetalle.GridControl = Me.dgHistorico
        Me.gvDetalle.Name = "gvDetalle"
        Me.gvDetalle.OptionsBehavior.Editable = False
        Me.gvDetalle.OptionsView.ShowGroupPanel = False
        Me.gvDetalle.ViewCaption = "Detalle de movimientos"
        '
        'colFECHA1
        '
        Me.colFECHA1.Caption = "Fecha"
        Me.colFECHA1.FieldName = "FECHA"
        Me.colFECHA1.Name = "colFECHA1"
        Me.colFECHA1.Visible = True
        Me.colFECHA1.VisibleIndex = 0
        '
        'colSERIE
        '
        Me.colSERIE.Caption = "Serie"
        Me.colSERIE.FieldName = "SERIE"
        Me.colSERIE.Name = "colSERIE"
        Me.colSERIE.Visible = True
        Me.colSERIE.VisibleIndex = 1
        '
        'colNUMDOC
        '
        Me.colNUMDOC.Caption = "Documento"
        Me.colNUMDOC.FieldName = "NUMDOC"
        Me.colNUMDOC.Name = "colNUMDOC"
        Me.colNUMDOC.Visible = True
        Me.colNUMDOC.VisibleIndex = 2
        '
        'colREFERENCIA
        '
        Me.colREFERENCIA.Caption = "Referencia"
        Me.colREFERENCIA.FieldName = "REFERENCIA"
        Me.colREFERENCIA.Name = "colREFERENCIA"
        '
        'colBULTOS_Detalle
        '
        Me.colBULTOS_Detalle.Caption = "Bultos"
        Me.colBULTOS_Detalle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBULTOS_Detalle.FieldName = "BULTOS"
        Me.colBULTOS_Detalle.Name = "colBULTOS_Detalle"
        '
        'colPAQUETES_Detalle
        '
        Me.colPAQUETES_Detalle.Caption = "Paquetes"
        Me.colPAQUETES_Detalle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPAQUETES_Detalle.FieldName = "PAQUETES"
        Me.colPAQUETES_Detalle.Name = "colPAQUETES_Detalle"
        '
        'colUNIDADES_Detalle
        '
        Me.colUNIDADES_Detalle.AppearanceHeader.Options.UseTextOptions = True
        Me.colUNIDADES_Detalle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUNIDADES_Detalle.Caption = "Unidades"
        Me.colUNIDADES_Detalle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUNIDADES_Detalle.FieldName = "UNIDADES"
        Me.colUNIDADES_Detalle.Name = "colUNIDADES_Detalle"
        Me.colUNIDADES_Detalle.Visible = True
        Me.colUNIDADES_Detalle.VisibleIndex = 3
        '
        'colPRCMONEDA_Detalle
        '
        Me.colPRCMONEDA_Detalle.AppearanceHeader.Options.UseTextOptions = True
        Me.colPRCMONEDA_Detalle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPRCMONEDA_Detalle.Caption = "Precio"
        Me.colPRCMONEDA_Detalle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPRCMONEDA_Detalle.FieldName = "PRCMONEDA"
        Me.colPRCMONEDA_Detalle.Name = "colPRCMONEDA_Detalle"
        Me.colPRCMONEDA_Detalle.Visible = True
        Me.colPRCMONEDA_Detalle.VisibleIndex = 4
        '
        'colDESC1_Detalle
        '
        Me.colDESC1_Detalle.AppearanceHeader.Options.UseTextOptions = True
        Me.colDESC1_Detalle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDESC1_Detalle.Caption = "Dto.1"
        Me.colDESC1_Detalle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDESC1_Detalle.FieldName = "DESC1"
        Me.colDESC1_Detalle.Name = "colDESC1_Detalle"
        Me.colDESC1_Detalle.Visible = True
        Me.colDESC1_Detalle.VisibleIndex = 5
        '
        'colDESC2_Detalle
        '
        Me.colDESC2_Detalle.AppearanceHeader.Options.UseTextOptions = True
        Me.colDESC2_Detalle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDESC2_Detalle.Caption = "Dto.2"
        Me.colDESC2_Detalle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDESC2_Detalle.FieldName = "DESC2"
        Me.colDESC2_Detalle.Name = "colDESC2_Detalle"
        Me.colDESC2_Detalle.Visible = True
        Me.colDESC2_Detalle.VisibleIndex = 6
        '
        'colDESC3_Detalle
        '
        Me.colDESC3_Detalle.Caption = "Dto.3"
        Me.colDESC3_Detalle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDESC3_Detalle.FieldName = "DESC3"
        Me.colDESC3_Detalle.Name = "colDESC3_Detalle"
        '
        'colDESC4_Detalle
        '
        Me.colDESC4_Detalle.Caption = "Desc.4"
        Me.colDESC4_Detalle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDESC4_Detalle.FieldName = "DESC4"
        Me.colDESC4_Detalle.Name = "colDESC4_Detalle"
        '
        'colBASE_Detalle
        '
        Me.colBASE_Detalle.AppearanceHeader.Options.UseTextOptions = True
        Me.colBASE_Detalle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colBASE_Detalle.Caption = "Importe"
        Me.colBASE_Detalle.DisplayFormat.FormatString = "{0:c2}"
        Me.colBASE_Detalle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBASE_Detalle.FieldName = "BASE"
        Me.colBASE_Detalle.Name = "colBASE_Detalle"
        Me.colBASE_Detalle.Visible = True
        Me.colBASE_Detalle.VisibleIndex = 7
        '
        'dgHistorico
        '
        Me.dgHistorico.DataSource = Me.VENTASBindingSource
        Me.dgHistorico.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.gvDetalle
        GridLevelNode1.RelationName = "VENTAS_DETALLE_VENTAS"
        Me.dgHistorico.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.dgHistorico.Location = New System.Drawing.Point(0, 0)
        Me.dgHistorico.MainView = Me.gvHistorico
        Me.dgHistorico.Name = "dgHistorico"
        Me.dgHistorico.Size = New System.Drawing.Size(784, 362)
        Me.dgHistorico.TabIndex = 1
        Me.dgHistorico.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvHistorico, Me.gvDetalle})
        '
        'VENTASBindingSource
        '
        Me.VENTASBindingSource.DataMember = "VENTAS"
        Me.VENTASBindingSource.DataSource = Me.DsHistorico
        '
        'DsHistorico
        '
        Me.DsHistorico.DataSetName = "dsHistorico"
        Me.DsHistorico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvHistorico
        '
        Me.gvHistorico.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCODART, Me.colDESCLIN, Me.colFECHA, Me.colBULTOS, Me.colPAQUETES, Me.colUNIDADES, Me.colPRCMONEDA, Me.colDESC1, Me.colDESC2, Me.colDESC3, Me.colDESC4, Me.colBASE})
        Me.gvHistorico.GridControl = Me.dgHistorico
        Me.gvHistorico.Name = "gvHistorico"
        Me.gvHistorico.OptionsBehavior.Editable = False
        Me.gvHistorico.OptionsView.ShowGroupPanel = False
        '
        'colCODART
        '
        Me.colCODART.Caption = "Artículo"
        Me.colCODART.FieldName = "CODART"
        Me.colCODART.Name = "colCODART"
        Me.colCODART.Visible = True
        Me.colCODART.VisibleIndex = 0
        Me.colCODART.Width = 95
        '
        'colDESCLIN
        '
        Me.colDESCLIN.Caption = "Descripción"
        Me.colDESCLIN.FieldName = "DESCLIN"
        Me.colDESCLIN.Name = "colDESCLIN"
        Me.colDESCLIN.Visible = True
        Me.colDESCLIN.VisibleIndex = 1
        Me.colDESCLIN.Width = 237
        '
        'colFECHA
        '
        Me.colFECHA.Caption = "Fecha"
        Me.colFECHA.FieldName = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.Visible = True
        Me.colFECHA.VisibleIndex = 2
        Me.colFECHA.Width = 86
        '
        'colBULTOS
        '
        Me.colBULTOS.Caption = "Bultos"
        Me.colBULTOS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBULTOS.FieldName = "BULTOS"
        Me.colBULTOS.Name = "colBULTOS"
        '
        'colPAQUETES
        '
        Me.colPAQUETES.Caption = "Paquetes"
        Me.colPAQUETES.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPAQUETES.FieldName = "PAQUETES"
        Me.colPAQUETES.Name = "colPAQUETES"
        '
        'colUNIDADES
        '
        Me.colUNIDADES.AppearanceHeader.Options.UseTextOptions = True
        Me.colUNIDADES.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUNIDADES.Caption = "Unidades"
        Me.colUNIDADES.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUNIDADES.FieldName = "UNIDADES"
        Me.colUNIDADES.Name = "colUNIDADES"
        Me.colUNIDADES.Visible = True
        Me.colUNIDADES.VisibleIndex = 3
        Me.colUNIDADES.Width = 66
        '
        'colPRCMONEDA
        '
        Me.colPRCMONEDA.AppearanceHeader.Options.UseTextOptions = True
        Me.colPRCMONEDA.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPRCMONEDA.Caption = "Precio"
        Me.colPRCMONEDA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPRCMONEDA.FieldName = "PRCMONEDA"
        Me.colPRCMONEDA.Name = "colPRCMONEDA"
        Me.colPRCMONEDA.Visible = True
        Me.colPRCMONEDA.VisibleIndex = 4
        Me.colPRCMONEDA.Width = 66
        '
        'colDESC1
        '
        Me.colDESC1.AppearanceHeader.Options.UseTextOptions = True
        Me.colDESC1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDESC1.Caption = "Dto.1"
        Me.colDESC1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDESC1.FieldName = "DESC1"
        Me.colDESC1.Name = "colDESC1"
        Me.colDESC1.Visible = True
        Me.colDESC1.VisibleIndex = 5
        Me.colDESC1.Width = 66
        '
        'colDESC2
        '
        Me.colDESC2.AppearanceHeader.Options.UseTextOptions = True
        Me.colDESC2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colDESC2.Caption = "Dto.2"
        Me.colDESC2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDESC2.FieldName = "DESC2"
        Me.colDESC2.Name = "colDESC2"
        Me.colDESC2.Visible = True
        Me.colDESC2.VisibleIndex = 6
        Me.colDESC2.Width = 66
        '
        'colDESC3
        '
        Me.colDESC3.Caption = "Dto.3"
        Me.colDESC3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDESC3.FieldName = "DESC3"
        Me.colDESC3.Name = "colDESC3"
        '
        'colDESC4
        '
        Me.colDESC4.Caption = "Dto.4"
        Me.colDESC4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDESC4.FieldName = "DESC4"
        Me.colDESC4.Name = "colDESC4"
        '
        'colBASE
        '
        Me.colBASE.AppearanceHeader.Options.UseTextOptions = True
        Me.colBASE.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colBASE.Caption = "Importe"
        Me.colBASE.DisplayFormat.FormatString = "{0:c2}"
        Me.colBASE.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBASE.FieldName = "BASE"
        Me.colBASE.Name = "colBASE"
        Me.colBASE.Visible = True
        Me.colBASE.VisibleIndex = 7
        Me.colBASE.Width = 84
        '
        'colDESCLIN_Detalle
        '
        Me.colDESCLIN_Detalle.Caption = "Descripción"
        Me.colDESCLIN_Detalle.FieldName = "DESCLIN"
        Me.colDESCLIN_Detalle.Name = "colDESCLIN_Detalle"
        '
        'fHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 362)
        Me.Controls.Add(Me.dgHistorico)
        Me.MinimizeBox = False
        Me.Name = "fHistorico"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Histórico de albaranes"
        Me.TopMost = True
        CType(Me.gvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VENTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvHistorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VENTASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsHistorico As dsHistorico
    Friend WithEvents dgHistorico As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvDetalle As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFECHA1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSERIE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNUMDOC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colREFERENCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBULTOS_Detalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAQUETES_Detalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNIDADES_Detalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRCMONEDA_Detalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESC1_Detalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESC2_Detalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESC3_Detalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESC4_Detalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBASE_Detalle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gvHistorico As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCODART As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCLIN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFECHA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBULTOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPAQUETES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUNIDADES As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPRCMONEDA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESC1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESC2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESC3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESC4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBASE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDESCLIN_Detalle As DevExpress.XtraGrid.Columns.GridColumn
End Class
