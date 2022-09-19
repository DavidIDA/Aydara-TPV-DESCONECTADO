Public Class PropiedadesControl

    Private Sub PropiedadesControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            With DirectCast(Me.PropertyGridControl.SelectedObject, DevExpress.XtraGrid.Views.Grid.GridView)
                For i As Integer = 0 To .VisibleColumns.Count - 1

                    Me.cmbColumnas.Properties.Items.Add(.VisibleColumns(i))

                Next
            End With

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub bttDefault_Click(sender As Object, e As EventArgs) Handles bttDefault.Click
        Try
            DirectCast(Me.PropertyGridControl.SelectedObject, DevExpress.XtraGrid.Views.Grid.GridView).RestoreLayoutFromRegistry(Me.PropertyGridControl.Tag)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmbColumnas_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbColumnas.ButtonClick
        Me.cmbColumnas.EditValue = DBNull.Value
    End Sub

    Private Sub cmbColumnas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColumnas.SelectedIndexChanged
        If Not Me.cmbColumnas.EditValue Is Nothing Then
            Me.PropertyGridControl.SelectedObject = Me.cmbColumnas.EditValue
            Me.PropertyGridControl.RetrieveFields()
        End If
        Me.bttDefault.Enabled = IsDBNull(Me.cmbColumnas.EditValue)
    End Sub

End Class