Partial Class dsEHLIS

    Public Sub ActualizarPrecios(ByVal CodigoProveedor As Integer, ByVal ActualizaCoste As Boolean, ByVal IncrementoCoste As Decimal, ByVal ActualizaVenta As Boolean, ByVal IncrementoVenta As Decimal, ByVal GeneraEtiquetas As Boolean, ByVal CrearCodigoBarras As Boolean)

        Dim fWait As New DevExpress.Utils.WaitDialogForm("", "Actualizando precios")

        Try
            Dim rTarifa As dsEHLIS.TarifasRow

            Dim Articulo As New dsArticulos
            Dim taArticulos As New dsArticulosTableAdapters.ARTICULOSTableAdapter

            Dim taReferencias As New dsArticulosTableAdapters.REFERENCIAS_PROVEEDORESTableAdapter

            Dim taCodigoBarras As New dsArticulosTableAdapters.CODIGO_BARRASTableAdapter
            Dim rCodigoBarras As dsArticulos.CODIGO_BARRASRow

            Dim Etiquetas As New dsEtiquetas
            Dim taEtiquetas As New dsEtiquetasTableAdapters.ETIQUETASTableAdapter
            Dim rEtiqueta As dsEtiquetas.ETIQUETASRow

            'Actualizar costes
            Dim Tarifas As DataRow() = Me.Tarifas.Select("ISNULL(Codigo,'') <> ''")

            If Tarifas.Length > 0 Then

                For i As Integer = 0 To Tarifas.Length - 1

                    rTarifa = Tarifas(i)

                    Articulo.Clear()
                    taArticulos.DameArticulo(Articulo.ARTICULOS, rTarifa.Codigo)

                    If Articulo.ARTICULOS.Count > 0 Then
                        With DirectCast(Articulo.ARTICULOS(0), dsArticulos.ARTICULOSRow)

                            fWait.SetCaption("Actualizando artículo " & i + 1 & " de " & Tarifas.Length)

                            'Actualiza precios referencia
                            taReferencias.FillBy(Articulo.REFERENCIAS_PROVEEDORES, .Id)

                            Dim Referencia As DataRow() = Articulo.REFERENCIAS_PROVEEDORES.Select("CodigoProveedor = " & CodigoProveedor)
                            If Referencia.Length > 0 Then

                                With DirectCast(Referencia(0), dsArticulos.REFERENCIAS_PROVEEDORESRow)
                                    .PrecioVenta = rTarifa.PVR
                                    If ActualizaCoste Then .PrecioCoste = rTarifa.PrecioCoste + Math.Round(rTarifa.PrecioCoste * IncrementoCoste / 100, 3, MidpointRounding.AwayFromZero)
                                End With

                                taReferencias.Update(Articulo.REFERENCIAS_PROVEEDORES)

                            End If

                            'Actualiza precio venta artículo
                            If ActualizaVenta Then

                                Dim PrecioVenta As Decimal = rTarifa.PVR + Math.Round(rTarifa.PVR * IncrementoVenta / 100, DecimalesPrecio, MidpointRounding.AwayFromZero)

                                If .Precio <> PrecioVenta Then
                                    .Precio = PrecioVenta
                                    taArticulos.Update(Articulo.ARTICULOS)

                                    If GeneraEtiquetas Then

                                        Dim dr As SqlClient.SqlDataReader = Nothing
                                        Dim cmd As New SqlClient.SqlCommand

                                        Try
                                            'Comprobar que la etiqueta no exista en la base de datos
                                            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                                            cmd.Connection.Open()
                                            cmd.CommandText = "SELECT COUNT(*) FROM ETIQUETAS WHERE CodigoArticulo='" & .Codigo & "'"
                                            dr = cmd.ExecuteReader
                                            If dr.Read Then
                                                Exit Try
                                            End If

                                            rEtiqueta = Etiquetas.ETIQUETAS.NewETIQUETASRow
                                            rEtiqueta.CodigoArticulo = .Codigo
                                            Etiquetas.ETIQUETAS.AddETIQUETASRow(rEtiqueta)

                                            taEtiquetas.Update(Etiquetas.ETIQUETAS)

                                        Catch ex As Exception
                                            Throw ex
                                        Finally
                                            If Not dr.IsClosed Then dr.Close()
                                            If Not cmd.Connection Is Nothing Then
                                                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                                            End If
                                        End Try

                                    End If

                                End If

                            End If

                            If CrearCodigoBarras Then

                                taCodigoBarras.Articulo(Articulo.CODIGO_BARRAS, .Id)

                                Dim CodigoBarras As DataRow() = Articulo.CODIGO_BARRAS.Select("CodigoBarras = " & rTarifa.EAN)

                                If CodigoBarras.Length = 0 Then

                                    Dim dr As SqlClient.SqlDataReader = Nothing
                                    Dim cmd As New SqlClient.SqlCommand

                                    Try
                                        'Comprobar que el código de barras no exista en la base de datos
                                        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
                                        cmd.Connection.Open()
                                        cmd.CommandText = "SELECT * FROM CODIGO_BARRAS LEFT JOIN ARTICULOS ON ARTICULOS.Id=CODIGO_BARRAS.Articulo_Id " & _
                                                          "WHERE CodigoBarras='" & rTarifa.EAN & "'"
                                        dr = cmd.ExecuteReader
                                        If dr.Read Then
                                            'MsgBox(rTarifa.Codigo & ": " & rTarifa.Descripcion & "(" & rTarifa.EAN & ")" & vbCrLf & "Ya existe ese código de barras asociado al artículo: " & dr("Codigo") & " - " & dr("Descripcion"), MsgBoxStyle.Information, "Ya existe")
                                            Exit Try
                                        End If

                                        rCodigoBarras = Articulo.CODIGO_BARRAS.NewCODIGO_BARRASRow
                                        rCodigoBarras.CodigoBarras = rTarifa.EAN
                                        rCodigoBarras.Articulo_Id = .Id
                                        Articulo.CODIGO_BARRAS.AddCODIGO_BARRASRow(rCodigoBarras)

                                        taCodigoBarras.Update(Articulo.CODIGO_BARRAS)

                                    Catch ex As Exception
                                        Throw ex
                                    Finally
                                        If Not dr.IsClosed Then dr.Close()
                                        If Not cmd.Connection Is Nothing Then
                                            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
                                        End If
                                    End Try

                                End If

                            End If

                        End With
                    End If

                Next

            End If

        Catch ex As Exception
            Throw ex
        Finally
            fWait.Close()
        End Try
    End Sub

End Class
