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
            panel5 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            textBox2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            panel7 = new Panel();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            textBox3 = new TextBox();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(label5);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(button2);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(587, 12);
            panel5.Name = "panel5";
            panel5.Size = new Size(569, 482);
            panel5.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(107, 365);
            label5.Name = "label5";
            label5.Size = new Size(408, 16);
            label5.TabIndex = 16;
            label5.Text = "Input the OTP verification code that you received in your email";
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightGray;
            panel6.Location = new Point(157, 412);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 10F);
            textBox2.ForeColor = Color.DarkGray;
            textBox2.Location = new Point(157, 384);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 21);
            textBox2.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(274, 300);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 13;
            label6.Text = "00:00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 7.20000029F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(121, 273);
            label7.Name = "label7";
            label7.Size = new Size(375, 16);
            label7.TabIndex = 12;
            label7.Text = "A new OTP code will be generated when the time expires";
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.ForeColor = Color.White;
            button1.Location = new Point(250, 323);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightGray;
            panel7.Location = new Point(157, 259);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 2);
            panel7.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(433, 235);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(19, 17);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(157, 421);
            button2.Name = "button2";
            button2.Size = new Size(270, 38);
            button2.TabIndex = 2;
            button2.Text = "Verify";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 10F);
            textBox3.ForeColor = Color.DarkGray;
            textBox3.Location = new Point(157, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 21);
            textBox3.TabIndex = 1;
            textBox3.Text = "juandelacruz@gmail.com";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(157, 209);
            label8.Name = "label8";
            label8.Size = new Size(161, 19);
            label8.TabIndex = 7;
            label8.Text = "Username or Email";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(572, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(158, 146);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = Properties.Resources.images;
            pictureBox4.Location = new Point(895, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 31);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // FormForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(1167, 506);
            Controls.Add(panel5);
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
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
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
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private TextBox textBox2;
        private Label label6;
        private Label label7;
        private Button button1;
        private Panel panel7;
        private PictureBox pictureBox2;
        private Button button2;
        private TextBox textBox3;
        private Label label8;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}