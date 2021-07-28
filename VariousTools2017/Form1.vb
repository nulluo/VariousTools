Public Class Form1


#Region "Property"
    'UNIMPLEMENTED: 何のために用意したプロパティだっけ？これ
    'Private Property Duration As Integer

    Dim _endTime As DateTime
    ''' <summary>
    ''' カウントダウン終了時刻
    ''' </summary>
    ''' <returns>カウントダウン終了時刻</returns>
    Private Property EndTime As DateTime
        Get
            Return _endTime
        End Get
        Set(value As DateTime)
            _endTime = value
            My.Settings.EndTime = _endTime
            My.Settings.Save()
            Me.endTimeLabel.Text = _endTime.ToString("t")
            Me.deadEndTimeLabel.Text = _endTime.AddHours(1).ToString("t")
        End Set
    End Property

    Dim _startTime As DateTime
    Private Property StartTime As DateTime
        Get
            Return _startTIme
        End Get
        Set(value As DateTime)
            _startTime = value
            Me.startTimeLabel.Text = _startTime.ToString("t")
            My.Settings.StartTime = _startTime
            My.Settings.Save()

            'UNIMPLEMENTED: StartTimeプロパティに値がセットされたタイミングで自動的にEndTimeに値が入るような連動プロパティにしてOK
            'UNIMPLEMENTED: ↑そうすると、EndTimeはApp.configに持つ必要がなくなる?←でもデバッグしやすくない？持ってたほうが
        End Set
    End Property

    Dim _isCountdownOnGoing As Boolean
    ''' <summary>
    ''' カウントダウン継続中であるかどうか
    ''' </summary>
    ''' <returns>カウントダウン継続中であるかどうかを表す真理値</returns>
    Private Property IsCountdownOnGoing As Boolean
        Get
            Return _isCountdownOnGoing
        End Get
        Set(onGoing As Boolean)
            _isCountdownOnGoing = onGoing
            If onGoing Then
                Me.startButton.Enabled = False
                Me.resetButton.Enabled = True
            Else
                'UNIMPLEMENTED: ここに,Falseが入った時の画面コントロールの表示制御を移動（ループに注意）

            End If
        End Set
    End Property


    Dim _isDeadEndCountdownOnGoing As Boolean
    ''' <summary>
    ''' カウントダウン終了後の残り1時間のカウントダウン継続中であるかどうか
    ''' </summary>
    ''' <returns>IsCountdownGoingがFalseになってから1時間経過するまでの間のみTrueを返し、それ以外の場合はFalseを返す。</returns>
    Private Property IsDeadEndCountdownOnGoing As Boolean
        Get
            Return _isCountdownOnGoing
        End Get
        Set(value As Boolean)

        End Set
    End Property



    ''' <summary>
    ''' 22時を過ぎているかどうか
    ''' </summary>
    ''' <returns>22時を過ぎているかどうかを表す真理値</returns>
    Private Property IsOver22 As Boolean

    ''' <summary>
    ''' 今日アラームが鳴動したかどうか
    ''' </summary>
    ''' <returns></returns>
    Private Property IsAlarmed As Boolean

#End Region

    'UNIMPLEMENTED: フォームの中でブラウザを開く機能を使えば、出退勤管理システムから出勤を押したのと同時にカウントダウンスタートできないかな…
    'UNIMPLEMENTED: 時刻表示を2桁固定で先頭0埋めにする
    'UNIMPLEMENTED: 2017に移行した時にソリューションとプロジェクトの単位が変わっちゃったのを修正する
    'UNIMPLEMENTED: アラート音の鳴り方がおかしい（繰り返し鳴り続ける）のを改善
    'UNIMPLEMENTED: アラーム鳴動中、22時カウントダウンの文字色を変える▶10時間オーバーのやつにも同じ考え方が使える


    ''' <summary>
    ''' 画面初期化
    ''' </summary>
    Private Sub InitializeForm()
        Dim nowTime As Date = Now
        Dim endTimeMySettings As Date = My.Settings.EndTime
        Dim startTimeMySettings As Date = My.Settings.StartTime
        If endTimeMySettings.CompareTo(nowTime) < 0 Then
            '設定ファイルに保存されたカウントダウン終了時刻を過ぎている場合は、
            '既に今日のカウントダウン終了時刻を過ぎた後か、
            '設定ファイルの時刻は昨日以前に設定したカウントダウン終了時刻である場合なので
            'カウントダウン実行中をOFFにする
            Me.IsCountdownOnGoing = False

            Me.startButton.Enabled = True
            Me.resetButton.Enabled = False

            Me.IsOver22 = False
            Me.IsAlarmed = False

            Me.startTimeLabel.Text = String.Empty
            Me.endTimeLabel.Text = String.Empty
            Me.countDownLabel.Text = String.Empty
            If endTimeMySettings.AddHours(1).CompareTo(nowTime) < 0 Then
                '設定ファイルに保存されたカウントダウン終了時刻から1時間以上過ぎている場合は
                'DeadEndへのカウントダウンも終了しているのでDeadEndカウントダウン実行中フラグを下ろす
                Me.IsDeadEndCountdownOnGoing = False
            Else
                Me.IsDeadEndCountdownOnGoing = True
            End If
        Else
            '設定ファイルに保存されたカウントダウン終了時刻を過ぎていない場合は、
            'アラーム設定後に端末の再起動等でアプリが終了した場合なので、
            '該当の終了時刻を再度セットする
            Me.StartTime = startTimeMySettings
            Me.EndTime = endTimeMySettings
            Me.IsCountdownOnGoing = True
        End If

        If Not Me.IsDeadEndCountdownOnGoing Then
            Me.countDownLabel.ForeColor = Color.Black
        Else
            Me.countDownLabel.ForeColor = Color.Red
        End If
    End Sub

#Region "Event Handler"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.InitializeForm()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim nowTime As Date = Now
        Me.nowTimeLabel.Text = nowTime.ToString("HH:mm:ss")

        '22時へのカウントダウン
        If Not IsOver22 Then
            Dim pm10oClock As Date
            With nowTime
                pm10oClock = New Date(.Year, .Month, .Day, 22, 0, 0)
            End With

            If pm10oClock.CompareTo(nowTime) < 0 Then
                IsOver22 = True
                WindowFlasher.Flash()
            Else
                Dim countFor22 As TimeSpan
                countFor22 = pm10oClock.Subtract(nowTime)
                Me.countdownFor22Label.Text = countFor22.ToString("hh\:mm\:ss")
            End If

        End If

        'EndTimeへのカウントダウン
        If IsCountdownOnGoing Then
            Me.countDownLabel.Text = EndTime.Subtract(nowTime).ToString("hh\:mm\:ss")
            Debug.WriteLine("IsCountdownOnGoing")
            If EndTime.CompareTo(nowTime) < 0 Then
                Me.IsAlarmed = True

                'Debug.WriteLine("EndTimeを過ぎた")
                Me.IsDeadEndCountdownOnGoing = True
                Me.countDownForLabel.Text = My.Settings.EndTime.AddHours(1) & "まで"
                WindowFlasher.Flash()
            End If
        End If

        'DeadEndTimeへのカウントダウン
        If Me.IsDeadEndCountdownOnGoing Then
            Me.countDownLabel.Text = EndTime.AddHours(1).Subtract(nowTime).ToString("hh\:mm\:ss")
            If EndTime.AddMinutes(45).CompareTo(nowTime) < 0 Then
                Me.IsAlarmed = True
                'Debug.WriteLine("EndTimeを過ぎた")
                Me.IsDeadEndCountdownOnGoing = True
                WindowFlasher.Flash()
                Me.countDownLabel.ForeColor = Color.Red
            End If
            If EndTime.AddHours(1).CompareTo(nowTime) < 0 Then
                Me.IsDeadEndCountdownOnGoing = False
                Me.countDownForLabel.Text = String.Empty
            End If
        End If
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Me.StartTime = Now
        Me.EndTime = Now.AddHours(Constants.Limit)
        Me.IsCountdownOnGoing = True
        Me.countDownForLabel.Text = My.Settings.EndTime & "まで"
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        Me.InitializeForm()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WindowFlasher.Flash()
    End Sub

    Private Sub resetEndTimeButton_Click(sender As Object, e As EventArgs) Handles resetEndTimeButton.Click
        Me.EndTime = New Date(2000, 1, 1)
    End Sub

#End Region
End Class
