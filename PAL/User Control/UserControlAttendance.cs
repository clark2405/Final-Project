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
using Final_Project.PAL.Forms;

namespace Final_Project.PAL.User_Control
{
    public partial class UserControlAttendance : UserControl
    {
        OleDbConnection myConn;
        OleDbCommand cmd;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\joshlee rash\Downloads\DatabaseHere.accdb";

        public UserControlAttendance()
        {
            InitializeComponent();

            // Check if the columns exist before accessing them
            if (dataGridViewMarkAttendance.Columns["ClassID"] != null)
            {
                dataGridViewMarkAttendance.Columns["ClassID"].Visible = false; // Hide the ClassID column
            }

            if (dataGridViewMarkAttendance.Columns["Column5"] != null)
            {
                dataGridViewMarkAttendance.Columns["Column5"].Visible = false;
            }

            // Load classes into the comboBox when the control loads
            LoadClasses();
        }

        private void LoadClasses()
        {
            try
            {
                myConn = new OleDbConnection(connectionString);
                myConn.Open();

                string query = "SELECT ClassID, ClassName FROM Class ORDER BY ClassName"; // Select both ClassID and ClassName
                cmd = new OleDbCommand(query, myConn);
                OleDbDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader); // Load the data from the reader into the DataTable
                reader.Close();

                comboBoxClass.Items.Clear();
                comboBoxClass.DisplayMember = null; // Clear any previous DisplayMember
                comboBoxClass.ValueMember = null;     // Clear any previous ValueMember

                comboBoxClass.DataSource = dt;
                comboBoxClass.DisplayMember = "ClassName";
                comboBoxClass.ValueMember = "ClassID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading classes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (myConn != null && myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxClass.SelectedItem != null)
                {
                    DataRowView selectedRow = (DataRowView)comboBoxClass.SelectedItem;
                    int selectedClassID = Convert.ToInt32(selectedRow["ClassID"]);
                    //MessageBox.Show($"Selected ClassID: {selectedClassID}");
                    LoadStudents(selectedClassID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadStudents(int classID)
        {
            try
            {
                myConn = new OleDbConnection(connectionString);
                myConn.Open();

                // Modified SQL query to select student name and a default 'Present' status
                string query = @"SELECT adds.Name AS StudentName, 'Present' AS Status
                                FROM Class c
                                INNER JOIN AddStudent adds ON c.ClassName = adds.Class
                                WHERE c.ClassID = ?";

                cmd = new OleDbCommand(query, myConn);
                cmd.Parameters.AddWithValue("?", classID);

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridViewMarkAttendance.DataSource = dt;

                // Set the HeaderText for the columns
                if (dataGridViewMarkAttendance.Columns.Count >= 2)
                {
                    dataGridViewMarkAttendance.Columns[0].HeaderText = "Student Name";
                    dataGridViewMarkAttendance.Columns[1].HeaderText = "Status";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (myConn != null && myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }


        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewMarkAttendance.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewMarkAttendance.SelectedRows[0];

                // Assuming your DataGridView has columns named "StudentName" and "Status".
                // Adjust these names if yours are different.
                string studentName = selectedRow.Cells["StudentName"].Value?.ToString();
                string status = selectedRow.Cells["Status"].Value?.ToString();

                AttendanceSheet attendanceForm = new AttendanceSheet();

                if (attendanceForm != null)
                {
                    attendanceForm.StudentNameValue = studentName;
                    attendanceForm.StatusValue = status;
                    attendanceForm.DateTextBoxValue = DateTime.Now.ToShortDateString(); // Or get from a date picker if you have one
                   //attendanceForm.TimeInTextBoxValue = DateTime.Now.ToShortTimeString(); // Or get from a time picker if you have one
                                                                                          // ... pass other relevant data if needed ...
                }

                attendanceForm.ShowDialog();

                if (attendanceForm.DialogResult == DialogResult.OK)
                {
                    // Handle any data returned from the AttendanceSheet form if needed.
                }

                if (attendanceForm != null)
                {
                    attendanceForm.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}