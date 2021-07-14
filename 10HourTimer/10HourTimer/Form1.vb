Public Class Form1

    Private Property Duration As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InitializeForm()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.nowTimeLabel.Text = Now.ToString("HH:mm:ss")
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Me.startTimeLabel.Text = Now.ToString("t")
        Me.endTimeLabel.Text = Now.AddHours(Constants.Limit).ToString("t")
        Me.startButton.Enabled = False
        Me.resetButton.Enabled = True
    End Sub

    ''' <summary>
    ''' 画面初期化
    ''' </summary>
    Private Sub InitializeForm()
        Me.Duration = 0
        Me.startButton.Enabled = True
        Me.resetButton.Enabled = False

        Me.startTimeLabel.Text = String.Empty
        Me.endTimeLabel.Text = String.Empty
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        Me.InitializeForm()
    End Sub

End Class
