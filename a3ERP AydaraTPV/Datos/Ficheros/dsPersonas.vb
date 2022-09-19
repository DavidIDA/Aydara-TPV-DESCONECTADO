Partial Class dsPersonas

    Public Sub Cargar()
        Try
            Dim taPersonas As New dsPersonasTableAdapters.PERSONATableAdapter
            taPersonas.Fill(Me.PERSONA)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
