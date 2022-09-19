Imports System.Net.FtpWebRequest
Imports System.Net
Imports System.IO
Public Class Ftp

    Dim host, user, pass As String

    Public Sub New(ByVal host As String, ByVal user As String, ByVal pass As String)
        Me.host = host
        Me.user = user
        Me.pass = pass
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
    'Public Function ExisteObjeto(ByVal dir As String, Optional ByVal EsDirectorio As Boolean = False) As Boolean

    '    'REVISAR FUNCIÓN (FALLA)
    '    Return True

    '    Dim peticionFTP As FtpWebRequest

    '    ' Creamos una peticion FTP con la dirección del objeto que queremos saber si existe
    '    peticionFTP = CType(WebRequest.Create(New Uri(dir)), FtpWebRequest)

    '    ' Fijamos el usuario y la contraseña de la petición
    '    peticionFTP.Credentials = New NetworkCredential(user, pass)

    '    If EsDirectorio Then
    '        ' Para saber si el objeto existe, solicitamos la fecha de creación del mismo
    '        peticionFTP.Method = WebRequestMethods.Ftp.ListDirectory
    '    Else
    '        ' Para saber si el objeto existe, solicitamos la fecha de creación del mismo
    '        peticionFTP.Method = WebRequestMethods.Ftp.GetDateTimestamp
    '    End If

    '    peticionFTP.UsePassive = False

    '    Try
    '        ' Si el objeto existe, se devolverá True
    '        Dim respuestaFTP As FtpWebResponse
    '        respuestaFTP = CType(peticionFTP.GetResponse, FtpWebResponse)
    '        respuestaFTP.Close()
    '        Return True
    '    Catch ex As Exception
    '        ' Si el objeto no existe, se producirá un error y al entrar por el Catch
    '        ' se devolverá falso
    '        Return False
    '    End Try
    'End Function
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

#Region "SubirFicheroFTP"
    Public Function SubirFicheroFTP(ByVal fichero As String, ByVal destino As String, ByVal dir As String) As String
        Dim infoFichero As New FileInfo(fichero)

        Dim uri As String
        uri = destino

        '' Si no existe el directorio, lo creamos
        'If Not ExisteObjeto(dir, True) Then
        '    CreaDirectorio(dir)
        'End If

        Dim peticionFTP As FtpWebRequest

        ' Creamos una peticion FTP con la dirección del fichero que vamos a subir
        peticionFTP = CType(FtpWebRequest.Create(New Uri(destino)), FtpWebRequest)

        ' Fijamos el usuario y la contraseña de la petición
        peticionFTP.Credentials = New NetworkCredential(user, pass)

        peticionFTP.KeepAlive = False
        peticionFTP.UsePassive = False

        ' Seleccionamos el comando que vamos a utilizar: Subir un fichero
        peticionFTP.Method = WebRequestMethods.Ftp.UploadFile

        ' Especificamos el tipo de transferencia de datos
        If Mid(fichero, fichero.Length - 3) = ".seq" Then
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

        Try
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
    Public Function SubirFichero(ByVal fichero As String, ByVal destino As String, ByVal dir As String) As String
        Try
            '' Si no existe el directorio, lo creamos
            'If Not ExisteObjeto(dir, True) Then
            '    CreaDirectorio(dir)
            'End If

            My.Computer.Network.UploadFile(fichero, destino, user, pass, 2500, FileIO.UICancelOption.DoNothing)

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

#Region "DameFicherosAlmacen"
    Public Function DameFicherosAlmacen()

        Dim reader As StreamReader = Nothing

        Try
            Dim Resultado As New ArrayList

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
                    If UCase(Mid(line, 1, 4)) = "AL" & Format(General.NumeroAlmacen, "00") Then

                        'Descargar fichero
                        My.Computer.Network.DownloadFile(General.Comunicaciones_Direccion & "/" & line, Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\" & line, General.Comunicaciones_Usuario, General.Comunicaciones_Password, True, 100000, True)

                        If Not Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\Entradas") Then
                            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\Entradas")
                        End If

                        If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\" & line) Then
                            File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\" & line, Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\Entradas\" & line, True)
                        End If

                        'Eliminar fichero
                        If IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\" & line).Length <> 0 Then
                            Dim ConexionFTP As New Ftp(General.Comunicaciones_Direccion, General.Comunicaciones_Usuario, General.Comunicaciones_Password)
                            ConexionFTP.EliminarFichero(General.Comunicaciones_Direccion & "/" & line)
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

#Region "DameFicherosTerminal"
    Public Function DameFicherosTerminal(ByVal Prefijo As String)

        Dim reader As StreamReader = Nothing

        Try
            Dim Resultado As New ArrayList

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
                    If UCase(Mid(line, 1, 8)) = Prefijo & Format(General.NumeroAlmacen, "00") Then

                        'Descargar fichero
                        My.Computer.Network.DownloadFile(General.Comunicaciones_Terminales & "/" & line, Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\" & line, General.Comunicaciones_Usuario, General.Comunicaciones_Password, True, 100000, True)

                        If Not Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\Terminal") Then
                            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\Terminal")
                        End If

                        If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\" & line) Then
                            File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\" & line, Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\Terminal\" & line, True)
                        End If

                        'Eliminar fichero
                        If IO.File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\Tienda " & Format(CodigoTienda, "00") & "\" & line).Length <> 0 Then
                            Dim ConexionFTP As New Ftp(General.Comunicaciones_Terminales, General.Comunicaciones_Usuario, General.Comunicaciones_Password)
                            ConexionFTP.EliminarFichero(General.Comunicaciones_Terminales & "/" & line)
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

#Region "ActualizaAplicacion"
    Public Shared Function ActualizaAplicacion(ByVal FTP As String, ByVal Usuario As String, ByVal Password As String)
        Try
            General.DatosTiendaActual(CodigoTienda)
        
            Dim ConexionFTP As New Ftp(General.Comunicaciones_Direccion, General.Comunicaciones_Usuario, General.Comunicaciones_Password)

            'Crear carpeta si no existe
            If Not My.Computer.FileSystem.DirectoryExists(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV") Then My.Computer.FileSystem.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV")

            'Descargar paquete instalacion si existe
            Dim Fichero As String = "AydaraTPV" & IIf(IntPtr.Size = 8, "_x64", "") & ".msi"
            'If My.Computer.Info.OSPlatform Then
            'If ConexionFTP.ExisteObjeto(General.Comunicaciones_Direccion & "/" & Fichero) Then
            '    My.Computer.Network.DownloadFile(General.Comunicaciones_Direccion & "/" & Fichero, Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\" & Fichero, General.Comunicaciones_Usuario, General.Comunicaciones_Password, True, 100000, True)
            '    Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\IDA\Aydara TPV\" & Fichero)
            '    Return True
            'Else
            '    Return False
            'End If

        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region

End Class