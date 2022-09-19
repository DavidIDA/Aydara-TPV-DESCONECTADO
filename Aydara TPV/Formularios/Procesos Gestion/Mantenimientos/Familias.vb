Public Class Familias

#Region "Familias_FormClosing"
    Private Sub Familias_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.bttCancelar.Text = "Cancelar" And Me.DsArticulos.HasChanges Then
            If MsgBox("Está editando una familia. ¿Seguro que desea salir sin guardar los cambios?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.No Then e.Cancel = True Else Me.Dispose()
        Else
            'Me.Dispose()
        End If
    End Sub
#End Region

#Region "Familias_KeyUp"
    Private Sub Familias_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "Familias_Shown"
    Private Sub Familias_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.lblDescuentoTarjeta.Visible = GestionTarjetas
        Me.txtDescuentoTarjeta.Visible = GestionTarjetas
        Me.colDescuentoTarjeta.Visible = GestionTarjetas
    End Sub
#End Region

#Region "bttNuevo_Click"
    Private Sub bttNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttNuevo.Click
        Try
            Me.DsArticulos.FAMILIASARTICULOS.Clear()
            Me.DsArticulos.SUBFAMILIASARTICULOS.Clear()
            Me.FAMILIASARTICULOSBindingSource.AddNew()

            ActivaDesactivaMenu(False)
            Me.bttGuardar.Enabled = False
            Me.txtCodigo.Properties.ReadOnly = False
            Me.txtCodigo.Focus()

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
            Me.txtDescripcion.Focus()
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try

            Dim DsArticulos As New dsArticulos, tFamilias As New dsArticulosTableAdapters.FAMILIASARTICULOSTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("Descripcion")
            Columnas.Add("Descripción")
            Columnas.Add(0)
            Columnas.Add(0)

            tFamilias.Fill(DsArticulos.FAMILIASARTICULOS)

            If Buscar(DsArticulos, "FAMILIASARTICULOS", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
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
            If Me.gvSubfamilias.RowCount > 0 Then
                MsgBox("La familia tiene subfamilias asociadas." & vbCrLf & "Elimine las subfamilias para poder dar de baja la familia.", MsgBoxStyle.Information, "No se puede eliminar")
                Exit Sub
            End If
            If MsgBox("¿Seguro que desea eliminar la familia seleccionada?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar familia") = MsgBoxResult.Yes Then
                Me.FAMILIASARTICULOSBindingSource.RemoveCurrent()
                Me.FAMILIASARTICULOSTableAdapter.Update(Me.DsArticulos.FAMILIASARTICULOS)
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
            Me.FAMILIASARTICULOSBindingSource.CancelEdit()

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

            Me.FAMILIASARTICULOSBindingSource.EndEdit()
            Me.FAMILIASARTICULOSTableAdapter.Update(Me.DsArticulos.FAMILIASARTICULOS)

            'Guardar subfamilias
            Dim i As Integer
            For i = 0 To Me.gvSubfamilias.RowCount - 1
                Me.gvSubfamilias.SetRowCellValue(i, Me.colFamilia_Id, Me.DsArticulos.FAMILIASARTICULOS.Rows(0).Item("Id"))
                Me.gvSubfamilias.SetRowCellValue(i, Me.colCodigo, Me.gvSubfamilias.GetRowCellDisplayText(i, Me.colCodigo))
            Next
            Me.SUBFAMILIASARTICULOSBindingSource.EndEdit()
            Me.SUBFAMILIASARTICULOSTableAdapter.Update(Me.DsArticulos.SUBFAMILIASARTICULOS)

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

            If Not Me.txtCodigo.IsModified Or Me.txtCodigo.Text = String.Empty Then Exit Sub

            'Si es nuevo registro comprobar si existe el código de artículo
            If Me.bttCancelar.Text = "Cancelar" Then
                Dim cmd As New SqlClient.SqlCommand
                cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                cmd.Connection.Open()
                cmd.CommandText = "SELECT * FROM FAMILIASARTICULOS WHERE Codigo='" & Me.txtCodigo.Text & "'"
                If CType(cmd.ExecuteReader, SqlClient.SqlDataReader).HasRows Then
                    MsgBox("Ya existe una familia con ese código", MsgBoxStyle.Information, "Ya existe")
                    Me.txtCodigo.Text = String.Empty
                    Me.txtCodigo.Focus()
                Else
                    Me.bttGuardar.Enabled = True
                    ActivaDesactivaCampos(False)
                End If
                Exit Sub
            End If

            'Mostrar información de la familia
            Dim CodigoFamilia As String = Me.txtCodigo.Text
            Me.FAMILIASARTICULOSTableAdapter.DameFamilia(Me.DsArticulos.FAMILIASARTICULOS, CodigoFamilia)

            If Me.FAMILIASARTICULOSBindingSource.Count = 0 Then
                If MsgBox("No existe ninguna familia con ese código." & vbCrLf & "¿Desea dar de alta una nueva familia?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "No existe") = MsgBoxResult.Yes Then
                    Me.bttNuevo_Click(Nothing, Nothing)
                    Me.txtCodigo.Text = CodigoFamilia
                    Me.txtDescripcion.Focus()
                    Me.bttGuardar.Enabled = True
                    ActivaDesactivaCampos(False)
                Else
                    ActivaDesactivaMenu(True)
                    ActivaDesactivaCampos(True)
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
        Me.bttModificar.Enabled = IIf(Me.FAMILIASARTICULOSBindingSource.Count = 0, False, activa)
        Me.bttEliminar.Enabled = IIf(Me.FAMILIASARTICULOSBindingSource.Count = 0, False, activa)
        Me.bttCancelar.Text = IIf(activa, "Salir", "Cancelar")
        Me.bttGuardar.Enabled = Not activa
        'Datos subfamilias
        If Me.DsArticulos.FAMILIASARTICULOS.Rows.Count > 0 Then
            Me.SUBFAMILIASARTICULOSTableAdapter.Familia(Me.DsArticulos.SUBFAMILIASARTICULOS, Me.DsArticulos.FAMILIASARTICULOS.Rows(0).Item("Id"))
        Else
            Me.DsArticulos.SUBFAMILIASARTICULOS.Clear()
        End If
    End Sub
#End Region

#Region "ActivaDesactivaCampos"
    Private Sub ActivaDesactivaCampos(ByVal activa As Boolean)
        Me.txtCodigo.Properties.ReadOnly = Not activa
        Me.txtCodigo.Properties.Buttons(0).Enabled = activa
        Me.txtDescripcion.Properties.ReadOnly = activa
        Me.txtDescuentoTarjeta.Properties.ReadOnly = activa
        Me.txtEtiqueta.Properties.ReadOnly = activa
        Me.imgImagen.Properties.ReadOnly = activa
        Me.bttNuevaImagen.Enabled = Not activa
        Me.bttEliminarImagen.Enabled = Not activa
        Me.colDescripcion.OptionsColumn.ReadOnly = activa
        Me.checkTpvTactil.Properties.ReadOnly = activa
        Me.NavListadoSubfamilias.Buttons.Append.Enabled = Not activa
        Me.NavListadoSubfamilias.Buttons.Remove.Enabled = Not activa

        Me.txtCtaCompras.Properties.ReadOnly = activa
        Me.txtCtaVentas.Properties.ReadOnly = activa
    End Sub
#End Region

#Region "bttNuevaImagen_Click"
    Private Sub bttNuevaImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttNuevaImagen.Click
        Me.imgImagen.LoadImage()
        Me.txtEtiqueta.EditValue = Mid(Me.txtDescripcion.EditValue, 1, 10)
        Me.checkTpvTactil.Checked = True
    End Sub
#End Region

#Region "bttEliminarImagen_Click"
    Private Sub bttEliminarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttEliminarImagen.Click
        Me.imgImagen.EditValue = System.DBNull.Value
        Me.txtEtiqueta.EditValue = String.Empty
        Me.checkTpvTactil.Checked = False
    End Sub
#End Region

#Region "gvSubfamilias_InvalidRowException"
    Private Sub gvSubfamilias_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvSubfamilias.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
#End Region

#Region "gvSubfamilias_ValidateRow"
    Private Sub gvSubfamilias_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvSubfamilias.ValidateRow
        'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then
        '    e.Valid = False
        '    Exit Sub
        'End If
        'Comprobar datos
        Dim LineaActual As Integer = IIf(Me.gvSubfamilias.IsNewItemRow(e.RowHandle), Me.gvSubfamilias.RowCount - 1, e.RowHandle)
        Dim i As Integer
        For i = 0 To Me.gvSubfamilias.RowCount - 1
            If LineaActual <> i And Me.gvSubfamilias.GetRowCellDisplayText(e.RowHandle, Me.colCodigo) = Me.gvSubfamilias.GetRowCellDisplayText(i, Me.colCodigo) Then
                MsgBox("El código de la sufmalia seleccionada ya existe", MsgBoxStyle.Information, "Ya existe")
                Me.gvSubfamilias.CancelUpdateCurrentRow()
                Me.gvSubfamilias.FocusedColumn = Me.colCodigo
                'e.Valid = False
                Exit Sub
            End If
        Next
        If Me.gvSubfamilias.GetRowCellValue(e.RowHandle, Me.colCodigo) = String.Empty Then
            MsgBox("Introduce el código de la subfamilia", MsgBoxStyle.Information, "Falta código de subfamilia")
            Me.gvSubfamilias.FocusedColumn = Me.colCodigo
            e.Valid = False
            Exit Sub
        End If
        If Len(Me.gvSubfamilias.GetRowCellValue(e.RowHandle, Me.colCodigo)) > 15 Then
            MsgBox("El código de la subfamilia no puede tener más de 15 caracteres", MsgBoxStyle.Information, "Atención")
            Me.gvSubfamilias.FocusedColumn = Me.colCodigo
            e.Valid = False
            Exit Sub
        End If
        If Len(Me.gvSubfamilias.GetRowCellValue(e.RowHandle, Me.colDescripcion)) > 50 Then
            MsgBox("La descripción no puede tener más de 50 caracteres", MsgBoxStyle.Information, "Atención")
            Me.gvSubfamilias.FocusedColumn = Me.colDescripcion
            e.Valid = False
            Exit Sub
        End If
    End Sub
#End Region

#Region "gvSubfamilias_FocusedRowChanged"
    Private Sub gvSubfamilias_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvSubfamilias.FocusedRowChanged
        If Me.gvSubfamilias.IsNewItemRow(e.FocusedRowHandle) Then
            Me.colCodigo.OptionsColumn.ReadOnly = False
        Else
            Me.gvSubfamilias.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            Me.colCodigo.OptionsColumn.ReadOnly = True
        End If
    End Sub
#End Region

#Region "NavListadoSubfamilias_ButtonClick"
    Private Sub NavListadoSubfamilias_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles NavListadoSubfamilias.ButtonClick
        Select Case e.Button.ButtonType
            Case DevExpress.XtraEditors.NavigatorButtonType.NextPage
                Me.gvSubfamilias.MoveNextPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.PrevPage
                Me.gvSubfamilias.MovePrevPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.Append
                Me.gvSubfamilias.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                Me.gvSubfamilias.MoveLastVisible()
                Me.gvSubfamilias.Focus()
                Me.gvSubfamilias.FocusedColumn = Me.colCodigo
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.Remove
                If MsgBox("¿Seguro que desea eliminar la subfamilia seleccionada?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar subfamilia") = MsgBoxResult.No Then
                    e.Handled = True
                End If
        End Select
    End Sub
#End Region

End Class