Partial Class dsConsultaTickets

    Structure Filtros
        Dim FECINI As Date
        Dim FECFIN As Date
        Dim CODCLI As String
        Dim CODART As String
        Dim LINEAS_PRECIOMANUAL As Boolean
        Dim LINEAS_NEGATIVAS As Boolean
        Dim LINEAS_DTO
    End Structure

    Public Sub EstadisticaArticulos(ByVal Filtros As Filtros, Optional Pendientes As Boolean = False)

        Dim taArticulos As New dsConsultaTicketsTableAdapters.ARTICULOSTableAdapter
        Dim taTickets As New dsConsultaTicketsTableAdapters.ARTICULOS_TICKETSTableAdapter

        Try
            taArticulos.daArticulos.SelectCommand.CommandTimeout = 600000
            taTickets.daTickets.SelectCommand.CommandTimeout = 600000

            'Filtros
            Dim sql_Where As String = " WHERE HISTORICO_TICKETS.CodigoTienda = " & CodigoTienda

            If Filtros.FECINI <> Date.MinValue Then
                sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                sql_Where &= "HISTORICO_TICKETS.FechaTicket >= '" & Filtros.FECINI & "'"
            End If

            If Filtros.FECFIN <> Date.MinValue Then
                sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                sql_Where &= "HISTORICO_TICKETS.FechaTicket <= '" & Filtros.FECFIN & "'"
            End If

            If Filtros.CODCLI <> String.Empty Then
                sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                sql_Where &= "HISTORICO_TICKETS.ClienteCredito = '" & Filtros.CODCLI & "'"
            End If

            If Filtros.CODART <> String.Empty Then
                sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                sql_Where &= "HISTORICO_TICKETS_LINEAS.CodigoArticulo = '" & Filtros.CODART & "'"
            End If

            If Filtros.LINEAS_PRECIOMANUAL Then
                sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                sql_Where &= "HISTORICO_TICKETS_LINEAS.PrecioManual = 1"
            End If

            If Filtros.LINEAS_NEGATIVAS Then
                sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                sql_Where &= "HISTORICO_TICKETS_LINEAS.Cantidad < 0"
            End If

            If Filtros.LINEAS_DTO Then
                sql_Where &= IIf(sql_Where = String.Empty, " WHERE ", " AND ")
                sql_Where &= "HISTORICO_TICKETS_LINEAS.DescuentoLinea <> 0"
            End If

            Dim sql() As String = Split(taArticulos.daArticulos.SelectCommand.CommandText, "GROUP BY")
            taArticulos.daArticulos.SelectCommand.CommandText = sql(0) & sql_Where & " GROUP BY " & sql(1)

            If Pendientes Then
                taArticulos.daArticulos.SelectCommand.CommandText = taArticulos.daArticulos.SelectCommand.CommandText.Replace("HISTORICO_", String.Empty)
            End If

            If Filtros.FECFIN <> Date.MinValue Then
                taArticulos.Fill(Me.ARTICULOS, Filtros.FECFIN)
            Else
                taArticulos.Fill(Me.ARTICULOS, "31/12/9999")
            End If

            sql = Split(taTickets.daTickets.SelectCommand.CommandText, "GROUP BY")
            taTickets.daTickets.SelectCommand.CommandText = sql(0) & sql_Where & " GROUP BY " & sql(1)
            taTickets.Fill(Me.ARTICULOS_TICKETS)

        Catch ex As Exception
            Throw ex
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