<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class InfCodigosBarras
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
        Dim EaN13Generator1 As DevExpress.XtraPrinting.BarCode.EAN13Generator = New DevExpress.XtraPrinting.BarCode.EAN13Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.CodigoBarras = New DevExpress.XtraReports.UI.CalculatedField()
        Me.DsEtiquetas1 = New AydaraTPV.dsEtiquetas()
        Me.Prefijo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ETIQUETASTableAdapter = New AydaraTPV.dsEtiquetasTableAdapters.ETIQUETASTableAdapter()
        Me.Articulo = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.DsEtiquetas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode1, Me.XrLabel2})
        Me.Detail.KeepTogether = True
        Me.Detail.MultiColumn.ColumnCount = 5
        Me.Detail.MultiColumn.ColumnSpacing = 12.0!
        Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IMPRIMIR.CodigoBarras")})
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 33.0!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(108.0!, 50.0!)
        Me.XrBarCode1.StylePriority.UseTextAlignment = False
        Me.XrBarCode1.Symbology = EaN13Generator1
        Me.XrBarCode1.Text = "XrBarCode1"
        '
        'XrLabel2
        '
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IMPRIMIR.Descripcion")})
        Me.XrLabel2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 17.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(108.0!, 17.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "XrLabel2"
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 0.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.PageHeader.Visible = False
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 0.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.PageFooter.Visible = False
        '
        'CodigoBarras
        '
        Me.CodigoBarras.DataMember = "IMPRIMIR"
        Me.CodigoBarras.Expression = "[Parameters.Prefijo] + [CodigoArticulo]  + iif(len([CodigoColor])=1,'0','') +  [C" & _
    "odigoColor] +  iif(len([CodigoTalla])=1,'0','') + [CodigoTalla]"
        Me.CodigoBarras.Name = "CodigoBarras"
        '
        'DsEtiquetas1
        '
        Me.DsEtiquetas1.DataSetName = "dsEtiquetas"
        Me.DsEtiquetas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Prefijo
        '
        Me.Prefijo.Name = "Prefijo"
        '
        'ETIQUETASTableAdapter
        '
        Me.ETIQUETASTableAdapter.ClearBeforeFill = True
        '
        'Articulo
        '
        Me.Articulo.DataMember = "IMPRIMIR"
        Me.Articulo.Expression = "'CODIGO: ' + [CodigoArticulo]"
        Me.Articulo.Name = "Articulo"
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 32.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 32.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'InfCodigosBarras
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CodigoBarras, Me.Articulo})
        Me.DataMember = "IMPRIMIR"
        Me.DataSource = Me.DsEtiquetas1
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(32, 32, 32, 32)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Prefijo})
        Me.Version = "13.2"
        CType(Me.DsEtiquetas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CodigoBarras As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Prefijo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DsEtiquetas1 As AydaraTPV.dsEtiquetas
    Friend WithEvents ETIQUETASTableAdapter As AydaraTPV.dsEtiquetasTableAdapters.ETIQUETASTableAdapter
    Friend WithEvents Articulo As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
