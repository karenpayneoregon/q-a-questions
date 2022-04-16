Imports System.Configuration
Imports System.IO
Imports ConfigurationLibrary.Models


Namespace Classes

	Public Class SettingsOperations
		''' <summary>
		''' The environment, under the current project bin\debug folder there are three sub folders
		''' Development, Test and Production
		'''
		''' Each has the same app.config file as it would while running
		'''
		''' Below the app name compiled is SidesConnector.exe
		''' </summary>
		Private Const _configurationFileName As String = "SidesConnector.exe.config"

		Private Shared ReadOnly LocalFileNameDevelopment As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Development", _configurationFileName)
		Private Shared ReadOnly LocalFileNameTest As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Test", _configurationFileName)
		Private Shared ReadOnly LocalFileNameProduction As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Production", _configurationFileName)


		''' <summary>
		''' Set current <see cref="Models.WorkEnvironment"/>
		''' </summary>
		''' <param name="environment">Selected environment</param>
		''' <returns>folder location and file name</returns>
		Public Shared Function GetLocation(ByVal environment As WorkEnvironment) As (folder As String, fileName As String)
			Select Case environment
				Case WorkEnvironment.Development
					Return New ValueTuple(Of String, String)(Path.GetDirectoryName(LocalFileNameDevelopment), Path.GetFileName(LocalFileNameDevelopment))

				Case WorkEnvironment.Testing
					Return New ValueTuple(Of String, String)(Path.GetDirectoryName(LocalFileNameTest), Path.GetFileName(LocalFileNameTest))

				Case WorkEnvironment.Production
					Return New ValueTuple(Of String, String)(Path.GetDirectoryName(LocalFileNameProduction), Path.GetFileName(LocalFileNameProduction))

				Case Else
					Throw New ArgumentOutOfRangeException(NameOf(environment), environment, Nothing)
			End Select

		End Function

		''' <summary>
		''' Set value for specified key to current selected configuration file
		''' </summary>
		''' <param name="environment"><see cref="WorkEnvironment"/></param>
		''' <param name="key">AppSettings key</param>
		''' <param name="value">AppSettings value</param>
		''' <returns>success and a exception on failure</returns>
		Public Shared Function SetValue(ByVal environment As WorkEnvironment, ByVal key As String, ByVal value As String) As (success As Boolean, exception As Exception)

			Try
				Dim results = GetLocation(environment)
				Dim fileMap = New ExeConfigurationFileMap With {.ExeConfigFilename = Path.Combine(Path.GetFullPath(results.folder & "\" & results.fileName))}
				Dim config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None)

				config.AppSettings.Settings(key).Value = value
				config.Save()

				Return (True, Nothing)
			Catch ex As Exception
				Return (False, ex)
			End Try

		End Function

		Public Shared Function ReadSettings(Optional ByVal environment As WorkEnvironment = WorkEnvironment.Development) As (success As Boolean, exception As Exception, items As List(Of SettingItem))

			Try

				Dim results = GetLocation(environment)
				Dim fileMap = New ExeConfigurationFileMap With {.ExeConfigFilename = Path.Combine(Path.GetFullPath(results.folder & "\" & results.fileName))}
				Dim config = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None)
				Dim collection As KeyValueConfigurationCollection = config.AppSettings.Settings

				Dim list As List(Of SettingItem) = (From element As KeyValueConfigurationElement In collection Select New SettingItem() With {
						.Name = element.Key,
						.Value = element.Value,
						.Type = element.Key.GetType()
					}).OrderBy(Function(setting) setting.Name).ToList()


				For index As Integer = 0 To list.Count - 1


					Dim dummy As Integer = 0
					If Integer.TryParse(list(index).Value, dummy) Then
						list(index).Type = GetType(Integer)
					End If

					If Not String.IsNullOrWhiteSpace(list(index).Value) Then

						If list(index).Value.ToLower() = "false" OrElse list(index).Value.ToLower() = "true" Then
							list(index).Type = GetType(Boolean)
						End If

						If list(index).Value.Contains("\") Then
							list(index).IsPath = True
						End If

					End If
				Next index

				Return (True, Nothing, list)

			Catch ex As Exception
				Return (False, ex, Nothing)
			End Try


		End Function

	End Class
End Namespace
