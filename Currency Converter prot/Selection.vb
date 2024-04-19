Public Class Selection
    Private Sub btnLocal_Click(sender As Object, e As EventArgs) Handles btnLocal.Click
        Program1.Show()
        Me.Hide()
        ' "Program1" is the 3rd form in the program and will show with "Show()".
        ' "Me" is the current form you are on and will hide with "Hide()".
    End Sub

    Private Sub btnCommon_Click(sender As Object, e As EventArgs) Handles btnCommon.Click
        Program2.Show()
        Me.Hide()
        ' "Program2" is the 4th and last form in the program and will show with "Show()".
        ' "Me" is the current form you are on and will hide with "Hide()". 
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
        ' Exits the application.
    End Sub
End Class