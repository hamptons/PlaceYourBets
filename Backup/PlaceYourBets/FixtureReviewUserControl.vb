Public Class FixtureReviewUserControl

    Public Sub New(home As String, away As String)

        ' This call is required by the designer.
        InitializeComponent()

        homeFixtureLabel.Text = home
        awayFixtureLabel.Text = away
    End Sub

End Class
