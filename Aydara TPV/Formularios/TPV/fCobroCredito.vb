Public Class fCobroCredito

    Dim _TipoCobro As String

    Property TipoCobro As String
        Get
            Return Me._TipoCobro
        End Get
        Set(value As String)
            Me._TipoCobro = value
        End Set
    End Property

    Private Sub fCobroCredito_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Escape
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Case Keys.F1
                Me.bttCobroFactura_Click(Me.bttEfectivoFactura, Nothing)
            Case Keys.F2
                Me.bttCobroFactura_Click(Me.bttTarjetaFactura, Nothing)
            Case Keys.F4
                Me.bttCobroFactura_Click(Me.bttPendienteFactura, Nothing)
        End Select
    End Sub

    Private Sub bttCobroFactura_Click(sender As Object, e As EventArgs) Handles bttEfectivoFactura.Click, bttTarjetaFactura.Click, bttPendienteFactura.Click
        Try
            Me.TipoCobro = sender.tag
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

End Class