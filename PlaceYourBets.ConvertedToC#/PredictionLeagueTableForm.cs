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
namespace PlaceYourBets
{
	public partial class PredictionLeagueTableForm
	{


		private List<Users> userResultList = new List<Users>();
		private void MainMenuButton_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.MenuForm.Show();
			this.Close();
		}

		private void ShutdownButton_Click(System.Object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void PredictionLeagueTableForm_Load(System.Object sender, System.EventArgs e)
		{
			FixtureBuilder fb = new FixtureBuilder();
			userResultList = fb.getScores();

			this.PredictionsLeagueFlowLayoutPanel.Enabled = true;
			this.PredictionsLeagueFlowLayoutPanel.Visible = true;
			this.NavigationGroupBox.Visible = true;
			this.MainMenuButton.Visible = true;

			foreach (Users user in userResultList) {
				PredictionLeagueUserControl review = new PredictionLeagueUserControl(user.user, user.correct);
				this.PredictionsLeagueFlowLayoutPanel.Controls.Add(review);

			}

		}
	}
}

