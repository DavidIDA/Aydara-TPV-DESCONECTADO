<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class InfListadoEtiquetas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfListadoEtiquetas))
        Dim ShapeRectangle1 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Dim ShapeRectangle2 As DevExpress.XtraPrinting.Shape.ShapeRectangle = New DevExpress.XtraPrinting.Shape.ShapeRectangle()
        Dim EaN13Generator1 As DevExpress.XtraPrinting.BarCode.EAN13Generator = New DevExpress.XtraPrinting.BarCode.EAN13Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrShape2 = New DevExpress.XtraReports.UI.XRShape()
        Me.XrShape1 = New DevExpress.XtraReports.UI.XRShape()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.CodigoBarras = New DevExpress.XtraReports.UI.CalculatedField()
        Me.DsEtiquetas = New AydaraTPV.dsEtiquetas()
        Me.Prefijo = New DevExpress.XtraReports.Parameters.Parameter()
        Me.Articulo = New DevExpress.XtraReports.UI.CalculatedField()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.DsEtiquetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1, Me.XrShape2, Me.XrShape1, Me.XrLabel7, Me.XrBarCode1, Me.XrLabel1, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2})
        Me.Detail.HeightF = 155.0!
        Me.Detail.MultiColumn.ColumnCount = 4
        Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.Image = CType(resources.GetObject("XrPictureBox1.Image"), System.Drawing.Image)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(155.0!, 102.2778!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(40.65276!, 37.08331!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'XrShape2
        '
        Me.XrShape2.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.XrShape2.ForeColor = System.Drawing.Color.Transparent
        Me.XrShape2.LineWidth = 0
        Me.XrShape2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 141.7222!)
        Me.XrShape2.Name = "XrShape2"
        Me.XrShape2.Shape = ShapeRectangle1
        Me.XrShape2.SizeF = New System.Drawing.SizeF(202.0695!, 13.27778!)
        '
        'XrShape1
        '
        Me.XrShape1.FillColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.XrShape1.ForeColor = System.Drawing.Color.Transparent
        Me.XrShape1.LineWidth = 0
        Me.XrShape1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrShape1.Name = "XrShape1"
        Me.XrShape1.Shape = ShapeRectangle2
        Me.XrShape1.SizeF = New System.Drawing.SizeF(202.0695!, 13.27778!)
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 32.0!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(35.41667!, 17.0!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.StylePriority.UseTextAlignment = False
        Me.XrLabel7.Text = "REF.:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IMPRIMIR.CodigoBarras")})
        Me.XrBarCode1.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 49.0!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100.0!)
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(145.0!, 73.43056!)
        Me.XrBarCode1.StylePriority.UseFont = False
        Me.XrBarCode1.Symbology = EaN13Generator1
        Me.XrBarCode1.Text = "XrBarCode1"
        '
        'XrLabel1
        '
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IMPRIMIR.Articulo")})
        Me.XrLabel1.Font = New System.Drawing.Font("Calibri", 9.75!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(45.41667!, 32.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(150.2361!, 17.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "XrLabel1"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IMPRIMIR.Precio", "{0:c2}")})
        Me.XrLabel4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(60.36112!, 122.4305!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(94.63892!, 16.93052!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "XrLabel4"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 122.4305!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(50.36111!, 16.93052!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "P.V.P.:"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel2
        '
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IMPRIMIR.Descripcion")})
        Me.XrLabel2.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 15.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(185.6528!, 17.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "XrLabel2"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        'DsEtiquetas
        '
        Me.DsEtiquetas.DataSetName = "dsEtiquetas"
        Me.DsEtiquetas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Prefijo
        '
        Me.Prefijo.Name = "Prefijo"
        '
        'Articulo
        '
        Me.Articulo.DataMember = "IMPRIMIR"
        Me.Articulo.Expression = "'CODIGO: ' + [CodigoArticulo]"
        Me.Articulo.Name = "Articulo"
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 10.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 10.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'InfListadoEtiquetas
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CodigoBarras, Me.Articulo})
        Me.DataMember = "IMPRIMIR"
        Me.DataSource = Me.DsEtiquetas
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(10, 10, 10, 10)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Prefijo})
        Me.Version = "13.2"
        CType(Me.DsEtiquetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents CodigoBarras As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Prefijo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DsEtiquetas As AydaraTPV.dsEtiquetas
    Friend WithEvents Articulo As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrShape2 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrShape1 As DevExpress.XtraReports.UI.XRShape
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
End Class
