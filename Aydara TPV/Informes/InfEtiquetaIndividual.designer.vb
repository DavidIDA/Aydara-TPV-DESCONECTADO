<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class InfEtiquetaIndividual
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
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrBarCode1 = New DevExpress.XtraReports.UI.XRBarCode()
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
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrBarCode1})
        Me.Detail.KeepTogether = True
        Me.Detail.MultiColumn.ColumnSpacing = 12.0!
        Me.Detail.MultiColumn.Layout = DevExpress.XtraPrinting.ColumnLayout.AcrossThenDown
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseTextAlignment = False
        '
        'XrBarCode1
        '
        Me.XrBarCode1.AutoModule = True
        Me.XrBarCode1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "IMPRIMIR.CodigoBarras")})
        Me.XrBarCode1.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 10.00001!)
        Me.XrBarCode1.Name = "XrBarCode1"
        Me.XrBarCode1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrBarCode1.SizeF = New System.Drawing.SizeF(172.0!, 73.0!)
        Me.XrBarCode1.StylePriority.UsePadding = False
        Me.XrBarCode1.StylePriority.UseTextAlignment = False
        Me.XrBarCode1.Symbology = Code128Generator1
        Me.XrBarCode1.Text = "XrBarCode1"
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
        Me.TopMarginBand1.HeightF = 0.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 0.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'InfEtiquetaIndividual
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.CodigoBarras, Me.Articulo})
        Me.DataMember = "IMPRIMIR"
        Me.DataSource = Me.DsEtiquetas1
        Me.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 96
        Me.PageWidth = 192
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.Prefijo})
        Me.Version = "13.2"
        CType(Me.DsEtiquetas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents CodigoBarras As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents Prefijo As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents DsEtiquetas1 As AydaraTPV.dsEtiquetas
    Friend WithEvents ETIQUETASTableAdapter As AydaraTPV.dsEtiquetasTableAdapters.ETIQUETASTableAdapter
    Friend WithEvents Articulo As DevExpress.XtraReports.UI.CalculatedField
    Friend WithEvents XrBarCode1 As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
