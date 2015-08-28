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
	public partial class PredictionLeagueUserControl
	{


		public PredictionLeagueUserControl(string user, double correct)
		{
			// This call is required by the designer.
			InitializeComponent();

			// Add any initialization after the InitializeComponent() call.
			usernameLabel.Text = user;
			pointsLabel.Text = correct.ToString() + "%";
		}

	}
}
