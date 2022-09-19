Public Class TiposIncidencia

#Region "TiposIncidencia_FormClosing"
    Private Sub TiposIncidencia_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Actualizar línea actual
        Me.gvTiposIncidencia.UpdateCurrentRow()
        'comprobar si hay cambios sin guardar
        If Me.DsIncidenciasTipos.HasChanges Then
            If MsgBox("¿Desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "¿Guardar cambios?") = MsgBoxResult.Yes Then
                Me.INCIDENCIASTIPOSBindingSource.EndEdit()
                Me.INCIDENCIAS_TIPOSTableAdapter.Update(Me.DsIncidenciasTipos.INCIDENCIAS_TIPOS)
            End If
        End If
    End Sub
#End Region

#Region "TiposUnidades_KeyUp"
    Private Sub TiposUnidades_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "TiposUnidades_Load"
    Private Sub TiposUnidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.INCIDENCIAS_TIPOSTableAdapter.Fill(Me.DsIncidenciasTipos.INCIDENCIAS_TIPOS)
        Me.gvTiposIncidencia.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
    End Sub
#End Region

#Region "gvTiposIncidencia_CellValueChanged"
    Private Sub gvTiposIncidencia_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvTiposIncidencia.CellValueChanged

        If Me.gvTiposIncidencia.IsNewItemRow(e.RowHandle) And e.Column Is Me.colCodigo Then

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

            Try
                cmd.Connection.Open()
                cmd.CommandText = "SELECT COUNT(*) FROM INCIDENCIAS_TIPOS WHERE IDTipo = " & e.Value

                If CInt(cmd.ExecuteScalar) > 0 Then
                    MsgBox("El código introducido ya existe", MsgBoxStyle.Information, "Ya existe")
                    Me.gvTiposIncidencia.CancelUpdateCurrentRow()
                    Me.gvTiposIncidencia.FocusedColumn = Me.colCodigo
                    Exit Sub
                End If

            Catch ex As Exception
                MsgBox("Error al comprobar si existe código", MsgBoxStyle.Exclamation)
            Finally
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End Try

        End If

    End Sub
#End Region

#Region "gvTiposIncidencia_InvalidRowException"
    Private Sub gvTiposIncidencia_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvTiposIncidencia.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
#End Region

#Region "gvTiposIncidencia_ValidateRow"
    Private Sub gvTiposIncidencia_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvTiposIncidencia.ValidateRow
        'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then
        '    e.Valid = False
        '    Exit Sub
        'End If
        'Comprobar datos
        If Me.gvTiposIncidencia.GetRowCellValue(e.RowHandle, Me.colCodigo) Is System.DBNull.Value Then
            MsgBox("Introduce el código", MsgBoxStyle.Information, "Falta código")
            Me.gvTiposIncidencia.FocusedColumn = Me.colCodigo
            e.Valid = False
            Exit Sub
        End If
    End Sub
#End Region

#Region "gvTiposIncidencia_FocusedRowChanged"
    Private Sub gvTiposIncidencia_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvTiposIncidencia.FocusedRowChanged
        If Me.gvTiposIncidencia.IsNewItemRow(e.FocusedRowHandle) Then
            Me.colCodigo.OptionsColumn.ReadOnly = False
        Else
            Me.gvTiposIncidencia.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            Me.colCodigo.OptionsColumn.ReadOnly = True
        End If
    End Sub
#End Region

#Region "NavListadoTiposIncidencia_ButtonClick"
    Private Sub NavListadoTiposIncidencia_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles NavListadoTiposIncidencia.ButtonClick
        Select Case e.Button.ButtonType
            Case DevExpress.XtraEditors.NavigatorButtonType.NextPage
                Me.gvTiposIncidencia.MoveNextPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.PrevPage
                Me.gvTiposIncidencia.MovePrevPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.Append
                Me.gvTiposIncidencia.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                Me.gvTiposIncidencia.Focus()
                Me.gvTiposIncidencia.FocusedColumn = Me.colCodigo
            Case DevExpress.XtraEditors.NavigatorButtonType.Remove
                If MsgBox("¿Seguro que desea eliminar el tipo seleccionado", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar color") = MsgBoxResult.No Then
                    e.Handled = True
                End If
            Case DevExpress.XtraEditors.NavigatorButtonType.EndEdit 'Guardar cambios
                Me.INCIDENCIAS_TIPOSTableAdapter.Update(Me.DsIncidenciasTipos.INCIDENCIAS_TIPOS)
            Case DevExpress.XtraEditors.NavigatorButtonType.CancelEdit 'Cancelar cambios
                Me.DsIncidenciasTipos.RejectChanges()
        End Select
    End Sub
#End Region

End Class