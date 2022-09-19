Partial Class dsTPVConfiguracion

    Public Sub Cargar()
        Try
            Dim taConfig As New dsTPVConfiguracionTableAdapters.IDA_AYDARATPVTableAdapter
            taConfig.Fill(Me.IDA_AYDARATPV)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
