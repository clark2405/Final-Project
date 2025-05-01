using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.PAL.Forms
{
    public partial class FormLogin : Form
    {
        OleDbConnection Account_DataBase_Conn;
        OleDbCommand Account_DataBase_Command;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\joshlee rash\Downloads\DatabaseHere.accdb";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
            pictureBoxHide.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            pictureBoxError.Hide();
            labelError.Hide();

            // Set password character
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin.PerformClick();
                e.Handled = true;
            }
        }

        private void labelFP_Click(object sender, EventArgs e)
        {
            FormForgotPassword formForgotPassword = new FormForgotPassword();
            formForgotPassword.ShowDialog();
        }

        private bool Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                labelError.Text = "Please enter your Name and Password";
                labelError.Show();
                pictureBoxError.Show();
                return false;
            }

            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Try logging in as a teacher
                    string teacherQuery = "SELECT TeacherID, TeacherName FROM TeacherAccount WHERE TeacherName = ? AND Password = ?";
                    using (OleDbCommand teacherCmd = new OleDbCommand(teacherQuery, conn))
                    {
                        teacherCmd.Parameters.AddWithValue("?", username); // Using TeacherName as username
                        teacherCmd.Parameters.AddWithValue("?", password);

                        using (OleDbDataReader teacherReader = teacherCmd.ExecuteReader())
                        {
                            if (teacherReader.Read())
                            {
                                string loggedInTeacherName = teacherReader["TeacherName"].ToString();
                                int teacherID = Convert.ToInt32(teacherReader["TeacherID"]);

                                FormMain mainForm = new FormMain
                                {
                                    Username = loggedInTeacherName,
                                    Role = "Teacher"
                                };

                                this.Hide();
                                mainForm.FormClosed += (s, args) => this.Close();
                                mainForm.Show();
                                return true; // Login successful as teacher
                            }
                        }
                    }

                    // If teacher login failed, try logging in as a student
                    string studentQuery = "SELECT StudentID, StudentName FROM StudentAccount WHERE StudentName = ? AND Password = ?";
                    using (OleDbCommand studentCmd = new OleDbCommand(studentQuery, conn))
                    {
                        studentCmd.Parameters.AddWithValue("?", username); // Using StudentName as username
                        studentCmd.Parameters.AddWithValue("?", password);

                        using (OleDbDataReader studentReader = studentCmd.ExecuteReader())
                        {
                            if (studentReader.Read())
                            {
                                int studentID = Convert.ToInt32(studentReader["StudentID"]);
                                string loggedInStudentName = studentReader["StudentName"].ToString();

                                FormStudentAccess studentAccessForm = new FormStudentAccess
                                {
                                    StudentID = studentID,
                                    StudentName = loggedInStudentName
                                };

                                this.Hide();
                                studentAccessForm.FormClosed += (s, args) => this.Close();
                                studentAccessForm.Show();
                                return true; // Login successful as student
                            }
                        }
                    }

                    // If neither teacher nor student login was successful
                    labelError.Text = "Invalid Name or Password";
                    labelError.Show();
                    pictureBoxError.Show();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // For testing purposes - you can use this to bypass the database check

        // Add this button to your form for testing
        private void buttonTestLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string username = textBoxName.Text;
            string password = textBoxPassword.Text;
            Login(username, password);
        }
    }
}