Public Class Clientes

#Region "Clientes_FormClosing"
    Private Sub Clientes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bttCancelar.Text = "Cancelar" And Me.DsClientes.HasChanges Then
            If MsgBox("Está editando un cliente. ¿Seguro que desea salir sin guardar los cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = True Else Me.Dispose()
        Else
            'Me.Dispose()
        End If
    End Sub
#End Region

#Region "Clientes_KeyUp"
    Private Sub Clientes_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "Clientes_Load"
    Private Sub Clientes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.DsClientes.PENDIENTES_COBRO.CodigoTiendaColumn.DefaultValue = CodigoTienda
        Me.DsClientes.PENDIENTES_COBRO.CodigoCajaColumn.DefaultValue = CodigoCaja
        Me.DsClientes.PENDIENTES_COBRO.FechaColumn.DefaultValue = Date.Today
    End Sub
#End Region

#Region "Clientes_Shown"
    Private Sub Clientes_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.maskImporte.Mask.EditMask = "c" & DecimalesImporte
        Me.gvPendientesCobro.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
        Me.gvPendientesCobro.FocusedColumn = Me.colNombre
    End Sub
#End Region

#Region "bttNuevo_Click"
    Private Sub bttNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttNuevo.Click
        Try
            Me.DsClientes.Clear()
            Me.CLIENTESBindingSource.AddNew()

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT Isnull(Max(Codigo),0) FROM CLIENTES"
            Me.txtCodigo.EditValue = cmd.ExecuteScalar + 1

            ActivaDesactivaMenu(False)
            ActivaDesactivaCampos(False)
            Me.txtNombreFiscal.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttModificar_Click"
    Private Sub bttModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttModificar.Click
        Try
            ActivaDesactivaMenu(False)
            ActivaDesactivaCampos(False)
            Me.txtNombreFiscal.Focus()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try

            Dim dsClientes As New dsClientes, tClientes As New dsClientesTableAdapters.CLIENTESTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Tarjeta") 'Encabezado
            Columnas.Add(60) 'Tamaño columna
            Columnas.Add(60) 'Tamaño máximo columna 

            Columnas.Add("ClienteCredito")
            Columnas.Add("Cliente")
            Columnas.Add(60)
            Columnas.Add(60)

            Columnas.Add("NombreFiscal")
            Columnas.Add("Nombre Fiscal")
            Columnas.Add(250)
            Columnas.Add(250)

            Columnas.Add("Direccion")
            Columnas.Add("Dirección")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("TelParticular")
            Columnas.Add("Teléfono")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("CIF")
            Columnas.Add("N.I.F.")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("SaldoPuntos")
            Columnas.Add("Saldo puntos")
            Columnas.Add(80)
            Columnas.Add(80)

            tClientes.Fill(dsClientes.CLIENTES)

            If Buscar(dsClientes, "CLIENTES", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigo.Text = ResultadoBusqueda
                Me.txtCodigo.IsModified = True
                Me.txtCodigo_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttEliminar_Click"
    Private Sub bttEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEliminar.Click
        Try
            If Me.gvPendientesCobro.RowCount > 0 Then
                MsgBox("El cliente tiene tickets pendientes de cobro." & vbCrLf & "Elimine lo pendiente de cobro antes de poder dar de baja al cliente", MsgBoxStyle.Information)
                Exit Try
            End If
            If MsgBox("¿Seguro que desea eliminar el cliente seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar cliente") = MsgBoxResult.Yes Then
                Me.CLIENTESBindingSource.RemoveCurrent()
                Me.CLIENTESTableAdapter.Update(Me.DsClientes.CLIENTES)
                ActivaDesactivaMenu(True)
                Me.txtCodigo.Focus()
            End If
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Try
            If sender.text = "Salir" Then Me.Close() : Exit Sub

            'If MsgBox("¿Seguro que desea deshacer los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Deshacer cambios") = MsgBoxResult.No Then Exit Sub
            Me.CLIENTESBindingSource.CancelEdit()

            ActivaDesactivaMenu(True)
            ActivaDesactivaCampos(True)

            Me.txtCodigo.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttGuardar_Click"
    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click
        Try
            'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then Exit Sub
            Me.CLIENTESBindingSource.EndEdit()
            Me.CLIENTESTableAdapter.Update(Me.DsClientes.CLIENTES)

            'Guardar pendiente de cobro
            Dim i As Integer
            For i = 0 To Me.gvPendientesCobro.RowCount - 1
                Me.gvPendientesCobro.SetRowCellValue(i, Me.colCodigoCliente, Me.txtCodigo.EditValue)
            Next
            Me.PENDIENTESCOBROBindingSource.EndEdit()
            Me.PENDIENTES_COBROTableAdapter.Update(Me.DsClientes.PENDIENTES_COBRO)

            ActivaDesactivaMenu(True)
            ActivaDesactivaCampos(True)

            Me.txtCodigo.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigo_ButtonClick"
    Private Sub txtCodigo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigo.ButtonClick
        Me.bttBuscar_Click(Nothing, Nothing)
    End Sub
#End Region

#Region "txtCodigo_Validated"
    Private Sub txtCodigo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.Validated
        Try
            If Not IsNumeric(Me.txtCodigo.EditValue) Then Exit Try
            If Not Me.txtCodigo.IsModified Then Exit Try

            Dim CodigoCliente As Integer = Me.txtCodigo.Text
            Me.CLIENTESTableAdapter.DameCliente(Me.DsClientes.CLIENTES, CodigoCliente)

            If Me.CLIENTESBindingSource.Count = 0 Then
                If MsgBox("No existe ningún cliente con ese código." & vbCrLf & "¿Desea dar de alta un nuevo cliente?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "No existe") = MsgBoxResult.Yes Then
                    Me.bttNuevo_Click(Nothing, Nothing)
                    Me.txtCodigo.Text = CodigoCliente
                    Me.txtNombreFiscal.Focus()
                    Me.bttGuardar.Enabled = True
                    ActivaDesactivaCampos(False)
                Else
                    Me.DsClientes.Clear()
                    Me.ActivaDesactivaMenu(True)
                    Me.txtCodigo.Focus()
                End If
            Else
                Me.DsClientes.PENDIENTES_COBRO.NombreColumn.DefaultValue = Me.txtNombreFiscal.EditValue
                Me.PENDIENTES_COBROTableAdapter.Cliente(Me.DsClientes.PENDIENTES_COBRO, CodigoCliente)
                Me.ActivaDesactivaMenu(True)
                Me.ActivaDesactivaCampos(True)
                Me.txtCodigo.Focus()
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "ActivaDesactivaMenu"
    Private Sub ActivaDesactivaMenu(ByVal activa As Boolean)
        Me.bttNuevo.Enabled = activa
        Me.bttBuscar.Enabled = activa
        Me.bttModificar.Enabled = IIf(Me.CLIENTESBindingSource.Count = 0, False, activa)
        Me.bttEliminar.Enabled = IIf(Me.CLIENTESBindingSource.Count = 0 Or Me.txtCodigo.EditValue = 0, False, activa)
        Me.bttTarjeta.Enabled = IIf(Me.CLIENTESBindingSource.Count = 0 Or Me.txtCodigo.EditValue = 0, False, activa)
        Me.bttCancelar.Text = IIf(activa, "Salir", "Cancelar")
        Me.bttGuardar.Enabled = Not activa
    End Sub
#End Region

#Region "ActivaDesactivaCampos"
    Private Sub ActivaDesactivaCampos(ByVal activa As Boolean)
        Me.txtCodigo.Properties.ReadOnly = IIf(activa, False, True)
        Me.txtCodigo.Properties.Buttons(0).Enabled = activa
        Me.txtNIF.Properties.ReadOnly = activa
        Me.txtNombreFiscal.Properties.ReadOnly = activa
        Me.txtDireccion.Properties.ReadOnly = activa
        Me.txtCodigoPostal.Properties.ReadOnly = activa
        Me.txtPoblacion.Properties.ReadOnly = activa
        Me.txtProvincia.Properties.ReadOnly = activa
        Me.txtTelefonos.Properties.ReadOnly = activa
        Me.txtMovil.Properties.ReadOnly = activa
        Me.checkTieneTarjeta.Properties.ReadOnly = activa
        Me.txtCaducidadTarjeta.Properties.ReadOnly = IIf(Me.checkTieneTarjeta.Checked, activa, True)
        Me.txtDescuentoTarjeta.Properties.ReadOnly = IIf(Me.checkTieneTarjeta.Checked, activa, True)
        Me.CheckControlBaja.Properties.ReadOnly = activa
        Me.gvPendientesCobro.OptionsBehavior.AllowAddRows = IIf(activa, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
        Me.gvPendientesCobro.OptionsBehavior.AllowDeleteRows = IIf(activa, DevExpress.Utils.DefaultBoolean.False, DevExpress.Utils.DefaultBoolean.True)
        Me.colCodigoCaja.OptionsColumn.ReadOnly = activa
        Me.colCodigoTienda.OptionsColumn.ReadOnly = activa
        Me.colCodigoTicket.OptionsColumn.ReadOnly = activa
        Me.colFecha.OptionsColumn.ReadOnly = activa
        Me.colImporteCobrado.OptionsColumn.ReadOnly = activa
        Me.colImporteTicket.OptionsColumn.ReadOnly = activa
        Me.txtEmail.Properties.ReadOnly = activa
        Me.txtObservaciones.Properties.ReadOnly = activa
        Me.txtClienteCredito.Properties.Buttons(0).Visible = Not activa
        Me.txtClienteCredito.Properties.Buttons(1).Visible = Not activa
    End Sub
#End Region

#Region "checkTieneTarjeta_CheckedChanged"
    Private Sub checkTieneTarjeta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkTieneTarjeta.CheckedChanged
        Me.txtCaducidadTarjeta.Properties.ReadOnly = IIf(Me.checkTieneTarjeta.Checked, False, True)
        Me.txtDescuentoTarjeta.Properties.ReadOnly = IIf(Me.checkTieneTarjeta.Checked, False, True)
    End Sub
#End Region

#Region "txtClienteCredito_ButtonClick"
    Private Sub txtClienteCredito_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtClienteCredito.ButtonClick
        Try
            Select Case e.Button.Tag

                Case "Buscar"
                    Try
                        Dim dsClientes As New dsClientes, tClientes As New dsClientesTableAdapters.CLICREDITableAdapter
                        Dim Columnas As New ArrayList

                        Columnas.Add("Codigo") 'Campo
                        Columnas.Add("Código") 'Encabezado
                        Columnas.Add(80) 'Tamaño columna
                        Columnas.Add(80) 'Tamaño máximo columna

                        Columnas.Add("NombreFiscal")
                        Columnas.Add("Nombre Fiscal")
                        Columnas.Add(0)
                        Columnas.Add(0)

                        Columnas.Add("Direccion")
                        Columnas.Add("Dirección")
                        Columnas.Add(0)
                        Columnas.Add(0)

                        Columnas.Add("NIF")
                        Columnas.Add("N.I.F.")
                        Columnas.Add(100)
                        Columnas.Add(100)

                        tClientes.Fill(dsClientes.CLICREDI)

                        If Buscar(dsClientes, "CLICREDI", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                            Me.txtClienteCredito.EditValue = ResultadoBusqueda
                        End If

                        Me.bttGuardar_Click(Me.bttGuardar, Nothing)

                    Catch ex As Exception
                        System.Windows.Forms.MessageBox.Show(ex.Message)
                    End Try

                Case "Nuevo"

                    Dim fClienteCredito As New fClienteCredito
                    If fClienteCredito.ShowDialog = Windows.Forms.DialogResult.OK Then
                        Me.txtClienteCredito.EditValue = fClienteCredito.CODCLI
                    End If

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "txtClienteCredito_OpenLink"
    Private Sub txtClienteCredito_OpenLink(sender As Object, e As DevExpress.XtraEditors.Controls.OpenLinkEventArgs) Handles txtClienteCredito.OpenLink
        Try
            If Me.txtClienteCredito.Text = String.Empty Then Exit Try

            Dim fClienteCredito As New fClienteCredito(Me.txtClienteCredito.EditValue)
            fClienteCredito.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "bttTarjeta_Click"
    Private Sub bttTarjeta_Click(sender As Object, e As EventArgs) Handles bttTarjeta.Click
        Try
            Dim fTarjeta As New DameCliente
            fTarjeta.ComprobarCodigo = False

            If Not fTarjeta.ShowDialog = Windows.Forms.DialogResult.OK Then Exit Try

            'Comprobar que no existe
            Dim dsCliente As New dsClientes
            Dim taCliente As New dsClientesTableAdapters.CLIENTESTableAdapter

            taCliente.DameCliente(dsCliente.CLIENTES, fTarjeta.CodigoCliente)

            If dsCliente.CLIENTES.Count > 0 Then
                With dsCliente.CLIENTES(0)
                    MsgBox("Ese código de tarjeta ya está asignado en el cliente " & vbCrLf & .Codigo & " - " & .NombreFiscal, MsgBoxStyle.Information, Me.Text)
                    Exit Try
                End With
            End If

            If MsgBox("¿Seguro que desea asignar el código de tarjeta " & fTarjeta.CodigoCliente & " al cliente " & Me.txtNombreFiscal.Text & "?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Try

            Me.CambiarCodigo(fTarjeta.CodigoCliente)

            Me.txtCodigo.EditValue = fTarjeta.CodigoCliente
            Me.txtCodigo.IsModified = True
            Me.txtCodigo_Validated(Me.txtCodigo, Nothing)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "CambiarCodigo"
    Private Sub CambiarCodigo(Codigo As Integer)

        If Me.DsClientes.CLIENTES.Count = 0 Then Exit Sub

        Dim conexion As New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        conexion.Open()
        Dim transaccion As SqlClient.SqlTransaction
        transaccion = conexion.BeginTransaction()

        Dim cmd As New SqlClient.SqlCommand

        Try
            Dim CodActual As Integer = Me.DsClientes.CLIENTES(0).Codigo

            cmd.Connection = conexion
            cmd.Transaction = transaccion

            cmd.CommandText = "UPDATE CLIENTES SET Codigo = " & Codigo & " WHERE Codigo=" & CodActual
            cmd.ExecuteNonQuery()

            cmd.CommandText = "UPDATE TICKETS SET CodigoCliente = " & Codigo & " WHERE CodigoCliente=" & CodActual
            cmd.ExecuteNonQuery()

            cmd.CommandText = "UPDATE HISTORICO_TICKETS SET CodigoCliente = " & Codigo & " WHERE CodigoCliente=" & CodActual
            cmd.ExecuteNonQuery()

            cmd.CommandText = "UPDATE HISTORICO_TICKETS_ANULADOS SET CodigoCliente = " & Codigo & " WHERE CodigoCliente=" & CodActual
            cmd.ExecuteNonQuery()

            cmd.CommandText = "UPDATE PENDIENTES_COBRO SET CodigoCliente = " & Codigo & " WHERE CodigoCliente=" & CodActual
            cmd.ExecuteNonQuery()

            transaccion.Commit()

        Catch ex As Exception
            transaccion.Rollback()
            Throw ex
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Sub
#End Region

End Class