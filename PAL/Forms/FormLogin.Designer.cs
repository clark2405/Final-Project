namespace Final_Project.PAL.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBoxClose = new PictureBox();
            pictureBoxMinimize = new PictureBox();
            groupBox1 = new GroupBox();
            textBoxPassword = new TextBox();
            labelFP = new Label();
            pictureBoxError = new PictureBox();
            labelError = new Label();
            pictureBoxShow = new PictureBox();
            pictureBoxHide = new PictureBox();
            label2 = new Label();
            buttonLogin = new Button();
            textBoxName = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            fileSystemWatcher1 = new FileSystemWatcher();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = Properties.Resources.images;
            pictureBoxClose.Location = new Point(1157, 12);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(31, 31);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.MouseHover += pictureBoxClose_MouseHover;
            // 
            // pictureBoxMinimize
            // 
            pictureBoxMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimize.Cursor = Cursors.Hand;
            pictureBoxMinimize.Image = (Image)resources.GetObject("pictureBoxMinimize.Image");
            pictureBoxMinimize.Location = new Point(1120, 12);
            pictureBoxMinimize.Name = "pictureBoxMinimize";
            pictureBoxMinimize.Size = new Size(31, 31);
            pictureBoxMinimize.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimize.TabIndex = 1;
            pictureBoxMinimize.TabStop = false;
            pictureBoxMinimize.Click += pictureBoxMinimize_Click;
            pictureBoxMinimize.MouseHover += pictureBoxMinimize_MouseHover;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(labelFP);
            groupBox1.Controls.Add(pictureBoxError);
            groupBox1.Controls.Add(labelError);
            groupBox1.Controls.Add(pictureBoxShow);
            groupBox1.Controls.Add(pictureBoxHide);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Century Gothic", 10F);
            groupBox1.Location = new Point(107, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 348);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please Login";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(95, 166);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(241, 28);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.KeyPress += textBoxPassword_KeyPress;
            textBoxPassword.KeyUp += textBoxPassword_KeyUp;
            // 
            // labelFP
            // 
            labelFP.AutoSize = true;
            labelFP.Cursor = Cursors.Hand;
            labelFP.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFP.ForeColor = Color.Maroon;
            labelFP.Location = new Point(158, 239);
            labelFP.Name = "labelFP";
            labelFP.Size = new Size(152, 19);
            labelFP.TabIndex = 7;
            labelFP.Text = "Forgot Password?";
            labelFP.Click += labelFP_Click;
            // 
            // pictureBoxError
            // 
            pictureBoxError.Cursor = Cursors.Hand;
            pictureBoxError.Image = (Image)resources.GetObject("pictureBoxError.Image");
            pictureBoxError.Location = new Point(95, 202);
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.Size = new Size(25, 25);
            pictureBoxError.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxError.TabIndex = 6;
            pictureBoxError.TabStop = false;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelError.ForeColor = Color.FromArgb(234, 73, 73);
            labelError.Location = new Point(124, 207);
            labelError.Name = "labelError";
            labelError.Size = new Size(230, 20);
            labelError.TabIndex = 5;
            labelError.Text = "Invalid Username or Password";
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShow.Cursor = Cursors.Hand;
            pictureBoxShow.Image = (Image)resources.GetObject("pictureBoxShow.Image");
            pictureBoxShow.Location = new Point(335, 166);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(25, 28);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShow.TabIndex = 4;
            pictureBoxShow.TabStop = false;
            pictureBoxShow.Click += pictureBoxShow_Click;
            pictureBoxShow.MouseHover += pictureBoxShow_MouseHover;
            // 
            // pictureBoxHide
            // 
            pictureBoxHide.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHide.Cursor = Cursors.Hand;
            pictureBoxHide.Image = (Image)resources.GetObject("pictureBoxHide.Image");
            pictureBoxHide.Location = new Point(335, 166);
            pictureBoxHide.Name = "pictureBoxHide";
            pictureBoxHide.Size = new Size(25, 28);
            pictureBoxHide.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHide.TabIndex = 2;
            pictureBoxHide.TabStop = false;
            pictureBoxHide.Click += pictureBoxHide_Click;
            pictureBoxHide.MouseHover += pictureBoxHide_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 135);
            label2.Name = "label2";
            label2.Size = new Size(92, 19);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.Maroon;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Image = Properties.Resources.arrow_right__1_;
            buttonLogin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogin.Location = new Point(93, 272);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(265, 38);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Log In";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click_1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(95, 92);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(265, 28);
            textBoxName.TabIndex = 1;
            textBoxName.KeyPress += textBoxName_KeyPress;
            textBoxName.KeyUp += textBoxName_KeyUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 59);
            label1.Name = "label1";
            label1.Size = new Size(96, 19);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(607, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(5, 408);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(800, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(234, 73, 73);
            label3.Location = new Point(814, 419);
            label3.Name = "label3";
            label3.Size = new Size(172, 34);
            label3.TabIndex = 8;
            label3.Text = "CheckPoint";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(234, 73, 73);
            label4.Location = new Point(665, 462);
            label4.Name = "label4";
            label4.Size = new Size(470, 34);
            label4.TabIndex = 9;
            label4.Text = "Attendance Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Location = new Point(-16, 663);
            panel2.Name = "panel2";
            panel2.Size = new Size(1222, 60);
            panel2.TabIndex = 10;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBoxMinimize);
            Controls.Add(pictureBoxClose);
            Font = new Font("Century Gothic", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimize).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxMinimize;
        private GroupBox groupBox1;
        private TextBox textBoxPassword;
        private Label label2;
        private Button buttonLogin;
        private TextBox textBoxName;
        private Label label1;
        private PictureBox pictureBoxHide;
        private PictureBox pictureBoxShow;
        private PictureBox pictureBoxError;
        private Label labelError;
        private Label labelFP;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private FileSystemWatcher fileSystemWatcher1;
        private ToolTip toolTip1;
    }
}