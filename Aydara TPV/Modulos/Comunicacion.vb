Imports System.Net
Imports System.io

Public Class Comunicacion

    Enum TipoFicheroTerminal
        Inventario
        Pedido
        Etiquetas
    End Enum

#Region "GeneraPedido"
    Public Shared Function GeneraPedido(ByVal dsPedidos As dsPedidos, ByVal NombreFichero As String)

        Dim ExistePedido As Boolean

        Try
            If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio") Then My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio")

            'Comprobar si existe un envío anterior
            Comunicacion.DescargaFicheros(NombreFichero)

            ExistePedido = My.Computer.FileSystem.FileExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio\" & NombreFichero)

            Dim sw As New System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio\" & NombreFichero, True, System.Text.Encoding.Default)

            If Not ExistePedido Then
                sw.WriteLine("PEDIDOS")
                sw.WriteLine("**" & Format(Date.Today, "dd-MM-yyyy"))
            End If

            Dim i As Integer
            Dim rLineaPedido As dsPedidos.PEDIDOS_LINEASRow
            For i = 0 To dsPedidos.PEDIDOS_LINEAS.Rows.Count - 1
                rLineaPedido = dsPedidos.PEDIDOS_LINEAS.Rows(i)
                sw.WriteLine(String.Format("{0,15}", rLineaPedido.CodigoArticulo) & Format(rLineaPedido.Cajas * 100, "0000000000") & Format(rLineaPedido.Cantidad * 100, "0000000000"))
            Next

            'Cerrar el fichero
            sw.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "GeneraInventario"
    Public Shared Function GeneraInventario(ByVal dsInventario As dsInventario)
        Try
            If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio") Then My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio")

            Dim sw As New System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio\finve" & Format(General.NumeroAlmacen, "00") & ".seq", False, System.Text.Encoding.Default)

            Dim i As Integer
            Dim rInventario As dsInventario.INVENTARIORow
            For i = 0 To dsInventario.INVENTARIO.Rows.Count - 1
                rInventario = dsInventario.INVENTARIO.Rows(i)
                sw.WriteLine(String.Format("{0,15}", rInventario.CodigoArticulo) & Format(rInventario.Cantidad * 100, "0000000000"))
            Next

            'Cerrar el fichero
            sw.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "GeneraTraspasoAlmacenes"
    Public Shared Function GeneraTraspasoAlmacenes(ByVal dsTraspasoAlmacenes As dsTraspasoAlmacenes, ByVal NombreFichero As String)
        Try
            If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio") Then My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio")

            Dim sw As New System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio\" & LCase(NombreFichero), True, System.Text.Encoding.Default)

            Dim i As Integer
            Dim rTraspaso As dsTraspasoAlmacenes.TRASPASO_ALMACENESRow
            For i = 0 To dsTraspasoAlmacenes.TRASPASO_ALMACENES.Rows.Count - 1
                rTraspaso = dsTraspasoAlmacenes.TRASPASO_ALMACENES.Rows(i)
                If i = 0 Then
                    'Añadir primera línea almacén de destino
                    sw.WriteLine("TRASPA" & Format(rTraspaso.AlmacenDestino, "00") & Format(Date.Now, "HHmmss") & Format(Date.Today, "dd-MM-yyyy"))
                End If
                sw.WriteLine(String.Format("{0,15}", rTraspaso.CodigoArticulo) & Format(rTraspaso.Cantidad * 100, "0000000000"))
            Next

            'Cerrar el fichero
            sw.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "GeneraTarjetas"
    Public Shared Function GeneraTarjetas()
        Try
            If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio") Then My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio")

            Dim sw As New System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio\fcli" & Format(General.NumeroAlmacen, "00") & ".seq", False, System.Text.Encoding.Default)

            Dim dsClientes As New dsClientes
            Dim taClientes As New dsClientesTableAdapters.CLIENTESTableAdapter

            taClientes.Fill(dsClientes.CLIENTES)

            For i As Integer = 0 To dsClientes.CLIENTES.Count - 1
                With dsClientes.CLIENTES(i)

                    If .Codigo = 0 Then Continue For

                    sw.Write(.Codigo)
                    sw.Write(vbTab)
                    sw.Write(.NombreFiscal)
                    sw.Write(vbTab)
                    sw.Write(.CIF)
                    sw.Write(vbTab)
                    sw.Write(.Direccion)
                    sw.Write(vbTab)
                    sw.Write(.CodigoPostal)
                    sw.Write(vbTab)
                    sw.Write(.Poblacion)
                    sw.Write(vbTab)
                    sw.Write(.Provincia)
                    sw.Write(vbTab)
                    sw.Write(.TelParticular)
                    sw.Write(vbTab)
                    sw.Write(.TelMovil)
                    sw.Write(vbTab)
                    sw.Write(.SaldoPuntos)
                    sw.Write(vbTab)
                    sw.Write(IIf(.ControlBaja, "S", "N"))

                    sw.WriteLine()

                End With
            Next

            'Cerrar el fichero
            sw.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "GeneraIncidencias"
    Public Shared Function GeneraIncidencias()
        Try
            If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio") Then My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio")

            Dim sw As New System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio\finc" & Format(General.NumeroAlmacen, "00") & ".seq", False, System.Text.Encoding.Default)

            Dim dsIncidencias As New dsIncidencias
            Dim taIncidencias As New dsIncidenciasTableAdapters.INCIDENCIASTableAdapter

            taIncidencias.Pendientes(dsIncidencias.INCIDENCIAS)

            For i As Integer = 0 To dsIncidencias.INCIDENCIAS.Count - 1
                With dsIncidencias.INCIDENCIAS(i)

                    sw.Write(.Fecha)
                    sw.Write(vbTab)
                    sw.Write(.TempTipo)
                    sw.Write(vbTab)
                    sw.Write(.TempOperario)
                    sw.Write(vbTab)
                    sw.Write(.TempCodigo)
                    sw.Write(vbTab)
                    sw.Write(.TempArticulo)
                    sw.Write(vbTab)
                    sw.Write(.Comentario.Replace(vbCrLf, " "))
                    sw.Write(vbTab)
                    sw.Write(.Cantidad)
                    sw.Write(vbTab)
                    sw.Write(.PrecioCoste)

                    sw.WriteLine()

                End With
            Next

            'Cerrar el fichero
            sw.Close()

            taIncidencias.CerrarPendientes()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "GeneraTickets"
    Public Shared Function GeneraTickets(ByVal dsComunicaciones As dsComunicaciones, ByVal FechaCierre As Date, ByVal NombreFichero As String, Optional ByVal Reenviar As Boolean = False)
        Try
            If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio") Then My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio")

            'Fichero de incidencias
            GeneraIncidencias()

            'Fichero de tarjetas
            GeneraTarjetas()

            'Comprobar si existe un envío anterior
            'Comunicacion.DescargaFicheros(NombreFichero)

            Dim sw As New System.IO.StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio\" & NombreFichero, True, System.Text.Encoding.Default)

            Dim i As Integer
            Dim rTicket As dsComunicaciones.TICKETSRow
            Dim linea As String
            Dim IdTicket As Integer
            Dim NumeroLinea As Integer

            sw.WriteLine("VENTAS" & Format(FechaCierre, "dd-MM-yyyy"))

            For i = 0 To dsComunicaciones.TICKETS.Rows.Count - 1

                rTicket = dsComunicaciones.TICKETS.Rows(i)

                'Comprobar si es cabecera ó línea
                If rTicket.IdTicket <> IdTicket Then

                    IdTicket = rTicket.IdTicket

                    linea = String.Empty
                    linea &= Format(rTicket.CodigoCaja, "00")
                    linea &= Format(rTicket.NumeroTicket, "000000")
                    linea &= Format(General.NumeroAlmacen, "00")
                    linea &= "**********"
                    'linea &= Format(rTicket.FechaTicket, "dd-MM-yyyy")
                    linea &= DateDiff(DateInterval.Day, CDate("01-01-1900"), rTicket.FechaTicket) + 1
                    linea &= Format(rTicket.HoraTicket, "HH:mm")

                    'Tipo de cobro
                    Select Case rTicket.TipoCobro
                        Case "E"
                            linea &= "1"
                        Case "A"
                            linea &= "2"
                        Case "P"
                            linea &= "4"
                        Case "V"
                            linea &= "5"
                        Case Else
                            linea &= "3"
                    End Select

                    linea &= Format(rTicket.CodigoCliente, "00000000")
                    linea &= Format(rTicket.CodigoEmleado, "00")
                    If rTicket.IsRepartoDomicilioNull Then
                        linea &= " "
                    Else
                        linea &= IIf(rTicket.RepartoDomicilio, "*", " ")
                    End If
                    linea &= " "
                    linea &= IIf(rTicket.ImpresoTicket, "S", "N")
                    If rTicket.IsNumeroAlbaranNull Then
                        linea &= "      "
                    Else
                        linea &= Format(CInt(rTicket.NumeroAlbaran), "000000")
                    End If
                    linea &= "1"
                    linea &= IIf(rTicket.Tipofactura > 0, "S", "N")
                    linea &= rTicket.Tipofactura
                    linea &= " "
                    linea &= String.Format("{0,10}", CInt(rTicket.NumeroLineas * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.ImporteTotal * 100))
                    linea &= String.Format("{0,10}", CInt((rTicket.ImporteEfectivo) * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.ImporteTalonCheque * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.ImporteValesProveedor * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.ImporteValesCobrados * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.ImporteTarjeta * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.ImporteEnvases * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.ImportePendienteCobro * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.ImporteValesEmitidos * 100))
                    linea &= String.Format("{0,10}", CInt((rTicket.ImporteTotal + rTicket.ImporteCambios) * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.ImporteCambios * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.FidelizacionImporte * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.FidelizacionVales * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.FidelizacionPuntos * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.FidelizacionLoteria * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.Puntoscanjeados * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.ValesCanjeados * 100))
                    If Not rTicket.IsClienteCreditoNull Then
                        linea &= Format(CInt(rTicket.ClienteCredito), "00000000")
                    Else
                        linea &= Format(0, "00000000")
                    End If
                    linea &= String.Format("{0,10}", CInt(rTicket.PorcentajeDescuento * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.TotalDtoPP * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.TotalRecargo * 100))
                    linea &= String.Format("{0,10}", CInt(rTicket.Km * 100))

                    'Forma de pago
                    If rTicket.IsForPagNull Then rTicket.ForPag = String.Empty
                    linea &= String.Format("{0,8}", rTicket.ForPag)

                    sw.WriteLine(linea)

                    NumeroLinea = 1

                End If

                linea = String.Empty
                linea &= Format(rTicket.CodigoCaja, "00")
                linea &= Format(rTicket.NumeroTicket, "000000")
                linea &= Format(General.NumeroAlmacen, "00")
                linea &= Format(NumeroLinea, "000")
                linea &= String.Format("{0,15}", rTicket.CodigoArticulo)
                linea &= IIf(rTicket.Promocion, "S", "N")
                linea &= IIf(rTicket.PrecioManual, "S", "N")
                linea &= Format(rTicket.CodigoEmleado, "00")
                linea &= Format(General.NumeroAlmacen, "00")
                linea &= String.Format("{0,24}", Mid(rTicket.DescripcionArticulo, 1, 24))
                linea &= String.Format("{0,10}", CInt(rTicket.UnidadStock * 100))
                linea &= String.Format("{0,10}", CInt(rTicket.Precio * 10000))
                linea &= String.Format("{0,10}", CInt(rTicket.DescuentoLinea * 100))
                linea &= String.Format("{0,10}", CInt(rTicket.Importe * 100))
                linea &= String.Format("{0,10}", 0)
                linea &= String.Format("{0,10}", CInt(rTicket.DtoFidelizacion * 100))
                linea &= String.Format("{0,10}", rTicket.TipoIva * 100)
                linea &= String.Format("{0,10}", 0)
                linea &= String.Format("{0,10}", CInt(Math.Round(rTicket.Cantidad * rTicket.Precio * rTicket.DescuentoLinea, 2, MidpointRounding.AwayFromZero)))

                If Not rTicket.IsPesoNull Then
                    linea &= String.Format("{0,10}", CInt(Math.Round(rTicket.Peso, 3, MidpointRounding.AwayFromZero) * 1000))
                Else
                    linea &= String.Format("{0,10}", 0)
                End If

                sw.WriteLine(linea)

                NumeroLinea += 1

            Next

            'Movimientos de caja
            Dim dsTiendas As New dsTiendas
            Dim rSituacion As dsTiendas.SITUACIONRow

            If Reenviar Then
                dsTiendas.SITUACION.Merge(General.SituacionTiendaFecha(FechaCierre).SITUACION)
            Else
                dsTiendas.SITUACION.Merge(General.SituacionTienda.SITUACION)
            End If

            sw.WriteLine("CAJAS" & Format(FechaCierre, "dd-MM-yyyy"))

            For i = 0 To dsTiendas.SITUACION.Rows.Count - 1

                rSituacion = dsTiendas.SITUACION.Rows(i)

                linea = Format(General.NumeroAlmacen, "00")
                linea &= Format(rSituacion.CodigoCaja, "00")
                linea &= String.Format("{0,10}", CInt(rSituacion.Tickets * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.Lineas * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.Efectivo * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.Talon * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.NumeroAlbaranes * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.Tarjeta * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.ValesCobrados * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.ValesProveedor * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.Envases * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.Venta * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.CobrosCliente * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.PagosProveedor * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.EntradaCambios * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.RetiradaFondos * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.NumeroFacturas * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.PendienteCobro * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.PendienteCredito * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.ValesClienteCanjeados * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.RepartoDomicilio * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.ValesEmitidos * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.AlbaranCredito * 100))
                linea &= String.Format("{0,10}", 0)
                linea &= String.Format("{0,10}", CInt(rSituacion.ImporteFacturas * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.DescuentoPP * 100))
                linea &= String.Format("{0,10}", CInt(rSituacion.RecargoEquivalencia * 100))

                sw.WriteLine(linea)

            Next

            'Cerrar el fichero
            sw.Close()

            Return True

        Catch ex As Exception
            MsgBox("Error al generar el fichero de tickets." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            Return False
        End Try
    End Function
#End Region

#Region "DescargaFicheros"
    Public Shared Function DescargaFicheros(Optional ByVal NombreFichero As String = "", Optional ByVal DireccionEnvio As Boolean = False)
        Try
            General.DatosTiendaActual(CodigoTienda)

            If Comunicaciones_DirectorioFicheros = String.Empty Then
                Comunicaciones_DirectorioFicheros = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV"
            End If

            Dim DirectorioFicheros As String = Comunicaciones_DirectorioFicheros & "\Envio"
            If Not IO.Directory.Exists(DirectorioFicheros) Then IO.Directory.CreateDirectory(DirectorioFicheros)

            Select Case General.Comunicaciones_Tipo

                Case 1 'Manual
                    'Crear carpeta si no existe
                    If Not My.Computer.FileSystem.DirectoryExists(DirectorioFicheros) Then My.Computer.FileSystem.CreateDirectory(DirectorioFicheros)
                    If IO.File.Exists(DirectorioFicheros & "\envio.zip") Then
                        'Descomprimir fichero
                        AGI2005.ICSharpZLib.Descomprimir(DirectorioFicheros, DirectorioFicheros & "\envio.zip", True, False)
                    End If

                Case 2 'FTP

                    Dim ConexionFTP As New Ftp(General.Comunicaciones_Direccion, General.Comunicaciones_Usuario, General.Comunicaciones_Password)

                    'Crear carpeta si no existe
                    If Not My.Computer.FileSystem.DirectoryExists(Comunicaciones_DirectorioFicheros) Then My.Computer.FileSystem.CreateDirectory(Comunicaciones_DirectorioFicheros)

                    If NombreFichero <> String.Empty Then

                        'If Not DireccionEnvio Then
                        '    If IO.File.Exists(Comunicaciones_DirectorioFicheros & "/" & NombreFichero) Then IO.File.Delete(Comunicaciones_DirectorioFicheros & "/" & NombreFichero)
                        '    My.Computer.Network.DownloadFile("http://app.aydara.com/araestetic/AydaraTPV/recibo", Comunicaciones_DirectorioFicheros & "\" & NombreFichero)
                        'End If

                        'DESCARGAR FICHERO
                        '-----------------
                        If DireccionEnvio Then
                            'If ConexionFTP.ExisteObjeto(General.Comunicaciones_Direccion & "/" & NombreFichero) Then
                            My.Computer.Network.DownloadFile(General.Comunicaciones_Direccion & "/" & NombreFichero, Comunicaciones_DirectorioFicheros & "\" & NombreFichero, General.Comunicaciones_Usuario, General.Comunicaciones_Password, True, 100000, True)
                            'End If
                        Else
                            'If ConexionFTP.ExisteObjeto(General.Comunicaciones_Envio & "/" & NombreFichero) Then
                            My.Computer.Network.DownloadFile(General.Comunicaciones_Envio & "/" & NombreFichero, Comunicaciones_DirectorioFicheros & "\" & NombreFichero, General.Comunicaciones_Usuario, General.Comunicaciones_Password, True, 100000, True)
                            'End If
                        End If

                    Else

                        'DESCARGAR TODOS FICHEROS
                        '------------------------

                        'Descargar fichero envio.zip si existe
                        ' If ConexionFTP.ExisteObjeto(General.Comunicaciones_Direccion & "/envio.zip") Then

                        If IO.File.Exists(Comunicaciones_DirectorioFicheros & "\envio.zip") Then IO.File.Delete(Comunicaciones_DirectorioFicheros & "\envio.zip")
                        'My.Computer.Network.DownloadFile(General.Comunicaciones_Direccion & "/envio.zip", Comunicaciones_DirectorioFicheros & "\envio.zip", General.Comunicaciones_Usuario, General.Comunicaciones_Password, True, 100000, True)
                        'My.Computer.Network.DownloadFile("http://app.aydara.com/araestetic/AydaraTPV/envio/envio.zip", Comunicaciones_DirectorioFicheros & "\envio.zip")

                        'Descomprimir fichero
                        'AGI2005.ICSharpZLib.Descomprimir(DirectorioFicheros, Comunicaciones_DirectorioFicheros & "\envio.zip", True, False)

                        'End If

                        '' Get the object used to communicate with the server.
                        'Dim request As FtpWebRequest = CType(WebRequest.Create(General.Comunicaciones_Direccion & "/envio.zip"), FtpWebRequest)
                        'request.Method = WebRequestMethods.Ftp.DownloadFile
                        '' This example assumes the FTP site uses anonymous logon.
                        'request.Credentials = New NetworkCredential(General.Comunicaciones_Usuario, General.Comunicaciones_Password)
                        'Dim response As FtpWebResponse = CType(request.GetResponse(), FtpWebResponse)
                        'Dim responseStream As Stream = response.GetResponseStream()
                        'Dim reader As StreamReader = New StreamReader(responseStream)
                        'reader.ReadToEnd()
                        'reader.Close()
                        'response.Close()

                        'Descarga fichero FTP
                        Dim downloadRequest As FtpWebRequest = WebRequest.Create(General.Comunicaciones_Direccion & "/envio.zip")
                        downloadRequest.Method = WebRequestMethods.Ftp.DownloadFile
                        downloadRequest.Credentials = New NetworkCredential(General.Comunicaciones_Usuario, General.Comunicaciones_Password)
                        Using downloadResponse As FtpWebResponse = downloadRequest.GetResponse(),
                              sourceStream As Stream = downloadResponse.GetResponseStream(),
                              targetStream As Stream = File.Create(Comunicaciones_DirectorioFicheros & "\envio.zip")
                            Dim buffer As Byte() = New Byte(10240 - 1) {}
                            Dim read As Integer
                            Do
                                read = sourceStream.Read(buffer, 0, buffer.Length)
                                If read > 0 Then
                                    targetStream.Write(buffer, 0, read)
                                End If
                            Loop While read > 0
                        End Using

                        'Descomprimir fichero
                        AGI2005.ICSharpZLib.Descomprimir(DirectorioFicheros, Comunicaciones_DirectorioFicheros & "\envio.zip", True, False)

                    End If

                Case 3 'Mail
                    If NombreFichero <> String.Empty Then Mail.ConectarSesion()

            End Select

            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return False
        End Try
    End Function
#End Region

#Region "DescargaFicherosTerminales"
    Public Shared Function DescargaFicherosTerminales(ByVal Tipo As TipoFicheroTerminal)
        Try

            General.DatosTiendaActual(CodigoTienda)

            Select Case General.Comunicaciones_Tipo

                Case 2 'FTP

                    Dim ConexionFTP As New Ftp(General.Comunicaciones_Terminales, General.Comunicaciones_Usuario, General.Comunicaciones_Password)

                    'Crear carpeta si no existe
                    If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV") Then My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV")

                    'Crear carpeta si no existe
                    If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(General.CodigoTienda, "00")) Then My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(General.CodigoTienda, "00"))

                    'Descargar ficheros de terminales
                    Select Case Tipo
                        Case TipoFicheroTerminal.Etiquetas
                            ConexionFTP.DameFicherosTerminal("TERETI")
                        Case TipoFicheroTerminal.Inventario
                            ConexionFTP.DameFicherosTerminal("TERINV")
                        Case TipoFicheroTerminal.Pedido
                            ConexionFTP.DameFicherosTerminal("TERPED")
                    End Select

            End Select

            Return True

        Catch ex As Exception
            Return False
        Finally

        End Try
    End Function
#End Region

#Region "Envio"
    Public Shared Function Envio(Optional ByVal NombreFichero As String = "")
        Try
            Dim i As Integer

            Dim tFiles() As String
            tFiles = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio")

            General.DatosTiendaActual(CodigoTienda)

            Select Case General.Comunicaciones_Tipo

                Case 1 'Copia local

                    If Not Directory.Exists(General.Comunicaciones_DirectorioFicheros & "\Recibo") Then
                        Directory.CreateDirectory(General.Comunicaciones_DirectorioFicheros & "\Recibo")
                    End If

                    For i = 0 To tFiles.Length - 1
                        NombreFichero = Mid(tFiles(i), Len(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio\") + 1)
                        IO.File.Copy(tFiles(i), General.Comunicaciones_DirectorioFicheros & "\Recibo\" & LCase(NombreFichero), True)
                        If IO.File.Exists(General.Comunicaciones_DirectorioFicheros & "\Recibo\" & LCase(NombreFichero)) Then IO.File.Delete(tFiles(i))
                    Next

                Case 2 'FTP

                    Dim ConexionFTP As New Ftp(General.Comunicaciones_Direccion, General.Comunicaciones_Usuario, General.Comunicaciones_Password)

                    If NombreFichero <> String.Empty Then

                        'ENVIAR FICHERO
                        '--------------
                        If ConexionFTP.SubirFichero(tFiles(i), General.Comunicaciones_Envio & "\" & LCase(NombreFichero), General.Comunicaciones_Envio) Then
                            IO.File.Delete(tFiles(i))
                        End If

                    Else

                        'ENVIAR TODOS FICHEROS
                        '---------------------
                        For i = 0 To tFiles.Length - 1
                            NombreFichero = Mid(tFiles(i), Len(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio\") + 1)
                            'If NombreFichero = "TRASPASO.SEQ" Then NombreFichero = "TRAS" & Format(General.NumeroAlmacen, "00") & Format(Date.Today.Day, "00") & ".SEQ"
                            If ConexionFTP.SubirFichero(tFiles(i), General.Comunicaciones_Envio & "\" & LCase(NombreFichero), General.Comunicaciones_Envio) Then
                                IO.File.Delete(tFiles(i))
                            End If
                        Next

                    End If

                Case 3 'Mail

            End Select

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "EnvioDatosTerminal"
    Public Shared Function EnvioDatosTerminal(ByVal RutaFichero As String, ByVal NombreFichero As String)
        Try

            General.DatosTiendaActual(CodigoTienda)

            Select Case General.Comunicaciones_Tipo

                Case 2 'FTP

                    Dim ConexionFTP As New Ftp(General.Comunicaciones_Direccion, General.Comunicaciones_Usuario, General.Comunicaciones_Password)

                    'ENVIAR FICHERO
                    '--------------
                    If ConexionFTP.SubirFichero(RutaFichero, General.Comunicaciones_Terminales & "\" & NombreFichero, General.Comunicaciones_Terminales) Then
                        IO.File.Delete(RutaFichero)
                    End If

            End Select

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

#Region "DatosBascula"
    Public Shared Function DatosBascula(ByVal Precio As Decimal) As Decimal

        Dim bascula As New CommManager()
        Dim Cadena As String, CheckSum As String
        Dim intentos_validacion As Integer = My.Settings.TiempoEsperaBascula

        Dim aviso As DevExpress.XtraEditors.LabelControl = Nothing

        Try
            Cadena = Conversion.Hex(Asc("9")) : CheckSum = Asc("9")
            Cadena &= Conversion.Hex(Asc("8")) : CheckSum = CheckSum Xor Asc("8")
            Cadena &= Conversion.Hex(Asc(Format(Precio * 100, "00000").Substring(0, 1))) : CheckSum = CheckSum Xor Asc(Format(Precio * 100, "00000").Substring(0, 1))
            Cadena &= Conversion.Hex(Asc(Format(Precio * 100, "00000").Substring(1, 1))) : CheckSum = CheckSum Xor Asc(Format(Precio * 100, "00000").Substring(1, 1))
            Cadena &= Conversion.Hex(Asc(Format(Precio * 100, "00000").Substring(2, 1))) : CheckSum = CheckSum Xor Asc(Format(Precio * 100, "00000").Substring(2, 1))
            Cadena &= Conversion.Hex(Asc(Format(Precio * 100, "00000").Substring(3, 1))) : CheckSum = CheckSum Xor Asc(Format(Precio * 100, "00000").Substring(3, 1))
            Cadena &= Conversion.Hex(Asc(Format(Precio * 100, "00000").Substring(4, 1))) : CheckSum = CheckSum Xor Asc(Format(Precio * 100, "00000").Substring(4, 1))
            Cadena &= Conversion.Hex(CheckSum)
            Cadena &= "0D0A" 'Retorno carro + Nueva línea

            bascula.PortName = My.Settings.PuertoBascula
            bascula.CurrentTransmissionType = CommManager.TransmissionType.Hex

            bascula.OpenPort()

            bascula.Message = Cadena
            bascula.Type = CommManager.MessageType.Normal

EnviarDatos:
            bascula.WriteData(Cadena)

            Dim intentos_conexion As Integer = 10
            While intentos_conexion > 0
                If bascula.DisplayValue = String.Empty Then
                    System.Threading.Thread.Sleep(100)
                    intentos_conexion -= 1
                Else
                    Exit While
                End If
            End While
            If bascula.DisplayValue = String.Empty Then
                If (MsgBox("No hay comunicación con la báscula." & vbCrLf & "¿Desea reintentar la operación?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                    intentos_validacion = My.Settings.TiempoEsperaBascula
                    GoTo EnviarDatos
                Else
                    Return 0
                End If
            End If

            'If intentos_validacion = 50 Then MsgBox("ARTÍCULO DE PESO", MsgBoxStyle.Information)
            If intentos_validacion = My.Settings.TiempoEsperaBascula - 2 Then
                If Not aviso Is Nothing Then aviso.Dispose()
                aviso = General.AvisoPantalla(TPV_Tactil, "ESPERANDO PESO", 120, 480)
            End If

            If bascula.DisplayValue <> String.Empty Then
                'Comprobar que no devuelve error
                If bascula.DisplayValue.Substring(7, 1) = "1" Or bascula.DisplayValue.Substring(27, 1) = "1" Or bascula.DisplayValue.Substring(9, 14) = "30 30 30 30 30" Then
                    While intentos_validacion > 0
                        System.Threading.Thread.Sleep(100)
                        intentos_validacion -= 1
                        GoTo EnviarDatos
                    End While
                End If
            End If
            If bascula.DisplayValue.Substring(7, 1) = "1" Or bascula.DisplayValue.Substring(27, 1) = "1" Or bascula.DisplayValue.Substring(9, 14) = "30 30 30 30 30" Then
                If (MsgBox("Peso incorrecto." & vbCrLf & "¿Desea reintentar la operación?", MsgBoxStyle.Information + MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                    intentos_validacion = My.Settings.TiempoEsperaBascula
                    GoTo EnviarDatos
                Else
                    Return 0
                End If
            End If

            Dim datos() As String
            datos = Split(bascula.DisplayValue, Environment.NewLine)

            Dim hex As String
            hex = Replace(datos(0), " ", "")

            Dim dec As Long
            Dim hexpart As String
            Dim peso As String = String.Empty
            For x As Integer = 1 To (hex.Length / 2)
                hexpart = hex.Substring((x * 2) - 2, 2)
                dec = Int32.Parse(hexpart, System.Globalization.NumberStyles.HexNumber)
                peso &= Chr(dec)
            Next

            If IsNumeric(peso) Then
                Return CType(peso.Substring(3), Decimal) / 1000
            Else
                Return 0
            End If

        Catch ex As Exception
            MsgBox("Error al obtener datos de la báscula", MsgBoxStyle.Exclamation)
            Return 0
        Finally
            bascula.ClosePort()
            If Not aviso Is Nothing Then aviso.Dispose()
        End Try
    End Function
#End Region

#Region "ExportarImagenes"
    Public Shared Function ExportarImagenes(ByVal arrayTiendas As ArrayList)

        Dim dsImagenes As New dsComunicaciones
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            cmd.Connection.Open()

            'Familias de artículos
            cmd.CommandText = "SELECT Id, Codigo, Etiqueta, TpvTactil, Imagen FROM FAMILIASARTICULOS WHERE TpvTactil=1"

            dsImagenes.ARTICULOS_IMAGENES.Load(cmd.ExecuteReader)

            dsImagenes.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Imagenes_Familias.xml")

            dsImagenes.ARTICULOS_IMAGENES.Clear()

            'Artículos
            cmd.CommandText = "SELECT Id, Codigo, Etiqueta, TpvTactil, Imagen FROM ARTICULOS WHERE TpvTactil=1"

            dsImagenes.ARTICULOS_IMAGENES.Load(cmd.ExecuteReader)

            cmd.Connection.Close()

            dsImagenes.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Imagenes_Articulos.xml")

            General.DatosTiendaActual(CodigoTienda)

            Select Case General.Comunicaciones_Tipo

                Case 2 'FTP

                    Dim ConexionFTP As New Ftp(General.Comunicaciones_Direccion, General.Comunicaciones_Usuario, General.Comunicaciones_Password)

                    For i As Integer = 0 To arrayTiendas.Count - 1
                        If ConexionFTP.SubirFichero(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Imagenes" & arrayTiendas.Item(i) & ".SEQ", General.Comunicaciones_Direccion & "/Imagenes" & arrayTiendas.Item(i) & ".SEQ", General.Comunicaciones_Direccion) Then
                            IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Imagenes" & arrayTiendas.Item(i) & ".SEQ")
                        End If
                    Next

                    If ConexionFTP.SubirFichero(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Imagenes_Familias.xml", General.Comunicaciones_Direccion & "/Imagenes_Familias.xml", General.Comunicaciones_Direccion) Then
                        IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Imagenes_Familias.xml")
                    End If
                    If ConexionFTP.SubirFichero(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Imagenes_Articulos.xml", General.Comunicaciones_Direccion & "/Imagenes_Articulos.xml", General.Comunicaciones_Direccion) Then
                        IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Imagenes_Articulos.xml")
                    End If

                Case 3 'Mail

            End Select

            Return True

        Catch ex As Exception
            Return False
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Function
#End Region

#Region "ImportarImagenes"
    Public Shared Function ImportarImagenes()

        Dim dsImagenes As New dsComunicaciones, dsArticulos As New dsArticulos
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            General.DatosTiendaActual(CodigoTienda)

            Select Case General.Comunicaciones_Tipo

                Case 2 'FTP

                    Dim ConexionFTP As New Ftp(General.Comunicaciones_Direccion, General.Comunicaciones_Usuario, General.Comunicaciones_Password)

                    'Crear carpeta si no existe
                    If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV") Then My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV")

                    ''Descargar fichero envio.zip si existe
                    'If ConexionFTP.ExisteObjeto(General.Comunicaciones_Direccion & "/Imagenes" & Format(General.NumeroAlmacen, "00") & ".SEQ") Then
                    '    If ConexionFTP.ExisteObjeto(General.Comunicaciones_Direccion & "/Imagenes_Familias.xml") Then
                    '        My.Computer.Network.DownloadFile(General.Comunicaciones_Direccion & "/Imagenes_Familias.xml", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Imagenes_Familias.xml", General.Comunicaciones_Usuario, General.Comunicaciones_Password, True, 100000, True)
                    '    End If
                    '    If ConexionFTP.ExisteObjeto(General.Comunicaciones_Direccion & "/Imagenes_Articulos.xml") Then
                    '        My.Computer.Network.DownloadFile(General.Comunicaciones_Direccion & "/Imagenes_Articulos.xml", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Imagenes_Articulos.xml", General.Comunicaciones_Usuario, General.Comunicaciones_Password, True, 100000, True)
                    '    End If
                    'Else
                    '    Return False
                    '    Exit Try
                    'End If

                Case 3 'Mail
                    Mail.ConectarSesion()

            End Select

            'Familias de artículos
            dsImagenes.ReadXml(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Imagenes_Familias.xml")

            If dsImagenes.ARTICULOS_IMAGENES.Count > 0 Then

                cmd.Connection.Open()

                'Quitar imagen a todas familias de artículos
                cmd.CommandText = "UPDATE FAMILIASARTICULOS SET TpvTactil=0"
                cmd.ExecuteNonQuery()

                For i As Integer = 0 To dsImagenes.ARTICULOS_IMAGENES.Count - 1

                    cmd.CommandText = "SELECT * FROM FAMILIASARTICULOS WHERE Codigo='" & dsImagenes.ARTICULOS_IMAGENES(i).Codigo & "'"

                    dsArticulos.FAMILIASARTICULOS.Clear()
                    dsArticulos.FAMILIASARTICULOS.Load(cmd.ExecuteReader)

                    If dsArticulos.FAMILIASARTICULOS.Count >= 0 Then
                        If dsImagenes.ARTICULOS_IMAGENES(i).IsImagenNull Then dsArticulos.FAMILIASARTICULOS(0).SetImagenNull() Else dsArticulos.FAMILIASARTICULOS(0).Imagen = dsImagenes.ARTICULOS_IMAGENES(i).Imagen
                        dsArticulos.FAMILIASARTICULOS(0).Etiqueta = dsImagenes.ARTICULOS_IMAGENES(i).Etiqueta
                        dsArticulos.FAMILIASARTICULOS(0).TpvTactil = dsImagenes.ARTICULOS_IMAGENES(i).TpvTactil
                    End If

                    Dim taArticulos As New dsArticulosTableAdapters.FAMILIASARTICULOSTableAdapter
                    taArticulos.Update(dsArticulos.FAMILIASARTICULOS)

                Next

                cmd.Connection.Close()

            End If

            dsImagenes.ARTICULOS_IMAGENES.Clear()

            'Artículos
            dsImagenes.ReadXml(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Imagenes_Articulos.xml")

            If dsImagenes.ARTICULOS_IMAGENES.Count > 0 Then

                cmd.Connection.Open()

                'Desmarcar TpvTactil a todos artículos
                cmd.CommandText = "UPDATE Articulos SET TpvTactil=0"
                cmd.ExecuteNonQuery()

                For i As Integer = 0 To dsImagenes.ARTICULOS_IMAGENES.Count - 1

                    cmd.CommandText = "SELECT * FROM ARTICULOS WHERE Codigo='" & dsImagenes.ARTICULOS_IMAGENES(i).Codigo & "'"

                    dsArticulos.ARTICULOS.Clear()
                    dsArticulos.ARTICULOS.Load(cmd.ExecuteReader)

                    If dsArticulos.ARTICULOS.Count >= 0 Then
                        If dsImagenes.ARTICULOS_IMAGENES(i).IsImagenNull Then dsArticulos.FAMILIASARTICULOS(0).SetImagenNull() Else dsArticulos.ARTICULOS(0).Imagen = dsImagenes.ARTICULOS_IMAGENES(i).Imagen
                        dsArticulos.ARTICULOS(0).Etiqueta = dsImagenes.ARTICULOS_IMAGENES(i).Etiqueta
                        dsArticulos.ARTICULOS(0).TpvTactil = dsImagenes.ARTICULOS_IMAGENES(i).TpvTactil
                    End If

                    Dim taArticulos As New dsArticulosTableAdapters.ARTICULOSTableAdapter
                    taArticulos.Update(dsArticulos.ARTICULOS)

                Next

                cmd.Connection.Close()

            End If

            Return True

        Catch ex As Exception
            Return False
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Function
#End Region

#Region "ExportarPromociones"
    Public Shared Function ExportarPromociones()

        Dim dsPromociones As New dsComunicaciones
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            cmd.Connection.Open()

            'Promociones especiales
            cmd.CommandText = "SELECT * FROM PROMOCIONES WHERE CodigoTienda = " & General.CodigoTienda & " AND FechaFinal>='" & Date.Now & "' AND CodigoArticuloRegalo<>''"

            dsPromociones.COMUNICACIONES_PROMOCIONES.Load(cmd.ExecuteReader)

            cmd.Connection.Close()

            dsPromociones.WriteXml(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Promociones.xml")

            General.DatosTiendaActual(CodigoTienda)

            Select Case General.Comunicaciones_Tipo

                Case 2 'FTP

                    Dim ConexionFTP As New Ftp(General.Comunicaciones_Direccion, General.Comunicaciones_Usuario, General.Comunicaciones_Password)

                    If ConexionFTP.SubirFichero(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Promociones.xml", General.Comunicaciones_Direccion & "/Promociones.xml", General.Comunicaciones_Direccion) Then
                        IO.File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Promociones.xml")
                    End If

                Case 3 'Mail

            End Select

            Return True

        Catch ex As Exception
            Return False
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Function
#End Region

#Region "ImportarPromociones"
    Public Shared Function ImportarPromociones()

        Dim dsComunicaciones As New dsComunicaciones
        Dim taPromociones As New dsComunicacionesTableAdapters.COMUNICACIONES_PROMOCIONESTableAdapter

        Try
            'Select Case General.Comunicaciones_Tipo

            '    Case 2 'FTP

            '        Dim ConexionFTP As New Ftp(General.Comunicaciones_Direccion, General.Comunicaciones_Usuario, General.Comunicaciones_Password)

            '        'Crear carpeta si no existe
            '        If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(General.CodigoTienda, "00")) Then My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(General.CodigoTienda, "00"))

            '        'Descargar fichero Promociones.xml si existe
            '        If ConexionFTP.ExisteObjeto(General.Comunicaciones_Direccion & "/Promociones.xml") Then
            '            My.Computer.Network.DownloadFile(General.Comunicaciones_Direccion & "/Promociones.xml", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(General.CodigoTienda, "00") & "\Promociones.xml", General.Comunicaciones_Usuario, General.Comunicaciones_Password, True, 100000, True)
            '        End If

            '    Case 3 'Mail
            '        Mail.ConectarSesion()

            'End Select

            If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(General.CodigoTienda, "00") & "\Promociones.xml") Then
                'Inserta promociones
                dsComunicaciones.ReadXml(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(General.CodigoTienda, "00") & "\Promociones.xml")
                taPromociones.Update(dsComunicaciones.COMUNICACIONES_PROMOCIONES)
            Else
                Return False
            End If

            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function
#End Region

#Region "ImportarTarifas"
    Public Shared Function ImportarTarifas()

        Dim dsComunicaciones As New dsComunicaciones

        Dim dtArticulos As New dsArticulos.ARTICULOSDataTable
        Dim taArticulos As New dsArticulosTableAdapters.ARTICULOSTableAdapter
        Dim rArticulos As dsArticulos.ARTICULOSRow

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(General.CodigoTienda, "00") & "\Tarifas.xml") Then

                dsComunicaciones.ReadXml(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(General.CodigoTienda, "00") & "\Tarifas.xml")

                For i As Integer = 0 To dsComunicaciones.COMUNICACIONES_TARIFAS.Count - 1
                    If Not dsComunicaciones.COMUNICACIONES_TARIFAS(i).IsPrecioNull Then

                        'Actualizar precio de venta y existencia
                        If Not dsComunicaciones.COMUNICACIONES_TARIFAS(i).IsPrecioNull Then
                            If dsComunicaciones.COMUNICACIONES_TARIFAS(i).Precio <> 0 Then Almacen.ActualizaPrecio(Format(dsComunicaciones.COMUNICACIONES_TARIFAS(i).CodigoArticulo, "0000000"), 1, 0, dsComunicaciones.COMUNICACIONES_TARIFAS(i).Precio)
                        End If

                        If Not dsComunicaciones.COMUNICACIONES_TARIFAS(i).IsExistenciaNull Then
                            If dsComunicaciones.COMUNICACIONES_TARIFAS(i).Existencia <> 0 Then Almacen.ActualizaStock(Format(dsComunicaciones.COMUNICACIONES_TARIFAS(i).CodigoArticulo, "0000000"), 1, 0, dsComunicaciones.COMUNICACIONES_TARIFAS(i).Existencia)
                        End If

                        'Actualizar precio de costo y quitar control de baja
                        cmd.CommandText = "SELECT * FROM Articulos WHERE Codigo='" & Format(dsComunicaciones.COMUNICACIONES_TARIFAS(i).CodigoArticulo, "0000000") & "'"
                        dtArticulos.Load(CType(cmd.ExecuteReader, SqlClient.SqlDataReader))
                        If dtArticulos.Rows.Count > 0 Then
                            rArticulos = dtArticulos.Rows(0)
                            If Not dsComunicaciones.COMUNICACIONES_TARIFAS(i).IsPrecioCostoNull Then
                                If dsComunicaciones.COMUNICACIONES_TARIFAS(i).PrecioCosto <> 0 Then rArticulos.PrecioCoste = dsComunicaciones.COMUNICACIONES_TARIFAS(i).PrecioCosto
                            End If
                            rArticulos.ControlBaja = False
                            taArticulos.Update(dtArticulos)
                        End If

                    End If
                Next

            Else
                Return False
            End If

            Return True

        Catch ex As Exception
            Return False
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Function
#End Region

#Region "ImportarArticulos"
    Public Shared Function ImportarArticulos()

        Dim dsArticulos As New dsArticulos

        Dim taArticulos As New dsArticulosTableAdapters.ARTICULOSTableAdapter
        Dim rArticulos As dsArticulos.ARTICULOSRow

        Dim taCodigoBarras As New dsArticulosTableAdapters.CODIGO_BARRASTableAdapter
        Dim rCodigoBarras As dsArticulos.CODIGO_BARRASRow

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Dim numlinea As Integer

        Try
            If IO.File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(General.CodigoTienda, "00") & "\Articulos.txt") Then

                Dim sr As New IO.StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(General.CodigoTienda, "00") & "\Articulos.txt")

                While Not sr.EndOfStream

                    numlinea += 1

                    Dim linea() As String = Split(sr.ReadLine, vbTab)

                    If linea(0) = String.Empty Then Continue While

                    'Comprobar que no exista código de barras
                    cmd.CommandText = "SELECT COUNT(*) FROM CODIGO_BARRAS WHERE CodigoBarras = '" & linea(1) & "'"
                    If cmd.ExecuteScalar > 0 Then Continue While
                    If dsArticulos.CODIGO_BARRAS.Select("CodigoBarras = '" & linea(1) & "'").Length > 0 Then Continue While

                    rArticulos = dsArticulos.ARTICULOS.NewARTICULOSRow

                    With rArticulos
                        .Codigo = linea(0)
                        .Descripcion = linea(2)
                        .PrecioCoste = linea(3)
                        .Precio = linea(4)
                        'Familia
                        cmd.CommandText = "SELECT Id FROM FAMILIASARTICULOS WHERE Codigo = '" & Format(CInt(linea(5)), "000") & "'"
                        .CodigoFamilia = cmd.ExecuteScalar
                        'Subfamilia
                        cmd.CommandText = "SELECT Id FROM SUBFAMILIASARTICULOS WHERE Familia_Id = " & .CodigoFamilia & " AND Codigo = '" & Format(CInt(linea(6)), "000") & "'"
                        .CodigoSubfamilia = cmd.ExecuteScalar
                    End With

                    dsArticulos.ARTICULOS.AddARTICULOSRow(rArticulos)

                    'Añadir código de barras
                    rCodigoBarras = dsArticulos.CODIGO_BARRAS.NewCODIGO_BARRASRow
                    rCodigoBarras.DescripcionColor = rArticulos.Codigo
                    rCodigoBarras.CodigoBarras = linea(1)
                    dsArticulos.CODIGO_BARRAS.AddCODIGO_BARRASRow(rCodigoBarras)

                End While

                taArticulos.Update(dsArticulos.ARTICULOS)

                'Indicar Id de artículo en códigos de barras
                For i As Integer = 0 To dsArticulos.CODIGO_BARRAS.Count - 1
                    cmd.CommandText = "SELECT Id FROM ARTICULOS WHERE Codigo = '" & dsArticulos.CODIGO_BARRAS(i).DescripcionColor & "'"
                    dsArticulos.CODIGO_BARRAS(i).Articulo_Id = cmd.ExecuteScalar
                Next
                taCodigoBarras.Update(dsArticulos.CODIGO_BARRAS)

            Else
                Return False
            End If

            Return True

        Catch ex As Exception
            MsgBox("Error línea " & numlinea & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            Return False
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Function
#End Region

End Class
