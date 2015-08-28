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

	public partial class RegistrationForm
	{

		private void RegistrationForm_Load(System.Object sender, System.EventArgs e)
		{
			usernameTextBox.TextAlign = HorizontalAlignment.Center;
			this.LinkLabel.Location = new System.Drawing.Point(0, 10);

		}

		private void registerButton_Click(System.Object sender, System.EventArgs e)
		{
			var fb = new FixtureBuilder();
			var userList = new List<string>();
			string username = null;
			userList = fb.getPRUsers();
			username = this.usernameTextBox.Text;
			string urlBase = "http://www.predictresults.co.uk/API/PYBMembers.php?user='";
			string url = null;

			if (userList.Contains(username)) {
				url = urlBase + username + "'";

				HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();

				Stream receiveStream = response.GetResponseStream();
				StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

				response.Close();
				readStream.Close();

				Interaction.MsgBox("User '" + username + "' " + "registered as Place Your Bets user");
				My.MyProject.Forms.ContainerForm.Show();
				LoginUserControl fLoginUserControl = new LoginUserControl();
				My.MyProject.Forms.ContainerForm.MainFlowLayoutPanel.Controls.Add(fLoginUserControl);
				My.MyProject.Forms.ContainerForm.AcceptButton = fLoginUserControl.loginButton;
				this.Close();

			} else {
				Interaction.MsgBox("Username not recognised");
			}
		}

		private void closeButton_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.ContainerForm.Show();
			LoginUserControl fLoginUserControl = new LoginUserControl();
			My.MyProject.Forms.ContainerForm.MainFlowLayoutPanel.Controls.Add(fLoginUserControl);
			My.MyProject.Forms.ContainerForm.AcceptButton = fLoginUserControl.loginButton;
			this.Close();
		}

		private void LinkLabel_LinkClicked(System.Object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.LinkLabel.LinkVisited = true;
			System.Diagnostics.Process.Start("http://www.predictresults.co.uk/register-3/");
		}
		public RegistrationForm()
		{
			Load += RegistrationForm_Load;
			InitializeComponent();
		}
	}
}
