Public Class FicheroVales

#Region "ListadoVales_FormClosing"
    Private Sub ListadoVales_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Me.Dispose()
    End Sub
#End Region

#Region "ListadoVales_KeyUp"
    Private Sub ListadoVales_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "ListadoVales_Load"
    Private Sub ListadoVales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.VALES_TIENDATableAdapter.Listado(Me.DsValesTienda.VALES_TIENDA)

    End Sub
#End Region

#Region "ListadoVales_Shown"
    Private Sub ListadoVales_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.gvVales.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
        Me.gvVales.FocusedColumn = Me.colCodigoVale
    End Sub
#End Region

#Region "gvVales_CellValueChanged"
    Private Sub gvVales_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvVales.CellValueChanged
        If Me.gvVales.IsNewItemRow(e.RowHandle) And e.Column Is Me.colCodigoVale Then
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT ISNULL(CodigoVale,0) FROM VALES_TIENDA WHERE CodigoVale=" & Me.gvVales.GetRowCellValue(e.RowHandle, Me.colCodigoVale)
            If cmd.ExecuteScalar > 0 Then
                MsgBox("El código del vale introducido ya existe", MsgBoxStyle.Information, "Ya existe")
                Me.gvVales.CancelUpdateCurrentRow()
                Me.gvVales.FocusedColumn = Me.colCodigoVale
                Exit Sub
            End If
        End If
    End Sub
#End Region

#Region "NavValesTienda_ButtonClick"
    Private Sub NavValesTienda_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles NavValesTienda.ButtonClick
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Custom Then

            Me.gvVales.CloseEditor()
            Me.gvVales.UpdateCurrentRow()

            ResultadoBusqueda = String.Empty

            Dim i As Integer
            For i = 0 To Me.gvVales.RowCount - 1
                If Me.gvVales.GetRowCellValue(i, Me.colSeleccionado) Then
                    If ResultadoBusqueda <> String.Empty Then ResultadoBusqueda &= "+"
                    ResultadoBusqueda &= Me.gvVales.GetRowCellValue(i, Me.colCodigoTienda) & "+" & Me.gvVales.GetRowCellValue(i, Me.colCodigoVale) & "+" & Me.gvVales.GetRowCellValue(i, Me.colImporte)
                End If
            Next

            If ResultadoBusqueda <> String.Empty Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If

        End If
    End Sub
#End Region

#Region "dgVales_MouseDoubleClick"
    Private Sub dgVales_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgVales.MouseDoubleClick

        If Me.gvVales.GetFocusedRow Is Nothing Then Exit Sub

        ResultadoBusqueda = Me.gvVales.GetFocusedRowCellValue(Me.colCodigoTienda) & "+" & Me.gvVales.GetFocusedRowCellValue(Me.colCodigoVale) & "+" & Me.gvVales.GetFocusedRowCellValue(Me.colImporte)

        If ResultadoBusqueda <> String.Empty Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

    End Sub
#End Region

End Class