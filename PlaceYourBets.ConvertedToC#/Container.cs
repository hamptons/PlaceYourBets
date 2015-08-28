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

	public partial class ContainerForm
	{

		private int fixtureNo = 0;
		private List<Fixture> fixtures = new List<Fixture>();
		private List<FixtureBox> fixtureBoxList = new List<FixtureBox>();
		private List<string> userList = new List<string>();
		private List<string> submittedList = new List<string>();
		private List<Users> userResultList = new List<Users>();

		private int fix;
		public int currentUser {
			get { return m_user; }
			set { m_user = value; }
		}

		private int m_user;

		private void ContainerForm_Load(System.Object sender, System.EventArgs e)
		{
			Version version = null;
			version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			this.Text = string.Format("v{0}.{1}", version.Major, version.Minor);

			this.enterPredictionsButton.Visible = true;
			this.betSlipButton.Visible = true;
			this.whoBetButton.Visible = true;
			this.predictionLeagueButton.Visible = true;
			this.myAccountButton.Visible = true;
			this.logOutButton.Visible = true;
			this.enterPredictionsButton.Text = "";
			this.betSlipButton.Text = "";
			this.whoBetButton.Text = "";
			this.predictionLeagueButton.Text = "";
			this.myAccountButton.Text = "";
			this.logOutButton.Text = "";
			this.enterPredictionsButton.Enabled = false;
			this.betSlipButton.Enabled = false;
			this.whoBetButton.Enabled = false;
			this.predictionLeagueButton.Enabled = false;
			this.myAccountButton.Enabled = false;
			this.logOutButton.Enabled = false;
			this.submitGroupBox.Visible = true;
			this.submitGroupBox.Visible = false;
			this.submitButton.Visible = false;
			this.editButton.Visible = false;
			this.MainFlowLayoutPanel.Visible = false;
			this.MainFlowLayoutPanel.Enabled = false;
			this.MainFlowLayoutPanel.Controls.Clear();

			LoginUserControl fLoginUserControl = new LoginUserControl();
			this.MainFlowLayoutPanel.Controls.Add(fLoginUserControl);
			this.MainFlowLayoutPanel.Visible = true;
			this.MainFlowLayoutPanel.Enabled = true;
			this.AcceptButton = fLoginUserControl.loginButton;

		}



		private void enterPredictionsButton_Click(System.Object sender, System.EventArgs e)
		{
			fixtureBoxList.Clear();
			this.MainFlowLayoutPanel.Controls.Clear();
			FixtureBuilder fb = new FixtureBuilder();
			fixtures = fb.getFixtures();
			fix = 0;


			try {
				foreach (Fixture Fixture in fixtures) {
					FixtureBox usercontrol = new FixtureBox(Fixture.Home_Team, Fixture.Away_Team, Fixture.Date, getTeamBadge(fixtures[fix].Home_Team), getTeamBadge(fixtures[fix].Away_Team));
					MainFlowLayoutPanel.Controls.Add(usercontrol);
					usercontrol.Dock = DockStyle.Fill;
					usercontrol.Visible = false;
					fixtureBoxList.Add(usercontrol);
					fix = fix + 1;

				}

				fixtureBoxList[0].Visible = true;
				fixtureBoxList[0].backButton.Enabled = false;
				this.submitButton.Visible = false;
				this.editButton.Visible = false;

			} catch (NullReferenceException ex) {
				Interaction.MsgBox("No fixtures available");
			}

			if (fix != 10) {
				this.MainFlowLayoutPanel.Controls.Clear();
				fixtureBoxList.Clear();
				Interaction.MsgBox("There are currently no fixtures to display");
			}

		}


		private void submitButton_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.ProgressBarForm.Show();

			this.SubmitPredictions();

			My.MyProject.Forms.ProgressBarForm.Close();

			Interaction.MsgBox("Predictions submitted");
			submitGroupBox.Visible = false;
			this.MainFlowLayoutPanel.Controls.Clear();


		}

		private void editButton_Click_1(System.Object sender, System.EventArgs e)
		{
			List<Control> list = new List<Control>();

			foreach (object control_loopVariable in MainFlowLayoutPanel.Controls) {
				control = control_loopVariable;
				if (control is FixtureReviewUserControl) {
					list.Add(control);
				}
			}

			foreach (Control control_loopVariable in list) {
				control = control_loopVariable;
				MainFlowLayoutPanel.Controls.Remove(control);

			}

			foreach (Fixture fixture in fixtures) {
				FixtureReviewUserControl review = new FixtureReviewUserControl(fixture.Home_Team, fixture.Away_Team);
				this.MainFlowLayoutPanel.Controls.Remove(review);

			}

			fixtureBoxList[0].Visible = true;
			fixtureBoxList[0].backButton.Enabled = false;
			fixtureNo = 0;

			this.submitGroupBox.Visible = false;
			this.submitButton.Visible = false;
			this.editButton.Visible = false;
		}

		private void betSlipButton_Click_1(System.Object sender, System.EventArgs e)
		{
			this.MainFlowLayoutPanel.Controls.Clear();
			FixtureBuilder fb = new FixtureBuilder();
			fixtures = fb.getBet();

			this.submitGroupBox.Visible = false;

			try {
				foreach (Fixture fixture in fixtures) {
					FixtureReviewUserControl review = new FixtureReviewUserControl(fixture.Home_Team, fixture.Away_Team);
					this.MainFlowLayoutPanel.Controls.Add(review);

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

			} catch (NullReferenceException ex) {
				Interaction.MsgBox("Not enough users have entered their predictions yet. Please try later");
			}
		}

		private void whoBetButton_Click(System.Object sender, System.EventArgs e)
		{
			this.MainFlowLayoutPanel.Controls.Clear();
			FixtureBuilder fb = new FixtureBuilder();
			userList = fb.getUsers();
			submittedList = fb.usersSubmitted();

			this.MainFlowLayoutPanel.Enabled = true;
			this.MainFlowLayoutPanel.Visible = true;
			this.submitGroupBox.Visible = false;

			foreach (string user in userList) {
				UserPredictionsUserControl review = new UserPredictionsUserControl(user);
				this.MainFlowLayoutPanel.Controls.Add(review);

				if (submittedList.Contains(user)) {
					review.submittedLabel.BackColor = Color.LightGreen;
					review.submittedLabel.Text = "Submitted";
				}

			}
		}

		private void predictionLeagueButton_Click(System.Object sender, System.EventArgs e)
		{
			this.MainFlowLayoutPanel.Controls.Clear();
			FixtureBuilder fb = new FixtureBuilder();
			userResultList = fb.getScores();
			Dictionary<int, string> userDictionary = new Dictionary<int, string>();
			userDictionary = fb.getIdsandUsers();

			this.MainFlowLayoutPanel.Enabled = true;
			this.MainFlowLayoutPanel.Visible = true;
			this.submitGroupBox.Visible = false;

			string name = "";

			foreach (Users user in userResultList) {
				userDictionary.TryGetValue(user.UserID, out name);
				PredictionLeagueUserControl review = new PredictionLeagueUserControl(name, user.correct);
				this.MainFlowLayoutPanel.Controls.Add(review);

			}
		}

		private void logOutButton_Click(System.Object sender, System.EventArgs e)
		{
			this.MainFlowLayoutPanel.Controls.Clear();
			this.enterPredictionsButton.Text = "";
			this.betSlipButton.Text = "";
			this.whoBetButton.Text = "";
			this.predictionLeagueButton.Text = "";
			this.myAccountButton.Text = "";
			this.logOutButton.Text = "";
			this.enterPredictionsButton.Enabled = false;
			this.betSlipButton.Enabled = false;
			this.whoBetButton.Enabled = false;
			this.predictionLeagueButton.Enabled = false;
			this.myAccountButton.Enabled = false;
			this.logOutButton.Enabled = false;
			this.coverTitleLabel.Visible = false;
			LoginUserControl fLoginUserControl = new LoginUserControl();
			this.MainFlowLayoutPanel.Controls.Add(fLoginUserControl);
			this.AcceptButton = fLoginUserControl.loginButton;
		}

		public void makeFixtureVisible(bool forward)
		{
			try {

				if ((forward)) {
					int previousFixtureNo = fixtureNo;
					fixtureNo = fixtureNo + 1;
					fixtureBoxList[previousFixtureNo].Visible = false;

					if (fixtureNo == 9) {
						fixtureBoxList[fixtureNo].nextButton.Text = "Review >";
						fixtureBoxList[fixtureNo].nextButton.BackColor = Color.LightGreen;
					}

					if (fixtureBoxList[previousFixtureNo].homeRadioButton.Checked == true) {
						fixtures[previousFixtureNo].Prediction = 1;
					}
					if (fixtureBoxList[previousFixtureNo].awayRadioButton.Checked == true) {
						fixtures[previousFixtureNo].Prediction = 2;
					}
					if (fixtureBoxList[previousFixtureNo].drawRadioButton.Checked == true) {
						fixtures[previousFixtureNo].Prediction = 3;
					}

				} else {
					fixtureNo = fixtureNo - 1;
					fixtureBoxList[fixtureNo + 1].Visible = false;

				}

				fixtureBoxList[fixtureNo].Visible = true;

			} catch (ArgumentOutOfRangeException ex) {
				Interaction.MsgBox("The full set of fixtures is not available. Please email complaints to michael.cole@advancedcomputersoftware.com");
			}
		}

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

			this.MainFlowLayoutPanel.Enabled = true;
			this.MainFlowLayoutPanel.Visible = true;
			this.submitGroupBox.Visible = true;
			this.submitButton.Visible = true;
			this.editButton.Visible = true;


			foreach (Fixture fixture in fixtures) {
				FixtureReviewUserControl review = new FixtureReviewUserControl(fixture.Home_Team, fixture.Away_Team);
				this.MainFlowLayoutPanel.Controls.Add(review);

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
				default:
					badge = PlaceYourBets.My.Resources.Resources.icon2;

					break;
			}

			return badge;

		}


		public void SubmitPredictions()
		{
			bool submitted = false;


			while ((!submitted)) {

				foreach (Fixture fixture in fixtures) {
					My.MyProject.Forms.ProgressBarForm.ProgressBar1.PerformStep();
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

				submitted = true;

			}
		}


	}
}
