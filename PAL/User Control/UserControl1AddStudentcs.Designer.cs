namespace Final_Project.PAL.User_Control
{
    partial class UserControl1AddStudentcs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlAddStudent = new TabControl();
            tabPageAddStudent = new TabPage();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            comboBoxClass = new ComboBox();
            buttonAdd = new Button();
            panel3 = new Panel();
            label5 = new Label();
            textBoxMale = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            textBoxRegNo = new TextBox();
            panel1 = new Panel();
            label3 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchStudent = new TabPage();
            comboBox1 = new ComboBox();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label9 = new Label();
            labelCountStudent = new Label();
            label8 = new Label();
            dataGridViewStudent = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            textBoxSearch = new TextBox();
            pictureBoxSearch = new PictureBox();
            panel5 = new Panel();
            label6 = new Label();
            label7 = new Label();
            tabPageUPStudent = new TabPage();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            comboBox2 = new ComboBox();
            panel6 = new Panel();
            label10 = new Label();
            textBox2 = new TextBox();
            label11 = new Label();
            panel7 = new Panel();
            textBox3 = new TextBox();
            panel8 = new Panel();
            label12 = new Label();
            textBox4 = new TextBox();
            label13 = new Label();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            label14 = new Label();
            tabControlAddStudent.SuspendLayout();
            tabPageAddStudent.SuspendLayout();
            tabPageSearchStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            tabPageUPStudent.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlAddStudent
            // 
            tabControlAddStudent.Alignment = TabAlignment.Bottom;
            tabControlAddStudent.Anchor = AnchorStyles.None;
            tabControlAddStudent.Controls.Add(tabPageAddStudent);
            tabControlAddStudent.Controls.Add(tabPageSearchStudent);
            tabControlAddStudent.Controls.Add(tabPageUPStudent);
            tabControlAddStudent.Location = new Point(3, 0);
            tabControlAddStudent.Name = "tabControlAddStudent";
            tabControlAddStudent.SelectedIndex = 0;
            tabControlAddStudent.Size = new Size(942, 501);
            tabControlAddStudent.TabIndex = 1;
            // 
            // tabPageAddStudent
            // 
            tabPageAddStudent.BackColor = Color.White;
            tabPageAddStudent.Controls.Add(radioButtonFemale);
            tabPageAddStudent.Controls.Add(radioButtonMale);
            tabPageAddStudent.Controls.Add(comboBoxClass);
            tabPageAddStudent.Controls.Add(buttonAdd);
            tabPageAddStudent.Controls.Add(panel3);
            tabPageAddStudent.Controls.Add(label5);
            tabPageAddStudent.Controls.Add(textBoxMale);
            tabPageAddStudent.Controls.Add(label4);
            tabPageAddStudent.Controls.Add(panel2);
            tabPageAddStudent.Controls.Add(textBoxRegNo);
            tabPageAddStudent.Controls.Add(panel1);
            tabPageAddStudent.Controls.Add(label3);
            tabPageAddStudent.Controls.Add(textBoxName);
            tabPageAddStudent.Controls.Add(label2);
            tabPageAddStudent.Controls.Add(label1);
            tabPageAddStudent.Location = new Point(4, 4);
            tabPageAddStudent.Name = "tabPageAddStudent";
            tabPageAddStudent.Padding = new Padding(3);
            tabPageAddStudent.Size = new Size(934, 467);
            tabPageAddStudent.TabIndex = 0;
            tabPageAddStudent.Text = " Add Student";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Century Gothic", 10F);
            radioButtonFemale.Location = new Point(635, 246);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(91, 25);
            radioButtonFemale.TabIndex = 16;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Century Gothic", 10F);
            radioButtonMale.Location = new Point(635, 215);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(74, 25);
            radioButtonMale.TabIndex = 15;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.Flat;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Items.AddRange(new object[] { "-- SELECT --" });
            comboBoxClass.Location = new Point(112, 215);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(273, 29);
            comboBoxClass.TabIndex = 14;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Maroon;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(115, 291);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(114, 37);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(115, 244);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 2);
            panel3.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label5.Location = new Point(553, 229);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 10;
            label5.Text = "Gender:";
            // 
            // textBoxMale
            // 
            textBoxMale.BorderStyle = BorderStyle.None;
            textBoxMale.Font = new Font("Century Gothic", 10F);
            textBoxMale.Location = new Point(115, 220);
            textBoxMale.Name = "textBoxMale";
            textBoxMale.Size = new Size(270, 21);
            textBoxMale.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label4.Location = new Point(115, 193);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 7;
            label4.Text = "Male:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(553, 175);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 6;
            // 
            // textBoxRegNo
            // 
            textBoxRegNo.BorderStyle = BorderStyle.None;
            textBoxRegNo.Font = new Font("Century Gothic", 10F);
            textBoxRegNo.Location = new Point(553, 151);
            textBoxRegNo.Name = "textBoxRegNo";
            textBoxRegNo.Size = new Size(270, 21);
            textBoxRegNo.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(115, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.Location = new Point(556, 125);
            label3.Name = "label3";
            label3.Size = new Size(75, 19);
            label3.TabIndex = 4;
            label3.Text = "Reg No:";
            // 
            // textBoxName
            // 
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Century Gothic", 10F);
            textBoxName.Location = new Point(115, 151);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(270, 21);
            textBoxName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(115, 125);
            label2.Name = "label2";
            label2.Size = new Size(65, 19);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 0;
            label1.Text = "Add Student:";
            // 
            // tabPageSearchStudent
            // 
            tabPageSearchStudent.Controls.Add(comboBox1);
            tabPageSearchStudent.Controls.Add(panel4);
            tabPageSearchStudent.Controls.Add(textBox1);
            tabPageSearchStudent.Controls.Add(label9);
            tabPageSearchStudent.Controls.Add(labelCountStudent);
            tabPageSearchStudent.Controls.Add(label8);
            tabPageSearchStudent.Controls.Add(dataGridViewStudent);
            tabPageSearchStudent.Controls.Add(textBoxSearch);
            tabPageSearchStudent.Controls.Add(pictureBoxSearch);
            tabPageSearchStudent.Controls.Add(panel5);
            tabPageSearchStudent.Controls.Add(label6);
            tabPageSearchStudent.Controls.Add(label7);
            tabPageSearchStudent.Location = new Point(4, 4);
            tabPageSearchStudent.Name = "tabPageSearchStudent";
            tabPageSearchStudent.Padding = new Padding(3);
            tabPageSearchStudent.Size = new Size(934, 468);
            tabPageSearchStudent.TabIndex = 1;
            tabPageSearchStudent.Text = "Search Student";
            tabPageSearchStudent.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "-- SELECT --", "Name", "Reg No.", "Class" });
            comboBox1.Location = new Point(619, 60);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 29);
            comboBox1.TabIndex = 18;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Location = new Point(619, 93);
            panel4.Name = "panel4";
            panel4.Size = new Size(186, 2);
            panel4.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 10F);
            textBox1.Location = new Point(619, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 21);
            textBox1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label9.Location = new Point(619, 36);
            label9.Name = "label9";
            label9.Size = new Size(96, 19);
            label9.TabIndex = 15;
            label9.Text = "Search By:";
            // 
            // labelCountStudent
            // 
            labelCountStudent.AutoSize = true;
            labelCountStudent.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCountStudent.Location = new Point(822, 446);
            labelCountStudent.Name = "labelCountStudent";
            labelCountStudent.Size = new Size(33, 21);
            labelCountStudent.TabIndex = 11;
            labelCountStudent.Text = "{?}";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label8.Location = new Point(686, 448);
            label8.Name = "label8";
            label8.Size = new Size(119, 19);
            label8.TabIndex = 10;
            label8.Text = "Total Classes:";
            // 
            // dataGridViewStudent
            // 
            dataGridViewStudent.AllowUserToAddRows = false;
            dataGridViewStudent.AllowUserToDeleteRows = false;
            dataGridViewStudent.AllowUserToResizeColumns = false;
            dataGridViewStudent.AllowUserToResizeRows = false;
            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudent.BackgroundColor = Color.White;
            dataGridViewStudent.BorderStyle = BorderStyle.None;
            dataGridViewStudent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudent.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewStudent.Location = new Point(15, 112);
            dataGridViewStudent.Name = "dataGridViewStudent";
            dataGridViewStudent.ReadOnly = true;
            dataGridViewStudent.RowHeadersWidth = 51;
            dataGridViewStudent.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewStudent.ShowCellErrors = false;
            dataGridViewStudent.ShowEditingIcon = false;
            dataGridViewStudent.ShowRowErrors = false;
            dataGridViewStudent.Size = new Size(900, 328);
            dataGridViewStudent.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Reg No.";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Class";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "Gender";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Century Gothic", 10F);
            textBoxSearch.Location = new Point(154, 68);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(225, 21);
            textBoxSearch.TabIndex = 6;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Cursor = Cursors.Hand;
            pictureBoxSearch.Image = Properties.Resources.search__1_;
            pictureBoxSearch.Location = new Point(405, 63);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(19, 26);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 8;
            pictureBoxSearch.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Location = new Point(151, 93);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 2);
            panel5.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label6.Location = new Point(154, 47);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 5;
            label6.Text = "Search:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(3, 3);
            label7.Name = "label7";
            label7.Size = new Size(161, 23);
            label7.TabIndex = 4;
            label7.Text = "Search Student:";
            // 
            // tabPageUPStudent
            // 
            tabPageUPStudent.Controls.Add(radioButton1);
            tabPageUPStudent.Controls.Add(radioButton2);
            tabPageUPStudent.Controls.Add(comboBox2);
            tabPageUPStudent.Controls.Add(panel6);
            tabPageUPStudent.Controls.Add(label10);
            tabPageUPStudent.Controls.Add(textBox2);
            tabPageUPStudent.Controls.Add(label11);
            tabPageUPStudent.Controls.Add(panel7);
            tabPageUPStudent.Controls.Add(textBox3);
            tabPageUPStudent.Controls.Add(panel8);
            tabPageUPStudent.Controls.Add(label12);
            tabPageUPStudent.Controls.Add(textBox4);
            tabPageUPStudent.Controls.Add(label13);
            tabPageUPStudent.Controls.Add(buttonDelete);
            tabPageUPStudent.Controls.Add(buttonUpdate);
            tabPageUPStudent.Controls.Add(label14);
            tabPageUPStudent.Location = new Point(4, 4);
            tabPageUPStudent.Name = "tabPageUPStudent";
            tabPageUPStudent.Padding = new Padding(3);
            tabPageUPStudent.Size = new Size(934, 468);
            tabPageUPStudent.TabIndex = 2;
            tabPageUPStudent.Text = "Update and Delete Student";
            tabPageUPStudent.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Century Gothic", 10F);
            radioButton1.Location = new Point(632, 243);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(91, 25);
            radioButton1.TabIndex = 42;
            radioButton1.TabStop = true;
            radioButton1.Text = "Female";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Century Gothic", 10F);
            radioButton2.Location = new Point(632, 212);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(74, 25);
            radioButton2.TabIndex = 41;
            radioButton2.TabStop = true;
            radioButton2.Text = "Male";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "-- SELECT --" });
            comboBox2.Location = new Point(109, 212);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(273, 29);
            comboBox2.TabIndex = 40;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Location = new Point(112, 241);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label10.Location = new Point(550, 226);
            label10.Name = "label10";
            label10.Size = new Size(76, 19);
            label10.TabIndex = 39;
            label10.Text = "Gender:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 10F);
            textBox2.Location = new Point(112, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 21);
            textBox2.TabIndex = 37;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label11.Location = new Point(112, 190);
            label11.Name = "label11";
            label11.Size = new Size(55, 19);
            label11.TabIndex = 36;
            label11.Text = "Male:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightGray;
            panel7.Location = new Point(550, 172);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 2);
            panel7.TabIndex = 35;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 10F);
            textBox3.Location = new Point(550, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 21);
            textBox3.TabIndex = 34;
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightGray;
            panel8.Location = new Point(112, 172);
            panel8.Name = "panel8";
            panel8.Size = new Size(270, 2);
            panel8.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label12.Location = new Point(553, 122);
            label12.Name = "label12";
            label12.Size = new Size(75, 19);
            label12.TabIndex = 33;
            label12.Text = "Reg No:";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Century Gothic", 10F);
            textBox4.Location = new Point(112, 148);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(270, 21);
            textBox4.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label13.Location = new Point(112, 122);
            label13.Name = "label13";
            label13.Size = new Size(65, 19);
            label13.TabIndex = 30;
            label13.Text = "Name:";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.SandyBrown;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(247, 291);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(114, 37);
            buttonDelete.TabIndex = 28;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Maroon;
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.FlatAppearance.BorderSize = 0;
            buttonUpdate.FlatStyle = FlatStyle.Flat;
            buttonUpdate.ForeColor = Color.White;
            buttonUpdate.Location = new Point(115, 291);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(114, 37);
            buttonUpdate.TabIndex = 27;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Maroon;
            label14.Location = new Point(3, 3);
            label14.Name = "label14";
            label14.Size = new Size(279, 23);
            label14.TabIndex = 14;
            label14.Text = "Update and Delete Student:";
            // 
            // UserControl1AddStudentcs
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControlAddStudent);
            Font = new Font("Century Gothic", 9.75F);
            Margin = new Padding(2, 3, 2, 3);
            Name = "UserControl1AddStudentcs";
            Size = new Size(942, 501);
            tabControlAddStudent.ResumeLayout(false);
            tabPageAddStudent.ResumeLayout(false);
            tabPageAddStudent.PerformLayout();
            tabPageSearchStudent.ResumeLayout(false);
            tabPageSearchStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            tabPageUPStudent.ResumeLayout(false);
            tabPageUPStudent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAddStudent;
        private TabPage tabPageAddStudent;
        private Button buttonAdd;
        private TextBox textBoxFemale;
        private Panel panel3;
        private Label label5;
        private TextBox textBoxMale;
        private Label label4;
        private Panel panel2;
        private TextBox textBoxRegNo;
        private Panel panel1;
        private Label label3;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
        private TabPage tabPageSearchStudent;
        private Label labelCountStudent;
        private Label label8;
        private DataGridView dataGridViewStudent;
        private TextBox textBoxSearch;
        private PictureBox pictureBoxSearch;
        private Panel panel5;
        private Label label6;
        private Label label7;
        private TabPage tabPageUPStudent;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Label label14;
        private ComboBox comboBoxClass;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ComboBox comboBox1;
        private Panel panel4;
        private TextBox textBox1;
        private Label label9;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox2;
        private Panel panel6;
        private Label label10;
        private TextBox textBox2;
        private Label label11;
        private Panel panel7;
        private TextBox textBox3;
        private Panel panel8;
        private Label label12;
        private TextBox textBox4;
        private Label label13;
    }
}
