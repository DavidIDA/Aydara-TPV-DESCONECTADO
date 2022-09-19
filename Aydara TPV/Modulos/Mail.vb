Imports System.IO.Compression.DeflateStream

Module Mail
    Public WithEvents oSession As New OSPOP3.Session
    Public bHeadersOnly As Boolean
    Dim bItem As Boolean

#Region "ConectarSesion"
    Public Sub ConectarSesion()
        If oSession.OpenPOP3(General.Comunicaciones_Direccion, 110, General.Comunicaciones_Usuario, General.Comunicaciones_Password) Then
            LeerCorreos()
            oSession.ClosePOP3()
        Else
            MsgBox("Error al conectar", MsgBoxStyle.Critical, "Error de conexión")
        End If
    End Sub
#End Region

#Region "LeerCorreos"
    Private Sub LeerCorreos()
        oSession.GetMailboxSize()

        Dim m As New OSPOP3.Message
        Dim a As OSPOP3.Attachment
        Dim i As Integer

        For i = 1 To oSession.GetMessageCount
            m = oSession.GetMessage(i)
            For Each a In m.Attachments
                If a.Filename = "envio.zip" Or Mid(a.Filename, 1, 4) = "al" & Format(General.NumeroAlmacen, "00") Then
                    a.Save(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\" & a.Filename)
                    oSession.DeleteMessage(i)
                    i = oSession.GetMessageCount + 1
                End If
            Next
        Next

    End Sub
#End Region

#Region "EnviarEMail"
    Public Function EnviarEMail(ByVal strOrigen As String, ByVal strDestinatario As String, ByVal strCopia As String, ByVal strCopiaOculta As String, ByVal strAsunto As String, ByVal strMsg As String, ByVal Adjunto As String, ByVal intPrioridad As Integer)

        Dim email As New System.Net.Mail.MailMessage
        Dim strHostAddress As String = General.Comunicaciones_Direccion
        Dim objsmtp As New System.Net.Mail.SmtpClient
        'Dim attachment As Attachment
        Try

            objsmtp.Host = strHostAddress
            If strHostAddress = "smtp.live.com" Then objsmtp.EnableSsl = True
            objsmtp.Credentials = New System.Net.NetworkCredential(General.Comunicaciones_Usuario, General.Comunicaciones_Password)

            email.From = New Net.Mail.MailAddress(strOrigen)

            email.To.Add(strDestinatario)
            If strCopia <> String.Empty Then email.CC.Add(strCopia)
            If strCopiaOculta <> String.Empty Then email.Bcc.Add(strCopiaOculta)
            email.Subject = strAsunto

            email.Body = strMsg

            Dim Attachment As System.Net.Mail.Attachment

            If Adjunto <> String.Empty Then
                Attachment = New System.Net.Mail.Attachment(Adjunto)
                email.Attachments.Add(Attachment)
            End If

            Attachment = Nothing
            'email.Attachments(0).CreateAttachmentFromString("C:\Documents and Settings\Roberto\Escritorio\Talleres IBERAUTO\Aydara Talleres\Aydara Talleres\LogoIda.ico", "Logo")

            email.IsBodyHtml = True

            If intPrioridad = 1 Then

                email.Priority = Net.Mail.MailPriority.Low
            ElseIf intPrioridad = 2 Then

                email.Priority = Net.Mail.MailPriority.High
            Else

                email.Priority = Net.Mail.MailPriority.Normal
            End If

            objsmtp.Send(email)

            email.Dispose()

            Return True

        Catch ex As System.Exception
            Return False
            'System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Function
#End Region

End Module
