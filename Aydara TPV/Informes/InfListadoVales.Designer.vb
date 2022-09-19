<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class InfListadoVales
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfListadoVales))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.bandDetalle = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.Detalle = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.txtImporte = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.txtTotalImporte = New DevExpress.XtraReports.UI.XRLabel
        Me.DsValesTienda1 = New AydaraTPV.dsValesTienda
        Me.VALES_TIENDATableAdapter = New AydaraTPV.dsValesTiendaTableAdapters.VALES_TIENDATableAdapter
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsValesTienda1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'bandDetalle
        '
        Me.bandDetalle.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.bandDetalle.Height = 17
        Me.bandDetalle.Name = "bandDetalle"
        Me.bandDetalle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        resources.ApplyResources(Me.bandDetalle, "bandDetalle")
        '
        'XrTable2
        '
        resources.ApplyResources(Me.XrTable2, "XrTable2")
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.Detalle})
        '
        'Detalle
        '
        Me.Detalle.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell6, Me.XrTableCell8, Me.txtImporte})
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Weight = 1.4993215739484396
        '
        'XrTableCell2
        '
        Me.XrTableCell2.CanGrow = False
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "VALES_TIENDA.CodigoVale", "")})
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        resources.ApplyResources(Me.XrTableCell2, "XrTableCell2")
        Me.XrTableCell2.Weight = 19.358411703239291
        '
        'XrTableCell4
        '
        Me.XrTableCell4.CanGrow = False
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "VALES_TIENDA.FechaVale", "")})
        Me.XrTableCell4.Name = "XrTableCell4"
        resources.ApplyResources(Me.XrTableCell4, "XrTableCell4")
        Me.XrTableCell4.Weight = 22.510188087774281
        '
        'XrTableCell6
        '
        Me.XrTableCell6.CanGrow = False
        Me.XrTableCell6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "VALES_TIENDA.Nombre", "")})
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Weight = 74.477272727272748
        '
        'XrTableCell8
        '
        Me.XrTableCell8.CanGrow = False
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "VALES_TIENDA.Concepto", "")})
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Weight = 66.165621734587262
        '
        'txtImporte
        '
        Me.txtImporte.CanGrow = False
        Me.txtImporte.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "VALES_TIENDA.Importe", "{0:c2}")})
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary1, "XrSummary1")
        Me.txtImporte.Summary = XrSummary1
        resources.ApplyResources(Me.txtImporte, "txtImporte")
        Me.txtImporte.Weight = 27.496342737722046
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrPageInfo1})
        Me.PageFooter.Height = 29
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        resources.ApplyResources(Me.PageFooter, "PageFooter")
        '
        'XrPageInfo2
        '
        resources.ApplyResources(Me.XrPageInfo2, "XrPageInfo2")
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.StyleName = "PageInfo"
        '
        'XrPageInfo1
        '
        resources.ApplyResources(Me.XrPageInfo1, "XrPageInfo1")
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.StyleName = "PageInfo"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeader.Height = 36
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        resources.ApplyResources(Me.PageHeader, "PageHeader")
        '
        'XrTable1
        '
        Me.XrTable1.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom
        resources.ApplyResources(Me.XrTable1, "XrTable1")
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell3, Me.XrTableCell5, Me.XrTableCell7, Me.XrTableCell9})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1
        '
        'XrTableCell1
        '
        Me.XrTableCell1.CanGrow = False
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StyleName = "FieldCaption"
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        resources.ApplyResources(Me.XrTableCell1, "XrTableCell1")
        Me.XrTableCell1.Weight = 20.021943573667713
        '
        'XrTableCell3
        '
        Me.XrTableCell3.CanGrow = False
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StyleName = "FieldCaption"
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        resources.ApplyResources(Me.XrTableCell3, "XrTableCell3")
        Me.XrTableCell3.Weight = 22.460292580982241
        '
        'XrTableCell5
        '
        Me.XrTableCell5.CanGrow = False
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StyleName = "FieldCaption"
        resources.ApplyResources(Me.XrTableCell5, "XrTableCell5")
        Me.XrTableCell5.Weight = 74.195402298850567
        '
        'XrTableCell7
        '
        Me.XrTableCell7.CanGrow = False
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StyleName = "FieldCaption"
        resources.ApplyResources(Me.XrTableCell7, "XrTableCell7")
        Me.XrTableCell7.Weight = 66.829153605015676
        '
        'XrTableCell9
        '
        Me.XrTableCell9.CanGrow = False
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StyleName = "FieldCaption"
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        resources.ApplyResources(Me.XrTableCell9, "XrTableCell9")
        Me.XrTableCell9.Weight = 28.159874608150467
        '
        'Title
        '
        Me.Title.BackColor = System.Drawing.Color.White
        Me.Title.BorderColor = System.Drawing.SystemColors.ControlText
        Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Title.BorderWidth = 1
        Me.Title.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Title.ForeColor = System.Drawing.Color.Maroon
        Me.Title.Name = "Title"
        '
        'FieldCaption
        '
        Me.FieldCaption.BackColor = System.Drawing.Color.White
        Me.FieldCaption.BorderColor = System.Drawing.SystemColors.ControlText
        Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.FieldCaption.BorderWidth = 1
        Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
        Me.FieldCaption.Name = "FieldCaption"
        '
        'PageInfo
        '
        Me.PageInfo.BackColor = System.Drawing.Color.White
        Me.PageInfo.BorderColor = System.Drawing.SystemColors.ControlText
        Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.PageInfo.BorderWidth = 1
        Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PageInfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PageInfo.Name = "PageInfo"
        '
        'DataField
        '
        Me.DataField.BackColor = System.Drawing.Color.White
        Me.DataField.BorderColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.DataField.BorderWidth = 1
        Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.DataField.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataField.Name = "DataField"
        '
        'ReportHeaderBand1
        '
        Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.ReportHeaderBand1.Height = 51
        Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
        '
        'XrLabel1
        '
        resources.ApplyResources(Me.XrLabel1, "XrLabel1")
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.StyleName = "Title"
        '
        'ReportFooter
        '
        Me.ReportFooter.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.txtTotalImporte})
        Me.ReportFooter.Height = 33
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.StylePriority.UseBorders = False
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        resources.ApplyResources(Me.XrLabel3, "XrLabel3")
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.StyleName = "FieldCaption"
        Me.XrLabel3.StylePriority.UseBorders = False
        '
        'txtTotalImporte
        '
        Me.txtTotalImporte.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.txtTotalImporte.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "VALES_TIENDA.Importe", "")})
        resources.ApplyResources(Me.txtTotalImporte, "txtTotalImporte")
        Me.txtTotalImporte.Name = "txtTotalImporte"
        Me.txtTotalImporte.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTotalImporte.StylePriority.UseBorders = False
        Me.txtTotalImporte.StylePriority.UseFont = False
        Me.txtTotalImporte.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary2, "XrSummary2")
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.txtTotalImporte.Summary = XrSummary2
        '
        'DsValesTienda1
        '
        Me.DsValesTienda1.DataSetName = "dsValesTienda"
        Me.DsValesTienda1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VALES_TIENDATableAdapter
        '
        Me.VALES_TIENDATableAdapter.ClearBeforeFill = True
        '
        'InfListadoVales
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.bandDetalle, Me.PageFooter, Me.PageHeader, Me.ReportHeaderBand1, Me.ReportFooter})
        Me.DataMember = "VALES_TIENDA"
        Me.DataSource = Me.DsValesTienda1
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "9.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsValesTienda1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents bandDetalle As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents Detalle As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtImporte As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents txtTotalImporte As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DsValesTienda1 As AydaraTPV.dsValesTienda
    Friend WithEvents VALES_TIENDATableAdapter As AydaraTPV.dsValesTiendaTableAdapters.VALES_TIENDATableAdapter
End Class
