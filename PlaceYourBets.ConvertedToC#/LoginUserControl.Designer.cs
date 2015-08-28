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
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class LoginUserControl : System.Windows.Forms.UserControl
	{

		//UserControl overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.PictureBox = new System.Windows.Forms.PictureBox();
			this.userLabel = new System.Windows.Forms.Label();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.loginButton = new System.Windows.Forms.Button();
			this.registerButton = new System.Windows.Forms.Button();
			this.shutdownButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.PictureBox).BeginInit();
			this.SuspendLayout();
			//
			//PictureBox
			//
			this.PictureBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.PictureBox.Image = global::PlaceYourBets.My.Resources.Resources.icon2;
			this.PictureBox.Location = new System.Drawing.Point(0, 0);
			this.PictureBox.Name = "PictureBox";
			this.PictureBox.Size = new System.Drawing.Size(400, 400);
			this.PictureBox.TabIndex = 0;
			this.PictureBox.TabStop = false;
			//
			//userLabel
			//
			this.userLabel.Location = new System.Drawing.Point(567, 82);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(64, 26);
			this.userLabel.TabIndex = 5;
			this.userLabel.Text = "Username";
			this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//usernameTextBox
			//
			this.usernameTextBox.BackColor = System.Drawing.Color.White;
			this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.usernameTextBox.Location = new System.Drawing.Point(450, 102);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(300, 20);
			this.usernameTextBox.TabIndex = 6;
			this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			//
			//loginButton
			//
			this.loginButton.BackColor = System.Drawing.Color.White;
			this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.loginButton.Location = new System.Drawing.Point(450, 128);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(300, 40);
			this.loginButton.TabIndex = 7;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = false;
			//
			//registerButton
			//
			this.registerButton.BackColor = System.Drawing.Color.White;
			this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.registerButton.Location = new System.Drawing.Point(450, 211);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(300, 40);
			this.registerButton.TabIndex = 8;
			this.registerButton.Text = "Register";
			this.registerButton.UseVisualStyleBackColor = false;
			//
			//shutdownButton
			//
			this.shutdownButton.BackColor = System.Drawing.Color.White;
			this.shutdownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.shutdownButton.Location = new System.Drawing.Point(450, 257);
			this.shutdownButton.Name = "shutdownButton";
			this.shutdownButton.Size = new System.Drawing.Size(300, 40);
			this.shutdownButton.TabIndex = 9;
			this.shutdownButton.Text = "Shutdown";
			this.shutdownButton.UseVisualStyleBackColor = false;
			//
			//LoginUserControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.shutdownButton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.userLabel);
			this.Controls.Add(this.PictureBox);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "LoginUserControl";
			this.Size = new System.Drawing.Size(800, 400);
			((System.ComponentModel.ISupportInitialize)this.PictureBox).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.PictureBox PictureBox;
		internal System.Windows.Forms.Label userLabel;
		internal System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.Button withEventsField_loginButton;
		internal System.Windows.Forms.Button loginButton {
			get { return withEventsField_loginButton; }
			set {
				if (withEventsField_loginButton != null) {
					withEventsField_loginButton.Click -= loginButton_Click;
				}
				withEventsField_loginButton = value;
				if (withEventsField_loginButton != null) {
					withEventsField_loginButton.Click += loginButton_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_registerButton;
		internal System.Windows.Forms.Button registerButton {
			get { return withEventsField_registerButton; }
			set {
				if (withEventsField_registerButton != null) {
					withEventsField_registerButton.Click -= registerButton_Click;
				}
				withEventsField_registerButton = value;
				if (withEventsField_registerButton != null) {
					withEventsField_registerButton.Click += registerButton_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_shutdownButton;
		internal System.Windows.Forms.Button shutdownButton {
			get { return withEventsField_shutdownButton; }
			set {
				if (withEventsField_shutdownButton != null) {
					withEventsField_shutdownButton.Click -= shutdownButton_Click;
				}
				withEventsField_shutdownButton = value;
				if (withEventsField_shutdownButton != null) {
					withEventsField_shutdownButton.Click += shutdownButton_Click;
				}
			}

		}
	}
}
