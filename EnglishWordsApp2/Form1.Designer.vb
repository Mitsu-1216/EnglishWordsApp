<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.answer = New System.Windows.Forms.Button()
        Me.EnglishProblem = New System.Windows.Forms.Label()
        Me.problemNumber = New System.Windows.Forms.Label()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TextBoxAnswer = New System.Windows.Forms.TextBox()
        Me.EnglishAnswer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.correctAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'answer
        '
        Me.answer.Location = New System.Drawing.Point(127, 249)
        Me.answer.Margin = New System.Windows.Forms.Padding(4)
        Me.answer.Name = "answer"
        Me.answer.Size = New System.Drawing.Size(177, 71)
        Me.answer.TabIndex = 0
        Me.answer.Text = "答え"
        Me.answer.UseVisualStyleBackColor = True
        '
        'EnglishProblem
        '
        Me.EnglishProblem.AutoSize = True
        Me.EnglishProblem.Font = New System.Drawing.Font("MS UI Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EnglishProblem.Location = New System.Drawing.Point(115, 139)
        Me.EnglishProblem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EnglishProblem.Name = "EnglishProblem"
        Me.EnglishProblem.Size = New System.Drawing.Size(181, 72)
        Me.EnglishProblem.TabIndex = 1
        Me.EnglishProblem.Text = "リンゴ"
        '
        'problemNumber
        '
        Me.problemNumber.AutoSize = True
        Me.problemNumber.Location = New System.Drawing.Point(52, 54)
        Me.problemNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.problemNumber.Name = "problemNumber"
        Me.problemNumber.Size = New System.Drawing.Size(0, 21)
        Me.problemNumber.TabIndex = 2
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(598, 358)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(4)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(273, 124)
        Me.NextButton.TabIndex = 3
        Me.NextButton.Text = "次の問題"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(56, 358)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(273, 124)
        Me.BackButton.TabIndex = 4
        Me.BackButton.Text = "前の問題"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'TextBoxAnswer
        '
        Me.TextBoxAnswer.BackColor = System.Drawing.SystemColors.Info
        Me.TextBoxAnswer.Location = New System.Drawing.Point(598, 139)
        Me.TextBoxAnswer.Multiline = True
        Me.TextBoxAnswer.Name = "TextBoxAnswer"
        Me.TextBoxAnswer.Size = New System.Drawing.Size(259, 60)
        Me.TextBoxAnswer.TabIndex = 5
        '
        'EnglishAnswer
        '
        Me.EnglishAnswer.AutoSize = True
        Me.EnglishAnswer.Location = New System.Drawing.Point(493, 274)
        Me.EnglishAnswer.Name = "EnglishAnswer"
        Me.EnglishAnswer.Size = New System.Drawing.Size(63, 21)
        Me.EnglishAnswer.TabIndex = 6
        Me.EnglishAnswer.Text = "apple"
        Me.EnglishAnswer.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'correctAnswer
        '
        Me.correctAnswer.AutoSize = True
        Me.correctAnswer.Location = New System.Drawing.Point(704, 284)
        Me.correctAnswer.Name = "correctAnswer"
        Me.correctAnswer.Size = New System.Drawing.Size(0, 21)
        Me.correctAnswer.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 525)
        Me.Controls.Add(Me.correctAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EnglishAnswer)
        Me.Controls.Add(Me.TextBoxAnswer)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.problemNumber)
        Me.Controls.Add(Me.EnglishProblem)
        Me.Controls.Add(Me.answer)
        Me.Font = New System.Drawing.Font("UD デジタル 教科書体 NK-B", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "answer1"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents answer As Button
    Friend WithEvents EnglishProblem As Label
    Friend WithEvents problemNumber As Label
    Friend WithEvents NextButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents TextBoxAnswer As TextBox
    Friend WithEvents EnglishAnswer As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents correctAnswer As Label
End Class
