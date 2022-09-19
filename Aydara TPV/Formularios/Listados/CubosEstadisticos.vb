Imports DevExpress.XtraCharts

Public Class CubosEstadisticos

#Region "CubosEstadisticos_KeyUp"
    Private Sub CubosEstadisticos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "bttActualizar_Click"
    Private Sub bttActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttActualizar.Click

        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            Me.Cursor = Cursors.WaitCursor

            cmd.Connection.Open()

            Dim dsConsultaTickets As New dsConsultaTickets
            Dim sql As String = String.Empty
            Dim i As Integer

            dsConsultaTickets.ESTADISTICAS.Clear()
            Me.dgEstadisticas.Fields.Clear()

            'Cabeceras de tickets
            For i = 0 To Me.lstCabecerasTickets.Items.Count - 1
                If Me.lstCabecerasTickets.Items(i).CheckState = CheckState.Checked Then

                    Me.dgEstadisticas.Fields.Add(Me.lstCabecerasTickets.Items(i).Value, DevExpress.XtraPivotGrid.PivotArea.FilterArea)

                    'Comprobar si es un campo especial
                    Select Case Me.lstCabecerasTickets.Items(i).Value
                        Case "HoraTicket"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "LEFT(CONVERT(VARCHAR,HISTORICO_TICKETS.HoraTicket,8),2) AS HoraTicket"
                        Case "NombreCliente"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "(SELECT NombreFiscal FROM CLIENTES WHERE Codigo=HISTORICO_TICKETS.CodigoCliente) AS NombreCliente"
                        Case Else
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & Me.lstCabecerasTickets.Items(i).Value
                    End Select

                    'Configurar celdas especiales
                    Select Case Me.lstCabecerasTickets.Items(i).Value
                        Case "FechaTicket"
                            Me.dgEstadisticas.Fields(Me.lstCabecerasTickets.Items(i).Value).ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
                            Me.dgEstadisticas.Fields(Me.lstCabecerasTickets.Items(i).Value).ValueFormat.FormatString = "d"
                    End Select

                End If
            Next

            'Líneas de tickets
            For i = 0 To Me.lstLineasTickets.Items.Count - 1
                If Me.lstLineasTickets.Items(i).CheckState = CheckState.Checked Then

                    Me.dgEstadisticas.Fields.Add(Me.lstLineasTickets.Items(i).Value, DevExpress.XtraPivotGrid.PivotArea.FilterArea)

                    'Comprobar si es un campo especial
                    Select Case Me.lstLineasTickets.Items(i).Value
                        Case "NombreEmpleado"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "(SELECT Nombre FROM OPERARIOS WHERE Codigo=HISTORICO_TICKETS_LINEAS.CodigoEmleado) AS NombreEmpleado"
                        Case "Precio"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "HISTORICO_TICKETS_LINEAS.Precio AS " & Me.lstLineasTickets.Items(i).Value
                        Case Else
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & Me.lstLineasTickets.Items(i).Value
                    End Select

                    'Configurar celdas especiales
                    Select Case Me.lstLineasTickets.Items(i).Value
                    End Select

                End If
            Next

            'Artículos
            For i = 0 To Me.lstArticulos.Items.Count - 1
                If Me.lstArticulos.Items(i).CheckState = CheckState.Checked Then

                    Me.dgEstadisticas.Fields.Add(Me.lstArticulos.Items(i).Value, DevExpress.XtraPivotGrid.PivotArea.FilterArea)

                    'Comprobar si es un campo especial
                    Select Case Me.lstArticulos.Items(i).Value
                        Case "Articulos_Codigo"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "ARTICULOS.Codigo AS " & Me.lstArticulos.Items(i).Value
                        Case "Articulos_Descripcion"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "ARTICULOS.Descripcion AS " & Me.lstArticulos.Items(i).Value
                        Case "Articulos_Proveedor"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "ARTICULOS.CodigoProveedor AS " & Me.lstArticulos.Items(i).Value
                        Case "Articulos_PrecioCoste"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "ARTICULOS.PrecioCoste AS " & Me.lstArticulos.Items(i).Value
                        Case "Articulos_Imagen"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "ARTICULOS.Imagen AS " & Me.lstArticulos.Items(i).Value
                        Case Else
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & Me.lstArticulos.Items(i).Value
                    End Select

                    'Configurar celdas especiales
                    Select Case Me.lstArticulos.Items(i).Value
                    End Select

                End If
            Next

            'Familias
            For i = 0 To Me.lstFamilias.Items.Count - 1
                If Me.lstFamilias.Items(i).CheckState = CheckState.Checked Then

                    Me.dgEstadisticas.Fields.Add(Me.lstFamilias.Items(i).Value, DevExpress.XtraPivotGrid.PivotArea.FilterArea)

                    'Comprobar si es un campo especial
                    Select Case Me.lstFamilias.Items(i).Value
                        Case "Familias_Codigo"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "FAMILIASARTICULOS.Codigo AS " & Me.lstFamilias.Items(i).Value
                        Case "Familias_Descripcion"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "FAMILIASARTICULOS.Descripcion AS " & Me.lstFamilias.Items(i).Value
                        Case "Familias_Imagen"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "FAMILIASARTICULOS.Imagen AS " & Me.lstFamilias.Items(i).Value
                        Case Else
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & Me.lstFamilias.Items(i).Value
                    End Select

                    'Configurar celdas especiales
                    Select Case Me.lstFamilias.Items(i).Value
                    End Select

                End If
            Next

            'Subfamilias
            For i = 0 To Me.lstSubfamilias.Items.Count - 1
                If Me.lstSubfamilias.Items(i).CheckState = CheckState.Checked Then

                    Me.dgEstadisticas.Fields.Add(Me.lstSubfamilias.Items(i).Value, DevExpress.XtraPivotGrid.PivotArea.FilterArea)

                    'Comprobar si es un campo especial
                    Select Case Me.lstSubfamilias.Items(i).Value
                        Case "Subfamilias_Codigo"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "SUBFAMILIASARTICULOS.Codigo AS " & Me.lstSubfamilias.Items(i).Value
                        Case "Subfamilias_Descripcion"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "SUBFAMILIASARTICULOS.Descripcion AS " & Me.lstSubfamilias.Items(i).Value
                        Case "Subfamilias_Imagen"
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & "SUBFAMILIASARTICULOS.Imagen AS " & Me.lstSubfamilias.Items(i).Value
                        Case Else
                            sql &= IIf(sql = String.Empty, "SELECT ", ", ") & Me.lstSubfamilias.Items(i).Value
                    End Select

                    'Configurar celdas especiales
                    Select Case Me.lstFamilias.Items(i).Value
                    End Select

                End If
            Next

            If sql <> String.Empty Then
                cmd.CommandText = sql & " FROM HISTORICO_TICKETS " & _
                                        " LEFT JOIN HISTORICO_TICKETS_LINEAS ON HISTORICO_TICKETS.Id=HISTORICO_TICKETS_LINEAS.Ticket_Id " & _
                                        " LEFT JOIN ARTICULOS ON HISTORICO_TICKETS_LINEAS.CodigoArticulo=ARTICULOS.Codigo " & _
                                        " LEFT JOIN FAMILIASARTICULOS ON FAMILIASARTICULOS.Id=ARTICULOS.CodigoFamilia " & _
                                        " LEFT JOIN SUBFAMILIASARTICULOS ON SUBFAMILIASARTICULOS.Familia_Id=ARTICULOS.CodigoFamilia AND SUBFAMILIASARTICULOS.Id=ARTICULOS.CodigoSubFamilia"
                dsConsultaTickets.ESTADISTICAS.Load(cmd.ExecuteReader)
            End If

            Me.dgEstadisticas.DataSource = dsConsultaTickets.ESTADISTICAS

        Catch ex As Exception
            MsgBox("Error al cargar datos del listado", MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub
#End Region

#Region "bttImprimirListado_Click"
    Private Sub bttImprimirListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimirListado.Click, bttImprimirGrafico.Click
        Try
            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PaperKind = Drawing.Printing.PaperKind.A4

            Informe.PageHeaderFooter = Informes.CabeceraInforme("Cubo estadístico", Nothing)

            Informe.Component = IIf(sender Is Me.bttImprimirListado, Me.dgEstadisticas, Me.grafico)

            Informe.PrintingSystem = ps

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia(Me.txtTituloListado.EditValue, Informe)

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

#Region "checkCabecerasTickets_CheckedChanged"
    Private Sub checkCabecerasTickets_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkCabecerasTickets.CheckedChanged, checkLineasTicket.CheckedChanged, checkArticulos.CheckedChanged, checkFamilias.CheckedChanged, checkSubfamilias.CheckedChanged
        Dim i As Integer
        Select Case sender.name
            Case Me.checkCabecerasTickets.Name
                For i = 0 To Me.lstCabecerasTickets.Items.Count - 1
                    Me.lstCabecerasTickets.Items(i).CheckState = Me.checkCabecerasTickets.CheckState
                Next
            Case Me.checkLineasTicket.Name
                For i = 0 To Me.lstLineasTickets.Items.Count - 1
                    Me.lstLineasTickets.Items(i).CheckState = Me.checkLineasTicket.CheckState
                Next
            Case Me.checkArticulos.Name
                For i = 0 To Me.lstArticulos.Items.Count - 1
                    Me.lstArticulos.Items(i).CheckState = Me.checkArticulos.CheckState
                Next
            Case Me.checkFamilias.Name
                For i = 0 To Me.lstFamilias.Items.Count - 1
                    Me.lstFamilias.Items(i).CheckState = Me.checkFamilias.CheckState
                Next
            Case Me.checkSubfamilias.Name
                For i = 0 To Me.lstSubfamilias.Items.Count - 1
                    Me.lstSubfamilias.Items(i).CheckState = Me.checkSubfamilias.CheckState
                Next
        End Select
    End Sub
#End Region

#Region "panelEstadisticas_Resize"
    Private Sub panelEstadisticas_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles panelEstadisticas.Resize
        Me.panelEstadisticas.SplitterPosition = Me.panelEstadisticas.Height / 2
    End Sub
#End Region

#Region "bttPropiedades_Click"
    Private Sub bttPropiedades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttPropiedades.Click
        Me.PropiedadesControl()
    End Sub
#End Region

#Region "PorpiedadesControl"
    Private Sub PropiedadesControl()
        Try
            Dim f As New DevExpress.XtraEditors.XtraForm

            Dim panel As New DevExpress.XtraEditors.SplitContainerControl
            Dim propiedadesGrilla As New DevExpress.XtraVerticalGrid.PropertyGridControl
            Dim propiedadesGrafico As New DevExpress.XtraVerticalGrid.PropertyGridControl

            panel.Dock = DockStyle.Fill

            propiedadesGrilla.SelectedObject = Me.dgEstadisticas
            propiedadesGrilla.Dock = DockStyle.Fill

            propiedadesGrafico.SelectedObject = Me.grafico
            propiedadesGrafico.Dock = DockStyle.Fill

            f.Text = "Propiedades"
            f.ShowIcon = False
            f.ShowInTaskbar = False
            f.MinimizeBox = False
            f.StartPosition = FormStartPosition.CenterParent
            f.Width = 800 : f.Height = 600

            panel.SplitterPosition = f.Width / 2

            panel.Panel1.Controls.Add(propiedadesGrilla)
            panel.Panel2.Controls.Add(propiedadesGrafico)
            f.Controls.Add(panel)

            f.ShowDialog()

        Catch ex As Exception
            MsgBox("Error al mostrar las propiedades de los objetos", MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

End Class