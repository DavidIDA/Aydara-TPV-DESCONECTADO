Partial Class dsAlbaranesCompras

    Public Sub InfoArticulo(ByVal CodigoProveedor As Integer, ByVal CodigoArticulo As String)

        Dim InfoArticulo As New dsAlbaranesComprasTableAdapters.INFO_ARTICULOTableAdapter

        Try
            InfoArticulo.Fill(Me.INFO_ARTICULO, CodigoProveedor, CodigoArticulo)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
