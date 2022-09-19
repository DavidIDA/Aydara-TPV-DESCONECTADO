Partial Class dsArticulos

    Public Sub Nuevo()

        Dim a3ERPOpcion As New a3ERPActiveX.Opcion

        Try
            a3ERPOpcion.Iniciar()
            a3ERPOpcion.IdOpcion = "manArticulo"
            a3ERPOpcion.AnadirParametro("Accion", "Edicion")
            a3ERPOpcion.Ejecutar()

        Catch ex As Exception
            Throw ex
        Finally
            a3ERPOpcion.Acabar()
        End Try

    End Sub

    Public Sub Editar(CODART As String)

        Dim a3ERPOpcion As New a3ERPActiveX.Opcion

        Try
            a3ERPOpcion.Iniciar()
            a3ERPOpcion.IdOpcion = "manArticulo"
            a3ERPOpcion.AnadirParametro("Accion", "Edicion")
            a3ERPOpcion.AnadirParametro("CODIGO", CODART)
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
            a3ERPOpcion.IdOpcion = "manArticulo"
            a3ERPOpcion.Ejecutar()

        Catch ex As Exception
            Throw ex
        Finally
            a3ERPOpcion.Acabar()
        End Try

    End Sub

    Public Function Seleccionar() As String
        Try
            Dim SeleccionIDA As Boolean = False

            Select Case a3ERP.Empresa
                Case a3ERP.FormatoEmpresa.Garrido
                    SeleccionIDA = True
            End Select

            If SeleccionIDA Then

                Dim dsSeleccion As New dsSeleccion
                Return dsSeleccion.Seleccionar(dsSeleccion.Fichero.Artículos)

            Else

                Return Aydara.Seleccionar("ARTICULO", "CODART", "BLOQUEADO='F'")

            End If


        Catch ex As Exception
            Return String.Empty
        End Try
    End Function

    Public Function BultosPaquetesUnidades(ByVal CODART As String, ByVal BULTOS As Decimal, ByVal PAQUETES As Decimal, ByVal UNIDADES As Decimal, ByVal EsCompras As Boolean) As Array
        Try
            Dim sql As String, Datos() As Decimal = Nothing, Fraccion As Integer
            ReDim Datos(2)

            If BULTOS <> 0 Then

                sql = "SELECT PAQBUL" & IIf(EsCompras, "C", "V") & " FROM ARTICULO WHERE CODART = '" & CODART & "'"
                Fraccion = Aydara.SentenciaSQL(sql)
                PAQUETES = BULTOS * Fraccion

                sql = "SELECT UNIPAQ" & IIf(EsCompras, "C", "V") & " FROM ARTICULO WHERE CODART = '" & CODART & "'"
                Fraccion = Aydara.SentenciaSQL(sql)
                UNIDADES = PAQUETES * Fraccion

            ElseIf PAQUETES <> 0 Then

                sql = "SELECT PAQBUL" & IIf(EsCompras, "C", "V") & " FROM ARTICULO WHERE CODART = '" & CODART & "'"
                Fraccion = Aydara.SentenciaSQL(sql)
                If Fraccion <> 0 Then
                    If PAQUETES Mod Fraccion = 0 Then BULTOS = PAQUETES / Fraccion
                End If

                sql = "SELECT UNIPAQ" & IIf(EsCompras, "C", "V") & " FROM ARTICULO WHERE CODART = '" & CODART & "'"
                Fraccion = Aydara.SentenciaSQL(sql)
                UNIDADES = PAQUETES * Fraccion

            ElseIf UNIDADES <> 0 Then

                sql = "SELECT UNIPAQ" & IIf(EsCompras, "C", "V") & " FROM ARTICULO WHERE CODART = '" & CODART & "'"
                Fraccion = Aydara.SentenciaSQL(sql)
                If Fraccion <> 0 Then
                    If UNIDADES Mod Fraccion = 0 Then PAQUETES = UNIDADES / Fraccion
                End If

                sql = "SELECT PAQBUL" & IIf(EsCompras, "C", "V") & " FROM ARTICULO WHERE CODART = '" & CODART & "'"
                Fraccion = Aydara.SentenciaSQL(sql)
                If Fraccion <> 0 Then
                    If PAQUETES Mod Fraccion = 0 Then BULTOS = PAQUETES / Fraccion
                End If

            End If

            Datos(0) = BULTOS
            Datos(1) = PAQUETES
            Datos(2) = UNIDADES

            Return Datos

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Sub InfoArticulo(EsCompras As Boolean, CODIGO As String, Optional ByVal CODALM As String = "", Optional ByVal CODART As String = "", Optional FECHA As Date = Nothing, Optional TARIFA As String = "")
        Try
            If FECHA = Date.MinValue Then FECHA = Date.Today

            Dim taInfo As New dsArticulosTableAdapters.INFOARTTableAdapter

            taInfo.Fill(Me.INFOART, IIf(EsCompras, CODIGO, String.Empty), CODALM, CODART)

            If Me.INFOART.Count = 0 Then
                taInfo.DatosArticulo(Me.INFOART, IIf(EsCompras, CODIGO, String.Empty), CODART)
            End If

        Catch ex As Exception
            MsgBox("Error al obtener información adicional del artículo." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub


End Class
