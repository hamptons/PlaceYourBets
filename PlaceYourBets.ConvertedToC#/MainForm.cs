using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Net;
using System.Text;
namespace PlaceYourBets
{

	public partial class FixturesForm
	{

		private List<Fixture> fixtures = new List<Fixture>();
		private int fixtureNo = 0;
		private List<FixtureBox> fixtureBoxList = new List<FixtureBox>();

		private List<FixtureReviewUserControl> FixtureReviewUserControlList = new List<FixtureReviewUserControl>();
		public int currentUser {
			get { return m_user; }
			set { m_user = value; }
		}

		private int m_user;
		//Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

		//    Dim fb As New FixtureBuilder
		//    fixtures = fb.getFixtures()
		//    Dim fix As Integer = 0

		//    For Each Fixture As Fixture In fixtures
		//        Dim usercontrol As New FixtureBox(Fixture.Home_Team, Fixture.Away_Team, Fixture.Date, getTeamBadge(fixtures.Item(fix).Home_Team), getTeamBadge(fixtures.Item(fix).Away_Team))
		//        Me.Controls.Add(usercontrol)
		//        usercontrol.Visible = False
		//        fixtureBoxList.Add(usercontrol)
		//        fix = fix + 1
		//    Next


		//    fixtureBoxList.Item(0).Visible = True
		//    fixtureBoxList.Item(0).backButton.Enabled = False
		//    Me.submitGroupBox.Visible = True
		//    Me.MainMenuButton.Visible = True


		//End Sub

		//Public Sub makeFixtureVisible(forward As Boolean)

		//    If (forward) Then

		//        Dim previousFixtureNo As Integer = fixtureNo
		//        fixtureNo = fixtureNo + 1
		//        fixtureBoxList.Item(previousFixtureNo).Visible = False

		//        If fixtureNo = 9 Then
		//            fixtureBoxList.Item(fixtureNo).nextButton.Text = "Review >"
		//            fixtureBoxList.Item(fixtureNo).nextButton.BackColor = Color.LightGreen
		//        End If

		//        If fixtureBoxList.Item(previousFixtureNo).homeRadioButton.Checked = True Then
		//            fixtures.Item(previousFixtureNo).Prediction = 1
		//        End If
		//        If fixtureBoxList.Item(previousFixtureNo).awayRadioButton.Checked = True Then
		//            fixtures.Item(previousFixtureNo).Prediction = 2
		//        End If
		//        If fixtureBoxList.Item(previousFixtureNo).drawRadioButton.Checked = True Then
		//            fixtures.Item(previousFixtureNo).Prediction = 3
		//        End If

		//    Else
		//        fixtureNo = fixtureNo - 1
		//        fixtureBoxList.Item(fixtureNo + 1).Visible = False

		//    End If

		//    fixtureBoxList.Item(fixtureNo).Visible = True

		//End Sub

		public int getFixtureNo()
		{
			return fixtureNo;
		}


		public void reviewPredictions()
		{
			int previousFixtureNo = fixtureNo;
			fixtureNo = fixtureNo + 1;
			fixtureBoxList[fixtureNo - 1].Visible = false;

			if (fixtureBoxList[previousFixtureNo].homeRadioButton.Checked == true) {
				fixtures[previousFixtureNo].Prediction = 1;
			}
			if (fixtureBoxList[previousFixtureNo].awayRadioButton.Checked == true) {
				fixtures[previousFixtureNo].Prediction = 2;
			}
			if (fixtureBoxList[previousFixtureNo].drawRadioButton.Checked == true) {
				fixtures[previousFixtureNo].Prediction = 3;
			}

			this.MainMenuButton.Visible = false;
			this.FlowLayoutPanel.Enabled = true;
			this.FlowLayoutPanel.Visible = true;
			this.submitButton.Visible = true;
			this.editButton.Visible = true;


			foreach (Fixture fixture in fixtures) {
				FixtureReviewUserControl review = new FixtureReviewUserControl(fixture.Home_Team, fixture.Away_Team);
				this.FlowLayoutPanel.Controls.Add(review);

				if (fixture.Prediction == 1) {
					review.homeFixtureLabel.BackColor = Color.LightGreen;
				}
				if (fixture.Prediction == 2) {
					review.awayFixtureLabel.BackColor = Color.LightGreen;
				}
				if (fixture.Prediction == 3) {
					review.drawLabel.BackColor = Color.LightGreen;
				}
			}

		}

		private void submitButton_Click(System.Object sender, System.EventArgs e)
		{
			SubmitPredictions();
			Interaction.MsgBox("Predictions submitted");
			My.MyProject.Forms.MenuForm.Show();
			this.Close();
		}


		private void editButton_Click(System.Object sender, System.EventArgs e)
		{
			if (this.FlowLayoutPanel.Controls.Count > 0) {
				this.FlowLayoutPanel.Controls.Clear();
			}

			this.FlowLayoutPanel.Visible = false;
			fixtureBoxList[0].Visible = true;
			fixtureBoxList[0].backButton.Enabled = false;
			fixtureNo = 0;

			this.FlowLayoutPanel.Height = 166;
			this.FlowLayoutPanel.Width = 394;

			this.submitButton.Visible = false;
			this.editButton.Visible = false;
			this.MainMenuButton.Visible = true;


		}

		public Image getTeamBadge(string team)
		{
			Image badge = PlaceYourBets.My.Resources.Resources.icon2;
			switch (team) {
				case "Arsenal":
					badge = PlaceYourBets.My.Resources.Resources.ARS;
					break;
				case "Aston Villa":
					badge = PlaceYourBets.My.Resources.Resources.AST;
					break;
				case "Burnley":
					badge = PlaceYourBets.My.Resources.Resources.BUR;
					break;
				case "Chelsea":
					badge = PlaceYourBets.My.Resources.Resources.CHE;
					break;
				case "Crystal Palace":
					badge = PlaceYourBets.My.Resources.Resources.CRY;
					break;
				case "Everton":
					badge = PlaceYourBets.My.Resources.Resources.EVE;
					break;
				case "Hull City":
					badge = PlaceYourBets.My.Resources.Resources.HUL;
					break;
				case "Leicester City":
					badge = PlaceYourBets.My.Resources.Resources.LEI;
					break;
				case "Liverpool":
					badge = PlaceYourBets.My.Resources.Resources.LIV;
					break;
				case "Manchester City":
					badge = PlaceYourBets.My.Resources.Resources.MNC;
					break;
				case "Manchester United":
					badge = PlaceYourBets.My.Resources.Resources.MNU;
					break;
				case "Newcastle United":
					badge = PlaceYourBets.My.Resources.Resources.NWC;
					break;
				case "Queens Park Rangers":
					badge = PlaceYourBets.My.Resources.Resources.QPR;
					break;
				case "Southampton":
					badge = PlaceYourBets.My.Resources.Resources.SOU;
					break;
				case "Stoke City":
					badge = PlaceYourBets.My.Resources.Resources.STO;
					break;
				case "Sunderland":
					badge = PlaceYourBets.My.Resources.Resources.SUN;
					break;
				case "Swansea City":
					badge = PlaceYourBets.My.Resources.Resources.SWA;
					break;
				case "Tottenham Hotspur":
					badge = PlaceYourBets.My.Resources.Resources.TOT;
					break;
				case "West Bromwich Albion":
					badge = PlaceYourBets.My.Resources.Resources.WBA;
					break;
				case "West Ham United":
					badge = PlaceYourBets.My.Resources.Resources.WHU;

					break;
			}

			return badge;

		}

		public bool lastFixture(int value)
		{

			var item = fixtures.Count;

			if (value == item) {
				return true;
			} else {
				return false;
			}

		}


		public void SubmitPredictions()
		{
			ProgressBar ProgressBar1 = null;
			ProgressBar1 = new ProgressBar();
			//set position
			ProgressBar1.Location = new Point(10, 10);
			//set values
			ProgressBar1.Minimum = 0;
			ProgressBar1.Maximum = 200;
			ProgressBar1.Value = 130;
			//add the progress bar to the form
			this.Controls.Add(ProgressBar1);
			ProgressBar1.Visible = true;

			foreach (Fixture fixture in fixtures) {
				string UrlBase = "http://www.predictresults.co.uk/API/InsertDataUsingSP.php?userid=";
				string user = currentUser.ToString();
				string fixtureID = fixture.ID.ToString();
				string prediction = fixture.Prediction.ToString();
				string url = UrlBase + user + "&fixtureid=" + fixtureID + "&prediction=" + prediction;
				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();

				//Get the stream associated with the response. 
				Stream receiveStream = response.GetResponseStream();
				StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

				response.Close();
				readStream.Close();

			}

			ProgressBar1.Visible = false;

		}


		private void MainMenuButton_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.MenuForm.Show();
			this.Close();
		}


		private void ShutdownButton_Click(System.Object sender, System.EventArgs e)
		{
			Application.Exit();
		}


		private void submitGroupBox_Enter(System.Object sender, System.EventArgs e)
		{
		}
	}
}
