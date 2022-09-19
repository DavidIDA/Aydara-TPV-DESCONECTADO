Partial Class dsTarifas

    Public Sub Cargar(Tipo As String)
        Try
            Dim taTarifas As New dsTarifasTableAdapters.TARIFASTableAdapter
            taTarifas.Fill(Me.TARIFAS, Tipo)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub TarifasVenta(CODART As String, UNIDADES As Double)
        Try
            Dim taTarifas As New dsTarifasTableAdapters.TARIFAVETableAdapter
            taTarifas.Fill(Me.TARIFAVE, CODART, UNIDADES)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
