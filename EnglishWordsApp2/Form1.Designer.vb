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
        Me.correctAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'answer
        '
        Me.answer.Font = New System.Drawing.Font("UD デジタル 教科書体 NK-B", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.answer.Location = New System.Drawing.Point(74, 256)
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
        Me.EnglishProblem.Font = New System.Drawing.Font("UD デジタル 教科書体 NK-B", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EnglishProblem.Location = New System.Drawing.Point(55, 117)
        Me.EnglishProblem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.EnglishProblem.Name = "EnglishProblem"
        Me.EnglishProblem.Size = New System.Drawing.Size(294, 111)
        Me.EnglishProblem.TabIndex = 1
        Me.EnglishProblem.Text = "リンゴ"
        '
        'problemNumber
        '
        Me.problemNumber.AutoSize = True
        Me.problemNumber.Font = New System.Drawing.Font("UD デジタル 教科書体 NK-B", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.problemNumber.ForeColor = System.Drawing.SystemColors.Highlight
        Me.problemNumber.Location = New System.Drawing.Point(67, 57)
        Me.problemNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.problemNumber.Name = "problemNumber"
        Me.problemNumber.Size = New System.Drawing.Size(104, 37)
        Me.problemNumber.TabIndex = 2
        Me.problemNumber.Text = "第１問"
        '
        'NextButton
        '
        Me.NextButton.Font = New System.Drawing.Font("UD デジタル 教科書体 NK-B", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.NextButton.Location = New System.Drawing.Point(584, 358)
        Me.NextButton.Margin = New System.Windows.Forms.Padding(4)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(273, 124)
        Me.NextButton.TabIndex = 3
        Me.NextButton.Text = "次の問題"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Font = New System.Drawing.Font("UD デジタル 教科書体 NK-B", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.BackButton.Location = New System.Drawing.Point(76, 358)
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
        Me.TextBoxAnswer.Font = New System.Drawing.Font("UD デジタル 教科書体 NK-B", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBoxAnswer.Location = New System.Drawing.Point(598, 139)
        Me.TextBoxAnswer.Multiline = True
        Me.TextBoxAnswer.Name = "TextBoxAnswer"
        Me.TextBoxAnswer.Size = New System.Drawing.Size(259, 60)
        Me.TextBoxAnswer.TabIndex = 5
        '
        'EnglishAnswer
        '
        Me.EnglishAnswer.AutoSize = True
        Me.EnglishAnswer.Font = New System.Drawing.Font("UD デジタル 教科書体 NK-B", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.EnglishAnswer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.EnglishAnswer.Location = New System.Drawing.Point(390, 255)
        Me.EnglishAnswer.Name = "EnglishAnswer"
        Me.EnglishAnswer.Size = New System.Drawing.Size(175, 60)
        Me.EnglishAnswer.TabIndex = 6
        Me.EnglishAnswer.Text = "apple"
        Me.EnglishAnswer.Visible = False
        '
        'correctAnswer
        '
        Me.correctAnswer.AutoSize = True
        Me.correctAnswer.Font = New System.Drawing.Font("UD デジタル 教科書体 NK-B", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.correctAnswer.Location = New System.Drawing.Point(733, 244)
        Me.correctAnswer.Name = "correctAnswer"
        Me.correctAnswer.Size = New System.Drawing.Size(0, 83)
        Me.correctAnswer.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(960, 525)
        Me.Controls.Add(Me.correctAnswer)
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
    Friend WithEvents correctAnswer As Label
End Class
