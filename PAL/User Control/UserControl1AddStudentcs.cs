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
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Database Files\Attendance Management\Attendance Management.accdb";

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
        }

        private void LoadClasses()
{
    try
    {
        connection.Open();
        string query = "SELECT ClassID, ClassName FROM Class ORDER BY ClassName";
        OleDbCommand cmd = new OleDbCommand(query, connection);
        
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
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error loading classes: " + ex.Message);
    }
    finally
    {
        connection.Close();
    }
}

        private void LoadStudents()
        {
            try
            {
                connection.Open();
                string query = @"SELECT s.Name, s.RegNo, c.ClassName, s.Gender 
                        FROM AddStudent s
                        INNER JOIN Class c ON s.ClassID = c.ClassID";
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Clear existing columns first
                dataGridViewStudent.Columns.Clear();

                // Disable auto-generation of columns
                dataGridViewStudent.AutoGenerateColumns = false;

                // Manually create and add columns
                dataGridViewStudent.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Name",
                    HeaderText = "Name",
                    Name = "Name"
                });

                dataGridViewStudent.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "RegNo",
                    HeaderText = "Reg No.",
                    Name = "RegNo"
                });

                dataGridViewStudent.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "ClassName",
                    HeaderText = "Class",
                    Name = "ClassName"
                });

                dataGridViewStudent.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Gender",
                    HeaderText = "Gender",
                    Name = "Gender"
                });

                // Set the data source
                dataGridViewStudent.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
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

            // Get selected class name
            string className = comboBoxClass.Text; // Get the ClassName directly

            // Get gender
            string gender = radioButtonMale.Checked ? "Male" : "Female";

            try
            {
                using (var connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Insert the student using ClassName
                    string studentQuery = "INSERT INTO AddStudent (Name, RegNo, Class, Gender) VALUES (?, ?, ?, ?)";
                    using (var studentCmd = new OleDbCommand(studentQuery, connection))
                    {
                        studentCmd.Parameters.AddWithValue("@Name", textBoxName.Text.Trim());
                        studentCmd.Parameters.AddWithValue("@RegNo", regNo);
                        studentCmd.Parameters.AddWithValue("@Class", className); // Use ClassName here
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
                comboBoxClass1.SelectedValue = selectedRow.Cells["ClassID"].Value;
                textBoxRegNo1.Text = selectedRow.Cells["RegNo"].Value.ToString();

                string gender = selectedRow.Cells["Gender"].Value.ToString();
                if (gender == "Male")
                    radioButtonMale1.Checked = true;
                else
                    radioButtonFemale1.Checked = true;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudent.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a student to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected student data
            DataGridViewRow selectedRow = dataGridViewStudent.SelectedRows[0];
            int classID = Convert.ToInt32(selectedRow.Cells["ClassID"].Value);
            string gender = selectedRow.Cells["Gender"].Value.ToString();

            if (MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    connection.Open();

                    // 1. Delete the student
                    string deleteQuery = "DELETE FROM AddStudent WHERE ClassID = ?";
                    OleDbCommand deleteCmd = new OleDbCommand(deleteQuery, connection);
                    deleteCmd.Parameters.AddWithValue("@ClassID", classID);

                    int deleteResult = deleteCmd.ExecuteNonQuery();

                    if (deleteResult > 0)
                    {
                        // 2. Update class statistics
                        string updateClassQuery = @"UPDATE Class SET 
                                                 QuantityStudents = QuantityStudents - 1,
                                                 MaleNumber = MaleNumber - IIF(? = 'Male', 1, 0),
                                                 FemaleNum = FemaleNum - IIF(? = 'Female', 1, 0)
                                                 WHERE ClassID = ?";
                        OleDbCommand updateCmd = new OleDbCommand(updateClassQuery, connection);
                        updateCmd.Parameters.AddWithValue("@Gender1", gender);
                        updateCmd.Parameters.AddWithValue("@Gender2", gender);
                        updateCmd.Parameters.AddWithValue("@ClassID", classID);

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Student deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear update fields
                        textBoxName1.Clear();
                        comboBoxClass1.SelectedIndex = -1;
                        textBoxRegNo1.Clear();
                        radioButtonMale1.Checked = true;

                        // Refresh the student list
                        LoadStudents();
                        LoadClasses();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting student: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void dataGridViewStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}