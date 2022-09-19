Imports DevExpress.XtraPrinting

Public Class Informes

    Public Shared Function CabeceraInforme(ByVal Titulo As String, ByVal Filtros As ArrayList) As PageHeaderFooter
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

            Dim headerfooter As DevExpress.XtraPrinting.PageHeaderFooter = New _
            DevExpress.XtraPrinting.PageHeaderFooter(headerArea, footerArea)

            Return headerfooter

        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Shared Sub AbrirVistaPrevia(ByVal Titulo As String, ByVal Informe As PrintableComponentLink)

        Dim f As New PreImpreso
        f.Informe.PrintingSystem = Informe.PrintingSystem

        Informe.PrintingSystem.PreviewFormEx.PrintBarManager.AllowQuickCustomization = False
        Informe.PrintingSystem.PreviewFormEx.Text = Titulo
        Informe.PrintingSystem.PreviewFormEx.MdiParent = Principal

        General.AbrirFormulario(f, Titulo)

    End Sub

    Public Shared Sub TotalesTicket(Factura As dsInfFactura)
        Try
            If Factura.TICKETS.Count = 0 Then Exit Try

            'Recargo cliente
            Dim PorcentajeDescuento As Decimal = 0
            Dim TieneRecargo As Boolean = False

            With Factura.TICKETS(0)
                PorcentajeDescuento = .PorcentajeDescuento
                TieneRecargo = (.TotalRecargo <> 0)
            End With

            'Recargo equivalencia líneas
            If TieneRecargo
                For i As Integer = 0 To Factura.TICKETS_LINEAS.Count - 1
                    With Factura.TICKETS_LINEAS(i)

                        Select Case .PorcentajeIVA
                            Case TipoIva1
                                .PorcentajeRecargo = TipoRecargo1
                            Case TipoIva2
                                .PorcentajeRecargo = TipoRecargo2
                            Case TipoIva3
                                .PorcentajeRecargo = TipoRecargo3
                            Case TipoIva4
                                .PorcentajeRecargo = TipoRecargo4
                        End Select

                    End With
                Next
            End If

            'Totales ticket
            Dim rTotales As dsInfFactura.TOTALESRow = Factura.TOTALES.NewTOTALESRow
            Dim Lineas As DataRow()

            With rTotales

                If Factura.TICKETS_LINEAS.Select("PorcentajeIVA = " & CDbl(DatosTienda.TipoIva1)).Length > 0 Then .PorIva1 = DatosTienda.TipoIva1 : .Base1 = 0
                If Factura.TICKETS_LINEAS.Select("PorcentajeIVA = " & CDbl(DatosTienda.TipoIva2)).Length > 0 Then .PorIva2 = DatosTienda.TipoIva2 : .Base2 = 0
                If Factura.TICKETS_LINEAS.Select("PorcentajeIVA = " & CDbl(DatosTienda.TipoIva3)).Length > 0 Then .PorIva3 = DatosTienda.TipoIva3 : .Base3 = 0
                If Factura.TICKETS_LINEAS.Select("PorcentajeIVA = " & CDbl(DatosTienda.TipoIva4)).Length > 0 Then .PorIva4 = DatosTienda.TipoIva4 : .Base4 = 0

                If Not .IsPorIva1Null Then
                    Lineas = Factura.TICKETS_LINEAS.Select("PorcentajeIVA = " & CDbl(.PorIva1))
                    For i As Integer = 0 To Lineas.Length - 1
                        With CType(Lineas(i), dsInfFactura.TICKETS_LINEASRow)
                            rTotales.Base1 += .Importe / (1 + .PorcentajeIVA / 100)
                        End With
                    Next
                    If PorcentajeDescuento <> 0 Then .Base1 -= Math.Round(.Base1 * PorcentajeDescuento / 100, 2, MidpointRounding.AwayFromZero)
                    .TotIva1 = Math.Round(.Base1 * .PorIva1 / 100, 2, MidpointRounding.AwayFromZero)
                    If TieneRecargo Then
                        .PorRec1 = DatosTienda.TipoRecargo1
                        .TotRec1 = Math.Round(.Base1 * .PorRec1 / 100, 2, MidpointRounding.AwayFromZero)
                    End If
                End If

                If Not .IsPorIva2Null Then
                    Lineas = Factura.TICKETS_LINEAS.Select("PorcentajeIVA = " & CDbl(.PorIva2))
                    For i As Integer = 0 To Lineas.Length - 1
                        With CType(Lineas(i), dsInfFactura.TICKETS_LINEASRow)
                            rTotales.Base2 += .Importe / (1 + .PorcentajeIVA / 100)
                        End With
                    Next
                    If PorcentajeDescuento <> 0 Then .Base2 -= Math.Round(.Base2 * PorcentajeDescuento / 100, 2, MidpointRounding.AwayFromZero)
                    .TotIva2 = Math.Round(.Base2 * .PorIva2 / 100, 2, MidpointRounding.AwayFromZero)
                    If TieneRecargo Then
                        .PorRec2 = DatosTienda.TipoRecargo2
                        .TotRec2 = Math.Round(.Base2 * .PorRec2 / 100, 2, MidpointRounding.AwayFromZero)
                    End If
                End If

                If Not .IsPorIva3Null Then
                    Lineas = Factura.TICKETS_LINEAS.Select("PorcentajeIVA = " & CDbl(.PorIva3))
                    For i As Integer = 0 To Lineas.Length - 1
                        With CType(Lineas(i), dsInfFactura.TICKETS_LINEASRow)
                            rTotales.Base3 += .Importe / (1 + .PorcentajeIVA / 100)
                        End With
                    Next
                    If PorcentajeDescuento <> 0 Then .Base3 -= Math.Round(.Base3 * PorcentajeDescuento / 100, 2, MidpointRounding.AwayFromZero)
                    .TotIva3 = Math.Round(.Base3 * .PorIva3 / 100, 2, MidpointRounding.AwayFromZero)
                    If TieneRecargo Then
                        .PorRec3 = DatosTienda.TipoRecargo3
                        .TotRec3 = Math.Round(.Base3 * .PorRec3 / 100, 2, MidpointRounding.AwayFromZero)
                    End If
                End If

                If Not .IsPorIva4Null Then
                    Lineas = Factura.TICKETS_LINEAS.Select("PorcentajeIVA = " & CDbl(.PorIva4))
                    For i As Integer = 0 To Lineas.Length - 1
                        With CType(Lineas(i), dsInfFactura.TICKETS_LINEASRow)
                            rTotales.Base4 += .Importe / (1 + .PorcentajeIVA / 100)
                        End With
                    Next
                    If PorcentajeDescuento <> 0 Then .Base4 -= Math.Round(.Base4 * PorcentajeDescuento / 100, 2, MidpointRounding.AwayFromZero)
                    .TotIva4 = Math.Round(.Base4 * .PorIva4 / 100, 2, MidpointRounding.AwayFromZero)
                    If TieneRecargo Then
                        .PorRec4 = DatosTienda.TipoRecargo4
                        .TotRec4 = Math.Round(.Base4 * .PorRec4 / 100, 2, MidpointRounding.AwayFromZero)
                    End If
                End If

            End With

            Factura.TOTALES.AddTOTALESRow(rTotales)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
