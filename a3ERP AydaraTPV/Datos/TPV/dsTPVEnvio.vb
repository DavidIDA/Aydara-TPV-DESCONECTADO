Partial Class dsTPVEnvio

    Partial Class ALTERNADataTable

    End Class

    Dim FTP As New Ftp()

    Dim DirectorioFicheros As String = Aydara.SentenciaSQL("SELECT DIRECTORIO FROM IDA_AYDARATPV")
    Dim LOG As New dsTPVLog

#Region "Enviar"
    Public Sub Enviar()

        Dim configActual As Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture

        Try
            Aydara.Estado("Comprobando directorio de comunicación", "Comunicación tiendas")

            'Comprobar directorio de ficheros
            If Me.DirectorioFicheros = String.Empty Then
                MsgBox("Seleccione un directorio para los ficheros en la configuración")
                Exit Try
            End If

            Me.DirectorioFicheros &= "\Envio"
            If Not IO.Directory.Exists(Me.DirectorioFicheros) Then
                IO.Directory.CreateDirectory(Me.DirectorioFicheros)
            End If

            'Configuración punto decimal
            Dim r As New Globalization.CultureInfo("es-ES")
            r.NumberFormat.CurrencyDecimalSeparator = ","
            r.NumberFormat.NumberDecimalSeparator = ","
            System.Threading.Thread.CurrentThread.CurrentCulture = r

            Me.ExportarArticulos()
            Me.ExportarCodigosDeBarras()
            Me.ExportarInventario()
            Me.ExportarClientes()
            'Me.ExportarFormasPago()
            'Me.ExportarTarifas()

            'Comprimir ficheros
            Dim folder As New IO.DirectoryInfo(Me.DirectorioFicheros)
            Dim DirectorioZIP As String = Me.DirectorioFicheros & "\envio.zip"

            If IO.File.Exists(DirectorioZIP) Then IO.File.Delete(DirectorioZIP)

            a3ERP.fWaitForm.SetCaption("Comprimiendo ficheros")
            LOG.Nuevo("E", "Comprimiendo ficheros")
            AGI2005.ICSharpZLib.Comprimir(IO.Directory.GetFiles(Me.DirectorioFicheros), DirectorioZIP, False)

            'FTP
            If FTP.host <> String.Empty Then

                For Each file As IO.FileInfo In folder.GetFiles()

                    If LCase(file.Extension) <> ".zip" Then Continue For

                    a3ERP.fWaitForm.SetCaption("Subiendo fichero " & file.Name)
                    LOG.Nuevo("E", "Subiendo fichero " & file.Name)

                    Dim msgError As String = FTP.SubirFicheroEntradasAlmacen(file.FullName, file.Name)

                    If msgError = String.Empty Then
                        IO.File.Delete(file.FullName)
                    Else
                        LOG.Nuevo("X", "Error al subir fichero " & file.Name & ". " & msgError)
                    End If

                Next

                'Eliminar ficheros
                For Each file As IO.FileInfo In folder.GetFiles()
                    If IO.File.Exists(file.FullName) Then IO.File.Delete(file.FullName)
                Next

            End If

        Catch ex As Exception
            LOG.Nuevo("X", "Error al enviar ficheros. " & ex.Message)
            Throw ex
        Finally
            System.Threading.Thread.CurrentThread.CurrentCulture = configActual
            Aydara.Estado()
        End Try
    End Sub
#End Region

#Region "ExportarArticulos"
    Private Sub ExportarArticulos()

        a3ERP.fWaitForm.SetCaption("Exportando fichero de artículos")
        LOG.Nuevo("E", "Exportando fichero de artículos")

        Dim sr As New IO.StreamWriter(Me.DirectorioFicheros & "\ARTICULO.SEQ", False, System.Text.Encoding.Default)
        Dim taArticulos As New dsTPVEnvioTableAdapters.ARTICULOTableAdapter

        Try
            taArticulos.Fill(Me.ARTICULO, "", "1", "2", "3")

            For i As Integer = 0 To Me.ARTICULO.Count - 1
                With Me.ARTICULO(i)

                    Try

                        If .CODART = a3ERP.DatosConfig.CODARTBLAN Then Continue For

                        Dim Linea As New System.Text.StringBuilder

                        'Código artículo
                        Linea.AppendFormat(.CODART.Trim)
                        Linea.Append(vbTab)

                        'Descripción
                        Linea.Append(Mid(.DESCART, 1, 150))
                        Linea.Append(vbTab)

                        'Tipo IVA
                        Linea.Append(.TIPOIVA)
                        Linea.Append(vbTab)

                        'Familia y subfamilia
                        Dim Familia As String = String.Empty
                        If Not .IsCODFAMESTNull Then Familia = Trim(.CODFAMEST)
                        If IsNumeric(Familia) And Len(Familia) >= 3 And Len(Familia) <= 6 Then

                            Linea.Append(Mid(Familia, 1, 3))

                            Linea.Append(vbTab)

                            If Len(Familia) = 6 Then
                                Linea.Append(Mid(Familia, 4, 3))
                            Else
                                Linea.Append("001")
                            End If

                        Else
                            Linea.Append("001")
                            Linea.Append(vbTab)
                            Linea.Append("001")
                        End If

                        Linea.Append(vbTab)

                        'Proveedor
                        Linea.AppendFormat("{0:00000}", 1)
                        Linea.Append(vbTab)

                        'Código envase
                        Dim Envase As String = String.Empty
                        If Not .IsCODENVASENull Then Envase = Trim(.CODENVASE)
                        'If IsNumeric(Envase) And Len(Envase) <= 7 Then
                        '    Linea.AppendFormat("{0:0000000}", CInt(Envase))
                        'Else
                        '    Linea.AppendFormat(" ")
                        'End If
                        Linea.AppendFormat(" ")

                        Linea.Append(vbTab)

                        'Control etiquetas
                        Linea.Append(IIf(.CONTROLETIQUETAS = "T", "S", "N"))
                        Linea.Append(vbTab)

                        'Cantidad variable
                        Linea.Append(IIf(.CANTIDADVARIABLE = "T", "S", "N"))
                        Linea.Append(vbTab)

                        'Artículo de peso
                        Linea.Append(IIf(.ARTICULOPESO = "T", "S", "N"))
                        Linea.Append(vbTab)

                        'Control de baja
                        Linea.Append(IIf(.BLOQUEADO = "T" Or .OBSOLETO = "T", "S", "N"))
                        Linea.Append(vbTab)

                        'Tipo de unidad
                        If .TIPOUNIDAD <> String.Empty Then
                            Linea.Append(Mid(.TIPOUNIDAD, 1, 1))
                        Else
                            Linea.Append(" ")
                        End If
                        Linea.Append(vbTab)

                        'Unidades/caja
                        Linea.Append(.UNIPAQV)
                        Linea.Append(vbTab)

                        'Mínimo venta
                        Linea.Append(1)
                        Linea.Append(vbTab)

                        'Mínimo compra
                        Linea.Append(1)
                        Linea.Append(vbTab)

                        'Peso
                        Linea.Append(.PESO)
                        Linea.Append(vbTab)

                        'Descuento
                        Linea.Append(0)
                        Linea.Append(vbTab)

                        'Precio coste
                        Dim TarifaCoste As Double = 0
                        If Not .IsTARIFA_COSTENull Then TarifaCoste = Math.Round(.TARIFA_COSTE, 3, MidpointRounding.AwayFromZero)
                        Linea.Append(TarifaCoste)
                        Linea.Append(vbTab)

                        'Tarifa 1
                        Dim Tarifa1 As Double = Math.Round(.PRCVENTA, 2, MidpointRounding.AwayFromZero)
                        'If Not .IsTARIFA_1Null Then Tarifa1 = Math.Round(.PRCVENTA, 2, MidpointRounding.AwayFromZero)
                        Linea.Append(Tarifa1)
                        Linea.Append(vbTab)

                        'Tarifa 2
                        Dim Tarifa2 As Double = 0
                        If Not .IsTARIFA_2Null Then Tarifa2 = Math.Round(.TARIFA_2, 2, MidpointRounding.AwayFromZero)
                        If Tarifa2 = 0 Then Tarifa2 = Tarifa1
                        Linea.Append(Tarifa2)
                        Linea.Append(vbTab)

                        'Tarifa 3
                        Dim Tarifa3 As Double = 0
                        If Not .IsTARIFA_3Null Then Tarifa3 = Math.Round(.TARIFA_3, 2, MidpointRounding.AwayFromZero)
                        Linea.Append(Tarifa3)
                        Linea.Append(vbTab)

                        'Tipo de artículo
                        If .ARTICULODIRECTO = "T" Then
                            Linea.Append("5")
                        ElseIf .ARTICULOSECCION = "T" Then
                            Linea.Append("X")
                        Else
                            Linea.Append(" ")
                        End If

                        Linea.Append(vbTab)

                        'Unidades promoción
                        Linea.Append(0)
                        Linea.Append(vbTab)

                        'Precio promoción
                        Linea.Append(0)
                        Linea.Append(vbTab)

                        'PLU
                        Linea.AppendFormat("{0:00}", .BASCULA)
                        Linea.AppendFormat("{0:000}", .PLU)
                        Linea.Append(vbTab)

                        'Origen
                        Linea.Append(.ORIGEN)
                        Linea.Append(vbTab)

                        'Categoría
                        Linea.Append(.CATEGORIA)
                        Linea.Append(vbTab)

                        'Calibre
                        Linea.Append(.CALIBRE)
                        Linea.Append(vbTab)

                        'Dto.Fidelización
                        Linea.Append(.PORFIDELIZACION)
                        Linea.Append(vbTab)

                        'Importe Ecoraee
                        Linea.Append(.IMPORTEECORAEE)
                        Linea.Append(vbTab)

                        'Equivalencia (doble unidad)
                        Linea.Append(.EQUIVALENCIA)
                        Linea.Append(vbTab)

                        sr.WriteLine(Linea)

                    Catch ex As Exception
                        LOG.Nuevo("X", "Error al exportar datos del artículo " & .CODART & ". " & ex.Message)
                    End Try

                End With

            Next

        Catch ex As Exception
            'MsgBox("Error al exportar fichero de artículos." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            LOG.Nuevo("X", "Error al exportar fichero de artículos. " & ex.Message)
        Finally
            sr.Close()
        End Try
    End Sub
#End Region

#Region "ExportarFamilias"
    Private Sub ExportarFamilias()

        a3ERP.fWaitForm.SetCaption("Exportando fichero de familias de artículos")
        LOG.Nuevo("E", "Exportando fichero de familia de artículos")

        Dim sr As New IO.StreamWriter(Me.DirectorioFicheros & "\FAMILIAS.SEQ", False, System.Text.Encoding.Default)
        Dim taFamilias As New dsTPVEnvioTableAdapters.FAMILIASTableAdapter

        Try
            taFamilias.Fill(Me.FAMILIAS)

            For i As Integer = 0 To Me.FAMILIAS.Count - 1
                With Me.FAMILIAS(i)

                    Dim Linea As New System.Text.StringBuilder

                    'Familia y subfamilia
                    Dim Familia As String = Trim(.CODFAM)
                    If IsNumeric(Familia) And Len(Familia) >= 3 And Len(Familia) <= 6 Then

                        Linea.Append(Mid(Familia, 1, 3))

                        Linea.Append(vbTab)

                        If Len(Familia) = 6 Then
                            Linea.Append(Mid(Familia, 4, 3))
                        Else
                            Linea.Append(String.Empty)
                        End If

                    Else
                        Linea.Append("001")
                        Linea.Append(vbTab)
                        Linea.Append(String.Empty)
                    End If

                    Linea.Append(vbTab)

                    'Descripción
                    Linea.Append(Mid(.DESCFAM, 1, 40))

                    Linea.Append(vbTab)

                    'Descuento
                    Linea.Append(0)

                    sr.WriteLine(Linea)

                End With

            Next


        Catch ex As Exception
            ' MsgBox("Error al exportar fichero de familias de artículos." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            LOG.Nuevo("X", "Error al exportar fichero de familias de artículos. " & ex.Message)
        Finally
            sr.Close()
        End Try
    End Sub
#End Region

#Region "ExportarCodigosDeBarras"
    Private Sub ExportarCodigosDeBarras()

        a3ERP.fWaitForm.SetCaption("Exportando códigos de barras de artículos")
        LOG.Nuevo("E", "Exportando códigos de barras de artículos")

        Dim sr As New IO.StreamWriter(Me.DirectorioFicheros & "\COBARRAS.SEQ", False, System.Text.Encoding.Default)
        Dim taBarras As New dsTPVEnvioTableAdapters.ALTERNATableAdapter

        Try
            taBarras.Fill(Me.ALTERNA)

            For i As Integer = 0 To Me.ALTERNA.Count - 1
                With Me.ALTERNA(i)

                    Dim Linea As New System.Text.StringBuilder

                    'Código de barras
                    Linea.Append(Trim(.CODALT))
                    Linea.Append(vbTab)

                    'Código artículo
                    'If IsNumeric(.CODART) Then
                    '    Linea.AppendFormat("{0:0000000}", CInt(.CODART))
                    'Else
                    '    Linea.AppendFormat(.CODART.Trim)
                    'End If
                    Linea.AppendFormat(.CODART.Trim)
                    Linea.Append(vbTab)

                    sr.WriteLine(Linea)

                End With
            Next


        Catch ex As Exception
            'MsgBox("Error al exportar códigos de barras de artículos." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            LOG.Nuevo("X", "Error al exportar códigos de barras de artículos. " & ex.Message)
        Finally
            sr.Close()
        End Try
    End Sub
#End Region

#Region "ExportarTarjetas"
    Private Sub ExportarTarjetas()

        a3ERP.fWaitForm.SetCaption("Exportando fichero de tarjetas de clientes")
        LOG.Nuevo("E", "Exportando fichero de tarjetas de clientes")

        Dim sr As New IO.StreamWriter(Me.DirectorioFicheros & "\CLIENTES.SEQ", False, System.Text.Encoding.Default)
        Dim taClientes As New dsTPVEnvioTableAdapters.IDA_TARJETASTableAdapter

        Try
            taClientes.Fill(Me.IDA_TARJETAS)

            For i As Integer = 0 To Me.IDA_TARJETAS.Count - 1
                With Me.IDA_TARJETAS(i)

                    Dim Linea As New System.Text.StringBuilder

                    'Nº tarjeta
                    Linea.AppendFormat("{0:00000000}", .NUMTARJETA)
                    Linea.Append(vbTab)

                    'Nombre
                    If Not .IsNOMCLINull Then
                        Linea.Append(Mid(.NOMCLI, 1, 50))
                    Else
                        Linea.Append(String.Empty)
                    End If
                    Linea.Append(vbTab)

                    'Dirección
                    If Not .IsDIRCLINull Then
                        Linea.Append(Mid(.DIRCLI, 1, 50))
                    Else
                        Linea.Append(String.Empty)
                    End If
                    Linea.Append(vbTab)

                    'Código postal
                    If Not .IsDTOCLINull Then
                        Linea.Append(Mid(.DTOCLI, 1, 5))
                    Else
                        Linea.Append(String.Empty)
                    End If
                    Linea.Append(vbTab)

                    'Población
                    If Not .IsPOBCLINull Then
                        Linea.Append(Mid(.POBCLI, 1, 50))
                    Else
                        Linea.Append(String.Empty)
                    End If
                    Linea.Append(vbTab)

                    'Provincia
                    If Not .IsPOVCLINull Then
                        Linea.Append(Mid(.POVCLI, 1, 30))
                    Else
                        Linea.Append(String.Empty)
                    End If
                    Linea.Append(vbTab)

                    'Teléfono
                    If Not .IsTELCLINull Then
                        Linea.Append(Mid(.TELCLI, 1, 30))
                    Else
                        Linea.Append(String.Empty)
                    End If
                    Linea.Append(vbTab)

                    'NIF
                    If Not .IsNIFCLINull Then
                        Linea.Append(Mid(.NIFCLI, 1, 15))
                    Else
                        Linea.Append(String.Empty)
                    End If
                    Linea.Append(vbTab)

                    'Control de baja
                    Linea.Append(IIf(.BLOQUEADO = "T", "S", "N"))
                    Linea.Append(vbTab)

                    'Fecha caducidad
                    If Not .IsFECCADNull Then
                        Linea.Append(.FECCAD.ToShortDateString)
                    Else
                        Linea.Append(String.Empty)
                    End If
                    Linea.Append(vbTab)

                    'Descuento
                    If Not .IsDESCCLINull Then
                        Linea.Append(.DESCCLI)
                    Else
                        Linea.Append(0)
                    End If
                    Linea.Append(vbTab)

                    'Cliente albarán crédito
                    If Not .IsCODCLINull Then
                        Linea.AppendFormat("S" & vbTab & .CODCLI.Trim)
                    Else
                        Linea.Append("N" & vbTab & String.Empty)
                    End If
                    Linea.Append(vbTab)

                    'Saldo puntos
                    Linea.Append(.PUNTOSSALDO)
                    Linea.Append(vbTab)

                    'Matrícula
                    Linea.Append(String.Empty)
                    Linea.Append(vbTab)

                    'Marca
                    Linea.Append(String.Empty)
                    Linea.Append(vbTab)

                    'Modelo
                    Linea.Append(String.Empty)
                    Linea.Append(vbTab)

                    'Tipo vehículo
                    Linea.Append(String.Empty)

                    sr.WriteLine(Linea)

                End With
            Next


        Catch ex As Exception
            'MsgBox("Error al exportar fichero de clientes." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            LOG.Nuevo("X", "Error al exportar fichero de tarjetas de clientes. " & ex.Message)
        Finally
            sr.Close()
        End Try
    End Sub
#End Region

#Region "ExportarPromociones"
    Private Sub ExportarPromociones()

        a3ERP.fWaitForm.SetCaption("Exportando fichero de promociones")
        LOG.Nuevo("E", "Exportando fichero de promociones")

        Dim sr As New IO.StreamWriter(Me.DirectorioFicheros & "\PROMOCIO.SEQ", False, System.Text.Encoding.Default)
        Dim taPromociones As New dsTPVEnvioTableAdapters.IDA_PROMOCIONESTableAdapter

        Try
            Select Case a3ERP.Empresa
                Case a3ERP.FormatoEmpresa.Calavia
                    taPromociones.Fill(Me.IDA_PROMOCIONES, "4", "6", "10")
                Case a3ERP.FormatoEmpresa.Molina
                    taPromociones.Fill(Me.IDA_PROMOCIONES, "4", "5", "8")
                Case Else
                    taPromociones.Fill(Me.IDA_PROMOCIONES, "1", "2", "3")
            End Select

            For i As Integer = 0 To Me.IDA_PROMOCIONES.Count - 1
                With Me.IDA_PROMOCIONES(i)

                    Dim Linea As New System.Text.StringBuilder

                    'Código artículo
                    'If IsNumeric(.CODART) Then
                    '    Linea.AppendFormat("{0:0000000}", CInt(.CODART))
                    'Else
                    '    Linea.AppendFormat(.CODART.Trim)
                    'End If
                    Linea.AppendFormat(.CODART.Trim)
                    Linea.Append(vbTab)

                    'Código almacén
                    If IsNumeric(.CODALM) Then
                        Linea.AppendFormat("{0:00}", CInt(.CODALM))
                    Else
                        Linea.Append(.CODALM)
                    End If
                    Linea.Append(vbTab)

                    'Tarifa
                    Linea.AppendFormat("{0:00}", CInt(.TARIFA))
                    Linea.Append(vbTab)

                    'Fecha inicio
                    Linea.Append(.FECMIN.ToShortDateString)
                    Linea.Append(vbTab)

                    'Fecha fin
                    Linea.Append(.FECMAX.ToShortDateString)
                    Linea.Append(vbTab)

                    'Precio
                    Linea.Append(Math.Round(.PRECIO, 2, MidpointRounding.AwayFromZero))
                    Linea.Append(vbTab)

                    'Unidades
                    Linea.Append(.UNIDADES)
                    Linea.Append(vbTab)

                    'Artículo regalo
                    If Not .IsCODARTREGALONull Then
                        'Linea.AppendFormat("{0:0000000}", CInt(.CODARTREGALO))
                        Linea.AppendFormat(.CODARTREGALO.Trim)
                        Linea.Append(vbTab)
                        Linea.Append(.FRACCIONSC)
                        Linea.Append(vbTab)
                        Linea.Append(.UNIDADESSC)
                        Linea.Append(vbTab)
                        Linea.Append(Math.Round(.PRECIOREGALO, 2, MidpointRounding.AwayFromZero))
                        Linea.Append(vbTab)
                    Else
                        Linea.AppendFormat(" ")
                        Linea.Append(vbTab)
                        Linea.Append(0)
                        Linea.Append(vbTab)
                        Linea.Append(0)
                        Linea.Append(vbTab)
                        Linea.Append(0)
                        Linea.Append(vbTab)
                    End If

                    sr.WriteLine(Linea)

                End With

            Next


        Catch ex As Exception
            'MsgBox("Error al exportar fichero de promociones." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            LOG.Nuevo("X", "Error al exportar fichero de promociones. " & ex.Message)
        Finally
            sr.Close()
        End Try
    End Sub
#End Region

#Region "ExportarEntradasAlmacen"
    Private Sub ExportarEntradasAlmacen()

        Dim taEntradas As New dsTPVEnvioTableAdapters.IDA_ENTRADASALMACENTableAdapter

        a3ERP.fWaitForm.SetCaption("Buscando entradas de almacén")
        LOG.Nuevo("E", "Buscando entradas de almacén")

        Try
            taEntradas.Fill(Me.IDA_ENTRADASALMACEN)

            Dim Tienda As New dsTiendas
            Dim Tiendas As New Collections.ArrayList
            Dim Entradas As DataRow() = Me.IDA_ENTRADASALMACEN.Select("", "CODALM")

            For i As Integer = 0 To Entradas.Count - 1
                With DirectCast(Entradas(i), dsTPVEnvio.IDA_ENTRADASALMACENRow)
                    If Not Tiendas.Contains(.CODALM) Then Tiendas.Add(.CODALM)
                End With
            Next

            For i As Integer = 0 To Tiendas.Count - 1

                'Comprobar comunicación tienda
                Tienda.Cargar(Tiendas(i))
                If Tienda.TIENDAS.Count > 0 Then
                    If Tienda.TIENDAS(0).IDA_COMUNICACION <> "FTP" And Tienda.TIENDAS(0).IDA_COMUNICACION <> "USB" Then Continue For
                Else
                    Continue For
                End If

                Dim Errores As Boolean = False
                Dim NombreFichero As String = "al" & String.Format("{0:00}", CInt(Tiendas(i))) & String.Format("{0:00}", Today.Day) & ".seq"

                a3ERP.fWaitForm.SetCaption("Comprobando fichero de entradas del almacén " & CInt(Tiendas(i)))

                Dim sr As New IO.StreamWriter(Me.DirectorioFicheros & "\" & NombreFichero, True, System.Text.Encoding.Default)

                Try
                    a3ERP.fWaitForm.SetCaption("Exportando entradas del almacén " & CInt(Tiendas(i)))
                    LOG.Nuevo("E", "Exportando entradas del almacén", Tiendas(i))

                    Entradas = Me.IDA_ENTRADASALMACEN.Select("CODALM = '" & Tiendas(i) & "'")

                    sr.WriteLine("ENSAL")

                    For j As Integer = 0 To Entradas.Count - 1
                        With DirectCast(Entradas(j), dsTPVEnvio.IDA_ENTRADASALMACENRow)

                            If Not IsNumeric(.CODALM) Then Continue For
                            If Not IsNumeric(.CODART) Then Continue For

                            Dim Linea As New System.Text.StringBuilder

                            'Código almacén
                            Linea.AppendFormat("{0:00}", CInt(.CODALM))

                            'Código artículo
                            'If IsNumeric(.CODART) Then
                            '    Linea.AppendFormat("{0:0000000}", CInt(.CODART))
                            'Else
                            '    Linea.AppendFormat(.CODART.Trim)
                            'End If
                            Linea.AppendFormat(.CODART.Trim)

                            'Cantidad
                            Linea.AppendFormat("{0,10}", .UNIDADES * 100)

                            'Precio
                            Linea.AppendFormat("{0,10}", .PRECIO * 100)

                            Dim NUMDOC As Integer = .NUMDOC
                            If Len(NUMDOC.ToString) > 6 Then NUMDOC = Mid(NUMDOC.ToString, Len(NUMDOC.ToString) - 5)
                            Linea.AppendFormat("{0:000000}", NUMDOC)

                            sr.WriteLine(Linea)

                            .FECHAENVIO = Today.ToShortDateString

                        End With
                    Next

                Catch ex As Exception
                    'MsgBox("Error al exportar fichero de entradas de almacén." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
                    LOG.Nuevo("X", "Error al exportar fichero de entradas de almacén. " & ex.Message, Tiendas(i))
                    Errores = True
                Finally
                    sr.Close()
                End Try

                taEntradas.Update(Me.IDA_ENTRADASALMACEN)

            Next

        Catch ex As Exception
            'MsgBox("Error al buscar entradas de almacén." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            LOG.Nuevo("X", "Error al buscar entradas de almacén. " & ex.Message)
        End Try
    End Sub
#End Region

#Region "ExportarInventario"
    Public Sub ExportarInventario()
        Try
            Dim dsTiendas As New dsTiendas

            dsTiendas.Cargar()

            Dim Tiendas As DataRow() = dsTiendas.TIENDAS.Select("ENVIARINVENTARIO = 'T'")

            For tienda As Integer = 0 To Tiendas.Length - 1
                With DirectCast(Tiendas(tienda), dsTiendas.TIENDASRow)

                    'Comprobar comunicación tienda
                    If .IDA_COMUNICACION <> "FTP" And .IDA_COMUNICACION <> "USB" Then Continue For

                    Dim taInventario As New dsTPVEnvioTableAdapters.StockTableAdapter

                    a3ERP.fWaitForm.SetCaption("Exportando inventario del almacén " & LTrim(.CODALM))
                    LOG.Nuevo("E", "Exportando inventario del almacén", .CODALM)

                    taInventario.Fill(Me.Stock, .CODALM)

                    Dim Errores As Boolean = False
                    Dim NombreFichero As String = "inve" & String.Format("{0:00}", CInt(.CODALM)) & ".seq"

                    Dim sr As New IO.StreamWriter(Me.DirectorioFicheros & "\" & NombreFichero, False, System.Text.Encoding.Default)

                    Try
                        For i As Integer = 0 To Me.Stock.Count - 1
                            With DirectCast(Me.Stock(i), dsTPVEnvio.StockRow)

                                Dim Linea As New System.Text.StringBuilder

                                'Código artículo
                                Linea.Append(.CODART.Trim)
                                Linea.Append(vbTab)

                                'Cantidad
                                Linea.Append(.Stock)
                                Linea.Append(vbTab)

                                'Mínimo
                                Linea.Append(.StockMin)
                                Linea.Append(vbTab)

                                'Máximo
                                Linea.Append(.StockMax)
                                Linea.Append(vbTab)

                                sr.WriteLine(Linea)

                            End With
                        Next

                    Catch ex As Exception
                        'MsgBox("Error al exportar fichero de inventario de almacén." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
                        LOG.Nuevo("X", "Error al exportar fichero de inventario de almacén. " & ex.Message, .CODALM)
                        Errores = True
                    Finally
                        sr.Close()
                    End Try

                    'If Mid(.IDA_TIPOTERMINAL, 1, 1) = "W" Then

                    '    'Comprimir inventario
                    '    Dim DirectorioINV As String = Me.DirectorioFicheros & "\" & NombreFichero
                    '    Dim DirectorioZIP As String = Me.DirectorioFicheros & "\inve" & String.Format("{0:00}", CInt(.CODALM)) & ".zip"

                    '    If IO.File.Exists(DirectorioZIP) Then IO.File.Delete(DirectorioZIP)

                    '    ZipUtil.Comprimir(Me.DirectorioFicheros, NombreFichero, DirectorioZIP, False)

                    '    If IO.File.Exists(DirectorioINV) Then IO.File.Delete(DirectorioINV)

                    'End If

                End With
            Next

        Catch ex As Exception
            'MsgBox("Error al calcular inventario de almacén." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            LOG.Nuevo("X", "Error al calcular inventario de almacén." & ex.Message)
        End Try
    End Sub
#End Region

#Region "ExportarPLU"
    Private Sub ExportarPLU()

        a3ERP.fWaitForm.SetCaption("Exportando fichero PLU")
        LOG.Nuevo("E", "Exportando fichero PLU")

        Dim sr As New IO.StreamWriter(Me.DirectorioFicheros & "\TX.TXT", False, System.Text.Encoding.Default)
        Dim taPLU As New dsTPVEnvioTableAdapters.PLUTableAdapter

        Try
            taPLU.Fill(Me.PLU)

            For i As Integer = 0 To Me.PLU.Count - 1
                With Me.PLU(i)

                    Dim Linea As New System.Text.StringBuilder

                    'Código báscula
                    Linea.AppendFormat("{0:00}", .IDA_CODBAS)

                    Linea.Append("L2")
                    Linea.Append("00")
                    Linea.Append("A")

                    'Código almacén
                    If IsNumeric(.CODART) Then
                        Linea.AppendFormat("{0:000000}", CInt(.CODART))
                    Else
                        Continue For
                        'Linea.AppendFormat("{0,6}", Mid(.CODART, 1, 6))
                    End If

                    'PLU
                    Linea.AppendFormat("{0:000}", .IDA_PLU)

                    Linea.AppendFormat("{0,-24}", Mid(.DESCART, 1, 24))

                    Linea.Append(Space(48))

                    If Not .IsPRECIOPROMONull Then
                        Linea.AppendFormat("{0:00000000}", CInt(.PRECIOPROMO * 100))
                    ElseIf Not .IsTARIFA_10Null Then
                        Linea.AppendFormat("{0:00000000}", CInt(.TARIFA_10 * 100))
                    ElseIf Not .IsTARIFA_4Null Then
                        Linea.AppendFormat("{0:00000000}", CInt(.TARIFA_4 * 100))
                    Else
                        Linea.AppendFormat("{0:00000000}", CInt(.PRCVENTA * 100))
                    End If

                    Linea.Append("0000000000000000")

                    Linea.Append(Space(18))

                    sr.WriteLine(Linea)

                End With

            Next

        Catch ex As Exception
            'MsgBox("Error al exportar fichero PLU." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            LOG.Nuevo("X", "Error al exportar fichero PLU. " & ex.Message)
        Finally
            sr.Close()
        End Try

    End Sub
#End Region

#Region "ExportarTarifas"
    Private Sub ExportarTarifas()

        a3ERP.fWaitForm.SetCaption("Exportando fichero de tarifas")
        LOG.Nuevo("E", "Exportando fichero de tarifas")

        Dim sr As New IO.StreamWriter(Me.DirectorioFicheros & "\TARIFAS.SEQ", False, System.Text.Encoding.Default)
        Dim taTarifas As New dsTPVEnvioTableAdapters.TARIFASTableAdapter

        Try
            taTarifas.Fill(Me.TARIFAS)

            For i As Integer = 0 To Me.TARIFAS.Count - 1
                With Me.TARIFAS(i)

                    Try

                        If .CODART = a3ERP.DatosConfig.CODARTBLAN Then Continue For

                        Dim Linea As New System.Text.StringBuilder

                        'Código artículo
                        'If IsNumeric(.CODART) Then
                        '    Linea.AppendFormat("{0:0000000}", CInt(.CODART))
                        'Else
                        '    Linea.AppendFormat(.CODART.Trim)
                        'End If
                        Linea.AppendFormat(.CODART.Trim)
                        Linea.Append(vbTab)

                        'Nº tarifa
                        Linea.Append(.TARIFA.Trim)
                        Linea.Append(vbTab)

                        'Precio
                        Linea.Append(.PRECIO)
                        Linea.Append(vbTab)

                        'IVA incluido
                        Linea.Append(IIf(.IVAINCLUIDO = "T", "S", "N"))

                        sr.WriteLine(Linea)

                    Catch ex As Exception
                        LOG.Nuevo("X", "Error al exportar datos de tarifas " & .CODART & ". " & ex.Message)
                    End Try

                End With

            Next

        Catch ex As Exception
            'MsgBox("Error al exportar fichero de artículos." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            LOG.Nuevo("X", "Error al exportar fichero de tarifas. " & ex.Message)
        Finally
            sr.Close()
        End Try
    End Sub
#End Region

#Region "ExportarClientes"
    Private Sub ExportarClientes()

        a3ERP.fWaitForm.SetCaption("Exportando fichero de clientes de crédito")
        LOG.Nuevo("E", "Exportando fichero de clientes de crédito")

        Dim sr As New IO.StreamWriter(Me.DirectorioFicheros & "\CLICREDI.SEQ", False, System.Text.Encoding.Default)
        Dim taClientes As New dsTPVEnvioTableAdapters.CLIENTESTableAdapter

        Try
            taClientes.Fill(Me.CLIENTES)

            For i As Integer = 0 To Me.CLIENTES.Count - 1
                With Me.CLIENTES(i)

                    If Not IsNumeric(.CODCLI) Then Continue For

                    Dim Linea As New System.Text.StringBuilder

                    'Código cliente
                    Linea.AppendFormat(.CODCLI.Trim)
                    Linea.Append(vbTab)

                    'Nombre fiscal
                    Linea.Append(.NOMCLI)
                    Linea.Append(vbTab)

                    'Nombre comercial
                    Linea.Append(.RAZON)
                    Linea.Append(vbTab)

                    'Dirección
                    Linea.Append(.DIRCLI)
                    Linea.Append(vbTab)

                    'Código postal
                    Linea.Append(.DTOCLI)
                    Linea.Append(vbTab)

                    'Población
                    Linea.Append(.POBCLI)
                    Linea.Append(vbTab)

                    'Provincia
                    Linea.Append(.PROVINCIA)
                    Linea.Append(vbTab)

                    'NIF
                    Linea.Append(.NIFCLI)
                    Linea.Append(vbTab)

                    'Forma de pago
                    Linea.Append(.FORPAG)
                    Linea.Append(vbTab)

                    'Recargo equivalencia
                    Linea.Append(IIf(.APLIREC = "T", "S", "N"))
                    Linea.Append(vbTab)

                    'Tarifa
                    If Not .IsTARIFANull Then
                        Linea.Append(.TARIFA.Trim)
                    Else
                        Linea.Append(String.Empty)
                    End If
                    Linea.Append(vbTab)

                    'Descuento
                    If Not .IsPORPRONTONull Then
                        Linea.Append(.PORPRONTO)
                    Else
                        Linea.Append(0)
                    End If
                    Linea.Append(vbTab)

                    'Teléfono
                    Linea.Append(.TELCLI)
                    Linea.Append(vbTab)

                    'Móvil
                    Linea.Append(.TELCLI2)
                    Linea.Append(vbTab)

                    'e-Mail
                    Linea.Append(.E_MAIL)
                    Linea.Append(vbTab)

                    'Cta.Cte.
                    Linea.Append(.CuentaExt)
                    Linea.Append(vbTab)

                    'Cliente CND
                    Linea.Append(.DescCar1)
                    Linea.Append(vbTab)

                    sr.WriteLine(Linea)

                End With
            Next


        Catch ex As Exception
            'MsgBox("Error al exportar fichero de clientes." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            LOG.Nuevo("X", "Error al exportar fichero de clientes de crédito. " & ex.Message)
        Finally
            sr.Close()
        End Try
    End Sub
#End Region

#Region "ExportarFormasPago"
    Private Sub ExportarFormasPago()

        a3ERP.fWaitForm.SetCaption("Exportando fichero de formas de pago")
        LOG.Nuevo("E", "Exportando fichero de formas de pago")

        Dim sr As New IO.StreamWriter(Me.DirectorioFicheros & "\FORMAPAG.SEQ", False, System.Text.Encoding.Default)
        Dim taFormaPag As New dsTPVEnvioTableAdapters.FORMAPAGTableAdapter

        Try
            taFormaPag.Fill(Me.FORMAPAG)

            For i As Integer = 0 To Me.FORMAPAG.Count - 1
                With Me.FORMAPAG(i)

                    Try
                        Dim Linea As New System.Text.StringBuilder

                        'Código
                        Linea.AppendFormat(.FORPAG.Trim)
                        Linea.Append(vbTab)

                        'Descripción
                        Linea.Append(.DESCFOR.Trim)
                        Linea.Append(vbTab)

                        'Nº vencimientos
                        Linea.Append(.NUMVENCIM)
                        Linea.Append(vbTab)

                        'Primer vencimiento
                        Linea.Append(.PRIMLAPSO)
                        Linea.Append(vbTab)

                        'Días entre vencimientos
                        Linea.Append(.SIGLAPSO)

                        sr.WriteLine(Linea)

                    Catch ex As Exception
                        LOG.Nuevo("X", "Error al exportar datos de forma de pago " & .FORPAG & ". " & ex.Message)
                    End Try

                End With

            Next

        Catch ex As Exception
            'MsgBox("Error al exportar fichero de artículos." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            LOG.Nuevo("X", "Error al exportar fichero de formas de pago. " & ex.Message)
        Finally
            sr.Close()
        End Try
    End Sub
#End Region

End Class
