Public Class PredictionLeagueTableForm

    Private userResultList As New List(Of Users)

    Private Sub MainMenuButton_Click(sender As System.Object, e As System.EventArgs) Handles MainMenuButton.Click
        MenuForm.Show()
        Me.Close()
    End Sub

    Private Sub ShutdownButton_Click(sender As System.Object, e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub PredictionLeagueTableForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim fb As New FixtureBuilder
        userResultList = fb.getScores()

        Me.PredictionsLeagueFlowLayoutPanel.Enabled = True
        Me.PredictionsLeagueFlowLayoutPanel.Visible = True
        Me.NavigationGroupBox.Visible = True
        Me.MainMenuButton.Visible = True

        For Each user As Users In userResultList
            Dim review As New PredictionLeagueUserControl(user.user, user.correct)
            Me.PredictionsLeagueFlowLayoutPanel.Controls.Add(review)

        Next

    End Sub
End Class

