Public Class Selection
    Private Sub btnLocal_Click(sender As Object, e As EventArgs) Handles btnLocal.Click
        Program1.Show()
        Me.Hide()
    End Sub

    Private Sub btnCommon_Click(sender As Object, e As EventArgs) Handles btnCommon.Click
        Program2.Show()
        Me.Hide()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub
End Class