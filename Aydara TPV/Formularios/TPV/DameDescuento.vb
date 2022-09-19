Public Class DameDescuento
    Implements ITeclado

    Private Sub DameDescuento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then txtDescuento_Validated(Nothing, Nothing)
    End Sub

#Region "DameDescuento_Shown"
    Private Sub DameDescuento_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.TecladoNumerico.fPadre = Me
        Me.txtDescuento.Focus()
        'System.Console.Beep()
        Me.txtDescuento.SelectAll()
        Me.txtDescuento.IsModified = True
    End Sub
#End Region

#Region "DameDescuento_FormClosing"
    Private Sub DameDescuento_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'TecladoNumericoAnterior.Dispose()
    End Sub
#End Region

#Region "txtDescuento_Validated"
    Private Sub txtDescuento_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescuento.Validated
        Try
            If Not IsNumeric(Me.txtDescuento.EditValue) Then Exit Sub
            If Me.txtDescuento.EditValue > 999999 Then Exit Sub
            ResultadoBusqueda = Me.txtDescuento.EditValue
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgBox("Error al seleccionar el descuento")
        End Try
    End Sub
#End Region

#Region "Teclado"
    Public Sub DevuelveFoco() Implements ITeclado.DevuelveFoco
        Me.txtDescuento.Focus()
    End Sub
    Public Sub BotonCaracter(ByVal valor As String) Implements ITeclado.BotonCaracter
        DevuelveFoco()
        SendKeys.Send(valor)
    End Sub
    Public Sub BotonFuncion(ByVal key As Keys) Implements ITeclado.BotonFuncion
        DevuelveFoco()
        If key = Keys.Subtract Then Exit Sub
        SendKeys.Send(Chr(key))
    End Sub
#End Region

End Class