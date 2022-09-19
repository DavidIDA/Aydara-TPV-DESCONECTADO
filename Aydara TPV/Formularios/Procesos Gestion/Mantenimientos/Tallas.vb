Public Class Tallas

#Region "Tallas_FormClosing"
    Private Sub Tallas_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Actualizar línea actual
        Me.gvTallas.UpdateCurrentRow()
        'comprobar si hay cambios sin guardar
        If Me.DsArticulos.HasChanges Then
            If MsgBox("¿Desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "¿Guardar cambios?") = MsgBoxResult.Yes Then
                Me.TALLASBindingSource.EndEdit()
                Me.TALLASTableAdapter.Update(Me.DsArticulos.TALLAS)
            End If
        End If
    End Sub
#End Region

#Region "Tallas_KeyUp"
    Private Sub Tallas_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "Tallas_Load"
    Private Sub Tallas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TALLASTableAdapter.Fill(Me.DsArticulos.TALLAS)
        Me.gvTallas.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
    End Sub
#End Region

#Region "Tallas_Shown"
    Private Sub Tallas_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.gvTallas.MoveLastVisible()
    End Sub
#End Region

#Region "gvTallas_InitNewRow"
    Private Sub gvTallas_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvTallas.InitNewRow
        Dim UltimoCodigo As Integer, i As Integer
        For i = 0 To Me.DsArticulos.TALLAS.Rows.Count - 1
            If Me.DsArticulos.TALLAS.Rows(i).Item("CodigoTalla") > UltimoCodigo Then UltimoCodigo = Me.DsArticulos.TALLAS.Rows(i).Item("CodigoTalla")
        Next
        Me.gvTallas.SetRowCellValue(e.RowHandle, Me.colCodigoTalla, UltimoCodigo + 1)
    End Sub
#End Region

#Region "gvTallas_CellValueChanged"
    Private Sub gvTallas_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvTallas.CellValueChanged
        If Me.gvTallas.IsNewItemRow(e.RowHandle) And e.Column Is Me.colCodigoTalla Then
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT ISNULL(CodigoTalla,0) FROM TALLAS WHERE CodigoTalla=" & Me.gvTallas.GetRowCellValue(e.RowHandle, Me.colCodigoTalla)
            If cmd.ExecuteScalar > 0 Then
                MsgBox("El código de la talla introducido ya existe", MsgBoxStyle.Information, "Ya existe")
                Me.gvTallas.CancelUpdateCurrentRow()
                Me.gvTallas.FocusedColumn = Me.colCodigoTalla
                Exit Sub
            End If
        End If
    End Sub
#End Region

#Region "gvTallas_DoubleClick"
    Private Sub gvTallas_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvTallas.DoubleClick
        If Me.gvTallas.GetRow(Me.gvTallas.FocusedRowHandle) Is Nothing Then Exit Sub
        Select Case Me.Tag
            Case "Artículos"
                Articulos.DsArticulos.ARTICULOS.Rows(0).Item("CodigoTalla") = Me.gvTallas.GetRowCellValue(Me.gvTallas.FocusedRowHandle, Me.colCodigoTalla)
                Me.Tag = String.Empty
                Me.Close()
        End Select
    End Sub
#End Region

#Region "gvTallas_InvalidRowException"
    Private Sub gvTallas_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvTallas.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
#End Region

#Region "gvTallas_ValidateRow"
    Private Sub gvTallas_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvTallas.ValidateRow
        'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then
        '    e.Valid = False
        '    Exit Sub
        'End If
        'Comprobar datos
        If Me.gvTallas.GetRowCellValue(e.RowHandle, Me.colCodigoTalla) Is System.DBNull.Value Then
            MsgBox("Introduce el código de la talla", MsgBoxStyle.Information, "Falta código de talla")
            Me.gvTallas.FocusedColumn = Me.colCodigoTalla
            e.Valid = False
            Exit Sub
        End If

        Dim i As Integer
        For i = 1 To 17 'Nº de columnas
            If Len(Me.gvTallas.GetRowCellValue(e.RowHandle, Me.gvTallas.Columns(i))) > 4 Then
                MsgBox("La descripción de las tallas no pueden tener más de 4 caracteres", MsgBoxStyle.Information, "Atención")
                Me.gvTallas.FocusedColumn = Me.gvTallas.Columns(i)
                e.Valid = False
                Exit Sub
            End If
        Next
    End Sub
#End Region

#Region "gvTallas_FocusedRowChanged"
    Private Sub gvTallas_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvTallas.FocusedRowChanged
        Me.gvTallas.OptionsBehavior.Editable = (e.FocusedRowHandle <> 0)
        Me.NavListadoTallas.Buttons.Remove.Enabled = (e.FocusedRowHandle <> 0)
        If Me.gvTallas.IsNewItemRow(e.FocusedRowHandle) And e.FocusedRowHandle <> 0 Then
            Me.colCodigoTalla.OptionsColumn.ReadOnly = False
        Else
            Me.gvTallas.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            Me.colCodigoTalla.OptionsColumn.ReadOnly = True
        End If
    End Sub
#End Region

#Region "NavListadoTallas_ButtonClick"
    Private Sub NavListadoTallas_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles NavListadoTallas.ButtonClick
        Select Case e.Button.ButtonType
            Case DevExpress.XtraEditors.NavigatorButtonType.NextPage
                Me.gvTallas.MoveNextPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.PrevPage
                Me.gvTallas.MovePrevPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.Append
                Me.gvTallas.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                Me.gvTallas.Focus()
                Me.gvTallas.FocusedColumn = Me.colCodigoTalla
            Case DevExpress.XtraEditors.NavigatorButtonType.Remove
                If MsgBox("¿Seguro que desea eliminar la talla seleccionada?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar talla") = MsgBoxResult.No Then
                    e.Handled = True
                End If
            Case DevExpress.XtraEditors.NavigatorButtonType.EndEdit 'Guardar cambios
                Me.TALLASTableAdapter.Update(Me.DsArticulos.TALLAS)
            Case DevExpress.XtraEditors.NavigatorButtonType.CancelEdit 'Cancelar cambios
                Me.DsArticulos.RejectChanges()
        End Select
    End Sub
#End Region

End Class