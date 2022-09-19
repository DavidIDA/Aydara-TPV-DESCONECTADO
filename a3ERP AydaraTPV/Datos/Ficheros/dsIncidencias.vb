Partial Class dsIncidencias

    Public Sub Cargar()
        Try
            Dim taIncidencias As New dsIncidenciasTableAdapters.IDA_INCIDENCIASTableAdapter
            taIncidencias.Fill(Me.IDA_INCIDENCIAS)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
