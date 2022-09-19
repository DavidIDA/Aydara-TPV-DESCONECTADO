Imports a3ERPActiveX
Imports System.Collections

Public Class a3ERP

    Dim a3ERPEnlace As New a3ERPActiveX.Enlace

    Public Shared DatosConfig As dsEmpresa.DATOSCONFIGRow
    Public Shared fWaitForm As DevExpress.Utils.WaitDialogForm
    Public Shared Empresa As FormatoEmpresa

    Dim CODPRO As String, FECHA As Date, REFERENCIA As String

    Enum FormatoEmpresa
        IDA
        Calavia
        Molina
        Garrido
        Solum
        Bejalon
        BodegasJavier
        Rezusta
        Europast
        FPM
        Balper
    End Enum

    Public Function ListaProcedimientos() As Object
        Dim lista As Object() = {"Iniciar", "Finalizar", "Opcion"}
        Return lista
    End Function

#Region "Eventos sistema"
    Public Sub Iniciar(Empresa As String, Sistema As String, Optional NombreEmpresa As String = "", Optional Usuario As String = "", Optional Password As String = "")
        Try
            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.Skins.SkinManager.EnableFormSkins()
            DevExpress.Data.CurrencyDataController.DisableThreadingProblemsDetection = True

            If NombreEmpresa <> String.Empty Then
                If Usuario <> String.Empty Then My.Settings.Usuario = Usuario
                If Password <> String.Empty Then My.Settings.Password = Password
                Me.a3ERPEnlace.LoginUsuario(My.Settings.Usuario, My.Settings.Password)
            End If

            Me.a3ERPEnlace.Iniciar(NombreEmpresa)

            Me.a3ERPEnlace.RaiseOnException = True
            Me.a3ERPEnlace.VerBarraDeProgreso = True

            My.Settings.Usuario = Me.a3ERPEnlace.Usuario
            My.Settings.Empresa = Me.a3ERPEnlace.EmpresaActiva

            Aydara.ActualizaCadenaConexion(Me.a3ERPEnlace.Conexion, "aydara", "Isl#Web2009")

            'Configuración empresa
            Dim dsEmpresa As New dsEmpresa

            While Not dsEmpresa.DatosConfiguracion()

                If Not My.Computer.Keyboard.CtrlKeyDown Then Exit Try

                Dim fLogin As New fLogin(Me.a3ERPEnlace, My.Settings.Usuario, String.Empty)

                If fLogin.ShowDialog() = DialogResult.OK Then
                    My.Settings.Usuario = fLogin.Usuario
                    My.Settings.Password = fLogin.Password
                    Aydara.ActualizaCadenaConexion(Me.a3ERPEnlace.Conexion, My.Settings.Usuario, My.Settings.Password)
                Else
                    MsgBox("Error al conectar con librería a3ERP Distribución", MsgBoxStyle.Critical)
                    Exit Try
                End If

            End While

            'Configuración visual
            Dim SkinActivo As String = Me.SkinActivo
            If SkinActivo <> String.Empty Then

                Dim skins As DevExpress.Skins.SkinContainerCollection = DevExpress.Skins.SkinManager.Default.Skins

                For i As Integer = 0 To skins.Count - 1
                    If Replace(SkinActivo, " ", "") = Replace(skins(i).SkinName, " ", "") Then
                        My.Settings.Skin = skins(i).SkinName
                        Exit For
                    End If
                Next

            End If
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(My.Settings.Skin)

        Catch ex As Exception
            MsgBox("Error al conectar con librería a3ERP Distribución." & vbCrLf & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Sub Finalizar()
        Try
            Me.a3ERPEnlace.Acabar()

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "Funcíon obtener valor campo"
    Private Function ValorCampo(Registro As Object, NombreCampo As String) As String
        Try
            For i As Integer = 1 To Registro.length - 1
                If Registro(i)(0) = NombreCampo Then
                    Return Registro(i)(1)
                End If
            Next
            Return String.Empty
        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
#End Region

#Region "Opciones menú"
    Public Sub Opcion(IdOpcion As String, Parametro As String)
        Try
            Dim fOpcion As DevExpress.XtraEditors.XtraForm = Nothing

            Select Case IdOpcion
                Case "ida_ConfiguracionTPV"
                    fOpcion = New fConfiguracionTPV

                Case "ida_EnvioTiendas"
                    Dim Envio As New dsTPVEnvio
                    Envio.Enviar()

                Case "ida_RecepcionTiendas"
                    Dim Recepcion As New dsTPVRecepcion
                    Recepcion.Recepcionar()

                Case "ida_ActualizacionTiendas"
                    fOpcion = New fRecepcionTiendas

                Case "ida_EstadisticasTienda"
                    fOpcion = New fEstadisticasTickets

                Case "ida_SituacionTienda"
                    fOpcion = New fSituacionTienda

                Case "ida_TicketsTiendas"
                    fOpcion = New fTickets

                Case "ida_LogComunicacionTiendas"
                    fOpcion = New fLogTiendas

                Case "ida_TerminalesInventario"
                    fOpcion = New fTerminalesInventario

                Case "ida_TotalesCaja"
                    fOpcion = New fIngresosTienda

                Case "ida_TarjetasTienda"
                    fOpcion = New fTarjetasTiendas

                Case "ida_CierreTienda"
                    fOpcion = New fCierreTienda

                Case "ida_Inventario"
                    'fOpcion = New fInventario

                Case "ida_PedidoTraspaso"
                    fOpcion = New fPedido(Parametro, False)

                Case "ida_PedidoCompraTraspaso"
                    fOpcion = New fPedido(Parametro, True)

            End Select

            If Not fOpcion Is Nothing Then fOpcion.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
#End Region

#Region "SkinActivo"
    Private Function SkinActivo()

        Dim Skin As String = String.Empty

        Dim ConexionSQL As New ADODB.Connection
        Dim RecordAffected As New Object

        ConexionSQL = a3ERPEnlace.GetConexionDB("SISTEMA")

        Dim rs As New ADODB.Recordset

        rs = ConexionSQL.Execute("SELECT __SKINUSUARIOS.SKINACTIVO FROM USUARIOS INNER JOIN __SKINUSUARIOS ON USUARIOS.ID = __SKINUSUARIOS.IDUSUARIO WHERE USUARIO = '" & My.Settings.Usuario & "'", RecordAffected)

        Try
            If Not rs.EOF Then
                Skin = rs.Fields("SKINACTIVO").Value
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        Return Skin

    End Function
#End Region

End Class
