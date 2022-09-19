Public Class Info

#Region "Info_KeyUp"
    Private Sub Info_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.Control And e.KeyCode = Keys.N Then
            If MsgBox("¿Seguro que desea crear de nuevo la empresa?" & vbCrLf & "Perderá todos los datos de la base de datos local", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                My.Settings.CadenaConexion = "Nueva"
                My.Settings.Item("AydaraTPVConnectionString") = My.Settings.CadenaConexion
                My.Settings.Save()

                MsgBox("Reinicie la aplicación para generar la nueva empresa", MsgBoxStyle.Information)

                Principal.Tag = "update"
                Me.Close()

                Application.Exit()

            End If
        End If
    End Sub
#End Region

#Region "Info_Load"
    Private Sub Info_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim sDatosActivacion As Activacion.sDatosActivacion = Activacion.DatosActivacion

            If sDatosActivacion.DiasRestantes < 0 Then
                Me.lblDíasRestantes.Text = "La clave del producto está caducada."
                Me.bttContinuar.Visible = False
            ElseIf sDatosActivacion.DiasRestantes = 0 Then
                Me.lblDíasRestantes.Text = "SU LICENCIA CADUCA HOY."
                Me.lblDíasRestantes.ForeColor = Color.Maroon
            Else
                Me.lblDíasRestantes.Text = IIf(sDatosActivacion.CodigoActivacion <> String.Empty, "La clave del producto", "La versión de prueba") & " caduca en " & sDatosActivacion.DiasRestantes & IIf(sDatosActivacion.DiasRestantes <> 1, " días.", " día.")
            End If

            If sDatosActivacion.DiasRestantes = 999 Then Me.lblDíasRestantes.Visible = False

            Me.lblNumeroSerie.Text = Activacion.NumeroSerie
            Me.bttActivar.Text = IIf(sDatosActivacion.CodigoActivacion <> String.Empty, "Renovar", "Activar")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "bttContinuar_Click"
    Private Sub bttContinuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttContinuar.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        End Try
    End Sub
#End Region

#Region "bttActivar_Click"
    Private Sub bttActivar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttActivar.Click

        Dim dsActivaciones As New dsActivaciones

        Try
            'Comprobar código de activación
            Dim Codigo As String = Activacion.ComprobarCodigo(Mid(Me.txtCodigoActivacion.EditValue, 1, 4) & Mid(Me.txtCodigoActivacion.EditValue, 6, 4) & Mid(Me.txtCodigoActivacion.EditValue, 11, 4))

            If Codigo = Activacion.CodigoIDA Then
                If Activacion.ActivarEquipo(Me.lblNumeroSerie.Text, Mid(Me.txtCodigoActivacion.EditValue, 1, 4) & Mid(Me.txtCodigoActivacion.EditValue, 6, 4) & Mid(Me.txtCodigoActivacion.EditValue, 11, 4)) Then
                    MsgBox("El producto ha sido activado con éxito.", MsgBoxStyle.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Exit Try
                End If
            End If

            If IsDate(Codigo) Then

                Dim FechaCaducidad As Date = Codigo

                If FechaCaducidad < Date.Today Then
                    MsgBox("El código de activación ha caducado.", MsgBoxStyle.Information)
                    Me.txtCodigoActivacion.Focus()
                Else
                    If Activacion.ActivarEquipo(Me.lblNumeroSerie.Text, Mid(Me.txtCodigoActivacion.EditValue, 1, 4) & Mid(Me.txtCodigoActivacion.EditValue, 6, 4) & Mid(Me.txtCodigoActivacion.EditValue, 11, 4)) Then
                        MsgBox("El producto ha sido activado con éxito." & vbCrLf & "Licencia válida hasta el " & FechaCaducidad, MsgBoxStyle.Information)
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    Else
                        MsgBox("Error al activar el producto", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                MsgBox("El código de activación es incorrecto.", MsgBoxStyle.Exclamation)
                Me.txtCodigoActivacion.Focus()
            End If

        Catch ex As Exception
            MsgBox("Error al activar el producto", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "bttWeb_Click"
    Private Sub bttWeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttWeb.Click
        Process.Start("http://www.ida.es")
    End Sub
#End Region

#Region "bttMail_Click"
    Private Sub bttMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttMail.Click
        Process.Start("mailto:ida@ida.es")
    End Sub
#End Region

End Class