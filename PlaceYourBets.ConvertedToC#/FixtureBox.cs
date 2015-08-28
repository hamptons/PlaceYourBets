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
	public partial class FixtureBox
	{


		public FixtureBox(string home, string away, System.DateTime fixtureDate, Image homeBadge, Image awayBadge)
		{
			// This call is required by the designer.
			InitializeComponent();

			// Add any initialization after the InitializeComponent() call.
			homeLabel.Text = home;
			awayLabel.Text = away;
			dateLabel.Text = fixtureDate;
			homeBadgeBox.Image = homeBadge;
			awayBadgeBox.Image = awayBadge;

		}


		private void nextButton_Click(System.Object sender, System.EventArgs e)
		{
			if (My.MyProject.Forms.ContainerForm.getFixtureNo() == 9) {
				My.MyProject.Forms.ContainerForm.reviewPredictions();
			} else {
				My.MyProject.Forms.ContainerForm.makeFixtureVisible(true);
			}
		}

		private void backButton_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.ContainerForm.makeFixtureVisible(false);
		}

	}
}
