Partial Class dsValesTienda

    Dim taVales As New dsValesTiendaTableAdapters.VALES_TIENDATableAdapter

    Public Sub Actualizar()
        Try
            Me.taVales.Update(Me.VALES_TIENDA)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function DameUltimoVale() As Integer
        Try
            Dim miview As New DataView
            miview.Table = Me.VALES_TIENDA
            miview.Sort = "CodigoVale DESC"

            If miview.Count > 0 Then
                Return CType(miview(0).Row, VALES_TIENDARow).CodigoVale
            Else
                Return -1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
End Class
