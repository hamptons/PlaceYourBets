<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContainerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ContainerForm))
        Me.TitleBanner = New System.Windows.Forms.Panel()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.enterPredictionsButton = New System.Windows.Forms.Button()
        Me.predictionLeagueButton = New System.Windows.Forms.Button()
        Me.myAccountButton = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.MainFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.submitGroupBox = New System.Windows.Forms.GroupBox()
        Me.editButton = New System.Windows.Forms.Button()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.logOutButton = New System.Windows.Forms.Button()
        Me.betSlipButton = New System.Windows.Forms.Button()
        Me.whoBetButton = New System.Windows.Forms.Button()
        Me.coverTitleLabel = New System.Windows.Forms.Label()
        Me.TitleBanner.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.submitGroupBox.SuspendLayout()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleBanner
        '
        Me.TitleBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TitleBanner.Controls.Add(Me.coverTitleLabel)
        Me.TitleBanner.Controls.Add(Me.PictureBox)
        Me.TitleBanner.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleBanner.Location = New System.Drawing.Point(0, 0)
        Me.TitleBanner.Name = "TitleBanner"
        Me.TitleBanner.Size = New System.Drawing.Size(1008, 200)
        Me.TitleBanner.TabIndex = 0
        '
        'PictureBox
        '
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox.Image = Global.PlaceYourBets.My.Resources.Resources.title
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(1006, 198)
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'enterPredictionsButton
        '
        Me.enterPredictionsButton.BackColor = System.Drawing.Color.White
        Me.enterPredictionsButton.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterPredictionsButton.Location = New System.Drawing.Point(2, 6)
        Me.enterPredictionsButton.Name = "enterPredictionsButton"
        Me.enterPredictionsButton.Size = New System.Drawing.Size(200, 75)
        Me.enterPredictionsButton.TabIndex = 0
        Me.enterPredictionsButton.Text = "Enter Predictions"
        Me.enterPredictionsButton.UseVisualStyleBackColor = False
        '
        'predictionLeagueButton
        '
        Me.predictionLeagueButton.BackColor = System.Drawing.Color.White
        Me.predictionLeagueButton.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.predictionLeagueButton.Location = New System.Drawing.Point(3, 249)
        Me.predictionLeagueButton.Name = "predictionLeagueButton"
        Me.predictionLeagueButton.Size = New System.Drawing.Size(200, 75)
        Me.predictionLeagueButton.TabIndex = 4
        Me.predictionLeagueButton.Text = "Prediction League"
        Me.predictionLeagueButton.UseVisualStyleBackColor = False
        '
        'myAccountButton
        '
        Me.myAccountButton.BackColor = System.Drawing.Color.White
        Me.myAccountButton.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myAccountButton.Location = New System.Drawing.Point(3, 330)
        Me.myAccountButton.Name = "myAccountButton"
        Me.myAccountButton.Size = New System.Drawing.Size(200, 75)
        Me.myAccountButton.TabIndex = 5
        Me.myAccountButton.Text = "My Account"
        Me.myAccountButton.UseVisualStyleBackColor = False
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.MainFlowLayoutPanel)
        Me.MainPanel.Controls.Add(Me.BottomPanel)
        Me.MainPanel.Controls.Add(Me.GroupBox)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 200)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1008, 497)
        Me.MainPanel.TabIndex = 9
        '
        'MainFlowLayoutPanel
        '
        Me.MainFlowLayoutPanel.BackColor = System.Drawing.Color.White
        Me.MainFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainFlowLayoutPanel.Location = New System.Drawing.Point(208, 0)
        Me.MainFlowLayoutPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.MainFlowLayoutPanel.Name = "MainFlowLayoutPanel"
        Me.MainFlowLayoutPanel.Size = New System.Drawing.Size(800, 400)
        Me.MainFlowLayoutPanel.TabIndex = 7
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.Black
        Me.BottomPanel.Controls.Add(Me.submitGroupBox)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(208, 400)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(800, 97)
        Me.BottomPanel.TabIndex = 6
        '
        'submitGroupBox
        '
        Me.submitGroupBox.BackColor = System.Drawing.Color.Black
        Me.submitGroupBox.Controls.Add(Me.editButton)
        Me.submitGroupBox.Controls.Add(Me.submitButton)
        Me.submitGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.submitGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.submitGroupBox.Name = "submitGroupBox"
        Me.submitGroupBox.Size = New System.Drawing.Size(800, 97)
        Me.submitGroupBox.TabIndex = 0
        Me.submitGroupBox.TabStop = False
        Me.submitGroupBox.Visible = False
        '
        'editButton
        '
        Me.editButton.BackColor = System.Drawing.Color.White
        Me.editButton.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editButton.Location = New System.Drawing.Point(426, 25)
        Me.editButton.Name = "editButton"
        Me.editButton.Size = New System.Drawing.Size(200, 50)
        Me.editButton.TabIndex = 6
        Me.editButton.Text = "Edit"
        Me.editButton.UseVisualStyleBackColor = False
        '
        'submitButton
        '
        Me.submitButton.BackColor = System.Drawing.Color.White
        Me.submitButton.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.Location = New System.Drawing.Point(190, 25)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(200, 50)
        Me.submitButton.TabIndex = 5
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = False
        '
        'GroupBox
        '
        Me.GroupBox.BackColor = System.Drawing.Color.Black
        Me.GroupBox.Controls.Add(Me.logOutButton)
        Me.GroupBox.Controls.Add(Me.betSlipButton)
        Me.GroupBox.Controls.Add(Me.whoBetButton)
        Me.GroupBox.Controls.Add(Me.enterPredictionsButton)
        Me.GroupBox.Controls.Add(Me.myAccountButton)
        Me.GroupBox.Controls.Add(Me.predictionLeagueButton)
        Me.GroupBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox.Size = New System.Drawing.Size(208, 497)
        Me.GroupBox.TabIndex = 5
        Me.GroupBox.TabStop = False
        '
        'logOutButton
        '
        Me.logOutButton.BackColor = System.Drawing.Color.White
        Me.logOutButton.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logOutButton.Location = New System.Drawing.Point(3, 411)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(200, 78)
        Me.logOutButton.TabIndex = 6
        Me.logOutButton.Text = "Log Off"
        Me.logOutButton.UseVisualStyleBackColor = False
        '
        'betSlipButton
        '
        Me.betSlipButton.BackColor = System.Drawing.Color.White
        Me.betSlipButton.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.betSlipButton.Location = New System.Drawing.Point(3, 87)
        Me.betSlipButton.Name = "betSlipButton"
        Me.betSlipButton.Size = New System.Drawing.Size(200, 75)
        Me.betSlipButton.TabIndex = 2
        Me.betSlipButton.Text = "Bet Slip"
        Me.betSlipButton.UseVisualStyleBackColor = False
        '
        'whoBetButton
        '
        Me.whoBetButton.BackColor = System.Drawing.Color.White
        Me.whoBetButton.Font = New System.Drawing.Font("Calisto MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.whoBetButton.Location = New System.Drawing.Point(3, 168)
        Me.whoBetButton.Name = "whoBetButton"
        Me.whoBetButton.Size = New System.Drawing.Size(200, 75)
        Me.whoBetButton.TabIndex = 3
        Me.whoBetButton.Text = "Who's Bet"
        Me.whoBetButton.UseVisualStyleBackColor = False
        '
        'coverTitleLabel
        '
        Me.coverTitleLabel.BackColor = System.Drawing.Color.Black
        Me.coverTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.coverTitleLabel.Location = New System.Drawing.Point(0, 0)
        Me.coverTitleLabel.Name = "coverTitleLabel"
        Me.coverTitleLabel.Size = New System.Drawing.Size(1006, 198)
        Me.coverTitleLabel.TabIndex = 1
        Me.coverTitleLabel.Visible = False
        '
        'ContainerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 697)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TitleBanner)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1024, 750)
        Me.Name = "ContainerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TitleBanner.ResumeLayout(False)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.BottomPanel.ResumeLayout(False)
        Me.submitGroupBox.ResumeLayout(False)
        Me.GroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitleBanner As System.Windows.Forms.Panel
    Friend WithEvents enterPredictionsButton As System.Windows.Forms.Button
    Friend WithEvents predictionLeagueButton As System.Windows.Forms.Button
    Friend WithEvents myAccountButton As System.Windows.Forms.Button
    Friend WithEvents MainPanel As System.Windows.Forms.Panel
    Friend WithEvents GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents BottomPanel As System.Windows.Forms.Panel
    Friend WithEvents MainFlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents whoBetButton As System.Windows.Forms.Button
    Friend WithEvents submitGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents editButton As System.Windows.Forms.Button
    Friend WithEvents submitButton As System.Windows.Forms.Button
    Friend WithEvents logOutButton As System.Windows.Forms.Button
    Friend WithEvents betSlipButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents coverTitleLabel As System.Windows.Forms.Label
End Class
