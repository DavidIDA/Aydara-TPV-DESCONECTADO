Public Class ValesTienda 

#Region "ValesTienda_KeyUp"
    Private Sub ValesTienda_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "ValesTienda_Load"
    Private Sub ValesTienda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.VALES_TIENDATableAdapter.Fill(Me.DsValesTienda.VALES_TIENDA)
        Me.gvValesTienda.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
    End Sub
#End Region

    Private Sub ValesTienda_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.gvValesTienda.CloseEditor()
        Me.gvValesTienda.UpdateCurrentRow()
    End Sub

#Region "ValesTienda_Shown"
    Private Sub ValesTienda_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.maskImporte.Mask.EditMask = "c" & DecimalesImporte
        Me.gvValesTienda.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
        Me.gvValesTienda.FocusedColumn = Me.colNombre
    End Sub
#End Region

#Region "bttNuevo_Click"
    Private Sub bttNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttNuevo.Click
        Me.VALESTIENDABindingSource.AddNew()
        Me.gvValesTienda.Focus()
        Me.gvValesTienda.FocusedColumn = Me.colCodigoTienda
    End Sub
#End Region

#Region "bttEliminar_Click"
    Private Sub bttEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttEliminar.Click
        If MsgBox("¿Seguro que desea eliminar el vale seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar vale") = MsgBoxResult.Yes Then
            Me.VALESTIENDABindingSource.RemoveCurrent()
            Me.VALES_TIENDATableAdapter.Update(Me.DsValesTienda.VALES_TIENDA)
        End If
    End Sub
#End Region

#Region "gvValesTienda_InvalidRowException"
    Private Sub gvValesTienda_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvValesTienda.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
#End Region

#Region "gvValesTienda_ValidateRow"
    Private Sub gvValesTienda_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvValesTienda.ValidateRow
        Try
            If Me.gvValesTienda.GetRowCellValue(e.RowHandle, Me.colCodigoTienda) Is System.DBNull.Value Then
                MsgBox("Introduce el Código de la Tienda", MsgBoxStyle.Information, "Falta Código de Tienda")
                Me.gvValesTienda.FocusedColumn = Me.colCodigoTienda
                e.Valid = False
                Exit Sub
            End If

            If Me.gvValesTienda.GetRowCellValue(e.RowHandle, Me.colCodigoVale) Is System.DBNull.Value Then
                MsgBox("Introduce el Código de Vale", MsgBoxStyle.Information, "Falta Código Vale")
                Me.gvValesTienda.FocusedColumn = Me.colCodigoVale
                e.Valid = False
                Exit Sub
            End If

            If Me.gvValesTienda.IsNewItemRow(e.RowHandle) Then
                Dim cmd As New SqlClient.SqlCommand
                cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                cmd.Connection.Open()
                cmd.CommandText = "SELECT * FROM VALES_TIENDA WHERE CodigoVale=" & Me.gvValesTienda.GetRowCellValue(e.RowHandle, Me.colCodigoVale) & "AND CodigoTienda=" & Me.gvValesTienda.GetRowCellValue(e.RowHandle, Me.colCodigoTienda) & ""
                If CType(cmd.ExecuteReader, SqlClient.SqlDataReader).HasRows Then
                    MsgBox("El código de Vale introducido ya existe para la Tienda Introducida", MsgBoxStyle.Information, "Ya existe")
                    Me.gvValesTienda.FocusedColumn = Me.colCodigoVale
                    e.Valid = False
                    Exit Sub
                End If
            End If

            If Len(Me.gvValesTienda.GetRowCellValue(e.RowHandle, Me.colNombre)) > 40 Then
                MsgBox("No puedes introducir un texto tan largo", MsgBoxStyle.Information, "Demasiado Texto")
                Me.gvValesTienda.FocusedColumn = Me.colNombre
                e.Valid = False
                Exit Sub
            End If

            If Len(Me.gvValesTienda.GetRowCellValue(e.RowHandle, Me.colConcepto)) > 40 Then
                MsgBox("No puedes introducir un texto tan largo", MsgBoxStyle.Information, "Demasiado Texto")
                Me.gvValesTienda.FocusedColumn = Me.colConcepto
                e.Valid = False
                Exit Sub
            End If

            'Guardar cambios
            Me.VALESTIENDABindingSource.EndEdit()
            Me.VALES_TIENDATableAdapter.Update(Me.DsValesTienda.VALES_TIENDA)

        Catch ex As Exception
            MsgBox("Error al guardar los cambios", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

End Class