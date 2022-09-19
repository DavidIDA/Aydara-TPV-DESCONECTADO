Public Class Colores

#Region "Colores_FormClosing"
    Private Sub Colores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Actualizar línea actual
        Me.gvColores.UpdateCurrentRow()
        'comprobar si hay cambios sin guardar
        If Me.DsArticulos.HasChanges Then
            If MsgBox("¿Desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "¿Guardar cambios?") = MsgBoxResult.Yes Then
                Me.COLORESBindingSource.EndEdit()
                Me.COLORESTableAdapter.Update(Me.DsArticulos.COLORES)
            End If
        End If
    End Sub
#End Region

#Region "Colores_KeyUp"
    Private Sub Colores_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "Colores_Load"
    Private Sub Colores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.COLORESTableAdapter.Fill(Me.DsArticulos.COLORES)
        Me.gvColores.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
    End Sub
#End Region

#Region "Colores_Shown"
    Private Sub Colores_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.gvColores.MoveLastVisible()
    End Sub
#End Region

#Region "gvColores_InitNewRow"
    Private Sub gvColores_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvColores.InitNewRow
        Dim UltimoCodigo As Integer, i As Integer
        For i = 0 To Me.DsArticulos.COLORES.Rows.Count - 1
            If Me.DsArticulos.COLORES.Rows(i).Item("CodigoColor") > UltimoCodigo Then UltimoCodigo = Me.DsArticulos.COLORES.Rows(i).Item("CodigoColor")
        Next
        Me.gvColores.SetRowCellValue(e.RowHandle, Me.colCodigoColor, UltimoCodigo + 1)
    End Sub
#End Region

#Region "gvColores_CellValueChanged"
    Private Sub gvColores_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvColores.CellValueChanged
        If Me.gvColores.IsNewItemRow(e.RowHandle) And e.Column Is Me.colCodigoColor Then
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT ISNULL(CodigoColor,0) FROM Colores WHERE CodigoColor=" & Me.gvColores.GetRowCellValue(e.RowHandle, Me.colCodigoColor)
            If cmd.ExecuteScalar > 0 Then
                MsgBox("El código del color introducido ya existe", MsgBoxStyle.Information, "Ya existe")
                Me.gvColores.CancelUpdateCurrentRow()
                Me.gvColores.FocusedColumn = Me.colCodigoColor
                Exit Sub
            End If
        End If
    End Sub
#End Region

#Region "gvColores_InvalidRowException"
    Private Sub gvColores_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvColores.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
#End Region

#Region "gvColores_ValidateRow"
    Private Sub gvColores_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvColores.ValidateRow
        'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then
        '    e.Valid = False
        '    Exit Sub
        'End If
        'Comprobar datos
        If Me.gvColores.GetRowCellValue(e.RowHandle, Me.colCodigoColor) Is System.DBNull.Value Then
            MsgBox("Introduce el código del color", MsgBoxStyle.Information, "Falta código de color")
            Me.gvColores.FocusedColumn = Me.colCodigoColor
            e.Valid = False
            Exit Sub
        End If
        If Len(Me.gvColores.GetRowCellValue(e.RowHandle, Me.colDescripcion)) > 10 Then
            MsgBox("La descripción del color no puede tener más de 10 caracteres", MsgBoxStyle.Information, "Atención")
            Me.gvColores.FocusedColumn = Me.colDescripcion
            e.Valid = False
            Exit Sub
        End If
    End Sub
#End Region

#Region "gvColores_FocusedRowChanged"
    Private Sub gvColores_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvColores.FocusedRowChanged
        Me.gvColores.OptionsBehavior.Editable = (e.FocusedRowHandle <> 0)
        Me.NavListadoColores.Buttons.Remove.Enabled = (e.FocusedRowHandle <> 0)
        If Me.gvColores.IsNewItemRow(e.FocusedRowHandle) Then
            Me.colCodigoColor.OptionsColumn.ReadOnly = False
        Else
            Me.gvColores.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            Me.colCodigoColor.OptionsColumn.ReadOnly = True
        End If
    End Sub
#End Region

#Region "NavListadoColores_ButtonClick"
    Private Sub NavListadoColores_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles NavListadoColores.ButtonClick
        Select Case e.Button.ButtonType
            Case DevExpress.XtraEditors.NavigatorButtonType.NextPage
                Me.gvColores.MoveNextPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.PrevPage
                Me.gvColores.MovePrevPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.Append
                Me.gvColores.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                Me.gvColores.Focus()
                Me.gvColores.FocusedColumn = Me.colCodigoColor
            Case DevExpress.XtraEditors.NavigatorButtonType.Remove
                If MsgBox("¿Seguro que desea eliminar el color seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar color") = MsgBoxResult.No Then
                    e.Handled = True
                End If
            Case DevExpress.XtraEditors.NavigatorButtonType.EndEdit 'Guardar cambios
                Me.COLORESTableAdapter.Update(Me.DsArticulos.COLORES)
            Case DevExpress.XtraEditors.NavigatorButtonType.CancelEdit 'Cancelar cambios
                Me.DsArticulos.RejectChanges()
        End Select
    End Sub
#End Region

End Class