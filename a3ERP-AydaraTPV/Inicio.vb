Public Class Inicio

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Enlace As New a3ERP_AydaraTPV.a3ERP

        Try
            'Leer empresa
            If Environment.GetCommandLineArgs.Length > 1 Then
                My.Settings.Empresa = Environment.GetCommandLineArgs(1)
            End If

            If My.Settings.Empresa = String.Empty Then Exit Try

            Enlace.Iniciar("", "", My.Settings.Empresa)

            Dim LOG As New a3ERP_AydaraTPV.dsTPVLog

            Try
                LOG.Nuevo("A", "Inicio comunicación tiendas")

                Dim Recepcion As New a3ERP_AydaraTPV.dsTPVRecepcion
                Recepcion.ModoActualizacion = a3ERP_AydaraTPV.dsTPVRecepcion.TipoActualizacion.Automatico
                Recepcion.Recepcionar()
                Recepcion.LeerFicheros()

                Dim Envio As New a3ERP_AydaraTPV.dsTPVEnvio
                Envio.Enviar()

            Catch ex As Exception
                'MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                LOG.Nuevo("X", ex.Message)
            Finally
                Enlace.Finalizar()
                LOG.Nuevo("A", "Fin comunicación tiendas")
            End Try

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Inicio_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Close()
    End Sub

End Class
