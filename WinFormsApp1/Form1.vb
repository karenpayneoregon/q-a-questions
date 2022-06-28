Imports System.Globalization
Public Class Form1
    Private ReadOnly _lastChecked As New LastChecked() With {.Index = -1}
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim months = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).ToList()
        checkedListBox1.DataSource = months
    End Sub

    Private Sub checkedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles checkedListBox1.ItemCheck
        _lastChecked.CheckState = e.NewValue
        _lastChecked.Index = e.Index
    End Sub

    Private Sub LastCheckedButton_Click(sender As Object, e As EventArgs) Handles LastCheckedButton.Click
        If _lastChecked.Index > -1 Then
            MessageBox.Show($"Index: {_lastChecked.Index,-5}{_lastChecked.CheckState}")
        Else
            MessageBox.Show("Nothing checked yet")
        End If
    End Sub
End Class

Public Class LastChecked
    Public Property Index() As Integer
    Public Property CheckState() As CheckState
End Class

