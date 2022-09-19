Public Class EstadisticasTickets

#Region "EstadisticasTickets_Shown"
    Private Sub EstadisticasTickets_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.maskImporte.Mask.EditMask = "c" & DecimalesImporte
        Me.maskImporte_Hora.Mask.EditMask = "c" & DecimalesImporte
        Me.maskImporte_Familia.Mask.EditMask = "c" & DecimalesImporte
        Me.maskImporte_Contabilidad.Mask.EditMask = "c" & DecimalesImporte
        Me.maskImporte_IVA.Mask.EditMask = "c" & DecimalesImporte
        Me.maskImporte_Vendedor.Mask.EditMask = "c" & DecimalesImporte
        Me.maskImporte_Cliente.Mask.EditMask = "c" & DecimalesImporte
        Me.colImporteTotal.SummaryItem.DisplayFormat = "{0:c" & DecimalesImporte & "}"
        Me.colImporteTotal_Hora.SummaryItem.DisplayFormat = "{0:c" & DecimalesImporte & "}"
        Me.colImporteTotal_Familia.SummaryItem.DisplayFormat = "{0:c" & DecimalesImporte & "}"
        Me.colImporteVendedor.SummaryItem.DisplayFormat = "{0:c" & DecimalesImporte & "}"
        Me.colImporte_Contabilidad.SummaryItem.DisplayFormat = "{0:c" & DecimalesImporte & "}"
        Me.colImporteTotales.SummaryItem.DisplayFormat = "{0:c" & DecimalesImporte & "}"
        Me.colImporte_IVA.SummaryItem.DisplayFormat = "{0:c" & DecimalesImporte & "}"
        Me.colImporteTotal_Cliente.SummaryItem.DisplayFormat = "{0:c" & DecimalesImporte & "}"
        Me.colImporteDescuento_Cliente.SummaryItem.DisplayFormat = "{0:c" & DecimalesImporte & "}"
    End Sub
#End Region

#Region "EstadisticasTickets_KeyUp"
    Private Sub EstadisticasTickets_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "BuscaTickets"
    Private Sub BuscaTickets()

        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.CommandTimeout = 600000
        cmd.Connection.Open()

        Try
            Me.DsConsultaTickets.Clear()

            'Cabeceras tickets
            Select Case Me.TabInformes.SelectedTabPage.Name
                Case Me.TabPagTicketsDia.Name
                    cmd.CommandText = "SELECT HISTORICO_TICKETS.CodigoCaja, HISTORICO_TICKETS.NumeroTicket, HISTORICO_TICKETS.HoraTicket AS FechaTicket, ISNULL(CLICREDI.NombreFiscal,CLIENTES.NombreFiscal) AS NombreFiscal, HISTORICO_TICKETS.NumeroLineas, HISTORICO_TICKETS.ImporteTotal, " & _
                                      "CASE TipoFactura WHEN 1 THEN 'A-' + CONVERT(VARCHAR,NumeroAlbaran) WHEN 2 THEN 'F1-' + CONVERT(VARCHAR,NumeroAlbaran) WHEN 3 THEN 'F2-' + CONVERT(VARCHAR,NumeroAlbaran) ELSE 'T-' + CONVERT(VARCHAR,NumeroTicket) END AS NumeroDocumento " & _
                                      "FROM HISTORICO_TICKETS " & _
                                      "LEFT JOIN CLIENTES ON HISTORICO_TICKETS.CodigoCliente=CLIENTES.Codigo " & _
                                      "LEFT JOIN CLICREDI ON HISTORICO_TICKETS.ClienteCredito=CLICREDI.Codigo"
                Case Me.TabPagTicketsHora.Name
                    cmd.CommandText = "SELECT left(CONVERT(varchar,HISTORICO_TICKETS.HoraTicket,8),2) AS HoraTicket, COUNT(HISTORICO_TICKETS.Id) AS NumeroTicket, SUM(HISTORICO_TICKETS.NumeroLineas) AS NumeroLineas, SUM(HISTORICO_TICKETS.ImporteTotal) AS ImporteTotal " & _
                                      "FROM HISTORICO_TICKETS"
                Case Me.TabFamilias.Name
                    cmd.CommandText = "SELECT FAMILIASARTICULOS.Codigo + ': ' + FAMILIASARTICULOS.Descripcion AS HoraTicket, " & _
                                      "SUBFAMILIASARTICULOS.Codigo + ': ' + SUBFAMILIASARTICULOS.Descripcion AS TipoCobro, " & _
                                      "COUNT(HISTORICO_TICKETS.Id) AS NumeroTicket, COUNT(HISTORICO_TICKETS_LINEAS.Id) AS NumeroLineas, SUM(HISTORICO_TICKETS_LINEAS.Importe) AS ImporteTotal " & _
                                      "FROM HISTORICO_TICKETS INNER JOIN HISTORICO_TICKETS_LINEAS ON HISTORICO_TICKETS.Id = HISTORICO_TICKETS_LINEAS.Ticket_Id " & _
                                      "INNER JOIN ARTICULOS ON ARTICULOS.Codigo = HISTORICO_TICKETS_LINEAS.CodigoArticulo " & _
                                      "LEFT JOIN FAMILIASARTICULOS ON FAMILIASARTICULOS.Id = ARTICULOS.CodigoFamilia " & _
                                      "LEFT JOIN SUBFAMILIASARTICULOS ON SUBFAMILIASARTICULOS.Id = ARTICULOS.CodigoSubfamilia"
                Case Me.TabVendedor.Name
                    cmd.CommandText = "SELECT LTRIM(STR(OPERARIOS.Codigo)) + ': ' + OPERARIOS.Nombre AS HoraTicket, COUNT(HISTORICO_TICKETS.Id) AS NumeroTicket, COUNT(HISTORICO_TICKETS_LINEAS.Id) AS NumeroLineas, SUM(HISTORICO_TICKETS_LINEAS.Importe) AS ImporteTotal " & _
                                      "FROM HISTORICO_TICKETS INNER JOIN HISTORICO_TICKETS_LINEAS ON HISTORICO_TICKETS.Id = HISTORICO_TICKETS_LINEAS.Ticket_Id " & _
                                      "INNER JOIN OPERARIOS ON OPERARIOS.Codigo = HISTORICO_TICKETS_LINEAS.CodigoEmleado"
                Case Me.TabCliente.Name
                    cmd.CommandText = "SELECT LTRIM(STR(ISNULL(CLIENTES.Codigo,CLICREDI.Codigo))) + ': ' + ISNULL(CLICREDI.NombreFiscal,CLIENTES.NombreFiscal) AS NombreFiscal, COUNT(HISTORICO_TICKETS.Id) AS NumeroTicket, COUNT(HISTORICO_TICKETS_LINEAS.Id) AS NumeroLineas, SUM(HISTORICO_TICKETS_LINEAS.Importe) AS ImporteTotal, " & _
                                      "CLIENTES.DescuentoTarjeta / 100 AS PorcentajeDescuento, (SUM(HISTORICO_TICKETS_LINEAS.Importe) * CLIENTES.DescuentoTarjeta / 100) AS ImporteDescuento " & _
                                      "FROM HISTORICO_TICKETS INNER JOIN HISTORICO_TICKETS_LINEAS ON HISTORICO_TICKETS.Id = HISTORICO_TICKETS_LINEAS.Ticket_Id " & _
                                      "LEFT JOIN CLIENTES ON HISTORICO_TICKETS.CodigoCliente=CLIENTES.Codigo " & _
                                      "LEFT JOIN CLICREDI ON HISTORICO_TICKETS.ClienteCredito=CLICREDI.Codigo"
                Case Me.TabContabilidad.Name
                    cmd.CommandText = "SELECT HISTORICO_TICKETS.CodigoCaja, HISTORICO_TICKETS.NumeroTicket, HISTORICO_TICKETS.HoraTicket AS FechaTicket, ISNULL(CLICREDI.NombreFiscal,CLIENTES.NombreFiscal) AS NombreFiscal, HISTORICO_TICKETS.NumeroLineas, HISTORICO_TICKETS.ImporteTotal, " & _
                                      "CASE TipoFactura WHEN 1 THEN 'A-' + CONVERT(VARCHAR,NumeroAlbaran) WHEN 2 THEN 'F1-' + CONVERT(VARCHAR,NumeroAlbaran) WHEN 3 THEN 'F2-' + CONVERT(VARCHAR,NumeroAlbaran) ELSE 'T-' + CONVERT(VARCHAR,NumeroTicket) END AS NumeroDocumento, " & _
                                      "CASE ImporteEfectivo WHEN 0 THEN '' ELSE 'EF ' END " & _
                                      "+ CASE ImporteTarjeta WHEN 0 THEN '' ELSE 'TJ ' END " & _
                                      "+ CASE ImporteTalonCheque WHEN 0 THEN '' ELSE 'TL ' END " & _
                                      "+ CASE ImporteValesProveedor WHEN 0 THEN '' ELSE 'VP ' END " & _
                                      "+ CASE ImporteValesCobrados WHEN 0 THEN '' ELSE 'VC ' END " & _
                                      "+ CASE ImporteEnvases WHEN 0 THEN '' ELSE 'EN ' END " & _
                                      "+ CASE ImportePendienteCobro WHEN 0 THEN '' ELSE 'PC ' END " & _
                                      "+ CASE ImporteValesEmitidos WHEN 0 THEN '' ELSE 'VE ' END " & _
                                      "AS TipoCobro, " & _
                                      "(SELECT TOP 1 CodigoEmleado FROM HISTORICO_TICKETS_LINEAS WHERE Ticket_Id = HISTORICO_TICKETS.Id) AS CodigoEmpleado, " & _
                                      "ISNULL((SELECT SUM(Importe-Importe/(1+(PorcentajeIVA/100))) FROM HISTORICO_TICKETS_LINEAS WHERE Ticket_Id = HISTORICO_TICKETS.Id),0) AS TotIva, " & _
                                      "ISNULL((SELECT SUM(Importe/(1+(PorcentajeIVA/100))) FROM HISTORICO_TICKETS_LINEAS WHERE Ticket_Id = HISTORICO_TICKETS.Id),0) AS Base, " & _
                                      "ISNULL((SELECT SUM(Cantidad*Precio*DescuentoLinea/100) FROM HISTORICO_TICKETS_LINEAS WHERE Ticket_Id = HISTORICO_TICKETS.Id),0) AS ImporteDescuento " & _
                                      "FROM HISTORICO_TICKETS " & _
                                      "LEFT JOIN CLIENTES ON HISTORICO_TICKETS.CodigoCliente=CLIENTES.Codigo " & _
                                      "LEFT JOIN CLICREDI ON HISTORICO_TICKETS.ClienteCredito=CLICREDI.Codigo"
                Case Me.TabArticulos.Name

                    'Filtros
                    Dim Filtros As New dsConsultaTickets.Filtros
                    If IsDate(Me.txtFechaInicio.EditValue) Then Filtros.FECINI = Me.txtFechaInicio.EditValue
                    If IsDate(Me.txtFechaFin.EditValue) Then Filtros.FECFIN = CDate(Me.txtFechaFin.EditValue).AddDays(1).AddSeconds(-1)
                    Filtros.CODCLI = Me.txtCodigoCliente.EditValue
                    Filtros.CODART = Me.txtCodigoArticulo.EditValue
                    'Filtros.LINEAS_PRECIOMANUAL = Me.checkPrecioManual.Checked
                    'Filtros.LINEAS_NEGATIVAS = Me.checkLineasNegativas.Checked
                    'Filtros.LINEAS_DTO = Me.checkLineasDto.Checked

                    Me.DsConsultaTickets.EstadisticaArticulos(Filtros, Me.checkPendiente.Checked)

                    Exit Try

            End Select

            'Filtros
            Dim Filtro As String = String.Empty
            Filtro = " WHERE CodigoTienda=" & CodigoTienda & " AND HISTORICO_TICKETS.EnEspera = 0"
            If IsDate(Me.txtFechaInicio.EditValue) Then Filtro &= " AND HISTORICO_TICKETS.FechaTicket>='" & Me.txtFechaInicio.EditValue & "'"
            If IsDate(Me.txtFechaFin.EditValue) Then Filtro &= " AND HISTORICO_TICKETS.FechaTicket<='" & Me.txtFechaFin.EditValue & "'"
            If IsNumeric(Me.txtCodigoCliente.EditValue) Then Filtro &= " AND HISTORICO_TICKETS.ClienteCredito='" & Me.txtCodigoCliente.EditValue & "'"
            If Me.txtCodigoArticulo.EditValue <> String.Empty Then Filtro &= " AND HISTORICO_TICKETS.Id IN (SELECT Ticket_Id FROM HISTORICO_TICKETS_LINEAS WHERE CodigoArticulo='" & Me.txtCodigoArticulo.EditValue & "')"
            cmd.CommandText &= Filtro

            'Agrupaciones
            Select Case Me.TabInformes.SelectedTabPage.Name
                Case Me.TabPagTicketsDia.Name
                    cmd.CommandText &= " ORDER BY CodigoCaja, HoraTicket"
                Case Me.TabPagTicketsHora.Name
                    cmd.CommandText &= " GROUP BY left(CONVERT(varchar,HISTORICO_TICKETS.HoraTicket,8),2)"
                Case Me.TabFamilias.Name
                    cmd.CommandText &= " GROUP BY FAMILIASARTICULOS.Codigo, FAMILIASARTICULOS.Descripcion, SUBFAMILIASARTICULOS.Codigo, SUBFAMILIASARTICULOS.Descripcion"
                Case Me.TabVendedor.Name
                    cmd.CommandText &= " GROUP BY OPERARIOS.Codigo, OPERARIOS.Nombre"
                Case Me.TabCliente.Name
                    cmd.CommandText &= " GROUP BY CLIENTES.Codigo, CLIENTES.NombreFiscal, CLIENTES.DescuentoTarjeta, CLICREDI.Codigo, CLICREDI.NombreFiscal"
                Case Me.TabContabilidad.Name
                    cmd.CommandText &= " ORDER BY CodigoCaja, HoraTicket"
            End Select

            If Me.checkPendiente.Checked Then
                cmd.CommandText = cmd.CommandText.Replace("HISTORICO_", String.Empty)
            End If

            Me.DsConsultaTickets.TICKETS.Load(cmd.ExecuteReader)

            'Totales
            If Me.TabInformes.SelectedTabPage Is Me.TabContabilidad Then

                Dim dr As SqlClient.SqlDataReader
                cmd.CommandText = "SELECT ISNULL(SUM(ImporteEfectivo-ImporteCambios),0) AS Efectivo, " & _
                                  "ISNULL(SUM(ImporteTarjeta),0) AS Tarjeta, " & _
                                  "ISNULL(SUM(ImporteTalonCheque),0) AS Talon, " & _
                                  "ISNULL(SUM(ImporteValesProveedor),0) AS ValesProveedor, " & _
                                  "ISNULL(SUM(ImporteValesCobrados),0) AS ValesCobrados, " & _
                                  "ISNULL(SUM(ImporteEnvases),0) AS Envases, " & _
                                  "ISNULL(SUM(ImportePendienteCobro),0) AS PendienteCobro, " & _
                                  "ISNULL(SUM(ImporteValesEmitidos),0) AS ValesEmitidos, " & _
                                  "ISNULL(SUM(ValesCanjeados),0) AS ValesCanjeados, " & _
                                  "ISNULL(SUM(TotalDtoPP),0) AS TotalDtoPP, " & _
                                  "ISNULL(SUM(TotalRecargo),0) AS TotalRecargo " & _
                                  "FROM HISTORICO_TICKETS" & Filtro

                If Me.checkPendiente.Checked Then
                    cmd.CommandText = cmd.CommandText.Replace("HISTORICO_", String.Empty)
                End If

                dr = cmd.ExecuteReader
                If dr.Read Then
                    If dr("Efectivo") <> 0 Then Me.DsConsultaTickets.TOTALES.AddTOTALESRow("Total efectivo", dr("Efectivo"), 0, 0, 0)
                    If dr("Tarjeta") <> 0 Then Me.DsConsultaTickets.TOTALES.AddTOTALESRow("Total tarjeta", dr("Tarjeta"), 0, 0, 0)
                    If dr("Talon") <> 0 Then Me.DsConsultaTickets.TOTALES.AddTOTALESRow("Total talones", dr("Talon"), 0, 0, 0)
                    If dr("ValesProveedor") <> 0 Then Me.DsConsultaTickets.TOTALES.AddTOTALESRow("Total vales proveedor", dr("ValesProveedor"), 0, 0, 0)
                    If dr("ValesCobrados") <> 0 Then Me.DsConsultaTickets.TOTALES.AddTOTALESRow("Total vales cobrados", dr("ValesCobrados"), 0, 0, 0)
                    If dr("Envases") <> 0 Then Me.DsConsultaTickets.TOTALES.AddTOTALESRow("Total envases", dr("Envases"), 0, 0, 0)
                    If dr("PendienteCobro") <> 0 Then Me.DsConsultaTickets.TOTALES.AddTOTALESRow("Total pendientes de cobro", dr("PendienteCobro"), 0, 0, 0)
                    If dr("ValesEmitidos") <> 0 Then Me.DsConsultaTickets.TOTALES.AddTOTALESRow("Total vales emitidos", dr("ValesEmitidos"), 0, 0, 0)
                    If dr("ValesCanjeados") <> 0 Then Me.DsConsultaTickets.TOTALES.AddTOTALESRow("Total vales canjeados", dr("ValesCanjeados"), 0, 0, 0)
                    If dr("TotalDtoPP") <> 0 Then Me.DsConsultaTickets.TOTALES.AddTOTALESRow("Total descuento P.P.", dr("TotalDtoPP"), 0, 0, 0)
                    If dr("TotalRecargo") <> 0 Then Me.DsConsultaTickets.TOTALES.AddTOTALESRow("Total recargo", dr("TotalRecargo"), 0, 0, 0)
                End If
                dr.Close()

                cmd.CommandText = "SELECT HISTORICO_TICKETS_LINEAS.PorcentajeIVA, ISNULL(SUM(HISTORICO_TICKETS_LINEAS.Importe),0) AS Total " & _
                                    "FROM HISTORICO_TICKETS INNER JOIN HISTORICO_TICKETS_LINEAS ON HISTORICO_TICKETS.Id = HISTORICO_TICKETS_LINEAS.Ticket_Id"

                cmd.CommandText &= Filtro & " GROUP BY HISTORICO_TICKETS_LINEAS.PorcentajeIVA"

                If Me.checkPendiente.Checked Then
                    cmd.CommandText = cmd.CommandText.Replace("HISTORICO_", String.Empty)
                End If

                'Calcular diferencia entre bases
                Dim TotalBases As Decimal, TotalIVA As Decimal, TotalVentas As Decimal, Diferencia As Decimal

                dr = cmd.ExecuteReader
                While dr.Read
                    TotalBases += Math.Round(dr("Total") / (1 + (dr("PorcentajeIVA") / 100)), DecimalesImporte, MidpointRounding.AwayFromZero)
                    TotalIVA += Math.Round(dr("Total") - (dr("Total") / (1 + (dr("PorcentajeIVA") / 100))), DecimalesImporte, MidpointRounding.AwayFromZero)
                    TotalVentas += dr("Total")
                End While
                dr.Close()
                Diferencia = TotalVentas - (TotalBases + TotalIVA)

                dr = cmd.ExecuteReader
                While dr.Read
                    TotalBases = Math.Round(dr("Total") / (1 + (dr("PorcentajeIVA") / 100)), DecimalesImporte, MidpointRounding.AwayFromZero)
                    TotalIVA = Math.Round(dr("Total") - (dr("Total") / (1 + (dr("PorcentajeIVA") / 100))), DecimalesImporte, MidpointRounding.AwayFromZero)
                    TotalVentas = dr("Total")
                    If TotalBases <> 0 Then
                        Me.DsConsultaTickets.TOTALES.AddTOTALESRow("Total IVA", dr("Total"), TotalBases + Diferencia, dr("PorcentajeIVA"), TotalIVA)
                        Diferencia = 0
                    End If
                End While
                dr.Close()

            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            cmd.Connection.Close()
            Me.bttBuscar.Tag = True
        End Try

    End Sub
#End Region

#Region "bttBuscar_Click"
    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.BuscaTickets()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "txtCodigoCliente_ButtonClick"
    Private Sub txtCodigoCliente_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoCliente.ButtonClick
        Try

            Dim dsClientes As New dsClientes, tClientes As New dsClientesTableAdapters.CLICREDITableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("NombreFiscal")
            Columnas.Add("Nombre Fiscal")
            Columnas.Add(250)
            Columnas.Add(250)

            Columnas.Add("Direccion")
            Columnas.Add("Dirección")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("Nif")
            Columnas.Add("N.I.F.")
            Columnas.Add(100)
            Columnas.Add(100)

            tClientes.Fill(dsClientes.CLICREDI)

            If Buscar(dsClientes, "CLICREDI", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoCliente.EditValue = ResultadoBusqueda
                Me.txtCodigoCliente.IsModified = True
                Me.txtCodigoCliente_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoCliente_Validated"
    Private Sub txtCodigoCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCliente.Validated

        If Not Me.txtCodigoCliente.IsModified Then Exit Sub

        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT NombreFiscal FROM CLICREDI WHERE LTRIM(Codigo) = '" & Me.txtCodigoCliente.EditValue.ToString.Trim & "'"
            Me.txtNombreCliente.EditValue = cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox("Error al buscar el cliente", MsgBoxStyle.Information)
        Finally
            cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "txtCodigoArticulo_ButtonClick"
    Private Sub txtCodigoArticulo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoArticulo.ButtonClick
        Try
            Dim dsArticulos As New dsArticulos
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(0) 'Tamaño columna
            Columnas.Add(0) 'Tamaño máximo columna

            Columnas.Add("Etiqueta")
            Columnas.Add("Familia-Subf")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("Codigo")
            Columnas.Add("Código")
            Columnas.Add(80)
            Columnas.Add(80)

            Columnas.Add("Descripcion")
            Columnas.Add("Descripción")
            Columnas.Add(0)
            Columnas.Add(0)

            Dim cmd As New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT (SELECT Codigo FROM FAMILIASARTICULOS WHERE FAMILIASARTICULOS.Id=ARTICULOS.CodigoFamilia) + ' - ' + " & _
                              "(SELECT Codigo FROM SUBFAMILIASARTICULOS WHERE Familia_Id=ARTICULOS.CodigoFamilia AND SUBFAMILIASARTICULOS.Id=ARTICULOS.CodigoSubfamilia) AS Etiqueta, " & _
                              "Codigo, Descripcion FROM ARTICULOS ORDER BY Etiqueta, Descripcion"

            dsArticulos.ARTICULOS.Load(cmd.ExecuteReader)

            cmd.Connection.Close()

            If Buscar(dsArticulos, "ARTICULOS", Columnas, 3, True).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoArticulo.Text = ResultadoBusqueda
                Me.txtCodigoArticulo.IsModified = True
                Me.txtCodigoArticulo_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "txtCodigoArticulo_Validated"
    Private Sub txtCodigoArticulo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoArticulo.Validated

        If Not Me.txtCodigoArticulo.IsModified Then Exit Sub

        If IsNumeric(Me.txtCodigoArticulo.EditValue) Then
            Me.txtCodigoArticulo.EditValue = Format(Int(Me.txtCodigoArticulo.EditValue), "0000000")
        End If

        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT Descripcion FROM ARTICULOS WHERE Codigo='" & Me.txtCodigoArticulo.EditValue & "'"
            Me.txtDescripcionArticulo.EditValue = cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox("Error al buscar el cliente", MsgBoxStyle.Information)
        Finally
            cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "TabInformes_SelectedPageChanged"
    Private Sub TabInformes_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles TabInformes.SelectedPageChanged
        If Me.bttBuscar.Tag Then Me.BuscaTickets()
        Me.gvTicketsFamilia.ExpandAllGroups()
    End Sub
#End Region

#Region "bttImprimir_Click"
    Private Sub bttImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImprimir.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PaperKind = Printing.PaperKind.A4

            Select Case Me.TabInformes.SelectedTabPage.Name

                Case Me.TabPagTicketsDia.Name
                    Informe.PageHeaderFooter = Informes.CabeceraInforme("Tickets día", Nothing)
                    Informe.Component = Me.dgTicketsDia

                Case Me.TabPagTicketsHora.Name
                    Informe.PageHeaderFooter = Informes.CabeceraInforme("Tickets hora", Nothing)
                    Informe.Component = Me.dgTicketsHora

                Case Me.TabArticulos.Name
                    Informe.PageHeaderFooter = Informes.CabeceraInforme("Tickets artículo", Nothing)
                    Informe.Component = Me.dgArticulos

                Case Me.TabFamilias.Name
                    Informe.PageHeaderFooter = Informes.CabeceraInforme("Tickets familia", Nothing)
                    Informe.Component = Me.dgTicketsFamilia

                Case Me.TabVendedor.Name
                    Informe.PageHeaderFooter = Informes.CabeceraInforme("Tickets vendedor", Nothing)
                    Informe.Component = Me.dgTicketsVendedor

                Case Me.TabCliente.Name
                    Informe.PageHeaderFooter = Informes.CabeceraInforme("Tickets cliente", Nothing)
                    Informe.Component = Me.dgTicketsCliente

                Case Me.TabContabilidad.Name

                    Dim InfContable As New InfContable
                    InfContable.DataSource = Me.DsConsultaTickets

                    Dim InfContable_Totales As New InfContable_Totales
                    InfContable_Totales.DataSource = Me.DsConsultaTickets

                    If Me.DsConsultaTickets.TICKETS.Select("TipoFactura = 1").Length > 0 Then

                        Dim InfContable_IVA_Tickets As New InfContable_IVA
                        InfContable_IVA_Tickets.DataSource = Me.DsConsultaTickets
                        InfContable_IVA_Tickets.FilterString = "[BaseImponible] <> 0 AND [TipoFactura] = 0"
                        InfContable_IVA_Tickets.txtTitulo.Text = "Tickets"

                        Dim InfContable_IVA_Albaranes As New InfContable_IVA
                        InfContable_IVA_Albaranes.DataSource = Me.DsConsultaTickets
                        InfContable_IVA_Albaranes.FilterString = "[BaseImponible] <> 0 AND [TipoFactura] = 1"
                        InfContable_IVA_Albaranes.txtTitulo.Text = "Albaranes"

                        InfContable.subIVA_Tickets.ReportSource = InfContable_IVA_Tickets
                        InfContable.subIVA_Albaranes.ReportSource = InfContable_IVA_Albaranes

                    Else

                        InfContable.subIVA_Tickets.Dispose()
                        InfContable.subIVA_Albaranes.Dispose()

                    End If

                    Dim InfContable_IVA_Totales As New InfContable_IVA
                    InfContable_IVA_Totales.DataSource = Me.DsConsultaTickets

                    InfContable.subTotales.ReportSource = InfContable_Totales
                    InfContable.subIVA_Totales.ReportSource = InfContable_IVA_Totales

                    InfContable.txtTitulo.Text = "Listado contable"
                    If IsDate(Me.txtFechaInicio.EditValue) Then InfContable.txtTitulo.Text &= " desde " & Me.txtFechaInicio.EditValue
                    If IsDate(Me.txtFechaFin.EditValue) Then InfContable.txtTitulo.Text &= " hasta " & Me.txtFechaFin.EditValue

                    InfContable.CreateDocument()

                    Dim f As New PreImpreso
                    f.Informe.PrintingSystem = InfContable.PrintingSystem

                    General.AbrirFormulario(f, InfContable.txtTitulo.Text)

                    Exit Try

            End Select

            Informe.PrintingSystem = ps

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia("Tickets día", Informe)

        Catch ex As Exception
            MsgBox("Error al generar el informe", MsgBoxStyle.Exclamation)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "bttImprimirListadoHoras_Click"
    Private Sub bttImprimirListadoHoras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim Informe As New DevExpress.XtraPrinting.PrintableComponentLink
            Dim ps As DevExpress.XtraPrinting.PrintingSystem = New DevExpress.XtraPrinting.PrintingSystem()

            Informe.PaperKind = Printing.PaperKind.A4
            Informe.PageHeaderFooter = Informes.CabeceraInforme("Tickets hora", Nothing)

            Informe.Component = Me.dgTicketsHora

            Informe.PrintingSystem = ps

            Informe.CreateDocument()

            Informes.AbrirVistaPrevia("Tickets hora", Informe)

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