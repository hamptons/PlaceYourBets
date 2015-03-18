Imports System
Imports System.IO
Imports System.Net
Imports System.Text

Public Class ContainerForm

    Private fixtureNo As Integer = 0
    Private fixtures As New List(Of Fixture)
    Private fixtureBoxList As New List(Of FixtureBox)
    Private userList As New List(Of String)
    Private submittedList As New List(Of String)
    Private userResultList As New List(Of Users)
    Private fix As Integer

    Public Property currentUser As Integer
        Get
            Return m_user
        End Get
        Set(value As Integer)
            m_user = value
        End Set
    End Property
    Private m_user As Integer

    Private Sub ContainerForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim version As Version
        version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version
        Me.Text = String.Format("v{0}.{1}", version.Major, version.Minor)

        Me.enterPredictionsButton.Visible = True
        Me.betSlipButton.Visible = True
        Me.whoBetButton.Visible = True
        Me.predictionLeagueButton.Visible = True
        Me.myAccountButton.Visible = True
        Me.logOutButton.Visible = True
        Me.enterPredictionsButton.Text = ""
        Me.betSlipButton.Text = ""
        Me.whoBetButton.Text = ""
        Me.predictionLeagueButton.Text = ""
        Me.myAccountButton.Text = ""
        Me.logOutButton.Text = ""
        Me.enterPredictionsButton.Enabled = False
        Me.betSlipButton.Enabled = False
        Me.whoBetButton.Enabled = False
        Me.predictionLeagueButton.Enabled = False
        Me.myAccountButton.Enabled = False
        Me.logOutButton.Enabled = False
        Me.submitGroupBox.Visible = True
        Me.submitGroupBox.Visible = False
        Me.submitButton.Visible = False
        Me.editButton.Visible = False
        Me.MainFlowLayoutPanel.Visible = False
        Me.MainFlowLayoutPanel.Enabled = False
        Me.MainFlowLayoutPanel.Controls.Clear()

        Dim fLoginUserControl As New LoginUserControl
        Me.MainFlowLayoutPanel.Controls.Add(fLoginUserControl)
        Me.MainFlowLayoutPanel.Visible = True
        Me.MainFlowLayoutPanel.Enabled = True
        Me.AcceptButton = fLoginUserControl.loginButton

    End Sub


    Private Sub enterPredictionsButton_Click(sender As System.Object, e As System.EventArgs) Handles enterPredictionsButton.Click

        fixtureBoxList.Clear()
        Me.MainFlowLayoutPanel.Controls.Clear()
        Dim fb As New FixtureBuilder
        fixtures = fb.getFixtures()
        fix = 0

        Try

        For Each Fixture As Fixture In fixtures
            Dim usercontrol As New FixtureBox(Fixture.Home_Team, Fixture.Away_Team, Fixture.Date, getTeamBadge(fixtures.Item(fix).Home_Team), getTeamBadge(fixtures.Item(fix).Away_Team))
            MainFlowLayoutPanel.Controls.Add(usercontrol)
            usercontrol.Dock = DockStyle.Fill
            usercontrol.Visible = False
            fixtureBoxList.Add(usercontrol)
            fix = fix + 1

        Next

        fixtureBoxList.Item(0).Visible = True
        fixtureBoxList.Item(0).backButton.Enabled = False
        Me.submitButton.Visible = False
            Me.editButton.Visible = False

        Catch ex As NullReferenceException
            MsgBox("No fixtures available")
        End Try

        If fix <> 10 Then
            Me.MainFlowLayoutPanel.Controls.Clear()
            fixtureBoxList.Clear()
            MsgBox("There are currently no fixtures to display")
        End If

    End Sub

    Private Sub submitButton_Click(sender As System.Object, e As System.EventArgs) Handles submitButton.Click

        ProgressBarForm.Show()

        Me.SubmitPredictions()

        ProgressBarForm.Close()

        MsgBox("Predictions submitted")
        submitGroupBox.Visible = False
        Me.MainFlowLayoutPanel.Controls.Clear()


    End Sub

    Private Sub editButton_Click_1(sender As System.Object, e As System.EventArgs) Handles editButton.Click
        Dim list As New List(Of Control)

        For Each control In MainFlowLayoutPanel.Controls
            If TypeOf control Is FixtureReviewUserControl Then
                list.Add(control)
            End If
        Next

        For Each control In list
            MainFlowLayoutPanel.Controls.Remove(control)

        Next

        For Each fixture As Fixture In fixtures
            Dim review As New FixtureReviewUserControl(fixture.Home_Team, fixture.Away_Team)
            Me.MainFlowLayoutPanel.Controls.Remove(review)

        Next

        fixtureBoxList.Item(0).Visible = True
        fixtureBoxList.Item(0).backButton.Enabled = False
        fixtureNo = 0

        Me.submitGroupBox.Visible = False
        Me.submitButton.Visible = False
        Me.editButton.Visible = False
    End Sub

    Private Sub betSlipButton_Click_1(sender As System.Object, e As System.EventArgs) Handles betSlipButton.Click
        Me.MainFlowLayoutPanel.Controls.Clear()
        Dim fb As New FixtureBuilder
        fixtures = fb.getBet()

        Me.submitGroupBox.Visible = False

        Try
            For Each fixture As Fixture In fixtures
                Dim review As New FixtureReviewUserControl(fixture.Home_Team, fixture.Away_Team)
                Me.MainFlowLayoutPanel.Controls.Add(review)

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

        Catch ex As NullReferenceException
            MsgBox("Not enough users have entered their predictions yet. Please try later")
        End Try
    End Sub

    Private Sub whoBetButton_Click(sender As System.Object, e As System.EventArgs) Handles whoBetButton.Click
        Me.MainFlowLayoutPanel.Controls.Clear()
        Dim fb As New FixtureBuilder
        userList = fb.getUsers()
        submittedList = fb.usersSubmitted()

        Me.MainFlowLayoutPanel.Enabled = True
        Me.MainFlowLayoutPanel.Visible = True
        Me.submitGroupBox.Visible = False

        For Each user As String In userList
            Dim review As New UserPredictionsUserControl(user)
            Me.MainFlowLayoutPanel.Controls.Add(review)

            If submittedList.Contains(user) Then
                review.submittedLabel.BackColor = Color.LightGreen
                review.submittedLabel.Text = "Submitted"
            End If

        Next
    End Sub

    Private Sub predictionLeagueButton_Click(sender As System.Object, e As System.EventArgs) Handles predictionLeagueButton.Click
        Me.MainFlowLayoutPanel.Controls.Clear()
        Dim fb As New FixtureBuilder
        userResultList = fb.getScores()
        Dim userDictionary As New Dictionary(Of Integer, String)
        userDictionary = fb.getIdsandUsers()

        Me.MainFlowLayoutPanel.Enabled = True
        Me.MainFlowLayoutPanel.Visible = True
        Me.submitGroupBox.Visible = False

        Dim name As String = ""

        For Each user As Users In userResultList
            userDictionary.TryGetValue(user.UserID, name)
            Dim review As New PredictionLeagueUserControl(name, user.correct)
            Me.MainFlowLayoutPanel.Controls.Add(review)

        Next
    End Sub

    Private Sub logOutButton_Click(sender As System.Object, e As System.EventArgs) Handles logOutButton.Click
        Me.MainFlowLayoutPanel.Controls.Clear()
        Me.enterPredictionsButton.Text = ""
        Me.betSlipButton.Text = ""
        Me.whoBetButton.Text = ""
        Me.predictionLeagueButton.Text = ""
        Me.myAccountButton.Text = ""
        Me.logOutButton.Text = ""
        Me.enterPredictionsButton.Enabled = False
        Me.betSlipButton.Enabled = False
        Me.whoBetButton.Enabled = False
        Me.predictionLeagueButton.Enabled = False
        Me.myAccountButton.Enabled = False
        Me.logOutButton.Enabled = False
        Me.coverTitleLabel.Visible = False
        Dim fLoginUserControl As New LoginUserControl
        Me.MainFlowLayoutPanel.Controls.Add(fLoginUserControl)
        Me.AcceptButton = fLoginUserControl.loginButton
    End Sub

    Public Sub makeFixtureVisible(forward As Boolean)
        Try
            If (forward) Then

                Dim previousFixtureNo As Integer = fixtureNo
                fixtureNo = fixtureNo + 1
                fixtureBoxList.Item(previousFixtureNo).Visible = False

                If fixtureNo = 9 Then
                    fixtureBoxList.Item(fixtureNo).nextButton.Text = "Review >"
                    fixtureBoxList.Item(fixtureNo).nextButton.BackColor = Color.LightGreen
                End If

                If fixtureBoxList.Item(previousFixtureNo).homeRadioButton.Checked = True Then
                    fixtures.Item(previousFixtureNo).Prediction = 1
                End If
                If fixtureBoxList.Item(previousFixtureNo).awayRadioButton.Checked = True Then
                    fixtures.Item(previousFixtureNo).Prediction = 2
                End If
                If fixtureBoxList.Item(previousFixtureNo).drawRadioButton.Checked = True Then
                    fixtures.Item(previousFixtureNo).Prediction = 3
                End If

            Else
                fixtureNo = fixtureNo - 1
                fixtureBoxList.Item(fixtureNo + 1).Visible = False

            End If

            fixtureBoxList.Item(fixtureNo).Visible = True

        Catch ex As ArgumentOutOfRangeException
            MsgBox("The full set of fixtures is not available. Please email complaints to michael.cole@advancedcomputersoftware.com")
        End Try
    End Sub

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

        Me.MainFlowLayoutPanel.Enabled = True
        Me.MainFlowLayoutPanel.Visible = True
        Me.submitGroupBox.Visible = True
        Me.submitButton.Visible = True
        Me.editButton.Visible = True


        For Each fixture As Fixture In fixtures
            Dim review As New FixtureReviewUserControl(fixture.Home_Team, fixture.Away_Team)
            Me.MainFlowLayoutPanel.Controls.Add(review)

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
            Case Else
                badge = My.Resources.icon2

        End Select

        Return badge

    End Function

    Public Sub SubmitPredictions()

        Dim submitted As Boolean = False

        While (Not submitted)

            For Each fixture As Fixture In fixtures

                ProgressBarForm.ProgressBar1.PerformStep()
                Dim UrlBase As String = "http://www.predictresults.co.uk/pradeep/InsertDataUsingSP.php?userid="
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

            submitted = True

        End While
    End Sub

    
End Class