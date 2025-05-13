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
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Database Files\Attendance Management\DatabaseHere (Final).accdb";
        public int UserID { get; set; }

        public UserControlAttendance(int userID)
        {
            InitializeComponent();
            UserID = userID;
            InitializeDataGridView(); // Make sure this method defines columns including "StudentID"
            LoadClasses();
            dateTimePicker1.Value = DateTime.Today;
            LoadAttendanceForSelectedClassAndDate();
        }

        private void InitializeDataGridView()
        {
            // Ensure dataGridViewMarkAttendance has columns:
            // "StudentID" (Visible=false if preferred, but data should be there)
            // "StudentName"
            // "Status"
            // "AttendanceDate"
            // Example:
            // dataGridViewMarkAttendance.AutoGenerateColumns = false;
            // dataGridViewMarkAttendance.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentID", HeaderText = "Student ID", DataPropertyName = "StudentID", Visible = false });
            // dataGridViewMarkAttendance.Columns.Add(new DataGridViewTextBoxColumn { Name = "StudentName", HeaderText = "Student Name", DataPropertyName = "StudentName" });
            // dataGridViewMarkAttendance.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Status", DataPropertyName = "Status" });
            // dataGridViewMarkAttendance.Columns.Add(new DataGridViewTextBoxColumn { Name = "AttendanceDate", HeaderText = "Date", DataPropertyName = "AttendanceDate", DefaultCellStyle = new DataGridViewCellStyle { Format = "d" } }); // Short date format
        }

        private void LoadClasses()
        {
            try
            {
                using (myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();
                    string query = "SELECT ClassID, ClassName FROM Class WHERE TeacherID = @userIDParam ORDER BY ClassName";
                    using (OleDbCommand cmd = new OleDbCommand(query, myConn))
                    {
                        cmd.Parameters.AddWithValue("@userIDParam", UserID);
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
            // This seems to be an older event handler name from a previous control.
            // Assuming dateTimePicker1 is the correct one as used in constructor and LoadAttendanceForSelectedClassAndDate
            LoadAttendanceForSelectedClassAndDate();
        }

        // This is the event handler for your DateTimePicker named dateTimePicker1
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadAttendanceForSelectedClassAndDate();
            // You might not need FilterAttendanceByDate if LoadAttendanceForSelectedClassAndDate already reloads for the new date.
            // FilterAttendanceByDate(dateTimePicker1.Value.Date); // If you keep this, ensure it works with how LoadAttendance populates the grid.
        }


        private void LoadAttendanceForSelectedClassAndDate()
        {
            if (comboBoxClass.SelectedItem != null && comboBoxClass.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)comboBoxClass.SelectedItem;
                // Ensure selectedValue is convertible to int.
                if (int.TryParse(comboBoxClass.SelectedValue.ToString(), out int selectedClassID))
                {
                    DateTime selectedDate = dateTimePicker1.Value.Date;
                    LoadAttendance(selectedClassID, selectedDate);
                }
                else
                {
                    if (dataGridViewMarkAttendance.DataSource != null)
                    {
                        ((DataTable)dataGridViewMarkAttendance.DataSource).Rows.Clear();
                    }
                    // Optionally, show a message if ClassID is not valid.
                }
            }
            else
            {
                if (dataGridViewMarkAttendance.DataSource != null)
                {
                    ((DataTable)dataGridViewMarkAttendance.DataSource).Rows.Clear();
                }
            }
        }

        private void LoadAttendance(int classID, DateTime attendanceDate)
        {
            try
            {
                using (myConn = new OleDbConnection(connectionString))
                {
                    myConn.Open();

                    string studentQuery = @"SELECT StudentID, Name AS StudentName  
                                                   FROM AddStudent  
                                                   WHERE ClassID = @classIDParam";
                    DataTable studentDt = new DataTable();
                    using (OleDbCommand studentCmd = new OleDbCommand(studentQuery, myConn))
                    {
                        studentCmd.Parameters.AddWithValue("@classIDParam", classID);
                        OleDbDataAdapter studentAdapter = new OleDbDataAdapter(studentCmd);
                        studentAdapter.Fill(studentDt);
                    }

                    string attendanceQuery = @"SELECT StudentID, Status  
                                                      FROM Attendance  
                                                      WHERE ClassID = @classIDParam AND AttendanceDate = @attendanceDateParam";

                    DataTable attendanceDt = new DataTable();
                    using (OleDbCommand attendanceCmd = new OleDbCommand(attendanceQuery, myConn))
                    {
                        attendanceCmd.Parameters.AddWithValue("@classIDParam", classID);
                        attendanceCmd.Parameters.AddWithValue("@attendanceDateParam", attendanceDate.Date); // Ensure date only  
                        OleDbDataAdapter attendanceAdapter = new OleDbDataAdapter(attendanceCmd);
                        attendanceAdapter.Fill(attendanceDt);
                    }

                    var attendanceStatus = new System.Collections.Generic.Dictionary<int, string>();
                    foreach (DataRow row in attendanceDt.Rows)
                    {
                        if (row["StudentID"] != DBNull.Value && row["Status"] != DBNull.Value)
                        {
                            attendanceStatus[Convert.ToInt32(row["StudentID"])] = row["Status"].ToString();
                        }
                    }

                    DataTable attendanceReportDt = new DataTable();
                    attendanceReportDt.Columns.Add("StudentID", typeof(int));
                    attendanceReportDt.Columns.Add("StudentName", typeof(string));
                    attendanceReportDt.Columns.Add("Status", typeof(string));
                    attendanceReportDt.Columns.Add("AttendanceDate", typeof(DateTime));

                    foreach (DataRow studentRow in studentDt.Rows)
                    {
                        int studentID = Convert.ToInt32(studentRow["StudentID"]);
                        string studentName = studentRow["StudentName"].ToString();
                        string status = string.Empty; // Default status  

                        if (attendanceStatus.ContainsKey(studentID))
                        {
                            string userStatus = attendanceStatus[studentID];
                            if (!string.IsNullOrEmpty(userStatus))
                            {
                                status = userStatus; // Use the status from the database if available  
                            }
                        }

                        attendanceReportDt.Rows.Add(studentID, studentName, status, attendanceDate.Date);
                    }

                    dataGridViewMarkAttendance.DataSource = attendanceReportDt;
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

                if (selectedRow.Cells["StudentID"] == null || selectedRow.Cells["StudentID"].Value == null || selectedRow.Cells["StudentID"].Value == DBNull.Value)
                {
                    MessageBox.Show("Selected row does not contain a valid StudentID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int studentID = Convert.ToInt32(selectedRow.Cells["StudentID"].Value);
                string studentName = selectedRow.Cells["StudentName"].Value?.ToString();
                string currentStatus = selectedRow.Cells["Status"].Value?.ToString();
                DateTime currentDate = Convert.ToDateTime(selectedRow.Cells["AttendanceDate"].Value);
                string className = comboBoxClass.Text;

                int classID_context = -1;
                if (comboBoxClass.SelectedValue != null && int.TryParse(comboBoxClass.SelectedValue.ToString(), out int parsedClassID))
                {
                    classID_context = parsedClassID;
                }
                else
                {
                    MessageBox.Show("Could not determine the current Class ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (AttendanceSheet attendanceForm = new AttendanceSheet())
                {
                    attendanceForm.StudentNameValue = studentName;
                    attendanceForm.StatusValue = currentStatus;
                    attendanceForm.DateTextBoxValue = currentDate.ToShortDateString();
                    attendanceForm.ClassNameValue = className;

                    if (attendanceForm.ShowDialog() == DialogResult.OK)
                    {
                        string newStatus = attendanceForm.NewStatusValue;
                        DateTime newDate = attendanceForm.NewDateValue.Date;

                        // Update the database
                        UpdateAttendanceInDatabase(studentID, classID_context, newDate, newStatus);

                        // Reload the attendance data to reflect changes
                        LoadAttendanceForSelectedClassAndDate();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Modified UpdateAttendanceInDatabase to use StudentID and ClassID directly
        private void UpdateAttendanceInDatabase(int studentID, int classID, DateTime attendanceDate, string status)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Step 1: Check if a record already exists
                    string checkQuery = @"SELECT COUNT(*) FROM Attendance
                                  WHERE StudentID = @StudentID AND ClassID = @ClassID AND AttendanceDate = @AttendanceDate";

                    using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@StudentID", studentID);
                        checkCmd.Parameters.AddWithValue("@ClassID", classID);
                        checkCmd.Parameters.AddWithValue("@AttendanceDate", attendanceDate.Date);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Record exists: UPDATE it
                            string updateQuery = @"UPDATE Attendance
                                           SET Status = @Status, TeacherID = @TeacherID
                                           WHERE StudentID = @StudentID AND ClassID = @ClassID AND AttendanceDate = @AttendanceDate";

                            using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@Status", status);
                                updateCmd.Parameters.AddWithValue("@TeacherID", UserID);
                                updateCmd.Parameters.AddWithValue("@StudentID", studentID);
                                updateCmd.Parameters.AddWithValue("@ClassID", classID);
                                updateCmd.Parameters.AddWithValue("@AttendanceDate", attendanceDate.Date);

                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Record does not exist: INSERT new
                            string insertQuery = @"INSERT INTO Attendance (StudentID, ClassID, AttendanceDate, Status, TeacherID)
                                           VALUES (@StudentID, @ClassID, @AttendanceDate, @Status, @TeacherID)";

                            using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@StudentID", studentID);
                                insertCmd.Parameters.AddWithValue("@ClassID", classID);
                                insertCmd.Parameters.AddWithValue("@AttendanceDate", attendanceDate.Date);
                                insertCmd.Parameters.AddWithValue("@Status", status);
                                insertCmd.Parameters.AddWithValue("@TeacherID", UserID);

                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating attendance in database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // FilterAttendanceByDate might not be necessary if LoadAttendanceForSelectedClassAndDate
        // is called on dateTimePicker1_ValueChanged and correctly reloads the grid.
        // If you use it, ensure it's compatible with how data is loaded.
        private void FilterAttendanceByDate(DateTime selectedDate)
        {
            if (dataGridViewMarkAttendance.DataSource is DataTable attendanceTable)
            {
                // Apply a filter to the DataTable to show only rows matching the selected date
                // Note: OleDb date literals are usually enclosed in # in Access SQL.
                // Ensure the format matches your database expectations.
                try
                {
                    attendanceTable.DefaultView.RowFilter = $"AttendanceDate = #{selectedDate:MM/dd/yyyy}#";
                }
                catch (Exception ex)
                {
                    // Handle potential errors if AttendanceDate column is not a DateTime type after all, or filter is malformed
                    MessageBox.Show("Error filtering by date: " + ex.Message, "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}