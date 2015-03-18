<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserPredictionsUserControl
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
        Me.userLabel = New System.Windows.Forms.Label()
        Me.submittedLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'userLabel
        '
        Me.userLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLabel.Location = New System.Drawing.Point(165, 8)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(200, 35)
        Me.userLabel.TabIndex = 0
        Me.userLabel.Text = "User"
        Me.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'submittedLabel
        '
        Me.submittedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submittedLabel.Location = New System.Drawing.Point(418, 8)
        Me.submittedLabel.Name = "submittedLabel"
        Me.submittedLabel.Size = New System.Drawing.Size(200, 35)
        Me.submittedLabel.TabIndex = 1
        Me.submittedLabel.Text = "Submitted"
        Me.submittedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserPredictionsUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.submittedLabel)
        Me.Controls.Add(Me.userLabel)
        Me.Name = "UserPredictionsUserControl"
        Me.Size = New System.Drawing.Size(800, 50)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents userLabel As System.Windows.Forms.Label
    Friend WithEvents submittedLabel As System.Windows.Forms.Label

End Class
