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
	public partial class MenuForm
	{

		private void enterPredictionsButton_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.FixturesForm.Show();
			this.Close();
		}


		private void reviewCurrentBet_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.ReviewForm.Show();
			this.Close();
		}

		private void shutdownButton_Click(System.Object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void SubmittedPredictionsButton_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.PredictionsSubmitted.Show();
			this.Close();
		}

		private void PredictionLeagueTableButton_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.PredictionLeagueTableForm.Show();
			this.Close();
		}
		public MenuForm()
		{
			InitializeComponent();
		}
	}
}

