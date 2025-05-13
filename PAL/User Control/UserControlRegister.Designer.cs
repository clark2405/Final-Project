namespace Final_Project.PAL.User_Control
{
    partial class UserControlRegister
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
            components = new System.ComponentModel.Container();
            tabControlRegister = new TabControl();
            tabPageAddUser = new TabPage();
            textBoxID = new MaskedTextBox();
            pictureBoxErrorID = new PictureBox();
            panel12 = new Panel();
            label19 = new Label();
            panel11 = new Panel();
            textBoxAddress = new TextBox();
            label17 = new Label();
            textBoxEmail = new TextBox();
            pictureBoxErrorEmail = new PictureBox();
            panel3 = new Panel();
            label4 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            pictureBoxErrorDateofBirth = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            dateTimePickerDOB = new MaskedTextBox();
            panel9 = new Panel();
            textBoxPassword = new TextBox();
            label15 = new Label();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            buttonAdd = new Button();
            label5 = new Label();
            panel1 = new Panel();
            textBoxFullName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPageSearchUser = new TabPage();
            combobxSearchBy = new ComboBox();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label9 = new Label();
            labelCountStudent = new Label();
            label8 = new Label();
            dataGridViewAccount = new DataGridView();
            textBoxSearch = new TextBox();
            pictureBoxSearch = new PictureBox();
            panel5 = new Panel();
            label6 = new Label();
            label7 = new Label();
            tabPageUPStudent = new TabPage();
            textBoxNewAddress = new TextBox();
            radioButtonNewFemale = new RadioButton();
            radioButtonNewMale = new RadioButton();
            label16 = new Label();
            pictureBox4 = new PictureBox();
            maskedTextBoxNewID = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            panel6 = new Panel();
            label10 = new Label();
            panel7 = new Panel();
            label12 = new Label();
            textBoxNewEmail = new TextBox();
            pictureBox2 = new PictureBox();
            panel8 = new Panel();
            label13 = new Label();
            maskedTextBox5 = new MaskedTextBox();
            panel13 = new Panel();
            label20 = new Label();
            maskedTextBoxNewBDAY = new MaskedTextBox();
            panel15 = new Panel();
            textBoxNewPass = new TextBox();
            label22 = new Label();
            btnConfirm = new Button();
            panel16 = new Panel();
            textBoxNewName = new TextBox();
            label24 = new Label();
            buttonDelete = new Button();
            label14 = new Label();
            toolTip1 = new ToolTip(components);
            tabControlRegister.SuspendLayout();
            tabPageAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxErrorID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxErrorEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxErrorDateofBirth).BeginInit();
            tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).BeginInit();
            tabPageUPStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tabControlRegister
            // 
            tabControlRegister.Alignment = TabAlignment.Bottom;
            tabControlRegister.Anchor = AnchorStyles.None;
            tabControlRegister.Controls.Add(tabPageAddUser);
            tabControlRegister.Controls.Add(tabPageSearchUser);
            tabControlRegister.Controls.Add(tabPageUPStudent);
            tabControlRegister.Location = new Point(-5, 0);
            tabControlRegister.Name = "tabControlRegister";
            tabControlRegister.SelectedIndex = 0;
            tabControlRegister.Size = new Size(947, 594);
            tabControlRegister.TabIndex = 2;
            // 
            // tabPageAddUser
            // 
            tabPageAddUser.BackColor = Color.White;
            tabPageAddUser.Controls.Add(textBoxID);
            tabPageAddUser.Controls.Add(pictureBoxErrorID);
            tabPageAddUser.Controls.Add(panel12);
            tabPageAddUser.Controls.Add(label19);
            tabPageAddUser.Controls.Add(panel11);
            tabPageAddUser.Controls.Add(textBoxAddress);
            tabPageAddUser.Controls.Add(label17);
            tabPageAddUser.Controls.Add(textBoxEmail);
            tabPageAddUser.Controls.Add(pictureBoxErrorEmail);
            tabPageAddUser.Controls.Add(panel3);
            tabPageAddUser.Controls.Add(label4);
            tabPageAddUser.Controls.Add(maskedTextBox2);
            tabPageAddUser.Controls.Add(pictureBoxErrorDateofBirth);
            tabPageAddUser.Controls.Add(panel2);
            tabPageAddUser.Controls.Add(label3);
            tabPageAddUser.Controls.Add(dateTimePickerDOB);
            tabPageAddUser.Controls.Add(panel9);
            tabPageAddUser.Controls.Add(textBoxPassword);
            tabPageAddUser.Controls.Add(label15);
            tabPageAddUser.Controls.Add(radioButtonFemale);
            tabPageAddUser.Controls.Add(radioButtonMale);
            tabPageAddUser.Controls.Add(buttonAdd);
            tabPageAddUser.Controls.Add(label5);
            tabPageAddUser.Controls.Add(panel1);
            tabPageAddUser.Controls.Add(textBoxFullName);
            tabPageAddUser.Controls.Add(label2);
            tabPageAddUser.Controls.Add(label1);
            tabPageAddUser.Location = new Point(4, 4);
            tabPageAddUser.Name = "tabPageAddUser";
            tabPageAddUser.Padding = new Padding(3);
            tabPageAddUser.Size = new Size(939, 558);
            tabPageAddUser.TabIndex = 0;
            tabPageAddUser.Text = "Add Account";
            // 
            // textBoxID
            // 
            textBoxID.BorderStyle = BorderStyle.None;
            textBoxID.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxID.ForeColor = Color.DarkGray;
            textBoxID.Location = new Point(112, 255);
            textBoxID.Mask = "0000-0000000-0";
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(270, 21);
            textBoxID.TabIndex = 41;
            textBoxID.Text = "000000000000";
            // 
            // pictureBoxErrorID
            // 
            pictureBoxErrorID.Anchor = AnchorStyles.None;
            pictureBoxErrorID.Image = Properties.Resources._614338_;
            pictureBoxErrorID.Location = new Point(388, 259);
            pictureBoxErrorID.Name = "pictureBoxErrorID";
            pictureBoxErrorID.Size = new Size(19, 17);
            pictureBoxErrorID.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxErrorID.TabIndex = 40;
            pictureBoxErrorID.TabStop = false;
            // 
            // panel12
            // 
            panel12.BackColor = Color.LightGray;
            panel12.Location = new Point(112, 279);
            panel12.Name = "panel12";
            panel12.Size = new Size(270, 2);
            panel12.TabIndex = 37;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label19.Location = new Point(109, 226);
            label19.Name = "label19";
            label19.Size = new Size(31, 19);
            label19.TabIndex = 39;
            label19.Text = "ID:";
            // 
            // panel11
            // 
            panel11.BackColor = Color.LightGray;
            panel11.Location = new Point(109, 441);
            panel11.Name = "panel11";
            panel11.Size = new Size(711, 2);
            panel11.TabIndex = 34;
            // 
            // textBoxAddress
            // 
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxAddress.Font = new Font("Century Gothic", 10F);
            textBoxAddress.Location = new Point(109, 392);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(711, 48);
            textBoxAddress.TabIndex = 33;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label17.Location = new Point(109, 370);
            label17.Name = "label17";
            label17.Size = new Size(81, 19);
            label17.TabIndex = 32;
            label17.Text = "Address:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Century Gothic", 10F);
            textBoxEmail.ForeColor = Color.DarkGray;
            textBoxEmail.Location = new Point(112, 181);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(270, 21);
            textBoxEmail.TabIndex = 31;
            textBoxEmail.Text = "juandelacruz@gmail.com";
            // 
            // pictureBoxErrorEmail
            // 
            pictureBoxErrorEmail.Anchor = AnchorStyles.None;
            pictureBoxErrorEmail.Image = Properties.Resources._614338_;
            pictureBoxErrorEmail.Location = new Point(388, 185);
            pictureBoxErrorEmail.Name = "pictureBoxErrorEmail";
            pictureBoxErrorEmail.Size = new Size(19, 17);
            pictureBoxErrorEmail.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxErrorEmail.TabIndex = 30;
            pictureBoxErrorEmail.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(112, 205);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 2);
            panel3.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label4.Location = new Point(109, 152);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 29;
            label4.Text = "Email:";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.BorderStyle = BorderStyle.None;
            maskedTextBox2.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox2.ForeColor = Color.DarkGray;
            maskedTextBox2.Location = new Point(112, 181);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.RightToLeft = RightToLeft.No;
            maskedTextBox2.Size = new Size(270, 21);
            maskedTextBox2.TabIndex = 28;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // pictureBoxErrorDateofBirth
            // 
            pictureBoxErrorDateofBirth.Anchor = AnchorStyles.None;
            pictureBoxErrorDateofBirth.Image = Properties.Resources._614338_;
            pictureBoxErrorDateofBirth.Location = new Point(826, 185);
            pictureBoxErrorDateofBirth.Name = "pictureBoxErrorDateofBirth";
            pictureBoxErrorDateofBirth.Size = new Size(19, 17);
            pictureBoxErrorDateofBirth.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxErrorDateofBirth.TabIndex = 26;
            pictureBoxErrorDateofBirth.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(550, 205);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.Location = new Point(547, 152);
            label3.Name = "label3";
            label3.Size = new Size(111, 19);
            label3.TabIndex = 25;
            label3.Text = "Date of Birth:";
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.BorderStyle = BorderStyle.None;
            dateTimePickerDOB.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePickerDOB.ForeColor = Color.DarkGray;
            dateTimePickerDOB.Location = new Point(550, 181);
            dateTimePickerDOB.Mask = "00/00/0000";
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(270, 21);
            dateTimePickerDOB.TabIndex = 24;
            dateTimePickerDOB.Text = "00000000";
            dateTimePickerDOB.ValidatingType = typeof(DateTime);
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightGray;
            panel9.Location = new Point(550, 137);
            panel9.Name = "panel9";
            panel9.Size = new Size(270, 2);
            panel9.TabIndex = 19;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Century Gothic", 10F);
            textBoxPassword.Location = new Point(550, 113);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(270, 21);
            textBoxPassword.TabIndex = 18;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label15.Location = new Point(550, 84);
            label15.Name = "label15";
            label15.Size = new Size(92, 19);
            label15.TabIndex = 17;
            label15.Text = "Password:";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Century Gothic", 10F);
            radioButtonFemale.Location = new Point(630, 270);
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
            radioButtonMale.Location = new Point(630, 239);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(74, 25);
            radioButtonMale.TabIndex = 15;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Maroon;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(109, 463);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(114, 37);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label5.Location = new Point(549, 258);
            label5.Name = "label5";
            label5.Size = new Size(76, 19);
            label5.TabIndex = 10;
            label5.Text = "Gender:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(112, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 3;
            // 
            // textBoxFullName
            // 
            textBoxFullName.BorderStyle = BorderStyle.None;
            textBoxFullName.Font = new Font("Century Gothic", 10F);
            textBoxFullName.Location = new Point(112, 113);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(270, 21);
            textBoxFullName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(109, 84);
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
            label1.Size = new Size(225, 23);
            label1.TabIndex = 0;
            label1.Text = "Add Student Account:";
            // 
            // tabPageSearchUser
            // 
            tabPageSearchUser.Controls.Add(combobxSearchBy);
            tabPageSearchUser.Controls.Add(panel4);
            tabPageSearchUser.Controls.Add(textBox1);
            tabPageSearchUser.Controls.Add(label9);
            tabPageSearchUser.Controls.Add(labelCountStudent);
            tabPageSearchUser.Controls.Add(label8);
            tabPageSearchUser.Controls.Add(dataGridViewAccount);
            tabPageSearchUser.Controls.Add(textBoxSearch);
            tabPageSearchUser.Controls.Add(pictureBoxSearch);
            tabPageSearchUser.Controls.Add(panel5);
            tabPageSearchUser.Controls.Add(label6);
            tabPageSearchUser.Controls.Add(label7);
            tabPageSearchUser.Location = new Point(4, 4);
            tabPageSearchUser.Name = "tabPageSearchUser";
            tabPageSearchUser.Padding = new Padding(3);
            tabPageSearchUser.Size = new Size(939, 558);
            tabPageSearchUser.TabIndex = 1;
            tabPageSearchUser.Text = "Accounts";
            tabPageSearchUser.UseVisualStyleBackColor = true;
            // 
            // combobxSearchBy
            // 
            combobxSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            combobxSearchBy.FlatStyle = FlatStyle.Flat;
            combobxSearchBy.FormattingEnabled = true;
            combobxSearchBy.Location = new Point(610, 93);
            combobxSearchBy.Name = "combobxSearchBy";
            combobxSearchBy.Size = new Size(186, 31);
            combobxSearchBy.TabIndex = 18;
            combobxSearchBy.Visible = false;
            combobxSearchBy.SelectedIndexChanged += combobxAccountType_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Location = new Point(610, 126);
            panel4.Name = "panel4";
            panel4.Size = new Size(186, 2);
            panel4.TabIndex = 17;
            panel4.Visible = false;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 10F);
            textBox1.Location = new Point(610, 99);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 21);
            textBox1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label9.Location = new Point(613, 72);
            label9.Name = "label9";
            label9.Size = new Size(115, 19);
            label9.TabIndex = 15;
            label9.Text = "Search Type:";
            label9.Visible = false;
            // 
            // labelCountStudent
            // 
            labelCountStudent.AutoSize = true;
            labelCountStudent.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCountStudent.Location = new Point(787, 533);
            labelCountStudent.Name = "labelCountStudent";
            labelCountStudent.Size = new Size(33, 21);
            labelCountStudent.TabIndex = 11;
            labelCountStudent.Text = "{?}";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label8.Location = new Point(655, 536);
            label8.Name = "label8";
            label8.Size = new Size(126, 19);
            label8.TabIndex = 10;
            label8.Text = "Total Account:";
            // 
            // dataGridViewAccount
            // 
            dataGridViewAccount.AllowUserToAddRows = false;
            dataGridViewAccount.AllowUserToDeleteRows = false;
            dataGridViewAccount.AllowUserToResizeColumns = false;
            dataGridViewAccount.AllowUserToResizeRows = false;
            dataGridViewAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAccount.BackgroundColor = Color.White;
            dataGridViewAccount.BorderStyle = BorderStyle.None;
            dataGridViewAccount.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccount.Location = new Point(3, 138);
            dataGridViewAccount.Name = "dataGridViewAccount";
            dataGridViewAccount.ReadOnly = true;
            dataGridViewAccount.RowHeadersWidth = 51;
            dataGridViewAccount.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewAccount.ShowCellErrors = false;
            dataGridViewAccount.ShowEditingIcon = false;
            dataGridViewAccount.ShowRowErrors = false;
            dataGridViewAccount.Size = new Size(930, 394);
            dataGridViewAccount.TabIndex = 9;
            dataGridViewAccount.SelectionChanged += dataGridViewAccount_SelectionChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.None;
            textBoxSearch.Font = new Font("Century Gothic", 10F);
            textBoxSearch.Location = new Point(145, 101);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(225, 21);
            textBoxSearch.TabIndex = 6;
            textBoxSearch.Visible = false;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // pictureBoxSearch
            // 
            pictureBoxSearch.Cursor = Cursors.Hand;
            pictureBoxSearch.Image = Properties.Resources.search__1_;
            pictureBoxSearch.Location = new Point(396, 96);
            pictureBoxSearch.Name = "pictureBoxSearch";
            pictureBoxSearch.Size = new Size(19, 26);
            pictureBoxSearch.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSearch.TabIndex = 8;
            pictureBoxSearch.TabStop = false;
            pictureBoxSearch.Visible = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightGray;
            panel5.Location = new Point(142, 126);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 2);
            panel5.TabIndex = 7;
            panel5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label6.Location = new Point(148, 83);
            label6.Name = "label6";
            label6.Size = new Size(71, 19);
            label6.TabIndex = 5;
            label6.Text = "Search:";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(6, 6);
            label7.Name = "label7";
            label7.Size = new Size(97, 23);
            label7.TabIndex = 4;
            label7.Text = "Students:";
            // 
            // tabPageUPStudent
            // 
            tabPageUPStudent.BackColor = Color.White;
            tabPageUPStudent.Controls.Add(textBoxNewAddress);
            tabPageUPStudent.Controls.Add(radioButtonNewFemale);
            tabPageUPStudent.Controls.Add(radioButtonNewMale);
            tabPageUPStudent.Controls.Add(label16);
            tabPageUPStudent.Controls.Add(pictureBox4);
            tabPageUPStudent.Controls.Add(maskedTextBoxNewID);
            tabPageUPStudent.Controls.Add(pictureBox1);
            tabPageUPStudent.Controls.Add(panel6);
            tabPageUPStudent.Controls.Add(label10);
            tabPageUPStudent.Controls.Add(panel7);
            tabPageUPStudent.Controls.Add(label12);
            tabPageUPStudent.Controls.Add(textBoxNewEmail);
            tabPageUPStudent.Controls.Add(pictureBox2);
            tabPageUPStudent.Controls.Add(panel8);
            tabPageUPStudent.Controls.Add(label13);
            tabPageUPStudent.Controls.Add(maskedTextBox5);
            tabPageUPStudent.Controls.Add(panel13);
            tabPageUPStudent.Controls.Add(label20);
            tabPageUPStudent.Controls.Add(maskedTextBoxNewBDAY);
            tabPageUPStudent.Controls.Add(panel15);
            tabPageUPStudent.Controls.Add(textBoxNewPass);
            tabPageUPStudent.Controls.Add(label22);
            tabPageUPStudent.Controls.Add(btnConfirm);
            tabPageUPStudent.Controls.Add(panel16);
            tabPageUPStudent.Controls.Add(textBoxNewName);
            tabPageUPStudent.Controls.Add(label24);
            tabPageUPStudent.Controls.Add(buttonDelete);
            tabPageUPStudent.Controls.Add(label14);
            tabPageUPStudent.Location = new Point(4, 4);
            tabPageUPStudent.Name = "tabPageUPStudent";
            tabPageUPStudent.Padding = new Padding(3);
            tabPageUPStudent.Size = new Size(939, 561);
            tabPageUPStudent.TabIndex = 2;
            tabPageUPStudent.Text = "Update and Delete Account";
            // 
            // textBoxNewAddress
            // 
            textBoxNewAddress.BorderStyle = BorderStyle.None;
            textBoxNewAddress.Font = new Font("Century Gothic", 10F);
            textBoxNewAddress.Location = new Point(114, 392);
            textBoxNewAddress.Multiline = true;
            textBoxNewAddress.Name = "textBoxNewAddress";
            textBoxNewAddress.Size = new Size(711, 48);
            textBoxNewAddress.TabIndex = 77;
            // 
            // radioButtonNewFemale
            // 
            radioButtonNewFemale.AutoSize = true;
            radioButtonNewFemale.Font = new Font("Century Gothic", 10F);
            radioButtonNewFemale.Location = new Point(650, 293);
            radioButtonNewFemale.Name = "radioButtonNewFemale";
            radioButtonNewFemale.Size = new Size(91, 25);
            radioButtonNewFemale.TabIndex = 76;
            radioButtonNewFemale.TabStop = true;
            radioButtonNewFemale.Text = "Female";
            radioButtonNewFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonNewMale
            // 
            radioButtonNewMale.AutoSize = true;
            radioButtonNewMale.Font = new Font("Century Gothic", 10F);
            radioButtonNewMale.Location = new Point(650, 262);
            radioButtonNewMale.Name = "radioButtonNewMale";
            radioButtonNewMale.Size = new Size(74, 25);
            radioButtonNewMale.TabIndex = 75;
            radioButtonNewMale.TabStop = true;
            radioButtonNewMale.Text = "Male";
            radioButtonNewMale.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label16.Location = new Point(569, 281);
            label16.Name = "label16";
            label16.Size = new Size(76, 19);
            label16.TabIndex = 74;
            label16.Text = "Gender:";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.Image = Properties.Resources._614338_;
            pictureBox4.Location = new Point(831, 167);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(19, 17);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 73;
            pictureBox4.TabStop = false;
            // 
            // maskedTextBoxNewID
            // 
            maskedTextBoxNewID.BorderStyle = BorderStyle.None;
            maskedTextBoxNewID.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBoxNewID.ForeColor = Color.DarkGray;
            maskedTextBoxNewID.Location = new Point(117, 255);
            maskedTextBoxNewID.Mask = "0000-0000000-0";
            maskedTextBoxNewID.Name = "maskedTextBoxNewID";
            maskedTextBoxNewID.Size = new Size(270, 21);
            maskedTextBoxNewID.TabIndex = 72;
            maskedTextBoxNewID.Text = "000000000000";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources._614338_;
            pictureBox1.Location = new Point(393, 241);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 17);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 71;
            pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Location = new Point(117, 279);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 69;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label10.Location = new Point(114, 226);
            label10.Name = "label10";
            label10.Size = new Size(31, 19);
            label10.TabIndex = 70;
            label10.Text = "ID:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightGray;
            panel7.Location = new Point(114, 441);
            panel7.Name = "panel7";
            panel7.Size = new Size(711, 2);
            panel7.TabIndex = 66;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label12.Location = new Point(114, 374);
            label12.Name = "label12";
            label12.Size = new Size(81, 19);
            label12.TabIndex = 64;
            label12.Text = "Address:";
            // 
            // textBoxNewEmail
            // 
            textBoxNewEmail.BorderStyle = BorderStyle.None;
            textBoxNewEmail.Font = new Font("Century Gothic", 10F);
            textBoxNewEmail.ForeColor = Color.DarkGray;
            textBoxNewEmail.Location = new Point(117, 181);
            textBoxNewEmail.Name = "textBoxNewEmail";
            textBoxNewEmail.Size = new Size(270, 21);
            textBoxNewEmail.TabIndex = 63;
            textBoxNewEmail.Text = "juandelacruz@gmail.com";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources._614338_;
            pictureBox2.Location = new Point(390, 167);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 17);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 62;
            pictureBox2.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightGray;
            panel8.Location = new Point(117, 205);
            panel8.Name = "panel8";
            panel8.Size = new Size(270, 2);
            panel8.TabIndex = 59;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label13.Location = new Point(114, 152);
            label13.Name = "label13";
            label13.Size = new Size(58, 19);
            label13.TabIndex = 61;
            label13.Text = "Email:";
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.BorderStyle = BorderStyle.None;
            maskedTextBox5.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox5.ForeColor = Color.DarkGray;
            maskedTextBox5.Location = new Point(117, 181);
            maskedTextBox5.Mask = "00/00/0000";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.RightToLeft = RightToLeft.No;
            maskedTextBox5.Size = new Size(270, 21);
            maskedTextBox5.TabIndex = 60;
            maskedTextBox5.ValidatingType = typeof(DateTime);
            // 
            // panel13
            // 
            panel13.BackColor = Color.LightGray;
            panel13.Location = new Point(555, 205);
            panel13.Name = "panel13";
            panel13.Size = new Size(270, 2);
            panel13.TabIndex = 56;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label20.Location = new Point(552, 152);
            label20.Name = "label20";
            label20.Size = new Size(111, 19);
            label20.TabIndex = 58;
            label20.Text = "Date of Birth:";
            // 
            // maskedTextBoxNewBDAY
            // 
            maskedTextBoxNewBDAY.BorderStyle = BorderStyle.None;
            maskedTextBoxNewBDAY.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBoxNewBDAY.ForeColor = Color.DarkGray;
            maskedTextBoxNewBDAY.Location = new Point(555, 181);
            maskedTextBoxNewBDAY.Mask = "00/00/0000";
            maskedTextBoxNewBDAY.Name = "maskedTextBoxNewBDAY";
            maskedTextBoxNewBDAY.Size = new Size(270, 21);
            maskedTextBoxNewBDAY.TabIndex = 57;
            maskedTextBoxNewBDAY.Text = "00000000";
            maskedTextBoxNewBDAY.ValidatingType = typeof(DateTime);
            // 
            // panel15
            // 
            panel15.BackColor = Color.LightGray;
            panel15.Location = new Point(555, 137);
            panel15.Name = "panel15";
            panel15.Size = new Size(270, 2);
            panel15.TabIndex = 52;
            // 
            // textBoxNewPass
            // 
            textBoxNewPass.BorderStyle = BorderStyle.None;
            textBoxNewPass.Font = new Font("Century Gothic", 10F);
            textBoxNewPass.Location = new Point(555, 113);
            textBoxNewPass.Name = "textBoxNewPass";
            textBoxNewPass.Size = new Size(270, 21);
            textBoxNewPass.TabIndex = 51;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label22.Location = new Point(555, 84);
            label22.Name = "label22";
            label22.Size = new Size(92, 19);
            label22.TabIndex = 50;
            label22.Text = "Password:";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Maroon;
            btnConfirm.Cursor = Cursors.Hand;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(114, 461);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(114, 37);
            btnConfirm.TabIndex = 47;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // panel16
            // 
            panel16.BackColor = Color.LightGray;
            panel16.Location = new Point(117, 137);
            panel16.Name = "panel16";
            panel16.Size = new Size(270, 2);
            panel16.TabIndex = 44;
            // 
            // textBoxNewName
            // 
            textBoxNewName.BorderStyle = BorderStyle.None;
            textBoxNewName.Font = new Font("Century Gothic", 10F);
            textBoxNewName.Location = new Point(117, 113);
            textBoxNewName.Name = "textBoxNewName";
            textBoxNewName.Size = new Size(270, 21);
            textBoxNewName.TabIndex = 43;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label24.Location = new Point(114, 84);
            label24.Name = "label24";
            label24.Size = new Size(65, 19);
            label24.TabIndex = 42;
            label24.Text = "Name:";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.SandyBrown;
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(242, 461);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(114, 37);
            buttonDelete.TabIndex = 28;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Maroon;
            label14.Location = new Point(3, 3);
            label14.Name = "label14";
            label14.Size = new Size(291, 23);
            label14.TabIndex = 14;
            label14.Text = "Update and Delete Account:";
            // 
            // UserControlRegister
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlRegister);
            Font = new Font("Century Gothic", 12F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControlRegister";
            Size = new Size(932, 597);
            tabControlRegister.ResumeLayout(false);
            tabPageAddUser.ResumeLayout(false);
            tabPageAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxErrorID).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxErrorEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxErrorDateofBirth).EndInit();
            tabPageSearchUser.ResumeLayout(false);
            tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccount).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSearch).EndInit();
            tabPageUPStudent.ResumeLayout(false);
            tabPageUPStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlRegister;
        private TabPage tabPageAddUser;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
        private Button buttonAdd;
        private Label label5;
        private Panel panel1;
        private TextBox textBoxFullName;
        private Label label2;
        private Label label1;
        private TabPage tabPageSearchUser;
        private ComboBox combobxSearchBy;
        private Panel panel4;
        private TextBox textBox1;
        private Label label9;
        private Label labelCountStudent;
        private Label label8;
        private DataGridView dataGridViewAccount;
        private TextBox textBoxSearch;
        private PictureBox pictureBoxSearch;
        private Panel panel5;
        private Label label6;
        private Label label7;
        private TabPage tabPageUPStudent;
        private Button buttonDelete;
        private Label label14;
        private Panel panel9;
        private TextBox textBoxPassword;
        private Label label15;
        private PictureBox pictureBoxErrorDateofBirth;
        private Panel panel2;
        private Label label3;
        private MaskedTextBox dateTimePickerDOB;
        private ToolTip toolTip1;
        private PictureBox pictureBoxErrorEmail;
        private Panel panel3;
        private Label label4;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBoxEmail;
        private Panel panel11;
        private TextBox textBoxAddress;
        private Label label17;
        private TextBox textBox5;
        private PictureBox pictureBoxErrorID;
        private Panel panel12;
        private Label label19;
        private MaskedTextBox textBoxID;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBoxNewID;
        private PictureBox pictureBox1;
        private Panel panel6;
        private Label label10;
        private CheckBox checkBox1;
        private Label label11;
        private Panel panel7;
        private TextBox textBox2;
        private Label label12;
        private TextBox textBoxNewEmail;
        private PictureBox pictureBox2;
        private Panel panel8;
        private Label label13;
        private MaskedTextBox maskedTextBox5;
        private Panel panel13;
        private Label label20;
        private MaskedTextBox maskedTextBoxNewBDAY;
        private Panel panel15;
        private TextBox textBoxNewPass;
        private Label label22;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btnConfirm;
        private Panel panel16;
        private TextBox textBoxNewName;
        private Label label24;
        private PictureBox pictureBox4;
        private RadioButton radioButtonNewFemale;
        private RadioButton radioButtonNewMale;
        private Label label16;
        private TextBox textBoxNewAddress;
    }
}
