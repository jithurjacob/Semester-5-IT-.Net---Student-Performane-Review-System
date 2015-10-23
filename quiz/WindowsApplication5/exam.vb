Imports Microsoft.SqlServer
Imports System.Data.SqlClient
Public Class exam


    Dim reader As SqlDataReader
    Public cn As New SqlConnection("Data Source=(LocalDB)\v11.0;Initial Catalog=quizdb;Integrated Security=True")
    Private Sub exam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QuizdbDataSet4.category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.QuizdbDataSet4.category)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles start_lbl.Click
        Try
            Dim qns As String = "j"
            ComboBox1.Enabled = False
            Dim cat As String = ComboBox1.SelectedValue.ToString
            Dim cmd As New SqlCommand("select id from questions where categoryname=@name;", cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@name", cat)
            cn.Open()
            reader = cmd.ExecuteReader
            Dim i As Integer = 0
            While reader.Read
                qns += ("," + reader.Item("id").ToString)
            End While
            If qns.Equals("j") Then
                ComboBox1.Enabled = True
                MsgBox("No questions are available foor selected category...")
                cn.Close()
                Return
            End If
            reader.Close()
            cn.Close()
            qns = qns.Replace("j,", "")
            ' MsgBox(qns)
            Dim qn_no() As String = qns.Split(",")
            'MsgBox(qn_no.Count.ToString)
            Dim n As Integer = qn_no.Count
            If n < 5 Then
                MsgBox("Sorry less than 5 questions are available for this category...")
                ComboBox1.Enabled = True
                cn.Close()
                Return
            End If
            VBMath.Randomize(Double.Parse(Now.Ticks))
            Dim newr As String = rand(n)
            Dim k() As String = newr.Split(",")
            ' MsgBox(newr)
            qnsset.Text = qns
            qnslist.Text = newr
            index_txt.Text = "0"
            Timer1.Start()
            start_lbl.Visible = False
            loadqn(k(0))
            crctanslist.Text = "0,0,0,0,0"


            pre_btn.Visible = True
            next_btn.Visible = True
            finish_btn.Visible = True
            qns_txt.Visible = True
            c1_rbn.Visible = True
            c2_rbn.Visible = True
            c3_rbn.Visible = True
            c4_rbn.Visible = True

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Public Function rand(ByVal n As Integer) As String
        Dim output As String = ""
        Dim rand_order As String = "j"

        For i = 1 To 5

            rand_order += ("," + Math.Floor(VBMath.Rnd(n) * n).ToString)
            ' MsgBox(rand_order)
        Next
        Dim valid As Boolean = True
        ' MsgBox(rand_order.ToString)
        rand_order = rand_order.Replace("j,", "")
        Dim s() As String = rand_order.Split(",")
        For Each p As String In s
            ' MsgBox("testing : " + p)
            Dim c As Integer = 0
            For Each g As String In s
                If (g.ToString.Equals(p)) Then
                    ' MsgBox("g:" + g + "p:" + p)
                    c += 1

                End If
            Next
            ' MsgBox(c.ToString)
            If c > 1 Then
                valid = False
                Exit For
            End If
        Next
        output = rand_order
        If Not valid Then
            ' MsgBox("loop")
            output = rand(n)
        End If
        ' MsgBox(output)
        Return output
    End Function

    Public s As Integer = 0
    Public m As Integer = 0
    Public h As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        s = s + 1
        If (s.Equals(60)) Then
            m = 1
            s = 0
        End If
        If (m.Equals(60)) Then
            h = 1
            m = 0
        End If
        time_lbl.Text = h.ToString + "h :: " + m.ToString + "m :: " + s.ToString + "s"
    End Sub

    Public Sub loadqn(ByVal id As Integer)
        Try
            cn.Open()
            Dim cmd As New SqlCommand("select * from questions where id=@id", cn)
            cmd.Parameters.Clear()
            Dim q() As String = qnsset.Text.Split(",")
            id = Integer.Parse(q(id))
            cmd.Parameters.AddWithValue("@id", id)
            Dim reader As SqlDataReader
            reader = cmd.ExecuteReader
            While reader.Read
                qns_txt.Text = reader.Item("qns").ToString
                cans_txt.Text = reader.Item("ans").ToString
                c1_rbn.Text = reader.Item("choice1").ToString
                c2_rbn.Text = reader.Item("choice2").ToString
                c3_rbn.Text = reader.Item("choice3").ToString
                c4_rbn.Text = reader.Item("choice4").ToString

            End While
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Public Function selectedrdbn() As Integer
        If c1_rbn.Checked Then
            Return 1
        ElseIf c2_rbn.Checked Then
            Return 2
        ElseIf c3_rbn.Checked Then
            Return 3
        ElseIf c4_rbn.Checked Then
            Return 4


        End If

    End Function
    Public Sub selectrdbn(ByVal d As Integer)
        Select Case d
            Case 0
            Case 1
                c1_rbn.Checked = True
            Case 2
                c2_rbn.Checked = True
            Case 3
                c3_rbn.Checked = True
            Case 4
                c4_rbn.Checked = True

        End Select
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        Dim index As String = index_txt.Text
        Dim i As Integer = Integer.Parse(index)

        Dim selectedans As String = selectedrdbn()
        Dim ans As String = choices_txt.Text
        Dim r() As String = ans.Split(",")
        r(i) = selectedans
        ans = String.Join(",", r)
        choices_txt.Text = ans

        Dim crctanslist_() As String = crctanslist.Text.Split(",")
        If correct() Then
            crctanslist_(i) = "1"
        Else
            crctanslist_(i) = "0"
        End If
        crctanslist.Text = String.Join(",", crctanslist_)
        i += 1
        If (i < 0) Then
            i = 0
        ElseIf i > 4 Then
            i = 4
        End If
        selectrdbn(r(i))
        Dim rs() As String = qnslist.Text.Split(",")
        loadqn(rs(i))
        index_txt.Text = i.ToString
    End Sub
    Public Function correct() As Boolean
        Dim result As Boolean = False
        Dim ans As String = cans_txt.Text
        If c1_rbn.Checked Then
            If c1_rbn.Text.Equals(ans) Then
                Return True
            Else
                Return False
            End If
        ElseIf c2_rbn.Checked Then
            If c2_rbn.Text.Equals(ans) Then
                Return True
            Else
                Return False
            End If
        ElseIf c3_rbn.Checked Then
            If c3_rbn.Text.Equals(ans) Then
                Return True
            Else
                Return False
            End If
        ElseIf c4_rbn.Checked Then
            If c4_rbn.Text.Equals(ans) Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles pre_btn.Click
        Dim index As String = index_txt.Text
        Dim i As Integer = Integer.Parse(index)

        Dim selectedans As String = selectedrdbn()
        Dim ans As String = choices_txt.Text
        Dim r() As String = ans.Split(",")
        r(i) = selectedans
        ans = String.Join(",", r)
        choices_txt.Text = ans

        Dim crctanslist_() As String = crctanslist.Text.Split(",")
        If correct() Then
            crctanslist_(i) = "1"
        Else
            crctanslist_(i) = "0"
        End If
        crctanslist.Text = String.Join(",", crctanslist_)
        i -= 1
        If (i < 0) Then
            i = 0
        ElseIf i > 4 Then
            i = 4
        End If
        selectrdbn(r(i))
        Dim rs() As String = qnslist.Text.Split(",")
        loadqn(rs(i))
        index_txt.Text = i.ToString
    End Sub

    Private Sub finish_btn_Click(sender As Object, e As EventArgs) Handles finish_btn.Click
        Try
            pre_btn.Visible = False
            next_btn.Visible = False
            finish_btn.Visible = False
            qns_txt.Visible = False
            c1_rbn.Visible = False
            c2_rbn.Visible = False
            c3_rbn.Visible = False
            c4_rbn.Visible = False
            start_lbl.Visible = True
            Dim c As Integer = 0
            For Each s As String In crctanslist.Text
                If s.Equals("1") Then
                    c += 1
                End If
            Next
            cn.Open()
            Dim count As String = "1"
            Dim cmd1 As New SqlCommand("select max(id)+1 as count from result;", cn)
            reader = cmd1.ExecuteReader
            While reader.Read
                count = reader.Item("count").ToString
            End While
            reader.Close()
            cn.Close()

            cn.Open()
            Dim cmd2 As New SqlCommand("insert into result values(@id,@name,@date,@time,@score,@cat);", cn)
            cmd2.Parameters.Clear()
            cmd2.Parameters.AddWithValue("@id", count.ToString)
            cmd2.Parameters.AddWithValue("@name", login.username_txt.Text)
            cmd2.Parameters.AddWithValue("@time", time_lbl.Text)
            cmd2.Parameters.AddWithValue("@score", (c * 10).ToString)
            cmd2.Parameters.AddWithValue("@date", Now.ToLocalTime.ToString)
            cmd2.Parameters.AddWithValue("@cat", ComboBox1.SelectedValue.ToString)
            cmd2.ExecuteNonQuery()
            cn.Close()
            MsgBox("Number of correct answers : " + c.ToString + Environment.NewLine + "Time taken : " + time_lbl.Text)
            Me.Dispose()
            stntaccnt.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Me.Dispose()

        End Try
    End Sub

    Private Sub c1_rbn_CheckedChanged(sender As Object, e As EventArgs) Handles c1_rbn.CheckedChanged

    End Sub
End Class