Public Class ActualizandoTienda

    Dim WithEvents Espera As New Timer
    Dim cmd As New SqlClient.SqlCommand

    Private Sub bttSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttSalir.Click
        If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        Me.DialogResult = Windows.Forms.DialogResult.Abort
    End Sub

    Private Sub ActualizandoTienda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()
        cmd.CommandText = "SELECT Actualizando FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
        Espera.Interval = 5000
        Espera.Start()
    End Sub

    Private Sub Espera_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Espera.Tick
        'Comprobar si ha terminado el proceso
        If Not CType(cmd.ExecuteScalar, Boolean) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub imgAbrirTienda_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles imgAbrirTienda.MouseClick
        If MsgBox("¿Seguro que desea desbloquear la tienda?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim cmd As New SqlClient.SqlCommand

            Try
                cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                cmd.Connection.Open()

                cmd.CommandText = "UPDATE TIENDAS SET Actualizando = 0 WHERE CodigoTienda=" & CodigoTienda

                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Error al intentar desbloquear la tienda", MsgBoxStyle.Exclamation)
            Finally
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End Try

        End If
    End Sub

End Class