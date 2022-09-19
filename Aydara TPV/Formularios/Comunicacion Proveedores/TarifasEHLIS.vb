Public Class TarifasEHLIS 

    Private Sub TarifasEHLIS_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim RutaFichero As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV"

            'Descargar fichero
            My.Computer.Network.DownloadFile("https://www.cadena88.com/Tarifas/TarifaACG00000.zip", RutaFichero & "\TarifaEHLIS.zip", General.Comunicaciones_Usuario, General.Comunicaciones_Password, True, 100000, True)

            'Descomprimir fichero
            AGI2005.ICSharpZLib.Descomprimir(RutaFichero, RutaFichero & "\TarifaEHLIS.zip", True, False)

            'Leer fichero
            Dim sr As New System.IO.StreamReader(RutaFichero & "\TarifaACG00000.txt", System.Text.Encoding.Default, True)

            Try
                'Configuración punto decimal
                Dim r As New Globalization.CultureInfo("es-ES")
                r.NumberFormat.CurrencyDecimalSeparator = ","
                r.NumberFormat.NumberDecimalSeparator = "."
                System.Threading.Thread.CurrentThread.CurrentCulture = r

                Dim rTarifa As dsEHLIS.TarifasRow

                While sr.Peek() <> -1

                    Dim s As String = sr.ReadLine()
                    Dim Linea() As String = Split(s, "|")

                    If Linea.Length < 10 Then Continue While

                    rTarifa = Me.DsEHLIS.Tarifas.NewRow

                    With rTarifa

                        'Datos tarifa
                        .Referencia = Trim(Linea(0) & Linea(1) & Linea(2))
                        .Descripcion = Linea(3)
                        .PrecioCoste = CDec(Linea(6))
                        .PVR = CDec(Linea(7))
                        .EAN = Linea(8)
                        .Familia = Linea(9)

                    End With

                    Me.DsEHLIS.Tarifas.AddTarifasRow(rTarifa)

                End While

            Catch ex As Exception
                Throw ex
            Finally
                sr.Close()
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub DatosArticulo()

        Dim fWait As New DevExpress.Utils.WaitDialogForm("", "Comprobando artículos")

        Try
            Dim Tarifa As DataRow()
            Dim rTarifa As dsEHLIS.TarifasRow

            Dim taReferencias As New dsEHLISTableAdapters.ReferenciasTableAdapter
            taReferencias.Fill(Me.DsEHLIS.Referencias, Me.txtCodigoProveedor.EditValue)

            For i As Integer = 0 To Me.DsEHLIS.Referencias.Count - 1
                With Me.DsEHLIS.Referencias(i)

                    fWait.SetCaption("Leyendo artículo " & i + 1 & " de " & Me.DsEHLIS.Referencias.Count)

                    Tarifa = Me.DsEHLIS.Tarifas.Select("Referencia = '" & .Referencia & "'")

                    If Tarifa.Length > 0 Then
                        rTarifa = Tarifa(0)
                        rTarifa.Codigo = .Codigo
                        If .IsPrecioCosteNull Then .PrecioCoste = 0
                        If .IsPrecioVentaNull Then .PrecioVenta = 0
                        rTarifa.PrecioCoste_Actual = .PrecioCoste
                        rTarifa.PVR_Actual = .PrecioVenta
                        If rTarifa.PrecioCoste_Actual < rTarifa.PrecioCoste Then
                            rTarifa.Variacion = 1
                        ElseIf rTarifa.PrecioCoste_Actual > rTarifa.PrecioCoste Then
                            rTarifa.Variacion = 2
                        End If
                    End If

                End With
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            fWait.Close()
        End Try
    End Sub

    Private Sub bttActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttActualizar.Click
        Try
            Me.DsEHLIS.ActualizarPrecios(Me.txtCodigoProveedor.EditValue, Me.checkActualizarCostes.Checked, Me.txtIncrementoCoste.EditValue, Me.checkActualizarVenta.Checked, Me.txtIncrementoventa.EditValue, Me.checkEtiquetas.Checked, Me.checkCodigosBarras.Checked)

            MsgBox("Proceso de actualización finalizado", MsgBoxStyle.Information, Me.Text)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

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

    Private Sub bttBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttBuscar.Click
        Try
            If IsNumeric(Me.txtCodigoProveedor.EditValue) Then
                Me.DatosArticulo()
            Else
                MsgBox("Indique el código del proveedor EHLIS", MsgBoxStyle.Information)
                Me.txtCodigoProveedor.Focus()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub checkReferenciados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkReferenciados.CheckedChanged
        If Me.checkReferenciados.Checked Then
            Me.TarifasBindingSource.Filter = "Codigo IS NOT NULL"
        Else
            Me.TarifasBindingSource.Filter = String.Empty
        End If
    End Sub

End Class