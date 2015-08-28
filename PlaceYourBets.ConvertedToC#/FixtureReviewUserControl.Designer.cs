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
	partial class FixtureReviewUserControl : System.Windows.Forms.UserControl
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
			this.awayFixtureLabel = new System.Windows.Forms.Label();
			this.drawLabel = new System.Windows.Forms.Label();
			this.homeFixtureLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//awayFixtureLabel
			//
			this.awayFixtureLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.awayFixtureLabel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.awayFixtureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.awayFixtureLabel.Location = new System.Drawing.Point(459, 3);
			this.awayFixtureLabel.Name = "awayFixtureLabel";
			this.awayFixtureLabel.Size = new System.Drawing.Size(316, 30);
			this.awayFixtureLabel.TabIndex = 5;
			this.awayFixtureLabel.Text = "Away Team";
			this.awayFixtureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//drawLabel
			//
			this.drawLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.drawLabel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.drawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.drawLabel.Location = new System.Drawing.Point(333, 3);
			this.drawLabel.Name = "drawLabel";
			this.drawLabel.Size = new System.Drawing.Size(120, 30);
			this.drawLabel.TabIndex = 4;
			this.drawLabel.Text = "Draw";
			this.drawLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//homeFixtureLabel
			//
			this.homeFixtureLabel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.homeFixtureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.homeFixtureLabel.Location = new System.Drawing.Point(12, 3);
			this.homeFixtureLabel.Name = "homeFixtureLabel";
			this.homeFixtureLabel.Size = new System.Drawing.Size(315, 30);
			this.homeFixtureLabel.TabIndex = 3;
			this.homeFixtureLabel.Text = "Home Team";
			this.homeFixtureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//FixtureReviewUserControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.awayFixtureLabel);
			this.Controls.Add(this.drawLabel);
			this.Controls.Add(this.homeFixtureLabel);
			this.Name = "FixtureReviewUserControl";
			this.Size = new System.Drawing.Size(800, 35);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Label awayFixtureLabel;
		internal System.Windows.Forms.Label drawLabel;

		internal System.Windows.Forms.Label homeFixtureLabel;
	}
}
