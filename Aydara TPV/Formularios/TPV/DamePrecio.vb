Public Class DamePrecio
    Implements ITeclado

    Private Sub DamePrecio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then txtPrecio_Validated(Nothing, Nothing)
    End Sub

    Private Sub DamePrecio_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.txtPrecio.Properties.Mask.EditMask = "c" & DecimalesPrecio
    End Sub

#Region "DamePrecio_Shown"
    Private Sub DamePrecio_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.TecladoNumerico.fPadre = Me
        Me.txtPrecio.Focus()
        'System.Console.Beep()
        Me.txtPrecio.SelectAll()
        Me.txtPrecio.IsModified = True
    End Sub
#End Region

#Region "DamePrecio_FormClosing"
    Private Sub DamePrecio_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'TecladoNumericoAnterior.Dispose()
    End Sub
#End Region

#Region "txtPrecio_Validated"
    Private Sub txtPrecio_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecio.Validated
        Try
            If Not IsNumeric(Me.txtPrecio.EditValue) Then Exit Sub

            If Me.txtPrecio.EditValue.ToString.Length = 13 Then
                If Me.txtPrecio.Text.Substring(0, 1) = "2" Then
                    Me.txtPrecio.EditValue = Me.txtPrecio.EditValue.ToString.Substring(8, 4) / 100
                End If
            End If

            If Me.txtPrecio.EditValue > 999999 Then Exit Sub

            ResultadoBusqueda = Me.txtPrecio.EditValue
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MsgBox("Error al seleccionar el precio")
        End Try
    End Sub
#End Region

#Region "Teclado"
    Public Sub DevuelveFoco() Implements ITeclado.DevuelveFoco
        Me.txtPrecio.Focus()
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