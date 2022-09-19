Partial Class dsSorteos

    Dim _SorteoActivo As dsSorteos.SORTEOSRow

    Property SorteoActivo As dsSorteos.SORTEOSRow
        Get
            Return Me._SorteoActivo
        End Get
        Set(value As dsSorteos.SORTEOSRow)
            Me._SorteoActivo = value
        End Set
    End Property

    Public Sub Cargar()
        Try
            Dim taSorteos As New dsSorteosTableAdapters.SORTEOSTableAdapter

            taSorteos.Fill(Me.SORTEOS)

            For i As Integer = 0 To Me.SORTEOS.Count - 1
                If Me.SORTEOS(i).FechaInicio <= Date.Today And Me.SORTEOS(i).FechaFin >= Date.Today Then
                    Me.SorteoActivo = Me.SORTEOS(i)
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
