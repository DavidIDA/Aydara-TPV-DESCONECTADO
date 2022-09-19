Imports System.Net.FtpWebRequest
Imports System.Net
Imports System.IO
Public Class Ftp

    Dim _host, _user, _pass, _envio As String
    Dim LOG As New dsTPVLog

#Region "Properties"
    Property host As String
        Get
            Return Me._host
        End Get
        Set(value As String)
            Me._host = value
        End Set
    End Property
    Property user As String
        Get
            Return Me._user
        End Get
        Set(value As String)
            Me._user = value
        End Set
    End Property
    Property pass As String
        Get
            Return Me._pass
        End Get
        Set(value As String)
            Me._pass = value
        End Set
    End Property
    Property envio As String
        Get
            Return Me._envio
        End Get
        Set(value As String)
            Me._envio = value
        End Set
    End Property
#End Region

    Enum Direccion
        Envio
        Recepcion
    End Enum

    Public Sub New()

        Dim dtConfig As New dsTPVConfiguracion.IDA_AYDARATPVDataTable
        Dim taConfig As New dsTPVConfiguracionTableAdapters.IDA_AYDARATPVTableAdapter

        taConfig.Fill(dtConfig)

        If dtConfig.Count > 0 Then
            With dtConfig(0)
                Me.envio = .ENVIO
                Me.host = .RECEPCION
                Me.user = .USUARIO
                Me.pass = .PASSWORD
            End With
        End If

    End Sub

#Region "EliminarFichero"
    Public Function EliminarFichero(ByVal fichero As String) As String
        Dim peticionFTP As FtpWebRequest

        ' Creamos una petición FTP con la dirección del fichero a eliminar
        peticionFTP = CType(WebRequest.Create(New Uri(fichero)), FtpWebRequest)

        ' Fijamos el usuario y la contraseña de la petición
        peticionFTP.Credentials = New NetworkCredential(user, pass)

        ' Seleccionamos el comando que vamos a utilizar: Eliminar un fichero
        peticionFTP.Method = WebRequestMethods.Ftp.DeleteFile
        peticionFTP.UsePassive = False

        Try
            Dim respuestaFTP As FtpWebResponse
            respuestaFTP = CType(peticionFTP.GetResponse(), FtpWebResponse)
            respuestaFTP.Close()
            ' Si todo ha ido bien, devolvemos String.Empty
            Return String.Empty
        Catch ex As Exception
            ' Si se produce algún fallo, se devolverá el mensaje del error
            Return ex.Message
        End Try
    End Function
#End Region

#Region "ExisteObjeto"
    Public Function ExisteObjeto(ByVal dir As String, Optional ByVal EsDirectorio As Boolean = False) As Boolean

        Dim peticionFTP As FtpWebRequest

        ' Creamos una peticion FTP con la dirección del objeto que queremos saber si existe
        peticionFTP = CType(WebRequest.Create(New Uri(dir)), FtpWebRequest)

        ' Fijamos el usuario y la contraseña de la petición
        peticionFTP.Credentials = New NetworkCredential(user, pass)

        If EsDirectorio Then
            ' Para saber si el objeto existe, solicitamos la fecha de creación del mismo
            peticionFTP.Method = WebRequestMethods.Ftp.ListDirectory
        Else
            ' Para saber si el objeto existe, solicitamos la fecha de creación del mismo
            peticionFTP.Method = WebRequestMethods.Ftp.GetDateTimestamp
        End If

        peticionFTP.UsePassive = False

        peticionFTP.Timeout = 100000

        Dim respuestaFTP As FtpWebResponse = Nothing

        Try
            ' Si el objeto existe, se devolverá True
            respuestaFTP = CType(peticionFTP.GetResponse, FtpWebResponse)
            Return True

        Catch ex As Exception
            ' Si el objeto no existe, se producirá un error y al entrar por el Catch
            ' se devolverá falso
            Return False
        Finally
            If Not respuestaFTP Is Nothing Then respuestaFTP.Close()
        End Try

    End Function
#End Region

#Region "CreaDirectorio"
    Public Function CreaDirectorio(ByVal dir As String) As String
        Dim peticionFTP As FtpWebRequest

        ' Creamos una peticion FTP con la dirección del directorio que queremos crear
        peticionFTP = CType(WebRequest.Create(New Uri(dir)), FtpWebRequest)

        ' Fijamos el usuario y la contraseña de la petición
        peticionFTP.Credentials = New NetworkCredential(user, pass)

        ' Seleccionamos el comando que vamos a utilizar: Crear un directorio
        peticionFTP.Method = WebRequestMethods.Ftp.MakeDirectory

        peticionFTP.Timeout = 100000

        Try
            Dim respuesta As FtpWebResponse
            respuesta = CType(peticionFTP.GetResponse(), FtpWebResponse)
            respuesta.Close()
            ' Si todo ha ido bien, se devolverá String.Empty
            Return String.Empty
        Catch ex As Exception
            ' Si se produce algún fallo, se devolverá el mensaje del error
            Return ex.Message
        End Try
    End Function
#End Region

#Region "SubirFicheroEntradasAlmacen"
    Public Function SubirFicheroEntradasAlmacen(ByVal fichero As String, NombreFichero As String) As String
        Try
            Dim infoFichero As New FileInfo(fichero)

            Dim uri As String
            uri = Me.envio & "/" & NombreFichero

            ' Si no existe el directorio, lo creamos
            If Not ExisteObjeto(Me.envio, True) Then
                CreaDirectorio(Me.envio)
            End If

            If ExisteObjeto(uri) Then EliminarFichero(uri)

            Dim peticionFTP As FtpWebRequest

            ' Creamos una peticion FTP con la dirección del fichero que vamos a subir
            peticionFTP = CType(FtpWebRequest.Create(New Uri(uri)), FtpWebRequest)

            ' Fijamos el usuario y la contraseña de la petición
            peticionFTP.Credentials = New NetworkCredential(user, pass)

            peticionFTP.KeepAlive = False
            peticionFTP.UsePassive = False

            ' Seleccionamos el comando que vamos a utilizar: Subir un fichero
            peticionFTP.Method = System.Net.WebRequestMethods.Ftp.AppendFile

            ' Especificamos el tipo de transferencia de datos
            If UCase(Mid(fichero, fichero.Length - 3)) = ".SEQ" Then
                peticionFTP.UseBinary = False
            Else
                peticionFTP.UseBinary = True
            End If

            ' Informamos al servidor sobre el tamaño del fichero que vamos a subir
            peticionFTP.ContentLength = infoFichero.Length

            ' Fijamos un buffer de 2KB
            Dim longitudBuffer As Integer
            longitudBuffer = 2048
            Dim lector As Byte() = New Byte(2048) {}

            Dim num As Integer

            ' Abrimos el fichero para subirlo
            Dim fs As FileStream
            fs = infoFichero.OpenRead()


            Dim escritor As Stream
            escritor = peticionFTP.GetRequestStream()

            ' Leemos 2 KB del fichero en cada iteración
            num = fs.Read(lector, 0, longitudBuffer)

            While (num <> 0)
                ' Escribimos el contenido del flujo de lectura en el
                ' flujo de escritura del comando FTP
                escritor.Write(lector, 0, num)
                num = fs.Read(lector, 0, longitudBuffer)
            End While

            escritor.Close()
            fs.Close()
            ' Si todo ha ido bien, se devolverá String.Empty
            Return String.Empty

        Catch ex As Exception
            ' Si se produce algún fallo, se devolverá el mensaje del error
            Return ex.Message
        End Try
    End Function
#End Region

#Region "SubirFichero"
    Public Function SubirFichero(ByVal fichero As String, filename As String, Optional destino As String = "") As String
        Try
            If destino = String.Empty Then destino = Me.envio

            ' Si no existe el directorio, lo creamos
            If Not ExisteObjeto(destino, True) Then
                CreaDirectorio(destino)
            End If

            destino &= "/" & filename

            My.Computer.Network.UploadFile(fichero, destino, user, pass, True, 100000, FileIO.UICancelOption.DoNothing)



            Return True

        Catch ex As Exception
            'If Me.SubirFicheroFTP(fichero, destino, dir) Then
            '    Return True
            'Else
            '    Return False
            'End If
            Return False
        End Try
    End Function
#End Region

#Region "DameFicheros"
    Public Function DameFicheros(Directorio As String, Optional eliminar As Boolean = False)

        Dim reader As StreamReader = Nothing

        Try
            Dim Resultado As New Collections.ArrayList

            Dim ftpRequest As FtpWebRequest = CType(WebRequest.Create(host), FtpWebRequest)

            ' use the provided credentials

            ftpRequest.Credentials = New NetworkCredential(user, pass)

            ' Download a file. Look at the other methods to see all of the potential FTP features
            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory

            ' get the response object
            Dim ftpResponse As FtpWebResponse = CType(ftpRequest.GetResponse, FtpWebResponse)

            Dim streamresultado As Stream = ftpResponse.GetResponseStream()

            reader = New StreamReader(streamresultado, False)

            Dim line As String
            ' Read and display the lines from the file until the end 
            ' of the file is reached.
            Do
                line = reader.ReadLine()
                If Not IsNothing(line) Then

                    If Len(line) > 3 Then
                        If UCase(Mid(line, Len(line) - 3)) = ".SEQ" Then

                            'Comprobar si existe un fichero con el mismo nombre pendiente
                            If IO.File.Exists(Directorio & "\" & line) Then
                                If IO.File.ReadAllLines(Directorio & "\" & line).Length <> 0 Then Continue Do
                            End If

                            'Descargar fichero
                            Aydara.Estado("Descargando fichero " & line)
                            LOG.Nuevo("R", "Descargando fichero " & line)
                            My.Computer.Network.DownloadFile(Me.host & "/" & line, Directorio & "\" & line, Me.user, Me.pass, True, 600000, True)

                            If eliminar Then

                                'Comprobar fichero descargado
                                If IO.File.ReadAllLines(Directorio & "\" & line).Length <> 0 Then

                                    'Eliminar fichero
                                    Dim ConexionFTP As New Ftp()
                                    ConexionFTP.EliminarFichero(Me.host & "/" & line)

                                Else

                                    LOG.Nuevo("X", "Fichero descargado vacío." & vbCrLf & line)

                                End If

                            End If

                        End If
                    End If

                End If

            Loop Until line Is Nothing

            Return True

        Catch ex As Exception
            Return False
        Finally
            If Not IsNothing(reader) Then
                reader.Close()
            End If
        End Try
    End Function
#End Region

#Region "DescargarFichero"
    Public Function DescargarFichero(NombreFichero As String, Directorio As String, DireccionFtp As Direccion, Optional eliminar As Boolean = False)
        Try
            'Comprobar si existe un fichero con el mismo nombre pendiente
            If IO.File.Exists(Directorio & "\" & NombreFichero) Then
                If IO.File.ReadAllLines(Directorio & "\" & NombreFichero).Length <> 0 Then Return False
            End If

            'Descargar fichero
            If ExisteObjeto(IIf(DireccionFtp = Direccion.Envio, Me.envio, Me.host) & "/" & NombreFichero) Then

                My.Computer.Network.DownloadFile(IIf(DireccionFtp = Direccion.Envio, Me.envio, Me.host) & "/" & NombreFichero, Directorio & "\" & NombreFichero, Me.user, Me.pass, True, 600000, True)

                If eliminar Then

                    'Comprobar fichero descargado
                    If IO.File.ReadAllLines(Directorio & "\" & NombreFichero).Length <> 0 Then

                        'Eliminar fichero
                        Dim ConexionFTP As New Ftp()
                        ConexionFTP.EliminarFichero(IIf(DireccionFtp = Direccion.Envio, Me.envio, Me.host) & "/" & NombreFichero)

                    Else

                        LOG.Nuevo("X", "Fichero descargado vacío." & vbCrLf & NombreFichero)

                    End If

                End If

            End If

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

End Class