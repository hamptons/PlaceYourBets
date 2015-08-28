Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Public Class FixturesForm

    Private fixtures As New List(Of Fixture)
    Private fixtureNo As Integer = 0
    Private fixtureBoxList As New List(Of FixtureBox)
    Private FixtureReviewUserControlList As New List(Of FixtureReviewUserControl)

    Public Property currentUser As Integer
        Get
            Return m_user
        End Get
        Set(value As Integer)
            m_user = value
        End Set
    End Property
    Private m_user As Integer

    'Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    '    Dim fb As New FixtureBuilder
    '    fixtures = fb.getFixtures()
    '    Dim fix As Integer = 0

    '    For Each Fixture As Fixture In fixtures
    '        Dim usercontrol As New FixtureBox(Fixture.Home_Team, Fixture.Away_Team, Fixture.Date, getTeamBadge(fixtures.Item(fix).Home_Team), getTeamBadge(fixtures.Item(fix).Away_Team))
    '        Me.Controls.Add(usercontrol)
    '        usercontrol.Visible = False
    '        fixtureBoxList.Add(usercontrol)
    '        fix = fix + 1
    '    Next


    '    fixtureBoxList.Item(0).Visible = True
    '    fixtureBoxList.Item(0).backButton.Enabled = False
    '    Me.submitGroupBox.Visible = True
    '    Me.MainMenuButton.Visible = True


    'End Sub

    'Public Sub makeFixtureVisible(forward As Boolean)

    '    If (forward) Then

    '        Dim previousFixtureNo As Integer = fixtureNo
    '        fixtureNo = fixtureNo + 1
    '        fixtureBoxList.Item(previousFixtureNo).Visible = False

    '        If fixtureNo = 9 Then
    '            fixtureBoxList.Item(fixtureNo).nextButton.Text = "Review >"
    '            fixtureBoxList.Item(fixtureNo).nextButton.BackColor = Color.LightGreen
    '        End If

    '        If fixtureBoxList.Item(previousFixtureNo).homeRadioButton.Checked = True Then
    '            fixtures.Item(previousFixtureNo).Prediction = 1
    '        End If
    '        If fixtureBoxList.Item(previousFixtureNo).awayRadioButton.Checked = True Then
    '            fixtures.Item(previousFixtureNo).Prediction = 2
    '        End If
    '        If fixtureBoxList.Item(previousFixtureNo).drawRadioButton.Checked = True Then
    '            fixtures.Item(previousFixtureNo).Prediction = 3
    '        End If

    '    Else
    '        fixtureNo = fixtureNo - 1
    '        fixtureBoxList.Item(fixtureNo + 1).Visible = False

    '    End If

    '    fixtureBoxList.Item(fixtureNo).Visible = True

    'End Sub

    Public Function getFixtureNo() As Integer
        Return fixtureNo
    End Function

    Public Sub reviewPredictions()

        Dim previousFixtureNo As Integer = fixtureNo
        fixtureNo = fixtureNo + 1
        fixtureBoxList.Item(fixtureNo - 1).Visible = False

        If fixtureBoxList.Item(previousFixtureNo).homeRadioButton.Checked = True Then
            fixtures.Item(previousFixtureNo).Prediction = 1
        End If
        If fixtureBoxList.Item(previousFixtureNo).awayRadioButton.Checked = True Then
            fixtures.Item(previousFixtureNo).Prediction = 2
        End If
        If fixtureBoxList.Item(previousFixtureNo).drawRadioButton.Checked = True Then
            fixtures.Item(previousFixtureNo).Prediction = 3
        End If

        Me.MainMenuButton.Visible = False
        Me.FlowLayoutPanel.Enabled = True
        Me.FlowLayoutPanel.Visible = True
        Me.submitButton.Visible = True
        Me.editButton.Visible = True


        For Each fixture As Fixture In fixtures
            Dim review As New FixtureReviewUserControl(fixture.Home_Team, fixture.Away_Team)
            Me.FlowLayoutPanel.Controls.Add(review)

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

    Private Sub submitButton_Click(sender As System.Object, e As System.EventArgs) Handles submitButton.Click
        SubmitPredictions()
        MsgBox("Predictions submitted")
        MenuForm.Show()
        Me.Close()
    End Sub

    Private Sub editButton_Click(sender As System.Object, e As System.EventArgs) Handles editButton.Click

        If Me.FlowLayoutPanel.Controls.Count > 0 Then
            Me.FlowLayoutPanel.Controls.Clear()
        End If

        Me.FlowLayoutPanel.Visible = False
        fixtureBoxList.Item(0).Visible = True
        fixtureBoxList.Item(0).backButton.Enabled = False
        fixtureNo = 0

        Me.FlowLayoutPanel.Height = 166
        Me.FlowLayoutPanel.Width = 394

        Me.submitButton.Visible = False
        Me.editButton.Visible = False
        Me.MainMenuButton.Visible = True


    End Sub

    Public Function getTeamBadge(team As String) As Image
        Dim badge As Image = My.Resources.icon2
        Select Case team
            Case "Arsenal"
                badge = My.Resources.ARS
            Case "Aston Villa"
                badge = My.Resources.AST
            Case "Burnley"
                badge = My.Resources.BUR
            Case "Chelsea"
                badge = My.Resources.CHE
            Case "Crystal Palace"
                badge = My.Resources.CRY
            Case "Everton"
                badge = My.Resources.EVE
            Case "Hull City"
                badge = My.Resources.HUL
            Case "Leicester City"
                badge = My.Resources.LEI
            Case "Liverpool"
                badge = My.Resources.LIV
            Case "Manchester City"
                badge = My.Resources.MNC
            Case "Manchester United"
                badge = My.Resources.MNU
            Case "Newcastle United"
                badge = My.Resources.NWC
            Case "Queens Park Rangers"
                badge = My.Resources.QPR
            Case "Southampton"
                badge = My.Resources.SOU
            Case "Stoke City"
                badge = My.Resources.STO
            Case "Sunderland"
                badge = My.Resources.SUN
            Case "Swansea City"
                badge = My.Resources.SWA
            Case "Tottenham Hotspur"
                badge = My.Resources.TOT
            Case "West Bromwich Albion"
                badge = My.Resources.WBA
            Case "West Ham United"
                badge = My.Resources.WHU

        End Select

        Return badge

    End Function

    Public Function lastFixture(value As Integer) As Boolean

        Dim item = fixtures.Count

        If value = item Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub SubmitPredictions()

        Dim ProgressBar1 As ProgressBar
        ProgressBar1 = New ProgressBar()
        'set position
        ProgressBar1.Location = New Point(10, 10)
        'set values
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 200
        ProgressBar1.Value = 130
        'add the progress bar to the form
        Me.Controls.Add(ProgressBar1)
        ProgressBar1.Visible = True

        For Each fixture As Fixture In fixtures
            Dim UrlBase As String = "http://www.predictresults.co.uk/API/InsertDataUsingSP.php?userid="
            Dim user As String = currentUser.ToString()
            Dim fixtureID As String = fixture.ID.ToString()
            Dim prediction As String = fixture.Prediction.ToString()
            Dim url As String = UrlBase + user + "&fixtureid=" + fixtureID + "&prediction=" + prediction
            Dim request As HttpWebRequest = CType(WebRequest.Create(url), HttpWebRequest)
            Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

            'Get the stream associated with the response. 
            Dim receiveStream As Stream = response.GetResponseStream()
            Dim readStream As New StreamReader(receiveStream, Encoding.UTF8)

            response.Close()
            readStream.Close()

        Next

        ProgressBar1.Visible = False

    End Sub


    Private Sub MainMenuButton_Click(sender As System.Object, e As System.EventArgs) Handles MainMenuButton.Click
        MenuForm.Show()
        Me.Close()
    End Sub


    Private Sub ShutdownButton_Click(sender As System.Object, e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub submitGroupBox_Enter(sender As System.Object, e As System.EventArgs) Handles submitGroupBox.Enter

    End Sub
End Class
