Public Class PreImpreso

    Dim _Report As DevExpress.XtraReports.UI.XtraReport

    Private Property Report() As DevExpress.XtraReports.UI.XtraReport
        Get
            Return Me._Report
        End Get
        Set(value As DevExpress.XtraReports.UI.XtraReport)
            Me._Report = value
        End Set
    End Property

    Public Sub New(Optional Report As DevExpress.XtraReports.UI.XtraReport = Nothing)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Report = Report

    End Sub

    Private Sub bttDefinir_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles bttDefinir.ItemClick

        'If Me.Report Is Nothing Then Exit Sub

        'Dim fDefinir As New DefineReport

        'Try
        '    Me.Report.DisplayName = Me.Report.Name
        '    fDefinir.ReportDesigner1.OpenReport(Me.Report)
        '    fDefinir.ShowDialog()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        'End Try

    End Sub

End Class