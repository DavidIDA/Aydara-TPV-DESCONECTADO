Public Class Aydara

#Region "ActualizaCadenaConexion"
    Public Shared Sub ActualizaCadenaConexion(CadenaConexionEnlace As String, ByVal Usuario As String, ByVal Password As String)
        Try
            Dim CadenaConexion As String

            CadenaConexion = "User ID=" & Usuario & ";Password=" & Password

            Dim conexion() As String = Split(CadenaConexionEnlace, ";")
            Dim i As Integer

            For i = 0 To conexion.Length - 1
                If Mid(conexion(i), 1, 11) = "Data Source" Then
                    CadenaConexion &= ";" & conexion(i)
                ElseIf Mid(conexion(i), 1, 15) = "Initial Catalog" Then
                    CadenaConexion &= ";" & conexion(i)
                End If
            Next

            Dim BBDD As String = String.Empty

            My.Settings.Item("SqlConection") = CadenaConexion
            My.Settings.Usuario = Usuario
            My.Settings.Password = Password
            My.Settings.Save()

        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "Estado"
    Public Shared Sub Estado(Optional ByVal Texto As String = "", Optional Titulo As String = "")

        If Not a3ERP.fWaitForm Is Nothing Then a3ERP.fWaitForm.Close()

        If Titulo <> String.Empty Or Texto <> String.Empty Then
            If Titulo = String.Empty Then Titulo = "Cargando datos. Espere por favor"
            a3ERP.fWaitForm = New DevExpress.Utils.WaitDialogForm(Texto, Titulo, New Size(300, 75))
        End If

    End Sub
#End Region

#Region "SentenciaSQL"
    Public Shared Function SentenciaSQL(ByVal SQL As String) As String

        If SQL = String.Empty Then Return String.Empty

        Dim a3ERPDatos As New a3ERPActiveX.DatosA3

        Try
            Dim resultado = a3ERPDatos.EjecutarSQL(SQL)

            If Not resultado Is Nothing Then
                Return resultado
            Else
                Return String.Empty
            End If

        Catch ex As Exception
            Return String.Empty
        End Try

    End Function
#End Region

#Region "VerOpcion"
    Public Shared Sub VerOpcion(IdOpcion As String, Optional Parametros() As String = Nothing)

        Dim a3ERPOpcion As New a3ERPActiveX.Opcion

        Try
            a3ERPOpcion.Iniciar()

            a3ERPOpcion.IdOpcion = IdOpcion

            If Not Parametros Is Nothing Then
                For i As Integer = 0 To Parametros.Length - 1 Step 2
                    a3ERPOpcion.AnadirParametro(Parametros(i), Parametros(i + 1))
                Next
            End If

            a3ERPOpcion.Ejecutar()

        Catch ex As Exception
            Throw ex
        Finally
            a3ERPOpcion.Acabar()
        End Try

    End Sub
#End Region

#Region "ObtPrcVenta"
    Public Shared Function ObtPrcVenta(ByVal CODART As String, ByVal CODCLI As String, ByVal CODMON As String, ByVal TARIFA As String, ByVal UNIDADES As Decimal, ByVal FECHA As Date) As Decimal

        Dim NaxVarios As New a3ERPActiveX.Varios
        Dim Precios As Array = Nothing

        Try
            Precios = NaxVarios.ObtPrcVenta(CODART, CODCLI, CODMON, TARIFA, UNIDADES, FECHA.ToShortDateString)

            If Not Precios Is Nothing Then
                Return Precios(0)
            Else
                Return 0
            End If

        Catch ex As Exception
            Return 0
        End Try

    End Function
#End Region

#Region "ObtDescuentos"
    Public Shared Function ObtDescuentos(ByVal EsCompras As Boolean, ByVal CODIGO As String, ByVal CODART As String, ByVal UNIDADES As Decimal, ByVal FECHA As Date, Optional ByVal Preventa As Boolean = False, Optional AplicaFactura As Boolean = True) As Collections.ArrayList

        Dim dr As SqlClient.SqlDataReader
        Dim cmd As New SqlClient.SqlCommand
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.SqlConection)

        Dim Descuentos As New Collections.ArrayList
        Dim ColumnaCodigo As String = IIf(EsCompras, "CODPRO", "CODCLI")

        Dim AcumulaDtoFamilia As Boolean = True
        Dim AcumulaDtoGeneral As Boolean = True

        Try
            If Aydara.SentenciaSQL("SELECT " & IIf(EsCompras, "DTOSPRCESPCOMPRAS", "DTOSPRCESP") & " FROM DATOSCONFIG") = "F" Then

                'Comprobar si tiene precio especial el cliente/proveedor
                If Aydara.SentenciaSQL("SELECT COUNT(*) FROM PRCESP WHERE CODART = '" & CODART & "' AND " & ColumnaCodigo & " = '" & CODIGO & "' AND GETDATE() BETWEEN FECMIN AND FECMAX AND UNIDADES <= " & Replace(Math.Abs(UNIDADES), ",", ".")) > 0 Then
                    Exit Try
                End If

                If Not EsCompras Then
                    'Comprobar si tiene precio especial la familia del cliente
                    Dim FAMCLIESP As String = Aydara.SentenciaSQL("SELECT FAMCLIESP FROM CLIENTES WHERE CODCLI = '" & CODIGO & "'")
                    If Aydara.SentenciaSQL("SELECT COUNT(*) FROM PRCESP WHERE CODART = '" & CODART & "' AND FAMCLI = '" & FAMCLIESP & "' AND GETDATE() BETWEEN FECMIN AND FECMAX AND UNIDADES <= " & Replace(Math.Abs(UNIDADES), ",", ".")) > 0 Then
                        Exit Try
                    End If
                End If

            End If

            cmd.Connection.Open()

Descuentos:
            'Descuentos por artículo
            cmd.CommandText = "SELECT * FROM IDA_DESCUENTOS " & _
                              "WHERE APLICA=" & Math.Abs(CInt(AplicaFactura)) & " AND " & ColumnaCodigo & " = '" & CODIGO & "' AND UNIDADES <= " & Replace(Math.Abs(UNIDADES), ",", ".") & " AND '" & FECHA & "' BETWEEN FECMIN AND FECMAX " & _
                              "AND CODART = '" & CODART & "' " & _
                              "ORDER BY FECMIN"
            dr = cmd.ExecuteReader
            While dr.Read
                If dr("PORDESC") <> 0 Then Descuentos.Add(dr("PORDESC"))
                AcumulaDtoFamilia = dr("ACUMULAFAMILIA")
                AcumulaDtoGeneral = dr("ACUMULAGENERAL")
            End While
            dr.Close()

            If AcumulaDtoFamilia Then
                'Descuentos por familia
                cmd.CommandText = "SELECT IDA_DESCUENTOS.* " & _
                                  "FROM IDA_DESCUENTOS INNER JOIN ARTICULO ON IDA_DESCUENTOS.CODFAM = ARTICULO." & IIf(EsCompras, "FAMARTDESCCOM", "FAMARTDESCVEN") & " " & _
                                  "WHERE IDA_DESCUENTOS.APLICA=" & Math.Abs(CInt(AplicaFactura)) & " AND IDA_DESCUENTOS." & ColumnaCodigo & " = '" & CODIGO & "' AND IDA_DESCUENTOS.UNIDADES <= " & Replace(Math.Abs(UNIDADES), ",", ".") & " AND '" & FECHA & "' BETWEEN IDA_DESCUENTOS.FECMIN AND IDA_DESCUENTOS.FECMAX " & _
                                  "AND ARTICULO.CODART = '" & CODART & "' " & _
                                  "ORDER BY IDA_DESCUENTOS.FECMIN"
                dr = cmd.ExecuteReader
                While dr.Read
                    If dr("PORDESC") <> 0 Then Descuentos.Add(dr("PORDESC"))
                    If AcumulaDtoGeneral Then AcumulaDtoGeneral = dr("ACUMULAGENERAL")
                End While
                dr.Close()
            End If

            If AcumulaDtoGeneral Then
                'Si viene de preventa y no tiene descuentos añadir dto 0
                If Preventa And Descuentos.Count = 0 Then
                    Descuentos.Add(0)
                End If
                'Descuentos generales
                cmd.CommandText = "SELECT * " & _
                                  "FROM IDA_DESCUENTOS " & _
                                  "WHERE APLICA=" & Math.Abs(CInt(AplicaFactura)) & " AND " & ColumnaCodigo & " = '" & CODIGO & "' AND UNIDADES <= " & Replace(Math.Abs(UNIDADES), ",", ".") & " AND '" & FECHA & "' BETWEEN FECMIN AND FECMAX " & _
                                  "AND ISNULL(CODFAM,'') = '' AND ISNULL(CODART,'') = '' " & _
                                  "ORDER BY FECMIN"
                dr = cmd.ExecuteReader
                While dr.Read
                    If dr("PORDESC") <> 0 Then Descuentos.Add(dr("PORDESC"))
                End While
                dr.Close()
            End If

            If Descuentos.Count = 0 And Not EsCompras And ColumnaCodigo <> "FAMCLI" Then
                ColumnaCodigo = "FAMCLI"
                CODIGO = Aydara.SentenciaSQL("SELECT FAMCLIDESC FROM CLIENTES WHERE CODCLI = '" & CODIGO & "'")
                If CODIGO <> String.Empty Then GoTo Descuentos
            End If

        Catch ex As Exception
            MsgBox("Error al obtener descuentos." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

        Return Descuentos

    End Function
#End Region

#Region "ObtDescUnidad"
    Public Shared Function ObtDescUnidad(ByVal EsCompras As Boolean, ByVal CODIGO As String, ByVal CODART As String, ByVal UNIDADES As Decimal, ByVal FECHA As Date) As Decimal

        Dim Descuento As String

        Try
            Descuento = "SELECT ISNULL(DESCUNI,0) FROM IDA_DESCUENTOS " & _
                        "WHERE APLICA=1 AND " & IIf(EsCompras, "CODPRO", "CODCLI") & " = '" & CODIGO & "' AND UNIDADES <= " & Replace(Math.Abs(UNIDADES), ",", ".") & " AND '" & FECHA & "' BETWEEN FECMIN AND FECMAX " & _
                        "AND CODART = '" & CODART & "' " & _
                        "ORDER BY FECMIN DESC"

            Descuento = Aydara.SentenciaSQL(Descuento)

            If IsNumeric(Descuento) Then Return CDec(Descuento)

            If Not EsCompras Then

                CODIGO = Aydara.SentenciaSQL("SELECT FAMCLIDESC FROM CLIENTES WHERE CODCLI = '" & CODIGO & "'")

                Descuento = "SELECT ISNULL(DESCUNI,0) FROM IDA_DESCUENTOS " & _
                            "WHERE APLICA=1 AND FAMCLI = '" & CODIGO & "' AND UNIDADES <= " & Replace(Math.Abs(UNIDADES), ",", ".") & " AND " & FECHA & " BETWEEN FECMIN AND FECMAX " & _
                            "AND CODART = '" & CODART & "' " & _
                            "ORDER BY FECMIN DESC"

                Descuento = Aydara.SentenciaSQL(Descuento)

            End If

        Catch ex As Exception
            MsgBox("Error al obtener descuento unidad." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
            Return 0
        End Try

        If IsNumeric(Descuento) Then Return CDec(Descuento) Else Return 0

    End Function
#End Region

#Region "ObtPrecioTarifa"
    Public Shared Function ObtPrecioTarifa(TARIFA As String, CODART As String) As Decimal
        Try
            Dim Precio As String = Aydara.SentenciaSQL("SELECT TOP 1 PRECIO FROM TARIFAVE WHERE TARIFA = '" & TARIFA & "' AND CODART = '" & CODART & "' AND GETDATE() BETWEEN FECMIN AND FECMAX AND UNIDADES = 0 ORDER BY FECMIN DESC")

            If IsNumeric(Precio) Then Return CDbl(Precio) Else Return 0

        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region

#Region "ObtMargenMinimo"
    Public Shared Function ObtMargenMinimo(CODART As String) As Decimal
        Try
            Dim Margen As String = Aydara.SentenciaSQL("SELECT IDA_MARGENMINIMO FROM ARTICULO WHERE CODART = '" & CODART & "'")

            If IsNumeric(Margen) Then Return CDbl(Margen) Else Return 0

        Catch ex As Exception
            Return 0
        End Try
    End Function
#End Region

#Region "ObtCodArt"
    Public Shared Function ObtCodArt(Codigo As String) As String

        Dim CODART As String = String.Empty

        Try
            CODART = Aydara.SentenciaSQL("SELECT CODART FROM ARTICULO WHERE LTRIM(CODART) = '" & Codigo.Trim & "'")

            If CODART = String.Empty Then
                CODART = Aydara.SentenciaSQL("SELECT CODART FROM ALTERNA WHERE LTRIM(CODALT) = '" & Codigo.Trim & "'")
            End If

        Catch ex As Exception
            Return String.Empty
        End Try

        Return CODART

    End Function
#End Region

#Region "EliminarCeros"
    Public Shared Function EliminarCeros(ByVal Cadena As String) As String
        'Eliminar ceros del código cliente
        While Len(Cadena) > 1 And Mid(Cadena, 1, 1) = "0"
            Cadena = Mid(Cadena, 2)
        End While
        Return Cadena
    End Function
#End Region

#Region "Seleccionar"
    Public Shared Function Seleccionar(Tabla As String, Campo As String, Optional Filtro As String = "") As String

        Dim a3ERPSeleccion As New a3ERPActiveX.Seleccion

        Try
            a3ERPSeleccion.Tabla = Tabla
            a3ERPSeleccion.Filtro = Filtro
            a3ERPSeleccion.CampoResultado = Campo

            Return a3ERPSeleccion.Ejecutar

        Catch ex As Exception
            Return Nothing
        End Try

    End Function
#End Region

#Region "ConfigurarGrilla"
    Public Shared Sub ConfigurarGrilla(Elemento As Object, ClaveRegistro As String)
        Try
            Dim fPropiedades As New PropiedadesControl
            fPropiedades.PropertyGridControl.SelectedObject = Elemento
            fPropiedades.PropertyGridControl.Tag = ClaveRegistro
            fPropiedades.ShowDialog()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

End Class
