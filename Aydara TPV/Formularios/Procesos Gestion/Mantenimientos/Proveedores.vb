Public Class Proveedores

#Region "Proveedores_FormClosing"
    Private Sub Proveedores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bttCancelar.Text = "Cancelar" And Me.DsProveedores.HasChanges Then
            If MsgBox("Está editando un proveedor. ¿Seguro que desea salir sin guardar los cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = True Else Me.Dispose()
        Else
            'Me.Dispose()
        End If
    End Sub
#End Region

#Region "Proveedores_KeyUp"
    Private Sub Proveedores_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "bttNuevo_Click"
    Private Sub bttNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttNuevo.Click
        Try
            Me.DsProveedores.PROVEEDORES.Clear()
            Me.PROVEEDORESBindingSource.AddNew()

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT Isnull(Max(Codigo),0) FROM Proveedores"
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

            Dim dsProveedores As New dsProveedores, tProveedores As New dsProveedoresTableAdapters.PROVEEDORESTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("Nombre")
            Columnas.Add("Nombre Fiscal")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("Direccion")
            Columnas.Add("Dirección")
            Columnas.Add(0)
            Columnas.Add(0)

            tProveedores.Fill(dsProveedores.PROVEEDORES)

            If Buscar(dsProveedores, "Proveedores", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
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
            If MsgBox("¿Seguro que desea eliminar el proveedor seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar proveedor") = MsgBoxResult.Yes Then
                Me.PROVEEDORESBindingSource.RemoveCurrent()
                Me.PROVEEDORESTableAdapter.Update(Me.DsProveedores.PROVEEDORES)
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
            Me.PROVEEDORESBindingSource.CancelEdit()

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
            Me.PROVEEDORESBindingSource.EndEdit()
            Me.PROVEEDORESTableAdapter.Update(Me.DsProveedores.PROVEEDORES)

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

            Dim CodigoProveedor As Integer = Me.txtCodigo.Text
            Me.PROVEEDORESTableAdapter.DameProveedor(Me.DsProveedores.PROVEEDORES, CodigoProveedor)

            If Me.PROVEEDORESBindingSource.Count = 0 Then
                If MsgBox("No existe ningún proveedor con ese código." & vbCrLf & "¿Desea dar de alta un nuevo proveedor?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "No existe") = MsgBoxResult.Yes Then
                    Me.bttNuevo_Click(Nothing, Nothing)
                    Me.txtCodigo.Text = CodigoProveedor
                    Me.txtNombreFiscal.Focus()
                    Me.bttGuardar.Enabled = True
                    ActivaDesactivaCampos(False)
                Else
                    Me.DsProveedores.PROVEEDORES.Clear()
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
        Me.bttModificar.Enabled = IIf(Me.PROVEEDORESBindingSource.Count = 0, False, activa)
        Me.bttEliminar.Enabled = IIf(Me.PROVEEDORESBindingSource.Count = 0, False, activa)
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
        Me.txtFax.Properties.ReadOnly = activa
        Me.txtPersonaContacto.Properties.ReadOnly = activa
    End Sub
#End Region

End Class