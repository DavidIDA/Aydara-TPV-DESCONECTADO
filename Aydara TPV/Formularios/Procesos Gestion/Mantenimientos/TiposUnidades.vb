Public Class TiposUnidades

#Region "TiposUnidades_FormClosing"
    Private Sub TiposUnidades_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Actualizar línea actual
        Me.gvTiposUnidades.UpdateCurrentRow()
        'comprobar si hay cambios sin guardar
        If Me.DsArticulos.HasChanges Then
            If MsgBox("¿Desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "¿Guardar cambios?") = MsgBoxResult.Yes Then
                Me.TiposUnidadesBindingSource.EndEdit()
                Me.TIPOS_UNIDADESTableAdapter.Update(Me.DsArticulos.TIPOS_UNIDADES)
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
        Me.TIPOS_UNIDADESTableAdapter.Fill(Me.DsArticulos.TIPOS_UNIDADES)
        Me.gvTiposUnidades.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
    End Sub
#End Region

#Region "gvTiposUnidades_CellValueChanged"
    Private Sub gvTiposUnidades_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvTiposUnidades.CellValueChanged

        If Me.gvTiposUnidades.IsNewItemRow(e.RowHandle) And e.Column Is Me.colCodigo Then

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

            Try
                cmd.Connection.Open()
                cmd.CommandText = "SELECT COUNT(*) FROM TIPOS_UNIDADES WHERE Codigo='" & e.Value & "'"

                If CInt(cmd.ExecuteScalar) > 0 Then
                    MsgBox("El código introducido ya existe", MsgBoxStyle.Information, "Ya existe")
                    Me.gvTiposUnidades.CancelUpdateCurrentRow()
                    Me.gvTiposUnidades.FocusedColumn = Me.colCodigo
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

#Region "gvTiposUnidades_InvalidRowException"
    Private Sub gvTiposUnidades_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvTiposUnidades.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
#End Region

#Region "gvTiposUnidades_ValidateRow"
    Private Sub gvTiposUnidades_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvTiposUnidades.ValidateRow
        'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then
        '    e.Valid = False
        '    Exit Sub
        'End If
        'Comprobar datos
        If Me.gvTiposUnidades.GetRowCellValue(e.RowHandle, Me.colCodigo) Is System.DBNull.Value Then
            MsgBox("Introduce el código", MsgBoxStyle.Information, "Falta código")
            Me.gvTiposUnidades.FocusedColumn = Me.colCodigo
            e.Valid = False
            Exit Sub
        End If
    End Sub
#End Region

#Region "gvTiposUnidades_FocusedRowChanged"
    Private Sub gvTiposUnidades_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvTiposUnidades.FocusedRowChanged
        If Me.gvTiposUnidades.IsNewItemRow(e.FocusedRowHandle) Then
            Me.colCodigo.OptionsColumn.ReadOnly = False
        Else
            Me.gvTiposUnidades.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            Me.colCodigo.OptionsColumn.ReadOnly = True
        End If
    End Sub
#End Region

#Region "NavListadoTiposUnidades_ButtonClick"
    Private Sub NavListadoTiposUnidades_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles NavListadoTiposUnidades.ButtonClick
        Select Case e.Button.ButtonType
            Case DevExpress.XtraEditors.NavigatorButtonType.NextPage
                Me.gvTiposUnidades.MoveNextPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.PrevPage
                Me.gvTiposUnidades.MovePrevPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.Append
                Me.gvTiposUnidades.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                Me.gvTiposUnidades.Focus()
                Me.gvTiposUnidades.FocusedColumn = Me.colCodigo
            Case DevExpress.XtraEditors.NavigatorButtonType.Remove
                If MsgBox("¿Seguro que desea eliminar el tipo seleccionado", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar color") = MsgBoxResult.No Then
                    e.Handled = True
                End If
            Case DevExpress.XtraEditors.NavigatorButtonType.EndEdit 'Guardar cambios
                Me.TIPOS_UNIDADESTableAdapter.Update(Me.DsArticulos.TIPOS_UNIDADES)
            Case DevExpress.XtraEditors.NavigatorButtonType.CancelEdit 'Cancelar cambios
                Me.DsArticulos.RejectChanges()
        End Select
    End Sub
#End Region

End Class