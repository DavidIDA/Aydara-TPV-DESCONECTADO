Public Class TecladoNumerico

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

    Private Sub bttNumero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btt0.Click, btt1.Click, btt2.Click, btt3.Click, btt4.Click, btt5.Click, btt6.Click, btt7.Click, btt8.Click, btt9.Click, bttPunto.Click
        Me._fPadre.BotonCaracter(sender.Text)
    End Sub

    Private Sub bttMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttMenos.Click
        Me._fPadre.BotonFuncion(Keys.Subtract)
    End Sub

    Private Sub bttBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBorrar.Click
        Me._fPadre.BotonFuncion(Keys.Back)
    End Sub

    Private Sub bttIntro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttIntro.Click
        Me._fPadre.BotonFuncion(Keys.Enter)
    End Sub

End Class
