using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Final_Project.PAL.User_Control
{
    public partial class UserControlDashboard : UserControl
    {
        private string accessConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Database Files\Attendance Management\DatabaseHere (Final).accdb";
        public int UserID { get; set; }

        public UserControlDashboard(int userID)
        {
            InitializeComponent();
            UserID = userID;
            Count();
        }

        public void Count()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(accessConnectionString))
                {
                    connection.Open();

                    // Query to count classes owned by the current user  
                    string classQuery = "SELECT COUNT(*) FROM Class WHERE TeacherID = @UserID";
                    OleDbCommand classCmd = new OleDbCommand(classQuery, connection);
                    classCmd.Parameters.AddWithValue("@UserID", UserID);
                    int classCount = (int)classCmd.ExecuteScalar();

                    // Query to count students added by the current user  
                    string studentQuery = "SELECT COUNT(*) FROM AddStudent WHERE TeacherID = @UserID";
                    OleDbCommand studentCmd = new OleDbCommand(studentQuery, connection);
                    studentCmd.Parameters.AddWithValue("@UserID", UserID);
                    int studentCount = (int)studentCmd.ExecuteScalar();

                    // Update UI labels  
                    labelTotalClasses.Text = classCount.ToString();
                    labelTotalStudent.Text = studentCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
