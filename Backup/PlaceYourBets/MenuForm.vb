Public Class MenuForm

    Private Sub enterPredictionsButton_Click(sender As System.Object, e As System.EventArgs) Handles enterPredictionsButton.Click
        FixturesForm.Show()
        Me.Close()
    End Sub


    Private Sub reviewCurrentBet_Click(sender As System.Object, e As System.EventArgs) Handles reviewCurrentBet.Click
        ReviewForm.Show()
        Me.Close()
    End Sub

    Private Sub shutdownButton_Click(sender As System.Object, e As System.EventArgs) Handles shutdownButton.Click
        Application.Exit()
    End Sub

    Private Sub SubmittedPredictionsButton_Click(sender As System.Object, e As System.EventArgs) Handles SubmittedPredictionsButton.Click
        PredictionsSubmitted.Show()
        Me.Close()
    End Sub

    Private Sub PredictionLeagueTableButton_Click(sender As System.Object, e As System.EventArgs) Handles PredictionLeagueTableButton.Click
        PredictionLeagueTableForm.Show()
        Me.Close()
    End Sub
End Class

