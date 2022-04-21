Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextProgressBar1.Value = 100 Then
            TextProgressBar1.ProgressColor = Color.LightGreen
            TextProgressBar1.Value = 0
        End If

        TextProgressBar1.Value = TextProgressBar1.Value + 10

        If TextProgressBar1.Value < 20 Then
            TextProgressBar1.CustomText = "Stage 1"
        ElseIf TextProgressBar1.Value > 30 AndAlso TextProgressBar1.Value < 50 Then
            TextProgressBar1.CustomText = "Stage 2"
        ElseIf TextProgressBar1.Value > 99 Then
            TextProgressBar1.CustomText = "Done"
            TextProgressBar1.ProgressColor = Color.Yellow
        End If
    End Sub
End Class
