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
	partial class FixturesForm : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FixturesForm));
			this.submitButton = new System.Windows.Forms.Button();
			this.editButton = new System.Windows.Forms.Button();
			this.submitGroupBox = new System.Windows.Forms.GroupBox();
			this.MainMenuButton = new System.Windows.Forms.Button();
			this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.submitGroupBox.SuspendLayout();
			this.SuspendLayout();
			//
			//submitButton
			//
			this.submitButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.submitButton.BackColor = System.Drawing.Color.White;
			this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.submitButton.Location = new System.Drawing.Point(166, 12);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(216, 54);
			this.submitButton.TabIndex = 1;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = false;
			this.submitButton.Visible = false;
			//
			//editButton
			//
			this.editButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.editButton.BackColor = System.Drawing.Color.White;
			this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.editButton.Location = new System.Drawing.Point(411, 12);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(216, 54);
			this.editButton.TabIndex = 2;
			this.editButton.Text = "Edit";
			this.editButton.UseVisualStyleBackColor = false;
			this.editButton.Visible = false;
			//
			//submitGroupBox
			//
			this.submitGroupBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.submitGroupBox.Controls.Add(this.MainMenuButton);
			this.submitGroupBox.Controls.Add(this.editButton);
			this.submitGroupBox.Controls.Add(this.submitButton);
			this.submitGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.submitGroupBox.Location = new System.Drawing.Point(0, 300);
			this.submitGroupBox.Name = "submitGroupBox";
			this.submitGroupBox.Size = new System.Drawing.Size(794, 72);
			this.submitGroupBox.TabIndex = 0;
			this.submitGroupBox.TabStop = false;
			this.submitGroupBox.Visible = false;
			//
			//MainMenuButton
			//
			this.MainMenuButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.MainMenuButton.BackColor = System.Drawing.Color.White;
			this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.MainMenuButton.Location = new System.Drawing.Point(289, 12);
			this.MainMenuButton.Name = "MainMenuButton";
			this.MainMenuButton.Size = new System.Drawing.Size(216, 54);
			this.MainMenuButton.TabIndex = 1;
			this.MainMenuButton.Text = "Menu";
			this.MainMenuButton.UseVisualStyleBackColor = false;
			this.MainMenuButton.Visible = false;
			//
			//FlowLayoutPanel
			//
			this.FlowLayoutPanel.AutoSize = true;
			this.FlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.FlowLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlowLayoutPanel.Enabled = false;
			this.FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.FlowLayoutPanel.MaximumSize = new System.Drawing.Size(800, 0);
			this.FlowLayoutPanel.Name = "FlowLayoutPanel";
			this.FlowLayoutPanel.Size = new System.Drawing.Size(794, 300);
			this.FlowLayoutPanel.TabIndex = 5;
			this.FlowLayoutPanel.Visible = false;
			//
			//MainForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(794, 372);
			this.Controls.Add(this.FlowLayoutPanel);
			this.Controls.Add(this.submitGroupBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(300, 200);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Place Your Bets";
			this.submitGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private System.Windows.Forms.Button withEventsField_editButton;
		internal System.Windows.Forms.Button editButton {
			get { return withEventsField_editButton; }
			set {
				if (withEventsField_editButton != null) {
					withEventsField_editButton.Click -= editButton_Click;
				}
				withEventsField_editButton = value;
				if (withEventsField_editButton != null) {
					withEventsField_editButton.Click += editButton_Click;
				}
			}
		}
		private System.Windows.Forms.GroupBox withEventsField_submitGroupBox;
		internal System.Windows.Forms.GroupBox submitGroupBox {
			get { return withEventsField_submitGroupBox; }
			set {
				if (withEventsField_submitGroupBox != null) {
					withEventsField_submitGroupBox.Enter -= submitGroupBox_Enter;
				}
				withEventsField_submitGroupBox = value;
				if (withEventsField_submitGroupBox != null) {
					withEventsField_submitGroupBox.Enter += submitGroupBox_Enter;
				}
			}
		}
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

		internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
		public FixturesForm()
		{
			InitializeComponent();
		}
	}
}
