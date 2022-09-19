Module Almacen

    Public Structure DatosPromocion
        Dim CodigoArticulo As String
        Dim Precio As Decimal
        Dim CodigoArticuloRegalo As String
        Dim FraccionSinCargo As Decimal
        Dim UnidadesSinCargo As Decimal
        Dim PrecioArticuloRegalo As Decimal
        Dim CodigoColorRegalo As Integer
        Dim NumeroTallaRegalo As Integer
        Dim FechaFinal As Date
        Dim Unidades As Decimal
    End Structure

    Public Structure DatosUnidad
        Dim Peso As Decimal
        Dim Descripcion As String
    End Structure

    Public Structure DatosExistencias
        Dim Id As Integer
        Dim ExistenciaInicial As Decimal
        Dim ExistenciaActual As Decimal
        Dim StockMinimo As Decimal
        Dim StockMaximo As Decimal
        Dim PrecioVenta As Decimal
    End Structure

#Region "DameDescripcionArticulo"
    Public Function DameDescripcionArticulo(ByVal CodigoArticulo As String)

        Dim Descripcion As String
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT Descripcion FROM ARTICULOS WHERE Codigo='" & CodigoArticulo & "'"

            Descripcion = cmd.ExecuteScalar

            If Descripcion Is Nothing Then Descripcion = "** ARTÍCULO NO EXISTE **"

        Catch ex As Exception
            Return String.Empty
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

        Return Descripcion

    End Function
#End Region

#Region "DamePrecioArticulo"
    Public Function DamePrecioArticulo(ByVal CodigoArticulo As String, ByVal CodigoColor As Integer, ByVal CodigoTalla As Integer)
        Try
            Dim Precio As Decimal
            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            If GestionTallas Or GestionColores Then
                cmd.CommandText = "SELECT PrecioVenta FROM Existencias INNER JOIN Articulos ON Articulos.Id=Existencias.Articulo_Id " & _
                                  "WHERE CodigoTienda=" & CodigoTienda & " AND Codigo='" & CodigoArticulo & "' AND CodigoColor=" & CodigoColor & " AND Existencias.CodigoTalla=" & CodigoTalla
                Precio = cmd.ExecuteScalar
            End If

            If Precio = 0 Then
                cmd.CommandText = "SELECT Precio FROM Articulos WHERE Codigo='" & CodigoArticulo & "'"
                Precio = cmd.ExecuteScalar
            End If

            cmd.Connection.Close()

            Return Precio

        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region

#Region "DamePrecioTarifa"
    Public Function DamePrecioTarifa(Tarifa As String, ByVal CodigoArticulo As String)

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

            cmd.Connection.Open()

            cmd.CommandText = "SELECT TARIFAS.Precio FROM TARIFAS INNER JOIN ARTICULOS ON ARTICULOS.Id = TARIFAS.Articulo_Id " & _
                              "WHERE Tarifa = '" & Tarifa & "' AND ARTICULOS.Codigo = '" & CodigoArticulo & "'"

            Return cmd.ExecuteScalar

        Catch ex As Exception
            Return 0
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try

    End Function
#End Region

#Region "DamePorcentajeIva"
    Public Function DamePorcentajeIva(ByVal CodigoArticulo As String)

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

            cmd.Connection.Open()

            cmd.CommandText = "SELECT TipoIVA FROM ARTICULOS WHERE Codigo = '" & CodigoArticulo & "'"

            Dim TipoIva As Integer = cmd.ExecuteScalar

            cmd.CommandText = "SELECT TipoIva" & TipoIva & " FROM TIENDAS WHERE CodigoTienda=" & CodigoTienda

            Return cmd.ExecuteScalar

        Catch ex As Exception
            Return 0
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try

    End Function
#End Region

#Region "IvaIncluidoTarifa"
    Public Function IvaIncluidoTarifa(Tarifa As String) As Boolean

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

            cmd.Connection.Open()

            cmd.CommandText = "SELECT TARIFAS.IvaIncluido FROM TARIFAS WHERE Tarifa = '" & Tarifa & "'"

            Return cmd.ExecuteScalar

        Catch ex As Exception
            Return 0
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try

    End Function
#End Region

#Region "DamePrecioCosteArticulo"
    Public Function DamePrecioCosteArticulo(ByVal CodigoArticulo As String)

        Dim Precio As Decimal
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT PrecioCoste FROM Articulos WHERE Codigo='" & CodigoArticulo & "'"

            Precio = cmd.ExecuteScalar

        Catch ex As Exception
            Precio = 0
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

        Return Precio

    End Function
#End Region

#Region "DameTallaArticulo"
    Public Function DameTallaArticulo(ByVal CodigoArticulo As String, ByVal CodigoTalla As Integer) As String
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim Talla As String

            If CodigoTalla <= 0 Then Return String.Empty : Exit Try

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT Talla_" & CodigoTalla & " FROM Tallas INNER JOIN Articulos ON Tallas.CodigoTalla=Articulos.CodigoTalla " & _
                              "WHERE Codigo='" & CodigoArticulo & "'"

            Talla = cmd.ExecuteScalar

            cmd.Connection.Close()

            Return Talla

        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
#End Region

#Region "DameDescripcionColor"
    Public Function DameDescripcionColor(ByVal CodigoColor As String)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim Color As String

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT Descripcion FROM COLORES WHERE CodigoColor=" & CodigoColor

            Color = cmd.ExecuteScalar

            cmd.Connection.Close()

            Return Color

        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
#End Region

#Region "DameColor"
    Public Function DameColor(ByVal CodigoColor As String)
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim Color As String

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT Color FROM COLORES WHERE CodigoColor=" & CodigoColor

            Color = cmd.ExecuteScalar

            cmd.Connection.Close()

            Return Color

        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
#End Region

#Region "DamePrecioPromocion"
    Public Function DamePrecioPromocion(ByVal CodigoArticulo As String, ByVal CodigoColor As Integer, ByVal CodigoTalla As Integer, Optional ByVal Cantidad As Decimal = 0) As DatosPromocion
        Try
            Dim dr As SqlClient.SqlDataReader
            Dim cmd As New SqlClient.SqlCommand
            Dim Promocion As DatosPromocion = Nothing
            Dim orden As Integer = 1 'Orden 1: color y talla, 2: solo talla, 3: solo color, 4 ni color ni talla

            If Not GestionColores Or Not GestionTallas Then
                If GestionTallas Then
                    orden = 2
                ElseIf GestionColores Then
                    orden = 3
                Else
                    orden = 4
                End If
            End If

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

SqlPromociones:
            cmd.CommandText = "SELECT * FROM Promociones " & _
                              "WHERE CodigoTienda=" & CodigoTienda & " AND CodigoArticulo='" & CodigoArticulo & "' " & _
                              "AND FechaInicio<='" & Date.Now & "' AND FechaFinal>='" & Date.Now & "' " & _
                              "AND Unidades <= " & Replace(Math.Abs(Cantidad), ",", ".")

            If orden = 1 Then
                cmd.CommandText += " AND CodigoColor=" & CodigoColor & " AND CodigoTalla=" & CodigoTalla
            ElseIf orden = 2 Then
                cmd.CommandText += " AND ISNULL(CodigoColor,-1)=-1 AND CodigoTalla=" & CodigoTalla
            ElseIf orden = 3 Then
                cmd.CommandText += " AND CodigoColor=" & CodigoColor & " AND ISNULL(CodigoTalla,-1)=-1"
            ElseIf orden = 4 Then
                cmd.CommandText += " AND ISNULL(CodigoColor,-1)=-1 AND ISNULL(CodigoTalla,-1)=-1"
            End If

            cmd.CommandText += " ORDER BY UNIDADES DESC, FechaFinal"

            dr = cmd.ExecuteReader

            If Not dr.HasRows Then

                dr.Close()
                orden += 1
                If orden = 3 And Not GestionColores Then orden = 4
                If orden <= 4 Then GoTo SqlPromociones

            Else

                If dr.Read Then
                    Promocion.CodigoArticulo = CodigoArticulo
                    Promocion.Precio = dr("PrecioPromocion")
                    Promocion.CodigoArticuloRegalo = dr("CodigoArticuloRegalo")
                    Promocion.FraccionSinCargo = dr("FraccionSinCargo")
                    Promocion.UnidadesSinCargo = dr("UnidadesSinCargo")
                    Promocion.PrecioArticuloRegalo = dr("PrecioArticuloRegalo")
                    Promocion.CodigoColorRegalo = IIf(orden = 1 Or orden = 3, CodigoColor, -1)
                    Promocion.NumeroTallaRegalo = IIf(orden = 1 Or orden = 2, CodigoTalla, -1)
                    Promocion.FechaFinal = dr("FechaFinal")
                    Promocion.Unidades = dr("Unidades")
                End If
                dr.Close()

            End If

            ''Comprobar promoción ficha del artículo
            'cmd.CommandText = "SELECT UnidadesPromocion, PrecioPromocion FROM ARTICULOS WHERE Codigo='" & CodigoArticulo & "'"
            'dr = cmd.ExecuteReader
            'If dr.Read Then
            '    If Cantidad >= CDec(dr("UnidadesPromocion")) Then
            '        Promocion.CodigoArticulo = CodigoArticulo
            '        Promocion.Precio = dr("PrecioPromocion")
            '    End If
            'End If
            'dr.Close()

            cmd.Connection.Close()

            Return Promocion

        Catch ex As Exception
            Return Nothing
        End Try
    End Function
#End Region

#Region "DameDescuentoArticulo"
    Public Function DameDescuentoArticulo(ByVal CodigoArticulo As String, ByVal GestionTarjetas As Boolean, CodigoCliente As Integer) As Decimal
        Try
            Dim cmd As New SqlClient.SqlCommand
            Dim Descuento As Decimal

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            If GestionTarjetas Then

                'Descuento del artículo - subfamilia - familia - cliente - tienda

                cmd.CommandText = "SELECT CASE WHEN Descuento<>0 THEN Descuento ELSE CASE WHEN SUBFAMILIASARTICULOS.DescuentoTarjeta<>0 THEN SUBFAMILIASARTICULOS.DescuentoTarjeta ELSE FAMILIASARTICULOS.DescuentoTarjeta END END " & _
                                  "FROM (Articulos INNER JOIN FAMILIASARTICULOS ON Articulos.CodigoFamilia=FAMILIASARTICULOS.Id) " & _
                                  "INNER JOIN SUBFAMILIASARTICULOS ON ARTICULOS.codigoSubfamilia=SUBFAMILIASARTICULOS.Id " & _
                                  "WHERE Articulos.Codigo='" & CodigoArticulo & "'"
                Descuento = cmd.ExecuteScalar

                If Descuento = 0 Then
                    cmd.CommandText = "SELECT DescuentoTarjeta FROM Clientes WHERE Codigo=" & CodigoCliente
                    Descuento = cmd.ExecuteScalar
                End If

                If Descuento = 0 Then Descuento = General.DescuentoTarjetas

            Else

                'Descuento del artículo

                cmd.CommandText = "SELECT Descuento  " & _
                                  "FROM Articulos " & _
                                  "WHERE Articulos.Codigo='" & CodigoArticulo & "'"
                Descuento = cmd.ExecuteScalar

            End If

            cmd.Connection.Close()

            Return Descuento

        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region

#Region "DameMinimoCompraArticulo"
    Public Function DameMinimoCompraArticulo(ByVal CodigoArticulo As String)

        Dim MinimoCompra As Decimal
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT MinimoCompra " & _
                              "FROM Articulos " & _
                              "WHERE Codigo='" & CodigoArticulo & "'"

            MinimoCompra = cmd.ExecuteScalar

        Catch ex As Exception
            MinimoCompra = 0
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

        Return MinimoCompra

    End Function
#End Region

#Region "DameMinimoVentaArticulo"
    Public Function DameMinimoVentaArticulo(ByVal CodigoArticulo As String)

        Dim MinimoVenta As Decimal
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT MinimoVenta " & _
                              "FROM Articulos " & _
                              "WHERE Codigo='" & CodigoArticulo & "'"

            MinimoVenta = cmd.ExecuteScalar

        Catch ex As Exception
            MinimoVenta = 0
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

        Return MinimoVenta

    End Function
#End Region

#Region "DameEquivalenciaArticulo"
    Public Function DameEquivalenciaArticulo(ByVal CodigoArticulo As String)

        Dim MinimoVenta As Decimal
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT Equivalencia " & _
                              "FROM Articulos " & _
                              "WHERE Codigo='" & CodigoArticulo & "'"

            MinimoVenta = cmd.ExecuteScalar

        Catch ex As Exception
            MinimoVenta = 0
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

        Return MinimoVenta

    End Function
#End Region

#Region "ActualizaStock"
    Public Sub ActualizaStock(ByVal CodigoArticulo As String, ByVal CodigoColor As Integer, ByVal CodigoTalla As Integer, ByVal Cantidad As Decimal)
        Try
            Dim dtExistencias As New dsArticulos.EXISTENCIASDataTable
            Dim taExistencias As New dsArticulosTableAdapters.EXISTENCIASTableAdapter
            Dim rExistencias As dsArticulos.EXISTENCIASRow

            Dim cmd As New SqlClient.SqlCommand
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            'Si no utiliza gestión tallas/colores (-1) aplicamos valor por defecto de existencias
            If CodigoColor = -1 Then CodigoColor = 0
            If CodigoTalla = -1 Then CodigoTalla = 1

            cmd.CommandText = "SELECT Existencias.* FROM Articulos INNER JOIN Existencias ON Articulos.Id=Existencias.Articulo_Id " & _
                            "WHERE CodigoTienda=" & CodigoTienda & " AND Codigo='" & CodigoArticulo & "' " & _
                            " AND Codigocolor=" & CodigoColor & " AND Existencias.CodigoTalla=" & CodigoTalla

            dtExistencias.Load(CType(cmd.ExecuteReader, SqlClient.SqlDataReader))

            If dtExistencias.Rows.Count > 0 Then
                rExistencias = dtExistencias.Rows(0)
                rExistencias.ExistenciaActual += Cantidad
                taExistencias.Update(dtExistencias)
            End If

        Catch ex As Exception
            MsgBox("Error al actualizar stock del artículo " & CodigoArticulo)
        End Try
    End Sub
#End Region

#Region "ActualizaExistencias"
    Public Sub ActualizaExistencias(ByVal Existencias_Id As Integer, ByVal ExistenciaInicial As Decimal, ByVal ExistenciaActual As Decimal, ByVal StockMinimo As Decimal, ByVal StockMaximo As Decimal, ByVal PrecioVenta As Decimal)

        Dim dtExistencias As New dsArticulos.EXISTENCIASDataTable
        Dim taExistencias As New dsArticulosTableAdapters.EXISTENCIASTableAdapter
        Dim rExistencias As dsArticulos.EXISTENCIASRow

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT * FROM Existencias WHERE EXISTENCIAS.Id=" & Existencias_Id

            dtExistencias.Load(CType(cmd.ExecuteReader, SqlClient.SqlDataReader))

            If dtExistencias.Rows.Count > 0 Then
                rExistencias = dtExistencias.Rows(0)
                rExistencias.ExistenciaInicial = ExistenciaInicial
                rExistencias.ExistenciaActual = ExistenciaActual
                rExistencias.StockMinimo = StockMinimo
                rExistencias.StockMaximo = StockMaximo
                rExistencias.PrecioVenta = PrecioVenta
                taExistencias.Update(dtExistencias)
            End If

        Catch ex As Exception
            MsgBox("Error al actualizar existencias." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try
    End Sub
#End Region

#Region "ActualizaPrecio"
    Public Sub ActualizaPrecio(ByVal CodigoArticulo As String, ByVal CodigoColor As Integer, ByVal CodigoTalla As Integer, ByVal Precio As Decimal, Optional ByVal CreaEtiqueta As Boolean = False)

        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
        cmd.Connection.Open()

        Try
            If Not GestionColores And Not GestionTallas Then 'Actualiza precio del artículo

                Dim dtArticulos As New dsArticulos.ARTICULOSDataTable
                Dim taArticulos As New dsArticulosTableAdapters.ARTICULOSTableAdapter
                Dim rArticulos As dsArticulos.ARTICULOSRow

                cmd.CommandText = "SELECT * FROM Articulos WHERE Codigo='" & CodigoArticulo & "'"

                dtArticulos.Load(CType(cmd.ExecuteReader, SqlClient.SqlDataReader))

                If dtArticulos.Rows.Count > 0 Then
                    rArticulos = dtArticulos.Rows(0)
                    rArticulos.Precio = Precio
                    taArticulos.Update(dtArticulos)
                End If

            Else 'Actualiza precio de la talla/color del artículo

                Dim dtExistencias As New dsArticulos.EXISTENCIASDataTable
                Dim taExistencias As New dsArticulosTableAdapters.EXISTENCIASTableAdapter
                Dim rExistencias As dsArticulos.EXISTENCIASRow

                cmd.CommandText = "SELECT Existencias.* FROM Articulos INNER JOIN Existencias ON Articulos.Id=Existencias.Articulo_Id " & _
                                  "WHERE Codigo='" & CodigoArticulo & "' AND Codigocolor=" & CodigoColor & " AND Existencias.CodigoTalla=" & CodigoTalla

                dtExistencias.Load(CType(cmd.ExecuteReader, SqlClient.SqlDataReader))

                If dtExistencias.Rows.Count > 0 Then
                    rExistencias = dtExistencias.Rows(0)
                    rExistencias.PrecioVenta = Precio
                    taExistencias.Update(dtExistencias)
                End If

            End If

            If CreaEtiqueta Then
                cmd.CommandText = "SELECT Count(CodigoArticulo) FROM ETIQUETAS " & _
                                  "WHERE CodigoArticulo='" & CodigoArticulo & "' AND CodigoColor=" & CodigoColor & " AND CodigoTalla=" & CodigoTalla

                If cmd.ExecuteScalar = 0 Then

                    cmd.CommandText = "SELECT ControlEtiquetas FROM ARTICULOS WHERE Codigo='" & CodigoArticulo & "'"

                    If cmd.ExecuteScalar = True Then

                        Dim dtEtiquetas As New dsEtiquetas.ETIQUETASDataTable
                        Dim taEtiquetas As New dsEtiquetasTableAdapters.ETIQUETASTableAdapter
                        Dim rEtiquetas As dsEtiquetas.ETIQUETASRow

                        rEtiquetas = dtEtiquetas.NewETIQUETASRow
                        rEtiquetas.CodigoArticulo = CodigoArticulo
                        rEtiquetas.CodigoColor = CodigoColor
                        rEtiquetas.CodigoTalla = CodigoTalla
                        rEtiquetas.Etiquetas = 1
                        dtEtiquetas.AddETIQUETASRow(rEtiquetas)
                        taEtiquetas.Update(dtEtiquetas)

                    End If

                End If

            End If

        Catch ex As Exception
            MsgBox("Error al actualizar precio del artículo " & CodigoArticulo)
        End Try

        cmd.Connection.Close()

    End Sub
#End Region

#Region "ActualizaPrecioCoste"
    Public Sub ActualizaPrecioCoste(ByVal CodigoArticulo As String, ByVal PrecioCoste As Decimal)

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            Dim dtArticulos As New dsArticulos.ARTICULOSDataTable
            Dim taArticulos As New dsArticulosTableAdapters.ARTICULOSTableAdapter
            Dim rArticulos As dsArticulos.ARTICULOSRow

            cmd.CommandText = "SELECT * FROM Articulos WHERE Codigo='" & CodigoArticulo & "'"

            dtArticulos.Load(CType(cmd.ExecuteReader, SqlClient.SqlDataReader))

            If dtArticulos.Rows.Count > 0 Then
                rArticulos = dtArticulos.Rows(0)
                rArticulos.PrecioCoste = PrecioCoste
                taArticulos.Update(dtArticulos)
            End If

        Catch ex As Exception
            MsgBox("Error al actualizar precio del artículo " & CodigoArticulo)
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try

    End Sub
#End Region

#Region "ActualizaPrecioCoste"
    Public Sub ActualizaPrecioCoste(ByVal CodigoArticulo As String, ByVal CodigoProveedor As Integer, ByVal Referencia As String, ByVal PrecioCoste As Decimal)

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            Dim dtReferencias As New dsArticulos.REFERENCIAS_PROVEEDORESDataTable
            Dim taReferencias As New dsArticulosTableAdapters.REFERENCIAS_PROVEEDORESTableAdapter
            Dim rReferencia As dsArticulos.REFERENCIAS_PROVEEDORESRow

            cmd.CommandText = "SELECT * FROM REFERENCIAS_PROVEEDORES " & _
                              "INNER JOIN ARTICULOS ON ARTICULOS.Id = REFERENCIAS_PROVEEDORES.Articulo_Id " & _
                              "WHERE ARTICULOS.Codigo='" & CodigoArticulo & "' " & _
                              "AND REFERENCIAS_PROVEEDORES.CodigoProveedor = " & CodigoProveedor & " AND REFERENCIAS_PROVEEDORES.Referencia = '" & Referencia & "'"

            dtReferencias.Load(CType(cmd.ExecuteReader, SqlClient.SqlDataReader))

            If dtReferencias.Rows.Count > 0 Then
                rReferencia = dtReferencias.Rows(0)
                rReferencia.PrecioCoste = PrecioCoste
                taReferencias.Update(dtReferencias)
            End If

        Catch ex As Exception
            MsgBox("Error al actualizar precio del artículo " & CodigoArticulo)
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try

    End Sub
#End Region

#Region "DameDatosUnidadArticulo"
    Public Function DameDatosUnidadArticulo(ByVal CodigoArticulo As String) As DatosUnidad

        Dim Datos As New DatosUnidad
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT ISNULL(ARTICULOS.PesoUnidad,0) AS PesoUnidad, ISNULL(TIPOS_UNIDADES.Descripcion,'') AS Descripcion " & _
                              "FROM ARTICULOS LEFT JOIN TIPOS_UNIDADES ON ARTICULOS.TipoUnidad_Id=TIPOS_UNIDADES.Id " & _
                              "WHERE ARTICULOS.Codigo='" & CodigoArticulo & "'"

            dr = cmd.ExecuteReader
            If dr.Read Then
                Datos.Peso = dr("PesoUnidad")
                Datos.Descripcion = dr("Descripcion")
            End If
            dr.Close()

        Catch ex As Exception
            Datos = Nothing
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

        Return Datos

    End Function
#End Region

#Region "DameUnidadesCajaArticulo"
    Public Function DameUnidadesCajaArticulo(ByVal CodigoArticulo As String)

        Dim UnidadesCaja As Decimal
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT UnidadCaja FROM Articulos WHERE Codigo='" & CodigoArticulo & "'"

            UnidadesCaja = cmd.ExecuteScalar

            cmd.Connection.Close()

        Catch ex As Exception
            UnidadesCaja = 0
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

        Return UnidadesCaja

    End Function
#End Region

#Region "DatosExistenciasArticulo"
    Public Function DatosExistenciasArticulo(ByVal CodigoArticulo As String, ByVal CodigoColor As Integer, ByVal CodigoTalla As Integer) As DatosExistencias

        Dim Datos As New DatosExistencias
        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT * FROM Existencias INNER JOIN Articulos ON Articulos.Id=Existencias.Articulo_Id " & _
                              "WHERE CodigoTienda=" & CodigoTienda & " AND Codigo='" & CodigoArticulo & "' AND CodigoColor=" & CodigoColor & " AND Existencias.CodigoTalla=" & CodigoTalla

            dr = cmd.ExecuteReader
            If dr.Read Then
                Datos.Id = dr("Id")
                Datos.ExistenciaInicial = dr("ExistenciaInicial")
                Datos.ExistenciaActual = dr("ExistenciaActual")
                Datos.StockMinimo = dr("StockMinimo")
                Datos.StockMaximo = dr("StockMaximo")
                Datos.PrecioVenta = dr("PrecioVenta")
            End If
            dr.Close()

            cmd.Connection.Close()

        Catch ex As Exception
            Datos = Nothing
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

        Return Datos

    End Function
#End Region

End Module
