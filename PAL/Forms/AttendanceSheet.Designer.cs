namespace Final_Project.PAL.Forms
{
    partial class AttendanceSheet
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
            buttonConfirm = new Button();
            buttonClose = new Button();
            panel1 = new Panel();
            textBoxClassName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            textBoxStudentName = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            textBoxDate = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            textBoxStatus = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonConfirm
            // 
            buttonConfirm.BackColor = Color.Maroon;
            buttonConfirm.FlatAppearance.BorderSize = 0;
            buttonConfirm.FlatStyle = FlatStyle.Flat;
            buttonConfirm.ForeColor = Color.White;
            buttonConfirm.Location = new Point(332, 347);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(114, 37);
            buttonConfirm.TabIndex = 14;
            buttonConfirm.Text = "Confirm";
            buttonConfirm.UseVisualStyleBackColor = false;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.Maroon;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.ForeColor = Color.White;
            buttonClose.Location = new Point(212, 347);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(114, 37);
            buttonClose.TabIndex = 15;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Location = new Point(127, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 18;
            // 
            // textBoxClassName
            // 
            textBoxClassName.BorderStyle = BorderStyle.None;
            textBoxClassName.Font = new Font("Century Gothic", 10F);
            textBoxClassName.Location = new Point(127, 61);
            textBoxClassName.Name = "textBoxClassName";
            textBoxClassName.Size = new Size(270, 21);
            textBoxClassName.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 16;
            label2.Text = "Class Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(83, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 21;
            // 
            // textBoxStudentName
            // 
            textBoxStudentName.BorderStyle = BorderStyle.None;
            textBoxStudentName.Font = new Font("Century Gothic", 10F);
            textBoxStudentName.Location = new Point(83, 104);
            textBoxStudentName.Name = "textBoxStudentName";
            textBoxStudentName.Size = new Size(270, 21);
            textBoxStudentName.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label1.Location = new Point(12, 105);
            label1.Name = "label1";
            label1.Size = new Size(65, 19);
            label1.TabIndex = 19;
            label1.Text = "Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Location = new Point(83, 197);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 2);
            panel3.TabIndex = 24;
            // 
            // textBoxDate
            // 
            textBoxDate.BorderStyle = BorderStyle.None;
            textBoxDate.Font = new Font("Century Gothic", 10F);
            textBoxDate.Location = new Point(83, 173);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.Size = new Size(270, 21);
            textBoxDate.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(153, 19);
            label3.TabIndex = 22;
            label3.Text = "Attendance Date:";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Location = new Point(56, 280);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 2);
            panel4.TabIndex = 27;
            // 
            // textBoxStatus
            // 
            textBoxStatus.BorderStyle = BorderStyle.None;
            textBoxStatus.Font = new Font("Century Gothic", 10F);
            textBoxStatus.Location = new Point(56, 256);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(270, 21);
            textBoxStatus.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold);
            label4.Location = new Point(12, 221);
            label4.Name = "label4";
            label4.Size = new Size(60, 19);
            label4.TabIndex = 25;
            label4.Text = "Status:";
            // 
            // AttendanceSheet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 412);
            Controls.Add(panel4);
            Controls.Add(textBoxStatus);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(textBoxDate);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(textBoxStudentName);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(textBoxClassName);
            Controls.Add(label2);
            Controls.Add(buttonClose);
            Controls.Add(buttonConfirm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AttendanceSheet";
            Text = "AttendanceSheet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConfirm;
        private Button buttonClose;
        private Panel panel1;
        private TextBox textBoxClassName;
        private Label label2;
        private Panel panel2;
        private TextBox textBoxStudentName;
        private Label label1;
        private Panel panel3;
        private TextBox textBoxDate;
        private Label label3;
        private Panel panel4;
        private TextBox textBoxStatus;
        private Label label4;
    }
}