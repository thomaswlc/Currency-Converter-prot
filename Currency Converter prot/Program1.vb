Public Class Program1

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Selection.Show()
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetText()
        Change.ResetText()
        txtAmount.ResetText()
    End Sub

    Private Sub USD_CheckedChanged(sender As Object, e As EventArgs) Handles USD.CheckedChanged
        Dim Amount As Decimal
        Dim USD As Decimal

        Amount = txtAmount.Text

        USD = Amount * 1.206
        Change.Text = USD
    End Sub

    Private Sub EUR_CheckedChanged(sender As Object, e As EventArgs) Handles EUR.CheckedChanged
        Dim Amount As Decimal
        Dim EUR As Decimal

        Amount = txtAmount.Text

        EUR = Amount * 1.17
        Change.Text = EUR
    End Sub

    Private Sub CNY_CheckedChanged(sender As Object, e As EventArgs) Handles CNY.CheckedChanged
        Dim Amount As Decimal
        Dim CNY As Decimal

        Amount = txtAmount.Text

        CNY = Amount * 9.04
        Change.Text = CNY
    End Sub

    Private Sub COP_CheckedChanged(sender As Object, e As EventArgs) Handles COP.CheckedChanged
        Dim Amount As Decimal
        Dim COP As Decimal

        Amount = txtAmount.Text

        COP = Amount * 5009
        Change.Text = COP

    End Sub
End Class