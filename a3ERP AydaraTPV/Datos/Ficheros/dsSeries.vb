Partial Class dsSeries

    Public Sub Cargar(Optional TIPOCONT As String = "")
        Try
            Dim taSeries As New dsSeriesTableAdapters.SERIESTableAdapter

            If TIPOCONT <> String.Empty Then taSeries.TipoContable(Me.SERIES, TIPOCONT)

            If Me.SERIES.Count = 0 Then taSeries.Fill(Me.SERIES)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
