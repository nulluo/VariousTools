Public Class Form1

    Private Property Duration As Integer
    Private Property EndTime As DateTime

    Private Property IsStarted As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InitializeForm()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.nowTimeLabel.Text = Now.ToString("HH:mm:ss")
        If IsStarted Then
            Me.countDownLabel.Text = EndTime.Subtract(Now).ToString("hh\:mm\:ss")

            If EndTime.CompareTo(Now) < 0 Then
                WindowFlasher.Flash()
            End If
        End If
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Me.startTimeLabel.Text = Now.ToString("t")
        Me.EndTime = Now.AddHours(Constants.Limit)
        Me.endTimeLabel.Text = EndTime.ToString("t")

        Me.startButton.Enabled = False
        Me.resetButton.Enabled = True
        Me.IsStarted = True
    End Sub

    ''' <summary>
    ''' 画面初期化
    ''' </summary>
    Private Sub InitializeForm()
        Me.Duration = 0
        Me.startButton.Enabled = True
        Me.resetButton.Enabled = False

        Me.IsStarted = False

        Me.startTimeLabel.Text = String.Empty
        Me.endTimeLabel.Text = String.Empty
        Me.countDownLabel.Text = String.Empty
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        Me.InitializeForm()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WindowFlasher.Flash()
    End Sub
End Class
