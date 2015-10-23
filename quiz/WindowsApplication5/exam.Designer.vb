<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class exam
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuizdbDataSet4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuizdbDataSet4 = New QuizApplication.quizdbDataSet4()
        Me.CategoryTableAdapter = New QuizApplication.quizdbDataSet4TableAdapters.categoryTableAdapter()
        Me.start_lbl = New System.Windows.Forms.Label()
        Me.qnslist = New System.Windows.Forms.Label()
        Me.time_lbl = New System.Windows.Forms.Label()
        Me.finish_btn = New System.Windows.Forms.Label()
        Me.pre_btn = New System.Windows.Forms.Label()
        Me.next_btn = New System.Windows.Forms.Label()
        Me.index_txt = New System.Windows.Forms.Label()
        Me.choices_txt = New System.Windows.Forms.Label()
        Me.qns_txt = New System.Windows.Forms.Label()
        Me.c1_rbn = New System.Windows.Forms.RadioButton()
        Me.c2_rbn = New System.Windows.Forms.RadioButton()
        Me.c3_rbn = New System.Windows.Forms.RadioButton()
        Me.c4_rbn = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cans_txt = New System.Windows.Forms.Label()
        Me.qnsset = New System.Windows.Forms.Label()
        Me.crctanslist = New System.Windows.Forms.Label()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizdbDataSet4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizdbDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose category : "
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CategoryBindingSource
        Me.ComboBox1.DisplayMember = "name"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(181, 35)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(207, 27)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "name"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "category"
        Me.CategoryBindingSource.DataSource = Me.QuizdbDataSet4BindingSource
        '
        'QuizdbDataSet4BindingSource
        '
        Me.QuizdbDataSet4BindingSource.DataSource = Me.QuizdbDataSet4
        Me.QuizdbDataSet4BindingSource.Position = 0
        '
        'QuizdbDataSet4
        '
        Me.QuizdbDataSet4.DataSetName = "quizdbDataSet4"
        Me.QuizdbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'start_lbl
        '
        Me.start_lbl.AutoSize = True
        Me.start_lbl.Location = New System.Drawing.Point(458, 38)
        Me.start_lbl.Name = "start_lbl"
        Me.start_lbl.Size = New System.Drawing.Size(38, 19)
        Me.start_lbl.TabIndex = 2
        Me.start_lbl.Text = "Start"
        '
        'qnslist
        '
        Me.qnslist.AutoSize = True
        Me.qnslist.Location = New System.Drawing.Point(56, 91)
        Me.qnslist.Name = "qnslist"
        Me.qnslist.Size = New System.Drawing.Size(48, 19)
        Me.qnslist.TabIndex = 3
        Me.qnslist.Text = "qnslist"
        Me.qnslist.Visible = False
        '
        'time_lbl
        '
        Me.time_lbl.AutoSize = True
        Me.time_lbl.Location = New System.Drawing.Point(181, 91)
        Me.time_lbl.Name = "time_lbl"
        Me.time_lbl.Size = New System.Drawing.Size(0, 19)
        Me.time_lbl.TabIndex = 4
        '
        'finish_btn
        '
        Me.finish_btn.AutoSize = True
        Me.finish_btn.Location = New System.Drawing.Point(244, 433)
        Me.finish_btn.Name = "finish_btn"
        Me.finish_btn.Size = New System.Drawing.Size(73, 19)
        Me.finish_btn.TabIndex = 5
        Me.finish_btn.Text = "Finish Test"
        Me.finish_btn.Visible = False
        '
        'pre_btn
        '
        Me.pre_btn.AutoSize = True
        Me.pre_btn.Location = New System.Drawing.Point(77, 433)
        Me.pre_btn.Name = "pre_btn"
        Me.pre_btn.Size = New System.Drawing.Size(118, 19)
        Me.pre_btn.TabIndex = 6
        Me.pre_btn.Text = "Previous question"
        Me.pre_btn.Visible = False
        '
        'next_btn
        '
        Me.next_btn.AutoSize = True
        Me.next_btn.Location = New System.Drawing.Point(415, 433)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(94, 19)
        Me.next_btn.TabIndex = 7
        Me.next_btn.Text = "Next question"
        Me.next_btn.Visible = False
        '
        'index_txt
        '
        Me.index_txt.AutoSize = True
        Me.index_txt.Location = New System.Drawing.Point(56, 110)
        Me.index_txt.Name = "index_txt"
        Me.index_txt.Size = New System.Drawing.Size(41, 19)
        Me.index_txt.TabIndex = 8
        Me.index_txt.Text = "index"
        Me.index_txt.Visible = False
        '
        'choices_txt
        '
        Me.choices_txt.AutoSize = True
        Me.choices_txt.Location = New System.Drawing.Point(60, 133)
        Me.choices_txt.Name = "choices_txt"
        Me.choices_txt.Size = New System.Drawing.Size(61, 19)
        Me.choices_txt.TabIndex = 9
        Me.choices_txt.Text = "0,0,0,0,0"
        Me.choices_txt.Visible = False
        '
        'qns_txt
        '
        Me.qns_txt.AutoSize = True
        Me.qns_txt.Location = New System.Drawing.Point(224, 177)
        Me.qns_txt.Name = "qns_txt"
        Me.qns_txt.Size = New System.Drawing.Size(49, 19)
        Me.qns_txt.TabIndex = 10
        Me.qns_txt.Text = "Label3"
        Me.qns_txt.Visible = False
        '
        'c1_rbn
        '
        Me.c1_rbn.AutoSize = True
        Me.c1_rbn.Location = New System.Drawing.Point(64, 236)
        Me.c1_rbn.Name = "c1_rbn"
        Me.c1_rbn.Size = New System.Drawing.Size(111, 23)
        Me.c1_rbn.TabIndex = 11
        Me.c1_rbn.TabStop = True
        Me.c1_rbn.Text = "RadioButton1"
        Me.c1_rbn.UseVisualStyleBackColor = True
        Me.c1_rbn.Visible = False
        '
        'c2_rbn
        '
        Me.c2_rbn.AutoSize = True
        Me.c2_rbn.Location = New System.Drawing.Point(64, 265)
        Me.c2_rbn.Name = "c2_rbn"
        Me.c2_rbn.Size = New System.Drawing.Size(111, 23)
        Me.c2_rbn.TabIndex = 12
        Me.c2_rbn.TabStop = True
        Me.c2_rbn.Text = "RadioButton2"
        Me.c2_rbn.UseVisualStyleBackColor = True
        Me.c2_rbn.Visible = False
        '
        'c3_rbn
        '
        Me.c3_rbn.AutoSize = True
        Me.c3_rbn.Location = New System.Drawing.Point(64, 295)
        Me.c3_rbn.Name = "c3_rbn"
        Me.c3_rbn.Size = New System.Drawing.Size(111, 23)
        Me.c3_rbn.TabIndex = 13
        Me.c3_rbn.TabStop = True
        Me.c3_rbn.Text = "RadioButton3"
        Me.c3_rbn.UseVisualStyleBackColor = True
        Me.c3_rbn.Visible = False
        '
        'c4_rbn
        '
        Me.c4_rbn.AutoSize = True
        Me.c4_rbn.Location = New System.Drawing.Point(64, 325)
        Me.c4_rbn.Name = "c4_rbn"
        Me.c4_rbn.Size = New System.Drawing.Size(111, 23)
        Me.c4_rbn.TabIndex = 14
        Me.c4_rbn.TabStop = True
        Me.c4_rbn.Text = "RadioButton4"
        Me.c4_rbn.UseVisualStyleBackColor = True
        Me.c4_rbn.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'cans_txt
        '
        Me.cans_txt.AutoSize = True
        Me.cans_txt.Location = New System.Drawing.Point(56, 156)
        Me.cans_txt.Name = "cans_txt"
        Me.cans_txt.Size = New System.Drawing.Size(52, 19)
        Me.cans_txt.TabIndex = 15
        Me.cans_txt.Text = "crctans"
        Me.cans_txt.Visible = False
        '
        'qnsset
        '
        Me.qnsset.AutoSize = True
        Me.qnsset.Location = New System.Drawing.Point(64, 75)
        Me.qnsset.Name = "qnsset"
        Me.qnsset.Size = New System.Drawing.Size(49, 19)
        Me.qnsset.TabIndex = 16
        Me.qnsset.Text = "qnsset"
        Me.qnsset.Visible = False
        '
        'crctanslist
        '
        Me.crctanslist.AutoSize = True
        Me.crctanslist.Location = New System.Drawing.Point(60, 182)
        Me.crctanslist.Name = "crctanslist"
        Me.crctanslist.Size = New System.Drawing.Size(69, 19)
        Me.crctanslist.TabIndex = 17
        Me.crctanslist.Text = "crctanslist"
        Me.crctanslist.Visible = False
        '
        'exam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(587, 461)
        Me.Controls.Add(Me.crctanslist)
        Me.Controls.Add(Me.qnsset)
        Me.Controls.Add(Me.cans_txt)
        Me.Controls.Add(Me.c4_rbn)
        Me.Controls.Add(Me.c3_rbn)
        Me.Controls.Add(Me.c2_rbn)
        Me.Controls.Add(Me.c1_rbn)
        Me.Controls.Add(Me.qns_txt)
        Me.Controls.Add(Me.choices_txt)
        Me.Controls.Add(Me.index_txt)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.pre_btn)
        Me.Controls.Add(Me.finish_btn)
        Me.Controls.Add(Me.time_lbl)
        Me.Controls.Add(Me.qnslist)
        Me.Controls.Add(Me.start_lbl)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(603, 500)
        Me.MinimumSize = New System.Drawing.Size(603, 500)
        Me.Name = "exam"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "exam"
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuizdbDataSet4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuizdbDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents QuizdbDataSet4 As QuizApplication.quizdbDataSet4
    Friend WithEvents QuizdbDataSet4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As QuizApplication.quizdbDataSet4TableAdapters.categoryTableAdapter
    Friend WithEvents start_lbl As System.Windows.Forms.Label
    Friend WithEvents qnslist As System.Windows.Forms.Label
    Friend WithEvents time_lbl As System.Windows.Forms.Label
    Friend WithEvents finish_btn As System.Windows.Forms.Label
    Friend WithEvents pre_btn As System.Windows.Forms.Label
    Friend WithEvents next_btn As System.Windows.Forms.Label
    Friend WithEvents index_txt As System.Windows.Forms.Label
    Friend WithEvents choices_txt As System.Windows.Forms.Label
    Friend WithEvents qns_txt As System.Windows.Forms.Label
    Friend WithEvents c1_rbn As System.Windows.Forms.RadioButton
    Friend WithEvents c2_rbn As System.Windows.Forms.RadioButton
    Friend WithEvents c3_rbn As System.Windows.Forms.RadioButton
    Friend WithEvents c4_rbn As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cans_txt As System.Windows.Forms.Label
    Friend WithEvents qnsset As System.Windows.Forms.Label
    Friend WithEvents crctanslist As System.Windows.Forms.Label
End Class
