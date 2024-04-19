Public Class MainPage
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
        ' Exits the application.
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Name = txtName.Text
        Selection.Show()
        Me.Hide()
        ' "Selection" is the next form in the program and will show with the "Show()".
        ' "Me" is the current form you are on in the program and will hide with "Hide()"
    End Sub
End Class
