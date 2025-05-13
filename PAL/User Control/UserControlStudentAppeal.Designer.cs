namespace Final_Project.PAL.User_Control
{
    partial class UserControlStudentAppeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlStudentAppeal));
            dataGridAppeal = new DataGridView();
            richTextBoxStudentAppeal = new RichTextBox();
            buttonSubmitAppeal = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridAppeal).BeginInit();
            SuspendLayout();
            // 
            // dataGridAppeal
            // 
            dataGridAppeal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAppeal.BackgroundColor = Color.White;
            dataGridAppeal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAppeal.Location = new Point(19, 15);
            dataGridAppeal.Name = "dataGridAppeal";
            dataGridAppeal.ReadOnly = true;
            dataGridAppeal.RowHeadersWidth = 51;
            dataGridAppeal.Size = new Size(880, 323);
            dataGridAppeal.TabIndex = 10;
            dataGridAppeal.CellClick += dataGridAppeal_CellClick;
            dataGridAppeal.CellContentClick += dataGridAppeal_CellContentClick;
            dataGridAppeal.RowHeaderMouseClick += dataGridAppeal_RowHeaderMouseClick;
            // 
            // richTextBoxStudentAppeal
            // 
            richTextBoxStudentAppeal.BorderStyle = BorderStyle.FixedSingle;
            richTextBoxStudentAppeal.Location = new Point(19, 354);
            richTextBoxStudentAppeal.Name = "richTextBoxStudentAppeal";
            richTextBoxStudentAppeal.Size = new Size(880, 156);
            richTextBoxStudentAppeal.TabIndex = 11;
            richTextBoxStudentAppeal.Text = "";
            // 
            // buttonSubmitAppeal
            // 
            buttonSubmitAppeal.BackColor = Color.Maroon;
            buttonSubmitAppeal.Cursor = Cursors.Hand;
            buttonSubmitAppeal.FlatAppearance.BorderSize = 0;
            buttonSubmitAppeal.FlatStyle = FlatStyle.Flat;
            buttonSubmitAppeal.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold);
            buttonSubmitAppeal.ForeColor = Color.White;
            buttonSubmitAppeal.Image = (Image)resources.GetObject("buttonSubmitAppeal.Image");
            buttonSubmitAppeal.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSubmitAppeal.Location = new Point(701, 534);
            buttonSubmitAppeal.Name = "buttonSubmitAppeal";
            buttonSubmitAppeal.Size = new Size(198, 45);
            buttonSubmitAppeal.TabIndex = 15;
            buttonSubmitAppeal.Text = "Submit Appeal";
            buttonSubmitAppeal.UseVisualStyleBackColor = false;
            buttonSubmitAppeal.Click += buttonSubmitAppeal_Click;
            // 
            // UserControlStudentAppeal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(buttonSubmitAppeal);
            Controls.Add(richTextBoxStudentAppeal);
            Controls.Add(dataGridAppeal);
            Name = "UserControlStudentAppeal";
            Size = new Size(932, 597);
            ((System.ComponentModel.ISupportInitialize)dataGridAppeal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridAppeal;
        private RichTextBox richTextBoxStudentAppeal;
        private Button buttonSubmitAppeal;
    }
}
