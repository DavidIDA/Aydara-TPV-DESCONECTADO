Imports System.ComponentModel
Imports System.Configuration.Install

Public Class Installer

    Public Sub New()
        MyBase.New()

        'El Diseñador de componentes requiere esta llamada.
        InitializeComponent()

        'Agregue el código de inicialización después de llamar a InitializeComponent

    End Sub

    Private Sub Installer_AfterInstall(ByVal sender As Object, ByVal e As System.Configuration.Install.InstallEventArgs) Handles Me.AfterInstall
        ''Encriptar cadena de conexión
        'Dim config As System.Configuration.Configuration = Configuration.ConfigurationManager.OpenExeConfiguration(Me.Context.Parameters("assemblyPath"))
        'config.ConnectionStrings.SectionInformation.ProtectSection(Nothing)
        'config.ConnectionStrings.SectionInformation.ForceSave = True
        'config.Save()
    End Sub

End Class
