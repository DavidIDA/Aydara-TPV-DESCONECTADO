Public Class DameCantidad
    Implements ITeclado

    Private Sub DameCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then txtCantidad_Validated(Nothing, Nothing)
    End Sub

#Region "DameCantidad_Shown"
    Private Sub DameCantidad_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.TecladoNumerico.fPadre = Me
        Me.txtCantidad.Focus()
        'System.Console.Beep()
        Me.txtCantidad.SelectAll()
        Me.txtCantidad.IsModified = True
    End Sub
#End Region

#Region "DameCantidad_FormClosing"
    Private Sub DameCantidad_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'TecladoNumericoAnterior.Dispose()
    End Sub
#End Region

#Region "txtCantidad_Validated"
    Private Sub txtCantidad_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.Validated
        Try
            If Not IsNumeric(Me.txtCantidad.EditValue) Then Exit Sub
            If Me.txtCantidad.EditValue = 0 Or Me.txtCantidad.EditValue > 999999 Then Exit Sub
            ResultadoBusqueda = Me.txtCantidad.EditValue
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MsgBox("Error al seleccionar el cantidad")
        End Try
    End Sub
#End Region

#Region "Teclado"
    Public Sub DevuelveFoco() Implements ITeclado.DevuelveFoco
        Me.txtCantidad.Focus()
    End Sub
    Public Sub BotonCaracter(ByVal valor As String) Implements ITeclado.BotonCaracter
        DevuelveFoco()
        SendKeys.Send(valor)
    End Sub
    Public Sub BotonFuncion(ByVal key As Keys) Implements ITeclado.BotonFuncion
        DevuelveFoco()
        If key = Keys.Subtract And IsNumeric(Me.txtCantidad.EditValue) Then Me.txtCantidad.EditValue *= -1 : Exit Sub
        SendKeys.Send(Chr(key))
    End Sub
#End Region

End Class