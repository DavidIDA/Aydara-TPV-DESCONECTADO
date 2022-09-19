Public Class MovimientosCaja

    Dim CodigoEmpleado As Integer

#Region "MovimientosCaja_KeyUp"
    Private Sub MovimientosCaja_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Escape
                Me.bttCancelar_Click(Nothing, Nothing)
            Case Keys.F1
                Me.bttTipoPago_Click(Me.bttEntradaCambios, Nothing) : Me.bttEntradaCambios.Checked = True
            Case Keys.F2
                Me.bttTipoPago_Click(Me.bttRetiradaFondos, Nothing) : Me.bttRetiradaFondos.Checked = True
            Case Keys.F3
                Me.bttTipoPago_Click(Me.bttPagosCaja, Nothing) : Me.bttPagosCaja.Checked = True
            Case Keys.F4
                Me.bttTipoPago_Click(Me.bttCobrosCliente, Nothing) : Me.bttCobrosCliente.Checked = True
            Case Keys.F5
                Me.bttTipoPago_Click(Me.bttEmisionVales, Nothing) : Me.bttEmisionVales.Checked = True
        End Select
    End Sub
#End Region

#Region "MovimientosCaja_Load"
    Private Sub MovimientosCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'Pedir caja y empleado
            If Not Me.SeleccionaCaja() Then Me.Close() : Exit Try
            If Not Me.SeleccionaEmpleado Then Me.Close() : Exit Try

            General.DatosCajaActual(General.CodigoCaja)
            If General.ImprimeTicket = 1 Then Me.txtCopias.EditValue = 0 Else Me.txtCopias.EditValue = 1

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "MovimientosCaja_Shown"
    Private Sub MovimientosCaja_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            'Decimales en precios
            Me.txtImporteEntradaRetirada.Properties.Mask.EditMask = "c" & DecimalesImporte
            Me.txtImportePagosCaja.Properties.Mask.EditMask = "c" & DecimalesImporte
            Me.txtSaldoCliente.Properties.Mask.EditMask = "c" & DecimalesImporte
            Me.txtImporteCobroCliente.Properties.Mask.EditMask = "c" & DecimalesImporte
            Me.txtImporteVales.Properties.Mask.EditMask = "c" & DecimalesImporte

            Me.TipoPago(1)
            Me.bttEntradaCambios.Checked = True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
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
                MsgBox("Todas las cajas están cerradas", MsgBoxStyle.Information)
                cancela = True
            ElseIf CajasAbiertas = 1 Then
                cmd.CommandText = "SELECT CodigoCaja FROM CAJAS WHERE CodigoTienda=" & CodigoTienda & " AND CajaCerrada = 0"
                General.CodigoCaja = cmd.ExecuteScalar
            Else
                If Not DameCaja.ShowDialog = Windows.Forms.DialogResult.OK Then
                    cancela = True
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

#Region "SeleccionaEmpleado"
    Private Function SeleccionaEmpleado()

        Dim cancela As Boolean

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            cmd.Connection.Open()

            cmd.CommandText = "SELECT Count(Codigo) FROM OPERARIOS"

            If cmd.ExecuteScalar = 1 Then
                cmd.CommandText = "SELECT Codigo FROM OPERARIOS"
                Me.CodigoEmpleado = cmd.ExecuteScalar
            Else
                Me.Enabled = False
                If DameEmpleado.ShowDialog = Windows.Forms.DialogResult.OK Then
                    cmd.CommandText = "SELECT * FROM OPERARIOS WHERE Codigo=" & CodigoEmpleado
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
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Function
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "bttTipoPago_Click"
    Private Sub bttTipoPago_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttEntradaCambios.Click, bttRetiradaFondos.Click, bttPagosCaja.Click, bttCobrosCliente.Click, bttEmisionVales.Click
        Me.TipoPago(sender.Tag)
    End Sub
#End Region

#Region "TipoPago"
    Public Sub TipoPago(ByVal Opcion As Integer)

        'Desactivar opciones
        Me.bttEntradaCambios.Checked = False
        Me.bttRetiradaFondos.Checked = False
        Me.bttPagosCaja.Checked = False
        Me.bttCobrosCliente.Checked = False
        Me.bttEmisionVales.Checked = False

        'Limpiar entrada / retirada
        Me.txtImporteEntradaRetirada.EditValue = System.DBNull.Value

        'Limpiar pagos por caja
        Me.txtImportePagosCaja.EditValue = System.DBNull.Value
        Me.txtPagadoA.EditValue = String.Empty : Me.txtPagadoA.Properties.ReadOnly = True
        Me.txtConceptoPagosCaja.EditValue = String.Empty : Me.txtConceptoPagosCaja.Properties.ReadOnly = True

        'Limpiar cobros cliente
        Me.txtCodigoCliente.EditValue = System.DBNull.Value
        Me.txtNombreCliente.EditValue = String.Empty
        Me.txtSaldoCliente.EditValue = System.DBNull.Value
        Me.txtNumeroTicket.EditValue = String.Empty : Me.txtNumeroTicket.Properties.ReadOnly = True
        Me.txtNumeroTicket.Properties.Buttons(0).Enabled = False
        Me.txtImporteCobroCliente.EditValue = System.DBNull.Value : Me.txtImporteCobroCliente.Properties.ReadOnly = True
        Me.txtConceptoCliente.EditValue = String.Empty : Me.txtConceptoCliente.Properties.ReadOnly = True
        Me.checkEfectivo.Checked = False
        Me.checkTarjeta.Checked = False

        'Limpiar emisión vales
        Me.txtImporteVales.EditValue = System.DBNull.Value
        Me.txtAfavorde.EditValue = String.Empty : Me.txtAfavorde.Properties.ReadOnly = True
        Me.txtConceptoVales.EditValue = String.Empty : Me.txtConceptoVales.Properties.ReadOnly = True

        Me.bttAceptar.Enabled = False

        Select Case Opcion
            Case 1 'Entrada de cambios
                Me.Tag = "EC"
                Me.TabMovimientosCaja.SelectedTabPage = Me.TabEntradaRetirada
                Me.txtImporteEntradaRetirada.Focus()
                If General.ImprimeTicket <> 1 Then Me.txtCopias.EditValue = 1

            Case 2 'Retirada de fondos
                Me.Tag = "RF"
                Me.TabMovimientosCaja.SelectedTabPage = Me.TabEntradaRetirada
                Me.txtImporteEntradaRetirada.Focus()
                If General.ImprimeTicket <> 1 Then Me.txtCopias.EditValue = 1

            Case 3 'Pagos por caja
                Me.Tag = "PC"
                Me.TabMovimientosCaja.SelectedTabPage = Me.TabPagosCaja
                Me.txtImportePagosCaja.Focus()
                If General.ImprimeTicket <> 1 Then Me.txtCopias.EditValue = 2

            Case 4 'Cobros a cliente
                Me.Tag = "CC"
                Me.TabMovimientosCaja.SelectedTabPage = Me.TabCobrosCliente
                Me.txtCodigoCliente.Focus()
                If General.ImprimeTicket <> 1 Then Me.txtCopias.EditValue = 2

            Case 5 'Emisión de vales
                Me.Tag = "EV"
                Me.TabMovimientosCaja.SelectedTabPage = Me.TabEmisionVales
                Me.txtImporteVales.Focus()
                If General.ImprimeTicket <> 1 Then Me.txtCopias.EditValue = 2

        End Select
    End Sub
#End Region

#Region "txtImportes_Validated"
    Private Sub txtImportes_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporteEntradaRetirada.Validated, txtImportePagosCaja.Validated, txtImporteCobroCliente.Validated, txtImporteVales.Validated

        Dim Importe As Decimal = 0

        Try
            If IsNumeric(sender.EditValue) Then Importe = sender.EditValue

            If Importe = 0 Then sender.Focus() : Exit Try

            Select Case sender.Name
                Case Me.txtImporteEntradaRetirada.Name
                    Me.bttAceptar.Enabled = True
                    Me.bttAceptar.Focus()

                Case Me.txtImportePagosCaja.Name
                    Me.txtPagadoA.Properties.ReadOnly = False

                Case Me.txtImporteCobroCliente.Name
                    If Importe > Me.txtSaldoCliente.EditValue Then
                        sender.Focus()
                        Me.bttAceptar.Enabled = False
                    Else
                        Me.txtConceptoCliente.Properties.ReadOnly = False
                        Me.bttAceptar.Enabled = True
                    End If

                Case Me.txtImporteVales.Name
                    Me.txtAfavorde.Properties.ReadOnly = False

            End Select

        Catch ex As Exception
            MsgBox("Error al comprobar el importe", MsgBoxStyle.Exclamation)
        End Try

    End Sub
#End Region

#Region "bttTeclado_Click"
    Private Sub bttTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttTeclado.Click
        System.Diagnostics.Process.Start("osk.exe")
    End Sub
#End Region

#Region "txtPagadoA_Validated"
    Private Sub txtPagadoA_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPagadoA.Validated
        Me.txtConceptoPagosCaja.Properties.ReadOnly = (Me.txtPagadoA.EditValue = String.Empty)
        Me.bttAceptar.Enabled = (Me.txtPagadoA.EditValue <> String.Empty)
        If Me.bttAceptar.Enabled Then Me.txtConceptoPagosCaja.Focus() Else Me.txtPagadoA.Focus()
    End Sub
#End Region

#Region "txtAfavorde_Validated"
    Private Sub txtAfavorde_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAfavorde.Validated
        Me.txtConceptoVales.Properties.ReadOnly = (Me.txtAfavorde.EditValue = String.Empty)
        Me.bttAceptar.Enabled = (Me.txtAfavorde.EditValue <> String.Empty)
        If Me.bttAceptar.Enabled Then Me.txtConceptoVales.Focus() Else Me.txtAfavorde.Focus()
    End Sub
#End Region

#Region "txtConceptos_Validated"
    Private Sub txtConceptos_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtConceptoPagosCaja.Validated, txtConceptoCliente.Validated, txtConceptoVales.Validated
        Me.bttAceptar.Focus()
    End Sub
#End Region

#Region "txtCodigoCliente_ButtonClick"
    Private Sub txtCodigoCliente_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoCliente.ButtonClick
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
                        Me.txtCodigoCliente.EditValue = ResultadoBusqueda
                        Me.txtNumeroTicket.Focus()
                        Me.txtSaldoCliente.EditValue = Me.DameSaldoCliente()
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
                        Me.txtCodigoCliente.Text = ResultadoBusqueda
                        Me.txtNumeroTicket.Focus()
                        Me.txtSaldoCliente.EditValue = Me.DameSaldoCliente()
                        Me.txtNumeroTicket.EditValue = System.DBNull.Value
                        Me.txtImporteCobroCliente.EditValue = System.DBNull.Value
                    End If

            End Select

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoCliente_Validated"
    Private Sub txtCodigoCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCliente.Validated

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            If Not Me.txtCodigoCliente.IsModified Then Exit Sub

            If Not IsNumeric(Me.txtCodigoCliente.Text) Then
                Me.txtCodigoCliente.EditValue = System.DBNull.Value
                Me.txtCodigoCliente.Focus()
                Exit Try
            End If

            cmd.Connection.Open()
            cmd.CommandText = "SELECT COUNT(*) FROM CLIENTES WHERE Codigo=" & (Me.txtCodigoCliente.EditValue)

            If cmd.ExecuteScalar = 0 Then
                MsgBox("El cliente no existe.", MsgBoxStyle.Information)
                Me.txtCodigoCliente.EditValue = System.DBNull.Value
                Me.txtCodigoCliente.Focus()
            Else

                'Recoger datos del cliente
                Me.txtSaldoCliente.EditValue = Me.DameSaldoCliente()
                Me.txtNumeroTicket.EditValue = System.DBNull.Value
                Me.txtImporteCobroCliente.EditValue = System.DBNull.Value

                cmd.CommandText = "SELECT NombreFiscal FROM CLIENTES WHERE Codigo=" & (Me.txtCodigoCliente.EditValue)
                Me.txtNombreCliente.EditValue = cmd.ExecuteScalar

                Me.txtNumeroTicket.Properties.Buttons(0).Enabled = True
                Me.txtNumeroTicket.Properties.ReadOnly = False
                Me.txtImporteCobroCliente.Properties.ReadOnly = False

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

        If IsNumeric(Me.txtCodigoCliente.EditValue) Then

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

            Try
                cmd.Connection.Open()
                cmd.CommandText = "SELECT ISNULL(SUM(ImporteTicket),0) - ISNULL(SUM(ImporteCobrado),0) FROM PENDIENTES_COBRO WHERE CodigoCliente=" & (Me.txtCodigoCliente.EditValue)

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

#Region "txtNumeroTicket_ButtonClick"
    Private Sub txtNumeroTicket_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtNumeroTicket.ButtonClick

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

            tCorbros.Cliente(dsCobros.PENDIENTES_COBRO, Me.txtCodigoCliente.EditValue)

            If Buscar(dsCobros, "PENDIENTES_COBRO", ColumnasCC, 0).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtNumeroTicket.EditValue = ResultadoBusqueda
                Me.txtImporteCobroCliente.Focus()
                Me.txtImporteCobroCliente.EditValue = Me.DameImporte()
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
#End Region

#Region "txtNumeroTicket_Validated"
    Private Sub txtNumeroTicket_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNumeroTicket.Validated

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            If Not Me.txtNumeroTicket.IsModified Then Exit Sub

            If Not IsNumeric(Me.txtNumeroTicket.EditValue) Then
                Me.txtNumeroTicket.EditValue = System.DBNull.Value
                Me.txtNumeroTicket.Focus()
                Exit Try
            End If

            cmd.Connection.Open()
            cmd.CommandText = "SELECT COUNT(*) FROM PENDIENTES_COBRO WHERE CodigoTicket=" & Me.txtNumeroTicket.EditValue

            If cmd.ExecuteScalar = 0 Then
                MsgBox("El nº de ticket no existe.", MsgBoxStyle.Information)
                Me.txtNumeroTicket.EditValue = System.DBNull.Value
                Me.txtNumeroTicket.Focus()
            Else
                Me.txtImporteCobroCliente.Focus()
                Me.txtImporteCobroCliente.EditValue = DameImporte()
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "DameImporte"
    Function DameImporte() As Decimal
        If IsNumeric(Me.txtNumeroTicket.EditValue) Then

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

            Try
                cmd.Connection.Open()
                cmd.CommandText = "SELECT ISNULL(SUM(ImporteTicket),0) - ISNULL(SUM(ImporteCobrado),0) FROM PENDIENTES_COBRO WHERE CodigoTicket=" & Me.txtNumeroTicket.EditValue

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

#Region "bttAceptar_Click"
    Private Sub bttAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAceptar.Click

        Dim dsMovimientosCaja As New dsMovimientosCaja
        Dim tMovimientosCaja As New dsMovimientosCajaTableAdapters.MOVIMIENTOS_CAJATableAdapter
        Dim rMovimientosCaja As dsMovimientosCaja.MOVIMIENTOS_CAJARow

        Dim NumeroVale As Integer

        Try
            'Nuevo movimiento
            rMovimientosCaja = dsMovimientosCaja.MOVIMIENTOS_CAJA.NewMOVIMIENTOS_CAJARow

            Select Case Me.Tag

                Case "EC", "RF"
                    rMovimientosCaja.CodigoTienda = General.CodigoTienda
                    rMovimientosCaja.CodigoCaja = General.CodigoCaja
                    rMovimientosCaja.FechaMovimiento = Date.Now
                    rMovimientosCaja.TipoMovimiento = Me.Tag
                    rMovimientosCaja.Importe = Me.txtImporteEntradaRetirada.EditValue
                    rMovimientosCaja.CodigoEmpleado = Me.CodigoEmpleado

                Case "PC"

                    'Nuevo movimiento
                    rMovimientosCaja.CodigoTienda = General.CodigoTienda
                    rMovimientosCaja.CodigoCaja = General.CodigoCaja
                    rMovimientosCaja.FechaMovimiento = Date.Now
                    rMovimientosCaja.TipoMovimiento = Me.Tag
                    rMovimientosCaja.Importe = Me.txtImportePagosCaja.EditValue
                    rMovimientosCaja.Concepto = Me.txtConceptoPagosCaja.EditValue
                    rMovimientosCaja.CodigoEmpleado = Me.CodigoEmpleado

                Case "CC"

                    'Comprobar forma de pago
                    If Not Me.checkEfectivo.Checked And Not Me.checkTarjeta.Checked Then
                        MsgBox("Seleccione la forma de pago", MsgBoxStyle.Information)
                        Exit Try
                    End If

                    'Nuevo movimiento
                    rMovimientosCaja.CodigoTienda = General.CodigoTienda
                    rMovimientosCaja.CodigoCaja = General.CodigoCaja
                    rMovimientosCaja.CodigoCliente = Me.txtCodigoCliente.EditValue
                    rMovimientosCaja.FechaMovimiento = Date.Now
                    rMovimientosCaja.TipoMovimiento = Me.Tag
                    rMovimientosCaja.TipoCobro = IIf(Me.checkEfectivo.Checked, 0, 1)
                    rMovimientosCaja.Importe = Me.txtImporteCobroCliente.EditValue
                    rMovimientosCaja.Concepto = Me.txtConceptoCliente.EditValue
                    rMovimientosCaja.CodigoEmpleado = Me.CodigoEmpleado

                    'Actualizar pendientes de cobro
                    Dim NumeroTicket As Integer
                    If IsNumeric(Me.txtNumeroTicket.EditValue) Then NumeroTicket = Me.txtNumeroTicket.EditValue
                    Me.ActualizarPendientesCobro(rMovimientosCaja.CodigoCliente, rMovimientosCaja.Importe, NumeroTicket)

                Case "EV"

                    'Nuevo movimiento
                    rMovimientosCaja.CodigoTienda = General.CodigoTienda
                    rMovimientosCaja.CodigoCaja = General.CodigoCaja
                    rMovimientosCaja.FechaMovimiento = Date.Now
                    rMovimientosCaja.TipoMovimiento = Me.Tag
                    rMovimientosCaja.TipoCobro = IIf(Me.checkEntregaCuenta.Checked, 0, 1)
                    rMovimientosCaja.Importe = Me.txtImporteVales.EditValue
                    rMovimientosCaja.Concepto = Me.txtConceptoVales.EditValue
                    rMovimientosCaja.CodigoEmpleado = Me.CodigoEmpleado

                    'Emitir nuevo vale
                    NumeroVale = Me.NuevoVale()

            End Select

            'Añadir movimiento
            dsMovimientosCaja.MOVIMIENTOS_CAJA.AddMOVIMIENTOS_CAJARow(rMovimientosCaja)
            tMovimientosCaja.Update(dsMovimientosCaja.MOVIMIENTOS_CAJA)

            'Imprimir ticket/s
            If General.ImprimeTicket = 2 Then
                If MsgBox("¿Desea imprimir el ticket?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Try
                End If
            End If

            Me.ImprimirTicket(NumeroVale)

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
#End Region

#Region "ActualizarPendientesCobro"
    Private Sub ActualizarPendientesCobro(ByVal CodigoCliente As Integer, ByVal ImportePendiente As Decimal, ByVal NumeroTicket As Integer)

        Dim dsPendientesCobro As New dsPendientesCobro
        Dim tPendientesCobro As New dsPendientesCobroTableAdapters.PENDIENTES_COBROTableAdapter
        Dim rPendientesCobro As dsPendientesCobro.PENDIENTES_COBRORow

        Dim i As Integer
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            cmd.Connection.Open()

            cmd.CommandText = "SELECT * FROM PENDIENTES_COBRO WHERE CodigoCliente=" & CodigoCliente
            If NumeroTicket <> 0 Then cmd.CommandText += " AND CodigoTicket = " & NumeroTicket
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

    End Sub
#End Region

#Region "NuevoVale"
    Private Function NuevoVale() As Integer

        Dim dsValesTienda As New dsValesTienda
        Dim tValesTienda As New dsValesTiendaTableAdapters.VALES_TIENDATableAdapter
        Dim rValesTienda As dsValesTienda.VALES_TIENDARow

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Dim NumeroVale As Integer

        Try
            rValesTienda = dsValesTienda.VALES_TIENDA.NewVALES_TIENDARow
            rValesTienda.CodigoTienda = General.CodigoTienda
            rValesTienda.FechaVale = Date.Now
            rValesTienda.Nombre = Me.txtPagadoA.EditValue
            rValesTienda.Concepto = Me.txtConceptoVales.EditValue
            rValesTienda.Importe = Me.txtImporteVales.EditValue

            'Nº de vale
            cmd.Connection.Open()
            cmd.CommandText = "SELECT NumeroVale FROM TIENDAS WHERE CodigoTienda = " & CodigoTienda
            NumeroVale = CInt(cmd.ExecuteScalar) + 1

            rValesTienda.CodigoVale = NumeroVale

            dsValesTienda.VALES_TIENDA.AddVALES_TIENDARow(rValesTienda)
            tValesTienda.Update(dsValesTienda.VALES_TIENDA)

            'Actualizar nº vale en tienda
            cmd.CommandText = "UPDATE TIENDAS SET NumeroVale=" & NumeroVale & " WHERE CodigoTienda=" & General.CodigoTienda
            cmd.ExecuteNonQuery()

            Return NumeroVale

        Catch ex As Exception
            MsgBox("Error al emitir nuevo vale." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try

    End Function
#End Region

#Region "ImprimirTicket"
    Private Sub ImprimirTicket(ByVal NumeroVale As Integer)

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            Dim ticket As String = String.Empty

            If ActivaAperturaCajon Then ticket += AbreCajon()

            ticket &= vbCrLf & ActivaExpandido()

            'Datos tienda
            cmd.Connection.Open()
            cmd.CommandText = "SELECT TextoCabecera1 FROM TIENDAS WHERE CodigoTienda=" & General.CodigoTienda

            ticket &= cmd.ExecuteScalar

            ticket &= DesactivaExpandido()

            ticket &= vbCrLf & vbCrLf & "FECHA: " & Date.Today & " HORA: " & Format(Date.Now, "HH:mm") & " T:" & Format(General.NumeroAlmacen, "00") & " C:" & Format(General.CodigoCaja, "00")

            ticket &= vbCrLf & vbCrLf

            Select Case Me.Tag
                Case "EC"
                    ticket &= "       *** PRESTAMO PARA CAMBIOS ***"
                    ticket &= vbCrLf & vbCrLf & "HA RECIBIDO LA CANTIDAD DE: " & Replace(Me.txtImporteEntradaRetirada.Text, "€", "EUROS")
                    ticket &= vbCrLf & vbCrLf & "       RECIBI:"

                Case "RF"
                    ticket &= "       *** RETIRADA DE FONDOS ***"
                    ticket &= vbCrLf & vbCrLf & "HA RETIRADO LA CANTIDAD DE: " & Replace(Me.txtImporteEntradaRetirada.Text, "€", "EUROS")
                    ticket &= vbCrLf & vbCrLf & "       RECIBI:"

                Case "PC"
                    ticket &= "         *** PAGOS POR CAJA ***"
                    ticket &= vbCrLf & vbCrLf & "PAGADO A: " & vbCrLf & Me.txtPagadoA.EditValue
                    ticket &= vbCrLf & "HA RECIBIDO LA CANTIDAD DE: " & Replace(Me.txtImportePagosCaja.Text, "€", "EUROS")
                    ticket += vbCrLf & "EN CONCEPTO DE: " & vbCrLf & Me.txtConceptoPagosCaja.EditValue
                    ticket &= vbCrLf & vbCrLf & "       RECIBI:"

                Case "CC"
                    ticket &= "        *** COBROS A CLIENTES ***"
                    ticket &= vbCrLf & vbCrLf & "CODIGO CLIENTE: " & Me.txtCodigoCliente.Text
                    ticket &= vbCrLf & Me.txtNombreCliente.EditValue
                    ticket &= vbCrLf & "HA PAGADO LA CANTIDAD DE: " & Replace(Me.txtImporteCobroCliente.Text, "€", "EUROS")
                    ticket &= vbCrLf & "EN CONCEPTO DE: " & Me.txtConceptoCliente.EditValue
                    If IsNumeric(Me.txtNumeroTicket.EditValue) Then ticket &= vbCrLf & vbCrLf & "NTRA. Factura num: " & Me.txtNumeroTicket.EditValue
                    ticket &= vbCrLf & vbCrLf & "       RECIBI:"

                Case "EV"
                    ticket &= ActivaExpandido() & vbCrLf & "NUM. VALE : " & NumeroVale & vbCrLf
                    'subrayado con iguales
                    Dim i As Integer = Len("NUM. VALE : " & NumeroVale)
                    While i > 0
                        ticket &= "="
                        i -= 1
                    End While
                    ticket &= DesactivaExpandido()
                    ticket &= vbCrLf & vbCrLf & "VALE DE COMPRA A FAVOR DE: " & vbCrLf & Me.txtAfavorde.EditValue
                    ticket += vbCrLf & "EN CONCEPTO DE: " & vbCrLf & Me.txtConceptoVales.EditValue
                    ticket &= vbCrLf & "HA RECIBIDO LA CANTIDAD DE: " & Replace(Me.txtImporteVales.Text, "€", "EUROS")
                    If Me.checkEntregaCuenta.Checked = True Then ticket &= vbCrLf & vbCrLf & "        *** ENTREGA A CUENTA ***"

            End Select

            If ActivaCorteTicket Then ticket += CorteTicket()

            For i As Integer = 1 To Me.txtCopias.EditValue
                Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket)
            Next

        Catch ex As Exception
            MsgBox("Error al imprimir ticket." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Sub
#End Region

    Private Sub bttArqueo_Click(sender As Object, e As EventArgs) Handles bttArqueo.Click
        Try
            Dim Arqueo As New ArqueoCaja
            Arqueo.CierreCaja = False

            If Arqueo.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtImporteEntradaRetirada.EditValue = Arqueo.TotalEfectivo
                Me.txtImporteEntradaRetirada.DoValidate()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

End Class