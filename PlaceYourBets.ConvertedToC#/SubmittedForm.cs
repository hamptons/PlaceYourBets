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
	public partial class PredictionsSubmitted
	{

		private List<string> userList = new List<string>();

		private List<string> submittedList = new List<string>();
		private void ShutdownButton_Click(System.Object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void MainMenuButton_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.MenuForm.Show();
			this.Close();
		}


		private void ReviewForm_Load(System.Object sender, System.EventArgs e)
		{
			FixtureBuilder fb = new FixtureBuilder();
			userList = fb.getUsers();
			submittedList = fb.usersSubmitted();

			this.UserPredictionsFlowLayoutPanel.Enabled = true;
			this.UserPredictionsFlowLayoutPanel.Visible = true;
			this.NavigationGroupBox.Visible = true;
			this.MainMenuButton.Visible = true;

			foreach (string user in userList) {
				UserPredictionsUserControl review = new UserPredictionsUserControl(user);
				this.UserPredictionsFlowLayoutPanel.Controls.Add(review);

				if (submittedList.Contains(user)) {
					review.submittedLabel.BackColor = Color.LightGreen;
					review.submittedLabel.Text = "Submitted";
				}

			}

		}


		private void UserPredictionsFlowLayoutPanel_Paint(System.Object sender, System.Windows.Forms.PaintEventArgs e)
		{
		}
		public PredictionsSubmitted()
		{
			Load += ReviewForm_Load;
			InitializeComponent();
		}
	}
}
