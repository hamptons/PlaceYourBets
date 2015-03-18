Imports System.Net
Imports Newtonsoft.Json

Public Class ReviewForm

    Private fixtures As New List(Of Fixture)

    Private Sub ReviewForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim fb As New FixtureBuilder
        fixtures = fb.getBet()

        Me.ReviewBetsFlowLayoutPanel.Enabled = True
        Me.ReviewBetsFlowLayoutPanel.Visible = True
        Me.FinishReviewGroupBox.Visible = True
        Me.MainMenuButton.Visible = True

        For Each fixture As Fixture In fixtures
            Dim review As New FixtureReviewUserControl(fixture.Home_Team, fixture.Away_Team)
            Me.ReviewBetsFlowLayoutPanel.Controls.Add(review)

            If fixture.Prediction = 1 Then
                review.homeFixtureLabel.BackColor = Color.LightGreen
            End If
            If fixture.Prediction = 2 Then
                review.awayFixtureLabel.BackColor = Color.LightGreen
            End If
            If fixture.Prediction = 3 Then
                review.drawLabel.BackColor = Color.LightGreen
            End If
        Next

    End Sub

    Private Sub MainMenuButton_Click(sender As System.Object, e As System.EventArgs) Handles MainMenuButton.Click
        MenuForm.Show()
        Me.Close()
    End Sub

    Private Sub ShutdownButton_Click(sender As System.Object, e As System.EventArgs)
        Application.Exit()
    End Sub
End Class