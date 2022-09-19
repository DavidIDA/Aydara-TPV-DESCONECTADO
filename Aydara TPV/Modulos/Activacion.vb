Public Class Activacion

    Const IV As String = "12345678"
    Public Const DiasDemo As Integer = 15
    Public Const ClienteIDA As String = "ida976460350"
    Public Const CodigoIDA As String = "ida"

    Public Structure sDatosActivacion
        Dim DiasRestantes As Integer
        Dim CodigoActivacion As String
    End Structure

#Region "NumeroSerie"
    Public Shared Function NumeroSerie() As String
        Try
            'Calcula código de activación
            Dim FileWsh As Object
            FileWsh = CreateObject("Scripting.FileSystemObject")
            Return Replace(Mid(FileWsh.Drives(Environment.GetEnvironmentVariable("SystemDrive")).SerialNumber, 1, 24), "-", "M")

        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
#End Region

#Region "DatosActivacion"
    Public Shared Function DatosActivacion() As sDatosActivacion

        Dim Datos As sDatosActivacion

        Dim dsActivaciones As New dsActivaciones
        Dim cmd As New SqlClient.SqlCommand

        Dim conexion As New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Dim NumeroSerie As String = Activacion.NumeroSerie

        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox("Error al conectar con la base de datos." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error al actualizar versión")
            Return Nothing
        End Try

        Try
            Dim Crypto As New AGI2005.Crypto(AGI2005.Crypto.CryptoProvider.TripleDES)
            Crypto.IV = Activacion.IV
            Crypto.Key = NumeroSerie

            cmd.Connection = conexion

            cmd.CommandText = "SELECT * FROM ACTIVACIONES WHERE NumeroSerie='" & NumeroSerie & "'"

            dsActivaciones.ACTIVACIONES.Load(cmd.ExecuteReader)

            If dsActivaciones.ACTIVACIONES.Count > 0 Then

                'Comprobar código de activación
                If dsActivaciones.ACTIVACIONES(0).FechaCaducidad = Activacion.ClienteIDA Then
                    Datos.DiasRestantes = 999
                Else
                    Dim FechaEncriptada As String = Crypto.DescifrarCadena(dsActivaciones.ACTIVACIONES(0).FechaCaducidad)

                    If FechaEncriptada = Activacion.CodigoIDA Then
                        Datos.DiasRestantes = 999
                    Else
                        Dim FechaCaducidad As Date
                        FechaCaducidad = Mid(FechaEncriptada, 1, 2) & "-" & Mid(FechaEncriptada, 3, 2) & "-" & Mid(FechaEncriptada, 5, 2)
                        Datos.DiasRestantes = DateDiff(DateInterval.Day, Date.Today, FechaCaducidad)
                    End If

                End If

                Datos.CodigoActivacion = dsActivaciones.ACTIVACIONES(0).CodigoActivacion

            Else

                'Añadir nº de serie
                Dim taActivaciones As New dsActivacionesTableAdapters.ACTIVACIONESTableAdapter
                Dim rActivacion As dsActivaciones.ACTIVACIONESRow

                rActivacion = dsActivaciones.ACTIVACIONES.NewACTIVACIONESRow
                rActivacion.NumeroSerie = NumeroSerie
                rActivacion.NombreEquipo = My.Computer.Name
                rActivacion.CodigoActivacion = String.Empty

                'Fecha de instalación
                rActivacion.FechaInstalacion = Crypto.CifrarCadena(Format(Date.Today, "ddMMyy"))

                'Fecha de caducidad
                rActivacion.FechaCaducidad = Crypto.CifrarCadena(Format(DateAdd(DateInterval.Day, DiasDemo, Date.Today), "ddMMyy"))

                dsActivaciones.ACTIVACIONES.AddACTIVACIONESRow(rActivacion)

                taActivaciones.Update(dsActivaciones.ACTIVACIONES)

                Datos.DiasRestantes = DiasDemo
                Datos.CodigoActivacion = String.Empty

            End If

                Return Datos

        Catch ex As Exception
            'MsgBox("Error al comprobar activación del producto.", MsgBoxStyle.Critical, "Error al actualizar versión")
            Datos.DiasRestantes = -1
            Datos.CodigoActivacion = String.Empty
            Return Datos
        Finally
            If conexion.State = ConnectionState.Open Then conexion.Close()
        End Try

    End Function
#End Region

#Region "ComprobarCodigo"
    Public Shared Function ComprobarCodigo(ByVal Codigo As String) As String
        Try
            Dim Crypto As New AGI2005.Crypto(AGI2005.Crypto.CryptoProvider.TripleDES)
            Crypto.IV = Activacion.IV
            Crypto.Key = NumeroSerie()

            Dim FechaCaducidad As Date

            If Codigo = ClienteIDA Then Return CodigoIDA

            Dim FechaEncriptada As String = Crypto.DescifrarCadena(Codigo)

            If FechaEncriptada = CodigoIDA Then Return CodigoIDA

            FechaCaducidad = Mid(FechaEncriptada, 1, 2) & "-" & Mid(FechaEncriptada, 3, 2) & "-" & Mid(FechaEncriptada, 5, 2)

            Return FechaCaducidad.ToString

        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
#End Region

#Region "ActivarEquipo"
    Public Shared Function ActivarEquipo(ByVal NumeroSerie As String, ByVal FechaEncriptada As String)

        Dim dtActivaciones As New dsActivaciones.ACTIVACIONESDataTable
        Dim taActivaciones As New dsActivacionesTableAdapters.ACTIVACIONESTableAdapter

        Dim cmd As New SqlClient.SqlCommand()
        cmd.Connection = New SqlClient.SqlConnection(My.Settings.AydaraTPVConnectionString)

        Try
            cmd.Connection.Open()
            cmd.CommandText = "SELECT * FROM ACTIVACIONES WHERE NumeroSerie='" & NumeroSerie & "'"

            dtActivaciones.Load(cmd.ExecuteReader)

            If dtActivaciones.Count > 0 Then
                dtActivaciones(0).CodigoActivacion = IV
                dtActivaciones(0).FechaCaducidad = FechaEncriptada
                taActivaciones.Update(dtActivaciones)
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        Finally
            If cmd.Connection.State = ConnectionState.Open Then cmd.Connection.Close()
        End Try

    End Function
#End Region

End Class
