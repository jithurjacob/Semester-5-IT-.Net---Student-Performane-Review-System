Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Public Class adminpage
    Public cn As New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=quizdb;Integrated Security=True")
    Dim reader As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles changepwd_btn.Click
        Try
            Dim currentpassword As String = cpwd_txt.Text
            Dim newpassword As String = newpwd_txt.Text
            Dim verifypassword As String = verify_txt.Text
            cn.Open()
            Dim dbpassword As String = ""
            Dim cmd As New SqlCommand("select * from admin;", cn)
            Dim reader As SqlDataReader = cmd.ExecuteReader
            While reader.Read
                dbpassword = reader.Item("pwd")

            End While
            reader.Close()
            cn.Close()
            If currentpassword.Equals(dbpassword) Then
                '  MsgBox("ok")
                cn.Open()
                Dim cmd1 As New SqlCommand("update admin set pwd=@pwd ", cn)
                cmd1.Parameters.Clear()
                cmd1.Parameters.AddWithValue("@pwd", newpassword)
                cmd1.Parameters.AddWithValue("@pre", currentpassword)
                cmd1.ExecuteNonQuery()
                MsgBox("Password changed successfully...")
                cn.Close()
            Else
                MsgBox("password is wrong")

            End If
           




        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim count = "1", name As String
        Try
            cn.Close()
            cn.Open()
            Dim cmd1 As New SqlCommand("select max(id)+1 as count from category;", cn)
            reader = cmd1.ExecuteReader
            While reader.Read
                count = reader.Item("count")
            End While
            reader.Close()
            cn.Close()

            cn.Open()
            Dim cmd2 As New SqlCommand("select  count(*) as count from category where name= @name;", cn)
            cmd2.Parameters.Clear()
            cmd2.Parameters.AddWithValue("@name", category_name.Text)
            reader = cmd2.ExecuteReader
            While reader.Read
                If Not reader.Item("count").ToString.Equals("0") Then
                    MsgBox("Category Name already exists...")
                    Return
                End If
            End While
            reader.Close()

            cn.Close()
            cn.Open()
            Dim cmd As New SqlCommand("insert into category values(@id,@name);", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", count)
            cmd.Parameters.AddWithValue("@name", category_name.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Category added successfully...")
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            cn.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub adminpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuizdbDataSet4.category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.QuizdbDataSet4.category)
        'TODO: This line of code loads data into the 'QuizdbDataSet3.questions' table. You can move, or remove it, as needed.
        Me.QuestionsTableAdapter.Fill(Me.QuizdbDataSet3.questions)
        'TODO: This line of code loads data into the 'QuizdbDataSet2.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.QuizdbDataSet2.users)

    End Sub

    Private Sub addqns_btn_Click(sender As Object, e As EventArgs) Handles addqns_btn.Click
        Dim count = "1", cat, qns, cans, c1, c2, c3, c4 As String
        qns = qns_txt.Text
        cat = category_cb.SelectedValue.ToString
        cans = cans_txt.Text
        c1 = c1_txt.Text
        c2 = c2_txt.Text
        c3 = c3_txt.Text
        c4 = c4_txt.Text
        Try
            cn.Open()
            Dim cmd1 As New SqlCommand("select max(id)+1 as count from questions;", cn)
            reader = cmd1.ExecuteReader
            While reader.Read
                count = reader.Item("count").ToString
            End While
            reader.Close()
            cn.Close()

            cn.Open()
            Dim cmd2 As New SqlCommand("select  count(*) as count from questions where qns= @qns;", cn)
            cmd2.Parameters.Clear()
            cmd2.Parameters.AddWithValue("@qns", qns)
            reader = cmd2.ExecuteReader
            While reader.Read
                If Not reader.Item("count").ToString.Equals("0") Then
                    MsgBox("Question already exists...")
                    Return
                End If
            End While
            reader.Close()

            cn.Close()
            cn.Open()
            Dim cmd As New SqlCommand("insert into questions values(@id,@cat,@qns,@ans,@c1,@c2,@c3,@c4);", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id", count)
            cmd.Parameters.AddWithValue("@cat", cat)
            cmd.Parameters.AddWithValue("@qns", qns)
            cmd.Parameters.AddWithValue("@ans", cans)
            cmd.Parameters.AddWithValue("@c1", c1)
            cmd.Parameters.AddWithValue("@c2", c2)
            cmd.Parameters.AddWithValue("@c3", c3)
            cmd.Parameters.AddWithValue("@c4", c4)
            cmd.ExecuteNonQuery()
            MsgBox("Question added successfully...")
            Me.QuestionsTableAdapter.Fill(Me.QuizdbDataSet3.questions)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
            cn.Close()
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Me.CategoryTableAdapter.Fill(Me.QuizdbDataSet4.category)
    End Sub
End Class