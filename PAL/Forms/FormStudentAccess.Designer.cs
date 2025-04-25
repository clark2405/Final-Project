namespace Final_Project.PAL.Forms
{
    partial class FormStudentAccess
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentAccess));
            panelContainer = new Panel();
            labelRole = new Label();
            label6 = new Label();
            labelUsername = new Label();
            label3 = new Label();
            buttonLogout = new Button();
            buttonMinimize = new Button();
            panel4 = new Panel();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            panelBack = new Panel();
            buttonDown = new Button();
            panelExpand = new Panel();
            pictureBox2 = new PictureBox();
            labelTime = new Label();
            panel3 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panelSlide = new Panel();
            buttonDashboard = new Button();
            panel5 = new Panel();
            buttonAttendance = new Button();
            buttonReport = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel4.SuspendLayout();
            panelBack.SuspendLayout();
            panelExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(268, 123);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(932, 564);
            panelContainer.TabIndex = 5;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.BackColor = Color.Maroon;
            labelRole.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(166, 35);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(33, 23);
            labelRole.TabIndex = 0;
            labelRole.Text = "{?}";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Maroon;
            label6.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(50, 35);
            label6.Name = "label6";
            label6.Size = new Size(55, 23);
            label6.TabIndex = 0;
            label6.Text = "Role:";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.BackColor = Color.Maroon;
            labelUsername.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(166, 12);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(33, 23);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "{?}";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Maroon;
            label3.Font = new Font("Century Gothic", 11F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(50, 12);
            label3.Name = "label3";
            label3.Size = new Size(103, 23);
            label3.TabIndex = 3;
            label3.Text = "Welcome:";
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.White;
            buttonLogout.Cursor = Cursors.Hand;
            buttonLogout.Dock = DockStyle.Top;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            buttonLogout.ForeColor = Color.Goldenrod;
            buttonLogout.Image = (Image)resources.GetObject("buttonLogout.Image");
            buttonLogout.Location = new Point(0, 40);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(198, 35);
            buttonLogout.TabIndex = 0;
            buttonLogout.Text = "     Logout";
            buttonLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLogout.UseVisualStyleBackColor = false;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.White;
            buttonMinimize.Cursor = Cursors.Hand;
            buttonMinimize.Dock = DockStyle.Top;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            buttonMinimize.ForeColor = Color.Goldenrod;
            buttonMinimize.Image = (Image)resources.GetObject("buttonMinimize.Image");
            buttonMinimize.Location = new Point(0, 0);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(198, 40);
            buttonMinimize.TabIndex = 0;
            buttonMinimize.Text = "     Minimize";
            buttonMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMinimize.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonLogout);
            panel4.Controls.Add(buttonMinimize);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(198, 125);
            panel4.TabIndex = 0;
            // 
            // panelBack
            // 
            panelBack.Controls.Add(buttonDown);
            panelBack.Controls.Add(panelExpand);
            panelBack.Controls.Add(pictureBox2);
            panelBack.Controls.Add(labelTime);
            panelBack.Controls.Add(panel3);
            panelBack.Dock = DockStyle.Top;
            panelBack.Location = new Point(0, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(932, 165);
            panelBack.TabIndex = 0;
            // 
            // buttonDown
            // 
            buttonDown.FlatStyle = FlatStyle.Flat;
            buttonDown.Image = (Image)resources.GetObject("buttonDown.Image");
            buttonDown.Location = new Point(755, 12);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(39, 31);
            buttonDown.TabIndex = 6;
            buttonDown.UseVisualStyleBackColor = true;
            // 
            // panelExpand
            // 
            panelExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelExpand.BackColor = Color.Maroon;
            panelExpand.BorderStyle = BorderStyle.FixedSingle;
            panelExpand.Controls.Add(panel4);
            panelExpand.Location = new Point(1433, 49);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(200, 107);
            panelExpand.TabIndex = 3;
            panelExpand.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Files_for_FINAL_PROJECT;
            pictureBox2.Location = new Point(838, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.White;
            labelTime.ForeColor = Color.Maroon;
            labelTime.Location = new Point(21, 16);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(34, 23);
            labelTime.TabIndex = 0;
            labelTime.Text = "{?}";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Controls.Add(labelRole);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(labelUsername);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(932, 116);
            panel3.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelBack);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(268, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(932, 125);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 102);
            label1.Name = "label1";
            label1.Size = new Size(270, 23);
            label1.TabIndex = 0;
            label1.Text = "Attendance Management";
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(8, 47);
            panelSlide.TabIndex = 4;
            // 
            // buttonDashboard
            // 
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.Location = new Point(23, 184);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Size = new Size(250, 47);
            buttonDashboard.TabIndex = 3;
            buttonDashboard.Text = "       Dashboard";
            buttonDashboard.TextAlign = ContentAlignment.MiddleRight;
            buttonDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonDashboard.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(panelSlide);
            panel5.Location = new Point(0, 184);
            panel5.Name = "panel5";
            panel5.Size = new Size(8, 536);
            panel5.TabIndex = 3;
            // 
            // buttonAttendance
            // 
            buttonAttendance.FlatAppearance.BorderSize = 0;
            buttonAttendance.FlatStyle = FlatStyle.Flat;
            buttonAttendance.ForeColor = Color.White;
            buttonAttendance.Image = (Image)resources.GetObject("buttonAttendance.Image");
            buttonAttendance.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAttendance.Location = new Point(23, 237);
            buttonAttendance.Name = "buttonAttendance";
            buttonAttendance.Size = new Size(250, 47);
            buttonAttendance.TabIndex = 9;
            buttonAttendance.Text = "       Attendance";
            buttonAttendance.TextAlign = ContentAlignment.MiddleRight;
            buttonAttendance.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAttendance.UseVisualStyleBackColor = true;
            // 
            // buttonReport
            // 
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.ForeColor = Color.White;
            buttonReport.Image = (Image)resources.GetObject("buttonReport.Image");
            buttonReport.ImageAlign = ContentAlignment.MiddleLeft;
            buttonReport.Location = new Point(23, 290);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(250, 47);
            buttonReport.TabIndex = 7;
            buttonReport.Text = "       Report";
            buttonReport.TextAlign = ContentAlignment.MiddleRight;
            buttonReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReport.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(86, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(buttonAttendance);
            panel1.Controls.Add(buttonReport);
            panel1.Controls.Add(buttonDashboard);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 720);
            panel1.TabIndex = 3;
            // 
            // FormStudentAccess
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormStudentAccess";
            Text = "FormStudentAccess";
            panel4.ResumeLayout(false);
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            panelExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private Label labelRole;
        private Label label6;
        private Label labelUsername;
        private Label label3;
        private Button buttonLogout;
        private Button buttonMinimize;
        private Panel panel4;
        private System.Windows.Forms.Timer timerDateAndTime;
        private Panel panelBack;
        private Button buttonDown;
        private Panel panelExpand;
        private PictureBox pictureBox2;
        private Label labelTime;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Panel panelSlide;
        private Button buttonDashboard;
        private Panel panel5;
        private Button buttonAttendance;
        private Button buttonReport;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}