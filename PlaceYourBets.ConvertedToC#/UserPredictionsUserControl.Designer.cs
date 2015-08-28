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
	partial class UserPredictionsUserControl : System.Windows.Forms.UserControl
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
			this.userLabel = new System.Windows.Forms.Label();
			this.submittedLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//userLabel
			//
			this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.userLabel.Location = new System.Drawing.Point(165, 8);
			this.userLabel.Name = "userLabel";
			this.userLabel.Size = new System.Drawing.Size(200, 35);
			this.userLabel.TabIndex = 0;
			this.userLabel.Text = "User";
			this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//submittedLabel
			//
			this.submittedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.submittedLabel.Location = new System.Drawing.Point(418, 8);
			this.submittedLabel.Name = "submittedLabel";
			this.submittedLabel.Size = new System.Drawing.Size(200, 35);
			this.submittedLabel.TabIndex = 1;
			this.submittedLabel.Text = "Submitted";
			this.submittedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//UserPredictionsUserControl
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Controls.Add(this.submittedLabel);
			this.Controls.Add(this.userLabel);
			this.Name = "UserPredictionsUserControl";
			this.Size = new System.Drawing.Size(800, 50);
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Label userLabel;

		internal System.Windows.Forms.Label submittedLabel;
	}
}
