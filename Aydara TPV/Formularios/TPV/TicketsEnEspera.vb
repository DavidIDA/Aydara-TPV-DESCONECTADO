Public Class TicketsEnEspera

#Region "TicketsEnEspera_FormClosing"
    Private Sub TicketsEnEspera_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.DsTickets.Clear()
        'Me.Dispose()
    End Sub
#End Region

#Region "TicketsEnEspera_KeyUp"
    Private Sub TicketsEnEspera_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub
#End Region

#Region "TicketsEnEspera_Load"
    Private Sub TicketsEnEspera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TICKETSTableAdapter.EnEspera(Me.DsTickets.TICKETS, CodigoTienda, CodigoCaja)
        Me.TICKETS_LINEASTableAdapter.EnEspera(Me.DsTickets.TICKETS_LINEAS, CodigoTienda, CodigoCaja)
        Me.dgTickets.LevelTree.Nodes.Add("TICKETS_TICKETS_LINEAS", Me.gvLineas)
    End Sub
#End Region

#Region "dgTickets_MouseDoubleClick"
    Private Sub dgTickets_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgTickets.MouseDoubleClick
        If Me.gvTickets.GetRow(Me.gvTickets.FocusedRowHandle) Is Nothing Then Exit Sub
        ResultadoBusqueda = Me.gvTickets.GetFocusedRowCellValue(Me.colId)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
#End Region

#Region "TicketsEnEspera_Shown"
    Private Sub TicketsEnEspera_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Decimales en precios
        Me.maskImporte.Mask.EditMask = "c" & DecimalesImporte
        Me.gvTickets.FocusedRowHandle = -999997 'Foco en la línea de búsqueda
        Me.gvTickets.FocusedColumn = Me.colHoraTicket
    End Sub
#End Region

    Private Sub bttSeleccionar_Click(sender As Object, e As EventArgs) Handles bttSeleccionar.Click
        Me.dgTickets_MouseDoubleClick(Nothing, Nothing)
    End Sub

    Private Sub bttSalir_Click(sender As Object, e As EventArgs) Handles bttSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub bttImprimirFactura_Click(sender As Object, e As EventArgs) Handles bttImprimirFactura.Click
        If Not IsNothing(Me.gvTickets.GetFocusedRow) Then
            Me.ImprimirFactura(Me.gvTickets.GetFocusedRowCellValue(Me.colId))
            Me.Close()
        End If
    End Sub

#Region "ImprimirFactura"
    Public Sub ImprimirFactura(ByVal IdTicket As Integer)

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Dim dsFactura As New dsInfFactura
        Dim rticket As dsInfFactura.TICKETSRow

        Me.Cursor = Cursors.WaitCursor

        Try
            Dim ticket As String
            Dim cabeceraTicket As String = String.Empty
            Dim pieTicket As String = String.Empty

            ticket = ActivaExpandido()

            'Datos ticket
            cmd.CommandText = "SELECT t.*, f.DescFor FROM TICKETS t LEFT OUTER JOIN FORMAPAG f ON t.ForPag = f.FORPAG WHERE t.Id=" & IdTicket
            dsFactura.TICKETS.Load(cmd.ExecuteReader)
            If dsFactura.TICKETS.Rows.Count = 1 Then
                rticket = dsFactura.TICKETS.Rows(0)
            Else
                MsgBox("Error al reimprimir la factura", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            'Datos tienda
            cmd.CommandText = "SELECT * FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
            dsFactura.TIENDAS.Load(cmd.ExecuteReader)

            Dim Cliente As New dsClientes
            cmd.CommandText = "SELECT * FROM CLIENTES WHERE Codigo=" & rticket.CodigoCliente
            Cliente.CLIENTES.Load(cmd.ExecuteReader)

            If Cliente.CLIENTES.Count > 0 Then

                Dim fDatosCliente As New fDatosCliente

                With Cliente.CLIENTES(0)

                    Dim rCliente As dsInfFactura.CLIENTESRow = dsFactura.CLIENTES.NewCLIENTESRow
                    rCliente.Codigo = 0
                    rCliente.NombreFiscal = .NombreFiscal
                    rCliente.Direccion = .Direccion
                    rCliente.CodigoPostal = .CodigoPostal
                    rCliente.Poblacion = .Poblacion
                    rCliente.Provincia = .Provincia
                    rCliente.Nif = .CIF
                    dsFactura.CLIENTES.AddCLIENTESRow(rCliente)

                End With

            End If

            'Líneas ticket
            cmd.CommandText = "SELECT * FROM TICKETS_LINEAS WHERE Ticket_Id=" & IdTicket
            dsFactura.TICKETS_LINEAS.Load(cmd.ExecuteReader)

            'Totales ticket
            Informes.TotalesTicket(dsFactura)

            Dim Informe As New InfTicket

            'Nombre empleado
            Informe.RequestParameters = False
            If dsFactura.TICKETS_LINEAS.Rows.Count > 0 Then
                cmd.CommandText = "SELECT NombreTicket FROM OPERARIOS WHERE Codigo=" & dsFactura.TICKETS_LINEAS.Rows(0).Item("CodigoEmleado")
                Informe.Parameters("Empleado").Value = "LE ATENDIO: " & cmd.ExecuteScalar
            End If

            Informe.Parameters("Documento").Value = "RESERVA"
            Informe.Parameters("Numero").Value = 0

            Informe.DataSource = dsFactura

            Informe.CreateDocument()

            Dim printTool As New DevExpress.XtraPrinting.PrintTool(Informe.PrintingSystem)

            If My.Settings.ImpresoraFacturas = String.Empty Then

                Dim f As New PreImpreso
                f.Informe.PrintingSystem = Informe.PrintingSystem

                If Not printTool.PrintDialog Then
                    General.AbrirFormulario(f, "Reserva material")
                End If

            Else
                printTool.Print(My.Settings.ImpresoraFacturas)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Error al reimprimir el ticket." & vbCrLf & ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

End Class