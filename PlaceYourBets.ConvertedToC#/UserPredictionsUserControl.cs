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
	public partial class UserPredictionsUserControl
	{

		public UserPredictionsUserControl(string user)
		{
			// This call is required by the designer.
			InitializeComponent();

			userLabel.Text = user;
			submittedLabel.Text = "Not Submitted";
			submittedLabel.BackColor = Color.Red;

		}
	}
}
