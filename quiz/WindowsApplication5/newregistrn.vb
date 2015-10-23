Imports Microsoft.SqlServer
Imports System.Data.SqlClient


Public Class newuserregn
    Public cn As New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=quizdb;Integrated Security=True")

    Private Sub NEWButton1_Click(sender As Object, e As EventArgs) Handles submit_btn.Click, Label9.Click
        Try
            If name_txt.Text.Equals("") Or age_txt.Text.Equals("") Or address_txt.Text.Equals("") Or phone_txt.Text.Equals("") Or email_txt.Text.Equals("") Or pwd_txt.Text.Equals("") Or cpwd_txt.Text.Equals("") Then
                MsgBox("enter the field values")
                Return

            End If
            If Not pwd_txt.Text.Equals(cpwd_txt.Text) Then
                MsgBox("Password field values donot match...")
                Return
            End If

            ' newuserlog.Show()
            Dim id As String
            Dim gender As String '= gender_txt.text
            Dim name As String
            name = name_txt.Text
            Dim dob As String
            dob = DateTimePicker1.Value.ToShortDateString
            Dim emailid As String = email_txt.Text
            Dim age As String = age_txt.Text
            Dim pwd As String = pwd_txt.Text
            If male_btn.Checked Then
                gender = "male"
            Else
                gender = "female"
            End If
            Dim address As String = address_txt.Text
            Dim mobno As String = phone_txt.Text
            Dim invalid_input As Boolean = False
            Dim valid As New valid
            If (valid.is_name(name)) Then
                '   MsgBox("ok name accepted")
            Else
                MsgBox("not name")
                invalid_input = True
                Return
            End If
            If (valid.is_age(age)) Then
                '  MsgBox("ok age accepted")
            Else
                MsgBox("not age")
                invalid_input = True
                Return
            End If
            If (valid.is_mobile_number(mobno)) Then
                ' MsgBox("ok mobile no accepted")
            Else
                MsgBox("not mobile number")
                invalid_input = True
                Return
            End If
            If (valid.is_email(emailid)) Then
                '   MsgBox("ok email accepted")
            Else
                MsgBox("not email")
                invalid_input = True
                Return
            End If

            '  MsgBox(name + dob + age + gender + address + emailid + mobno)
            Dim reader As SqlDataReader
            cn.Close()
            cn.Open()

            Dim cmd As New SqlCommand("select count(*) as count from users where emailid=@username", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@username", emailid)
            reader = cmd.ExecuteReader
            If reader.Read Then
                '  MsgBox(reader.RecordsAffected.ToString)
                Dim count As String = reader.Item("count")
                If (count.Equals("0")) Then
                    ' ok
                    ' MsgBox("ok")

                Else
                    ' not ok
                    MsgBox("Email Id already exists")
                    invalid_input = True
                    Return
                End If
            Else
                MsgBox("invalid  data")
                invalid_input = True
                Return
            End If
            reader.Close()

            cn.Close()

            ' now all data is valid and we have checked if same mail id have been used before
            If Not invalid_input Then
                cn.Open()

                id = "1"
                Dim cmd1 As New SqlCommand("select max(id)+1 as max from users", cn)
                reader = cmd1.ExecuteReader
                While reader.Read ' reader.NextResult()
                    id = reader.Item("max").ToString()
                End While
                reader.Close()

                cn.Close()

                cn.Open()
                MsgBox(id.ToString)
                Dim cmd3 As New SqlCommand("insert into users values(@id,@name,@age,@gender,@mobno,@emailid,@address,@pwd);", cn)
                cmd3.Parameters.Clear()
                cmd3.Parameters.AddWithValue("@id", id)
                cmd3.Parameters.AddWithValue("@name", name)
                cmd3.Parameters.AddWithValue("@age", age)
                cmd3.Parameters.AddWithValue("@gender", gender)
                cmd3.Parameters.AddWithValue("@mobno", mobno)
                cmd3.Parameters.AddWithValue("@emailid", emailid)
                cmd3.Parameters.AddWithValue("@address", address)
                cmd3.Parameters.AddWithValue("@pwd", pwd)
                cmd3.Parameters.AddWithValue("@dob", dob)
                ' MsgBox(cmd.CommandText.ToString)

                cmd3.ExecuteNonQuery()

                ' MsgBox(cmd.CommandText.ToString)
                MsgBox("User added successfully...")
                name_txt.Text = ""
                age_txt.Text = ""
                phone_txt.Text = ""
                email_txt.Text = ""
                address_txt.Text = ""
                pwd_txt.Text = ""
                cpwd_txt.Text = ""




                cn.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub NEWTextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub name_txt_TextChanged(sender As Object, e As EventArgs) Handles name_txt.TextChanged

    End Sub

    Private Sub male_btn_CheckedChanged(sender As Object, e As EventArgs) Handles male_btn.CheckedChanged, female_btn.CheckedChanged
        If male_btn.Checked Then
            female_btn.Checked = False


        End If
        If female_btn.Checked Then
            male_btn.Checked = False


        End If

    End Sub

   
    Private Sub newuserregn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub phone_txt_TextChanged(sender As Object, e As EventArgs) Handles phone_txt.TextChanged

    End Sub
End Class