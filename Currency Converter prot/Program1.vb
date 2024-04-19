Public Class Program1
    Private Sub USD_CheckedChanged(sender As Object, e As EventArgs) Handles chcUSD.CheckedChanged
        Dim Amount As Decimal
        Dim USD As Decimal
        ' Declares "Amount" and "USD" as a decimal because they will be digits.

        Amount = txtAmount.Text
        ' Sets variable "Amount" as the label and will view text.

        USD = Amount * 1.206
        Change.Text = USD
        ' USD is Amount multiplied by 1.206 as that is the exchange rate.
        ' Changes the text to USD.

        If chcUSD.Checked Then

            Dim text2add As String
            text2add = "GBP-- " & txtAmount.Text & " - USD-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
        ' If the USD checkbox is checked then it will declare "text2add" as a string.
        ' "text2add" will add the idividual text "GBP-- " and the amount of GBP entered and then the individual text " - USD-- " and the amount of USD exchanged from GBP.
        ' That is then added to the ListBox "lstTransactions.
    End Sub

    Private Sub EUR_CheckedChanged(sender As Object, e As EventArgs) Handles chcEUR.CheckedChanged
        Dim Amount As Decimal
        Dim EUR As Decimal
        ' Declares "Amount" and "EUR" as a decimal because they will be digits.

        Amount = txtAmount.Text
        ' Sets variable "Amount" as the label and will view text.

        EUR = Amount * 1.17
        Change.Text = EUR
        ' EUR is Amount multiplied by 1.17 as that is the exchange rate.
        ' Changes the text to EUR.

        If chcEUR.Checked Then
            Dim text2add As String

            text2add = "GBP-- " & txtAmount.Text & " - EUR-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
        ' If the EUR checkbox is checked then it will declare "text2add" as a string.
        ' "text2add" will add the idividual text "GBP-- " and the amount of GBP entered and then the individual text " - EUR-- " and the amount of EUR exchanged from GBP.
        ' That is then added to the ListBox "lstTransactions.
    End Sub

    Private Sub CNY_CheckedChanged(sender As Object, e As EventArgs) Handles chcCNY.CheckedChanged
        Dim Amount As Decimal
        Dim CNY As Decimal
        ' Declares "Amount" and "CNY" as a decimal because they will be digits.

        Amount = txtAmount.Text
        ' Sets variable "Amount" as the label and will view text.

        CNY = Amount * 9.04
        Change.Text = CNY
        ' CNY is Amount multiplied by 9.04 as that is the exchange rate.
        ' Changes the text to CNY.

        If chcCNY.Checked Then
            Dim text2add As String

            text2add = "GBP-- " & txtAmount.Text & " - CNY-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
        ' If the CNY checkbox is checked then it will declare "text2add" as a string.
        ' "text2add" will add the idividual text "GBP-- " and the amount of GBP entered and then the individual text " - CNY-- " and the amount of CNY exchanged from GBP.
        ' That is then added to the ListBox "lstTransactions.
    End Sub

    Private Sub COP_CheckedChanged(sender As Object, e As EventArgs) Handles chcCOP.CheckedChanged
        Dim Amount As Decimal
        Dim COP As Decimal
        ' Declares "Amount" and "COP" as a decimal because they will be digits.

        Amount = txtAmount.Text
        ' Sets variable "Amount" as the label and will view text.

        COP = Amount * 5009
        Change.Text = COP
        ' COP is Amount multiplied by 5009 as that is the exchange rate.
        ' Changes the text to COP.

        If chcCOP.Checked Then
            Dim text2add As String

            text2add = "GBP-- " & txtAmount.Text & " - COP-- " & Change.Text
            lstTransactions.Items.Add(text2add)
        End If
        ' If the COP checkbox is checked then it will declare "text2add" as a string.
        ' "text2add" will add the idividual text "GBP-- " and the amount of GBP entered and then the individual text " - COP-- " and the amount of COP exchanged from GBP.
        ' That is then added to the ListBox "lstTransactions.
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
        ' Exits the application.
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Selection.Show()
        Me.Hide()
        ' "Selection" is the next form in the program and will show with the "Show()".
        ' "Me" is the current form you are on in the program and will hide with "Hide()"
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetText()
        Change.ResetText()
        txtAmount.ResetText()
        'When the Reset button is pressed, it resets the text with "ResetText()", "Change.ResetText()", "txtAmount.ResetText()".

    End Sub
End Class