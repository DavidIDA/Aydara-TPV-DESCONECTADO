Module General

    Public DatosTienda As dsTiendas.TIENDASRow

    'Parámetros tienda
    Public CodigoTienda As Integer
    Public NombreTienda As String
    Public FormatoEmpresa As String
    Public DecimalesPrecio As Integer, DecimalesImporte As Integer, CopiasDocumentos As Integer
    Public GestionTallas As Boolean, GestionColores As Boolean, ImpresionEtiquetas As Boolean, ControlVendedores As Boolean
    Public CantidadManual As Boolean, PrecioManual As Boolean, DtoEnLinea As Boolean, DtoSobrePromociones As Boolean
    Public VentasPorFamiliaCierre As Boolean, VentasPorVendedorCierre As Boolean
    Public TipoIva1 As Decimal, TipoIva2 As Decimal, TipoIva3 As Decimal, TipoIva4 As Decimal
    Public TicketDeBascula As Boolean, PrefijoBascula1 As String, PrefijoBascula2 As String, PrefijoBascula3 As String
    Public PrefijoEtiqueta As String
    Public GestionTarjetas As Boolean, DescuentoTarjetas As Decimal, ControlTarjetas As Boolean
    Public TextoImpuesto As String
    Public RecibePromociones As Boolean
    Public ActualizaCosto As Boolean
    Public DtoSobreTarifa As Decimal
    Public DtoSobrePromocion As Decimal
    Public AlbaranFormatoTicket As Decimal, AlbaranFormatoA4 As Decimal
    Public EtiquetaElectronica As Boolean, VentaCredito As Boolean

    Dim Actualizando As Boolean

    'Parámetros comunicaciones-varios
    Public NumeroAlmacen As Integer, TipoTienda As Integer, Comunicaciones_Tipo As Integer
    Public Comunicaciones_Direccion As String, Comunicaciones_Usuario As String, Comunicaciones_Password As String, Comunicaciones_Envio As String, Comunicaciones_Terminales As String, Comunicaciones_DirectorioFicheros As String
    Public ArticuloPropioInicio As String, ArticuloPropioFin As String, NumeroTarifa As Integer
    Public TipoRecargo1 As Decimal, TipoRecargo2 As Decimal, TipoRecargo3 As Decimal, TipoRecargo4 As Decimal
    Public FechaUltimaActualizacion As Date

    'Parámetros caja
    Public CodigoCaja As Integer
    Public ActivaCorteTicket As Boolean, ActivaAperturaCajon As Boolean, ActivaVisor As Boolean
    Public TextoCorteTicket As String, TextoAperturaCajon As String, TextoActivaVisor As String, TextoDesactivaVisor As String, TextoActivaExpandido As String, TextoDesactivaExpandido As String
    Public ImprimeTicket As Integer, NumeroTicket As Integer

    Public CodigoEmpleado As Integer

    'Resultado al hacer doble click en búsquedas
    Public ResultadoBusqueda As String

#Region "AbrirFormulario"
    Function AbrirFormulario(ByVal Nombre As Form, ByVal Titulo As String)
        Try
            Principal.Cursor = Cursors.WaitCursor

            Dim f As Form
            'Si esta abierta la pestaña la muestra
            For Each f In Principal.MdiChildren()
                If f.Name = Nombre.Name And f.Name <> "PreImpreso" Then
                    f.Select()
                    Return True
                End If
            Next

            f = Nombre
            f.Text = Titulo
            f.MdiParent = Principal
            f.Show()
            Return True

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            Return False
        Finally
            Principal.Cursor = Cursors.Default
        End Try
    End Function
#End Region

#Region "Buscar"
    Public Function Buscar(ByVal DataSet As DataSet, ByVal DataMember As String, ByVal Columnas As ArrayList, ByVal FocoColumna As Integer, Optional ByVal OcultaId As Boolean = False, Optional ByVal Filtro As String = "") As Form
        Try
            Dim f As New Busqueda
            Dim i As Integer

            For i = 0 To Columnas.Count - 1 Step 4
                f.gvBusqueda.Columns.AddVisible(Columnas(i), Columnas(i + 1))
                If Columnas(i + 2) > 0 Then f.gvBusqueda.Columns(CType(i / 4, Integer)).Width = Columnas(i + 2)
                If Columnas(i + 3) > 0 Then f.gvBusqueda.Columns(CType(i / 4, Integer)).MaxWidth = Columnas(i + 3)
            Next

            If OcultaId Then f.gvBusqueda.Columns(0).Visible = False

            f.dgBusqueda.DataSource = DataSet
            f.dgBusqueda.DataMember = DataMember

            f.gvBusqueda.FocusedRowHandle = -999997
            f.gvBusqueda.FocusedColumn = f.gvBusqueda.Columns(FocoColumna)

            If Filtro <> "" Then f.gvBusqueda.ActiveFilterString = Filtro

            If f.dgBusqueda.DataMember = "CLIENTES" Or f.dgBusqueda.DataMember = "CLICREDI" Then
                f.gvBusqueda.RowHeight = 35
            End If

            Return f

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
#End Region

#Region "DatosTiendaActual"
    Public Function DatosTiendaActual(ByVal CodigoTienda As Integer) As Boolean
        Try
            Dim dsTiendas As New dsTiendas
            Dim taTiendas As New dsTiendasTableAdapters.TIENDASTableAdapter

            taTiendas.Fill(dsTiendas.TIENDAS)

            If dsTiendas.TIENDAS.Count > 0 Then

                DatosTienda = dsTiendas.TIENDAS(0)

                With DatosTienda
                    NombreTienda = .NombreFiscal
                    FormatoEmpresa = .FormatoEmpresa
                    CopiasDocumentos = .CopiasDocumentos
                    DecimalesPrecio = .DecimalesPrecio
                    DecimalesImporte = .DecimalesImporte
                    GestionTallas = .GestionTallas
                    GestionColores = .GestionColores
                    ImpresionEtiquetas = .ImpresionEtiquetas
                    ControlVendedores = .ControlVendedores
                    CantidadManual = .CantidadManual
                    PrecioManual = .PrecioManual
                    DtoEnLinea = .DtoEnLinea
                    DtoSobrePromociones = .DtoSobrePromociones
                    VentasPorFamiliaCierre = .VtasPorFamiliaCierre
                    VentasPorVendedorCierre = .VtasPorVendedorCierre
                    TipoIva1 = .TipoIva1
                    TipoIva2 = .TipoIva2
                    TipoIva3 = .TipoIva3
                    TipoIva4 = .TipoIva4
                    GestionTarjetas = .GestionTarjetas
                    DescuentoTarjetas = .GeneralTarjetas
                    ControlTarjetas = .ControlTarjetas
                    TicketDeBascula = .TicketDeBascula
                    PrefijoBascula1 = .PrefijoBascula1
                    PrefijoBascula2 = .PrefijoBascula2
                    PrefijoBascula3 = .PrefijoBascula3
                    PrefijoEtiqueta = .PrefijoEtiqueta
                    TextoImpuesto = .TextoImpuesto
                    'Comunicaciones
                    NumeroAlmacen = .NumeroAlmacen
                    TipoTienda = .TipoTienda
                    Comunicaciones_Tipo = .Comunicaciones_Tipo
                    Comunicaciones_Direccion = .Comunicaciones_Direccion
                    Comunicaciones_Usuario = .Comunicaciones_Usuario
                    Comunicaciones_Password = .Comunicaciones_Password
                    Comunicaciones_Envio = .Comunicaciones_Envio
                    Comunicaciones_Terminales = .Comunicaciones_Terminales
                    Comunicaciones_DirectorioFicheros = .Comunicaciones_DirectorioFicheros
                    ArticuloPropioInicio = .ArticuloPropioInicio
                    ArticuloPropioFin = .ArticuloPropioFin
                    NumeroTarifa = .NumeroTarifa
                    TipoRecargo1 = .TipoRecargo1
                    TipoRecargo2 = .TipoRecargo2
                    TipoRecargo3 = .TipoRecargo3
                    TipoRecargo4 = .TipoRecargo4
                    FechaUltimaActualizacion = .FechaUltimaActualizacion
                    Actualizando = .Actualizando
                    RecibePromociones = .RecibePromociones
                    ActualizaCosto = .ActualizaCosto
                    DtoSobreTarifa = .DtoSobreTarifa
                    DtoSobrePromocion = .DtoSobrePromocion
                    AlbaranFormatoTicket = .AlbaranFormatoTicket
                    AlbaranFormatoA4 = .AlbaranFormatoA4
                    EtiquetaElectronica = .EtiquetaElectronica
                    VentaCredito = .VentaCredito
                End With

            End If

            If Actualizando Then
                If ActualizandoTienda.ShowDialog() = DialogResult.Abort Then Application.Exit()
            End If

            Return True

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show("Error al obtener datos de la tienda." & vbCrLf & ex.Message)
            Return False
        End Try
    End Function
#End Region

#Region "DatosCajaActual"
    Public Sub DatosCajaActual(ByVal CodigoCaja As Integer)

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand

        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            cmd.CommandText = "SELECT * FROM CAJAS"

            If CodigoCaja > 0 Then cmd.CommandText += " WHERE CodigoCaja=" & CodigoCaja

            dr = cmd.ExecuteReader

            If dr.Read Then
                ActivaCorteTicket = dr("CorteTicket")
                ActivaAperturaCajon = dr("AperturaCajon")
                ActivaVisor = dr("Visor")
                TextoCorteTicket = dr("TextoCorteTicket")
                TextoAperturaCajon = dr("AbreCajon")
                TextoActivaVisor = dr("ActivaVisor")
                TextoDesactivaVisor = dr("DesactivaVisor")
                TextoActivaExpandido = dr("ActivaExpandido")
                TextoDesactivaExpandido = dr("DesactivaExpandido")
                ImprimeTicket = dr("ImprimeTicket")
                NumeroTicket = dr("NumeroTicket")
            Else
                If CodigoCaja = 0 Then
                    MsgBox("No se ha encontrado ninguna caja en la base de datos", MsgBoxStyle.Exclamation, "No existe ninguna tienda")
                Else
                    DatosCajaActual(0)
                End If
            End If

            dr.Close()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Sub
#End Region

#Region "CorteTicket"
    Public Function CorteTicket() As String
        Dim parametros() As String
        Dim cadena As String = vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf & vbCrLf
        Dim i As Integer

        parametros = Split(TextoCorteTicket, "+")

        For i = 0 To parametros.Length - 1
            If parametros(i) <> String.Empty Then cadena += Chr(parametros(i))
        Next

        Return cadena

    End Function
#End Region

#Region "ActivaExpandido"
    Public Function ActivaExpandido() As String
        Dim parametros() As String
        Dim cadena As String = String.Empty
        Dim i As Integer

        parametros = Split(TextoActivaExpandido, "+")

        For i = 0 To parametros.Length - 1
            If parametros(i) <> String.Empty Then cadena += Chr(parametros(i))
        Next

        Return cadena

    End Function
#End Region

#Region "DesactivaExpandido"
    Public Function DesactivaExpandido() As String
        Dim parametros() As String
        Dim cadena As String = String.Empty
        Dim i As Integer

        parametros = Split(TextoDesactivaExpandido, "+")

        For i = 0 To parametros.Length - 1
            If parametros(i) <> String.Empty Then cadena += Chr(parametros(i))
        Next

        Return cadena

    End Function
#End Region

#Region "AbreCajon"
    Public Function AbreCajon() As String
        Dim parametros() As String
        Dim cadena As String = String.Empty
        Dim i As Integer

        parametros = Split(TextoAperturaCajon, "+")

        For i = 0 To parametros.Length - 1
            If parametros(i) <> String.Empty Then cadena += Chr(parametros(i))
        Next

        Return cadena

    End Function
#End Region

#Region "SituacionTienda"
    Public Function SituacionTienda(Optional ByVal CodigoCaja As Integer = 0, Optional ByVal CierreTurno As Boolean = False) As dsTiendas

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Dim dsTiendas As New dsTiendas

            Dim rSituacion As dsTiendas.SITUACIONRow
            Dim cmdTotales As New SqlClient.SqlCommand

            cmdTotales.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmdTotales.Connection.Open()

            cmd.CommandText = "SELECT CodigoCaja FROM Cajas WHERE CodigoTienda=" & CodigoTienda
            If CodigoCaja <> 0 Then cmd.CommandText &= " AND CodigoCaja=" & CodigoCaja
            cmd.CommandText &= " ORDER BY CodigoCaja"

            dr = cmd.ExecuteReader
            While dr.Read

                rSituacion = dsTiendas.SITUACION.NewSITUACIONRow

                rSituacion.CodigoCaja = dr("CodigoCaja")

                'Total tickets
                cmdTotales.CommandText = "SELECT ISNULL(Count(Id),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND EnEspera=0 AND TipoFactura=0"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"

                rSituacion.Tickets = cmdTotales.ExecuteScalar

                'Total líneas tickets
                cmdTotales.CommandText = "SELECT ISNULL(Count(TICKETS_Lineas.Id),0) FROM TICKETS INNER JOIN TiCKETS_LINEAS ON TICKETS.Id=TICKETS_LINEAS.Ticket_Id WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND TICKETS.EnEspera=0  AND TICKETS.TipoFactura=0"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.Lineas = cmdTotales.ExecuteScalar

                'Total efectivo
                Dim TotalEfectivo As Decimal
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteEfectivo-ImporteCambios),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja")
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                TotalEfectivo = cmdTotales.ExecuteScalar

                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre IS NULL AND (TipoMovimiento='EC' OR (TipoMovimiento='CC' AND TipoCobro=0) OR (TipoMovimiento='EV' AND TipoCobro=1))"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(Movimientos_Caja.CierreTurno,0)=0"
                TotalEfectivo += cmdTotales.ExecuteScalar

                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre IS NULL AND (TipoMovimiento='RF' OR TipoMovimiento='PC')"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(Movimientos_Caja.CierreTurno,0)=0"
                TotalEfectivo -= cmdTotales.ExecuteScalar

                'If TotalEfectivo > 0 Then rSituacion.Efectivo = TotalEfectivo
                rSituacion.Efectivo = TotalEfectivo

                'Total cheques
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteTalonCheque),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja")
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.Talon = cmdTotales.ExecuteScalar

                'Total tarjeta
                Dim TotalTarjeta As Decimal
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteTarjeta),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja")
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                TotalTarjeta = cmdTotales.ExecuteScalar

                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre IS NULL AND (TipoMovimiento='CC' AND TipoCobro=1)"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(Movimientos_Caja.CierreTurno,0)=0"
                TotalTarjeta += cmdTotales.ExecuteScalar

                rSituacion.Tarjeta = TotalTarjeta

                'Total vales proveedor
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteValesProveedor),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja")
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.ValesProveedor = cmdTotales.ExecuteScalar

                'Total envases
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteEnvases),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja")
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.Envases = cmdTotales.ExecuteScalar

                'Total pendiente cobro
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImportePendienteCobro),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja")
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.PendienteCobro = cmdTotales.ExecuteScalar

                'Total vales emitidos
                Dim TotalValesEmitidos As Decimal
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteValesEmitidos),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja")
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                TotalValesEmitidos = cmdTotales.ExecuteScalar

                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre IS NULL AND TipoMovimiento='EV'"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(Movimientos_Caja.CierreTurno,0)=0"
                TotalValesEmitidos += cmdTotales.ExecuteScalar

                rSituacion.ValesEmitidos = TotalValesEmitidos

                'Total vales cobrados
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteValesCobrados),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja")
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.ValesCobrados = cmdTotales.ExecuteScalar

                'Total cobros a cliente
                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre IS NULL AND TipoMovimiento='CC'"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(Movimientos_Caja.CierreTurno,0)=0"
                rSituacion.CobrosCliente = cmdTotales.ExecuteScalar

                'Total pagos proveedor
                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre IS NULL AND TipoMovimiento='PC'"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(Movimientos_Caja.CierreTurno,0)=0"
                rSituacion.PagosProveedor = cmdTotales.ExecuteScalar

                'Número de albaranes de crédito
                cmdTotales.CommandText = "SELECT Count(Id) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND TipoFactura = 1"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.NumeroAlbaranes = cmdTotales.ExecuteScalar

                'Total líneas albaranes
                cmdTotales.CommandText = "SELECT ISNULL(Count(TICKETS_Lineas.Id),0) FROM TICKETS INNER JOIN TiCKETS_LINEAS ON TICKETS.Id=TICKETS_LINEAS.Ticket_Id WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND TipoFactura = 1"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.LineasAlbaranes = cmdTotales.ExecuteScalar

                'Total albarán crédito
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteTotal),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND TipoFactura = 1"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.AlbaranCredito = cmdTotales.ExecuteScalar

                'Número de facturas de crédito
                cmdTotales.CommandText = "SELECT Count(Id) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND (TipoFactura = 2 OR TipoFactura = 3)"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.NumeroFacturas = cmdTotales.ExecuteScalar

                'Total líneas facturas
                cmdTotales.CommandText = "SELECT ISNULL(Count(TICKETS_Lineas.Id),0) FROM TICKETS INNER JOIN TiCKETS_LINEAS ON TICKETS.Id=TICKETS_LINEAS.Ticket_Id WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND (TipoFactura = 2 OR TipoFactura = 3)"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.LineasFacturas = cmdTotales.ExecuteScalar

                'Total facturas crédito
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteTotal),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND (TipoFactura = 2 OR TipoFactura = 3)"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.ImporteFacturas = cmdTotales.ExecuteScalar

                'Total pendiente cobro venta crédito
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImportePendienteCobro),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND TipoFactura <> 0"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.PendienteCredito = cmdTotales.ExecuteScalar

                'Total entrada cambios
                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre IS NULL AND TipoMovimiento='EC'"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(Movimientos_Caja.CierreTurno,0)=0"
                rSituacion.EntradaCambios = cmdTotales.ExecuteScalar

                'Total retirada fondos
                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre IS NULL AND TipoMovimiento='RF'"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(Movimientos_Caja.CierreTurno,0)=0"
                rSituacion.RetiradaFondos = cmdTotales.ExecuteScalar

                'Total descuentos
                cmdTotales.CommandText = "SELECT ISNULL(Sum(Round(TICKETS_LINEAS.Cantidad * TICKETS_LINEAS.Precio * TICKETS_LINEAS.DescuentoLinea / 100, 2)),0) " & _
                                         "FROM TICKETS INNER JOIN TICKETS_LINEAS ON TICKETS.Id = TICKETS_LINEAS.Ticket_Id " & _
                                         "WHERE TICKETS.CodigoTienda=" & CodigoTienda & " AND TICKETS.CodigoCaja=" & dr("CodigoCaja") & " AND TICKETS.EnEspera=0"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.Descuentos = cmdTotales.ExecuteScalar

                'Total reparto a domicilio
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteTotal),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND RepartoDomicilio=1"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.RepartoDomicilio = cmdTotales.ExecuteScalar

                'Total vales cliente canjeados
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ValesCanjeados),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND RepartoDomicilio=1"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.ValesClienteCanjeados = cmdTotales.ExecuteScalar

                'Total venta
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteTotal),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND EnEspera=0"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.Venta = cmdTotales.ExecuteScalar

                'Total descuento PP
                cmdTotales.CommandText = "SELECT ISNULL(Sum(TotalDtoPP),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND EnEspera=0"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.DescuentoPP = cmdTotales.ExecuteScalar

                'Total recargos
                cmdTotales.CommandText = "SELECT ISNULL(Sum(TotalRecargo),0) FROM TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND EnEspera=0"
                If CierreTurno Then cmdTotales.CommandText &= " AND ISNULL(TICKETS.CierreTurno,0)=0"
                rSituacion.RecargoEquivalencia = cmdTotales.ExecuteScalar

                dsTiendas.SITUACION.AddSITUACIONRow(rSituacion)

            End While

            dr.Close()

            Return dsTiendas

        Catch ex As Exception
            MsgBox("Error al calcular totales de las cajas", MsgBoxStyle.Exclamation)
            Return Nothing
        Finally
            cmd.Connection.Close()
        End Try
    End Function
#End Region

#Region "SituacionTiendaFecha"
    Public Function SituacionTiendaFecha(ByVal FechaCierre As Date) As dsTiendas

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            Dim dsTiendas As New dsTiendas

            Dim rSituacion As dsTiendas.SITUACIONRow
            Dim cmdTotales As New SqlClient.SqlCommand

            cmdTotales.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmdTotales.Connection.Open()

            cmd.CommandText = "SELECT CodigoCaja FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND HISTORICO_TICKETS.FechaTicket='" & FechaCierre & "' " & _
                              "GROUP BY CodigoCaja ORDER BY CodigoCaja"

            dr = cmd.ExecuteReader
            While dr.Read

                rSituacion = dsTiendas.SITUACION.NewSITUACIONRow

                rSituacion.CodigoCaja = dr("CodigoCaja")

                'Total tickets
                cmdTotales.CommandText = "SELECT ISNULL(Count(Id),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND HISTORICO_TICKETS.FechaTicket='" & FechaCierre & "' AND HISTORICO_TICKETS.TipoFactura=0"

                rSituacion.Tickets = cmdTotales.ExecuteScalar

                'Total líneas tickets
                cmdTotales.CommandText = "SELECT ISNULL(Count(HISTORICO_TICKETS_Lineas.Id),0) FROM HISTORICO_TICKETS INNER JOIN HISTORICO_TICKETS_LINEAS ON HISTORICO_TICKETS.Id=HISTORICO_TICKETS_LINEAS.Ticket_Id WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND HISTORICO_TICKETS.FechaTicket='" & FechaCierre & "'  AND HISTORICO_TICKETS.TipoFactura=0"
                rSituacion.Lineas = cmdTotales.ExecuteScalar

                'Total efectivo
                Dim TotalEfectivo As Decimal
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteEfectivo-ImporteCambios),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND HISTORICO_TICKETS.FechaTicket='" & FechaCierre & "'"
                TotalEfectivo = cmdTotales.ExecuteScalar

                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre='" & FechaCierre & "' AND (TipoMovimiento='EC' OR (TipoMovimiento='CC' AND TipoCobro=0) OR (TipoMovimiento='EV' AND TipoCobro=1))"
                TotalEfectivo += cmdTotales.ExecuteScalar

                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre='" & FechaCierre & "' AND (TipoMovimiento='RF' OR TipoMovimiento='PC')"
                TotalEfectivo -= cmdTotales.ExecuteScalar

                'If TotalEfectivo > 0 Then rSituacion.Efectivo = TotalEfectivo
                rSituacion.Efectivo = TotalEfectivo

                'Total cheques
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteTalonCheque),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND FechaTicket='" & FechaCierre & "'"
                rSituacion.Talon = cmdTotales.ExecuteScalar

                'Total tarjeta
                Dim TotalTarjeta As Decimal
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteTarjeta),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND FechaTicket='" & FechaCierre & "'"
                TotalTarjeta = cmdTotales.ExecuteScalar

                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre='" & FechaCierre & "' AND (TipoMovimiento='CC' AND TipoCobro=1)"
                TotalTarjeta += cmdTotales.ExecuteScalar

                rSituacion.Tarjeta = TotalTarjeta

                'Total vales proveedor
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteValesProveedor),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND FechaTicket='" & FechaCierre & "'"
                rSituacion.ValesProveedor = cmdTotales.ExecuteScalar

                'Total envases
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteEnvases),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND FechaTicket='" & FechaCierre & "'"
                rSituacion.Envases = cmdTotales.ExecuteScalar

                'Total pendiente cobro
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImportePendienteCobro),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND FechaTicket='" & FechaCierre & "'"
                rSituacion.PendienteCobro = cmdTotales.ExecuteScalar

                'Total vales emitidos
                Dim TotalValesEmitidos As Decimal
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteValesEmitidos),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND FechaTicket='" & FechaCierre & "'"
                TotalValesEmitidos = cmdTotales.ExecuteScalar

                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre='" & FechaCierre & "' AND TipoMovimiento='EV'"
                TotalValesEmitidos += cmdTotales.ExecuteScalar

                rSituacion.ValesEmitidos = TotalValesEmitidos

                'Total vales cobrados
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteValesCobrados),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND FechaTicket='" & FechaCierre & "'"
                rSituacion.ValesCobrados = cmdTotales.ExecuteScalar

                'Total cobros a cliente
                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre='" & FechaCierre & "' AND TipoMovimiento='CC'"
                rSituacion.CobrosCliente = cmdTotales.ExecuteScalar

                'Total pagos proveedor
                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre='" & FechaCierre & "' AND TipoMovimiento='PC'"
                rSituacion.PagosProveedor = cmdTotales.ExecuteScalar

                'Número de albaranes de crédito
                cmdTotales.CommandText = "SELECT Count(Id) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND TipoFactura = 1 AND FechaTicket='" & FechaCierre & "'"
                rSituacion.NumeroAlbaranes = cmdTotales.ExecuteScalar

                'Total líneas albaranes
                cmdTotales.CommandText = "SELECT ISNULL(Count(HISTORICO_TiCKETS_LINEAS.Id),0) FROM HISTORICO_TICKETS INNER JOIN HISTORICO_TiCKETS_LINEAS ON HISTORICO_TICKETS.Id=HISTORICO_TICKETS_LINEAS.Ticket_Id " & _
                                         "WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND TipoFactura = 1 AND FechaTicket='" & FechaCierre & "'"
                rSituacion.LineasAlbaranes = cmdTotales.ExecuteScalar

                'Total albarán crédito
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteTotal),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND TipoFactura = 1 AND FechaTicket='" & FechaCierre & "'"
                rSituacion.AlbaranCredito = cmdTotales.ExecuteScalar

                'Número de facturas de crédito
                cmdTotales.CommandText = "SELECT Count(Id) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND (TipoFactura = 2 OR TipoFactura = 3) AND FechaTicket='" & FechaCierre & "'"
                rSituacion.NumeroFacturas = cmdTotales.ExecuteScalar

                'Total líneas facturas
                cmdTotales.CommandText = "SELECT ISNULL(Count(HISTORICO_TiCKETS_LINEAS.Id),0) FROM HISTORICO_TICKETS INNER JOIN HISTORICO_TiCKETS_LINEAS ON HISTORICO_TICKETS.Id=HISTORICO_TICKETS_LINEAS.Ticket_Id " & _
                                         "WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND (TipoFactura = 2 OR TipoFactura = 3) AND FechaTicket='" & FechaCierre & "'"
                rSituacion.LineasFacturas = cmdTotales.ExecuteScalar

                'Total facturas crédito
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteTotal),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND (TipoFactura = 2 OR TipoFactura = 3) AND FechaTicket='" & FechaCierre & "'"
                rSituacion.ImporteFacturas = cmdTotales.ExecuteScalar

                'Total pendiente cobro venta crédito
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImportePendienteCobro),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND TipoFactura <> 0 AND FechaTicket='" & FechaCierre & "'"
                rSituacion.PendienteCredito = cmdTotales.ExecuteScalar

                'Total entrada cambios
                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre='" & FechaCierre & "' AND TipoMovimiento='EC'"
                rSituacion.EntradaCambios = cmdTotales.ExecuteScalar

                'Total retirada fondos
                cmdTotales.CommandText = "SELECT ISNULL(Sum(Importe),0) FROM Movimientos_Caja WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND FechaCierre='" & FechaCierre & "' AND TipoMovimiento='RF'"
                rSituacion.RetiradaFondos = cmdTotales.ExecuteScalar

                'Total descuentos
                cmdTotales.CommandText = "SELECT ISNULL(Sum(Round(HISTORICO_TICKETS_LINEAS.Cantidad * HISTORICO_TICKETS_LINEAS.Precio * HISTORICO_TICKETS_LINEAS.DescuentoLinea / 100, 2)),0) " & _
                                         "FROM HISTORICO_TICKETS INNER JOIN HISTORICO_TICKETS_LINEAS ON HISTORICO_TICKETS.Id = HISTORICO_TICKETS_LINEAS.Ticket_Id " & _
                                         "WHERE HISTORICO_TICKETS.CodigoTienda=" & CodigoTienda & " AND HISTORICO_TICKETS.CodigoCaja=" & dr("CodigoCaja") & " AND HISTORICO_TICKETS.FechaTicket='" & FechaCierre & "'"
                rSituacion.Descuentos = cmdTotales.ExecuteScalar

                'Total reparto a domicilio
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteTotal),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND RepartoDomicilio=1 AND FechaTicket='" & FechaCierre & "'"
                rSituacion.RepartoDomicilio = cmdTotales.ExecuteScalar

                'Total vales cliente canjeados
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ValesCanjeados),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & _
                                         " AND RepartoDomicilio=1 AND FechaTicket='" & FechaCierre & "'"
                rSituacion.ValesClienteCanjeados = cmdTotales.ExecuteScalar

                'Total venta
                cmdTotales.CommandText = "SELECT ISNULL(Sum(ImporteTotal),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND FechaTicket='" & FechaCierre & "'"
                rSituacion.Venta = cmdTotales.ExecuteScalar

                'Total descuentos PP
                cmdTotales.CommandText = "SELECT ISNULL(Sum(TotalDtoPP),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND FechaTicket='" & FechaCierre & "'"
                rSituacion.DescuentoPP = cmdTotales.ExecuteScalar

                'Total recargos
                cmdTotales.CommandText = "SELECT ISNULL(Sum(TotalRecargo),0) FROM HISTORICO_TICKETS WHERE CodigoTienda=" & CodigoTienda & " AND CodigoCaja=" & dr("CodigoCaja") & " AND FechaTicket='" & FechaCierre & "'"
                rSituacion.RecargoEquivalencia = cmdTotales.ExecuteScalar

                dsTiendas.SITUACION.AddSITUACIONRow(rSituacion)

            End While

            dr.Close()

            Return dsTiendas

        Catch ex As Exception
            MsgBox("Error al calcular totales de las cajas", MsgBoxStyle.Exclamation)
            Return Nothing
        Finally
            cmd.Connection.Close()
        End Try
    End Function
#End Region

#Region "CompruebaCadenaConexion"
    Public Sub CompruebaCadenaConexion(ByVal CadenaConexion As String)

        Try
            If CadenaConexion = String.Empty Then

                'Obtener valores de la versión anterior
                My.Settings.Upgrade()
                CadenaConexion = My.Settings.CadenaConexion

            End If

            If CadenaConexion = String.Empty Or CadenaConexion = "Nueva" Then

                'Cadena de conexión por defecto
                CadenaConexion = "Data Source=.\SQLExpress;AttachDbFilename=" & Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Datos\AydaraTPV.mdf;Integrated Security=True;User Instance=True;Connect Timeout=120"

                Dim fNuevaTienda As New NuevaTienda(CadenaConexion)
                fNuevaTienda.ShowDialog()

            End If

            My.Settings.CadenaConexion = CadenaConexion
            My.Settings.Item("AydaraTPVConnectionString") = My.Settings.CadenaConexion
            My.Settings.Save()

            General.EncriptarConfiguracion()

            General.ComprobarVersion()

        Catch ex As Exception
            MsgBox("Error al comprobar fichero de configuración." & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
#End Region

#Region "CopiaSeguridad"
    Public Sub CopiaSeguridad()

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.CommandTimeout = 600000

        Try
            cmd.Connection.Open()

            Dim BuscaCarpeta As New FolderBrowserDialog

            BuscaCarpeta.ShowDialog()

            Dim Directorio As String = BuscaCarpeta.SelectedPath

            If Directorio <> String.Empty Then

                cmd.CommandText = "BACKUP DATABASE [" & cmd.Connection.Database & "]" & _
                                  " TO DISK = N'" & Directorio & "\AydaraTPV " & Format(Date.Now, "dd-MM-yyyy HH-mm") & ".bak'"

                cmd.ExecuteNonQuery()

                MsgBox("Copia de seguridad realizada correctamente", MsgBoxStyle.Information)

            End If

        Catch ex As Exception
            MsgBox("Error al crear la copia de seguridad" & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Sub
#End Region

#Region "ComprobarVersionBD"
    Public Sub ComprobarVersion()

        Dim VersionBD As Integer
        Dim cmd As New SqlClient.SqlCommand
        Dim i As Integer

        Dim conexion As New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        Dim transaccion As SqlClient.SqlTransaction = Nothing

        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error al actualizar versión")
            Exit Sub
        End Try

        Try
            transaccion = conexion.BeginTransaction()

            cmd.Connection = conexion
            cmd.Transaction = transaccion

            cmd.CommandText = "select count(*) FROM INFORMATION_SCHEMA.COLUMNS AS c1 where c1.column_name = 'VersionBD' and c1.table_name='TIENDAS'"
            If cmd.ExecuteScalar = 0 Then
                cmd.CommandText = "ALTER TABLE TIENDAS ADD VersionBD int"
                cmd.ExecuteNonQuery()
            End If

            cmd.CommandText = "SELECT ISNULL(VersionBD,0) FROM TIENDAS"
            VersionBD = cmd.ExecuteScalar

            Dim ResourceScripts As Resources.ResourceManager = My.Resources.ScriptsBD.ResourceManager

            If My.Application.Info.Version.Revision > VersionBD Then

                For i = VersionBD + 1 To My.Application.Info.Version.Revision
                    Dim obj As Object = ResourceScripts.GetObject("sql_" & i)
                    Dim sql() As String = Split(obj.ToString, vbCrLf & "GO")
                    For j As Integer = 0 To sql.Length - 1
                        cmd.CommandText = sql(j)
                        cmd.ExecuteNonQuery()
                    Next
                Next

                cmd.CommandText = "UPDATE TIENDAS SET VersionBD = " & My.Application.Info.Version.Revision
                cmd.ExecuteNonQuery()

                transaccion.Commit()

            End If

        Catch ex As Exception
            transaccion.Rollback()
            MsgBox("Error al actualizar la versión de la base de datos." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error al actualizar versión")
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try
    End Sub
#End Region

#Region "ComprobarVersionApp"
    Public Sub ComprobarVersionApp()
        Try
            If Comunicacion.DescargaFicheros("Version.seq", True) Then
                Dim FicheroVersion As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Version.seq"
                If IO.File.Exists(FicheroVersion) Then
                    Dim sr As New System.IO.StreamReader(FicheroVersion, System.Text.Encoding.Default, True)
                    Dim VersionApp As String = String.Empty
                    Try
                        VersionApp = sr.ReadLine
                        sr.Close()
                    Catch ex As Exception
                        'Error al leer el fichero
                    Finally
                        IO.File.Delete(FicheroVersion)
                    End Try

                    If VersionApp <> String.Empty Then
                        Dim Version As New System.Version(VersionApp)
                        If My.Application.Info.Version.CompareTo(Version) < 0 Then
                            MsgBox("Existe una nueva actualización disponible." & vbCrLf & "A continuación se procederá a la descarga del fichero." & vbCrLf & "Instale la actualización y acceda de nuevo a la aplicación.", MsgBoxStyle.Information)
                            If Ftp.ActualizaAplicacion(General.Comunicaciones_Direccion, General.Comunicaciones_Usuario, General.Comunicaciones_Password) Then
                                Application.Exit()
                                Exit Sub
                            End If
                        End If
                    End If

                End If
            End If
        Catch ex As Exception
            'Error al comprobar actualización
        End Try
    End Sub
#End Region

#Region "AvisoPantalla"
    Public Function AvisoPantalla(ByVal Pantalla As Form, ByVal Texto As String, ByVal Alto As Integer, ByVal Ancho As Integer) As DevExpress.XtraEditors.LabelControl

        Dim Aviso As New DevExpress.XtraEditors.LabelControl, Formato As New Font("Tahoma", 28, FontStyle.Bold)

        Try
            Pantalla.Enabled = False

            Aviso.Height = Alto : Aviso.Width = Ancho
            Aviso.Top = TPV_Tactil.Height / 2 - Aviso.Height / 2 : Aviso.Left = TPV_Tactil.Width / 2 - Aviso.Width / 2

            Aviso.Text = Texto
            Aviso.Font = Formato
            Aviso.ForeColor = Color.DarkRed
            Aviso.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Aviso.Appearance.TextOptions.VAlignment = DevExpress.Utils.HorzAlignment.Center
            Aviso.BorderStyle = BorderStyle.Fixed3D
            Aviso.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None

            Pantalla.Controls.Add(Aviso)
            Aviso.BringToFront()

            Pantalla.Refresh()

        Finally
        End Try

        Return Aviso

    End Function
#End Region

#Region "EncriptarConfiguracion"
    Private Sub EncriptarConfiguracion()
        Try
            'Encriptar fichero de configuración de la aplicación (app.config)
            Dim config As System.Configuration.Configuration = System.Configuration.ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
            config.ConnectionStrings.SectionInformation.ProtectSection(Nothing)
            config.ConnectionStrings.SectionInformation.ForceSave = True
            If config.SectionGroups("userSettings").Sections.Count > 0 Then
                config.SectionGroups("userSettings").Sections(0).SectionInformation.ProtectSection(Nothing)
                config.SectionGroups("userSettings").Sections(0).SectionInformation.ForceSave = True
            End If
            config.Save()

            'Encriptar fichero de configuración del usuario (user.config)
            config = System.Configuration.ConfigurationManager.OpenExeConfiguration(System.Configuration.ConfigurationUserLevel.PerUserRoamingAndLocal)
            If config.SectionGroups("userSettings").Sections.Count > 0 Then
                config.SectionGroups("userSettings").Sections(0).SectionInformation.ProtectSection(Nothing)
                config.SectionGroups("userSettings").Sections(0).SectionInformation.ForceSave = True
            End If

            config.Save()

        Catch ex As Exception
            'Error al encriptar
        End Try
    End Sub
#End Region

#Region "ConvertToByteArray"
    Public Function ConvertToByteArray(ByVal value As Bitmap) As Byte()

        Dim bitmapBytes As Byte()

        Using stream As New System.IO.MemoryStream

            value.Save(stream, value.RawFormat)
            bitmapBytes = stream.ToArray

        End Using

        Return bitmapBytes

    End Function
#End Region

#Region "RedimensionarImagenes"
    Public Function RedimensionarImagenes()

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Dim dtFamiliasArticulos As New dsArticulos.FAMILIASARTICULOSDataTable
        Dim taFamiliasArticulos As New dsArticulosTableAdapters.FAMILIASARTICULOSTableAdapter

        Dim dtArticulos As New dsArticulos.ARTICULOSDataTable
        Dim taArticulos As New dsArticulosTableAdapters.ARTICULOSTableAdapter

        Dim i As Integer

        Try
            cmd.Connection.Open()

            cmd.CommandText = "SELECT * FROM FAMILIASARTICULOS WHERE NOT Imagen IS NULL"

            dtFamiliasArticulos.Load(cmd.ExecuteReader)

            For i = 0 To dtFamiliasArticulos.Count - 1
                Dim resized As Image = ResizeImage(New Bitmap(New IO.MemoryStream(dtFamiliasArticulos(i).Imagen)), 80, 70)
                Dim memStream As IO.MemoryStream = New IO.MemoryStream()
                resized.Save(memStream, System.Drawing.Imaging.ImageFormat.Png)
                dtFamiliasArticulos(i).Imagen = memStream.ToArray
            Next

            taFamiliasArticulos.Update(dtFamiliasArticulos)

            cmd.CommandText = "SELECT * FROM ARTICULOS WHERE NOT Imagen IS NULL"

            dtArticulos.Load(cmd.ExecuteReader)

            For i = 0 To dtArticulos.Count - 1
                Dim resized As Image = ResizeImage(New Bitmap(New IO.MemoryStream(dtArticulos(i).Imagen)), 80, 70)
                Dim memStream As IO.MemoryStream = New IO.MemoryStream()
                resized.Save(memStream, System.Drawing.Imaging.ImageFormat.Png)
                dtArticulos(i).Imagen = memStream.ToArray
            Next

            taArticulos.Update(dtArticulos)

            Return True

        Catch ex As Exception
            Return False
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Function

    Public Function ResizeImage(ByVal SourceImage As Drawing.Image, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32) As Drawing.Bitmap

        Dim bmSource = New Drawing.Bitmap(SourceImage)
        Return ResizeImage(bmSource, TargetWidth, TargetHeight)

    End Function

    Public Function ResizeImage(ByVal bmSource As Drawing.Bitmap, ByVal TargetWidth As Int32, ByVal TargetHeight As Int32) As Drawing.Bitmap
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio = bmSource.Width / bmSource.Height
        Dim nDestAspectRatio = bmDest.Width / bmDest.Height

        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = bmDest.Width
        Dim NewHeight = CInt(bmSource.Height * bmDest.Width / bmSource.Width) 'bmDest.Height

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If

        Using grDest = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                .PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighQuality
                .SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
                .CompositingMode = Drawing.Drawing2D.CompositingMode.SourceOver

                .DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight)
            End With
        End Using

        Return bmDest
    End Function

#End Region

#Region "ReiniciarComunicacionBascula"
    Public Sub ReiniciarComunicacionBascula()
        If IO.Directory.Exists(My.Settings.DirectorioBascula) Then
            Dim sr As New IO.StreamWriter(My.Settings.DirectorioBascula & "\CTRL.TXT")
            Try
                sr.Write("R")
                sr.WriteLine()
            Catch ex As Exception
                Throw ex
            Finally
                sr.Close()
            End Try
        End If
    End Sub
#End Region

End Module
