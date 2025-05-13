using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.PAL.User_Control
{
    public partial class UserControlStudentAppeal : UserControl
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Database Files\Attendance Management\DatabaseHere (Final).accdb";
        public string Name { get; set; }
        public int UserId { get; set; }
        public UserControlStudentAppeal(int userID)
        {
            InitializeComponent();
            UserId = userID;
            GetName();
            LoadAttendance();
        }
        private void GetName()
        {
            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                try
                {
                    myConn.Open();
                    string query = "SELECT StudentName FROM StudentAccount WHERE StudentID = @StudentID";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", UserId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string studentName = result.ToString();
                            Name = studentName; // Store the StudentName in labelUsername
                        }
                        else
                        {
                            MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
      private void LoadAttendance()
{
    using (OleDbConnection myConn = new OleDbConnection(connectionString))
    {
        try
        {
            myConn.Open();
            string query = @"SELECT AddStudent.Class, Attendance.AttendanceDate, Attendance.Status, Attendance.TeacherID
                             FROM AddStudent 
                             LEFT JOIN Attendance ON AddStudent.StudentID = Attendance.StudentID
                             WHERE AddStudent.Name = ?";

            using (OleDbCommand cmd = new OleDbCommand(query, myConn))
            {
                cmd.Parameters.AddWithValue("?", Name); // Use the name retrieved by GetName

                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridAppeal.AutoGenerateColumns = true;
                        dataGridAppeal.DataSource = dt;
                        dataGridAppeal.Refresh(); // Ensure the DataGridView refreshes to display data
                    }
                    else
                    {
                        MessageBox.Show("No attendance records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

        private void buttonSubmitAppeal_Click(object sender, EventArgs e)
        {
            try
            {
                string appealMessage = richTextBoxStudentAppeal.Text.Trim();
                if (string.IsNullOrWhiteSpace(appealMessage))
                {
                    MessageBox.Show("The appeal message cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get the selected row from the DataGridView
                if (dataGridAppeal.SelectedRows.Count == 0 && dataGridAppeal.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Please select an attendance record to appeal.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataGridViewRow selectedRow;
                if (dataGridAppeal.SelectedRows.Count > 0)
                {
                    selectedRow = dataGridAppeal.SelectedRows[0];
                }
                else
                {
                    selectedRow = dataGridAppeal.Rows[dataGridAppeal.SelectedCells[0].RowIndex];
                }

                // Get the TeacherID from the selected row
                if (selectedRow.Cells["TeacherID"].Value == null)
                {
                    MessageBox.Show("No teacher found for the selected attendance record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int teacherId = Convert.ToInt32(selectedRow.Cells["TeacherID"].Value);
                string teacherEmail = GetTeacherEmailById(teacherId);
                string studentEmail = GetStudentEmailById(UserId);

                if (string.IsNullOrEmpty(teacherEmail))
                {
                    MessageBox.Show("Unable to retrieve teacher's email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(studentEmail))
                {
                    MessageBox.Show("Unable to retrieve your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Prepare and send the email
                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress(studentEmail),
                    Subject = "Appeal for Attendance Correction",
                    Body = appealMessage
                };
                mailMessage.To.Add(teacherEmail);

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new System.Net.NetworkCredential("clarkjaca@gmail.com", "aqrd tszf pecv iibd"),
                    EnableSsl = true
                };

                smtpClient.Send(mailMessage);

                MessageBox.Show("Your appeal has been successfully sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBoxStudentAppeal.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while sending the appeal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridAppeal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked row is valid
            {
                DataGridViewRow row = dataGridAppeal.Rows[e.RowIndex];
                string className = row.Cells["Class"].Value?.ToString();
                string attendanceDate = row.Cells["AttendanceDate"].Value?.ToString()?.Split(' ')[0]; // Extract only the date part
                string status = row.Cells["Status"].Value?.ToString();

                if (!string.IsNullOrEmpty(className) && !string.IsNullOrEmpty(attendanceDate) && !string.IsNullOrEmpty(status))
                {
                    richTextBoxStudentAppeal.Text = $"I would like to appeal the attendance record for the class '{className}' on {attendanceDate}. The current status is marked as '{status}', and I believe this is incorrect. Please review and correct this record. Thank you.";
                }
            }
        }

        private void dataGridAppeal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked row is valid
            {
                DataGridViewRow row = dataGridAppeal.Rows[e.RowIndex];
                string className = row.Cells["Class"].Value?.ToString();

                if (!string.IsNullOrEmpty(className))
                {
                    try
                    {
                        // Query to get the TeacherID based on the selected class
                        string query = "SELECT TeacherID FROM AddStudent WHERE Class = ?";

                        using (OleDbConnection myConn = new OleDbConnection(connectionString))
                        {
                            myConn.Open();
                            using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                            {
                                cmd.Parameters.AddWithValue("?", className);

                                object result = cmd.ExecuteScalar();
                                if (result != null)
                                {
                                    int teacherId = Convert.ToInt32(result);

                                    // Fetch the teacher's email using the TeacherID
                                    string teacherEmail = GetTeacherEmailById(teacherId);

                                    if (!string.IsNullOrEmpty(teacherEmail))
                                    {
                                        MessageBox.Show($"Teacher Email: {teacherEmail}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Unable to retrieve the teacher's email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No teacher found for the selected class.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridAppeal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked row is valid
            {
                DataGridViewRow row = dataGridAppeal.Rows[e.RowIndex];
                string className = row.Cells["Class"].Value?.ToString();
                string attendanceDate = row.Cells["AttendanceDate"].Value?.ToString()?.Split(' ')[0]; // Extract only the date part
                string status = row.Cells["Status"].Value?.ToString();

                if (!string.IsNullOrEmpty(className) && !string.IsNullOrEmpty(attendanceDate) && !string.IsNullOrEmpty(status))
                {
                    richTextBoxStudentAppeal.Text = $"I would like to appeal the attendance record for the class '{className}' on {attendanceDate}. The current status is marked as '{status}', and I believe this is incorrect. Please review and correct this record. Thank you.";
                }
            }
        }

        //private void buttonSubmitAppeal_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        // Updated query to fetch TeacherID based on student's class
        //        string query = @"SELECT TOP 1 Attendance.TeacherID
        //                 FROM AddStudent
        //                 INNER JOIN Attendance ON AddStudent.StudentID = Attendance.StudentID
        //                 WHERE AddStudent.StudentID = ?"; // This is the StudentID of the logged-in user

        //        using (OleDbConnection myConn = new OleDbConnection(connectionString))
        //        {
        //            myConn.Open();
        //            using (OleDbCommand cmd = new OleDbCommand(query, myConn))
        //            {
        //                cmd.Parameters.AddWithValue("?", UserId); // Use the current logged-in student ID

        //                using (OleDbDataReader reader = cmd.ExecuteReader())
        //                {
        //                    if (reader.Read())
        //                    {
        //                        int teacherId = Convert.ToInt32(reader["TeacherID"]);

        //                        // Fetch emails
        //                        string teacherEmail = GetTeacherEmailById(teacherId);
        //                        string studentEmail = GetStudentEmailById(UserId);

        //                        if (string.IsNullOrEmpty(teacherEmail) || string.IsNullOrEmpty(studentEmail))
        //                        {
        //                            MessageBox.Show("Unable to retrieve email addresses.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                            return;
        //                        }

        //                        string appealMessage = richTextBoxStudentAppeal.Text.Trim();

        //                        if (string.IsNullOrWhiteSpace(appealMessage))
        //                        {
        //                            MessageBox.Show("The appeal message cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                            return;
        //                        }

        //                        // Send email
        //                        MailMessage mailMessage = new MailMessage
        //                        {
        //                            From = new MailAddress(studentEmail),
        //                            Subject = "Appeal for Attendance Correction",
        //                            Body = appealMessage
        //                        };
        //                        mailMessage.To.Add(teacherEmail);

        //                        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
        //                        {
        //                            Credentials = new System.Net.NetworkCredential("clarkjaca@gmail.com", "aqrd tszf pecv iibd"), // Update credentials securely
        //                            EnableSsl = true
        //                        };

        //                        smtpClient.Send(mailMessage);

        //                        MessageBox.Show("Your appeal has been successfully sent.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        richTextBoxStudentAppeal.Clear();
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("No teacher found for your class. Please ensure your attendance records are correctly linked to a teacher.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"An error occurred while sending the appeal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}


        private string GetStudentEmailById(int studentId)
        {
            string email = null;
            string query = "SELECT StudentEmail FROM StudentAccount WHERE StudentID = ?";

            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                try
                {
                    myConn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", studentId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            email = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while retrieving student email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return email;
        }

        private string GetTeacherEmailById(int teacherId)
        {
            string email = null;
            string query = "SELECT TeacherEmail FROM TeacherAccount WHERE TeacherID = ?";

            using (OleDbConnection myConn = new OleDbConnection(connectionString))
            {
                try
                {
                    myConn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", teacherId);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            email = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while retrieving teacher email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return email;
        }
    }
}
