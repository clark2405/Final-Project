using Final_Project.PAL.User_Control;
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
            showDashboard();
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
                this.Hide(); // Hide the current form  
                FormLogin formLogin = new FormLogin(); // Create a new instance of FormLogin  
                formLogin.Show(); // Show the login form  
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
        private void showDashboard()
        {
            UserControlDashboard userControlDashboard = new UserControlDashboard(FormLogin.LoggedInUserID);
            userControlDashboard.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControlDashboard);
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            UserControlDashboard userControlDashboard = new UserControlDashboard(FormLogin.LoggedInUserID);
            userControlDashboard.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControlDashboard);
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAttendance);
            UserControlAttendance userControlAttendance = new UserControlAttendance(FormLogin.LoggedInUserID);
            userControlAttendance.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControlAttendance);

        }

        private void buttonAddClass_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddClass);
            UserControlAddClass userControlAddClass = new UserControlAddClass(FormLogin.LoggedInUserID);
            userControlAddClass.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControlAddClass);
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAddStudent);
            UserControl1AddStudentcs userControlAddStudent = new UserControl1AddStudentcs(FormLogin.LoggedInUserID);
            userControlAddStudent.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControlAddStudent);
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonReport);
            UserControlAnalyticsReport userControlAnalyticsReport = new UserControlAnalyticsReport(FormLogin.LoggedInUserID);
            userControlAnalyticsReport.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControlAnalyticsReport);

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonRegister);
            UserControlRegister userControlRegister = new UserControlRegister(FormLogin.LoggedInUserID);
            userControlRegister.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControlRegister);
        }

        private void buttonMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                this.Hide(); // Hide the current form  
                FormLogin formLogin = new FormLogin(); // Create a new instance of FormLogin  
                formLogin.Show(); // Show the login form  
            }
            else
            {
                panelExpand.Hide();
            }
        }
    }
}
