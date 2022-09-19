Public Class CobroTicket

    Public rTicket As dsTickets.TICKETSRow
    Public LineasTicket As DataRow() = Nothing

    Dim DatosVales() As String

    Public NumeroVale As Integer

    Public ModificarCobro As Boolean

    Dim Tarifa As Integer = NumeroTarifa

#Region "CobroTicket_FormClosing"
    Private Sub CobroTicket_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Me.Dispose()
    End Sub
#End Region

#Region "CobroTicket_KeyUp"
    Private Sub CobroTicket_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Escape
                Me.bttCancelar_Click(Nothing, Nothing)
            Case Keys.F1
                If Me.TabCobro.SelectedTabPage Is Me.TabCobroFactura Then
                    Me.bttCobroFactura_Click(Me.bttEfectivoFactura, Nothing)
                Else
                    Me.bttTipoPago_Click(Me.bttEfectivo, Nothing) : Me.bttEfectivo.Checked = True
                End If
            Case Keys.F2
                If Me.TabCobro.SelectedTabPage Is Me.TabCobroFactura Then
                    Me.bttCobroFactura_Click(Me.bttTarjetaFactura, Nothing)
                Else
                    Me.bttTipoPago_Click(Me.bttTarjeta, Nothing) : Me.bttTarjeta.Checked = True
                End If
            Case Keys.F3
                Me.bttTipoPago_Click(Me.bttVarios, Nothing) : Me.bttVarios.Checked = True
            Case Keys.F4
                If Me.TabCobro.SelectedTabPage Is Me.TabCobroFactura Then
                    Me.bttCobroFactura_Click(Me.bttPendienteFactura, Nothing)
                Else
                    Me.bttTipoPago_Click(Me.bttPendienteCobro, Nothing) : Me.bttPendienteCobro.Checked = True
                End If
            Case Keys.F5
                If Me.bttVales.Enabled Then Me.bttTipoPago_Click(Me.bttVales, Nothing) : Me.bttVales.Checked = True
            Case Keys.F6
                Me.bttRepartoDomicilio.Checked = Not Me.bttRepartoDomicilio.Checked
            Case Keys.F7
                Me.bttTarjetaCliente.Checked = Not Me.bttTarjetaCliente.Checked
            Case Keys.F9
                If Me.bttVentaCredito.Visible Then Me.bttTipoPago_Click(Me.bttVentaCredito, Nothing) : Me.bttVentaCredito.Checked = True
            Case Keys.C
                If e.Control Then
                    Dim fCanjearPuntos As New fCanjearPuntos(TPV_Tactil.txtCodigoEmpleado.EditValue)
                    fCanjearPuntos.ShowDialog()
                End If
        End Select
    End Sub
#End Region

#Region "CobroTicket_Shown"
    Private Sub CobroTicket_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        'Decimales en precios
        Me.txtEntrega.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtValePropio.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtValeProveedor.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtTalon.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtTarjeta.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtEfectivo.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtCambio.Properties.Mask.EditMask = "c" & DecimalesImporte

        'If General.TipoTienda = 0 And General.FormatoEmpresa = 2 And rTicket.ImporteTotal >= 0 Then
        '    Me.bttVales.Text = "(F5) ALBARÁN CRÉDITO"
        '    Me.bttVales.Tag = 6
        '    Me.bttVales.Enabled = True
        'Else
        '    Me.bttVales.Text = "(F5) VALES"
        '    Me.bttVales.Tag = 5
        '    Me.bttVales.Enabled = (rTicket.ImporteTotal < 0)
        'End If

        Me.bttVentaCredito.Visible = VentaCredito
        Me.bttTarjetaCliente.Checked = (rTicket.CodigoCliente <> 0)

        If Not Me.bttVentaCredito.Visible Then
            Me.bttVales.Height = Me.bttEfectivo.Height
            Me.bttVales.Font = Me.bttEfectivo.Font
        Else
            Me.bttVales.Height = Me.bttVentaCredito.Height
            Me.bttVales.Font = Me.bttVentaCredito.Font
        End If

        If Me.ModificarCobro Then

            'Recoger datos último cobro
            Me.bttRepartoDomicilio.Checked = rTicket.RepartoDomicilio
            TPV_Tactil.txtTotal.EditValue = rTicket.ImporteTotal

            Me.Text = "Tipo de cobro anterior: "
            Select Case rTicket.TipoCobro
                Case "E"
                    Me.Text &= "Efectivo"
                    Me.TipoPago(1)
                    Me.bttEfectivo.Checked = True
                    Me.txtEntrega.EditValue = rTicket.ImporteTotal
                    Me.txtEntrega.Focus()
                Case "T"
                    Me.Text &= "Tarjeta"
                    Me.TipoPago(2)
                    Me.bttTarjeta.Checked = True
                    Me.txtEntrega.EditValue = rTicket.ImporteTotal
                    Me.txtEntrega.Focus()
                Case "X"
                    Me.Text &= "Varios"
                    Me.TipoPago(3)
                    Me.bttVarios.Checked = True
                    If rTicket.ImporteValesCobrados <> 0 Then Me.txtValePropio.EditValue = rTicket.ImporteValesCobrados
                    If rTicket.ImporteValesProveedor <> 0 Then Me.txtValeProveedor.EditValue = rTicket.ImporteValesProveedor
                    If rTicket.ImporteEfectivo <> 0 Then Me.txtEfectivo.EditValue = rTicket.ImporteEfectivo
                    If rTicket.ImporteTarjeta <> 0 Then Me.txtTarjeta.EditValue = rTicket.ImporteTarjeta
                    If rTicket.ImporteEnvases <> 0 Then Me.txtEnvases.EditValue = rTicket.ImporteEnvases
                    If rTicket.ImporteTalonCheque <> 0 Then Me.txtTalon.EditValue = rTicket.ImporteTalonCheque
                Case "P"
                    Me.Text &= "Pendiente de cobro"
                    Me.TipoPago(4)
                    Me.bttPendienteCobro.Checked = True
                    If rTicket.ImporteValesCobrados <> 0 Then Me.txtValePropio.EditValue = rTicket.ImporteValesCobrados
                    If rTicket.ImporteValesProveedor <> 0 Then Me.txtValeProveedor.EditValue = rTicket.ImporteValesProveedor
                    If rTicket.ImporteEfectivo <> 0 Then Me.txtEfectivo.EditValue = rTicket.ImporteEfectivo
                    If rTicket.ImporteTarjeta <> 0 Then Me.txtTarjeta.EditValue = rTicket.ImporteTarjeta
                    If rTicket.ImporteEnvases <> 0 Then Me.txtEnvases.EditValue = rTicket.ImporteEnvases
                    If rTicket.ImporteTalonCheque <> 0 Then Me.txtTalon.EditValue = rTicket.ImporteTalonCheque
                    'Datos del cliente
                    Me.txtCodigoCliente.EditValue = rTicket.CodigoCliente
                    Me.DireccionRepartoCliente(Me.txtCodigoCliente.EditValue)
                Case "V"
                    Me.Text &= "Vales"
                    Me.TipoPago(5)
                    Me.bttVales.Checked = True
                Case "A"
                    Me.Text &= "Albarán de crédito"
                    Me.TipoPago(6)
                    Me.bttVentaCredito.Checked = True
            End Select

            'Inicializar cobro anterior
            rTicket.ImporteCambios = 0
            rTicket.ImporteEfectivo = 0
            rTicket.ImporteEnvases = 0
            rTicket.ImportePendienteCobro = 0
            rTicket.ImporteTalonCheque = 0
            rTicket.ImporteTarjeta = 0
            rTicket.ImporteValesCobrados = 0
            rTicket.ImporteValesEmitidos = 0
            rTicket.ImporteValesProveedor = 0

            Me.txtImportes_Validated(Nothing, Nothing)

        Else

            'Nuevo cobro
            Me.TipoPago(1)
            Me.bttEfectivo.Checked = True
            Me.bttRepartoDomicilio.Checked = False

        End If

        'Me.txtDatosCliente.EditValue = String.Empty
        Me.DatosVales = Nothing

    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "TipoPago"
    Public Sub TipoPago(ByVal Opcion As Integer)

        Me.bttEfectivo.Checked = False
        Me.bttTarjeta.Checked = False
        Me.bttVarios.Checked = False
        Me.bttPendienteCobro.Checked = False
        Me.bttVales.Checked = False
        Me.bttVentaCredito.Checked = False
        Me.bttEfectivoFactura.Checked = False
        Me.bttTarjetaFactura.Checked = False
        Me.bttPendienteFactura.Checked = False
        Me.txtEntrega.EditValue = System.DBNull.Value
        Me.txtValePropio.EditValue = System.DBNull.Value
        Me.txtValeProveedor.EditValue = System.DBNull.Value
        Me.txtEnvases.EditValue = System.DBNull.Value
        Me.txtTalon.EditValue = System.DBNull.Value
        Me.txtTarjeta.EditValue = System.DBNull.Value
        Me.txtEfectivo.EditValue = System.DBNull.Value
        Me.txtConcepto.Text = String.Empty
        Me.txtPagadoA.Text = String.Empty
        Me.txtCambio.EditValue = 0
        Me.bttValidarCliente.Tag = Opcion

        Me.bttDtoPP.Checked = False
        Me.bttDtoPP.Visible = False

        Select Case Opcion
            Case 1 'Efectivo
                Me.Tag = "E"
                Me.TabCobro.SelectedTabPage = Me.TabEntrega
                Me.lblCambio.Text = "Cambio:"
                Me.bttAceptar.Enabled = False
                Me.txtEntrega.Focus()

            Case 2 'Tarjeta
                Me.Tag = "T"
                Me.TabCobro.SelectedTabPage = Me.TabEntrega
                Me.lblCambio.Text = "Cambio:"
                Me.txtEntrega.EditValue = rTicket.ImporteTotal
                Me.bttAceptar.Enabled = True
                Me.bttAceptar.Focus()

            Case 3 'Varios
                Me.Tag = "X"
                Me.TabCobro.SelectedTabPage = Me.TabVarios
                Me.lblCambio.Text = "Resto:"
                Me.bttAceptar.Enabled = False
                Me.txtValePropio.Focus()

            Case 4 'Pendiente cobro
                Me.Tag = "P"
                Me.lblCambio.Text = "Pdte:"
                Me.txtCambio.EditValue = rTicket.ImporteTotal

                'Primero seleccionar cliente
                Me.txtCodigoCliente.EditValue = rTicket.CodigoCliente
                Me.txtCodigoCliente.IsModified = True
                Me.txtCodigoCliente_Validated(Nothing, Nothing)
                If rTicket.CodigoCliente = 0 Or Not Me.bttTarjetaCliente.Enabled Then
                    Me.TabCobro.SelectedTabPage = Me.TabCliente
                    Me.txtCodigoCliente.Focus()
                    Me.bttAceptar.Enabled = False
                Else
                    Me.TabCobro.SelectedTabPage = Me.TabVarios
                    Me.txtValePropio.Focus()
                    Me.bttAceptar.Enabled = True
                End If

                'Me.Tag = "Y"
                'Me.TabCobro.SelectedTabPage = Me.TabVarios
                'Me.lblCambio.Text = "Pdte. Cobro:"
                'Me.txtCambio.EditValue = rTicket.ImporteTotal
                'Me.bttAceptar.Enabled = True
                'Me.txtValePropio.Focus()

            Case 5 'Vales
                Me.Tag = "V"
                Me.TabCobro.SelectedTabPage = Me.TabVales
                Me.txtPagadoA.Focus()

            Case 6 'Venta crédito
                Me.TabCobro.SelectedTabPage = Me.TabVentaCredito

            Case 7, 8 'Venta crédito
                Me.Tag = "A"

                Me.bttVentaCredito.Checked = True
                Me.TabCobro.SelectedTabPage = Me.TabCliente

                'Deshabilitar otras opciones
                Me.bttEfectivo.Enabled = False
                Me.bttTarjeta.Enabled = False
                Me.bttVarios.Enabled = False
                Me.bttPendienteCobro.Enabled = False
                'Me.bttVales.Enabled = False
                Me.bttTarjetaCliente.Enabled = False
                Me.bttRepartoDomicilio.Enabled = False

                'Buscar cliente de tareta
                Dim Cliente As New dsClientesTableAdapters.CLIENTESTableAdapter
                Dim ClienteCredito As String = Cliente.ClienteCredito(rTicket.CodigoCliente)
                If ClienteCredito <> String.Empty Then
                    Me.txtCodigoCliente.EditValue = ClienteCredito
                    Me.txtCodigoCliente.IsModified = True
                    Me.txtCodigoCliente.DoValidate()
                    Me.bttValidarCliente.Focus()
                Else
                    Me.txtCodigoCliente.EditValue = 0
                    Me.txtDatosCliente.EditValue = String.Empty
                    Me.txtCodigoCliente.Focus()
                End If
                Me.bttAceptar.Enabled = False

        End Select
    End Sub
#End Region

#Region "bttTipoPago_Click"
    Private Sub bttTipoPago_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttEfectivo.Click, bttTarjeta.Click, bttVarios.Click, bttPendienteCobro.Click, bttVentaCredito.Click
        TipoPago(sender.Tag)
    End Sub
#End Region

#Region "Teclado"
    Private Sub bttNumero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btt0.Click, btt1.Click, btt2.Click, btt3.Click, btt4.Click, btt5.Click, btt6.Click, btt7.Click, btt8.Click, btt9.Click, bttMenos.Click, bttPunto.Click
        SendKeys.Send(sender.text)
    End Sub
    Private Sub bttBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBorrar.Click
        SendKeys.Send(Chr(Keys.Back))
    End Sub
    Private Sub bttIntro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttIntro.Click
        SendKeys.Send(Chr(Keys.Enter))
    End Sub
#End Region

#Region "txtImportes_Click_GotFocus"
    Private Sub txtImportes_Click_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEntrega.Click, txtValePropio.Click, txtValeProveedor.Click, txtEnvases.Click, txtTarjeta.Click, txtTalon.Click, txtEfectivo.Click, txtEntrega.GotFocus, txtValePropio.GotFocus, txtValeProveedor.GotFocus, txtEnvases.GotFocus, txtTarjeta.GotFocus, txtTalon.GotFocus, txtEfectivo.GotFocus
        sender.SelectAll()
    End Sub
#End Region

#Region "txtEntrega_KeyPress"
    Private Sub txtEntrega_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntrega.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtImportes_Validated(sender, Nothing)
        End If
    End Sub
#End Region

#Region "txtImportes_Validated"
    Private Sub txtImportes_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEntrega.Validated, txtValePropio.Validated, txtValeProveedor.Validated, txtEnvases.Validated, txtTarjeta.Validated, txtTalon.Validated, txtEfectivo.Validated
        Try

            If Not sender Is Nothing Then
                If IsNumeric(sender.editvalue) Then
                    If sender.editvalue > 999999 Then sender.editvalue = CDec(0)
                End If
            End If

            Try
                If sender Is Me.txtValePropio Then
                    If Me.txtValePropio.IsModified Then
                        If FicheroVales.ShowDialog = Windows.Forms.DialogResult.OK Then
                            DatosVales = Split(ResultadoBusqueda, "+")
                            Dim i As Integer, ImporteTotalVales As Decimal = 0
                            For i = 0 To DatosVales.Length - 1 Step 3
                                ImporteTotalVales += Math.Round(CDec(DatosVales(i + 2)), DecimalesImporte, MidpointRounding.AwayFromZero)
                            Next
                            If ImporteTotalVales <> Me.txtValePropio.EditValue Then
                                DatosVales = Nothing
                                Me.txtValePropio.EditValue = System.DBNull.Value
                                Me.txtValePropio.Focus()
                            End If
                        Else
                            DatosVales = Nothing
                            Me.txtValePropio.EditValue = System.DBNull.Value
                            Me.txtValePropio.Focus()
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error al mostrar vales", MsgBoxStyle.Exclamation, "Vales")
            End Try

            Dim ImporteCobrado As Decimal
            If Me.TabCobro.SelectedTabPage Is Me.TabEntrega Then
                ImporteCobrado = IIf(IsNumeric(Me.txtEntrega.EditValue), Me.txtEntrega.EditValue, 0)
            Else
                ImporteCobrado = IIf(IsNumeric(Me.txtValePropio.EditValue), Me.txtValePropio.EditValue, 0) + IIf(IsNumeric(Me.txtValeProveedor.EditValue), Me.txtValeProveedor.EditValue, 0) + IIf(IsNumeric(Me.txtEnvases.EditValue), Me.txtEnvases.EditValue, 0) + IIf(IsNumeric(Me.txtTalon.EditValue), Me.txtTalon.EditValue, 0) + IIf(IsNumeric(Me.txtTarjeta.EditValue), Me.txtTarjeta.EditValue, 0) + IIf(IsNumeric(Me.txtEfectivo.EditValue), Me.txtEfectivo.EditValue, 0)
            End If

            Select Case Me.Tag
                Case "E", "T" 'Efectivo o Tarjeta
                    If ImporteCobrado >= rTicket.ImporteTotal Then
                        Me.txtCambio.EditValue = ImporteCobrado - rTicket.ImporteTotal
                        Me.bttAceptar.Enabled = True
                        Me.bttAceptar.Focus()
                    Else
                        Me.txtCambio.EditValue = 0
                        Me.bttAceptar.Enabled = False
                        Me.txtEntrega.Focus()
                    End If

                Case "X" 'Varios
                    If ImporteCobrado >= rTicket.ImporteTotal Then
                        Me.lblCambio.Text = "Cambio:"
                        Me.txtCambio.EditValue = ImporteCobrado - rTicket.ImporteTotal
                        Me.bttAceptar.Enabled = True
                        Me.bttAceptar.Focus()
                    Else
                        Me.lblCambio.Text = "Resto:"
                        Me.txtCambio.EditValue = rTicket.ImporteTotal - ImporteCobrado
                        Me.bttAceptar.Enabled = False
                    End If

                Case "P" 'Pendiente de cobro
                    If ImporteCobrado < rTicket.ImporteTotal Then
                        Me.txtCambio.EditValue = rTicket.ImporteTotal - ImporteCobrado
                        Me.bttAceptar.Enabled = True
                    Else
                        Me.txtCambio.EditValue = 0
                        Me.bttAceptar.Enabled = False
                    End If
            End Select

            If Not sender Is Nothing Then
                If IsNumeric(sender.editvalue) Then
                    If sender.editvalue = 0 Then sender.editvalue = System.DBNull.Value
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al comprobar importes", MsgBoxStyle.Exclamation, "Comprobar importes")
        End Try
    End Sub
#End Region

#Region "bttAceptar_Click"
    Private Sub bttAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAceptar.Click
        Try
            rTicket.TipoCobro = Me.Tag

            Select Case rTicket.TipoCobro

                Case "E" 'Efectivo
                    rTicket.ImporteEfectivo = IIf(IsNumeric(Me.txtEntrega.EditValue), Me.txtEntrega.EditValue, 0)
                    rTicket.ImporteCambios = Me.txtCambio.EditValue

                Case "T" 'Tarjeta
                    If rTicket.TipoFactura = 0 Then
                        rTicket.ImporteTarjeta = IIf(IsNumeric(Me.txtEntrega.EditValue), Me.txtEntrega.EditValue, 0)
                        rTicket.ImporteCambios = Me.txtCambio.EditValue
                    Else
                        rTicket.ImporteTarjeta = rTicket.ImporteTotal
                        rTicket.ImporteCambios = 0
                    End If

                Case "X", "P" 'Varios o confirmar Pdte. de cobro
                    If IsNumeric(Me.txtEfectivo.EditValue) Then rTicket.ImporteEfectivo = Me.txtEfectivo.EditValue
                    If IsNumeric(Me.txtEnvases.EditValue) Then rTicket.ImporteEnvases = Me.txtEnvases.EditValue
                    If IsNumeric(Me.txtTalon.EditValue) Then rTicket.ImporteTalonCheque = Me.txtTalon.EditValue
                    If IsNumeric(Me.txtTarjeta.EditValue) Then rTicket.ImporteTarjeta = Me.txtTarjeta.EditValue
                    If IsNumeric(Me.txtValePropio.EditValue) Then rTicket.ImporteValesCobrados = Me.txtValePropio.EditValue
                    If IsNumeric(Me.txtValeProveedor.EditValue) Then rTicket.ImporteValesProveedor = Me.txtValeProveedor.EditValue
                    If rTicket.TipoCobro = "P" Then
                        If rTicket.TipoFactura = 0 Then
                            rTicket.CodigoCliente = Me.txtCodigoCliente.EditValue
                            rTicket.ImportePendienteCobro = Me.txtCambio.EditValue
                        Else
                            rTicket.ImportePendienteCobro = rTicket.ImporteTotal
                            rTicket.ImporteCambios = 0
                        End If
                    Else
                        rTicket.ImporteCambios = Me.txtCambio.EditValue
                    End If

                    'Comprobar vales
                    If Not DatosVales Is Nothing Then
                        If Me.txtCambio.EditValue > 0 And Me.txtValePropio.EditValue > rTicket.ImporteTotal Then
                            If MsgBox("¿Desea emitir un nuevo vale por el importe restante (" & Me.txtCambio.Text & ")?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                rTicket.ImporteCambios = 0
                                Me.TabCobro.SelectedTabPage = Me.TabVales
                                Me.txtPagadoA.Focus()
                                Me.Tag = "V"
                                Exit Sub
                            Else
                                EliminaVales()
                            End If
                        Else
                            EliminaVales()
                        End If
                    End If

                Case "V" 'Vales
                    If Not DatosVales Is Nothing Then
                        EliminaVales()
                        rTicket.ImporteValesEmitidos = Me.txtCambio.EditValue
                        NuevoVale(Me.txtCambio.EditValue)
                    Else
                        rTicket.ImporteValesEmitidos = rTicket.ImporteTotal * -1
                        NuevoVale(rTicket.ImporteTotal * -1)
                    End If

                Case "Y" 'Pendiente de cobro
                    Me.TabCobro.SelectedTabPage = Me.TabCliente
                    Me.txtCodigoCliente.EditValue = rTicket.CodigoCliente
                    Me.txtCodigoCliente.IsModified = True
                    Me.txtCodigoCliente_Validated(Nothing, Nothing)
                    Me.txtCodigoCliente.Focus()
                    Me.Tag = "P"
                    Exit Sub

                Case "R"
                    rTicket.RepartoDomicilio = True
                    rTicket.DireccionReparto = Me.txtDatosCliente.EditValue
                    Me.TabCobro.SelectedTabPage = Me.TabEntrega
                    Me.txtEntrega.Focus()
                    Me.Tag = "E"
                    Exit Sub

                Case "C" 'Cliente - Tarjeta
                    rTicket.CodigoCliente = Me.txtCodigoCliente.EditValue
                    If Not Me.ModificarCobro Then
                        TPV_Tactil.txtCodigoCliente_Validated(Nothing, Nothing)
                        Me.ActualizaDescuentoLineas(False)
                    End If
                    'Me.TipoPago(IIf(Me.bttEfectivo.Checked, 1, IIf(Me.bttTarjeta.Checked, 2, IIf(Me.bttVarios.Checked, 3, IIf(Me.bttPendienteCobro.Checked, 4, IIf(Me.bttVales.Checked, 5, 1))))))
                    Me.TipoPago(1)
                    Me.bttEfectivo.Checked = True

                    Exit Sub

            End Select

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MsgBox("Error al guardar ticket", MsgBoxStyle.Exclamation, "Ticket incorrecto")
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        End Try
    End Sub
#End Region

#Region "NuevoVale"
    Private Sub NuevoVale(ByVal Importe As Decimal)
        Try
            Dim dtVales As New dsValesTienda.VALES_TIENDADataTable
            Dim tVales As New dsValesTiendaTableAdapters.VALES_TIENDATableAdapter
            Dim rVales As dsValesTienda.VALES_TIENDARow

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT NumeroVale FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda

            rVales = dtVales.NewRow
            rVales.CodigoTienda = CodigoTienda
            rVales.CodigoVale = cmd.ExecuteScalar + 1
            rVales.FechaVale = Date.Now
            rVales.Nombre = Me.txtPagadoA.Text
            rVales.Concepto = Me.txtConcepto.Text
            rVales.Importe = Importe
            dtVales.AddVALES_TIENDARow(rVales)
            tVales.Update(dtVales)

            'Actualizar nº vale en tienda
            cmd.CommandText = "UPDATE TIENDAS SET NumeroVale=" & rVales.CodigoVale & " WHERE CodigoTienda=" & CodigoTienda
            cmd.ExecuteNonQuery()

            Me.NumeroVale = rVales.CodigoVale

        Catch ex As Exception
            MsgBox("Error al crear nuevo vale", MsgBoxStyle.Exclamation, "Nuevo vale")
        End Try
    End Sub
#End Region

#Region "EliminaVales"
    Private Sub EliminaVales()

        Dim cmd As New SqlClient.SqlCommand
        Dim i As Integer

        Try
            'Elimnar vales
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            For i = 0 To DatosVales.Length - 1 Step 3
                cmd.CommandText = "DELETE FROM VALES_TIENDA " & _
                                  "WHERE CodigoTienda=" & DatosVales(i) & " AND CodigoVale=" & DatosVales(i + 1)
            Next
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error al eliminar vales.", MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Sub
#End Region

#Region "bttTarjetaCliente_CheckedChanged"
    Private Sub bttTarjetaCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttTarjetaCliente.CheckedChanged

        If Me.bttTarjetaCliente.Checked Then
            Me.txtCodigoCliente.EditValue = rTicket.CodigoCliente
            Me.txtDatosCliente.EditValue = TPV_Tactil.txtNombreCliente.EditValue
            Me.TabCobro.SelectedTabPage = Me.TabCliente
            Me.txtCodigoCliente.Focus()
            Me.bttValidarCliente.Tag = 0
            If rTicket.CodigoCliente <> 0 Then Me.bttValidarCliente_Click(Nothing, Nothing)
            Me.bttAceptar.Enabled = False
            'Me.bttAceptar.Enabled = True
            'Me.Tag = "C"
        Else
            rTicket.CodigoCliente = 0
            If Not Me.ModificarCobro Then
                TPV_Tactil.txtCodigoCliente.EditValue = 0
                TPV_Tactil.txtCodigoCliente.IsModified = True
                TPV_Tactil.txtCodigoCliente_Validated(Nothing, Nothing)
                Me.ActualizaDescuentoLineas(False)
            End If
            If Me.TabCobro.SelectedTabPage Is Me.TabCliente Then
                'Me.TipoPago(IIf(Me.bttEfectivo.Checked, 1, IIf(Me.bttTarjeta.Checked, 2, IIf(Me.bttVarios.Checked, 3, IIf(Me.bttPendienteCobro.Checked, 4, IIf(Me.bttVales.Checked, 5, 1))))))
                Me.TipoPago(Me.bttEfectivo.Tag)
                Me.bttEfectivo.Checked = True
            End If
        End If

        'If Me.bttTarjetaCliente.Checked Then
        '    If DameCliente.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        rTicket.CodigoCliente = DameCliente.CodigoCliente
        '    Else
        '        rTicket.CodigoCliente = 0
        '    End If
        'Else
        '    rTicket.CodigoCliente = 0
        'End If
        'TPV_Tactil.txtCodigoCliente_Validated(Nothing, Nothing)

        ''Actualiza descuentos en líneas
        'Dim rLineaTicket As dsTickets.TICKETS_LINEASRow
        'Dim i As Integer

        'For i = 0 To TPV_Tactil.DsTickets.TICKETS_LINEAS.Rows.Count - 1

        '    rLineaTicket = TPV_Tactil.DsTickets.TICKETS_LINEAS.Rows(i)

        '    If Not rLineaTicket.Promocion Or DtoSobrePromociones = True Then
        '        rLineaTicket.DescuentoLinea = DameDescuentoArticulo(rLineaTicket.CodigoArticulo, GestionTarjetas, rTicket.CodigoCliente)
        '        If rLineaTicket.DescuentoLinea = 0 Then rLineaTicket.DescuentoLinea = DescuentoTarjetas
        '    End If

        '    rLineaTicket.Importe = Math.Round(rLineaTicket.Cantidad * rLineaTicket.Precio - rLineaTicket.Cantidad * rLineaTicket.Precio * rLineaTicket.DescuentoLinea / 100, DecimalesImporte, MidpointRounding.AwayFromZero)

        'Next

        'Dim Total As Decimal
        'For i = 0 To TPV_Tactil.DsTickets.TICKETS_LINEAS.Rows.Count - 1
        '    rLineaTicket = TPV_Tactil.DsTickets.TICKETS_LINEAS.Rows(i)
        '    If Not rLineaTicket.RowState = DataRowState.Deleted Then Total += rLineaTicket.Importe
        'Next
        'rTicket.ImporteTotal = Total
        'TPV_Tactil.txtTotal.EditValue = Total

    End Sub
#End Region

#Region "bttRepartoDomicilio_CheckedChanged"
    Private Sub bttRepartoDomicilio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttRepartoDomicilio.CheckedChanged
        If Me.bttRepartoDomicilio.Checked Then

            'Datos dirección cliente
            Me.txtCodigoCliente.EditValue = rTicket.CodigoCliente
            Me.DireccionRepartoCliente(rTicket.CodigoCliente)
            Me.TabCobro.SelectedTabPage = Me.TabCliente
            Me.txtCodigoCliente.Focus()

            'Guardar pantalla de origen
            If Me.bttEfectivo.Checked Then Me.bttValidarCliente.Tag = Me.bttEfectivo.Tag
            If Me.bttTarjeta.Checked Then Me.bttValidarCliente.Tag = Me.bttTarjeta.Tag
            If Me.bttVarios.Checked Then Me.bttValidarCliente.Tag = Me.bttVarios.Tag
            If Me.bttPendienteCobro.Checked Then Me.bttValidarCliente.Tag = Me.bttPendienteCobro.Tag
            If Me.bttVales.Checked Then Me.bttValidarCliente.Tag = Me.bttVales.Tag
            If Me.bttVentaCredito.Checked Then Me.bttVentaCredito.Tag = Me.bttVentaCredito.Tag

            rTicket.RepartoDomicilio = True
            rTicket.DireccionReparto = Me.txtDatosCliente.EditValue

        Else
            rTicket.RepartoDomicilio = False
            rTicket.DireccionReparto = String.Empty

            'Volver a forma de pago indicada anteriormente
            Select Case Me.bttValidarCliente.Tag
                Case 1, 2
                    Me.TabCobro.SelectedTabPage = Me.TabEntrega
                Case 3, 4
                    Me.TabCobro.SelectedTabPage = Me.TabVarios
                Case 5
                    Me.TabCobro.SelectedTabPage = Me.TabVales
                Case 6
                    'Me.bttAceptar.Enabled = True
                    Me.bttAceptar.Focus()
            End Select

            'Código antiguo
            'Me.bttAceptar.Enabled = True
            'Me.Tag = "R"
            'Else
            '    rTicket.RepartoDomicilio = False
            '    rTicket.DireccionReparto = String.Empty
            '    If Me.TabCobro.SelectedTabPage Is Me.TabCliente Then
            '        Me.bttTipoPago_Click(Me.bttEfectivo, Nothing)
            '        Me.bttEfectivo.Checked = True
            '    End If

        End If
    End Sub
#End Region

#Region "ActualizaDescuentoLineas"
    Private Sub ActualizaDescuentoLineas(ActualizaPrecio As Integer, Optional DtoPP As Decimal = 0)
        Try
            rTicket.PorcentajeDescuento = 0
            rTicket.TotalDtoPP = 0
            rTicket.TotalRecargo = 0
            rTicket.ImporteTotal = 0

            'Actualiza descuentos en líneas
            Dim dsTickets As New dsTickets
            Dim rLineaTicket As dsTickets.TICKETS_LINEASRow, rLineaCliente As dsTickets.TICKETS_LINEASRow
            Dim Base1 As Decimal = 0, Base2 As Decimal = 0, Base3 As Decimal = 0, Base4 As Decimal = 0

            Dim Lineas As DataRow()

            If Not Me.LineasTicket Is Nothing Then
                Lineas = Me.LineasTicket
            Else
                Lineas = TPV_Tactil.DsTickets.TICKETS_LINEAS.Select
            End If

            For i As Integer = 0 To Lineas.Length - 1

                rLineaTicket = Lineas(i)

                rLineaCliente = dsTickets.TICKETS_LINEAS.NewTICKETS_LINEASRow
                rLineaCliente.Cantidad = rLineaTicket.Cantidad
                rLineaCliente.Precio = rLineaTicket.Precio
                rLineaCliente.DescuentoLinea = rLineaTicket.DescuentoLinea
                rLineaCliente.Importe = rLineaTicket.Importe
                rLineaCliente.ImporteEcoraee = rLineaTicket.ImporteEcoraee

                If rTicket.CodigoCliente <> 0 And (Not rLineaTicket.Promocion Or DtoSobrePromociones = True) Then

                    Dim DtoLinea As Decimal = DameDescuentoArticulo(rLineaTicket.CodigoArticulo, TPV_Tactil.Gestiontarjetas, rTicket.CodigoCliente)

                    If DtoLinea > rLineaCliente.DescuentoLinea Then rLineaCliente.DescuentoLinea = DtoLinea

                    If rLineaCliente.DescuentoLinea = 0 Then rLineaCliente.DescuentoLinea = TPV_Tactil.DescuentoTarjetas

                Else

                    rLineaCliente.DescuentoLinea = 0

                End If

                If ActualizaPrecio Then

                    Dim Precio As Decimal = DamePrecioTarifa(Me.Tarifa, rLineaTicket.CodigoArticulo)
                    If Precio <> 0 Then

                        rLineaCliente.Precio = Precio
                        If Not IvaIncluidoTarifa(Me.Tarifa) Then rLineaCliente.Precio += Math.Round(rLineaCliente.Precio * rLineaTicket.PorcentajeIVA / 100, 2, MidpointRounding.AwayFromZero)

                        If Not rLineaTicket.IsPesoNull Then
                            rLineaCliente.Cantidad = 1
                            rLineaCliente.Precio *= rLineaTicket.Peso
                        End If

                    End If

                End If

                rLineaCliente.Importe = Math.Round(rLineaCliente.Cantidad * rLineaCliente.Precio - rLineaCliente.Cantidad * rLineaCliente.Precio * rLineaCliente.DescuentoLinea / 100 + rLineaCliente.Cantidad * rLineaCliente.ImporteEcoraee, DecimalesImporte, MidpointRounding.AwayFromZero)

                If Not rLineaTicket.PrecioManual And Math.Abs(rLineaTicket.Importe) > Math.Abs(rLineaCliente.Importe) Then

                    Dim PromocionRegalo As Boolean = False

                    If rLineaTicket.Promocion Then
                        'Comprobar si tiene regalo asociado
                        Dim Promocion As Almacen.DatosPromocion = DamePrecioPromocion(rLineaTicket.CodigoArticulo, rLineaTicket.CodigoColor, rLineaTicket.NumeroTalla)
                        PromocionRegalo = (Promocion.CodigoArticuloRegalo <> String.Empty)
                    End If

                    If Not PromocionRegalo Then
                        rLineaTicket.Cantidad = rLineaCliente.Cantidad
                        rLineaTicket.Precio = rLineaCliente.Precio
                        rLineaTicket.DescuentoLinea = rLineaCliente.DescuentoLinea
                        rLineaTicket.Importe = rLineaCliente.Importe
                        rLineaTicket.Promocion = False
                    End If

                End If

                Select Case rLineaTicket.PorcentajeIVA
                    Case TipoIva1
                        Base1 += rLineaTicket.Importe / (1 + rLineaTicket.PorcentajeIVA / 100)
                    Case TipoIva2
                        Base2 += rLineaTicket.Importe / (1 + rLineaTicket.PorcentajeIVA / 100)
                    Case TipoIva3
                        Base3 += rLineaTicket.Importe / (1 + rLineaTicket.PorcentajeIVA / 100)
                    Case TipoIva4
                        Base4 += rLineaTicket.Importe / (1 + rLineaTicket.PorcentajeIVA / 100)
                End Select

                rTicket.ImporteTotal += rLineaTicket.Importe

            Next

            If Not rTicket.IsClienteCreditoNull Then

                Dim dsClientes As New dsClientes
                Dim taCliente As New dsClientesTableAdapters.CLICREDITableAdapter
                Dim Cliente As dsClientes.CLICREDIRow

                taCliente.FillBy(dsClientes.CLICREDI, rTicket.ClienteCredito)

                If dsClientes.CLICREDI.Count > 0 Then

                    Cliente = dsClientes.CLICREDI(0)

                    If DtoPP <> 0 Then Cliente.DescuentoPP = DtoPP
                    If Cliente.DescuentoPP = 0 And Cliente.RecargoEquivalencia = 0 Then Exit Try

                    'Redondear totales bases imponibles
                    Base1 = Math.Round(Base1, 2, MidpointRounding.AwayFromZero)
                    Base2 = Math.Round(Base2, 2, MidpointRounding.AwayFromZero)
                    Base3 = Math.Round(Base3, 2, MidpointRounding.AwayFromZero)
                    Base4 = Math.Round(Base4, 2, MidpointRounding.AwayFromZero)
                    Dim BaseLineas As Decimal = Base1 + Base2 + Base3 + Base4

                    'Total descuento PP
                    If Cliente.DescuentoPP <> 0 Then
                        rTicket.PorcentajeDescuento = Cliente.DescuentoPP
                        rTicket.TotalDtoPP = Math.Round(BaseLineas * Cliente.DescuentoPP / 100, 2, MidpointRounding.AwayFromZero)
                        Base1 -= Math.Round(Base1 * Cliente.DescuentoPP / 100, 2, MidpointRounding.AwayFromZero)
                        Base2 -= Math.Round(Base2 * Cliente.DescuentoPP / 100, 2, MidpointRounding.AwayFromZero)
                        Base3 -= Math.Round(Base3 * Cliente.DescuentoPP / 100, 2, MidpointRounding.AwayFromZero)
                        Base4 -= Math.Round(Base4 * Cliente.DescuentoPP / 100, 2, MidpointRounding.AwayFromZero)
                    End If

                    'Total base imponible
                    BaseLineas = Base1 + Base2 + Base3 + Base4
                    rTicket.ImporteTotal = Math.Round(BaseLineas, 2, MidpointRounding.AwayFromZero)

                    'Total IVA
                    rTicket.ImporteTotal += Math.Round(Base1 * TipoIva1 / 100, 2, MidpointRounding.AwayFromZero)
                    rTicket.ImporteTotal += Math.Round(Base2 * TipoIva2 / 100, 2, MidpointRounding.AwayFromZero)
                    rTicket.ImporteTotal += Math.Round(Base3 * TipoIva3 / 100, 2, MidpointRounding.AwayFromZero)
                    rTicket.ImporteTotal += Math.Round(Base4 * TipoIva4 / 100, 2, MidpointRounding.AwayFromZero)

                    'Total recargo
                    If Cliente.RecargoEquivalencia And rTicket.TipoFactura <> 3 Then
                        rTicket.TotalRecargo += Math.Round(Base1 * TipoRecargo1 / 100, 2, MidpointRounding.AwayFromZero)
                        rTicket.TotalRecargo += Math.Round(Base2 * TipoRecargo2 / 100, 2, MidpointRounding.AwayFromZero)
                        rTicket.TotalRecargo += Math.Round(Base3 * TipoRecargo3 / 100, 2, MidpointRounding.AwayFromZero)
                        rTicket.TotalRecargo += Math.Round(Base4 * TipoRecargo4 / 100, 2, MidpointRounding.AwayFromZero)
                        rTicket.ImporteTotal += rTicket.TotalRecargo
                    End If

                End If

            End If

        Catch ex As Exception
            Throw ex
        Finally
            rTicket.ImporteTotal = Math.Round(rTicket.ImporteTotal, DecimalesImporte, MidpointRounding.AwayFromZero)
            TPV_Tactil.txtTotal.EditValue = rTicket.ImporteTotal
        End Try
    End Sub
#End Region

#Region "DireccionRepartoCliente"
    Private Sub DireccionRepartoCliente(ByVal CodigoCliente As Integer)

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Dim VentaCredito As Boolean = (Me.Tag = "A")

            If VentaCredito Then
                cmd.CommandText = "SELECT COUNT(*) FROM CLICREDI"
                If cmd.ExecuteScalar = 0 Then VentaCredito = False
            End If

            If Me.txtCodigoCliente.EditValue <> 0 And VentaCredito Then

                cmd.CommandText = "SELECT CLICREDI.NombreFiscal, CLICREDI.Direccion, CLICREDI.Poblacion, '' AS TelParticular " & _
                                  "FROM CLICREDI LEFT JOIN CLIENTES ON CLIENTES.ClienteCredito = CLICREDI.Codigo " & _
                                  "WHERE CLICREDI.Codigo = " & Me.txtCodigoCliente.EditValue

            Else
                cmd.CommandText = "SELECT NombreFiscal, Direccion, Poblacion, TelParticular FROM CLIENTES WHERE Codigo=" & CodigoCliente
            End If

            dr = cmd.ExecuteReader
            If dr.Read Then
                Me.txtDatosCliente.EditValue = Trim(dr("NombreFiscal"))
                If Trim(dr("Direccion")) <> String.Empty Then Me.txtDatosCliente.EditValue &= vbCrLf & Trim(dr("Direccion"))
                If Trim(dr("Poblacion")) <> String.Empty Then Me.txtDatosCliente.EditValue &= vbCrLf & Trim(dr("Poblacion"))
                If Trim(dr("TelParticular")) <> String.Empty Then Me.txtDatosCliente.EditValue &= vbCrLf & "TELEFONO : " & Trim(dr("TelParticular"))
                Me.txtDatosCliente.EditValue &= vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf
                'Me.txtDatosCliente.Focus()
                'Me.txtDatosCliente.DeselectAll()
            Else
                Me.txtCodigoCliente.EditValue = 0
                Me.txtDatosCliente.EditValue = String.Empty
                MsgBox("No existe ningún cliente con ese código", MsgBoxStyle.Information)
                Me.txtCodigoCliente.Focus()
            End If
            dr.Close()

        Catch ex As Exception
            'Error al mostrar dirección de reparto del cliente
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "bttTeclado_Click"
    Private Sub bttTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttTeclado.Click, bttTeclado2.Click
        System.Diagnostics.Process.Start("osk.exe")
        Select Case sender.tag
            Case 1
                Me.txtDatosCliente.Focus()
            Case 2
                Me.txtPagadoA.Focus()
        End Select
    End Sub
#End Region

#Region "txtCodigoCliente_ButtonClick"
    Private Sub txtCodigoCliente_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoCliente.ButtonClick
        Try

            Dim dsClientes As New dsClientes, tClientes As New dsClientesTableAdapters.CLIENTESTableAdapter, tCliCredi As New dsClientesTableAdapters.CLICREDITableAdapter
            Dim Columnas As New ArrayList
            Dim Tabla As String

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Dim VentaCredito As Boolean = (Me.Tag = "A")

            If VentaCredito Then
                If tCliCredi.NumeroClientes = 0 Then VentaCredito = False
            End If

            If VentaCredito Then

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

                Columnas.Add("DescCar1")
                Columnas.Add("CND")
                Columnas.Add(60)
                Columnas.Add(60)

                Tabla = "CLICREDI"
                tCliCredi.Fill(dsClientes.CLICREDI)

            Else

                Columnas.Add("NombreFiscal")
                Columnas.Add("Nombre Fiscal")
                Columnas.Add(300)
                Columnas.Add(300)

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

                Tabla = "CLIENTES"
                tClientes.Activos(dsClientes.CLIENTES)

            End If

            If Buscar(dsClientes, Tabla, Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
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

        Try
            If Not IsNumeric(Me.txtCodigoCliente.EditValue) Then
                Me.txtCodigoCliente.Focus()
                Exit Sub
            End If

            Me.DireccionRepartoCliente(Me.txtCodigoCliente.EditValue)

        Catch ex As Exception
            MsgBox("Error al obtener datos del cliente", MsgBoxStyle.Information, "Datos cliente")
        End Try

    End Sub
#End Region

#Region "bttValidarCliente_Click"
    Private Sub bttValidarCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttValidarCliente.Click

        If Me.bttValidarCliente.Tag = 0 Then 'Botón tarjeta cliente
            Me.DatosCliente(False)
            rTicket.CodigoCliente = Me.txtCodigoCliente.EditValue
            If Not Me.ModificarCobro Then
                TPV_Tactil.txtCodigoCliente.IsModified = True
                TPV_Tactil.txtCodigoCliente_Validated(Nothing, Nothing)
                TPV_Tactil.SorteActivo()
                Me.ActualizaDescuentoLineas(False)
                Me.TipoPago(Me.bttEfectivo.Tag)
                Me.bttEfectivo.Checked = True
            Else
                Me.bttAceptar.Enabled = True
                Me.bttAceptar.Focus()
            End If
        Else
            'Volver a forma de pago indicada anteriormente
            Select Case Me.bttValidarCliente.Tag
                Case 1, 2
                    Me.TabCobro.SelectedTabPage = Me.TabEntrega
                    Me.txtEntrega.Focus()

                Case 3, 4
                    Me.TabCobro.SelectedTabPage = Me.TabVarios
                    Me.txtValePropio.Focus()
                    Me.bttAceptar.Enabled = True

                Case 5
                    Me.TabCobro.SelectedTabPage = Me.TabVales
                    Me.txtPagadoA.Focus()

                Case 7, 8 'Venta crédito
                    Me.DatosCliente(True)
                    If Me.txtCodigoCliente.EditValue <> 0 Then
                        rTicket.ClienteCredito = Me.txtCodigoCliente.EditValue
                        Me.ActualizaDescuentoLineas(True)
                        If Me.bttValidarCliente.Tag = 7 Then
                            rTicket.TipoFactura = 1
                            Me.TabCobro.SelectedTabPage = Me.TabCobroFactura
                        Else
                            Me.txtConfirmarCliente.EditValue = rTicket.ClienteCredito
                            Me.TabCobro.SelectedTabPage = Me.TabCobroFactura
                        End If
                        Me.bttAceptar.Enabled = False
                        Me.bttDtoPP.Visible = (rTicket.ImporteTotal >= 180)
                    End If

            End Select
        End If

        'Guardar reparto a domicilio si está activado
        rTicket.RepartoDomicilio = Me.bttRepartoDomicilio.Checked
        rTicket.DireccionReparto = IIf(Me.bttRepartoDomicilio.Checked, Me.txtDatosCliente.EditValue, String.Empty)

    End Sub
#End Region

#Region "DatosCliente"
    Private Sub DatosCliente(VentaCredito As Boolean)

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            If Not IsNumeric(Me.txtCodigoCliente.EditValue) Then
                Me.txtCodigoCliente.Focus()
                Exit Sub
            End If

            Dim dr As SqlClient.SqlDataReader

            If VentaCredito Then
                'Comprobar si existen clientes de crédito
                cmd.CommandText = "SELECT COUNT(*) FROM CLICREDI"
                If cmd.ExecuteScalar = 0 Then VentaCredito = False
            End If

            If Me.txtCodigoCliente.EditValue <> 0 And VentaCredito Then

                cmd.CommandText = "SELECT NombreFiscal, Tarifa, 0 AS ControlBaja, IsNull(CuentaExt,'') CuentaExt, IsNull(DescCar1,'') CND " & _
                                  "FROM CLICREDI " & _
                                  "WHERE Codigo = " & Me.txtCodigoCliente.EditValue

            Else

                cmd.CommandText = "SELECT NombreFiscal, CaducidadTarjeta, DescuentoTarjeta, CLIENTES.ControlBaja, '' CuentaExt, '' CND " & _
                                  "FROM CLIENTES " & _
                                  "WHERE CLIENTES.Codigo = " & Me.txtCodigoCliente.EditValue

            End If

            If Me.txtCodigoCliente.EditValue = 0 Then
                Me.Tarifa = General.NumeroTarifa
                Me.txtDatosCliente.EditValue = cmd.ExecuteScalar
                Me.txtCodigoCliente.Focus()
                Me.txtCodigoCliente.IsModified = False
                Me.bttAceptar.Enabled = False
                Exit Try
            End If

            dr = cmd.ExecuteReader
            If dr.Read Then

                'Comprobar control de baja
                If Not dr("ControlBaja") Then

                    If VentaCredito Then

                        'Venta crédito comprobar tarifa
                        If dr("Tarifa") <> String.Empty Then
                            Me.Tarifa = dr("Tarifa")
                        Else
                            Me.Tarifa = NumeroTarifa
                        End If

                        'Comprobar si es cliente CND
                        If dr("CND") <> "SI" Then
                            MsgBox("No es cliente CND", MsgBoxStyle.Information)
                        End If

                    Else

                        'Tarjeta cliente comprobar dto
                        If General.GestionTarjetas Then
                            If IsDate(dr("CaducidadTarjeta")) Then
                                If dr("CaducidadTarjeta") > rTicket.FechaTicket Then
                                    TPV_Tactil.Gestiontarjetas = True
                                    TPV_Tactil.DescuentoTarjetas = IIf(dr("Descuentotarjeta") <> 0, dr("Descuentotarjeta"), General.DescuentoTarjetas)
                                Else
                                    TPV_Tactil.Gestiontarjetas = False
                                    TPV_Tactil.DescuentoTarjetas = 0
                                End If
                            Else
                                TPV_Tactil.DescuentoTarjetas = IIf(dr("Descuentotarjeta") <> 0, dr("Descuentotarjeta"), General.DescuentoTarjetas)
                            End If
                        End If

                    End If

                    'Pendiente de cobro
                    If dr("CuentaExt") <> String.Empty Then
                        Me.FORMAPAGBindingSource.Filter = String.Empty
                    Else
                        Me.FORMAPAGBindingSource.Filter = "FORPAG IN ('10','4835')"
                    End If

                    Me.bttAceptar.Enabled = True
                    Me.bttAceptar.Focus()

                Else
                    MsgBox("Cliente con control de baja", MsgBoxStyle.Information, "Control de baja")
                    Me.txtCodigoCliente.Focus()
                    Me.txtCodigoCliente.IsModified = False
                    Me.bttAceptar.Enabled = False
                End If

                Else
                    MsgBox("No existe ningún cliente con ese código", MsgBoxStyle.Information, "No existe")
                    Me.txtCodigoCliente.Focus()
                    Me.txtCodigoCliente.IsModified = False
                    Me.bttAceptar.Enabled = False
                End If
                dr.Close()

        Catch ex As Exception
            MsgBox("Error al obtener datos del cliente", MsgBoxStyle.Information, "Datos cliente")
        Finally
            cmd.Connection.Close()
        End Try

    End Sub
#End Region

    Private Sub bttAlbaran_Click(sender As Object, e As EventArgs) Handles bttAlbaran.Click
        rTicket.TipoFactura = 1
        Me.bttPendienteFactura.Visible = True
        Me.TipoPago(7)
    End Sub

    Private Sub bttFactura_Click(sender As Object, e As EventArgs) Handles bttFactura.Click
        rTicket.TipoFactura = 2
        Me.bttPendienteFactura.Visible = True
        Me.TipoPago(8)
    End Sub

    Private Sub bttCobroFactura_Click(sender As Object, e As EventArgs) Handles bttEfectivoFactura.Click, bttTarjetaFactura.Click, bttPendienteFactura.Click
        Try
            Me.Tag = sender.Tag

            Select Case Me.Tag
                Case "E"
                    Me.TabCobro.SelectedTabPage = Me.TabEntrega
                    Me.txtEntrega.Focus()
                Case "T"
                    Me.TabCobro.SelectedTabPage = Me.TabEntrega
                    Me.txtEntrega.EditValue = rTicket.ImporteTotal
                    Me.bttAceptar.Enabled = True
                    Me.bttAceptar.Focus()
                Case "P"
                    'Formas de pago
                    Me.FORMAPAGTableAdapter.Fill(Me.DsClientes.FORMAPAG)
                    If Me.FORMAPAGBindingSource.Filter <> String.Empty Then
                        Me.txtForPag.EditValue = "10"
                    Else
                        If rTicket.ImporteTotal < 180 Then Me.txtForPag.EditValue = "35"
                        If rTicket.ImporteTotal >= 180 And rTicket.ImporteTotal < 360 Then Me.txtForPag.EditValue = "2"
                        If rTicket.ImporteTotal >= 360 And rTicket.ImporteTotal < 540 Then Me.txtForPag.EditValue = "6"
                        If rTicket.ImporteTotal >= 540 Then Me.txtForPag.EditValue = "7"
                    End If
                    Me.TabCobro.SelectedTabPage = Me.TabFormaPago
                    Me.txtForPag.Focus()
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttConfirmarCliente_Click(sender As Object, e As EventArgs) Handles bttConfirmarCliente.Click
        Try
            If IsNumeric(Me.txtConfirmarCliente.EditValue) Then Me.txtConfirmarCliente.EditValue = CInt(Me.txtConfirmarCliente.EditValue)

            Select Case Me.txtConfirmarCliente.EditValue
                Case rTicket.ClienteCredito
                    Me.TabCobro.SelectedTabPage = Me.TabCobroFactura
                Case 0
                    rTicket.TipoFactura = 3
                    Me.bttPendienteFactura.Visible = False
                    Me.ActualizaDescuentoLineas(True)
                    Me.TabCobro.SelectedTabPage = Me.TabCobroFactura
                Case Else
                    Me.txtConfirmarCliente.EditValue = rTicket.ClienteCredito
                    Me.txtConfirmarCliente.Focus()
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub bttFormaPago_Click(sender As Object, e As EventArgs) Handles bttFormaPago.Click
        If Not Me.txtForPag.EditValue Is Nothing Then
            rTicket.ForPag = Me.txtForPag.EditValue
            Me.bttAceptar_Click(Me.bttAceptar, Nothing)
        End If
    End Sub

    Private Sub bttDtoPP_CheckedChanged(sender As Object, e As EventArgs) Handles bttDtoPP.CheckedChanged
        If Me.bttDtoPP.Checked Then
            Me.ActualizaDescuentoLineas(False, 3)
        Else
            Me.ActualizaDescuentoLineas(False, 0)
        End If
    End Sub

    Private Sub bttVales_Click(sender As Object, e As EventArgs) Handles bttVales.Click
        Try
            Dim fvales As New ValesTienda
            If rTicket.CodigoCliente <> 0 Then fvales.VALESTIENDABindingSource.Filter = "CodigoCliente = " & rTicket.CodigoCliente & " AND Consumido = 0"
            fvales.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

End Class