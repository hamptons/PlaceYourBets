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
	public partial class FixtureReviewUserControl
	{


		public FixtureReviewUserControl(string home, string away)
		{
			// This call is required by the designer.
			InitializeComponent();

			homeFixtureLabel.Text = home;
			awayFixtureLabel.Text = away;
		}

	}
}
