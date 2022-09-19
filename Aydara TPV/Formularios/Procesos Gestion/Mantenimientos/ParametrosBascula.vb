Public Class ParametrosBascula

#Region "ParametrosBascula_FormClosing"
    Private Sub ParametrosBascula_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Actualizar línea actual
        Me.gvParametrosBascula.UpdateCurrentRow()
        'comprobar si hay cambios sin guardar
        If Me.DsTiendas.HasChanges Then
            If MsgBox("¿Desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "¿Guardar cambios?") = MsgBoxResult.Yes Then
                'Me.ParametrosBasculaBindingSource.EndEdit()
                Me.PARAMETROS_BASCULATableAdapter.Update(Me.DsTiendas.PARAMETROS_BASCULA)
            End If
        End If
    End Sub
#End Region

#Region "ParametrosBascula_KeyUp"
    Private Sub ParametrosBascula_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "ParametrosBascula_Load"
    Private Sub ParametrosBascula_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PARAMETROS_BASCULATableAdapter.Fill(Me.DsTiendas.PARAMETROS_BASCULA)
        Me.gvParametrosBascula.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
    End Sub
#End Region

#Region "gvParametrosBascula_CellValueChanged"
    Private Sub gvParametrosBascula_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvParametrosBascula.CellValueChanged

        If Me.gvParametrosBascula.IsNewItemRow(e.RowHandle) And e.Column Is Me.colPrefijo Then

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

            Try
                cmd.Connection.Open()
                cmd.CommandText = "SELECT COUNT(*) FROM PARAMETROS_BASCULA WHERE Prefijo='" & e.Value & "'"

                If CInt(cmd.ExecuteScalar) > 0 Then
                    MsgBox("El prefijo introducido ya existe", MsgBoxStyle.Information, "Ya existe")
                    Me.gvParametrosBascula.CancelUpdateCurrentRow()
                    Me.gvParametrosBascula.FocusedColumn = Me.colPrefijo
                    Exit Try
                End If

            Catch ex As Exception
                MsgBox("Error al comprobar si existe prefijo báscula", MsgBoxStyle.Exclamation)
            Finally
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End Try

        Else

            If Not e.Value Is System.DBNull.Value Then
                If e.Value = 0 Then
                    Me.gvParametrosBascula.SetFocusedRowCellValue(e.Column, System.DBNull.Value)
                End If
            End If

        End If

    End Sub
#End Region

#Region "gvParametrosBascula_InvalidRowException"
    Private Sub gvParametrosBascula_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvParametrosBascula.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
#End Region

#Region "gvParametrosBascula_ValidateRow"
    Private Sub gvParametrosBascula_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvParametrosBascula.ValidateRow
        'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then
        '    e.Valid = False
        '    Exit Sub
        'End If

        'Comprobar datos
        Try

            'Prefijo
            If Not IsNumeric(Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPrefijo)) Then
                MsgBox("Introduce el prefijo", MsgBoxStyle.Information, "Falta prefijo")
                Me.gvParametrosBascula.FocusedColumn = Me.colPrefijo
                e.Valid = False
                Exit Try
            End If

            'Artículo
            If Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosInicial_Articulo) Is System.DBNull.Value Or Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosFinal_Articulo) Is System.DBNull.Value Then
                MsgBox("Introduce las posiciones del código de artículo", MsgBoxStyle.Information)
                Me.gvParametrosBascula.FocusedColumn = Me.colPosInicial_Articulo
                e.Valid = False
                Exit Try
            End If

            'Peso
            If Not Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosInicial_Peso) Is System.DBNull.Value Then
                If Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosInicial_Peso) <= Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosFinal_Articulo) Then
                    MsgBox("La posición inicial del peso debe ser superior a la posición final del artículo", MsgBoxStyle.Information)
                    Me.gvParametrosBascula.FocusedColumn = Me.colPosInicial_Peso
                    e.Valid = False
                    Exit Try
                End If
                If Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosFinal_Peso) Is System.DBNull.Value Then
                    MsgBox("Introduce la posición final del peso", MsgBoxStyle.Information)
                    Me.gvParametrosBascula.FocusedColumn = Me.colPosFinal_Peso
                    e.Valid = False
                    Exit Try
                End If
            End If
            If Not Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosFinal_Peso) Is System.DBNull.Value Then
                If Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosInicial_Peso) Is System.DBNull.Value Then
                    MsgBox("Introduce la posición inicial del peso", MsgBoxStyle.Information)
                    Me.gvParametrosBascula.FocusedColumn = Me.colPosInicial_Peso
                    e.Valid = False
                    Exit Try
                End If
                If Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosFinal_Peso) <= Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosInicial_Peso) Then
                    MsgBox("La posición final del peso debe ser superior a su posición inicial", MsgBoxStyle.Information)
                    Me.gvParametrosBascula.FocusedColumn = Me.colPosFinal_Peso
                    e.Valid = False
                    Exit Try
                End If
            End If

            'Importe
            If Not Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosInicial_Importe) Is System.DBNull.Value Then
                If Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosInicial_Importe) <= Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosFinal_Articulo) Then
                    MsgBox("La posición inicial del importe debe ser superior a la posición final del artículo", MsgBoxStyle.Information)
                    Me.gvParametrosBascula.FocusedColumn = Me.colPosInicial_Importe
                    e.Valid = False
                    Exit Try
                End If
                If Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosFinal_Importe) Is System.DBNull.Value Then
                    MsgBox("Introduce la posición final del importe", MsgBoxStyle.Information)
                    Me.gvParametrosBascula.FocusedColumn = Me.colPosFinal_Importe
                    e.Valid = False
                    Exit Try
                End If
            End If
            If Not Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosInicial_Importe) Is System.DBNull.Value And Not Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosFinal_Peso) Is System.DBNull.Value Then
                If Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosInicial_Importe) <= Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosFinal_Peso) Then
                    MsgBox("La posición inicial del importe debe ser superior a la posición final del peso", MsgBoxStyle.Information)
                    Me.gvParametrosBascula.FocusedColumn = Me.colPosInicial_Importe
                    e.Valid = False
                    Exit Try
                End If
            End If
            If Not Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosFinal_Importe) Is System.DBNull.Value Then
                If Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosInicial_Importe) Is System.DBNull.Value Then
                    MsgBox("Introduce la posición inicial del importe", MsgBoxStyle.Information)
                    Me.gvParametrosBascula.FocusedColumn = Me.colPosInicial_Importe
                    e.Valid = False
                    Exit Try
                End If
                If Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosFinal_Importe) <= Me.gvParametrosBascula.GetRowCellValue(e.RowHandle, Me.colPosInicial_Importe) Then
                    MsgBox("La posición final del importe debe ser superior a su posición inicial", MsgBoxStyle.Information)
                    Me.gvParametrosBascula.FocusedColumn = Me.colPosFinal_Importe
                    e.Valid = False
                    Exit Try
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al comprobar los datos", MsgBoxStyle.Exclamation)
        End Try

    End Sub
#End Region

#Region "gvParametrosBascula_FocusedRowChanged"
    Private Sub gvParametrosBascula_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        If Me.gvParametrosBascula.IsNewItemRow(e.FocusedRowHandle) Then
            Me.colPrefijo.OptionsColumn.ReadOnly = False
        Else
            Me.gvParametrosBascula.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            Me.colPrefijo.OptionsColumn.ReadOnly = True
        End If
    End Sub
#End Region

#Region "NavListadoParametrosBascula_ButtonClick"
    Private Sub NavListadoParametrosBascula_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles NavListadoParametrosBascula.ButtonClick
        Select Case e.Button.ButtonType
            Case DevExpress.XtraEditors.NavigatorButtonType.NextPage
                Me.gvParametrosBascula.MoveNextPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.PrevPage
                Me.gvParametrosBascula.MovePrevPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.Append
                Me.gvParametrosBascula.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                Me.gvParametrosBascula.Focus()
                Me.gvParametrosBascula.FocusedColumn = Me.colPrefijo
            Case DevExpress.XtraEditors.NavigatorButtonType.Remove
                If MsgBox("¿Seguro que desea eliminar el prefijo seleccionado", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar color") = MsgBoxResult.No Then
                    e.Handled = True
                End If
            Case DevExpress.XtraEditors.NavigatorButtonType.EndEdit 'Guardar cambios
                Me.PARAMETROS_BASCULATableAdapter.Update(Me.DsTiendas.PARAMETROS_BASCULA)
            Case DevExpress.XtraEditors.NavigatorButtonType.CancelEdit 'Cancelar cambios
                Me.DsTiendas.RejectChanges()
        End Select
    End Sub
#End Region

End Class