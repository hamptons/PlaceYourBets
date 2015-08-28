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
	partial class MenuForm : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
			this.enterPredictionsButton = new System.Windows.Forms.Button();
			this.reviewCurrentBet = new System.Windows.Forms.Button();
			this.shutdownButton = new System.Windows.Forms.Button();
			this.SubmittedPredictionsButton = new System.Windows.Forms.Button();
			this.PredictionLeagueTableButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			//enterPredictionsButton
			//
			this.enterPredictionsButton.BackColor = System.Drawing.Color.White;
			this.enterPredictionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.enterPredictionsButton.Font = new System.Drawing.Font("Bauhaus 93", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.enterPredictionsButton.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(64)), Convert.ToInt32(Convert.ToByte(64)), Convert.ToInt32(Convert.ToByte(64)));
			this.enterPredictionsButton.Location = new System.Drawing.Point(70, 37);
			this.enterPredictionsButton.Name = "enterPredictionsButton";
			this.enterPredictionsButton.Size = new System.Drawing.Size(300, 150);
			this.enterPredictionsButton.TabIndex = 1;
			this.enterPredictionsButton.Text = "Enter Predictions";
			this.enterPredictionsButton.UseVisualStyleBackColor = false;
			//
			//reviewCurrentBet
			//
			this.reviewCurrentBet.BackColor = System.Drawing.Color.White;
			this.reviewCurrentBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.reviewCurrentBet.Font = new System.Drawing.Font("Bauhaus 93", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.reviewCurrentBet.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(64)), Convert.ToInt32(Convert.ToByte(64)), Convert.ToInt32(Convert.ToByte(64)));
			this.reviewCurrentBet.Location = new System.Drawing.Point(424, 37);
			this.reviewCurrentBet.Name = "reviewCurrentBet";
			this.reviewCurrentBet.Size = new System.Drawing.Size(300, 150);
			this.reviewCurrentBet.TabIndex = 2;
			this.reviewCurrentBet.Text = "Bet Slip";
			this.reviewCurrentBet.UseVisualStyleBackColor = false;
			//
			//shutdownButton
			//
			this.shutdownButton.BackColor = System.Drawing.Color.White;
			this.shutdownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.shutdownButton.Location = new System.Drawing.Point(289, 395);
			this.shutdownButton.Name = "shutdownButton";
			this.shutdownButton.Size = new System.Drawing.Size(216, 54);
			this.shutdownButton.TabIndex = 5;
			this.shutdownButton.Text = "Close";
			this.shutdownButton.UseVisualStyleBackColor = false;
			//
			//SubmittedPredictionsButton
			//
			this.SubmittedPredictionsButton.BackColor = System.Drawing.Color.White;
			this.SubmittedPredictionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SubmittedPredictionsButton.Font = new System.Drawing.Font("Bauhaus 93", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.SubmittedPredictionsButton.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(64)), Convert.ToInt32(Convert.ToByte(64)), Convert.ToInt32(Convert.ToByte(64)));
			this.SubmittedPredictionsButton.Location = new System.Drawing.Point(70, 216);
			this.SubmittedPredictionsButton.Name = "SubmittedPredictionsButton";
			this.SubmittedPredictionsButton.Size = new System.Drawing.Size(300, 150);
			this.SubmittedPredictionsButton.TabIndex = 3;
			this.SubmittedPredictionsButton.Text = "Who's Bet";
			this.SubmittedPredictionsButton.UseVisualStyleBackColor = false;
			//
			//PredictionLeagueTableButton
			//
			this.PredictionLeagueTableButton.BackColor = System.Drawing.Color.White;
			this.PredictionLeagueTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.PredictionLeagueTableButton.Font = new System.Drawing.Font("Bauhaus 93", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.PredictionLeagueTableButton.ForeColor = System.Drawing.Color.FromArgb(Convert.ToInt32(Convert.ToByte(64)), Convert.ToInt32(Convert.ToByte(64)), Convert.ToInt32(Convert.ToByte(64)));
			this.PredictionLeagueTableButton.Location = new System.Drawing.Point(424, 216);
			this.PredictionLeagueTableButton.Name = "PredictionLeagueTableButton";
			this.PredictionLeagueTableButton.Size = new System.Drawing.Size(300, 150);
			this.PredictionLeagueTableButton.TabIndex = 4;
			this.PredictionLeagueTableButton.Text = "Prediction League Table";
			this.PredictionLeagueTableButton.UseVisualStyleBackColor = false;
			//
			//MenuForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::PlaceYourBets.My.Resources.Resources.pitch1;
			this.ClientSize = new System.Drawing.Size(794, 472);
			this.Controls.Add(this.PredictionLeagueTableButton);
			this.Controls.Add(this.SubmittedPredictionsButton);
			this.Controls.Add(this.shutdownButton);
			this.Controls.Add(this.reviewCurrentBet);
			this.Controls.Add(this.enterPredictionsButton);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "MenuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu";
			this.ResumeLayout(false);

		}
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
		private System.Windows.Forms.Button withEventsField_reviewCurrentBet;
		internal System.Windows.Forms.Button reviewCurrentBet {
			get { return withEventsField_reviewCurrentBet; }
			set {
				if (withEventsField_reviewCurrentBet != null) {
					withEventsField_reviewCurrentBet.Click -= reviewCurrentBet_Click;
				}
				withEventsField_reviewCurrentBet = value;
				if (withEventsField_reviewCurrentBet != null) {
					withEventsField_reviewCurrentBet.Click += reviewCurrentBet_Click;
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
		private System.Windows.Forms.Button withEventsField_SubmittedPredictionsButton;
		internal System.Windows.Forms.Button SubmittedPredictionsButton {
			get { return withEventsField_SubmittedPredictionsButton; }
			set {
				if (withEventsField_SubmittedPredictionsButton != null) {
					withEventsField_SubmittedPredictionsButton.Click -= SubmittedPredictionsButton_Click;
				}
				withEventsField_SubmittedPredictionsButton = value;
				if (withEventsField_SubmittedPredictionsButton != null) {
					withEventsField_SubmittedPredictionsButton.Click += SubmittedPredictionsButton_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_PredictionLeagueTableButton;
		internal System.Windows.Forms.Button PredictionLeagueTableButton {
			get { return withEventsField_PredictionLeagueTableButton; }
			set {
				if (withEventsField_PredictionLeagueTableButton != null) {
					withEventsField_PredictionLeagueTableButton.Click -= PredictionLeagueTableButton_Click;
				}
				withEventsField_PredictionLeagueTableButton = value;
				if (withEventsField_PredictionLeagueTableButton != null) {
					withEventsField_PredictionLeagueTableButton.Click += PredictionLeagueTableButton_Click;
				}
			}
		}
	}
}
