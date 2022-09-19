Partial Class dsRepresentantes

    Public Sub Cargar(Optional Filtro As String = "")
        Try
            Dim taRepresentantes As New dsRepresentantesTableAdapters.REPRESENTableAdapter

            If Filtro <> String.Empty Then
                taRepresentantes.daRepresentantes.SelectCommand.CommandText &= " WHERE " & Filtro
            End If

            taRepresentantes.Fill(Me.REPRESEN)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class

Namespace dsRepresentantesTableAdapters
    Partial Public Class REPRESENTableAdapter
        Public ReadOnly Property daRepresentantes() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class
End Namespace

