<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PredictionsSubmitted
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PredictionsSubmitted))
        Me.NavigationGroupBox = New System.Windows.Forms.GroupBox()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.UserPredictionsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.NavigationGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NavigationGroupBox
        '
        Me.NavigationGroupBox.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NavigationGroupBox.Controls.Add(Me.MainMenuButton)
        Me.NavigationGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NavigationGroupBox.Location = New System.Drawing.Point(0, 295)
        Me.NavigationGroupBox.Name = "NavigationGroupBox"
        Me.NavigationGroupBox.Size = New System.Drawing.Size(784, 67)
        Me.NavigationGroupBox.TabIndex = 0
        Me.NavigationGroupBox.TabStop = False
        '
        'MainMenuButton
        '
        Me.MainMenuButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MainMenuButton.BackColor = System.Drawing.Color.White
        Me.MainMenuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuButton.Location = New System.Drawing.Point(284, 7)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(216, 54)
        Me.MainMenuButton.TabIndex = 1
        Me.MainMenuButton.Text = "Menu"
        Me.MainMenuButton.UseVisualStyleBackColor = False
        Me.MainMenuButton.Visible = False
        '
        'UserPredictionsFlowLayoutPanel
        '
        Me.UserPredictionsFlowLayoutPanel.AutoSize = True
        Me.UserPredictionsFlowLayoutPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.UserPredictionsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserPredictionsFlowLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.UserPredictionsFlowLayoutPanel.MaximumSize = New System.Drawing.Size(800, 0)
        Me.UserPredictionsFlowLayoutPanel.Name = "UserPredictionsFlowLayoutPanel"
        Me.UserPredictionsFlowLayoutPanel.Size = New System.Drawing.Size(784, 295)
        Me.UserPredictionsFlowLayoutPanel.TabIndex = 1
        '
        'PredictionsSubmitted
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 362)
        Me.Controls.Add(Me.UserPredictionsFlowLayoutPanel)
        Me.Controls.Add(Me.NavigationGroupBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PredictionsSubmitted"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Predictions Submitted"
        Me.NavigationGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NavigationGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MainMenuButton As System.Windows.Forms.Button
    Friend WithEvents UserPredictionsFlowLayoutPanel As System.Windows.Forms.FlowLayoutPanel
End Class
