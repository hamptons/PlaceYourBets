<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PredictionLeagueTableForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PredictionLeagueTableForm))
        Me.NavigationGroupBox = New System.Windows.Forms.GroupBox()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.editButton = New System.Windows.Forms.Button()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.PredictionsLeagueFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.NavigationGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NavigationGroupBox
        '
        Me.NavigationGroupBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NavigationGroupBox.Controls.Add(Me.MainMenuButton)
        Me.NavigationGroupBox.Controls.Add(Me.editButton)
        Me.NavigationGroupBox.Controls.Add(Me.submitButton)
        Me.NavigationGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavigationGroupBox.Location = New System.Drawing.Point(0, 387)
        Me.NavigationGroupBox.Name = "NavigationGroupBox"
        Me.NavigationGroupBox.Size = New System.Drawing.Size(794, 73)
        Me.NavigationGroupBox.TabIndex = 1
        Me.NavigationGroupBox.TabStop = False
        Me.NavigationGroupBox.Visible = False
        '
        'MainMenuButton
        '
        Me.MainMenuButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MainMenuButton.BackColor = System.Drawing.Color.White
        Me.MainMenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuButton.Location = New System.Drawing.Point(290, 13)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(216, 54)
        Me.MainMenuButton.TabIndex = 1
        Me.MainMenuButton.Text = "Menu"
        Me.MainMenuButton.UseVisualStyleBackColor = False
        Me.MainMenuButton.Visible = False
        '
        'editButton
        '
        Me.editButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.editButton.BackColor = System.Drawing.Color.White
        Me.editButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.Location = New System.Drawing.Point(411, 13)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(216, 54)
        Me.editButton.TabIndex = 2
        Me.editButton.Text = "Edit"
        Me.editButton.UseVisualStyleBackColor = False
        Me.editButton.Visible = False
        '
        'submitButton
        '
        Me.submitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.submitButton.BackColor = System.Drawing.Color.White
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.Location = New System.Drawing.Point(169, 13)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(216, 54)
        Me.submitButton.TabIndex = 1
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = False
        Me.submitButton.Visible = False
        '
        'PredictionsLeagueFlowLayoutPanel
        '
        Me.PredictionsLeagueFlowLayoutPanel.AutoSize = True
        Me.PredictionsLeagueFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PredictionsLeagueFlowLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PredictionsLeagueFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PredictionsLeagueFlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.PredictionsLeagueFlowLayoutPanel.MaximumSize = New System.Drawing.Size(800, 0)
        Me.PredictionsLeagueFlowLayoutPanel.Name = "PredictionsLeagueFlowLayoutPanel"
        Me.PredictionsLeagueFlowLayoutPanel.Size = New System.Drawing.Size(794, 387)
        Me.PredictionsLeagueFlowLayoutPanel.TabIndex = 2
        '
        'PredictionLeagueTableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(794, 460)
        Me.Controls.Add(Me.PredictionsLeagueFlowLayoutPanel)
        Me.Controls.Add(Me.NavigationGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PredictionLeagueTableForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Predictions League"
        Me.NavigationGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NavigationGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MainMenuButton As System.Windows.Forms.Button
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents submitButton As System.Windows.Forms.Button
    Friend WithEvents PredictionsLeagueFlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
End Class
