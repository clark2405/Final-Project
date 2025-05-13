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
    public partial class FormStudentAccess : Form
    {
        private Button currentButton; // Track the currently selected button
        public string Username, Role;
        public int StudentID { get; set; }
        public string StudentName { get; set; }

        // Modified constructor to accept role parameter
        public FormStudentAccess(string role = "", string username = "", int studentId = 0, string studentName = "")
        {
            InitializeComponent();

            // Set the properties from parameters
            this.Role = role;
            this.Username = username;
            this.StudentID = studentId;
            this.StudentName = studentName;

            // Ensure panelSlide is properly initialized
            panelSlide.Size = new Size(8, 47); // Set appropriate size
            panelSlide.BackColor = Color.White;  // Set color
            panelSlide.Visible = false; // Start hidden
            showDashboard();
            // Add panelSlide to the panel containing the buttons
            panel1.Controls.Add(panelSlide);

            timerDateAndTime.Start();
        }

        // Remove the FormMain_Load method as it's redundant
        // Keep only the FormStudentAccess_Load method

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showDashboard()
        {
            UserControlStudentDashboard userControStudentlDashboard = new UserControlStudentDashboard(FormLogin.LoggedInUserID);
            userControStudentlDashboard.Dock = DockStyle.Fill;
            userControStudentlDashboard.BringToFront();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControStudentlDashboard);
        }

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

        private void FormStudentAccess_Load(object sender, EventArgs e)
        {
            panelExpand.Hide();

            // Set the role label text - this happens automatically when the form loads
           

            // You might also want to set the username or student name in another label
            // For example: labelUsername.Text = Username;

            if (Role == "Üser")
            {
                buttonDashboard.Hide();
               
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonDashboard);
            UserControlStudentDashboard userControlStudentDashboard = new UserControlStudentDashboard(FormLogin.LoggedInUserID);
            userControlStudentDashboard.Dock = DockStyle.Fill;
            userControlStudentDashboard.BringToFront();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControlStudentDashboard);
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxClose_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                this.Hide(); // Hide the current form
                FormLogin loginForm = new FormLogin();
                loginForm.FormClosed += (s, args) => this.Close(); // Ensure the application closes if the login form is closed
                loginForm.Show();
            }
            else
            {
                panelExpand.Hide();
            }
        }

        private void buttonDown_Click_1(object sender, EventArgs e)
        {
            panelExpand.Visible = !panelExpand.Visible;
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
           
            UserControlStudentAnalyticsReport userControlStudentAnalyticsReport = new UserControlStudentAnalyticsReport();
            userControlStudentAnalyticsReport.Dock = DockStyle.Fill;
            userControlStudentAnalyticsReport.BringToFront();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControlStudentAnalyticsReport);
        }

        private void timerDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("f");
        }

        private void timerDateAndTime_Tick_1(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            labelTime.Text = now.ToString("f");
        }

        private void pictureBoxClose_Click_2(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                timerDateAndTime.Stop();
                this.Hide(); // Hide the current form
                FormLogin loginForm = new FormLogin();
                loginForm.FormClosed += (s, args) => this.Close(); // Ensure the application closes if the login form is closed
                loginForm.Show();
            }
            else
            {
                panelExpand.Hide();
            }
        }

        private void pictureBoxMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonAppeal_Click(object sender, EventArgs e)
        {
            MoveSidePanel(buttonAppeal);
            UserControlStudentAppeal userControlStudentAppeal = new UserControlStudentAppeal(FormLogin.LoggedInUserID);
            userControlStudentAppeal.Dock = DockStyle.Fill;
            userControlStudentAppeal.BringToFront();
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControlStudentAppeal);
        }
    }
}
