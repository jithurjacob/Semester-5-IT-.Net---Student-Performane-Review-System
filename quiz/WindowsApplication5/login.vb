Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Public Class login
    Public cn As New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=quizdb;Integrated Security=True")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' MsgBox("hh")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Label4.Click


        newuserregn.Show()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Label3.Click

        Try
            If username_txt.Text.Equals("admin") Then
                Dim username As String = username_txt.Text
                Dim pwd As String
                username = username_txt.Text
                pwd = pwd_txt.Text
                cn.Open()
                Dim cmd As New SqlCommand("select count(*) as count from admin where pwd=@pwd;", cn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@pwd", pwd)
                ' MsgBox(cmd.CommandText.ToString)

                'Form7.Show()
                Dim reader As SqlDataReader
                reader = cmd.ExecuteReader
                If reader.Read Then
                    '  MsgBox(reader.RecordsAffected.ToString)
                    Dim count As String = reader.Item("count")
                    If (count.Equals("1")) Then
                        ' ok
                        MsgBox("ok")
                        Me.Hide()
                        adminpage.Show()
                    Else
                        ' not ok
                        MsgBox("not ok")
                    End If
                Else
                    MsgBox("invalid login data")
                End If
                reader.Close()
                cn.Close()
            Else
                Dim username As String = username_txt.Text
                Dim pwd As String
                username = username_txt.Text
                pwd = pwd_txt.Text
                cn.Open()
                Dim cmd As New SqlCommand("select count(*) as count from users where emailid=@username and pwd=@pwd;", cn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@pwd", pwd)
                ' MsgBox(cmd.CommandText.ToString)

                'Form7.Show()
                Dim reader As SqlDataReader
                reader = cmd.ExecuteReader
                If reader.Read Then
                    '  MsgBox(reader.RecordsAffected.ToString)
                    Dim count As String = reader.Item("count")
                    If (count.Equals("1")) Then
                        ' ok
                        ' MsgBox("ok")
                        Me.Hide()
                        stntaccnt.Show()
                    Else
                        ' not ok
                        MsgBox("invalid login data")
                    End If
                Else
                    MsgBox("invalid login data")
                End If
                reader.Close()
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles username_txt.KeyPress
        ' MsgBox(e.KeyChar.ToString)
        If e.KeyChar.Equals(Keys.Enter) Then
            pwd_txt.Focus()

        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles username_txt.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
