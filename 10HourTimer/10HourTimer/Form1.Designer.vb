<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.startButton = New System.Windows.Forms.Button()
        Me.nowTimeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.startTimeLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.endTimeLabel = New System.Windows.Forms.Label()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.countDownLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(56, 363)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(158, 68)
        Me.startButton.TabIndex = 0
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'nowTimeLabel
        '
        Me.nowTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nowTimeLabel.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.nowTimeLabel.Location = New System.Drawing.Point(56, 58)
        Me.nowTimeLabel.Name = "nowTimeLabel"
        Me.nowTimeLabel.Size = New System.Drawing.Size(351, 67)
        Me.nowTimeLabel.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 41)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Current"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(506, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 41)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Start"
        '
        'startTimeLabel
        '
        Me.startTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.startTimeLabel.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.startTimeLabel.Location = New System.Drawing.Point(517, 58)
        Me.startTimeLabel.Name = "startTimeLabel"
        Me.startTimeLabel.Size = New System.Drawing.Size(168, 67)
        Me.startTimeLabel.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(506, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 41)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "End"
        '
        'endTimeLabel
        '
        Me.endTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.endTimeLabel.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.endTimeLabel.Location = New System.Drawing.Point(517, 211)
        Me.endTimeLabel.Name = "endTimeLabel"
        Me.endTimeLabel.Size = New System.Drawing.Size(168, 67)
        Me.endTimeLabel.TabIndex = 1
        '
        'resetButton
        '
        Me.resetButton.Enabled = False
        Me.resetButton.Location = New System.Drawing.Point(622, 363)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(158, 68)
        Me.resetButton.TabIndex = 0
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'countDownLabel
        '
        Me.countDownLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.countDownLabel.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.countDownLabel.Location = New System.Drawing.Point(56, 238)
        Me.countDownLabel.Name = "countDownLabel"
        Me.countDownLabel.Size = New System.Drawing.Size(351, 67)
        Me.countDownLabel.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 41)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Count Down"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(330, 363)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 58)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 41.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(813, 461)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.endTimeLabel)
        Me.Controls.Add(Me.startTimeLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.countDownLabel)
        Me.Controls.Add(Me.nowTimeLabel)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.startButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startButton As Button
    Friend WithEvents nowTimeLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents startTimeLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents endTimeLabel As Label
    Friend WithEvents resetButton As Button
    Friend WithEvents countDownLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
