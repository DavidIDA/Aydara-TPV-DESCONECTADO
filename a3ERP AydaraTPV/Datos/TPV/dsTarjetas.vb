Partial Class dsTarjetas

    Dim taTarjetas As New dsTarjetasTableAdapters.IDA_TARJETASTableAdapter

    Public Event ActualizaDatos()

    Public Sub AddEvents()
        AddHandler Me.IDA_TARJETAS.ColumnChanged, AddressOf Me.IDA_TARJETAS.IDA_TARJETASDataTable_ColumnChanged
    End Sub

    Public Sub RemoveEvents()
        RemoveHandler Me.IDA_TARJETAS.ColumnChanged, AddressOf Me.IDA_TARJETAS.IDA_TARJETASDataTable_ColumnChanged
    End Sub

#Region "Funciones"
    Public Sub Cargar()
        Try
            Me.RemoveEvents()

            taTarjetas.Fill(Me.IDA_TARJETAS)

        Catch ex As Exception
            Throw ex
        Finally
            Me.AddEvents()
        End Try
    End Sub

    Public Sub Guardar()
        Try
            Me.RemoveEvents()

            Me.taTarjetas.Update(Me.IDA_TARJETAS)

        Catch ex As Exception
            Throw ex
        Finally
            Me.AddEvents()
        End Try
    End Sub

    Public Sub Cancelar()
        Try
            Me.RejectChanges()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region

#Region "Eventos Dataset"
    Public Sub onActualizaDatos()
        RaiseEvent ActualizaDatos()
    End Sub
#End Region

#Region "Eventos tarjetas"
    Partial Class IDA_TARJETASDataTable
        Public Sub IDA_TARJETASDataTable_ColumnChanged(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanged
            Try
                DirectCast(Me.DataSet, dsTarjetas).RemoveEvents()

                If e.Column Is Me.columnCODCLI Then

                    With DirectCast(e.Row, dsTarjetas.IDA_TARJETASRow)

                        If Not .IsCODCLINull Then

                            Dim Cliente As New dsClientes
                            Dim rCliente As dsClientes.CLIENTESRow

                            Cliente.Cargar(Aydara.SentenciaSQL("SELECT CODCLI FROM CLIENTES WHERE LTRIM(CODCLI) = '" & .CODCLI.Trim & "'"))

                            If Cliente.CLIENTES.Count > 0 Then

                                rCliente = Cliente.CLIENTES(0)

                                .CODCLI = rCliente.CODCLI
                                .NOMCLI = rCliente.NOMCLI
                                If Not rCliente.IsDIRCLINull Then .DIRCLI = rCliente.DIRCLI
                                If Not rCliente.IsDTOCLINull Then .DTOCLI = rCliente.DTOCLI
                                If Not rCliente.IsPOBCLINull Then .POBCLI = rCliente.POBCLI
                                If Not rCliente.IsCODPROVINull Then .POVCLI = rCliente.CODPROVI
                                If Not rCliente.IsNIFCLINull Then .NIFCLI = rCliente.NIFCLI
                                If Not rCliente.IsTELCLINull Then .TELCLI = rCliente.TELCLI

                            Else
                                .SetCODCLINull()
                            End If

                        End If

                    End With

                End If

            Catch ex As Exception
                Throw ex
            Finally
                DirectCast(Me.DataSet, dsTarjetas).AddEvents()
                DirectCast(Me.DataSet, dsTarjetas).onActualizaDatos()
            End Try
        End Sub

        Private Sub IDA_TARJETASDataTable_RowDeleted(sender As Object, e As DataRowChangeEventArgs) Handles Me.RowDeleted
            DirectCast(Me.DataSet, dsTarjetas).onActualizaDatos()
        End Sub
    End Class
#End Region

#Region "ImportarFichero"
    Public Sub ImportarFichero(ByVal RutaFichero As String)

        Dim sr As New IO.StreamReader(RutaFichero, System.Text.Encoding.Default)
        Dim linea() As String
        Dim TipoLinea As String = String.Empty

        Dim rTarjeta As dsTarjetas.IDA_TARJETASRow

        Dim configActual As Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture

        Try
            Aydara.Estado("Leyendo fichero de tarjetas")

            Me.RemoveEvents()

            'Configuración punto decimal
            Dim r As New Globalization.CultureInfo("es-ES")
            r.NumberFormat.CurrencyDecimalSeparator = ","
            r.NumberFormat.NumberDecimalSeparator = ","
            System.Threading.Thread.CurrentThread.CurrentCulture = r

            'Eliminar datos actuales
            Me.IDA_TARJETAS.Clear()

            'Primera línea encabezados
            sr.ReadLine()

            While Not sr.EndOfStream

                linea = Split(sr.ReadLine, vbTab)

                If linea.Length = 0 Then Continue While
                If Not IsNumeric(linea(0)) Then Continue While

                Dim CODCLI As String = Aydara.SentenciaSQL("SELECT CODCLI FROM CLIENTES WHERE LTRIM(CODCLI) = '" & linea(1).Trim & "'")

                rTarjeta = Me.IDA_TARJETAS.NewIDA_TARJETASRow

                rTarjeta.NUMTARJETA = linea(0)
                If CODCLI <> String.Empty Then rTarjeta.CODCLI = CODCLI
                rTarjeta.NOMCLI = Mid(linea(2).Trim, 1, 100)
                rTarjeta.DIRCLI = Mid(linea(3).Trim, 1, 60)
                rTarjeta.DTOCLI = Mid(linea(4).Trim, 1, 10)
                rTarjeta.POBCLI = Mid(linea(5).Trim, 1, 50)
                rTarjeta.POVCLI = Mid(linea(6).Trim, 1, 50)
                rTarjeta.TELCLI = Mid(linea(7).Trim, 1, 15)
                rTarjeta.NIFCLI = Mid(linea(8).Trim, 1, 20)
                If IsDate(linea(10)) Then rTarjeta.FECCAD = linea(10)
                rTarjeta.BLOQUEADO = linea(12)
                rTarjeta.DESCCLI = linea(13)
                rTarjeta.PUNTOSSALDO = linea(14)
                rTarjeta.IMPRESA = linea(16)
                rTarjeta.PUNTOSCANJE = linea(17)

                Me.IDA_TARJETAS.AddIDA_TARJETASRow(rTarjeta)

            End While

            'Eliminar datos actuales
            a3ERP.fWaitForm.SetCaption("Eliminando datos actuales...")
            Me.taTarjetas.Eliminar()

            'Guardar datos importados
            a3ERP.fWaitForm.SetCaption("Guardando datos importados...")
            Me.taTarjetas.Update(Me.IDA_TARJETAS)

        Catch ex As Exception
            Throw ex
        Finally
            System.Threading.Thread.CurrentThread.CurrentCulture = configActual
            sr.Close()
            Me.AddEvents()
        End Try

    End Sub
#End Region

End Class
