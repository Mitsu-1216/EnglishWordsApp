Public Class Form1
    Dim Number As Integer = 1
    Dim EnglishProblemWords() As String = {"リンゴ", "学校", "鉛筆", "机", "鞄", "本", "部屋", "コップ", "椅子", "頭"}
    Dim EnglishAnswerWords() As String = {"apple", "school", "pencil", "desk", "bag", "book", "room", "cup", "chair", "head"}
    Dim i As Integer = 0

    'BackButton.enabled = True

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        i = i + 1
        EnglishProblem.Text = EnglishProblemWords(i)
        EnglishAnswer.Text = EnglishAnswerWords(i)
        EnglishAnswer.Visible = False
        problemNumber.Text = "第" + (i + 1).ToString + "門"
        If i = EnglishProblemWords.Count - 1 Then
            NextButton.Enabled = False
        End If
        If Not i = 0 Then
            BackButton.Enabled = True
        End If
        correctAnswer.Text = ""
        TextBoxAnswer.Text = ""

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If i > 0 Then
            i = i - 1
            EnglishProblem.Text = EnglishProblemWords(i)
        End If
        problemNumber.Text = "第" + (i - 1).ToString + "門"
        If i = 0 Then
            BackButton.Enabled = False
        End If
        If Not i = EnglishProblemWords.Count - 1 Then
            NextButton.Enabled = True
        End If
        correctAnswer.Text = ""
        TextBoxAnswer.Text = ""
        EnglishAnswer.Text = EnglishAnswerWords(i)
        EnglishAnswer.Visible = False
    End Sub

    Private Sub BackButton_property(sender As Object, e As EventArgs) Handles MyBase.Load
        If i = 0 Then
            BackButton.Enabled = False
        End If
    End Sub

    '次の問題
    Private Sub answer_Click(sender As Object, e As EventArgs) Handles answer.Click
        EnglishAnswer.Visible = True
        If TextBoxAnswer.Text = EnglishAnswerWords(i) Then
            correctAnswer.Text = "〇"
        Else
            correctAnswer.Text = "×"
        End If
    End Sub

    Private Sub problemNumber_Click(sender As Object, e As EventArgs) Handles MyBase.Load
        problemNumber.Text = "第" + (i + 1).ToString + "門"
    End Sub
End Class
