Public Class Teclado

    Public Event DevuelveFoco()
    Public Event BotonCaracter(ByVal valor As String)
    Public Event BotonFuncion()

    Private _fPadre As ITeclado

    Public Property fPadre() As ITeclado
        Get
            Return Me._fPadre
        End Get
        Set(ByVal Value As ITeclado)
            Me._fPadre = Value
        End Set
    End Property

    Private Sub bttCaracter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttº.Click, btt0.Click, btt1.Click, btt2.Click, btt3.Click, btt4.Click, btt5.Click, btt6.Click, btt7.Click, btt8.Click, btt9.Click, bttComilla.Click, bttAbreAdmiracion.Click, bttq.Click, bttw.Click, btte.Click, bttr.Click, bttt.Click, btty.Click, bttu.Click, btti.Click, btto.Click, bttp.Click, bttComillaInversa.Click, bttMas.Click, btta.Click, btts.Click, bttd.Click, bttf.Click, bttg.Click, btth.Click, bttj.Click, bttk.Click, bttl.Click, bttñ.Click, bttTilde.Click, bttç.Click, bttMenorMayor.Click, bttz.Click, bttx.Click, bttc.Click, bttv.Click, bttb.Click, bttn.Click, bttm.Click, bttComa.Click, bttPunto.Click, bttGuion.Click, bttEspacio.Click
        Dim valor As String = sender.Text
        If valor = "+" Or valor = "%" Or valor = "(" Or valor = ")" Or valor = "^" Then
            valor = "{" & valor & "}"
        End If
        Me._fPadre.DevuelveFoco()
        Me._fPadre.BotonCaracter(valor)
    End Sub

    Private Sub bttBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBorrar.Click
        Me._fPadre.BotonFuncion(Keys.Back)
    End Sub

    Private Sub bttIntro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttIntro.Click
        Me._fPadre.BotonFuncion(Keys.Enter)
    End Sub

    Private Sub bttMayusculas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttMayusculas.Click
        Me.bttMayusculas.Tag = IIf(Me.bttMayusculas.Tag = "MAY", "MIN", "MAY")
        Me.bttMayusculas.ButtonStyle = IIf(Me.bttMayusculas.Tag = "MAY", DevExpress.XtraEditors.Controls.BorderStyles.Office2003, DevExpress.XtraEditors.Controls.BorderStyles.Default)
        Me.bttq.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttq.Text), LCase(Me.bttq.Text))
        Me.bttw.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttw.Text), LCase(Me.bttw.Text))
        Me.btte.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.btte.Text), LCase(Me.btte.Text))
        Me.bttr.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttr.Text), LCase(Me.bttr.Text))
        Me.bttt.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttt.Text), LCase(Me.bttt.Text))
        Me.btty.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.btty.Text), LCase(Me.btty.Text))
        Me.bttu.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttu.Text), LCase(Me.bttu.Text))
        Me.btti.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.btti.Text), LCase(Me.btti.Text))
        Me.btto.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.btto.Text), LCase(Me.btto.Text))
        Me.bttp.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttp.Text), LCase(Me.bttp.Text))
        Me.btta.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.btta.Text), LCase(Me.btta.Text))
        Me.btts.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.btts.Text), LCase(Me.btts.Text))
        Me.bttd.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttd.Text), LCase(Me.bttd.Text))
        Me.bttf.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttf.Text), LCase(Me.bttf.Text))
        Me.bttg.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttg.Text), LCase(Me.bttg.Text))
        Me.btth.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.btth.Text), LCase(Me.btth.Text))
        Me.bttj.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttj.Text), LCase(Me.bttj.Text))
        Me.bttk.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttk.Text), LCase(Me.bttk.Text))
        Me.bttl.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttl.Text), LCase(Me.bttl.Text))
        Me.bttñ.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttñ.Text), LCase(Me.bttñ.Text))
        Me.bttç.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttç.Text), LCase(Me.bttç.Text))
        Me.bttz.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttz.Text), LCase(Me.bttz.Text))
        Me.bttx.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttx.Text), LCase(Me.bttx.Text))
        Me.bttc.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttc.Text), LCase(Me.bttc.Text))
        Me.bttv.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttv.Text), LCase(Me.bttv.Text))
        Me.bttb.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttb.Text), LCase(Me.bttb.Text))
        Me.bttn.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttn.Text), LCase(Me.bttn.Text))
        Me.bttm.Text = IIf(Me.bttMayusculas.Tag = "MAY", UCase(Me.bttm.Text), LCase(Me.bttm.Text))
    End Sub

    Private Sub bttShiftIzq_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttShiftIzq.Click, bttShiftDer.Click
        Me.bttShiftIzq.Tag = IIf(Me.bttShiftIzq.Tag = "ON", "OFF", "ON")
        Me.bttShiftIzq.ButtonStyle = IIf(Me.bttShiftIzq.Tag = "ON", DevExpress.XtraEditors.Controls.BorderStyles.Office2003, DevExpress.XtraEditors.Controls.BorderStyles.Default)
        Me.bttShiftDer.ButtonStyle = IIf(Me.bttShiftIzq.Tag = "ON", DevExpress.XtraEditors.Controls.BorderStyles.Office2003, DevExpress.XtraEditors.Controls.BorderStyles.Default)
        Me.bttAlt.Tag = "OFF"
        Me.bttAlt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
        Me.bttº.Text = IIf(Me.bttShiftIzq.Tag = "ON", "ª", "º")
        Me.btt1.Text = IIf(Me.bttShiftIzq.Tag = "ON", "!", "1")
        Me.btt2.Text = IIf(Me.bttShiftIzq.Tag = "ON", """", "2")
        Me.btt3.Text = IIf(Me.bttShiftIzq.Tag = "ON", "·", "3")
        Me.btt4.Text = IIf(Me.bttShiftIzq.Tag = "ON", "$", "4")
        Me.btt5.Text = IIf(Me.bttShiftIzq.Tag = "ON", "%", "5")
        Me.btt6.Text = IIf(Me.bttShiftIzq.Tag = "ON", "&&", "6")
        Me.btt7.Text = IIf(Me.bttShiftIzq.Tag = "ON", "/", "7")
        Me.btt8.Text = IIf(Me.bttShiftIzq.Tag = "ON", "(", "8")
        Me.btt9.Text = IIf(Me.bttShiftIzq.Tag = "ON", ")", "9")
        Me.btt0.Text = IIf(Me.bttShiftIzq.Tag = "ON", "=", "0")
        Me.bttComilla.Text = IIf(Me.bttShiftIzq.Tag = "ON", "?", "'")
        Me.bttAbreAdmiracion.Text = IIf(Me.bttShiftIzq.Tag = "ON", "¿", "¡")
        Me.btte.Text = "e"
        Me.bttComillaInversa.Text = IIf(Me.bttShiftIzq.Tag = "ON", "^", "`")
        Me.bttMas.Text = IIf(Me.bttShiftIzq.Tag = "ON", "*", "+")
        Me.bttTilde.Text = IIf(Me.bttShiftIzq.Tag = "ON", "¨", "´")
        Me.bttç.Text = "ç"
        Me.bttMenorMayor.Text = IIf(Me.bttShiftIzq.Tag = "ON", ">", "<")
        Me.bttComa.Text = IIf(Me.bttShiftIzq.Tag = "ON", ";", ",")
        Me.bttPunto.Text = IIf(Me.bttShiftIzq.Tag = "ON", ":", ".")
        Me.bttGuion.Text = IIf(Me.bttShiftIzq.Tag = "ON", "_", "-")
    End Sub

    Private Sub bttAlt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAlt.Click
        Me.bttAlt.Tag = IIf(Me.bttAlt.Tag = "ON", "OFF", "ON")
        Me.bttAlt.ButtonStyle = IIf(Me.bttAlt.Tag = "ON", DevExpress.XtraEditors.Controls.BorderStyles.Office2003, DevExpress.XtraEditors.Controls.BorderStyles.Default)
        Me.bttShiftIzq.Tag = "OFF"
        Me.bttShiftIzq.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
        Me.bttShiftDer.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default
        Me.bttº.Text = IIf(Me.bttAlt.Tag = "ON", "\", "º")
        Me.btt1.Text = IIf(Me.bttAlt.Tag = "ON", "|", "1")
        Me.btt2.Text = IIf(Me.bttAlt.Tag = "ON", "@", "2")
        Me.btt3.Text = IIf(Me.bttAlt.Tag = "ON", "#", "3")
        Me.btt4.Text = IIf(Me.bttAlt.Tag = "ON", "", "4")
        Me.btt5.Text = IIf(Me.bttAlt.Tag = "ON", "", "5")
        Me.btt6.Text = IIf(Me.bttAlt.Tag = "ON", "¬", "6")
        Me.btt7.Text = IIf(Me.bttAlt.Tag = "ON", "", "7")
        Me.btt8.Text = IIf(Me.bttAlt.Tag = "ON", "", "8")
        Me.btt9.Text = IIf(Me.bttAlt.Tag = "ON", "", "9")
        Me.btt0.Text = IIf(Me.bttAlt.Tag = "ON", "", "0")
        Me.bttComilla.Text = IIf(Me.bttAlt.Tag = "ON", "", "'")
        Me.bttAbreAdmiracion.Text = IIf(Me.bttAlt.Tag = "ON", "", "¡")
        Me.btte.Text = IIf(Me.bttAlt.Tag = "ON", "€", "e")
        Me.bttComillaInversa.Text = IIf(Me.bttAlt.Tag = "ON", "[", "`")
        Me.bttMas.Text = IIf(Me.bttAlt.Tag = "ON", "]", "+")
        Me.bttTilde.Text = IIf(Me.bttAlt.Tag = "ON", "{", "´")
        Me.bttç.Text = IIf(Me.bttAlt.Tag = "ON", "}", "´")
        Me.bttMenorMayor.Text = IIf(Me.bttAlt.Tag = "ON", "", "<")
        Me.bttComa.Text = IIf(Me.bttAlt.Tag = "ON", "", ",")
        Me.bttPunto.Text = IIf(Me.bttAlt.Tag = "ON", "", ".")
        Me.bttGuion.Text = IIf(Me.bttAlt.Tag = "ON", "", "-")
    End Sub

    Private Sub bttCerrarTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCerrarTeclado.Click
        Me.Close()
    End Sub

End Class