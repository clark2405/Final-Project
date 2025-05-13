namespace Final_Project.PAL.User_Control
{
    partial class UserControlStudentAnalyticsReport
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
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            dailyToolStripMenuItem = new ToolStripMenuItem();
            weeklyToolStripMenuItem = new ToolStripMenuItem();
            monthlyToolStripMenuItem = new ToolStripMenuItem();
            yearlyToolStripMenuItem = new ToolStripMenuItem();
            studentsData = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 41);
            panel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dailyToolStripMenuItem, weeklyToolStripMenuItem, monthlyToolStripMenuItem, yearlyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(932, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dailyToolStripMenuItem
            // 
            dailyToolStripMenuItem.Name = "dailyToolStripMenuItem";
            dailyToolStripMenuItem.Size = new Size(57, 24);
            dailyToolStripMenuItem.Text = "Daily";
            // 
            // weeklyToolStripMenuItem
            // 
            weeklyToolStripMenuItem.Name = "weeklyToolStripMenuItem";
            weeklyToolStripMenuItem.Size = new Size(70, 24);
            weeklyToolStripMenuItem.Text = "Weekly";
            // 
            // monthlyToolStripMenuItem
            // 
            monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
            monthlyToolStripMenuItem.Size = new Size(77, 24);
            monthlyToolStripMenuItem.Text = "Monthly";
            // 
            // yearlyToolStripMenuItem
            // 
            yearlyToolStripMenuItem.Name = "yearlyToolStripMenuItem";
            yearlyToolStripMenuItem.Size = new Size(62, 24);
            yearlyToolStripMenuItem.Text = "Yearly";
            // 
            // studentsData
            // 
            studentsData.Dock = DockStyle.Fill;
            studentsData.Location = new Point(0, 0);
            studentsData.MatchAxesScreenDataRatio = false;
            studentsData.Name = "studentsData";
            studentsData.Size = new Size(932, 597);
            studentsData.TabIndex = 2;
            // 
            // UserControlStudentAnalyticsReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(studentsData);
            Name = "UserControlStudentAnalyticsReport";
            Size = new Size(932, 597);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dailyToolStripMenuItem;
        private ToolStripMenuItem weeklyToolStripMenuItem;
        private ToolStripMenuItem monthlyToolStripMenuItem;
        private ToolStripMenuItem yearlyToolStripMenuItem;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart studentsData;
    }
}
