Public Class DameCaja
    Implements ITeclado

#Region "DameCaja_Shown"
    Private Sub DameCaja_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.TecladoNumerico.fPadre = Me
        Me.txtCodigoCaja.Focus()
        Me.txtCodigoCaja.SelectAll()
        Me.txtCodigoCaja.IsModified = True
    End Sub
#End Region

#Region "DameCaja_FormClosing"
    Private Sub DameCaja_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'TecladoNumericoAnterior.Dispose()
    End Sub
#End Region

#Region "txtCodigoCaja_Validated"
    Private Sub txtCodigoCaja_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCaja.Validated

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            If Not IsNumeric(Me.txtCodigoCaja.EditValue) Then Exit Try

            cmd.Connection.Open()
            cmd.CommandText = "SELECT COUNT(CodigoCaja) FROM CAJAS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & Me.txtCodigoCaja.EditValue
            If Not Me.Tag = CierreTienda.Name Then cmd.CommandText &= " AND CajaCerrada = 0"

            If cmd.ExecuteScalar = 0 Then
                TecladoNumericoAnterior.TopMost = False
                MsgBox("No hay ninguna caja abierta con ese código", MsgBoxStyle.Information, "No está disponible")
                TecladoNumericoAnterior.TopMost = True
                Me.txtCodigoCaja.EditValue = String.Empty
                Me.txtCodigoCaja.Focus()
            Else
                CodigoCaja = Me.txtCodigoCaja.EditValue
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MsgBox("Error al seleccionar la caja")
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            Me.Tag = String.Empty
        End Try

    End Sub
#End Region

#Region "txtCodigoCaja_ButtonClick"
    Private Sub txtCodigoCaja_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoCaja.ButtonClick
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        'Me.Dispose()
    End Sub
#End Region

#Region "Teclado"
    Public Sub DevuelveFoco() Implements ITeclado.DevuelveFoco
        Me.txtCodigoCaja.Focus()
    End Sub
    Public Sub BotonCaracter(ByVal valor As String) Implements ITeclado.BotonCaracter
        DevuelveFoco()
        SendKeys.Send(valor)
    End Sub
    Public Sub BotonFuncion(ByVal key As Keys) Implements ITeclado.BotonFuncion
        If key = Keys.Enter Then
            DevuelveFoco()
            SendKeys.Send(Chr(key))
        End If
    End Sub
#End Region

End Class