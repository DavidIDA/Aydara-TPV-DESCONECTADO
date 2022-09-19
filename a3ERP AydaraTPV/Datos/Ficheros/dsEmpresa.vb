Partial Class dsEmpresa

    Public Function DatosConfiguracion()
        Try
            Dim taDatosConfig As New dsEmpresaTableAdapters.DATOSCONFIGTableAdapter
            taDatosConfig.Fill(Me.DATOSCONFIG)

            a3ERP.DatosConfig = Me.DATOSCONFIG(0)

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
