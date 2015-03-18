Public Class ProgressBarForm

    Private Sub ProgressBarForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ProgressBar1 As ProgressBar
        ProgressBar1 = New ProgressBar()
        'set position
        ProgressBar1.Location = New Point(100, 100)
        'set values
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 9
        ProgressBar1.Step = 1
        'add the progress bar to the form
        Me.Controls.Add(ProgressBar1)
        ProgressBar1.Visible = True

    End Sub
End Class