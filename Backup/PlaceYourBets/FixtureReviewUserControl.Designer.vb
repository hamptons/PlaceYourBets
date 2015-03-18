<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FixtureReviewUserControl
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
        Me.awayFixtureLabel = New System.Windows.Forms.Label()
        Me.drawLabel = New System.Windows.Forms.Label()
        Me.homeFixtureLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'awayFixtureLabel
        '
        Me.awayFixtureLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.awayFixtureLabel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.awayFixtureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.awayFixtureLabel.Location = New System.Drawing.Point(472, 3)
        Me.awayFixtureLabel.Name = "awayFixtureLabel"
        Me.awayFixtureLabel.Size = New System.Drawing.Size(328, 30)
        Me.awayFixtureLabel.TabIndex = 5
        Me.awayFixtureLabel.Text = "Away Team"
        Me.awayFixtureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'drawLabel
        '
        Me.drawLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.drawLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.drawLabel.Location = New System.Drawing.Point(346, 3)
        Me.drawLabel.Name = "drawLabel"
        Me.drawLabel.Size = New System.Drawing.Size(120, 30)
        Me.drawLabel.TabIndex = 4
        Me.drawLabel.Text = "Draw"
        Me.drawLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'homeFixtureLabel
        '
        Me.homeFixtureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeFixtureLabel.Location = New System.Drawing.Point(12, 3)
        Me.homeFixtureLabel.Name = "homeFixtureLabel"
        Me.homeFixtureLabel.Size = New System.Drawing.Size(328, 30)
        Me.homeFixtureLabel.TabIndex = 3
        Me.homeFixtureLabel.Text = "Home Team"
        Me.homeFixtureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FixtureReviewUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.awayFixtureLabel)
        Me.Controls.Add(Me.drawLabel)
        Me.Controls.Add(Me.homeFixtureLabel)
        Me.Name = "FixtureReviewUserControl"
        Me.Size = New System.Drawing.Size(800, 35)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents awayFixtureLabel As System.Windows.Forms.Label
    Friend WithEvents drawLabel As System.Windows.Forms.Label
    Friend WithEvents homeFixtureLabel As System.Windows.Forms.Label

End Class
