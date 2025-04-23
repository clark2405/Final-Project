namespace Final_Project.PAL.Forms
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            panel1 = new Panel();
            radioButton1 = new RadioButton();
            buttonVerify = new Button();
            panel4 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            textBoxEmail = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(buttonVerify);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(551, 435);
            panel1.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(140, 385);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(131, 24);
            radioButton1.TabIndex = 15;
            radioButton1.TabStop = true;
            radioButton1.Text = "Show Password";
            radioButton1.UseVisualStyleBackColor = true;
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
            buttonVerify.Location = new Point(329, 381);
            buttonVerify.Name = "buttonVerify";
            buttonVerify.Size = new Size(139, 30);
            buttonVerify.TabIndex = 14;
            buttonVerify.Text = "Verify";
            buttonVerify.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightGray;
            panel4.Location = new Point(140, 358);
            panel4.Name = "panel4";
            panel4.Size = new Size(328, 2);
            panel4.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 10F);
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Location = new Point(140, 330);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 21);
            textBox1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(140, 308);
            label2.Name = "label2";
            label2.Size = new Size(238, 19);
            label2.TabIndex = 13;
            label2.Text = "Confirm your new password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Location = new Point(140, 282);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 2);
            panel2.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Century Gothic", 10F);
            textBoxEmail.ForeColor = Color.DarkGray;
            textBoxEmail.Location = new Point(140, 254);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(328, 21);
            textBoxEmail.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(140, 232);
            label1.Name = "label1";
            label1.Size = new Size(213, 19);
            label1.TabIndex = 10;
            label1.Text = "Enter your new password";
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
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(58, 435);
            panel3.TabIndex = 12;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(575, 459);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePassword";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox textBoxEmail;
        private Label label1;
        private Panel panel4;
        private TextBox textBox1;
        private Label label2;
        private RadioButton radioButton1;
        private Button buttonVerify;
    }
}