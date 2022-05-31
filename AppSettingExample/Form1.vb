Public Class Form1
    Private Sub GetButton_Click(sender As Object, e As EventArgs) Handles GetButton.Click
        Label1.Text = ApplicationSetting.GetConnection
    End Sub

    Private Sub SetButton_Click(sender As Object, e As EventArgs) Handles SetButton.Click
        ApplicationSetting.SetConnection(ConnectionStringTextBox.Text)
    End Sub
End Class
