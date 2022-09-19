Public Class PendientesCobro

#Region "PendientesCobro_FormClosing"
    Private Sub PendientesCobro_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Actualizar línea actual
        Me.gvPendientesCobro.UpdateCurrentRow()
        'comprobar si hay cambios sin guardar
        If Me.DsPendientesCobro.HasChanges Then
            If MsgBox("¿Desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "¿Guardar cambios?") = MsgBoxResult.Yes Then
                Me.PENDIENTESCOBROBindingSource.EndEdit()
                Me.PENDIENTES_COBROTableAdapter.Update(Me.DsPendientesCobro.PENDIENTES_COBRO)
            End If
        End If
    End Sub
#End Region

#Region "PendientesCobro_Load"
    Private Sub PendientesCobro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PENDIENTES_COBROTableAdapter.Fill(Me.DsPendientesCobro.PENDIENTES_COBRO)
        Me.gvPendientesCobro.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
    End Sub
#End Region

#Region "PendientesCobro_Shown"
    Private Sub PendientesCobro_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.maskImporte.Mask.EditMask = "c" & DecimalesImporte
        Me.gvPendientesCobro.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
        Me.gvPendientesCobro.FocusedColumn = Me.colCodigoCliente
    End Sub
#End Region

#Region "gvPendientesCobro_InitNewRow"
    Private Sub gvPendientesCobro_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvPendientesCobro.InitNewRow
        Dim UltimoCodigo As Integer, i As Integer
        For i = 0 To Me.DsPendientesCobro.PENDIENTES_COBRO.Rows.Count - 1
            If Me.DsPendientesCobro.PENDIENTES_COBRO.Rows(i).Item("CodigoCliente") > UltimoCodigo Then UltimoCodigo = Me.DsPendientesCobro.PENDIENTES_COBRO.Rows(i).Item("CodigoCliente")
        Next
        Me.gvPendientesCobro.SetRowCellValue(e.RowHandle, Me.colCodigoCliente, UltimoCodigo + 1)
    End Sub
#End Region

#Region "gvPendienteCobro_CellValueChanged"
    Private Sub gvPendienteCobro_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvPendientesCobro.CellValueChanged
        If Me.gvPendientesCobro.IsNewItemRow(e.RowHandle) And e.Column Is Me.colCodigoCliente Then
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT ISNULL(CodigoCliente,0) FROM PENDIENTE_COBRO WHERE CodigoCliente=" & Me.gvPendientesCobro.GetRowCellValue(e.RowHandle, Me.colCodigoCliente)
            If cmd.ExecuteScalar > 0 Then
                MsgBox("El código del cliente introducido ya existe", MsgBoxStyle.Information, "Ya existe")
                Me.gvPendientesCobro.CancelUpdateCurrentRow()
                Me.gvPendientesCobro.FocusedColumn = Me.colCodigoCliente
                Exit Sub
            End If
        End If
    End Sub
#End Region

#Region "gvVales_InvalidRowException"
    Private Sub gvVales_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvPendientesCobro.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
#End Region

#Region "gvPendienteCobro_ValidateRow"
    Private Sub gvPendienteCobro_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvPendientesCobro.ValidateRow
        'If MsgBox("¿Seguro que desea guardar los cambios realizados?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Guardar cambios") = MsgBoxResult.No Then
        '    e.Valid = False
        '    Exit Sub
        'End If
        'Comprobar datos
        If Me.gvPendientesCobro.GetRowCellValue(e.RowHandle, Me.colCodigoCliente) Is System.DBNull.Value Then
            MsgBox("Introduce el código del Cliente", MsgBoxStyle.Information, "Falta código de Cliente")
            Me.gvPendientesCobro.FocusedColumn = Me.colCodigoCliente
            e.Valid = False
            Exit Sub
        End If

    End Sub
#End Region

#Region "gvPendienteCobro_FocusedRowChanged"
    Private Sub gvPendienteCobro_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvPendientesCobro.FocusedRowChanged
        If Me.gvPendientesCobro.IsNewItemRow(e.FocusedRowHandle) Then
            Me.colCodigoCliente.OptionsColumn.ReadOnly = False
        Else
            Me.gvPendientesCobro.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
            Me.colCodigoCliente.OptionsColumn.ReadOnly = True
        End If
    End Sub
#End Region

#Region "NavListadoPendienteCobro_ButtonClick"
    Private Sub NavListadoPendienteCobro_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles NavListadoPendientesCobro.ButtonClick
        Select Case e.Button.ButtonType
            Case DevExpress.XtraEditors.NavigatorButtonType.NextPage
                Me.gvPendientesCobro.MoveNextPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.PrevPage
                Me.gvPendientesCobro.MovePrevPage()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.Remove
                If MsgBox("¿Seguro que desea eliminar el movimiento de caja seleccionado", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar movimiento de caja") = MsgBoxResult.No Then
                    e.Handled = True
                End If
            Case DevExpress.XtraEditors.NavigatorButtonType.EndEdit 'Guardar cambios
                Me.PENDIENTES_COBROTableAdapter.Update(Me.DsPendientesCobro.PENDIENTES_COBRO)
            Case DevExpress.XtraEditors.NavigatorButtonType.CancelEdit 'Cancelar cambios
                Me.DsPendientesCobro.RejectChanges()
        End Select
    End Sub
#End Region

End Class