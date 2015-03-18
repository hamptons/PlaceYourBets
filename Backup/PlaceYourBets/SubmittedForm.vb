Public Class PredictionsSubmitted

    Private userList As New List(Of String)
    Private submittedList As New List(Of String)

    Private Sub ShutdownButton_Click(sender As System.Object, e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub MainMenuButton_Click(sender As System.Object, e As System.EventArgs) Handles MainMenuButton.Click
        MenuForm.Show()
        Me.Close()
    End Sub

    Private Sub ReviewForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim fb As New FixtureBuilder
        userList = fb.getUsers()
        submittedList = fb.usersSubmitted()

        Me.UserPredictionsFlowLayoutPanel.Enabled = True
        Me.UserPredictionsFlowLayoutPanel.Visible = True
        Me.NavigationGroupBox.Visible = True
        Me.MainMenuButton.Visible = True

        For Each user As String In userList
            Dim review As New UserPredictionsUserControl(user)
            Me.UserPredictionsFlowLayoutPanel.Controls.Add(review)

            If submittedList.Contains(user) Then
                review.submittedLabel.BackColor = Color.LightGreen
                review.submittedLabel.Text = "Submitted"
            End If

        Next

    End Sub

    Private Sub UserPredictionsFlowLayoutPanel_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles UserPredictionsFlowLayoutPanel.Paint

    End Sub
End Class