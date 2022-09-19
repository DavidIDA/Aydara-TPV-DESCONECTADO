Partial Class dsProveedores

    Dim Codigo As String

    Public Sub Cargar(Optional CODPRO As String = "")

        Dim taProveedores As New dsProveedoresTableAdapters.PROVEEDTableAdapter

        Try
            If CODPRO <> String.Empty Then
                taProveedores.FillBy(Me.PROVEED, CODPRO)
            Else
                taProveedores.Fill(Me.PROVEED)
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Nuevo()

        Dim a3ERPOpcion As New a3ERPActiveX.Opcion

        Try
            a3ERPOpcion.Iniciar()
            a3ERPOpcion.IdOpcion = "manProveed"
            a3ERPOpcion.AnadirParametro("Accion", "Edicion")
            a3ERPOpcion.Ejecutar()

        Catch ex As Exception
            Throw ex
        Finally
            a3ERPOpcion.Acabar()
        End Try

    End Sub

    Public Sub Editar(CODPRO As String)

        Dim a3ERPOpcion As New a3ERPActiveX.Opcion

        Try
            a3ERPOpcion.Iniciar()
            a3ERPOpcion.IdOpcion = "manProveed"
            a3ERPOpcion.AnadirParametro("Accion", "Edicion")
            a3ERPOpcion.AnadirParametro("CODIGO", CODPRO)
            a3ERPOpcion.Ejecutar()

        Catch ex As Exception
            Throw ex
        Finally
            a3ERPOpcion.Acabar()
        End Try

    End Sub

    Public Sub Mantenimiento()

        Dim a3ERPOpcion As New a3ERPActiveX.Opcion

        Try
            a3ERPOpcion.Iniciar()
            a3ERPOpcion.IdOpcion = "manProveed"
            a3ERPOpcion.Ejecutar()

        Catch ex As Exception
            Throw ex
        Finally
            a3ERPOpcion.Acabar()
        End Try

    End Sub

    Public Function Seleccionar() As String

        Try
            Return Aydara.Seleccionar("PROVEED", "CODPRO", "BLOQUEADO='F'")

        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub Eliminar(CODPRO As String)

        Dim a3ERPMaestro As New a3ERPActiveX.Maestro

        Try
            a3ERPMaestro.Iniciar("PROVEED")

            If a3ERPMaestro.Buscar(CODPRO) Then
                a3ERPMaestro.Borrar()
            End If

        Catch ex As Exception
            Throw ex
        Finally
            a3ERPMaestro.Acabar()
        End Try
    End Sub

    Public Function Referencia(CODPRO As String) As String
        Try
            Dim a3ERPSeleccion As New a3ERPActiveX.Seleccion

            a3ERPSeleccion.Tabla = "REFPRO"
            a3ERPSeleccion.Filtro = "CODPRO='" & CODPRO & "'"

            a3ERPSeleccion.CampoResultado = "REFERENCIA"

            Return a3ERPSeleccion.Ejecutar()

        Catch ex As Exception
            Throw ex
        End Try
    End Function

End Class
