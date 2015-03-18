<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PredictionLeagueUserControl
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
        Me.usernameLabel = New System.Windows.Forms.Label()
        Me.pointsLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'usernameLabel
        '
        Me.usernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameLabel.Location = New System.Drawing.Point(114, 19)
        Me.usernameLabel.Name = "usernameLabel"
        Me.usernameLabel.Size = New System.Drawing.Size(240, 64)
        Me.usernameLabel.TabIndex = 0
        Me.usernameLabel.Text = "user"
        Me.usernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pointsLabel
        '
        Me.pointsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointsLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.pointsLabel.Location = New System.Drawing.Point(465, 19)
        Me.pointsLabel.Name = "pointsLabel"
        Me.pointsLabel.Size = New System.Drawing.Size(240, 64)
        Me.pointsLabel.TabIndex = 1
        Me.pointsLabel.Text = "points"
        Me.pointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PredictionLeagueUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.pointsLabel)
        Me.Controls.Add(Me.usernameLabel)
        Me.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PredictionLeagueUserControl"
        Me.Size = New System.Drawing.Size(800, 100)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents usernameLabel As System.Windows.Forms.Label
    Friend WithEvents pointsLabel As System.Windows.Forms.Label

End Class
