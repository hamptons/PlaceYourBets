<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.loginButton = New System.Windows.Forms.Button()
        Me.shutdownButton = New System.Windows.Forms.Button()
        Me.userLabel = New System.Windows.Forms.Label()
        Me.usernameTextBox = New System.Windows.Forms.TextBox()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.registerButton = New System.Windows.Forms.Button()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.White
        Me.loginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.Location = New System.Drawing.Point(446, 244)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(300, 40)
        Me.loginButton.TabIndex = 1
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'shutdownButton
        '
        Me.shutdownButton.BackColor = System.Drawing.Color.White
        Me.shutdownButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shutdownButton.Location = New System.Drawing.Point(597, 290)
        Me.shutdownButton.Name = "shutdownButton"
        Me.shutdownButton.Size = New System.Drawing.Size(145, 40)
        Me.shutdownButton.TabIndex = 3
        Me.shutdownButton.Text = "Shutdown"
        Me.shutdownButton.UseVisualStyleBackColor = False
        '
        'userLabel
        '
        Me.userLabel.Location = New System.Drawing.Point(561, 162)
        Me.userLabel.Name = "userLabel"
        Me.userLabel.Size = New System.Drawing.Size(64, 26)
        Me.userLabel.TabIndex = 4
        Me.userLabel.Text = "Username"
        Me.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTextBox.Location = New System.Drawing.Point(446, 182)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.Size = New System.Drawing.Size(300, 20)
        Me.usernameTextBox.TabIndex = 0
        '
        'titleLabel
        '
        Me.titleLabel.Font = New System.Drawing.Font("Bauhaus 93", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.Location = New System.Drawing.Point(446, 20)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(300, 133)
        Me.titleLabel.TabIndex = 6
        Me.titleLabel.Text = "Place Your Bets..."
        Me.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'registerButton
        '
        Me.registerButton.BackColor = System.Drawing.Color.White
        Me.registerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerButton.Location = New System.Drawing.Point(446, 290)
        Me.registerButton.Name = "registerButton"
        Me.registerButton.Size = New System.Drawing.Size(145, 40)
        Me.registerButton.TabIndex = 2
        Me.registerButton.Text = "Register"
        Me.registerButton.UseVisualStyleBackColor = False
        '
        'PictureBox
        '
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox.Image = Global.PlaceYourBets.My.Resources.Resources.icon2
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(394, 400)
        Me.PictureBox.TabIndex = 7
        Me.PictureBox.TabStop = False
        '
        'LoginForm
        '
        Me.AcceptButton = Me.loginButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 400)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.registerButton)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.usernameTextBox)
        Me.Controls.Add(Me.userLabel)
        Me.Controls.Add(Me.shutdownButton)
        Me.Controls.Add(Me.loginButton)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loginButton As System.Windows.Forms.Button
    Friend WithEvents shutdownButton As System.Windows.Forms.Button
    Friend WithEvents userLabel As System.Windows.Forms.Label
    Friend WithEvents usernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents titleLabel As System.Windows.Forms.Label
    Friend WithEvents registerButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox

End Class
