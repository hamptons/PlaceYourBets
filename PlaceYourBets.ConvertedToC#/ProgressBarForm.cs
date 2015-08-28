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
	public partial class ProgressBarForm
	{

		private void ProgressBarForm_Load(System.Object sender, System.EventArgs e)
		{
			ProgressBar ProgressBar1 = null;
			ProgressBar1 = new ProgressBar();
			//set position
			ProgressBar1.Location = new Point(100, 100);
			//set values
			ProgressBar1.Minimum = 0;
			ProgressBar1.Maximum = 9;
			ProgressBar1.Step = 1;
			//add the progress bar to the form
			this.Controls.Add(ProgressBar1);
			ProgressBar1.Visible = true;

		}
		public ProgressBarForm()
		{
			Load += ProgressBarForm_Load;
			InitializeComponent();
		}
	}
}
