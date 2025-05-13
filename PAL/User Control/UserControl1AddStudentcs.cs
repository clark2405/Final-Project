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
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Database Files\Attendance Management\DatabaseHere (Final).accdb";
        public int UserID { get; set; }
        public UserControl1AddStudentcs(int userID)
        {
            InitializeComponent();
            UserID =  userID;
            // Initialize database connection
            connection = new OleDbConnection(connectionString);

            // Set default gender selection
            radioButtonMale.Checked = true;
            radioButtonMale1.Checked = true;

            // Load classes and students
            LoadClasses();
            LoadStudents();
            ConfigureDataGridView();
            CountStudents();
        }

        private void LoadClasses()
        {
            try
            {
                using (OleDbConnection loadConnection = new OleDbConnection(connectionString))
                {
                    loadConnection.Open();
                    // Modify query to filter classes by the logged-in user's ID
                    string query = "SELECT ClassID, ClassName FROM Class WHERE TeacherID = ? ORDER BY ClassName";
                    OleDbCommand cmd = new OleDbCommand(query, loadConnection);
                    cmd.Parameters.AddWithValue("@TeacherID", UserID); // Use the logged-in teacher's ID

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

                    // Query to get only the students added by the logged-in teacher
                    string query = "SELECT * FROM AddStudent WHERE TeacherID = ?";

                    OleDbCommand cmd = new OleDbCommand(query, loadConnection);
                    cmd.Parameters.AddWithValue("@TeacherID", UserID); // Filter by the logged-in teacher's ID

                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
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

            if (!int.TryParse(textBoxRegNo.Text, out int regNo))
            {
                MessageBox.Show("Please enter a valid registration number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected class ID and name
            int classID = Convert.ToInt32(comboBoxClass.SelectedValue);
            string className = comboBoxClass.Text;

            // Get gender
            string gender = radioButtonMale.Checked ? "Male" : "Female";

            try
            {
                using (var connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Check gender limits in the Class table
                    string classQuery = "SELECT MaleNumber, FemaleNumber FROM Class WHERE ClassID = ?";
                    using (var classCmd = new OleDbCommand(classQuery, connection))
                    {
                        classCmd.Parameters.AddWithValue("@ClassID", classID);
                        using (var reader = classCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int maleLimit = Convert.ToInt32(reader["MaleNumber"]);
                                int femaleLimit = Convert.ToInt32(reader["FemaleNumber"]);

                                // Count existing students by gender in the AddStudent table
                                string countQuery = "SELECT Gender, COUNT(Gender) AS GenderCount FROM AddStudent WHERE ClassID = ? GROUP BY Gender";
                                using (var countCmd = new OleDbCommand(countQuery, connection))
                                {
                                    countCmd.Parameters.AddWithValue("@ClassID", classID);
                                    using (var countReader = countCmd.ExecuteReader())
                                    {
                                        int currentMaleCount = 0;
                                        int currentFemaleCount = 0;

                                        while (countReader.Read())
                                        {
                                            string existingGender = countReader["Gender"]?.ToString() ?? string.Empty;
                                            int count = Convert.ToInt32(countReader["GenderCount"]);

                                            if (existingGender == "Male")
                                                currentMaleCount = count;
                                            else if (existingGender == "Female")
                                                currentFemaleCount = count;
                                        }

                                        // Check if adding the new student exceeds the gender limit
                                        if (gender == "Male" && currentMaleCount >= maleLimit)
                                        {
                                            MessageBox.Show("The male student limit for this class has been reached.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                        else if (gender == "Female" && currentFemaleCount >= femaleLimit)
                                        {
                                            MessageBox.Show("The female student limit for this class has been reached.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Class not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }

                    // Insert the student using both ClassID and Class
                    string studentQuery = "INSERT INTO AddStudent (Name, RegNo, ClassID, Class, Gender, TeacherID) VALUES (?, ?, ?, ?, ?, ?)";
                    using (var studentCmd = new OleDbCommand(studentQuery, connection))
                    {
                        studentCmd.Parameters.AddWithValue("@Name", textBoxName.Text.Trim());
                        studentCmd.Parameters.AddWithValue("@RegNo", regNo);
                        studentCmd.Parameters.AddWithValue("@ClassID", classID);
                        studentCmd.Parameters.AddWithValue("@Class", className);
                        studentCmd.Parameters.AddWithValue("@Gender", gender);
                        studentCmd.Parameters.AddWithValue("@TeacherID", UserID);

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

                // Use Name as the unique identifier for a student  
                string studentName = selectedRow.Cells["Name"].Value.ToString();

                if (MessageBox.Show($"Are you sure you want to delete the student '{studentName}'?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Always create a new connection for each operation  
                    using (OleDbConnection conn = new OleDbConnection(connectionString))
                    {
                        conn.Open();

                        // Delete the student using Name  
                        string deleteQuery = "DELETE FROM AddStudent WHERE Name = ?";
                        OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, conn);
                        deleteCmd.Parameters.AddWithValue("?", studentName);

                        int deleteResult = deleteCmd.ExecuteNonQuery();

                        if (deleteResult > 0)
                        {
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

                    // Refresh the student list  
                    LoadStudents();
                    LoadClasses();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CountStudents()
        {
            try
            {
                using (OleDbConnection countConnection = new OleDbConnection(connectionString))
                {
                    countConnection.Open();

                    // Query to count students added by the logged-in teacher
                    string query = "SELECT COUNT(*) FROM AddStudent WHERE TeacherID = ?";
                    OleDbCommand cmd = new OleDbCommand(query, countConnection);
                    cmd.Parameters.AddWithValue("@TeacherID", UserID);

                    int studentCount = Convert.ToInt32(cmd.ExecuteScalar());

                    // Update the label with the student count
                    labelCountStudent.Text = $"{studentCount}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error counting students: " + ex.Message);
            }
        }
    }
}