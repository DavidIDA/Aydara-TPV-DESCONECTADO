Public Class Recepcion

#Region "Recepcion_Shown"
    Private Sub Recepcion_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Try
            Principal.Tag = "update"

            CheckForIllegalCrossThreadCalls = False
            Me.BackgroundWorker1.RunWorkerAsync()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "Recepcion"
    Private Sub Recepcion()
        Dim cmd As New SqlClient.SqlCommand()

        Try
            Me.Cursor = Cursors.WaitCursor

            Me.lblFicheros.Text = "Buscando actualizaciones..."
            Me.lblFicheros.Refresh()
            General.ComprobarVersionApp()

            Me.lblFicheros.Text = "Descargando ficheros..."
            Me.lblFicheros.Refresh()
            'Me.lblRegistros.Text = String.Empty
            'Me.lblRegistros.Refresh()
            Me.pbFicheros.Text = 0
            Me.pbRegistros.Text = 0

            If Comunicacion.DescargaFicheros Then

                Dim conexion As New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                conexion.Open()

                Dim transaccion As SqlClient.SqlTransaction

                cmd.Connection = conexion

                'Poner marca actualizando
                cmd.CommandText = "UPDATE TIENDAS SET Actualizando=1 WHERE CodigoTienda=" & CodigoTienda
                cmd.ExecuteNonQuery()

                Dim RutaFichero As String
                Dim NombreFichero As String
                Dim j As Int32 = 0
                Dim n As Int32 = 0
                Dim Contador As Int32 = 1

                'Ficheros
                Dim Ficheros As New ArrayList
                Ficheros.Add("FAMILIAS.SEQ")
                Ficheros.Add("ARTICULO.SEQ")
                Ficheros.Add("COBARRAS.SEQ")
                Ficheros.Add("CLIENTES.SEQ")
                Ficheros.Add("PROMOCIO.SEQ")
                Ficheros.Add("Promociones.xml")
                Ficheros.Add("Tarifas.xml")
                n = Ficheros.Count - 1

                Dim dsComunicaciones As New dsComunicaciones

                Try

                    For j = 0 To n

                        RutaFichero = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\" & Ficheros(j)

                        If IO.File.Exists(RutaFichero) Then

                            'NombreFichero = Mid(tFiles(j), Len(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\") + 1)
                            NombreFichero = Ficheros(j)

                            Me.lblFicheros.Text = "Leyendo fichero..."
                            Me.lblFicheros.Refresh()
                            Me.pbFicheros.Text = Int((j + 1) / (n + 1) * 100)
                            Me.pbFicheros.Refresh()

                            Select Case NombreFichero

                                Case "FAMILIAS.SEQ"

                                    'Eliminar familias de artículos temporal
                                    Me.lblFicheros.Text = "Creando tabla temporal de familias de artículos..."
                                    Me.lblFicheros.Refresh()

                                    transaccion = conexion.BeginTransaction()
                                    cmd.Transaction = transaccion

                                    cmd.CommandText = "CrearTablaTemporal_FamiliasArticulos"
                                    cmd.ExecuteNonQuery()

                                    transaccion.Commit()

                                    Me.lblFicheros.Text = "Leyendo fichero de familias de artículos"
                                    Me.lblFicheros.Refresh()

                                    Dim tFamilias As New dsComunicacionesTableAdapters.COMUNICACIONES_FAMILIASARTICULOSTableAdapter
                                    Dim rFamilia As dsComunicaciones.COMUNICACIONES_FAMILIASARTICULOSRow

                                    Dim sr As New System.IO.StreamReader(RutaFichero, System.Text.Encoding.Default, True)
                                    Dim LineaActual As Integer = 0
                                    Dim TotalLineas As Integer = sr.ReadToEnd().Split(vbCrLf).Length - 1
                                    sr.Close()

                                    'Primera pasada para familias
                                    sr = New System.IO.StreamReader(RutaFichero, System.Text.Encoding.Default, True)

                                    Try
                                        While sr.Peek() <> -1

                                            LineaActual += 1
                                            Me.pbRegistros.Text = Int(LineaActual / TotalLineas * 100)
                                            Me.pbRegistros.Refresh()

                                            Dim s As String = sr.ReadLine()

                                            If String.IsNullOrEmpty(s) Then
                                                Continue While
                                            End If

                                            Dim Linea() As String

                                            Linea = Split(s, vbTab)

                                            ''Me.lblRegistros.Text = "Leyendo familia " & LineaActual & " de " & TotalLineas & ". " & Linea(0) & ": " & Linea(2)
                                            ''Me.lblRegistros.Refresh()

                                            rFamilia = dsComunicaciones.COMUNICACIONES_FAMILIASARTICULOS.NewCOMUNICACIONES_FAMILIASARTICULOSRow
                                            rFamilia.CodigoFamilia = Trim(Linea(0))
                                            rFamilia.CodigoSubfamilia = Trim(Linea(1))
                                            rFamilia.Descripcion = Linea(2)
                                            rFamilia.DescuentoTarjeta = Linea(3)
                                            dsComunicaciones.COMUNICACIONES_FAMILIASARTICULOS.AddCOMUNICACIONES_FAMILIASARTICULOSRow(rFamilia)

                                        End While

                                        Me.lblFicheros.Text = "Creando tabla temporal de familias de artículos..."
                                        Me.lblFicheros.Refresh()
                                        'Me.lblRegistros.Text = String.Empty
                                        'Me.lblRegistros.Refresh()

                                        transaccion = conexion.BeginTransaction()
                                        cmd.Transaction = transaccion

                                        Me.lblFicheros.Text = "Actualizando familias de artículos..."
                                        Me.lblFicheros.Refresh()

                                        tFamilias.Update(dsComunicaciones.COMUNICACIONES_FAMILIASARTICULOS)

                                        'Actualizar familias existentes
                                        cmd.CommandText = "UPDATE FAMILIASARTICULOS " & _
                                                          "SET Descripcion = COMUNICACIONES_FAMILIASARTICULOS.Descripcion, DescuentoTarjeta = COMUNICACIONES_FAMILIASARTICULOS.DescuentoTarjeta " & _
                                                          "FROM FAMILIASARTICULOS INNER JOIN COMUNICACIONES_FAMILIASARTICULOS ON FAMILIASARTICULOS.Codigo = COMUNICACIONES_FAMILIASARTICULOS.CodigoFamilia " & _
                                                          "WHERE CodigoSubfamilia=''"
                                        cmd.ExecuteNonQuery()

                                        'Añadir familias nuevas
                                        Me.lblFicheros.Text = "Añadiendo familias nuevas..."
                                        Me.lblFicheros.Refresh()
                                        cmd.CommandText = "INSERT INTO FAMILIASARTICULOS (Codigo, Descripcion, DescuentoTarjeta) " & _
                                                          "SELECT COMUNICACIONES_FAMILIASARTICULOS.CodigoFamilia, COMUNICACIONES_FAMILIASARTICULOS.Descripcion, COMUNICACIONES_FAMILIASARTICULOS.DescuentoTarjeta " & _
                                                          "FROM COMUNICACIONES_FAMILIASARTICULOS " & _
                                                          "WHERE CodigoSubfamilia='' AND CodigoFamilia NOT IN (SELECT Codigo FROM FAMILIASARTICULOS)"
                                        cmd.ExecuteNonQuery()

                                        'Actualizar subfamilias existentes
                                        Me.lblFicheros.Text = "Actualizando subfamilias de artículos..."
                                        Me.lblFicheros.Refresh()
                                        cmd.CommandText = "UPDATE SUBFAMILIASARTICULOS " & _
                                                          "SET Descripcion = COMUNICACIONES_FAMILIASARTICULOS.Descripcion, DescuentoTarjeta = COMUNICACIONES_FAMILIASARTICULOS.DescuentoTarjeta " & _
                                                          "FROM (FAMILIASARTICULOS INNER JOIN SUBFAMILIASARTICULOS ON FAMILIASARTICULOS.Id = SUBFAMILIASARTICULOS.Familia_Id) INNER JOIN COMUNICACIONES_FAMILIASARTICULOS " & _
                                                          "ON FAMILIASARTICULOS.Codigo = COMUNICACIONES_FAMILIASARTICULOS.CodigoFamilia AND SUBFAMILIASARTICULOS.Codigo = COMUNICACIONES_FAMILIASARTICULOS.CodigoSubFamilia " & _
                                                          "WHERE CodigoSubfamilia<>''"
                                        cmd.ExecuteNonQuery()

                                        'Añadir subfamilias nuevas
                                        Me.lblFicheros.Text = "Añadiendo subfamilias nuevas..."
                                        Me.lblFicheros.Refresh()
                                        cmd.CommandText = "INSERT INTO SUBFAMILIASARTICULOS (Familia_Id, Codigo, Descripcion, DescuentoTarjeta) " & _
                                                          "SELECT FAMILIASARTICULOS.Id, COMUNICACIONES_FAMILIASARTICULOS.CodigoSubfamilia, COMUNICACIONES_FAMILIASARTICULOS.Descripcion, COMUNICACIONES_FAMILIASARTICULOS.DescuentoTarjeta " & _
                                                          "FROM COMUNICACIONES_FAMILIASARTICULOS INNER JOIN FAMILIASARTICULOS ON COMUNICACIONES_FAMILIASARTICULOS.CodigoFamilia = FAMILIASARTICULOS.Codigo " & _
                                                          "WHERE CodigoSubfamilia<>'' AND CodigoSubfamilia NOT IN (SELECT Codigo FROM SUBFAMILIASARTICULOS WHERE Familia_Id = FAMILIASARTICULOS.Id)"
                                        cmd.ExecuteNonQuery()

                                        transaccion.Commit()

                                    Catch ex As Exception
                                        MsgBox("Error al actualizar las familias." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
                                        transaccion.Rollback()
                                    Finally
                                        sr.Close()
                                    End Try

                                Case "ARTICULO.SEQ"

                                    'Eliminar artículos temporal
                                    Me.lblFicheros.Text = "Creando tabla temporal de artículos..."
                                    Me.lblFicheros.Refresh()

                                    transaccion = conexion.BeginTransaction()
                                    cmd.Transaction = transaccion

                                    cmd.CommandText = "CrearTablaTemporal_Articulos"
                                    cmd.ExecuteNonQuery()

                                    transaccion.Commit()

                                    Me.lblFicheros.Text = "Leyendo fichero de artículos"
                                    Me.lblFicheros.Refresh()

                                    Dim tArticulos As New dsComunicacionesTableAdapters.COMUNICACIONES_ARTICULOSTableAdapter
                                    Dim rArticulo As dsComunicaciones.COMUNICACIONES_ARTICULOSRow

                                    'Dim sr As New System.IO.StreamReader(tFiles(j), System.Text.Encoding.Default, True)
                                    Dim sr As New System.IO.StreamReader(RutaFichero, System.Text.Encoding.Default, True)
                                    Dim LineaActual As Integer = 0
                                    Dim TotalLineas As Integer = sr.ReadToEnd().Split(vbCrLf).Length - 1
                                    sr.Close()

                                    'Primera pasada para los artículos
                                    sr = New System.IO.StreamReader(RutaFichero, System.Text.Encoding.Default, True)

                                    Try
                                        While sr.Peek() <> -1

                                            LineaActual += 1
                                            Me.pbRegistros.Text = Int(LineaActual / TotalLineas * 100)
                                            Me.pbRegistros.Refresh()

                                            Dim s As String = sr.ReadLine()

                                            If String.IsNullOrEmpty(s) Then
                                                Continue While
                                            End If

                                            Dim Linea() As String

                                            Linea = Split(s, vbTab)

                                            'Me.lblRegistros.Text = "Leyendo artículo " & LineaActual & " de " & TotalLineas & ". " & Linea(0) & ": " & Linea(1)
                                            'Me.lblRegistros.Refresh()

                                            rArticulo = dsComunicaciones.COMUNICACIONES_ARTICULOS.NewCOMUNICACIONES_ARTICULOSRow
                                            rArticulo.Codigo = Linea(0)
                                            rArticulo.Descripcion = Linea(1)
                                            rArticulo.TipoIva = Linea(2)
                                            rArticulo.CodigoFamilia = Linea(3)
                                            rArticulo.CodigoSubfamilia = Linea(4)
                                            rArticulo.CodigoProveedor = Linea(5)
                                            rArticulo.CodigoEnvase = Trim(Linea(6))
                                            rArticulo.ControlEtiquetas = IIf(Linea(7) = "S", True, False)
                                            rArticulo.CantidadVariable = IIf(Linea(8) = "S", True, False)
                                            rArticulo.ArticuloPeso = IIf(Linea(9) = "S", True, False)
                                            rArticulo.ControlBaja = IIf(Linea(10) = "S", True, False)
                                            rArticulo.TipoUnidad_Codigo = Linea(11)
                                            rArticulo.UnidadCaja = Linea(12)
                                            rArticulo.MinimoVenta = Linea(13)
                                            rArticulo.MinimoCompra = Linea(14)
                                            rArticulo.PesoUnidad = Linea(15)
                                            rArticulo.Descuento = Linea(16)
                                            rArticulo.TipoArticulo = Linea(21)

                                            If ActualizaCosto Then
                                                If rArticulo.TipoArticulo <> "5" Then rArticulo.PrecioCoste = Linea(17)
                                            Else
                                                rArticulo.PrecioCoste = 0
                                            End If

                                            Select Case General.TipoTienda
                                                Case 0, 2 'Propia o depósito
                                                    Select Case General.NumeroTarifa
                                                        Case 4
                                                            rArticulo.Precio = IIf(Linea(20) <> 0, Linea(20), Linea(18))
                                                        Case 6
                                                            rArticulo.Precio = IIf(Linea(19) <> 0, Linea(19), Linea(18))
                                                        Case Else
                                                            rArticulo.Precio = Linea(18)
                                                    End Select
                                                Case 1 'Franquicia
                                                    Select Case General.NumeroTarifa
                                                        Case 4
                                                            rArticulo.Precio = Linea(18)
                                                        Case 6
                                                            rArticulo.Precio = IIf(Linea(19) <> 0, Linea(19), Linea(18))
                                                        Case Else
                                                            rArticulo.Precio = Linea(18)
                                                    End Select
                                            End Select

                                            If DtoSobreTarifa <> 0 Then
                                                rArticulo.Precio = Math.Round(rArticulo.Precio - ((rArticulo.Precio * DtoSobreTarifa) / 100), 2, MidpointRounding.AwayFromZero)
                                            End If

                                            If RecibePromociones Then
                                                rArticulo.UnidadesPromocion = Linea(22)
                                                rArticulo.PrecioPromocion = Linea(23)
                                            Else
                                                rArticulo.UnidadesPromocion = 0
                                                rArticulo.PrecioPromocion = 0
                                            End If

                                            dsComunicaciones.COMUNICACIONES_ARTICULOS.AddCOMUNICACIONES_ARTICULOSRow(rArticulo)

                                        End While

                                        Me.lblFicheros.Text = "Actualizando artículos..."
                                        Me.lblFicheros.Refresh()
                                        'Me.lblRegistros.Text = String.Empty
                                        'Me.lblRegistros.Refresh()

                                        transaccion = conexion.BeginTransaction()
                                        cmd.Transaction = transaccion

                                        tArticulos.Update(dsComunicaciones.COMUNICACIONES_ARTICULOS)

                                        'Marcar todos artículos no propios con control de baja
                                        cmd.CommandText = "UPDATE ARTICULOS SET ControlBaja = 1"
                                        If General.ArticuloPropioInicio <> String.Empty And General.ArticuloPropioFin <> String.Empty Then
                                            cmd.CommandText &= " WHERE Codigo < '" & General.ArticuloPropioInicio & "' OR Codigo > '" & General.ArticuloPropioFin & "'"
                                        End If
                                        cmd.ExecuteNonQuery()

                                        'Crear etiquetas con precios nuevos
                                        Me.lblFicheros.Text = "Creando etiquetas con precios nuevos..."
                                        Me.lblFicheros.Refresh()
                                        cmd.CommandText = "INSERT INTO ETIQUETAS (CodigoArticulo, CodigoColor, CodigoTalla, Etiquetas) " & _
                                                          "SELECT COMUNICACIONES_ARTICULOS.Codigo, 0, 1, 1 " & _
                                                          "FROM COMUNICACIONES_ARTICULOS LEFT JOIN ARTICULOS ON COMUNICACIONES_ARTICULOS.Codigo = ARTICULOS.Codigo " & _
                                                          "WHERE COMUNICACIONES_ARTICULOS.ControlBaja=0 AND COMUNICACIONES_ARTICULOS.ControlEtiquetas=1 AND COMUNICACIONES_ARTICULOS.Precio <> ISNULL(ARTICULOS.Precio,0) " & _
                                                          "AND COMUNICACIONES_ARTICULOS.Codigo NOT IN (SELECT CodigoArticulo FROM ETIQUETAS)"
                                        cmd.ExecuteNonQuery()

                                        Me.lblFicheros.Text = "Actualizando artículos..."
                                        Me.lblFicheros.Refresh()
                                        cmd.CommandText = "UPDATE ARTICULOS " & _
                                                          "SET TipoIVA = COMUNICACIONES_ARTICULOS.TipoIVA, Descripcion = COMUNICACIONES_ARTICULOS.Descripcion, CodigoFamilia = FAMILIASARTICULOS.Id, CodigoSubfamilia = SUBFAMILIASARTICULOS.Id, " & _
                                                          "CodigoProveedor = COMUNICACIONES_ARTICULOS.CodigoProveedor, CodigoEnvase = COMUNICACIONES_ARTICULOS.CodigoEnvase, ControlEtiquetas = COMUNICACIONES_ARTICULOS.ControlEtiquetas, " & _
                                                          "CantidadVariable = COMUNICACIONES_ARTICULOS.CantidadVariable, ArticuloPeso = COMUNICACIONES_ARTICULOS.ArticuloPeso, ControlBaja = COMUNICACIONES_ARTICULOS.ControlBaja, " & _
                                                          "TipoUnidad_Id = TIPOS_UNIDADES.Id, UnidadCaja = COMUNICACIONES_ARTICULOS.UnidadCaja, MinimoVenta = COMUNICACIONES_ARTICULOS.MinimoVenta, MinimoCompra = COMUNICACIONES_ARTICULOS.MinimoCompra, " & _
                                                          "PesoUnidad = COMUNICACIONES_ARTICULOS.PesoUnidad, Descuento = COMUNICACIONES_ARTICULOS.Descuento, Precio = COMUNICACIONES_ARTICULOS.Precio, PrecioCoste = " & IIf(ActualizaCosto, "ISNULL(COMUNICACIONES_ARTICULOS.Preciocoste,0)", "ISNULL(ARTICULOS.PrecioCoste,0)") & ", " & _
                                                          "TipoArticulo = COMUNICACIONES_ARTICULOS.TipoArticulo, UnidadesPromocion = " & IIf(RecibePromociones, "ISNULL(COMUNICACIONES_ARTICULOS.UnidadesPromocion,0)", "ISNULL(ARTICULOS.UnidadesPromocion,0)") & ", PrecioPromocion = " & IIf(RecibePromociones, "ISNULL(COMUNICACIONES_ARTICULOS.PrecioPromocion,0)", "ISNULL(ARTICULOS.PrecioPromocion,0)") & " " & _
                                                          "FROM (((ARTICULOS INNER JOIN COMUNICACIONES_ARTICULOS ON ARTICULOS.Codigo = COMUNICACIONES_ARTICULOS.Codigo) " & _
                                                          "LEFT JOIN FAMILIASARTICULOS ON COMUNICACIONES_ARTICULOS.CodigoFamilia = FAMILIASARTICULOS.Codigo) " & _
                                                          "LEFT JOIN SUBFAMILIASARTICULOS ON COMUNICACIONES_ARTICULOS.CodigoSubfamilia = SUBFAMILIASARTICULOS.Codigo AND SUBFAMILIASARTICULOS.Familia_Id = FAMILIASARTICULOS.Id) " & _
                                                          "LEFT JOIN TIPOS_UNIDADES ON COMUNICACIONES_ARTICULOS.TipoUnidad_Codigo = TIPOS_UNIDADES.Codigo"
                                        cmd.ExecuteNonQuery()

                                        Me.lblFicheros.Text = "Actualizando existencias..."
                                        Me.lblFicheros.Refresh()
                                        cmd.CommandText = "UPDATE EXISTENCIAS " & _
                                                          "SET PrecioVenta = COMUNICACIONES_ARTICULOS.Precio " & _
                                                          "FROM ARTICULOS INNER JOIN COMUNICACIONES_ARTICULOS ON ARTICULOS.Codigo = COMUNICACIONES_ARTICULOS.Codigo " & _
                                                          "WHERE ARTICULOS.Id = EXISTENCIAS.Articulo_Id AND CodigoTienda=" & CodigoTienda & " AND EXISTENCIAS.CodigoColor=0 AND EXISTENCIAS.CodigoTalla=1"
                                        cmd.ExecuteNonQuery()

                                        'Añadir artículos nuevos
                                        Me.lblFicheros.Text = "Añadiendo artículos nuevos..."
                                        Me.lblFicheros.Refresh()
                                        cmd.CommandText = "INSERT INTO ARTICULOS (Codigo, Descripcion, TipoIVA, CodigoFamilia, CodigoSubfamilia, CodigoProveedor, CodigoEnvase, Controletiquetas, CantidadVariable, " & _
                                                          "ArticuloPeso, Controlbaja, CodigoTalla, TipoUnidad_Id, UnidadCaja, MinimoVenta, MinimoCompra, PesoUnidad, Descuento, Precio, PrecioCoste, TipoArticulo, UnidadesPromocion, PrecioPromocion) " & _
                                                          "SELECT COMUNICACIONES_ARTICULOS.Codigo, COMUNICACIONES_ARTICULOS.Descripcion, COMUNICACIONES_ARTICULOS.TipoIVA, FAMILIASARTICULOS.Id, SUBFAMILIASARTICULOS.Id, " & _
                                                          "COMUNICACIONES_ARTICULOS.CodigoProveedor, COMUNICACIONES_ARTICULOS.CodigoEnvase, COMUNICACIONES_ARTICULOS.Controletiquetas, COMUNICACIONES_ARTICULOS.CantidadVariable, " & _
                                                          "COMUNICACIONES_ARTICULOS.ArticuloPeso, COMUNICACIONES_ARTICULOS.Controlbaja, 1, TIPOS_UNIDADES.Id, COMUNICACIONES_ARTICULOS.UnidadCaja, COMUNICACIONES_ARTICULOS.MinimoVenta, " & _
                                                          "COMUNICACIONES_ARTICULOS.MinimoCompra, COMUNICACIONES_ARTICULOS.PesoUnidad, COMUNICACIONES_ARTICULOS.Descuento, COMUNICACIONES_ARTICULOS.Precio, COMUNICACIONES_ARTICULOS.PrecioCoste, " & _
                                                          "COMUNICACIONES_ARTICULOS.TipoArticulo, COMUNICACIONES_ARTICULOS.UnidadesPromocion, COMUNICACIONES_ARTICULOS.PrecioPromocion " & _
                                                          "FROM ((COMUNICACIONES_ARTICULOS " & _
                                                          "LEFT JOIN FAMILIASARTICULOS ON COMUNICACIONES_ARTICULOS.CodigoFamilia = FAMILIASARTICULOS.Codigo) " & _
                                                          "LEFT JOIN SUBFAMILIASARTICULOS ON COMUNICACIONES_ARTICULOS.CodigoSubfamilia = SUBFAMILIASARTICULOS.Codigo AND SUBFAMILIASARTICULOS.Familia_Id = FAMILIASARTICULOS.Id) " & _
                                                          "LEFT JOIN TIPOS_UNIDADES ON COMUNICACIONES_ARTICULOS.TipoUnidad_Codigo = TIPOS_UNIDADES.Codigo " & _
                                                          "WHERE COMUNICACIONES_ARTICULOS.Codigo NOT IN (SELECT Codigo FROM ARTICULOS)"
                                        cmd.ExecuteNonQuery()

                                        Me.lblFicheros.Text = "Actualizando existencias de artículos nuevos..."
                                        Me.lblFicheros.Refresh()
                                        cmd.CommandText = "INSERT INTO EXISTENCIAS (Articulo_Id, CodigoTienda, CodigoColor, CodigoTalla, ExistenciaInicial, ExistenciaActual, StockMinimo, StockMaximo, PrecioVenta) " & _
                                                          "SELECT Articulo_Id = ARTICULOS.Id, " & CodigoTienda & ", 0, 1, 0, 0, 0, 0, COMUNICACIONES_ARTICULOS.Precio " & _
                                                          "FROM ARTICULOS INNER JOIN COMUNICACIONES_ARTICULOS ON ARTICULOS.Codigo = COMUNICACIONES_ARTICULOS.Codigo " & _
                                                          "WHERE ARTICULOS.Id NOT IN (SELECT Articulo_Id FROM EXISTENCIAS)"
                                        cmd.ExecuteNonQuery()

                                        transaccion.Commit()

                                    Catch ex As Exception
                                        MsgBox("Error al actualizar el artículo." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
                                        transaccion.Rollback()
                                    Finally
                                        sr.Close()
                                    End Try

                                Case "COBARRAS.SEQ"

                                    Me.lblFicheros.Text = "Creando tabla temporal de códigos de barras..."
                                    Me.lblFicheros.Refresh()

                                    transaccion = conexion.BeginTransaction()
                                    cmd.Transaction = transaccion

                                    cmd.CommandText = "CrearTablaTemporal_CodigoBarras"
                                    cmd.ExecuteNonQuery()

                                    transaccion.Commit()

                                    Me.lblFicheros.Text = "Leyendo fichero de códigos de barras"
                                    Me.lblFicheros.Refresh()

                                    Dim tCodigoBarras As New dsComunicacionesTableAdapters.COMUNICACIONES_CODIGO_BARRASTableAdapter
                                    Dim rCodigoBarras As dsComunicaciones.COMUNICACIONES_CODIGO_BARRASRow

                                    Dim sr As New System.IO.StreamReader(RutaFichero, System.Text.Encoding.Default, True)
                                    Dim LineaActual As Integer = 0
                                    Dim TotalLineas As Integer = sr.ReadToEnd().Split(vbCrLf).Length - 1
                                    sr.Close()

                                    sr = New System.IO.StreamReader(RutaFichero, System.Text.Encoding.Default, True)

                                    Try
                                        While sr.Peek() <> -1

                                            LineaActual += 1
                                            Me.pbRegistros.Text = Int(LineaActual / TotalLineas * 100)
                                            Me.pbRegistros.Refresh()

                                            Dim s As String = sr.ReadLine()

                                            If String.IsNullOrEmpty(s) Then
                                                Continue While
                                            End If

                                            Dim Linea() As String

                                            Linea = Split(s, vbTab)

                                            'Me.lblRegistros.Text = "Leyendo código de barras " & LineaActual & " de " & TotalLineas & ". " & Linea(0)
                                            'Me.lblRegistros.Refresh()

                                            rCodigoBarras = dsComunicaciones.COMUNICACIONES_CODIGO_BARRAS.NewCOMUNICACIONES_CODIGO_BARRASRow
                                            rCodigoBarras.CodigoBarras = Linea(0)
                                            rCodigoBarras.Articulo_Codigo = Linea(1)
                                            dsComunicaciones.COMUNICACIONES_CODIGO_BARRAS.AddCOMUNICACIONES_CODIGO_BARRASRow(rCodigoBarras)

                                        End While

                                        Me.lblFicheros.Text = "Actualizando códigos de barras..."
                                        Me.lblFicheros.Refresh()
                                        'Me.lblRegistros.Text = String.Empty
                                        'Me.lblRegistros.Refresh()

                                        transaccion = conexion.BeginTransaction()
                                        cmd.Transaction = transaccion

                                        tCodigoBarras.Update(dsComunicaciones.COMUNICACIONES_CODIGO_BARRAS)

                                        'Eliminar todos los códigos de barras de artículos no propios e inexistentes
                                        Me.lblFicheros.Text = "Eliminando códigos de barras..."
                                        Me.lblFicheros.Refresh()

                                        cmd.CommandText = "DELETE CODIGO_BARRAS FROM CODIGO_BARRAS WHERE Articulo_Id NOT IN (SELECT Id FROM ARTICULOS)"
                                        cmd.ExecuteNonQuery()

                                        cmd.CommandText = "DELETE CODIGO_BARRAS FROM CODIGO_BARRAS INNER JOIN ARTICULOS ON ARTICULOS.Id=CODIGO_BARRAS.Articulo_Id WHERE CODIGO_BARRAS.CodigoColor IS NULL AND CODIGO_BARRAS.CodigoTalla IS NULL"
                                        If General.ArticuloPropioInicio <> String.Empty Then cmd.CommandText &= " AND Codigo<='" & General.ArticuloPropioInicio & "' "
                                        If General.ArticuloPropioFin <> String.Empty Then cmd.CommandText &= " AND Codigo>='" & General.ArticuloPropioFin & "' "
                                        cmd.ExecuteNonQuery()

                                        'Añadir códigos de barras
                                        Me.lblFicheros.Text = "Añadiendo códigos de barras..."
                                        Me.lblFicheros.Refresh()
                                        cmd.CommandText = "INSERT INTO CODIGO_BARRAS (CodigoBarras, Articulo_Id) " & _
                                                          "SELECT COMUNICACIONES_CODIGO_BARRAS.CodigoBarras, ARTICULOS.Id " & _
                                                          "FROM ARTICULOS INNER JOIN COMUNICACIONES_CODIGO_BARRAS ON ARTICULOS.Codigo = COMUNICACIONES_CODIGO_BARRAS.Articulo_Codigo " & _
                                                          "WHERE COMUNICACIONES_CODIGO_BARRAS.CodigoBarras NOT IN (SELECT CodigoBarras FROM CODIGO_BARRAS)"
                                        cmd.ExecuteNonQuery()

                                        transaccion.Commit()

                                    Catch ex As Exception
                                        MsgBox("Error al añadir código de barras." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
                                        transaccion.Rollback()
                                    Finally
                                        sr.Close()
                                    End Try

                                Case "CLIENTES.SEQ"

                                    'Sólo actualizar si es tienda propia
                                    If General.TipoTienda <> 0 Then Exit Select

                                    Me.lblFicheros.Text = "Creando tabla temporal de clientes..."
                                    Me.lblFicheros.Refresh()

                                    transaccion = conexion.BeginTransaction()
                                    cmd.Transaction = transaccion

                                    cmd.CommandText = "CrearTablaTemporal_Clientes"
                                    cmd.ExecuteNonQuery()

                                    transaccion.Commit()

                                    Me.lblFicheros.Text = "Leyendo fichero de clientes"
                                    Me.lblFicheros.Refresh()

                                    Dim tClientes As New dsComunicacionesTableAdapters.COMUNICACIONES_CLIENTESTableAdapter
                                    Dim rCliente As dsComunicaciones.COMUNICACIONES_CLIENTESRow

                                    Dim sr As New System.IO.StreamReader(RutaFichero, System.Text.Encoding.Default, True)
                                    Dim LineaActual As Integer = 0
                                    Dim TotalLineas As Integer = sr.ReadToEnd().Split(vbCrLf).Length - 1
                                    sr.Close()

                                    sr = New System.IO.StreamReader(RutaFichero, System.Text.Encoding.Default, True)

                                    Try
                                        While sr.Peek() <> -1

                                            LineaActual += 1
                                            Me.pbRegistros.Text = Int(LineaActual / TotalLineas * 100)
                                            Me.pbRegistros.Refresh()

                                            Dim s As String = sr.ReadLine()

                                            If String.IsNullOrEmpty(s) Then
                                                Continue While
                                            End If

                                            Dim Linea() As String

                                            Linea = Split(s, vbTab)

                                            'Me.lblRegistros.Text = "Leyendo cliente " & LineaActual & " de " & TotalLineas & ". " & Linea(0) & ": " & Linea(1)
                                            'Me.lblRegistros.Refresh()

                                            rCliente = dsComunicaciones.COMUNICACIONES_CLIENTES.NewCOMUNICACIONES_CLIENTESRow
                                            rCliente.Codigo = Linea(0)
                                            rCliente.NombreFiscal = Linea(1)
                                            rCliente.Direccion = Linea(2)
                                            rCliente.CodigoPostal = Linea(3)
                                            rCliente.Poblacion = Linea(4)
                                            rCliente.Provincia = Linea(5)
                                            rCliente.TelParticular = Linea(6)
                                            rCliente.CIF = Linea(7)
                                            rCliente.ControlBaja = IIf(Linea(8) = "S", True, False)
                                            rCliente.TieneTarjeta = True
                                            If IsDate(Linea(9)) Then
                                                rCliente.CaducidadTarjeta = Linea(9)
                                            Else
                                                rCliente.SetCaducidadTarjetaNull()
                                            End If
                                            rCliente.DescuentoTarjeta = Linea(10)
                                            rCliente.AlbaranCredito = IIf(Linea(11) = "S", True, False)

                                            dsComunicaciones.COMUNICACIONES_CLIENTES.AddCOMUNICACIONES_CLIENTESRow(rCliente)

                                        End While

                                        Me.lblFicheros.Text = "Actualizando clientes..."
                                        Me.lblFicheros.Refresh()
                                        'Me.lblRegistros.Text = String.Empty
                                        'Me.lblRegistros.Refresh()

                                        transaccion = conexion.BeginTransaction()
                                        cmd.Transaction = transaccion

                                        tClientes.Update(dsComunicaciones.COMUNICACIONES_CLIENTES)

                                        'Actualizar clientes existentes
                                        cmd.CommandText = "UPDATE CLIENTES " & _
                                                          "SET NombreFiscal = COMUNICACIONES_CLIENTES.NombreFiscal, Direccion = COMUNICACIONES_CLIENTES.Direccion, CodigoPostal = COMUNICACIONES_CLIENTES.CodigoPostal, Poblacion = COMUNICACIONES_CLIENTES.Poblacion, " & _
                                                          "Provincia = COMUNICACIONES_CLIENTES.Provincia, CIF = COMUNICACIONES_CLIENTES.CIF, TelParticular = COMUNICACIONES_CLIENTES.TelParticular, TelMovil = COMUNICACIONES_CLIENTES.TelMovil, " & _
                                                          "ControlBaja = COMUNICACIONES_CLIENTES.ControlBaja, TieneTarjeta = COMUNICACIONES_CLIENTES.TieneTarjeta, CaducidadTarjeta = COMUNICACIONES_CLIENTES.CaducidadTarjeta, DescuentoTarjeta = COMUNICACIONES_CLIENTES.DescuentoTarjeta, AlbaranCredito = COMUNICACIONES_CLIENTES.AlbaranCredito " & _
                                                          "FROM CLIENTES INNER JOIN COMUNICACIONES_CLIENTES ON CLIENTES.Codigo = COMUNICACIONES_CLIENTES.Codigo"
                                        cmd.ExecuteNonQuery()

                                        'Añadir familias nuevas
                                        Me.lblFicheros.Text = "Añadiendo clientes nuevos..."
                                        Me.lblFicheros.Refresh()
                                        cmd.CommandText = "INSERT INTO CLIENTES (Codigo, NombreFiscal, Direccion, CodigoPostal, Poblacion, Provincia, CIF, TelParticular, TelMovil, ControlBaja, TieneTarjeta, CaducidadTarjeta, DescuentoTarjeta, AlbaranCredito) " & _
                                                          "SELECT Codigo, NombreFiscal, Direccion, CodigoPostal, Poblacion, Provincia, CIF, TelParticular, TelMovil, ControlBaja, TieneTarjeta, CaducidadTarjeta, DescuentoTarjeta, AlbaranCredito " & _
                                                          "FROM COMUNICACIONES_CLIENTES " & _
                                                          "WHERE Codigo NOT IN (SELECT Codigo FROM CLIENTES)"
                                        cmd.ExecuteNonQuery()

                                        transaccion.Commit()

                                    Catch ex As Exception
                                        MsgBox("Error al actualizar clientes." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
                                        transaccion.Rollback()
                                    Finally
                                        sr.Close()
                                    End Try

                                Case "PROMOCIO.SEQ"

                                    If Not RecibePromociones Then
                                        Exit Select
                                    End If

                                    Me.lblFicheros.Text = "Creando tabla temporal de promociones..."
                                    Me.lblFicheros.Refresh()

                                    transaccion = conexion.BeginTransaction()
                                    cmd.Transaction = transaccion

                                    cmd.CommandText = "CrearTablaTemporal_Promociones"
                                    cmd.ExecuteNonQuery()

                                    transaccion.Commit()

                                    Me.lblFicheros.Text = "Leyendo fichero de promociones"
                                    Me.lblFicheros.Refresh()

                                    Dim tPromociones As New dsComunicacionesTableAdapters.COMUNICACIONES_PROMOCIONESTableAdapter
                                    Dim rPromocion As dsComunicaciones.COMUNICACIONES_PROMOCIONESRow

                                    Dim sr As New System.IO.StreamReader(RutaFichero, System.Text.Encoding.Default, True)
                                    Dim LineaActual As Integer = 0
                                    Dim TotalLineas As Integer = sr.ReadToEnd().Split(vbCrLf).Length - 1
                                    sr.Close()

                                    sr = New System.IO.StreamReader(RutaFichero, System.Text.Encoding.Default, True)

                                    Try
                                        While sr.Peek() <> -1

                                            LineaActual += 1
                                            Me.pbRegistros.Text = Int(LineaActual / TotalLineas * 100)
                                            Me.pbRegistros.Refresh()

                                            Dim s As String = sr.ReadLine()

                                            If String.IsNullOrEmpty(s) Then
                                                Continue While
                                            End If

                                            Dim Linea() As String

                                            Linea = Split(s, vbTab)

                                            'Me.lblRegistros.Text = "Leyendo promoción " & IIf(General.TipoTienda = 2, LineaActual, Int(LineaActual / 2)) & " de " & TotalLineas & ". Desde " & Linea(3) & " hasta " & Linea(4)
                                            'Me.lblRegistros.Refresh()

                                            Dim FechaInicio As Date = Linea(3)
                                            Dim FechaFinal As Date = Linea(4)

                                            If (FechaFinal >= Date.Today) And (Linea(1) = Format(General.NumeroAlmacen, "00") Or Linea(1) = "TD") And (Linea(2) = Format(General.NumeroTarifa, "00") Or Linea(2) = "10") Then

                                                rPromocion = dsComunicaciones.COMUNICACIONES_PROMOCIONES.NewCOMUNICACIONES_PROMOCIONESRow
                                                rPromocion.CodigoTienda = CodigoTienda
                                                rPromocion.CodigoArticulo = Linea(0)
                                                rPromocion.FechaInicio = FechaInicio
                                                rPromocion.FechaFinal = DateAdd(DateInterval.Second, -1, DateAdd(DateInterval.Day, 1, IIf(Year(FechaFinal) = 9999, "01/01/9999", FechaFinal)))

                                                rPromocion.PrecioPromocion = Linea(5)
                                                If IsNumeric(Linea(6)) Then rPromocion.Unidades = Linea(6)

                                                If DtoSobrePromocion <> 0 Then
                                                    rPromocion.PrecioPromocion = Math.Round(rPromocion.PrecioPromocion - ((rPromocion.PrecioPromocion * DtoSobrePromocion) / 100), 2, MidpointRounding.AwayFromZero)
                                                End If

                                                'Nº almacén y tarifa de la importación
                                                rPromocion.NumeroAlmacen = IIf(IsNumeric(Linea(1)), Linea(1), 0)
                                                rPromocion.NumeroTarifa = Linea(2)

                                                'Artículo regalo
                                                If IsNumeric(Linea(7)) Then
                                                    rPromocion.CodigoArticuloRegalo = Linea(7)
                                                    rPromocion.FraccionSinCargo = Linea(8)
                                                    rPromocion.UnidadesSinCargo = Linea(9)
                                                    rPromocion.PrecioArticuloRegalo = Linea(10)
                                                Else
                                                    rPromocion.CodigoArticuloRegalo = String.Empty
                                                    rPromocion.FraccionSinCargo = 0
                                                    rPromocion.UnidadesSinCargo = 0
                                                    rPromocion.PrecioArticuloRegalo = 0
                                                End If

                                                If rPromocion.RowState = DataRowState.Detached Then dsComunicaciones.COMUNICACIONES_PROMOCIONES.AddCOMUNICACIONES_PROMOCIONESRow(rPromocion)

                                            End If

                                        End While

                                        Me.lblFicheros.Text = "Actualizando promociones..."
                                        Me.lblFicheros.Refresh()
                                        'Me.lblRegistros.Text = String.Empty
                                        'Me.lblRegistros.Refresh()

                                        transaccion = conexion.BeginTransaction()
                                        cmd.Transaction = transaccion

                                        tPromociones.Update(dsComunicaciones.COMUNICACIONES_PROMOCIONES)

                                        'Resolver promociones (Eliminar las tarifas que tienen tarifa10, eliminar las de tipo tienda TD si existen con nº de almacén...)

                                        'Eliminar promociones caducadas
                                        Me.lblFicheros.Text = "Eliminando promociones caducadas..."
                                        Me.lblFicheros.Refresh()
                                        cmd.CommandText = "DELETE PROMOCIONES WHERE CodigoTienda=" & CodigoTienda & " AND (FechaFinal<'" & Date.Now & "' OR NumeroTarifa<>0)"
                                        cmd.ExecuteNonQuery()

                                        'Eliminar tarifas TD que existan en almacén
                                        cmd.CommandText = "DELETE FROM COMUNICACIONES_PROMOCIONES WHERE NumeroAlmacen=0 AND NumeroTarifa<>0 AND " & _
                                                          "(SELECT COUNT(Id) FROM COMUNICACIONES_PROMOCIONES AS PROMO_2 WHERE CodigoTienda=" & CodigoTienda & " AND CodigoArticulo=COMUNICACIONES_PROMOCIONES.CodigoArticulo " & _
                                                          "AND FechaInicio=COMUNICACIONES_PROMOCIONES.FechaInicio AND FechaFinal=COMUNICACIONES_PROMOCIONES.FechaFinal AND NumeroAlmacen=" & General.NumeroAlmacen & ") > 0"
                                        cmd.ExecuteNonQuery()

                                        If General.TipoTienda = 1 Then 'Tipo 1: Franquicia
                                            'Si es franquicia eliminar todas que la tarifa no coincida con la de la tienda
                                            cmd.CommandText = "DELETE FROM COMUNICACIONES_PROMOCIONES WHERE CodigoTienda=" & CodigoTienda & " AND NumeroTarifa<>0 " & _
                                                              "AND NumeroTarifa<>" & General.NumeroTarifa
                                        Else
                                            'Eliminar las tarifas que existan con tarifa 10
                                            cmd.CommandText = "DELETE FROM COMUNICACIONES_PROMOCIONES WHERE NumeroTarifa<>0 AND NumeroTarifa<>10 AND " & _
                                                              "(SELECT COUNT(Id) FROM COMUNICACIONES_PROMOCIONES AS PROMO_2 WHERE CodigoTienda=" & CodigoTienda & " AND CodigoArticulo=COMUNICACIONES_PROMOCIONES.CodigoArticulo " & _
                                                              "AND FechaInicio=COMUNICACIONES_PROMOCIONES.FechaInicio AND FechaFinal=COMUNICACIONES_PROMOCIONES.FechaFinal AND NumeroTarifa=10) > 0"
                                        End If
                                        cmd.ExecuteNonQuery()

                                        'Insertar promociones
                                        Me.lblFicheros.Text = "Añadiendo promociones nuevas..."
                                        Me.lblFicheros.Refresh()
                                        cmd.CommandText = "INSERT INTO PROMOCIONES (CodigoTienda, CodigoArticulo, FechaInicio, FechaFinal, Unidades, CodigoArticuloRegalo, PrecioPromocion, FraccionSinCargo, UnidadesSinCargo, PrecioArticuloRegalo, NumeroAlmacen, NumeroTarifa) " & _
                                                          "SELECT CodigoTienda, CodigoArticulo, FechaInicio, FechaFinal, Unidades, CodigoArticuloRegalo, PrecioPromocion, FraccionSinCargo, UnidadesSinCargo, PrecioArticuloRegalo, NumeroAlmacen, NumeroTarifa FROM COMUNICACIONES_PROMOCIONES"
                                        cmd.ExecuteNonQuery()

                                        transaccion.Commit()

                                    Catch ex As Exception
                                        MsgBox("Error al actualizar promociones." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
                                        transaccion.Rollback()
                                    Finally
                                        sr.Close()
                                    End Try

                                Case "Promociones.xml"

                                    If Not RecibePromociones Then
                                        Exit Select
                                    End If

                                    'Actualizar promociones especiales
                                    Me.lblFicheros.Text = "Importando promociones especiales..."
                                    Me.lblFicheros.Refresh()

                                    transaccion = conexion.BeginTransaction()
                                    cmd.Transaction = transaccion

                                    cmd.CommandText = "CrearTablaTemporal_Promociones"
                                    cmd.ExecuteNonQuery()

                                    transaccion.Commit()

                                    Try
                                        If Comunicacion.ImportarPromociones() Then

                                            transaccion = conexion.BeginTransaction()
                                            cmd.Transaction = transaccion

                                            'Actualizar promociones existentes
                                            Me.lblFicheros.Text = "Actualizando promociones especiales..."
                                            Me.lblFicheros.Refresh()

                                            cmd.CommandText = "UPDATE PROMOCIONES " & _
                                                              "SET CodigoArticuloRegalo = COMUNICACIONES_PROMOCIONES.CodigoArticuloRegalo, PrecioPromocion = COMUNICACIONES_PROMOCIONES.PrecioPromocion, FraccionSinCargo = COMUNICACIONES_PROMOCIONES.FraccionSinCargo, " & _
                                                              "UnidadesSinCargo = COMUNICACIONES_PROMOCIONES.UnidadesSinCargo, PrecioArticuloRegalo = COMUNICACIONES_PROMOCIONES.PrecioArticuloRegalo " & _
                                                              "FROM PROMOCIONES INNER JOIN COMUNICACIONES_PROMOCIONES ON PROMOCIONES.CodigoTienda = COMUNICACIONES_PROMOCIONES.CodigoTienda " & _
                                                              "AND PROMOCIONES.FechaInicio = COMUNICACIONES_PROMOCIONES.FechaInicio AND PROMOCIONES.FechaFinal = COMUNICACIONES_PROMOCIONES.FechaFinal AND PROMOCIONES.CodigoArticulo = COMUNICACIONES_PROMOCIONES.CodigoArticulo"
                                            cmd.ExecuteNonQuery()

                                            'Insertar promociones nuevas
                                            Me.lblFicheros.Text = "Añadiendo promociones especiales nuevas..."
                                            Me.lblFicheros.Refresh()
                                            cmd.CommandText = "INSERT INTO PROMOCIONES (CodigoTienda, CodigoArticulo, FechaInicio, FechaFinal, CodigoArticuloRegalo, PrecioPromocion, FraccionSinCargo, UnidadesSinCargo, PrecioArticuloRegalo, NumeroAlmacen, NumeroTarifa) " & _
                                                              "SELECT CodigoTienda, CodigoArticulo, FechaInicio, FechaFinal, CodigoArticuloRegalo, PrecioPromocion, FraccionSinCargo, UnidadesSinCargo, PrecioArticuloRegalo, NumeroAlmacen, " & General.NumeroTarifa & " FROM COMUNICACIONES_PROMOCIONES " & _
                                                              "WHERE CodigoArticulo NOT IN (SELECT CodigoArticulo FROM PROMOCIONES WHERE PROMOCIONES.CodigoTienda = COMUNICACIONES_PROMOCIONES.CodigoTienda " & _
                                                              "AND PROMOCIONES.FechaInicio = COMUNICACIONES_PROMOCIONES.FechaInicio AND PROMOCIONES.FechaFinal = COMUNICACIONES_PROMOCIONES.FechaFinal AND PROMOCIONES.CodigoArticulo = COMUNICACIONES_PROMOCIONES.CodigoArticulo)"
                                            cmd.ExecuteNonQuery()

                                            transaccion.Commit()

                                        End If

                                    Catch ex As Exception
                                        MsgBox("Error al importar promociones especiales." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
                                        transaccion.Rollback()
                                    End Try

                                Case "Tarifas.xml"
                                    'Actualizar tarifas de venta
                                    Me.lblFicheros.Text = "Actualizando tarifas de venta..."
                                    Me.lblFicheros.Refresh()

                                    Comunicacion.ImportarTarifas()

                            End Select
                        End If
                    Next

                    'Importar entradas de almacén
                    Dim tFiles() As String
                    tFiles = System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00"))

                    If tFiles.Length > 0 Then
                        Me.lblFicheros.Text = "Creando tabla temporal de entradas de almacén..."
                        Me.lblFicheros.Refresh()

                        transaccion = conexion.BeginTransaction()
                        cmd.Transaction = transaccion

                        cmd.CommandText = "CrearTablaTemporal_Entradas"
                        cmd.ExecuteNonQuery()

                        transaccion.Commit()

                        For j = 0 To tFiles.Length - 1

                            NombreFichero = Mid(tFiles(j), Len(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\") + 1)

                            If UCase(Mid(NombreFichero, 1, 2)) = "AL" And Mid(NombreFichero, 3, 2) = Format(General.NumeroAlmacen, "00") Then

                                Me.lblFicheros.Text = "Leyendo fichero de entradas de almacén"
                                Me.lblFicheros.Refresh()

                                Dim tEntradas As New dsComunicacionesTableAdapters.COMUNICACIONES_ENTRADASTableAdapter
                                Dim rEntradas As dsComunicaciones.COMUNICACIONES_ENTRADASRow

                                Dim sr As New System.IO.StreamReader(tFiles(j), System.Text.Encoding.Default, True)
                                Dim LineaActual As Integer = 0
                                Dim TotalLineas As Integer = sr.ReadToEnd().Split(vbCrLf).Length - 1
                                sr.Close()

                                sr = New System.IO.StreamReader(tFiles(j), System.Text.Encoding.Default, True)

                                Try
                                    While sr.Peek() <> -1

                                        LineaActual += 1
                                        Me.pbRegistros.Text = Int(LineaActual / TotalLineas * 100)
                                        Me.pbRegistros.Refresh()

                                        Dim s As String = sr.ReadLine()

                                        If String.IsNullOrEmpty(s) Then
                                            Continue While
                                        End If

                                        Dim Linea() As String

                                        Linea = Split(s, vbTab)

                                        'Me.lblRegistros.Text = "Leyendo entrada de almacén " & LineaActual & " de " & TotalLineas
                                        'Me.lblRegistros.Refresh()

                                        If Mid(Linea(0), 1, 2) = Format(General.NumeroAlmacen, "00") Then
                                            rEntradas = dsComunicaciones.COMUNICACIONES_ENTRADAS.NewCOMUNICACIONES_ENTRADASRow
                                            rEntradas.CodigoArticulo = Mid(Linea(0), 3, 7)
                                            rEntradas.Cantidad = CType(Mid(Linea(0), 10, 10), Decimal) / 100
                                            rEntradas.Precio = CType(Mid(Linea(0), 20, 10), Decimal) / 100
                                            rEntradas.NumeroAlbaran = Format(Date.Today, "yy") & "-" & Mid(Linea(0), 30, 6)
                                            dsComunicaciones.COMUNICACIONES_ENTRADAS.AddCOMUNICACIONES_ENTRADASRow(rEntradas)
                                        End If

                                    End While

                                    Me.lblFicheros.Text = "Actualizando entradas de almacén..."
                                    Me.lblFicheros.Refresh()
                                    'Me.lblRegistros.Text = String.Empty
                                    'Me.lblRegistros.Refresh()

                                    transaccion = conexion.BeginTransaction()
                                    cmd.Transaction = transaccion

                                    tEntradas.Update(dsComunicaciones.COMUNICACIONES_ENTRADAS)

                                    'Actualizar entradas existentes
                                    'cmd.CommandText = "UPDATE EXISTENCIAS " & _
                                    '                  "SET ExistenciaActual = ExistenciaActual - ALBARANES_COMPRAS_LINEAS.Cantidad " & _
                                    '                  "FROM (ALBARANES_COMPRAS INNER JOIN COMUNICACIONES_ENTRADAS ON ALBARANES_COMPRAS.NumeroAlbaran = COMUNICACIONES_ENTRADAS.NumeroAlbaran) " & _
                                    '                  "INNER JOIN ALBARANES_COMPRAS_LINEAS ON ALBARANES_COMPRAS.Id = ALBARANES_COMPRAS_LINEAS.AlbaranCompra_Id " & _
                                    '                  "INNER JOIN ARTICULOS ON ARTICULOS.Codigo = ALBARANES_COMPRAS_LINEAS.CodigoArticulo " & _
                                    '                  "WHERE ALBARANES_COMPRAS.CodigoTienda=" & CodigoTienda & " AND ALBARANES_COMPRAS_LINEAS.CodigoArticulo = COMUNICACIONES_ENTRADAS.CodigoArticulo " & _
                                    '                  "AND EXISTENCIAS.Articulo_Id = ARTICULOS.Id"
                                    'cmd.ExecuteNonQuery()

                                    'cmd.CommandText = "DELETE ALBARANES_COMPRAS_LINEAS " & _
                                    '                  "FROM (ALBARANES_COMPRAS INNER JOIN COMUNICACIONES_ENTRADAS ON ALBARANES_COMPRAS.NumeroAlbaran = COMUNICACIONES_ENTRADAS.NumeroAlbaran) " & _
                                    '                  "INNER JOIN ALBARANES_COMPRAS_LINEAS ON ALBARANES_COMPRAS.Id = ALBARANES_COMPRAS_LINEAS.AlbaranCompra_Id " & _
                                    '                  "WHERE ALBARANES_COMPRAS.CodigoTienda=" & CodigoTienda & " AND ALBARANES_COMPRAS_LINEAS.CodigoArticulo = COMUNICACIONES_ENTRADAS.CodigoArticulo"
                                    'cmd.ExecuteNonQuery()

                                    cmd.CommandText = "DELETE COMUNICACIONES_ENTRADAS " & _
                                                      "FROM (ALBARANES_COMPRAS INNER JOIN COMUNICACIONES_ENTRADAS ON ALBARANES_COMPRAS.NumeroAlbaran = COMUNICACIONES_ENTRADAS.NumeroAlbaran) " & _
                                                      "INNER JOIN ALBARANES_COMPRAS_LINEAS ON ALBARANES_COMPRAS.Id = ALBARANES_COMPRAS_LINEAS.AlbaranCompra_Id " & _
                                                      "WHERE ALBARANES_COMPRAS.CodigoTienda=" & CodigoTienda & " AND ALBARANES_COMPRAS_LINEAS.CodigoArticulo = COMUNICACIONES_ENTRADAS.CodigoArticulo " & _
                                                      "AND ALBARANES_COMPRAS_LINEAS.Cantidad = COMUNICACIONES_ENTRADAS.Cantidad"
                                    cmd.ExecuteNonQuery()

                                    'Añadir nuevas entradas
                                    Me.lblFicheros.Text = "Añadiendo entradas de almacén..."
                                    Me.lblFicheros.Refresh()

                                    cmd.CommandText = "INSERT INTO ALBARANES_COMPRAS (CodigoTienda, Numeroalbaran, Fecha, CodigoProveedor, NombreProveedor, Observaciones) " & _
                                                      "SELECT " & CodigoTienda & ", NumeroAlbaran, '" & Date.Today & "', 1, '" & NombreTienda & "', 'Importación fichero " & NombreFichero & "' " & _
                                                      "FROM COMUNICACIONES_ENTRADAS WHERE NumeroAlbaran NOT IN (SELECT Numeroalbaran FROM ALBARANES_COMPRAS WHERE CodigoTienda = " & CodigoTienda & ") " & _
                                                      "GROUP BY NumeroAlbaran"
                                    cmd.ExecuteNonQuery()

                                    cmd.CommandText = "INSERT INTO ALBARANES_COMPRAS_LINEAS (AlbaranCompra_Id, CodigoArticulo, Descripcion, Cantidad, Precio, Descuento, Total, Observaciones) " & _
                                                      "SELECT ALBARANES_COMPRAS.Id, COMUNICACIONES_ENTRADAS.CodigoArticulo, ARTICULOS.Descripcion, COMUNICACIONES_ENTRADAS.Cantidad, COMUNICACIONES_ENTRADAS.Precio, 0, COMUNICACIONES_ENTRADAS.Cantidad * COMUNICACIONES_ENTRADAS.Precio, '' " & _
                                                      "FROM (ALBARANES_COMPRAS INNER JOIN COMUNICACIONES_ENTRADAS ON ALBARANES_COMPRAS.NumeroAlbaran = COMUNICACIONES_ENTRADAS.NumeroAlbaran) " & _
                                                      "INNER JOIN ARTICULOS ON COMUNICACIONES_ENTRADAS.CodigoArticulo = ARTICULOS.Codigo"
                                    cmd.ExecuteNonQuery()

                                    Me.lblFicheros.Text = "Actualizando existencias..."
                                    Me.lblFicheros.Refresh()
                                    cmd.CommandText = "UPDATE EXISTENCIAS " & _
                                                      "SET ExistenciaActual = ExistenciaActual + COMUNICACIONES_ENTRADAS.Cantidad " & _
                                                      "FROM (COMUNICACIONES_ENTRADAS INNER JOIN ARTICULOS ON COMUNICACIONES_ENTRADAS.CodigoArticulo = ARTICULOS.Codigo) " & _
                                                      "INNER JOIN EXISTENCIAS ON EXISTENCIAS.Articulo_Id = ARTICULOS.Id " & _
                                                      "WHERE EXISTENCIAS.CodigoTienda=" & CodigoTienda & " AND EXISTENCIAS.CodigoColor=0 AND EXISTENCIAS.CodigoTalla=1"
                                    cmd.ExecuteNonQuery()

                                    transaccion.Commit()

                                Catch ex As Exception
                                    MsgBox("Error al actualizar entradas de almacén." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
                                    transaccion.Rollback()
                                Finally
                                    sr.Close()
                                End Try

                            End If
                        Next
                    End If


                    'Actualizar inventario
                    RutaFichero = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\INVE" & Format(General.NumeroAlmacen, "00") & ".SEQ"

                    If IO.File.Exists(RutaFichero) Then

                        Me.lblFicheros.Text = "Creando tabla temporal de inventario..."
                        Me.lblFicheros.Refresh()

                        transaccion = conexion.BeginTransaction()
                        cmd.Transaction = transaccion

                        cmd.CommandText = "CrearTablaTemporal_Existencias"
                        cmd.ExecuteNonQuery()

                        transaccion.Commit()

                        Me.lblFicheros.Text = "Leyendo fichero de inventario"
                        Me.lblFicheros.Refresh()

                        Dim tExistencias As New dsComunicacionesTableAdapters.COMUNICACIONES_EXISTENCIASTableAdapter
                        Dim rExistencias As dsComunicaciones.COMUNICACIONES_EXISTENCIASRow

                        Dim sr As New System.IO.StreamReader(RutaFichero, System.Text.Encoding.Default, True)
                        Dim LineaActual As Integer = 0
                        Dim TotalLineas As Integer = sr.ReadToEnd().Split(vbCrLf).Length - 1
                        sr.Close()

                        sr = New System.IO.StreamReader(RutaFichero, System.Text.Encoding.Default, True)

                        Try
                            While sr.Peek() <> -1

                                LineaActual += 1
                                Me.pbRegistros.Text = Int(LineaActual / TotalLineas * 100)
                                Me.pbRegistros.Refresh()

                                Dim s As String = sr.ReadLine()

                                If String.IsNullOrEmpty(s) Then
                                    Continue While
                                End If

                                Dim Linea() As String

                                Linea = Split(s, vbTab)

                                'Me.lblRegistros.Text = "Leyendo inventario " & LineaActual & " de " & TotalLineas
                                'Me.lblRegistros.Refresh()

                                rExistencias = dsComunicaciones.COMUNICACIONES_EXISTENCIAS.NewCOMUNICACIONES_EXISTENCIASRow
                                rExistencias.CodigoTienda = CodigoTienda
                                rExistencias.CodigoArticulo = Linea(0)
                                If IsNumeric(Linea(1)) Then rExistencias.ExistenciaActual = CType(Linea(1), Decimal) Else rExistencias.ExistenciaActual = -99999999
                                rExistencias.StockMinimo = CType(Linea(2), Decimal)
                                rExistencias.StockMaximo = CType(Linea(3), Decimal)
                                dsComunicaciones.COMUNICACIONES_EXISTENCIAS.AddCOMUNICACIONES_EXISTENCIASRow(rExistencias)

                            End While

                            Me.lblFicheros.Text = "Actualizando inventario..."
                            Me.lblFicheros.Refresh()
                            'Me.lblRegistros.Text = String.Empty
                            'Me.lblRegistros.Refresh()

                            transaccion = conexion.BeginTransaction()
                            cmd.Transaction = transaccion

                            tExistencias.Update(dsComunicaciones.COMUNICACIONES_EXISTENCIAS)

                            'Actualizar entradas existentes
                            cmd.CommandText = "UPDATE EXISTENCIAS " & _
                                              "SET ExistenciaActual = CASE WHEN COMUNICACIONES_EXISTENCIAS.ExistenciaActual <> -99999999 THEN COMUNICACIONES_EXISTENCIAS.ExistenciaActual ELSE EXISTENCIAS.ExistenciaActual END, " & _
                                              "StockMinimo = CASE WHEN EXISTENCIAS.StockMinimo = 0 THEN COMUNICACIONES_EXISTENCIAS.StockMinimo ELSE EXISTENCIAS.StockMinimo END, " & _
                                              "StockMaximo = CASE WHEN EXISTENCIAS.StockMinimo = 0 THEN COMUNICACIONES_EXISTENCIAS.StockMaximo ELSE EXISTENCIAS.StockMaximo END " & _
                                              "FROM (ARTICULOS INNER JOIN EXISTENCIAS ON ARTICULOS.Id = EXISTENCIAS.Articulo_Id) " & _
                                              "INNER JOIN COMUNICACIONES_EXISTENCIAS ON ARTICULOS.Codigo = COMUNICACIONES_EXISTENCIAS.CodigoArticulo " & _
                                              "WHERE COMUNICACIONES_EXISTENCIAS.CodigoTienda=" & CodigoTienda & " AND EXISTENCIAS.CodigoColor=0 AND EXISTENCIAS.CodigoTalla=1"
                            cmd.ExecuteNonQuery()

                            transaccion.Commit()

                        Catch ex As Exception
                            MsgBox("Error al actualizar inventario." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
                            transaccion.Rollback()
                        Finally
                            sr.Close()
                        End Try

                    End If

                    'Actualizar fecha última actualización en tienda
                    transaccion = conexion.BeginTransaction()
                    cmd.Transaction = transaccion

                    Try
                        'Quitar marca actualizando e indicar fecha actualización
                        cmd.CommandText = "UPDATE TIENDAS SET Actualizando=0, FechaUltimaActualizacion = '" & Date.Today & "' WHERE CodigoTienda=" & CodigoTienda
                        cmd.ExecuteNonQuery()

                        transaccion.Commit()

                        'Copiar fichero báscula
                        Try
                            RutaFichero = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\TX.TXT"
                            If IO.File.Exists(RutaFichero) And IO.Directory.Exists(My.Settings.DirectorioBascula) Then
                                IO.File.Copy(RutaFichero, My.Settings.DirectorioBascula & "\TX.TXT", True)
                                'General.ReiniciarComunicacionBascula()
                            End If
                        Catch ex As Exception
                            MsgBox("Error al copiar fichero de comunicación para las básculas." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
                        End Try

                        'Eliminar ficheros
                        Try
                            Me.lblFicheros.Text = "Eliminando ficheros..."
                            Me.lblFicheros.Refresh()

                            For j = 0 To tFiles.Length - 1
                                IO.File.Delete(tFiles(j))
                            Next

                        Catch ex As Exception
                            MsgBox("Error al intentar eliminar los ficheros recibidos." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
                        End Try

                        Me.lblFicheros.Text = "Proceso finalizado."
                        Me.lblFicheros.Refresh()

                    Catch ex As Exception
                        MsgBox("Error al actualizar la fecha de actualización", MsgBoxStyle.Exclamation)
                        transaccion.Rollback()
                    End Try

                Catch ex As Exception
                    MsgBox("Error al actualizar los datos de la tienda" & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
                Finally
                    If conexion.State = ConnectionState.Open Then conexion.Close()
                End Try

            Else
                MsgBox("No puede conectar o no existe ninguna actualización disponible", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MsgBox("Error al intentar actualizar los datos." & vbCrLf & Err.Description, MsgBoxStyle.Exclamation)
        Finally
            Me.Close()
        End Try

    End Sub
#End Region

#Region "BackgroundWorker1_DoWork"
    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Recepcion()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "BackgroundWorker1_RunWorkerCompleted"
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MsgBox("Proceso de actualización finalizado", MsgBoxStyle.Information)
        Principal.Tag = String.Empty
    End Sub
#End Region

End Class