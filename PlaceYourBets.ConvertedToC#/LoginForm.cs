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
using System.Text;
using System.Deployment.Application;
namespace PlaceYourBets
{

	public partial class LoginForm
	{


		private int userId;
		// TODO: Insert code to perform custom authentication using the provided username and password 
		// (See http://go.microsoft.com/fwlink/?LinkId=35339).  
		// The custom principal can then be attached to the current thread's principal as follows: 
		//     My.User.CurrentPrincipal = CustomPrincipal
		// where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
		// Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
		// such as the username, display name, etc.


		private void loginButton_Click(System.Object sender, System.EventArgs e)
		{
			FixtureBuilder fb = new FixtureBuilder();

			Dictionary<string, int> userDictionary = new Dictionary<string, int>();
			userDictionary = fb.getUsersAndIds();

			string username = usernameTextBox.Text.ToLower();
			userId = -1;

			if (string.IsNullOrEmpty(username)) {
				Interaction.MsgBox("Please enter your username");

			} else {
				if (userDictionary.ContainsKey(username)) {
					userDictionary.TryGetValue(username, out userId);
					My.MyProject.Forms.FixturesForm.currentUser = userId;
					My.MyProject.Forms.MenuForm.Show();
					this.Close();
				} else {
					Interaction.MsgBox("Username not recognised");
					usernameTextBox.Clear();
				}

			}

		}

		public object getUser()
		{
			return userId;
		}

		private void shutdownButton_Click(System.Object sender, System.EventArgs e)
		{
			Application.ExitThread();
		}


		private void LoginForm_Load(System.Object sender, System.EventArgs e)
		{
			usernameTextBox.TextAlign = HorizontalAlignment.Center;

			if (ApplicationDeployment.IsNetworkDeployed) {
				string publishVersion = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
			}

			Version version = null;
			version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			this.Text = string.Format("v{0}.{1}", version.Major, version.Minor);
		}

		private void registerButton_Click(System.Object sender, System.EventArgs e)
		{
			My.MyProject.Forms.RegistrationForm.Show();
			this.Close();
		}
		public LoginForm()
		{
			Load += LoginForm_Load;
			InitializeComponent();
		}

	}
}

