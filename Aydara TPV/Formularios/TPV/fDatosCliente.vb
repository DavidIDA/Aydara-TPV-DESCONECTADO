Public Class fDatosCliente

    Dim _Nuevo As Boolean, _Codigo As Integer

    Property Nuevo As Boolean
        Get
            Return Me._Nuevo
        End Get
        Set(value As Boolean)
            Me._Nuevo = value
        End Set
    End Property

    Private Sub fDatosCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.Enter

                    Dim Teclado As Process
                    Dim Teclados As Process() = Process.GetProcessesByName("osk") 'creates an array with all running processes with the same name

                    For Each Teclado In Teclados
                        Teclado.Kill()
                    Next

                Case Keys.Escape
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttAceptar_Click(sender As Object, e As EventArgs) Handles bttAceptar.Click
        Try
            If Me.Nuevo Then
                Me.CLIENTESBindingSource.EndEdit()
                Me.CLIENTESTableAdapter.Update(Me.DsClientes.CLIENTES)
                If Me.DsClientes.CLIENTES.Count > 0 Then ResultadoBusqueda = Me.DsClientes.CLIENTES(0).Codigo
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub bttCancelar_Click(sender As Object, e As EventArgs) Handles bttCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub bttTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttTeclado.Click
        Try
            System.Diagnostics.Process.Start("osk.exe")
            Me.txtNombreFiscal.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub fDatosCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Me.Nuevo Then

                Dim CliCredi As String = Me.ClienteCredito

                If CliCredi <> String.Empty Then
                    Me.DsClientes.Nuevo(CliCredi)
                    Me.txtNombreFiscal.Focus()
                Else
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                End If

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Function ClienteCredito() As String
        Try
            Dim dsClientes As New dsClientes, tCliCredi As New dsClientesTableAdapters.CLICREDITableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("NombreFiscal")
            Columnas.Add("Nombre Fiscal")
            Columnas.Add(300)
            Columnas.Add(300)

            Columnas.Add("Direccion")
            Columnas.Add("Dirección")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("Nif")
            Columnas.Add("N.I.F.")
            Columnas.Add(100)
            Columnas.Add(100)

            tCliCredi.Fill(dsClientes.CLICREDI)

            If Buscar(dsClientes, "CLICREDI", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Return ResultadoBusqueda
            Else
                Return String.Empty
            End If

        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Private Sub fDatosCliente_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Me.Nuevo Then Me.txtNombreFiscal.Focus()
    End Sub

End Class