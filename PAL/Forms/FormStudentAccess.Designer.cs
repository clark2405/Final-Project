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
            panel1 = new Panel();
            buttonAppeal = new Button();
            buttonDashboard = new Button();
            panel5 = new Panel();
            panelSlide = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            timerDateAndTime = new System.Windows.Forms.Timer(components);
            panel2 = new Panel();
            panelBack = new Panel();
            panel6 = new Panel();
            pictureBoxClose = new Button();
            pictureBoxMinimize = new Button();
            buttonDown = new Button();
            panelExpand = new Panel();
            panel4 = new Panel();
            buttonLogout = new Button();
            buttonMinimize = new Button();
            pictureBox2 = new PictureBox();
            labelTime = new Label();
            panel3 = new Panel();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panelBack.SuspendLayout();
            panel6.SuspendLayout();
            panelExpand.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(buttonAppeal);
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
            // buttonAppeal
            // 
            buttonAppeal.FlatAppearance.BorderSize = 0;
            buttonAppeal.FlatStyle = FlatStyle.Flat;
            buttonAppeal.ForeColor = Color.White;
            buttonAppeal.Image = (Image)resources.GetObject("buttonAppeal.Image");
            buttonAppeal.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAppeal.Location = new Point(23, 237);
            buttonAppeal.Name = "buttonAppeal";
            buttonAppeal.Size = new Size(250, 47);
            buttonAppeal.TabIndex = 9;
            buttonAppeal.Text = "       Appeal";
            buttonAppeal.TextAlign = ContentAlignment.MiddleRight;
            buttonAppeal.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAppeal.UseVisualStyleBackColor = true;
            buttonAppeal.Click += buttonAppeal_Click;
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
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(panelSlide);
            panel5.Location = new Point(0, 184);
            panel5.Name = "panel5";
            panel5.Size = new Size(8, 536);
            panel5.TabIndex = 3;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.White;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(8, 47);
            panelSlide.TabIndex = 4;
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
            // timerDateAndTime
            // 
            timerDateAndTime.Tick += timerDateAndTime_Tick_1;
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
            // panelBack
            // 
            panelBack.Controls.Add(panel6);
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
            // panel6
            // 
            panel6.Controls.Add(pictureBoxClose);
            panel6.Controls.Add(pictureBoxMinimize);
            panel6.Location = new Point(707, 49);
            panel6.Name = "panel6";
            panel6.Size = new Size(195, 125);
            panel6.TabIndex = 4;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.BackColor = Color.White;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Dock = DockStyle.Top;
            pictureBoxClose.FlatAppearance.BorderSize = 0;
            pictureBoxClose.FlatStyle = FlatStyle.Flat;
            pictureBoxClose.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            pictureBoxClose.ForeColor = Color.Goldenrod;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(0, 40);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(195, 35);
            pictureBoxClose.TabIndex = 8;
            pictureBoxClose.Text = "     Logout";
            pictureBoxClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            pictureBoxClose.UseVisualStyleBackColor = false;
            pictureBoxClose.Click += pictureBoxClose_Click_2;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.BackColor = Color.White;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Dock = DockStyle.Top;
            pictureBoxMinimize.FlatAppearance.BorderSize = 0;
            pictureBoxMinimize.FlatStyle = FlatStyle.Flat;
            pictureBoxMinimize.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            pictureBoxMinimize.ForeColor = Color.Goldenrod;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(0, 0);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(195, 40);
            pictureBoxMinimize.TabIndex = 7;
            pictureBoxMinimize.Text = "     Minimize";
            pictureBoxMinimize.TextImageRelation = TextImageRelation.ImageBeforeText;
            pictureBoxMinimize.UseVisualStyleBackColor = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click_1;
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
            buttonDown.Click += buttonDown_Click_1;
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
            labelTime.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTime.ForeColor = Color.Maroon;
            labelTime.Location = new Point(21, 16);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(35, 23);
            labelTime.TabIndex = 0;
            labelTime.Text = "{?}";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(932, 116);
            panel3.TabIndex = 2;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(268, 123);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(932, 597);
            panelContainer.TabIndex = 5;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormStudentAccess";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            panel6.ResumeLayout(false);
            panelExpand.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonAppeal;
        private Button buttonDashboard;
        private Panel panel5;
        private Panel panelSlide;
        private Label label1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerDateAndTime;
        private Panel panel2;
        private Panel panelBack;
        private Button buttonDown;
        private Panel panelExpand;
        private Panel panel4;
        private Button buttonLogout;
        private Button buttonMinimize;
        private PictureBox pictureBox2;
        private Label labelTime;
        private Panel panel3;
        private Panel panelContainer;
        private Panel panel6;
        private Button pictureBoxClose;
        private Button pictureBoxMinimize;
    }
}