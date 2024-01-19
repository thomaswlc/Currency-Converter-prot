Public Class Program1
    Private Sub USD_CheckedChanged(sender As Object, e As EventArgs) Handles chcUSD.CheckedChanged
        Dim Amount As Decimal
        Dim USD As Decimal


        Amount = txtAmount.Text

        USD = Amount * 1.206
        Change.Text = USD

        If chcUSD.Checked Then

            Dim text2add As String
            text2add = "GBP-- " & txtAmount.Text & " - USD-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
    End Sub

    Private Sub EUR_CheckedChanged(sender As Object, e As EventArgs) Handles chcEUR.CheckedChanged
        Dim Amount As Decimal
        Dim EUR As Decimal

        Amount = txtAmount.Text

        EUR = Amount * 1.17
        Change.Text = EUR

        If chcEUR.Checked Then
            Dim text2add As String

            text2add = "GBP-- " & txtAmount.Text & " - EUR-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
    End Sub

    Private Sub CNY_CheckedChanged(sender As Object, e As EventArgs) Handles chcCNY.CheckedChanged
        Dim Amount As Decimal
        Dim CNY As Decimal

        Amount = txtAmount.Text

        CNY = Amount * 9.04
        Change.Text = CNY

        If chcCNY.Checked Then
            Dim text2add As String

            text2add = "GBP-- " & txtAmount.Text & " - CNY-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
    End Sub

    Private Sub COP_CheckedChanged(sender As Object, e As EventArgs) Handles chcCOP.CheckedChanged
        Dim Amount As Decimal
        Dim COP As Decimal

        Amount = txtAmount.Text

        COP = Amount * 5009
        Change.Text = COP

        If chcCOP.Checked Then
            Dim text2add As String

            text2add = "GBP-- " & txtAmount.Text & " - COP-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
    End Sub
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


End Class