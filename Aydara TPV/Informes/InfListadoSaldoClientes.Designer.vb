<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class InfListadoSaldoclientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfListadoSaldoclientes))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.bandDetalle = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.Detalle = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.txtImporteTicket = New DevExpress.XtraReports.UI.XRTableCell
        Me.txtImporteCobrado = New DevExpress.XtraReports.UI.XRTableCell
        Me.txtImportePendiente = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.ghCliente = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.txtNombreCliente = New DevExpress.XtraReports.UI.XRLabel
        Me.txtCodigoCliente = New DevExpress.XtraReports.UI.XRLabel
        Me.txtTotalImporteCliente = New DevExpress.XtraReports.UI.XRLabel
        Me.ImportePrendiente = New DevExpress.XtraReports.UI.CalculatedField
        Me.DsPendientesCobro1 = New AydaraTPV.dsPendientesCobro
        Me.PENDIENTES_COBROTableAdapter = New AydaraTPV.dsPendientesCobroTableAdapters.PENDIENTES_COBROTableAdapter
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.txtTotalImporte = New DevExpress.XtraReports.UI.XRLabel
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPendientesCobro1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Detalle.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell8, Me.XrTableCell2, Me.txtImporteTicket, Me.txtImporteCobrado, Me.txtImportePendiente})
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Weight = 1.4993215739484396
        '
        'XrTableCell8
        '
        Me.XrTableCell8.CanGrow = False
        Me.XrTableCell8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PENDIENTES_COBRO.CodigoTicket", "")})
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Weight = 22.4042580982236
        '
        'XrTableCell2
        '
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PENDIENTES_COBRO.Fecha", "{0:MM/dd/yyyy}")})
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        resources.ApplyResources(Me.XrTableCell2, "XrTableCell2")
        Me.XrTableCell2.Weight = 24.7266196447231
        '
        'txtImporteTicket
        '
        Me.txtImporteTicket.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PENDIENTES_COBRO.ImporteTicket", "{0:c2}")})
        Me.txtImporteTicket.Name = "txtImporteTicket"
        Me.txtImporteTicket.StylePriority.UseTextAlignment = False
        resources.ApplyResources(Me.txtImporteTicket, "txtImporteTicket")
        Me.txtImporteTicket.Weight = 33.020768025078375
        '
        'txtImporteCobrado
        '
        Me.txtImporteCobrado.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PENDIENTES_COBRO.ImporteCobrado", "{0:c2}")})
        Me.txtImporteCobrado.Name = "txtImporteCobrado"
        Me.txtImporteCobrado.StylePriority.UseTextAlignment = False
        resources.ApplyResources(Me.txtImporteCobrado, "txtImporteCobrado")
        Me.txtImporteCobrado.Weight = 35.343129571577848
        '
        'txtImportePendiente
        '
        Me.txtImportePendiente.CanGrow = False
        Me.txtImportePendiente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PENDIENTES_COBRO.ImportePrendiente", "{0:c2}")})
        Me.txtImportePendiente.Name = "txtImportePendiente"
        Me.txtImportePendiente.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary1, "XrSummary1")
        Me.txtImportePendiente.Summary = XrSummary1
        resources.ApplyResources(Me.txtImportePendiente, "txtImportePendiente")
        Me.txtImportePendiente.Weight = 33.799895506792055
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
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrLabel4})
        Me.PageHeader.Height = 36
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        resources.ApplyResources(Me.PageHeader, "PageHeader")
        '
        'XrLabel5
        '
        resources.ApplyResources(Me.XrLabel5, "XrLabel5")
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.StyleName = "FieldCaption"
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        '
        'XrLabel4
        '
        resources.ApplyResources(Me.XrLabel4, "XrLabel4")
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.StyleName = "FieldCaption"
        Me.XrLabel4.StylePriority.UseTextAlignment = False
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
        'ghCliente
        '
        Me.ghCliente.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel3, Me.XrLabel2})
        Me.ghCliente.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CodigoCliente", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.ghCliente.Height = 45
        Me.ghCliente.Name = "ghCliente"
        '
        'XrLabel10
        '
        Me.XrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        resources.ApplyResources(Me.XrLabel10, "XrLabel10")
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.StylePriority.UseBorders = False
        Me.XrLabel10.StylePriority.UseFont = False
        Me.XrLabel10.StylePriority.UseTextAlignment = False
        '
        'XrLabel9
        '
        Me.XrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        resources.ApplyResources(Me.XrLabel9, "XrLabel9")
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.StylePriority.UseBorders = False
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.StylePriority.UseTextAlignment = False
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        resources.ApplyResources(Me.XrLabel8, "XrLabel8")
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.StylePriority.UseBorders = False
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.StylePriority.UseTextAlignment = False
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        resources.ApplyResources(Me.XrLabel7, "XrLabel7")
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.StylePriority.UseBorders = False
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        resources.ApplyResources(Me.XrLabel6, "XrLabel6")
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.StylePriority.UseBorders = False
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.StylePriority.UseTextAlignment = False
        '
        'XrLabel3
        '
        resources.ApplyResources(Me.XrLabel3, "XrLabel3")
        Me.XrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PENDIENTES_COBRO.CodigoCliente", "{0:00000}")})
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        Me.XrLabel3.StylePriority.UseBorders = False
        '
        'XrLabel2
        '
        resources.ApplyResources(Me.XrLabel2, "XrLabel2")
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PENDIENTES_COBRO.Nombre", "")})
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtNombreCliente, Me.txtCodigoCliente, Me.txtTotalImporteCliente})
        Me.GroupFooter1.Height = 20
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PENDIENTES_COBRO.Nombre", "")})
        resources.ApplyResources(Me.txtNombreCliente, "txtNombreCliente")
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'txtCodigoCliente
        '
        Me.txtCodigoCliente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PENDIENTES_COBRO.CodigoCliente", "{0:00000000}")})
        resources.ApplyResources(Me.txtCodigoCliente, "txtCodigoCliente")
        Me.txtCodigoCliente.Name = "txtCodigoCliente"
        Me.txtCodigoCliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        '
        'txtTotalImporteCliente
        '
        Me.txtTotalImporteCliente.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.txtTotalImporteCliente.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PENDIENTES_COBRO.ImportePrendiente", "")})
        resources.ApplyResources(Me.txtTotalImporteCliente, "txtTotalImporteCliente")
        Me.txtTotalImporteCliente.Name = "txtTotalImporteCliente"
        Me.txtTotalImporteCliente.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTotalImporteCliente.StylePriority.UseBorders = False
        Me.txtTotalImporteCliente.StylePriority.UseFont = False
        Me.txtTotalImporteCliente.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary2, "XrSummary2")
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.txtTotalImporteCliente.Summary = XrSummary2
        '
        'ImportePrendiente
        '
        Me.ImportePrendiente.DataMember = "PENDIENTES_COBRO"
        Me.ImportePrendiente.DataSource = Me.DsPendientesCobro1
        Me.ImportePrendiente.Expression = "[ImporteTicket]-[ImporteCobrado]"
        Me.ImportePrendiente.Name = "ImportePrendiente"
        '
        'DsPendientesCobro1
        '
        Me.DsPendientesCobro1.DataSetName = "dsPendientesCobro"
        Me.DsPendientesCobro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PENDIENTES_COBROTableAdapter
        '
        Me.PENDIENTES_COBROTableAdapter.ClearBeforeFill = True
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtTotalImporte})
        Me.ReportFooter.Height = 35
        Me.ReportFooter.Name = "ReportFooter"
        '
        'txtTotalImporte
        '
        Me.txtTotalImporte.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.txtTotalImporte.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "PENDIENTES_COBRO.ImportePrendiente", "")})
        resources.ApplyResources(Me.txtTotalImporte, "txtTotalImporte")
        Me.txtTotalImporte.Name = "txtTotalImporte"
        Me.txtTotalImporte.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTotalImporte.StylePriority.UseBorders = False
        Me.txtTotalImporte.StylePriority.UseFont = False
        Me.txtTotalImporte.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary3, "XrSummary3")
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.txtTotalImporte.Summary = XrSummary3
        '
        'InfListadoSaldoclientes
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.bandDetalle, Me.PageFooter, Me.PageHeader, Me.ReportHeaderBand1, Me.ghCliente, Me.GroupFooter1, Me.ReportFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.ImportePrendiente})
        Me.DataMember = "PENDIENTES_COBRO"
        Me.DataSource = Me.DsPendientesCobro1
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "9.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPendientesCobro1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents bandDetalle As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents Detalle As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtImportePendiente As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ghCliente As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents txtTotalImporteCliente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtNombreCliente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents txtCodigoCliente As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtImporteTicket As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtImporteCobrado As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ImportePrendiente As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents DsPendientesCobro1 As AydaraTPV.dsPendientesCobro
    Friend WithEvents PENDIENTES_COBROTableAdapter As AydaraTPV.dsPendientesCobroTableAdapters.PENDIENTES_COBROTableAdapter
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents txtTotalImporte As DevExpress.XtraReports.UI.XRLabel
End Class
