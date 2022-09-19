Public Class fDameDescripcion

    Dim _Texto As String

    Property Texto As String
        Get
            Return Me._Texto
        End Get
        Set(value As String)
            Me._Texto = value
        End Set
    End Property

    Private Sub fDameDescripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.txtDescripcion.Text = Me.Texto

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub bttAceptar_Click(sender As Object, e As EventArgs) Handles bttAceptar.Click
        Try
            Me.Texto = Me.txtDescripcion.Text
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub bttCancelar_Click(sender As Object, e As EventArgs) Handles bttCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub bttTeclado_Click(sender As Object, e As EventArgs) Handles bttTeclado.Click
        Try
            System.Diagnostics.Process.Start("osk.exe")
            Me.txtDescripcion.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

End Class