namespace DepartmentSystemClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DGWStudentList = new System.Windows.Forms.DataGridView();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.txtAddStudentNo = new System.Windows.Forms.TextBox();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxPutDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxSearchGraduate = new System.Windows.Forms.ComboBox();
            this.comboBoxPutGraduate = new System.Windows.Forms.ComboBox();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.comboBoxSearchGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.comboBoxPutGender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DGWStudentList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGWStudentList
            // 
            this.DGWStudentList.AllowUserToAddRows = false;
            this.DGWStudentList.AllowUserToDeleteRows = false;
            this.DGWStudentList.AllowUserToResizeColumns = false;
            this.DGWStudentList.AllowUserToResizeRows = false;
            this.DGWStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGWStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DGWStudentList, 6);
            this.DGWStudentList.Location = new System.Drawing.Point(3, 60);
            this.DGWStudentList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGWStudentList.Name = "DGWStudentList";
            this.DGWStudentList.ReadOnly = true;
            this.DGWStudentList.RowHeadersWidth = 51;
            this.DGWStudentList.RowTemplate.Height = 29;
            this.DGWStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGWStudentList.Size = new System.Drawing.Size(721, 181);
            this.DGWStudentList.TabIndex = 0;
            this.DGWStudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGWStudentList_CellContentClick);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(624, 300);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(82, 22);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // txtAddStudentNo
            // 
            this.txtAddStudentNo.Location = new System.Drawing.Point(3, 300);
            this.txtAddStudentNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddStudentNo.Name = "txtAddStudentNo";
            this.txtAddStudentNo.Size = new System.Drawing.Size(110, 23);
            this.txtAddStudentNo.TabIndex = 3;
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(123, 300);
            this.txtAddName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(110, 23);
            this.txtAddName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Graduate Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Department Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Student No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Student No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Department Id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(363, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Graduate Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(123, 27);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(110, 23);
            this.txtSearchName.TabIndex = 13;
            // 
            // txtSearchId
            // 
            this.txtSearchId.Location = new System.Drawing.Point(3, 27);
            this.txtSearchId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(110, 23);
            this.txtSearchId.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(624, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 22);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(243, 27);
            this.comboBoxDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(110, 23);
            this.comboBoxDepartment.TabIndex = 20;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxPutDepartment
            // 
            this.comboBoxPutDepartment.FormattingEnabled = true;
            this.comboBoxPutDepartment.Location = new System.Drawing.Point(243, 300);
            this.comboBoxPutDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPutDepartment.Name = "comboBoxPutDepartment";
            this.comboBoxPutDepartment.Size = new System.Drawing.Size(110, 23);
            this.comboBoxPutDepartment.TabIndex = 21;
            // 
            // comboBoxSearchGraduate
            // 
            this.comboBoxSearchGraduate.FormattingEnabled = true;
            this.comboBoxSearchGraduate.Location = new System.Drawing.Point(363, 27);
            this.comboBoxSearchGraduate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSearchGraduate.Name = "comboBoxSearchGraduate";
            this.comboBoxSearchGraduate.Size = new System.Drawing.Size(110, 23);
            this.comboBoxSearchGraduate.TabIndex = 22;
            this.comboBoxSearchGraduate.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchGraduate_SelectedIndexChanged);
            // 
            // comboBoxPutGraduate
            // 
            this.comboBoxPutGraduate.FormattingEnabled = true;
            this.comboBoxPutGraduate.Location = new System.Drawing.Point(363, 300);
            this.comboBoxPutGraduate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPutGraduate.Name = "comboBoxPutGraduate";
            this.comboBoxPutGraduate.Size = new System.Drawing.Size(110, 23);
            this.comboBoxPutGraduate.TabIndex = 23;
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(624, 335);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(82, 22);
            this.btnDeleteStudent.TabIndex = 24;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Location = new System.Drawing.Point(3, 245);
            this.btnNewStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(82, 22);
            this.btnNewStudent.TabIndex = 25;
            this.btnNewStudent.Text = "New Student";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // comboBoxSearchGender
            // 
            this.comboBoxSearchGender.FormattingEnabled = true;
            this.comboBoxSearchGender.Location = new System.Drawing.Point(483, 27);
            this.comboBoxSearchGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSearchGender.Name = "comboBoxSearchGender";
            this.comboBoxSearchGender.Size = new System.Drawing.Size(110, 23);
            this.comboBoxSearchGender.TabIndex = 26;
            this.comboBoxSearchGender.SelectedIndexChanged += new System.EventHandler(this.comboBoxSearchGender_SelectedIndexChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(483, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 15);
            this.lblGender.TabIndex = 27;
            this.lblGender.Text = "Gender";
            // 
            // comboBoxPutGender
            // 
            this.comboBoxPutGender.FormattingEnabled = true;
            this.comboBoxPutGender.Location = new System.Drawing.Point(483, 300);
            this.comboBoxPutGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPutGender.Name = "comboBoxPutGender";
            this.comboBoxPutGender.Size = new System.Drawing.Size(110, 23);
            this.comboBoxPutGender.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Gender";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.50619F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.50619F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58477F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.58477F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.41032F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.25061F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteStudent, 5, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPutGender, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSearchId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPutGraduate, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPutDepartment, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnNewStudent, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtAddName, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSearchGender, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAddStudentNo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblGender, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddStudent, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtSearchName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxDepartment, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxSearchGraduate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.DGWStudentList, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(150, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.775068F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.943089F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.32249F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.943089F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.962059F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.485095F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.2981F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(727, 375);
            this.tableLayoutPanel1.TabIndex = 30;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(57)))), ((int)(((byte)(113)))));
            this.btnSignOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(3, 3);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(138, 34);
            this.btnSignOut.TabIndex = 30;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(227)))), ((int)(((byte)(250)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 402);
            this.panel1.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Location = new System.Drawing.Point(62, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Developed By";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Right;
            this.label11.Location = new System.Drawing.Point(46, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "Emirhan Aydınat";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 364);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.86047F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.13953F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(144, 38);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnSignOut, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(144, 40);
            this.tableLayoutPanel3.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWStudentList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DGWStudentList;
        private Button btnAddStudent;
        private TextBox txtAddStudentNo;
        private TextBox txtAddName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtSearchName;
        private TextBox txtSearchId;
        private Button btnSearch;
        private ComboBox comboBoxDepartment;
        private ComboBox comboBoxPutDepartment;
        private ComboBox comboBoxSearchGraduate;
        private ComboBox comboBoxPutGraduate;
        private Button btnDeleteStudent;
        private Button btnNewStudent;
        private ComboBox comboBoxSearchGender;
        private Label lblGender;
        private ComboBox comboBoxPutGender;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSignOut;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label10;
        private Label label11;
    }
}