Public Class PredictionLeagueUserControl

    Public Sub New(user As String, correct As Double)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        usernameLabel.Text = user
        pointsLabel.Text = correct.ToString() + "%"
    End Sub
End Class
