<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class InfFactura_Totales
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
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.txtImporte = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.DsInfFactura1 = New AydaraTPV.dsInfFactura()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtImporteRecargo = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtBaseImponible = New DevExpress.XtraReports.UI.XRLabel()
        Me.txtImporteIva = New DevExpress.XtraReports.UI.XRLabel()
        Me.ImporteIVA = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ImporteBase = New DevExpress.XtraReports.UI.CalculatedField()
        Me.IVA = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Recargo = New DevExpress.XtraReports.UI.CalculatedField()
        Me.ImporteRecargo = New DevExpress.XtraReports.UI.CalculatedField()
        CType(Me.DsInfFactura1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtImporte})
        Me.Detail.HeightF = 23.3333397!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.Detail.Visible = False
        '
        'txtImporte
        '
        Me.txtImporte.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS_LINEAS.Importe")})
        Me.txtImporte.LocationFloat = New DevExpress.Utils.PointFloat(10.0000095!, 0.333341002!)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtImporte.SizeF = New System.Drawing.SizeF(115.0!, 23.0!)
        Me.txtImporte.Text = "txtImporte"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel9, Me.XrLabel2, Me.XrLine2, Me.XrLine1, Me.XrLabel7, Me.XrLabel6, Me.XrLabel1, Me.XrLabel3})
        Me.PageHeader.HeightF = 48.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.PageHeader.Visible = False
        '
        'XrLabel9
        '
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(383.333313!, 17.0000095!)
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(103.458397!, 16.0!)
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        Me.XrLabel9.Text = "Importe Recargo"
        Me.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel2
        '
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(306.25!, 17.0000095!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(65.9583435!, 16.0!)
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "% Recargo"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 8.0!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(625.0!, 8.0!)
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 33.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(625.0!, 8.0!)
        '
        'XrLabel7
        '
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(517.0!, 17.0000095!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(117.0!, 16.0!)
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "TOTAL FACTURA"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel6
        '
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(208.0!, 17.0000095!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(87.8333435!, 16.0!)
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        Me.XrLabel6.Text = "Importe IVA"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel1
        '
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(133.0!, 17.0000095!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(67.0!, 16.0!)
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "% IVA"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel3
        '
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(7.99999189!, 17.0000095!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(117.0!, 16.0!)
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "Base Imponible"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'DsInfFactura1
        '
        Me.DsInfFactura1.DataSetName = "dsInfFactura"
        Me.DsInfFactura1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupHeader1
        '
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("PorcentajeIVA", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.txtImporteRecargo, Me.XrLabel8, Me.txtBaseImponible, Me.txtImporteIva})
        Me.GroupFooter1.HeightF = 17.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'XrLabel10
        '
        Me.XrLabel10.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS_LINEAS.Recargo", "{0:p2}")})
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(306.25!, 0.0!)
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(65.9583435!, 17.0!)
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        Me.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtImporteRecargo
        '
        Me.txtImporteRecargo.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS_LINEAS.ImporteRecargo")})
        Me.txtImporteRecargo.LocationFloat = New DevExpress.Utils.PointFloat(381.25!, 0.0!)
        Me.txtImporteRecargo.Name = "txtImporteRecargo"
        Me.txtImporteRecargo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtImporteRecargo.Scripts.OnPrintOnPage = "txtImporteRecargo_PrintOnPage"
        Me.txtImporteRecargo.SizeF = New System.Drawing.SizeF(105.541702!, 17.0!)
        Me.txtImporteRecargo.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:c2}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.txtImporteRecargo.Summary = XrSummary1
        Me.txtImporteRecargo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'XrLabel8
        '
        Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS_LINEAS.IVA", "{0:p2}")})
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(133.0!, 0.0!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(67.0!, 17.0!)
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        Me.XrLabel8.Text = "XrLabel8"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtBaseImponible
        '
        Me.txtBaseImponible.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS_LINEAS.ImporteBase")})
        Me.txtBaseImponible.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 0.0!)
        Me.txtBaseImponible.Name = "txtBaseImponible"
        Me.txtBaseImponible.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtBaseImponible.SizeF = New System.Drawing.SizeF(118.0!, 17.0!)
        Me.txtBaseImponible.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:c2}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.txtBaseImponible.Summary = XrSummary2
        Me.txtBaseImponible.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'txtImporteIva
        '
        Me.txtImporteIva.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TICKETS_LINEAS.ImporteIVA")})
        Me.txtImporteIva.LocationFloat = New DevExpress.Utils.PointFloat(208.0!, 0.0!)
        Me.txtImporteIva.Name = "txtImporteIva"
        Me.txtImporteIva.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtImporteIva.SizeF = New System.Drawing.SizeF(87.8333435!, 17.0!)
        Me.txtImporteIva.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:c2}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.txtImporteIva.Summary = XrSummary3
        Me.txtImporteIva.Text = "txtImporteIva"
        Me.txtImporteIva.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        '
        'ImporteIVA
        '
        Me.ImporteIVA.DataMember = "TICKETS_LINEAS"
        Me.ImporteIVA.Expression = "[Importe] - ([Importe]/(1+[PorcentajeIVA]/100))"
        Me.ImporteIVA.Name = "ImporteIVA"
        '
        'ImporteBase
        '
        Me.ImporteBase.DataMember = "TICKETS_LINEAS"
        Me.ImporteBase.Expression = "Round([Importe]/(1+[PorcentajeIVA]/100),2)"
        Me.ImporteBase.Name = "ImporteBase"
        '
        'IVA
        '
        Me.IVA.DataMember = "TICKETS_LINEAS"
        Me.IVA.Expression = "[PorcentajeIVA]/100"
        Me.IVA.Name = "IVA"
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'Recargo
        '
        Me.Recargo.DataMember = "TICKETS_LINEAS"
        Me.Recargo.Expression = "Iif([PorcentajeRecargo]<>0,[PorcentajeRecargo]/100,?)"
        Me.Recargo.Name = "Recargo"
        '
        'ImporteRecargo
        '
        Me.ImporteRecargo.DataMember = "TICKETS_LINEAS"
        Me.ImporteRecargo.Expression = "Iif([PorcentajeRecargo]<>0,[Importe] - ([Importe]/(1+[PorcentajeRecargo]/100)),?)" & _
    ""
        Me.ImporteRecargo.Name = "ImporteRecargo"
        '
        'InfFactura_Totales
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.GroupHeader1, Me.GroupFooter1, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.ImporteIVA, Me.ImporteBase, Me.IVA, Me.Recargo, Me.ImporteRecargo})
        Me.DataMember = "TICKETS_LINEAS"
        Me.DataSource = Me.DsInfFactura1
        Me.Version = "13.2"
        CType(Me.DsInfFactura1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents DsInfFactura1 As AydaraTPV.dsInfFactura
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtImporteIva As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ImporteIVA As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents ImporteBase As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents txtBaseImponible As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents IVA As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtImporteRecargo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Recargo As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents ImporteRecargo As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents txtImporte As DevExpress.XtraReports.UI.XRLabel
End Class
