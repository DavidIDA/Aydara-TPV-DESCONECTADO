Partial Class dsFamilias

    Public Sub Cargar()
        Try
            Dim taFamilias As New dsFamiliasTableAdapters.FAMILIASTableAdapter
            taFamilias.Fill(Me.FAMILIAS)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
