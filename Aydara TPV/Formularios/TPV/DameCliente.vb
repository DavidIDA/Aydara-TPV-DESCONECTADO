Public Class DameCliente
    Implements ITeclado

    Public CodigoCliente As Integer = 0
    Public ComprobarCodigo As Boolean = True

#Region "DameCliente_Shown"
    Private Sub DameCliente_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.TecladoNumerico.fPadre = Me
        Me.txtCodigoCliente.Focus()
        'System.Console.Beep()
        Me.txtCodigoCliente.SelectAll()
        Me.txtCodigoCliente.IsModified = True
    End Sub
#End Region

#Region "DameCliente_FormClosing"
    Private Sub DameCliente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'TecladoNumericoAnterior.Dispose()
    End Sub
#End Region

#Region "txtCodigoCliente_Validated"
    Private Sub txtCodigoCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCliente.Validated

        If Me.txtCodigoCliente.EditValue = String.Empty Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Exit Sub
        End If

        If Not ComprobarCodigo Then
            Me.CodigoCliente = Me.txtCodigoCliente.EditValue
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Exit Sub
        End If

        Try
            Dim Codigo As Integer = Me.CompruebaCodigo(Me.txtCodigoCliente.EditValue)

            If Codigo <> 0 Then

                Me.CodigoCliente = Codigo
                Me.CompruebaPdteCobro()
                Me.DialogResult = Windows.Forms.DialogResult.OK

            Else

                TecladoNumericoAnterior.TopMost = False
                MsgBox("No hay ningún cliente con ese código", MsgBoxStyle.Information, "No está disponible")
                TecladoNumericoAnterior.TopMost = True
                Me.txtCodigoCliente.EditValue = String.Empty
                Me.txtCodigoCliente.Focus()

            End If

        Catch ex As Exception
            MsgBox("Error al seleccionar el cliente")
        End Try

    End Sub
#End Region

#Region "txtCodigoCliente_ButtonClick"
    Private Sub txtCodigoCliente_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoCliente.ButtonClick
        Try

            Dim dsClientes As New dsClientes, tClientes As New dsClientesTableAdapters.CLIENTESTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("NombreFiscal")
            Columnas.Add("Nombre Fiscal")
            Columnas.Add(200)
            Columnas.Add(200)

            Columnas.Add("Direccion")
            Columnas.Add("Dirección")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("TelParticular")
            Columnas.Add("Teléfono")
            Columnas.Add(100)
            Columnas.Add(100)

            Columnas.Add("CIF")
            Columnas.Add("N.I.F.")
            Columnas.Add(100)
            Columnas.Add(100)

            tClientes.Activos(dsClientes.CLIENTES)
            
            If Buscar(dsClientes, "CLIENTES", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.CodigoCliente = ResultadoBusqueda
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "Teclado"
    Public Sub DevuelveFoco() Implements ITeclado.DevuelveFoco
        Me.txtCodigoCliente.Focus()
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

#Region "CompruebaCodigo"
    Private Function CompruebaCodigo(Codigo As Integer) As Integer

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT COUNT(Codigo) FROM CLIENTES WHERE Codigo=" & Codigo

            If cmd.ExecuteScalar = 0 Then

                If Codigo < 27500000 Then

                    Codigo += 27500000

                    cmd.CommandText = "SELECT COUNT(Codigo) FROM CLIENTES WHERE Codigo=" & Codigo

                    If cmd.ExecuteScalar > 0 Then Return Codigo

                Else
                    Return 0
                End If

            Else
                Return Codigo
            End If

        Catch ex As Exception
            Return 0
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try
    End Function
#End Region

#Region "CompruebaPdteCobro"
    Private Sub CompruebaPdteCobro()

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT ISNULL(SUM(ImporteTicket-ImporteCobrado),0) FROM PENDIENTES_COBRO WHERE CodigoCliente=" & Me.CodigoCliente

            Dim Importe As Decimal = cmd.ExecuteScalar

            If Importe <> 0 Then

                MsgBox("PENDIENTE DE COBRO: " & Math.Round(Importe, 2) & "€", MsgBoxStyle.Information)

            End If

        Catch ex As Exception
            Throw ex
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try
    End Sub
#End Region

End Class