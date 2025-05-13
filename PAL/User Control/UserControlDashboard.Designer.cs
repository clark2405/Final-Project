namespace Final_Project.PAL.User_Control
{
    partial class UserControlDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDashboard));
            panel1 = new Panel();
            labelTotalClasses = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            labelTotalStudent = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(253, 183, 71);
            panel1.Controls.Add(labelTotalClasses);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(115, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 128);
            panel1.TabIndex = 0;
            // 
            // labelTotalClasses
            // 
            labelTotalClasses.AutoSize = true;
            labelTotalClasses.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelTotalClasses.ForeColor = Color.White;
            labelTotalClasses.Location = new Point(123, 66);
            labelTotalClasses.Name = "labelTotalClasses";
            labelTotalClasses.Size = new Size(35, 23);
            labelTotalClasses.TabIndex = 2;
            labelTotalClasses.Text = "{?}";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(97, 47);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 1;
            label1.Text = "Classes";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.SandyBrown;
            panel2.Controls.Add(labelTotalStudent);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(571, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 128);
            panel2.TabIndex = 3;
            // 
            // labelTotalStudent
            // 
            labelTotalStudent.AutoSize = true;
            labelTotalStudent.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            labelTotalStudent.ForeColor = Color.White;
            labelTotalStudent.Location = new Point(123, 66);
            labelTotalStudent.Name = "labelTotalStudent";
            labelTotalStudent.Size = new Size(35, 23);
            labelTotalStudent.TabIndex = 2;
            labelTotalStudent.Text = "{?}";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(97, 47);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 1;
            label3.Text = "Student";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // UserControlDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9.75F);
            Margin = new Padding(4);
            Name = "UserControlDashboard";
            Size = new Size(942, 501);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label labelTotalClasses;
        private Label label1;
        private Panel panel2;
        private Label labelTotalStudent;
        private Label label3;
        private PictureBox pictureBox2;

    }
}
