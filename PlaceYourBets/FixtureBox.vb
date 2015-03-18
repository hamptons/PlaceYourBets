﻿Public Class FixtureBox

    Public Sub New(home As String, away As String, fixtureDate As Date, homeBadge As Image, awayBadge As Image)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        homeLabel.Text = home
        awayLabel.Text = away
        dateLabel.Text = fixtureDate
        homeBadgeBox.Image = homeBadge
        awayBadgeBox.Image = awayBadge

    End Sub


    Private Sub nextButton_Click(sender As System.Object, e As System.EventArgs) Handles nextButton.Click
        If ContainerForm.getFixtureNo() = 9 Then
            ContainerForm.reviewPredictions()
        Else
            ContainerForm.makeFixtureVisible(True)
        End If
    End Sub

    Private Sub backButton_Click(sender As System.Object, e As System.EventArgs) Handles backButton.Click
        ContainerForm.makeFixtureVisible(False)
    End Sub

End Class
