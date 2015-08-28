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
	partial class PredictionsSubmitted : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredictionsSubmitted));
			this.NavigationGroupBox = new System.Windows.Forms.GroupBox();
			this.MainMenuButton = new System.Windows.Forms.Button();
			this.UserPredictionsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.NavigationGroupBox.SuspendLayout();
			this.SuspendLayout();
			//
			//NavigationGroupBox
			//
			this.NavigationGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NavigationGroupBox.Controls.Add(this.MainMenuButton);
			this.NavigationGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.NavigationGroupBox.Location = new System.Drawing.Point(0, 295);
			this.NavigationGroupBox.Name = "NavigationGroupBox";
			this.NavigationGroupBox.Size = new System.Drawing.Size(784, 67);
			this.NavigationGroupBox.TabIndex = 0;
			this.NavigationGroupBox.TabStop = false;
			//
			//MainMenuButton
			//
			this.MainMenuButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.MainMenuButton.BackColor = System.Drawing.Color.White;
			this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.MainMenuButton.Location = new System.Drawing.Point(284, 7);
			this.MainMenuButton.Name = "MainMenuButton";
			this.MainMenuButton.Size = new System.Drawing.Size(216, 54);
			this.MainMenuButton.TabIndex = 1;
			this.MainMenuButton.Text = "Menu";
			this.MainMenuButton.UseVisualStyleBackColor = false;
			this.MainMenuButton.Visible = false;
			//
			//UserPredictionsFlowLayoutPanel
			//
			this.UserPredictionsFlowLayoutPanel.AutoSize = true;
			this.UserPredictionsFlowLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.UserPredictionsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.UserPredictionsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.UserPredictionsFlowLayoutPanel.MaximumSize = new System.Drawing.Size(800, 0);
			this.UserPredictionsFlowLayoutPanel.Name = "UserPredictionsFlowLayoutPanel";
			this.UserPredictionsFlowLayoutPanel.Size = new System.Drawing.Size(784, 295);
			this.UserPredictionsFlowLayoutPanel.TabIndex = 1;
			//
			//PredictionsSubmitted
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(784, 362);
			this.Controls.Add(this.UserPredictionsFlowLayoutPanel);
			this.Controls.Add(this.NavigationGroupBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "PredictionsSubmitted";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Predictions Submitted";
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
		private System.Windows.Forms.FlowLayoutPanel withEventsField_UserPredictionsFlowLayoutPanel;
		internal System.Windows.Forms.FlowLayoutPanel UserPredictionsFlowLayoutPanel {
			get { return withEventsField_UserPredictionsFlowLayoutPanel; }
			set {
				if (withEventsField_UserPredictionsFlowLayoutPanel != null) {
					withEventsField_UserPredictionsFlowLayoutPanel.Paint -= UserPredictionsFlowLayoutPanel_Paint;
				}
				withEventsField_UserPredictionsFlowLayoutPanel = value;
				if (withEventsField_UserPredictionsFlowLayoutPanel != null) {
					withEventsField_UserPredictionsFlowLayoutPanel.Paint += UserPredictionsFlowLayoutPanel_Paint;
				}
			}
		}
	}
}
