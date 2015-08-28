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
	partial class RegistrationForm : System.Windows.Forms.Form
	{

		//Form overrides dispose to clean up the component list.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
			this.userLabel = new System.Windows.Forms.Label();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.registerButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.LinkLabel = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			//
			//userLabel
			//
			this.userLabel.Location = new System.Drawing.Point(364, 133);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(64, 26);
			this.userLabel.TabIndex = 5;
			this.userLabel.Text = "Username";
			this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//usernameTextBox
			//
			this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.usernameTextBox.Location = new System.Drawing.Point(247, 153);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(300, 20);
			this.usernameTextBox.TabIndex = 0;
			//
			//registerButton
			//
			this.registerButton.BackColor = System.Drawing.Color.White;
			this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.registerButton.Location = new System.Drawing.Point(247, 210);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(300, 50);
			this.registerButton.TabIndex = 1;
			this.registerButton.Text = "Register";
			this.registerButton.UseVisualStyleBackColor = false;
			//
			//closeButton
			//
			this.closeButton.BackColor = System.Drawing.Color.White;
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.closeButton.Location = new System.Drawing.Point(247, 266);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(300, 50);
			this.closeButton.TabIndex = 2;
			this.closeButton.Text = "Close";
			this.closeButton.UseVisualStyleBackColor = false;
			//
			//LinkLabel
			//
			this.LinkLabel.BackColor = System.Drawing.Color.White;
			this.LinkLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.LinkLabel.Location = new System.Drawing.Point(0, 0);
			this.LinkLabel.Name = "LinkLabel";
			this.LinkLabel.Size = new System.Drawing.Size(798, 70);
			this.LinkLabel.TabIndex = 9;
			this.LinkLabel.TabStop = true;
			this.LinkLabel.Text = "Enter the username you are registered with on PredictResults.co.uk. If you are no" + "t a member please go to http://www.predictresults.co.uk/register-3/";
			this.LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//RegistrationForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(798, 402);
			this.Controls.Add(this.LinkLabel);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.userLabel);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "RegistrationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "New User";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.Label userLabel;
		internal System.Windows.Forms.TextBox usernameTextBox;
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
		private System.Windows.Forms.Button withEventsField_closeButton;
		internal System.Windows.Forms.Button closeButton {
			get { return withEventsField_closeButton; }
			set {
				if (withEventsField_closeButton != null) {
					withEventsField_closeButton.Click -= closeButton_Click;
				}
				withEventsField_closeButton = value;
				if (withEventsField_closeButton != null) {
					withEventsField_closeButton.Click += closeButton_Click;
				}
			}
		}
		private System.Windows.Forms.LinkLabel withEventsField_LinkLabel;
		internal System.Windows.Forms.LinkLabel LinkLabel {
			get { return withEventsField_LinkLabel; }
			set {
				if (withEventsField_LinkLabel != null) {
					withEventsField_LinkLabel.LinkClicked -= LinkLabel_LinkClicked;
				}
				withEventsField_LinkLabel = value;
				if (withEventsField_LinkLabel != null) {
					withEventsField_LinkLabel.LinkClicked += LinkLabel_LinkClicked;
				}
			}
		}
	}
}
