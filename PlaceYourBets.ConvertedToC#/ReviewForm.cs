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
using System.Net;
using Newtonsoft.Json;
namespace PlaceYourBets
{

	public partial class ReviewForm
	{


		private List<Fixture> fixtures = new List<Fixture>();

		private void ReviewForm_Load(System.Object sender, System.EventArgs e)
		{
			FixtureBuilder fb = new FixtureBuilder();
			fixtures = fb.getBet();

			this.ReviewBetsFlowLayoutPanel.Enabled = true;
			this.ReviewBetsFlowLayoutPanel.Visible = true;
			this.FinishReviewGroupBox.Visible = true;
			this.MainMenuButton.Visible = true;

			foreach (Fixture fixture in fixtures) {
				FixtureReviewUserControl review = new FixtureReviewUserControl(fixture.Home_Team, fixture.Away_Team);
				this.ReviewBetsFlowLayoutPanel.Controls.Add(review);

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

		private void MainMenuButton_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.MenuForm.Show();
			this.Close();
		}

		private void ShutdownButton_Click(System.Object sender, System.EventArgs e)
		{
			Application.Exit();
		}
		public ReviewForm()
		{
			Load += ReviewForm_Load;
			InitializeComponent();
		}
	}
}
