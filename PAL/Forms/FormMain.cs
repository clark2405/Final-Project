using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.PAL.Forms
{
    public partial class FormMain : Form
    {
        private Button currentButton; // Track the currently selected button
        public string Username, Role;

        public FormMain()
        {
            InitializeComponent();

            // Ensure panelSlide is properly initialized
            panelSlide.Size = new Size(8, 47); // Set appropriate size
            panelSlide.BackColor = Color.White;  // Set color
            panelSlide.Visible = false; // Start hidden

            // Add panelSlide to the panel containing the buttons
            panel1.Controls.Add(panelSlide);

            timerDateAndTime.Start();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                Application.Exit(); // ✅ Ensures the full application closes
            }
            else
            {
                panelExpand.Hide();
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            panelExpand.Visible = !panelExpand.Visible;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();
            labelUsername.Text = Username;
            labelRole.Text = Role;

            if (Role == "Üser")
            {
                buttonDashboard.Hide();
                buttonAddClass.Hide();
                buttonAddStudent.Hide();
                buttonRegister.Hide();
            }
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("f");
        }

        // ✅ Fix: Move panelSlide to the clicked button and handle button visibility
        private void MoveSidePanel(Button button)
        {
            if (panelSlide != null) // Check if panelSlide is initialized
            {
                panelSlide.Visible = true; // Ensure it's visible
                panelSlide.BringToFront(); // Bring it above other controls
                panelSlide.Location = new Point(button.Left - panelSlide.Width, button.Top); // Align with button
                panelSlide.Size = new Size(panelSlide.Width, button.Height); // Resize to match button

                if (currentButton != null)
                {
                    currentButton.BackColor = Color.Maroon; // Reset the color of the previously selected button
                }

                currentButton = button; // Update the currently selected button
                currentButton.BackColor = Color.Transparent; // Change the color of the currently selected button to transparent
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            userControlAddClass1.Visible = false;
            userControlDashboard1.Count();
            userControlDashboard1.Visible = true;
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            userControlAddClass1.Visible = false;
            userControlDashboard1.Visible = false;
        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddClass);
            userControlAddClass1.Visible = true;
            userControlDashboard1.Visible = false;
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStudent);
            userControlAddClass1.Visible = false;
            userControlDashboard1.Visible = false;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            userControlAddClass1.Visible = false;
            userControlDashboard1.Visible = false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonRegister);
            userControlAddClass1.Visible = false;
            userControlDashboard1.Visible = false;
        }
    }
}
