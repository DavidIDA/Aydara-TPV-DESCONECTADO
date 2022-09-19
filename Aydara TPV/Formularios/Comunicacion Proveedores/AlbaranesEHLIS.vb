Public Class AlbaranesEHLIS

#Region "AlbaranesEHLIS_Load"
    Private Sub AlbaranesEHLIS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.WebBrowser1.Navigate("https://www.cadena88.com/online/importacion/albaranes.php")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "Eventos txtCodigoproveedor"
    Private Sub txtCodigoproveedor_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtCodigoProveedor.ButtonClick
        Try
            Dim dsProveedores As New dsProveedores, tProveedores As New dsProveedoresTableAdapters.PROVEEDORESTableAdapter
            Dim Columnas As New ArrayList

            Columnas.Add("Codigo") 'Campo
            Columnas.Add("Código") 'Encabezado
            Columnas.Add(80) 'Tamaño columna
            Columnas.Add(80) 'Tamaño máximo columna

            Columnas.Add("Nombre")
            Columnas.Add("Nombre Fiscal")
            Columnas.Add(0)
            Columnas.Add(0)

            Columnas.Add("Direccion")
            Columnas.Add("Dirección")
            Columnas.Add(0)
            Columnas.Add(0)

            tProveedores.Fill(dsProveedores.PROVEEDORES)

            If Buscar(dsProveedores, "Proveedores", Columnas, 1).ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.txtCodigoProveedor.EditValue = ResultadoBusqueda
            End If

        Catch ex As Exception
            MsgBox("Error al mostrar listado de proveedores", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtCodigoProveedor_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoProveedor.EditValueChanged
        Try
            If Me.txtCodigoProveedor.IsModified Then Me.DatosProveedor()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DatosProveedor()
        Try
            If Not IsNumeric(Me.txtCodigoProveedor.EditValue) Then
                Me.txtNombreProveedor.Text = String.Empty
                Exit Sub
            End If

            Dim cmd As New SqlClient.SqlCommand

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()
            cmd.CommandText = "SELECT Nombre FROM PROVEEDORES WHERE Codigo=" & Int(Me.txtCodigoProveedor.EditValue)

            Me.txtNombreProveedor.Text = cmd.ExecuteScalar

            cmd.Connection.Close()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region

#Region "bttImportarFichero_Click"
    Private Sub bttImportarFichero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttImportarFichero.Click

        If Not IsNumeric(Me.txtCodigoProveedor.EditValue) Then
            MsgBox("Indique el código del proveedor EHLIS", MsgBoxStyle.Information)
            Me.txtCodigoProveedor.Focus()
            Exit Sub
        End If

        Dim BuscaFichero As New OpenFileDialog
        Dim RutaFichero As String = String.Empty

        'Configuración punto decimal
        Dim r As New Globalization.CultureInfo("es-ES")
        Dim CurrencyDecimalSeparator As String = r.NumberFormat.CurrencyDecimalSeparator
        Dim NumberDecimalSeparator As String = r.NumberFormat.CurrencyDecimalSeparator

        Try
            If BuscaFichero.ShowDialog = Windows.Forms.DialogResult.OK Then
                RutaFichero = BuscaFichero.FileName
            Else
                Exit Try
            End If

            If RutaFichero = String.Empty Then Exit Try

            'Configuración punto decimal
            r.NumberFormat.CurrencyDecimalSeparator = "."
            r.NumberFormat.NumberDecimalSeparator = "."
            System.Threading.Thread.CurrentThread.CurrentCulture = r

            Dim sr As New IO.StreamReader(RutaFichero, System.Text.Encoding.Default)
            Dim linea As String

            Dim Albaran As New dsAlbaranesCompras
            Dim rCabecera As dsAlbaranesCompras.ALBARANES_COMPRASRow = Nothing
            Dim rLinea As dsAlbaranesCompras.ALBARANES_COMPRAS_LINEASRow = Nothing

            Dim ReferenciasNuevas As String = String.Empty

            Try
                While Not sr.EndOfStream

                    linea = sr.ReadLine

                    Select Case Mid(linea, 1, 1)

                        Case "C"
                            'Comprobar si existe albarán
                            If Me.ExisteAlbaran(Me.txtCodigoProveedor.EditValue, Mid(linea, 2, 10)) Then
                                MsgBox("Ya existe un albarán del proveedor con ese número", MsgBoxStyle.Exclamation)
                                Exit Try
                            End If

                            rCabecera = Albaran.ALBARANES_COMPRAS.NewALBARANES_COMPRASRow
                            rCabecera.CodigoTienda = CodigoTienda
                            rCabecera.NumeroAlbaran = Mid(linea, 2, 10)
                            rCabecera.Fecha = New Date(Mid(linea, 12, 4), Mid(linea, 16, 2), Mid(linea, 18, 2))
                            rCabecera.CodigoProveedor = Me.txtCodigoProveedor.EditValue
                            rCabecera.NombreProveedor = Me.txtNombreProveedor.EditValue
                            Albaran.ALBARANES_COMPRAS.AddALBARANES_COMPRASRow(rCabecera)

                        Case "L"

                            'Buscar artículo referencia EHLIS
                            Dim CodigoArticulo As String = Me.ArticuloReferencia(Me.txtCodigoProveedor.EditValue, Trim(Mid(linea, 40, 12)))
                            If CodigoArticulo = String.Empty Then
                                ReferenciasNuevas &= Trim(Mid(linea, 40, 12)) & ": " & Trim(Mid(linea, 52, 70)) & vbCrLf
                                Continue While
                            End If

                            If rCabecera Is Nothing Then Continue While

                            rLinea = Albaran.ALBARANES_COMPRAS_LINEAS.NewALBARANES_COMPRAS_LINEASRow
                            rLinea.AlbaranCompra_Id = rCabecera.Id
                            rLinea.CodigoArticulo = CodigoArticulo
                            rLinea.Descripcion = Trim(Mid(linea, 52, 70))
                            rLinea.Cantidad = Mid(linea, 122, 10)
                            rLinea.Precio = Mid(linea, 144, 10)
                            rLinea.Total = Mid(linea, 131, 13)
                            If Mid(linea, 144, 10) <> Mid(linea, 154, 10) Then
                                rLinea.Descuento = (1 - Math.Round(rLinea.Total / rLinea.Precio, 2, MidpointRounding.AwayFromZero)) * 100
                            End If
                            rLinea.Observaciones = Trim(Mid(linea, 41, 11))
                            Albaran.ALBARANES_COMPRAS_LINEAS.AddALBARANES_COMPRAS_LINEASRow(rLinea)

                    End Select

                End While

                If ReferenciasNuevas <> String.Empty Then
                    MsgBox("Existen referencias sin artículo asociado: " & vbCrLf & vbCrLf & ReferenciasNuevas, MsgBoxStyle.Exclamation, "Referenicas nuevas")
                Else

                    Dim taCabecera As New dsAlbaranesComprasTableAdapters.ALBARANES_COMPRASTableAdapter
                    Dim taLineas As New dsAlbaranesComprasTableAdapters.ALBARANES_COMPRAS_LINEASTableAdapter

                    taCabecera.Update(Albaran.ALBARANES_COMPRAS)
                    taLineas.Update(Albaran.ALBARANES_COMPRAS_LINEAS)

                    Me.ActualizaStockAlbaran(Albaran)
                    Me.ActualizaCostes(Albaran)

                    MsgBox("Albarán guardado correctamente", MsgBoxStyle.Information)

                End If

            Catch ex As Exception
                Throw ex
            Finally
                sr.Close()
                'Configuración punto decimal
                r.NumberFormat.CurrencyDecimalSeparator = CurrencyDecimalSeparator
                r.NumberFormat.NumberDecimalSeparator = NumberDecimalSeparator
                System.Threading.Thread.CurrentThread.CurrentCulture = r
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "ExisteAlbaran"
    Private Function ExisteAlbaran(ByVal CodigoProveedor As Integer, ByVal NumAlbaran As String) As Boolean

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT COUNT(*) " & _
                              "FROM ALBARANES_COMPRAS " & _
                              "WHERE CodigoProveedor = " & CodigoProveedor & " AND NumeroAlbaran = '" & NumAlbaran & "'"

            Return (cmd.ExecuteScalar > 0)

        Catch ex As Exception
            Return False
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try

    End Function
#End Region

#Region "ArticuloReferencia"
    Private Function ArticuloReferencia(ByVal CodigoProveedor As Integer, ByVal Referencia As String) As String

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT ISNULL(ARTICULOS.Codigo,'') " & _
                              "FROM ARTICULOS INNER JOIN REFERENCIAS_PROVEEDORES ON ARTICULOS.Id = REFERENCIAS_PROVEEDORES.Articulo_Id " & _
                              "WHERE REFERENCIAS_PROVEEDORES.CodigoProveedor = " & CodigoProveedor & " AND REFERENCIAS_PROVEEDORES.Referencia = '" & Referencia & "'"

            Return cmd.ExecuteScalar

        Catch ex As Exception
            Return String.Empty
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
        End Try

    End Function
#End Region

#Region "ActualizaStockAlbaran"
    Private Sub ActualizaStockAlbaran(ByVal Albaran As dsAlbaranesCompras)
        Try
            For i As Integer = 0 To Albaran.ALBARANES_COMPRAS_LINEAS.Rows.Count - 1
                With Albaran.ALBARANES_COMPRAS_LINEAS(i)
                    Almacen.ActualizaStock(.CodigoArticulo, 0, 1, .Cantidad)
                End With
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region "ActualizaCostes"
    Private Sub ActualizaCostes(ByVal Albaran As dsAlbaranesCompras)
        Try
            For i As Integer = 0 To Albaran.ALBARANES_COMPRAS_LINEAS.Rows.Count - 1
                With Albaran.ALBARANES_COMPRAS_LINEAS(i)
                    If Me.checkActualizarCostesFicha.Checked Then
                        Almacen.ActualizaPrecioCoste(.CodigoArticulo, IIf(.Descuento <> 0, Math.Round(.Total / .Cantidad, 3, MidpointRounding.AwayFromZero), .Precio))
                    End If
                    If Me.checkActualizarCostesReferencia.Checked Then
                        Almacen.ActualizaPrecioCoste(.CodigoArticulo, Me.txtCodigoProveedor.EditValue, .Observaciones, IIf(.Descuento <> 0, Math.Round(.Total / .Cantidad, 3, MidpointRounding.AwayFromZero), .Precio))
                    End If
                End With
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

End Class