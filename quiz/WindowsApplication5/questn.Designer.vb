<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class questn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.timer_txt = New System.Windows.Forms.TextBox()
        Me.timer_lbl = New System.Windows.Forms.Label()
        Me.count_txt = New System.Windows.Forms.TextBox()
        Me.count_lbl = New System.Windows.Forms.Label()
        Me.submit_btn = New System.Windows.Forms.Button()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.previous_btn = New System.Windows.Forms.Button()
        Me.achck_chk = New System.Windows.Forms.CheckBox()
        Me.optiond_txt = New System.Windows.Forms.TextBox()
        Me.optionc_txt = New System.Windows.Forms.TextBox()
        Me.optionb_txt = New System.Windows.Forms.TextBox()
        Me.dcheck_chk = New System.Windows.Forms.CheckBox()
        Me.ccheck_chk = New System.Windows.Forms.CheckBox()
        Me.bcheck_chk = New System.Windows.Forms.CheckBox()
        Me.optna_txt = New System.Windows.Forms.TextBox()
        Me.questn_txt = New System.Windows.Forms.TextBox()
        Me.question_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.start_btn = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(1, 12)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(744, 505)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.timer_txt)
        Me.TabPage1.Controls.Add(Me.timer_lbl)
        Me.TabPage1.Controls.Add(Me.count_txt)
        Me.TabPage1.Controls.Add(Me.count_lbl)
        Me.TabPage1.Controls.Add(Me.submit_btn)
        Me.TabPage1.Controls.Add(Me.next_btn)
        Me.TabPage1.Controls.Add(Me.previous_btn)
        Me.TabPage1.Controls.Add(Me.achck_chk)
        Me.TabPage1.Controls.Add(Me.optiond_txt)
        Me.TabPage1.Controls.Add(Me.optionc_txt)
        Me.TabPage1.Controls.Add(Me.optionb_txt)
        Me.TabPage1.Controls.Add(Me.dcheck_chk)
        Me.TabPage1.Controls.Add(Me.ccheck_chk)
        Me.TabPage1.Controls.Add(Me.bcheck_chk)
        Me.TabPage1.Controls.Add(Me.optna_txt)
        Me.TabPage1.Controls.Add(Me.questn_txt)
        Me.TabPage1.Controls.Add(Me.question_lbl)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.start_btn)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(736, 479)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "CATEGORY"
        '
        'timer_txt
        '
        Me.timer_txt.Location = New System.Drawing.Point(345, 25)
        Me.timer_txt.Multiline = True
        Me.timer_txt.Name = "timer_txt"
        Me.timer_txt.Size = New System.Drawing.Size(78, 30)
        Me.timer_txt.TabIndex = 19
        '
        'timer_lbl
        '
        Me.timer_lbl.AutoSize = True
        Me.timer_lbl.Location = New System.Drawing.Point(298, 33)
        Me.timer_lbl.Name = "timer_lbl"
        Me.timer_lbl.Size = New System.Drawing.Size(41, 13)
        Me.timer_lbl.TabIndex = 18
        Me.timer_lbl.Text = "TIMER"
        '
        'count_txt
        '
        Me.count_txt.Location = New System.Drawing.Point(543, 25)
        Me.count_txt.Multiline = True
        Me.count_txt.Name = "count_txt"
        Me.count_txt.Size = New System.Drawing.Size(84, 30)
        Me.count_txt.TabIndex = 17
        '
        'count_lbl
        '
        Me.count_lbl.AutoSize = True
        Me.count_lbl.Location = New System.Drawing.Point(492, 33)
        Me.count_lbl.Name = "count_lbl"
        Me.count_lbl.Size = New System.Drawing.Size(45, 13)
        Me.count_lbl.TabIndex = 16
        Me.count_lbl.Text = "COUNT"
        '
        'submit_btn
        '
        Me.submit_btn.Location = New System.Drawing.Point(413, 383)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.Size = New System.Drawing.Size(75, 36)
        Me.submit_btn.TabIndex = 15
        Me.submit_btn.Text = "SUBMIT"
        Me.submit_btn.UseVisualStyleBackColor = True
        '
        'next_btn
        '
        Me.next_btn.Location = New System.Drawing.Point(301, 383)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(75, 36)
        Me.next_btn.TabIndex = 14
        Me.next_btn.Text = "NEXT"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'previous_btn
        '
        Me.previous_btn.Location = New System.Drawing.Point(197, 383)
        Me.previous_btn.Name = "previous_btn"
        Me.previous_btn.Size = New System.Drawing.Size(75, 36)
        Me.previous_btn.TabIndex = 13
        Me.previous_btn.Text = "PREVIOUS"
        Me.previous_btn.UseVisualStyleBackColor = True
        '
        'achck_chk
        '
        Me.achck_chk.AutoSize = True
        Me.achck_chk.Location = New System.Drawing.Point(158, 231)
        Me.achck_chk.Name = "achck_chk"
        Me.achck_chk.Size = New System.Drawing.Size(33, 17)
        Me.achck_chk.TabIndex = 12
        Me.achck_chk.Text = "A"
        Me.achck_chk.UseVisualStyleBackColor = True
        '
        'optiond_txt
        '
        Me.optiond_txt.Location = New System.Drawing.Point(427, 303)
        Me.optiond_txt.Name = "optiond_txt"
        Me.optiond_txt.Size = New System.Drawing.Size(122, 20)
        Me.optiond_txt.TabIndex = 11
        '
        'optionc_txt
        '
        Me.optionc_txt.Location = New System.Drawing.Point(197, 303)
        Me.optionc_txt.Name = "optionc_txt"
        Me.optionc_txt.Size = New System.Drawing.Size(100, 20)
        Me.optionc_txt.TabIndex = 10
        '
        'optionb_txt
        '
        Me.optionb_txt.Location = New System.Drawing.Point(427, 231)
        Me.optionb_txt.Name = "optionb_txt"
        Me.optionb_txt.Size = New System.Drawing.Size(122, 20)
        Me.optionb_txt.TabIndex = 9
        '
        'dcheck_chk
        '
        Me.dcheck_chk.AutoSize = True
        Me.dcheck_chk.Location = New System.Drawing.Point(375, 305)
        Me.dcheck_chk.Name = "dcheck_chk"
        Me.dcheck_chk.Size = New System.Drawing.Size(34, 17)
        Me.dcheck_chk.TabIndex = 8
        Me.dcheck_chk.Text = "D"
        Me.dcheck_chk.UseVisualStyleBackColor = True
        '
        'ccheck_chk
        '
        Me.ccheck_chk.AutoSize = True
        Me.ccheck_chk.Location = New System.Drawing.Point(158, 305)
        Me.ccheck_chk.Name = "ccheck_chk"
        Me.ccheck_chk.Size = New System.Drawing.Size(33, 17)
        Me.ccheck_chk.TabIndex = 7
        Me.ccheck_chk.Text = "C"
        Me.ccheck_chk.UseVisualStyleBackColor = True
        '
        'bcheck_chk
        '
        Me.bcheck_chk.AutoSize = True
        Me.bcheck_chk.Location = New System.Drawing.Point(375, 233)
        Me.bcheck_chk.Name = "bcheck_chk"
        Me.bcheck_chk.Size = New System.Drawing.Size(33, 17)
        Me.bcheck_chk.TabIndex = 6
        Me.bcheck_chk.Text = "B"
        Me.bcheck_chk.UseVisualStyleBackColor = True
        '
        'optna_txt
        '
        Me.optna_txt.Location = New System.Drawing.Point(197, 231)
        Me.optna_txt.Name = "optna_txt"
        Me.optna_txt.Size = New System.Drawing.Size(100, 20)
        Me.optna_txt.TabIndex = 5
        '
        'questn_txt
        '
        Me.questn_txt.Location = New System.Drawing.Point(158, 97)
        Me.questn_txt.Multiline = True
        Me.questn_txt.Name = "questn_txt"
        Me.questn_txt.Size = New System.Drawing.Size(422, 91)
        Me.questn_txt.TabIndex = 3
        '
        'question_lbl
        '
        Me.question_lbl.AutoSize = True
        Me.question_lbl.Location = New System.Drawing.Point(69, 133)
        Me.question_lbl.Name = "question_lbl"
        Me.question_lbl.Size = New System.Drawing.Size(63, 13)
        Me.question_lbl.TabIndex = 2
        Me.question_lbl.Text = "QUESTION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'start_btn
        '
        Me.start_btn.Location = New System.Drawing.Point(158, 25)
        Me.start_btn.Name = "start_btn"
        Me.start_btn.Size = New System.Drawing.Size(75, 43)
        Me.start_btn.TabIndex = 0
        Me.start_btn.Text = "START EXAM"
        Me.start_btn.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(736, 479)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "SCIENCE"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage10)
        Me.TabControl2.Controls.Add(Me.TabPage8)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage9)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Location = New System.Drawing.Point(-4, -46)
        Me.TabControl2.Multiline = True
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(744, 538)
        Me.TabControl2.TabIndex = 1
        '
        'TabPage10
        '
        Me.TabPage10.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage10.Controls.Add(Me.Label8)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage10.Size = New System.Drawing.Size(736, 512)
        Me.TabPage10.TabIndex = 0
        Me.TabPage10.Text = "CATEGORY"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 1
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(736, 479)
        Me.TabPage8.TabIndex = 1
        Me.TabPage8.Text = "SCIENCE"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(736, 479)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "SPORTS"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage9
        '
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(736, 479)
        Me.TabPage9.TabIndex = 3
        Me.TabPage9.Text = "APTITUDE"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(736, 479)
        Me.TabPage7.TabIndex = 4
        Me.TabPage7.Text = "GENERAL KNOWLEDGE"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(736, 479)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "SPORTS"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(736, 479)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "APTITUDE"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(736, 479)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "GENERAL KNOWLEDGE"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'questn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 536)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "questn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "START EXAM"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.TabPage10.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents start_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents optiond_txt As System.Windows.Forms.TextBox
    Friend WithEvents optionc_txt As System.Windows.Forms.TextBox
    Friend WithEvents optionb_txt As System.Windows.Forms.TextBox
    Friend WithEvents dcheck_chk As System.Windows.Forms.CheckBox
    Friend WithEvents ccheck_chk As System.Windows.Forms.CheckBox
    Friend WithEvents bcheck_chk As System.Windows.Forms.CheckBox
    Friend WithEvents optna_txt As System.Windows.Forms.TextBox
    Friend WithEvents questn_txt As System.Windows.Forms.TextBox
    Friend WithEvents question_lbl As System.Windows.Forms.Label
    Friend WithEvents achck_chk As System.Windows.Forms.CheckBox
    Friend WithEvents submit_btn As System.Windows.Forms.Button
    Friend WithEvents next_btn As System.Windows.Forms.Button
    Friend WithEvents previous_btn As System.Windows.Forms.Button
    Friend WithEvents count_txt As System.Windows.Forms.TextBox
    Friend WithEvents count_lbl As System.Windows.Forms.Label
    Friend WithEvents timer_txt As System.Windows.Forms.TextBox
    Friend WithEvents timer_lbl As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
End Class
