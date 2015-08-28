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
	partial class ReviewForm : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewForm));
			this.FinishReviewGroupBox = new System.Windows.Forms.GroupBox();
			this.MainMenuButton = new System.Windows.Forms.Button();
			this.ReviewBetsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.FinishReviewGroupBox.SuspendLayout();
			this.SuspendLayout();
			//
			//FinishReviewGroupBox
			//
			this.FinishReviewGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.FinishReviewGroupBox.Controls.Add(this.MainMenuButton);
			this.FinishReviewGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.FinishReviewGroupBox.Location = new System.Drawing.Point(0, 292);
			this.FinishReviewGroupBox.Name = "FinishReviewGroupBox";
			this.FinishReviewGroupBox.Size = new System.Drawing.Size(784, 70);
			this.FinishReviewGroupBox.TabIndex = 0;
			this.FinishReviewGroupBox.TabStop = false;
			//
			//MainMenuButton
			//
			this.MainMenuButton.BackColor = System.Drawing.Color.White;
			this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.MainMenuButton.Location = new System.Drawing.Point(282, 10);
			this.MainMenuButton.Name = "MainMenuButton";
			this.MainMenuButton.Size = new System.Drawing.Size(216, 54);
			this.MainMenuButton.TabIndex = 1;
			this.MainMenuButton.Text = "Menu";
			this.MainMenuButton.UseVisualStyleBackColor = false;
			//
			//ReviewBetsFlowLayoutPanel
			//
			this.ReviewBetsFlowLayoutPanel.AutoSize = true;
			this.ReviewBetsFlowLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ReviewBetsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ReviewBetsFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.ReviewBetsFlowLayoutPanel.MaximumSize = new System.Drawing.Size(800, 0);
			this.ReviewBetsFlowLayoutPanel.Name = "ReviewBetsFlowLayoutPanel";
			this.ReviewBetsFlowLayoutPanel.Size = new System.Drawing.Size(784, 292);
			this.ReviewBetsFlowLayoutPanel.TabIndex = 1;
			//
			//ReviewForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(784, 362);
			this.Controls.Add(this.ReviewBetsFlowLayoutPanel);
			this.Controls.Add(this.FinishReviewGroupBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MinimumSize = new System.Drawing.Size(300, 200);
			this.Name = "ReviewForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Review Bet";
			this.FinishReviewGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.GroupBox FinishReviewGroupBox;
		internal System.Windows.Forms.FlowLayoutPanel ReviewBetsFlowLayoutPanel;
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
	}
}
