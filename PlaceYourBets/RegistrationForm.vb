Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Public Class RegistrationForm

    Private Sub RegistrationForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        usernameTextBox.TextAlign = HorizontalAlignment.Center
        Me.LinkLabel.Location = New System.Drawing.Point(0, 10)

    End Sub

    Private Sub registerButton_Click(sender As System.Object, e As System.EventArgs) Handles registerButton.Click
        Dim fb = New FixtureBuilder
        Dim userList = New List(Of String)
        Dim username As String
        userList = fb.getPRUsers()
        username = Me.usernameTextBox.Text
        Dim urlBase As String = "http://www.predictresults.co.uk/pradeep/PYBMembers.php?user='"
        Dim url As String

        If userList.Contains(username) Then
            url = urlBase + username + "'"

            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

            Dim receiveStream As Stream = response.GetResponseStream()
            Dim readStream As New StreamReader(receiveStream, Encoding.UTF8)

            response.Close()
            readStream.Close()

            MsgBox("User '" + username + "' " + "registered as Place Your Bets user")
            ContainerForm.Show()
            Dim fLoginUserControl As New LoginUserControl
            ContainerForm.MainFlowLayoutPanel.Controls.Add(fLoginUserControl)
            ContainerForm.AcceptButton = fLoginUserControl.loginButton
            Me.Close()

        Else
            MsgBox("Username not recognised")
        End If
    End Sub

    Private Sub closeButton_Click(sender As System.Object, e As System.EventArgs) Handles closeButton.Click
        ContainerForm.Show()
        Dim fLoginUserControl As New LoginUserControl
        ContainerForm.MainFlowLayoutPanel.Controls.Add(fLoginUserControl)
        ContainerForm.AcceptButton = fLoginUserControl.loginButton
        Me.Close()
    End Sub

    Private Sub LinkLabel_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel.LinkClicked
        Me.LinkLabel.LinkVisited = True
        System.Diagnostics.Process.Start("http://www.predictresults.co.uk/register-3/")
    End Sub
End Class