Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Models
	''' <summary>
	''' Represents a single key/value from configuration file
	''' </summary>
	Public Class SettingItem
		Implements INotifyPropertyChanged

		Private _value As String
		''' <summary>
		''' Key in file
		''' </summary>
		Public Property Name() As String

		''' <summary>
		''' Value of key
		''' </summary>
		Public Property Value() As String
			Get
				Return _value
			End Get
			Set(ByVal value As String)
				_value = value
				OnPropertyChanged()
			End Set
		End Property
		''' <summary>
		''' Expected type as when read in all values are strings
		''' </summary>
		Public Property Type() As Type
		''' <summary>
		''' Is Value a folder
		''' </summary>
		Public Property IsPath() As Boolean
		Public Overrides Function ToString() As String
			Return $"{Name} = {Value}"
		End Function

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Protected Overridable Sub OnPropertyChanged(<CallerMemberName> Optional ByVal propertyName As String = Nothing)
			PropertyChangedEvent?.Invoke(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
	End Class
End Namespace
