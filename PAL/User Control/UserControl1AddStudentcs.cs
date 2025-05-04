using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Final_Project.PAL.User_Control
{
    public partial class UserControl1AddStudentcs : UserControl
    {
        private OleDbConnection connection;
        OleDbConnection myConn;
        OleDbCommand cmd;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Database Files\Attendance Management\DatabaseHere.accdb";

        public UserControl1AddStudentcs()
        {
            InitializeComponent();

            // Initialize database connection
            connection = new OleDbConnection(connectionString);

            // Set default gender selection
            radioButtonMale.Checked = true;
            radioButtonMale1.Checked = true;

            // Load classes and students
            LoadClasses();
            LoadStudents();
            ConfigureDataGridView();
        }

        private void LoadClasses()
        {
            try
            {
                using (OleDbConnection loadConnection = new OleDbConnection(connectionString))
                {
                    loadConnection.Open();
                    string query = "SELECT ClassID, ClassName FROM Class ORDER BY ClassName";
                    OleDbCommand cmd = new OleDbCommand(query, loadConnection);

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    // Bind to Add Student ComboBox
                    comboBoxClass.DisplayMember = "ClassName";
                    comboBoxClass.ValueMember = "ClassID";
                    comboBoxClass.DataSource = dt;

                    // Bind to Update Student ComboBox
                    comboBoxClass1.DisplayMember = "ClassName";
                    comboBoxClass1.ValueMember = "ClassID";
                    comboBoxClass1.DataSource = dt.Copy();
                } // loadConnection is automatically closed and disposed here
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes: " + ex.Message);
            }
        }

        private void LoadStudents()
        {
            try
            {
                using (OleDbConnection loadConnection = new OleDbConnection(connectionString))
                {
                    loadConnection.Open();

                    // Simple query to get all students
                    string query = "SELECT * FROM AddStudent";

                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, loadConnection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Clear existing columns and binding
                    dataGridViewStudent.DataSource = null;
                    dataGridViewStudent.Columns.Clear();

                    // Set the data source
                    dataGridViewStudent.DataSource = dt;

                    // Optional: Add a message to confirm loading (for debugging)
                    if (dt.Rows.Count > 0)
                    {
                        // MessageBox.Show($"Successfully loaded {dt.Rows.Count} students.");
                    }
                    else
                    {
                        // MessageBox.Show("No student records found in the database.");
                    }
                } // loadConnection is automatically closed and disposed here
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
        }

        private void ConfigureDataGridView()
        {
            // Enable selection
            dataGridViewStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStudent.MultiSelect = false;
            dataGridViewStudent.ReadOnly = true;
            dataGridViewStudent.AllowUserToAddRows = false;

            // Auto-size columns
            dataGridViewStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter student name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxClass.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Declare regNo variable outside the if block
            int regNo;
            if (!int.TryParse(textBoxRegNo.Text, out regNo))
            {
                MessageBox.Show("Please enter a valid registration number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected class ID and name
            int classID = Convert.ToInt32(comboBoxClass.SelectedValue);
            string className = comboBoxClass.Text; // Get the ClassName directly

            // Get gender
            string gender = radioButtonMale.Checked ? "Male" : "Female";

            try
            {
                using (var connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Insert the student using both ClassID and Class
                    string studentQuery = "INSERT INTO AddStudent (Name, RegNo, ClassID, Class, Gender) VALUES (?, ?, ?, ?, ?)";
                    using (var studentCmd = new OleDbCommand(studentQuery, connection))
                    {
                        studentCmd.Parameters.AddWithValue("@Name", textBoxName.Text.Trim());
                        studentCmd.Parameters.AddWithValue("@RegNo", regNo); // regNo is now accessible here
                        studentCmd.Parameters.AddWithValue("@ClassID", classID); // Use ClassID here
                        studentCmd.Parameters.AddWithValue("@Class", className); // Use Class name here
                        studentCmd.Parameters.AddWithValue("@Gender", gender);

                        int studentResult = studentCmd.ExecuteNonQuery();

                        if (studentResult > 0)
                        {
                            MessageBox.Show("Student added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadStudents(); // Refresh the student list
                        }
                        else
                        {
                            MessageBox.Show("Failed to add student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message);
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate input fields
            if (string.IsNullOrWhiteSpace(textBoxName1.Text))
            {
                MessageBox.Show("Please enter student name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxClass1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxRegNo1.Text, out int regNo))
            {
                MessageBox.Show("Please enter a valid registration number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected student data
            DataGridViewRow selectedRow = dataGridViewStudent.SelectedRows[0];
            string currentRegNo = selectedRow.Cells["RegNo"].Value.ToString(); // Use RegNo to identify the student

            // Get selected class name
            string newClassName = comboBoxClass1.Text; // Get the new ClassName directly

            // Get new gender
            string newGender = radioButtonMale1.Checked ? "Male" : "Female";

            try
            {
                connection.Open();

                // Update the student record
                string studentQuery = "UPDATE AddStudent SET Name = ?, RegNo = ?, Class = ?, Gender = ? WHERE RegNo = ?";
                OleDbCommand studentCmd = new OleDbCommand(studentQuery, connection);
                studentCmd.Parameters.AddWithValue("@Name", textBoxName1.Text.Trim());
                studentCmd.Parameters.AddWithValue("@RegNo", regNo);
                studentCmd.Parameters.AddWithValue("@Class", newClassName); // Use new ClassName here
                studentCmd.Parameters.AddWithValue("@Gender", newGender);
                studentCmd.Parameters.AddWithValue("@OldRegNo", currentRegNo); // Use RegNo to identify the student

                int studentResult = studentCmd.ExecuteNonQuery();

                if (studentResult > 0)
                {
                    MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudents();
                    LoadClasses();

                    // Clear update fields
                    textBoxName1.Clear();
                    comboBoxClass1.SelectedIndex = -1;
                    textBoxRegNo1.Clear();
                    radioButtonMale1.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridViewStudent_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewStudent.SelectedRows[0];

                // Populate the update form fields with selected student's data
                textBoxName1.Text = selectedRow.Cells["Name"].Value.ToString();
                textBoxRegNo1.Text = selectedRow.Cells["RegNo"].Value.ToString();

                // Use ClassID to set the selected class in the combobox
                if (selectedRow.Cells["ClassID"] != null && selectedRow.Cells["ClassID"].Value != null)
                {
                    comboBoxClass1.SelectedValue = selectedRow.Cells["ClassID"].Value;
                }

                string gender = selectedRow.Cells["Gender"].Value.ToString();
                if (gender == "Male")
                    radioButtonMale1.Checked = true;
                else
                    radioButtonFemale1.Checked = true;
            }
        }

        

        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Get selected student data
                DataGridViewRow selectedRow = dataGridViewStudent.SelectedRows[0];

                // Check if the necessary columns exist
                if (!selectedRow.DataGridView.Columns.Contains("RegNo"))
                {
                    MessageBox.Show("RegNo column not found in the grid. Please check column names.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Use RegNo as the unique identifier for a student
                int regNo = Convert.ToInt32(selectedRow.Cells["RegNo"].Value);

                // Get ClassID and Gender if they exist
                int classID = 0;
                string gender = "";

                if (selectedRow.DataGridView.Columns.Contains("ClassID"))
                {
                    classID = Convert.ToInt32(selectedRow.Cells["ClassID"].Value);
                }

                if (selectedRow.DataGridView.Columns.Contains("Gender"))
                {
                    gender = selectedRow.Cells["Gender"].Value.ToString();
                }

                if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Always create a new connection for each operation
                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        conn.Open();

                        // 1. Delete the student using RegNo (unique identifier)
                        string deleteQuery = "DELETE FROM AddStudent WHERE RegNo = ?";
                        OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, conn);
                        deleteCmd.Parameters.AddWithValue("?", regNo);

                        int deleteResult = deleteCmd.ExecuteNonQuery();

                        if (deleteResult > 0)
                        {
                            // 2. Update class statistics if ClassID is valid
                            if (classID > 0)
                            {
                                try
                                {
                                    string updateClassQuery = @"UPDATE Class SET 
                                                 QuantityStudents = QuantityStudents - 1,
                                                 MaleNumber = IIF(? = 'Male', MaleNumber - 1, MaleNumber),
                                                 FemaleNum = IIF(? = 'Female', FemaleNum - 1, FemaleNum)
                                                 WHERE ClassID = ?";
                                    OleDbCommand updateCmd = new OleDbCommand(updateClassQuery, conn);
                                    updateCmd.Parameters.AddWithValue("?", gender);
                                    updateCmd.Parameters.AddWithValue("?", gender);
                                    updateCmd.Parameters.AddWithValue("?", classID);

                                    updateCmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    // Just log this error but continue - the student is already deleted
                                    //MessageBox.Show("Warning: Student deleted but class statistics could not be updated: " + ex.Message,
                                    //    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }

                            MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear update fields
                            textBoxName1.Clear();
                            comboBoxClass1.SelectedIndex = -1;
                            textBoxRegNo1.Clear();
                            radioButtonMale1.Checked = true;
                        }
                        else
                        {
                            MessageBox.Show("No student was deleted. The student may no longer exist in the database.",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    } // Connection is automatically closed here

                    // Refresh the student list - with a new connection
                    LoadStudents();
                    LoadClasses();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}