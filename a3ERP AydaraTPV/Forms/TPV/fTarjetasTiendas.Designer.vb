<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fTarjetasTiendas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fTarjetasTiendas))
        Me.dgTarjetas = New DevExpress.XtraGrid.GridControl()
        Me.IDATARJETASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsTarjetas = New a3ERP_AydaraTPV.dsTarjetas()
        Me.gvTarjetas = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
        Me.colNUMTARJETA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colBLOQUEADO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.CheckEdit = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colDESCCLI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFECCAD = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colIMPRESA = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPUNTOSCANJE = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPUNTOSSALDO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colCODCLI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.bttCODCLI = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colNOMCLI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDIRCLI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colDTOCLI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPOBCLI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colPOVCLI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colNIFCLI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTELCLI = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colTELCLI2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.colFOTO = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
        Me.imgFoto = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.gcOpciones = New DevExpress.XtraEditors.GroupControl()
        Me.bttImportar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttExportarExcel = New DevExpress.XtraEditors.SimpleButton()
        Me.bttImprimir = New DevExpress.XtraEditors.SimpleButton()
        Me.bttGuardar = New DevExpress.XtraEditors.SimpleButton()
        Me.bttCancelar = New DevExpress.XtraEditors.SimpleButton()
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        Me.gridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
        CType(Me.dgTarjetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IDATARJETASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsTarjetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvTarjetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bttCODCLI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgTarjetas
        '
        Me.dgTarjetas.DataSource = Me.IDATARJETASBindingSource
        Me.dgTarjetas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTarjetas.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.dgTarjetas.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.dgTarjetas.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.dgTarjetas.EmbeddedNavigator.TextStringFormat = "Tarjeta {0} de {1}"
        Me.dgTarjetas.Location = New System.Drawing.Point(0, 0)
        Me.dgTarjetas.MainView = Me.gvTarjetas
        Me.dgTarjetas.Name = "dgTarjetas"
        Me.dgTarjetas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.bttCODCLI, Me.CheckEdit, Me.imgFoto})
        Me.dgTarjetas.Size = New System.Drawing.Size(784, 484)
        Me.dgTarjetas.TabIndex = 6
        Me.dgTarjetas.UseEmbeddedNavigator = True
        Me.dgTarjetas.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvTarjetas})
        '
        'IDATARJETASBindingSource
        '
        Me.IDATARJETASBindingSource.DataMember = "IDA_TARJETAS"
        Me.IDATARJETASBindingSource.DataSource = Me.DsTarjetas
        '
        'DsTarjetas
        '
        Me.DsTarjetas.DataSetName = "dsTarjetas"
        Me.DsTarjetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gvTarjetas
        '
        Me.gvTarjetas.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand3})
        Me.gvTarjetas.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colBLOQUEADO, Me.colCODCLI, Me.colDESCCLI, Me.colDIRCLI, Me.colDTOCLI, Me.colFECCAD, Me.colNIFCLI, Me.colNOMCLI, Me.colNUMTARJETA, Me.colPOBCLI, Me.colPOVCLI, Me.colTELCLI, Me.colTELCLI2, Me.colIMPRESA, Me.colPUNTOSCANJE, Me.colPUNTOSSALDO, Me.colFOTO})
        Me.gvTarjetas.GridControl = Me.dgTarjetas
        Me.gvTarjetas.Name = "gvTarjetas"
        Me.gvTarjetas.OptionsCustomization.AllowRowSizing = True
        Me.gvTarjetas.OptionsFind.AlwaysVisible = True
        Me.gvTarjetas.OptionsNavigation.EnterMoveNextColumn = True
        Me.gvTarjetas.OptionsSelection.MultiSelect = True
        Me.gvTarjetas.OptionsView.EnableAppearanceEvenRow = True
        Me.gvTarjetas.OptionsView.EnableAppearanceOddRow = True
        Me.gvTarjetas.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.gvTarjetas.OptionsView.ShowGroupPanel = False
        '
        'colNUMTARJETA
        '
        Me.colNUMTARJETA.Caption = "Nº Tarjeta"
        Me.colNUMTARJETA.FieldName = "NUMTARJETA"
        Me.colNUMTARJETA.Name = "colNUMTARJETA"
        Me.colNUMTARJETA.Visible = True
        Me.colNUMTARJETA.Width = 59
        '
        'colBLOQUEADO
        '
        Me.colBLOQUEADO.Caption = "Bloqueada"
        Me.colBLOQUEADO.ColumnEdit = Me.CheckEdit
        Me.colBLOQUEADO.FieldName = "BLOQUEADO"
        Me.colBLOQUEADO.Name = "colBLOQUEADO"
        Me.colBLOQUEADO.Visible = True
        Me.colBLOQUEADO.Width = 69
        '
        'CheckEdit
        '
        Me.CheckEdit.AutoHeight = False
        Me.CheckEdit.Caption = "Check"
        Me.CheckEdit.Name = "CheckEdit"
        Me.CheckEdit.ValueChecked = "T"
        Me.CheckEdit.ValueUnchecked = "F"
        '
        'colDESCCLI
        '
        Me.colDESCCLI.Caption = "%Dto"
        Me.colDESCCLI.FieldName = "DESCCLI"
        Me.colDESCCLI.Name = "colDESCCLI"
        Me.colDESCCLI.Visible = True
        Me.colDESCCLI.Width = 37
        '
        'colFECCAD
        '
        Me.colFECCAD.Caption = "Caducidad"
        Me.colFECCAD.FieldName = "FECCAD"
        Me.colFECCAD.Name = "colFECCAD"
        Me.colFECCAD.Visible = True
        Me.colFECCAD.Width = 59
        '
        'colIMPRESA
        '
        Me.colIMPRESA.Caption = "Impresa"
        Me.colIMPRESA.ColumnEdit = Me.CheckEdit
        Me.colIMPRESA.FieldName = "IMPRESA"
        Me.colIMPRESA.Name = "colIMPRESA"
        Me.colIMPRESA.Visible = True
        Me.colIMPRESA.Width = 58
        '
        'colPUNTOSCANJE
        '
        Me.colPUNTOSCANJE.Caption = "Ptos.Canjeados"
        Me.colPUNTOSCANJE.FieldName = "PUNTOSCANJE"
        Me.colPUNTOSCANJE.Name = "colPUNTOSCANJE"
        Me.colPUNTOSCANJE.Visible = True
        Me.colPUNTOSCANJE.Width = 85
        '
        'colPUNTOSSALDO
        '
        Me.colPUNTOSSALDO.Caption = "Ptos.Saldo"
        Me.colPUNTOSSALDO.FieldName = "PUNTOSSALDO"
        Me.colPUNTOSSALDO.Name = "colPUNTOSSALDO"
        Me.colPUNTOSSALDO.Visible = True
        Me.colPUNTOSSALDO.Width = 67
        '
        'colCODCLI
        '
        Me.colCODCLI.Caption = "Cliente"
        Me.colCODCLI.ColumnEdit = Me.bttCODCLI
        Me.colCODCLI.FieldName = "CODCLI"
        Me.colCODCLI.Name = "colCODCLI"
        Me.colCODCLI.Visible = True
        Me.colCODCLI.Width = 87
        '
        'bttCODCLI
        '
        Me.bttCODCLI.AutoHeight = False
        Me.bttCODCLI.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.bttCODCLI.Name = "bttCODCLI"
        '
        'colNOMCLI
        '
        Me.colNOMCLI.Caption = "Nombre"
        Me.colNOMCLI.FieldName = "NOMCLI"
        Me.colNOMCLI.Name = "colNOMCLI"
        Me.colNOMCLI.Visible = True
        Me.colNOMCLI.Width = 169
        '
        'colDIRCLI
        '
        Me.colDIRCLI.Caption = "Dirección"
        Me.colDIRCLI.FieldName = "DIRCLI"
        Me.colDIRCLI.Name = "colDIRCLI"
        Me.colDIRCLI.Visible = True
        Me.colDIRCLI.Width = 112
        '
        'colDTOCLI
        '
        Me.colDTOCLI.Caption = "C.Postal"
        Me.colDTOCLI.FieldName = "DTOCLI"
        Me.colDTOCLI.Name = "colDTOCLI"
        Me.colDTOCLI.Visible = True
        Me.colDTOCLI.Width = 49
        '
        'colPOBCLI
        '
        Me.colPOBCLI.Caption = "Población"
        Me.colPOBCLI.FieldName = "POBCLI"
        Me.colPOBCLI.Name = "colPOBCLI"
        Me.colPOBCLI.Visible = True
        Me.colPOBCLI.Width = 54
        '
        'colPOVCLI
        '
        Me.colPOVCLI.Caption = "Provincia"
        Me.colPOVCLI.FieldName = "POVCLI"
        Me.colPOVCLI.Name = "colPOVCLI"
        Me.colPOVCLI.Visible = True
        Me.colPOVCLI.Width = 52
        '
        'colNIFCLI
        '
        Me.colNIFCLI.Caption = "NIF"
        Me.colNIFCLI.FieldName = "NIFCLI"
        Me.colNIFCLI.Name = "colNIFCLI"
        Me.colNIFCLI.Visible = True
        Me.colNIFCLI.Width = 40
        '
        'colTELCLI
        '
        Me.colTELCLI.Caption = "Teléfono"
        Me.colTELCLI.FieldName = "TELCLI"
        Me.colTELCLI.Name = "colTELCLI"
        Me.colTELCLI.Visible = True
        Me.colTELCLI.Width = 51
        '
        'colTELCLI2
        '
        Me.colTELCLI2.Caption = "Teléfono2"
        Me.colTELCLI2.FieldName = "TELCLI2"
        Me.colTELCLI2.Name = "colTELCLI2"
        Me.colTELCLI2.Visible = True
        Me.colTELCLI2.Width = 57
        '
        'colFOTO
        '
        Me.colFOTO.Caption = "Foto"
        Me.colFOTO.ColumnEdit = Me.imgFoto
        Me.colFOTO.FieldName = "FOTO"
        Me.colFOTO.Name = "colFOTO"
        Me.colFOTO.Visible = True
        '
        'imgFoto
        '
        Me.imgFoto.Name = "imgFoto"
        Me.imgFoto.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'gcOpciones
        '
        Me.gcOpciones.Controls.Add(Me.bttImportar)
        Me.gcOpciones.Controls.Add(Me.bttExportarExcel)
        Me.gcOpciones.Controls.Add(Me.bttImprimir)
        Me.gcOpciones.Controls.Add(Me.bttGuardar)
        Me.gcOpciones.Controls.Add(Me.bttCancelar)
        Me.gcOpciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gcOpciones.Location = New System.Drawing.Point(0, 484)
        Me.gcOpciones.Name = "gcOpciones"
        Me.gcOpciones.Size = New System.Drawing.Size(784, 78)
        Me.gcOpciones.TabIndex = 5
        Me.gcOpciones.Text = "Opciones"
        '
        'bttImportar
        '
        Me.bttImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttImportar.Image = CType(resources.GetObject("bttImportar.Image"), System.Drawing.Image)
        Me.bttImportar.Location = New System.Drawing.Point(260, 38)
        Me.bttImportar.Name = "bttImportar"
        Me.bttImportar.Size = New System.Drawing.Size(117, 28)
        Me.bttImportar.TabIndex = 92
        Me.bttImportar.Text = "Importar datos"
        '
        'bttExportarExcel
        '
        Me.bttExportarExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.bttExportarExcel.Image = CType(resources.GetObject("bttExportarExcel.Image"), System.Drawing.Image)
        Me.bttExportarExcel.Location = New System.Drawing.Point(12, 38)
        Me.bttExportarExcel.Name = "bttExportarExcel"
        Me.bttExportarExcel.Size = New System.Drawing.Size(119, 28)
        Me.bttExportarExcel.TabIndex = 91
        Me.bttExportarExcel.Text = "Exportar a excel"
        '
        'bttImprimir
        '
        Me.bttImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bttImprimir.Image = CType(resources.GetObject("bttImprimir.Image"), System.Drawing.Image)
        Me.bttImprimir.Location = New System.Drawing.Point(137, 38)
        Me.bttImprimir.Name = "bttImprimir"
        Me.bttImprimir.Size = New System.Drawing.Size(117, 28)
        Me.bttImprimir.TabIndex = 2
        Me.bttImprimir.Text = "Imprimir tarjetas"
        '
        'bttGuardar
        '
        Me.bttGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttGuardar.Enabled = False
        Me.bttGuardar.Image = CType(resources.GetObject("bttGuardar.Image"), System.Drawing.Image)
        Me.bttGuardar.Location = New System.Drawing.Point(676, 38)
        Me.bttGuardar.Name = "bttGuardar"
        Me.bttGuardar.Size = New System.Drawing.Size(96, 28)
        Me.bttGuardar.TabIndex = 0
        Me.bttGuardar.Text = "(F3) &Guardar"
        '
        'bttCancelar
        '
        Me.bttCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bttCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttCancelar.Enabled = False
        Me.bttCancelar.Image = CType(resources.GetObject("bttCancelar.Image"), System.Drawing.Image)
        Me.bttCancelar.Location = New System.Drawing.Point(544, 38)
        Me.bttCancelar.Name = "bttCancelar"
        Me.bttCancelar.Size = New System.Drawing.Size(126, 28)
        Me.bttCancelar.TabIndex = 1
        Me.bttCancelar.Text = "(ALT+F3) &Cancelar"
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Datos tarjeta"
        Me.GridBand1.Columns.Add(Me.colNUMTARJETA)
        Me.GridBand1.Columns.Add(Me.colBLOQUEADO)
        Me.GridBand1.Columns.Add(Me.colDESCCLI)
        Me.GridBand1.Columns.Add(Me.colFECCAD)
        Me.GridBand1.Columns.Add(Me.colIMPRESA)
        Me.GridBand1.Columns.Add(Me.colPUNTOSCANJE)
        Me.GridBand1.Columns.Add(Me.colPUNTOSSALDO)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.VisibleIndex = 0
        Me.GridBand1.Width = 434
        '
        'gridBand3
        '
        Me.gridBand3.Caption = "Datos cliente"
        Me.gridBand3.Columns.Add(Me.colCODCLI)
        Me.gridBand3.Columns.Add(Me.colNOMCLI)
        Me.gridBand3.Columns.Add(Me.colDIRCLI)
        Me.gridBand3.Columns.Add(Me.colDTOCLI)
        Me.gridBand3.Columns.Add(Me.colPOBCLI)
        Me.gridBand3.Columns.Add(Me.colPOVCLI)
        Me.gridBand3.Columns.Add(Me.colNIFCLI)
        Me.gridBand3.Columns.Add(Me.colTELCLI)
        Me.gridBand3.Columns.Add(Me.colTELCLI2)
        Me.gridBand3.Name = "gridBand3"
        Me.gridBand3.VisibleIndex = 1
        Me.gridBand3.Width = 671
        '
        'fTarjetasTiendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.dgTarjetas)
        Me.Controls.Add(Me.gcOpciones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "fTarjetasTiendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tarjetas tienda"
        CType(Me.dgTarjetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IDATARJETASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsTarjetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvTarjetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bttCODCLI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgTarjetas As DevExpress.XtraGrid.GridControl
    Friend WithEvents gcOpciones As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bttImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bttCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DsTarjetas As a3ERP_AydaraTPV.dsTarjetas
    Friend WithEvents IDATARJETASBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gvTarjetas As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents colNUMTARJETA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCODCLI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNOMCLI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDIRCLI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDTOCLI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPOBCLI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPOVCLI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colNIFCLI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTELCLI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colTELCLI2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colBLOQUEADO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDESCCLI As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colFECCAD As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colIMPRESA As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPUNTOSCANJE As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colPUNTOSSALDO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bttCODCLI As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents CheckEdit As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colFOTO As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents bttExportarExcel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents imgFoto As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents bttImportar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
End Class
