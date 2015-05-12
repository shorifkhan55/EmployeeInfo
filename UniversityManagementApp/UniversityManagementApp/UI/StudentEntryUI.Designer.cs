namespace UniversityManagementApp
{
    partial class StudentEntryUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.studentsListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deleteButton = new System.Windows.Forms.Button();
            this.regNoSearchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameSearchTextBox = new System.Windows.Forms.TextBox();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(81, 92);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(359, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Location = new System.Drawing.Point(81, 131);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(359, 20);
            this.regNoTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reg No";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(81, 168);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(359, 85);
            this.addressTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(279, 259);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // studentsListView
            // 
            this.studentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5});
            this.studentsListView.FullRowSelect = true;
            this.studentsListView.GridLines = true;
            this.studentsListView.Location = new System.Drawing.Point(484, 127);
            this.studentsListView.Name = "studentsListView";
            this.studentsListView.Size = new System.Drawing.Size(506, 154);
            this.studentsListView.TabIndex = 7;
            this.studentsListView.UseCompatibleStateImageBehavior = false;
            this.studentsListView.View = System.Windows.Forms.View.Details;
            this.studentsListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.studentsListView.DoubleClick += new System.EventHandler(this.studentsListView_DoubleClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Id";
            this.columnHeader4.Width = 54;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 124;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "RegNo";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Address";
            this.columnHeader3.Width = 126;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(365, 259);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // regNoSearchTextBox
            // 
            this.regNoSearchTextBox.Location = new System.Drawing.Point(615, 52);
            this.regNoSearchTextBox.Name = "regNoSearchTextBox";
            this.regNoSearchTextBox.Size = new System.Drawing.Size(213, 20);
            this.regNoSearchTextBox.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(756, 76);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Reg No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name";
            // 
            // nameSearchTextBox
            // 
            this.nameSearchTextBox.Location = new System.Drawing.Point(614, 26);
            this.nameSearchTextBox.Name = "nameSearchTextBox";
            this.nameSearchTextBox.Size = new System.Drawing.Size(213, 20);
            this.nameSearchTextBox.TabIndex = 12;
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Location = new System.Drawing.Point(108, 35);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(312, 21);
            this.departmentComboBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Department";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dept Name";
            this.columnHeader5.Width = 98;
            // 
            // StudentEntryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 432);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.departmentComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nameSearchTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.regNoSearchTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.studentsListView);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regNoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "StudentEntryUI";
            this.Text = "Student Entry ";
            this.Load += new System.EventHandler(this.StudentEntryUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListView studentsListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox regNoSearchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameSearchTextBox;
        private System.Windows.Forms.ComboBox departmentComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

