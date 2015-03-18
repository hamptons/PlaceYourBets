<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FixtureBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.homeLabel = New System.Windows.Forms.Label()
        Me.vsLabel = New System.Windows.Forms.Label()
        Me.awayLabel = New System.Windows.Forms.Label()
        Me.game3GroupBox = New System.Windows.Forms.GroupBox()
        Me.awayRadioButton = New System.Windows.Forms.RadioButton()
        Me.drawRadioButton = New System.Windows.Forms.RadioButton()
        Me.homeRadioButton = New System.Windows.Forms.RadioButton()
        Me.backButton = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.awayBadgeBox = New System.Windows.Forms.PictureBox()
        Me.homeBadgeBox = New System.Windows.Forms.PictureBox()
        Me.game3GroupBox.SuspendLayout()
        CType(Me.awayBadgeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.homeBadgeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'homeLabel
        '
        Me.homeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeLabel.Location = New System.Drawing.Point(184, 101)
        Me.homeLabel.Name = "homeLabel"
        Me.homeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.homeLabel.Size = New System.Drawing.Size(200, 21)
        Me.homeLabel.TabIndex = 0
        Me.homeLabel.Text = "Home"
        Me.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'vsLabel
        '
        Me.vsLabel.AutoSize = True
        Me.vsLabel.Location = New System.Drawing.Point(390, 130)
        Me.vsLabel.Name = "vsLabel"
        Me.vsLabel.Size = New System.Drawing.Size(18, 13)
        Me.vsLabel.TabIndex = 1
        Me.vsLabel.Text = "vs"
        Me.vsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'awayLabel
        '
        Me.awayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.awayLabel.Location = New System.Drawing.Point(414, 102)
        Me.awayLabel.Name = "awayLabel"
        Me.awayLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.awayLabel.Size = New System.Drawing.Size(200, 18)
        Me.awayLabel.TabIndex = 2
        Me.awayLabel.Text = "Away"
        Me.awayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'game3GroupBox
        '
        Me.game3GroupBox.BackColor = System.Drawing.Color.White
        Me.game3GroupBox.Controls.Add(Me.awayRadioButton)
        Me.game3GroupBox.Controls.Add(Me.drawRadioButton)
        Me.game3GroupBox.Controls.Add(Me.homeRadioButton)
        Me.game3GroupBox.Location = New System.Drawing.Point(237, 200)
        Me.game3GroupBox.Name = "game3GroupBox"
        Me.game3GroupBox.Size = New System.Drawing.Size(328, 34)
        Me.game3GroupBox.TabIndex = 3
        Me.game3GroupBox.TabStop = False
        '
        'awayRadioButton
        '
        Me.awayRadioButton.AutoSize = True
        Me.awayRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.awayRadioButton.Location = New System.Drawing.Point(231, 10)
        Me.awayRadioButton.Name = "awayRadioButton"
        Me.awayRadioButton.Size = New System.Drawing.Size(61, 22)
        Me.awayRadioButton.TabIndex = 3
        Me.awayRadioButton.Text = "Away"
        Me.awayRadioButton.UseVisualStyleBackColor = True
        '
        'drawRadioButton
        '
        Me.drawRadioButton.AutoSize = True
        Me.drawRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drawRadioButton.Location = New System.Drawing.Point(156, 10)
        Me.drawRadioButton.Name = "drawRadioButton"
        Me.drawRadioButton.Size = New System.Drawing.Size(61, 22)
        Me.drawRadioButton.TabIndex = 2
        Me.drawRadioButton.Text = "Draw"
        Me.drawRadioButton.UseVisualStyleBackColor = True
        '
        'homeRadioButton
        '
        Me.homeRadioButton.AutoSize = True
        Me.homeRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeRadioButton.Location = New System.Drawing.Point(68, 10)
        Me.homeRadioButton.Name = "homeRadioButton"
        Me.homeRadioButton.Size = New System.Drawing.Size(67, 22)
        Me.homeRadioButton.TabIndex = 1
        Me.homeRadioButton.Text = "Home"
        Me.homeRadioButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.BackColor = System.Drawing.Color.White
        Me.backButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.Location = New System.Drawing.Point(214, 250)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(170, 50)
        Me.backButton.TabIndex = 4
        Me.backButton.Text = "< Back"
        Me.backButton.UseVisualStyleBackColor = False
        '
        'nextButton
        '
        Me.nextButton.BackColor = System.Drawing.Color.White
        Me.nextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextButton.Location = New System.Drawing.Point(417, 250)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(170, 50)
        Me.nextButton.TabIndex = 5
        Me.nextButton.Text = "Next >"
        Me.nextButton.UseVisualStyleBackColor = False
        '
        'dateLabel
        '
        Me.dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Location = New System.Drawing.Point(354, 51)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(30, 13)
        Me.dateLabel.TabIndex = 100
        Me.dateLabel.Text = "Date"
        '
        'awayBadgeBox
        '
        Me.awayBadgeBox.Location = New System.Drawing.Point(468, 142)
        Me.awayBadgeBox.Name = "awayBadgeBox"
        Me.awayBadgeBox.Size = New System.Drawing.Size(40, 40)
        Me.awayBadgeBox.TabIndex = 6
        Me.awayBadgeBox.TabStop = False
        '
        'homeBadgeBox
        '
        Me.homeBadgeBox.Location = New System.Drawing.Point(292, 142)
        Me.homeBadgeBox.Name = "homeBadgeBox"
        Me.homeBadgeBox.Size = New System.Drawing.Size(40, 40)
        Me.homeBadgeBox.TabIndex = 5
        Me.homeBadgeBox.TabStop = False
        '
        'FixtureBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.nextButton)
        Me.Controls.Add(Me.awayBadgeBox)
        Me.Controls.Add(Me.homeBadgeBox)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.game3GroupBox)
        Me.Controls.Add(Me.awayLabel)
        Me.Controls.Add(Me.vsLabel)
        Me.Controls.Add(Me.homeLabel)
        Me.Name = "FixtureBox"
        Me.Size = New System.Drawing.Size(800, 400)
        Me.game3GroupBox.ResumeLayout(False)
        Me.game3GroupBox.PerformLayout()
        CType(Me.awayBadgeBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.homeBadgeBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents homeLabel As System.Windows.Forms.Label
    Friend WithEvents vsLabel As System.Windows.Forms.Label
    Friend WithEvents awayLabel As System.Windows.Forms.Label
    Friend WithEvents game3GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents awayRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents drawRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents homeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents backButton As System.Windows.Forms.Button
    Friend WithEvents homeBadgeBox As System.Windows.Forms.PictureBox
    Friend WithEvents awayBadgeBox As System.Windows.Forms.PictureBox
    Friend WithEvents nextButton As System.Windows.Forms.Button
    Friend WithEvents dateLabel As System.Windows.Forms.Label

End Class
