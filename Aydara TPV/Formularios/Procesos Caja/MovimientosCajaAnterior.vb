Imports System.IO
Public Class MovimientosCajaAnterior

    Dim Asteriscos As String
    Dim TipoMovimiento As String
    Dim TipoCobro As Integer = 0
    Dim numVale As Integer
    Dim var As Integer = 0
    Dim CodigoEmpleado As Integer

#Region "ProcesosCaja_Closing"
    Private Sub ProcesosCaja_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.bttCancelar_Click(Nothing, Nothing)
    End Sub
#End Region

#Region "MovimientosCaja_KeyUp"
    Private Sub MovimientosCaja_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "MovimientosCaja_Shown"
    Private Sub MovimientosCaja_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Me.txtImporte.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtSaldoCC.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtImporteCC.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtCopias.Text = CopiasDocumentos

        If ControlVendedores Then
            If Not Me.SeleccionaEmpleado() Then Me.Close()
        End If

    End Sub
#End Region

#Region "bttAceptar_Click"
    Private Sub bttAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAceptar.Click

        Dim dsTiendas As New dsTiendas
        Dim tTiendas As New dsTiendasTableAdapters.TIENDASTableAdapter
        Dim rTiendas As dsTiendas.TIENDASRow

        If Me.TipoMovimiento <> "CC" Then

            Dim dsMovimientosCaja As New dsMovimientosCaja
            Dim tMovimientosCaja As New dsMovimientosCajaTableAdapters.MOVIMIENTOS_CAJATableAdapter
            Dim rMovimientosCaja As dsMovimientosCaja.MOVIMIENTOS_CAJARow

            If Me.checkEntrega.Checked = True Then Me.TipoCobro = 1 Else Me.TipoCobro = 0

            rMovimientosCaja = dsMovimientosCaja.MOVIMIENTOS_CAJA.NewMOVIMIENTOS_CAJARow
            rMovimientosCaja.CodigoTienda = CodigoTienda
            rMovimientosCaja.CodigoCaja = Me.txtCaja.Text
            rMovimientosCaja.FechaMovimiento = Date.Now
            rMovimientosCaja.TipoMovimiento = Me.TipoMovimiento
            rMovimientosCaja.TipoCobro = Me.TipoCobro
            rMovimientosCaja.Importe = Me.txtImporte.Text
            rMovimientosCaja.Concepto = Me.txtConceptoDe.Text
            rMovimientosCaja.CodigoEmpleado = Me.CodigoEmpleado

            dsMovimientosCaja.MOVIMIENTOS_CAJA.AddMOVIMIENTOS_CAJARow(rMovimientosCaja)
            tMovimientosCaja.Update(dsMovimientosCaja.MOVIMIENTOS_CAJA)

        End If

        If Me.TipoMovimiento = "CC" Then

            If Not Me.checkEfectivo.Checked And Not Me.checkTarjeta.Checked Then
                MsgBox("Seleccione la forma de pago", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim dsMovimientosCaja As New dsMovimientosCaja
            Dim tMovimientosCaja As New dsMovimientosCajaTableAdapters.MOVIMIENTOS_CAJATableAdapter
            Dim rMovimientosCaja As dsMovimientosCaja.MOVIMIENTOS_CAJARow

            rMovimientosCaja = dsMovimientosCaja.MOVIMIENTOS_CAJA.NewMOVIMIENTOS_CAJARow
            rMovimientosCaja.CodigoTienda = CodigoTienda
            rMovimientosCaja.CodigoCaja = Me.txtCajaCC.Text
            rMovimientosCaja.CodigoCliente = Me.txtClienteCC.Text
            rMovimientosCaja.FechaMovimiento = Date.Now
            rMovimientosCaja.TipoMovimiento = Me.TipoMovimiento
            rMovimientosCaja.TipoCobro = IIf(Me.checkEfectivo.Checked, 0, 1)
            rMovimientosCaja.Importe = Me.txtImporteCC.Text
            rMovimientosCaja.Concepto = Me.txtConceptoCC.Text
            rMovimientosCaja.CodigoEmpleado = Me.CodigoEmpleado

            dsMovimientosCaja.MOVIMIENTOS_CAJA.AddMOVIMIENTOS_CAJARow(rMovimientosCaja)
            tMovimientosCaja.Update(dsMovimientosCaja.MOVIMIENTOS_CAJA)

            'REVISAR QUE O HA HECHO ROBERTO

            Dim dsPendientesCobro As New dsPendientesCobro
            Dim tPendientesCobro As New dsPendientesCobroTableAdapters.PENDIENTES_COBROTableAdapter
            Dim rPendientesCobro As dsPendientesCobro.PENDIENTES_COBRORow

            Dim i As Integer
            Dim ImportePendiente As Decimal = Me.txtImporteCC.Text
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

            Try
                cmd.Connection.Open()
                cmd.CommandText = "SELECT * FROM PENDIENTES_COBRO WHERE CodigoCliente=" & Me.txtClienteCC.EditValue

                If Me.txtTicketCC.Text <> String.Empty Then cmd.CommandText += " AND CodigoTicket = " & (Me.txtTicketCC.Text)
                cmd.CommandText += " ORDER BY Fecha"
                dsPendientesCobro.PENDIENTES_COBRO.Load(CType(cmd.ExecuteReader, SqlClient.SqlDataReader))

                For i = 0 To dsPendientesCobro.PENDIENTES_COBRO.Rows.Count - 1
                    rPendientesCobro = dsPendientesCobro.PENDIENTES_COBRO.Rows(i)
                    If rPendientesCobro.ImporteCobrado + ImportePendiente > rPendientesCobro.ImporteTicket Then
                        ImportePendiente -= rPendientesCobro.ImporteTicket - rPendientesCobro.ImporteCobrado
                        rPendientesCobro.ImporteCobrado = rPendientesCobro.ImporteTicket
                    Else
                        rPendientesCobro.ImporteCobrado += ImportePendiente
                        Exit For
                    End If
                Next
                tPendientesCobro.Update(dsPendientesCobro.PENDIENTES_COBRO)

                cmd.CommandText = "DELETE FROM PENDIENTES_COBRO WHERE ImporteTicket = ImporteCobrado"
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                Throw ex
            Finally
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End Try

        End If

        If Me.TipoMovimiento = "EV" Then

            Dim dsValesTienda As New dsValesTienda
            Dim tValesTienda As New dsValesTiendaTableAdapters.VALES_TIENDATableAdapter
            Dim rValesTienda As dsValesTienda.VALES_TIENDARow

            rValesTienda = dsValesTienda.VALES_TIENDA.NewVALES_TIENDARow
            rValesTienda.CodigoTienda = CodigoTienda
            rValesTienda.CodigoVale = numVale
            rValesTienda.FechaVale = Date.Now
            rValesTienda.Nombre = Me.txtPagadoA.Text
            rValesTienda.Concepto = Me.txtConceptoDe.Text
            rValesTienda.Importe = Me.txtImporte.Text

            dsValesTienda.VALES_TIENDA.AddVALES_TIENDARow(rValesTienda)
            tValesTienda.Update(dsValesTienda.VALES_TIENDA)

        End If

        If (ImpresionEtiquetas = False) Then
            bttCancelar_Click(Nothing, Nothing)
        ElseIf ImpresionEtiquetas = True Then
            If var = 1 Then
                If MsgBox("¿Desea imprimir el ticket?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    ImprimeTicket = 0
                    If Me.txtCopias.Text = 0 Then
                        Me.txtCopias.Text = IIf(Me.TipoMovimiento = "PC" Or Me.TipoMovimiento = "CC" Or Me.TipoMovimiento = "EV", 2, 1)
                    End If
                End If
            End If

            Dim ticket As String = String.Empty

            If ActivaAperturaCajon Then ticket += AbreCajon()

            tTiendas.DameTienda(dsTiendas.TIENDAS, CodigoTienda)
            rTiendas = dsTiendas.TIENDAS.Rows(0)

            ticket += vbCrLf & ActivaExpandido()
            ticket += rTiendas.TextoCabecera1

            ticket += DesactivaExpandido()

            ticket += vbCrLf & vbCrLf & "FECHA: " & Date.Today & " HORA: " & Format(Date.Now, "HH:mm") & " T:" & Format(CodigoTienda, "00") & " C:" & Format(CodigoCaja, "00")
            ticket += vbCrLf & vbCrLf & (Asteriscos)
            'If Me.TipoMovimiento = "CC" Then ticket += vbCrLf & "CODIGO DE CLIENTE: " &
            If Me.TipoMovimiento = "CC" Then
                ticket += vbCrLf & "CODIGO CLIENTE: " & Me.txtClienteCC.Text
                ticket += vbCrLf & Me.txtNombreClienteCC.Text
                ticket += vbCrLf & "HA PAGADO LA CANTIDAD DE: " & Format(CType(Me.txtImporteCC.EditValue, Decimal), "0.00") & " EUROS"
                ticket += vbCrLf & "EN CONCEPTO DE: " & Me.txtConceptoCC.Text
                If Me.txtTicketCC.Text <> String.Empty Then ticket += vbCrLf & vbCrLf & "NTRA. Factura num: " & Me.txtTicketCC.Text
            End If
            If Me.txtConceptoDe.Visible And Me.TipoMovimiento = "PC" Then
                ticket += vbCrLf & "PAGADO A: " & vbCrLf & Me.txtPagadoA.Text
            ElseIf Me.txtConceptoDe.Visible And Me.TipoMovimiento = "EV" Then
                ticket += vbCrLf & "VALE DE COMPRA A FAVOR DE: " & vbCrLf & Me.txtPagadoA.Text
            End If

            If Me.TipoMovimiento = "EC" Or Me.TipoMovimiento = "PC" Then ticket += vbCrLf & "HA RECIBIDO LA CANTIDAD DE: " & Format(CType(Me.txtImporte.EditValue, Decimal), "0.00") & " EUROS"
            If Me.TipoMovimiento = "RF" Then ticket += vbCrLf & "HA RETIRADO LA CANTIDAD DE: " & Format(CType(Me.txtImporte.EditValue, Decimal), "0.00") & " EUROS"
            If Me.txtPagadoA.Visible And Me.TipoMovimiento = "PC" Then ticket += vbCrLf & "EN CONCEPTO DE: " & vbCrLf & Me.txtConceptoDe.Text
            If Me.txtPagadoA.Visible And Me.TipoMovimiento = "EV" Then ticket += vbCrLf & "EN CONCEPTO DE: " & vbCrLf & Me.txtConceptoDe.Text
            If Me.TipoMovimiento = "EV" Then ticket += vbCrLf & "HA RECIBIDO LA CANTIDAD DE: " & Format(CType(Me.txtImporte.EditValue, Decimal), "0.00") & " EUROS"
            If Me.checkEntrega.Checked = True Then ticket += vbCrLf & vbCrLf & "        *** ENTREGA A CUENTA ***"
            If Me.TipoMovimiento <> "EV" Then ticket += vbCrLf & vbCrLf & "       RECIBI:"
            If ActivaCorteTicket Then ticket += CorteTicket()

            If ImprimeTicket = 0 Then
                Dim numCopias As Integer = 0
                numCopias = CType(Me.txtCopias.Text, Integer)
                Dim i As Integer

                For i = 1 To numCopias
                    Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket)
                Next
            End If
            var = 0
            'Actualizar contador vale en tienda
            If Me.TipoMovimiento = "EV" Then
                rTiendas.NumeroVale += 1
                tTiendas.Update(dsTiendas.TIENDAS)
            End If

            bttCancelar_Click(Nothing, Nothing)
        Else
            bttCancelar_Click(Nothing, Nothing)
        End If

    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Try
            Me.txtCajaCC.EditValue = System.String.Empty
            Me.txtNombreClienteCC.EditValue = System.String.Empty
            Me.txtImporteCC.EditValue = 0
            Me.txtSaldoCC.EditValue = 0
            Me.txtTicketCC.EditValue = System.String.Empty
            Me.txtClienteCC.EditValue = System.String.Empty
            Me.txtConceptoCC.EditValue = System.String.Empty
            Me.panelDatosComunes.Text = System.String.Empty
            Me.txtCaja.Text = System.String.Empty
            Me.txtImporte.EditValue = 0
            Me.txtPagadoA.Text = System.String.Empty
            Me.txtConceptoDe.Text = System.String.Empty
            Me.checkEntrega.Checked = False
            Me.ActivaDesactivaMenu(True)
            Me.ActivaDesactivaCampos(False, 0)
            DatosCajaActual(CodigoCaja) 'coger parametros de la caja actual
            Me.bttEntradaCambios.Focus()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "ActivaDesactivaMenu"
    Private Sub ActivaDesactivaMenu(ByVal activa As Boolean)
        Me.bttCancelar.Visible = Not activa
        Me.bttAceptar.Visible = Not activa
        Me.txtImporte.Properties.ReadOnly = activa
        Me.bttEntradaCambios.Enabled = activa
        Me.bttRetiradaFondos.Enabled = activa
        Me.bttPagosCaja.Enabled = activa
        Me.bttCobrosCliente.Enabled = activa
        Me.bttEmisionVales.Enabled = activa
        Me.bttAceptar.Enabled = activa
    End Sub
#End Region

#Region "ActivaDesactivaCampos"
    Private Sub ActivaDesactivaCampos(ByVal activa As Boolean, ByVal Opcion As Integer)

        Me.txtCaja.Properties.ReadOnly = False
        Me.txtCajaCC.Properties.ReadOnly = False
        Me.txtImporte.Properties.ReadOnly = True
        Me.txtPagadoA.Properties.ReadOnly = True
        Me.txtConceptoDe.Properties.ReadOnly = True
        Me.txtClienteCC.Properties.ReadOnly = True
        Me.txtClienteCC.Properties.Buttons(0).Enabled = False
        Me.txtClienteCC.Properties.Buttons(1).Enabled = False
        Me.txtTicketCC.Properties.ReadOnly = True
        Me.txtTicketCC.Properties.Buttons(0).Enabled = False
        Me.txtImporteCC.Properties.ReadOnly = True
        Me.txtConceptoCC.Properties.ReadOnly = True
        Me.txtCopias.EditValue = String.Empty
        Me.checkEfectivo.Checked = False
        Me.checkTarjeta.Checked = False

        Select Case Opcion
            Case 0
                Me.panelDatosComunes.Visible = activa
                Me.panelPagadoA.Visible = activa
                Me.panelEntregaCuenta.Visible = activa
                Me.PanelCobrosCliente.Visible = activa
                Me.txtCaja.Properties.Buttons(0).Enabled = activa
                Me.LabelControl2.Top = 106
                Me.txtImporte.Top = 103
                Me.txtCopias.Visible = activa
                Me.lblCopias.Visible = activa

            Case 1
                Me.panelDatosComunes.Visible = activa
                Me.txtCaja.Properties.Buttons(0).Enabled = activa
                Me.txtCopias.Visible = activa
                Me.lblCopias.Visible = activa
                Me.txtCaja.Properties.ReadOnly = False
            Case 2
                Me.panelDatosComunes.Visible = activa
                Me.panelPagadoA.Visible = activa
                Me.txtCaja.Properties.Buttons(0).Enabled = activa
                Me.txtCopias.Visible = activa
                Me.lblCopias.Visible = activa
                Me.lblPagadoFavor.Text = "Pagado a:"
            Case 3
                Me.PanelCobrosCliente.Visible = activa
                Me.txtCopias.Visible = activa
                Me.lblCopias.Visible = activa
                Me.txtCajaCC.Focus()
            Case 4
                Me.panelDatosComunes.Visible = activa
                Me.panelPagadoA.Visible = activa
                Me.panelEntregaCuenta.Visible = activa
                Me.txtCaja.Properties.Buttons(0).Enabled = activa
                Me.txtCopias.Visible = activa
                Me.lblCopias.Visible = activa
                Me.lblPagadoFavor.Text = "A favor de:"
        End Select

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()
        cmd.CommandText = "SELECT COUNT(CodigoCaja+CajaCerrada) FROM CAJAS WHERE CodigoTienda=" & CodigoTienda

        If cmd.ExecuteScalar = 1 Then
            cmd.CommandText = "SELECT CodigoCaja FROM CAJAS WHERE CodigoTienda=" & CodigoTienda
            If Opcion = 3 Then
                Me.txtCajaCC.EditValue = cmd.ExecuteScalar
                Me.txtCajaCC.IsModified = True
                Me.txtCajaCC_Validated(Nothing, Nothing)
                Me.txtClienteCC.Focus()
            Else
                Me.txtCaja.EditValue = cmd.ExecuteScalar
                Me.txtCaja.IsModified = True
                Me.txtCaja_Validated(Nothing, Nothing)
                Me.txtImporte.Focus()
            End If
        End If

        cmd.Connection.Close()

    End Sub
#End Region

#Region "txtCaja_Validated"
    Private Sub txtCaja_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCaja.Validated

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            If Not Me.txtCaja.IsModified Then Exit Sub

            If IsNumeric(Me.txtCaja.Text) Then
                Me.txtCaja.Text = Format(CType(Me.txtCaja.Text, Integer), "00")
            Else
                'MsgBox("Solo puedes introducir datos numéricos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Solo Números")
                Me.txtCaja.Text = System.String.Empty
                Me.txtCaja.Focus()
                Exit Sub
            End If

            cmd.Connection.Open()
            cmd.CommandText = "SELECT * FROM CAJAS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja='" & (Me.txtCaja.EditValue) & "' AND CajaCerrada = 0"
            If Not CType(cmd.ExecuteReader, SqlClient.SqlDataReader).HasRows Then
                MsgBox("La caja no existe o está cerrada", MsgBoxStyle.Information)
                Me.txtCaja.Text = System.String.Empty
                Me.txtCaja.Focus()
            Else
                DatosCajaActual(Me.txtCaja.Text)
                Me.txtCaja.Properties.ReadOnly = True
                Me.txtImporte.Properties.ReadOnly = False
                If ImprimeTicket = 0 Then
                    Me.txtCopias.Text = IIf(Me.TipoMovimiento = "PC" Or Me.TipoMovimiento = "CC" Or Me.TipoMovimiento = "EV", 2, 1)
                ElseIf ImprimeTicket = 1 Then
                    Me.txtCopias.Text = 0
                ElseIf ImprimeTicket = 2 Then
                    var = 1
                End If
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "bttEntradaCambios_Click"
    Private Sub bttEntradaCambios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEntradaCambios.Click
        Me.panelDatosComunes.Text = "Entrada de Cambios"
        Me.TipoMovimiento = "EC"
        Me.TipoCobro = 1
        Me.ActivaDesactivaMenu(False)
        Me.ActivaDesactivaCampos(True, 1)
        Me.Asteriscos = "       *** PRESTAMO PARA CAMBIOS ***" & vbCrLf

        If Me.txtCaja.Visible = True Then
            Me.txtCaja.Focus()
        Else
            Me.txtImporte.Focus()
        End If

    End Sub
#End Region

#Region "bttRetiradaFondos_Click"
    Private Sub bttRetiradaFondos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttRetiradaFondos.Click
        Me.panelDatosComunes.Text = "Retirada de Fondos"
        Me.TipoMovimiento = "RF"
        Me.TipoCobro = 1
        Me.ActivaDesactivaMenu(False)
        Me.ActivaDesactivaCampos(True, 1)
        Me.Asteriscos = "       *** RETIRADA DE FONDOS ***" & vbCrLf
        Me.txtCaja.Focus()
    End Sub
#End Region

#Region "bttPagosCaja_Click"
    Private Sub bttPagosCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttPagosCaja.Click
        Me.panelDatosComunes.Text = "Pagos por Caja"
        Me.TipoMovimiento = "PC"
        Me.TipoCobro = 1
        Me.ActivaDesactivaMenu(False)
        Me.ActivaDesactivaCampos(True, 2)
        Me.Asteriscos = "         *** PAGOS POR CAJA ***" & vbCrLf
        Me.txtCaja.Focus()
    End Sub
#End Region

#Region "bttCobrosCliente_Click"
    Private Sub bttCobrosCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCobrosCliente.Click
        Me.TipoMovimiento = "CC"
        Me.TipoCobro = 1
        Me.ActivaDesactivaMenu(False)
        Me.ActivaDesactivaCampos(True, 3)
        Me.Asteriscos = "        *** COBROS A CLIENTES ***" & vbCrLf

    End Sub
#End Region

#Region "bttEmisionVales_Click"
    Private Sub bttEmisionVales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEmisionVales.Click
        Me.panelDatosComunes.Text = "Emisión de Vales"
        Me.TipoMovimiento = "EV"
        Me.TipoCobro = 0
        Me.ActivaDesactivaMenu(False)
        Me.ActivaDesactivaCampos(True, 4)

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()
        cmd.CommandText = "SELECT NumeroVale FROM TIENDAS WHERE CodigoTienda = " & CodigoTienda

        numVale = cmd.ExecuteScalar
        numVale += 1
        Me.Asteriscos = ActivaExpandido() & vbCrLf & "NUM. VALE : " & numVale & vbCrLf

        'subrayado con iguales
        Dim i As Integer = Len("NUM. VALE : " & numVale + 1)
        While i > 0
            Me.Asteriscos += "="
            i -= 1
        End While
        Me.Asteriscos += DesactivaExpandido() & vbCrLf
        Me.txtCaja.Focus()
    End Sub
#End Region

#Region "txtCaja_ButtonClick"
    Private Sub txtCaja_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCaja.ButtonClick
        Try
            Dim dsCajas As New dsCajas, tCajas As New dsCajasTableAdapters.CAJASTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("CodigoCaja")
            Columnas.Add("Codigo Caja")
            Columnas.Add(80)
            Columnas.Add(80)

            tCajas.CajasAbiertas(dsCajas.CAJAS, CodigoTienda)

            If Buscar(dsCajas, "CAJAS", Columnas, 0).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCaja.Text = ResultadoBusqueda
                Me.txtImporte.Focus()
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttSalir_Click"
    Private Sub bttSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttSalir.Click
        Me.Close()
    End Sub
#End Region

    'PENDIENTES COBRO

#Region "txtCajaCC_ButtonClick"
    Private Sub txtCajaCC_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCajaCC.ButtonClick
        Try
            Dim dsCajas As New dsCajas, tCajas As New dsCajasTableAdapters.CAJASTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("CodigoCaja")
            Columnas.Add("Codigo Caja")
            Columnas.Add(80)
            Columnas.Add(80)

            tCajas.CajasAbiertas(dsCajas.CAJAS, CodigoTienda)

            If Buscar(dsCajas, "CAJAS", Columnas, 0).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCajaCC.Text = ResultadoBusqueda
                Me.txtClienteCC.Focus()
                Me.txtClienteCC.EditValue = System.String.Empty
                Me.txtSaldoCC.EditValue = System.DBNull.Value
                Me.txtTicketCC.EditValue = System.String.Empty
                Me.txtImporteCC.EditValue = System.DBNull.Value
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCajaCC_Validated"
    Private Sub txtCajaCC_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCajaCC.Validated

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            If Not Me.txtCajaCC.IsModified Then Exit Sub

            If IsNumeric(Me.txtCajaCC.Text) Then
                Me.txtCajaCC.Text = Format(CType(Me.txtCajaCC.Text, Integer), "00")
            Else
                'MsgBox("Solo puedes introducir datos numéricos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Solo Números")
                Me.txtCajaCC.Text = System.String.Empty
                Me.txtCajaCC.Focus()
                Exit Sub
            End If

            cmd.Connection.Open()
            cmd.CommandText = "SELECT * FROM CAJAS WHERE CodigoCaja='" & (Me.txtCajaCC.EditValue) & "' AND CajaCerrada = 0"
            If Not CType(cmd.ExecuteReader, SqlClient.SqlDataReader).HasRows Then
                MsgBox("La caja no existe o está cerrada.", MsgBoxStyle.Information)
                Me.txtCajaCC.Text = System.String.Empty
                Me.txtCajaCC.Focus()
            Else
                DatosCajaActual(Me.txtCajaCC.Text)
                If ImprimeTicket = 0 Then
                    Me.txtCopias.Text = IIf(Me.TipoMovimiento = "PC" Or Me.TipoMovimiento = "CC" Or Me.TipoMovimiento = "EV", 2, 1)
                ElseIf ImprimeTicket = 1 Then
                    Me.txtCopias.Text = 0
                ElseIf ImprimeTicket = 2 Then
                    var = 1
                End If
                Me.txtClienteCC.EditValue = System.String.Empty
                Me.txtSaldoCC.EditValue = System.DBNull.Value
                Me.txtTicketCC.EditValue = System.String.Empty
                Me.txtImporteCC.EditValue = System.DBNull.Value
                Me.txtClienteCC.Properties.ReadOnly = False
                Me.txtClienteCC.Properties.Buttons(0).Enabled = True
                Me.txtClienteCC.Properties.Buttons(1).Enabled = True
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "txtClienteCC_ButtonClick"
    Private Sub txtClienteCC_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtClienteCC.ButtonClick
        Try
            Select Case e.Button.Index
                Case 0

                    Dim dsClientes As New dsClientes, tClientes As New dsClientesTableAdapters.CLIENTESTableAdapter
                    Dim Columnas As New ArrayList

                    Columnas.Add("Codigo")
                    Columnas.Add("Código")
                    Columnas.Add(80)
                    Columnas.Add(80)
                    Columnas.Add("NombreFiscal")
                    Columnas.Add("Nombre Fiscal")
                    Columnas.Add(0)
                    Columnas.Add(0)

                    tClientes.Fill(dsClientes.CLIENTES)

                    If Buscar(dsClientes, "CLIENTES", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                        If Me.txtCajaCC.Text = System.String.Empty Or Me.txtCajaCC.Text Is System.DBNull.Value Then
                            MsgBox("Indique el código de caja", MsgBoxStyle.Information)
                            Me.txtClienteCC.Text = System.String.Empty
                            Me.txtNombreClienteCC.Text = System.String.Empty
                            Me.txtSaldoCC.EditValue = System.String.Empty
                            Me.txtCajaCC.Focus()
                        Else
                            Me.txtClienteCC.Text = ResultadoBusqueda
                            Me.txtTicketCC.Focus()
                            Me.txtSaldoCC.EditValue = DameSaldoCliente()
                            Me.txtTicketCC.EditValue = System.String.Empty
                            Me.txtImporteCC.EditValue = System.DBNull.Value
                        End If

                    End If

                Case 1

                    Dim dsCobros As New dsPendientesCobro, tCorbros As New dsPendientesCobroTableAdapters.PENDIENTES_COBROTableAdapter
                    Dim ColumnasCC As New ArrayList

                    ColumnasCC.Add("CodigoCliente")
                    ColumnasCC.Add("Codigo de Cliente")
                    ColumnasCC.Add(150)
                    ColumnasCC.Add(150)
                    ColumnasCC.Add("NombreFiscal")
                    ColumnasCC.Add("Nombre de Cliente")
                    ColumnasCC.Add(150)
                    ColumnasCC.Add(150)
                    ColumnasCC.Add("Fecha")
                    ColumnasCC.Add("Fecha")
                    ColumnasCC.Add(150)
                    ColumnasCC.Add(150)
                    ColumnasCC.Add("CodigoTicket")
                    ColumnasCC.Add("Numero de Ticket")
                    ColumnasCC.Add(150)
                    ColumnasCC.Add(150)
                    ColumnasCC.Add("ImporteTicket")
                    ColumnasCC.Add("Importe Ticket")
                    ColumnasCC.Add(150)
                    ColumnasCC.Add(150)
                    ColumnasCC.Add("ImporteCobrado")
                    ColumnasCC.Add("Importe Cobrado")
                    ColumnasCC.Add(150)
                    ColumnasCC.Add(150)

                    tCorbros.Todos(dsCobros.PENDIENTES_COBRO)

                    If Buscar(dsCobros, "PENDIENTES_COBRO", ColumnasCC, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                        If Me.txtCajaCC.Text = System.String.Empty Or Me.txtCajaCC.Text Is System.DBNull.Value Then
                            MsgBox("Indique el código de caja.", MsgBoxStyle.Information)
                            Me.txtClienteCC.Text = System.String.Empty
                            Me.txtNombreClienteCC.Text = System.String.Empty
                            Me.txtSaldoCC.EditValue = System.String.Empty
                            Me.txtCajaCC.Focus()
                        Else
                            Me.txtClienteCC.Text = ResultadoBusqueda
                            Me.txtTicketCC.Focus()
                            Me.txtSaldoCC.EditValue = DameSaldoCliente()
                            Me.txtTicketCC.EditValue = System.String.Empty
                            Me.txtImporteCC.EditValue = System.DBNull.Value
                        End If
                    End If

            End Select

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtClienteCC_Validated"
    Private Sub txtClienteCC_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtClienteCC.Validated

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            If Not Me.txtClienteCC.IsModified Then Exit Sub

            If IsNumeric(Me.txtClienteCC.Text) Then
                'Me.txtClienteCC.Text = Format(CType(Me.txtClienteCC.Text, Integer), "00000")
            Else
                'MsgBox("Solo puedes introducir datos numéricos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Solo Números")
                Me.txtClienteCC.Text = System.String.Empty
                Me.txtClienteCC.Focus()
                Exit Sub
            End If

            cmd.Connection.Open()
            cmd.CommandText = "SELECT COUNT(*) FROM CLIENTES WHERE Codigo=" & (Me.txtClienteCC.Text)
            If cmd.ExecuteScalar = 0 Then
                MsgBox("El cliente no existe.", MsgBoxStyle.Information)
                Me.txtClienteCC.Text = System.String.Empty
                Me.txtClienteCC.Focus()
            Else
                Me.txtSaldoCC.EditValue = DameSaldoCliente()
                If ImprimeTicket = 0 Then
                    Me.txtCopias.Text = 1
                ElseIf ImprimeTicket = 1 Then
                    Me.txtCopias.Text = 0
                ElseIf ImprimeTicket = 2 Then
                    var = 1
                End If
                Me.txtTicketCC.EditValue = System.String.Empty
                Me.txtImporteCC.EditValue = System.DBNull.Value

                cmd.CommandText = "SELECT NombreFiscal FROM CLIENTES WHERE Codigo=" & (Me.txtClienteCC.Text)
                Me.txtNombreClienteCC.Text = cmd.ExecuteScalar

                Me.txtTicketCC.Properties.ReadOnly = False
                Me.txtTicketCC.Properties.Buttons(0).Enabled = True
                Me.txtImporteCC.Properties.ReadOnly = False
            End If
            If Me.txtCajaCC.Text = System.String.Empty Or Me.txtCajaCC.Text Is System.DBNull.Value Then
                MsgBox("Indique el código de caja.", MsgBoxStyle.Information)
                Me.txtClienteCC.Text = System.String.Empty
                Me.txtNombreClienteCC.Text = System.String.Empty
                Me.txtSaldoCC.EditValue = System.DBNull.Value
                Me.txtCajaCC.Focus()
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Sub
#End Region

#Region "txtTicketCC_ButtonClick"
    Private Sub txtTicketCC_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtTicketCC.ButtonClick
        Try
            Dim dsCobros As New dsPendientesCobro, tCorbros As New dsPendientesCobroTableAdapters.PENDIENTES_COBROTableAdapter
            Dim ColumnasCC As New ArrayList

            ColumnasCC.Add("CodigoTicket")
            ColumnasCC.Add("Numero de Ticket")
            ColumnasCC.Add(150)
            ColumnasCC.Add(150)
            ColumnasCC.Add("CodigoTienda")
            ColumnasCC.Add("Codigo de Tienda")
            ColumnasCC.Add(150)
            ColumnasCC.Add(150)
            ColumnasCC.Add("Fecha")
            ColumnasCC.Add("Codigo de Cliente")
            ColumnasCC.Add(150)
            ColumnasCC.Add(150)
            ColumnasCC.Add("ImporteTicket")
            ColumnasCC.Add("Importe Ticket")
            ColumnasCC.Add(150)
            ColumnasCC.Add(150)
            ColumnasCC.Add("ImporteCobrado")
            ColumnasCC.Add("Importe Cobrado")
            ColumnasCC.Add(150)
            ColumnasCC.Add(150)

            tCorbros.Cliente(dsCobros.PENDIENTES_COBRO, Me.txtClienteCC.Text)

            If Buscar(dsCobros, "PENDIENTES_COBRO", ColumnasCC, 0).ShowDialog = Windows.Forms.DialogResult.OK Then
                If Me.txtCajaCC.Text = System.String.Empty Or Me.txtCajaCC.Text Is System.DBNull.Value Then
                    MsgBox("Indique el código de caja.", MsgBoxStyle.Information)
                    Me.txtTicketCC.EditValue = System.String.Empty
                    Me.txtNombreClienteCC.Text = System.String.Empty
                    Me.txtSaldoCC.EditValue = System.String.Empty
                    Me.txtCajaCC.Focus()
                Else
                    Me.txtTicketCC.Text = ResultadoBusqueda
                    Me.txtImporteCC.Focus()
                    Me.txtImporteCC.EditValue = DameImporte()
                End If
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
#End Region

#Region "txtTicketCC_Validated"
    Private Sub txtTicketCC_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTicketCC.Validated

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            If Not Me.txtTicketCC.IsModified Then Exit Sub

            If IsNumeric(Me.txtTicketCC.Text) Then
                Me.txtTicketCC.Text = Format(CType(Me.txtTicketCC.Text, Integer), "000000")
            Else
                'MsgBox("Solo puedes introducir datos numéricos", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Solo Números")
                Me.txtTicketCC.Text = System.String.Empty
                Me.txtTicketCC.Focus()
                Exit Sub
            End If

            cmd.Connection.Open()
            cmd.CommandText = "SELECT COUNT(*) FROM PENDIENTES_COBRO WHERE CodigoTicket=" & (Me.txtTicketCC.Text)
            If cmd.ExecuteScalar = 0 Then
                MsgBox("El nº de ticket no existe.", MsgBoxStyle.Information)
                Me.txtTicketCC.EditValue = System.String.Empty
                Me.txtTicketCC.Focus()
            Else
                If ImprimeTicket = 0 Then
                    Me.txtCopias.Text = 1
                ElseIf ImprimeTicket = 1 Then
                    Me.txtCopias.Text = 0
                ElseIf ImprimeTicket = 2 Then
                    var = 1
                End If
                Me.txtImporteCC.Focus()
                Me.txtImporteCC.EditValue = DameImporte()
            End If
            If Me.txtCajaCC.Text = System.String.Empty Or Me.txtCajaCC.Text Is System.DBNull.Value Then
                MsgBox("Indique el código de caja.", MsgBoxStyle.Information)
                Me.txtClienteCC.Text = System.String.Empty
                Me.txtNombreClienteCC.Text = System.String.Empty
                Me.txtSaldoCC.EditValue = System.DBNull.Value
                Me.txtCajaCC.Focus()
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "DameSaldoCliente"
    Function DameSaldoCliente() As Decimal

        If IsNumeric(Me.txtClienteCC.Text) Then

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

            Try
                cmd.Connection.Open()
                cmd.CommandText = "SELECT ISNULL(SUM(ImporteTicket),0) - ISNULL(SUM(ImporteCobrado),0) FROM PENDIENTES_COBRO WHERE CodigoCliente=" & (Me.txtClienteCC.Text)

                Return cmd.ExecuteScalar

            Catch ex As Exception
                Return 0
            Finally
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End Try
        Else
            Return 0
        End If
    End Function
#End Region

#Region "DameImporte"
    Function DameImporte() As Decimal
        If IsNumeric(Me.txtClienteCC.Text) Then

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

            Try
                cmd.Connection.Open()
                cmd.CommandText = "SELECT ISNULL(SUM(ImporteTicket),0) - ISNULL(SUM(ImporteCobrado),0) FROM PENDIENTES_COBRO WHERE CodigoTicket=" & (Me.txtTicketCC.Text)

                Return cmd.ExecuteScalar

            Catch ex As Exception
                Return 0
            Finally
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End Try
        Else
            Return 0
        End If
    End Function
#End Region

#Region "txtImporte_Validated"
    Private Sub txtImporte_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporte.Validated
        If Me.txtImporte.EditValue <> 0 Then
            Me.txtPagadoA.Properties.ReadOnly = False
            Me.bttAceptar.Enabled = Not (Me.panelPagadoA.Visible)
            If Me.bttAceptar.Enabled Then Me.bttAceptar.Focus()
        Else
            Me.txtImporte.Focus()
        End If
    End Sub
#End Region

#Region "txtPagadoA_Validated"
    Private Sub txtPagadoA_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPagadoA.Validated
        If Me.txtPagadoA.EditValue <> String.Empty Then
            Me.txtConceptoDe.Properties.ReadOnly = False
            Me.bttAceptar.Enabled = True
        Else
            Me.txtPagadoA.Focus()
        End If
    End Sub
#End Region

#Region "txtImporteCC_Validated"
    Private Sub txtImporteCC_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteCC.Validated
        If IsNumeric(Me.txtImporteCC.EditValue) Then
            If Me.txtImporteCC.EditValue <> 0 And CDec(Me.txtImporteCC.EditValue) <= CDec(Me.txtSaldoCC.EditValue) Then
                Me.txtConceptoCC.Properties.ReadOnly = False
                Me.bttAceptar.Enabled = True
            Else
                Me.txtImporteCC.Focus()
                Me.bttAceptar.Enabled = False
            End If
        Else
            Me.txtImporteCC.Focus()
        End If
    End Sub
#End Region

#Region "checkEntrega_CheckedChanged"
    Private Sub checkEntrega_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkEntrega.CheckedChanged
        Me.checkEntrega.Text = IIf(Me.checkEntrega.Checked, "X", String.Empty)
    End Sub
#End Region

#Region "SeleccionaEmpleado"
    Private Function SeleccionaEmpleado()
        Try
            Dim cancela As Boolean

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT Count(Codigo) FROM OPERARIOS"
            If cmd.ExecuteScalar = 1 Then
                cmd.CommandText = "SELECT Codigo FROM OPERARIOS"
                Me.CodigoEmpleado = cmd.ExecuteScalar
            Else
                Me.Enabled = False
                If DameEmpleado.ShowDialog = Windows.Forms.DialogResult.OK Then
                    cmd.CommandText = "SELECT Codigo FROM OPERARIOS WHERE Codigo=" & CodigoEmpleado
                    Me.CodigoEmpleado = cmd.ExecuteScalar
                Else
                    cancela = True
                End If
                Me.Enabled = True
            End If

            Return Not cancela

        Catch ex As Exception
            MsgBox("Error al seleccionar empleado", MsgBoxStyle.Exclamation, "Selecciona empleado")
            Return False
        End Try
    End Function
#End Region

#Region "checkEfectivo_CheckedChanged"
    Private Sub checkEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkEfectivo.CheckedChanged
        Me.checkTarjeta.Checked = False
    End Sub
#End Region

#Region "checkTarjeta_CheckedChanged"
    Private Sub checkTarjeta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkTarjeta.CheckedChanged
        Me.checkEfectivo.Checked = False
    End Sub
#End Region

End Class
