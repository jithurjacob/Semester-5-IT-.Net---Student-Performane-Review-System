<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminpage
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.category_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PwdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuizdbDataSet2 = New QuizApplication.quizdbDataSet2()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.changepwd_btn = New System.Windows.Forms.Button()
        Me.verify_txt = New System.Windows.Forms.TextBox()
        Me.vpwd_lbl = New System.Windows.Forms.Label()
        Me.newpwd_txt = New System.Windows.Forms.TextBox()
        Me.npwd_lbl = New System.Windows.Forms.Label()
        Me.cpwd_txt = New System.Windows.Forms.TextBox()
        Me.cpwd_lbl = New System.Windows.Forms.Label()
        Me.chngepwd_lbl = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.qns_txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.addqns_btn = New System.Windows.Forms.Button()
        Me.c4_txt = New System.Windows.Forms.TextBox()
        Me.c3_txt = New System.Windows.Forms.TextBox()
        Me.c2_txt = New System.Windows.Forms.TextBox()
        Me.c1_txt = New System.Windows.Forms.TextBox()
        Me.cans_txt = New System.Windows.Forms.TextBox()
        Me.category_cb = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuizdbDataSet4 = New QuizApplication.quizdbDataSet4()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategorynameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QnsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Choice1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Choice2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Choice3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Choice4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuestionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuizdbDataSet3 = New QuizApplication.quizdbDataSet3()
        Me.UsersTableAdapter = New QuizApplication.quizdbDataSet2TableAdapters.usersTableAdapter()
        Me.QuestionsTableAdapter = New QuizApplication.quizdbDataSet3TableAdapters.questionsTableAdapter()
        Me.CategoryTableAdapter = New QuizApplication.quizdbDataSet4TableAdapters.categoryTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizdbDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizdbDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuizdbDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(771, 475)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.category_name)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(763, 449)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ADD CATEGORY"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(427, 207)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "CANCEL"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(296, 207)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "ADD"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'category_name
        '
        Me.category_name.Location = New System.Drawing.Point(427, 131)
        Me.category_name.Name = "category_name"
        Me.category_name.Size = New System.Drawing.Size(100, 20)
        Me.category_name.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ENTER THE CATEGORY NAME"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(763, 449)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "STUDENT DETAILS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.MobnoDataGridViewTextBoxColumn, Me.EmailidDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PwdDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.UsersBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(3, 185)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(757, 261)
        Me.DataGridView1.TabIndex = 0
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        '
        'MobnoDataGridViewTextBoxColumn
        '
        Me.MobnoDataGridViewTextBoxColumn.DataPropertyName = "mobno"
        Me.MobnoDataGridViewTextBoxColumn.HeaderText = "mobno"
        Me.MobnoDataGridViewTextBoxColumn.Name = "MobnoDataGridViewTextBoxColumn"
        '
        'EmailidDataGridViewTextBoxColumn
        '
        Me.EmailidDataGridViewTextBoxColumn.DataPropertyName = "emailid"
        Me.EmailidDataGridViewTextBoxColumn.HeaderText = "emailid"
        Me.EmailidDataGridViewTextBoxColumn.Name = "EmailidDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PwdDataGridViewTextBoxColumn
        '
        Me.PwdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PwdDataGridViewTextBoxColumn.DataPropertyName = "pwd"
        Me.PwdDataGridViewTextBoxColumn.HeaderText = "pwd"
        Me.PwdDataGridViewTextBoxColumn.Name = "PwdDataGridViewTextBoxColumn"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "users"
        Me.UsersBindingSource.DataSource = Me.QuizdbDataSet2
        '
        'QuizdbDataSet2
        '
        Me.QuizdbDataSet2.DataSetName = "quizdbDataSet2"
        Me.QuizdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.changepwd_btn)
        Me.TabPage3.Controls.Add(Me.verify_txt)
        Me.TabPage3.Controls.Add(Me.vpwd_lbl)
        Me.TabPage3.Controls.Add(Me.newpwd_txt)
        Me.TabPage3.Controls.Add(Me.npwd_lbl)
        Me.TabPage3.Controls.Add(Me.cpwd_txt)
        Me.TabPage3.Controls.Add(Me.cpwd_lbl)
        Me.TabPage3.Controls.Add(Me.chngepwd_lbl)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(763, 449)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "OPTIONS"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(310, 249)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 36)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'changepwd_btn
        '
        Me.changepwd_btn.Location = New System.Drawing.Point(177, 249)
        Me.changepwd_btn.Name = "changepwd_btn"
        Me.changepwd_btn.Size = New System.Drawing.Size(96, 36)
        Me.changepwd_btn.TabIndex = 7
        Me.changepwd_btn.Text = "OK"
        Me.changepwd_btn.UseVisualStyleBackColor = True
        '
        'verify_txt
        '
        Me.verify_txt.Location = New System.Drawing.Point(310, 198)
        Me.verify_txt.Name = "verify_txt"
        Me.verify_txt.Size = New System.Drawing.Size(100, 20)
        Me.verify_txt.TabIndex = 6
        '
        'vpwd_lbl
        '
        Me.vpwd_lbl.AutoSize = True
        Me.vpwd_lbl.Location = New System.Drawing.Point(161, 201)
        Me.vpwd_lbl.Name = "vpwd_lbl"
        Me.vpwd_lbl.Size = New System.Drawing.Size(114, 13)
        Me.vpwd_lbl.TabIndex = 5
        Me.vpwd_lbl.Text = "VERIFY  PASSWORD"
        '
        'newpwd_txt
        '
        Me.newpwd_txt.Location = New System.Drawing.Point(310, 155)
        Me.newpwd_txt.Name = "newpwd_txt"
        Me.newpwd_txt.Size = New System.Drawing.Size(100, 20)
        Me.newpwd_txt.TabIndex = 4
        '
        'npwd_lbl
        '
        Me.npwd_lbl.AutoSize = True
        Me.npwd_lbl.Location = New System.Drawing.Point(161, 158)
        Me.npwd_lbl.Name = "npwd_lbl"
        Me.npwd_lbl.Size = New System.Drawing.Size(99, 13)
        Me.npwd_lbl.TabIndex = 3
        Me.npwd_lbl.Text = "NEW PASSWORD"
        '
        'cpwd_txt
        '
        Me.cpwd_txt.Location = New System.Drawing.Point(310, 115)
        Me.cpwd_txt.Name = "cpwd_txt"
        Me.cpwd_txt.Size = New System.Drawing.Size(100, 20)
        Me.cpwd_txt.TabIndex = 2
        '
        'cpwd_lbl
        '
        Me.cpwd_lbl.AutoSize = True
        Me.cpwd_lbl.Location = New System.Drawing.Point(158, 118)
        Me.cpwd_lbl.Name = "cpwd_lbl"
        Me.cpwd_lbl.Size = New System.Drawing.Size(129, 13)
        Me.cpwd_lbl.TabIndex = 1
        Me.cpwd_lbl.Text = "CURRENT  PASSWORD"
        '
        'chngepwd_lbl
        '
        Me.chngepwd_lbl.AutoSize = True
        Me.chngepwd_lbl.Location = New System.Drawing.Point(216, 53)
        Me.chngepwd_lbl.Name = "chngepwd_lbl"
        Me.chngepwd_lbl.Size = New System.Drawing.Size(118, 13)
        Me.chngepwd_lbl.TabIndex = 0
        Me.chngepwd_lbl.Text = "CHANGE PASSWORD"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.qns_txt)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.addqns_btn)
        Me.TabPage4.Controls.Add(Me.c4_txt)
        Me.TabPage4.Controls.Add(Me.c3_txt)
        Me.TabPage4.Controls.Add(Me.c2_txt)
        Me.TabPage4.Controls.Add(Me.c1_txt)
        Me.TabPage4.Controls.Add(Me.cans_txt)
        Me.TabPage4.Controls.Add(Me.category_cb)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Controls.Add(Me.Label1)
        Me.TabPage4.Controls.Add(Me.DataGridView2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(763, 449)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "QUESTIONS PORTAL"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'qns_txt
        '
        Me.qns_txt.Location = New System.Drawing.Point(287, 33)
        Me.qns_txt.Name = "qns_txt"
        Me.qns_txt.Size = New System.Drawing.Size(333, 20)
        Me.qns_txt.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(196, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Question :"
        '
        'addqns_btn
        '
        Me.addqns_btn.Location = New System.Drawing.Point(287, 213)
        Me.addqns_btn.Name = "addqns_btn"
        Me.addqns_btn.Size = New System.Drawing.Size(100, 23)
        Me.addqns_btn.TabIndex = 13
        Me.addqns_btn.Text = "Add question"
        Me.addqns_btn.UseVisualStyleBackColor = True
        '
        'c4_txt
        '
        Me.c4_txt.Location = New System.Drawing.Point(287, 174)
        Me.c4_txt.Name = "c4_txt"
        Me.c4_txt.Size = New System.Drawing.Size(333, 20)
        Me.c4_txt.TabIndex = 12
        '
        'c3_txt
        '
        Me.c3_txt.Location = New System.Drawing.Point(287, 145)
        Me.c3_txt.Name = "c3_txt"
        Me.c3_txt.Size = New System.Drawing.Size(333, 20)
        Me.c3_txt.TabIndex = 11
        '
        'c2_txt
        '
        Me.c2_txt.Location = New System.Drawing.Point(287, 115)
        Me.c2_txt.Name = "c2_txt"
        Me.c2_txt.Size = New System.Drawing.Size(333, 20)
        Me.c2_txt.TabIndex = 10
        '
        'c1_txt
        '
        Me.c1_txt.Location = New System.Drawing.Point(287, 85)
        Me.c1_txt.Name = "c1_txt"
        Me.c1_txt.Size = New System.Drawing.Size(333, 20)
        Me.c1_txt.TabIndex = 9
        '
        'cans_txt
        '
        Me.cans_txt.Location = New System.Drawing.Point(287, 59)
        Me.cans_txt.Name = "cans_txt"
        Me.cans_txt.Size = New System.Drawing.Size(333, 20)
        Me.cans_txt.TabIndex = 8
        '
        'category_cb
        '
        Me.category_cb.DataSource = Me.CategoryBindingSource
        Me.category_cb.DisplayMember = "name"
        Me.category_cb.FormattingEnabled = True
        Me.category_cb.Location = New System.Drawing.Point(287, 6)
        Me.category_cb.Name = "category_cb"
        Me.category_cb.Size = New System.Drawing.Size(187, 21)
        Me.category_cb.TabIndex = 7
        Me.category_cb.ValueMember = "name"
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "category"
        Me.CategoryBindingSource.DataSource = Me.QuizdbDataSet4
        '
        'QuizdbDataSet4
        '
        Me.QuizdbDataSet4.DataSetName = "quizdbDataSet4"
        Me.QuizdbDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(198, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Choice 4 :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(198, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Choice 3 :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(198, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Choice 2 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(198, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Choice 1 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(158, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Correct answer :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Category  : "
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.CategorynameDataGridViewTextBoxColumn, Me.QnsDataGridViewTextBoxColumn, Me.AnsDataGridViewTextBoxColumn, Me.Choice1DataGridViewTextBoxColumn, Me.Choice2DataGridViewTextBoxColumn, Me.Choice3DataGridViewTextBoxColumn, Me.Choice4DataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.QuestionsBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView2.Location = New System.Drawing.Point(3, 253)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(757, 193)
        Me.DataGridView2.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'CategorynameDataGridViewTextBoxColumn
        '
        Me.CategorynameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CategorynameDataGridViewTextBoxColumn.DataPropertyName = "categoryname"
        Me.CategorynameDataGridViewTextBoxColumn.HeaderText = "categoryname"
        Me.CategorynameDataGridViewTextBoxColumn.Name = "CategorynameDataGridViewTextBoxColumn"
        '
        'QnsDataGridViewTextBoxColumn
        '
        Me.QnsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.QnsDataGridViewTextBoxColumn.DataPropertyName = "qns"
        Me.QnsDataGridViewTextBoxColumn.HeaderText = "qns"
        Me.QnsDataGridViewTextBoxColumn.Name = "QnsDataGridViewTextBoxColumn"
        '
        'AnsDataGridViewTextBoxColumn
        '
        Me.AnsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.AnsDataGridViewTextBoxColumn.DataPropertyName = "ans"
        Me.AnsDataGridViewTextBoxColumn.HeaderText = "ans"
        Me.AnsDataGridViewTextBoxColumn.Name = "AnsDataGridViewTextBoxColumn"
        '
        'Choice1DataGridViewTextBoxColumn
        '
        Me.Choice1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Choice1DataGridViewTextBoxColumn.DataPropertyName = "choice1"
        Me.Choice1DataGridViewTextBoxColumn.HeaderText = "choice1"
        Me.Choice1DataGridViewTextBoxColumn.Name = "Choice1DataGridViewTextBoxColumn"
        '
        'Choice2DataGridViewTextBoxColumn
        '
        Me.Choice2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Choice2DataGridViewTextBoxColumn.DataPropertyName = "choice2"
        Me.Choice2DataGridViewTextBoxColumn.HeaderText = "choice2"
        Me.Choice2DataGridViewTextBoxColumn.Name = "Choice2DataGridViewTextBoxColumn"
        '
        'Choice3DataGridViewTextBoxColumn
        '
        Me.Choice3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Choice3DataGridViewTextBoxColumn.DataPropertyName = "choice3"
        Me.Choice3DataGridViewTextBoxColumn.HeaderText = "choice3"
        Me.Choice3DataGridViewTextBoxColumn.Name = "Choice3DataGridViewTextBoxColumn"
        '
        'Choice4DataGridViewTextBoxColumn
        '
        Me.Choice4DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Choice4DataGridViewTextBoxColumn.DataPropertyName = "choice4"
        Me.Choice4DataGridViewTextBoxColumn.HeaderText = "choice4"
        Me.Choice4DataGridViewTextBoxColumn.Name = "Choice4DataGridViewTextBoxColumn"
        '
        'QuestionsBindingSource
        '
        Me.QuestionsBindingSource.DataMember = "questions"
        Me.QuestionsBindingSource.DataSource = Me.QuizdbDataSet3
        '
        'QuizdbDataSet3
        '
        Me.QuizdbDataSet3.DataSetName = "quizdbDataSet3"
        Me.QuizdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'QuestionsTableAdapter
        '
        Me.QuestionsTableAdapter.ClearBeforeFill = True
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'adminpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 475)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "adminpage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMIN"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuizdbDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuizdbDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuizdbDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents category_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents changepwd_btn As System.Windows.Forms.Button
    Friend WithEvents verify_txt As System.Windows.Forms.TextBox
    Friend WithEvents vpwd_lbl As System.Windows.Forms.Label
    Friend WithEvents newpwd_txt As System.Windows.Forms.TextBox
    Friend WithEvents npwd_lbl As System.Windows.Forms.Label
    Friend WithEvents cpwd_txt As System.Windows.Forms.TextBox
    Friend WithEvents cpwd_lbl As System.Windows.Forms.Label
    Friend WithEvents chngepwd_lbl As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents QuizdbDataSet2 As QuizApplication.quizdbDataSet2
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsersTableAdapter As QuizApplication.quizdbDataSet2TableAdapters.usersTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PwdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents QuizdbDataSet3 As QuizApplication.quizdbDataSet3
    Friend WithEvents QuestionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents QuestionsTableAdapter As QuizApplication.quizdbDataSet3TableAdapters.questionsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategorynameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QnsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Choice1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Choice2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Choice3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Choice4DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents category_cb As System.Windows.Forms.ComboBox
    Friend WithEvents QuizdbDataSet4 As QuizApplication.quizdbDataSet4
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoryTableAdapter As QuizApplication.quizdbDataSet4TableAdapters.categoryTableAdapter
    Friend WithEvents c4_txt As System.Windows.Forms.TextBox
    Friend WithEvents c3_txt As System.Windows.Forms.TextBox
    Friend WithEvents c2_txt As System.Windows.Forms.TextBox
    Friend WithEvents c1_txt As System.Windows.Forms.TextBox
    Friend WithEvents cans_txt As System.Windows.Forms.TextBox
    Friend WithEvents addqns_btn As System.Windows.Forms.Button
    Friend WithEvents qns_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
