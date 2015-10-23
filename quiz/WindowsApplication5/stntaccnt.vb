Public Class stntaccnt

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub stntaccnt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuizdbDataSet1.result' table. You can move, or remove it, as needed.
        Me.ResultTableAdapter.Fill(Me.QuizdbDataSet1.result)
        welcome_txt.Text = "Hi , " + login.username_txt.Text
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        exam.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.ResultTableAdapter.Fill(Me.QuizdbDataSet1.result)
    End Sub
End Class