Partial Class dsTiposIVA

    Public Sub Cargar()
        Try
            Dim taTiposIVA As New dsTiposIVATableAdapters.TIPOIVATableAdapter
            taTiposIVA.Fill(Me.TIPOIVA)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
