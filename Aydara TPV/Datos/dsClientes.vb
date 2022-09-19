Partial Class dsClientes

    Partial Class CLIENTESDataTable

        Private Sub CLIENTESDataTable_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanged
            Try
                RemoveHandler Me.ColumnChanged, AddressOf CLIENTESDataTable_ColumnChanged

                If e.Column Is Me.columnClienteCredito Then

                    If IsDBNull(e.ProposedValue) Then Exit Try

                    Dim rTarjeta As dsClientes.CLIENTESRow = e.Row
                    'If rTarjeta.NombreFiscal <> String.Empty Then Exit Try

                    Dim taClienteCredito As New dsClientesTableAdapters.CLICREDITableAdapter
                    Dim dtClienteCredito As New dsClientes.CLICREDIDataTable
                    taClienteCredito.FillBy(dtClienteCredito, e.ProposedValue)

                    If dtClienteCredito.Count > 0 Then
                        With dtClienteCredito(0)
                            rTarjeta.ClienteCredito = .Codigo
                            If Not .IsNombreFiscalNull Then rTarjeta.NombreFiscal = .NombreFiscal
                            If Not .IsDireccionNull Then rTarjeta.Direccion = .Direccion
                            If Not .IsCodigoPostalNull Then rTarjeta.CodigoPostal = .CodigoPostal
                            If Not .IsPoblacionNull Then rTarjeta.Poblacion = .Poblacion
                            If Not .IsProvinciaNull Then rTarjeta.Provincia = .Provincia
                            If Not .IsNifNull Then rTarjeta.CIF = .Nif
                            If Not .IsTelParticularNull Then rTarjeta.TelParticular = .TelParticular
                            If Not .IsTelMovilNull Then rTarjeta.TelMovil = .TelMovil
                            If Not .IsEmailNull Then rTarjeta.Email = .Email
                        End With
                    End If

                End If

            Catch ex As Exception
                Throw ex
            Finally
                AddHandler Me.ColumnChanged, AddressOf CLIENTESDataTable_ColumnChanged
            End Try
        End Sub

    End Class

    Public Sub Nuevo(Optional CliCredi As String = "")
        Try
            Me.CLIENTES.Clear()

            Dim rCliente As dsClientes.CLIENTESRow = Me.CLIENTES.NewCLIENTESRow
            Dim taClientes As New dsClientesTableAdapters.CLIENTESTableAdapter

            With rCliente
                .Codigo = taClientes.UltimoCodigo + 1
                If CliCredi <> 0 Then .ClienteCredito = CliCredi
            End With

            Me.CLIENTES.AddCLIENTESRow(rCliente)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
