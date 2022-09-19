Public Class DameEmpleado
    Implements ITeclado

#Region "DameEmpleado_Shown"
    Private Sub DameEmpleado_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.TecladoNumerico.fPadre = Me
        Me.txtCodigoEmpleado.Focus()
        'System.Console.Beep()
        Me.txtCodigoEmpleado.SelectAll()
        Me.txtCodigoEmpleado.IsModified = True
    End Sub
#End Region

#Region "DameEmpleado_FormClosing"
    Private Sub DameEmpleado_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'TecladoNumericoAnterior.Dispose()
    End Sub
#End Region

#Region "txtCodigoEmpleado_Validated"
    Private Sub txtCodigoEmpleado_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoEmpleado.Validated

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            If Not IsNumeric(Me.txtCodigoEmpleado.EditValue) Then Exit Try

            cmd.Connection.Open()

            cmd.CommandText = "SELECT COUNT(Codigo) FROM OPERARIOS WHERE Codigo=" & Me.txtCodigoEmpleado.EditValue

            If cmd.ExecuteScalar = 0 Then
                TecladoNumericoAnterior.TopMost = False
                MsgBox("No hay ningún empleado con ese código", MsgBoxStyle.Information, "No está disponible")
                TecladoNumericoAnterior.TopMost = True
                Me.txtCodigoEmpleado.EditValue = String.Empty
                Me.txtCodigoEmpleado.Focus()
            Else
                CodigoEmpleado = Me.txtCodigoEmpleado.EditValue
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            MsgBox("Error al seleccionar el empleado")
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Sub
#End Region

#Region "txtCodigoEmpleado_ButtonClick"
    Private Sub txtCodigoEmpleado_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoEmpleado.ButtonClick
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        'Me.Dispose()
    End Sub
#End Region

#Region "Teclado"
    Public Sub DevuelveFoco() Implements ITeclado.DevuelveFoco
        Me.txtCodigoEmpleado.Focus()
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