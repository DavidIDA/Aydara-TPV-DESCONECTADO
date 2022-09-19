Public Class TPV_Tactil

    'Datos envase
    Dim CodigoEnvase As String = String.Empty
    'Gestión tarjetas
    Public Gestiontarjetas As Boolean '= General.GestionTarjetas
    Public DescuentoTarjetas As Decimal '= General.DescuentoTarjetas

    Dim rTicket As dsTickets.TICKETSRow

    Dim UltimaLinea As LineaTicket

    Structure LineaTicket
        Dim CodigoArticulo As String
        Dim DescripcionArticulo As String
        Dim CodigoColor As Integer
        Dim NumeroTalla As Integer
        Dim PrecioManual As Boolean
        Dim Precio As Decimal
        Dim DescuentoLinea As Decimal
        Dim PorcentajeIVA As Decimal
        Dim Promocion As Boolean
        Dim DtoFidelizacion As Decimal
        Dim ImporteEcoraee As Decimal
    End Structure

#Region "TPV_Tactil_FormClosing"
    Private Sub TPV_Tactil_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Me.bttSalir.Enabled Then e.Cancel = True
    End Sub
#End Region

#Region "TPV_Tactil_KeyUp"
    Private Sub TPV_Tactil_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Escape
                Me.bttSalir_Click(Nothing, Nothing)
            Case Keys.F1
                Me.bttCantidadManual_Click(Nothing, Nothing)
            Case Keys.F2
                Me.bttPrecioManual_Click(Nothing, Nothing)
            Case Keys.F3
                Me.bttDescuentoLinea_Click(Nothing, Nothing)
            Case Keys.F4
                Me.bttBorraLinea_Click(Nothing, Nothing)
            Case Keys.F5
                Me.bttModificarLinea_Click(Nothing, Nothing)
            Case Keys.F6
                Me.bttCambioVendedor_Click(Nothing, Nothing)
            Case Keys.F7
                Me.bttAbreCajon_Click(Nothing, Nothing)
            Case Keys.F8
                Me.bttConsultaTicket_Click(Nothing, Nothing)
            Case Keys.F9
                Me.bttTicketEspera_Click(Nothing, Nothing)
            Case Keys.F10
                Me.bttConsultaArticulos_Click(Nothing, Nothing)
            Case Keys.F11
                Me.bttCobroTicket_Click(Nothing, Nothing)
            Case Keys.F12
                If Me.bttBorrarTicket.Enabled Then
                    Me.bttBorrarTicket_Click(Nothing, Nothing)
                Else
                    Me.bttCanjearPuntos_Click(Nothing, Nothing)
                End If
            Case Keys.I
                If e.Control Then Me.ImprimirTicket()
            Case Keys.C
                If e.Control Then Me.bttCanjearPuntos_Click(Nothing, Nothing)
        End Select
    End Sub
#End Region

#Region "TPV_Tactil_Shown"
    Private Sub TPV_Tactil_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            Me.Cursor = Cursors.WaitCursor

            Me.Enabled = False

            'Decimales en precios
            Me.txtTotal.Properties.Mask.EditMask = "c" & DecimalesImporte
            Me.maskPrecio.Mask.EditMask = "c" & DecimalesPrecio
            Me.maskImporte.Mask.EditMask = "c" & DecimalesImporte

            'Ocultar abrir cajón en Calavia
            If General.FormatoEmpresa = 2 Then Me.bttAbreCajon.Visible = False

            'Pedir caja
            If Not Me.SeleccionaCaja() Then Me.Enabled = True : Me.Close() : Exit Sub

            'Nuevo ticket
            Me.NuevoTicket()

            Me.Cursor = Cursors.WaitCursor

            If CantidadManual Then
                Me.colCantidad.AppearanceHeader.ForeColor = Color.Maroon
                Me.colCantidad.AppearanceHeader.Font = New Font(Me.colCantidad.AppearanceHeader.Font, FontStyle.Bold)
            End If
            If PrecioManual Then
                Me.colPrecio.AppearanceHeader.ForeColor = Color.Maroon
                Me.colPrecio.AppearanceHeader.Font = New Font(Me.colPrecio.AppearanceHeader.Font, FontStyle.Bold)
            End If

            'Cargar familias de artículos
            Me.CargaFamiliasArticulos()
            'If Me.lvFamilias.RowCount = 0 Then
            '    Me.CargaArticulos()
            '    Me.lblArticulos.Text = "ARTÍCULOS"
            'Else
            '    Me.lblArticulos.Text = "ARTÍCULOS FAMILIA SELECCIONADA"
            'End If

            Me.Enabled = True
            Me.txtCodigoArticulo.Focus()

        Catch ex As Exception
            MsgBox("Errores en la carga del T.P.V.", MsgBoxStyle.Exclamation, "Error al cargar T.P.V.")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

#Region "bttSalir_Click"
    Private Sub bttSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttSalir.Click
        'Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub
#End Region

#Region "TimerHora_Tick"
    Private Sub TimerHora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerHora.Tick
        Me.txtHora.EditValue = Date.Now
    End Sub
#End Region

#Region "txtCodigoCliente_Click"
    Private Sub txtCodigoCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCliente.Click
        Try
            RemoveHandler txtCodigoArticulo.Validated, AddressOf txtCodigoArticulo_Validated
            Me.txtCodigoCliente.Focus()
        Finally
            AddHandler txtCodigoArticulo.Validated, AddressOf txtCodigoArticulo_Validated
        End Try
    End Sub
#End Region

#Region "txtCodigoCliente_ButtonClick"
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
#End Region

#Region "txtCodigoCliente_Validated"
    Public Sub txtCodigoCliente_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCliente.Validated

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            If Not IsNumeric(Me.txtCodigoCliente.EditValue) Then
                Me.txtCodigoCliente.Focus()
                Exit Sub
            End If

            Gestiontarjetas = False
            DescuentoTarjetas = 0

            Dim dr As SqlClient.SqlDataReader
            cmd.CommandText = "SELECT NombreFiscal, TieneTarjeta, CaducidadTarjeta, DescuentoTarjeta, ControlBaja, SaldoPuntos, IsNull(Observaciones,'') Observaciones " & _
                              "FROM CLIENTES " & _
                              "WHERE CLIENTES.Codigo = " & Me.txtCodigoCliente.EditValue

            dr = cmd.ExecuteReader
            If dr.Read Then

                'Comprobar control de baja
                If Not dr("ControlBaja") Then

                    Me.txtNombreCliente.Text = dr("NombreFiscal")
                    If General.GestionTarjetas And dr("TieneTarjeta") Then
                        If IsDate(dr("CaducidadTarjeta")) Then
                            If dr("CaducidadTarjeta") > Me.txtFecha.EditValue Then
                                Gestiontarjetas = True
                                DescuentoTarjetas = IIf(dr("Descuentotarjeta") <> 0, dr("Descuentotarjeta"), General.DescuentoTarjetas)
                            End If
                        Else
                            Gestiontarjetas = True
                            DescuentoTarjetas = IIf(dr("Descuentotarjeta") <> 0, dr("Descuentotarjeta"), General.DescuentoTarjetas)
                        End If
                    End If
                    If Me.txtCodigoCliente.EditValue <> 0 And CInt(dr("SaldoPuntos")) <> 0 Then
                        Me.txtEstado.Caption = "Saldo puntos: " & CInt(dr("SaldoPuntos"))
                    Else
                        Me.txtEstado.Caption = String.Empty
                    End If
                    Me.txtCodigoArticulo.Focus()

                Else
                    MsgBox("Cliente con control de baja", MsgBoxStyle.Information, "Control de baja")
                    Me.txtCodigoCliente.Focus()
                End If

                'Observaciones cliente
                If dr("Observaciones") <> String.Empty Then
                    MsgBox(dr("Observaciones"), MsgBoxStyle.Information)
                End If

            Else
                MsgBox("No existe ningún cliente con ese código", MsgBoxStyle.Information, "No existe")
                Me.txtEstado.Caption = String.Empty
                Me.txtCodigoCliente.Focus()
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox("Error al obtener datos del cliente", MsgBoxStyle.Information, "Datos cliente")
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "lvFamilias_BeforeLeaveRow"
    Private Sub lvFamilias_BeforeLeaveRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles lvFamilias.BeforeLeaveRow
        Me.lvFamilias.SetFocusedRowCellValue(Me.colSubfamiliaSeleccionada, 0)
    End Sub
#End Region

#Region "lvFamilias_FocusedRowChanged"
    Private Sub lvFamilias_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles lvFamilias.FocusedRowChanged
        If IsNothing(Me.lvFamilias.GetFocusedRow) Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        Me.lvFamilias.SetFocusedRowCellValue(Me.colFamiliaSeleccionada, 1)
        Me.SUBFAMILIASARTICULOSBindingSource.Filter = "Familia_Id = " & Me.lvFamilias.GetFocusedRowCellValue(Me.colIdFamilia)
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region "lvSubFamilias_BeforeLeaveRow"
    Private Sub lvSubFamilias_BeforeLeaveRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles lvSubfamilias.BeforeLeaveRow
        Me.lvSubfamilias.SetFocusedRowCellValue(Me.colSubfamiliaSeleccionada, 0)
    End Sub
#End Region

#Region "lvSubfamilias_Click"
    Private Sub lvSubfamilias_Click(sender As Object, e As EventArgs) Handles lvSubfamilias.Click
        If IsNothing(Me.lvSubfamilias.GetFocusedRow) Then Exit Sub
        Me.Cursor = Cursors.WaitCursor
        'Me.lvSubfamilias.SetFocusedRowCellValue(Me.colSubfamiliaSeleccionada, 1)
        Me.CargaArticulos()
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region "ActivaDesactivaMenu"
    Private Sub ActivaDesactivaMenu(ByVal activa As Boolean)

        If Me.DsTickets.TICKETS_LINEAS.Select.Length > 0 Then
            Me.txtCodigoCliente.Properties.ReadOnly = activa
            Me.txtCodigoCliente.Properties.Buttons(0).Enabled = IIf(activa, False, True)
            Me.bttCobroTicket.Enabled = activa
            Me.bttBorrarTicket.Enabled = activa
            Me.bttBorraLinea.Enabled = activa
            Me.bttModificarLinea.Enabled = activa
            Me.bttSalir.Enabled = IIf(activa, False, True)
            Me.bttConsultaTicket.Enabled = IIf(activa, False, True)
            Me.bttTicketEspera.Font = New Font(Me.bttDescuentoLinea.Font, FontStyle.Regular)
            Me.bttTicketEspera.ForeColor = Color.Empty
        Else
            Me.txtCodigoCliente.Properties.ReadOnly = False
            Me.txtCodigoCliente.Properties.Buttons(0).Enabled = True
            Me.bttCobroTicket.Enabled = False
            Me.bttBorrarTicket.Enabled = False
            Me.bttBorraLinea.Enabled = False
            Me.bttModificarLinea.Enabled = False
            Me.bttSalir.Enabled = True
            Me.bttConsultaTicket.Enabled = True
            If ExistenTicketsEnEspera() Then
                Me.bttTicketEspera.Font = New Font(Me.bttDescuentoLinea.Font, FontStyle.Bold)
                Me.bttTicketEspera.ForeColor = Color.Maroon
            Else
                Me.bttTicketEspera.Font = New Font(Me.bttDescuentoLinea.Font, FontStyle.Regular)
                Me.bttTicketEspera.ForeColor = Color.Empty
            End If
        End If

        Me.bttCajas.Font = New Font(Me.bttCajas.Font, FontStyle.Regular)
        Me.bttCajas.ForeColor = Color.Empty
        Me.bttCantidadManual.Font = New Font(Me.bttCantidadManual.Font, FontStyle.Regular)
        Me.bttCantidadManual.ForeColor = Color.Empty
        Me.bttPrecioManual.Font = New Font(Me.bttPrecioManual.Font, FontStyle.Regular)
        Me.bttPrecioManual.ForeColor = Color.Empty
        Me.bttDescuentoLinea.Font = New Font(Me.bttDescuentoLinea.Font, FontStyle.Regular)
        Me.bttDescuentoLinea.ForeColor = Color.Empty

        Me.bttCanjearPuntos.Visible = Not Me.bttBorrarTicket.Enabled

        Me.gvLineasTicket.MoveLastVisible()

        Me.TotalTicket()

    End Sub
#End Region

#Region "NavListadoFamilias_ButtonClick"
    Private Sub NavListadoFamilias_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        Select Case e.Button.ButtonType
            Case DevExpress.XtraEditors.NavigatorButtonType.NextPage
                Me.SeleccionaUltimaFamiliaVisible()
                Me.lvFamilias.MoveNextPage()
                Me.SeleccionaPrimeraFamiliaVisible()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.PrevPage
                Me.SeleccionaPrimeraFamiliaVisible()
                Me.lvFamilias.MovePrevPage()
                e.Handled = True
        End Select
    End Sub
#End Region

#Region "NavListadoArticulos_ButtonClick"
    Private Sub NavListadoArticulos_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)
        Select Case e.Button.ButtonType
            Case DevExpress.XtraEditors.NavigatorButtonType.NextPage
                Me.SeleccionaUltimoArticuloVisible()
                Me.lvArticulos.MoveNextPage()
                Me.SeleccionaPrimerArticuloVisible()
                e.Handled = True
            Case DevExpress.XtraEditors.NavigatorButtonType.PrevPage
                Me.SeleccionaPrimerArticuloVisible()
                Me.lvArticulos.MovePrevPage()
                e.Handled = True
        End Select
    End Sub
#End Region

#Region "bttConsultaArticulos_Click"
    Private Sub bttConsultaArticulos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttConsultaArticulos.Click
        Try
            RemoveHandler txtCodigoArticulo.Validated, AddressOf txtCodigoArticulo_Validated

            Dim resultado As DialogResult = BusquedaArticulos.ShowDialog()
            If resultado = Windows.Forms.DialogResult.Retry Then

                Me.NuevaLineaTicket(ResultadoBusqueda, 1, -1, -1, True)

            ElseIf resultado = Windows.Forms.DialogResult.OK Then

                'Nueva línea de ticket
                Dim i As Integer
                Dim ArticuloSeleccionado() As String = Split(ResultadoBusqueda, "+")
                Dim CodigoArticulo As String = String.Empty

                For i = 0 To ArticuloSeleccionado.Length - 3
                    CodigoArticulo += ArticuloSeleccionado(i)
                Next

                Me.NuevaLineaTicket(CodigoArticulo, 1, CInt(ArticuloSeleccionado(ArticuloSeleccionado.Length - 2)), CInt(ArticuloSeleccionado(ArticuloSeleccionado.Length - 1)), True)

            End If

        Finally
            AddHandler txtCodigoArticulo.Validated, AddressOf txtCodigoArticulo_Validated
        End Try
    End Sub
#End Region

#Region "bttCambioVendedor_Click"
    Private Sub bttCambioVendedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCambioVendedor.Click
        SeleccionaEmpleado()
    End Sub
#End Region

#Region "bttAbreCajon_Click"
    Private Sub bttAbreCajon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAbreCajon.Click
        Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, AbreCajon)
    End Sub
#End Region

#Region "NuevoTicket"
    Private Sub NuevoTicket()
        Try
            Me.DsTickets.Clear()

            rTicket = DsTickets.TICKETS.NewTICKETSRow
            Me.DsTickets.TICKETS_LINEAS.Ticket_IdColumn.DefaultValue = rTicket.Id
            Me.DsTickets.TICKETS.AddTICKETSRow(rTicket)

            rTicket.FechaTicket = Date.Today

            'Cliente por defecto 0-Venta contado
            Me.txtCodigoCliente.EditValue = 0
            Me.txtCodigoCliente_Validated(Nothing, Nothing)

            Me.txtCodigoCaja.EditValue = CodigoCaja

            'Selecciona empleado si es 1º ticket o si tiene control de vendeores
            If Me.txtCodigoEmpleado.EditValue = 0 Or ControlVendedores Then
                If Not Me.SeleccionaEmpleado() And Me.bttSalir.Enabled Then Me.Close() : Exit Sub
            End If

            'Desactivar menu
            ActivaDesactivaMenu(False)
            Me.bttPrecioManual.Enabled = IIf(PrecioManual, False, True)
            Me.bttCantidadManual.Enabled = IIf(CantidadManual, False, True)
            Me.bttDescuentoLinea.Enabled = IIf(DtoEnLinea, False, True)

            General.DatosCajaActual(CodigoCaja)

            'COMPROBAR TOPE EFECTIVO CAJA
            Me.CompruebaTopeEfectivoCaja()

            Me.txtCodigoArticulo.Focus()

        Catch ex As Exception
            MsgBox("Error al activar nuevo ticket", MsgBoxStyle.Exclamation, "Nuevo ticket")
        End Try
    End Sub
#End Region

#Region "NuevaLineaTicket"
    Private Sub NuevaLineaTicket(ByVal CodigoArticulo As String, ByVal Cantidad As Decimal, ByVal CodigoColor As Integer, ByVal NumeroTalla As Integer, ByVal EsUltimaLinea As Boolean)

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand

        Dim IdArticulo As Integer, CodigoTallaje As Integer
        Dim CantidadVariable As Boolean = False
        Dim ArticuloPeso As Boolean
        Dim Equivalencia As Decimal = 1

        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            'Comprobar que exista código de artículo
            cmd.CommandText = "SELECT COUNT(Id) FROM ARTICULOS WHERE Codigo='" & CodigoArticulo & "'"
            If cmd.ExecuteScalar = 0 Then Exit Try

            'Nueva línea de ticket
            Dim rLineaTicket As dsTickets.TICKETS_LINEASRow
            rLineaTicket = Me.DsTickets.TICKETS_LINEAS.NewRow

            rLineaTicket.Ticket_Id = rTicket.Id
            rLineaTicket.CodigoArticulo = CodigoArticulo

            'Mostrar datos del artículo seleccionado
            cmd.CommandText = "SELECT Id, CodigoTalla, Descripcion, TipoIVA, CodigoEnvase, CantidadVariable, ArticuloPeso, DtoFidelizacion, ImporteEcoraee, Equivalencia " & _
                              "FROM ARTICULOS WHERE Codigo='" & rLineaTicket.CodigoArticulo & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                IdArticulo = dr("Id")
                CodigoTallaje = dr("CodigoTalla")
                rLineaTicket.DescripcionArticulo = dr("Descripcion")
                rLineaTicket.UnidadStock = Cantidad
                rLineaTicket.PorcentajeIVA = dr("TipoIVA")
                rLineaTicket.DtoFidelizacion = dr("DtoFidelizacion")
                rLineaTicket.ImporteEcoraee = dr("ImporteEcoraee")
                CodigoEnvase = dr("CodigoEnvase")
                CantidadVariable = dr("CantidadVariable")
                ArticuloPeso = dr("ArticuloPeso")
                Equivalencia = dr("Equivalencia")
            End If
            dr.Close()

            rLineaTicket.CodigoEmleado = Me.txtCodigoEmpleado.EditValue

            'Obtener pocentaje IVA
            cmd.CommandText = "SELECT TipoIva" & rLineaTicket.PorcentajeIVA & " FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
            rLineaTicket.PorcentajeIVA = cmd.ExecuteScalar

            If (GestionColores And CodigoColor < 0) Or (GestionTallas And NumeroTalla < 0) Then
                'Dame color y talla
                Me.Enabled = False
                DameColorTalla.IdArticulo = IdArticulo
                DameColorTalla.CodigoTallaje = CodigoTallaje
                If DameColorTalla.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim DatosColorTalla() As String = Split(ResultadoBusqueda, "+")
                    If IsNumeric(DatosColorTalla(0)) Then rLineaTicket.CodigoColor = DatosColorTalla(0)
                    If IsNumeric(DatosColorTalla(1)) Then rLineaTicket.NumeroTalla = DatosColorTalla(1)
                End If
                Me.Enabled = True
            Else
                rLineaTicket.CodigoColor = CodigoColor
                rLineaTicket.NumeroTalla = NumeroTalla
            End If

            'Precio del artículo
            Dim Promocion As Almacen.DatosPromocion
            Promocion = DamePrecioPromocion(rLineaTicket.CodigoArticulo, rLineaTicket.CodigoColor, rLineaTicket.NumeroTalla, rLineaTicket.UnidadStock)
            If Promocion.Precio <> 0 Then
                rLineaTicket.Precio = Promocion.Precio
                rLineaTicket.Promocion = True
            Else
                rLineaTicket.Precio = DamePrecioArticulo(rLineaTicket.CodigoArticulo, rLineaTicket.CodigoColor, rLineaTicket.NumeroTalla)
            End If

            If IsNothing(Promocion.CodigoArticulo) Or DtoSobrePromociones = True Then
                rLineaTicket.DescuentoLinea = DameDescuentoArticulo(rLineaTicket.CodigoArticulo, Gestiontarjetas, Me.txtCodigoCliente.EditValue)
                If rLineaTicket.DescuentoLinea = 0 Then rLineaTicket.DescuentoLinea = DescuentoTarjetas
            End If

            Me.ActualizaTotalLinea(rLineaTicket)

            Me.DsTickets.TICKETS_LINEAS.AddTICKETS_LINEASRow(rLineaTicket)

            InfoArticulo()

            Me.txtCodigoArticulo.EditValue = String.Empty
            Me.gvLineasTicket.MoveLastVisible()

            'Comprobar mínimo de venta del artículo
            Dim MinimoVenta As Integer = DameMinimoVentaArticulo(rLineaTicket.CodigoArticulo)

            If Me.bttCajas.Font.Bold Then
                Dim UnidadesCaja As Decimal = Almacen.DameUnidadesCajaArticulo(rLineaTicket.CodigoArticulo)
                If UnidadesCaja <> 0 Then rLineaTicket.UnidadStock = UnidadesCaja
            End If

            If ArticuloPeso And My.Settings.PuertoBascula <> String.Empty Then
                'Artículo de peso
                rLineaTicket.UnidadStock = Math.Round(Comunicacion.DatosBascula(rLineaTicket.Precio), 2, MidpointRounding.AwayFromZero)
                Me.Enabled = True
                If rLineaTicket.UnidadStock = 0 Then
                    DameCantidad.txtCantidad.EditValue = rLineaTicket.UnidadStock
                    Me.Enabled = False
                    DameCantidad.ShowDialog()
                    rLineaTicket.UnidadStock = ResultadoBusqueda
                End If
            Else
                'Artículo normal
                If CantidadVariable Or CantidadManual Or Me.bttCantidadManual.Font.Bold Or (rLineaTicket.UnidadStock > 0 And rLineaTicket.UnidadStock < MinimoVenta) Then
                    DameCantidad.txtCantidad.EditValue = rLineaTicket.UnidadStock
                    Me.Enabled = False
                    DameCantidad.ShowDialog()
                    rLineaTicket.UnidadStock = ResultadoBusqueda

                    While MinimoVenta > 0 And rLineaTicket.UnidadStock > 0 And rLineaTicket.UnidadStock < MinimoVenta
                        MsgBox("El mínimo de venta del artículo es " & MinimoVenta, MsgBoxStyle.Information, "Mínimo de venta")
                        DameCantidad.txtCantidad.EditValue = rLineaTicket.UnidadStock
                        DameCantidad.ShowDialog()
                        rLineaTicket.UnidadStock = ResultadoBusqueda
                    End While
                End If
            End If

            'Descripción línea
            If rLineaTicket.DescripcionArticulo.Trim = String.Empty Then
                Dim fDescripcion As New fDameDescripcion
                fDescripcion.Texto = rLineaTicket.DescripcionArticulo.Trim
                If fDescripcion.ShowDialog = Windows.Forms.DialogResult.OK Then
                    rLineaTicket.DescripcionArticulo = fDescripcion.Texto
                End If
            End If

            'Precio
            If PrecioManual Or Me.bttPrecioManual.Font.Bold Or rLineaTicket.Precio = 0 Then
                DamePrecio.txtPrecio.EditValue = rLineaTicket.PrecioUniSinIva
                Me.Enabled = False
                If Not PrecioManual And Me.bttPrecioManual.Font.Bold Then System.Console.Beep()
                DamePrecio.ShowDialog()
                rLineaTicket.Precio = ResultadoBusqueda
                rLineaTicket.Precio += rLineaTicket.Precio * rLineaTicket.PorcentajeIVA / 100
                rLineaTicket.Precio = Math.Round(rLineaTicket.Precio, 4, MidpointRounding.AwayFromZero)
                rLineaTicket.PrecioManual = True
            End If

            'Descuento
            If (DtoEnLinea Or Me.bttDescuentoLinea.Font.Bold) Then
                DameDescuento.txtDescuento.EditValue = rLineaTicket.DescuentoLinea
                Me.Enabled = False
                DameDescuento.ShowDialog()
                rLineaTicket.DescuentoLinea = ResultadoBusqueda
            End If

            'Sumar cantidad vendida
            rLineaTicket.UnidadStock += Me.CantidadVendida(rLineaTicket.Id, rLineaTicket.CodigoArticulo, rLineaTicket.DescripcionArticulo, rLineaTicket.CodigoColor, rLineaTicket.NumeroTalla, rLineaTicket.Precio, rLineaTicket.DescuentoLinea)

            If rLineaTicket.UnidadStock <> 0 Then

                'Comprueba si tiene promoción fija el artículo
                Promocion = DamePrecioPromocion(rLineaTicket.CodigoArticulo, rLineaTicket.CodigoColor, rLineaTicket.NumeroTalla, rLineaTicket.UnidadStock + Me.CantidadVendida(rLineaTicket.Id, rLineaTicket.CodigoArticulo, rLineaTicket.CodigoColor, rLineaTicket.NumeroTalla, rLineaTicket.Precio, rLineaTicket.DescuentoLinea, False))
                If Promocion.Precio <> 0 Then
                    rLineaTicket.Precio = Promocion.Precio
                    rLineaTicket.Promocion = True
                    If Not DtoSobrePromociones Then rLineaTicket.DescuentoLinea = 0
                    'Sumar cantidad vendida
                    rLineaTicket.UnidadStock += Me.CantidadVendida(rLineaTicket.Id, rLineaTicket.CodigoArticulo, rLineaTicket.DescripcionArticulo, rLineaTicket.CodigoColor, rLineaTicket.NumeroTalla, rLineaTicket.Precio, rLineaTicket.DescuentoLinea)
                End If

                'Equivalencia doble unidad
                rLineaTicket.Cantidad = rLineaTicket.UnidadStock * Equivalencia

                'Almacenar datos de última línea
                If EsUltimaLinea Then Me.GuardaUltimaLinea(rLineaTicket)

                'Actualiza total línea
                Me.ActualizaTotalLinea(rLineaTicket)

            Else
                'Elimina línea
                rLineaTicket.Delete()
                Me.gvLineasTicket.RefreshData()
                Me.TotalTicket()
            End If

            'ENVASE
            If CodigoEnvase <> String.Empty Then
                NuevaLineaTicket(CodigoEnvase, rLineaTicket.UnidadStock, -1, -1, True)
                CodigoEnvase = String.Empty
            End If

            Me.ActivaDesactivaMenu(True)
            Me.txtCodigoArticulo.Focus()
            Me.ReiniciaAccesos()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            Me.Enabled = True
        End Try
    End Sub
#End Region

#Region "NuevaLineaTicket-Bascula-Promoción..."
    Private Sub NuevaLineaTicket(ByVal CodigoArticulo As String, ByVal Cantidad As Decimal, ByVal Precio As Decimal, ByVal Promocion As Boolean, Optional ByVal LineaTratada As Boolean = False, Optional ByVal ImporteExacto As Decimal = 0)

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            'Comprobar que exista código de artículo
            cmd.CommandText = "SELECT COUNT(Id) FROM ARTICULOS WHERE Codigo='" & CodigoArticulo & "'"
            If cmd.ExecuteScalar = 0 Then Exit Try

            'Nueva línea de ticket
            Dim rLineaTicket As dsTickets.TICKETS_LINEASRow
            rLineaTicket = Me.DsTickets.TICKETS_LINEAS.NewRow

            rLineaTicket.Ticket_Id = rTicket.Id
            rLineaTicket.CodigoArticulo = CodigoArticulo

            'Mostrar datos del artículo seleccionado
            cmd.CommandText = "SELECT Descripcion, TipoIVA, DtoFidelizacion, ImporteEcoraee, Equivalencia FROM ARTICULOS WHERE Codigo='" & rLineaTicket.CodigoArticulo & "'"
            dr = cmd.ExecuteReader
            If dr.Read() Then
                rLineaTicket.DescripcionArticulo = dr("Descripcion")
                rLineaTicket.PorcentajeIVA = dr("TipoIVA")
                rLineaTicket.DtoFidelizacion = dr("DtoFidelizacion")
                rLineaTicket.ImporteEcoraee = dr("ImporteEcoraee")
                rLineaTicket.UnidadStock = Cantidad
                rLineaTicket.Cantidad = rLineaTicket.UnidadStock * CDec(dr("Equivalencia"))
                rLineaTicket.Precio = Precio
            End If
            dr.Close()

            rLineaTicket.CodigoEmleado = Me.txtCodigoEmpleado.EditValue

            'Obtener pocentaje IVA
            cmd.CommandText = "SELECT TipoIva" & rLineaTicket.PorcentajeIVA & " FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
            rLineaTicket.PorcentajeIVA = cmd.ExecuteScalar

            Me.ActualizaTotalLinea(rLineaTicket)
            rLineaTicket.Promocion = Promocion
            rLineaTicket.LineaTratada = LineaTratada
            If ImporteExacto <> 0 Then
                rLineaTicket.UnidadStock = 1
                rLineaTicket.Cantidad = 1
                rLineaTicket.Precio = ImporteExacto
                rLineaTicket.Importe = ImporteExacto
                If Precio <> 0 Then
                    rLineaTicket.Peso = Math.Round(ImporteExacto / Precio, 4, MidpointRounding.AwayFromZero)
                End If
            End If

            Me.DsTickets.TICKETS_LINEAS.AddTICKETS_LINEASRow(rLineaTicket)

            Me.txtCodigoArticulo.EditValue = String.Empty
            Me.txtCodigoArticulo.Focus()
            Me.ReiniciaAccesos()

            ActivaDesactivaMenu(True)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Sub
#End Region

#Region "txtCodigoArticulo_Validated"
    Private Sub txtCodigoArticulo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoArticulo.Validated
        Try
            RemoveHandler txtCodigoArticulo.Validated, AddressOf txtCodigoArticulo_Validated

            If Not Me.txtCodigoArticulo.IsModified Or Me.txtCodigoArticulo.Text = String.Empty Then Me.txtCodigoArticulo.Focus() : Exit Sub

            'Comprobar si comienza con un carácter especial
            If Len(Me.txtCodigoArticulo.EditValue) = 1 And (Mid(Me.txtCodigoArticulo.EditValue, 1, 1) = "+" Or Mid(Me.txtCodigoArticulo.EditValue, 1, 1) = "-") Then Me.txtCodigoArticulo.EditValue &= "1"
            If (Mid(Me.txtCodigoArticulo.EditValue, 1, 1) = "+" Or Mid(Me.txtCodigoArticulo.EditValue, 1, 1) = "-") And IsNumeric(Mid(Me.txtCodigoArticulo.EditValue, 2)) And Me.gvLineasTicket.RowCount > 0 Then

                'Añadir o restar cantidad al último artículo leído
                If Me.UltimaLinea.CodigoArticulo <> String.Empty Then

                    Dim rDuplicaLinea As dsTickets.TICKETS_LINEASRow
                    rDuplicaLinea = Me.DsTickets.TICKETS_LINEAS.NewTICKETS_LINEASRow
                    rDuplicaLinea.Ticket_Id = rTicket.Id
                    rDuplicaLinea.CodigoArticulo = Me.UltimaLinea.CodigoArticulo
                    rDuplicaLinea.DescripcionArticulo = Me.UltimaLinea.DescripcionArticulo
                    rDuplicaLinea.CodigoColor = Me.UltimaLinea.CodigoColor
                    rDuplicaLinea.NumeroTalla = Me.UltimaLinea.NumeroTalla
                    rDuplicaLinea.PrecioManual = Me.UltimaLinea.PrecioManual
                    rDuplicaLinea.Precio = Me.UltimaLinea.Precio
                    rDuplicaLinea.DescuentoLinea = Me.UltimaLinea.DescuentoLinea
                    rDuplicaLinea.PorcentajeIVA = Me.UltimaLinea.PorcentajeIVA
                    rDuplicaLinea.Promocion = Me.UltimaLinea.Promocion
                    rDuplicaLinea.CodigoEmleado = Me.txtCodigoEmpleado.EditValue
                    rDuplicaLinea.DtoFidelizacion = Me.UltimaLinea.DtoFidelizacion
                    rDuplicaLinea.ImporteEcoraee = Me.UltimaLinea.ImporteEcoraee

                    Me.DsTickets.TICKETS_LINEAS.AddTICKETS_LINEASRow(rDuplicaLinea)

                    rDuplicaLinea.UnidadStock = Me.txtCodigoArticulo.EditValue
                    rDuplicaLinea.UnidadStock += Me.CantidadVendida(rDuplicaLinea.Id, rDuplicaLinea.CodigoArticulo, rDuplicaLinea.DescripcionArticulo, rDuplicaLinea.CodigoColor, rDuplicaLinea.NumeroTalla, rDuplicaLinea.Precio, rDuplicaLinea.DescuentoLinea)

                    If rDuplicaLinea.UnidadStock > 0 Then

                        'Comprueba si tiene promoción fija el artículo
                        Dim Promocion As Almacen.DatosPromocion = Nothing
                        Promocion = DamePrecioPromocion(rDuplicaLinea.CodigoArticulo, rDuplicaLinea.CodigoColor, rDuplicaLinea.NumeroTalla, rDuplicaLinea.UnidadStock + Me.CantidadVendida(rDuplicaLinea.Id, rDuplicaLinea.CodigoArticulo, rDuplicaLinea.CodigoColor, rDuplicaLinea.NumeroTalla, rDuplicaLinea.Precio, rDuplicaLinea.DescuentoLinea, False))
                        If Promocion.Precio <> 0 Then
                            rDuplicaLinea.Precio = Promocion.Precio
                            rDuplicaLinea.Promocion = True
                            If Not DtoSobrePromociones Then rDuplicaLinea.DescuentoLinea = 0
                            'Sumar cantidad vendida
                            rDuplicaLinea.UnidadStock += Me.CantidadVendida(rDuplicaLinea.Id, rDuplicaLinea.CodigoArticulo, rDuplicaLinea.DescripcionArticulo, rDuplicaLinea.CodigoColor, rDuplicaLinea.NumeroTalla, rDuplicaLinea.Precio, rDuplicaLinea.DescuentoLinea)
                        End If

                        'Equivalencia doble unidad
                        rDuplicaLinea.Cantidad = rDuplicaLinea.UnidadStock * DameEquivalenciaArticulo(rDuplicaLinea.CodigoArticulo)

                        'Actualiza total línea
                        Me.ActualizaTotalLinea(rDuplicaLinea)

                    Else
                        'Elimina línea
                        rDuplicaLinea.Delete()
                        Me.gvLineasTicket.RefreshData()
                        Me.TotalTicket()
                    End If

                End If

                Me.txtCodigoArticulo.EditValue = String.Empty
                Me.txtCodigoArticulo.Focus()
                Exit Sub
            End If

            Dim CodigoArticulo As String = String.Empty, CodigoColor As Integer = -1, NumeroTalla As Integer = -1, ControlBaja As Boolean, ArticuloPeso As Boolean

            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            'Comprobar si es un código de barras de báscula
            Dim PesoBascula As Decimal = 0, ImporteBascula As Decimal = 0, PrecioTarifa As Decimal = 0

            If Len(Me.txtCodigoArticulo.EditValue) = 13 And TicketDeBascula Then

                'Buscar si existe prefijo en parámetros de báscula
                Dim dsTiendas As New dsTiendas
                Dim rParametros As dsTiendas.PARAMETROS_BASCULARow

                cmd.CommandText = "SELECT * FROM PARAMETROS_BASCULA WHERE Prefijo='" & Mid(Me.txtCodigoArticulo.Text, 1, 2) & "'"

                dsTiendas.PARAMETROS_BASCULA.Load(cmd.ExecuteReader)

                If dsTiendas.PARAMETROS_BASCULA.Count > 0 Then

                    rParametros = dsTiendas.PARAMETROS_BASCULA(0)

                    If Not rParametros.IsPosInicial_ArticuloNull And Not rParametros.IsPosFinal_ArticuloNull Then

                        CodigoArticulo = Mid(Me.txtCodigoArticulo.Text, rParametros.PosInicial_Articulo, rParametros.PosFinal_Articulo - rParametros.PosInicial_Articulo + 1)

                        'If IsNumeric(CodigoArticulo) Then CodigoArticulo = Format(CInt(CodigoArticulo), "0000000")

                        If Not rParametros.IsPosInicial_PesoNull And Not rParametros.IsPosFinal_PesoNull Then
                            PesoBascula = Mid(Me.txtCodigoArticulo.Text, rParametros.PosInicial_Peso, rParametros.PosFinal_Peso - rParametros.PosInicial_Peso + 1) / 100
                        End If

                        If Not rParametros.IsPosInicial_ImporteNull And Not rParametros.IsPosFinal_ImporteNull Then
                            ImporteBascula = Mid(Me.txtCodigoArticulo.Text, rParametros.PosInicial_Importe, rParametros.PosFinal_Importe - rParametros.PosInicial_Importe + 1) / 100
                        End If

                    End If

                ElseIf IsNumeric(Mid(Me.txtCodigoArticulo.EditValue, 8, 5)) And (Mid(Me.txtCodigoArticulo.EditValue, 1, 2) = PrefijoBascula1 Or Mid(Me.txtCodigoArticulo.EditValue, 1, 2) = PrefijoBascula2 Or Mid(Me.txtCodigoArticulo.EditValue, 1, 2) = PrefijoBascula3) Then

                    'Mostrar información del artículo
                    If General.FormatoEmpresa = 2 Then
                        CodigoArticulo = Me.CodigoBarrasCalavia()
                    Else
                        CodigoArticulo = "00" & Mid(Me.txtCodigoArticulo.Text, 3, 5)
                    End If

                    If Len(Me.txtCodigoArticulo.EditValue) = 13 Then ImporteBascula = CDec(Mid(Me.txtCodigoArticulo.EditValue, 8, 5)) / 100

                End If

                If CodigoArticulo <> String.Empty Then

                    cmd.CommandText = "SELECT Codigo, ControlBaja, ArticuloPeso, Precio FROM Articulos WHERE Codigo='" & CodigoArticulo & "'"

                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        CodigoArticulo = dr("Codigo")
                        ControlBaja = dr("ControlBaja")
                        ArticuloPeso = dr("ArticuloPeso")
                        PrecioTarifa = dr("Precio")
                    Else
                        CodigoArticulo = String.Empty
                        ControlBaja = False
                        ArticuloPeso = False
                        PrecioTarifa = 0
                    End If
                    dr.Close()

                    'Permitir vender aunque tenga control de baja
                    ControlBaja = False

                    If ControlBaja Then
                        MsgBox("Artículo marcado con control de baja", MsgBoxStyle.Information, "Control de Baja")
                        Me.txtCodigoArticulo.Text = String.Empty
                        Me.txtCodigoArticulo.Focus()
                        Exit Sub
                    ElseIf CodigoArticulo <> String.Empty Then
                        If ArticuloPeso And My.Settings.PuertoBascula <> String.Empty Then
                            Me.NuevaLineaTicket(CodigoArticulo, 1, CodigoColor, NumeroTalla, True)
                        ElseIf PesoBascula <> 0 Then
                            Me.NuevaLineaTicket(CodigoArticulo, PesoBascula, CodigoColor, NumeroTalla, True)
                        ElseIf ImporteBascula <> 0 Then
                            Me.NuevaLineaTicket(CodigoArticulo, 1, PrecioTarifa, False, , ImporteBascula)
                        Else
                            Me.NuevaLineaTicket(CodigoArticulo, 1, CodigoColor, NumeroTalla, True)
                        End If
                    Else
                        MsgBox("No existe ningún artículo asociado con ese código", MsgBoxStyle.Information, "No existe")
                        Me.txtCodigoArticulo.Text = String.Empty
                        Me.txtCodigoArticulo.Focus()
                    End If

                    Exit Sub

                End If

            End If

            'Comprobar si es un código de barras de etiqueta
            If Len(Me.txtCodigoArticulo.EditValue) = 13 And IsNumeric(Mid(Me.txtCodigoArticulo.EditValue, 8)) And Mid(Me.txtCodigoArticulo.EditValue, 1, 2) = PrefijoEtiqueta Then

                'Mostrar información del artículo
                CodigoArticulo = Mid(Me.txtCodigoArticulo.Text, 3, 7)
                If GestionColores Then CodigoColor = Int(Mid(Me.txtCodigoArticulo.EditValue, 10, 2))
                If GestionTallas Then NumeroTalla = Int(Mid(Me.txtCodigoArticulo.EditValue, 12, 2))

                cmd.CommandText = "SELECT Codigo, ControlBaja FROM Articulos WHERE Codigo='" & CodigoArticulo & "'"

                dr = cmd.ExecuteReader
                If dr.Read Then
                    CodigoArticulo = dr("Codigo")
                    ControlBaja = dr("ControlBaja")
                Else
                    CodigoArticulo = String.Empty
                End If
                dr.Close()

                'Permitir vender aunque tenga control de baja
                ControlBaja = False

                If ControlBaja Then
                    MsgBox("Artículo marcado con control de baja", MsgBoxStyle.Information, "Control de Baja")
                    Me.txtCodigoArticulo.Text = String.Empty
                    Me.txtCodigoArticulo.Focus()
                    Exit Sub
                ElseIf CodigoArticulo <> String.Empty Then
                    Me.NuevaLineaTicket(CodigoArticulo, 1, CodigoColor, NumeroTalla, True)
                Else
                    MsgBox("No existe ningún artículo asociado con ese código", MsgBoxStyle.Information, "No existe")
                    Me.txtCodigoArticulo.Text = String.Empty
                    Me.txtCodigoArticulo.Focus()
                End If

                Exit Sub
            End If

            'Mostrar información del artículo
            cmd.CommandText = "SELECT Codigo, ControlBaja FROM Articulos WHERE Codigo='" & Me.txtCodigoArticulo.EditValue & "'"
            dr = cmd.ExecuteReader
            If dr.Read Then
                CodigoArticulo = dr("Codigo")
                ControlBaja = dr("ControlBaja")
            End If
            dr.Close()

            'Comprobar si es un código de barras
            If CodigoArticulo = String.Empty Then

                cmd.CommandText = "SELECT Codigo, ISNULL(CodigoColor,-1) AS CodigoColor, ISNULL(Codigo_Barras.CodigoTalla,-1) AS CodigoTalla, ControlBaja " & _
                                  "FROM Articulos INNER JOIN Codigo_Barras on Articulos.Id=Codigo_Barras.Articulo_Id " & _
                                  "WHERE Codigo_Barras.Codigobarras='" & Me.txtCodigoArticulo.EditValue & "'"

                dr = cmd.ExecuteReader
                If dr.Read Then
                    CodigoArticulo = dr("Codigo")
                    CodigoColor = dr("CodigoColor")
                    NumeroTalla = dr("CodigoTalla")
                    CodigoArticulo = dr("Codigo")
                    ControlBaja = dr("ControlBaja")
                End If
                dr.Close()

                If CodigoArticulo = String.Empty And DatosTienda.FormatoEmpresa = "3" Then
                    If Me.CodigoBarrasMolina() Then Exit Sub
                End If

                'Permitir vender aunque tenga control de baja
                ControlBaja = False

                If ControlBaja Then
                    MsgBox("Artículo marcado con control de baja", MsgBoxStyle.Information, "Control de Baja")
                    Me.txtCodigoArticulo.Text = String.Empty
                    Me.txtCodigoArticulo.Focus()
                    Exit Sub
                ElseIf CodigoArticulo <> String.Empty Then
                    NuevaLineaTicket(CodigoArticulo, 1, CodigoColor, NumeroTalla, True)
                Else
                    Dim resultado As Integer = MsgBoxResult.Cancel
                    While resultado = MsgBoxResult.Cancel
                        System.Console.Beep()
                        resultado = MsgBox("No existe ningún artículo asociado a ese código de barras" & vbCrLf & "¿Desea asignarlo a un artículo?", MsgBoxStyle.Information + MsgBoxStyle.YesNoCancel + MsgBoxStyle.DefaultButton3, "No existe")
                        If resultado = MsgBoxResult.Yes Then
                            AsignaCodigoBarras(Me.txtCodigoArticulo.EditValue)
                        ElseIf resultado = MsgBoxResult.No Then
                            Me.txtCodigoArticulo.Text = String.Empty
                            Me.txtCodigoArticulo.Focus()
                        End If
                    End While
                End If

                Exit Sub
            End If

            'Permitir vender aunque tenga control de baja
            ControlBaja = False

            If ControlBaja Then
                MsgBox("Artículo marcado con control de baja", MsgBoxStyle.Information, "Control de Baja")
                Me.txtCodigoArticulo.Text = String.Empty
                Me.txtCodigoArticulo.Focus()
                Exit Sub
            ElseIf CodigoArticulo <> String.Empty Then
                NuevaLineaTicket(CodigoArticulo, 1, CodigoColor, NumeroTalla, True)
            Else
                MsgBox("No existe ningún artículo asociado con ese código", MsgBoxStyle.Information, "No existe")
                Me.txtCodigoArticulo.Text = String.Empty
                Me.txtCodigoArticulo.Focus()
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            AddHandler txtCodigoArticulo.Validated, AddressOf txtCodigoArticulo_Validated
        End Try

    End Sub
#End Region

#Region "bttBorrarTicket_Click"
    Private Sub bttBorrarTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBorrarTicket.Click
        Try
            If MsgBox("¿Seguro que desea eliminar el ticket activo?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar ticket") = MsgBoxResult.No Then
                Me.txtCodigoArticulo.Focus()
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor

            'Guardar ticket en histórico de eliminados
            Me.TICKETSBindingSource.EndEdit()
            Me.TICKETSLINEASBindingSource.EndEdit()

            'Eliminar cabecera ticket
            If Me.DsTickets.TICKETS.Rows.Count > 0 Then

                Dim taAnulados As New dsTicketsTableAdapters.HISTORICO_TICKETS_ANULADOSTableAdapter
                Dim taAnulados_Lineas As New dsTicketsTableAdapters.HISTORICO_TICKETS_ANULADOS_LINEASTableAdapter
                Dim rCabecera As dsTickets.HISTORICO_TICKETS_ANULADOSRow
                Dim rLinea As dsTickets.HISTORICO_TICKETS_ANULADOS_LINEASRow

                Try
                    'Cabecera
                    For i As Integer = 0 To Me.DsTickets.TICKETS.Count - 1

                        If Me.DsTickets.TICKETS(i).RowState = DataRowState.Deleted Then Continue For

                        rCabecera = Me.DsTickets.HISTORICO_TICKETS_ANULADOS.NewHISTORICO_TICKETS_ANULADOSRow

                        For col As Integer = 0 To Me.DsTickets.HISTORICO_TICKETS_ANULADOS.Columns.Count - 1
                            With Me.DsTickets.HISTORICO_TICKETS_ANULADOS.Columns(col)
                                rCabecera.Item(.ColumnName) = Me.DsTickets.TICKETS(i).Item(.ColumnName)
                            End With
                        Next

                        'Validar ticket
                        rCabecera.CodigoTienda = CodigoTienda
                        rCabecera.CodigoCaja = CodigoCaja
                        rCabecera.FechaTicket = Date.Today
                        rCabecera.HoraTicket = Date.Now
                        rCabecera.NumeroLineas = Me.DsTickets.TICKETS_LINEAS.Rows.Count
                        rCabecera.ImporteTotal = Me.txtTotal.EditValue
                        rCabecera.EnEspera = False

                        Dim conexion As New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                        Dim cmd As New SqlClient.SqlCommand

                        Try
                            conexion.Open()
                            cmd.Connection = conexion
                            cmd.CommandText = "SELECT NumeroTicket FROM CAJAS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & CodigoCaja

                            rCabecera.NumeroTicket = cmd.ExecuteScalar + 1

                        Catch ex As Exception
                            'Error al guardar nº de ticket
                        Finally
                            If conexion.State = ConnectionState.Open Then conexion.Close()
                        End Try

                        Me.DsTickets.HISTORICO_TICKETS_ANULADOS.AddHISTORICO_TICKETS_ANULADOSRow(rCabecera)

                    Next

                    'Líneas
                    For i As Integer = 0 To Me.DsTickets.TICKETS_LINEAS.Count - 1

                        If Me.DsTickets.TICKETS_LINEAS(i).RowState = DataRowState.Deleted Then Continue For

                        rLinea = Me.DsTickets.HISTORICO_TICKETS_ANULADOS_LINEAS.NewHISTORICO_TICKETS_ANULADOS_LINEASRow

                        For col As Integer = 0 To Me.DsTickets.HISTORICO_TICKETS_ANULADOS_LINEAS.Columns.Count - 1
                            With Me.DsTickets.HISTORICO_TICKETS_ANULADOS_LINEAS.Columns(col)
                                rLinea.Item(.ColumnName) = Me.DsTickets.TICKETS_LINEAS(i).Item(.ColumnName)
                            End With
                        Next

                        Me.DsTickets.HISTORICO_TICKETS_ANULADOS_LINEAS.AddHISTORICO_TICKETS_ANULADOS_LINEASRow(rLinea)

                    Next

                    taAnulados.Update(Me.DsTickets.HISTORICO_TICKETS_ANULADOS)
                    taAnulados_Lineas.Update(Me.DsTickets.HISTORICO_TICKETS_ANULADOS_LINEAS)

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try

                Me.DsTickets.TICKETS.Rows(0).Delete()

            End If

            Me.TICKETSTableAdapter.Update(Me.DsTickets.TICKETS)
            Me.TICKETS_LINEASTableAdapter.Update(Me.DsTickets.TICKETS_LINEAS)

            Me.NuevoTicket()

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox("Error al eliminar el ticket", MsgBoxStyle.Exclamation, "Eliminar ticket")
        End Try
    End Sub
#End Region

#Region "SeleccionaCaja"
    Private Function SeleccionaCaja()

        Dim cancela As Boolean
        Dim CajasAbiertas As Integer

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            cmd.Connection.Open()

            cmd.CommandText = "SELECT COUNT(CodigoCaja) FROM CAJAS WHERE CodigoTienda=" & CodigoTienda & " AND CajaCerrada = 0"
            CajasAbiertas = cmd.ExecuteScalar

            If CajasAbiertas = 0 Then
                MsgBox("Todas las cajas están cerradas", MsgBoxStyle.Information)
                cancela = True
            ElseIf CajasAbiertas = 1 Then
                cmd.CommandText = "SELECT CodigoCaja FROM CAJAS WHERE CodigoTienda=" & CodigoTienda & " AND CajaCerrada = 0"
                CodigoCaja = cmd.ExecuteScalar
                Me.txtCodigoCaja.EditValue = CodigoCaja
            Else
                If DameCaja.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.txtCodigoCaja.EditValue = CodigoCaja
                Else
                    cancela = True
                End If
            End If

            Return Not cancela

        Catch ex As Exception
            MsgBox("Error al seleccionar caja", MsgBoxStyle.Exclamation, "Selecciona caja")
            Return False
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Function
#End Region

#Region "SeleccionaEmpleado"
    Private Function SeleccionaEmpleado()

        Dim cancela As Boolean

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            cmd.Connection.Open()

            cmd.CommandText = "SELECT Count(Codigo) FROM OPERARIOS"
            If cmd.ExecuteScalar = 1 Then
                cmd.CommandText = "SELECT * FROM OPERARIOS"
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    Me.txtCodigoEmpleado.EditValue = dr("Codigo")
                    Me.txtNombreTicket.Caption = dr("NombreTicket")
                End If
                dr.Close()
            Else
                Me.Enabled = False
                If DameEmpleado.ShowDialog = Windows.Forms.DialogResult.OK Then
                    cmd.CommandText = "SELECT * FROM OPERARIOS WHERE Codigo=" & CodigoEmpleado
                    dr = cmd.ExecuteReader
                    If dr.Read() Then
                        Me.txtCodigoEmpleado.EditValue = dr("Codigo")
                        Me.txtNombreTicket.Caption = dr("NombreTicket")
                    End If
                    dr.Close()
                Else
                    cancela = True
                End If
                Me.Enabled = True
            End If

            Return Not cancela

        Catch ex As Exception
            MsgBox("Error al seleccionar empleado", MsgBoxStyle.Exclamation, "Selecciona empleado")
            Return False
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Function
#End Region

#Region "bttBorraLinea_Click"
    Private Sub bttBorraLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBorraLinea.Click
        Try
            If Me.gvLineasTicket.GetFocusedRow Is Nothing Then Exit Sub

            If MsgBox("¿Seguro que desea eliminar la línea seleccionada?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminar línea") = MsgBoxResult.No Then
                Me.txtCodigoArticulo.Focus()
                Exit Sub
            End If

            Me.gvLineasTicket.DeleteRow(Me.gvLineasTicket.FocusedRowHandle)

            'Dim NumeroLinea As Integer = Me.gvLineasTicket.FocusedRowHandle
            'Dim rLineaTicket As dsTickets.TICKETS_LINEASRow

            'rLineaTicket = Me.DsTickets.TICKETS_LINEAS.Rows(NumeroLinea)
            'rLineaTicket.Delete()

            Me.ActivaDesactivaMenu(True)
            Me.txtCodigoArticulo.Focus()

        Catch ex As Exception
            MsgBox("Error al eliminar línea", MsgBoxStyle.Exclamation, "Eliminar línea")
        End Try
    End Sub
#End Region

#Region "bttPrecioManual_Click"
    Private Sub bttPrecioManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttPrecioManual.Click
        If Me.bttPrecioManual.ForeColor = Color.Maroon Then
            Me.bttPrecioManual.Font = New Font(Me.bttPrecioManual.Font, FontStyle.Regular)
            Me.bttPrecioManual.ForeColor = Color.Empty
        Else
            Me.bttPrecioManual.Font = New Font(Me.bttPrecioManual.Font, FontStyle.Bold)
            Me.bttPrecioManual.ForeColor = Color.Maroon
        End If
    End Sub
#End Region

#Region "bttCantidadManual_Click"
    Private Sub bttCantidadManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCantidadManual.Click
        If Me.bttCantidadManual.ForeColor = Color.Maroon Then
            Me.bttCantidadManual.Font = New Font(Me.bttCantidadManual.Font, FontStyle.Regular)
            Me.bttCantidadManual.ForeColor = Color.Empty
        Else
            Me.bttCantidadManual.Font = New Font(Me.bttCantidadManual.Font, FontStyle.Bold)
            Me.bttCantidadManual.ForeColor = Color.Maroon
        End If
    End Sub
#End Region

#Region "bttDescuentoLinea_Click"
    Private Sub bttDescuentoLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttDescuentoLinea.Click
        If Me.bttDescuentoLinea.ForeColor = Color.Maroon Then
            Me.bttDescuentoLinea.Font = New Font(Me.bttDescuentoLinea.Font, FontStyle.Regular)
            Me.bttDescuentoLinea.ForeColor = Color.Empty
        Else
            Me.bttDescuentoLinea.Font = New Font(Me.bttDescuentoLinea.Font, FontStyle.Bold)
            Me.bttDescuentoLinea.ForeColor = Color.Maroon
        End If
    End Sub
#End Region

#Region "bttModificarLinea_Click"
    Private Sub bttModificarLinea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttModificarLinea.Click
        If MsgBox("¿Seguro que desea modificar la línea seleccionada?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                RemoveHandler txtCodigoArticulo.Validated, AddressOf txtCodigoArticulo_Validated

                Me.Enabled = False

                With CType(Me.gvLineasTicket.GetFocusedDataRow, dsTickets.TICKETS_LINEASRow)

                    'Descripción línea
                    Dim fDescripcion As New fDameDescripcion
                    fDescripcion.Texto = .DescripcionArticulo
                    If fDescripcion.ShowDialog = Windows.Forms.DialogResult.OK Then
                        .DescripcionArticulo = fDescripcion.Texto
                    End If

                    'Comprobar mínimo de venta del artículo
                    Dim MinimoVenta As Integer = DameMinimoVentaArticulo(.CodigoArticulo)

                    DameCantidad.txtCantidad.EditValue = .UnidadStock
                    DameCantidad.ShowDialog()
                    .UnidadStock = ResultadoBusqueda

                    While MinimoVenta > 0 And .UnidadStock < MinimoVenta
                        MsgBox("El mínimo de venta del artículo es " & MinimoVenta, MsgBoxStyle.Information, "Mínimo de venta")
                        DameCantidad.txtCantidad.EditValue = .UnidadStock
                        DameCantidad.ShowDialog()
                        .UnidadStock = ResultadoBusqueda
                    End While

                    'Equivalencia doble unidad
                    .Cantidad = .UnidadStock * DameEquivalenciaArticulo(.CodigoArticulo)

                    'Precio sin IVA
                    DamePrecio.txtPrecio.EditValue = .PrecioUniSinIva
                    DamePrecio.ShowDialog()
                    .Precio = ResultadoBusqueda
                    .Precio += .Precio * .PorcentajeIVA / 100
                    .Precio *= .UnidadStock / .Cantidad
                    .Precio = Math.Round(.Precio, 4, MidpointRounding.AwayFromZero)
                    .PrecioManual = True

                    'Descuento
                    DameDescuento.txtDescuento.EditValue = .DescuentoLinea
                    DameDescuento.ShowDialog()
                    .DescuentoLinea = ResultadoBusqueda

                End With

                'Total importe línea
                Me.ActualizaTotalLinea(Me.gvLineasTicket.GetFocusedDataRow)

                Me.Enabled = True

                ActivaDesactivaMenu(True)
                Me.txtCodigoArticulo.Focus()

            Finally
                AddHandler txtCodigoArticulo.Validated, AddressOf txtCodigoArticulo_Validated
            End Try
        End If
    End Sub
#End Region

#Region "TotalTicket"
    Private Sub TotalTicket()

        Dim Total As Decimal = 0

        Try
            Dim Lineas As DataRow() = Me.DsTickets.TICKETS_LINEAS.Select

            For i As Integer = 0 To Lineas.Length - 1
                With CType(Lineas(i), dsTickets.TICKETS_LINEASRow)
                    Total += .Importe
                End With
            Next

        Catch ex As Exception
            MsgBox("Error al calcular total del ticket", MsgBoxStyle.Exclamation, Me.Text)
        Finally
            Me.txtTotal.EditValue = Total
        End Try

    End Sub
#End Region

#Region "lvArticulos_Click"
    Private Sub lvArticulos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvArticulos.Click
        If Me.lvArticulos.GetFocusedRow Is Nothing Then Exit Sub
        Try
            'RemoveHandler txtCodigoArticulo.Validated, AddressOf txtCodigoArticulo_Validated

            Me.txtCodigoArticulo.Text = Me.lvArticulos.GetFocusedRowCellValue(Me.colArticulos_CodigoArticulo)
            Me.txtCodigoArticulo.IsModified = True
            Me.txtCodigoArticulo_Validated(Nothing, Nothing)

        Finally
            'AddHandler txtCodigoArticulo.Validated, AddressOf txtCodigoArticulo_Validated
        End Try
    End Sub
#End Region

#Region "Teclado"
    Private Sub bttNumero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btt0.Click, btt1.Click, btt2.Click, btt3.Click, btt4.Click, btt5.Click, btt6.Click, btt7.Click, btt8.Click, btt9.Click, bttMenos.Click
        SendKeys.Send(sender.text)
    End Sub
    Private Sub bttMas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bttMas.Click
        SendKeys.Send("{+}")
    End Sub
    Private Sub bttBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBorrar.Click
        SendKeys.Send(Chr(Keys.Back))
    End Sub
    Private Sub bttIntro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttIntro.Click
        SendKeys.Send(Chr(Keys.Enter))
    End Sub
#End Region

#Region "AsignaCodigoBarras"
    Private Sub AsignaCodigoBarras(ByVal CodigoBarras As String)
        Try
            RemoveHandler txtCodigoArticulo.Validated, AddressOf txtCodigoArticulo_Validated

            BusquedaArticulos.Tag = "Id"

            Dim resultado As DialogResult = BusquedaArticulos.ShowDialog()
            If resultado = Windows.Forms.DialogResult.Retry Then

                Dim rCodigoBarras As dsArticulos.CODIGO_BARRASRow
                rCodigoBarras = Me.DsArticulos.CODIGO_BARRAS.NewRow

                rCodigoBarras.CodigoBarras = CodigoBarras
                rCodigoBarras.Articulo_Id = ResultadoBusqueda

                Me.DsArticulos.CODIGO_BARRAS.AddCODIGO_BARRASRow(rCodigoBarras)
                CType(New dsArticulosTableAdapters.CODIGO_BARRASTableAdapter, dsArticulosTableAdapters.CODIGO_BARRASTableAdapter).Update(Me.DsArticulos.CODIGO_BARRAS)

                Me.txtCodigoArticulo_Validated(Nothing, Nothing)

            ElseIf resultado = Windows.Forms.DialogResult.OK Then

                Dim ArticuloSeleccionado() As String = Split(ResultadoBusqueda, "+")
                Dim rCodigoBarras As dsArticulos.CODIGO_BARRASRow
                rCodigoBarras = Me.DsArticulos.CODIGO_BARRAS.NewRow

                rCodigoBarras.CodigoBarras = CodigoBarras
                rCodigoBarras.Articulo_Id = ArticuloSeleccionado(0)
                rCodigoBarras.CodigoColor = ArticuloSeleccionado(1)
                rCodigoBarras.CodigoTalla = ArticuloSeleccionado(2)

                Me.DsArticulos.CODIGO_BARRAS.AddCODIGO_BARRASRow(rCodigoBarras)
                CType(New dsArticulosTableAdapters.CODIGO_BARRASTableAdapter, dsArticulosTableAdapters.CODIGO_BARRASTableAdapter).Update(Me.DsArticulos.CODIGO_BARRAS)

                Me.txtCodigoArticulo_Validated(Nothing, Nothing)

            Else

                Me.txtCodigoArticulo.Text = String.Empty
                Me.txtCodigoArticulo.Focus()

            End If

        Finally
            AddHandler txtCodigoArticulo.Validated, AddressOf txtCodigoArticulo_Validated
        End Try
    End Sub
#End Region

#Region "Promocion_Envase"
    Private Sub Promocion_Envase(ByVal rLineaTicket As dsTickets.TICKETS_LINEASRow, ByVal Cantidad As Decimal, ByVal Promocion As Boolean)

        'PROMOCIÓN
        If Promocion And rLineaTicket.CodigoArticuloRegalo <> String.Empty And Cantidad >= (rLineaTicket.FraccionSinCargo + rLineaTicket.UnidadesSinCargo) Then
            NuevaLineaTicket(rLineaTicket.CodigoArticuloRegalo, Int(Cantidad / (rLineaTicket.FraccionSinCargo + rLineaTicket.UnidadesSinCargo)) * rLineaTicket.UnidadesSinCargo, rLineaTicket.PrecioRegalo, True)
        End If

        'ENVASE
        If CodigoEnvase <> String.Empty Then
            NuevaLineaTicket(CodigoEnvase, Cantidad, -1, -1)
            CodigoEnvase = String.Empty
        End If

    End Sub
#End Region

#Region "gvLineasTicket_FocusedRowChanged"
    Private Sub gvLineasTicket_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvLineasTicket.FocusedRowChanged
        InfoArticulo()
    End Sub
#End Region

#Region "gvLineasTicket_InvalidRowException"
    Private Sub gvLineasTicket_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvLineasTicket.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
#End Region

#Region "InfoArticulo"
    Private Sub InfoArticulo()
        Try
            If Me.gvLineasTicket.GetFocusedRow Is Nothing Then
                Me.txtInfoArticulo.Text = String.Empty
                Me.txtInfoPromocion.Text = String.Empty
                Me.ImgPromocion.Visible = False
                Exit Sub
            End If

            Me.txtInfoArticulo.Text = Me.gvLineasTicket.GetFocusedRowCellValue(Me.colCodigoArticulo) & ": " & Me.gvLineasTicket.GetFocusedRowCellValue(Me.colDescripcionArticulo) & vbCrLf
            If GestionColores Then Me.txtInfoArticulo.Text &= "Color: " & DameDescripcionColor(Me.gvLineasTicket.GetFocusedRowCellValue(Me.colCodigocolor)) & ". "
            If GestionTallas Then Me.txtInfoArticulo.Text &= "Talla: " & DameTallaArticulo(Me.gvLineasTicket.GetFocusedRowCellValue(Me.colCodigoArticulo), Me.gvLineasTicket.GetFocusedRowCellValue(Me.colNumeroTalla))
            If Me.gvLineasTicket.GetFocusedRowCellValue(Me.colDescuentoLinea) <> 0 Then Me.txtInfoArticulo.Text += IIf(GestionTallas Or GestionColores, ". ", "") & "Descuento: " & Math.Round(Me.gvLineasTicket.GetFocusedRowCellValue(Me.colDescuentoLinea), 2) & "% "

            Dim Promocion As Almacen.DatosPromocion
            Promocion = DamePrecioPromocion(Me.gvLineasTicket.GetFocusedRowCellValue(Me.colCodigoArticulo), Me.gvLineasTicket.GetFocusedRowCellValue(Me.colCodigocolor), Me.gvLineasTicket.GetFocusedRowCellValue(Me.colNumeroTalla))
            If Promocion.CodigoArticuloRegalo <> String.Empty Then
                Me.txtInfoPromocion.Visible = True
                Me.txtInfoPromocion.Text = "Por " & Int(Promocion.FraccionSinCargo) & " unidades, promoción: " & Int(Promocion.UnidadesSinCargo) & " de " & Almacen.DameDescripcionArticulo(Promocion.CodigoArticuloRegalo) & IIf(Promocion.PrecioArticuloRegalo <> 0, " a " & Math.Round(Promocion.PrecioArticuloRegalo, DecimalesPrecio, MidpointRounding.AwayFromZero), "")
            Else
                Me.txtInfoPromocion.Visible = False
            End If

            Me.ImgPromocion.Visible = Me.gvLineasTicket.GetFocusedRowCellValue(Me.colPromocion)

        Catch ex As Exception
            MsgBox("Error al mostrar información del artículo", MsgBoxStyle.Information, "Información del artículo")
        End Try
    End Sub
#End Region

#Region "gvLineasTicket_CustomDrawCell"
    Private Sub gvLineasTicket_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvLineasTicket.CustomDrawCell
        Try
            If Not IsNothing(Me.gvLineasTicket.GetDataRow(e.RowHandle)) Then
                Select Case e.Column.Name
                    Case Me.colCantidad.Name
                        Dim Promocion As Almacen.DatosPromocion
                        Promocion = DamePrecioPromocion(Me.gvLineasTicket.GetRowCellValue(e.RowHandle, Me.colCodigoArticulo), Me.gvLineasTicket.GetRowCellValue(e.RowHandle, Me.colCodigocolor), Me.gvLineasTicket.GetRowCellValue(e.RowHandle, Me.colNumeroTalla), Me.gvLineasTicket.GetRowCellValue(e.RowHandle, Me.colCantidad))
                        If Promocion.CodigoArticuloRegalo <> String.Empty Then
                            e.Graphics.FillRectangle(Brushes.PaleGreen, e.Bounds)
                        Else
                            e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds)
                        End If
                    Case Me.colImporte.Name
                        If Me.gvLineasTicket.GetRowCellValue(e.RowHandle, Me.colPromocion) = True Then
                            e.Graphics.FillRectangle(Brushes.PaleGreen, e.Bounds)
                        ElseIf Me.gvLineasTicket.GetRowCellValue(e.RowHandle, Me.colDescuentoLinea) <> 0 Then
                            e.Graphics.FillRectangle(Brushes.LemonChiffon, e.Bounds)
                        Else
                            e.Graphics.FillRectangle(Brushes.Transparent, e.Bounds)
                        End If
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "bttTicketEspera_Click"
    Private Sub bttTicketEspera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttTicketEspera.Click

        If Me.DsTickets.TICKETS_LINEAS.Rows.Count > 0 Then

            If MsgBox("¿Seguro que desea dejar el ticket en espera?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Ticket en espera") = MsgBoxResult.No Then Exit Sub
            Me.Cursor = Cursors.WaitCursor

            Try
                'Dejar ticket en espera
                rTicket.CodigoTienda = CodigoTienda
                rTicket.CodigoCaja = CodigoCaja
                rTicket.FechaTicket = Date.Today
                rTicket.HoraTicket = Date.Now
                rTicket.NumeroLineas = Me.DsTickets.TICKETS_LINEAS.Rows.Count
                rTicket.ImporteTotal = Me.txtTotal.EditValue
                rTicket.EnEspera = True

                'Control tarjetas
                If Me.txtCodigoCliente.EditValue = 0 And ControlTarjetas Then
                    Dim fTarjeta As New DameCliente
                    If fTarjeta.ShowDialog = Windows.Forms.DialogResult.OK Then
                        rTicket.CodigoCliente = fTarjeta.CodigoCliente
                    End If
                End If

                'Guardar ticket
                Me.TICKETSBindingSource.EndEdit()
                Me.TICKETSTableAdapter.Update(Me.DsTickets.TICKETS)

                'Guardar líneas del ticket
                Me.TICKETSLINEASBindingSource.EndEdit()
                Me.TICKETS_LINEASTableAdapter.Update(Me.DsTickets.TICKETS_LINEAS)

                'Actualizar Stock
                Dim Lineas As DataRow() = Me.DsTickets.TICKETS_LINEAS.Select
                For i As Integer = 0 To Lineas.Length - 1
                    With CType(Lineas(i), dsTickets.TICKETS_LINEASRow)
                        If Not .IsPesoNull Then
                            ActualizaStock(.CodigoArticulo, .CodigoColor, .NumeroTalla, .Peso * -1)
                        Else
                            ActualizaStock(.CodigoArticulo, .CodigoColor, .NumeroTalla, .UnidadStock * -1)
                        End If
                    End With
                Next

            Catch ex As Exception
                MsgBox("Error al dejar ticket en espera." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            Finally
                Me.Cursor = Cursors.Default
            End Try

            'Nuevo ticket en pantalla
            Me.NuevoTicket()

        Else

            Dim conexion As New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            conexion.Open()
            Dim transaccion As SqlClient.SqlTransaction
            transaccion = conexion.BeginTransaction()

            Try
                Me.Cursor = Cursors.WaitCursor

                If TicketsEnEspera.ShowDialog = Windows.Forms.DialogResult.OK Then

                    Me.DsTickets.Clear()

                    Me.TICKETSTableAdapter.DameTicket(Me.DsTickets.TICKETS, ResultadoBusqueda)
                    Me.TICKETS_LINEASTableAdapter.DameLineasTicket(Me.DsTickets.TICKETS_LINEAS, ResultadoBusqueda)

                    Me.DsTickets.TICKETS_LINEAS.Ticket_IdColumn.DefaultValue = ResultadoBusqueda

                    If Me.DsTickets.TICKETS.Rows.Count > 0 Then

                        'Cabecera ticket
                        rTicket = Me.DsTickets.TICKETS.Rows(0)

                        'Líneas ticket como nuevas
                        Dim i As Integer
                        Me.DsTickets.TICKETS.Rows(0).SetAdded()
                        For i = 0 To Me.DsTickets.TICKETS_LINEAS.Rows.Count - 1
                            Me.DsTickets.TICKETS_LINEAS.Rows(i).SetAdded()
                        Next

                        'Recuperar Stock
                        Dim Lineas As DataRow() = Me.DsTickets.TICKETS_LINEAS.Select
                        For i = 0 To Lineas.Length - 1
                            With CType(Lineas(i), dsTickets.TICKETS_LINEASRow)
                                If Not .IsPesoNull Then
                                    ActualizaStock(.CodigoArticulo, .CodigoColor, .NumeroTalla, .Peso)
                                Else
                                    ActualizaStock(.CodigoArticulo, .CodigoColor, .NumeroTalla, .UnidadStock)
                                End If
                            End With
                        Next

                    End If

                    'Elimina ticket de la base de datos
                    Dim cmd As New SqlClient.SqlCommand
                    cmd.Connection = conexion
                    cmd.Transaction = transaccion
                    'Elimna líneas del ticket
                    cmd.CommandText = "DELETE TICKETS_LINEAS WHERE Ticket_Id=" & ResultadoBusqueda
                    cmd.ExecuteNonQuery()
                    'Elimnar ticket
                    cmd.CommandText = "DELETE TICKETS WHERE Id=" & ResultadoBusqueda
                    cmd.ExecuteNonQuery()

                    transaccion.Commit()

                    'Desactivar menu
                    Me.ActivaDesactivaMenu(True)
                    Me.bttPrecioManual.Enabled = IIf(PrecioManual, False, True)
                    Me.bttCantidadManual.Enabled = IIf(CantidadManual, False, True)
                    Me.bttDescuentoLinea.Enabled = IIf(DtoEnLinea, False, True)

                    DatosCajaActual(CodigoCaja)

                    Me.txtCodigoCliente_Validated(Me.txtCodigoCliente, Nothing)
                    Me.txtCodigoArticulo.Focus()

                End If

            Catch ex As Exception
                transaccion.Rollback()
                System.Windows.Forms.MessageBox.Show(ex.Message)
            Finally
                Me.Cursor = Cursors.Default
            End Try

            conexion.Close()

        End If

    End Sub
#End Region

#Region "ExistenTicketsEnEspera"
    Function ExistenTicketsEnEspera()
        Try
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT Count(Id) FROM Tickets WHERE EnEspera=1"

            Return cmd.ExecuteScalar

        Catch ex As Exception
            MsgBox("Error al buscar tickets en espera", MsgBoxStyle.Exclamation, "Tickets en espera")
            Return False
        End Try
    End Function
#End Region

#Region "bttCobroTicket_Click"
    Private Sub bttCobroTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCobroTicket.Click

        Dim conexion As New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        conexion.Open()
        Dim transaccion As SqlClient.SqlTransaction
        transaccion = conexion.BeginTransaction()

        Dim hLineas As Integer

        Try
            'Definir pantalla para el cobro
            'Me.Enabled = False
            Me.PanelOpciones.Visible = False
            hLineas = Me.dgLineasTicket.Height
            Me.dgLineasTicket.Height = Me.Height - Me.dgLineasTicket.Top - 100

            'Guardar ticket
            Me.TICKETSBindingSource.EndEdit()
            Me.TICKETSTableAdapter.Update(Me.DsTickets.TICKETS)

            'Guardar líneas del ticket
            Me.TICKETSLINEASBindingSource.EndEdit()
            Me.TICKETS_LINEASTableAdapter.Update(Me.DsTickets.TICKETS_LINEAS)

            Me.DsTickets.AcceptChanges()

            'Control tarjetas
            If Me.txtCodigoCliente.EditValue = 0 And ControlTarjetas Then
                Dim fTarjeta As New DameCliente
                If fTarjeta.ShowDialog = Windows.Forms.DialogResult.OK Then
                    rTicket.CodigoCliente = fTarjeta.CodigoCliente
                End If
            End If

            'Aplica promociones
            Me.AplicaPromocionesRegalo()

            'Comprobar sorteos
            Me.SorteActivo()

            'Validar ticket
            rTicket.CodigoTienda = CodigoTienda
            rTicket.CodigoCaja = CodigoCaja
            rTicket.FechaTicket = Date.Today
            rTicket.HoraTicket = Date.Now
            rTicket.NumeroLineas = Me.DsTickets.TICKETS_LINEAS.Rows.Count
            rTicket.ImporteTotal = Me.txtTotal.EditValue
            rTicket.EnEspera = False

            Dim fCobro As New CobroTicket
            fCobro.Left = Me.dgFamilias.Left
            fCobro.Top = Me.dgFamilias.Top + 22
            fCobro.Width = Me.dgFamilias.Width + 20
            fCobro.Height = Me.dgLineasTicket.Height + 60
            fCobro.rTicket = rTicket
            If fCobro.ShowDialog = Windows.Forms.DialogResult.OK Then

                Me.Cursor = Cursors.WaitCursor

                'Actualiza nº último ticket en caja
                Dim cmd As New SqlClient.SqlCommand
                cmd.Connection = conexion
                cmd.Transaction = transaccion

                If rTicket.TipoFactura = 0 Then
                    cmd.CommandText = "UPDATE Cajas SET NumeroTicket=NumeroTicket+1 WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & CodigoCaja
                    cmd.ExecuteNonQuery()
                End If

                cmd.CommandText = "SELECT NumeroTicket FROM CAJAS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & CodigoCaja
                rTicket.NumeroTicket = cmd.ExecuteScalar + IIf(rTicket.TipoFactura <> 0, 1, 0)

                'Imprimir albarán de crédito
                If rTicket.TipoFactura = 1 Then
                    cmd.CommandText = "UPDATE TIENDAS SET NumeroAlbaran=ISNULL(NumeroAlbaran,0)+1 WHERE CodigoTienda=" & CodigoTienda
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "SELECT NumeroAlbaran FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
                    rTicket.NumeroAlbaran = cmd.ExecuteScalar
                End If

                'Imprimir factura de crédito
                If rTicket.TipoFactura = 2 Then
                    cmd.CommandText = "UPDATE TIENDAS SET NumeroFactura1 = ISNULL(NumeroFactura1,0) + 1 WHERE CodigoTienda=" & CodigoTienda
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "SELECT NumeroFactura1 FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
                    rTicket.NumeroAlbaran = cmd.ExecuteScalar
                End If

                'Imprimir factura de crédito (Serie 2)
                If rTicket.TipoFactura = 3 Then
                    cmd.CommandText = "UPDATE TIENDAS SET NumeroFactura2 = ISNULL(NumeroFactura2,0) + 1 WHERE CodigoTienda=" & CodigoTienda
                    cmd.ExecuteNonQuery()
                    cmd.CommandText = "SELECT NumeroFactura2 FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
                    rTicket.NumeroAlbaran = cmd.ExecuteScalar
                End If

                'Guardar descuento en cabecera ticket y actualiza stock en líneas
                Dim i As Integer
                Dim rLineaTicket As dsTickets.TICKETS_LINEASRow
                Dim TotalDtos As Decimal
                For i = 0 To Me.DsTickets.TICKETS_LINEAS.Rows.Count - 1
                    rLineaTicket = Me.DsTickets.TICKETS_LINEAS.Rows(i)
                    If Not rLineaTicket.RowState = DataRowState.Deleted Then
                        If Not rLineaTicket.IsPesoNull Then
                            ActualizaStock(rLineaTicket.CodigoArticulo, rLineaTicket.CodigoColor, rLineaTicket.NumeroTalla, rLineaTicket.Peso * -1)
                        Else
                            ActualizaStock(rLineaTicket.CodigoArticulo, rLineaTicket.CodigoColor, rLineaTicket.NumeroTalla, rLineaTicket.UnidadStock * -1)
                        End If
                        TotalDtos += Math.Round(Math.Round(rLineaTicket.Cantidad * rLineaTicket.Precio, 2, MidpointRounding.AwayFromZero) - rLineaTicket.Importe, 2, MidpointRounding.AwayFromZero)
                    End If
                Next
                rTicket.ImporteDescuento = TotalDtos

                'Preguntar si imprime ticket
                If rTicket.TipoFactura = 0 Then
                    If ImprimeTicket = 0 Then
                        rTicket.ImpresoTicket = True
                    ElseIf ImprimeTicket = 2 Then
                        If MsgBox("¿Desea imprimir el ticket?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Imprimir") = MsgBoxResult.Yes Then
                            rTicket.ImpresoTicket = True
                        End If
                    End If
                Else
                    rTicket.ImpresoTicket = True
                End If

                'Guardar ticket
                Me.TICKETSBindingSource.EndEdit()
                Me.TICKETSTableAdapter.Update(Me.DsTickets.TICKETS)

                'Guardar líneas del ticket
                Me.TICKETSLINEASBindingSource.EndEdit()
                Me.TICKETS_LINEASTableAdapter.Update(Me.DsTickets.TICKETS_LINEAS)

                'Añadir pendiente de cobro si ha seleccionado esa opción
                If rTicket.TipoFactura = 0 And rTicket.TipoCobro = "P" Then
                    Dim dsPendientesCobro As New dsPendientesCobro
                    Dim tPendientesCobro As New dsPendientesCobroTableAdapters.PENDIENTES_COBROTableAdapter
                    Dim rPendientesCobro As dsPendientesCobro.PENDIENTES_COBRORow

                    rPendientesCobro = dsPendientesCobro.PENDIENTES_COBRO.NewPENDIENTES_COBRORow
                    rPendientesCobro.CodigoCliente = fCobro.txtCodigoCliente.EditValue
                    rPendientesCobro.CodigoTienda = CodigoTienda
                    rPendientesCobro.CodigoCaja = CodigoCaja
                    rPendientesCobro.CodigoTicket = rTicket.NumeroTicket
                    rPendientesCobro.Fecha = rTicket.FechaTicket
                    Dim DatosCliente() As String = Split(fCobro.txtDatosCliente.EditValue, vbCrLf)
                    rPendientesCobro.Nombre = Mid(DatosCliente(0), 1, 50)
                    rPendientesCobro.ImporteTicket = rTicket.ImporteTotal
                    rPendientesCobro.ImporteCobrado = rTicket.ImporteTotal - rTicket.ImportePendienteCobro

                    dsPendientesCobro.PENDIENTES_COBRO.AddPENDIENTES_COBRORow(rPendientesCobro)
                    tPendientesCobro.Update(dsPendientesCobro.PENDIENTES_COBRO)
                End If

                transaccion.Commit()

                'Iprimir ticket
                If rTicket.TipoFactura = 0 Or (rTicket.TipoFactura = 1 And AlbaranFormatoTicket) Then
                    If rTicket.ImpresoTicket Then ImprimirTicket(fCobro.NumeroVale)
                End If

                'Imprimir albarán/factura
                If rTicket.TipoFactura > 1 Or (rTicket.TipoFactura = 1 And AlbaranFormatoA4) Then Me.ImprimirAlbaran(rTicket.Id)
                If rTicket.TipoFactura = 0 Then
                    If MsgBox("¿Desea imprimir factura?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        ConsultaTickets.ImprimirFactura(rTicket.Id)
                        rTicket.ImpresoTicket = True
                    End If
                End If

                'Actualizar saldo cliente
                If rTicket.FidelizacionPuntos <> 0 Then
                    Dim Cliente As New dsClientesTableAdapters.CLIENTESTableAdapter
                    Cliente.ActualizaSaldoPuntos(rTicket.FidelizacionPuntos, rTicket.CodigoCliente)
                End If

                'Nuevo ticket en pantalla
                Dim UltimoCambio As Decimal = rTicket.ImporteCambios
                Me.NuevoTicket()
                Me.txtInfoArticulo.EditValue = "Cambio ticket anterior: " & Math.Round(UltimoCambio, DecimalesImporte, MidpointRounding.AwayFromZero)

            Else
                Me.DsTickets.RejectChanges()
                Me.TICKETSBindingSource.ResetCurrentItem()
                Me.txtCodigoCliente_Validated(Nothing, Nothing)
                Me.TotalTicket()
                Me.gvLineasTicket.RefreshData()
            End If

        Catch ex As Exception
            transaccion.Rollback()
            MsgBox("Error al cobrar ticket." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation, "Cobro ticket")
        Finally
            'Me.Enabled = True
            Me.PanelOpciones.Visible = True
            Me.dgLineasTicket.Height = hLineas
            Me.Cursor = Cursors.Default
        End Try

        conexion.Close()

    End Sub
#End Region

#Region "bttConsultaTicket_Click"
    Private Sub bttConsultaTicket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttConsultaTicket.Click
        ConsultaTickets.Historico = False
        ConsultaTickets.ShowDialog()
    End Sub
#End Region

#Region "CantidadVendida"
    Private Function CantidadVendida(ByVal Id As Integer, ByVal CodigoArticulo As String, Descripcion As String, ByVal CodigoColor As Integer, ByVal NumeroTalla As Integer, ByVal Precio As Decimal, ByVal Descuento As Decimal, Optional ByVal AgrupaLineas As Boolean = True) As Decimal
        Try
            Dim i As Integer
            Dim Cantidad As Decimal
            Dim rLinea As dsTickets.TICKETS_LINEASRow

            For i = 0 To Me.DsTickets.TICKETS_LINEAS.Rows.Count - 1
                rLinea = Me.DsTickets.TICKETS_LINEAS.Rows(i)
                If Not rLinea.RowState = DataRowState.Deleted Then
                    If (rLinea.Id <> Id And rLinea.CodigoArticulo = CodigoArticulo And rLinea.DescripcionArticulo = Descripcion And rLinea.CodigoColor = CodigoColor And rLinea.NumeroTalla = NumeroTalla And rLinea.DescuentoLinea = Descuento) Then
                        If Not AgrupaLineas Or rLinea.Precio = Precio Then
                            Cantidad = rLinea.UnidadStock
                            If AgrupaLineas Then rLinea.Delete()
                            Exit For
                        End If
                    End If
                End If
            Next

            Return Cantidad

        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region

#Region "ActualizaTotalLinea"
    Private Sub ActualizaTotalLinea(ByVal rLineaTicket As dsTickets.TICKETS_LINEASRow)
        rLineaTicket.Importe = Math.Round(rLineaTicket.Cantidad * rLineaTicket.Precio - rLineaTicket.Cantidad * rLineaTicket.Precio * rLineaTicket.DescuentoLinea / 100, DecimalesImporte, MidpointRounding.AwayFromZero)
        rLineaTicket.Importe += Math.Round(rLineaTicket.Cantidad * rLineaTicket.ImporteEcoraee, DecimalesImporte, MidpointRounding.AwayFromZero)
        Me.TotalTicket()
        Me.gvLineasTicket.RefreshData()
    End Sub
#End Region

#Region "GuardaUltimaLinea"
    Private Sub GuardaUltimaLinea(ByVal rLineaTicket As dsTickets.TICKETS_LINEASRow)
        Me.UltimaLinea.CodigoArticulo = rLineaTicket.CodigoArticulo
        Me.UltimaLinea.DescripcionArticulo = rLineaTicket.DescripcionArticulo
        Me.UltimaLinea.CodigoColor = rLineaTicket.CodigoColor
        Me.UltimaLinea.NumeroTalla = rLineaTicket.NumeroTalla
        Me.UltimaLinea.PrecioManual = rLineaTicket.PrecioManual
        Me.UltimaLinea.Precio = rLineaTicket.Precio
        Me.UltimaLinea.DescuentoLinea = rLineaTicket.DescuentoLinea
        Me.UltimaLinea.PorcentajeIVA = rLineaTicket.PorcentajeIVA
        Me.UltimaLinea.Promocion = rLineaTicket.Promocion
        Me.UltimaLinea.DtoFidelizacion = rLineaTicket.DtoFidelizacion
        Me.UltimaLinea.ImporteEcoraee = rLineaTicket.ImporteEcoraee
    End Sub
#End Region

#Region "AplicaPromocionesRegalo"
    Private Sub AplicaPromocionesRegalo()
        Try
            Dim taPromociones As New dsPromociones.PROMOCIONESDataTable
            Dim rPromociones As dsPromociones.PROMOCIONESRow

            Dim Lineas As DataRow() = Me.DsTickets.TICKETS_LINEAS.Select
            Dim rLineaTicket As dsTickets.TICKETS_LINEASRow
            Dim i As Integer

            For i = 0 To Lineas.Length - 1

                rLineaTicket = Lineas(i)

                If rLineaTicket.Cantidad > 0 Then

                    '----------ARTICULO REGALO--------------
                    Dim Promocion As Almacen.DatosPromocion = DamePrecioPromocion(rLineaTicket.CodigoArticulo, rLineaTicket.CodigoColor, rLineaTicket.NumeroTalla, rLineaTicket.Cantidad)
                    If Promocion.CodigoArticuloRegalo <> String.Empty Then

                        Try
                            'Comprobar si existe ya la promoción
                            Dim promos As Integer
                            For promos = 0 To taPromociones.Rows.Count - 1
                                rPromociones = taPromociones.Rows(promos)
                                If rPromociones.CodigoArticulo = rLineaTicket.CodigoArticulo And rPromociones.CodigoColor = Promocion.CodigoColorRegalo And rPromociones.CodigoTalla = Promocion.NumeroTallaRegalo Then
                                    rPromociones.PrecioTarifa += rLineaTicket.UnidadStock 'Columna utilizada para acumular cantidad vendida
                                    Exit Try
                                End If
                            Next

                            rPromociones = taPromociones.NewPROMOCIONESRow
                            rPromociones.CodigoArticulo = rLineaTicket.CodigoArticulo
                            rPromociones.CodigoColor = Promocion.CodigoColorRegalo
                            rPromociones.CodigoTalla = Promocion.NumeroTallaRegalo
                            rPromociones.CodigoArticuloRegalo = Promocion.CodigoArticuloRegalo
                            rPromociones.FraccionSinCargo = Promocion.FraccionSinCargo
                            rPromociones.UnidadesSinCargo = Promocion.UnidadesSinCargo
                            rPromociones.PrecioArticuloRegalo = Promocion.PrecioArticuloRegalo
                            rPromociones.PrecioTarifa = rLineaTicket.Cantidad 'Columna utilizada para acumular cantidad vendida
                            taPromociones.AddPROMOCIONESRow(rPromociones)

                        Catch ex As Exception
                            'Error al tratar artículo regalo
                        End Try

                    End If

                End If

            Next

            'Resolver promociones cargadas
            Try
                Dim CantidadRegalo As Decimal
                For i = 0 To taPromociones.Rows.Count - 1
                    rPromociones = taPromociones.Rows(i)
                    If rPromociones.CodigoArticulo = rPromociones.CodigoArticuloRegalo Then
                        CantidadRegalo = Int(rPromociones.PrecioTarifa / (rPromociones.FraccionSinCargo + rPromociones.UnidadesSinCargo)) * rPromociones.UnidadesSinCargo
                    Else
                        CantidadRegalo = Int(rPromociones.PrecioTarifa / rPromociones.FraccionSinCargo) * rPromociones.UnidadesSinCargo
                    End If
                    Me.ActualizaLineaPromocion(rPromociones.CodigoArticulo, rPromociones.CodigoArticuloRegalo, CantidadRegalo, rPromociones.PrecioArticuloRegalo)
                Next
            Catch ex As Exception
                'Error al tratar artículo regalo
            End Try

            Me.TotalTicket()
            Me.gvLineasTicket.RefreshData()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "ActualizaLineaPromocion"
    Private Sub ActualizaLineaPromocion(ByVal CodigoArticulo As String, ByVal CodigoArticuloRegalo As String, ByVal CantidadRegalo As Decimal, ByVal PrecioArticuloRegalo As Decimal)

        If CantidadRegalo = 0 Then Exit Sub

        Try
            Dim Lineas As DataRow() = Me.DsTickets.TICKETS_LINEAS.Select
            Dim rLineaTicket As dsTickets.TICKETS_LINEASRow
            Dim i As Integer

            For i = 0 To Lineas.Length - 1

                rLineaTicket = Lineas(i)

                Dim Equivalencia As Decimal = rLineaTicket.Cantidad / rLineaTicket.UnidadStock

                If rLineaTicket.CodigoArticulo = CodigoArticuloRegalo And Not rLineaTicket.LineaTratada Then
                    If rLineaTicket.Cantidad > CantidadRegalo Then
                        rLineaTicket.UnidadStock -= CantidadRegalo
                        rLineaTicket.Cantidad = rLineaTicket.UnidadStock * Equivalencia
                        Me.ActualizaTotalLinea(rLineaTicket)
                        Me.NuevaLineaTicket(CodigoArticuloRegalo, CantidadRegalo, PrecioArticuloRegalo, True, True)
                        Exit For
                    Else
                        Me.NuevaLineaTicket(CodigoArticuloRegalo, rLineaTicket.UnidadStock, PrecioArticuloRegalo, True, True)
                        CantidadRegalo -= rLineaTicket.UnidadStock
                        rLineaTicket.Delete()
                        If CantidadRegalo = 0 Then Exit For
                    End If
                End If

            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "ImprimirTicket"
    Private Sub ImprimirTicket(Optional NumeroVale As Integer = 0)

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Me.Cursor = Cursors.WaitCursor

        Try
            Dim ticket As String = String.Empty
            Dim linea As String
            Dim cabeceraTicket As String = String.Empty
            Dim pieTicket As String = String.Empty
            Dim TotalDtos As Decimal

            If General.ActivaAperturaCajon Then ticket &= AbreCajon()

            ticket &= ActivaExpandido()

            'Datos tienda
            cmd.CommandText = "SELECT TextoCabecera1, TextoCabecera2, Nif, TextoPie FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
            dr = cmd.ExecuteReader
            If dr.Read Then
                cabeceraTicket = dr("TextoCabecera1")
                ticket &= cabeceraTicket
                ticket &= DesactivaExpandido()
                ticket &= vbCrLf & vbCrLf & dr("TextoCabecera2")

                linea = "C.I.F- " & dr("Nif")
                While Len(linea) < 25
                    linea &= " "
                End While
                ticket &= vbCrLf & linea & "* IVA INCLUIDO *"

                ticket &= vbCrLf & Format(rTicket.FechaTicket, "dd-MM-yyyy")
                ticket &= " " & Format(rTicket.HoraTicket, "HH:mm")
                If rTicket.TipoFactura = 1 Then
                    ticket &= "  ALBARAN:" & Format(rTicket.CodigoCaja, "00") & Format(rTicket.NumeroAlbaran, "000000")
                Else
                    ticket &= "  FACTURA:" & Format(rTicket.CodigoCaja, "00") & Format(rTicket.NumeroTicket, "000000")
                End If
                ticket &= "  T: " & Format(rTicket.CodigoTienda, "00")
                ticket &= vbCrLf & "ARTICULO         CANTIDAD    PVP  IMPORTE"
                ticket &= vbCrLf & "-----------------------------------------"
                pieTicket = dr("TextoPie")
            End If
            dr.Close()

            Dim i As Integer
            Dim rLineaTicket As dsTickets.TICKETS_LINEASRow

            For i = 0 To Me.DsTickets.TICKETS_LINEAS.Rows.Count - 1

                rLineaTicket = Me.DsTickets.TICKETS_LINEAS.Rows(i)

                ticket &= vbCrLf

                linea = Mid(rLineaTicket.DescripcionArticulo, 1, 18)

                While Len(linea & IIf(Int(rLineaTicket.Cantidad) = rLineaTicket.Cantidad, Int(rLineaTicket.Cantidad).ToString, Math.Round(rLineaTicket.Cantidad, 2, MidpointRounding.AwayFromZero).ToString)) < 24
                    linea &= " "
                End While
                linea &= IIf(Int(rLineaTicket.Cantidad) = rLineaTicket.Cantidad, Int(rLineaTicket.Cantidad), Math.Round(rLineaTicket.Cantidad, 2, MidpointRounding.AwayFromZero))

                While Len(linea & Math.Round(rLineaTicket.Precio, DecimalesPrecio, MidpointRounding.AwayFromZero).ToString) < 32
                    linea &= " "
                End While
                linea &= Math.Round(rLineaTicket.Precio, DecimalesPrecio, MidpointRounding.AwayFromZero)

                While Len(linea & Math.Round(rLineaTicket.Importe, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 40
                    linea &= " "
                End While
                linea &= Math.Round(rLineaTicket.Importe, DecimalesImporte, MidpointRounding.AwayFromZero)

                If rLineaTicket.Promocion Then
                    linea &= "P"
                ElseIf rLineaTicket.DescuentoLinea <> 0 Then
                    linea &= "*"
                    TotalDtos += (rLineaTicket.Cantidad * rLineaTicket.Precio) - rLineaTicket.Importe
                End If

                ticket &= linea

            Next

            ticket &= vbCrLf & "-----------------------------------------"

            'Totales ventas
            Try
                Dim valor As Decimal
                Dim ImporteBase As Decimal, TotalBases As Decimal, TotalIVA As Decimal
                Dim Diferencia As Decimal, IvaDiferencia As Decimal = TipoIva3

                'ticket &= vbCrLf & "BASE IMPONIBLE      %IVA     IMPORTE IVA"
                'ticket &= vbCrLf & "========================================"

                cmd.CommandText = "SELECT PorcentajeIVA, ISNULL(SUM(Importe),0) AS Total FROM TICKETS_LINEAS " & _
                                  "WHERE Ticket_Id=" & rTicket.Id & " GROUP BY PorcentajeIVA"

                'Calcular diferencia entre bases
                dr = cmd.ExecuteReader
                While dr.Read
                    ImporteBase = Math.Round(dr("Total") / (1 + (dr("PorcentajeIVA") / 100)), DecimalesImporte, MidpointRounding.AwayFromZero)
                    TotalBases += ImporteBase
                    TotalIVA += ImporteBase * dr("PorcentajeIVA") / 100
                    If dr("PorcentajeIVA") = TipoIva2 And IvaDiferencia = TipoIva3 Then IvaDiferencia = TipoIva2
                    If dr("PorcentajeIVA") = TipoIva1 Then IvaDiferencia = TipoIva1
                End While
                dr.Close()
                Diferencia = rTicket.ImporteTotal - (TotalBases + TotalIVA)

                'Imprimir líneas IVA
                dr = cmd.ExecuteReader
                While dr.Read

                    linea = "BASE AL "
                    valor = dr("PorcentajeIVA")
                    While Len(linea & Math.Round(valor, 1).ToString) < 12
                        linea &= " "
                    End While
                    linea &= Math.Round(valor, 1) & "%"

                    ImporteBase = Math.Round(dr("Total") / (1 + (dr("PorcentajeIVA") / 100)), DecimalesImporte, MidpointRounding.AwayFromZero)
                    valor = ImporteBase + IIf(dr("PorcentajeIVA") = IvaDiferencia, Diferencia, 0)
                    While Len(linea & Format(Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero), "0.00")) < 24
                        linea &= " "
                    End While
                    linea &= Format(Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero), "0.00")

                    linea &= "   IVA:"
                    valor = ImporteBase * dr("PorcentajeIVA") / 100
                    While Len(linea & Format(Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero), "0.00")) < 40
                        linea &= " "
                    End While
                    ticket &= vbCrLf & linea & Format(Math.Round(valor, DecimalesImporte, MidpointRounding.AwayFromZero), "0.00")

                    Diferencia = 0

                End While
                dr.Close()

                ticket &= vbCrLf & "----------------------------------------"

            Catch ex As Exception
                'Error al calcular totales de venta
            End Try

            linea = Me.DsTickets.TICKETS_LINEAS.Rows.Count & " Lineas, T O T A L"
            While Len(linea) + Len(Math.Round(rTicket.ImporteTotal, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) * 2 < 40
                linea &= " "
            End While

            ticket &= vbCrLf & linea
            ticket &= ActivaExpandido()
            ticket &= Math.Round(rTicket.ImporteTotal, DecimalesImporte, MidpointRounding.AwayFromZero)
            ticket &= DesactivaExpandido() & vbCrLf

            If TotalDtos <> 0 Then
                ticket &= vbCrLf & "* TOTAL DESCUENTOS: " & Math.Round(TotalDtos, DecimalesImporte, MidpointRounding.AwayFromZero) & vbCrLf
            End If

            If rTicket.ImporteValesEmitidos <> 0 Then

                ticket &= vbCrLf & "EMISION DE VALE PROPIO"

            ElseIf rTicket.TipoFactura = 1 Then

                ticket &= vbCrLf & "ALBARAN DE CREDITO"

            Else

                If rTicket.ImporteTalonCheque <> 0 Then
                    linea = "TALON"
                    While Len(linea & Math.Round(rTicket.ImporteTalonCheque, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rTicket.ImporteTalonCheque, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= vbCrLf & linea
                End If

                If rTicket.ImporteTarjeta <> 0 Then
                    linea = "TARJETA"
                    While Len(linea & Math.Round(rTicket.ImporteTarjeta, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rTicket.ImporteTarjeta, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= vbCrLf & linea
                End If

                If rTicket.ImporteValesProveedor <> 0 Then
                    linea = "VALE PROV."
                    While Len(linea & Math.Round(rTicket.ImporteValesProveedor, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rTicket.ImporteValesProveedor, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= vbCrLf & linea
                End If

                If rTicket.ImporteValesCobrados <> 0 Then
                    linea = "VALE PROP."
                    While Len(linea & Math.Round(rTicket.ImporteValesCobrados, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rTicket.ImporteValesCobrados, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= vbCrLf & linea
                End If

                If rTicket.ImporteEnvases <> 0 Then
                    linea = "ENVASES"
                    While Len(linea & Math.Round(rTicket.ImporteEnvases, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rTicket.ImporteEnvases, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= vbCrLf & linea
                End If

                If rTicket.ImporteEfectivo <> 0 Then
                    linea = "EFECTIVO"
                    While Len(linea & Math.Round(rTicket.ImporteEfectivo, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rTicket.ImporteEfectivo, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= vbCrLf & linea
                End If

                If rTicket.ImportePendienteCobro <> 0 Then
                    linea = "PDTE.COBRO"
                    While Len(linea & Math.Round(rTicket.ImportePendienteCobro, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rTicket.ImportePendienteCobro, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= vbCrLf & linea
                End If

                If rTicket.ImporteCambios <> 0 Then
                    linea = "     CAMBIO"
                    While Len(linea & Math.Round(rTicket.ImporteCambios, DecimalesImporte, MidpointRounding.AwayFromZero).ToString) < 20
                        linea &= " "
                    End While
                    linea &= Math.Round(rTicket.ImporteCambios, DecimalesImporte, MidpointRounding.AwayFromZero)
                    ticket &= linea
                End If

            End If

            ticket &= vbCrLf & vbCrLf & "LE ATENDIO " & Me.txtNombreTicket.Caption

            If rTicket.RepartoDomicilio Then ticket &= vbCrLf & vbCrLf & "*** REPARTO A DOMICILIO ***"

            ticket &= vbCrLf & vbCrLf & pieTicket

            If rTicket.TipoFactura = 1 Then
                ticket &= vbCrLf & vbCrLf & vbCrLf
                ticket &= "----------------------------------------"
                ticket &= vbCrLf & "CLIENTE : " & Format(rTicket.CodigoCliente, "00000000")
                ticket &= vbCrLf & Mid("NOMBRE  : " & Me.txtNombreCliente.EditValue, 1, 40)
                ticket &= vbCrLf & vbCrLf & "Ha efectuado en el dia de hoy compras"
                ticket &= vbCrLf & "por el valor de " & Math.Round(rTicket.ImporteTotal, DecimalesImporte, MidpointRounding.AwayFromZero) & " .-"
                ticket &= vbCrLf & "posteriormente se emitira una factura"
                ticket &= vbCrLf & "por este importe desglosando el IVA."
                ticket &= vbCrLf & vbCrLf & "            FIRMADO."
                ticket &= vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf
                ticket &= "----------------------------------------"
            ElseIf rTicket.CodigoCliente <> 0 Then
                ticket &= vbCrLf & vbCrLf
                ticket &= "----------------------------------------"
                ticket &= vbCrLf & "CLIENTE : " & Format(rTicket.CodigoCliente, "00000000")
                ticket &= vbCrLf & Mid("NOMBRE  : " & Me.txtNombreCliente.EditValue, 1, 40)
                ticket &= vbCrLf
                ticket &= "----------------------------------------"
            End If

            If rTicket.FidelizacionLoteria <> 0 Then

                'Datos sorte
                Dim Sorteo As New dsSorteos

                Sorteo.Cargar()

                If Not Sorteo.SorteoActivo Is Nothing Then
                    With Sorteo.SorteoActivo

                        ticket &= vbCrLf & vbCrLf & vbCrLf
                        ticket &= vbCrLf & "EL PORTADOR DEL TICKET JUEGA LA CANTIDAD"
                        ticket &= vbCrLf & "DE " & Math.Round(rTicket.ImporteSorteo, DecimalesImporte, MidpointRounding.AwayFromZero) & ".- EUROS DEL NUMERO " & ActivaExpandido() & dr("Numero") & DesactivaExpandido()
                        ticket &= vbCrLf & "PARA EL PROXIMO SORTEO DEL DIA " & .FechaSorteo.ToShortDateString & "."
                        ticket &= vbCrLf & "DEPOSITADO EN : " & .DepositadoEn
                        ticket &= vbCrLf & "TICKET ROTO O SIN EL SELLO, SERA NULO."

                    End With
                End If


            ElseIf rTicket.FidelizacionPuntos <> 0 Then

                Dim Cliente As New dsClientesTableAdapters.CLIENTESTableAdapter

                ticket &= vbCrLf & "PUNTOS GENERADOS  :" & Int(rTicket.FidelizacionPuntos)
                ticket &= vbCrLf & "PUNTOS ACUMULADOS :" & Int(Cliente.SaldoPuntos(rTicket.CodigoCliente)) + Int(rTicket.FidelizacionPuntos)

            ElseIf rTicket.FidelizacionVales <> 0 Then

                'If ActivaCorteTicket Then ticket &= CorteTicket()

                ''Datos cabecera tienda
                'ticket &= ActivaExpandido() & cabeceraTicket & DesactivaExpandido()
                'ticket &= vbCrLf & vbCrLf & Format(rTicket.FechaTicket, "dd-MM-yyyy")
                'ticket &= " " & Format(rTicket.HoraTicket, "HH:mm")
                'ticket &= "  TICKET: " & Format(rTicket.CodigoCaja, "00") & Format(rTicket.NumeroTicket, "000000")
                'ticket &= "  T: " & Format(rTicket.CodigoTienda, "00")
                'ticket &= vbCrLf & ActivaExpandido() & "     VALE SORTEO" & DesactivaExpandido()
                'ticket &= vbCrLf & "-----------------------------------------"
                'ticket &= vbCrLf & "Nombre:"
                'ticket &= vbCrLf & vbCrLf & "Direccion:"
                'ticket &= vbCrLf & vbCrLf & "Poblacion:"
                'ticket &= vbCrLf & vbCrLf & "Telefono:"
                'ticket &= vbCrLf & "-----------------------------------------"
                'ticket &= vbCrLf & "Fecha sorteo: " & Format(dr("FechaSorteo"), "dd-MM-yyyy")

                ticket &= vbCrLf & vbCrLf
                ticket &= "POR ESTA COMPRA HA OBTENIDO :"
                ticket &= vbCrLf & vbCrLf & ActivaExpandido() & "    " & Int(rTicket.ImporteSorteo) & " PUNTOS" & DesactivaExpandido()

            ElseIf rTicket.FidelizacionImporte <> 0 Then

                ticket &= vbCrLf & vbCrLf
                ticket &= "POR ESTA COMPRA HA OBTENIDO :"
                ticket &= vbCrLf & vbCrLf & ActivaExpandido() & "    " & Int(rTicket.ImporteSorteo) & " EUROS" & DesactivaExpandido()

            End If

            If ActivaCorteTicket Then ticket &= CorteTicket()

            If rTicket.RepartoDomicilio Then
                ticket &= "** REPARTO A DOMICILIO " & Format(rTicket.NumeroTicket, "000000") & " **"
                ticket &= vbCrLf & "FECHA " & rTicket.FechaTicket
                ticket &= vbCrLf & vbCrLf & rTicket.DireccionReparto
                If ActivaCorteTicket Then ticket &= CorteTicket()
            End If

            Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket)

            If rTicket.TipoFactura = 1 Then Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket)

            'Imprimir vale
            If rTicket.ImporteValesEmitidos <> 0 Then
                Me.ImprimirTicketVale(NumeroVale)
            End If

            'Imprimir pendiente de cobro
            If rTicket.ImportePendienteCobro <> 0 Then
                Me.ImprimirTicketPdteCobro()
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub
#End Region

#Region "ImprimirTicketPdteCobro"
    Private Sub ImprimirTicketPdteCobro()

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
                ticket &= "  T:" & Format(General.NumeroAlmacen, "00")
                ticket &= "  C:" & Format(rTicket.CodigoCaja, "00")
            End If
            dr.Close()

            'Datos pendiente de cobro
            cmd.CommandText = "SELECT * FROM PENDIENTES_COBRO WHERE CodigoTienda=" & rTicket.Codigotienda & " AND CodigoCaja=" & rTicket.CodigoCaja & " AND CodigoTicket=" & rTicket.NumeroTicket
            dr = cmd.ExecuteReader
            If dr.Read Then

                ticket &= vbCrLf & "CLIENTE: " & Format(Int(dr("CodigoCliente")), "00000")
                ticket &= vbCrLf & "         " & dr("Nombre")
                ticket &= vbCrLf & "Ha efectuado en el dia de hoy compras"
                ticket &= vbCrLf & "por el valor de " & Math.Round(rTicket.ImporteTotal, DecimalesImporte, MidpointRounding.AwayFromZero) & " euros"
                ticket &= vbCrLf & "adeudando por esta factura " & Format(Int(dr("CodigoTicket")), "0000000")
                ticket &= vbCrLf & "la cantidad de " & Math.Round(CDec(dr("ImporteTicket")) - CDec(dr("ImporteCobrado")), DecimalesImporte, MidpointRounding.AwayFromZero) & " euros"
                ticket &= vbCrLf & "con cargo a su cuenta."
                ticket &= vbCrLf & vbCrLf & "            FIRMADO."

            End If
            dr.Close()

            If ActivaCorteTicket Then ticket += CorteTicket()

            Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket)
            Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "ImprimirTicketVale"
    Private Sub ImprimirTicketVale(NumeroVale As Integer)

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

            'Datos vale
            cmd.CommandText = "SELECT * FROM VALES_TIENDA WHERE CodigoTienda=" & CodigoTienda & " AND CodigoVale=" & NumeroVale
            dr = cmd.ExecuteReader
            If dr.Read Then

                ticket &= ActivaExpandido()
                ticket &= vbCrLf & vbCrLf & "NUM. VALE : " & dr("CodigoVale") & vbCrLf

                Dim i As Integer = Len("NUM. VALE : " & dr("CodigoVale"))
                While i > 0
                    ticket &= "="
                    i -= 1
                End While
                ticket &= DesactivaExpandido() & vbCrLf & vbCrLf

                ticket &= "VALE DE COMPRA A FAVOR DE:" & vbCrLf
                ticket &= dr("Nombre") & vbCrLf
                ticket &= "EN CONCEPTO DE:" & vbCrLf
                ticket &= dr("Concepto") & vbCrLf
                ticket &= "POR IMPORTE DE: " & Math.Round(dr("Importe"), DecimalesImporte, MidpointRounding.AwayFromZero) & " euros"

            End If
            dr.Close()

            If ActivaCorteTicket Then ticket += CorteTicket()

            Imprimir.SendStringToPrinter(My.Settings.ImpresoraTickets, ticket)

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "CompruebaTopeEfectivoCaja"
    Private Sub CompruebaTopeEfectivoCaja()

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            'Total efectivo
            Dim TotalEfectivo As Decimal, TopeEfectivoCaja As Decimal

            cmd.CommandText = "SELECT TopeEfectivoEnCaja FROM CAJAS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & CodigoCaja
            TopeEfectivoCaja = cmd.ExecuteScalar

            cmd.CommandText = "SELECT ISNULL(Sum(ImporteEfectivo-ImporteCambios),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & CodigoCaja
            TotalEfectivo = cmd.ExecuteScalar

            cmd.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & CodigoCaja & _
                                     " AND FechaCierre IS NULL AND (TipoMovimiento='EC' OR TipoMovimiento='CC' OR (TipoMovimiento='EV' AND TipoCobro=1))"
            TotalEfectivo += cmd.ExecuteScalar

            cmd.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & CodigoCaja & _
                                     " AND FechaCierre IS NULL AND (TipoMovimiento='RF' OR TipoMovimiento='PC')"
            TotalEfectivo -= cmd.ExecuteScalar

            If TopeEfectivoCaja <> 0 And TotalEfectivo > TopeEfectivoCaja Then
                MsgBox("Superado tope efectivo en caja", MsgBoxStyle.Information)
            End If

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "BotonesAnteriorSiguiente"
    Private Sub SeleccionaPrimeraFamiliaVisible()
        Dim i As Integer
        For i = 0 To Me.lvFamilias.RowCount - 1
            If Me.lvFamilias.IsCardVisible(i) Then
                Me.lvFamilias.FocusedRowHandle = i
                Exit For
            End If
        Next
    End Sub

    Private Sub SeleccionaUltimaFamiliaVisible()
        Dim i As Integer
        For i = Me.lvFamilias.RowCount - 1 To 0 Step -1
            If Me.lvFamilias.IsCardVisible(i) Then
                Me.lvFamilias.FocusedRowHandle = i
                Exit For
            End If
        Next
    End Sub

    Private Sub SeleccionaPrimerArticuloVisible()
        Dim i As Integer
        For i = 0 To Me.lvArticulos.RowCount - 1
            If Me.lvArticulos.IsCardVisible(i) Then
                Me.lvArticulos.FocusedRowHandle = i
                Exit For
            End If
        Next
    End Sub

    Private Sub SeleccionaUltimoArticuloVisible()
        Dim i As Integer
        For i = Me.lvArticulos.RowCount - 1 To 0 Step -1
            If Me.lvArticulos.IsCardVisible(i) Then
                Me.lvArticulos.FocusedRowHandle = i
                Exit For
            End If
        Next
    End Sub
#End Region

#Region "CargaFamiliasArticulos"
    Private Sub CargaFamiliasArticulos()

        Dim cmd As New SqlClient.SqlCommand

        Try
            Me.DsArticulos.FAMILIASARTICULOS.Clear()

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            ''Crear familia sin imagen si existen artículos
            'cmd.CommandText = "SELECT COUNT(Id) FROM ARTICULOS " & _
            '                  "WHERE ControlBaja = 0 AND ISNULL(TpvTactil,1)=1 AND (NOT Imagen IS NULL OR ISNULL(Etiqueta,'')<>'') " & _
            '                  "AND CodigoFamilia IN (SELECT Id FROM FAMILIASARTICULOS WHERE Imagen IS NULL AND ISNULL(Etiqueta,'')='')"
            'If Int(cmd.ExecuteScalar) > 0 Then
            '    Dim rFamilia As dsArticulos.FAMILIASARTICULOSRow
            '    rFamilia = Me.DsArticulos.FAMILIASARTICULOS.NewFAMILIASARTICULOSRow
            '    rFamilia.Id = -1
            '    rFamilia.Etiqueta = "T.P.V."
            '    rFamilia.Imagen = General.ConvertToByteArray(My.Resources.AydaraTPV)
            '    Me.DsArticulos.FAMILIASARTICULOS.AddFAMILIASARTICULOSRow(rFamilia)
            'End If

            cmd.CommandText = "SELECT Id, Codigo, Descripcion, DescuentoTarjeta, Imagen, Etiqueta " & _
                              "FROM FAMILIASARTICULOS " & _
                              "WHERE TpvTactil=1 AND (NOT Imagen IS NULL OR ISNULL(Etiqueta,'')<>'')"

            Me.DsArticulos.FAMILIASARTICULOS.Load(cmd.ExecuteReader)

            cmd.CommandText = "SELECT * " & _
                              "FROM SUBFAMILIASARTICULOS"

            Me.DsArticulos.SUBFAMILIASARTICULOS.Load(cmd.ExecuteReader)

        Catch ex As Exception
            MsgBox("Error al cargar las familias de artículos", MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Sub
#End Region

#Region "CargaArticulos"
    Private Sub CargaArticulos()

        If Me.lvSubfamilias.GetFocusedRowCellValue(Me.colSubfamiliaId) Is Nothing Then Exit Sub
        If Me.lvFamilias.GetFocusedRowCellValue(Me.colIdFamilia) Is Nothing Then Exit Sub

        Dim cmd As New SqlClient.SqlCommand

        Try
            Me.DsArticulos.ARTICULOS.Clear()

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT ArticuloPeso, CantidadVariable, Codigo, CodigoEnvase, CodigoFamilia, CodigoProveedor, CodigoSubfamilia, CodigoTalla, ControlBaja, ControlEtiquetas, Descripcion, " & _
                              "Descuento, Etiqueta, FechaAlta, Id, Imagen, MinimoCompra, MinimoVenta, PesoUnidad, Precio, PrecioCoste, TipoArticulo, TipoIva, TipoUnidad_Id, UnidadCaja " & _
                              "FROM Articulos " & _
                              "WHERE ControlBaja = 0 AND ISNULL(TpvTactil,1)=1 AND (NOT Imagen IS NULL OR ISNULL(Etiqueta,'')<>'')"

            If Me.lvFamilias.RowCount > 0 Then
                If Me.lvFamilias.GetFocusedRowCellValue(Me.colIdFamilia) = -1 Then
                    cmd.CommandText &= " AND CodigoFamilia IN (SELECT Id FROM FAMILIASARTICULOS WHERE Imagen IS NULL AND ISNULL(Etiqueta,'')='')"
                Else
                    cmd.CommandText &= " AND CodigoFamilia=" & Me.lvFamilias.GetFocusedRowCellValue(Me.colIdFamilia)
                    cmd.CommandText &= " AND CodigoSubFamilia=" & Me.lvSubfamilias.GetFocusedRowCellValue(Me.colSubfamiliaId)
                End If
            End If

            Me.DsArticulos.ARTICULOS.Load(cmd.ExecuteReader)

            Me.dgArticulos.BringToFront()
            Me.navArticulos.NavigatableControl = Me.dgArticulos

        Catch ex As Exception
            MsgBox("Error al cargar artículos", MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Sub
#End Region

#Region "bttCajas_Click"
    Private Sub bttCajas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCajas.Click
        If Me.bttCajas.ForeColor = Color.Maroon Then
            Me.bttCajas.Font = New Font(Me.bttCajas.Font, FontStyle.Regular)
            Me.bttCajas.ForeColor = Color.Empty
        Else
            Me.bttCajas.Font = New Font(Me.bttCajas.Font, FontStyle.Bold)
            Me.bttCajas.ForeColor = Color.Maroon
        End If
    End Sub
#End Region

#Region "ImprimirAlbaran"
    Private Sub ImprimirAlbaran(ByVal IdTicket As Integer)

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
                MsgBox("Error al imprimir el albarán", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            'Datos tienda
            cmd.CommandText = "SELECT * FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
            dsFactura.TIENDAS.Load(cmd.ExecuteReader)

            'Datos cliente
            If rticket.IsClienteCreditoNull Then
                DameCliente.ShowDialog()
                rticket.ClienteCredito = DameCliente.CodigoCliente
            End If
            If rticket.TipoFactura = 3 Then
                cmd.CommandText = "SELECT * FROM CLIENTES WHERE Codigo = 0"
            Else
                cmd.CommandText = "SELECT * FROM CLICREDI WHERE Codigo = " & rticket.ClienteCredito
            End If
            dsFactura.CLIENTES.Load(cmd.ExecuteReader)

            'Líneas ticket
            cmd.CommandText = "SELECT * FROM TICKETS_LINEAS WHERE Ticket_Id=" & rticket.Id
            dsFactura.TICKETS_LINEAS.Load(cmd.ExecuteReader)

            'Totales ticket
            Informes.TotalesTicket(dsFactura)

            Dim Informe As New InfFactura

            'Nombre empleado
            Informe.RequestParameters = False

            If dsFactura.TICKETS_LINEAS.Rows.Count > 0 Then
                cmd.CommandText = "SELECT NombreTicket FROM OPERARIOS WHERE Codigo=" & dsFactura.TICKETS_LINEAS.Rows(0).Item("CodigoEmleado")
                Informe.Parameters("Empleado").Value = "LE ATENDIO: " & cmd.ExecuteScalar
            End If

            If Not rticket.IsNumeroAlbaranNull Then
                Informe.Parameters("Numero").Value = rticket.NumeroAlbaran
            Else
                Informe.Parameters("Numero").Value = rticket.HoraTicket.ToShortTimeString
                rticket.TipoFactura = 1
            End If

            If dsFactura.TIENDAS.Count > 0 Then
                With dsFactura.TIENDAS(0)

                    Select Case rticket.TipoFactura
                        Case 1
                            Informe.Parameters("Documento").Value = "ALBARÁN"
                            If Not .IsSerieAlbaranNull Then Informe.Parameters("Numero").Value = .SerieAlbaran.Trim & "-" & rticket.NumeroAlbaran
                        Case 2
                            Informe.Parameters("Documento").Value = "FACTURA"
                            If Not .IsSerieFactura1Null Then Informe.Parameters("Numero").Value = .SerieFactura1.Trim & "-" & rticket.NumeroAlbaran
                        Case 3
                            Informe.Parameters("Documento").Value = "ALBARÁN"
                            If Not .IsSerieFactura2Null Then Informe.Parameters("Numero").Value = .SerieFactura2.Trim & "-" & rticket.NumeroAlbaran
                    End Select

                End With
            End If

            Informe.DataSource = dsFactura

            Informe.CreateDocument()

            Dim printTool As New DevExpress.XtraPrinting.PrintTool(Informe.PrintingSystem)

            If My.Settings.ImpresoraFacturas = String.Empty Then

                Dim f As New PreImpreso
                f.Informe.PrintingSystem = Informe.PrintingSystem

                If Not printTool.PrintDialog Then
                    General.AbrirFormulario(f, Informe.Parameters("Documento").Value & " Nº " & Informe.Parameters("Numero").Value)
                End If

            Else
                printTool.Print(My.Settings.ImpresoraFacturas)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Error al imprimir el documento." & vbCrLf & ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

#Region "ImprimirOrdenTrabajo"
    Private Sub ImprimirOrdenTrabajo(ByVal IdTicket As Integer)

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
            cmd.CommandText = "SELECT * FROM TICKETS WHERE Id=" & IdTicket
            dsFactura.TICKETS.Load(cmd.ExecuteReader)
            If dsFactura.TICKETS.Rows.Count = 1 Then
                rticket = dsFactura.TICKETS.Rows(0)
            Else
                MsgBox("Error al imprimir el albarán", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            'Datos tienda
            cmd.CommandText = "SELECT * FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda
            dsFactura.TIENDAS.Load(cmd.ExecuteReader)

            'Datos cliente
            If rticket.CodigoCliente = 0 Then
                Dim fDameCliente As New DameCliente
                If fDameCliente.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    rticket.CodigoCliente = fDameCliente.CodigoCliente
                End If
            End If

            Dim Cliente As New dsClientes
            cmd.CommandText = "SELECT * FROM CLIENTES WHERE Codigo=" & rticket.CodigoCliente
            Cliente.CLIENTES.Load(cmd.ExecuteReader)

            If Cliente.CLIENTES.Count > 0 Then

                Dim fDatosCliente As New fDatosCliente

                With Cliente.CLIENTES(0)
                    fDatosCliente.txtNombreFiscal.EditValue = .NombreFiscal
                    fDatosCliente.txtDireccion.EditValue = .Direccion
                    fDatosCliente.txtCodigoPostal.EditValue = .CodigoPostal
                    fDatosCliente.txtPoblacion.EditValue = .Poblacion
                    fDatosCliente.txtProvincia.EditValue = .Provincia
                    fDatosCliente.txtNIF.EditValue = .CIF
                    If fDatosCliente.ShowDialog = Windows.Forms.DialogResult.OK Then

                        Dim rCliente As dsInfFactura.CLIENTESRow = dsFactura.CLIENTES.NewCLIENTESRow
                        rCliente.Codigo = 0
                        rCliente.NombreFiscal = fDatosCliente.txtNombreFiscal.EditValue
                        rCliente.Direccion = fDatosCliente.txtDireccion.EditValue
                        rCliente.CodigoPostal = fDatosCliente.txtCodigoPostal.EditValue
                        rCliente.Poblacion = fDatosCliente.txtPoblacion.EditValue
                        rCliente.Provincia = fDatosCliente.txtProvincia.EditValue
                        rCliente.Nif = fDatosCliente.txtNIF.EditValue
                        dsFactura.CLIENTES.AddCLIENTESRow(rCliente)

                        'Guardar cabecera ticket
                        Me.rTicket.CodigoCliente = rticket.CodigoCliente
                        Me.rTicket.Km = rticket.Km
                        Me.TICKETSBindingSource.EndEdit()
                        Me.TICKETSTableAdapter.Update(Me.DsTickets.TICKETS)

                    Else
                        Exit Try
                    End If
                End With

            Else
                Exit Try
            End If

            'Líneas ticket
            cmd.CommandText = "SELECT * FROM TICKETS_LINEAS WHERE Ticket_Id=" & rticket.Id
            dsFactura.TICKETS_LINEAS.Load(cmd.ExecuteReader)

            'Totales ticket
            Informes.TotalesTicket(dsFactura)

            Dim Informe As New InfFacturaSinValorar

            'Nombre empleado
            Informe.RequestParameters = False

            If dsFactura.TICKETS_LINEAS.Rows.Count > 0 Then
                cmd.CommandText = "SELECT NombreTicket FROM OPERARIOS WHERE Codigo=" & dsFactura.TICKETS_LINEAS.Rows(0).Item("CodigoEmleado")
                Informe.Parameters("Empleado").Value = "LE ATENDIO: " & cmd.ExecuteScalar
            End If

            If Not rticket.IsNumeroAlbaranNull Then
                Informe.Parameters("Numero").Value = General.NumeroAlmacen.ToString("00") & "-" & rticket.NumeroAlbaran
            Else
                Informe.Parameters("Numero").Value = General.NumeroAlmacen.ToString("00") & "-" & rticket.HoraTicket.ToShortTimeString
                rticket.TipoFactura = 1
            End If

            Select Case rticket.TipoFactura
                Case 1, 3
                    Informe.Parameters("Documento").Value = "ALBARÁN / ORDEN DE TRABAJO"
                Case Else
                    Informe.Parameters("Documento").Value = "FACTURA"
            End Select

            Informe.DataSource = dsFactura

            Informe.CreateDocument()

            Dim printTool As New DevExpress.XtraPrinting.PrintTool(Informe.PrintingSystem)

            If My.Settings.ImpresoraFacturas = String.Empty Then

                Dim f As New PreImpreso
                f.Informe.PrintingSystem = Informe.PrintingSystem

                If Not printTool.PrintDialog Then
                    General.AbrirFormulario(f, Informe.Parameters("Documento").Value & " Nº " & Informe.Parameters("Numero").Value)
                End If

            Else
                printTool.Print(My.Settings.ImpresoraFacturas)
            End If

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Error al imprimir el documento." & vbCrLf & ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            Me.Cursor = Cursors.Default
        End Try

    End Sub

#End Region

#Region "bttTeclado_ItemClick"
    Private Sub bttTeclado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        System.Diagnostics.Process.Start("osk.exe")
    End Sub
#End Region

#Region "CodigoBarrasCalavia"
    Private Function CodigoBarrasCalavia() As String

        Dim CodigoArticulo As String = "0000006"

        Try
            If Len(Me.txtCodigoArticulo.EditValue) = 8 And Mid(Me.txtCodigoArticulo.EditValue, 1, 2) = "26" Then
                If IsNumeric(Mid(Me.txtCodigoArticulo.EditValue, 3, 5)) Then
                    CodigoArticulo = Format(CInt(Mid(Me.txtCodigoArticulo.EditValue, 3, 5)), "0000000") : Exit Try
                End If
            End If
            If Len(Me.txtCodigoArticulo.EditValue) = 13 And (Mid(Me.txtCodigoArticulo.EditValue, 1, 2) = "26" Or Mid(Me.txtCodigoArticulo.EditValue, 1, 2) = "27") Then
                If IsNumeric(Mid(Me.txtCodigoArticulo.EditValue, 3, 5)) Then
                    CodigoArticulo = "01" & Format(CInt(Mid(Me.txtCodigoArticulo.EditValue, 3, 5)), "00000") : Exit Try
                End If
            End If
            If Len(Me.txtCodigoArticulo.EditValue) = 13 And Mid(Me.txtCodigoArticulo.EditValue, 1, 4) = "2324" Then
                CodigoArticulo = "0000004" : Exit Try
            End If
            If Len(Me.txtCodigoArticulo.EditValue) = 13 And Mid(Me.txtCodigoArticulo.EditValue, 1, 6) = "200000" Then
                CodigoArticulo = "0000004" : Exit Try
            End If

            Select Case Mid(Me.txtCodigoArticulo.EditValue, 1, 7)
                Case "2540003", "2540004", "2540005"
                    CodigoArticulo = "0000033" : Exit Try
                Case "2500005"
                    CodigoArticulo = "0000111" : Exit Try
                Case "2520001", "2520002"
                    CodigoArticulo = "0000002" : Exit Try
                Case "2520004"
                    CodigoArticulo = "0000022" : Exit Try
            End Select

            If General.NumeroAlmacen = 3 Then
                Select Case Mid(Me.txtCodigoArticulo.EditValue, 1, 7)
                    Case "2520003"
                        CodigoArticulo = "0000002" : Exit Try
                    Case "2520005"
                        CodigoArticulo = "0000022" : Exit Try
                End Select
            End If

            If General.NumeroAlmacen = 2 Or General.NumeroAlmacen = 3 Or General.NumeroAlmacen = 5 Then
                Select Case Mid(Me.txtCodigoArticulo.EditValue, 1, 3)
                    Case "254"
                        CodigoArticulo = "0000003" : Exit Try
                    Case "256"
                        CodigoArticulo = "0000004" : Exit Try
                    Case "250"
                        CodigoArticulo = "0000001" : Exit Try
                    Case "255"
                        CodigoArticulo = "0000006" : Exit Try
                End Select
            End If

            Select Case Mid(Me.txtCodigoArticulo.EditValue, 1, 4)
                Case "2505"
                    CodigoArticulo = "0000006" : Exit Try
            End Select

            Select Case Mid(Me.txtCodigoArticulo.EditValue, 1, 7)
                Case "2540001"
                    CodigoArticulo = "0000003" : Exit Try
                Case "2520003"
                    CodigoArticulo = "0000001" : Exit Try
            End Select

            Select Case Mid(Me.txtCodigoArticulo.EditValue, 1, 6)
                Case "250201"
                    CodigoArticulo = "0000001" : Exit Try
                Case "250202"
                    CodigoArticulo = "0000002" : Exit Try
                Case "250203"
                    CodigoArticulo = "0000003" : Exit Try
                Case "250204"
                    CodigoArticulo = "0000004" : Exit Try
                Case "250205"
                    CodigoArticulo = "0000022" : Exit Try
                Case "250206"
                    CodigoArticulo = "0000006" : Exit Try
                Case "250207"
                    CodigoArticulo = "0000033" : Exit Try
                Case "250208"
                    CodigoArticulo = "0000111" : Exit Try
            End Select

        Catch ex As Exception
            MsgBox("Error al comprobar código de barras." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try

        Return CodigoArticulo

    End Function
#End Region

#Region "CodigoBarrasMolina"
    Private Function CodigoBarrasMolina() As Boolean
        Try
            If Len(Me.txtCodigoArticulo.EditValue) = 13 And IsNumeric(Mid(Me.txtCodigoArticulo.EditValue, 1, 2)) Then
                Select Case Mid(Me.txtCodigoArticulo.EditValue, 1, 2)
                    Case "25"
                        Me.NuevaLineaTicket("0005800", 1, CDec(Me.txtCodigoArticulo.EditValue.ToString.Substring(8, 4)) / 100, False)
                        Return True
                    Case "27"
                        Me.NuevaLineaTicket("0005801", 1, CDec(Me.txtCodigoArticulo.EditValue.ToString.Substring(8, 4)) / 100, False)
                        Return True
                End Select
            End If

            Return False

        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "bttCanjearPuntos_Click"
    Private Sub bttCanjearPuntos_Click(sender As Object, e As EventArgs) Handles bttCanjearPuntos.Click
        Try
            Dim fCanjearPuntos As New fCanjearPuntos(Me.txtCodigoEmpleado.EditValue)
            fCanjearPuntos.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
#End Region

#Region "SorteActivo"
    Public Sub SorteActivo()
        Try
            Dim Sorteo As New dsSorteos

            Sorteo.Cargar()

            If Sorteo.SorteoActivo Is Nothing Then Exit Try

            With Sorteo.SorteoActivo

                If .SoloTarjetas And rTicket.CodigoCliente = 0 Then Exit Try

                If .Tipo = 0 Then
                    If .Fraccion > rTicket.ImporteTotal Then Exit Try
                    If .Fraccion <> 0 Then rTicket.ImporteSorteo = Int(rTicket.ImporteTotal / .Fraccion) * .Participacion
                Else

                    rTicket.ImporteSorteo = 0

                    Dim Lineas As DataRow() = Me.DsTickets.TICKETS_LINEAS.Select
                    For lin As Integer = 0 To Lineas.Length - 1
                        With CType(Lineas(lin), dsTickets.TICKETS_LINEASRow)

                            If Not Sorteo.SorteoActivo.AplicaPromociones And .Promocion Then Continue For

                            rTicket.ImporteSorteo += .Importe * .DtoFidelizacion / 100

                            If Sorteo.SorteoActivo.Tipo = 3 Then
                                If .DtoFidelizacion > .DescuentoLinea Then
                                    .DescuentoLinea = .DtoFidelizacion
                                    Me.ActualizaTotalLinea(Lineas(lin))
                                End If
                            End If

                        End With
                    Next

                End If

                Dim DecimalesPuntos As Integer = IIf(.Tipo = 1, 0, 2)
                rTicket.ImporteSorteo = Math.Round(rTicket.ImporteSorteo, DecimalesPuntos, MidpointRounding.AwayFromZero)

                Select Case .Tipo
                    Case 0
                        rTicket.FidelizacionLoteria = rTicket.ImporteSorteo
                    Case 1
                        rTicket.FidelizacionPuntos = rTicket.ImporteSorteo
                    Case 2
                        rTicket.FidelizacionVales = rTicket.ImporteSorteo
                    Case 3
                        rTicket.FidelizacionImporte = rTicket.ImporteSorteo
                End Select

            End With

            Me.TotalTicket()
            Me.gvLineasTicket.RefreshData()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

    Private Sub navArticulos_ButtonClick(sender As Object, e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs) Handles navArticulos.ButtonClick
        If e.Button.ButtonType = DevExpress.XtraEditors.NavigatorButtonType.Custom Then
            Me.ReiniciaAccesos()
        End If
    End Sub

    Private Sub ReiniciaAccesos()
        Me.lvFamilias.MoveFirst()
        Me.navArticulos.NavigatableControl = Me.dgFamilias
        Me.dgArticulos.SendToBack()
    End Sub

End Class