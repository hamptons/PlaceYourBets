Public Class UserPredictionsUserControl
    Public Sub New(user As String)

        ' This call is required by the designer.
        InitializeComponent()

        userLabel.Text = user
        submittedLabel.Text = "Not Submitted"
        submittedLabel.BackColor = Color.Red

    End Sub
End Class
