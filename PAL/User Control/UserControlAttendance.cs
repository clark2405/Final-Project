// UserControlAttendance.cs
using Final_Project.PAL.Forms;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Final_Project.PAL.User_Control
{
    public partial class UserControlAttendance : UserControl
    {
        private OleDbConnection myConn;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\joshlee rash\Downloads\DatabaseHere.accdb";

        public UserControlAttendance()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadClasses();
            // Set the default date to today's date when the control loads
            dateTimePicker1.Value = DateTime.Today;
            LoadAttendanceForSelectedClassAndDate(); // Load attendance for today's date initially
        }

        private void InitializeDataGridView()
        {
            // Ensure the DataGridView is set up correctly in the designer.
            // Columns: StudentName (string), Status (string), Date (DateTime)
            // Set AutoGenerateColumns = false and add columns manually.
        }

        private void LoadClasses()
        {
            try
            {
                using (myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();
                    string query = "SELECT ClassID, ClassName FROM Class ORDER BY ClassName";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        OleDbDataReader reader = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        reader.Close();

                        comboBoxClass.Items.Clear();
                        comboBoxClass.DisplayMember = "ClassName";
                        comboBoxClass.ValueMember = "ClassID";
                        comboBoxClass.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading classes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAttendanceForSelectedClassAndDate();
        }

        private void dateTimePickerAttendanceDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAttendanceForSelectedClassAndDate();
        }

        private void LoadAttendanceForSelectedClassAndDate()
        {
            if (comboBoxClass.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)comboBoxClass.SelectedItem;
                int selectedClassID = Convert.ToInt32(selectedRow["ClassID"]);
                DateTime selectedDate = dateTimePicker1.Value.Date; // Get only the date part
                LoadAttendance(selectedClassID, selectedDate);
            }
        }

        private void LoadAttendance(int classID, DateTime attendanceDate)
        {
            try
            {
                using (myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();

                    // Query to get all students for the selected class
                    string studentQuery = @"SELECT StudentID, Name AS StudentName
                                   FROM AddStudent
                                   WHERE ClassID = @classIDParam";

                    using (OleDbCommand studentCmd = new OleDbCommand(studentQuery, myConn))
                    {
                        studentCmd.Parameters.AddWithValue("@classIDParam", classID);
                        OleDbDataAdapter studentAdapter = new OleDbDataAdapter(studentCmd);
                        DataTable studentDt = new DataTable();
                        studentAdapter.Fill(studentDt);

                        // Query to get all attendance records for the selected class and date
                        string attendanceQuery = @"SELECT StudentID, Status
                                         FROM Attendance
                                         WHERE ClassID = @classIDParam AND AttendanceDate = @attendanceDateParam";
                        using (OleDbCommand attendanceCmd = new OleDbCommand(attendanceQuery, myConn))
                        {
                            attendanceCmd.Parameters.AddWithValue("@classIDParam", classID);
                            attendanceCmd.Parameters.AddWithValue("@attendanceDateParam", attendanceDate.Date);
                            OleDbDataAdapter attendanceAdapter = new OleDbDataAdapter(attendanceCmd);
                            DataTable attendanceDt = new DataTable();
                            attendanceAdapter.Fill(attendanceDt);

                            // Create a dictionary to easily look up attendance status by StudentID
                            var attendanceStatus = new System.Collections.Generic.Dictionary<int, string>();
                            foreach (DataRow row in attendanceDt.Rows)
                            {
                                if (row["StudentID"] != DBNull.Value && row["Status"] != DBNull.Value)
                                {
                                    attendanceStatus[(int)row["StudentID"]] = row["Status"].ToString();
                                }
                            }

                            // Create a new DataTable to bind to the DataGridView
                            DataTable attendanceReportDt = new DataTable();
                            attendanceReportDt.Columns.Add("StudentID", typeof(int));
                            attendanceReportDt.Columns.Add("StudentName", typeof(string));
                            attendanceReportDt.Columns.Add("Status", typeof(string));
                            attendanceReportDt.Columns.Add("AttendanceDate", typeof(DateTime));

                            // Populate the attendance report DataTable by matching students with their attendance
                            foreach (DataRow studentRow in studentDt.Rows)
                            {
                                int studentID = (int)studentRow["StudentID"];
                                string studentName = studentRow["StudentName"].ToString();
                                string status = attendanceStatus.ContainsKey(studentID) ? attendanceStatus[studentID] : "Absent";

                                attendanceReportDt.Rows.Add(studentID, studentName, status, attendanceDate.Date);
                            }

                            dataGridViewMarkAttendance.DataSource = attendanceReportDt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading attendance: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewMarkAttendance.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewMarkAttendance.SelectedRows[0];
                string studentName = selectedRow.Cells["StudentName"].Value?.ToString();
                string status = selectedRow.Cells["Status"].Value?.ToString();
                DateTime date = Convert.ToDateTime(selectedRow.Cells["AttendanceDate"].Value);
                string className = comboBoxClass.Text; // Get the current class name

                AttendanceSheet attendanceForm = new AttendanceSheet();

                if (attendanceForm != null)
                {
                    attendanceForm.StudentNameValue = studentName;
                    attendanceForm.StatusValue = status;
                    attendanceForm.DateTextBoxValue = date.ToShortDateString();
                    attendanceForm.ClassNameValue = className; // Pass the class name
                    if (attendanceForm.ShowDialog() == DialogResult.OK)
                    {
                        string newStatus = attendanceForm.NewStatusValue;
                        DateTime newDate = attendanceForm.NewDateValue.Date; // Ensure only the date part is used

                        // Update the DataGridView directly
                        selectedRow.Cells["Status"].Value = newStatus;
                        selectedRow.Cells["AttendanceDate"].Value = newDate;

                        // Update the database
                        UpdateAttendanceInDatabase(studentName, newDate, newStatus);
                    }
                }
                attendanceForm.Dispose();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateAttendanceInDatabase(string studentName, DateTime date, string status)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // First, get the StudentID and ClassID based on the StudentName
                    string getStudentIDQuery = "SELECT StudentID, ClassID FROM AddStudent WHERE Name = ?";
                    int studentID = -1;
                    int classID = -1;
                    using (OleDbCommand getIDCmd = new OleDbCommand(getStudentIDQuery, conn))
                    {
                        getIDCmd.Parameters.AddWithValue("?", studentName);
                        using (OleDbDataReader reader = getIDCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                studentID = Convert.ToInt32(reader["StudentID"]);
                                classID = Convert.ToInt32(reader["ClassID"]);
                            }
                            else
                            {
                                MessageBox.Show($"Could not find StudentID for '{studentName}'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // *** IMPORTANT: Replace this with your actual logic to get the current UserID ***
                    int currentUserID = GetCurrentUserID(); // Implement this method

                    // Check if an attendance record exists for the StudentID on the given date
                    string checkQuery = "SELECT COUNT(*) FROM Attendance WHERE StudentID = ? AND AttendanceDate = ?";
                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("?", studentID);
                        checkCmd.Parameters.AddWithValue("?", date.Date); // Use AttendanceDate
                        int recordCount = (int)checkCmd.ExecuteScalar();

                        if (recordCount > 0)
                        {
                            // Update existing record using StudentID
                            string updateQuery = @"UPDATE Attendance
                                           SET Status = ?, UserID = ?, ClassID = ?
                                           WHERE StudentID = ? AND AttendanceDate = ?";
                            using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("?", status);
                                updateCmd.Parameters.AddWithValue("?", currentUserID); // Use the actual UserID
                                updateCmd.Parameters.AddWithValue("?", classID);
                                updateCmd.Parameters.AddWithValue("?", studentID);
                                updateCmd.Parameters.AddWithValue("?", date.Date); // Use AttendanceDate
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insert a new record including UserID and ClassID
                            string insertQuery = @"INSERT INTO Attendance (StudentID, AttendanceDate, Status, UserID, ClassID)
                                           VALUES (?, ?, ?, ?, ?)";
                            using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("?", studentID);
                                insertCmd.Parameters.AddWithValue("?", date.Date); // Use AttendanceDate
                                insertCmd.Parameters.AddWithValue("?", status);
                                insertCmd.Parameters.AddWithValue("?", currentUserID); // Use the actual UserID
                                insertCmd.Parameters.AddWithValue("?", classID);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating attendance: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // You need to implement this method to get the current UserID
        private int GetCurrentUserID()
        {
            // Replace this with your actual logic to retrieve the logged-in user's ID
            // For example, you might get it from a session variable, a global property, etc.
            return 1; // Placeholder - ensure this is a valid UserID from your Users table
        }
    }
}