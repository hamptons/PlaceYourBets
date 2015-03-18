Imports System.String
Imports System.Text
Imports System.Deployment.Application

Public Class LoginForm

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

        Dim username As String = usernameTextBox.Text
        userId = -1

        If username = "" Then
            MsgBox("Please enter your username")

        Else
            If userDictionary.ContainsKey(username) Then
                userDictionary.TryGetValue(username, userId)
                FixturesForm.currentUser = userId
                MenuForm.Show()
                Me.Close()
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
        Application.ExitThread()
    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        usernameTextBox.TextAlign = HorizontalAlignment.Center

        If ApplicationDeployment.IsNetworkDeployed Then
            Dim publishVersion As String = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString()
        End If

        Dim version As Version
        version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version
        Me.Text = String.Format("v{0}.{1}", version.Major, version.Minor)
    End Sub

    Private Sub registerButton_Click(sender As System.Object, e As System.EventArgs) Handles registerButton.Click
        RegistrationForm.Show()
        Me.Close()
    End Sub
End Class

