Option Strict On
Imports System.IO
Imports System.Text.RegularExpressions

Module Program
    Sub Main(args As String())

        Dim folderNames() As String = {"|OED", "!OED~", "<<Dir", "(Me&^"}

        For Each name In folderNames
            Console.WriteLine($"{name} is valid? {IsValidFolderName(name)}")
        Next

        Console.ReadLine()

    End Sub
End Module

Public Module Directory
    Private ReadOnly _illegalInFileName As New Regex($"[{Regex.Escape(
        New String(Path.GetInvalidFileNameChars()))}]", RegexOptions.Compiled)

    Public Function IsValidFolderName(folder As String) As Boolean
        Return _illegalInFileName.Replace(folder, "") = folder
    End Function
End Module


