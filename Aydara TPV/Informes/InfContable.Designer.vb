<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class InfContable
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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.txtTitulo = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.subTotales = New DevExpress.XtraReports.UI.XRSubreport()
        Me.DsConsultaTickets1 = New AydaraTPV.dsConsultaTickets()
        Me.subIVA_Tickets = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.subIVA_Totales = New DevExpress.XtraReports.UI.XRSubreport()
        Me.subIVA_Albaranes = New DevExpress.XtraReports.UI.XRSubreport()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell13 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell17 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.DsConsultaTickets1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 15.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CodigoCaja", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("HoraTicket", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.txtTitulo})
        Me.PageHeader.HeightF = 65.625!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'txtTitulo
        '
        Me.txtTitulo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitulo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 7.999992!)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTitulo.SizeF = New System.Drawing.SizeF(727.0001!, 25.0!)
        Me.txtTitulo.StylePriority.UseFont = False
        Me.txtTitulo.StylePriority.UseTextAlignment = False
        Me.txtTitulo.Text = "LISTADO CONTABLE"
        Me.txtTitulo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.XrPageInfo1})
        Me.PageFooter.HeightF = 40.00001!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Format = "Página {0} de {1}"
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(400.0!, 17.00001!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(327.0!, 23.0!)
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 17.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
        '
        'subTotales
        '
        Me.subTotales.Id = 0
        Me.subTotales.LocationFloat = New DevExpress.Utils.PointFloat(333.0!, 50.0!)
        Me.subTotales.Name = "subTotales"
        Me.subTotales.SizeF = New System.Drawing.SizeF(393.9999!, 25.0!)
        '
        'DsConsultaTickets1
        '
        Me.DsConsultaTickets1.DataSetName = "dsConsultaTickets"
        Me.DsConsultaTickets1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'subIVA_Tickets
        '
        Me.subIVA_Tickets.Id = 0
        Me.subIVA_Tickets.LocationFloat = New DevExpress.Utils.PointFloat(333.0!, 82.99999!)
        Me.subIVA_Tickets.Name = "subIVA_Tickets"
        Me.subIVA_Tickets.SizeF = New System.Drawing.SizeF(393.9999!, 25.0!)
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 7.999992!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(727.0!, 8.0!)
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.subIVA_Totales, Me.subIVA_Albaranes, Me.XrLabel14, Me.XrLine2, Me.subTotales, Me.subIVA_Tickets})
        Me.ReportFooter.HeightF = 186.0!
        Me.ReportFooter.KeepTogether = True
        Me.ReportFooter.Name = "ReportFooter"
        '
        'subIVA_Totales
        '
        Me.subIVA_Totales.Id = 0
        Me.subIVA_Totales.LocationFloat = New DevExpress.Utils.PointFloat(333.0!, 150.0!)
        Me.subIVA_Totales.Name = "subIVA_Totales"
        Me.subIVA_Totales.SizeF = New System.Drawing.SizeF(393.9999!, 25.0!)
        '
        'subIVA_Albaranes
        '
        Me.subIVA_Albaranes.Id = 0
        Me.subIVA_Albaranes.LocationFloat = New DevExpress.Utils.PointFloat(333.0!, 117.0!)
        Me.subIVA_Albaranes.Name = "subIVA_Albaranes"
        Me.subIVA_Albaranes.SizeF = New System.Drawing.SizeF(393.9999!, 24.99999!)
        '
        'XrLabel14
        '
        Me.XrLabel14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS.ImporteTotal")})
        Me.XrLabel14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(633.0!, 17.00001!)
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(94.0!, 25.0!)
        Me.XrLabel14.StylePriority.UseFont = False
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:c2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrLabel14.Summary = XrSummary1
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 44.79167!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(727.0001!, 15.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell9, Me.XrTableCell8, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.CanGrow = False
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "Caja"
        Me.XrTableCell1.Weight = 0.13617603360341879R
        Me.XrTableCell1.WordWrap = False
        '
        'XrTableCell2
        '
        Me.XrTableCell2.CanGrow = False
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "Fecha"
        Me.XrTableCell2.Weight = 0.48280599074700392R
        Me.XrTableCell2.WordWrap = False
        '
        'XrTableCell3
        '
        Me.XrTableCell3.CanGrow = False
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "Total"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell3.Weight = 0.30794339434693596R
        Me.XrTableCell3.WordWrap = False
        '
        'XrTableCell4
        '
        Me.XrTableCell4.CanGrow = False
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "Nº ticket"
        Me.XrTableCell4.Weight = 0.27647874024791341R
        Me.XrTableCell4.WordWrap = False
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "Vd."
        Me.XrTableCell5.Weight = 0.13617597063730691R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.CanGrow = False
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "Cliente"
        Me.XrTableCell6.Weight = 0.99449800015430878R
        Me.XrTableCell6.WordWrap = False
        '
        'XrTableCell7
        '
        Me.XrTableCell7.CanGrow = False
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "Cobro"
        Me.XrTableCell7.Weight = 0.14305379052215614R
        Me.XrTableCell7.WordWrap = False
        '
        'XrTableCell8
        '
        Me.XrTableCell8.CanGrow = False
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "I.V.A."
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell8.Weight = 0.22274766072498842R
        Me.XrTableCell8.WordWrap = False
        '
        'XrTableCell9
        '
        Me.XrTableCell9.CanGrow = False
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "B.Imponible"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell9.Weight = 0.30012041901596725R
        Me.XrTableCell9.WordWrap = False
        '
        'XrTable2
        '
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(727.0001!, 15.0!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell10, Me.XrTableCell11, Me.XrTableCell12, Me.XrTableCell13, Me.XrTableCell14, Me.XrTableCell15, Me.XrTableCell16, Me.XrTableCell17, Me.XrTableCell18})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.CanGrow = False
        Me.XrTableCell10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS.CodigoCaja")})
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Weight = 0.13617603360341879R
        Me.XrTableCell10.WordWrap = False
        '
        'XrTableCell11
        '
        Me.XrTableCell11.CanGrow = False
        Me.XrTableCell11.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS.FechaTicket", "{0:dd/MM/yyyy HH:mm:ss}")})
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.Weight = 0.48280599074700392R
        Me.XrTableCell11.WordWrap = False
        '
        'XrTableCell12
        '
        Me.XrTableCell12.CanGrow = False
        Me.XrTableCell12.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS.NumeroDocumento")})
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Weight = 0.27647874024791341R
        Me.XrTableCell12.WordWrap = False
        '
        'XrTableCell13
        '
        Me.XrTableCell13.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS.CodigoEmpleado")})
        Me.XrTableCell13.Name = "XrTableCell13"
        Me.XrTableCell13.Weight = 0.13617597063730691R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.CanGrow = False
        Me.XrTableCell14.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS.NombreFiscal")})
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.Weight = 0.99449800015430878R
        Me.XrTableCell14.WordWrap = False
        '
        'XrTableCell15
        '
        Me.XrTableCell15.CanGrow = False
        Me.XrTableCell15.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS.TipoCobro")})
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Weight = 0.14305379052215614R
        Me.XrTableCell15.WordWrap = False
        '
        'XrTableCell16
        '
        Me.XrTableCell16.CanGrow = False
        Me.XrTableCell16.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS.Base", "{0:c2}")})
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell16.Weight = 0.30012041901596725R
        Me.XrTableCell16.WordWrap = False
        '
        'XrTableCell17
        '
        Me.XrTableCell17.CanGrow = False
        Me.XrTableCell17.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS.TotIva", "{0:c2}")})
        Me.XrTableCell17.Name = "XrTableCell17"
        Me.XrTableCell17.StylePriority.UseTextAlignment = False
        Me.XrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell17.Weight = 0.22274766072498842R
        Me.XrTableCell17.WordWrap = False
        '
        'XrTableCell18
        '
        Me.XrTableCell18.CanGrow = False
        Me.XrTableCell18.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS.ImporteTotal", "{0:c2}")})
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell18.Weight = 0.30794339434693596R
        Me.XrTableCell18.WordWrap = False
        '
        'InfContable
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataMember = "TICKETS"
        Me.DataSource = Me.DsConsultaTickets1
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 100, 100)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Version = "13.2"
        CType(Me.DsConsultaTickets1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents DsConsultaTickets1 As AydaraTPV.dsConsultaTickets
    Friend WithEvents subTotales As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents subIVA_Tickets As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents txtTitulo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents subIVA_Totales As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents subIVA_Albaranes As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell13 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell17 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
