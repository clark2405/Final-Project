namespace Final_Project.PAL.User_Control
{
    partial class UserControlAttendance
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
            tabPageMarkAttendance = new TabPage();
            dataGridViewMarkAttendance = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewCheckBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel8 = new Panel();
            comboBoxClass = new ComboBox();
            label3 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            tabControl1 = new TabControl();
            tabPageMarkAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarkAttendance).BeginInit();
            panel4.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageMarkAttendance
            // 
            tabPageMarkAttendance.Controls.Add(dataGridViewMarkAttendance);
            tabPageMarkAttendance.Controls.Add(panel8);
            tabPageMarkAttendance.Controls.Add(comboBoxClass);
            tabPageMarkAttendance.Controls.Add(label3);
            tabPageMarkAttendance.Controls.Add(panel7);
            tabPageMarkAttendance.Controls.Add(panel6);
            tabPageMarkAttendance.Controls.Add(panel4);
            tabPageMarkAttendance.Controls.Add(panel3);
            tabPageMarkAttendance.Controls.Add(panel2);
            tabPageMarkAttendance.Controls.Add(panel1);
            tabPageMarkAttendance.Controls.Add(label2);
            tabPageMarkAttendance.Controls.Add(label1);
            tabPageMarkAttendance.Controls.Add(dateTimePicker1);
            tabPageMarkAttendance.Location = new Point(4, 4);
            tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            tabPageMarkAttendance.Padding = new Padding(3);
            tabPageMarkAttendance.Size = new Size(934, 563);
            tabPageMarkAttendance.TabIndex = 0;
            tabPageMarkAttendance.Text = "Mark Attendance";
            tabPageMarkAttendance.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMarkAttendance
            // 
            dataGridViewMarkAttendance.AllowUserToAddRows = false;
            dataGridViewMarkAttendance.AllowUserToDeleteRows = false;
            dataGridViewMarkAttendance.AllowUserToResizeColumns = false;
            dataGridViewMarkAttendance.AllowUserToResizeRows = false;
            dataGridViewMarkAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMarkAttendance.BackgroundColor = Color.White;
            dataGridViewMarkAttendance.BorderStyle = BorderStyle.None;
            dataGridViewMarkAttendance.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewMarkAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMarkAttendance.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewMarkAttendance.Location = new Point(6, 166);
            dataGridViewMarkAttendance.Name = "dataGridViewMarkAttendance";
            dataGridViewMarkAttendance.RowHeadersWidth = 51;
            dataGridViewMarkAttendance.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewMarkAttendance.ScrollBars = ScrollBars.Vertical;
            dataGridViewMarkAttendance.ShowCellErrors = false;
            dataGridViewMarkAttendance.ShowEditingIcon = false;
            dataGridViewMarkAttendance.ShowRowErrors = false;
            dataGridViewMarkAttendance.Size = new Size(922, 391);
            dataGridViewMarkAttendance.TabIndex = 14;
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
            Column2.HeaderText = "Student Name";
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
            Column4.HeaderText = "Status";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.True;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            Column5.HeaderText = "Status";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightGray;
            panel8.Location = new Point(549, 120);
            panel8.Name = "panel8";
            panel8.Size = new Size(270, 2);
            panel8.TabIndex = 13;
            // 
            // comboBoxClass
            // 
            comboBoxClass.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxClass.FlatStyle = FlatStyle.Flat;
            comboBoxClass.FormattingEnabled = true;
            comboBoxClass.Location = new Point(549, 94);
            comboBoxClass.Name = "comboBoxClass";
            comboBoxClass.Size = new Size(270, 29);
            comboBoxClass.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.Location = new Point(546, 67);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 11;
            label3.Text = "Class:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightGray;
            panel7.Location = new Point(120, 120);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 2);
            panel7.TabIndex = 9;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Location = new Point(347, 94);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 23);
            panel6.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(390, 94);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 23);
            panel4.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 23);
            panel5.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Location = new Point(111, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 23);
            panel3.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(120, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 10);
            panel2.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(120, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 10);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(117, 67);
            label2.Name = "label2";
            label2.Size = new Size(52, 19);
            label2.TabIndex = 2;
            label2.Text = "Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(187, 23);
            label1.TabIndex = 1;
            label1.Text = "Mark Attendance:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(120, 94);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(270, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Anchor = AnchorStyles.None;
            tabControl1.Controls.Add(tabPageMarkAttendance);
            tabControl1.Location = new Point(-5, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(942, 597);
            tabControl1.TabIndex = 0;
            // 
            // UserControlAttendance
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tabControl1);
            Font = new Font("Century Gothic", 9.75F);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UserControlAttendance";
            Size = new Size(932, 597);
            Load += UserControlAttendance_Load;
            tabPageMarkAttendance.ResumeLayout(false);
            tabPageMarkAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarkAttendance).EndInit();
            panel4.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageMarkAttendance;
        private TabControl tabControl1;
        private Label label1;
        private Label label2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Panel panel5;
        private Panel panel6;
        private DateTimePicker dateTimePicker1;
        private Panel panel7;
        private ComboBox comboBoxClass;
        private Label label3;
        private Panel panel8;
        private DataGridView dataGridViewMarkAttendance;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewCheckBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
