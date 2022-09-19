Public Class fCanjearPuntos

    Dim CodigoEmpleado As Integer

    Public Sub New(CodigoEmpleado)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.CodigoEmpleado = CodigoEmpleado

    End Sub

#Region "fCanjearPuntos_KeyUp"
    Private Sub fCanjearPuntos_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Try
            Select Case e.KeyCode
                Case Keys.Escape
                    Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "Eventos txtCodigoCliente"
    Private Sub txtCodigoCliente_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoCliente.ButtonClick
        Try
            Dim dsClientes As New dsClientes, tClientes As New dsClientesTableAdapters.CLIENTESTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("NombreFiscal")
            Columnas.Add("Nombre Fiscal")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("Direccion")
            Columnas.Add("Dirección")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("TelParticular")
            Columnas.Add("Teléfono")
            Columnas.Add(100)
            Columnas.Add(100)

            Columnas.Add("CIF")
            Columnas.Add("N.I.F.")
            Columnas.Add(100)
            Columnas.Add(100)

            tClientes.Activos(dsClientes.CLIENTES)

            If Buscar(dsClientes, "CLIENTES", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoCliente.EditValue = ResultadoBusqueda
                Me.txtCodigoCliente.IsModified = True
                Me.txtCodigoCliente_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub txtCodigoCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCliente.Validated

        If Me.txtCodigoCliente.IsModified And Not IsNumeric(Me.txtCodigoCliente.EditValue) Then
            Me.txtCodigoCliente.Focus()
            Exit Sub
        End If

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            Dim dr As SqlClient.SqlDataReader
            cmd.CommandText = "SELECT NombreFiscal, TieneTarjeta, CaducidadTarjeta, ControlBaja, SaldoPuntos, CIF, Observaciones " & _
                              "FROM CLIENTES " & _
                              "WHERE Codigo = " & Me.txtCodigoCliente.EditValue

            dr = cmd.ExecuteReader
            If dr.Read Then

                Me.txtNombreCliente.EditValue = dr("NombreFiscal")
                Me.txtFechaCaducidad.EditValue = dr("CaducidadTarjeta")
                Me.txtNIF.EditValue = dr("CIF")
                Me.txtObservaciones.EditValue = dr("Observaciones")
                Me.txtSaldoPuntos.EditValue = dr("SaldoPuntos")
                Me.txtPuntosRegalo.EditValue = 0

                'Comprobar control de baja
                If Not dr("ControlBaja") Then
                    Me.txtPuntosRegalo.Focus()
                Else
                    MsgBox("Cliente con control de baja", MsgBoxStyle.Information, "Control de baja")
                    Me.txtCodigoCliente.Focus()
                End If

            Else
                MsgBox("No existe ningún cliente con ese código", MsgBoxStyle.Information, "No existe")
                Me.txtCodigoCliente.Focus()
                Me.txtNombreCliente.EditValue = String.Empty
                Me.txtSaldoPuntos.EditValue = 0
                Me.txtPuntosRegalo.EditValue = 0
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox("Error al obtener datos del cliente", MsgBoxStyle.Information, "Datos cliente")
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try

    End Sub
#End Region

#Region "Eventos txtCodigoArticulo"
    Private Sub txtCodigoArticulo_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoArticulo.ButtonClick
        Try
            Dim fBusqueda As New BusquedaArticulos

            If fBusqueda.ShowDialog = Windows.Forms.DialogResult.Retry Then
                Me.txtCodigoArticulo.EditValue = ResultadoBusqueda
                Me.txtCodigoArticulo.IsModified = True
                Me.txtCodigoArticulo_Validated(Nothing, Nothing)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub txtCodigoArticulo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoArticulo.Validated

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            Dim dr As SqlClient.SqlDataReader
            cmd.CommandText = "SELECT Descripcion, Controlbaja " & _
                              "FROM ARTICULOS " & _
                              "WHERE ARTICULOS.Codigo = '" & Me.txtCodigoArticulo.EditValue & "'"

            dr = cmd.ExecuteReader
            If dr.Read Then

                Me.txtDescripcion.Text = dr("Descripcion")
                Me.txtCantidad.EditValue = 1
                Me.txtCantidad.Focus()

                'Comprobar control de baja
                If Not dr("ControlBaja") Then
                    Me.txtCantidad.Focus()
                Else
                    MsgBox("Artículo con control de baja", MsgBoxStyle.Information, "Control de baja")
                    Me.txtCodigoArticulo.Focus()
                End If

            Else
                MsgBox("No existe ningún artículo con ese código", MsgBoxStyle.Information, "No existe")
                Me.txtCodigoArticulo.Focus()
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox("Error al obtener datos del artículo", MsgBoxStyle.Information, "Datos cliente")
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try

    End Sub
#End Region

#Region "bttConfirmar_Click"
    Private Sub bttConfirmar_Click(sender As Object, e As EventArgs) Handles bttConfirmar.Click

        If Me.txtCodigoCliente.EditValue = String.Empty Then Exit Sub
        If Me.txtCodigoArticulo.EditValue = String.Empty Then Exit Sub
        If Me.txtPuntosRegalo.EditValue > Me.txtSaldoPuntos.EditValue Then Exit Sub
        If Me.txtCantidad.EditValue > Me.txtSaldoPuntos.EditValue Then Exit Sub

        Dim dsTickets As New dsTickets
        Dim taTickets As New dsTicketsTableAdapters.TICKETSTableAdapter
        Dim taLineas As New dsTicketsTableAdapters.TICKETS_LINEASTableAdapter

        Try
            'Nuevo ticket
            Dim rTicket As dsTickets.TICKETSRow = dsTickets.TICKETS.NewTICKETSRow
            With rTicket
                .CodigoTienda = CodigoTienda
                .CodigoCaja = CodigoCaja
                .FechaTicket = Date.Today
                .HoraTicket = Date.Now
                .NumeroLineas = 1
                .TipoCobro = "E"
                .CodigoCliente = Me.txtCodigoCliente.EditValue
                .PuntosCanjeados = Me.txtPuntosRegalo.EditValue

                'Actualiza nº último ticket en caja
                Dim cmd As New SqlClient.SqlCommand
                Try
                    cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                    cmd.Connection.Open()

                    If rTicket.TipoFactura = 0 Then
                        cmd.CommandText = "UPDATE Cajas SET NumeroTicket=NumeroTicket+1 WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & CodigoCaja
                        cmd.ExecuteNonQuery()
                    End If

                    cmd.CommandText = "SELECT NumeroTicket FROM CAJAS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & CodigoCaja
                    .NumeroTicket = cmd.ExecuteScalar + IIf(rTicket.TipoFactura <> 0, 1, 0)

                Catch ex As Exception
                    Throw ex
                Finally
                    If Not cmd.Connection Is Nothing Then
                        If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                    End If
                End Try

            End With
            dsTickets.TICKETS.AddTICKETSRow(rTicket)

            Dim rLinea As dsTickets.TICKETS_LINEASRow = dsTickets.TICKETS_LINEAS.NewTICKETS_LINEASRow
            With rLinea
                .CodigoArticulo = Me.txtCodigoArticulo.EditValue
                .DescripcionArticulo = Mid(Me.txtDescripcion.EditValue, 1, 40)
                .Cantidad = Me.txtCantidad.EditValue
                .PorcentajeIVA = DamePorcentajeIva(.CodigoArticulo)
                .CodigoEmleado = Me.CodigoEmpleado
            End With
            dsTickets.TICKETS_LINEAS.AddTICKETS_LINEASRow(rLinea)

            taTickets.Update(dsTickets.TICKETS)
            taLineas.Update(dsTickets.TICKETS_LINEAS)

            'Actualizar saldo cliente
            Dim Cliente As New dsClientesTableAdapters.CLIENTESTableAdapter
            Cliente.ActualizaSaldoPuntos(rTicket.PuntosCanjeados * -1, rTicket.CodigoCliente)

            'Imprimir ticket
            Me.ImprimirTicket(rTicket)

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
#End Region

#Region "bttCancelar_Click"
    Private Sub bttCancelar_Click(sender As Object, e As EventArgs) Handles bttCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
#End Region

#Region "ImprimirTicket"
    Private Sub ImprimirTicket(rTicket As dsTickets.TICKETSRow)

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Dim ticket As String

            ticket = ActivaExpandido()

            'Datos tienda
            cmd.CommandText = "SELECT * FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
            dr = cmd.ExecuteReader
            If dr.Read Then
                ticket &= dr("TextoCabecera1")
                ticket &= DesactivaExpandido()
                ticket &= vbCrLf & vbCrLf & "FECHA: " & Format(rTicket.FechaTicket, "dd-MM-yyyy")
                ticket &= " HORA: " & Format(rTicket.HoraTicket, "HH:mm")
                ticket &= "  T:" & Format(rTicket.CodigoTienda, "00")
                ticket &= "  C:" & Format(rTicket.CodigoCaja, "00")
            End If
            dr.Close()

            'Datos puntos
            ticket &= ActivaExpandido()
            ticket &= vbCrLf & vbCrLf & "CANJE DE PUNTOS" & vbCrLf

            ticket &= DesactivaExpandido() & vbCrLf & vbCrLf

            ticket &= "TARJETA:  " & Me.txtCodigoCliente.EditValue & vbCrLf
            ticket &= "TITULAR:  " & Mid(Me.txtNombreCliente.EditValue, 1, 30) & vbCrLf
            ticket &= "REGALO:   " & Mid(Me.txtDescripcion.EditValue, 1, 30) & vbCrLf
            ticket &= "CANTIDAD: " & Me.txtCantidad.EditValue & vbCrLf
            ticket &= "PUNTOS CANJEADOS: " & CInt(Me.txtPuntosRegalo.EditValue) & vbCrLf
            ticket &= "SALDO POSTERIOR:  " & CInt(Me.txtSaldoPuntos.EditValue - Me.txtPuntosRegalo.EditValue) & vbCrLf

            If ActivaCorteTicket Then ticket += CorteTicket()

            Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket)
            Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket) 'Copia

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "txtPuntosRegalo_EditValueChanged"
    Private Sub txtPuntosRegalo_EditValueChanged(sender As Object, e As EventArgs) Handles txtPuntosRegalo.EditValueChanged
        Me.bttConfirmar.Enabled = (Me.txtPuntosRegalo.EditValue > 0 And Me.txtPuntosRegalo.EditValue <= Me.txtSaldoPuntos.EditValue)
    End Sub
#End Region

End Class