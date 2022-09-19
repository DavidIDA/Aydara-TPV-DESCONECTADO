Partial Public Class dsTPVRecepcion

    Dim FTP As New Ftp()

    Public DirectorioFicheros As String = Aydara.SentenciaSQL("SELECT DIRECTORIO FROM IDA_AYDARATPV")

    Dim LOG As New dsTPVLog
    Dim ConfigTPV As dsTPVConfiguracion.IDA_AYDARATPVRow

    Public ModoActualizacion As TipoActualizacion = TipoActualizacion.Manual

    Enum TipoActualizacion
        Automatico
        Manual
    End Enum

#Region "Recepcionar"
    Public Sub Recepcionar()
        Try
            'Comprobar directorio de ficheros
            If Me.DirectorioFicheros = String.Empty Then
                MsgBox("Seleccione un directorio para los ficheros en la configuración")
                Exit Try
            Else
                Me.DirectorioFicheros &= "\Recibo"
                If Not IO.Directory.Exists(Me.DirectorioFicheros) Then
                    IO.Directory.CreateDirectory(Me.DirectorioFicheros)
                End If
                If Not IO.Directory.Exists(Me.DirectorioFicheros & "\Backup") Then
                    IO.Directory.CreateDirectory(Me.DirectorioFicheros & "\Backup")
                End If
            End If

            FTP.DameFicheros(Me.DirectorioFicheros, True)

        Catch ex As Exception
            LOG.Nuevo("X", "Error al recibir ficheros. " & ex.Message)
            Throw ex
        Finally
            Aydara.Estado()
            'DevExpress.XtraEditors.XtraMessageBox.Show("Recepción de ficheros completado", "Recepción tiendas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
#End Region

#Region "LeerFicheros"
    Public Sub LeerFicheros()
        Try
            Aydara.Estado("Comprobando directorio", "Leyendo ficheros")

            Me.RECEPCION.Clear()

            'Configuración TPV
            Dim dsConfigTPV As New dsTPVConfiguracion
            dsConfigTPV.Cargar()
            If dsConfigTPV.IDA_AYDARATPV.Count > 0 Then
                Me.ConfigTPV = dsConfigTPV.IDA_AYDARATPV(0)
            Else
                MsgBox("Indique los datos de configuración del TPV", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            'Comprobar directorio de ficheros
            If Me.DirectorioFicheros = String.Empty Then
                MsgBox("Seleccione un directorio para los ficheros en la configuración", MsgBoxStyle.Exclamation)
                Exit Try
            Else
                'Me.DirectorioFicheros &= "\Recibo"
                If Not IO.Directory.Exists(Me.DirectorioFicheros) Then
                    IO.Directory.CreateDirectory(Me.DirectorioFicheros)
                End If
            End If

            Dim rFichero As dsTPVRecepcion.RECEPCIONRow
            Dim folder As New IO.DirectoryInfo(Me.DirectorioFicheros)

            Dim dsTiendas As New dsTiendas
            Dim Linea As String

            For Each file As IO.FileInfo In folder.GetFiles()

                rFichero = Me.RECEPCION.NewRECEPCIONRow

                With rFichero

                    Select Case UCase(Mid(file.Name, 1, 4))
                        Case "TIEN"
                            .TIPO = "V"
                            .CODALM = String.Format("{0,8}", CInt(Mid(file.Name, 5, 2)))
                            .DESCRIPCION = "Ventas día " & Mid(file.Name, 7, 2)
                            If Me.ModoActualizacion = dsTPVRecepcion.TipoActualizacion.Automatico Then .IMPORTAR = True
                        Case "FINV"
                            .TIPO = "I"
                            .CODALM = String.Format("{0,8}", CInt(Mid(file.Name, 6, 2)))
                            .DESCRIPCION = "Inventario"
                        Case "TRAS"
                            .TIPO = "T"
                            .CODALM = String.Format("{0,8}", CInt(Mid(file.Name, 5, 2)))
                            .DESCRIPCION = "Traspaso"
                            If Me.ModoActualizacion = dsTPVRecepcion.TipoActualizacion.Automatico Then .IMPORTAR = True
                        Case "FPED"
                            .TIPO = "P"
                            .CODALM = String.Format("{0,8}", CInt(Mid(file.Name, 6, 2)))
                            .DESCRIPCION = "Pedido"
                            .PEDIDO_FECHA = Date.Today
                            .PEDIDO_FECHAVALOR = Date.Today
                            If Me.ModoActualizacion = dsTPVRecepcion.TipoActualizacion.Automatico Then .IMPORTAR = True
                        Case "FCLI"
                            .TIPO = "C"
                            .CODALM = String.Format("{0,8}", CInt(Mid(file.Name, 5, 2)))
                            .DESCRIPCION = "Clientes"
                        Case "FINC"
                            .TIPO = "IN"
                            .CODALM = String.Format("{0,8}", CInt(Mid(file.Name, 6, 2)))
                            .DESCRIPCION = "Incidencias"
                        Case Else
                            Continue For
                    End Select

                    dsTiendas.Cargar(.CODALM)

                    If dsTiendas.TIENDAS.Count = 0 Then Continue For

                    Dim Tienda As dsTiendas.TIENDASRow = dsTiendas.TIENDAS(0)

                    If .TIPO = "V" And Tienda.RECIBETICKETS = "F" Then Continue For
                    .FICHERO = file.Name
                    .TIPOTIENDA = Tienda.IDA_TIPOTIENDA
                    .DESCALM = Tienda.DESCALM
                    If .TIPO = "P" Then
                        .PEDIDO_DESGLOSE = False '(Tienda.DESGLOSEPEDIDO = "T")
                        If Tienda.PEDIDOMANUAL = "T" Then .IMPORTAR = False
                    End If

                End With

                Me.RECEPCION.AddRECEPCIONRow(rFichero)

            Next

            'Leer ficheros de ventas
            Dim ventas As DataRow() = Me.RECEPCION.Select("TIPO='V'", "")
            If ventas.Length > 0 Then

                For i As Integer = 0 To ventas.Length - 1

                    With CType(ventas(i), dsTPVRecepcion.RECEPCIONRow)

                        a3ERP.fWaitForm.SetCaption("Fichero " & .FICHERO)

                        Dim sr As New System.IO.StreamReader(Me.DirectorioFicheros & "\" & .FICHERO, System.Text.Encoding.Default, True)

                        Select Case UCase(Mid(.FICHERO, 1, 4))

                            Case "TIEN"

                                Dim NumTickets As Integer = 0, NumLineas As Integer = 0
                                Dim LineaVentas As Boolean = False

                                Try
                                    While Not sr.EndOfStream

                                        Linea = sr.ReadLine

                                        If UCase(Mid(Linea, 1, 6)) = "VENTAS" Then
                                            LineaVentas = True
                                            Continue While
                                        End If

                                        If UCase(Mid(Linea, 1, 5)) = "CAJAS" Then
                                            LineaVentas = False
                                            Continue While
                                        End If

                                        If LineaVentas Then
                                            If Mid(Linea, 11, 10) = "**********" Then
                                                'CABECERA TICKET
                                                NumTickets += 1
                                            Else
                                                'LÍNEAS TICKET
                                                NumLineas += 1
                                            End If
                                        End If

                                    End While

                                    .TOTALTICKETS = NumTickets
                                    .TOTALLINEAS = NumLineas

                                Catch ex As Exception
                                    'Throw ex
                                    .LOG = "Error en línea " & NumTickets + NumLineas + 1 & vbCrLf & ex.Message
                                    .ESTADO = 2
                                Finally
                                    sr.Close()
                                End Try

                        End Select

                    End With

                Next

            End If

            If Me.ModoActualizacion = TipoActualizacion.Automatico Then

                'Importar tickets
                Me.ImportarTickets()

                'Generar venta crédito
                Me.GeneraVentaCredito()

                'Generar traspasos
                Me.GenerarTraspasos()

                'Generar pedidos
                Me.GenerarPedidos()

            End If

            'MsgBox("Proceso de actualización finalizado", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox("Error al comprobar ficheros." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            Aydara.Estado()
        End Try

    End Sub

#End Region

#Region "Actualizar"
    Public Sub Actualizar()
        Try
            Me.ImportarClientes()
            Me.ImportarTickets()
            Me.GeneraVentaCredito()
            Me.GenerarTraspasos()
            Me.GenerarPedidos()
            Me.GenerarIncidencias()
            Me.LeerInventarios()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "ImportarClientes"
    Private Sub ImportarClientes()
        Try
            Dim clientes As DataRow() = Me.RECEPCION.Select("TIPO = 'C'", "")
            If clientes.Length > 0 Then

                Dim Tarjetas As New dsTarjetas
                Dim taTarjetas As New dsTarjetasTableAdapters.IDA_TARJETASTableAdapter
                Dim rTarjeta As dsTarjetas.IDA_TARJETASRow

                For i As Integer = 0 To clientes.Length - 1

                    With CType(clientes(i), dsTPVRecepcion.RECEPCIONRow)

                        Aydara.Estado("Importando fichero " & .FICHERO)

                        'Fichero
                        Dim sr As New System.IO.StreamReader(Me.DirectorioFicheros & "\" & .FICHERO, System.Text.Encoding.Default, True)

                        Try
                            taTarjetas.Fill(Tarjetas.IDA_TARJETAS)

                            While Not sr.EndOfStream

                                Dim Linea() = Split(sr.ReadLine, vbTab)

                                If Linea.Length > 0 Then

                                    Dim tarjeta As DataRow() = Tarjetas.IDA_TARJETAS.Select("NUMTARJETA = " & Linea(0))

                                    If tarjeta.Length > 0 Then
                                        rTarjeta = tarjeta(0)
                                    Else
                                        rTarjeta = Tarjetas.IDA_TARJETAS.NewIDA_TARJETASRow
                                    End If

                                    With rTarjeta
                                        .NUMTARJETA = Linea(0)
                                        .NOMCLI = Linea(1)
                                        .NIFCLI = Linea(2)
                                        .DIRCLI = Linea(3)
                                        .DTOCLI = Linea(4)
                                        .POBCLI = Linea(5)
                                        .POVCLI = Linea(6)
                                        .TELCLI = Linea(7)
                                        .TELCLI2 = Linea(8)
                                        .PUNTOSSALDO = Linea(9)
                                        .BLOQUEADO = IIf(Linea(10) = "S", "T", "F")
                                        .MATRICULA = Linea(11)
                                        .TIPOVEHICULO = Linea(12)
                                        .MARCA = Linea(13)
                                        .MODELO = Linea(14)
                                    End With

                                    If rTarjeta.RowState = DataRowState.Detached Then Tarjetas.IDA_TARJETAS.AddIDA_TARJETASRow(rTarjeta)

                                End If

                            End While

                            Tarjetas.Guardar()

                        Catch ex As Exception
                            LOG.Nuevo("X", "Error al importar clientes." & vbCrLf & ex.Message)
                        Finally
                            sr.Close()
                        End Try

                        Try
                            If IO.File.Exists(Me.DirectorioFicheros & "\" & .FICHERO) Then
                                IO.File.Copy(Me.DirectorioFicheros & "\" & .FICHERO, Me.DirectorioFicheros & "\BackUp\" & .FICHERO, True)
                                IO.File.Delete(Me.DirectorioFicheros & "\" & .FICHERO)
                            End If

                        Catch ex As Exception
                            .LOG = "Clientes importados pero error al eliminar el fichero." & vbCrLf & ex.Message
                            .ESTADO = 3
                            LOG.Nuevo("X", "Clientes importados pero error al eliminar el fichero." & vbCrLf & ex.Message, .CODALM)
                        End Try

                    End With

                Next

            End If

        Catch ex As Exception
            LOG.Nuevo("X", "Error al intentar importar datos." & vbCrLf & ex.Message)
        Finally
            Aydara.Estado()
        End Try
    End Sub
#End Region

#Region "ImportarTickets"
    Private Sub ImportarTickets()
        Try
            Dim Linea As String
            Dim Fecha As Date

            'Importar ficheros de ventas
            Dim ventas As DataRow() = Me.RECEPCION.Select("TIPO = 'V' AND IMPORTAR = 1", "")
            If ventas.Length > 0 Then

                Dim Tickets As New dsTickets
                Dim taCajas As New dsTicketsTableAdapters.IDA_CAJASTableAdapter
                Dim taTickets As New dsTicketsTableAdapters.IDA_TICKETSTableAdapter
                Dim taTicketsLineas As New dsTicketsTableAdapters.IDA_TICKETSLINEASTableAdapter
                Dim rCaja As dsTickets.IDA_CAJASRow
                Dim rTicket As dsTickets.IDA_TICKETSRow = Nothing
                Dim rLineaTicket As dsTickets.IDA_TICKETSLINEASRow

                Dim dsTicketsExistentes As New dsTickets

                For i As Integer = 0 To ventas.Length - 1

                    With CType(ventas(i), dsTPVRecepcion.RECEPCIONRow)

                        Aydara.Estado("Importando fichero " & .FICHERO)

                        'Datos tienda
                        Dim dsTiendas As New dsTiendas
                        dsTiendas.Cargar(.CODALM)
                        If dsTiendas.TIENDAS.Count = 0 Then Continue For
                        Dim Tienda As dsTiendas.TIENDASRow = dsTiendas.TIENDAS(0)

                        'Fichero
                        Dim sr As New System.IO.StreamReader(Me.DirectorioFicheros & "\" & .FICHERO, System.Text.Encoding.Default, True)

                        Select Case UCase(Mid(.FICHERO, 1, 4))

                            Case "TIEN"

                                Dim NumTickets As Integer = 0, NumLineas As Integer = 0
                                Dim LineaVentas As Boolean = False, FechaCierreCajas As Date = Nothing

                                Try
                                    While Not sr.EndOfStream

                                        Linea = sr.ReadLine

                                        If UCase(Mid(Linea, 1, 6)) = "VENTAS" Then

                                            If IsDate(Mid(Linea, 7)) Then
                                                Fecha = Mid(Linea, 7)
                                                LineaVentas = True
                                            End If

                                            'Leer tickets existentes
                                            Dim taTicketsExistentes As New dsTicketsTableAdapters.IDA_TICKETSTableAdapter
                                            taTicketsExistentes.daTickets.SelectCommand.CommandText &= " WHERE CODALM = '" & .CODALM & "' AND FECCIERRE = '" & Fecha & "'"
                                            taTicketsExistentes.Fill(dsTicketsExistentes.IDA_TICKETS)

                                            Continue While

                                        End If

                                        If UCase(Mid(Linea, 1, 5)) = "CAJAS" Then
                                            If IsDate(Mid(Linea, 6)) Then
                                                FechaCierreCajas = Mid(Linea, 6)
                                                LineaVentas = False
                                            End If
                                            Continue While
                                        End If

                                        If Not LineaVentas Then

                                            'Totales de caja
                                            rCaja = Tickets.IDA_CAJAS.NewIDA_CAJASRow
                                            With rCaja
                                                .FECHA = FechaCierreCajas
                                                If IsNumeric(Mid(Linea, 1, 2)) Then .CODALM = String.Format("{0,8}", CInt(Mid(Linea, 1, 2)))
                                                If IsNumeric(Mid(Linea, 3, 2)) Then .CAJA = CInt(Mid(Linea, 3, 2))
                                                If IsNumeric(Mid(Linea, 5, 10)) Then .TICKETS = CInt(Mid(Linea, 5, 10)) / 100
                                                If IsNumeric(Mid(Linea, 15, 10)) Then .LINEAS = CInt(Mid(Linea, 15, 10)) / 100
                                                If IsNumeric(Mid(Linea, 25, 10)) Then .EFECTIVO = CDec(Mid(Linea, 25, 10)) / 100
                                                If IsNumeric(Mid(Linea, 35, 10)) Then .TALON = CDec(Mid(Linea, 35, 10)) / 100
                                                If IsNumeric(Mid(Linea, 45, 10)) Then .NUMALBARANES = CDec(Mid(Linea, 45, 10)) / 100
                                                If IsNumeric(Mid(Linea, 55, 10)) Then .TARJETA = CDec(Mid(Linea, 55, 10)) / 100
                                                If IsNumeric(Mid(Linea, 65, 10)) Then .VALESCOBRADOS = CDec(Mid(Linea, 65, 10)) / 100
                                                If IsNumeric(Mid(Linea, 75, 10)) Then .VALESPROVEEDOR = CDec(Mid(Linea, 75, 10)) / 100
                                                If IsNumeric(Mid(Linea, 85, 10)) Then .ENVASES = CDec(Mid(Linea, 85, 10)) / 100
                                                If IsNumeric(Mid(Linea, 95, 10)) Then .VENTA = CDec(Mid(Linea, 95, 10)) / 100
                                                If IsNumeric(Mid(Linea, 105, 10)) Then .COBROSCLIENTE = CDec(Mid(Linea, 105, 10)) / 100
                                                If IsNumeric(Mid(Linea, 115, 10)) Then .PAGOSPROVEEDOR = CDec(Mid(Linea, 115, 10)) / 100
                                                If IsNumeric(Mid(Linea, 125, 10)) Then .ENTRADACAMBIOS = CDec(Mid(Linea, 125, 10)) / 100
                                                If IsNumeric(Mid(Linea, 135, 10)) Then .RETIRADAFONDOS = CDec(Mid(Linea, 135, 10)) / 100
                                                If IsNumeric(Mid(Linea, 145, 10)) Then .NUMFACTURAS = CDec(Mid(Linea, 145, 10)) / 100
                                                If IsNumeric(Mid(Linea, 155, 10)) Then .PENDIENTECOBRO = CDec(Mid(Linea, 155, 10)) / 100
                                                If IsNumeric(Mid(Linea, 165, 10)) Then .PENDIENTECOBROCREDITO = CDec(Mid(Linea, 165, 10)) / 100
                                                If IsNumeric(Mid(Linea, 175, 10)) Then .VALESCANJEADOS = CDec(Mid(Linea, 175, 10)) / 100
                                                If IsNumeric(Mid(Linea, 185, 10)) Then .REPARTODOMICILIO = CDec(Mid(Linea, 185, 10)) / 100
                                                If IsNumeric(Mid(Linea, 195, 10)) Then .VALESEMITIDOS = CDec(Mid(Linea, 195, 10)) / 100
                                                If IsNumeric(Mid(Linea, 205, 10)) Then .TOTALBARANES = CDec(Mid(Linea, 205, 10)) / 100
                                                If IsNumeric(Mid(Linea, 225, 10)) Then .TOTFACTURAS = CDec(Mid(Linea, 225, 10)) / 100
                                                If IsNumeric(Mid(Linea, 235, 10)) Then .TOTPRONTO = CDec(Mid(Linea, 235, 10)) / 100
                                                If IsNumeric(Mid(Linea, 245, 10)) Then .TOTREC = CDec(Mid(Linea, 245, 10)) / 100
                                            End With
                                            Tickets.IDA_CAJAS.AddIDA_CAJASRow(rCaja)

                                            'Eliminar totales de caja existentes
                                            Aydara.SentenciaSQL("DELETE FROM IDA_CAJAS WHERE CODALM = '" & rCaja.CODALM & "' AND FECHA = '" & rCaja.FECHA & "' AND CAJA = " & rCaja.CAJA & " AND TICKETS = " & rCaja.TICKETS & " AND LINEAS = " & rCaja.LINEAS)

                                            Continue While

                                        End If

                                        If Mid(Linea, 11, 10) = "**********" Then

                                            'CABECERA TICKET
                                            NumTickets += 1

                                            rTicket = Tickets.IDA_TICKETS.NewIDA_TICKETSRow
                                            With rTicket

                                                .FECCIERRE = Fecha
                                                If IsNumeric(Mid(Linea, 1, 2)) Then .CAJA = CInt(Mid(Linea, 1, 2))
                                                .NUMDOC = Mid(Linea, 3, 6)
                                                If IsNumeric(Mid(Linea, 9, 2)) Then .CODALM = String.Format("{0,8}", CInt(Mid(Linea, 9, 2)))
                                                If IsNumeric(Mid(Linea, 21, 5)) Then .FECHA = DateAdd(DateInterval.Day, CInt(Mid(Linea, 21, 5) - 1), CDate("01-01-1900")) & " " & Mid(Linea, 26, 5)
                                                .TIPOCOBRO = Mid(Linea, 31, 1)
                                                If IsNumeric(Mid(Linea, 32, 8)) Then .NUMTARJETA = CDbl(Mid(Linea, 32, 8))
                                                If IsNumeric(Mid(Linea, 40, 2)) Then .CODPER = String.Format("{0,8}", CInt(Mid(Linea, 40, 2)))
                                                .REPARTODOMICILIO = (Mid(Linea, 42, 1) = "*")
                                                .IMPRESO = (Mid(Linea, 44, 1) = "S")

                                                .CREDITO = (Mid(Linea, 52, 1) = "S")
                                                .TIPDOC = 0 'Tipo documento 0 (Ticket), si es venta crédito guardamos el tipo de documento
                                                If .CREDITO Then
                                                    If Tienda.ALBARANCREDITO = "F" Then
                                                        .CREDITO = False
                                                        .NUMTARJETA = 0
                                                    Else
                                                        If IsNumeric(Mid(Linea, 53, 2)) Then .TIPDOC = Mid(Linea, 53, 2) Else .TIPDOC = 1
                                                        If IsNumeric(Mid(Linea, 45, 6)) Then .NUMDOC = Mid(Linea, 45, 6)
                                                    End If
                                                End If

                                                If IsNumeric(Mid(Linea, 55, 10)) Then .NUMLINEAS = CInt(Mid(Linea, 55, 10)) / 100
                                                If IsNumeric(Mid(Linea, 65, 10)) Then .TOTDOC = CDec(Mid(Linea, 65, 10)) / 100
                                                If IsNumeric(Mid(Linea, 75, 10)) Then .TOTEFECTIVO = CDec(Mid(Linea, 75, 10)) / 100
                                                If IsNumeric(Mid(Linea, 85, 10)) Then .TOTTALON = CDec(Mid(Linea, 85, 10)) / 100
                                                If IsNumeric(Mid(Linea, 95, 10)) Then .TOTVALESPROVEEDOR = CDec(Mid(Linea, 95, 10)) / 100
                                                If IsNumeric(Mid(Linea, 105, 10)) Then .TOTVALESCOBRADOS = CDec(Mid(Linea, 105, 10)) / 100
                                                If IsNumeric(Mid(Linea, 115, 10)) Then .TOTTARJETA = CDec(Mid(Linea, 115, 10)) / 100
                                                If IsNumeric(Mid(Linea, 125, 10)) Then .TOTENVASES = CDec(Mid(Linea, 125, 10)) / 100
                                                If IsNumeric(Mid(Linea, 135, 10)) Then .TOTPENDIENTE = CDec(Mid(Linea, 135, 10)) / 100
                                                If IsNumeric(Mid(Linea, 145, 10)) Then .TOTVALESEMITIDOS = CDec(Mid(Linea, 145, 10)) / 100
                                                If IsNumeric(Mid(Linea, 155, 10)) Then .TOTENTREGA = CDec(Mid(Linea, 155, 10)) / 100
                                                If IsNumeric(Mid(Linea, 165, 10)) Then .TOTCAMBIOS = CDec(Mid(Linea, 165, 10)) / 100

                                                'Datos fidelización, puntos, vales...
                                                If IsNumeric(Mid(Linea, 175, 10)) Then .FIDELIZADTO = CDec(Mid(Linea, 175, 10)) / 100
                                                If IsNumeric(Mid(Linea, 185, 10)) Then .FIDELIZAVALES = CDec(Mid(Linea, 185, 10)) / 100
                                                If IsNumeric(Mid(Linea, 195, 10)) Then .FIDELIZAPUNTOS = CDec(Mid(Linea, 195, 10)) / 100
                                                If IsNumeric(Mid(Linea, 205, 10)) Then .FIDELIZALOTERIA = CDec(Mid(Linea, 205, 10)) / 100
                                                If IsNumeric(Mid(Linea, 215, 10)) Then .CANJEPUNTOS = CDec(Mid(Linea, 215, 10)) / 100
                                                If IsNumeric(Mid(Linea, 225, 10)) Then .CANJEVALES = CDec(Mid(Linea, 225, 10)) / 100

                                                'Datos venta crédito
                                                If IsNumeric(Mid(Linea, 235, 8)) Then .CODCLI = String.Format("{0,8}", CInt(Mid(Linea, 235, 8)))
                                                If IsNumeric(Mid(Linea, 243, 10)) Then .PORPRONTO = CDec(Mid(Linea, 243, 10)) / 100
                                                If IsNumeric(Mid(Linea, 253, 10)) Then .TOTPRONTO = CDec(Mid(Linea, 253, 10)) / 100
                                                If IsNumeric(Mid(Linea, 263, 10)) Then .TOTREC = CDec(Mid(Linea, 263, 10)) / 100

                                                'Km
                                                If IsNumeric(Mid(Linea, 273, 10)) Then .TOTPUNTOS = CDec(Mid(Linea, 273, 10)) / 100

                                                'Forma de pago
                                                .FORPAG = Mid(Linea, 283, 8)

                                            End With

                                            'Comprobar si existe ticket en el fichero y en la base de datos
                                            If Tickets.IDA_TICKETS.Select("CAJA = " & rTicket.CAJA & " AND TIPDOC = " & rTicket.TIPDOC & " AND NUMDOC = " & rTicket.NUMDOC).Length > 0 Or dsTicketsExistentes.IDA_TICKETS.Select("CAJA = " & rTicket.CAJA & " AND TIPDOC = " & rTicket.TIPDOC & " AND NUMDOC = " & rTicket.NUMDOC).Length > 0 Then
                                                rTicket = Nothing
                                                Continue While
                                            Else
                                                Tickets.IDA_TICKETS.AddIDA_TICKETSRow(rTicket)
                                            End If

                                        ElseIf Not rTicket Is Nothing Then

                                            'LÍNEAS TICKET
                                            NumLineas += 1

                                            rLineaTicket = Tickets.IDA_TICKETSLINEAS.NewIDA_TICKETSLINEASRow
                                            With rLineaTicket

                                                .IDTICKET = rTicket.IDTICKET
                                                If IsNumeric(Mid(Linea, 11, 3)) Then .NUMLINEA = CInt(Mid(Linea, 11, 3))
                                                .CODART = Mid(Linea, 14, 15)
                                                If IsNumeric(.CODART) Then .CODART = Format(.CODART, "{0,15}")
                                                .PROMO = (Mid(Linea, 29, 1) = "S")
                                                .PRCMANUAL = (Mid(Linea, 30, 1) = "S")
                                                If IsNumeric(Mid(Linea, 31, 2)) Then .CODPER = CInt(Mid(Linea, 31, 2))
                                                .DESCLIN = LTrim(Mid(Linea, 35, 24))
                                                If IsNumeric(Mid(Linea, 59, 10)) Then .CANTIDAD = CDec(Mid(Linea, 59, 10)) / 100
                                                If IsNumeric(Mid(Linea, 69, 10)) Then .PRECIO = CDec(Mid(Linea, 69, 10)) / 10000
                                                If IsNumeric(Mid(Linea, 79, 10)) Then .DESC = CDec(Mid(Linea, 79, 10)) / 100
                                                If IsNumeric(Mid(Linea, 89, 10)) Then .TOTLIN = CDec(Mid(Linea, 89, 10)) / 100
                                                If IsNumeric(Mid(Linea, 109, 10)) Then .PORFIDELIZACION = CDec(Mid(Linea, 109, 10)) / 100

                                                'Tipo IVA
                                                If IsNumeric(Mid(Linea, 119, 10)) Then
                                                    Select Case CDec(Mid(Linea, 119, 10)) / 100
                                                        Case 1
                                                            .TIPIVA = Me.ConfigTPV.TIPIVA1
                                                        Case 2
                                                            .TIPIVA = Me.ConfigTPV.TIPIVA2
                                                        Case 3
                                                            .TIPIVA = Me.ConfigTPV.TIPIVA3
                                                        Case Else
                                                            .TIPIVA = "EXE"
                                                    End Select
                                                End If

                                                'Comprobar peso
                                                If IsNumeric(Mid(Linea, 149, 10)) Then

                                                    .PESOBASCULA = Math.Round(CDec(Mid(Linea, 149, 10)) / 1000, 3, MidpointRounding.AwayFromZero)

                                                    If .PESOBASCULA <> 0 And .CANTIDAD = 1 Then
                                                        .CANTIDAD = .PESOBASCULA
                                                        .PRECIO = Math.Round(.PRECIO / .CANTIDAD, 3)
                                                    End If

                                                End If

                                                'Artículo directo
                                                .ARTICULODIRECTO = Aydara.SentenciaSQL("SELECT IDA_ARTICULODIRECTO FROM ARTICULO WHERE CODART = '" & .CODART & "'")
                                                If .ARTICULODIRECTO = String.Empty Then .ARTICULODIRECTO = "T"

                                            End With
                                            Tickets.IDA_TICKETSLINEAS.AddIDA_TICKETSLINEASRow(rLineaTicket)

                                        End If

                                    End While

                                    Try
                                        Tickets.Guardar()

                                        If .TOTALTICKETS = NumTickets And .TOTALLINEAS = NumLineas Then
                                            .LOG = "Fichero importado correctamente (" & NumTickets & " cabeceras y " & NumLineas & " líneas de tickets)."
                                            .ESTADO = 1
                                            LOG.Nuevo("A", "Fichero importado correctamente (" & NumTickets & " cabeceras y " & NumLineas & " líneas de tickets).", .CODALM)
                                        Else
                                            .LOG = "Fichero importado parcialmente (" & NumTickets & " cabeceras y " & NumLineas & " líneas de tickets)."
                                            .ESTADO = 3
                                            LOG.Nuevo("A", "Fichero importado parcialmente (" & NumTickets & " cabeceras y " & NumLineas & " líneas de tickets).", .CODALM)
                                        End If

                                    Catch ex As Exception
                                        .LOG = "Error al guardar tickets en base de datos." & vbCrLf & ex.Message
                                        .ESTADO = 2
                                        LOG.Nuevo("X", "Error al guardar tickets en base de datos." & vbCrLf & ex.Message, .CODALM)
                                    End Try

                                Catch ex As Exception
                                    'Throw ex
                                    .LOG = "Error en línea " & NumTickets + NumLineas + 1 & vbCrLf & ex.Message
                                    .ESTADO = 2
                                    LOG.Nuevo("X", "Error en línea " & NumTickets + NumLineas + 1 & vbCrLf & ex.Message, .CODALM)
                                Finally
                                    sr.Close()
                                End Try

                                If .ESTADO <> 2 Then
                                    Try
                                        If IO.File.Exists(Me.DirectorioFicheros & "\" & .FICHERO) Then
                                            IO.File.Copy(Me.DirectorioFicheros & "\" & .FICHERO, Me.DirectorioFicheros & "\BackUp\" & .FICHERO, True)
                                            IO.File.Delete(Me.DirectorioFicheros & "\" & .FICHERO)
                                        End If
                                    Catch ex As Exception
                                        .LOG = "Tickets importados pero error al eliminar el fichero." & vbCrLf & ex.Message
                                        .ESTADO = 3
                                        LOG.Nuevo("X", "Tickets importados pero error al eliminar el fichero." & vbCrLf & ex.Message, .CODALM)
                                    End Try
                                End If

                        End Select

                        'Generar venta crédito
                        Me.GeneraVentaCredito()

                        'Generar albaranes/facturas pendientes
                        Dim Facturacion As New dsFacturacion

                        Try
                            Facturacion.BuscarTickets(String.Empty)
                            Facturacion.GenerarFacturaContado("CODALM = '" & .CODALM & "'")

                        Catch ex As Exception
                            LOG.Nuevo("X", "Error al generar albarán/factura de venta." & vbCrLf & ex.Message)
                        End Try


                    End With

                Next

            End If

        Catch ex As Exception
            LOG.Nuevo("X", "Error al intentar importar datos." & vbCrLf & ex.Message)
        Finally
            Me.IDA_TICKETSLINEAS.Clear()
            Me.IDA_TICKETS.Clear()
            Me.IDA_CAJAS.Clear()
            Aydara.Estado()
        End Try
    End Sub
#End Region

#Region "LeerTraspasos"
    Private Sub LeerTraspasos()
        Try
            Me.CABETRAS.Clear()
            Me.LINETRAS.Clear()

            Dim traspasos As DataRow() = Me.RECEPCION.Select("TIPO='T' AND IMPORTAR=1", "")
            If traspasos.Length > 0 Then

                Dim rCabetras As dsTPVRecepcion.CABETRASRow
                Dim rLinetras As dsTPVRecepcion.LINETRASRow
                Dim NUMLIN As Integer = 0
                Dim Linea As String

                For i As Integer = 0 To traspasos.Length - 1

                    With CType(traspasos(i), dsTPVRecepcion.RECEPCIONRow)

                        Dim sr As New System.IO.StreamReader(Me.DirectorioFicheros & "\" & .FICHERO, System.Text.Encoding.Default, True)

                        Try
                            While Not sr.EndOfStream

                                Linea = sr.ReadLine

                                If UCase(Mid(Linea, 1, 6)) = "TRASPA" Then

                                    'Nuevo traspaso
                                    NUMLIN += 1

                                    rCabetras = Me.CABETRAS.NewCABETRASRow
                                    With rCabetras
                                        .NUMLIN = NUMLIN
                                        .FICHERO = CType(traspasos(i), dsTPVRecepcion.RECEPCIONRow).FICHERO
                                        .CODALMSAL = CType(traspasos(i), dsTPVRecepcion.RECEPCIONRow).CODALM
                                        .CODALMENT = Aydara.EliminarCeros(Mid(Linea, 7, 2))
                                        .FECHA = Mid(Linea, 15)
                                    End With
                                    Me.CABETRAS.AddCABETRASRow(rCabetras)

                                Else

                                    'Nueva línea de traspaso
                                    rLinetras = Me.LINETRAS.NewLINETRASRow
                                    With rLinetras
                                        .NUMLIN = NUMLIN
                                        .UNIDADES = CInt(Aydara.EliminarCeros(Mid(Linea, 16))) / 100
                                        .CODART = Mid(Linea, 1, 15)
                                    End With
                                    If rLinetras.UNIDADES <> 0 Then Me.LINETRAS.AddLINETRASRow(rLinetras)

                                End If

                            End While

                        Catch ex As Exception
                            'Throw ex
                            .LOG = "Error al importar traspasos." & vbCrLf & ex.Message
                            .ESTADO = 2
                        Finally
                            sr.Close()
                        End Try

                    End With

                Next

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "LeerPedidos"
    Private Sub LeerPedidos()
        Try
            Me.CABEPEDV.Clear()
            Me.LINEPEDI.Clear()

            Dim pedidos As DataRow() = Me.RECEPCION.Select("TIPO = 'P' AND IMPORTAR = 1", "")
            If pedidos.Length > 0 Then

                Dim rCabePedv As dsTPVRecepcion.CABEPEDVRow
                Dim rLinePedi As dsTPVRecepcion.LINEPEDIRow
                Dim NUMLIN As Integer = 0
                Dim Linea As String

                For i As Integer = 0 To pedidos.Length - 1

                    With CType(pedidos(i), dsTPVRecepcion.RECEPCIONRow)

                        Dim sr As New System.IO.StreamReader(Me.DirectorioFicheros & "\" & .FICHERO, System.Text.Encoding.Default, True)

                        Try
                            'Nuevo pedido
                            NUMLIN += 1

                            rCabePedv = Me.CABEPEDV.NewCABEPEDVRow
                            With rCabePedv
                                .NUMLIN = NUMLIN
                                .FICHERO = CType(pedidos(i), dsTPVRecepcion.RECEPCIONRow).FICHERO
                                .CODALM = CType(pedidos(i), dsTPVRecepcion.RECEPCIONRow).CODALM
                                .FECHA = CType(pedidos(i), dsTPVRecepcion.RECEPCIONRow).PEDIDO_FECHA
                                .FECHAVALOR = CType(pedidos(i), dsTPVRecepcion.RECEPCIONRow).PEDIDO_FECHAVALOR
                                .TIPOTIENDA = CType(pedidos(i), dsTPVRecepcion.RECEPCIONRow).TIPOTIENDA
                                .DESGLOSE = CType(pedidos(i), dsTPVRecepcion.RECEPCIONRow).PEDIDO_DESGLOSE
                            End With
                            Me.CABEPEDV.AddCABEPEDVRow(rCabePedv)

                            While Not sr.EndOfStream

                                Linea = sr.ReadLine

                                If Linea = "PEDIDOS" Or UCase(Mid(Linea, 1, 2)) = "**" Then Continue While

                                'Nueva línea de pedido
                                rLinePedi = Me.LINEPEDI.NewLINEPEDIRow
                                With rLinePedi
                                    .NUMLIN = NUMLIN
                                    .CODART = Mid(Linea, 1, 15)
                                    .CAJAS = CInt(Aydara.EliminarCeros(Mid(Linea, 16, 10))) / 100
                                    .UNIDADES = CDbl(Aydara.EliminarCeros(Mid(Linea, 26, 10))) / 100
                                End With
                                If rLinePedi.CAJAS <> 0 Or rLinePedi.UNIDADES <> 0 Then Me.LINEPEDI.AddLINEPEDIRow(rLinePedi)

                            End While

                        Catch ex As Exception
                            'Throw ex
                            .LOG = "Error al importar pedidos." & vbCrLf & ex.Message
                            .ESTADO = 2
                        Finally
                            sr.Close()
                        End Try

                    End With

                Next

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "LeerInventarios"
    Private Sub LeerInventarios()
        Try
            Dim inventarios As DataRow() = Me.RECEPCION.Select("TIPO = 'I' AND IMPORTAR = 1", "")
            If inventarios.Length > 0 Then

                Aydara.Estado("Leyendo ficheros", "Importando inventario")

                Dim Linea As String
                Dim Inventario As New dsInventarios

                For i As Integer = 0 To inventarios.Length - 1

                    With CType(inventarios(i), dsTPVRecepcion.RECEPCIONRow)

                        Dim sr As New System.IO.StreamReader(Me.DirectorioFicheros & "\" & .FICHERO, System.Text.Encoding.Default, True)

                        Try
                            'Cargar inventario actual del almacén
                            Inventario.Cargar(.CODALM)

                            While Not sr.EndOfStream

                                Linea = sr.ReadLine

                                'Nuevo inventario
                                Inventario.Nuevo(.CODALM, Mid(Linea, 1, 15), 0, CInt(Aydara.EliminarCeros(Mid(Linea, 16, 10))) / 100)

                            End While

                            Inventario.Guardar()

                        Catch ex As Exception
                            'Throw ex
                            LOG.Nuevo("X", "Error al importar inventario." & vbCrLf & ex.Message, .CODALM)
                            .LOG = "Error al importar inventarios." & vbCrLf & ex.Message
                            .ESTADO = 2
                        Finally
                            sr.Close()
                        End Try

                        Try
                            If IO.File.Exists(Me.DirectorioFicheros & "\" & .FICHERO) Then
                                IO.File.Copy(Me.DirectorioFicheros & "\" & .FICHERO, Me.DirectorioFicheros & "\BackUp\" & .FICHERO, True)
                                IO.File.Delete(Me.DirectorioFicheros & "\" & .FICHERO)
                            End If
                        Catch ex As Exception
                            '.LOG = "Pedidos generados pero error al eliminar el fichero." & vbCrLf & ex.Message
                            LOG.Nuevo("X", "Inventarios generados pero error al eliminar el fichero." & vbCrLf & ex.Message, .CODALM)
                        End Try

                    End With

                Next

            End If

        Catch ex As Exception
            Throw ex
        Finally
            Aydara.Estado()
        End Try
    End Sub
#End Region

#Region "LeerIncidencias"
    Private Sub LeerIncidencias()
        Try
            Me.CABEREGU.Clear()
            Me.LINEREGU.Clear()

            Dim incidencias As DataRow() = Me.RECEPCION.Select("TIPO='IN' AND IMPORTAR=1", "")
            If incidencias.Length > 0 Then

                Dim rCabeRegu As dsTPVRecepcion.CABEREGURow
                Dim rLineregu As dsTPVRecepcion.LINEREGURow
                Dim Linea() As String, Fecha As Date, NumLin As Integer = 0

                For i As Integer = 0 To incidencias.Length - 1

                    With CType(incidencias(i), dsTPVRecepcion.RECEPCIONRow)

                        Dim sr As New System.IO.StreamReader(Me.DirectorioFicheros & "\" & .FICHERO, System.Text.Encoding.Default, True)

                        Try
                            While Not sr.EndOfStream

                                Linea = sr.ReadLine.Split(vbTab)

                                If Linea.Count = 0 Then Continue While
                                If Not IsDate(Linea(0)) Then Continue While

                                If Fecha.ToShortDateString <> CDate(Linea(0)).ToShortDateString Then

                                    NumLin += 1

                                    'Nueva regularización
                                    rCabeRegu = Me.CABEREGU.NewCABEREGURow
                                    With rCabeRegu
                                        .NUMLIN = NumLin
                                        .FICHERO = CType(incidencias(i), dsTPVRecepcion.RECEPCIONRow).FICHERO
                                        .CODALM = CType(incidencias(i), dsTPVRecepcion.RECEPCIONRow).CODALM
                                        .FECHA = Linea(0)
                                    End With
                                    Me.CABEREGU.AddCABEREGURow(rCabeRegu)

                                    Fecha = Linea(0)

                                End If

                                'Nueva línea
                                rLineregu = Me.LINEREGU.NewLINEREGURow
                                With rLineregu
                                    .NUMLIN = NumLin
                                    .TIPO = Linea(1)
                                    .OPERARIO = Linea(2)
                                    .CODART = Linea(3)
                                    .DESCLIN = Linea(4)
                                    .TEXTO = Linea(5)
                                    .UNIDADES = Linea(6)
                                    .PRCCOSTE = Linea(7)
                                End With
                                Me.LINEREGU.AddLINEREGURow(rLineregu)

                            End While

                        Catch ex As Exception
                            'Throw ex
                            .LOG = "Error al importar incidencias." & vbCrLf & ex.Message
                            .ESTADO = 2
                        Finally
                            sr.Close()
                        End Try

                    End With

                Next

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "GenerarTraspasos"
    Private Sub GenerarTraspasos()
        Try
            Aydara.Estado("Leyendo ficheros", "Generando traspasos")
            Me.LeerTraspasos()

            If Me.CABETRAS.Count > 0 Then

                Dim a3ERPTraspaso As New a3ERPActiveX.Traspaso
                Dim Lineas As DataRow()

                For i As Integer = 0 To Me.CABETRAS.Count - 1
                    With Me.CABETRAS(i)

                        Try
                            'Datos tienda
                            Dim dsTiendas As New dsTiendas
                            dsTiendas.Cargar(.CODALMSAL)
                            If dsTiendas.TIENDAS.Count = 0 Then Continue For
                            Dim Tienda As dsTiendas.TIENDASRow = dsTiendas.TIENDAS(0)

                            a3ERP.fWaitForm.SetCaption("Traspaso " & (i + 1) & " de " & Me.CABETRAS.Count)

                            a3ERPTraspaso.Iniciar()
                            a3ERPTraspaso.OmitirMensajes = True

                            'Unidades positivas
                            Lineas = Me.LINETRAS.Select("NUMLIN = " & .NUMLIN & " AND UNIDADES > 0")
                            If Lineas.Length > 0 Then

                                a3ERPTraspaso.Nuevo(.FECHA.ToShortDateString, .CODALMSAL, .CODALMENT)
                                If Not Tienda.IsTIPOCONTDESTINONull Then a3ERPTraspaso.AsStringCab("TIPOCONT") = Tienda.TIPOCONTDESTINO
                                If Not Tienda.IsSERIEDESTINONull Then a3ERPTraspaso.AsStringCab("SERIE") = Tienda.SERIEDESTINO

                                For lin As Integer = 0 To Lineas.Length - 1
                                    With DirectCast(Lineas(lin), dsTPVRecepcion.LINETRASRow)

                                        a3ERP.fWaitForm.SetCaption("Traspaso " & (i + 1) & " de " & Me.CABETRAS.Count & vbCrLf & "Línea " & (lin + 1) & " de " & Lineas.Length)

                                        Try
                                            a3ERPTraspaso.NuevaLineaArt(.CODART, .UNIDADES)
                                        Catch ex As Exception
                                            LOG.Nuevo("X", "Error al generar traspaso." & vbCrLf & ex.Message, a3ERPTraspaso.AsStringCab("CODALMSAL"))
                                            Continue For
                                        End Try

                                        'Datos trazabilidad
                                        If Aydara.SentenciaSQL("SELECT HAYLOTES FROM ARTICULO WHERE CODART = '" & a3ERPTraspaso.AsStringLin("CODART") & "'") = "T" Then
                                            a3ERPTraspaso.AnadirDetalle(a3ERPTraspaso.AsFloatLin("UNIDADES"), String.Empty, "TIENDA", String.Empty, String.Empty, String.Empty)
                                        End If

                                        a3ERPTraspaso.AnadirLinea()

                                    End With
                                Next

                                a3ERPTraspaso.Anade()

                                LOG.Nuevo("A", "Traspaso " & Trim(a3ERPTraspaso.AsStringCab("SERIE")) & "/" & CInt(a3ERPTraspaso.AsCurrencyCab("NUMDOC")) & " a tienda " & Trim(.CODALMENT), .CODALMSAL)

                            End If

                            'Unidades negativas
                            Lineas = Me.LINETRAS.Select("NUMLIN = " & .NUMLIN & " AND UNIDADES < 0")
                            If Lineas.Length > 0 Then

                                a3ERPTraspaso.Nuevo(.FECHA.ToShortDateString, .CODALMENT, .CODALMSAL)

                                For lin As Integer = 0 To Lineas.Length - 1
                                    With DirectCast(Lineas(lin), dsTPVRecepcion.LINETRASRow)

                                        a3ERP.fWaitForm.SetCaption("Traspaso " & (i + 1) & " de " & Me.CABETRAS.Count & vbCrLf & "Línea " & (lin + 1) & " de " & Lineas.Length)

                                        Try
                                            a3ERPTraspaso.NuevaLineaArt(.CODART, Math.Abs(.UNIDADES))
                                        Catch ex As Exception
                                            LOG.Nuevo("X", "Error al generar traspaso." & vbCrLf & ex.Message, a3ERPTraspaso.AsStringCab("CODALMENT"))
                                            Continue For
                                        End Try

                                        'Datos trazabilidad
                                        If Aydara.SentenciaSQL("SELECT HAYLOTES FROM ARTICULO WHERE CODART = '" & a3ERPTraspaso.AsStringLin("CODART") & "'") = "T" Then
                                            a3ERPTraspaso.AnadirDetalle(a3ERPTraspaso.AsFloatLin("UNIDADES"), String.Empty, "TIENDA", String.Empty, String.Empty, String.Empty)
                                        End If

                                        a3ERPTraspaso.AnadirLinea()

                                    End With
                                Next

                                a3ERPTraspaso.Anade()

                                LOG.Nuevo("A", "Traspaso negativo " & Trim(a3ERPTraspaso.AsStringCab("SERIE")) & "/" & CInt(a3ERPTraspaso.AsCurrencyCab("NUMDOC")) & " desde tienda " & Trim(.CODALMENT), .CODALMSAL)

                            End If

                            Try
                                If IO.File.Exists(Me.DirectorioFicheros & "\" & .FICHERO) Then
                                    IO.File.Copy(Me.DirectorioFicheros & "\" & .FICHERO, Me.DirectorioFicheros & "\BackUp\" & .FICHERO, True)
                                    IO.File.Delete(Me.DirectorioFicheros & "\" & .FICHERO)
                                End If
                            Catch ex As Exception
                                '.LOG = "Traspasos generados pero error al eliminar el fichero." & vbCrLf & ex.Message
                                LOG.Nuevo("X", "Traspasos generados pero error al eliminar el fichero." & vbCrLf & ex.Message, .CODALMSAL)
                            End Try

                        Catch ex As Exception
                            LOG.Nuevo("X", "Error al generar traspasos." & vbCrLf & ex.Message, .CODALMSAL)
                        Finally
                            a3ERPTraspaso.Acabar()
                        End Try

                    End With

                Next

            End If

        Catch ex As Exception
            LOG.Nuevo("X", "Error al leer fichero de traspasos." & vbCrLf & ex.Message)
        Finally
            Me.LINETRAS.Clear()
            Me.CABETRAS.Clear()
            Aydara.Estado()
        End Try

    End Sub
#End Region

#Region "GenerarPedidos"
    Private Sub GenerarPedidos()
        Try
            Aydara.Estado("Leyendo ficheros", "Generando pedidos de venta")
            Me.LeerPedidos()

            If Me.CABEPEDV.Count > 0 Then

                Dim a3ERPPedido As New a3ERPActiveX.Pedido

                Dim Lineas As DataRow()

                For i As Integer = 0 To Me.CABEPEDV.Count - 1
                    With Me.CABEPEDV(i)

                        a3ERPPedido.Iniciar()
                        a3ERPPedido.OmitirMensajes = True
                        a3ERPPedido.ActivarAlarmaCab = False
                        a3ERPPedido.ActivarAlarmaLin = False

                        Try
                            'Datos tienda
                            Dim dsTiendas As New dsTiendas
                            dsTiendas.Cargar(.CODALM)
                            If dsTiendas.TIENDAS.Count = 0 Then Continue For
                            Dim Tienda As dsTiendas.TIENDASRow = dsTiendas.TIENDAS(0)

                            a3ERP.fWaitForm.SetCaption("Creando pedido " & (i + 1) & " de " & Me.CABEPEDV.Count)

                            If Tienda.IsIDA_CODCLIPEDNull Then Continue For

                            Lineas = Me.LINEPEDI.Select("NUMLIN = " & .NUMLIN)
                            If Lineas.Length > 0 Then

                                'Cabecera pedido
                                Try
                                    a3ERPPedido.Nuevo(.FECHA.ToShortDateString, Tienda.IDA_CODCLIPED, False)
                                    a3ERPPedido.AsStringCab("FECENTREGA") = .FECHAVALOR
                                    If Not Tienda.IsTIPOCONTPEDIDONull Then a3ERPPedido.AsStringCab("TIPOCONT") = Tienda.TIPOCONTPEDIDO
                                    If Not Tienda.IsSERIEPEDIDONull Then a3ERPPedido.AsStringCab("SERIE") = Tienda.SERIEPEDIDO

                                Catch ex As Exception
                                    LOG.Nuevo("X", "Error al generar pedido de venta." & vbCrLf & ex.Message, a3ERPPedido.AsStringCab("CODALM"))
                                    Continue For
                                End Try

                                'Líneas pedido
                                For lin As Integer = 0 To Lineas.Length - 1
                                    With DirectCast(Lineas(lin), dsTPVRecepcion.LINEPEDIRow)

                                        a3ERP.fWaitForm.SetCaption("Pedido " & (i + 1) & " de " & Me.CABEPEDV.Count & vbCrLf & "Línea " & (lin + 1) & " de " & Lineas.Length)

                                        Try
                                            a3ERPPedido.NuevaLinea()
                                            a3ERPPedido.AsStringLin("CODART") = .CODART

                                            If a3ERPPedido.AsStringLin("CODART") = a3ERP.DatosConfig.CODARTBLAN Then Continue For

                                            a3ERPPedido.AsStringLin("PAQUETES") = .CAJAS
                                            If .UNIDADES <> 0 Then a3ERPPedido.AsStringLin("UNIDADES") = .UNIDADES

                                        Catch ex As Exception
                                            LOG.Nuevo("X", "Error al generar pedido de venta." & vbCrLf & ex.Message, a3ERPPedido.AsStringCab("CODALM"))
                                            Continue For
                                        End Try

                                        a3ERPPedido.AnadirLinea()

                                    End With
                                Next

                                a3ERP.fWaitForm.SetCaption("Guardando pedido")
                                a3ERPPedido.Anade()

                                LOG.Nuevo("A", "Pedido de venta " & Trim(a3ERPPedido.AsStringCab("SERIE")) & "/" & CInt(a3ERPPedido.AsCurrencyCab("NUMDOC")), .CODALM)

                            End If

                            Try
                                If IO.File.Exists(Me.DirectorioFicheros & "\" & .FICHERO) Then
                                    IO.File.Copy(Me.DirectorioFicheros & "\" & .FICHERO, Me.DirectorioFicheros & "\BackUp\" & .FICHERO, True)
                                    IO.File.Delete(Me.DirectorioFicheros & "\" & .FICHERO)
                                End If
                            Catch ex As Exception
                                '.LOG = "Pedidos generados pero error al eliminar el fichero." & vbCrLf & ex.Message
                                LOG.Nuevo("X", "Pedidos de venta generados pero error al eliminar el fichero." & vbCrLf & ex.Message, .CODALM)
                            End Try

                        Catch ex As Exception
                            LOG.Nuevo("X", "Error al generar pedidos de venta." & vbCrLf & ex.Message, .CODALM)
                        Finally
                            a3ERPPedido.Acabar()
                        End Try

                    End With

                Next

            End If

        Catch ex As Exception
            LOG.Nuevo("X", "Error al leer fichero de pedidos de venta." & vbCrLf & ex.Message)
        Finally
            Me.LINEPEDI.Clear()
            Me.CABEPEDV.Clear()
            Aydara.Estado()
        End Try

    End Sub

#End Region

#Region "GenerarIncidencias"
    Private Sub GenerarIncidencias()
        Try
            Aydara.Estado("Leyendo ficheros", "Generando regularización incidencias")
            Me.LeerIncidencias()

            If Me.CABEREGU.Count > 0 Then

                Dim a3ERPRegularizacion As New a3ERPActiveX.Regularizacion
                Dim Lineas As DataRow()

                For i As Integer = 0 To Me.CABEREGU.Count - 1
                    With Me.CABEREGU(i)

                        Try
                            'Datos tienda
                            Dim dsTiendas As New dsTiendas
                            dsTiendas.Cargar(.CODALM)
                            If dsTiendas.TIENDAS.Count = 0 Then Continue For
                            Dim Tienda As dsTiendas.TIENDASRow = dsTiendas.TIENDAS(0)

                            a3ERP.fWaitForm.SetCaption("Regularización " & (i + 1) & " de " & Me.CABEREGU.Count)

                            a3ERPRegularizacion.Iniciar()
                            a3ERPRegularizacion.OmitirMensajes = True

                            'Líneas
                            Lineas = Me.LINEREGU.Select("NUMLIN = " & .NUMLIN & " AND UNIDADES <> 0")
                            If Lineas.Length > 0 Then

                                a3ERPRegularizacion.Nuevo(.FECHA.ToShortDateString, .CODALM)
                                If Not Tienda.IsTIPOCONTDESTINONull Then a3ERPRegularizacion.AsStringCab("TIPOCONT") = Tienda.TIPOCONTDESTINO
                                If Not Tienda.IsSERIEDESTINONull Then a3ERPRegularizacion.AsStringCab("SERIE") = Tienda.SERIEDESTINO
                                a3ERPRegularizacion.AsStringCab("MOTIVO") = "Incidencias tienda"

                                For lin As Integer = 0 To Lineas.Length - 1
                                    With DirectCast(Lineas(lin), dsTPVRecepcion.LINEREGURow)

                                        a3ERP.fWaitForm.SetCaption("Regularización " & (i + 1) & " de " & Me.CABEREGU.Count & vbCrLf & "Línea " & (lin + 1) & " de " & Lineas.Length)

                                        Try
                                            a3ERPRegularizacion.NuevaLineaArt(.CODART, .UNIDADES)
                                        Catch ex As Exception
                                            LOG.Nuevo("X", "Error al generar regularización de incidencias." & vbCrLf & ex.Message, a3ERPRegularizacion.AsStringCab("CODALM"))
                                            Continue For
                                        End Try

                                        'Datos trazabilidad
                                        If Aydara.SentenciaSQL("SELECT HAYLOTES FROM ARTICULO WHERE CODART = '" & a3ERPRegularizacion.AsStringLin("CODART") & "'") = "T" Then
                                            a3ERPRegularizacion.AnadirDetalle(a3ERPRegularizacion.AsFloatLin("UNIDADES"), String.Empty, "TIENDA", String.Empty, String.Empty)
                                        End If

                                        'Datos adicionales
                                        a3ERPRegularizacion.AsStringLin("TEXTO") = "Tipo: " & .TIPO
                                        a3ERPRegularizacion.AsStringLin("TEXTO") &= vbCrLf & "Operario: " & .OPERARIO
                                        a3ERPRegularizacion.AsStringLin("TEXTO") &= vbCrLf & "Comentarios: " & .TEXTO

                                        a3ERPRegularizacion.AnadirLinea()

                                    End With
                                Next

                                a3ERPRegularizacion.Anade()

                                LOG.Nuevo("A", "Regularización " & Trim(a3ERPRegularizacion.AsStringCab("SERIE")) & "/" & CInt(a3ERPRegularizacion.AsCurrencyCab("NUMDOC")) & " de tienda " & Trim(.CODALM), .CODALM)

                            End If

                            Try
                                If IO.File.Exists(Me.DirectorioFicheros & "\" & .FICHERO) Then
                                    IO.File.Copy(Me.DirectorioFicheros & "\" & .FICHERO, Me.DirectorioFicheros & "\BackUp\" & .FICHERO, True)
                                    IO.File.Delete(Me.DirectorioFicheros & "\" & .FICHERO)
                                End If
                            Catch ex As Exception
                                '.LOG = "Traspasos generados pero error al eliminar el fichero." & vbCrLf & ex.Message
                                LOG.Nuevo("X", "Incidencias generadas pero error al eliminar el fichero." & vbCrLf & ex.Message, .CODALM)
                            End Try

                        Catch ex As Exception
                            LOG.Nuevo("X", "Error al generar incidencias." & vbCrLf & ex.Message, .CODALM)
                        Finally
                            a3ERPRegularizacion.Acabar()
                        End Try

                    End With

                Next

            End If

        Catch ex As Exception
            LOG.Nuevo("X", "Error al leer fichero de incidencias." & vbCrLf & ex.Message)
        Finally
            Me.LINEREGU.Clear()
            Me.CABEREGU.Clear()
            Aydara.Estado()
        End Try

    End Sub

#End Region

#Region "Venta crédito"
    Public Sub GeneraVentaCredito()
        Me.GenerarAlbaranesFacturas()
        Me.GenerarFacturasCredito()
        Me.GenerarFacturasContado()
    End Sub

#Region "GenerarAlbaranesFacturas"
    Private Sub GenerarAlbaranesFacturas()

        Dim VentaCredito As New dsTickets
        Dim Ticket As New dsTickets

        Try
            Aydara.Estado("Buscando tickets", "Generando venta crédito")
            VentaCredito.VentaCredito(1)

            If VentaCredito.IDA_TICKETS.Count > 0 Then

                Dim a3ERPAlbaran As New a3ERPActiveX.Albaran
                Dim tickets As Integer
                Dim lineas As Integer
                Dim CODCLI As String

                For tickets = 0 To VentaCredito.IDA_TICKETS.Count - 1
                    With VentaCredito.IDA_TICKETS(tickets)

                        Try
                            'Datos ticket
                            Ticket.Cargar(.IDTICKET)

                            'Datos tienda
                            Dim dsTiendas As New dsTiendas
                            dsTiendas.Cargar(.CODALM)
                            If dsTiendas.TIENDAS.Count = 0 Then Continue For
                            Dim Tienda As dsTiendas.TIENDASRow = dsTiendas.TIENDAS(0)

                            a3ERP.fWaitForm.SetCaption("Ticket nº " & Trim(.CODALM) & "/" & .CAJA & "-" & .NUMDOC & vbCrLf & "Creando albarán de venta")

                            If Not .IsCODCLINull Then
                                CODCLI = Aydara.SentenciaSQL("SELECT CODCLI FROM CLIENTES WHERE LTRIM(CODCLI) = '" & .CODCLI.Trim & "'")
                            Else
                                CODCLI = String.Empty
                            End If

                            If CODCLI = String.Empty Then
                                CODCLI = Aydara.SentenciaSQL("SELECT CODCLI FROM CLIENTES WHERE CONVERT(INT,CODCLI) = '" & .CODCLI.Trim & "'")
                            End If

                            If CODCLI = String.Empty Then
                                LOG.Nuevo("X", "No existe cliente asociado al ticket nº " & .NUMDOC, .CODALM)
                                Continue For
                            End If

                            a3ERPAlbaran.Iniciar()
                            a3ERPAlbaran.ValidarPrecios = False
                            a3ERPAlbaran.ValidarArtBloqueado = False
                            a3ERPAlbaran.OmitirMensajes = True
                            a3ERPAlbaran.ActivarAlarmaCab = False
                            a3ERPAlbaran.ActivarAlarmaLin = False

                            a3ERPAlbaran.Nuevo(.FECHA.ToShortDateString, CODCLI, False)
                            a3ERPAlbaran.AsStringCab("CODALM") = .CODALM
                            a3ERPAlbaran.AsStringCab("IVAINCLUIDO") = "T"
                            a3ERPAlbaran.AsStringCab("REFERENCIA") = Trim(.CODALM) & "/" & .CAJA & "-" & .NUMDOC
                            If Not Tienda.IsTARIFANull Then a3ERPAlbaran.AsStringCab("TARIFA") = Tienda.TARIFA
                            If Not Tienda.IsCENTROCOSTENull Then a3ERPAlbaran.AsStringCab("CENTROCOSTE") = Tienda.CENTROCOSTE
                            a3ERPAlbaran.AsStringCab("CENTROCOSTE") = "3"

                            'Tipo contable, serie y nº del documento
                            Select Case .TIPDOC
                                Case 1
                                    If Not Tienda.IsTIPOCONTALBARANNull Then a3ERPAlbaran.AsStringCab("TIPOCONT") = Tienda.TIPOCONTALBCREDITO
                                    If Not Tienda.IsSERIEALBCREDITONull Then a3ERPAlbaran.AsStringCab("SERIE") = Tienda.SERIEALBCREDITO
                                Case 2
                                    If Not Tienda.IsIDA_TIPOCONTFRA1Null Then a3ERPAlbaran.AsStringCab("TIPOCONT") = Tienda.IDA_TIPOCONTFRA1
                                    If Not Tienda.IsIDA_SERIEFRA1Null Then a3ERPAlbaran.AsStringCab("SERIE") = Tienda.IDA_SERIEFRA1
                                Case 3
                                    If Not Tienda.IsIDA_TIPOCONTFRA2Null Then a3ERPAlbaran.AsStringCab("TIPOCONT") = Tienda.IDA_TIPOCONTFRA2
                                    If Not Tienda.IsIDA_SERIEFRA2Null Then a3ERPAlbaran.AsStringCab("SERIE") = Tienda.IDA_SERIEFRA2
                            End Select
                            a3ERPAlbaran.AsStringCab("NUMDOC") = .NUMDOC

                            For lineas = 0 To Ticket.IDA_TICKETSLINEAS.Count - 1

                                With Ticket.IDA_TICKETSLINEAS(lineas)

                                    a3ERP.fWaitForm.SetCaption("Ticket " & a3ERPAlbaran.AsStringCab("REFERENCIA") & vbCrLf & "Línea " & (lineas + 1) & " de " & Ticket.IDA_TICKETSLINEAS.Count)

                                    a3ERPAlbaran.NuevaLinea()
                                    Try
                                        a3ERPAlbaran.AsStringLin("CODART") = .CODART
                                    Catch ex As Exception
                                        LOG.Nuevo("X", ex.Message, a3ERPAlbaran.AsStringCab("CODALM"))
                                    End Try
                                    a3ERPAlbaran.AsStringLin("DESCLIN") = .DESCLIN
                                    a3ERPAlbaran.AsFloatLin("UNIDADES") = .CANTIDAD

                                    'Datos trazabilidad
                                    If Aydara.SentenciaSQL("SELECT HAYLOTES FROM ARTICULO WHERE CODART = '" & a3ERPAlbaran.AsStringLin("CODART") & "'") = "T" Then
                                        If Aydara.SentenciaSQL("SELECT HAYFECCADUC FROM ARTICULO WHERE CODART = '" & .CODART & "'") = "T" Then
                                            a3ERPAlbaran.AnadirDetalle(a3ERPAlbaran.AsFloatLin("UNIDADES"), String.Empty, "TIENDA", String.Empty, Date.Today.ToShortDateString)
                                        Else
                                            a3ERPAlbaran.AnadirDetalle(a3ERPAlbaran.AsFloatLin("UNIDADES"), String.Empty, "TIENDA", String.Empty, String.Empty)
                                        End If
                                    ElseIf Aydara.SentenciaSQL("SELECT HAYNUMSERIE FROM ARTICULO WHERE CODART = '" & a3ERPAlbaran.AsStringLin("CODART") & "'") = "T" Then
                                        a3ERPAlbaran.AnadirDetalle(a3ERPAlbaran.AsFloatLin("UNIDADES"), "TIENDA", String.Empty, String.Empty, String.Empty)
                                    End If

                                    'Precios
                                    a3ERPAlbaran.AsFloatLin("PRCMONEDAMASIVA") = .PRECIO
                                    a3ERPAlbaran.AsFloatLin("DESC1") = .DESC
                                    a3ERPAlbaran.AsFloatLin("DESC2") = 0
                                    a3ERPAlbaran.AsFloatLin("DESC3") = 0
                                    a3ERPAlbaran.AsFloatLin("DESC4") = 0

                                End With

                                a3ERPAlbaran.AnadirLinea()

                            Next

                            Dim IDALBV As Double = a3ERPAlbaran.Anade()

                            LOG.Nuevo("A", "Albarán de venta " & Trim(a3ERPAlbaran.AsStringCab("TIPOCONT")) & "/" & Trim(a3ERPAlbaran.AsStringCab("SERIE")) & "/" & CInt(a3ERPAlbaran.AsCurrencyCab("NUMDOC")) & ". Cliente: " & Trim(a3ERPAlbaran.AsStringCab("CODCLI")) & " - " & a3ERPAlbaran.AsStringCab("NOMCLI"), .CODALM)

                            'Eliminar ticket
                            'Aydara.SentenciaSQL("DELETE FROM IDA_TICKETS WHERE IDTICKET = " & .IDTICKET)
                            Aydara.SentenciaSQL("UPDATE IDA_TICKETS SET IDALBV = " & IDALBV & " WHERE IDTICKET = " & .IDTICKET)

                            'Si es albarán cobrado, generar anticipo
                            Try
                                If .TIPDOC = 1 And .TOTEFECTIVO + .TOTTARJETA <> 0 Then

                                    a3ERP.fWaitForm.SetCaption("Ticket " & a3ERPAlbaran.AsStringCab("REFERENCIA") & vbCrLf & "Generando anticipo de cobro")

                                    Dim a3ERPCartera As New a3ERPActiveX.OperacionesCartera
                                    a3ERPCartera.CrearAnticipo(True, a3ERPAlbaran.AsStringCab("CODCLI"), a3ERP.DatosConfig.CODBAN, a3ERP.DatosConfig.DOCPAG, a3ERPAlbaran.AsStringCab("TIPOCONT"), a3ERP.DatosConfig.CODMON, a3ERPAlbaran.AsStringCab("FECHA"), a3ERPAlbaran.AsStringCab("FECHA"), .TOTEFECTIVO + .TOTTARJETA, "Anticipo de albarán " & Trim(a3ERPAlbaran.AsStringCab("TIPOCONT")) & "/" & Trim(a3ERPAlbaran.AsStringCab("SERIE")) & "/" & CInt(a3ERPAlbaran.AsCurrencyCab("NUMDOC")))

                                End If

                            Catch ex As Exception
                                LOG.Nuevo("X", "Error al generar anticipo en cartera." & vbCrLf & "Albarán " & Trim(a3ERPAlbaran.AsStringCab("TIPOCONT")) & "/" & Trim(a3ERPAlbaran.AsStringCab("SERIE")) & "/" & CInt(a3ERPAlbaran.AsCurrencyCab("NUMDOC")) & ". Cliente: " & Trim(a3ERPAlbaran.AsStringCab("CODCLI")) & " - " & a3ERPAlbaran.AsStringCab("NOMCLI") & vbCrLf & ex.Message, .CODALM)
                            End Try

                            'Si es factura, servir albarán
                            If .TIPDOC = 2 Or .TIPDOC = 3 Then

                                a3ERP.fWaitForm.SetCaption("Ticket " & a3ERPAlbaran.AsStringCab("REFERENCIA") & vbCrLf & "Generando factura")

                                Dim a3ERPFactura As New a3ERPActiveX.Factura

                                Try
                                    a3ERPFactura.Iniciar()
                                    a3ERPFactura.ValidarPrecios = False
                                    a3ERPFactura.ValidarArtBloqueado = False
                                    a3ERPFactura.OmitirMensajes = True
                                    a3ERPFactura.ActivarAlarmaCab = False
                                    a3ERPFactura.ActivarAlarmaLin = False

                                    a3ERPFactura.Nuevo(a3ERPAlbaran.AsStringCab("FECHA"), a3ERPAlbaran.AsStringCab("CODCLI"), False, False, (.TIPDOC = 2), (.TIPDOC = 2))

                                    a3ERPFactura.IniciarServir("A", a3ERPAlbaran.AsCurrencyCab("IDALBV"), False)
                                    a3ERPFactura.ServirDocumento()
                                    a3ERPFactura.FinServir()

                                    a3ERPFactura.AsStringCab("NUMDOC") = .NUMDOC

                                    If .TIPDOC = 2 And .TOTEFECTIVO + .TOTTARJETA <> 0 Then
                                        a3ERPFactura.AsStringCab("FORPAG") = "CT"
                                        a3ERPFactura.AsStringCab("DOCPAG") = "E"
                                    End If

                                    a3ERPFactura.Anade()

                                    LOG.Nuevo("A", "Factura de venta " & Trim(a3ERPFactura.AsStringCab("TIPOCONT")) & "/" & Trim(a3ERPFactura.AsStringCab("SERIE")) & "/" & CInt(a3ERPFactura.AsCurrencyCab("NUMDOC")) & ". Cliente: " & Trim(a3ERPFactura.AsStringCab("CODCLI")) & " - " & a3ERPFactura.AsStringCab("NOMCLI"), .CODALM)

                                    ''Factura cobrada, generar asiento de cobro
                                    'If .TIPDOC = 2 And .TOTEFECTIVO + .TOTTARJETA <> 0 Then

                                    '    a3ERP.fWaitForm.SetCaption("Ticket " & a3ERPAlbaran.AsStringCab("REFERENCIA") & vbCrLf & "Generando asiento de cobro")

                                    '    Dim a3ERPAsiento As New a3ERPActiveX.Asiento

                                    '    Try
                                    '        a3ERPAsiento.Iniciar()

                                    '        Dim CuentaCliente As String = Aydara.SentenciaSQL("SELECT CUENTA FROM CLIENTES WHERE CODCLI = '" & a3ERPFactura.AsStringCab("CODCLI") & "'")
                                    '        Dim CentroCoste As String = Aydara.SentenciaSQL("SELECT CENTROCOSTE FROM CLIENTES WHERE CODCLI = '" & a3ERPFactura.AsStringCab("CODCLI") & "'")

                                    '        a3ERPAsiento.Nuevo(a3ERPFactura.AsStringCab("FECHA"), a3ERPFactura.AsStringCab("TIPOCONT"), "N")
                                    '        a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, CuentaCliente, 0, "Cobro Fra. " & Trim(a3ERPFactura.AsStringCab("TIPOCONT")) & "/" & Trim(a3ERPFactura.AsStringCab("SERIE")) & "/" & CInt(a3ERPFactura.AsCurrencyCab("NUMDOC")), .TOTEFECTIVO + .TOTTARJETA, CentroCoste, String.Empty)
                                    '        If .TOTEFECTIVO <> 0 Then a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, Tienda.IDA_CTAEFECTIVO, .TOTEFECTIVO, "Cobro Fra. " & Trim(a3ERPFactura.AsStringCab("TIPOCONT")) & "/" & Trim(a3ERPFactura.AsStringCab("SERIE")) & "/" & CInt(a3ERPFactura.AsCurrencyCab("NUMDOC")), 0, CentroCoste, String.Empty)
                                    '        If .TOTTARJETA <> 0 Then a3ERPAsiento.AApunte(a3ERP.DatosConfig.CODMON, Tienda.IDA_CTATARJETA, .TOTTARJETA, "Cobro Fra. " & Trim(a3ERPFactura.AsStringCab("TIPOCONT")) & "/" & Trim(a3ERPFactura.AsStringCab("SERIE")) & "/" & CInt(a3ERPFactura.AsCurrencyCab("NUMDOC")), 0, CentroCoste, String.Empty)
                                    '        a3ERPAsiento.Anade()

                                    '        LOG.Nuevo("A", "Asiento de cobro de la factura " & Trim(a3ERPFactura.AsStringCab("TIPOCONT")) & "/" & Trim(a3ERPFactura.AsStringCab("SERIE")) & "/" & CInt(a3ERPFactura.AsCurrencyCab("NUMDOC")) & ". Cliente: " & Trim(a3ERPFactura.AsStringCab("CODCLI")) & " - " & a3ERPFactura.AsStringCab("NOMCLI"), .CODALM)

                                    '    Catch ex As Exception
                                    '        LOG.Nuevo("X", "Error al generar asiento de cobro." & vbCrLf & "Factura " & Trim(a3ERPFactura.AsStringCab("TIPOCONT")) & "/" & Trim(a3ERPFactura.AsStringCab("SERIE")) & "/" & CInt(a3ERPFactura.AsCurrencyCab("NUMDOC")) & ". Cliente: " & Trim(a3ERPFactura.AsStringCab("CODCLI")) & " - " & a3ERPFactura.AsStringCab("NOMCLI") & vbCrLf & ex.Message, .CODALM)
                                    '    Finally
                                    '        a3ERPAsiento.Acabar()
                                    '    End Try

                                    'End If

                                Catch ex As Exception
                                    LOG.Nuevo("X", "Error al generar factura de venta." & vbCrLf & "Albarán " & Trim(a3ERPAlbaran.AsStringCab("TIPOCONT")) & "/" & Trim(a3ERPAlbaran.AsStringCab("SERIE")) & "/" & CInt(a3ERPAlbaran.AsCurrencyCab("NUMDOC")) & ". Cliente: " & Trim(a3ERPAlbaran.AsStringCab("CODCLI")) & " - " & a3ERPAlbaran.AsStringCab("NOMCLI") & vbCrLf & ex.Message, .CODALM)
                                Finally
                                    a3ERPFactura.Acabar()
                                End Try
                            End If

                        Catch ex As Exception
                            LOG.Nuevo("X", "Error al generar albaranes de venta." & vbCrLf & ex.Message, .CODALM)
                        Finally
                            a3ERPAlbaran.Acabar()
                        End Try

                    End With

                Next

            End If

        Catch ex As Exception
            LOG.Nuevo("X", "Error al buscar albaranes de venta." & vbCrLf & ex.Message)
        Finally
            Me.IDA_TICKETSLINEAS.Clear()
            Me.IDA_TICKETS.Clear()
            Me.IDA_CAJAS.Clear()
            Aydara.Estado()
        End Try

    End Sub

#End Region

#Region "GenerarFacturasCredito"
    Private Sub GenerarFacturasCredito()

        Dim VentaCredito As New dsTickets
        Dim Ticket As New dsTickets

        Try
            Aydara.Estado("Buscando tickets", "Generando facturas de crédito (1/2)")
            VentaCredito.VentaCredito(2)

            If VentaCredito.IDA_TICKETS.Count > 0 Then

                Dim a3ERPFactura As New a3ERPActiveX.Factura
                Dim tickets As Integer
                Dim lineas As Integer
                Dim CODCLI As String

                For tickets = 0 To VentaCredito.IDA_TICKETS.Count - 1
                    With VentaCredito.IDA_TICKETS(tickets)

                        Try
                            'Datos ticket
                            Ticket.Cargar(.IDTICKET)

                            'Datos tienda
                            Dim dsTiendas As New dsTiendas
                            dsTiendas.Cargar(.CODALM)
                            If dsTiendas.TIENDAS.Count = 0 Then Continue For
                            Dim Tienda As dsTiendas.TIENDASRow = dsTiendas.TIENDAS(0)

                            a3ERP.fWaitForm.SetCaption("Factura nº " & Trim(.CODALM) & "/" & .CAJA & "-" & .NUMDOC)

                            If Not .IsCODCLINull Then
                                CODCLI = Aydara.SentenciaSQL("SELECT CODCLI FROM CLIENTES WHERE LTRIM(CODCLI) = '" & .CODCLI.Trim & "'")
                            Else
                                CODCLI = String.Empty
                            End If

                            If CODCLI = String.Empty Then
                                LOG.Nuevo("X", "No existe cliente asociado al ticket nº " & .NUMDOC, .CODALM)
                                Continue For
                            End If

                            a3ERPFactura.Iniciar()
                            a3ERPFactura.ValidarPrecios = False
                            a3ERPFactura.ValidarArtBloqueado = False
                            a3ERPFactura.OmitirMensajes = True
                            a3ERPFactura.ActivarAlarmaCab = False
                            a3ERPFactura.ActivarAlarmaLin = False

                            'Datos cabecera
                            a3ERPFactura.Nuevo(.FECHA.ToShortDateString, CODCLI, False, False, True, True)
                            a3ERPFactura.AsStringCab("CODALM") = .CODALM
                            If Not Tienda.IsIDA_TIPOCONTFRA1Null Then a3ERPFactura.AsStringCab("TIPOCONT") = Tienda.IDA_TIPOCONTFRA1
                            If Not Tienda.IsIDA_SERIEFRA1Null Then a3ERPFactura.AsStringCab("SERIE") = Tienda.IDA_SERIEFRA1
                            a3ERPFactura.AsStringCab("NUMDOC") = .NUMDOC
                            a3ERPFactura.AsStringCab("IVAINCLUIDO") = "T"
                            a3ERPFactura.AsStringCab("REFERENCIA") = Trim(.CODALM) & "/" & .CAJA & "-" & .NUMDOC
                            If Not Tienda.IsTARIFANull Then a3ERPFactura.AsStringCab("TARIFA") = Tienda.TARIFA
                            If Not Tienda.IsCENTROCOSTENull Then a3ERPFactura.AsStringCab("CENTROCOSTE") = Tienda.CENTROCOSTE
                            a3ERPFactura.AsStringCab("SIMPLIFICADA") = "T"
                            If Not .IsFORPAGNull Then If .FORPAG.Trim <> String.Empty Then a3ERPFactura.AsStringCab("FORPAG") = .FORPAG.Trim
                            a3ERPFactura.AsStringCab("CENTROCOSTE") = "3"

                            'Comprobar si está pagada
                            If .TOTEFECTIVO + .TOTTARJETA <> 0 Then
                                a3ERPFactura.AsStringCab("FORPAG") = "C"
                                a3ERPFactura.AsStringCab("DOCPAG") = IIf(.TOTTARJETA <> 0, "5", "E")
                            End If

                            For lineas = 0 To Ticket.IDA_TICKETSLINEAS.Count - 1

                                With Ticket.IDA_TICKETSLINEAS(lineas)

                                    a3ERP.fWaitForm.SetCaption(a3ERPFactura.AsStringCab("REFERENCIA") & vbCrLf & "Línea " & (lineas + 1) & " de " & Ticket.IDA_TICKETSLINEAS.Count)

                                    a3ERPFactura.NuevaLinea()
                                    Try
                                        a3ERPFactura.AsStringLin("CODART") = .CODART
                                    Catch ex As Exception
                                        LOG.Nuevo("X", ex.Message, a3ERPFactura.AsStringCab("CODALM"))
                                    End Try
                                    a3ERPFactura.AsStringLin("DESCLIN") = .DESCLIN
                                    a3ERPFactura.AsFloatLin("UNIDADES") = .CANTIDAD

                                    'Datos trazabilidad
                                    If Aydara.SentenciaSQL("SELECT HAYLOTES FROM ARTICULO WHERE CODART = '" & a3ERPFactura.AsStringLin("CODART") & "'") = "T" Then
                                        If Aydara.SentenciaSQL("SELECT HAYFECCADUC FROM ARTICULO WHERE CODART = '" & .CODART & "'") = "T" Then
                                            a3ERPFactura.AnadirDetalle(a3ERPFactura.AsFloatLin("UNIDADES"), String.Empty, "TIENDA", String.Empty, Date.Today.ToShortDateString)
                                        Else
                                            a3ERPFactura.AnadirDetalle(a3ERPFactura.AsFloatLin("UNIDADES"), String.Empty, "TIENDA", String.Empty, String.Empty)
                                        End If
                                    ElseIf Aydara.SentenciaSQL("SELECT HAYNUMSERIE FROM ARTICULO WHERE CODART = '" & a3ERPFactura.AsStringLin("CODART") & "'") = "T" Then
                                        a3ERPFactura.AnadirDetalle(a3ERPFactura.AsFloatLin("UNIDADES"), "TIENDA", String.Empty, String.Empty, String.Empty)
                                    End If

                                    'Precios
                                    a3ERPFactura.AsFloatLin("PRCMONEDAMASIVA") = .PRECIO
                                    a3ERPFactura.AsFloatLin("DESC1") = .DESC
                                    a3ERPFactura.AsFloatLin("DESC2") = 0
                                    a3ERPFactura.AsFloatLin("DESC3") = 0
                                    a3ERPFactura.AsFloatLin("DESC4") = 0

                                End With

                                a3ERPFactura.AnadirLinea()

                            Next

                            'Dto.P.P
                            a3ERPFactura.AsFloatCab("PORPRONTO") = .PORPRONTO

                            Dim IDFACV As Integer = a3ERPFactura.Anade()

                            LOG.Nuevo("A", "Factura de crédito " & Trim(a3ERPFactura.AsStringCab("TIPOCONT")) & "/" & Trim(a3ERPFactura.AsStringCab("SERIE")) & "/" & CInt(a3ERPFactura.AsCurrencyCab("NUMDOC")) & ". Cliente: " & Trim(a3ERPFactura.AsStringCab("CODCLI")) & " - " & a3ERPFactura.AsStringCab("NOMCLI") & " (" & .NUMTARJETA & ")", .CODALM)

                            'Eliminar ticket
                            'Aydara.SentenciaSQL("DELETE FROM IDA_TICKETS WHERE IDTICKET = " & .IDTICKET)
                            Aydara.SentenciaSQL("UPDATE IDA_TICKETS SET IDFACV = " & IDFACV & " WHERE IDTICKET = " & .IDTICKET)

                            'Comprobar si está pagada
                            If .TOTEFECTIVO + .TOTTARJETA <> 0 Then

                                Dim naxCartera As New a3ERPActiveX.Cartera

                                Try
                                    naxCartera.Iniciar()
                                    Dim NumCartera As Integer = naxCartera.ObtenerNumCartera(True, IDFACV)
                                    Dim NumVen As Integer = 0
                                    If NumCartera <> 0 Then
                                        If .TOTEFECTIVO <> 0 Then
                                            NumVen = Aydara.SentenciaSQL("SELECT NUMVEN FROM CARTERA WHERE NUMCARTERA = " & NumCartera & " AND PAGADO = 'F'")
                                            naxCartera.Editar(NumCartera)
                                            naxCartera.EditarVencimiento(NumVen)
                                            naxCartera.VAsString("DOCPAG") = "E"
                                            NumCartera = naxCartera.Anade
                                            Dim Operacion As New a3ERPActiveX.OperacionesCartera
                                            Operacion.Cobrar(NumCartera, NumVen, True, False, "", "", .FECHA.ToShortDateString, "")
                                        End If
                                        If .TOTTARJETA <> 0 Then
                                            NumVen = Aydara.SentenciaSQL("SELECT NUMVEN FROM CARTERA WHERE NUMCARTERA = " & NumCartera & " AND PAGADO = 'F'")
                                            naxCartera.Editar(NumCartera)
                                            naxCartera.EditarVencimiento(NumVen)
                                            naxCartera.VAsString("DOCPAG") = "5"
                                            NumCartera = naxCartera.Anade
                                            Dim Operacion As New a3ERPActiveX.OperacionesCartera
                                            Operacion.Cobrar(NumCartera, NumVen, True, False, "", "", .FECHA.ToShortDateString, "")
                                        End If
                                    End If
                                Catch ex As Exception
                                    LOG.Nuevo("X", "Error al procesar cobro factura." & vbCrLf & ex.Message, .CODALM)
                                Finally
                                    naxCartera.Acabar()
                                End Try
                            End If

                        Catch ex As Exception
                            LOG.Nuevo("X", "Error al generar facturas de crédito." & vbCrLf & ex.Message, .CODALM)
                        Finally
                            a3ERPFactura.Acabar()
                        End Try

                    End With

                Next

            End If

        Catch ex As Exception
            LOG.Nuevo("X", "Error al buscar facturas de crédito." & vbCrLf & ex.Message)
        Finally
            Me.IDA_TICKETSLINEAS.Clear()
            Me.IDA_TICKETS.Clear()
            Me.IDA_CAJAS.Clear()
            Aydara.Estado()
        End Try

    End Sub

#End Region

#Region "GenerarFacturasContado"
    Private Sub GenerarFacturasContado()

        Dim VentaCredito As New dsTickets
        Dim Ticket As New dsTickets

        Try
            Aydara.Estado("Buscando tickets", "Generando facturas de crédito (2/2)")
            VentaCredito.VentaCredito(3)

            If VentaCredito.IDA_TICKETS.Count > 0 Then

                Dim a3ERPFactura As New a3ERPActiveX.Factura
                Dim tickets As Integer
                Dim lineas As Integer
                Dim CODCLI As String

                For tickets = 0 To VentaCredito.IDA_TICKETS.Count - 1
                    With VentaCredito.IDA_TICKETS(tickets)

                        Try
                            'Datos ticket
                            Ticket.Cargar(.IDTICKET)

                            'Datos tienda
                            Dim dsTiendas As New dsTiendas
                            dsTiendas.Cargar(.CODALM)
                            If dsTiendas.TIENDAS.Count = 0 Then Continue For
                            Dim Tienda As dsTiendas.TIENDASRow = dsTiendas.TIENDAS(0)

                            a3ERP.fWaitForm.SetCaption("Factura nº " & Trim(.CODALM) & "/" & .CAJA & "-" & .NUMDOC)

                            If Not .IsCODCLINull Then
                                CODCLI = Aydara.SentenciaSQL("SELECT CODCLI FROM CLIENTES WHERE LTRIM(CODCLI) = " & .CODCLI)
                            Else
                                CODCLI = String.Empty
                            End If

                            If CODCLI = String.Empty Then
                                LOG.Nuevo("X", "No existe cliente asociado al ticket nº " & .NUMDOC, .CODALM)
                                Continue For
                            End If

                            a3ERPFactura.Iniciar()
                            a3ERPFactura.ValidarPrecios = False
                            a3ERPFactura.ValidarArtBloqueado = False
                            a3ERPFactura.OmitirMensajes = True
                            a3ERPFactura.ActivarAlarmaCab = False
                            a3ERPFactura.ActivarAlarmaLin = False

                            a3ERPFactura.Nuevo(.FECHA.ToShortDateString, CODCLI, False, False, False, True)
                            a3ERPFactura.AsStringCab("CODALM") = .CODALM
                            If Not Tienda.IsIDA_TIPOCONTFRA2Null Then a3ERPFactura.AsStringCab("TIPOCONT") = Tienda.IDA_TIPOCONTFRA2
                            If Not Tienda.IsIDA_SERIEFRA2Null Then a3ERPFactura.AsStringCab("SERIE") = Tienda.IDA_SERIEFRA2
                            a3ERPFactura.AsStringCab("NUMDOC") = .NUMDOC
                            a3ERPFactura.AsStringCab("IVAINCLUIDO") = "T"
                            a3ERPFactura.AsStringCab("REFERENCIA") = Trim(.CODALM) & "/" & .CAJA & "-" & .NUMDOC
                            If Not Tienda.IsTARIFANull Then a3ERPFactura.AsStringCab("TARIFA") = Tienda.TARIFA
                            If Not Tienda.IsCENTROCOSTENull Then a3ERPFactura.AsStringCab("CENTROCOSTE") = Tienda.CENTROCOSTE
                            a3ERPFactura.AsStringCab("SIMPLIFICADA") = "T"
                            a3ERPFactura.AsStringCab("CENTROCOSTE") = "3"

                            For lineas = 0 To Ticket.IDA_TICKETSLINEAS.Count - 1

                                With Ticket.IDA_TICKETSLINEAS(lineas)

                                    a3ERP.fWaitForm.SetCaption(a3ERPFactura.AsStringCab("REFERENCIA") & vbCrLf & "Línea " & (lineas + 1) & " de " & Ticket.IDA_TICKETSLINEAS.Count)

                                    a3ERPFactura.NuevaLinea()
                                    Try
                                        a3ERPFactura.AsStringLin("CODART") = .CODART
                                    Catch ex As Exception
                                        LOG.Nuevo("X", ex.Message, a3ERPFactura.AsStringCab("CODALM"))
                                    End Try
                                    a3ERPFactura.AsStringLin("DESCLIN") = .DESCLIN
                                    a3ERPFactura.AsFloatLin("UNIDADES") = .CANTIDAD

                                    'Datos trazabilidad
                                    If Aydara.SentenciaSQL("SELECT HAYLOTES FROM ARTICULO WHERE CODART = '" & a3ERPFactura.AsStringLin("CODART") & "'") = "T" Then
                                        If Aydara.SentenciaSQL("SELECT HAYFECCADUC FROM ARTICULO WHERE CODART = '" & .CODART & "'") = "T" Then
                                            a3ERPFactura.AnadirDetalle(a3ERPFactura.AsFloatLin("UNIDADES"), String.Empty, "TIENDA", String.Empty, Date.Today.ToShortDateString)
                                        Else
                                            a3ERPFactura.AnadirDetalle(a3ERPFactura.AsFloatLin("UNIDADES"), String.Empty, "TIENDA", String.Empty, String.Empty)
                                        End If
                                    ElseIf Aydara.SentenciaSQL("SELECT HAYNUMSERIE FROM ARTICULO WHERE CODART = '" & a3ERPFactura.AsStringLin("CODART") & "'") = "T" Then
                                        a3ERPFactura.AnadirDetalle(a3ERPFactura.AsFloatLin("UNIDADES"), "TIENDA", String.Empty, String.Empty, String.Empty)
                                    End If

                                    'Precios
                                    a3ERPFactura.AsFloatLin("PRCMONEDAMASIVA") = .PRECIO
                                    a3ERPFactura.AsFloatLin("DESC1") = .DESC
                                    a3ERPFactura.AsFloatLin("DESC2") = 0
                                    a3ERPFactura.AsFloatLin("DESC3") = 0
                                    a3ERPFactura.AsFloatLin("DESC4") = 0

                                End With

                                a3ERPFactura.AnadirLinea()

                            Next

                            Dim IDFACV As Integer = a3ERPFactura.Anade()

                            LOG.Nuevo("A", "Fctura de crédito " & Trim(a3ERPFactura.AsStringCab("TIPOCONT")) & "/" & Trim(a3ERPFactura.AsStringCab("SERIE")) & "/" & CInt(a3ERPFactura.AsCurrencyCab("NUMDOC")) & ". Cliente: " & Trim(a3ERPFactura.AsStringCab("CODCLI")) & " - " & a3ERPFactura.AsStringCab("NOMCLI") & " (" & .NUMTARJETA & ")", .CODALM)

                            'Eliminar ticket
                            'Aydara.SentenciaSQL("DELETE FROM IDA_TICKETS WHERE IDTICKET = " & .IDTICKET)
                            Aydara.SentenciaSQL("UPDATE IDA_TICKETS SET IDFACV = " & IDFACV & " WHERE IDTICKET = " & .IDTICKET)

                        Catch ex As Exception
                            LOG.Nuevo("X", "Error al generar facturas de crédito." & vbCrLf & ex.Message, .CODALM)
                        Finally
                            a3ERPFactura.Acabar()
                        End Try

                    End With

                Next

            End If

        Catch ex As Exception
            LOG.Nuevo("X", "Error al buscar facturas de crédito." & vbCrLf & ex.Message)
        Finally
            Me.IDA_TICKETSLINEAS.Clear()
            Me.IDA_TICKETS.Clear()
            Me.IDA_CAJAS.Clear()
            Aydara.Estado()
        End Try

    End Sub

#End Region

#End Region

End Class

