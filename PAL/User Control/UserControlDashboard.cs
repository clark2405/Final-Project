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
        private string accessConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                          Data Source= C:\Users\joshlee rash\Downloads\DatabaseHere.accdb";


        public UserControlDashboard()
        {
            InitializeComponent();
            Count();
        }
        public void Count()
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(accessConnectionString))
                {
                    connection.Open();

                    // Query to count classes from the Class table
                    string classQuery = "SELECT COUNT(*) FROM Class";
                    OleDbCommand classCmd = new OleDbCommand(classQuery, connection);
                    int classCount = (int)classCmd.ExecuteScalar();

                    // Query to count students from the AddStudent table
                    string studentQuery = "SELECT COUNT(*) FROM AddStudent";
                    OleDbCommand studentCmd = new OleDbCommand(studentQuery, connection);
                    int studentCount = (int)studentCmd.ExecuteScalar();

                    // Query to count users from the Users table
                    string roleQuery = "SELECT COUNT(*) FROM Users";
                    OleDbCommand roleCmd = new OleDbCommand(roleQuery, connection);
                    int roleCount = (int)roleCmd.ExecuteScalar();

                    // Update UI labels
                    labelTotalClasses.Text = classCount.ToString();
                    labelTotalStudent.Text = studentCount.ToString();
                    labelTotalRole.Text = roleCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
