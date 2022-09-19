Public Class InfTicket

    Dim total As Double

    Private Sub txtSumaSigue_SummaryGetResult(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.SummaryGetResultEventArgs)
        e.Result = total
        e.Handled = True
    End Sub

    Private Sub txtSumaSigue_SummaryRowChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        total += Convert.ToDouble(GetCurrentColumnValue("Importe"))
    End Sub

End Class