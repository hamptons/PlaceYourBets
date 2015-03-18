<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FixturesForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FixturesForm))
        Me.submitButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.submitGroupBox = New System.Windows.Forms.GroupBox()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.submitGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'submitButton
        '
        Me.submitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.submitButton.BackColor = System.Drawing.Color.White
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.Location = New System.Drawing.Point(166, 12)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(216, 54)
        Me.submitButton.TabIndex = 1
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = False
        Me.submitButton.Visible = False
        '
        'editButton
        '
        Me.editButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.editButton.BackColor = System.Drawing.Color.White
        Me.editButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.Location = New System.Drawing.Point(411, 12)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(216, 54)
        Me.editButton.TabIndex = 2
        Me.editButton.Text = "Edit"
        Me.editButton.UseVisualStyleBackColor = False
        Me.editButton.Visible = False
        '
        'submitGroupBox
        '
        Me.submitGroupBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.submitGroupBox.Controls.Add(Me.MainMenuButton)
        Me.submitGroupBox.Controls.Add(Me.editButton)
        Me.submitGroupBox.Controls.Add(Me.submitButton)
        Me.submitGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.submitGroupBox.Location = New System.Drawing.Point(0, 300)
        Me.submitGroupBox.Name = "submitGroupBox"
        Me.submitGroupBox.Size = New System.Drawing.Size(794, 72)
        Me.submitGroupBox.TabIndex = 0
        Me.submitGroupBox.TabStop = False
        Me.submitGroupBox.Visible = False
        '
        'MainMenuButton
        '
        Me.MainMenuButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MainMenuButton.BackColor = System.Drawing.Color.White
        Me.MainMenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuButton.Location = New System.Drawing.Point(289, 12)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(216, 54)
        Me.MainMenuButton.TabIndex = 1
        Me.MainMenuButton.Text = "Menu"
        Me.MainMenuButton.UseVisualStyleBackColor = False
        Me.MainMenuButton.Visible = False
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.AutoSize = True
        Me.FlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel.Enabled = False
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel.MaximumSize = New System.Drawing.Size(800, 0)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(794, 300)
        Me.FlowLayoutPanel.TabIndex = 5
        Me.FlowLayoutPanel.Visible = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(794, 372)
        Me.Controls.Add(Me.FlowLayoutPanel)
        Me.Controls.Add(Me.submitGroupBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 200)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Place Your Bets"
        Me.submitGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents submitButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents submitGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MainMenuButton As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel

End Class
