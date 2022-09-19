Public Class Sorteos

#Region "Sorteos_FormClosing"
    Private Sub Sorteos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            Me.SORTEOSBindingSource.EndEdit()

            If Me.DsSorteos.HasChanges Then
                If MsgBox("¿Desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) Then
                    Me.SORTEOSTableAdapter.Update(Me.DsSorteos.SORTEOS)
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al guardar los cambios." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "Sorteos_KeyUp"
    Private Sub Sorteos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "Sorteos_Load"
    Private Sub Sorteos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.SORTEOSTableAdapter.Fill(Me.DsSorteos.SORTEOS)
            If Me.SORTEOSBindingSource.Count = 0 Then Me.SORTEOSBindingSource.AddNew()

            Me.ActivaDesactivaCampos(False)
            Me.txtFechaInicio.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "Sorteos_Shown"
    Private Sub Sorteos_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.txtFraccion.Properties.Mask.EditMask = "c" & DecimalesImporte
        Me.txtParticipacion.Properties.Mask.EditMask = "c" & DecimalesImporte
    End Sub
#End Region

#Region "ActivaDesactivaMenu"
    Private Sub ActivaDesactivaMenu(ByVal activa As Boolean)
        Me.bttNuevo.Enabled = activa
        Me.bttBuscar.Enabled = activa
        Me.bttModificar.Enabled = IIf(Me.SORTEOSBindingSource.Count = 0, False, activa)
        Me.bttEliminar.Enabled = IIf(Me.SORTEOSBindingSource.Count = 0, False, activa)
        Me.bttCancelar.Text = IIf(activa, "Salir", "Cancelar")
        Me.bttGuardar.Enabled = Not activa
    End Sub
#End Region

#Region "ActivaDesactivaCampos"
    Private Sub ActivaDesactivaCampos(ByVal activa As Boolean)
        Me.txtFechaInicio.Properties.ReadOnly = activa
        Me.txtFechaFin.Properties.ReadOnly = activa
        Me.txtFechaSorteo.Properties.ReadOnly = activa
        Me.rgTipoSorteo.Properties.ReadOnly = activa
        Me.txtNumero.Properties.ReadOnly = activa
        Me.txtDepositadoEn.Properties.ReadOnly = activa
        Me.checkSoloTarjetas.Properties.ReadOnly = activa
        Me.checkAplicaPromociones.Properties.ReadOnly = activa
        Me.txtFraccion.Properties.ReadOnly = activa
        Me.txtParticipacion.Properties.ReadOnly = activa
    End Sub
#End Region

#Region "bttNuevo_Click"
    Private Sub bttNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttNuevo.Click
        Try
            Me.DsSorteos.Clear()
            Me.SORTEOSBindingSource.AddNew()

            Me.ActivaDesactivaMenu(False)
            Me.ActivaDesactivaCampos(False)
            Me.txtFechaInicio.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttModificar_Click"
    Private Sub bttModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttModificar.Click
        Try
            Me.ActivaDesactivaMenu(False)
            Me.ActivaDesactivaCampos(False)
            Me.txtFechaInicio.Focus()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try

            Dim dsSorteos As New dsSorteos, tSorteos As New dsSorteosTableAdapters.SORTEOSTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Id") 'Campo
            Columnas.Add("Id") 'Encabezado
            Columnas.Add(0) 'Tamaño columna
            Columnas.Add(0) 'Tamaño máximo columna

            Columnas.Add("FechaInicio")
            Columnas.Add("Fecha inicio")
            Columnas.Add(100)
            Columnas.Add(100)

            Columnas.Add("FechaFin")
            Columnas.Add("Fecha fin")
            Columnas.Add(100)
            Columnas.Add(100)

            Columnas.Add("FechaSorteo")
            Columnas.Add("Fecha sorteo")
            Columnas.Add(100)
            Columnas.Add(100)

            tSorteos.Fill(dsSorteos.SORTEOS)

            If Buscar(dsSorteos, "SORTEOS", Columnas, 1, True).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.DatosSorteo(ResultadoBusqueda)
                Me.ActivaDesactivaMenu(True)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttEliminar_Click"
    Private Sub bttEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEliminar.Click
        Try
            If MsgBox("¿Seguro que desea eliminar el sorteo seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar sorteo") = MsgBoxResult.Yes Then
                Me.SORTEOSBindingSource.RemoveCurrent()
                Me.SORTEOSTableAdapter.Update(Me.DsSorteos.SORTEOS)
                Me.Close()
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
            Me.SORTEOSBindingSource.CancelEdit()

            Me.ActivaDesactivaMenu(True)
            Me.ActivaDesactivaCampos(True)

            Me.txtFechaInicio.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttGuardar_Click"
    Private Sub bttGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttGuardar.Click
        Try
            If Not IsDate(Me.txtFechaInicio.EditValue) Or Not IsDate(Me.txtFechaFin.EditValue) Then
                MsgBox("Indique las fechas de activación", MsgBoxStyle.Information)
                Me.txtFechaInicio.Focus()
                Exit Try
            End If

            If Me.rgTipoSorteo.EditValue = 0 And (Me.txtNumero.EditValue = 0 Or Not IsDate(Me.txtFechaSorteo.EditValue)) Then
                MsgBox("Indique fecha y nº de lotería", MsgBoxStyle.Information)
                Me.txtNumero.Focus()
                Exit Try
            End If

            'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then Exit Sub
            Me.SORTEOSBindingSource.EndEdit()
            Me.SORTEOSTableAdapter.Update(Me.DsSorteos.SORTEOS)

            Me.txtFechaInicio.Focus()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "rgTipoSorteo_SelectedIndexChanged"
    Private Sub rgTipoSorteo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rgTipoSorteo.SelectedIndexChanged
        Me.panelLoteria.Visible = (Me.rgTipoSorteo.EditValue = 0)
        Me.checkAplicaPromociones.Visible = Not (Me.rgTipoSorteo.EditValue = 0)
    End Sub
#End Region

#Region "DatosSorteo"
    Private Sub DatosSorteo(ByVal IdSorteo As Integer)

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT * FROM SORTEOS WHERE Id=" & IdSorteo

            Me.DsSorteos.SORTEOS.Load(cmd.ExecuteReader)

        Catch ex As Exception
            MsgBox("Error al cargar datos del sorteo", MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

End Class