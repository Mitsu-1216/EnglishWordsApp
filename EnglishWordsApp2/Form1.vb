Public Class Form1
    Dim EnglishProblemWords() As String = {"リンゴ", "学校", "鉛筆", "机", "鞄", "本", "部屋", "コップ", "椅子", "頭"}
    Dim EnglishAnswerWords() As String = {"apple", "school", "pencil", "desk", "bag", "book", "room", "cup", "chair", "head"}
    Dim count As Integer = 0

    Private Sub problemNumber_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        problemNumber.Text = "第" + (count + 1).ToString + "門"
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        count = count + 1
        EnglishProblem.Text = EnglishProblemWords(count)
        EnglishAnswer.Text = EnglishAnswerWords(count)
        EnglishAnswer.Visible = False
        problemNumber.Text = "第" + (count + 1).ToString + "門"
        If count = EnglishProblemWords.Count - 1 Then
            NextButton.Enabled = False
        End If
        If Not count = 0 Then
            BackButton.Enabled = True
        End If
        correctAnswer.Text = ""
        TextBoxAnswer.Text = ""

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If count > 0 Then
            count = count - 1
            EnglishProblem.Text = EnglishProblemWords(count)
        End If
        problemNumber.Text = "第" + (count + 1).ToString + "門"
        If count = 0 Then
            BackButton.Enabled = False
        End If
        If Not count = EnglishProblemWords.Count - 1 Then
            NextButton.Enabled = True
        End If
        correctAnswer.Text = ""
        TextBoxAnswer.Text = ""
        EnglishAnswer.Text = EnglishAnswerWords(count)
        EnglishAnswer.Visible = False
    End Sub

    Private Sub BackButton_property(sender As Object, e As EventArgs) Handles MyBase.Load
        If count = 0 Then
            BackButton.Enabled = False
        End If
    End Sub

    '次の問題
    Private Sub answer_Click(sender As Object, e As EventArgs) Handles answer.Click
        EnglishAnswer.Visible = True
        If TextBoxAnswer.Text = EnglishAnswerWords(count) Then
            correctAnswer.Text = "〇"
            correctAnswer.ForeColor = Color.Blue
        Else
            correctAnswer.Text = "×"
            correctAnswer.ForeColor = Color.Red
        End If
    End Sub

End Class
