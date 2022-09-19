Public Class CierreTienda

    Dim Empleado As String

#Region "CierreTienda_Load"
    Private Sub CierreTienda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Dim tCajas As dsTiendas.SITUACIONDataTable
        tCajas = General.SituacionTienda.SITUACION
        Dim rCajas As dsTiendas.SITUACIONRow

        Try
            If Me.Tag <> "R" Then

                'Comprobar cajas
                cmd.Connection.Open()

                cmd.CommandText = "SELECT CodigoCaja FROM CAJAS WHERE CodigoTienda=" & CodigoTienda & " AND CajaCerrada=0"

                dr = cmd.ExecuteReader
                While dr.Read
                    For i As Integer = 0 To tCajas.Rows.Count - 1
                        rCajas = tCajas.Rows(i)
                        If dr(0) = rCajas.CodigoCaja Then
                            For j As Integer = 1 To tCajas.Columns.Count - 1
                                If rCajas(j) <> 0 Then
                                    MsgBox("Debe cerrar todas las cajas antes de efectuar el cierre de tienda", MsgBoxStyle.Information)
                                    Me.Close()
                                    Exit Sub
                                End If
                            Next
                        End If
                    Next
                End While
                dr.Close()

                'Pedir caja de cierre
                If Not Me.SeleccionaCaja() Then Me.Close() : Exit Try

                'Pedir empleado
                If Not Me.SeleccionaEmpleado() Then Me.Close() : Exit Try

            End If

            'Fecha actual
            Me.txtFechaCierre.EditValue = Date.Today

        Catch ex As Exception
            MsgBox("Error al comprobar cajas", MsgBoxStyle.Exclamation)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "CierreTienda_Shown"
    Private Sub CierreTienda_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.bttAceptar.Focus()
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "bttAceptar_Click"
    Private Sub bttAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAceptar.Click

        Dim conexion As New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        conexion.Open()

        Dim transaccion As SqlClient.SqlTransaction
        transaccion = conexion.BeginTransaction()

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = conexion
        cmd.Transaction = transaccion

        Try
            Me.Cursor = Cursors.WaitCursor

            If Me.Tag <> "R" Then

                'Iprimir ticket
                If ImprimeTicket = 0 Then
                    ImprimirTicket()
                ElseIf ImprimeTicket = 2 Then
                    If MsgBox("¿Desea imprimir el cierre?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Imprimir cierre") = MsgBoxResult.Yes Then
                        ImprimirTicket()
                    End If
                End If

            End If

            'Generar fichero para enviar
            If General.Comunicaciones_Tipo > 0 And General.TipoTienda <> 1 Then

                Dim dsComunicaciones As New dsComunicaciones

                'Comprobar si es cierre del día o es un reenvío
                If Me.Tag <> "R" Then
                    cmd.CommandText = "SELECT TICKETS.Id AS IdTicket, TICKETS.*, TICKETS_LINEAS.*, ISNULL(ARTICULOS.TipoIva,1) AS TipoIva " & _
                                      "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id " & _
                                      "LEFT JOIN ARTICULOS ON TICKETS_LINEAS.CodigoArticulo = ARTICULOS.Codigo " & _
                                      "WHERE TICKETS.CodigoTienda = " & CodigoTienda & " AND TICKETS.EnEspera = 0 " & _
                                      "ORDER BY TICKETS.Id"
                Else
                    cmd.CommandText = "SELECT HISTORICO_TICKETS.Id AS IdTicket, HISTORICO_TICKETS.*, HISTORICO_TICKETS_LINEAS.*, ISNULL(ARTICULOS.TipoIva,1) AS TipoIva " & _
                                      "FROM HISTORICO_TICKETS INNER JOIN HISTORICO_TICKETS_LINEAS ON HISTORICO_TICKETS.Id = HISTORICO_TICKETS_LINEAS.Ticket_Id " & _
                                      "LEFT JOIN ARTICULOS ON HISTORICO_TICKETS_LINEAS.CodigoArticulo = ARTICULOS.Codigo " & _
                                      "WHERE HISTORICO_TICKETS.CodigoTienda = " & CodigoTienda & " AND HISTORICO_TICKETS.FechaTicket = '" & Me.txtFechaCierre.EditValue & "' " & _
                                      "ORDER BY HISTORICO_TICKETS.Id"
                End If

                dsComunicaciones.TICKETS.Load(cmd.ExecuteReader)

                Dim NombreFichero As String = "tien" & Format(General.NumeroAlmacen, "00") & Format(Me.txtFechaCierre.DateTime.Day, "00") & ".seq"

                Comunicacion.GeneraTickets(dsComunicaciones, Me.txtFechaCierre.EditValue, NombreFichero, (Me.Tag = "R"))

            End If

            If Me.Tag <> "R" Then

                'Traspasar cabecera de tickets al histórico
                cmd.CommandText = "INSERT INTO HISTORICO_TICKETS (Id, CodigoTienda, CodigoCaja, NumeroTicket, FechaTicket, HoraTicket, TipoCobro, CodigoCliente, ImpresoTicket, " & _
                                  "ImporteEfectivo, ImporteTalonCheque, ImporteValesProveedor, ImporteValesCobrados, ImporteTarjeta, ImporteEnvases, " & _
                                  "ImportePendienteCobro, ImporteValesEmitidos, ImporteTotalCambios, ImporteCambios, PorcentajeDescuento, ImporteDescuento, " & _
                                  "NumeroLineas, ImporteTotal, EnEspera, RepartoDomicilio, DireccionReparto, ImporteSorteo, CierreTurno, FechaCierre, NumeroAlbaran," & _
                                  "TipoFactura, PuntosCanjeados, ClienteCredito, FidelizacionImporte, FidelizacionVales, FidelizacionPuntos, FidelizacionLoteria, ValesCanjeados, TotalRecargo, TotalDtoPP, Km, ForPag)"

                cmd.CommandText &= "SELECT Id, CodigoTienda, CodigoCaja, NumeroTicket, FechaTicket, HoraTicket, TipoCobro, CodigoCliente, ImpresoTicket, " & _
                                  "ImporteEfectivo, ImporteTalonCheque, ImporteValesProveedor, ImporteValesCobrados, ImporteTarjeta, ImporteEnvases, " & _
                                  "ImportePendienteCobro, ImporteValesEmitidos, ImporteTotalCambios, ImporteCambios, PorcentajeDescuento, ImporteDescuento, " & _
                                  "NumeroLineas, ImporteTotal, EnEspera, RepartoDomicilio, DireccionReparto, ImporteSorteo, CierreTurno, " & _
                                  "'" & Me.txtFechaCierre.EditValue & "' AS FechaCierre, NumeroAlbaran, TipoFactura, PuntosCanjeados, ClienteCredito, FidelizacionImporte, FidelizacionVales, FidelizacionPuntos, FidelizacionLoteria, ValesCanjeados, TotalRecargo, TotalDtoPP, Km, ForPag " & _
                                  "FROM TICKETS " & _
                                  "WHERE CodigoTienda=" & General.CodigoTienda & " AND TICKETS.EnEspera = 0"

                cmd.ExecuteNonQuery()

                'Traspasar líneas de tickets al histórico
                cmd.CommandText = "INSERT INTO HISTORICO_TICKETS_LINEAS (Id, Ticket_Id, CodigoArticulo, Promocion, PrecioManual, CodigoEmleado, " & _
                                  "DescripcionArticulo, Cantidad, Precio, DescuentoLinea, Importe, Peso, PorcentajeIVA, NumeroTalla, CodigoColor, " & _
                                  "CodigoArticuloRegalo, UnidadesRegalo, PrecioRegalo, CodigoColorPromocion, NumeroTallaPromocion, FraccionSinCargo, UnidadesSinCargo, UnidadStock, ImporteEcoraee, " & _
                                  "DtoFidelizacion, FechaCierre)"

                cmd.CommandText &= "SELECT TICKETS_LINEAS.Id, TICKETS_LINEAS.Ticket_Id, TICKETS_LINEAS.CodigoArticulo, TICKETS_LINEAS.Promocion, TICKETS_LINEAS.PrecioManual, TICKETS_LINEAS.CodigoEmleado, " & _
                                  "TICKETS_LINEAS.DescripcionArticulo, TICKETS_LINEAS.Cantidad, TICKETS_LINEAS.Precio, TICKETS_LINEAS.DescuentoLinea, TICKETS_LINEAS.Importe, TICKETS_LINEAS.Peso, TICKETS_LINEAS.PorcentajeIVA, TICKETS_LINEAS.NumeroTalla, TICKETS_LINEAS.CodigoColor, " & _
                                  "TICKETS_LINEAS.CodigoArticuloRegalo, TICKETS_LINEAS.UnidadesRegalo, TICKETS_LINEAS.PrecioRegalo, TICKETS_LINEAS.CodigoColorPromocion, TICKETS_LINEAS.NumeroTallaPromocion, TICKETS_LINEAS.FraccionSinCargo, TICKETS_LINEAS.UnidadesSinCargo, TICKETS_LINEAS.UnidadStock, TICKETS_LINEAS.ImporteEcoraee, " & _
                                  "TICKETS_LINEAS.DtoFidelizacion, '" & Me.txtFechaCierre.EditValue & "' AS FechaCierre " & _
                                  "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id=TICKETS_LINEAS.Ticket_Id " & _
                                  "WHERE TICKETS.CodigoTienda=" & General.CodigoTienda & " AND TICKETS.EnEspera = 0"

                cmd.ExecuteNonQuery()

                'Actualizar movimientos de caja
                cmd.CommandText = "UPDATE MOVIMIENTOS_CAJA " & _
                                  "SET FechaCierre='" & Me.txtFechaCierre.EditValue & "' " & _
                                  "WHERE FechaCierre IS NULL AND CodigoTienda=" & General.CodigoTienda
                cmd.ExecuteNonQuery()

                'Eliminar líneas de tickets
                cmd.CommandText = "DELETE TICKETS_LINEAS " & _
                                  "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id=TICKETS_LINEAS.Ticket_Id " & _
                                  "WHERE TICKETS.CodigoTienda=" & General.CodigoTienda & " AND TICKETS.EnEspera = 0"
                cmd.ExecuteNonQuery()

                'Eliminar cabecera de tickets
                cmd.CommandText = "DELETE TICKETS " & _
                                  "WHERE CodigoTienda=" & General.CodigoTienda & " AND TICKETS.EnEspera = 0"
                cmd.ExecuteNonQuery()

                'Abrir cajas
                cmd.CommandText = "UPDATE CAJAS SET CajaCerrada=0 " & _
                                  "WHERE CodigoTienda=" & General.CodigoTienda
                cmd.ExecuteNonQuery()

                transaccion.Commit()

            Else

                MsgBox("El fichero de ventas ha sido reenviado correctamente.", MsgBoxStyle.Information)

            End If

            If General.Comunicaciones_Tipo > 0 And General.TipoTienda <> 1 Then Comunicacion.Envio()

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            transaccion.Rollback()
            MsgBox("Error al cerrar la tienda." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Finally
            Me.Cursor = Cursors.Default
            conexion.Close()
        End Try

    End Sub
#End Region

#Region "SeleccionaCaja"
    Private Function SeleccionaCaja()

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            cmd.Connection.Open()

            cmd.CommandText = "SELECT COUNT(CodigoCaja) FROM CAJAS WHERE CodigoTienda=" & CodigoTienda

            If CInt(cmd.ExecuteScalar) > 1 Then
                DameCaja.Tag = Me.Name
                If DameCaja.ShowDialog = Windows.Forms.DialogResult.OK Then
                    General.DatosCajaActual(General.CodigoCaja)
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If

        Catch ex As Exception
            MsgBox("Error al seleccionar caja", MsgBoxStyle.Exclamation, "Selecciona caja")
            Return False
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Function
#End Region

#Region "SeleccionaEmpleado"
    Private Function SeleccionaEmpleado()

        Dim cmd As New SqlClient.SqlCommand
        Dim cancela As Boolean

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT Count(Codigo) FROM OPERARIOS"

            If cmd.ExecuteScalar = 1 Then
                cmd.CommandText = "SELECT NombreTicket FROM OPERARIOS"
                Me.Empleado = cmd.ExecuteScalar
            Else
                Me.Enabled = False
                If DameEmpleado.ShowDialog = Windows.Forms.DialogResult.OK Then
                    cmd.CommandText = "SELECT NombreTicket FROM OPERARIOS WHERE Codigo=" & CodigoEmpleado
                    Me.Empleado = cmd.ExecuteScalar
                Else
                    cancela = True
                End If
                Me.Enabled = True
            End If

            Return Not cancela

        Catch ex As Exception
            MsgBox("Error al seleccionar empleado", MsgBoxStyle.Exclamation, "Selecciona empleado")
            Return False
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Function
#End Region

#Region "ImprimirTicket"
    Private Sub ImprimirTicket()

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Dim ticket As String
            Dim linea As String
            Dim valor As Decimal

            ticket = ActivaExpandido()

            'Datos tienda
            cmd.CommandText = "SELECT * FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
            dr = cmd.ExecuteReader
            If dr.Read Then
                ticket &= dr("TextoCabecera1")
                ticket &= DesactivaExpandido()
            End If
            dr.Close()

            ticket &= vbCrLf & vbCrLf & "FECHA: " & Format(Me.txtFechaCierre.EditValue, "dd-MM-yyyy")
            ticket &= " CIERRE TIENDA: " & Format(General.NumeroAlmacen, "00")

            Dim tCajas As dsTiendas.SITUACIONDataTable
            Dim rCajas As dsTiendas.SITUACIONRow
            Dim i As Integer

            Dim TotalTickets As Integer, TotalLineas As Integer
            Dim TotalEfectivo As Decimal, TotalTalon As Decimal, TotalTarjeta As Decimal
            Dim TotalValesProveedor As Decimal, TotalEnvases As Decimal, TotalPendienteCobro As Decimal
            Dim TotalValesEmitidos As Decimal, TotalValesCobrados As Decimal, TotalCobrosCliente As Decimal, TotalPagosProveedor As Decimal
            Dim TotalEntradaCambios As Decimal, TotalRetiradaFondos As Decimal, TotalVenta As Decimal
            Dim NumeroAlbaranes As Integer, LineasAlbaranes As Integer, TotalAlbaranes As Decimal, NumeroFacturas As Integer, LineasFacturas As Integer, TotalFacturas As Decimal, PendienteVentaCredito As Decimal
            Dim TotalRepartoDomicilio As Decimal, TotalDescuentos As Decimal, TotalRecargos As Decimal, TotalDtoPP As Decimal

            'Calcular totales de cajas
            tCajas = General.SituacionTienda.SITUACION

            For i = 0 To tCajas.Rows.Count - 1
                rCajas = tCajas.Rows(i)

                If Not (rCajas.Tickets = 0 And rCajas.Lineas = 0 And rCajas.Efectivo = 0 And rCajas.Talon = 0 And rCajas.Tarjeta = 0 And rCajas.ValesProveedor = 0 And rCajas.Envases = 0 And rCajas.PendienteCobro = 0 And rCajas.ValesEmitidos = 0 And rCajas.ValesCobrados = 0 And rCajas.CobrosCliente = 0 And rCajas.PagosProveedor = 0 And rCajas.EntradaCambios = 0 And rCajas.RetiradaFondos = 0 And rCajas.Venta = 0) Then

                    'ticket &= vbCrLf & vbCrLf & "   ******** RESUMEN DE CAJA " & Format(rCajas.CodigoCaja, "00") & " *******"

                    'ticket &= vbCrLf & vbCrLf & "LIQUIDACION DE CAJA"
                    'ticket &= vbCrLf & "==================="

                    'Total tickets
                    valor = rCajas.Tickets
                    TotalTickets += valor
                    linea = "NUMERO TICKETS..:"
                    While Len(linea & Int(valor).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Int(valor)

                    'Total líneas tickets
                    valor = rCajas.Lineas
                    TotalLineas += valor
                    linea = "NUMERO LINEAS...:"
                    While Len(linea & Int(valor).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Int(valor)

                    'Total efectivo
                    valor = rCajas.Efectivo
                    TotalEfectivo += valor
                    linea = "EFECTIVO........:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Total cheques
                    valor = rCajas.Talon
                    TotalTalon += valor
                    linea = "TALON...........:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Total tarjeta
                    valor = rCajas.Tarjeta
                    TotalTarjeta += valor
                    linea = "TARJETA CREDITO.:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Total vales proveedor
                    valor = rCajas.ValesProveedor
                    TotalValesProveedor += valor
                    linea = "VALES PROVEEDOR.:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Total envases
                    valor = rCajas.Envases
                    TotalEnvases += valor
                    linea = "ABONO ENVASES...:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Total pendiente cobro
                    valor = rCajas.PendienteCobro
                    TotalPendienteCobro += valor
                    linea = "PTES. DE COBRO..:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Total vales emitidos
                    valor = rCajas.ValesEmitidos
                    TotalValesEmitidos += valor
                    linea = "VALES EMITIDOS..:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Total vales cobrados
                    valor = rCajas.ValesCobrados
                    TotalValesCobrados += valor
                    linea = "VALES COBRADOS..:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Total cobros a cliente
                    valor = rCajas.CobrosCliente
                    TotalCobrosCliente += valor
                    linea = "COBROS A CLIENTE:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Total pagos proveedor
                    valor = rCajas.PagosProveedor
                    TotalPagosProveedor += valor
                    linea = "PAGOS A PROVEED.:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'ticket &= vbCrLf & "-----------------"

                    'Total número de albaranes crédito
                    valor = rCajas.NumeroAlbaranes
                    NumeroAlbaranes += valor
                    linea = "NUMERO ALBARANES:"
                    While Len(linea & Int(valor).ToString) < 32
                        linea &= " "
                    End While

                    'Total líneas de albaranes crédito
                    valor = rCajas.LineasAlbaranes
                    LineasAlbaranes += valor
                    linea = "LINEAS ALBARANES:"
                    While Len(linea & Int(valor).ToString) < 32
                        linea &= " "
                    End While

                    'Total albaranes crédito
                    valor = rCajas.AlbaranCredito
                    TotalAlbaranes += valor
                    linea = "ALBARAN CREDITO.:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Total número de facturas
                    valor = rCajas.NumeroFacturas
                    NumeroFacturas += valor
                    linea = "NUMERO FACTURAS.:"
                    While Len(linea & Int(valor).ToString) < 32
                        linea &= " "
                    End While

                    'Total líneas de facturas
                    valor = rCajas.LineasFacturas
                    LineasFacturas += valor
                    linea = "LINEAS FACTURAS.:"
                    While Len(linea & Int(valor).ToString) < 32
                        linea &= " "
                    End While

                    'Total facturas
                    valor = rCajas.ImporteFacturas
                    TotalFacturas += valor
                    linea = "FACTURA CREDITO.:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Pendiente venta crédito
                    valor = rCajas.PendienteCredito
                    PendienteVentaCredito += valor
                    linea = "PDTE. CREDITO...:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'ticket &= vbCrLf & "-----------------"

                    'Total entrada cambios
                    valor = rCajas.EntradaCambios
                    TotalEntradaCambios += valor
                    linea = "ENTRADA CAMBIOS.:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Total retirada fondos
                    valor = rCajas.RetiradaFondos
                    TotalRetiradaFondos += valor
                    linea = "RETIDARA FONDOS.:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Total descuentos
                    valor = rCajas.Descuentos
                    TotalDescuentos += valor
                    linea = "DESCUENTOS......:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Total reparto a domicilio
                    valor = rCajas.RepartoDomicilio
                    TotalRepartoDomicilio += valor
                    linea = "REPARTO DOMICILI:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    valor = rCajas.Efectivo
                    linea = "IMPORTE EN CAJA.:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & "--------------------------------"
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    'Total venta
                    valor = rCajas.Venta
                    TotalVenta += valor
                    linea = "VENTA CAJA......:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    'ticket &= vbCrLf & "--------------------------------"
                    'ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                    'ticket &= vbCrLf & "--------------------------------"

                    'Total descuento PP
                    valor = rCajas.DescuentoPP
                    TotalDtoPP += valor
                    linea = "DESCUENTO PP:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While

                    'Total recargos
                    valor = rCajas.RecargoEquivalencia
                    TotalRecargos += valor
                    linea = "RECARGOS....:"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While

                End If

            Next

            'Resumen tienda
            ticket &= vbCrLf & vbCrLf & "   ******** RESUMEN TIENDA " & Format(General.NumeroAlmacen, "00") & " *******" & vbCrLf

            'Total tickets
            valor = TotalTickets
            linea = "NUMERO TICKETS..:"
            While Len(linea & Int(valor).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Int(valor)

            'Total líneas tickets
            valor = TotalLineas
            linea = "NUMERO LINEAS...:"
            While Len(linea & Int(valor).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Int(valor)

            ticket &= vbCrLf & "-----------------"

            'Total número de albaranes
            valor = NumeroAlbaranes
            linea = "NUMERO ALBARANES:"
            While Len(linea & Int(valor).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Int(valor)

            'Total líneas de albaranes crédito
            valor = LineasAlbaranes
            linea = "LINEAS ALBARANES:"
            While Len(linea & Int(valor).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Int(valor)

            'Total albaranes crédito
            valor = TotalAlbaranes
            linea = "ALBARAN CREDITO.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total número de facturas
            valor = NumeroFacturas
            linea = "NUMERO FACTURAS.:"
            While Len(linea & Int(valor).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Int(valor)

            'Total líneas de facturas crédito
            valor = LineasFacturas
            linea = "LINEAS FACTURAS:"
            While Len(linea & Int(valor).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Int(valor)

            'Total facturas crédito
            valor = TotalFacturas
            linea = "FACTURA CREDITO.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Pendiente venta crédito
            valor = PendienteVentaCredito
            linea = "PDTE. CREDITO...:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            ticket &= vbCrLf & "-----------------"

            'Total efectivo
            valor = TotalEfectivo
            linea = "EFECTIVO........:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total cheques
            valor = TotalTalon
            linea = "TALON...........:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total tarjeta
            valor = TotalTarjeta
            linea = "TARJETA CREDITO.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total vales proveedor
            valor = TotalValesProveedor
            linea = "VALES PROVEEDOR.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total envases
            valor = TotalEnvases
            linea = "ABONO ENVASES...:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total pendiente cobro
            valor = TotalPendienteCobro
            linea = "PTES. DE COBRO..:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total vales emitidos
            valor = TotalValesEmitidos
            linea = "VALES EMITIDOS..:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total vales cobrados
            valor = TotalValesCobrados
            linea = "VALES COBRADOS..:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total cobros a cliente
            valor = TotalCobrosCliente
            linea = "COBROS A CLIENTE:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total pagos proveedor
            valor = TotalPagosProveedor
            linea = "PAGOS A PROVEED.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total entrada cambios
            valor = TotalEntradaCambios
            linea = "ENTRADA CAMBIOS.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total retirada fondos
            valor = TotalRetiradaFondos
            linea = "RETIDARA FONDOS.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total descuentos
            valor = TotalDescuentos
            linea = "DESCUENTOS......:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total reparto a domicilio
            valor = TotalRepartoDomicilio
            linea = "REPARTO DOMICILI:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total importe caja
            valor = TotalEfectivo
            linea = "IMPORTE EN CAJA.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & "--------------------------------"
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total efectivo
            valor = TotalEfectivo + TotalRetiradaFondos
            linea = "TOTAL EFECTIVO..:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & "--------------------------------"
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            ticket &= vbCrLf & "--------------------------------"

            'Total venta
            valor = TotalVenta
            linea = "VENTA CAJA......:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            If TotalDtoPP <> 0 Then
                'Total descuentos PP
                valor = TotalDtoPP
                linea = "DESCUENTO PP:"
                While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                    linea &= " "
                End While
                ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
            End If

            If TotalRecargos <> 0 Then
                'Total recargos
                valor = TotalRecargos
                linea = "RECARGOS....:"
                While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                    linea &= " "
                End While
                ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
            End If

            ticket &= vbCrLf & "--------------------------------"

            If General.TipoTienda = 1 And ActivaCorteTicket Then ticket += CorteTicket()

            'Ventas por familia
            If VentasPorFamiliaCierre Then

                Dim cmdPromociones As New SqlClient.SqlCommand
                cmdPromociones.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                cmdPromociones.Connection.Open()

                Try
                    Dim TotalSinPromocion As Decimal, TotalPromociones As Decimal

                    ticket &= vbCrLf & vbCrLf & "   ******* VENTAS POR FAMILIA *******"
                    ticket &= vbCrLf & vbCrLf & "FAMILIA             VTA.NORMAL PROMOCION"
                    ticket &= vbCrLf & "========================================"

                    cmd.CommandText = "SELECT FAMILIASARTICULOS.Codigo, FAMILIASARTICULOS.Descripcion, ISNULL(SUM(TICKETS_LINEAS.Importe),0) AS Total " & _
                                      "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id " & _
                                      "INNER JOIN ARTICULOS ON TICKETS_LINEAS.CodigoArticulo=ARTICULOS.Codigo " & _
                                      "INNER JOIN FAMILIASARTICULOS ON ARTICULOS.CodigoFamilia=FAMILIASARTICULOS.Id " & _
                                      "WHERE TICKETS.CodigoTienda=" & CodigoTienda
                    If General.TipoTienda <> 1 Then cmd.CommandText &= " AND TICKETS.TipoFactura=0"
                    cmd.CommandText &= " GROUP BY FAMILIASARTICULOS.Codigo, FAMILIASARTICULOS.Descripcion"
                    dr = cmd.ExecuteReader
                    While dr.Read

                        linea = Mid(dr("Descripcion"), 1, 16)
                        While Len(linea) < 16
                            linea &= "."
                        End While
                        linea &= ":"

                        'Total líneas sin promoción
                        cmdPromociones.CommandText = "SELECT ISNULL(SUM(TICKETS_LINEAS.Importe),0) AS Total " & _
                                                      "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id " & _
                                                      "INNER JOIN ARTICULOS ON TICKETS_LINEAS.CodigoArticulo=ARTICULOS.Codigo " & _
                                                      "INNER JOIN FAMILIASARTICULOS ON ARTICULOS.CodigoFamilia=FAMILIASARTICULOS.Id " & _
                                                      "WHERE TICKETS.CodigoTienda=" & CodigoTienda & " AND TICKETS_LINEAS.Promocion=0 AND FAMILIASARTICULOS.Codigo='" & dr("Codigo") & "'"
                        If General.TipoTienda <> 1 Then cmdPromociones.CommandText &= " AND TICKETS.TipoFactura=0"
                        valor = cmdPromociones.ExecuteScalar
                        TotalSinPromocion += valor
                        While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 30
                            linea &= " "
                        End While
                        linea &= Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                        'Total líneas con promoción
                        cmdPromociones.CommandText = "SELECT ISNULL(SUM(TICKETS_LINEAS.Importe),0) AS Total " & _
                                                      "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id " & _
                                                      "INNER JOIN ARTICULOS ON TICKETS_LINEAS.CodigoArticulo=ARTICULOS.Codigo " & _
                                                      "INNER JOIN FAMILIASARTICULOS ON ARTICULOS.CodigoFamilia=FAMILIASARTICULOS.Id " & _
                                                      "WHERE TICKETS.CodigoTienda=" & CodigoTienda & " AND TICKETS_LINEAS.Promocion=1 AND FAMILIASARTICULOS.Codigo='" & dr("Codigo") & "'"
                        If General.TipoTienda <> 1 Then cmdPromociones.CommandText &= " AND TICKETS.TipoFactura=0"
                        valor = cmdPromociones.ExecuteScalar
                        TotalPromociones += valor
                        While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                            linea &= " "
                        End While
                        ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    End While
                    dr.Close()

                    ticket &= vbCrLf & "----------------------------------------"

                    'Totales
                    linea = "TOTAL VENTA NORMAL.....:"
                    While Len(linea & Math.Round(TotalSinPromocion, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalSinPromocion, DecimalesImporte, MidpointRounding.AwayFromZero)

                    linea = "TOTAL VENTA PROMOCIONES:"
                    While Len(linea & Math.Round(TotalPromociones, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalPromociones, DecimalesImporte, MidpointRounding.AwayFromZero)

                    ticket &= vbCrLf & "----------------------------------------"

                Catch ex As Exception
                    'Error al calcular totales por familia
                Finally
                    cmdPromociones.Connection.Close()
                End Try

                If General.TipoTienda = 2 Then

                    'Venta propia por familias
                    Try
                        cmdPromociones.Connection.Open()

                        Dim TotalSinPromocion As Decimal, TotalPromociones As Decimal

                        ticket &= vbCrLf & vbCrLf & "   ******* VTA.PROPIA FAMILIA *******"
                        ticket &= vbCrLf & vbCrLf & "FAMILIA             VTA.NORMAL PROMOCION"
                        ticket &= vbCrLf & "========================================"

                        cmd.CommandText = "SELECT FAMILIASARTICULOS.Codigo, FAMILIASARTICULOS.Descripcion, ISNULL(SUM(TICKETS_LINEAS.Importe),0) AS Total " & _
                                          "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id " & _
                                          "INNER JOIN ARTICULOS ON TICKETS_LINEAS.CodigoArticulo=ARTICULOS.Codigo " & _
                                          "INNER JOIN FAMILIASARTICULOS ON ARTICULOS.CodigoFamilia=FAMILIASARTICULOS.Id " & _
                                          "WHERE TICKETS.CodigoTienda=" & CodigoTienda & _
                                          " AND ((ARTICULOS.Codigo >= '" & General.ArticuloPropioInicio & "' AND ARTICULOS.Codigo <= '" & General.ArticuloPropioFin & "') OR (ARTICULOS.TipoArticulo = '5'))"
                        If General.TipoTienda <> 1 Then cmd.CommandText &= " AND TICKETS.TipoFactura=0"
                        cmd.CommandText &= " GROUP BY FAMILIASARTICULOS.Codigo, FAMILIASARTICULOS.Descripcion"
                        dr = cmd.ExecuteReader
                        While dr.Read

                            linea = Mid(dr("Descripcion"), 1, 16)
                            While Len(linea) < 16
                                linea &= "."
                            End While
                            linea &= ":"

                            'Total líneas sin promoción
                            cmdPromociones.CommandText = "SELECT ISNULL(SUM(TICKETS_LINEAS.Importe),0) AS Total " & _
                                                          "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id " & _
                                                          "INNER JOIN ARTICULOS ON TICKETS_LINEAS.CodigoArticulo=ARTICULOS.Codigo " & _
                                                          "INNER JOIN FAMILIASARTICULOS ON ARTICULOS.CodigoFamilia=FAMILIASARTICULOS.Id " & _
                                                          "WHERE TICKETS.CodigoTienda=" & CodigoTienda & " AND TICKETS_LINEAS.Promocion=0 AND FAMILIASARTICULOS.Codigo='" & dr("Codigo") & "' " & _
                                                          "AND ((ARTICULOS.Codigo >= '" & General.ArticuloPropioInicio & "' AND ARTICULOS.Codigo <= '" & General.ArticuloPropioFin & "') OR (ARTICULOS.TipoArticulo = '5'))"
                            If General.TipoTienda <> 1 Then cmdPromociones.CommandText &= " AND TICKETS.TipoFactura=0"
                            valor = cmdPromociones.ExecuteScalar
                            TotalSinPromocion += valor
                            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 30
                                linea &= " "
                            End While
                            linea &= Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                            'Total líneas con promoción
                            cmdPromociones.CommandText = "SELECT ISNULL(SUM(TICKETS_LINEAS.Importe),0) AS Total " & _
                                                          "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id " & _
                                                          "INNER JOIN ARTICULOS ON TICKETS_LINEAS.CodigoArticulo=ARTICULOS.Codigo " & _
                                                          "INNER JOIN FAMILIASARTICULOS ON ARTICULOS.CodigoFamilia=FAMILIASARTICULOS.Id " & _
                                                          "WHERE TICKETS.CodigoTienda=" & CodigoTienda & " AND TICKETS_LINEAS.Promocion=1 AND FAMILIASARTICULOS.Codigo='" & dr("Codigo") & "' " & _
                                                          "AND ((ARTICULOS.Codigo >= '" & General.ArticuloPropioInicio & "' AND ARTICULOS.Codigo <= '" & General.ArticuloPropioFin & "') OR (ARTICULOS.TipoArticulo = '5'))"
                            If General.TipoTienda <> 1 Then cmdPromociones.CommandText &= " AND TICKETS.TipoFactura=0"
                            valor = cmdPromociones.ExecuteScalar
                            TotalPromociones += valor
                            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                                linea &= " "
                            End While
                            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                        End While
                        dr.Close()

                        ticket &= vbCrLf & "----------------------------------------"

                        'Totales
                        linea = "TOTAL VENTA NORMAL.....:"
                        While Len(linea & Math.Round(TotalSinPromocion, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                            linea &= " "
                        End While
                        ticket &= vbCrLf & linea & Math.Round(TotalSinPromocion, DecimalesImporte, MidpointRounding.AwayFromZero)

                        linea = "TOTAL VENTA PROMOCIONES:"
                        While Len(linea & Math.Round(TotalPromociones, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                            linea &= " "
                        End While
                        ticket &= vbCrLf & linea & Math.Round(TotalPromociones, DecimalesImporte, MidpointRounding.AwayFromZero)

                        ticket &= vbCrLf & "----------------------------------------"

                    Catch ex As Exception
                        'Error al calcular totales por familia
                    Finally
                        cmdPromociones.Connection.Close()
                    End Try

                End If

            End If

            If General.TipoTienda = 1 And ActivaCorteTicket Then ticket += CorteTicket()

            'Ventas por vendedor
            If VentasPorVendedorCierre Then
                Try
                    Dim TotalVendedores As Decimal

                    ticket &= vbCrLf & vbCrLf & "   ******* VENTAS POR VENDEDOR ******"
                    ticket &= vbCrLf & vbCrLf & "VENDEDOR               TOTAL VENTA"
                    ticket &= vbCrLf & "========================================"

                    cmd.CommandText = "SELECT OPERARIOS.Nombre, ISNULL(SUM(Importe),0) AS Total " & _
                                      "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id " & _
                                      "INNER JOIN OPERARIOS ON TICKETS_LINEAS.CodigoEmleado = OPERARIOS.Codigo " & _
                                      "WHERE TICKETS.CodigoTienda=" & CodigoTienda
                    If General.TipoTienda <> 1 Then cmd.CommandText &= " AND TICKETS.TipoFactura=0"
                    cmd.CommandText &= " GROUP BY OPERARIOS.Codigo, OPERARIOS.Nombre"
                    dr = cmd.ExecuteReader
                    While dr.Read

                        valor = dr("Total")
                        TotalVendedores += valor
                        linea = Mid(dr("Nombre"), 1, 23)
                        While Len(linea) < 23
                            linea &= "."
                        End While
                        linea &= ":"
                        While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                            linea &= " "
                        End While
                        ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    End While
                    dr.Close()

                    ticket &= vbCrLf & "----------------------------------------"

                    'Totales
                    linea = "TOTAL VENTA VENDEDORES.:"
                    While Len(linea & Math.Round(TotalVendedores, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalVendedores, DecimalesImporte, MidpointRounding.AwayFromZero)

                    ticket &= vbCrLf & "----------------------------------------"

                Catch ex As Exception
                    'Error al calcular totales por vendedor
                End Try

            End If

            If General.TipoTienda = 1 And ActivaCorteTicket Then ticket += CorteTicket()

            'Totales ventas tickets
            Dim Copias As Integer = IIf(General.TipoTienda = 2, 2, 1)

TotalesVentas:
            Try
                Dim TotalBases As Decimal = 0, TotalIVA As Decimal = 0, TotalVentas As Decimal = 0

                ticket &= vbCrLf & vbCrLf & "   *** TOTAL VENTAS DIA " & Format(Me.txtFechaCierre.EditValue, "dd-MM-yyyy") & " **"
                ticket &= vbCrLf & vbCrLf & "BASE IMPONIBLE      %IVA     IMPORTE IVA"
                ticket &= vbCrLf & "========================================"

                cmd.CommandText = "SELECT TICKETS_LINEAS.PorcentajeIVA, ISNULL(SUM(TICKETS_LINEAS.Importe),0) AS Total " & _
                                  "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id " & _
                                  "WHERE TICKETS.CodigoTienda=" & CodigoTienda & " AND TICKETS.TipoFactura=0 GROUP BY PorcentajeIVA"

                'Calcular diferencia entre bases
                Dim Diferencia As Decimal = 0
                dr = cmd.ExecuteReader
                While dr.Read
                    TotalBases += Math.Round(dr("Total") / (1 + (dr("PorcentajeIVA") / 100)), DecimalesImporte, MidpointRounding.AwayFromZero)
                    TotalIVA += Math.Round(dr("Total") - (dr("Total") / (1 + (dr("PorcentajeIVA") / 100))), DecimalesImporte, MidpointRounding.AwayFromZero)
                    TotalVentas += dr("Total")
                End While
                dr.Close()
                Diferencia = TotalVentas - (TotalBases + TotalIVA)

                dr = cmd.ExecuteReader
                While dr.Read

                    valor = dr("Total") / (1 + (dr("PorcentajeIVA") / 100)) + Diferencia
                    linea = ""
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 14
                        linea &= " "
                    End While
                    linea &= Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    valor = dr("PorcentajeIVA")
                    While Len(linea & Math.Round(valor, 2).ToString) < 24
                        linea &= " "
                    End While
                    linea &= Math.Round(valor, 2)

                    valor = dr("Total") - (dr("Total") / (1 + (dr("PorcentajeIVA") / 100)))
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                    Diferencia = 0

                End While
                dr.Close()

                ticket &= vbCrLf & "----------------------------------------"

                'Totales
                linea = "TOTAL BASES............:"
                While Len(linea & Math.Round(TotalBases, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                    linea &= " "
                End While
                ticket &= vbCrLf & linea & Math.Round(TotalBases, DecimalesImporte, MidpointRounding.AwayFromZero)

                linea = "TOTAL IVA..............:"
                While Len(linea & Math.Round(TotalIVA, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                    linea &= " "
                End While
                ticket &= vbCrLf & linea & Math.Round(TotalIVA, DecimalesImporte, MidpointRounding.AwayFromZero)

                linea = "TOTAL VENTA............:"
                While Len(linea & Math.Round(TotalVentas, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                    linea &= " "
                End While
                ticket &= vbCrLf & linea & Math.Round(TotalVentas, DecimalesImporte, MidpointRounding.AwayFromZero)

                ticket &= vbCrLf & "----------------------------------------"

            Catch ex As Exception
                'Error al calcular totales tickets
            End Try

            'Si es depósito imprimir venta propia + liquidación
            If General.TipoTienda = 2 Then

                Try
                    Dim TotalBases As Decimal = 0, TotalIVA As Decimal = 0, TotalVentas As Decimal = 0

                    'Datos tienda
                    cmd.CommandText = "SELECT * FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        ticket &= dr("TextoCabecera1")
                        ticket &= DesactivaExpandido()
                    End If
                    dr.Close()

                    ticket &= vbCrLf & vbCrLf & "FECHA: " & Format(Me.txtFechaCierre.EditValue, "dd-MM-yyyy")
                    ticket &= " CIERRE TIENDA: " & Format(General.NumeroAlmacen, "00")

                    ticket &= vbCrLf & vbCrLf & "   ** TOTAL VENTA PROPIA " & Format(Me.txtFechaCierre.EditValue, "dd-MM-yyyy") & " **"
                    ticket &= vbCrLf & vbCrLf & "BASE IMPONIBLE      %IVA     IMPORTE IVA"
                    ticket &= vbCrLf & "========================================"

                    cmd.CommandText = "SELECT TICKETS_LINEAS.PorcentajeIVA, ISNULL(SUM(TICKETS_LINEAS.Importe),0) AS Total " & _
                                      "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id " & _
                                      "INNER JOIN ARTICULOS ON TICKETS_LINEAS.CodigoArticulo=ARTICULOS.Codigo " & _
                                      "WHERE TICKETS.CodigoTienda=" & CodigoTienda & " AND TICKETS.TipoFactura=0 " & _
                                      "AND ((ARTICULOS.Codigo >= '" & General.ArticuloPropioInicio & "' AND ARTICULOS.Codigo <= '" & General.ArticuloPropioFin & "') OR (ARTICULOS.TipoArticulo = '5')) " & _
                                      "GROUP BY TICKETS_LINEAS.PorcentajeIVA"

                    'Calcular diferencia entre bases
                    Dim Diferencia As Decimal = 0
                    dr = cmd.ExecuteReader
                    While dr.Read
                        TotalBases += Math.Round(dr("Total") / (1 + (dr("PorcentajeIVA") / 100)), DecimalesImporte, MidpointRounding.AwayFromZero)
                        TotalIVA += Math.Round(dr("Total") - (dr("Total") / (1 + (dr("PorcentajeIVA") / 100))), DecimalesImporte, MidpointRounding.AwayFromZero)
                        TotalVentas += dr("Total")
                    End While
                    dr.Close()
                    Diferencia = TotalVentas - (TotalBases + TotalIVA)

                    dr = cmd.ExecuteReader
                    While dr.Read

                        valor = dr("Total") / (1 + (dr("PorcentajeIVA") / 100)) + Diferencia
                        linea = ""
                        While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 14
                            linea &= " "
                        End While
                        linea &= Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                        valor = dr("PorcentajeIVA")
                        While Len(linea & Math.Round(valor, 2).ToString) < 24
                            linea &= " "
                        End While
                        linea &= Math.Round(valor, 2)

                        valor = dr("Total") - (dr("Total") / (1 + (dr("PorcentajeIVA") / 100)))
                        While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                            linea &= " "
                        End While
                        ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                        Diferencia = 0

                    End While
                    dr.Close()

                    ticket &= vbCrLf & "----------------------------------------"

                    'Totales
                    linea = "TOTAL BASES............:"
                    While Len(linea & Math.Round(TotalBases, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalBases, DecimalesImporte, MidpointRounding.AwayFromZero)

                    linea = "TOTAL IVA..............:"
                    While Len(linea & Math.Round(TotalIVA, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalIVA, DecimalesImporte, MidpointRounding.AwayFromZero)

                    linea = "TOTAL VENTA............:"
                    While Len(linea & Math.Round(TotalVentas, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalVentas, DecimalesImporte, MidpointRounding.AwayFromZero)

                    ticket &= vbCrLf & "----------------------------------------"

                Catch ex As Exception
                    'Error al calcular totales tickets
                End Try

                Try
                    Dim TotalBases As Decimal = 0, TotalIVA As Decimal = 0, TotalVentas As Decimal = 0

                    ticket &= vbCrLf & vbCrLf & "   ** LIQUIDACION VENTAS " & Format(Me.txtFechaCierre.EditValue, "dd-MM-yyyy") & " **"
                    ticket &= vbCrLf & vbCrLf & "BASE IMPONIBLE      %IVA     IMPORTE IVA"
                    ticket &= vbCrLf & "========================================"

                    cmd.CommandText = "SELECT TICKETS_LINEAS.PorcentajeIVA, ISNULL(SUM(TICKETS_LINEAS.Importe),0) AS Total " & _
                                      "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id " & _
                                      "INNER JOIN ARTICULOS ON TICKETS_LINEAS.CodigoArticulo=ARTICULOS.Codigo " & _
                                      "WHERE TICKETS.CodigoTienda=" & CodigoTienda & " AND TICKETS.TipoFactura=0 " & _
                                      "AND ((ARTICULOS.Codigo < '" & General.ArticuloPropioInicio & "' OR ARTICULOS.Codigo > '" & General.ArticuloPropioFin & "') AND (ARTICULOS.TipoArticulo <> '5')) " & _
                                      "GROUP BY TICKETS_LINEAS.PorcentajeIVA"

                    'Calcular diferencia entre bases
                    Dim Diferencia As Decimal = 0
                    dr = cmd.ExecuteReader
                    While dr.Read
                        TotalBases += Math.Round(dr("Total") / (1 + (dr("PorcentajeIVA") / 100)), DecimalesImporte, MidpointRounding.AwayFromZero)
                        TotalIVA += Math.Round(dr("Total") - (dr("Total") / (1 + (dr("PorcentajeIVA") / 100))), DecimalesImporte, MidpointRounding.AwayFromZero)
                        TotalVentas += dr("Total")
                    End While
                    dr.Close()
                    Diferencia = TotalVentas - (TotalBases + TotalIVA)

                    dr = cmd.ExecuteReader
                    While dr.Read

                        valor = dr("Total") / (1 + (dr("PorcentajeIVA") / 100)) + Diferencia
                        linea = ""
                        While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 14
                            linea &= " "
                        End While
                        linea &= Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                        valor = dr("PorcentajeIVA")
                        While Len(linea & Math.Round(valor, 2).ToString) < 24
                            linea &= " "
                        End While
                        linea &= Math.Round(valor, 2)

                        valor = dr("Total") - (dr("Total") / (1 + (dr("PorcentajeIVA") / 100)))
                        While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                            linea &= " "
                        End While
                        ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                        Diferencia = 0

                    End While
                    dr.Close()

                    ticket &= vbCrLf & "----------------------------------------"

                    'Totales
                    linea = "TOTAL BASES............:"
                    While Len(linea & Math.Round(TotalBases, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalBases, DecimalesImporte, MidpointRounding.AwayFromZero)

                    linea = "TOTAL IVA..............:"
                    While Len(linea & Math.Round(TotalIVA, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalIVA, DecimalesImporte, MidpointRounding.AwayFromZero)

                    linea = "TOTAL VENTA............:"
                    While Len(linea & Math.Round(TotalVentas, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalVentas, DecimalesImporte, MidpointRounding.AwayFromZero)

                    ticket &= vbCrLf & "----------------------------------------"

                Catch ex As Exception
                    'Error al calcular totales tickets
                End Try

            End If

            While Copias > 1

                Copias -= 1

                'Nombre del empleado
                ticket &= vbCrLf & vbCrLf & "EFECTUADO POR: " & Me.Empleado

                ticket &= vbCrLf & vbCrLf & "CONFORME ENCARGADO:" & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf

                If ActivaCorteTicket Then ticket += CorteTicket()

                GoTo TotalesVentas

            End While

            'Si es franquicia imprimir totales albaranes
            If General.TipoTienda = 1 Then

                'Totales ventas albaranes
                Try
                    Dim TotalBases As Decimal, TotalIVA As Decimal, TotalVentas As Decimal

                    ticket &= vbCrLf & vbCrLf & "   **** ALBARANES DIA " & Format(Me.txtFechaCierre.EditValue, "dd-MM-yyyy") & " ***"
                    ticket &= vbCrLf & vbCrLf & "BASE IMPONIBLE      %IVA     IMPORTE IVA"
                    ticket &= vbCrLf & "========================================"

                    cmd.CommandText = "SELECT TICKETS_LINEAS.PorcentajeIVA, ISNULL(SUM(TICKETS_LINEAS.Importe),0) AS Total " & _
                                      "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id " & _
                                      "WHERE TICKETS.CodigoTienda=" & CodigoTienda & " AND TICKETS.TipoFactura<>0 GROUP BY PorcentajeIVA"

                    'Calcular diferencia entre bases
                    Dim Diferencia As Decimal
                    dr = cmd.ExecuteReader
                    While dr.Read
                        TotalBases += Math.Round(dr("Total") / (1 + (dr("PorcentajeIVA") / 100)), DecimalesImporte, MidpointRounding.AwayFromZero)
                        TotalIVA += Math.Round(dr("Total") - (dr("Total") / (1 + (dr("PorcentajeIVA") / 100))), DecimalesImporte, MidpointRounding.AwayFromZero)
                        TotalVentas += dr("Total")
                    End While
                    dr.Close()
                    Diferencia = TotalVentas - (TotalBases + TotalIVA)

                    dr = cmd.ExecuteReader
                    While dr.Read

                        valor = dr("Total") / (1 + (dr("PorcentajeIVA") / 100)) + Diferencia
                        linea = ""
                        While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 14
                            linea &= " "
                        End While
                        linea &= Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                        valor = dr("PorcentajeIVA")
                        While Len(linea & Math.Round(valor, 2).ToString) < 24
                            linea &= " "
                        End While
                        linea &= Math.Round(valor, 2)

                        valor = dr("Total") - (dr("Total") / (1 + (dr("PorcentajeIVA") / 100)))
                        While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                            linea &= " "
                        End While
                        ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                        Diferencia = 0

                    End While
                    dr.Close()

                    ticket &= vbCrLf & "----------------------------------------"

                    'Totales
                    linea = "TOTAL BASES............:"
                    While Len(linea & Math.Round(TotalBases, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalBases, DecimalesImporte, MidpointRounding.AwayFromZero)

                    linea = "TOTAL IVA..............:"
                    While Len(linea & Math.Round(TotalIVA, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalIVA, DecimalesImporte, MidpointRounding.AwayFromZero)

                    linea = "TOTAL VENTA............:"
                    While Len(linea & Math.Round(TotalVentas, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalVentas, DecimalesImporte, MidpointRounding.AwayFromZero)

                    ticket &= vbCrLf & "----------------------------------------"

                Catch ex As Exception
                    'Error al calcular totales albaranes
                End Try

                'Totales ventas
                Try
                    Dim TotalBases As Decimal, TotalIVA As Decimal, TotalVentas As Decimal

                    ticket &= vbCrLf & vbCrLf & "   ** TOTAL GENERAL DIA " & Format(Me.txtFechaCierre.EditValue, "dd-MM-yyyy") & " **"
                    ticket &= vbCrLf & vbCrLf & "BASE IMPONIBLE      %IVA     IMPORTE IVA"
                    ticket &= vbCrLf & "========================================"

                    cmd.CommandText = "SELECT TICKETS_LINEAS.PorcentajeIVA, ISNULL(SUM(TICKETS_LINEAS.Importe),0) AS Total " & _
                                      "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id " & _
                                      "WHERE TICKETS.CodigoTienda=" & CodigoTienda & " GROUP BY PorcentajeIVA"

                    'Calcular diferencia entre bases
                    Dim Diferencia As Decimal
                    dr = cmd.ExecuteReader
                    While dr.Read
                        TotalBases += Math.Round(dr("Total") / (1 + (dr("PorcentajeIVA") / 100)), DecimalesImporte, MidpointRounding.AwayFromZero)
                        TotalIVA += Math.Round(dr("Total") - (dr("Total") / (1 + (dr("PorcentajeIVA") / 100))), DecimalesImporte, MidpointRounding.AwayFromZero)
                        TotalVentas += dr("Total")
                    End While
                    dr.Close()
                    Diferencia = TotalVentas - (TotalBases + TotalIVA)

                    dr = cmd.ExecuteReader
                    While dr.Read

                        valor = dr("Total") / (1 + (dr("PorcentajeIVA") / 100)) + Diferencia
                        linea = ""
                        While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 14
                            linea &= " "
                        End While
                        linea &= Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                        valor = dr("PorcentajeIVA")
                        While Len(linea & Math.Round(valor, 2).ToString) < 24
                            linea &= " "
                        End While
                        linea &= Math.Round(valor, 2)

                        valor = dr("Total") - (dr("Total") / (1 + (dr("PorcentajeIVA") / 100)))
                        While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                            linea &= " "
                        End While
                        ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

                        Diferencia = 0

                    End While
                    dr.Close()

                    ticket &= vbCrLf & "----------------------------------------"

                    'Totales
                    linea = "TOTAL BASES............:"
                    While Len(linea & Math.Round(TotalBases, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalBases, DecimalesImporte, MidpointRounding.AwayFromZero)

                    linea = "TOTAL IVA..............:"
                    While Len(linea & Math.Round(TotalIVA, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalIVA, DecimalesImporte, MidpointRounding.AwayFromZero)

                    linea = "TOTAL VENTA............:"
                    While Len(linea & Math.Round(TotalVentas, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(TotalVentas, DecimalesImporte, MidpointRounding.AwayFromZero)

                    ticket &= vbCrLf & "----------------------------------------"

                Catch ex As Exception
                    'Error al calcular totales
                End Try

            End If

            'Nombre del empleado
            ticket &= vbCrLf & vbCrLf & "EFECTUADO POR: " & Me.Empleado

            ticket &= vbCrLf & vbCrLf & "CONFORME ENCARGADO:" & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf

            If ActivaCorteTicket Then ticket += CorteTicket()

            Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            cmd.Connection.Close()
        End Try

    End Sub
#End Region

End Class