Public Class Configuracion 

#Region "Configuracion_KeyUp"
    Private Sub Configuracion_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "bttGuardar_Click"
    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click
        DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(Me.cmbApariencia.Text)
        My.Settings.Apariencia = Me.cmbApariencia.Text
        My.Settings.Save()
    End Sub
#End Region

End Class