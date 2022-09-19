Public Class Busqueda

#Region "Busqueda_KeyUp"
    Private Sub Busqueda_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.Enter

                    Dim Teclado As Process
                    Dim Teclados As Process() = Process.GetProcessesByName("osk") 'creates an array with all running processes with the same name

                    For Each Teclado In Teclados
                        Teclado.Kill()
                    Next

                Case Keys.Escape
                    Me.DialogResult = Windows.Forms.DialogResult.Abort

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "Busqueda_FormClosing"
    Private Sub Busqueda_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Me.Dispose()
    End Sub
#End Region

#Region "Busqueda_Shown"
    Private Sub Busqueda_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Try
            Me.gvBusqueda.ClearColumnsFilter()
            Me.gvBusqueda.FindFilterText = String.Empty

            If Me.gvBusqueda.IsFindPanelVisible Then
                Dim find As DevExpress.XtraGrid.Controls.FindControl = TryCast(Me.gvBusqueda.GridControl.Controls.Find("FindControl", True)(0), DevExpress.XtraGrid.Controls.FindControl)
                find.FindEdit.Focus()
            Else
                Me.gvBusqueda.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
            End If

            'Me.bttNuevo.Visible = (Me.dgBusqueda.DataMember = "CLIENTES")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "gvBusqueda_KeyUp"
    Private Sub gvBusqueda_KeyUp(sender As Object, e As KeyEventArgs) Handles gvBusqueda.KeyUp
        If e.KeyCode = Keys.Enter Then Me.dgBusqueda_MouseDoubleClick(Nothing, Nothing)
    End Sub
#End Region

#Region "dgBusqueda_MouseDoubleClick"
    Private Sub dgBusqueda_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgBusqueda.MouseDoubleClick
        Try
            If Me.gvBusqueda.GetRow(Me.gvBusqueda.FocusedRowHandle) Is Nothing Then Exit Sub
            ResultadoBusqueda = Me.gvBusqueda.GetRowCellValue(Me.gvBusqueda.FocusedRowHandle, Me.gvBusqueda.Columns(0))
            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Try
    End Sub
#End Region

#Region "bttImprimir_Click"
    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click
        Try
            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PaperKind = Printing.PaperKind.A4
            Informe.PageHeaderFooter = Me.Text 'Informes.CabeceraInforme(Me.txtTituloListado.EditValue, Nothing)

            Informe.Component = Me.dgBusqueda

            Informe.PrintingSystem = ps

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia(Me.Text, Informe)

            Me.DialogResult = Windows.Forms.DialogResult.Abort

        Catch ex As Exception
            MsgBox("Error al generar el informe", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "bttSeleccionar_Click"
    Private Sub bttSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttSeleccionar.Click
        Me.dgBusqueda_MouseDoubleClick(Nothing, Nothing)
    End Sub
#End Region

#Region "bttTeclado_Click"
    Private Sub bttTeclado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttTeclado.Click
        Try
            System.Diagnostics.Process.Start("osk.exe")
            Me.dgBusqueda.Focus()

            If Me.gvBusqueda.IsFindPanelVisible Then
                Dim find As DevExpress.XtraGrid.Controls.FindControl = TryCast(Me.gvBusqueda.GridControl.Controls.Find("FindControl", True)(0), DevExpress.XtraGrid.Controls.FindControl)
                find.FindEdit.Focus()
            Else
                Me.gvBusqueda.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "bttSalir_Click"
    Private Sub bttSalir_Click(sender As Object, e As EventArgs) Handles bttSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "bttNuevo_Click"
    Private Sub bttNuevo_Click(sender As Object, e As EventArgs) Handles bttNuevo.Click
        Try
            Dim fCliente As New fDatosCliente
            fCliente.Nuevo = True
            Me.DialogResult = fCliente.ShowDialog

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

End Class