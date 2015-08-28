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
	partial class PredictionLeagueUserControl : System.Windows.Forms.UserControl
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
			this.usernameLabel = new System.Windows.Forms.Label();
			this.pointsLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//usernameLabel
			//
			this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.usernameLabel.Location = new System.Drawing.Point(114, 10);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(240, 48);
			this.usernameLabel.TabIndex = 0;
			this.usernameLabel.Text = "user";
			this.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//pointsLabel
			//
			this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.pointsLabel.ForeColor = System.Drawing.Color.RoyalBlue;
			this.pointsLabel.Location = new System.Drawing.Point(453, 10);
			this.pointsLabel.Name = "pointsLabel";
			this.pointsLabel.Size = new System.Drawing.Size(240, 48);
			this.pointsLabel.TabIndex = 1;
			this.pointsLabel.Text = "points";
			this.pointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//PredictionLeagueUserControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(8f, 18f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.pointsLabel);
			this.Controls.Add(this.usernameLabel);
			this.Font = new System.Drawing.Font("Candara", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "PredictionLeagueUserControl";
			this.Size = new System.Drawing.Size(800, 70);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Label usernameLabel;

		internal System.Windows.Forms.Label pointsLabel;
	}
}
