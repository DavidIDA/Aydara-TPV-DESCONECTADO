Public Class ConsultaTickets

    Public Historico As Boolean

#Region "ConsultaTickets_FormClosing"
    Private Sub ConsultaTickets_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.DsConsultaTickets.Clear()
        'Me.Dispose()
    End Sub
#End Region

#Region "ConsultaTickets_KeyUp"
    Private Sub ConsultaTickets_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "ConsultaTickets_Load"
    Private Sub ConsultaTickets_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtFechaInicio.EditValue = System.DBNull.Value
        Me.txtFechaFin.EditValue = System.DBNull.Value
        Me.txtCodigoCliente.EditValue = String.Empty
        Me.txtNombreCliente.EditValue = String.Empty
        Me.txtCodigoArticulo.EditValue = String.Empty
        Me.txtDescripcionArticulo.EditValue = String.Empty
        Me.bttModificarCobro.Enabled = False
        Me.CheckVerAnulados.Checked = False
        If Not Historico Then Me.BuscaTickets(Me.CheckVerAnulados.Checked)
    End Sub
#End Region

#Region "ConsultaTickets_Shown"
    Private Sub ConsultaTickets_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.maskPrecio.Mask.EditMask = "c" & DecimalesPrecio
        Me.maskImporte.Mask.EditMask = "c" & DecimalesImporte
        'Me.gvTickets.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
        'Me.gvTickets.FocusedColumn = Me.colHoraTicket
        Me.txtFechaInicio.Focus()
    End Sub
#End Region

#Region "bttReimprimirTicket_Click"
    Private Sub bttReimprimirTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttReimprimirTicket.Click
        If Not IsNothing(Me.gvTickets.GetFocusedRow) Then
            With CType(Me.gvTickets.GetFocusedRow.Row, dsConsultaTickets.TICKETSRow)

                'Iprimir ticket
                If .TipoFactura = 0 Or (.TipoFactura = 1 And AlbaranFormatoTicket) Then
                    Me.ImprimirTicket(.Id)
                End If

                'Imprimir albarán
                If .TipoFactura > 1 Or (.TipoFactura = 1 And AlbaranFormatoA4) Then
                    Me.ImprimirAlbaran(.Id)
                End If

                Me.Close()

            End With
        End If
    End Sub
#End Region

#Region "ImprimirTicket"
    Private Sub ImprimirTicket(ByVal IdTicket As Integer)

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Dim dsTickets As New dsConsultaTickets
        Dim rticket As dsConsultaTickets.TICKETSRow

        Me.Cursor = Cursors.WaitCursor

        Try
            Dim ticket As String
            Dim linea As String
            Dim cabeceraTicket As String = String.Empty
            Dim pieTicket As String = String.Empty
            Dim TotalDtos As Decimal

            ticket = ActivaExpandido()

            'Datos ticket
            cmd.CommandText = "SELECT * FROM " & IIf(Historico, "HISTORICO_TICKETS", "TICKETS") & " WHERE Id=" & IdTicket
            dsTickets.TICKETS.Load(cmd.ExecuteReader)
            If dsTickets.TICKETS.Rows.Count = 1 Then
                rticket = dsTickets.TICKETS.Rows(0)
            Else
                MsgBox("Error al reimprimir el ticket", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            'Datos tienda
            cmd.CommandText = "SELECT TextoCabecera1, TextoCabecera2, Nif, TextoPie FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
            dr = cmd.ExecuteReader
            If dr.Read Then
                cabeceraTicket = dr("TextoCabecera1")
                ticket &= cabeceraTicket
                ticket &= DesactivaExpandido()
                ticket &= vbCrLf & vbCrLf & dr("TextoCabecera2")

                linea = "C.I.F- " & dr("Nif")
                While Len(linea) < 25
                    linea &= " "
                End While
                ticket &= vbCrLf & linea & "* IVA INCLUIDO *"

                ticket &= vbCrLf & Format(rticket.FechaTicket, "dd-MM-yyyy")
                ticket &= " " & Format(CType(rticket.HoraTicket, DateTime), "HH:mm")
                If rticket.TipoFactura = 1 Then
                    ticket &= "  ALBARAN:" & Format(rticket.CodigoCaja, "00") & Format(rticket.NumeroAlbaran, "000000")
                Else
                    ticket &= "  FACTURA:" & Format(rticket.CodigoCaja, "00") & Format(rticket.NumeroTicket, "000000")
                End If
                ticket &= "  T: " & Format(rticket.CodigoTienda, "00")
                ticket &= vbCrLf & "ARTICULO         CANTIDAD    PVP  IMPORTE"
                ticket &= vbCrLf & "-----------------------------------------"
                pieTicket = dr("TextoPie")
            End If
            dr.Close()

            Dim i As Integer
            Dim rLineaTicket As dsConsultaTickets.TICKETS_LINEASRow = Nothing

            'Líneas ticket
            cmd.CommandText = "SELECT * FROM " & IIf(Historico, "HISTORICO_TICKETS_LINEAS", "TICKETS_LINEAS") & " WHERE Ticket_Id=" & IdTicket
            dsTickets.TICKETS_LINEAS.Load(cmd.ExecuteReader)

            For i = 0 To dsTickets.TICKETS_LINEAS.Rows.Count - 1

                rLineaTicket = dsTickets.TICKETS_LINEAS.Rows(i)

                ticket &= vbCrLf

                linea = Mid(rLineaTicket.DescripcionArticulo, 1, 18)

                While Len(linea & IIf(Int(rLineaTicket.Cantidad) = rLineaTicket.Cantidad, Int(rLineaTicket.Cantidad).ToString, Math.Round(rLineaTicket.Cantidad, 2, MidpointRounding.AwayFromZero).ToString)) < 24
                    linea &= " "
                End While
                linea &= IIf(Int(rLineaTicket.Cantidad) = rLineaTicket.Cantidad, Int(rLineaTicket.Cantidad), Math.Round(rLineaTicket.Cantidad, 2, MidpointRounding.AwayFromZero))

                While Len(linea & Math.Round(rLineaTicket.Precio, DecimalesPrecio, MidpointRounding.AwayFromZero).ToString) < 32
                    linea &= " "
                End While
                linea &= Math.Round(rLineaTicket.Precio, DecimalesPrecio, MidpointRounding.AwayFromZero)

                While Len(linea & Math.Round(rLineaTicket.Importe, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                    linea &= " "
                End While
                linea &= Math.Round(rLineaTicket.Importe, DecimalesImporte, MidpointRounding.AwayFromZero)

                If rLineaTicket.Promocion Then
                    linea &= "P"
                ElseIf rLineaTicket.DescuentoLinea <> 0 Then
                    linea &= "*"
                    TotalDtos += (rLineaTicket.Cantidad * rLineaTicket.Precio) - rLineaTicket.Importe
                End If

                ticket &= linea

            Next

            ticket &= vbCrLf & "-----------------------------------------"

            'Totales ventas
            Try
                Dim valor As Decimal
                Dim ImporteBase As Decimal, TotalBases As Decimal, TotalIVA As Decimal
                Dim Diferencia As Decimal, IvaDiferencia As Decimal = TipoIva3

                'ticket &= vbCrLf & "BASE IMPONIBLE      %IVA     IMPORTE IVA"
                'ticket &= vbCrLf & "========================================"

                cmd.CommandText = "SELECT PorcentajeIVA, ISNULL(SUM(Importe),0) AS Total FROM " & IIf(Historico, "HISTORICO_TICKETS_LINEAS", "TICKETS_LINEAS") & _
                                  " WHERE Ticket_Id=" & rticket.Id & " GROUP BY PorcentajeIVA"

                'Calcular diferencia entre bases
                dr = cmd.ExecuteReader
                While dr.Read
                    ImporteBase = Math.Round(dr("Total") / (1 + (dr("PorcentajeIVA") / 100)), DecimalesImporte, MidpointRounding.AwayFromZero)
                    TotalBases += ImporteBase
                    TotalIVA += ImporteBase * dr("PorcentajeIVA") / 100
                    If dr("PorcentajeIVA") = TipoIva2 And IvaDiferencia = TipoIva3 Then IvaDiferencia = TipoIva2
                    If dr("PorcentajeIVA") = TipoIva1 Then IvaDiferencia = TipoIva1
                End While
                dr.Close()
                Diferencia = rticket.ImporteTotal - (TotalBases + TotalIVA)

                'Imprimir líneas IVA
                dr = cmd.ExecuteReader
                While dr.Read

                    linea = "BASE AL "
                    valor = dr("PorcentajeIVA")
                    While Len(linea & Math.Round(valor, 1).ToString) < 12
                        linea &= " "
                    End While
                    linea &= Math.Round(valor, 1) & "%"

                    ImporteBase = Math.Round(dr("Total") / (1 + (dr("PorcentajeIVA") / 100)), DecimalesImporte, MidpointRounding.AwayFromZero)
                    valor = ImporteBase + IIf(dr("PorcentajeIVA") = IvaDiferencia, Diferencia, 0)
                    While Len(linea & Format(Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero), "0.00")) < 24
                        linea &= " "
                    End While
                    linea &= Format(Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero), "0.00")

                    linea &= "   IVA:"
                    valor = ImporteBase * dr("PorcentajeIVA") / 100
                    While Len(linea & Format(Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero), "0.00")) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Format(Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero), "0.00")

                    Diferencia = 0

                End While
                dr.Close()

                ticket &= vbCrLf & "----------------------------------------"

            Catch ex As Exception
                'Error al calcular totales de venta
            End Try

            linea = dsTickets.TICKETS_LINEAS.Rows.Count & " Lineas, T O T A L"
            While Len(linea) + Len(Math.Round(rticket.ImporteTotal, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) * 2 < 40
                linea &= " "
            End While

            ticket &= vbCrLf & linea
            ticket &= ActivaExpandido()
            ticket &= Math.Round(rticket.ImporteTotal, DecimalesImporte, MidpointRounding.AwayFromZero)
            ticket &= DesactivaExpandido() & vbCrLf

            If TotalDtos <> 0 Then
                ticket &= vbCrLf & "* TOTAL DESCUENTOS: " & Math.Round(TotalDtos, DecimalesImporte, MidpointRounding.AwayFromZero) & vbCrLf
            End If

            If rticket.ImporteValesEmitidos <> 0 Then

                ticket &= vbCrLf & "EMISIÓN DE VALE PROPIO"

            Else

                If rticket.ImporteTalonCheque <> 0 Then
                    linea = "TALON"
                    While Len(linea & Math.Round(rticket.ImporteTalonCheque, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rticket.ImporteTalonCheque, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= vbCrLf & linea
                End If

                If rticket.ImporteTarjeta <> 0 Then
                    linea = "TARJETA"
                    While Len(linea & Math.Round(rticket.ImporteTarjeta, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rticket.ImporteTarjeta, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= vbCrLf & linea
                End If

                If rticket.ImporteValesProveedor <> 0 Then
                    linea = "VALE PROV."
                    While Len(linea & Math.Round(rticket.ImporteValesProveedor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rticket.ImporteValesProveedor, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= vbCrLf & linea
                End If

                If rticket.ImporteValesCobrados <> 0 Then
                    linea = "VALE PROP."
                    While Len(linea & Math.Round(rticket.ImporteValesCobrados, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rticket.ImporteValesCobrados, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= vbCrLf & linea
                End If

                If rticket.ImporteEnvases <> 0 Then
                    linea = "ENVASES"
                    While Len(linea & Math.Round(rticket.ImporteEnvases, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rticket.ImporteEnvases, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= vbCrLf & linea
                End If

                If rticket.ImporteEfectivo <> 0 Then
                    linea = "EFECTIVO"
                    While Len(linea & Math.Round(rticket.ImporteEfectivo, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rticket.ImporteEfectivo, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= vbCrLf & linea
                End If

                If rticket.ImportePendienteCobro <> 0 Then
                    linea = "PDTE.COBRO"
                    While Len(linea & Math.Round(rticket.ImportePendienteCobro, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rticket.ImportePendienteCobro, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= vbCrLf & linea
                End If

                If rticket.ImporteCambios <> 0 Then
                    linea = "     CAMBIO"
                    While Len(linea & Math.Round(rticket.ImporteCambios, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rticket.ImporteCambios, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= linea
                End If

            End If

            If Not IsNothing(rLineaTicket) Then
                cmd.CommandText = "SELECT NombreTicket FROM OPERARIOS WHERE Codigo=" & rLineaTicket.CodigoEmleado
                ticket &= vbCrLf & vbCrLf & "LE ATENDIO " & cmd.ExecuteScalar
            End If

            If rticket.RepartoDomicilio Then ticket &= vbCrLf & vbCrLf & "*** REPARTO A DOMICILIO ***"

            ticket += vbCrLf & vbCrLf & pieTicket

            If rticket.TipoFactura = 1 Then
                ticket &= vbCrLf & vbCrLf & vbCrLf
                ticket &= "----------------------------------------"
                ticket &= vbCrLf & "CLIENTE : " & Format(rticket.CodigoCliente, "00000000")
                cmd.CommandText = "SELECT NombreFiscal FROM CLIENTES WHERE Codigo=" & rticket.CodigoCliente
                ticket &= vbCrLf & Mid("NOMBRE  : " & cmd.ExecuteScalar, 1, 40)
                ticket &= vbCrLf & vbCrLf & "Ha efectuado en el dia de hoy compras"
                ticket &= vbCrLf & "por el valor de " & Math.Round(rticket.ImporteTotal, DecimalesImporte, MidpointRounding.AwayFromZero) & " .-"
                ticket &= vbCrLf & "posteriormente se emitira una factura"
                ticket &= vbCrLf & "por este importe desglosando el IVA."
                ticket &= vbCrLf & vbCrLf & "            FIRMADO."
                ticket &= vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf
                ticket &= "----------------------------------------"
            End If

            If rticket.FidelizacionLoteria <> 0 Then

                'Datos sorte
                Dim Sorteo As New dsSorteos

                Sorteo.Cargar()

                If Not Sorteo.SorteoActivo Is Nothing Then
                    With Sorteo.SorteoActivo

                        ticket &= vbCrLf & vbCrLf & vbCrLf
                        ticket &= vbCrLf & "EL PORTADOR DEL TICKET JUEGA LA CANTIDAD"
                        ticket &= vbCrLf & "DE " & Math.Round(rticket.ImporteSorteo, DecimalesImporte, MidpointRounding.AwayFromZero) & ".- EUROS DEL NUMERO " & ActivaExpandido() & dr("Numero") & DesactivaExpandido()
                        ticket &= vbCrLf & "PARA EL PROXIMO SORTEO DEL DIA " & .FechaSorteo.ToShortDateString & "."
                        ticket &= vbCrLf & "DEPOSITADO EN : " & .DepositadoEn
                        ticket &= vbCrLf & "TICKET ROTO O SIN EL SELLO, SERA NULO."

                    End With
                End If


            ElseIf rticket.FidelizacionPuntos <> 0 Then

                Dim Cliente As New dsClientesTableAdapters.CLIENTESTableAdapter

                ticket &= vbCrLf & "PUNTOS GENERADOS  :" & Int(rticket.FidelizacionPuntos)
                ticket &= vbCrLf & "PUNTOS ACUMULADOS :" & Int(Cliente.SaldoPuntos(rticket.CodigoCliente)) + Int(rticket.FidelizacionPuntos)

            ElseIf rticket.FidelizacionVales <> 0 Then

                ticket &= vbCrLf & vbCrLf
                ticket &= "POR ESTA COMPRA HA OBTENIDO :"
                ticket &= vbCrLf & vbCrLf & ActivaExpandido() & "    " & Int(rticket.ImporteSorteo) & " PUNTOS" & DesactivaExpandido()

            ElseIf rticket.FidelizacionImporte <> 0 Then

                ticket &= vbCrLf & vbCrLf
                ticket &= "POR ESTA COMPRA HA OBTENIDO :"
                ticket &= vbCrLf & vbCrLf & ActivaExpandido() & "    " & Int(rticket.ImporteSorteo) & " EUROS" & DesactivaExpandido()

            End If

            If ActivaCorteTicket Then ticket += CorteTicket()

            If rticket.RepartoDomicilio Then
                ticket &= "** REPARTO A DOMICILIO " & Format(rticket.NumeroTicket, "000000") & " **"
                ticket &= vbCrLf & "FECHA " & rticket.FechaTicket
                ticket &= vbCrLf & vbCrLf & rticket.DireccionReparto
                If ActivaCorteTicket Then ticket &= CorteTicket()
            End If

            Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Error al reimprimir el ticket." & vbCrLf & ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

#Region "ImprimirAlbaran"
    Private Sub ImprimirAlbaran(ByVal IdTicket As Integer)

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Dim dsFactura As New dsInfFactura
        Dim rticket As dsInfFactura.TICKETSRow

        Me.Cursor = Cursors.WaitCursor

        Try
            Dim ticket As String
            Dim cabeceraTicket As String = String.Empty
            Dim pieTicket As String = String.Empty

            ticket = ActivaExpandido()

            'Datos ticket
            cmd.CommandText = "SELECT t.*, f.DescFor FROM " & IIf(Historico, "HISTORICO_TICKETS", "TICKETS") & " t LEFT OUTER JOIN FORMAPAG f ON t.ForPag = f.FORPAG WHERE t.Id=" & IdTicket
            dsFactura.TICKETS.Load(cmd.ExecuteReader)
            If dsFactura.TICKETS.Rows.Count = 1 Then
                rticket = dsFactura.TICKETS.Rows(0)
            Else
                MsgBox("Error al imprimir el albarán", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            'Datos tienda
            cmd.CommandText = "SELECT * FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
            dsFactura.TIENDAS.Load(cmd.ExecuteReader)

            'Datos cliente
            If rticket.IsClienteCreditoNull Then
                DameCliente.ShowDialog()
                rticket.ClienteCredito = DameCliente.CodigoCliente
            End If

            If rticket.TipoFactura = 3 Then
                cmd.CommandText = "SELECT * FROM CLIENTES WHERE Codigo = 0"
            Else
                cmd.CommandText = "SELECT * FROM CLICREDI WHERE Codigo = " & rticket.ClienteCredito
            End If
            dsFactura.CLIENTES.Load(cmd.ExecuteReader)

            'Líneas ticket
            cmd.CommandText = "SELECT * FROM " & IIf(Historico, "HISTORICO_TICKETS_LINEAS", "TICKETS_LINEAS") & " WHERE Ticket_Id=" & rticket.Id
            dsFactura.TICKETS_LINEAS.Load(cmd.ExecuteReader)

            'Totales ticket
            Informes.TotalesTicket(dsFactura)

            Dim Informe As New InfFactura

            'Nombre empleado
            Informe.RequestParameters = False

            If dsFactura.TICKETS_LINEAS.Rows.Count > 0 Then
                cmd.CommandText = "SELECT NombreTicket FROM OPERARIOS WHERE Codigo=" & dsFactura.TICKETS_LINEAS.Rows(0).Item("CodigoEmleado")
                Informe.Parameters("Empleado").Value = "LE ATENDIO: " & cmd.ExecuteScalar
            End If

            Informe.Parameters("Numero").Value = rticket.NumeroAlbaran

            If dsFactura.TIENDAS.Count > 0 Then
                With dsFactura.TIENDAS(0)

                    Select Case rticket.TipoFactura
                        Case 1
                            Informe.Parameters("Documento").Value = "ALBARÁN"
                            If Not .IsSerieAlbaranNull Then Informe.Parameters("Numero").Value = .SerieAlbaran.Trim & "-" & rticket.NumeroAlbaran
                        Case 2
                            Informe.Parameters("Documento").Value = "FACTURA"
                            If Not .IsSerieFactura1Null Then Informe.Parameters("Numero").Value = .SerieFactura1.Trim & "-" & rticket.NumeroAlbaran
                        Case 3
                            Informe.Parameters("Documento").Value = "ALBARÁN"
                            If Not .IsSerieFactura2Null Then Informe.Parameters("Numero").Value = .SerieFactura2.Trim & "-" & rticket.NumeroAlbaran
                    End Select

                End With
            End If

            Informe.DataSource = dsFactura

            Informe.CreateDocument()

            Dim printTool As New DevExpress.XtraPrinting.PrintTool(Informe.PrintingSystem)

            If My.Settings.ImpresoraFacturas = String.Empty Then

                Dim f As New PreImpreso
                f.Informe.PrintingSystem = Informe.PrintingSystem

                If Not printTool.PrintDialog Then
                    General.AbrirFormulario(f, Informe.Parameters("Documento").Value & " Nº " & rticket.NumeroAlbaran)
                End If

            Else
                printTool.Print(My.Settings.ImpresoraFacturas)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Error al imprimir el documento." & vbCrLf & ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

#Region "BuscaTickets"
    Private Sub BuscaTickets(ByVal VerAnulados As Boolean)

        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Dim TablaCabeceras As String, TablaLineas As String

        If VerAnulados Then
            TablaCabeceras = "HISTORICO_TICKETS_ANULADOS"
            TablaLineas = "HISTORICO_TICKETS_ANULADOS_LINEAS"
        Else
            TablaCabeceras = IIf(Historico, "HISTORICO_TICKETS", "TICKETS")
            TablaLineas = IIf(Historico, "HISTORICO_TICKETS_LINEAS", "TICKETS_LINEAS")
        End If

        Try
            Me.DsConsultaTickets.Clear()

            'Cabeceras tickets
            If VerAnulados Then
                cmd.CommandText = "SELECT HoraTicket AS FechaTicket, HISTORICO_TICKETS_ANULADOS.*, CLIENTES.NombreFiscal, CONVERT(VARCHAR," & TablaCabeceras & ".NumeroTicket) AS NumeroDocumento"
            Else
                cmd.CommandText = "SELECT HoraTicket AS FechaTicket, " & TablaCabeceras & ".*, ISNULL(CLICREDI.NombreFiscal,CLIENTES.NombreFiscal) AS NombreFiscal, " & _
                                  "CASE TipoFactura WHEN 1 THEN 'A-' + CONVERT(VARCHAR," & TablaCabeceras & ".NumeroAlbaran) WHEN 2 THEN 'F1-' + CONVERT(VARCHAR," & TablaCabeceras & ".NumeroAlbaran) WHEN 3 THEN 'F2-' + CONVERT(VARCHAR," & TablaCabeceras & ".NumeroAlbaran) ELSE 'T-' + CONVERT(VARCHAR," & TablaCabeceras & ".NumeroTicket) END AS NumeroDocumento"
            End If

            cmd.CommandText &= " FROM " & TablaCabeceras & " LEFT JOIN CLIENTES ON " & TablaCabeceras & ".CodigoCliente=CLIENTES.Codigo"

            If Not VerAnulados Then cmd.CommandText &= " LEFT JOIN CLICREDI ON " & TablaCabeceras & ".ClienteCredito=CONVERT(int,CLICREDI.Codigo)"

            cmd.CommandText &= " WHERE CodigoTienda=" & CodigoTienda & " AND EnEspera=0"

            If Not Historico Then cmd.CommandText &= " AND CodigoCaja=" & CodigoCaja

            If IsDate(Me.txtFechaInicio.EditValue) Then cmd.CommandText &= " AND " & TablaCabeceras & ".FechaTicket>='" & Me.txtFechaInicio.EditValue & "'"
            If IsDate(Me.txtFechaFin.EditValue) Then cmd.CommandText &= " AND " & TablaCabeceras & ".FechaTicket<='" & Me.txtFechaFin.EditValue & "'"
            If Not VerAnulados Then If IsNumeric(Me.txtCodigoCliente.EditValue) Then cmd.CommandText &= " AND " & TablaCabeceras & ".ClienteCredito='" & Me.txtCodigoCliente.EditValue & "'"
            If Me.txtCodigoArticulo.EditValue <> String.Empty Then cmd.CommandText &= " AND " & TablaCabeceras & ".Id IN (SELECT Ticket_Id FROM " & TablaLineas & " WHERE CodigoArticulo='" & Me.txtCodigoArticulo.EditValue & "')"

            cmd.CommandText &= " ORDER BY HoraTicket DESC"

            Me.DsConsultaTickets.TICKETS.Load(cmd.ExecuteReader)

            'Líneas tickets
            cmd.CommandText = "SELECT " & TablaLineas & ".* FROM " & TablaCabeceras & " INNER JOIN " & TablaLineas & " ON " & TablaCabeceras & ".Id=" & TablaLineas & ".Ticket_Id " & _
                              "WHERE CodigoTienda=" & CodigoTienda & " AND EnEspera=0"

            If Not Historico Then cmd.CommandText &= " AND CodigoCaja=" & CodigoCaja

            If IsDate(Me.txtFechaInicio.EditValue) Then cmd.CommandText &= " AND " & TablaCabeceras & ".FechaTicket>='" & Me.txtFechaInicio.EditValue & "'"
            If IsDate(Me.txtFechaFin.EditValue) Then cmd.CommandText &= " AND " & TablaCabeceras & ".FechaTicket<='" & Me.txtFechaFin.EditValue & "'"
            If Not VerAnulados Then If IsNumeric(Me.txtCodigoCliente.EditValue) Then cmd.CommandText &= " AND " & TablaCabeceras & ".ClienteCredito='" & Me.txtCodigoCliente.EditValue & "'"
            If Me.txtCodigoArticulo.EditValue <> String.Empty Then cmd.CommandText &= " AND " & TablaLineas & ".Ticket_Id IN (SELECT Ticket_Id FROM " & TablaLineas & " WHERE CodigoArticulo='" & Me.txtCodigoArticulo.EditValue & "')"

            Me.DsConsultaTickets.TICKETS_LINEAS.Load(cmd.ExecuteReader)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Me.BuscaTickets(Me.CheckVerAnulados.Checked)
    End Sub
#End Region

#Region "txtCodigoCliente_ButtonClick"
    Private Sub txtCodigoCliente_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoCliente.ButtonClick
        Try

            Dim dsClientes As New dsClientes, tClientes As New dsClientesTableAdapters.CLICREDITableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("NombreFiscal")
            Columnas.Add("Nombre Fiscal")
            Columnas.Add(250)
            Columnas.Add(250)

            Columnas.Add("Direccion")
            Columnas.Add("Dirección")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("Nif")
            Columnas.Add("N.I.F.")
            Columnas.Add(100)
            Columnas.Add(100)

            tClientes.Fill(dsClientes.CLICREDI)

            If Buscar(dsClientes, "CLICREDI", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoCliente.EditValue = ResultadoBusqueda
                Me.txtCodigoCliente.IsModified = True
                Me.txtCodigoCliente_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoCliente_Validated"
    Private Sub txtCodigoCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCliente.Validated

        If Not Me.txtCodigoCliente.IsModified Then Exit Sub

        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT NombreFiscal FROM CLICREDI WHERE LTRIM(Codigo) = '" & Me.txtCodigoCliente.EditValue.ToString.Trim & "'"
            Me.txtNombreCliente.EditValue = cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox("Error al buscar el cliente", MsgBoxStyle.Information)
        Finally
            cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "txtCodigoArticulo_ButtonClick"
    Private Sub txtCodigoArticulo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoArticulo.ButtonClick
        Try
            Dim dsArticulos As New dsArticulos
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(0) 'Tamaño columna
            Columnas.Add(0) 'Tamaño máximo columna

            Columnas.Add("Etiqueta")
            Columnas.Add("Familia-Subf")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("Codigo")
            Columnas.Add("Código")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("Descripcion")
            Columnas.Add("Descripción")
            Columnas.Add(0)
            Columnas.Add(0)

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT (SELECT Codigo FROM FAMILIASARTICULOS WHERE FAMILIASARTICULOS.Id=ARTICULOS.CodigoFamilia) + ' - ' + " & _
                              "(SELECT Codigo FROM SUBFAMILIASARTICULOS WHERE Familia_Id=ARTICULOS.CodigoFamilia AND SUBFAMILIASARTICULOS.Id=ARTICULOS.CodigoSubfamilia) AS Etiqueta, " & _
                              "Codigo, Descripcion FROM ARTICULOS ORDER BY Etiqueta, Descripcion"

            dsArticulos.ARTICULOS.Load(cmd.ExecuteReader)

            cmd.Connection.Close()

            If Buscar(dsArticulos, "ARTICULOS", Columnas, 3, True).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoArticulo.Text = ResultadoBusqueda
                Me.txtCodigoArticulo.IsModified = True
                Me.txtCodigoArticulo_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoArticulo_Validated"
    Private Sub txtCodigoArticulo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoArticulo.Validated

        If Not Me.txtCodigoArticulo.IsModified Then Exit Sub

        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT Descripcion FROM ARTICULOS WHERE Codigo='" & Me.txtCodigoArticulo.EditValue & "'"
            Me.txtDescripcionArticulo.EditValue = cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox("Error al buscar el cliente", MsgBoxStyle.Information)
        Finally
            cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "bttImprimirFactura_Click"
    Private Sub bttImprimirFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimirFactura.Click
        If Not IsNothing(Me.gvTickets.GetFocusedRow) Then
            Me.ImprimirFactura(Me.gvTickets.GetFocusedRowCellValue(Me.colId))
            Me.Close()
        End If
    End Sub
#End Region

#Region "ImprimirFactura"
    Public Sub ImprimirFactura(ByVal IdTicket As Integer)

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Dim dsFactura As New dsInfFactura
        Dim rticket As dsInfFactura.TICKETSRow

        Me.Cursor = Cursors.WaitCursor

        Try
            Dim ticket As String
            Dim cabeceraTicket As String = String.Empty
            Dim pieTicket As String = String.Empty

            ticket = ActivaExpandido()

            'Datos ticket
            cmd.CommandText = "SELECT t.*, f.DescFor FROM " & IIf(Historico, "HISTORICO_TICKETS", "TICKETS") & " t LEFT OUTER JOIN FORMAPAG f ON t.ForPag = f.FORPAG WHERE t.Id=" & IdTicket
            dsFactura.TICKETS.Load(cmd.ExecuteReader)
            If dsFactura.TICKETS.Rows.Count = 1 Then
                rticket = dsFactura.TICKETS.Rows(0)
            Else
                MsgBox("Error al reimprimir la factura", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            'Datos tienda
            cmd.CommandText = "SELECT * FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
            dsFactura.TIENDAS.Load(cmd.ExecuteReader)

            'Datos cliente
            If rticket.CodigoCliente = 0 Then
                Dim fDameCliente As New DameCliente
                If fDameCliente.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    rticket.CodigoCliente = fDameCliente.CodigoCliente
                End If
            End If

            Dim Cliente As New dsClientes
            cmd.CommandText = "SELECT * FROM CLIENTES WHERE Codigo=" & rticket.CodigoCliente
            Cliente.CLIENTES.Load(cmd.ExecuteReader)

            If Cliente.CLIENTES.Count > 0 Then

                Dim fDatosCliente As New fDatosCliente

                With Cliente.CLIENTES(0)
                    fDatosCliente.txtNombreFiscal.EditValue = .NombreFiscal
                    fDatosCliente.txtDireccion.EditValue = .Direccion
                    fDatosCliente.txtCodigoPostal.EditValue = .CodigoPostal
                    fDatosCliente.txtPoblacion.EditValue = .Poblacion
                    fDatosCliente.txtProvincia.EditValue = .Provincia
                    fDatosCliente.txtNIF.EditValue = .CIF
                    If fDatosCliente.ShowDialog = Windows.Forms.DialogResult.OK Then

                        Dim rCliente As dsInfFactura.CLIENTESRow = dsFactura.CLIENTES.NewCLIENTESRow
                        rCliente.Codigo = 0
                        rCliente.NombreFiscal = fDatosCliente.txtNombreFiscal.EditValue
                        rCliente.Direccion = fDatosCliente.txtDireccion.EditValue
                        rCliente.CodigoPostal = fDatosCliente.txtCodigoPostal.EditValue
                        rCliente.Poblacion = fDatosCliente.txtPoblacion.EditValue
                        rCliente.Provincia = fDatosCliente.txtProvincia.EditValue
                        rCliente.Nif = fDatosCliente.txtNIF.EditValue
                        dsFactura.CLIENTES.AddCLIENTESRow(rCliente)

                    End If
                End With

            End If

            'Líneas ticket
            cmd.CommandText = "SELECT * FROM " & IIf(Historico, "HISTORICO_TICKETS_LINEAS", "TICKETS_LINEAS") & " WHERE Ticket_Id=" & IdTicket
            dsFactura.TICKETS_LINEAS.Load(cmd.ExecuteReader)

            'Totales ticket
            Informes.TotalesTicket(dsFactura)

            Dim Informe As New InfTicket

            'Nombre empleado
            Informe.RequestParameters = False
            If dsFactura.TICKETS_LINEAS.Rows.Count > 0 Then
                cmd.CommandText = "SELECT NombreTicket FROM OPERARIOS WHERE Codigo=" & dsFactura.TICKETS_LINEAS.Rows(0).Item("CodigoEmleado")
                Informe.Parameters("Empleado").Value = "LE ATENDIO: " & cmd.ExecuteScalar
            End If

            Informe.Parameters("Documento").Value = "FACTURA"
            Informe.Parameters("Numero").Value = rticket.NumeroTicket

            Informe.DataSource = dsFactura

            Informe.CreateDocument()

            Dim printTool As New DevExpress.XtraPrinting.PrintTool(Informe.PrintingSystem)

            If My.Settings.ImpresoraFacturas = String.Empty Then

                Dim f As New PreImpreso
                f.Informe.PrintingSystem = Informe.PrintingSystem

                If Not printTool.PrintDialog Then
                    General.AbrirFormulario(f, Informe.Parameters("Documento").Value & " Nº " & rticket.NumeroTicket)
                End If

            Else
                printTool.Print(My.Settings.ImpresoraFacturas)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Error al reimprimir el ticket." & vbCrLf & ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

#Region "gvTickets_FocusedRowChanged"
    Private Sub gvTickets_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvTickets.FocusedRowChanged
        Try
            With CType(Me.gvTickets.GetFocusedDataRow, dsConsultaTickets.TICKETSRow)
                Me.bttModificarCobro.Enabled = Not Historico
                Me.bttImprimirFactura.Enabled = .TipoFactura = 0
            End With

        Catch ex As Exception
            Me.bttModificarCobro.Enabled = False
        End Try
    End Sub
#End Region

#Region "bttModificarCobro_Click"
    Private Sub bttModificarCobro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttModificarCobro.Click

        Dim conexion As New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        conexion.Open()
        Dim transaccion As SqlClient.SqlTransaction
        transaccion = conexion.BeginTransaction()

        Dim dsTickets As New dsTickets
        Dim taTickets As New dsTicketsTableAdapters.TICKETSTableAdapter
        Dim taLineasTicket As New dsTicketsTableAdapters.TICKETS_LINEASTableAdapter
        Dim rTicket As dsTickets.TICKETSRow

        Try
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = conexion
            cmd.Transaction = transaccion

            With CType(Me.gvTickets.GetFocusedDataRow, dsConsultaTickets.TICKETSRow)

                If .TipoFactura <> 0 Then

                    cmd.CommandText = "SELECT * FROM TICKETS WHERE Id = " & .Id
                    dsTickets.TICKETS.Load(cmd.ExecuteReader)

                    'Validar ticket
                    If dsTickets.TICKETS.Count = 1 Then
                        rTicket = dsTickets.TICKETS(0)
                    Else
                        Exit Try
                    End If

                    Dim f As New fCobroCredito
                    Select Case rTicket.TipoCobro
                        Case "E"
                            f.bttEfectivoFactura.Checked = True
                        Case "T"
                            f.bttTarjetaFactura.Checked = True
                        Case "P"
                            f.bttPendienteFactura.Checked = True
                    End Select

                    If f.ShowDialog = Windows.Forms.DialogResult.OK Then

                        rTicket.TipoCobro = f.TipoCobro
                        rTicket.ImporteEfectivo = 0
                        rTicket.ImporteTarjeta = 0
                        rTicket.ImportePendienteCobro = 0

                        Select Case rTicket.TipoCobro
                            Case "E"
                                rTicket.ImporteEfectivo = rTicket.ImporteTotal
                            Case "T"
                                rTicket.ImporteTarjeta = rTicket.ImporteTotal
                            Case "P"
                                rTicket.ImportePendienteCobro = rTicket.ImporteTotal
                        End Select

                        'Guardar ticket
                        taTickets.Update(dsTickets.TICKETS)

                    End If

                Else

                    'Definir pantalla para el cobro
                    Dim f As New CobroTicket
                    f.ModificarCobro = True
                    f.ControlBox = True
                    f.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
                    f.StartPosition = FormStartPosition.CenterParent

                    cmd.CommandText = "SELECT * FROM TICKETS WHERE Id = " & Me.gvTickets.GetFocusedRowCellValue(Me.colId)
                    dsTickets.TICKETS.Load(cmd.ExecuteReader)

                    cmd.CommandText = "SELECT * FROM TICKETS_LINEAS WHERE Ticket_Id = " & Me.gvTickets.GetFocusedRowCellValue(Me.colId)
                    dsTickets.TICKETS_LINEAS.Load(cmd.ExecuteReader)

                    'Validar ticket
                    If dsTickets.TICKETS.Count = 1 Then
                        rTicket = dsTickets.TICKETS(0)
                        f.rTicket = rTicket
                    Else
                        Exit Try
                    End If

                    'Eliminar pendientes de cobro
                    cmd.CommandText = "DELETE FROM PENDIENTES_COBRO " & _
                                      "WHERE CodigoTienda = " & rTicket.CodigoTienda & " AND CodigoCaja = " & rTicket.CodigoCaja & " AND CodigoCliente = " & rTicket.CodigoCliente & " AND CodigoTicket=" & rTicket.NumeroTicket
                    cmd.ExecuteNonQuery()

                    f.LineasTicket = dsTickets.TICKETS_LINEAS.Select
                    If f.ShowDialog = Windows.Forms.DialogResult.OK Then

                        Me.Cursor = Cursors.WaitCursor

                        'Imprimir albarán de crédito
                        If rTicket.TipoFactura = 1 Then
                            cmd.CommandText = "UPDATE TIENDAS SET NumeroAlbaran=ISNULL(NumeroAlbaran,0)+1 WHERE CodigoTienda=" & CodigoTienda
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "SELECT NumeroAlbaran FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
                            rTicket.NumeroAlbaran = cmd.ExecuteScalar
                        End If

                        'Imprimir factura de crédito
                        If rTicket.TipoFactura = 2 Then
                            cmd.CommandText = "UPDATE TIENDAS SET NumeroFactura1 = ISNULL(NumeroFactura1,0) + 1 WHERE CodigoTienda=" & CodigoTienda
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "SELECT NumeroFactura1 FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
                            rTicket.NumeroAlbaran = cmd.ExecuteScalar
                        End If

                        'Imprimir factura de crédito (Serie 2)
                        If rTicket.TipoFactura = 3 Then
                            cmd.CommandText = "UPDATE TIENDAS SET NumeroFactura2 = ISNULL(NumeroFactura2,0) + 1 WHERE CodigoTienda=" & CodigoTienda
                            cmd.ExecuteNonQuery()
                            cmd.CommandText = "SELECT NumeroFactura2 FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
                            rTicket.NumeroAlbaran = cmd.ExecuteScalar
                        End If

                        'Guardar ticket
                        taTickets.Update(dsTickets.TICKETS)
                        taLineasTicket.Update(dsTickets.TICKETS_LINEAS)

                        'Borra pendientes
                        transaccion.Commit()

                        'Añadir pendiente de cobro si ha seleccionado esa opción
                        If rTicket.TipoCobro = "P" Then
                            Dim dsPendientesCobro As New dsPendientesCobro
                            Dim tPendientesCobro As New dsPendientesCobroTableAdapters.PENDIENTES_COBROTableAdapter
                            Dim rPendientesCobro As dsPendientesCobro.PENDIENTES_COBRORow

                            rPendientesCobro = dsPendientesCobro.PENDIENTES_COBRO.NewPENDIENTES_COBRORow
                            rPendientesCobro.CodigoCliente = f.txtCodigoCliente.EditValue
                            rPendientesCobro.CodigoTienda = CodigoTienda
                            rPendientesCobro.CodigoCaja = CodigoCaja
                            rPendientesCobro.CodigoTicket = rTicket.NumeroTicket
                            rPendientesCobro.Fecha = rTicket.FechaTicket
                            Dim DatosCliente() As String = Split(f.txtDatosCliente.EditValue, vbCrLf)
                            rPendientesCobro.Nombre = Mid(DatosCliente(0), 1, 50)
                            rPendientesCobro.ImporteTicket = rTicket.ImporteTotal
                            rPendientesCobro.ImporteCobrado = rTicket.ImporteTotal - rTicket.ImportePendienteCobro

                            dsPendientesCobro.PENDIENTES_COBRO.AddPENDIENTES_COBRORow(rPendientesCobro)
                            tPendientesCobro.Update(dsPendientesCobro.PENDIENTES_COBRO)
                        End If

                    Else
                        dsTickets.RejectChanges()
                        transaccion.Rollback()
                    End If

                End If
            End With

        Catch ex As Exception
            transaccion.Rollback()
            MsgBox("Error al cobrar ticket." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Cobro ticket")
        Finally
            Me.Cursor = Cursors.Default
            TPV_Tactil.txtTotal.EditValue = 0
            TPV_Tactil.txtCodigoCliente_Validated(Nothing, Nothing)
        End Try

        conexion.Close()

        Me.gvTickets.RefreshData()

    End Sub
#End Region

End Class