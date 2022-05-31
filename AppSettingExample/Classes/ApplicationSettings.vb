Option Infer On

Imports System.Configuration
Imports System.IO
Imports System.Configuration.ConfigurationManager

Public Class ApplicationSetting
    Public Shared Property ConnectionPath() As String = "AppConnectionString"
    Public Shared Sub SetConnection(ByVal sender As String)
        SetValue(ConnectionPath(), sender)
    End Sub
    Public Shared ReadOnly Property GetConnection() As String
        Get
            Return AppSettings(ConnectionPath())
        End Get
    End Property
    Public Shared Sub SetValue(key As String, value As String)

        Dim appName = Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly().Location)

        Dim configFile = Path.Combine(appName, $"{Reflection.Assembly.GetExecutingAssembly().GetName().Name}.exe.config")

        Dim configFileMap = New ExeConfigurationFileMap With {.ExeConfigFilename = configFile}
        Dim config = OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None)

        If config.AppSettings.Settings(key) Is Nothing Then
            Throw New Exception($"Key {key} does not exist")
        End If

        config.AppSettings.Settings(key).Value = value

        config.Save()

        RefreshSection("appSettings")

    End Sub
End Class


