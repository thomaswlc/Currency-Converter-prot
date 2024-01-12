Public Class MainPage
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Name = txtName.Text
        Selection.Show()
        Me.Hide()
    End Sub
End Class
