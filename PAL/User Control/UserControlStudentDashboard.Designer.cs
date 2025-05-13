namespace Final_Project.PAL.User_Control
{
    partial class UserControlStudentDashboard
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
            panel2 = new Panel();
            labelUsername = new Label();
            label3 = new Label();
            dataGridAttendance = new DataGridView();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAttendance).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(labelUsername);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 465);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 99);
            panel2.TabIndex = 8;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Maroon;
            labelUsername.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(145, 34);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(33, 23);
            labelUsername.TabIndex = 9;
            labelUsername.Text = "{?}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Maroon;
            label3.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 34);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 10;
            label3.Text = "Welcome:";
            // 
            // dataGridAttendance
            // 
            dataGridAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAttendance.Location = new Point(19, 26);
            dataGridAttendance.Name = "dataGridAttendance";
            dataGridAttendance.ReadOnly = true;
            dataGridAttendance.RowHeadersWidth = 51;
            dataGridAttendance.Size = new Size(880, 415);
            dataGridAttendance.TabIndex = 9;
            // 
            // UserControlStudentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridAttendance);
            Controls.Add(panel2);
            Name = "UserControlStudentDashboard";
            Size = new Size(932, 564);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAttendance).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label labelUsername;
        private Label label3;
        private DataGridView dataGridAttendance;
    }
}
