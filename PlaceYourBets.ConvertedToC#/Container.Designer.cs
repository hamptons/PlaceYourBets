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
	partial class ContainerForm : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainerForm));
			this.TitleBanner = new System.Windows.Forms.Panel();
			this.PictureBox = new System.Windows.Forms.PictureBox();
			this.enterPredictionsButton = new System.Windows.Forms.Button();
			this.predictionLeagueButton = new System.Windows.Forms.Button();
			this.myAccountButton = new System.Windows.Forms.Button();
			this.MainPanel = new System.Windows.Forms.Panel();
			this.MainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.BottomPanel = new System.Windows.Forms.Panel();
			this.submitGroupBox = new System.Windows.Forms.GroupBox();
			this.editButton = new System.Windows.Forms.Button();
			this.submitButton = new System.Windows.Forms.Button();
			this.GroupBox = new System.Windows.Forms.GroupBox();
			this.logOutButton = new System.Windows.Forms.Button();
			this.betSlipButton = new System.Windows.Forms.Button();
			this.whoBetButton = new System.Windows.Forms.Button();
			this.coverTitleLabel = new System.Windows.Forms.Label();
			this.TitleBanner.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox).BeginInit();
			this.MainPanel.SuspendLayout();
			this.BottomPanel.SuspendLayout();
			this.submitGroupBox.SuspendLayout();
			this.GroupBox.SuspendLayout();
			this.SuspendLayout();
			//
			//TitleBanner
			//
			this.TitleBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TitleBanner.Controls.Add(this.coverTitleLabel);
			this.TitleBanner.Controls.Add(this.PictureBox);
			this.TitleBanner.Dock = System.Windows.Forms.DockStyle.Top;
			this.TitleBanner.Location = new System.Drawing.Point(0, 0);
			this.TitleBanner.Name = "TitleBanner";
			this.TitleBanner.Size = new System.Drawing.Size(1008, 200);
			this.TitleBanner.TabIndex = 0;
			//
			//PictureBox
			//
			this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PictureBox.Image = global::PlaceYourBets.My.Resources.Resources.title;
			this.PictureBox.Location = new System.Drawing.Point(0, 0);
			this.PictureBox.Name = "PictureBox";
			this.PictureBox.Size = new System.Drawing.Size(1006, 198);
			this.PictureBox.TabIndex = 0;
			this.PictureBox.TabStop = false;
			//
			//enterPredictionsButton
			//
			this.enterPredictionsButton.BackColor = System.Drawing.Color.White;
			this.enterPredictionsButton.Font = new System.Drawing.Font("Calisto MT", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.enterPredictionsButton.Location = new System.Drawing.Point(2, 6);
			this.enterPredictionsButton.Name = "enterPredictionsButton";
			this.enterPredictionsButton.Size = new System.Drawing.Size(200, 75);
			this.enterPredictionsButton.TabIndex = 0;
			this.enterPredictionsButton.Text = "Enter Predictions";
			this.enterPredictionsButton.UseVisualStyleBackColor = false;
			//
			//predictionLeagueButton
			//
			this.predictionLeagueButton.BackColor = System.Drawing.Color.White;
			this.predictionLeagueButton.Font = new System.Drawing.Font("Calisto MT", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.predictionLeagueButton.Location = new System.Drawing.Point(3, 249);
			this.predictionLeagueButton.Name = "predictionLeagueButton";
			this.predictionLeagueButton.Size = new System.Drawing.Size(200, 75);
			this.predictionLeagueButton.TabIndex = 4;
			this.predictionLeagueButton.Text = "Prediction League";
			this.predictionLeagueButton.UseVisualStyleBackColor = false;
			//
			//myAccountButton
			//
			this.myAccountButton.BackColor = System.Drawing.Color.White;
			this.myAccountButton.Font = new System.Drawing.Font("Calisto MT", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.myAccountButton.Location = new System.Drawing.Point(3, 330);
			this.myAccountButton.Name = "myAccountButton";
			this.myAccountButton.Size = new System.Drawing.Size(200, 75);
			this.myAccountButton.TabIndex = 5;
			this.myAccountButton.Text = "My Account";
			this.myAccountButton.UseVisualStyleBackColor = false;
			//
			//MainPanel
			//
			this.MainPanel.Controls.Add(this.MainFlowLayoutPanel);
			this.MainPanel.Controls.Add(this.BottomPanel);
			this.MainPanel.Controls.Add(this.GroupBox);
			this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainPanel.Location = new System.Drawing.Point(0, 200);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new System.Drawing.Size(1008, 497);
			this.MainPanel.TabIndex = 9;
			//
			//MainFlowLayoutPanel
			//
			this.MainFlowLayoutPanel.BackColor = System.Drawing.Color.White;
			this.MainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MainFlowLayoutPanel.Location = new System.Drawing.Point(208, 0);
			this.MainFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
			this.MainFlowLayoutPanel.Name = "MainFlowLayoutPanel";
			this.MainFlowLayoutPanel.Size = new System.Drawing.Size(800, 400);
			this.MainFlowLayoutPanel.TabIndex = 7;
			//
			//BottomPanel
			//
			this.BottomPanel.BackColor = System.Drawing.Color.Black;
			this.BottomPanel.Controls.Add(this.submitGroupBox);
			this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomPanel.Location = new System.Drawing.Point(208, 400);
			this.BottomPanel.Name = "BottomPanel";
			this.BottomPanel.Size = new System.Drawing.Size(800, 97);
			this.BottomPanel.TabIndex = 6;
			//
			//submitGroupBox
			//
			this.submitGroupBox.BackColor = System.Drawing.Color.Black;
			this.submitGroupBox.Controls.Add(this.editButton);
			this.submitGroupBox.Controls.Add(this.submitButton);
			this.submitGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.submitGroupBox.Location = new System.Drawing.Point(0, 0);
			this.submitGroupBox.Name = "submitGroupBox";
			this.submitGroupBox.Size = new System.Drawing.Size(800, 97);
			this.submitGroupBox.TabIndex = 0;
			this.submitGroupBox.TabStop = false;
			this.submitGroupBox.Visible = false;
			//
			//editButton
			//
			this.editButton.BackColor = System.Drawing.Color.White;
			this.editButton.Font = new System.Drawing.Font("Calisto MT", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.editButton.Location = new System.Drawing.Point(426, 25);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(200, 50);
			this.editButton.TabIndex = 6;
			this.editButton.Text = "Edit";
			this.editButton.UseVisualStyleBackColor = false;
			//
			//submitButton
			//
			this.submitButton.BackColor = System.Drawing.Color.White;
			this.submitButton.Font = new System.Drawing.Font("Calisto MT", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.submitButton.Location = new System.Drawing.Point(190, 25);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(200, 50);
			this.submitButton.TabIndex = 5;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = false;
			//
			//GroupBox
			//
			this.GroupBox.BackColor = System.Drawing.Color.Black;
			this.GroupBox.Controls.Add(this.logOutButton);
			this.GroupBox.Controls.Add(this.betSlipButton);
			this.GroupBox.Controls.Add(this.whoBetButton);
			this.GroupBox.Controls.Add(this.enterPredictionsButton);
			this.GroupBox.Controls.Add(this.myAccountButton);
			this.GroupBox.Controls.Add(this.predictionLeagueButton);
			this.GroupBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.GroupBox.Location = new System.Drawing.Point(0, 0);
			this.GroupBox.Margin = new System.Windows.Forms.Padding(0);
			this.GroupBox.Name = "GroupBox";
			this.GroupBox.Padding = new System.Windows.Forms.Padding(0);
			this.GroupBox.Size = new System.Drawing.Size(208, 497);
			this.GroupBox.TabIndex = 5;
			this.GroupBox.TabStop = false;
			//
			//logOutButton
			//
			this.logOutButton.BackColor = System.Drawing.Color.White;
			this.logOutButton.Font = new System.Drawing.Font("Calisto MT", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.logOutButton.Location = new System.Drawing.Point(3, 411);
			this.logOutButton.Name = "logOutButton";
			this.logOutButton.Size = new System.Drawing.Size(200, 78);
			this.logOutButton.TabIndex = 6;
			this.logOutButton.Text = "Log Off";
			this.logOutButton.UseVisualStyleBackColor = false;
			//
			//betSlipButton
			//
			this.betSlipButton.BackColor = System.Drawing.Color.White;
			this.betSlipButton.Font = new System.Drawing.Font("Calisto MT", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.betSlipButton.Location = new System.Drawing.Point(3, 87);
			this.betSlipButton.Name = "betSlipButton";
			this.betSlipButton.Size = new System.Drawing.Size(200, 75);
			this.betSlipButton.TabIndex = 2;
			this.betSlipButton.Text = "Bet Slip";
			this.betSlipButton.UseVisualStyleBackColor = false;
			//
			//whoBetButton
			//
			this.whoBetButton.BackColor = System.Drawing.Color.White;
			this.whoBetButton.Font = new System.Drawing.Font("Calisto MT", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.whoBetButton.Location = new System.Drawing.Point(3, 168);
			this.whoBetButton.Name = "whoBetButton";
			this.whoBetButton.Size = new System.Drawing.Size(200, 75);
			this.whoBetButton.TabIndex = 3;
			this.whoBetButton.Text = "Who's Bet";
			this.whoBetButton.UseVisualStyleBackColor = false;
			//
			//coverTitleLabel
			//
			this.coverTitleLabel.BackColor = System.Drawing.Color.Black;
			this.coverTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.coverTitleLabel.Location = new System.Drawing.Point(0, 0);
			this.coverTitleLabel.Name = "coverTitleLabel";
			this.coverTitleLabel.Size = new System.Drawing.Size(1006, 198);
			this.coverTitleLabel.TabIndex = 1;
			this.coverTitleLabel.Visible = false;
			//
			//ContainerForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1008, 697);
			this.Controls.Add(this.MainPanel);
			this.Controls.Add(this.TitleBanner);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximumSize = new System.Drawing.Size(1024, 750);
			this.Name = "ContainerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TitleBanner.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.PictureBox).EndInit();
			this.MainPanel.ResumeLayout(false);
			this.BottomPanel.ResumeLayout(false);
			this.submitGroupBox.ResumeLayout(false);
			this.GroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Panel TitleBanner;
		private System.Windows.Forms.Button withEventsField_enterPredictionsButton;
		internal System.Windows.Forms.Button enterPredictionsButton {
			get { return withEventsField_enterPredictionsButton; }
			set {
				if (withEventsField_enterPredictionsButton != null) {
					withEventsField_enterPredictionsButton.Click -= enterPredictionsButton_Click;
				}
				withEventsField_enterPredictionsButton = value;
				if (withEventsField_enterPredictionsButton != null) {
					withEventsField_enterPredictionsButton.Click += enterPredictionsButton_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_predictionLeagueButton;
		internal System.Windows.Forms.Button predictionLeagueButton {
			get { return withEventsField_predictionLeagueButton; }
			set {
				if (withEventsField_predictionLeagueButton != null) {
					withEventsField_predictionLeagueButton.Click -= predictionLeagueButton_Click;
				}
				withEventsField_predictionLeagueButton = value;
				if (withEventsField_predictionLeagueButton != null) {
					withEventsField_predictionLeagueButton.Click += predictionLeagueButton_Click;
				}
			}
		}
		internal System.Windows.Forms.Button myAccountButton;
		internal System.Windows.Forms.Panel MainPanel;
		internal System.Windows.Forms.GroupBox GroupBox;
		internal System.Windows.Forms.Panel BottomPanel;
		internal System.Windows.Forms.FlowLayoutPanel MainFlowLayoutPanel;
		private System.Windows.Forms.Button withEventsField_whoBetButton;
		internal System.Windows.Forms.Button whoBetButton {
			get { return withEventsField_whoBetButton; }
			set {
				if (withEventsField_whoBetButton != null) {
					withEventsField_whoBetButton.Click -= whoBetButton_Click;
				}
				withEventsField_whoBetButton = value;
				if (withEventsField_whoBetButton != null) {
					withEventsField_whoBetButton.Click += whoBetButton_Click;
				}
			}
		}
		internal System.Windows.Forms.GroupBox submitGroupBox;
		private System.Windows.Forms.Button withEventsField_editButton;
		internal System.Windows.Forms.Button editButton {
			get { return withEventsField_editButton; }
			set {
				if (withEventsField_editButton != null) {
					withEventsField_editButton.Click -= editButton_Click_1;
				}
				withEventsField_editButton = value;
				if (withEventsField_editButton != null) {
					withEventsField_editButton.Click += editButton_Click_1;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_submitButton;
		internal System.Windows.Forms.Button submitButton {
			get { return withEventsField_submitButton; }
			set {
				if (withEventsField_submitButton != null) {
					withEventsField_submitButton.Click -= submitButton_Click;
				}
				withEventsField_submitButton = value;
				if (withEventsField_submitButton != null) {
					withEventsField_submitButton.Click += submitButton_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_logOutButton;
		internal System.Windows.Forms.Button logOutButton {
			get { return withEventsField_logOutButton; }
			set {
				if (withEventsField_logOutButton != null) {
					withEventsField_logOutButton.Click -= logOutButton_Click;
				}
				withEventsField_logOutButton = value;
				if (withEventsField_logOutButton != null) {
					withEventsField_logOutButton.Click += logOutButton_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_betSlipButton;
		internal System.Windows.Forms.Button betSlipButton {
			get { return withEventsField_betSlipButton; }
			set {
				if (withEventsField_betSlipButton != null) {
					withEventsField_betSlipButton.Click -= betSlipButton_Click_1;
				}
				withEventsField_betSlipButton = value;
				if (withEventsField_betSlipButton != null) {
					withEventsField_betSlipButton.Click += betSlipButton_Click_1;
				}
			}
		}
		internal System.Windows.Forms.PictureBox PictureBox;
		internal System.Windows.Forms.Label coverTitleLabel;
		public ContainerForm()
		{
			Load += ContainerForm_Load;
			InitializeComponent();
		}
	}
}
