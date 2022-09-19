Public Class Empleados

#Region "Empleados_FormClosing"
    Private Sub Empleados_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bttCancelar.Text = "Cancelar" And Me.DsEmpleados.HasChanges Then
            If MsgBox("Está editando un empleado. ¿Seguro que desea salir sin guardar los cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = True Else Me.Dispose()
        Else
            'Me.Dispose()
        End If
    End Sub
#End Region

#Region "Empleados_KeyUp"
    Private Sub Empleados_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "bttNuevo_Click"
    Private Sub bttNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttNuevo.Click
        Try
            Me.DsEmpleados.OPERARIOS.Clear()
            Me.EMPLEADOSBindingSource.AddNew()

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT Isnull(Max(Codigo),0) FROM OPERARIOS"
            Me.txtCodigo.Text = cmd.ExecuteScalar + 1

            ActivaDesactivaMenu(False)
            ActivaDesactivaCampos(False)
            Me.txtNombre.Focus()

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
            Me.txtNombre.Focus()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try

            Dim dsEmpleados As New dsEmpleados, tEmpleados As New dsEmpleadosTableAdapters.OPERARIOSTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("Nombre")
            Columnas.Add("Nombre")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("Direccion")
            Columnas.Add("Dirección")
            Columnas.Add(0)
            Columnas.Add(0)

            tEmpleados.Fill(dsEmpleados.OPERARIOS)

            If Buscar(dsEmpleados, "Operarios", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
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
            If MsgBox("¿Seguro que desea eliminar el empleado seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar empleado") = MsgBoxResult.Yes Then
                Me.EMPLEADOSBindingSource.RemoveCurrent()
                Me.EMPLEADOSTableAdapter.Update(Me.DsEmpleados.OPERARIOS)
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
            Me.EMPLEADOSBindingSource.CancelEdit()

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
            Me.EMPLEADOSBindingSource.EndEdit()
            Me.EMPLEADOSTableAdapter.Update(Me.DsEmpleados.OPERARIOS)

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

            If Not Me.txtCodigo.IsModified Then Exit Sub

            Dim CodigoEmpleado As Integer = Me.txtCodigo.Text
            Me.EMPLEADOSTableAdapter.DameEmpleado(Me.DsEmpleados.OPERARIOS, CodigoEmpleado)

            If Me.EMPLEADOSBindingSource.Count = 0 Then
                If MsgBox("No existe ningún empleado con ese código." & vbCrLf & "¿Desea dar de alta un nuevo empleado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "No existe") = MsgBoxResult.Yes Then
                    Me.bttNuevo_Click(Nothing, Nothing)
                    Me.txtCodigo.Text = CodigoEmpleado
                    Me.txtNombre.Focus()
                    Me.bttGuardar.Enabled = True
                    ActivaDesactivaCampos(False)
                Else
                    Me.DsEmpleados.OPERARIOS.Clear()
                    ActivaDesactivaMenu(True)
                    Me.txtCodigo.Focus()
                End If
            Else
                ActivaDesactivaMenu(True)
                ActivaDesactivaCampos(True)
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
        Me.bttModificar.Enabled = IIf(Me.EMPLEADOSBindingSource.Count = 0, False, activa)
        Me.bttEliminar.Enabled = IIf(Me.EMPLEADOSBindingSource.Count = 0, False, activa)
        Me.bttCancelar.Text = IIf(activa, "Salir", "Cancelar")
        Me.bttGuardar.Enabled = IIf(activa, False, True)
    End Sub
#End Region

#Region "ActivaDesactivaCampos"
    Private Sub ActivaDesactivaCampos(ByVal activa As Boolean)
        Me.txtCodigo.Properties.ReadOnly = IIf(activa, False, True)
        Me.txtCodigo.Properties.Buttons(0).Enabled = activa
        Me.txtNombre.Properties.ReadOnly = activa
        Me.txtDireccion.Properties.ReadOnly = activa
        Me.txtPoblacion.Properties.ReadOnly = activa
        Me.txtTelefonos.Properties.ReadOnly = activa
        Me.txtNombreTicket.Properties.ReadOnly = activa
    End Sub
#End Region

#Region "txtNombre_Validated"
    Private Sub txtNombre_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombre.Validated
        If Me.txtNombre.IsModified And Me.txtNombreTicket.Text = String.Empty Then
            Me.txtNombreTicket.Text = Mid(Me.txtNombre.Text, 1, 20)
        End If
    End Sub
#End Region

End Class