<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Me.enterPredictionsButton = New System.Windows.Forms.Button()
        Me.reviewCurrentBet = New System.Windows.Forms.Button()
        Me.shutdownButton = New System.Windows.Forms.Button()
        Me.SubmittedPredictionsButton = New System.Windows.Forms.Button()
        Me.PredictionLeagueTableButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'enterPredictionsButton
        '
        Me.enterPredictionsButton.BackColor = System.Drawing.Color.White
        Me.enterPredictionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enterPredictionsButton.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterPredictionsButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.enterPredictionsButton.Location = New System.Drawing.Point(70, 37)
        Me.enterPredictionsButton.Name = "enterPredictionsButton"
        Me.enterPredictionsButton.Size = New System.Drawing.Size(300, 150)
        Me.enterPredictionsButton.TabIndex = 1
        Me.enterPredictionsButton.Text = "Enter Predictions"
        Me.enterPredictionsButton.UseVisualStyleBackColor = False
        '
        'reviewCurrentBet
        '
        Me.reviewCurrentBet.BackColor = System.Drawing.Color.White
        Me.reviewCurrentBet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reviewCurrentBet.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reviewCurrentBet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.reviewCurrentBet.Location = New System.Drawing.Point(424, 37)
        Me.reviewCurrentBet.Name = "reviewCurrentBet"
        Me.reviewCurrentBet.Size = New System.Drawing.Size(300, 150)
        Me.reviewCurrentBet.TabIndex = 2
        Me.reviewCurrentBet.Text = "Bet Slip"
        Me.reviewCurrentBet.UseVisualStyleBackColor = False
        '
        'shutdownButton
        '
        Me.shutdownButton.BackColor = System.Drawing.Color.White
        Me.shutdownButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shutdownButton.Location = New System.Drawing.Point(289, 395)
        Me.shutdownButton.Name = "shutdownButton"
        Me.shutdownButton.Size = New System.Drawing.Size(216, 54)
        Me.shutdownButton.TabIndex = 5
        Me.shutdownButton.Text = "Close"
        Me.shutdownButton.UseVisualStyleBackColor = False
        '
        'SubmittedPredictionsButton
        '
        Me.SubmittedPredictionsButton.BackColor = System.Drawing.Color.White
        Me.SubmittedPredictionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SubmittedPredictionsButton.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmittedPredictionsButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SubmittedPredictionsButton.Location = New System.Drawing.Point(70, 216)
        Me.SubmittedPredictionsButton.Name = "SubmittedPredictionsButton"
        Me.SubmittedPredictionsButton.Size = New System.Drawing.Size(300, 150)
        Me.SubmittedPredictionsButton.TabIndex = 3
        Me.SubmittedPredictionsButton.Text = "Who's Bet"
        Me.SubmittedPredictionsButton.UseVisualStyleBackColor = False
        '
        'PredictionLeagueTableButton
        '
        Me.PredictionLeagueTableButton.BackColor = System.Drawing.Color.White
        Me.PredictionLeagueTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PredictionLeagueTableButton.Font = New System.Drawing.Font("Bauhaus 93", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PredictionLeagueTableButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PredictionLeagueTableButton.Location = New System.Drawing.Point(424, 216)
        Me.PredictionLeagueTableButton.Name = "PredictionLeagueTableButton"
        Me.PredictionLeagueTableButton.Size = New System.Drawing.Size(300, 150)
        Me.PredictionLeagueTableButton.TabIndex = 4
        Me.PredictionLeagueTableButton.Text = "Prediction League Table"
        Me.PredictionLeagueTableButton.UseVisualStyleBackColor = False
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.PlaceYourBets.My.Resources.Resources.pitch1
        Me.ClientSize = New System.Drawing.Size(794, 472)
        Me.Controls.Add(Me.PredictionLeagueTableButton)
        Me.Controls.Add(Me.SubmittedPredictionsButton)
        Me.Controls.Add(Me.shutdownButton)
        Me.Controls.Add(Me.reviewCurrentBet)
        Me.Controls.Add(Me.enterPredictionsButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents enterPredictionsButton As System.Windows.Forms.Button
    Friend WithEvents reviewCurrentBet As System.Windows.Forms.Button
    Friend WithEvents shutdownButton As System.Windows.Forms.Button
    Friend WithEvents SubmittedPredictionsButton As System.Windows.Forms.Button
    Friend WithEvents PredictionLeagueTableButton As System.Windows.Forms.Button
End Class
