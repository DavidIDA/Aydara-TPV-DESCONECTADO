Partial Class dsConsultaTickets

    Enum Listado
        TicketsDia
        TicketsHora
        TicketsArticulo
        TicketsFamilia
        TicketsVendedor
        Contable
    End Enum

    Structure Filtros
        Dim CODALM As String
        Dim FECHAVENTA As Boolean
        Dim FECINI As Date
        Dim FECFIN As Date
        Dim CODCLI As String
        Dim CODART As String
        Dim REPARTODOMICILIO As Boolean
        Dim LINEAS_PRECIOMANUAL As Boolean
        Dim LINEAS_NEGATIVAS As Boolean
        Dim LINEAS_DTO
    End Structure

    Public Event ActualizaEstado(Texto As String)

    Public Sub onActualizaEstado(Optional Texto As String = "")
        RaiseEvent ActualizaEstado(Texto)
    End Sub

    Public Sub Buscar(TipoListado As Listado, Filtros As Filtros)

        Dim cmd As New SqlClient.SqlCommand()

        Try
            Me.onActualizaEstado("Buscando tickets...")

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.SqlConection)
            cmd.Connection.Open()

            Me.Clear()

            'Filtros
            Dim sql_Where As String = " WHERE IDA_TICKETS.CREDITO = 0"

            If Filtros.CODALM <> String.Empty Then
                sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                sql_Where &= "IDA_TICKETS.CODALM = '" & Filtros.CODALM & "'"
            End If

            If Filtros.FECINI <> Date.MinValue Then
                sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                sql_Where &= IIf(Filtros.FECHAVENTA, "IDA_TICKETS.FECHA", "IDA_TICKETS.FECCIERRE") & " >= '" & Filtros.FECINI & "'"
            End If

            If Filtros.FECFIN <> Date.MinValue Then
                sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                sql_Where &= IIf(Filtros.FECHAVENTA, "IDA_TICKETS.FECHA", "IDA_TICKETS.FECCIERRE") & " <= '" & Filtros.FECFIN & "'"
            End If

            If Filtros.CODCLI <> String.Empty Then
                sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                sql_Where &= "IDA_TICKETS.NUMTARJETA = " & Filtros.CODCLI
            End If

            If Filtros.CODART <> String.Empty Then
                sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                sql_Where &= "IDA_TICKETS.IDTICKET IN (SELECT IDTICKET FROM IDA_TICKETSLINEAS WHERE CODART='" & Filtros.CODART & "')"
            End If

            If Filtros.REPARTODOMICILIO Then
                sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                sql_Where &= "IDA_TICKETS.REPARTODOMICILIO = 1"
            End If

            'Cabeceras tickets
            Select Case TipoListado

                Case Listado.TicketsDia
                    cmd.CommandText = "SELECT IDA_TICKETS.CAJA AS CodigoCaja, IDA_TICKETS.NUMDOC AS NumeroTicket, IDA_TICKETS.FECHA AS FechaTicket, IDA_TICKETS.FECHA AS HoraTicket, ISNULL(IDA_TARJETAS.NOMCLI,'VENTA CONTADO') AS NombreFiscal, IDA_TICKETS.NUMLINEAS AS NumeroLineas, IDA_TICKETS.TOTDOC AS ImporteTotal " & _
                                      "FROM IDA_TICKETS " & _
                                      "LEFT JOIN IDA_TARJETAS ON IDA_TICKETS.NUMTARJETA = IDA_TARJETAS.NUMTARJETA"

                Case Listado.TicketsHora
                    cmd.CommandText = "SELECT left(CONVERT(varchar,IDA_TICKETS.FECHA,8),2) AS HoraTicket, COUNT(IDA_TICKETS.IDTICKET) AS NumeroTicket, SUM(IDA_TICKETS.NUMLINEAS) AS NumeroLineas, SUM(IDA_TICKETS.TOTDOC) AS ImporteTotal " & _
                                      "FROM IDA_TICKETS"

                Case Listado.TicketsFamilia
                    cmd.CommandText = "SELECT FAMILIASARTICULOS.CODFAM + ': ' + FAMILIASARTICULOS.DESCFAM AS HoraTicket, " & _
                                      "SUBFAMILIASARTICULOS.CODFAM + ': ' + SUBFAMILIASARTICULOS.DESCFAM AS TipoCobro, " & _
                                      "COUNT(IDA_TICKETS.IDTICKET) AS NumeroTicket, COUNT(IDA_TICKETSLINEAS.IDTICKET) AS NumeroLineas, " & _
                                      "SUM(IDA_TICKETSLINEAS.TOTLIN) AS ImporteTotal " & _
                                      "FROM IDA_TICKETS INNER JOIN IDA_TICKETSLINEAS ON IDA_TICKETS.IDTICKET = IDA_TICKETSLINEAS.IDTICKET " & _
                                      "LEFT JOIN ARTICULO ON ARTICULO.CODART = IDA_TICKETSLINEAS.CODART " & _
                                      "LEFT JOIN Familia_Estadis AS FAMILIASARTICULOS ON LTRIM(FAMILIASARTICULOS.CODFAM) = SUBSTRING(LTRIM(ARTICULO.CODFAMEST),1,3) " & _
                                      "LEFT JOIN Familia_Estadis AS SUBFAMILIASARTICULOS ON SUBFAMILIASARTICULOS.CODFAM = ARTICULO.CODFAMEST"

                Case Listado.TicketsVendedor
                    cmd.CommandText = "SELECT IDA_TICKETS.CODPER AS HoraTicket, COUNT(IDA_TICKETS.IDTICKET) AS NumeroTicket, COUNT(IDA_TICKETSLINEAS.IDTICKET) AS NumeroLineas, " & _
                                      "SUM(IDA_TICKETSLINEAS.TOTLIN) AS ImporteTotal " & _
                                      "FROM IDA_TICKETS INNER JOIN IDA_TICKETSLINEAS ON IDA_TICKETS.IDTICKET = IDA_TICKETSLINEAS.IDTICKET"

                Case Listado.Contable
                    cmd.CommandText = "SELECT IDA_TICKETS.CAJA AS CodigoCaja, IDA_TICKETS.NUMDOC AS NumeroTicket, IDA_TICKETS.FECHA AS FechaTicket, IDA_TICKETS.FECHA AS HoraTicket, ISNULL(IDA_TARJETAS.NOMCLI,'VENTA CONTADO') AS NombreFiscal, IDA_TICKETS.NUMLINEAS AS NumeroLineas, IDA_TICKETS.TOTDOC AS ImporteTotal, " & _
                                      "CASE TOTEFECTIVO WHEN 0 THEN '' ELSE 'EF ' END " & _
                                      "+ CASE TOTTARJETA WHEN 0 THEN '' ELSE 'TJ ' END " & _
                                      "+ CASE TOTTALON WHEN 0 THEN '' ELSE 'TL ' END " & _
                                      "+ CASE TOTVALESPROVEEDOR WHEN 0 THEN '' ELSE 'VP ' END " & _
                                      "+ CASE TOTVALESCOBRADOS WHEN 0 THEN '' ELSE 'VC ' END " & _
                                      "+ CASE TOTENVASES WHEN 0 THEN '' ELSE 'EN ' END " & _
                                      "+ CASE TOTPENDIENTE WHEN 0 THEN '' ELSE 'PC ' END " & _
                                      "+ CASE TOTVALESEMITIDOS WHEN 0 THEN '' ELSE 'VE ' END " & _
                                      "AS TipoCobro " & _
                                      "FROM IDA_TICKETS " & _
                                      "LEFT JOIN IDA_TARJETAS ON IDA_TICKETS.NUMTARJETA = IDA_TARJETAS.NUMTARJETA"

                Case Listado.TicketsArticulo

                    Dim taArticulos As New dsConsultaTicketsTableAdapters.ARTICULOSTableAdapter
                    Dim taTickets As New dsConsultaTicketsTableAdapters.ARTICULOS_TICKETSTableAdapter

                    Try
                        If Filtros.CODART <> String.Empty Then
                            sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                            sql_Where &= "IDA_TICKETSLINEAS.CODART = '" & Filtros.CODART & "'"
                        End If

                        If Filtros.LINEAS_PRECIOMANUAL Then
                            sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                            sql_Where &= "IDA_TICKETSLINEAS.PRCMANUAL = 1"
                        End If

                        If Filtros.LINEAS_NEGATIVAS Then
                            sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                            sql_Where &= "IDA_TICKETSLINEAS.CANTIDAD < 0"
                        End If

                        If Filtros.LINEAS_DTO Then
                            sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                            sql_Where &= "IDA_TICKETSLINEAS.[DESC] <> 0"
                        End If

                        Dim sql() As String = Split(taArticulos.daArticulos.SelectCommand.CommandText, "GROUP BY")
                        taArticulos.daArticulos.SelectCommand.CommandText = sql(0) & sql_Where & " GROUP BY " & sql(1)
                        taArticulos.Fill(Me.ARTICULOS)

                        sql = Split(taTickets.daTickets.SelectCommand.CommandText, "GROUP BY")
                        taTickets.daTickets.SelectCommand.CommandText = sql(0) & sql_Where & " GROUP BY " & sql(1)
                        taTickets.Fill(Me.ARTICULOS_TICKETS)

                    Catch ex As Exception
                        Throw ex
                    End Try

                    Exit Try

            End Select

            'Filtros
            cmd.CommandText &= sql_Where

            'Agrupaciones
            Select Case TipoListado

                Case Listado.TicketsDia
                    cmd.CommandText &= " ORDER BY IDA_TICKETS.FECHA"

                Case Listado.TicketsHora
                    cmd.CommandText &= " GROUP BY left(CONVERT(varchar,IDA_TICKETS.FECHA,8),2) ORDER BY left(CONVERT(varchar,IDA_TICKETS.FECHA,8),2)"

                Case Listado.TicketsFamilia
                    cmd.CommandText &= " GROUP BY FAMILIASARTICULOS.CODFAM, FAMILIASARTICULOS.DESCFAM, SUBFAMILIASARTICULOS.CODFAM, SUBFAMILIASARTICULOS.DESCFAM ORDER BY FAMILIASARTICULOS.CODFAM, SUBFAMILIASARTICULOS.CODFAM"

                Case Listado.TicketsVendedor
                    cmd.CommandText &= " GROUP BY IDA_TICKETS.CODPER ORDER BY IDA_TICKETS.CODPER"

                Case Listado.Contable
                    cmd.CommandText &= " ORDER BY IDA_TICKETS.FECHA"

            End Select

            Me.TICKETS.Load(cmd.ExecuteReader)

            'Totales
            If TipoListado = Listado.Contable Then

                Dim dr As SqlClient.SqlDataReader
                cmd.CommandText = "SELECT ISNULL(SUM(TOTEFECTIVO - TOTCAMBIOS),0) AS Efectivo, " & _
                                  "ISNULL(SUM(TOTTARJETA),0) AS Tarjeta, " & _
                                  "ISNULL(SUM(TOTTALON),0) AS Talon, " & _
                                  "ISNULL(SUM(TOTVALESPROVEEDOR),0) AS ValesProveedor, " & _
                                  "ISNULL(SUM(TOTVALESCOBRADOS),0) AS ValesCobrados, " & _
                                  "ISNULL(SUM(TOTENVASES),0) AS Envases, " & _
                                  "ISNULL(SUM(TOTPENDIENTE),0) AS PendienteCobro, " & _
                                  "ISNULL(SUM(TOTVALESEMITIDOS),0) AS ValesEmitidos " & _
                                  "FROM IDA_TICKETS" & sql_Where

                dr = cmd.ExecuteReader
                If dr.Read Then
                    If dr("Efectivo") <> 0 Then Me.TOTALES.AddTOTALESRow("Total efectivo", dr("Efectivo"), 0, 0, 0)
                    If dr("Tarjeta") <> 0 Then Me.TOTALES.AddTOTALESRow("Total tarjeta", dr("Tarjeta"), 0, 0, 0)
                    If dr("Talon") <> 0 Then Me.TOTALES.AddTOTALESRow("Total talones", dr("Talon"), 0, 0, 0)
                    If dr("ValesProveedor") <> 0 Then Me.TOTALES.AddTOTALESRow("Total vales proveedor", dr("ValesProveedor"), 0, 0, 0)
                    If dr("ValesCobrados") <> 0 Then Me.TOTALES.AddTOTALESRow("Total vales cobrados", dr("ValesCobrados"), 0, 0, 0)
                    If dr("Envases") <> 0 Then Me.TOTALES.AddTOTALESRow("Total envases", dr("Envases"), 0, 0, 0)
                    If dr("PendienteCobro") <> 0 Then Me.TOTALES.AddTOTALESRow("Total pendientes de cobro", dr("PendienteCobro"), 0, 0, 0)
                    If dr("ValesEmitidos") <> 0 Then Me.TOTALES.AddTOTALESRow("Total vales emitidos", dr("ValesEmitidos"), 0, 0, 0)
                End If
                dr.Close()

                cmd.CommandText = "SELECT TIPOIVA.PORIVA AS PorcentajeIVA, ISNULL(SUM(IDA_TICKETSLINEAS.TOTLIN),0) AS Total " & _
                                  "FROM IDA_TICKETS INNER JOIN IDA_TICKETSLINEAS ON IDA_TICKETS.IDTICKET = IDA_TICKETSLINEAS.IDTICKET " & _
                                  "LEFT JOIN TIPOIVA ON IDA_TICKETSLINEAS.TIPIVA = TIPOIVA.TIPIVA"

                cmd.CommandText &= sql_Where & " GROUP BY TIPOIVA.PORIVA"

                'Calcular diferencia entre bases
                Dim TotalBases As Decimal, TotalIVA As Decimal, TotalVentas As Decimal, Diferencia As Decimal

                dr = cmd.ExecuteReader
                While dr.Read
                    TotalBases += Math.Round(dr("Total") / (1 + (dr("PorcentajeIVA") / 100)), 2, MidpointRounding.AwayFromZero)
                    TotalIVA += Math.Round(dr("Total") - (dr("Total") / (1 + (dr("PorcentajeIVA") / 100))), 2, MidpointRounding.AwayFromZero)
                    TotalVentas += Math.Round(dr("Total"), 2, MidpointRounding.AwayFromZero)
                End While
                dr.Close()
                Diferencia = TotalVentas - (TotalBases + TotalIVA)

                dr = cmd.ExecuteReader
                While dr.Read
                    TotalBases = Math.Round(dr("Total") / (1 + (dr("PorcentajeIVA") / 100)), 2, MidpointRounding.AwayFromZero)
                    TotalIVA = Math.Round(dr("Total") - (dr("Total") / (1 + (dr("PorcentajeIVA") / 100))), 2, MidpointRounding.AwayFromZero)
                    TotalVentas = dr("Total")
                    If TotalBases <> 0 Then
                        Me.TOTALES.AddTOTALESRow("Total IVA", dr("Total") - Diferencia, TotalBases, dr("PorcentajeIVA"), TotalIVA)
                        Diferencia = 0
                    End If
                End While
                dr.Close()

            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
            Me.onActualizaEstado()
        End Try

    End Sub

End Class

Namespace dsConsultaTicketsTableAdapters
    Partial Public Class ARTICULOSTableAdapter
        Public ReadOnly Property daArticulos() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class

    Partial Public Class ARTICULOS_TICKETSTableAdapter
        Public ReadOnly Property daTickets() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class

End Namespace