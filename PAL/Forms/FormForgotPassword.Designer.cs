namespace Final_Project.PAL.Forms
{
    partial class FormForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgotPassword));
            panel1 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            buttonsend = new Button();
            panel2 = new Panel();
            pictureBoxError = new PictureBox();
            buttonVerify = new Button();
            textBoxEmail = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBoxClose = new PictureBox();
            toolTip1 = new ToolTip(components);
            panel3 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonsend);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBoxError);
            panel1.Controls.Add(buttonVerify);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBoxClose);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 482);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(107, 365);
            label4.Name = "label4";
            label4.Size = new Size(408, 16);
            label4.TabIndex = 16;
            label4.Text = "Input the OTP verification code that you received in your email";
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Location = new Point(157, 412);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 2);
            panel4.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 10F);
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Location = new Point(157, 384);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 21);
            textBox1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(274, 300);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 13;
            label3.Text = "00:00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 273);
            label2.Name = "label2";
            label2.Size = new Size(375, 16);
            label2.TabIndex = 12;
            label2.Text = "A new OTP code will be generated when the time expires";
            // 
            // buttonsend
            // 
            buttonsend.BackColor = Color.Maroon;
            buttonsend.ForeColor = Color.White;
            buttonsend.Location = new Point(250, 323);
            buttonsend.Name = "buttonsend";
            buttonsend.Size = new Size(94, 29);
            buttonsend.TabIndex = 11;
            buttonsend.Text = "Send";
            buttonsend.UseVisualStyleBackColor = false;
            buttonsend.Click += buttonsend_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(157, 259);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 0;
            // 
            // pictureBoxError
            // 
            pictureBoxError.Cursor = Cursors.Hand;
            pictureBoxError.Image = (Image)resources.GetObject("pictureBoxError.Image");
            pictureBoxError.Location = new Point(433, 235);
            pictureBoxError.Name = "pictureBoxError";
            pictureBoxError.Size = new Size(19, 17);
            pictureBoxError.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxError.TabIndex = 10;
            pictureBoxError.TabStop = false;
            pictureBoxError.MouseHover += pictureBoxError_MouseHover;
            // 
            // buttonVerify
            // 
            buttonVerify.BackColor = Color.Maroon;
            buttonVerify.Cursor = Cursors.Hand;
            buttonVerify.FlatAppearance.BorderSize = 0;
            buttonVerify.FlatStyle = FlatStyle.Flat;
            buttonVerify.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            buttonVerify.ForeColor = Color.White;
            buttonVerify.Image = (Image)resources.GetObject("buttonVerify.Image");
            buttonVerify.ImageAlign = ContentAlignment.MiddleLeft;
            buttonVerify.Location = new Point(157, 421);
            buttonVerify.Name = "buttonVerify";
            buttonVerify.Size = new Size(270, 38);
            buttonVerify.TabIndex = 2;
            buttonVerify.Text = "Verify";
            buttonVerify.UseVisualStyleBackColor = false;
            buttonVerify.Click += buttonVerify_Click;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Century Gothic", 10F);
            textBoxEmail.ForeColor = Color.DarkGray;
            textBoxEmail.Location = new Point(157, 231);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(270, 21);
            textBoxEmail.TabIndex = 1;
            textBoxEmail.Text = "juandelacruz@gmail.com";
            textBoxEmail.Enter += textBoxEmail_Enter;
            textBoxEmail.Leave += textBoxEmail_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(157, 209);
            label1.Name = "label1";
            label1.Size = new Size(161, 19);
            label1.TabIndex = 7;
            label1.Text = "Username or Email";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(203, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = Properties.Resources.images;
            pictureBoxClose.Location = new Point(526, 12);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(31, 31);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 1;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.MouseHover += pictureBoxClose_MouseHover;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(58, 482);
            panel3.TabIndex = 11;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FormForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(593, 506);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormForgotPassword";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += FormForgotPassword_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxClose;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxError;
        private Button buttonVerify;
        private TextBox textBoxEmail;
        private Label label1;
        private Panel panel2;
        private ToolTip toolTip1;
        private Panel panel3;
        private Button buttonsend;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Panel panel4;
        private TextBox textBox1;
        private Label label4;
    }
}