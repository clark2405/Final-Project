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
    public partial class UserControlAttendance : UserControl
    {
        OleDbConnection myConn;
        OleDbCommand cmd;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Database Files\Attendance Management\Attendance Management.accdb";

        public UserControlAttendance()
        {
            InitializeComponent();

            // Check if the columns exist before accessing them
            if (dataGridViewMarkAttendance.Columns["Column1"] != null)
            {
                dataGridViewMarkAttendance.Columns["Column1"].Visible = false;
            }

            if (dataGridViewMarkAttendance.Columns["Column5"] != null)
            {
                dataGridViewMarkAttendance.Columns["Column5"].Visible = false;
            }
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedDate = dateTimePicker1.Text;
                string selectedClass = comboBoxClass.SelectedItem.ToString();

                // Assuming 'tabPageMarkAttendance' is a TabPage control,  
                // replace the problematic line with a proper method or property call.  
                // If 'Attendance' is a custom property or method, ensure it is defined in the correct context.  
                // For now, I will comment out the problematic line and provide a placeholder.  

                // if (tabPageMarkAttendance.Attendance.IsMarkAttendance(selectedDate, selectedClass))  
                // {  
                //     MessageBox.Show("Attendance for this class and date is already marked.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                // }  
                // else  
                // {  
                //     LoadStudents(selectedClass);  
                // }  

                // Placeholder logic until clarification is provided:  
                LoadStudents(selectedClass);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudents(string className)
        {
            try
            {
                myConn = new OleDbConnection(connectionString);
                myConn.Open();

                string query = "SELECT StudentID, StudentName FROM Students WHERE Class = @Class";
                cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("@Class", className);

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewMarkAttendance.DataSource = dt;
                dataGridViewMarkAttendance.Columns["StudentID"].HeaderText = "ID";
                dataGridViewMarkAttendance.Columns["StudentName"].HeaderText = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (myConn != null && myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
    }
}
