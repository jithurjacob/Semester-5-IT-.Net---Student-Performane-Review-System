Imports Microsoft.SqlServer
Imports System.Data.SqlClient

Public Class db_sample
    Public cn As New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=quizdb;Integrated Security=True")


    Private Sub db_sample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuizdbDataSet.user' table. You can move, or remove it, as needed.
        Me.UserTableAdapter.Fill(Me.QuizdbDataSet.users)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmd As New SqlCommand("select * from users ", cn)
        Dim reader As SqlDataReader
        cn.Open()
        Try

            cmd.Connection = cn

            reader = cmd.ExecuteReader
            DataGridView2.Columns.Add("name", "Name")
            While reader.Read
                DataGridView2.Rows.Add()
                DataGridView2.Item(0, DataGridView2.RowCount - 1).Value = reader.Item("name")

            End While
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

        cn.Close()
    End Sub
End Class