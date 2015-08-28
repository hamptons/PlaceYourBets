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
	partial class PredictionLeagueTableForm : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredictionLeagueTableForm));
			this.NavigationGroupBox = new System.Windows.Forms.GroupBox();
			this.MainMenuButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.submitButton = new System.Windows.Forms.Button();
			this.PredictionsLeagueFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.NavigationGroupBox.SuspendLayout();
			this.SuspendLayout();
			//
			//NavigationGroupBox
			//
			this.NavigationGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NavigationGroupBox.Controls.Add(this.MainMenuButton);
			this.NavigationGroupBox.Controls.Add(this.editButton);
			this.NavigationGroupBox.Controls.Add(this.submitButton);
			this.NavigationGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.NavigationGroupBox.Location = new System.Drawing.Point(0, 387);
			this.NavigationGroupBox.Name = "NavigationGroupBox";
			this.NavigationGroupBox.Size = new System.Drawing.Size(794, 73);
			this.NavigationGroupBox.TabIndex = 1;
			this.NavigationGroupBox.TabStop = false;
			this.NavigationGroupBox.Visible = false;
			//
			//MainMenuButton
			//
			this.MainMenuButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.MainMenuButton.BackColor = System.Drawing.Color.White;
			this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.MainMenuButton.Location = new System.Drawing.Point(290, 13);
			this.MainMenuButton.Name = "MainMenuButton";
			this.MainMenuButton.Size = new System.Drawing.Size(216, 54);
			this.MainMenuButton.TabIndex = 1;
			this.MainMenuButton.Text = "Menu";
			this.MainMenuButton.UseVisualStyleBackColor = false;
			this.MainMenuButton.Visible = false;
			//
			//editButton
			//
			this.editButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.editButton.BackColor = System.Drawing.Color.White;
			this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.editButton.Location = new System.Drawing.Point(411, 13);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(216, 54);
			this.editButton.TabIndex = 2;
			this.editButton.Text = "Edit";
			this.editButton.UseVisualStyleBackColor = false;
			this.editButton.Visible = false;
			//
			//submitButton
			//
			this.submitButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.submitButton.BackColor = System.Drawing.Color.White;
			this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.submitButton.Location = new System.Drawing.Point(169, 13);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(216, 54);
			this.submitButton.TabIndex = 1;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = false;
			this.submitButton.Visible = false;
			//
			//PredictionsLeagueFlowLayoutPanel
			//
			this.PredictionsLeagueFlowLayoutPanel.AutoSize = true;
			this.PredictionsLeagueFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.PredictionsLeagueFlowLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.PredictionsLeagueFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PredictionsLeagueFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.PredictionsLeagueFlowLayoutPanel.MaximumSize = new System.Drawing.Size(800, 0);
			this.PredictionsLeagueFlowLayoutPanel.Name = "PredictionsLeagueFlowLayoutPanel";
			this.PredictionsLeagueFlowLayoutPanel.Size = new System.Drawing.Size(794, 387);
			this.PredictionsLeagueFlowLayoutPanel.TabIndex = 2;
			//
			//PredictionLeagueTableForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(794, 460);
			this.Controls.Add(this.PredictionsLeagueFlowLayoutPanel);
			this.Controls.Add(this.NavigationGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "PredictionLeagueTableForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Predictions League";
			this.NavigationGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.GroupBox NavigationGroupBox;
		private System.Windows.Forms.Button withEventsField_MainMenuButton;
		internal System.Windows.Forms.Button MainMenuButton {
			get { return withEventsField_MainMenuButton; }
			set {
				if (withEventsField_MainMenuButton != null) {
					withEventsField_MainMenuButton.Click -= MainMenuButton_Click;
				}
				withEventsField_MainMenuButton = value;
				if (withEventsField_MainMenuButton != null) {
					withEventsField_MainMenuButton.Click += MainMenuButton_Click;
				}
			}
		}
		internal System.Windows.Forms.Button editButton;
		internal System.Windows.Forms.Button submitButton;
		internal System.Windows.Forms.FlowLayoutPanel PredictionsLeagueFlowLayoutPanel;
		public PredictionLeagueTableForm()
		{
			Load += PredictionLeagueTableForm_Load;
			InitializeComponent();
		}
	}
}
