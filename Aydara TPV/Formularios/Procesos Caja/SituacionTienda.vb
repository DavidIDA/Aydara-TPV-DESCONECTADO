Public Class SituacionTienda 

#Region "SituacionTienda_Load"
    Private Sub SituacionTienda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Me.DsTiendas.SITUACION.Merge(General.SituacionTienda.SITUACION)
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region "SituacionTienda_Shown"
    Private Sub SituacionTienda_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en importe
        Me.maskImporte.Mask.EditMask = "c" & DecimalesImporte
    End Sub
#End Region

#Region "SituacionTienda_KeyUp"
    Private Sub SituacionTienda_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "bttImprimir_Click"
    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click
        Try
            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PaperKind = Printing.PaperKind.A4
            Informe.PageHeaderFooter = Informes.CabeceraInforme("Situación tienda", Nothing)

            Informe.Component = Me.dgSituacion

            Informe.PrintingSystem = ps

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia("Situación tienda", Informe)

            Me.Close()

        Catch ex As Exception
            MsgBox("Error al generar el informe", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCancelar.Click
        Me.Close()
    End Sub
#End Region

End Class