Partial Class dsEtiquetas

    Public Sub GeneraFicheroEtiquetasElectronicas(EnviarTodos As Boolean)
        Try
            Dim NombreFichero As String = Now.ToString("MMddHHmmss")
            Dim RutaFicheroDAT As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\" & NombreFichero & ".DAT"
            Dim RutaFicheroFLG As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\" & NombreFichero & ".flg"

            If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV") Then My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Envio")
            Dim sw As New System.IO.StreamWriter(RutaFicheroDAT, False, System.Text.Encoding.Default)

            Dim taEtiquetas As New dsEtiquetasTableAdapters.ETIQUETAS_ELECTRONICASTableAdapter
            Dim configActual As Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture

            Try
                'Configuración punto decimal
                Dim r As New Globalization.CultureInfo("es-ES")
                r.NumberFormat.CurrencyDecimalSeparator = "."
                r.NumberFormat.NumberDecimalSeparator = "."
                System.Threading.Thread.CurrentThread.CurrentCulture = r

                'Cargar datos
                taEtiquetas.Listado(Me.ETIQUETAS_ELECTRONICAS)

                Dim Etiquetas As DataRow()
                If EnviarTodos Then
                    Etiquetas = Me.ETIQUETAS_ELECTRONICAS.Select("", "CodigoArticulo")
                Else
                    Etiquetas = Me.ETIQUETAS_ELECTRONICAS.Select("Envio = 1", "CodigoArticulo")
                End If

                For i As Integer = 0 To Etiquetas.Length - 1
                    With CType(Etiquetas(i), dsEtiquetas.ETIQUETAS_ELECTRONICASRow)

                        sw.Write("1")
                        sw.Write(CDbl(.CodigoBarras).ToString("0000000000000"))
                        sw.Write(String.Format("{0,9}", .Precio.ToString("0.00")))
                        sw.Write(String.Format("{0,-50}", Mid(.Descripcion, 1, 50)))
                        sw.Write(Mid(.CodigoArticulo, 3, 5))

                        If .PesoUnidad <> 0 Then
                            sw.Write(String.Format("{0,9}", (.Precio / .PesoUnidad).ToString("0.00")))
                        Else
                            sw.Write(String.Format("{0,9}", CInt(0).ToString("0.00")))
                        End If

                        Select Case .TipoUnidad
                            Case "K"
                                sw.Write("1")
                            Case "L"
                                sw.Write("2")
                            Case "U"
                                sw.Write("3")
                            Case "M"
                                sw.Write("4")
                            Case Else
                                sw.Write("0")
                        End Select

                        If Not .IsFechaFinPromoNull Then
                            sw.Write(String.Format("{0,9}", .PrecioTarifa.ToString("0.00")))
                            sw.Write(.FechaFinPromo.ToString("ddMMyy"))
                        Else
                            sw.Write(String.Format("{0,9}", CInt(0).ToString("0.00")))
                            sw.Write("      ")
                        End If

                        sw.Write("0000.00")
                        sw.Write("0000.00")
                        sw.Write("0000.00")

                        If Not .IsFechaFinPromoNull Then
                            sw.Write("1")
                        Else
                            sw.Write("0")
                        End If

                        sw.Write("00")

                        If .Formato = 1 Then
                            sw.Write(String.Format("{0,-15}", Mid(IIf(.Origen.Trim = String.Empty, "ESPAÑA", .Origen), 1, 15)))
                            sw.Write(String.Format("{0,-10}", Mid(.Categoria, 1, 10)))
                            sw.Write(String.Format("{0,-5}", Mid(.Calibre, 1, 5)))
                            sw.Write(String.Format("{0,3}", .PLU))
                        Else
                            sw.Write(String.Format("{0,-15}", String.Empty))
                            sw.Write(String.Format("{0,-10}", String.Empty))
                            sw.Write(String.Format("{0,-5}", String.Empty))
                            sw.Write("000")
                        End If

                        sw.WriteLine()

                    End With
                Next

            Catch ex As Exception
                Throw ex
            Finally
                sw.Close()
                System.Threading.Thread.CurrentThread.CurrentCulture = configActual
            End Try

            Try
                sw = New System.IO.StreamWriter(RutaFicheroFLG, True, System.Text.Encoding.Default)
                sw.WriteLine(" ")
                sw.Close()

            Catch ex As Exception
                Throw ex
            End Try

            Try
                'Subir ficheros por FTP
                My.Computer.Network.UploadFile(RutaFicheroDAT, DatosTienda.EE_DireccionFTP & "/" & NombreFichero & ".DAT", DatosTienda.EE_UsuarioFTP, DatosTienda.EE_PasswordFTP, 2500, FileIO.UICancelOption.DoNothing)
                My.Computer.Network.UploadFile(RutaFicheroFLG, DatosTienda.EE_DireccionFTP & "/" & NombreFichero & ".flg", DatosTienda.EE_UsuarioFTP, DatosTienda.EE_PasswordFTP, 2500, FileIO.UICancelOption.DoNothing)

                If IO.File.Exists(RutaFicheroDAT) Then IO.File.Delete(RutaFicheroDAT)
                If IO.File.Exists(RutaFicheroFLG) Then IO.File.Delete(RutaFicheroFLG)

            Catch ex As Exception
                Throw ex
            End Try

            taEtiquetas.Enviadas()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
