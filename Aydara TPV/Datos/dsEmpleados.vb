Partial Class dsEmpleados

    Dim taEmpleados As New dsEmpleadosTableAdapters.OPERARIOSTableAdapter

#Region "Cargar"
    Public Function Cargar() As Integer
        Try
            Me.taEmpleados.Fill(Me.OPERARIOS)

            Return Me.OPERARIOS.Count
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

End Class
