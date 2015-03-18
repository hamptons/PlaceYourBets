<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReviewForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReviewForm))
        Me.FinishReviewGroupBox = New System.Windows.Forms.GroupBox()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.ReviewBetsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.FinishReviewGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'FinishReviewGroupBox
        '
        Me.FinishReviewGroupBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.FinishReviewGroupBox.Controls.Add(Me.MainMenuButton)
        Me.FinishReviewGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FinishReviewGroupBox.Location = New System.Drawing.Point(0, 292)
        Me.FinishReviewGroupBox.Name = "FinishReviewGroupBox"
        Me.FinishReviewGroupBox.Size = New System.Drawing.Size(784, 70)
        Me.FinishReviewGroupBox.TabIndex = 0
        Me.FinishReviewGroupBox.TabStop = False
        '
        'MainMenuButton
        '
        Me.MainMenuButton.BackColor = System.Drawing.Color.White
        Me.MainMenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuButton.Location = New System.Drawing.Point(282, 10)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(216, 54)
        Me.MainMenuButton.TabIndex = 1
        Me.MainMenuButton.Text = "Menu"
        Me.MainMenuButton.UseVisualStyleBackColor = False
        '
        'ReviewBetsFlowLayoutPanel
        '
        Me.ReviewBetsFlowLayoutPanel.AutoSize = True
        Me.ReviewBetsFlowLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ReviewBetsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReviewBetsFlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.ReviewBetsFlowLayoutPanel.MaximumSize = New System.Drawing.Size(800, 0)
        Me.ReviewBetsFlowLayoutPanel.Name = "ReviewBetsFlowLayoutPanel"
        Me.ReviewBetsFlowLayoutPanel.Size = New System.Drawing.Size(784, 292)
        Me.ReviewBetsFlowLayoutPanel.TabIndex = 1
        '
        'ReviewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(784, 362)
        Me.Controls.Add(Me.ReviewBetsFlowLayoutPanel)
        Me.Controls.Add(Me.FinishReviewGroupBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(300, 200)
        Me.Name = "ReviewForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review Bet"
        Me.FinishReviewGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FinishReviewGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ReviewBetsFlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents MainMenuButton As System.Windows.Forms.Button
End Class
