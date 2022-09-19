Partial Class dsTiposOperacion

    Public Sub Cargar()
        Try
            Dim taTiposOperacion As New dsTiposOperacionTableAdapters.REGIVATableAdapter
            taTiposOperacion.Fill(Me.REGIVA)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
