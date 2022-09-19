<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class InfListadoTarifas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfListadoTarifas))
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.bandDetalle = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.Detalle = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.txtPrecioVenta = New DevExpress.XtraReports.UI.XRTableCell
        Me.txtPrecioNeto = New DevExpress.XtraReports.UI.XRTableCell
        Me.txtPrecioCosto = New DevExpress.XtraReports.UI.XRTableCell
        Me.txtMargen = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblPrecioVenta = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblPrecioNeto = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblPrecioCosto = New DevExpress.XtraReports.UI.XRTableCell
        Me.lblMargen = New DevExpress.XtraReports.UI.XRTableCell
        Me.Title = New DevExpress.XtraReports.UI.XRControlStyle
        Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle
        Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle
        Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle
        Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.ghFamilia = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.ghSubFamilia = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.DsListadoArticulos1 = New AydaraTPV.dsListadoArticulos
        Me.PrecioNeto = New DevExpress.XtraReports.UI.CalculatedField
        Me.Margen = New DevExpress.XtraReports.UI.CalculatedField
        Me.TipoIVA3 = New DevExpress.XtraReports.Parameters.Parameter
        Me.TipoIVA2 = New DevExpress.XtraReports.Parameters.Parameter
        Me.TipoIVA1 = New DevExpress.XtraReports.Parameters.Parameter
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsListadoArticulos1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Detalle.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell4, Me.txtPrecioVenta, Me.txtPrecioNeto, Me.txtPrecioCosto, Me.txtMargen})
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Weight = 1.4993215739484396
        '
        'XrTableCell2
        '
        Me.XrTableCell2.CanGrow = False
        Me.XrTableCell2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoArticulos.Codigo", "")})
        Me.XrTableCell2.Name = "XrTableCell2"
        resources.ApplyResources(Me.XrTableCell2, "XrTableCell2")
        Me.XrTableCell2.Weight = 24.998432601880882
        '
        'XrTableCell4
        '
        Me.XrTableCell4.CanGrow = False
        Me.XrTableCell4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoArticulos.Descripcion", "")})
        Me.XrTableCell4.Name = "XrTableCell4"
        resources.ApplyResources(Me.XrTableCell4, "XrTableCell4")
        Me.XrTableCell4.Weight = 93.83986415882967
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.CanGrow = False
        Me.txtPrecioVenta.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoArticulos.PrecioVenta", "{0:c}")})
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary1, "XrSummary1")
        Me.txtPrecioVenta.Summary = XrSummary1
        resources.ApplyResources(Me.txtPrecioVenta, "txtPrecioVenta")
        Me.txtPrecioVenta.Weight = 22.390020898641584
        '
        'txtPrecioNeto
        '
        Me.txtPrecioNeto.CanGrow = False
        Me.txtPrecioNeto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoArticulos.PrecioNeto", "{0:c}")})
        Me.txtPrecioNeto.Name = "txtPrecioNeto"
        Me.txtPrecioNeto.StylePriority.UseTextAlignment = False
        resources.ApplyResources(Me.txtPrecioNeto, "txtPrecioNeto")
        Me.txtPrecioNeto.Weight = 22.040752351097186
        '
        'txtPrecioCosto
        '
        Me.txtPrecioCosto.CanGrow = False
        Me.txtPrecioCosto.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoArticulos.PrecioCoste", "{0:c}")})
        Me.txtPrecioCosto.Name = "txtPrecioCosto"
        Me.txtPrecioCosto.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary2, "XrSummary2")
        Me.txtPrecioCosto.Summary = XrSummary2
        resources.ApplyResources(Me.txtPrecioCosto, "txtPrecioCosto")
        Me.txtPrecioCosto.Weight = 22.705851619644722
        '
        'txtMargen
        '
        Me.txtMargen.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoArticulos.Margen", "{0:p2}")})
        Me.txtMargen.Name = "txtMargen"
        Me.txtMargen.StylePriority.UseTextAlignment = False
        resources.ApplyResources(XrSummary3, "XrSummary3")
        Me.txtMargen.Summary = XrSummary3
        resources.ApplyResources(Me.txtMargen, "txtMargen")
        Me.txtMargen.Weight = 24.032915360501562
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
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell3, Me.lblPrecioVenta, Me.lblPrecioNeto, Me.lblPrecioCosto, Me.lblMargen})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1
        '
        'XrTableCell1
        '
        Me.XrTableCell1.CanGrow = False
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StyleName = "FieldCaption"
        resources.ApplyResources(Me.XrTableCell1, "XrTableCell1")
        Me.XrTableCell1.Weight = 25.6619644723093
        '
        'XrTableCell3
        '
        Me.XrTableCell3.CanGrow = False
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StyleName = "FieldCaption"
        resources.ApplyResources(Me.XrTableCell3, "XrTableCell3")
        Me.XrTableCell3.Weight = 93.7899686520376
        '
        'lblPrecioVenta
        '
        Me.lblPrecioVenta.CanGrow = False
        Me.lblPrecioVenta.Name = "lblPrecioVenta"
        Me.lblPrecioVenta.StyleName = "FieldCaption"
        Me.lblPrecioVenta.StylePriority.UseTextAlignment = False
        resources.ApplyResources(Me.lblPrecioVenta, "lblPrecioVenta")
        Me.lblPrecioVenta.Weight = 22.108150470219442
        '
        'lblPrecioNeto
        '
        Me.lblPrecioNeto.CanGrow = False
        Me.lblPrecioNeto.Name = "lblPrecioNeto"
        Me.lblPrecioNeto.StyleName = "FieldCaption"
        Me.lblPrecioNeto.StylePriority.UseTextAlignment = False
        resources.ApplyResources(Me.lblPrecioNeto, "lblPrecioNeto")
        Me.lblPrecioNeto.Weight = 22.372518286311397
        '
        'lblPrecioCosto
        '
        Me.lblPrecioCosto.CanGrow = False
        Me.lblPrecioCosto.Name = "lblPrecioCosto"
        Me.lblPrecioCosto.StyleName = "FieldCaption"
        Me.lblPrecioCosto.StylePriority.UseTextAlignment = False
        resources.ApplyResources(Me.lblPrecioCosto, "lblPrecioCosto")
        Me.lblPrecioCosto.Weight = 22.208202716823404
        '
        'lblMargen
        '
        Me.lblMargen.CanGrow = False
        resources.ApplyResources(Me.lblMargen, "lblMargen")
        Me.lblMargen.Name = "lblMargen"
        Me.lblMargen.StyleName = "FieldCaption"
        Me.lblMargen.StylePriority.UseFont = False
        Me.lblMargen.StylePriority.UseForeColor = False
        Me.lblMargen.StylePriority.UseTextAlignment = False
        Me.lblMargen.Weight = 24.53056426332288
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
        'ghFamilia
        '
        Me.ghFamilia.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.XrLabel2})
        Me.ghFamilia.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CodigoFamilia", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.ghFamilia.Height = 25
        Me.ghFamilia.Level = 1
        Me.ghFamilia.Name = "ghFamilia"
        '
        'XrLabel3
        '
        resources.ApplyResources(Me.XrLabel3, "XrLabel3")
        Me.XrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoArticulos.DescripcionFamilia", "")})
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.StylePriority.UseBackColor = False
        '
        'XrLabel2
        '
        resources.ApplyResources(Me.XrLabel2, "XrLabel2")
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoArticulos.CodigoFamilia", "")})
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.StylePriority.UseBackColor = False
        '
        'ghSubFamilia
        '
        Me.ghSubFamilia.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel4, Me.XrLabel5})
        Me.ghSubFamilia.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("CodigoSubFamilia", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.ghSubFamilia.Height = 25
        Me.ghSubFamilia.Name = "ghSubFamilia"
        '
        'XrLabel4
        '
        resources.ApplyResources(Me.XrLabel4, "XrLabel4")
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoArticulos.CodigoSubFamilia", "")})
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.StylePriority.UseBackColor = False
        '
        'XrLabel5
        '
        resources.ApplyResources(Me.XrLabel5, "XrLabel5")
        Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ListadoArticulos.DescripcionSubFamilia", "")})
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.StylePriority.UseBackColor = False
        '
        'DsListadoArticulos1
        '
        Me.DsListadoArticulos1.DataSetName = "dsListadoArticulos"
        Me.DsListadoArticulos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PrecioNeto
        '
        Me.PrecioNeto.DataMember = "ListadoArticulos"
        Me.PrecioNeto.DataSource = Me.DsListadoArticulos1
        Me.PrecioNeto.Expression = "[PrecioVenta]/(1+(Iif([TipoIva]=1,[Parameters.TipoIVA1],Iif([TipoIva]=2,[Paramete" & _
            "rs.TipoIVA2],[Parameters.TipoIVA3]))/100))"
        Me.PrecioNeto.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.PrecioNeto.Name = "PrecioNeto"
        '
        'Margen
        '
        Me.Margen.DataMember = "ListadoArticulos"
        Me.Margen.DataSource = Me.DsListadoArticulos1
        Me.Margen.Expression = "Iif([PrecioCoste]<>0,(([PrecioVenta]-[PrecioVenta]*Iif([TipoIva]=1,[Parameters.Ti" & _
            "poIVA1],Iif([TipoIva]=2,[Parameters.TipoIVA2],[Parameters.TipoIVA3]))/100)-[Prec" & _
            "ioCoste])/[PrecioCoste],1)"
        Me.Margen.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.Margen.Name = "Margen"
        '
        'TipoIVA3
        '
        Me.TipoIVA3.Name = "TipoIVA3"
        Me.TipoIVA3.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.[Decimal]
        Me.TipoIVA3.Value = 0
        '
        'TipoIVA2
        '
        Me.TipoIVA2.Name = "TipoIVA2"
        Me.TipoIVA2.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.[Decimal]
        Me.TipoIVA2.Value = 0
        '
        'TipoIVA1
        '
        Me.TipoIVA1.Name = "TipoIVA1"
        Me.TipoIVA1.ParameterType = DevExpress.XtraReports.Parameters.ParameterType.[Decimal]
        Me.TipoIVA1.Value = 0
        '
        'InfListadoTarifas
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.bandDetalle, Me.PageFooter, Me.PageHeader, Me.ReportHeaderBand1, Me.ghFamilia, Me.ghSubFamilia})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.PrecioNeto, Me.Margen})
        Me.DataMember = "ListadoArticulos"
        Me.DataSource = Me.DsListadoArticulos1
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.TipoIVA1, Me.TipoIVA2, Me.TipoIVA3})
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
        Me.Version = "9.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsListadoArticulos1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblPrecioNeto As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblPrecioCosto As DevExpress.XtraReports.UI.XRTableCell
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
    Friend WithEvents txtPrecioVenta As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtPrecioNeto As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtPrecioCosto As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtMargen As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents lblMargen As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ghFamilia As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents ghSubFamilia As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents DsListadoArticulos1 As AydaraTPV.dsListadoArticulos
    Friend WithEvents lblPrecioVenta As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PrecioNeto As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Margen As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents TipoIVA3 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents TipoIVA2 As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents TipoIVA1 As DevExpress.XtraReports.Parameters.Parameter
End Class
