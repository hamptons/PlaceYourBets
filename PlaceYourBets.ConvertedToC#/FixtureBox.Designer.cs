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
	partial class FixtureBox : System.Windows.Forms.UserControl
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
			this.homeLabel = new System.Windows.Forms.Label();
			this.vsLabel = new System.Windows.Forms.Label();
			this.awayLabel = new System.Windows.Forms.Label();
			this.game3GroupBox = new System.Windows.Forms.GroupBox();
			this.awayRadioButton = new System.Windows.Forms.RadioButton();
			this.drawRadioButton = new System.Windows.Forms.RadioButton();
			this.homeRadioButton = new System.Windows.Forms.RadioButton();
			this.backButton = new System.Windows.Forms.Button();
			this.nextButton = new System.Windows.Forms.Button();
			this.dateLabel = new System.Windows.Forms.Label();
			this.awayBadgeBox = new System.Windows.Forms.PictureBox();
			this.homeBadgeBox = new System.Windows.Forms.PictureBox();
			this.game3GroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.awayBadgeBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.homeBadgeBox).BeginInit();
			this.SuspendLayout();
			//
			//homeLabel
			//
			this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.homeLabel.Location = new System.Drawing.Point(184, 101);
			this.homeLabel.Name = "homeLabel";
			this.homeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.homeLabel.Size = new System.Drawing.Size(200, 21);
			this.homeLabel.TabIndex = 0;
			this.homeLabel.Text = "Home";
			this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//vsLabel
			//
			this.vsLabel.AutoSize = true;
			this.vsLabel.Location = new System.Drawing.Point(390, 130);
			this.vsLabel.Name = "vsLabel";
			this.vsLabel.Size = new System.Drawing.Size(18, 13);
			this.vsLabel.TabIndex = 1;
			this.vsLabel.Text = "vs";
			this.vsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//awayLabel
			//
			this.awayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.awayLabel.Location = new System.Drawing.Point(414, 102);
			this.awayLabel.Name = "awayLabel";
			this.awayLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.awayLabel.Size = new System.Drawing.Size(200, 18);
			this.awayLabel.TabIndex = 2;
			this.awayLabel.Text = "Away";
			this.awayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//game3GroupBox
			//
			this.game3GroupBox.BackColor = System.Drawing.Color.White;
			this.game3GroupBox.Controls.Add(this.awayRadioButton);
			this.game3GroupBox.Controls.Add(this.drawRadioButton);
			this.game3GroupBox.Controls.Add(this.homeRadioButton);
			this.game3GroupBox.Location = new System.Drawing.Point(237, 200);
			this.game3GroupBox.Name = "game3GroupBox";
			this.game3GroupBox.Size = new System.Drawing.Size(328, 34);
			this.game3GroupBox.TabIndex = 3;
			this.game3GroupBox.TabStop = false;
			//
			//awayRadioButton
			//
			this.awayRadioButton.AutoSize = true;
			this.awayRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.awayRadioButton.Location = new System.Drawing.Point(231, 10);
			this.awayRadioButton.Name = "awayRadioButton";
			this.awayRadioButton.Size = new System.Drawing.Size(61, 22);
			this.awayRadioButton.TabIndex = 3;
			this.awayRadioButton.Text = "Away";
			this.awayRadioButton.UseVisualStyleBackColor = true;
			//
			//drawRadioButton
			//
			this.drawRadioButton.AutoSize = true;
			this.drawRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.drawRadioButton.Location = new System.Drawing.Point(156, 10);
			this.drawRadioButton.Name = "drawRadioButton";
			this.drawRadioButton.Size = new System.Drawing.Size(61, 22);
			this.drawRadioButton.TabIndex = 2;
			this.drawRadioButton.Text = "Draw";
			this.drawRadioButton.UseVisualStyleBackColor = true;
			//
			//homeRadioButton
			//
			this.homeRadioButton.AutoSize = true;
			this.homeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.homeRadioButton.Location = new System.Drawing.Point(68, 10);
			this.homeRadioButton.Name = "homeRadioButton";
			this.homeRadioButton.Size = new System.Drawing.Size(67, 22);
			this.homeRadioButton.TabIndex = 1;
			this.homeRadioButton.Text = "Home";
			this.homeRadioButton.UseVisualStyleBackColor = true;
			//
			//backButton
			//
			this.backButton.BackColor = System.Drawing.Color.White;
			this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.backButton.Location = new System.Drawing.Point(214, 250);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(170, 50);
			this.backButton.TabIndex = 4;
			this.backButton.Text = "< Back";
			this.backButton.UseVisualStyleBackColor = false;
			//
			//nextButton
			//
			this.nextButton.BackColor = System.Drawing.Color.White;
			this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.nextButton.Location = new System.Drawing.Point(417, 250);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(170, 50);
			this.nextButton.TabIndex = 5;
			this.nextButton.Text = "Next >";
			this.nextButton.UseVisualStyleBackColor = false;
			//
			//dateLabel
			//
			this.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dateLabel.AutoSize = true;
			this.dateLabel.Location = new System.Drawing.Point(427, 63);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(30, 13);
			this.dateLabel.TabIndex = 100;
			this.dateLabel.Text = "Date";
			//
			//awayBadgeBox
			//
			this.awayBadgeBox.Location = new System.Drawing.Point(417, 142);
			this.awayBadgeBox.Name = "awayBadgeBox";
			this.awayBadgeBox.Size = new System.Drawing.Size(40, 40);
			this.awayBadgeBox.TabIndex = 6;
			this.awayBadgeBox.TabStop = false;
			//
			//homeBadgeBox
			//
			this.homeBadgeBox.Location = new System.Drawing.Point(359, 142);
			this.homeBadgeBox.Name = "homeBadgeBox";
			this.homeBadgeBox.Size = new System.Drawing.Size(40, 40);
			this.homeBadgeBox.TabIndex = 5;
			this.homeBadgeBox.TabStop = false;
			//
			//FixtureBox
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.dateLabel);
			this.Controls.Add(this.nextButton);
			this.Controls.Add(this.awayBadgeBox);
			this.Controls.Add(this.homeBadgeBox);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.game3GroupBox);
			this.Controls.Add(this.awayLabel);
			this.Controls.Add(this.vsLabel);
			this.Controls.Add(this.homeLabel);
			this.Name = "FixtureBox";
			this.Size = new System.Drawing.Size(800, 400);
			this.game3GroupBox.ResumeLayout(false);
			this.game3GroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.awayBadgeBox).EndInit();
			((System.ComponentModel.ISupportInitialize)this.homeBadgeBox).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.Label homeLabel;
		internal System.Windows.Forms.Label vsLabel;
		internal System.Windows.Forms.Label awayLabel;
		internal System.Windows.Forms.GroupBox game3GroupBox;
		internal System.Windows.Forms.RadioButton awayRadioButton;
		internal System.Windows.Forms.RadioButton drawRadioButton;
		internal System.Windows.Forms.RadioButton homeRadioButton;
		private System.Windows.Forms.Button withEventsField_backButton;
		internal System.Windows.Forms.Button backButton {
			get { return withEventsField_backButton; }
			set {
				if (withEventsField_backButton != null) {
					withEventsField_backButton.Click -= backButton_Click;
				}
				withEventsField_backButton = value;
				if (withEventsField_backButton != null) {
					withEventsField_backButton.Click += backButton_Click;
				}
			}
		}
		internal System.Windows.Forms.PictureBox homeBadgeBox;
		internal System.Windows.Forms.PictureBox awayBadgeBox;
		private System.Windows.Forms.Button withEventsField_nextButton;
		internal System.Windows.Forms.Button nextButton {
			get { return withEventsField_nextButton; }
			set {
				if (withEventsField_nextButton != null) {
					withEventsField_nextButton.Click -= nextButton_Click;
				}
				withEventsField_nextButton = value;
				if (withEventsField_nextButton != null) {
					withEventsField_nextButton.Click += nextButton_Click;
				}
			}
		}

		internal System.Windows.Forms.Label dateLabel;
	}
}
