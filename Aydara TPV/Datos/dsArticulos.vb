Partial Public Class dsArticulos

    Dim taMovimientos As New dsArticulosTableAdapters.MovimientosTableAdapter

    Public Function CargarMovimientos(ByVal IDArticulo As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date) As Integer
        Try
            Me.Movimientos.Clear()

            Me.taMovimientos.Fill(Me.Movimientos, IDArticulo, FechaDesde, FechaHasta)

            'Me.AñadeStock(IDArticulo)

            Return Me.Movimientos.Count
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub AñadeStock(ByVal IDArticulo As Integer)
        Try
            Dim miview As New DataView
            miview.Table = Me.Movimientos
            miview.Sort = "Fecha ASC"

            Dim StockInicial As Decimal = AGI2005.BaseDatos.ConsultaDevuelveValor("SELECT TOP 1 ExistenciaInicial FROM EXISTENCIAS WHERE Articulo_Id=" & IDArticulo, AGI2005.BaseDatos.TipoValor.NumDecimal, My.Settings.AydaraTPVConnectionString)

            Dim Actual As Decimal = StockInicial

            For i As Integer = 0 To miview.Count - 1
                With CType(miview(i).Row, MovimientosRow)
                    If .Entrada > 0 Then
                        Actual += .Entrada
                    ElseIf .Salida > 0 Then
                        Actual -= .Salida
                    End If

                    .Stock = Actual
                End With
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub EnviarDatosTerminal()
        Try
            Dim taArticulos As New dsArticulosTableAdapters.ARTICULOSTableAdapter
            Dim taCodigosBarras As New dsArticulosTableAdapters.CODIGO_BARRASTableAdapter

            taArticulos.Fill(Me.ARTICULOS)
            taCodigosBarras.Articulos(Me.CODIGO_BARRAS)

            Dim Directorio As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Terminales"

            If Not My.Computer.FileSystem.DirectoryExists(Directorio) Then IO.Directory.CreateDirectory(Directorio)

            'Fichero de artículos
            Dim sr As New IO.StreamWriter(Directorio & "\ARTICULO.SEQ", False, System.Text.Encoding.Default)
            Try
                For i As Integer = 0 To Me.ARTICULOS.Count - 1
                    With CType(ARTICULOS(i), dsArticulos.ARTICULOSRow)

                        Dim Linea As New System.Text.StringBuilder

                        'Código artículo
                        Linea.AppendFormat("{0:0000000}", CInt(.Codigo))
                        Linea.Append(vbTab)

                        'Descripción
                        Linea.Append(Mid(.Descripcion, 1, 40))
                        Linea.Append(vbTab)

                        'Tipo IVA
                        Linea.Append(.TipoIva)
                        Linea.Append(vbTab)

                        'Familia y subfamilia
                        Linea.Append("001")
                        Linea.Append(vbTab)
                        Linea.Append(String.Empty)

                        Linea.Append(vbTab)

                        'Proveedor
                        Linea.AppendFormat("{0:00000}", 1)
                        Linea.Append(vbTab)

                        'Código envase
                        Linea.AppendFormat(String.Empty)

                        Linea.Append(vbTab)

                        'Control etiquetas
                        Linea.Append(IIf(.ControlEtiquetas, "S", "N"))
                        Linea.Append(vbTab)

                        'Cantidad variable
                        Linea.Append(IIf(.CantidadVariable, "S", "N"))
                        Linea.Append(vbTab)

                        'Artículo de peso
                        Linea.Append(IIf(.ArticuloPeso, "S", "N"))
                        Linea.Append(vbTab)

                        'Control de baja
                        Linea.Append(IIf(.ControlBaja, "S", "N"))
                        Linea.Append(vbTab)

                        'Tipo de unidad
                        Dim TipoUnidad As String = String.Empty
                        Linea.Append(Mid(TipoUnidad, 1, 1))

                        Linea.Append(vbTab)

                        'Unidades/caja
                        Linea.Append(.UnidadCaja)
                        Linea.Append(vbTab)

                        'Mínimo venta
                        Linea.Append(1)
                        Linea.Append(vbTab)

                        'Mínimo compra
                        Linea.Append(1)
                        Linea.Append(vbTab)

                        'Peso
                        Linea.Append(.PesoUnidad)
                        Linea.Append(vbTab)

                        'Descuento
                        Linea.Append(0)
                        Linea.Append(vbTab)

                        'Precio coste
                        Linea.Append(.PrecioCoste)
                        Linea.Append(vbTab)

                        'Tarifa 4
                        Dim Tarifa4 As Double = 0
                        Linea.Append(Tarifa4)
                        Linea.Append(vbTab)

                        'Tarifa 6
                        Dim Tarifa6 As Double = 0
                        If Tarifa6 = 0 Then Tarifa6 = Tarifa4
                        Linea.Append(Tarifa6)
                        Linea.Append(vbTab)

                        'Tarifa 10
                        Dim Tarifa10 As Double = 0
                        Linea.Append(Tarifa10)
                        Linea.Append(vbTab)

                        'Tipo de artículo
                        Linea.Append(.TipoArticulo)

                        Linea.Append(vbTab)

                        'Unidades promoción
                        Linea.Append(0)
                        Linea.Append(vbTab)

                        'Precio promoción
                        Linea.Append(0)

                        sr.WriteLine(Linea)

                    End With
                Next

            Catch ex As Exception
                Throw ex
            Finally
                sr.Close()
            End Try

            'Fichero de código de barras
            Try
                sr = New IO.StreamWriter(Directorio & "\COBARRAS.SEQ", False, System.Text.Encoding.Default)

                For i As Integer = 0 To Me.CODIGO_BARRAS.Count - 1
                    With Me.CODIGO_BARRAS(i)

                        Dim Linea As New System.Text.StringBuilder

                        'Código de barras
                        Linea.Append(Trim(.CodigoBarras))
                        Linea.Append(vbTab)

                        'Código de artículo
                        Linea.AppendFormat("{0:0000000}", CInt(.CodigoArticulo))

                        sr.WriteLine(Linea)

                    End With
                Next
            Catch ex As Exception
                Throw ex
            Finally
                sr.Close()
            End Try

            If General.Comunicaciones_Terminales <> String.Empty Then
                Comunicacion.EnvioDatosTerminal(Directorio & "\ARTICULO.SEQ", "ARTICULO.SEQ")
                Comunicacion.EnvioDatosTerminal(Directorio & "\COBARRAS.SEQ", "COBARRAS.SEQ")
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub GeneraFicheroBalanzas()

        If Not My.Computer.FileSystem.DirectoryExists(DatosTienda.DirectorioFicheroBasculas) Then My.Computer.FileSystem.CreateDirectory(DatosTienda.DirectorioFicheroBasculas)
        Dim sw As New System.IO.StreamWriter(DatosTienda.DirectorioFicheroBasculas & "\BAL.DAT", False, System.Text.Encoding.Default)

        Try
            Dim taArticulos As New dsArticulosTableAdapters.ARTICULOSTableAdapter
            taArticulos.Fill(Me.ARTICULOS)

            Dim Articulos As DataRow() = Me.ARTICULOS.Select("ISNULL(PLU,0) > 0", "Codigo")

            For i As Integer = 0 To Articulos.Length - 1
                With CType(Articulos(i), dsArticulos.ARTICULOSRow)
                    sw.Write("010000000")
                    sw.Write(CInt(.Codigo).ToString("000000"))
                    sw.Write(.PLU.ToString("0000"))
                    sw.Write(CInt(IIf(.ControlBaja, 0, .Precio) * 100).ToString("0000000"))
                    sw.Write("00000000")
                    sw.Write("0")
                    sw.Write(String.Format("{0,-25}", Mid(.Descripcion, 1, 25)))
                    sw.Write("0")
                    sw.Write(String.Format("{0,-25}", String.Empty))
                    sw.Write("0")
                    sw.Write(String.Format("{0,-25}", String.Empty))
                    sw.Write("0")
                    sw.Write(String.Format("{0,-25}", String.Empty))
                    sw.Write("0")
                    sw.Write(String.Format("{0,-25}", String.Empty))
                    sw.Write("0")
                    sw.Write(String.Format("{0,-25}", String.Empty))
                    sw.Write("0")
                    sw.Write(String.Format("{0,-25}", String.Empty))
                    sw.Write("0")
                    sw.Write(String.Format("{0,-25}", String.Empty))
                    sw.Write("0")
                    sw.Write(String.Format("{0,-25}", String.Empty))
                    sw.Write("0")
                    sw.Write(String.Format("{0,-25}", String.Empty))
                    sw.Write("00")
                    sw.Write(.PLU.ToString("000"))
                    sw.Write("00P")
                    sw.WriteLine()
                End With
            Next

        Catch ex As Exception
            Throw ex
        Finally
            sw.Close()
        End Try

    End Sub

End Class
