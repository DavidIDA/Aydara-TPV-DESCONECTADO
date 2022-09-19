Public Class CierreCaja

    Dim Empleado As String

#Region "CierreCaja_Load"
    Private Sub CierreCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Pedir empleado y caja
            If Not Me.SeleccionaCaja() Then Me.Close() : Exit Try

            'Pedir empleado
            If Not Me.SeleccionaEmpleado() Then Me.Close() : Exit Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "CierreCaja_Shown"
    Private Sub CierreCaja_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown


        Try
            Me.rgCierreDia.EditValue = True
            Me.checkArqueo.Checked = False
            Me.checkDefinitivo.Checked = False
            Me.bttAceptar.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "checkArqueo_CheckedChanged"
    Private Sub checkArqueo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkArqueo.CheckedChanged
        Me.checkArqueo.Text = IIf(Me.checkArqueo.Checked, "X", String.Empty)
    End Sub
#End Region

#Region "checkDefinitivo_CheckedChanged"
    Private Sub checkDefinitivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkDefinitivo.CheckedChanged
        Me.checkDefinitivo.Text = IIf(Me.checkDefinitivo.Checked, "X", String.Empty)
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "bttAceptar_Click"
    Private Sub bttAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAceptar.Click

        If Not IsNumeric(Me.txtCodigoCaja.EditValue) Then
            MsgBox("Seleccione la caja que desea cerrar", MsgBoxStyle.Information)
            Me.txtCodigoCaja.Focus()
            Exit Sub
        Else
            General.DatosCajaActual(Me.txtCodigoCaja.EditValue)
        End If

        'If Me.ExistenTicketsEnEspera Then
        '    If Me.checkDefinitivo.Checked Then
        '        If Me.rgCierreDia.EditValue = True Then
        '            MsgBox("No se puede cerrar la caja." & vbCrLf & "Existen tickets en espera.", MsgBoxStyle.Exclamation)
        '            Exit Sub
        '        Else
        '            If MsgBox("Existen tickets en espera." & vbCrLf & "�Desea continuar el cierre de turno?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        '                MsgBox("Cierre de turno cancelado por el usuario.", MsgBoxStyle.Exclamation)
        '                Exit Sub
        '            End If
        '        End If
        '    Else
        '        MsgBox("Existen tickets en espera.", MsgBoxStyle.Information)
        '    End If
        'End If

            If Me.checkArqueo.Checked Then
                ArqueoCaja.CodigoCaja = Me.txtCodigoCaja.EditValue
                If Not ArqueoCaja.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    MsgBox("Cierre de caja cancelado por el usuario.", MsgBoxStyle.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
                    Exit Sub
                End If
            End If

            If Me.rgCierreDia.EditValue = True Then Me.CierreDia()

            'Iprimir ticket
            If ImprimeTicket = 0 Then
                ImprimirTicket()
            ElseIf ImprimeTicket = 2 Then
                If MsgBox("�Desea imprimir el cierre?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Imprimir cierre") = MsgBoxResult.Yes Then
                    ImprimirTicket()
                End If
            End If

            If Me.rgCierreDia.EditValue = False Then Me.CierreTurno()

            Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub
#End Region

#Region "SeleccionaCaja"
    Private Function SeleccionaCaja()

        Dim cancela As Boolean
        Dim CajasAbiertas As Integer

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            cmd.Connection.Open()

            cmd.CommandText = "SELECT COUNT(CodigoCaja) FROM CAJAS WHERE CodigoTienda=" & CodigoTienda & " AND CajaCerrada = 0"
            CajasAbiertas = cmd.ExecuteScalar

            If CajasAbiertas = 0 Then

                MsgBox("No existe ninguna caja abierta", MsgBoxStyle.Information)
                cancela = True

            Else

                'Comprobar si existe m�s de una caja, si no pedir caja
                cmd.CommandText = "SELECT COUNT(CodigoCaja) FROM CAJAS WHERE CodigoTienda=" & CodigoTienda
                If CInt(cmd.ExecuteScalar) = 1 Then
                    cmd.CommandText = "SELECT CodigoCaja FROM CAJAS WHERE CodigoTienda=" & CodigoTienda
                    Me.txtCodigoCaja.EditValue = Format(CInt(cmd.ExecuteScalar), "00")
                Else
                    Me.Enabled = False
                    If DameCaja.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Me.txtCodigoCaja.EditValue = Format(CodigoCaja, "00")
                        Me.bttAceptar.Focus()
                    Else
                        cancela = True
                    End If
                    Me.Enabled = True
                End If

            End If

            Return Not cancela

        Catch ex As Exception
            MsgBox("Error al seleccionar caja", MsgBoxStyle.Exclamation, "Selecciona caja")
            Return False
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Function
#End Region

#Region "txtCodigoCaja_EditValueChanged"
    Private Sub txtCodigoCaja_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoCaja.EditValueChanged

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()
        cmd.CommandText = "SELECT CodigoCaja FROM CAJAS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja='" & (Me.txtCodigoCaja.EditValue) & "' AND CajaCerrada = 0"

        If Not CType(cmd.ExecuteReader, SqlClient.SqlDataReader).HasRows Then
            MsgBox("La caja no existe o est� cerrada", MsgBoxStyle.Information)
            Me.txtCodigoCaja.EditValue = System.String.Empty
            Me.txtCodigoCaja.Focus()
        End If

    End Sub
#End Region

#Region "SeleccionaEmpleado"
    Private Function SeleccionaEmpleado()



        Dim cancela As Boolean

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
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

#Region "CierreDia"
    Private Sub CierreDia()

        If Me.checkDefinitivo.Checked Then

            Dim dtCajas As New dsCajas.CAJASDataTable
            Dim tCajas As New dsCajasTableAdapters.CAJASTableAdapter
            Dim rCajas As dsCajas.CAJASRow

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            Try
                cmd.CommandText = "SELECT * FROM CAJAS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja = " & Me.txtCodigoCaja.EditValue

                dtCajas.Load(cmd.ExecuteReader)

                If dtCajas.Rows.Count > 0 Then
                    rCajas = dtCajas.Rows(0)
                    rCajas.CajaCerrada = True
                    tCajas.Update(dtCajas)
                    'MsgBox("La caja ha sido cerrada correctamente", MsgBoxStyle.Information)
                End If

            Catch ex As Exception
                MsgBox("Error al cerrar la caja", MsgBoxStyle.Exclamation)
            Finally
                cmd.Connection.Close()
            End Try

        End If

    End Sub
#End Region

#Region "CierreTurno"
    Private Sub CierreTurno()

        If Me.checkDefinitivo.Checked Then

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            Try
                'Marcar cierre turno en tickets
                cmd.CommandText = "UPDATE TICKETS SET CierreTurno=1 WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja = " & Me.txtCodigoCaja.EditValue & " AND EnEspera=0"
                cmd.ExecuteNonQuery()

                'Marcar cierre turno en movimientos de caja
                cmd.CommandText = "UPDATE MOVIMIENTOS_CAJA SET CierreTurno=1 WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja = " & Me.txtCodigoCaja.EditValue
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Error al cerrar turno", MsgBoxStyle.Exclamation)
            Finally
                cmd.Connection.Close()
            End Try

        End If

    End Sub
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

            Dim tCajas As dsTiendas.SITUACIONDataTable
            Dim rCajas As dsTiendas.SITUACIONRow

            'Calcular totales de caja
            tCajas = General.SituacionTienda(Me.txtCodigoCaja.EditValue, Not Me.rgCierreDia.EditValue).SITUACION

            If tCajas.Rows.Count = 0 Then Exit Sub

            rCajas = tCajas.Rows(0)

            ticket &= vbCrLf & vbCrLf & "   ********* CIERRE DE " & IIf(Me.rgCierreDia.EditValue = True, "CAJA", "TURNO") & " *********"

            ticket &= vbCrLf & vbCrLf & "FECHA: " & Format(Date.Today, "dd-MM-yyyy")
            ticket &= " HORA: " & Format(Date.Now, "HH:mm")
            ticket &= " T: " & Format(General.NumeroAlmacen, "00")
            ticket &= " C: " & Format(Int(Me.txtCodigoCaja.EditValue), "00")

            ticket &= vbCrLf & vbCrLf & "LIQUIDACION DE CAJA"
            ticket &= vbCrLf & "==================="

            'Total tickets
            valor = rCajas.Tickets
            linea = "NUMERO TICKETS..:"
            While Len(linea & Int(valor).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Int(valor)

            'Total l�neas tickets
            valor = rCajas.Lineas
            linea = "NUMERO LINEAS...:"
            While Len(linea & Int(valor).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Int(valor)

            'Total efectivo
            valor = rCajas.Efectivo
            linea = "EFECTIVO........:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total cheques
            valor = rCajas.Talon
            linea = "TALON...........:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total tarjeta
            valor = rCajas.Tarjeta
            linea = "TARJETA CREDITO.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total vales proveedor
            valor = rCajas.ValesProveedor
            linea = "VALES PROVEEDOR.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total envases
            valor = rCajas.Envases
            linea = "ABONO ENVASES...:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total pendiente cobro
            valor = rCajas.PendienteCobro
            linea = "PTES. DE COBRO..:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total vales emitidos
            valor = rCajas.ValesEmitidos
            linea = "VALES EMITIDOS..:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total vales cobrados
            valor = rCajas.ValesCobrados
            linea = "VALES COBRADOS..:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total cobros a cliente
            valor = rCajas.CobrosCliente
            linea = "COBROS A CLIENTE:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total pagos proveedor
            valor = rCajas.PagosProveedor
            linea = "PAGOS A PROVEED.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'N� de albaranes
            valor = rCajas.NumeroAlbaranes
            linea = "NUMERO ALBARANES:"
            While Len(linea & Int(valor).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Int(valor)

            'Total albaranes cr�dito
            valor = rCajas.AlbaranCredito
            linea = "ALBARAN CREDITO.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total entrada cambios
            valor = rCajas.EntradaCambios
            linea = "ENTRADA CAMBIOS.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total retirada fondos
            valor = rCajas.RetiradaFondos
            linea = "RETIDARA FONDOS.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total descuentos
            valor = rCajas.Descuentos
            linea = "DESCUENTOS......:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Reparto a domicilio
            valor = rCajas.RepartoDomicilio
            linea = "REPARTO DOMICILI:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            valor = rCajas.Efectivo
            linea = "IMPORTE EN CAJA.:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & "--------------------------------"
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            valor = rCajas.Efectivo + rCajas.RetiradaFondos
            linea = "TOTAL EFECTIVO..:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & "--------------------------------"
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)

            'Total venta
            valor = rCajas.Venta
            linea = "VENTA CAJA......:"
            While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                linea &= " "
            End While
            ticket &= vbCrLf & "--------------------------------"
            ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
            ticket &= vbCrLf & "--------------------------------"

            'Nombre del empleado
            ticket &= vbCrLf & "EFECTUADO POR: " & Me.Empleado

            ticket &= vbCrLf & vbCrLf & "CONFORME ENCARGADO:" & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf

            If Me.checkArqueo.Checked Then
                ticket &= vbCrLf & "ARQUEO:"
                ticket &= vbCrLf & "--------------------------------"

                'Billetes de 500
                valor = ArqueoCaja.txtImpBilletes500.EditValue
                If valor > 0 Then
                    linea = "      500 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                'Billetes de 200
                valor = ArqueoCaja.txtImpBilletes200.EditValue
                If valor > 0 Then
                    linea = "      200 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                'Billetes de 100
                valor = ArqueoCaja.txtImpBilletes100.EditValue
                If valor > 0 Then
                    linea = "      100 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                'Billetes de 50
                valor = ArqueoCaja.txtImpBilletes50.EditValue
                If valor > 0 Then
                    linea = "       50 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                'Billetes de 20
                valor = ArqueoCaja.txtImpBilletes20.EditValue
                If valor > 0 Then
                    linea = "       20 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                'Billetes de 10
                valor = ArqueoCaja.txtImpBilletes10.EditValue
                If valor > 0 Then
                    linea = "       10 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                'Billetes de 5
                valor = ArqueoCaja.txtImpBilletes5.EditValue
                If valor > 0 Then
                    linea = "        5 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                'Monedas de 2
                valor = ArqueoCaja.txtImpMonedas2.EditValue
                If valor > 0 Then
                    linea = "        2 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                'Monedas de 1
                valor = ArqueoCaja.txtImpMonedas1.EditValue
                If valor > 0 Then
                    linea = "        1 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                'Monedas de 0,50
                valor = ArqueoCaja.txtImpMonedas050.EditValue
                If valor > 0 Then
                    linea = "      0,50 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                'Monedas de 0,20
                valor = ArqueoCaja.txtImpMonedas020.EditValue
                If valor > 0 Then
                    linea = "      0,20 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                'Monedas de 0,10
                valor = ArqueoCaja.txtImpMonedas010.EditValue
                If valor > 0 Then
                    linea = "      0,10 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                'Monedas de 0,05
                valor = ArqueoCaja.txtImpMonedas005.EditValue
                If valor > 0 Then
                    linea = "      0,05 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                'Monedas de 0,02
                valor = ArqueoCaja.txtImpMonedas002.EditValue
                If valor > 0 Then
                    linea = "      0,02 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                'Monedas de 0,01
                valor = ArqueoCaja.txtImpMonedas001.EditValue
                If valor > 0 Then
                    linea = "      0,01 Euros"
                    While Len(linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero)
                End If

                ticket &= vbCrLf & "--------------------------------"

                linea = "TOTAL ARQUEO:"
                While Len(linea & Math.Round(ArqueoCaja.txtTotalEfectivo.EditValue, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 32
                    linea &= " "
                End While
                ticket &= vbCrLf & linea & Math.Round(ArqueoCaja.txtTotalEfectivo.EditValue, DecimalesImporte, MidpointRounding.AwayFromZero)

            End If

            If ActivaCorteTicket Then ticket += CorteTicket()

            Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "ExistenTicketsEnEspera"
    Private Function ExistenTicketsEnEspera()

        Dim Existen As Boolean = False

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            cmd.Connection.Open()

            'Comprobar que no existen tickets en espera
            cmd.CommandText = "SELECT COUNT(Id) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & Me.txtCodigoCaja.EditValue & " AND EnEspera=1"
            If cmd.ExecuteScalar > 0 Then
                Existen = True
            End If

        Catch ex As Exception
            'Error al buscar tickets en espera
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

        Return Existen

    End Function
#End Region

End Class