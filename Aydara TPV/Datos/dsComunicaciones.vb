Partial Public Class dsComunicaciones

    Public Sub ActualizarDatos()

        Dim fWait As New DevExpress.Utils.WaitDialogForm("Comprobando ficheros", "Actualización datos TPV", New Drawing.Size(300, 75))
        Dim cmd As New SqlClient.SqlCommand

        Try
            If Not Comunicacion.DescargaFicheros Then
                MsgBox("Error al intentar descargar los ficheros", MsgBoxStyle.Exclamation)
                Exit Try
            End If

            Dim DirectorioFicheros As String = Comunicaciones_DirectorioFicheros & "\Envio"

            cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)
            cmd.Connection.Open()

            'Poner marca actualizando
            cmd.CommandText = "UPDATE TIENDAS SET Actualizando = 1"
            cmd.ExecuteNonQuery()

            cmd.CommandTimeout = 600000
            cmd.CommandType = CommandType.StoredProcedure

            If IO.File.Exists(DirectorioFicheros & "\FAMILIAS.SEQ") Then

                fWait.SetCaption("Importando fichero de familias")

                cmd.CommandText = "ImportarFamilias"
                cmd.Parameters.Add(New SqlClient.SqlParameter("FicheroSEQ", DirectorioFicheros & "\FAMILIAS.SEQ"))
                cmd.ExecuteReader.Close()
                cmd.Parameters.Clear()

            End If

            If IO.File.Exists(DirectorioFicheros & "\ARTICULO.SEQ") Then

                fWait.SetCaption("Importando fichero de artículos")

                cmd.CommandText = "ImportarArticulos"
                cmd.Parameters.Add(New SqlClient.SqlParameter("FicheroSEQ", DirectorioFicheros & "\ARTICULO.SEQ"))
                cmd.ExecuteReader.Close()
                cmd.Parameters.Clear()

            End If

            If IO.File.Exists(DirectorioFicheros & "\COBARRAS.SEQ") Then

                fWait.SetCaption("Importando fichero de códigos de barras")

                cmd.CommandText = "ImportarCodigosBarras"
                cmd.Parameters.Add(New SqlClient.SqlParameter("FicheroSEQ", DirectorioFicheros & "\COBARRAS.SEQ"))
                cmd.ExecuteReader.Close()
                cmd.Parameters.Clear()

            End If

            If IO.File.Exists(DirectorioFicheros & "\FORMAPAG.SEQ") Then

                fWait.SetCaption("Importando fichero de formas de pago")

                cmd.CommandText = "ImportarFormasPago"
                cmd.Parameters.Add(New SqlClient.SqlParameter("FicheroSEQ", DirectorioFicheros & "\FORMAPAG.SEQ"))
                cmd.ExecuteReader.Close()
                cmd.Parameters.Clear()

            End If

            If IO.File.Exists(DirectorioFicheros & "\TARIFAS.SEQ") Then

                fWait.SetCaption("Importando fichero de tarifas")

                cmd.CommandText = "ImportarTarifas"
                cmd.Parameters.Add(New SqlClient.SqlParameter("FicheroSEQ", DirectorioFicheros & "\TARIFAS.SEQ"))
                cmd.ExecuteReader.Close()
                cmd.Parameters.Clear()

            End If

            'If IO.File.Exists(DirectorioFicheros & "\CLIENTES.SEQ") Then

            '    fWait.SetCaption("Importando fichero de clientes")

            '    cmd.CommandText = "ImportarClientes"
            '    cmd.Parameters.Add(New SqlClient.SqlParameter("FicheroSEQ", DirectorioFicheros & "\CLIENTES.SEQ"))
            '    cmd.ExecuteReader.Close()
            '    cmd.Parameters.Clear()

            'End If

            If IO.File.Exists(DirectorioFicheros & "\CLICREDI.SEQ") Then

                fWait.SetCaption("Importando fichero de clientes de crédito")

                cmd.CommandText = "ImportarClientesCredito"
                cmd.Parameters.Add(New SqlClient.SqlParameter("FicheroSEQ", DirectorioFicheros & "\CLICREDI.SEQ"))
                cmd.ExecuteReader.Close()
                cmd.Parameters.Clear()

            End If

            If IO.File.Exists(DirectorioFicheros & "\PROMOCIO.SEQ") Then

                fWait.SetCaption("Importando fichero de promociones")

                cmd.CommandText = "ImportarPromociones"
                cmd.Parameters.Add(New SqlClient.SqlParameter("FicheroSEQ", DirectorioFicheros & "\PROMOCIO.SEQ"))
                cmd.ExecuteReader.Close()
                cmd.Parameters.Clear()

            End If

            'Importar entradas de almacén
            Dim tFiles() As String
            tFiles = System.IO.Directory.GetFiles(DirectorioFicheros)

            For i As Integer = 0 To tFiles.Length - 1

                Dim NombreFichero As String = Mid(tFiles(i), Len(DirectorioFicheros & "\") + 1)

                If UCase(Mid(NombreFichero, 1, 2)) = "AL" And Mid(NombreFichero, 3, 2) = Format(General.NumeroAlmacen, "00") Then

                    fWait.SetCaption("Importando fichero de entradas de almacén")

                    cmd.CommandText = "ImportarEntradas"
                    cmd.Parameters.Add(New SqlClient.SqlParameter("FicheroSEQ", tFiles(i)))
                    cmd.ExecuteReader.Close()
                    cmd.Parameters.Clear()

                End If

            Next

            'Importar inventario
            If IO.File.Exists(DirectorioFicheros & "\INVE" & Format(General.NumeroAlmacen, "00") & ".SEQ") Then

                fWait.SetCaption("Importando fichero de inventario")

                cmd.CommandText = "ImportarInventario"
                cmd.Parameters.Add(New SqlClient.SqlParameter("FicheroSEQ", DirectorioFicheros & "\INVE" & Format(General.NumeroAlmacen, "00") & ".SEQ"))
                cmd.ExecuteReader.Close()
                cmd.Parameters.Clear()

                Try
                    'IO.File.Delete(DirectorioFicheros & "\INVE" & Format(General.NumeroAlmacen, "00") & ".SEQ")
                Catch ex As Exception
                    MsgBox(EstadisticasTickets.Menu, MsgBoxStyle.Exclamation)
                End Try

            End If

            'Actualizar precios báscula
            If IO.Directory.Exists(DatosTienda.DirectorioFicheroBasculas) Then

                fWait.SetCaption("Actualizando precios de básculas")

                Dim Articulos As New dsArticulos
                Articulos.GeneraFicheroBalanzas()

            End If

            'Actualizar etiquetas electrónicas
            If DatosTienda.EtiquetaElectronica Then

                fWait.SetCaption("Actualizando etiquetas electrónicas")

                Dim Etiquetas As New dsEtiquetas
                Etiquetas.GeneraFicheroEtiquetasElectronicas(False)

            End If

            fWait.SetCaption("Fin actualización")

            'Copiar fichero báscula
            Try
                Dim RutaFichero As String = Comunicaciones_DirectorioFicheros & "\Tienda " & Format(CodigoTienda, "00") & "\TX.TXT"
                If IO.File.Exists(RutaFichero) And IO.Directory.Exists(My.Settings.DirectorioBascula) Then
                    IO.File.Copy(RutaFichero, My.Settings.DirectorioBascula & "\TX.TXT", True)
                    'General.ReiniciarComunicacionBascula()
                End If
            Catch ex As Exception
                MsgBox("Error al copiar fichero de comunicación para las básculas." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        Try
            'Quitar marca actualizando e indicar fecha actualización
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "UPDATE TIENDAS SET Actualizando=0, FechaUltimaActualizacion = '" & Date.Today & "'"
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If Not cmd.Connection Is Nothing Then
                If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
            End If
            fWait.Close()
        End Try

    End Sub

End Class
