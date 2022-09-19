Partial Class dsIncidencias

    Dim taIncidencias As New dsIncidenciasTableAdapters.INCIDENCIASTableAdapter
    Dim WithEvents _Incidencias As INCIDENCIASDataTable

    Private Sub dsIncidencias_Initialized(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Initialized
        Me._Incidencias = Me.INCIDENCIAS
    End Sub

#Region "Funciones"
    Public Function Cargar() As Integer
        Try
            Me.taIncidencias.Fill(Me.INCIDENCIAS)

            Return Me.INCIDENCIAS.Count
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Guardar() As Integer
        Try
            Me.taIncidencias.Update(Me.INCIDENCIAS)

            Return Me.INCIDENCIAS.Count
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region



    Private Sub _Incidencias_TableNewRow(ByVal sender As Object, ByVal e As System.Data.DataTableNewRowEventArgs) Handles _Incidencias.TableNewRow
        Try
            With CType(e.Row, INCIDENCIASRow)
                .AfectaStock = 0
                .Comentario = String.Empty
                .Fecha = Date.Now
                .TempArticulo = String.Empty
                .TempCodigo = String.Empty
                .TempOperario = String.Empty
                .TempTipo = String.Empty
                .TipoID = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Actualizar()
        Try
            Dim lineas As DataRow() = Me.INCIDENCIAS.Select("", "", DataViewRowState.Added)

            For i As Integer = 0 To lineas.Length - 1
                With CType(lineas(i), INCIDENCIASRow)
                    If .AfectaStock Then
                        AGI2005.BaseDatos.ConsultaNonQuery("UPDATE EXISTENCIAS SET ExistenciaActual = ExistenciaActual + " & .Cantidad.ToString.Replace(",", ".") & " WHERE Articulo_Id=" & .ArticuloID, My.Settings.AydaraTPVConnectionString)
                    End If
                End With
            Next

            lineas = Me.INCIDENCIAS.Select("AfectaStock = 1 AND Cantidad <> 0", "", DataViewRowState.Deleted)

            If lineas.Length > 0 Then
                If MsgBox("¿Desea recuperar la existencia de las incidencias eliminadas?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    For i As Integer = 0 To lineas.Length - 1
                        With CType(lineas(i), INCIDENCIASRow)
                            AGI2005.BaseDatos.ConsultaNonQuery("UPDATE EXISTENCIAS SET ExistenciaActual = ExistenciaActual - " & .Item("Cantidad", DataRowVersion.Original).ToString.Replace(",", ".") & " WHERE Articulo_Id=" & .Item("ArticuloID", DataRowVersion.Original), My.Settings.AydaraTPVConnectionString)
                        End With
                    Next
                End If
            End If

            Me.taIncidencias.Update(Me.INCIDENCIAS)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
