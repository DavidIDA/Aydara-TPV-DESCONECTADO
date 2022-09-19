Partial Class dsActualizacionPrecios

    Dim taArticulo As New dsActualizacionPreciosTableAdapters.ARTICULOSTableAdapter
    Dim taProveedor As New dsActualizacionPreciosTableAdapters.REFERENCIAS_PROVEEDORESTableAdapter

    Public Sub Cargar(ByVal CodigoProveedor As Integer, ByVal CodigoArticulo As String, ByVal Precio As Decimal)
        Try
            Me.Clear()

            taArticulo.Fill(Me.ARTICULOS, CodigoArticulo)

            If Me.ARTICULOS.Count > 0 Then

                With Me.ARTICULOS(0)

                    taProveedor.Fill(Me.REFERENCIAS_PROVEEDORES, .Id, CodigoProveedor)

                    If Me.REFERENCIAS_PROVEEDORES.Count = 0 Then

                        Dim rProveedor As dsActualizacionPrecios.REFERENCIAS_PROVEEDORESRow

                        rProveedor = Me.REFERENCIAS_PROVEEDORES.NewREFERENCIAS_PROVEEDORESRow

                        rProveedor.Articulo_Id = .Id
                        rProveedor.CodigoProveedor = CodigoProveedor
                        rProveedor.PrecioCoste = Precio

                        Me.REFERENCIAS_PROVEEDORES.AddREFERENCIAS_PROVEEDORESRow(rProveedor)

                    End If

                End With

            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Guardar()
        Try
            taArticulo.Update(Me.ARTICULOS)
            taProveedor.Update(Me.REFERENCIAS_PROVEEDORES)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
