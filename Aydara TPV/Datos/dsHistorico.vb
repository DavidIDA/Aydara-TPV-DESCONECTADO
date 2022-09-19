Imports System.IO
Imports System.Text

Partial Class dsHistorico

    Dim taTickets As dsHistoricoTableAdapters.HISTORICO_TICKETSTableAdapter
    Dim taLineas As dsHistoricoTableAdapters.HISTORICO_TICKETS_LINEASTableAdapter
    Dim taTotales As dsHistoricoTableAdapters.TotalesPorClienteTableAdapter

#Region "Initialized"
    Private Sub dsHistorico_Initialized(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Initialized
        Me.taTickets = New dsHistoricoTableAdapters.HISTORICO_TICKETSTableAdapter
        Me.taLineas = New dsHistoricoTableAdapters.HISTORICO_TICKETS_LINEASTableAdapter
        Me.taTotales = New dsHistoricoTableAdapters.TotalesPorClienteTableAdapter

        Me.taTickets.Connection.ConnectionString = My.Settings.AydaraTPVConnectionString
        Me.taLineas.Connection.ConnectionString = My.Settings.AydaraTPVConnectionString
        Me.taTotales.Connection.ConnectionString = My.Settings.AydaraTPVConnectionString
    End Sub
#End Region

#Region "Cargar"
    Public Function Cargar(ByVal FechaDesde As String, ByVal FechaHasta As String, ByVal ClienteDesde As Integer, ByVal ClienteHasta As Integer) As Integer
        Dim str As String = Me.taTickets.daTickets.SelectCommand.CommandText
        Dim strLineas As String = Me.taLineas.daLineas.SelectCommand.CommandText
        Try
            Dim Filtro As String = String.Empty
            If IsDate(FechaDesde) Then
                Filtro &= "FechaTicket >= '" & FechaDesde & "'"
            End If

            If IsDate(FechaHasta) Then
                If Filtro <> String.Empty Then
                    Filtro &= " AND "
                End If

                Filtro &= "FechaHasta <= '" & FechaHasta & "'"
            End If

            If ClienteDesde <> -1 Then
                If Filtro <> String.Empty Then
                    Filtro &= " AND "
                End If

                Filtro &= "CodigoCliente >= " & ClienteDesde
            End If

            If ClienteHasta <> -1 Then
                If Filtro <> String.Empty Then
                    Filtro &= " AND "
                End If

                Filtro &= "CodigoCliente <= " & ClienteHasta
            End If

            If Filtro <> String.Empty Then
                Me.taTickets.daTickets.SelectCommand.CommandText = str & " WHERE " & Filtro
                Me.taLineas.daLineas.SelectCommand.CommandText = str & " WHERE Ticket_Id IN (SELECT Id FROM HISTORICO_TICKETS WHERE " & Filtro & ")"
            End If

            Me.taTickets.Fill(Me.HISTORICO_TICKETS)
            Me.taLineas.Fill(Me.HISTORICO_TICKETS_LINEAS)

            Return Me.HISTORICO_TICKETS.Count + Me.HISTORICO_TICKETS_LINEAS.Count
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Cargar(ByVal FechaDesde As String, ByVal FechaHasta As String, ByVal SoloPendientes As Boolean) As Integer
        Dim str As String = Me.taTickets.daTickets.SelectCommand.CommandText
        Dim strLineas As String = Me.taLineas.daLineas.SelectCommand.CommandText
        Try
            Dim Filtro As String = String.Empty

            Filtro = "TipoFactura <> 1"

            If IsDate(FechaDesde) Then
                Filtro &= " AND FechaTicket >= '" & FechaDesde & "'"
            End If

            If IsDate(FechaHasta) Then
                Filtro &= " AND FechaTicket <= '" & FechaHasta & "'"
            End If

            If SoloPendientes Then
                Filtro &= "AND Exportado=0"
            End If

            If Filtro <> String.Empty Then
                Me.taTickets.daTickets.SelectCommand.CommandText = str & " WHERE " & Filtro
                Me.taLineas.daLineas.SelectCommand.CommandText = strLineas & " WHERE Ticket_Id IN (SELECT Id FROM HISTORICO_TICKETS WHERE " & Filtro & ")"
            End If

            Me.taTickets.Fill(Me.HISTORICO_TICKETS)
            Me.taLineas.Fill(Me.HISTORICO_TICKETS_LINEAS)

            Return Me.HISTORICO_TICKETS.Count + Me.HISTORICO_TICKETS_LINEAS.Count
        Catch ex As Exception
            Throw ex
        Finally
            Me.taTickets.daTickets.SelectCommand.CommandText = str
            Me.taLineas.daLineas.SelectCommand.CommandText = strLineas
        End Try
    End Function

    Public Function CargarAlbaranes(ByVal FechaDesde As String, ByVal FechaHasta As String, ByVal SoloPendientes As Boolean) As Integer
        Dim str As String = Me.taTickets.daTickets.SelectCommand.CommandText
        Dim strLineas As String = Me.taLineas.daLineas.SelectCommand.CommandText
        Try
            Dim Filtro As String = String.Empty

            Filtro = "TipoFactura = 1"

            If IsDate(FechaDesde) Then
                Filtro &= " AND FechaTicket >= '" & FechaDesde & "'"
            End If

            If IsDate(FechaHasta) Then
                Filtro &= " AND FechaTicket <= '" & FechaHasta & "'"
            End If

            If SoloPendientes Then
                Filtro &= "AND Exportado=0"
            End If

            If Filtro <> String.Empty Then
                Me.taTickets.daTickets.SelectCommand.CommandText = str & " WHERE " & Filtro
                Me.taLineas.daLineas.SelectCommand.CommandText = strLineas & " WHERE Ticket_Id IN (SELECT Id FROM HISTORICO_TICKETS WHERE " & Filtro & ")"
            End If

            Me.taTickets.Fill(Me.HISTORICO_TICKETS)
            Me.taLineas.Fill(Me.HISTORICO_TICKETS_LINEAS)

            Return Me.HISTORICO_TICKETS.Count + Me.HISTORICO_TICKETS_LINEAS.Count
        Catch ex As Exception
            Throw ex
        Finally
            Me.taTickets.daTickets.SelectCommand.CommandText = str
            Me.taLineas.daLineas.SelectCommand.CommandText = strLineas
        End Try
    End Function
#End Region

#Region "CargarTotales"
    Public Function CargarTotales(ByVal FechaDesde As String, ByVal FechaHasta As String, ByVal ClienteDesde As Integer, ByVal ClienteHasta As Integer) As Integer
        Dim str As String = Me.taTotales.daTotales.SelectCommand.CommandText
        Try
            Dim Filtro As String = String.Empty
            If IsDate(FechaDesde) Then
                Filtro &= "FechaTicket >= '" & FechaDesde & "'"
            End If

            If IsDate(FechaHasta) Then
                If Filtro <> String.Empty Then
                    Filtro &= " AND "
                End If

                Filtro &= "FechaTicket <= '" & FechaHasta & "'"
            End If

            If ClienteDesde <> -1 Then
                If Filtro <> String.Empty Then
                    Filtro &= " AND "
                End If

                Filtro &= "CodigoCliente >= " & ClienteDesde
            End If

            If ClienteHasta <> -1 Then
                If Filtro <> String.Empty Then
                    Filtro &= " AND "
                End If

                Filtro &= "CodigoCliente <= " & ClienteHasta
            End If

            If Filtro <> String.Empty Then
                Me.taTotales.daTotales.SelectCommand.CommandText = str.Replace("GROUP BY", " AND " & Filtro & " GROUP BY")
            End If

            Me.taTotales.Fill(Me.TotalesPorCliente)

            Return Me.TotalesPorCliente.Count
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "GenerarVales"
    Public Sub GenerarVales(ByRef dsVales As dsValesTienda, ByVal Porcentaje As Decimal, ByVal NumInicial As Integer, FechaCaducidad As Date)
        Try
            For i As Integer = 0 To Me.TotalesPorCliente.Count - 1
                With Me.TotalesPorCliente(i)
                    Dim mirow As dsValesTienda.VALES_TIENDARow = dsVales.VALES_TIENDA.NewVALES_TIENDARow
                    mirow.CodigoTienda = CodigoTienda
                    mirow.CodigoVale = NumInicial + i
                    mirow.FechaVale = Date.Now
                    mirow.FechaCaducidad = FechaCaducidad
                    mirow.CodigoCliente = .CodigoCliente
                    mirow.Nombre = .NombreFiscal
                    mirow.Concepto = "CORRESPONDE A TARJETA " & .CodigoCliente
                    mirow.Importe = Math.Round((.TempTotal * Porcentaje) / 100, DecimalesImporte, MidpointRounding.AwayFromZero)

                    dsVales.VALES_TIENDA.AddVALES_TIENDARow(mirow)
                End With
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "ExportarContabilidad"
    Public Sub ExportarContabilidad(ByVal Fichero As String)
        Try

            Dim Inicio As Date
            Dim Fin As Date
            Dim Actual As Date

            Dim miview As New DataView
            miview.Table = Me.HISTORICO_TICKETS
            miview.Sort = "FechaTicket ASC"

            Inicio = CType(miview(0).Row, HISTORICO_TICKETSRow).FechaTicket.Date
            Fin = CType(miview(miview.Count - 1).Row, HISTORICO_TICKETSRow).FechaTicket.Date

            Actual = Inicio

            Dim asiento As Integer = 1
            Dim linea As Integer = 1

            Dim aux As Decimal = 0

            Dim str As New StringBuilder

            While Actual <= Fin

                Me.FamiliasContabilidad.Clear()

                aux = Me.DameTotal(Actual)

                If aux <> 0 Then
                    '-----------------------------------------------
                    '                   CABECERA
                    '-----------------------------------------------

                    str.Append("1")
                    str.Append("430007000   ")
                    str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                    str.AppendFormat("{0,5:00000}", asiento)
                    str.AppendFormat("{0,5:00000}", linea)
                    str.Append("C")
                    str.Append(Space(8))
                    str.Append("05")
                    str.Append("VENTA CONTADO TIENDA " & Actual.Day.ToString("00") & "-" & Actual.Month.ToString("00").Substring(0, 1))
                    str.Append(" ")


                    'str.AppendFormat("{0,12:000000000000}", aux * 100)
                    str.Append("000000000000")
                    str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                    str.AppendFormat("{0,4:0000}", linea)
                    str.Append("E")
                    str.Append(" ")

                    'aux = Me.DameTotalBI(Actual)
                    str.AppendFormat("{0,12:000000000000}", Math.Truncate(aux))
                    str.Append(".")
                    str.Append(((aux - Math.Truncate(aux)) * 100).ToString("00"))
                    str.Append("NN")
                    str.AppendLine()

                    '-----------------------------------------------
                    '               REGISTRO IVAS
                    '-----------------------------------------------

                    Dim Importes As RegistroIVA = Me.DameTotalesIVA(Actual)

                    str.Append("2")
                    str.Append("R")
                    str.AppendFormat("{0,5:00000}", asiento)
                    str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                    str.Append(Actual.Day.ToString("00") & Actual.Month.ToString("00") & Actual.Year)
                    str.Append("430007000   ")
                    str.Append(" ")
                    'str.AppendFormat("{0,12:000000000000}", Importes.SumaIVAs * 100)
                    str.Append("000000000000")
                    str.Append(" ")
                    'str.AppendFormat("{0,12:000000000000}", Importes.BI10 * 100)
                    str.Append("000000000000")
                    str.Append("R")
                    str.Append("  10.00 ")
                    'str.AppendFormat("{0,12:000000000000}", Math.Truncate(Importes.IVA10))
                    'str.Append(".")
                    'str.Append((Importes.IVA10 - Math.Truncate(Importes.IVA10)).ToString("00"))
                    str.Append("00000000000000.00")
                    str.Append(" ")
                    str.Append("000000000000")
                    str.Append(" ")
                    'str.AppendFormat("{0,12:000000000000}", Importes.BI21 * 100)
                    str.Append("000000000000")
                    str.Append("G")
                    str.Append("  21.00 ")
                    'str.AppendFormat("{0,12:000000000000}", Math.Truncate(Importes.IVA21))
                    'str.Append(".")
                    'str.Append((Importes.IVA21 - Math.Truncate(Importes.IVA21)).ToString("00"))
                    str.Append("00000000000000.00")
                    str.Append(" ")
                    str.Append("000000000000")
                    str.Append(" ")
                    'str.AppendFormat("{0,12:000000000000}", Importes.BI4 * 100)
                    str.Append("000000000000")
                    str.Append("S")
                    str.Append("  04.00 ")
                    'str.AppendFormat("{0,12:000000000000}", Math.Truncate(Importes.IVA4))
                    'str.Append(".")
                    'str.Append((Importes.IVA4 - Math.Truncate(Importes.IVA4)).ToString("00"))
                    str.Append("00000000000000.00")
                    str.Append(" ")
                    str.Append("000000000000")
                    str.Append(" ")

                    'aux = Me.DameTotal(Actual)
                    'str.AppendFormat("{0,12:000000000000}", aux * 100)
                    str.Append("000000000000")
                    str.Append("SS")
                    str.Append("VENTAS TIENDA " & Actual.Day.ToString("00") & "-" & Actual.Month.ToString("00") & "-" & Actual.Year & Space(13))
                    str.Append("000200001")
                    str.Append(" ")
                    str.Append("000000000000.00")
                    str.Append(" ")

                    str.AppendFormat("{0,12:000000000000}", Math.Truncate(Importes.BI10))
                    str.Append(".")
                    str.Append(((Importes.BI10 - Math.Truncate(Importes.BI10)) * 100).ToString("00"))
                    str.Append(" ")
                    str.AppendFormat("{0,12:000000000000}", Math.Truncate(Importes.IVA10))
                    str.Append(".")
                    str.Append(((Importes.IVA10 - Math.Truncate(Importes.IVA10)) * 100).ToString("00"))
                    str.Append(" ")
                    str.Append("000000000000.00")
                    str.Append(" ")
                    str.AppendFormat("{0,12:000000000000}", Math.Truncate(Importes.BI21))
                    str.Append(".")
                    str.Append(((Importes.BI21 - Math.Truncate(Importes.BI21)) * 100).ToString("00"))
                    str.Append(" ")
                    str.AppendFormat("{0,12:000000000000}", Math.Truncate(Importes.IVA21))
                    str.Append(".")
                    str.Append(((Importes.IVA21 - Math.Truncate(Importes.IVA21)) * 100).ToString("00"))
                    str.Append(" ")
                    str.Append("000000000000.00")
                    str.Append(" ")
                    str.AppendFormat("{0,12:000000000000}", Math.Truncate(Importes.BI4))
                    str.Append(".")
                    str.Append(((Importes.BI4 - Math.Truncate(Importes.BI4)) * 100).ToString("00"))
                    str.Append(" ")
                    str.AppendFormat("{0,12:000000000000}", Math.Truncate(Importes.IVA4))
                    str.Append(".")
                    str.Append(((Importes.IVA4 - Math.Truncate(Importes.IVA4)) * 100).ToString("00"))
                    str.Append(" ")
                    str.Append("000000000000.00")
                    str.Append(" ")
                    str.AppendFormat("{0,12:000000000000}", Math.Truncate(aux))
                    str.Append(".")
                    str.Append(((aux - Math.Truncate(aux)) * 100).ToString("00"))
                    str.Append("ES")
                    str.AppendLine()

                    '-----------------------------------------------
                    '               RESUMEN IVAS
                    '-----------------------------------------------


                    linea += 1

                    str.Append("1")
                    str.Append("47701       ")
                    str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                    str.AppendFormat("{0,5:00000}", asiento)
                    str.AppendFormat("{0,5:00000}", linea)
                    str.Append("A")
                    str.Append(Space(8))
                    str.Append("01")
                    str.Append("VENTAS TIENDA " & Actual.Day.ToString("00") & "-" & Actual.Month.ToString("00") & "-" & Actual.Year & "  ")
                    'str.AppendFormat("{0,12:000000000000}", Importes.SumaIVAs * 100)
                    str.Append("000000000000")
                    str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                    str.AppendFormat("{0,4:0000}", linea)
                    str.Append("E")
                    str.Append(" ")

                    aux = Importes.IVA10 + Importes.IVA21 + Importes.IVA4
                    str.AppendFormat("{0,12:000000000000}", Math.Truncate(aux))
                    str.Append(".")
                    str.Append(((aux - Math.Truncate(aux)) * 100).ToString("00"))
                    str.Append("NN")
                    str.AppendLine()

                    '-----------------------------------------------
                    '               FAMILIAS IVA
                    '-----------------------------------------------

                    Me.CargaFamilias(Importes.BI10 + Importes.BI21 + Importes.BI4, Actual)

                    Dim miviewFamilias As New DataView
                    miviewFamilias.Table = Me.FamiliasContabilidad
                    miviewFamilias.Sort = "CtaVentas ASC"

                    For i As Integer = 0 To miviewFamilias.Count - 1
                        With CType(miviewFamilias(i).Row, FamiliasContabilidadRow)
                            linea += 1

                            str.Append("1")
                            str.AppendFormat("{0,-12:}", .CtaVentas.Substring(0, IIf(.CtaVentas.Length > 12, 12, .CtaVentas.Length)))
                            str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                            str.AppendFormat("{0,5:00000}", asiento)
                            str.AppendFormat("{0,5:00000}", linea)
                            str.Append("A")
                            str.Append(Space(8))
                            str.Append("01")
                            str.Append("VENTAS TIENDA " & Actual.Day.ToString("00") & "-" & Actual.Month.ToString("00") & "-" & Actual.Year & "  ")
                            'str.AppendFormat("{0,12:000000000000}", .TotalBI * 100)
                            str.Append("000000000000")
                            str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                            str.AppendFormat("{0,4:0000}", linea)
                            str.Append("E")
                            str.Append(" ")
                            '.TotalBI = Math.Round(.TotalBI, 2)
                            str.AppendFormat("{0,12:000000000000}", Math.Truncate(.TotalBI))
                            str.Append(".")
                            str.Append(((.TotalBI - Math.Truncate(.TotalBI)) * 100).ToString("00"))
                            str.Append("NN")
                            str.AppendLine()

                        End With
                    Next


                    aux = Me.DameImporteTarjetas(Actual)

                    If aux <> 0 Then
                        '-----------------------------------------------
                        '               VENTA TARJETAS C
                        '-----------------------------------------------

                        linea += 1

                        str.Append("1430007181   ")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,5:00000}", asiento)
                        str.AppendFormat("{0,5:00000}", linea)
                        str.Append("C")
                        str.Append(Space(8))
                        str.Append("02")
                        str.Append("VENTA TARJETAS TIENDA " & Actual.Day.ToString("00") & "- ")
                        'str.AppendFormat("{0,12:000000000000}", Importes.TotalConCliente * 100)
                        str.Append("000000000000")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,4:0000}", linea)
                        str.Append("E ")


                        str.AppendFormat("{0,12:000000000000}", Math.Truncate(aux))
                        str.Append(".")
                        str.Append(((aux - Math.Truncate(aux)) * 100).ToString("00"))
                        str.Append("NN")
                        str.AppendLine()


                        '-----------------------------------------------
                        '               VENTA TARJETAS A
                        '-----------------------------------------------

                        linea += 1

                        str.Append("1430007000   ")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,5:00000}", asiento)
                        str.AppendFormat("{0,5:00000}", linea)
                        str.Append("A")
                        str.Append(Space(8))
                        str.Append("02")
                        str.Append("VENTA TARJETAS TIENDA " & Actual.Day.ToString("00") & "- ")
                        'str.AppendFormat("{0,12:000000000000}", Importes.TotalConCliente * 100)
                        str.Append("000000000000")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,4:0000}", linea)
                        str.Append("E ")
                        str.AppendFormat("{0,12:000000000000}", Math.Truncate(aux))
                        str.Append(".")
                        str.Append(((aux - Math.Truncate(aux)) * 100).ToString("00"))
                        str.Append("NN")
                        str.AppendLine()
                    End If


                    aux = Me.DameImporteVentasEfectivo(Actual)
                    If aux <> 0 Then
                        '-----------------------------------------------
                        '               VENTA EFECTIVO C
                        '-----------------------------------------------

                        linea += 1

                        str.Append("157001       ")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,5:00000}", asiento)
                        str.AppendFormat("{0,5:00000}", linea)
                        str.Append("C")
                        str.Append(Space(8))
                        str.Append("02")
                        str.Append("VENTAS EFECTIVO " & Actual.Day.ToString("00") & "-" & Actual.Month.ToString("00") & "-" & Actual.Year.ToString.Substring(0, 3) & " ")
                        'str.AppendFormat("{0,12:000000000000}", Importes.TotalSinCliente * 100)
                        str.Append("000000000000")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,4:0000}", linea)
                        str.Append("E ")
                        str.AppendFormat("{0,12:000000000000}", Math.Truncate(aux))
                        str.Append(".")
                        str.Append(((aux - Math.Truncate(aux)) * 100).ToString("00"))
                        str.Append("NN")
                        str.AppendLine()

                        '-----------------------------------------------
                        '               VENTA EFECTIVO A
                        '-----------------------------------------------

                        linea += 1

                        str.Append("1430007000   ")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,5:00000}", asiento)
                        str.AppendFormat("{0,5:00000}", linea)
                        str.Append("A")
                        str.Append(Space(8))
                        str.Append("02")
                        str.Append("VENTAS EFECTIVO " & Actual.Day.ToString("00") & "-" & Actual.Month.ToString("00") & "-" & Actual.Year.ToString.Substring(0, 3) & " ")
                        'str.AppendFormat("{0,12:000000000000}", Importes.TotalSinCliente * 100)
                        str.Append("000000000000")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,4:0000}", linea)
                        str.Append("E ")

                        'aux = Me.DameImporteVentasEfectivo(Actual)
                        str.AppendFormat("{0,12:000000000000}", Math.Truncate(aux))
                        str.Append(".")
                        str.Append(((aux - Math.Truncate(aux)) * 100).ToString("00"))
                        str.Append("NN")
                        str.AppendLine()
                    End If


                    aux = Me.DameImporteValesProveedor(Actual)
                    If aux <> 0 Then
                        '-----------------------------------------------
                        '               VENTA VALES PROVEEDOR C
                        '-----------------------------------------------

                        linea += 1

                        str.Append("1430007260   ")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,5:00000}", asiento)
                        str.AppendFormat("{0,5:00000}", linea)
                        str.Append("C")
                        str.Append(Space(8))
                        str.Append("02")
                        str.Append("VENTA VALES PROVEEDOR " & Actual.Day.ToString("00") & "-" & " ")
                        'str.AppendFormat("{0,12:000000000000}", Importes.TotalSinCliente * 100)
                        str.Append("000000000000")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,4:0000}", linea)
                        str.Append("E ")


                        str.AppendFormat("{0,12:000000000000}", Math.Truncate(aux))
                        str.Append(".")
                        str.Append(((aux - Math.Truncate(aux)) * 100).ToString("00"))
                        str.Append("NN")
                        str.AppendLine()


                        '-----------------------------------------------
                        '               VENTA VALES PROVEEDOR A
                        '-----------------------------------------------

                        linea += 1

                        str.Append("157001       ")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,5:00000}", asiento)
                        str.AppendFormat("{0,5:00000}", linea)
                        str.Append("A")
                        str.Append(Space(8))
                        str.Append("02")
                        str.Append("VENTA VALES PROVEEDOR " & Actual.Day.ToString("00") & "-" & " ")
                        'str.AppendFormat("{0,12:000000000000}", Importes.TotalSinCliente * 100)
                        str.Append("000000000000")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,4:0000}", linea)
                        str.Append("E ")

                        'aux = Me.DameImporteValesProveedor(Actual)
                        str.AppendFormat("{0,12:000000000000}", Math.Truncate(aux))
                        str.Append(".")
                        str.Append(((aux - Math.Truncate(aux)) * 100).ToString("00"))
                        str.Append("NN")
                        str.AppendLine()
                    End If


                    aux = Me.DameImporteValesPropios(Actual)
                    If aux <> 0 Then
                        '-----------------------------------------------
                        '               VENTA VALES PROPIOS C
                        '-----------------------------------------------

                        linea += 1

                        str.Append("170801       ")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,5:00000}", asiento)
                        str.AppendFormat("{0,5:00000}", linea)
                        str.Append("C")
                        str.Append(Space(8))
                        str.Append("02")
                        str.Append("VENTA VALES PROPIOS " & Actual.Day.ToString("00") & "-" & Actual.Month.ToString("00") & " ")
                        'str.AppendFormat("{0,12:000000000000}", Importes.TotalSinCliente * 100)
                        str.Append("000000000000")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,4:0000}", linea)
                        str.Append("E ")

                        str.AppendFormat("{0,12:000000000000}", Math.Truncate(aux))
                        str.Append(".")
                        str.Append(((aux - Math.Truncate(aux)) * 100).ToString("00"))
                        str.Append("NN")
                        str.AppendLine()


                        '-----------------------------------------------
                        '               VENTA VALES PROPIOS A
                        '-----------------------------------------------

                        linea += 1

                        str.Append("157001       ")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,5:00000}", asiento)
                        str.AppendFormat("{0,5:00000}", linea)
                        str.Append("A")
                        str.Append(Space(8))
                        str.Append("02")
                        str.Append("VENTA VALES PROPIOS " & Actual.Day.ToString("00") & "-" & Actual.Month.ToString("00") & " ")
                        'str.AppendFormat("{0,12:000000000000}", Importes.TotalSinCliente * 100)
                        str.Append("000000000000")
                        str.Append(Actual.Year & Actual.Month.ToString("00") & Actual.Day.ToString("00"))
                        str.AppendFormat("{0,4:0000}", linea)
                        str.Append("E ")

                        'aux = Me.DameImporteValesPropios(Actual)
                        str.AppendFormat("{0,12:000000000000}", Math.Truncate(aux))
                        str.Append(".")
                        str.Append(((aux - Math.Truncate(aux)) * 100).ToString("00"))
                        str.Append("NN")
                        str.AppendLine()
                    End If

                    asiento += 1
                End If

                Actual = Actual.AddDays(1)
                linea = 1
            End While

            File.WriteAllText(Fichero, str.ToString, System.Text.Encoding.Default)

            Me.MarcarComoExportados()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "ExportarAlbaranes"
    Public Sub ExportarAlbaranes(ByVal Fichero As String)

        Dim str As New StringBuilder

        Try
            Dim Cabeceras() As DataRow = Me.HISTORICO_TICKETS.Select("", "FechaTicket, NumeroAlbaran")

            For i As Integer = 0 To Cabeceras.Length - 1
                With DirectCast(Cabeceras(i), dsHistorico.HISTORICO_TICKETSRow)

                    str.AppendFormat("{0,8:00000000}", .NumeroAlbaran)
                    str.AppendFormat("{0,6:000000}", .CodigoCliente - IIf(.CodigoCliente >= 27000000, 27000000, 0))
                    str.Append(.FechaTicket.ToString("yyyyMMdd"))
                    str.Append("01")
                    str.Append(.HoraTicket.ToString("HHmm"))

                    Dim Importes As RegistroIVA = Me.DameTotalesIVA(.FechaTicket, .Id)

                    str.AppendFormat("{0,11:00000000000}", Math.Abs(Importes.BI10) * 100)
                    str.Append(IIf(Importes.BI10 < 0, "-", " "))
                    str.AppendFormat("{0,5:00000}", Importes.PorcentajeIva1 * 100)
                    str.AppendFormat("{0,11:00000000000}", Math.Abs(Importes.IVA10) * 100)
                    str.Append(IIf(Importes.Total10 < 0, "-", " "))
                    str.AppendFormat("{0,5:00000}", 0)
                    str.AppendFormat("{0,11:00000000000}", 0)
                    str.Append(" ")

                    str.AppendFormat("{0,11:00000000000}", Math.Abs(Importes.BI21) * 100)
                    str.Append(IIf(Importes.BI21 < 0, "-", " "))
                    str.AppendFormat("{0,5:00000}", Importes.PorcentajeIva2 * 100)
                    str.AppendFormat("{0,11:00000000000}", Math.Abs(Importes.IVA21) * 100)
                    str.Append(IIf(Importes.Total21 < 0, "-", " "))
                    str.AppendFormat("{0,5:00000}", 0)
                    str.AppendFormat("{0,11:00000000000}", 0)
                    str.Append(" ")

                    str.AppendFormat("{0,11:00000000000}", Math.Abs(Importes.BI4) * 100)
                    str.Append(IIf(Importes.BI4 < 0, "-", " "))
                    str.AppendFormat("{0,5:00000}", Importes.PorcentajeIva3 * 100)
                    str.AppendFormat("{0,11:00000000000}", Math.Abs(Importes.IVA4) * 100)
                    str.Append(IIf(Importes.Total4 < 0, "-", " "))
                    str.AppendFormat("{0,5:00000}", 0)
                    str.AppendFormat("{0,11:00000000000}", 0)
                    str.Append(" ")

                    str.AppendFormat("{0,11:00000000000}", 0)
                    str.Append(" ")
                    str.AppendFormat("{0,5:00000}", 0)
                    str.AppendFormat("{0,11:00000000000}", 0)
                    str.Append(" ")
                    str.AppendFormat("{0,5:00000}", 0)
                    str.AppendFormat("{0,11:00000000000}", 0)
                    str.Append(" ")

                    str.AppendFormat("{0,11:00000000000}", Math.Abs(.ImporteTotal) * 100)
                    str.Append(IIf(.ImporteTotal < 0, "-", " "))

                    str.AppendLine()

                    Dim Lineas() As DataRow = Me.HISTORICO_TICKETS_LINEAS.Select("Ticket_Id = " & .Id)

                    For linea As Integer = 0 To Lineas.Length - 1

                        str.AppendFormat("{0,8:00000000}", .NumeroAlbaran)

                        With DirectCast(Lineas(linea), dsHistorico.HISTORICO_TICKETS_LINEASRow)

                            str.AppendFormat("{0,-35}", Mid(.DescripcionArticulo, 1, 35))
                            str.AppendFormat("{0,11:00000000000}", Math.Abs(.Cantidad) * 100)
                            str.Append(IIf(.Cantidad < 0, "-", " "))

                            Dim Precio As Decimal = .Precio / (1 + .PorcentajeIVA / 100)
                            str.AppendFormat("{0,13:0000000000000}", Math.Abs(Precio) * 10000)
                            str.Append(IIf(Precio < 0, "-", " "))

                            str.AppendFormat("{0,5:00000}", .DescuentoLinea * 100)

                            str.AppendFormat("{0,11:00000000000}", Math.Round(Math.Abs(.Cantidad * Precio), 2, MidpointRounding.AwayFromZero) * 100)
                            str.Append(IIf(Math.Round(Math.Abs(.Cantidad * Precio), 2, MidpointRounding.AwayFromZero) < 0, "-", " "))

                            str.AppendFormat("{0,5:00000}", .PorcentajeIVA * 100)

                            str.Append("000081")
                            Select Case AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT FAMILIASARTICULOS.Codigo FROM ARTICULOS LEFT JOIN FAMILIASARTICULOS ON ARTICULOS.CodigoFamilia = FAMILIASARTICULOS.Id WHERE ARTICULOS.Codigo = '" & .CodigoArticulo & "'", AGI2005.BaseDatos.TipoValor.Texto, My.Settings.AydaraTPVConnectionString)
                                Case "200", "201"
                                    str.Append("000000000000002")
                                Case "210"
                                    str.Append("000000000000003")
                                Case "501", "507"
                                    str.Append("000000000000004")
                                Case "025"
                                    str.Append("000000000000005")
                                Case "508"
                                    str.Append("000000000000006")
                                Case "211", "213"
                                    str.Append("000000000000007")
                                Case "803"
                                    str.Append("000000000000008")
                                Case Else
                                    str.Append("000000000000001")
                            End Select

                        End With

                        str.AppendLine()

                    Next

                End With
            Next

            File.WriteAllText(Fichero, str.ToString, System.Text.Encoding.Default)

            Me.MarcarComoExportados()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "DameTotal"
    Private Function DameTotal(ByVal Fecha As Date) As Decimal
        Try
            Dim lineas As DataRow() = Me.HISTORICO_TICKETS.Select("FechaTicket = '" & Fecha & "'")

            Dim Acumulado As Decimal = 0
            For i As Integer = 0 To lineas.Length - 1
                Acumulado += CType(lineas(i), HISTORICO_TICKETSRow).ImporteTotal
            Next

            Return Acumulado
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "DameImporteTarjetas"
    Private Function DameImporteTarjetas(ByVal Fecha As Date) As Decimal
        Try
            Dim lineas As DataRow() = Me.HISTORICO_TICKETS.Select("FechaTicket = '" & Fecha & "'")

            Dim Acumulado As Decimal = 0
            For i As Integer = 0 To lineas.Length - 1
                Acumulado += CType(lineas(i), HISTORICO_TICKETSRow).ImporteTarjeta
            Next

            Return Acumulado
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "DameImporteVentasEfectivo"
    Private Function DameImporteVentasEfectivo(ByVal Fecha As Date) As Decimal
        Try
            Dim lineas As DataRow() = Me.HISTORICO_TICKETS.Select("FechaTicket = '" & Fecha & "'")

            Dim Acumulado As Decimal = 0
            For i As Integer = 0 To lineas.Length - 1
                With CType(lineas(i), HISTORICO_TICKETSRow)
                    Acumulado += (.ImporteEfectivo - .ImporteCambios + .ImporteValesProveedor + .ImporteValesCobrados)
                End With
            Next

            Return Acumulado
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "DameImporteValesProveedor"
    Private Function DameImporteValesProveedor(ByVal Fecha As Date) As Decimal
        Try
            Dim lineas As DataRow() = Me.HISTORICO_TICKETS.Select("FechaTicket = '" & Fecha & "'")

            Dim Acumulado As Decimal = 0
            For i As Integer = 0 To lineas.Length - 1
                Acumulado += CType(lineas(i), HISTORICO_TICKETSRow).ImporteValesProveedor
            Next

            Return Acumulado
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "DameImporteValesPropios"
    Private Function DameImporteValesPropios(ByVal Fecha As Date) As Decimal
        Try
            Dim lineas As DataRow() = Me.HISTORICO_TICKETS.Select("FechaTicket = '" & Fecha & "'")

            Dim Acumulado As Decimal = 0
            For i As Integer = 0 To lineas.Length - 1
                Acumulado += CType(lineas(i), HISTORICO_TICKETSRow).ImporteValesCobrados
            Next

            Return Acumulado
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "DameTotalBI"
    Private Function DameTotalBI(ByVal Fecha As Date) As Decimal
        Try
            Dim lineas As DataRow() = Me.HISTORICO_TICKETS_LINEAS.Select("TempFecha = '" & Fecha & "'")

            Dim Acumulado As Decimal = 0
            For i As Integer = 0 To lineas.Length - 1
                Acumulado += CType(lineas(i), HISTORICO_TICKETS_LINEASRow).Importe
            Next

            Return Acumulado
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

    Private Structure RegistroIVA
        Dim SumaIVAs As Decimal
        Dim BI10 As Decimal
        Dim IVA10 As Decimal
        Dim BI21 As Decimal
        Dim IVA21 As Decimal
        Dim BI4 As Decimal
        Dim IVA4 As Decimal
        'Dim VentasTarjeta As Decimal
        Dim BI10Efectivo As Decimal
        Dim IVA10Efectivo As Decimal
        Dim BI21Efectivo As Decimal
        Dim IVA21Efectivo As Decimal
        Dim BI4Efectivo As Decimal
        Dim IVA4Efectivo As Decimal
        Dim TotalEfectivo As Decimal

        Dim TotalConCliente As Decimal
        Dim TotalConClienteBI As Decimal

        Dim TotalSinCliente As Decimal
        Dim TotalSinClienteBI As Decimal

        Dim TotalValesProveedor As Decimal
        Dim TotalValesProveedorBI As Decimal

        Dim Total10 As Decimal
        Dim Total10Efectivo As Decimal

        Dim Total4 As Decimal
        Dim Total4Efectivo As Decimal

        Dim Total21 As Decimal
        Dim Total21Efectivo As Decimal

        Dim PorcentajeIva1 As Decimal
        Dim PorcentajeIva2 As Decimal
        Dim PorcentajeIva3 As Decimal

    End Structure

#Region "InicializarRegistroIVA"
    Private Sub InicializarRegistroIVA(ByRef miReg As RegistroIVA)
        Try
            With miReg
                .BI10 = 0
                .BI10Efectivo = 0
                .BI21 = 0
                .BI21Efectivo = 0
                .BI4 = 0
                .BI4Efectivo = 0
                .IVA10 = 0
                .IVA10Efectivo = 0
                .IVA21 = 0
                .IVA21Efectivo = 0
                .IVA4 = 0
                .IVA4Efectivo = 0
                .TotalConCliente = 0
                .TotalConClienteBI = 0
                .TotalEfectivo = 0
                .TotalSinCliente = 0
                .TotalSinClienteBI = 0
                .TotalValesProveedor = 0
                .TotalValesProveedorBI = 0

                .Total10 = 0
                .Total10Efectivo = 0
                .Total21 = 0
                .Total21Efectivo = 0
                .Total4 = 0
                .Total4Efectivo = 0

            End With
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "DameTotalesIVA"
    Private Function DameTotalesIVA(ByVal Fecha As Date, Optional ByVal IdTicket As Integer = 0) As RegistroIVA
        Try
            Dim res As New RegistroIVA
            Me.InicializarRegistroIVA(res)

            Dim lineas As DataRow()

            If IdTicket <> 0 Then
                lineas = Me.HISTORICO_TICKETS_LINEAS.Select("Ticket_Id='" & IdTicket & "'")
            Else
                lineas = Me.HISTORICO_TICKETS_LINEAS.Select("TempFecha='" & Fecha & "'")
            End If

            For i As Integer = 0 To lineas.Length - 1
                With CType(lineas(i), HISTORICO_TICKETS_LINEASRow)

                    Dim BI As Decimal = (.Importe / (1 + (.PorcentajeIVA / 100)))

                    'BI = Math.Round(BI, 2)

                    Dim IVA As Decimal = .Importe - (.Importe / (1 + (.PorcentajeIVA / 100)))
                    'IVA = Math.Round(IVA, 2)

                    res.SumaIVAs += IVA

                    Select Case .PorcentajeIVA
                        Case 10
                            res.PorcentajeIva1 = .PorcentajeIVA
                            res.BI10 += BI
                            res.IVA10 += IVA

                            res.Total10 += .Importe

                            If .TempTipo = "E" Then
                                res.BI10Efectivo += BI
                                res.IVA10Efectivo += IVA

                                res.Total10Efectivo += .Importe
                            End If
                        Case 21
                            res.PorcentajeIva2 = .PorcentajeIVA
                            res.BI21 += BI
                            res.IVA21 += IVA

                            res.Total21 += .Importe

                            If .TempTipo = "E" Then
                                res.BI21Efectivo += BI
                                res.IVA21Efectivo += IVA

                                res.Total21Efectivo += .Importe
                            End If
                        Case 4
                            res.PorcentajeIva3 = .PorcentajeIVA
                            res.BI4 += BI
                            res.IVA4 += IVA

                            res.Total4 += .Importe

                            If .TempTipo = "E" Then
                                res.BI4Efectivo += BI
                                res.IVA4Efectivo += IVA

                                res.Total4Efectivo += .Importe
                            End If
                    End Select

                    If .TempTipo = "E" Then
                        res.TotalEfectivo += .Importe
                    End If

                    If .TempCodigoCliente <> 0 Then
                        res.TotalConCliente += .Importe
                        res.TotalConClienteBI += BI
                    Else
                        res.TotalSinCliente += .Importe
                        res.TotalSinClienteBI += BI
                    End If

                End With
            Next

            res.BI10 = Math.Round(res.BI10, 2)
            res.BI10Efectivo = Math.Round(res.BI10Efectivo, 2)
            res.BI21 = Math.Round(res.BI21, 2)
            res.BI21Efectivo = Math.Round(res.BI21Efectivo, 2)
            res.BI4 = Math.Round(res.BI4, 2)
            res.BI4Efectivo = Math.Round(res.BI4Efectivo, 2)
            res.IVA10 = Math.Round(res.IVA10, 2)
            res.IVA10Efectivo = Math.Round(res.IVA10Efectivo, 2)
            res.IVA21 = Math.Round(res.IVA21, 2)
            res.IVA21Efectivo = Math.Round(res.IVA21Efectivo, 2)
            res.IVA4 = Math.Round(res.IVA4, 2)
            res.IVA4Efectivo = Math.Round(res.IVA4Efectivo, 2)
            res.SumaIVAs = Math.Round(res.SumaIVAs, 2)
            res.TotalEfectivo = Math.Round(res.TotalEfectivo, 2)

            res.TotalConCliente = Math.Round(res.TotalConCliente, 2)
            res.TotalConClienteBI = Math.Round(res.TotalConClienteBI, 2)

            res.TotalSinCliente = Math.Round(res.TotalSinCliente, 2)
            res.TotalSinClienteBI = Math.Round(res.TotalSinClienteBI, 2)

            res.TotalValesProveedor = Math.Round(res.TotalValesProveedor, 2)
            res.TotalValesProveedorBI = Math.Round(res.TotalValesProveedorBI, 2)

            Return res
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "CargaFamilias"
    Private Sub CargaFamilias(ByVal Total As Decimal, ByVal Fecha As Date)
        Try
            Dim AcumBI As Decimal = 0
            Dim lineas As DataRow() = Me.HISTORICO_TICKETS_LINEAS.Select("TempFecha='" & Fecha & "'")

            For i As Integer = 0 To lineas.Length - 1
                With CType(lineas(i), HISTORICO_TICKETS_LINEASRow)

                    Dim BI As Decimal = (.Importe / (1 + (.PorcentajeIVA / 100)))
                    Dim IVA As Decimal = .Importe - (.Importe / (1 + (.PorcentajeIVA / 100)))

                    Dim mirow As FamiliasContabilidadRow = Me.DameLineaFamilia(.TempCtaVentas)
                    mirow.TotalBI += BI
                    mirow.TotalIVA += IVA
                End With
            Next

            For i As Integer = 0 To Me.FamiliasContabilidad.Count - 1
                Me.FamiliasContabilidad(i).TotalBI = System.Math.Round(Me.FamiliasContabilidad(i).TotalBI, 2)
                Me.FamiliasContabilidad(i).TotalIVA = System.Math.Round(Me.FamiliasContabilidad(i).TotalIVA, 2)

                AcumBI += Me.FamiliasContabilidad(i).TotalBI
            Next

            If Total <> AcumBI Then
                If Me.FamiliasContabilidad.Count > 0 Then
                    Dim DIf As Decimal = Total - AcumBI
                    Me.FamiliasContabilidad(0).TotalBI += DIf
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "DameLineaFamilia"
    Private Function DameLineaFamilia(ByVal CtaVentas As String) As FamiliasContabilidadRow
        Try
            Dim linea As DataRow() = Me.FamiliasContabilidad.Select("CtaVentas='" & CtaVentas & "'")
            If linea.Length > 0 Then
                Return linea(0)
            Else
                Dim mirow As FamiliasContabilidadRow = Me.FamiliasContabilidad.NewFamiliasContabilidadRow
                mirow.CtaVentas = CtaVentas
                mirow.TotalBI = 0
                mirow.TotalIVA = 0
                Me.FamiliasContabilidad.AddFamiliasContabilidadRow(mirow)

                Return mirow
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "DameTotalTarjetasConCliente"
    Private Function DameTotalTarjetasConCliente(ByVal Fecha As Date) As Decimal
        Try
            Dim lineas As DataRow() = Me.HISTORICO_TICKETS.Select("CodigoCliente <> 0 AND FechaTicket = '" & Fecha & "'")

            Dim Acumulado As Decimal = 0
            For i As Integer = 0 To lineas.Length - 1
                Acumulado += CType(lineas(i), HISTORICO_TICKETSRow).ImporteTotal
            Next

            Return Acumulado
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "MarcarComoExportados"
    Private Sub MarcarComoExportados()
        Try
            For i As Integer = 0 To Me.HISTORICO_TICKETS.Count - 1
                Me.HISTORICO_TICKETS(i).Exportado = True
            Next

            Me.taTickets.Update(Me.HISTORICO_TICKETS)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

End Class

Namespace dsHistoricoTableAdapters
    Partial Public Class HISTORICO_TICKETSTableAdapter
        Public ReadOnly Property daTickets() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class
    Partial Public Class HISTORICO_TICKETS_LINEASTableAdapter
        Public ReadOnly Property daLineas() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class
    Partial Public Class TotalesPorClienteTableAdapter
        Public ReadOnly Property daTotales() As SqlClient.SqlDataAdapter
            Get
                If Me.CommandCollection.Length > 0 Then
                    Me.Adapter.SelectCommand = Me.CommandCollection(0)
                End If
                Return Me.Adapter
            End Get
        End Property
    End Class
End Namespace
