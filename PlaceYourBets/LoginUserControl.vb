Imports System.String
Imports System.Text
Imports System.Deployment.Application

Public Class LoginUserControl

    Private userId As Integer

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub loginButton_Click(sender As System.Object, e As System.EventArgs) Handles loginButton.Click

        Dim fb As New FixtureBuilder

        Dim userDictionary As New Dictionary(Of String, Integer)
        userDictionary = fb.getUsersAndIds()

        Dim username As String = usernameTextBox.Text.ToLower()
        userId = -1

        If username = "" Then
            MsgBox("Please enter your username")

        Else
            If userDictionary.ContainsKey(username) Then
                userDictionary.TryGetValue(username, userId)
                ContainerForm.currentUser = userId
                ContainerForm.enterPredictionsButton.Text = "Enter Predictions"
                ContainerForm.betSlipButton.Text = "Bet Slip"
                ContainerForm.whoBetButton.Text = "Who's Bet"
                ContainerForm.predictionLeagueButton.Text = "Prediction League"
                ContainerForm.myAccountButton.Text = "My Account"
                ContainerForm.logOutButton.Text = "Log Off"

                ContainerForm.logOutButton.Visible = True
                ContainerForm.enterPredictionsButton.Enabled = True
                ContainerForm.betSlipButton.Enabled = True
                ContainerForm.whoBetButton.Enabled = True
                ContainerForm.predictionLeagueButton.Enabled = True
                ContainerForm.myAccountButton.Enabled = True
                ContainerForm.logOutButton.Enabled = True
                ContainerForm.coverTitleLabel.Visible = True
                Me.Visible = False


            Else
                MsgBox("Username not recognised")
                usernameTextBox.Clear()
            End If

        End If

    End Sub

    Public Function getUser()
        Return userId
    End Function

    Private Sub shutdownButton_Click(sender As System.Object, e As System.EventArgs) Handles shutdownButton.Click
        Application.Exit()
    End Sub

    Private Sub registerButton_Click(sender As System.Object, e As System.EventArgs) Handles registerButton.Click
        RegistrationForm.Show()
        Me.Visible = False
    End Sub

End Class
