Public Class PromocionesEHLIS

#Region "PromocionesEHLIS_Load"
    Private Sub PromocionesEHLIS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.WebBrowser1.Navigate("https://www.cadena88.com/online")

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
            r.NumberFormat.CurrencyDecimalSeparator = ","
            r.NumberFormat.NumberDecimalSeparator = ","
            System.Threading.Thread.CurrentThread.CurrentCulture = r

            Dim sr As New IO.StreamReader(RutaFichero, System.Text.Encoding.Default)
            Dim linea() As String

            Dim Promocion As New dsPromociones
            Dim rPromocion As dsPromociones.PROMOCIONESRow = Nothing

            Dim ReferenciasNuevas As String = String.Empty

            Try
                'Leer primera línea cabecera
                sr.ReadLine()

                While Not sr.EndOfStream

                    linea = Split(sr.ReadLine, vbTab)

                    'Buscar artículo referencia EHLIS
                    Dim CodigoArticulo As String = Me.ArticuloReferencia(Me.txtCodigoProveedor.EditValue, Trim(linea(2)))
                    If CodigoArticulo = String.Empty Then
                        ReferenciasNuevas &= Trim(linea(2)) & ": " & Trim(linea(4)) & vbCrLf
                        Continue While
                    End If

                    If Me.ExistePromocion(CodigoArticulo, CDate(linea(7)), CDate(linea(8))) Then
                        Continue While
                    End If

                    rPromocion = Promocion.PROMOCIONES.NewPROMOCIONESRow
                    rPromocion.CodigoTienda = CodigoTienda
                    rPromocion.CodigoArticulo = CodigoArticulo
                    rPromocion.FechaInicio = CDate(linea(7))
                    rPromocion.FechaFinal = CDate(linea(8))
                    rPromocion.PrecioPromocion = CDec(linea(6))
                    Promocion.PROMOCIONES.AddPROMOCIONESRow(rPromocion)

                End While

                'If ReferenciasNuevas <> String.Empty Then
                '    MsgBox("Existen referencias sin artículo asociado: " & vbCrLf & vbCrLf & ReferenciasNuevas, MsgBoxStyle.Exclamation, "Referenicas nuevas")
                'End If

                Dim taPromocion As New dsPromocionesTableAdapters.PROMOCIONESTableAdapter

                taPromocion.Update(Promocion.PROMOCIONES)

                MsgBox("Promoción guardada correctamente", MsgBoxStyle.Information)

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

#Region "ExistePromocion"
    Private Function ExistePromocion(ByVal CodigoArticulo As String, ByVal FechaInicio As Date, ByVal FechaFin As Date) As Boolean

        Dim cmd As New SqlClient.SqlCommand

        Try
            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT COUNT(*) " & _
                              "FROM PROMOCIONES " & _
                              "WHERE CodigoArticulo = " & CodigoArticulo & " AND FechaInicio = '" & FechaInicio & "' AND FechaFinal = '" & FechaFin & "'"

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

End Class