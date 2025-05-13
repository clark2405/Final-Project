using OpenTK.Graphics.ES20;
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

namespace Final_Project.PAL.User_Control
{
    public partial class UserControlStudentDashboard : UserControl
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Database Files\Attendance Management\DatabaseHere (Final).accdb";
        public int UserID { get; set; }
        public UserControlStudentDashboard(int userID)
        {
            InitializeComponent();
            UserID = userID;
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
                        cmd.Parameters.AddWithValue("@StudentID", UserID);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string studentName = result.ToString();
                            labelUsername.Text = studentName; // Store the StudentName in labelUsername
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
                    string query = @"SELECT AddStudent.Class, Attendance.AttendanceDate, Attendance.Status
            FROM AddStudent LEFT JOIN Attendance ON AddStudent.StudentID = Attendance.StudentID
            WHERE AddStudent.Name = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("?", labelUsername.Text); // Use the name retrieved by GetName

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                dataGridAttendance.AutoGenerateColumns = true;
                                dataGridAttendance.DataSource = dt;
                                dataGridAttendance.Refresh(); // Ensure the DataGridView refreshes to display data
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
    }
}