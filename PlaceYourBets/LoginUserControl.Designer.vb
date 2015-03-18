<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginUserControl
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
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.userLabel = New System.Windows.Forms.Label()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.shutdownButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox
        '
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox.Image = Global.PlaceYourBets.My.Resources.Resources.icon2
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(400, 400)
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'userLabel
        '
        Me.userLabel.Location = New System.Drawing.Point(567, 82)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(64, 26)
        Me.userLabel.TabIndex = 5
        Me.userLabel.Text = "Username"
        Me.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'usernameTextBox
        '
        Me.usernameTextBox.BackColor = System.Drawing.Color.White
        Me.usernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTextBox.Location = New System.Drawing.Point(450, 102)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(300, 20)
        Me.usernameTextBox.TabIndex = 6
        Me.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.White
        Me.loginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.Location = New System.Drawing.Point(450, 128)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(300, 40)
        Me.loginButton.TabIndex = 7
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'registerButton
        '
        Me.registerButton.BackColor = System.Drawing.Color.White
        Me.registerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerButton.Location = New System.Drawing.Point(450, 211)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(300, 40)
        Me.registerButton.TabIndex = 8
        Me.registerButton.Text = "Register"
        Me.registerButton.UseVisualStyleBackColor = False
        '
        'shutdownButton
        '
        Me.shutdownButton.BackColor = System.Drawing.Color.White
        Me.shutdownButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shutdownButton.Location = New System.Drawing.Point(450, 257)
        Me.shutdownButton.Name = "shutdownButton"
        Me.shutdownButton.Size = New System.Drawing.Size(300, 40)
        Me.shutdownButton.TabIndex = 9
        Me.shutdownButton.Text = "Shutdown"
        Me.shutdownButton.UseVisualStyleBackColor = False
        '
        'LoginUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.shutdownButton)
        Me.Controls.Add(Me.registerButton)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.userLabel)
        Me.Controls.Add(Me.PictureBox)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "LoginUserControl"
        Me.Size = New System.Drawing.Size(800, 400)
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents userLabel As System.Windows.Forms.Label
    Friend WithEvents usernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents loginButton As System.Windows.Forms.Button
    Friend WithEvents registerButton As System.Windows.Forms.Button
    Friend WithEvents shutdownButton As System.Windows.Forms.Button

End Class
