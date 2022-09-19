Imports DevExpress.XtraPrinting

Public Class Informes

    Public Shared Function CabeceraInforme(ByVal Titulo As String, ByVal Filtros As Collections.ArrayList) As PageHeaderFooter
        Try
            Dim headerArea As DevExpress.XtraPrinting.PageHeaderArea = New DevExpress.XtraPrinting.PageHeaderArea
            Dim footerArea As DevExpress.XtraPrinting.PageFooterArea = New DevExpress.XtraPrinting.PageFooterArea

            footerArea.Font = New Font("Verdana", 8)
            headerArea.Font = New Font("Arial Black", 12)

            headerArea.Content.Add(Titulo)

            footerArea.Content.Add("Página [Page # of Pages #]")
            footerArea.Content.Add("[Date Printed] [Time Printed]")

            footerArea.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Near
            headerArea.LineAlignment = DevExpress.XtraPrinting.BrickAlignment.Center

            Dim headerfooter As DevExpress.XtraPrinting.PageHeaderFooter = New  _
            DevExpress.XtraPrinting.PageHeaderFooter(headerArea, footerArea)

            Return headerfooter

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Sub AbrirVistaPrevia(ByVal Titulo As String, ByVal Informe As PrintableComponentLink)

        Dim f As New PreImpreso

        Try
            f.Informe.PrintingSystem = Informe.PrintingSystem

            Informe.PrintingSystem.PreviewFormEx.PrintBarManager.AllowQuickCustomization = False
            Informe.PrintingSystem.PreviewFormEx.Text = Titulo

            f.ShowDialog()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

End Class
