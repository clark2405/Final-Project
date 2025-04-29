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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStudentDashboard));
            panel1 = new Panel();
            labelTotalStudentClasses = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            labelTotalRole = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            labelUsername = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(253, 183, 71);
            panel1.Controls.Add(labelTotalStudentClasses);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(101, 176);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 128);
            panel1.TabIndex = 5;
            // 
            // labelTotalStudentClasses
            // 
            labelTotalStudentClasses.AutoSize = true;
            labelTotalStudentClasses.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelTotalStudentClasses.ForeColor = Color.White;
            labelTotalStudentClasses.Location = new Point(140, 61);
            labelTotalStudentClasses.Name = "labelTotalStudentClasses";
            labelTotalStudentClasses.Size = new Size(35, 23);
            labelTotalStudentClasses.TabIndex = 2;
            labelTotalStudentClasses.Text = "{?}";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(123, 30);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 1;
            label1.Text = "Classes";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(44, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.Maroon;
            panel3.Controls.Add(labelTotalRole);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(563, 176);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 128);
            panel3.TabIndex = 7;
            // 
            // labelTotalRole
            // 
            labelTotalRole.AutoSize = true;
            labelTotalRole.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelTotalRole.ForeColor = Color.White;
            labelTotalRole.Location = new Point(116, 61);
            labelTotalRole.Name = "labelTotalRole";
            labelTotalRole.Size = new Size(35, 23);
            labelTotalRole.TabIndex = 2;
            labelTotalRole.Text = "{?}";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(116, 30);
            label5.Name = "label5";
            label5.Size = new Size(126, 23);
            label5.TabIndex = 1;
            label5.Text = "Attendance";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(44, 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(labelUsername);
            panel2.Controls.Add(label3);
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
            // UserControlStudentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "UserControlStudentDashboard";
            Size = new Size(932, 564);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelTotalStudentClasses;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Label labelTotalRole;
        private Label label5;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Label labelUsername;
        private Label label3;
    }
}
