Public Class PreImpreso

    Private Sub PreImpreso_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Me.Text = "Listado de etiquetas" Or Me.Text = "Códigos de barras" Then
            ImpresionEtiquetasPendientes.bttEliminar_Click(Nothing, Nothing)
        End If
    End Sub

End Class