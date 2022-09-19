Public Class Cajas

#Region "Articulos_FormClosing"
    Private Sub Cajas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bttCancelar.Text = "Cancelar" And Me.DsCajas.HasChanges Then
            If MsgBox("Está editando una caja. ¿Seguro que desea salir sin guardar los cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = True Else Me.Dispose()
        Else
            'Me.Dispose()
        End If
    End Sub
#End Region

#Region "Cajas_KeyUp"
    Private Sub Cajas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "Cajas_Load"
    Private Sub Cajas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.DsCajas.CAJAS.CodigoTiendaColumn.DefaultValue = CodigoTienda
    End Sub
#End Region

#Region "Cajas_Shown"
    Private Sub Cajas_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtTopeEfectivoCaja.Properties.Mask.EditMask = "c" & DecimalesPrecio
    End Sub
#End Region

#Region "bttNuevo_Click"
    Private Sub bttNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttNuevo.Click

        Dim cmd As New SqlClient.SqlCommand

        Try
            Me.DsCajas.CAJAS.Clear()
            Me.CAJASBindingSource.AddNew()

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT Isnull(Max(CodigoCaja),0) FROM CAJAS"

            Me.txtCodigoCaja.Text = cmd.ExecuteScalar + 1

            Me.ActivaDesactivaMenu(False)
            Me.ActivaDesactivaCampos(False)
            Me.txtCodigoCaja.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "bttModificar_Click"
    Private Sub bttModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttModificar.Click
        Try
            ActivaDesactivaMenu(False)
            ActivaDesactivaCampos(False)
            Me.txtCodigoCaja.Focus()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try

            Dim dsCajas As New dsCajas, tCajas As New dsCajasTableAdapters.CAJASTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("CodigoCaja") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(0) 'Tamaño columna
            Columnas.Add(0) 'Tamaño máximo columna

            Columnas.Add("NumeroTicket") 'Campo
            Columnas.Add("Contador Ticket") 'Encabezado
            Columnas.Add(0) 'Tamaño columna
            Columnas.Add(0) 'Tamaño máximo columna

            Columnas.Add("CajaCerrada") 'Campo
            Columnas.Add("Cerrada") 'Encabezado
            Columnas.Add(0) 'Tamaño columna
            Columnas.Add(0) 'Tamaño máximo columna

            tCajas.Tienda(dsCajas.CAJAS, CodigoTienda)

            If Buscar(dsCajas, "CAJAS", Columnas, 0).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoCaja.Text = ResultadoBusqueda
                Me.txtCodigoCaja.IsModified = True
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
            If MsgBox("¿Seguro que desea eliminar la Caja seleccionada?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar Caja") = MsgBoxResult.Yes Then
                Me.CAJASBindingSource.RemoveCurrent()
                Me.CAJASTableAdapter.Update(Me.DsCajas.CAJAS)
                ActivaDesactivaMenu(True)
                Me.txtCodigoCaja.Focus()
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
            Me.CAJASBindingSource.CancelEdit()

            ActivaDesactivaMenu(True)
            ActivaDesactivaCampos(True)

            Me.txtCodigoCaja.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttGuardar_Click"
    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click
        Try
            'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then Exit Sub

            Me.CAJASBindingSource.EndEdit()

            Me.DsCajas.CAJAS.Rows(0).Item("ImprimeTicket") = Me.cmbImprimeTicket.SelectedIndex

            Me.CAJASTableAdapter.Update(Me.DsCajas.CAJAS)

            ActivaDesactivaMenu(True)
            ActivaDesactivaCampos(True)

            Me.txtCodigoCaja.Focus()

            'Actualizar parámetros de la tienda si se ha modificado la que tiene seleccionada
            If Me.txtCodigoCaja.Text = CodigoCaja Then DatosCajaActual(CodigoCaja)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigo_Validated"
    Private Sub txtCodigo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCaja.Validated
        Try
            If Not Me.txtCodigoCaja.IsModified Then Exit Sub

            If Not IsNumeric(Me.txtCodigoCaja.Text) Then
                Me.txtCodigoCaja.Text = String.Empty
                MsgBox("No puedes introducir letras en este código.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Solo Números")
                Me.txtCodigoCaja.Focus()
                Exit Sub
            End If

            Dim CodigoCaja As Integer = Me.txtCodigoCaja.Text
            Me.CAJASTableAdapter.DameCaja(Me.DsCajas.CAJAS, CodigoCaja)

            If Me.CAJASBindingSource.Count = 0 Then
                If MsgBox("No existe ninguna caja con ese código." & vbCrLf & "¿Desea dar de alta una nueva caja?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "No existe") = MsgBoxResult.Yes Then
                    Me.bttNuevo_Click(Nothing, Nothing)
                    Me.txtCodigoCaja.Text = CodigoCaja
                    Me.txtNumeroTicket.Focus()
                    Me.bttGuardar.Enabled = True
                    ActivaDesactivaCampos(False)
                Else
                    Me.DsCajas.CAJAS.Clear()
                    ActivaDesactivaMenu(True)
                    Me.txtCodigoCaja.Focus()
                End If
            Else
                ActivaDesactivaMenu(True)
                ActivaDesactivaCampos(True)
                Me.txtCodigoCaja.Focus()
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoCaja_ButtonClick"
    Private Sub txtCodigoCaja_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoCaja.ButtonClick
        Me.bttBuscar_Click(Nothing, Nothing)
    End Sub
#End Region

#Region "ActivaDesactivaMenu"
    Private Sub ActivaDesactivaMenu(ByVal activa As Boolean)
        Me.bttNuevo.Enabled = activa
        Me.bttBuscar.Enabled = activa
        Me.bttModificar.Enabled = IIf(Me.CAJASBindingSource.Count = 0, False, activa)
        Me.bttEliminar.Enabled = IIf(Me.CAJASBindingSource.Count = 0, False, activa)
        Me.bttCancelar.Text = IIf(activa, "Salir", "Cancelar")
        Me.bttGuardar.Enabled = IIf(activa, False, True)

        If Me.DsCajas.CAJAS.Rows.Count > 0 Then
            Me.cmbImprimeTicket.SelectedIndex = Me.DsCajas.CAJAS.Rows(0).Item("ImprimeTicket")
        Else
            Me.cmbImprimeTicket.SelectedIndex = 0
        End If
    End Sub
#End Region

#Region "ActivaDesactivaCampos"
    Private Sub ActivaDesactivaCampos(ByVal activa As Boolean)
        'Me.txtCodigoCaja.Properties.ReadOnly = IIf(activa, True, False)
        'Me.txtCodigoCaja.Properties.Buttons(0).Enabled = activa
        Me.checkCajaCerrada.Properties.ReadOnly = activa
        Me.txtNumeroTicket.Properties.ReadOnly = activa
        Me.txtTopeEfectivoCaja.Properties.ReadOnly = activa
        Me.cmbImprimeTicket.Properties.ReadOnly = activa
        Me.checkAperturaCajon.Properties.ReadOnly = activa
        Me.checkCorteTicket.Properties.ReadOnly = activa
        Me.checkVisor.Properties.ReadOnly = activa
        Me.txtAbreCajon.Properties.ReadOnly = activa
        Me.txtCorteTicket.Properties.ReadOnly = activa
        Me.txtActivaVisor.Properties.ReadOnly = activa
        Me.txtDesactivaVisor.Properties.ReadOnly = activa
        Me.txtActivaExpandido.Properties.ReadOnly = activa
        Me.txtDesactivaExpandido.Properties.ReadOnly = activa
    End Sub
#End Region

End Class