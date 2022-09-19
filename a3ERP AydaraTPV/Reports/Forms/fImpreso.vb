Public Class fImpreso
    Public Sub New(Report As DevExpress.XtraReports.UI.XtraReport)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.DocumentViewer.DocumentSource = Report

    End Sub

End Class