using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace Final_Project.PAL.User_Control
{
    public partial class UserControlRegister : UserControl
    {
        // Connection string to the Access database
        private string accessConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= C:\Users\joshlee rash\Downloads\DatabaseHere.accdb";

        public UserControlRegister()
        {
            InitializeComponent();
            InitializeInputPlaceholders();
            SetupInputValidation();
            LoadAccountData(); // Load all data initially
            PopulateSearchComboBox();
        }

        private void PopulateSearchComboBox()
        {
            combobxSearchBy.Items.Add("Student Name");
            combobxSearchBy.Items.Add("Student ID");
            combobxSearchBy.SelectedIndex = 0; // Default to search by Student Name
        }

        private void InitializeInputPlaceholders()
        {
            SetPlaceholder(textBoxFullName, "Enter full name");
            SetPlaceholder(textBoxEmail, "example@email.com");
            SetPlaceholder(textBoxID, "Enter school ID");
            SetPlaceholder(textBoxAddress, "Enter address");
            SetPlaceholder(textBoxPassword, "Enter password");
            SetPlaceholder(textBoxSearch, "Search..."); // Generic search placeholder
        }

        private void SetPlaceholder(Control textBox, string placeholderText)
        {
            if (textBox is TextBox || textBox is MaskedTextBox)
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = SystemColors.GrayText;
                textBox.Tag = placeholderText;

                if (textBox == textBoxPassword && textBox is TextBox)
                {
                    ((TextBox)textBox).UseSystemPasswordChar = false;
                }

                textBox.Enter += Placeholder_Enter;
                textBox.Leave += Placeholder_Leave;
            }
            else if (textBox is TextBox && textBox == textBoxSearch) // Special handling for search placeholder
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = SystemColors.GrayText;
                textBox.Tag = placeholderText;
                textBox.Enter += Placeholder_Enter;
                textBox.Leave += Placeholder_Leave;
            }
            else
            {
                throw new ArgumentException("Control must be a TextBox or MaskedTextBox", nameof(textBox));
            }
        }

        private void Placeholder_Enter(object sender, EventArgs e)
        {
            Control textBox = (Control)sender;
            if (textBox.Text == textBox.Tag?.ToString())
            {
                textBox.Text = "";
            }
            textBox.ForeColor = SystemColors.WindowText; // Always set text color to normal on focus
            if (textBox == textBoxPassword && textBox is TextBox)
            {
                ((TextBox)textBox).UseSystemPasswordChar = true;
            }
        }

        private void Placeholder_Leave(object sender, EventArgs e)
        {
            Control textBox = (Control)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag?.ToString();
                textBox.ForeColor = SystemColors.GrayText;
                if (textBox == textBoxPassword && textBox is TextBox)
                {
                    ((TextBox)textBox).UseSystemPasswordChar = false;
                }
            }
        }

        private void SetupInputValidation()
        {
            HideValidationErrors();
            textBoxEmail.TextChanged += TextBoxEmail_TextChanged;
            dateTimePickerDOB.TextChanged += DateTimePickerDOB_TextChanged;
        }

        private void HideValidationErrors()
        {
            pictureBoxErrorDateofBirth.Visible = false;
            pictureBoxErrorEmail.Visible = false;
            pictureBoxErrorID.Visible = false;
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            pictureBoxErrorEmail.Visible = !IsValidEmail(textBoxEmail.Text);
        }

        private void DateTimePickerDOB_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox maskedTextBox = (MaskedTextBox)sender;
            if (maskedTextBox.MaskCompleted)
            {
                if (!DateTime.TryParse(maskedTextBox.Text, out DateTime dob) || dob > DateTime.Today)
                {
                    pictureBoxErrorDateofBirth.Visible = true;
                }
                else
                {
                    pictureBoxErrorDateofBirth.Visible = false;
                }
            }
            else
            {
                pictureBoxErrorDateofBirth.Visible = false;
            }
        }

        private bool IsValidEmail(string email)
        {
            if (email == "example@email.com" || string.IsNullOrWhiteSpace(email))
                return false;
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool AreInputsValid()
        {
            bool isValid = true;
            if (string.IsNullOrWhiteSpace(textBoxFullName.Text) || textBoxFullName.Text == textBoxFullName.Tag?.ToString())
                isValid = false;
            if (!IsValidEmail(textBoxEmail.Text))
                isValid = false;
            if (string.IsNullOrWhiteSpace(textBoxPassword.Text) || textBoxPassword.Text == textBoxPassword.Tag?.ToString())
                isValid = false;
            if (!((MaskedTextBox)dateTimePickerDOB).MaskCompleted || !DateTime.TryParse(((MaskedTextBox)dateTimePickerDOB).Text, out DateTime dob) || dob > DateTime.Today)
                isValid = false;
            // Removed check for radioButtonStudent

            if (!isValid)
            {
                MessageBox.Show("Please fill in all required fields correctly.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return isValid;
        }

        private void ClearInputFields()
        {
            textBoxFullName.Clear();
            textBoxEmail.Clear();
            textBoxPassword.Clear();
            textBoxID.Clear();
            textBoxAddress.Clear();
            ((MaskedTextBox)dateTimePickerDOB).Clear();
            // Removed radioButtonMale and radioButtonFemale clearing
            HideValidationErrors();
            InitializeInputPlaceholders();
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            RegisterStudent(); // Directly register a student
        }

        private void RegisterStudent()
        {
            if (!AreInputsValid()) return;

            string studentName = textBoxFullName.Text;
            string studentEmail = textBoxEmail.Text;
            string schoolId = textBoxID.Text == textBoxID.Tag?.ToString() ? null : textBoxID.Text;
            string password = textBoxPassword.Text;
            DateTime birthday = DateTime.Parse(((MaskedTextBox)dateTimePickerDOB).Text).Date;
            string gender = radioButtonMale.Checked ? "Male" : (radioButtonFemale.Checked ? "Female" : null); // Capture gender here
            string address = textBoxAddress.Text == textBoxAddress.Tag?.ToString() ? null : textBoxAddress.Text;

            using (var connection = new OleDbConnection(accessConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        InsertStudentAccount(connection, transaction, studentName, studentEmail, schoolId, password, birthday, gender, address);

                        transaction.Commit();
                        MessageBox.Show("Student registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputFields();
                        LoadAccountData(); // Refresh the DataGridView
                    }
                    catch (OleDbException ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"Database Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void InsertStudentAccount(OleDbConnection connection, OleDbTransaction transaction, string studentName, string studentEmail, string schoolId, string password, DateTime birthday, string gender, string address)
        {
            const string query = @"INSERT INTO [StudentAccount] ([StudentName], [StudentEmail], [SchoolID], [Password], [Birthday], [Gender], [Address]) VALUES (?, ?, ?, ?, ?, ?, ?)"; // Removed StudentID as it's AutoNumber
            using (var cmd = new OleDbCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@StudentName", studentName);
                cmd.Parameters.AddWithValue("@StudentEmail", studentEmail);
                cmd.Parameters.AddWithValue("@SchoolID", string.IsNullOrEmpty(schoolId) ? DBNull.Value : schoolId);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Birthday", birthday.Date);
                cmd.Parameters.AddWithValue("@Gender", string.IsNullOrEmpty(gender) ? DBNull.Value : gender); // Save gender here
                cmd.Parameters.AddWithValue("@Address", string.IsNullOrEmpty(address) ? DBNull.Value : address);
                cmd.ExecuteNonQuery();
            }
        }

        private void combobxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAccountData(); // Reload data when the account type selection changes
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadAccountData(); // Reload data whenever the search text changes
        }

        private void combobxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAccountData(); // Reload data when the search type changes
            textBoxSearch.Text = "Search...";
            textBoxSearch.ForeColor = SystemColors.GrayText;
            textBoxSearch.Tag = "Search...";
        }

        private void LoadAccountData()
        {
            DataTable studentAccounts = new DataTable();
            studentAccounts.Columns.Add("StudentID", typeof(int)); // Assuming StudentID is an integer
            studentAccounts.Columns.Add("StudentName", typeof(string));
            studentAccounts.Columns.Add("StudentEmail", typeof(string));
            studentAccounts.Columns.Add("SchoolID", typeof(string));
            studentAccounts.Columns.Add("Password", typeof(string));
            studentAccounts.Columns.Add("Birthday", typeof(DateTime));
            studentAccounts.Columns.Add("Gender", typeof(string));
            studentAccounts.Columns.Add("Address", typeof(string));

            string searchText = textBoxSearch.Text.Trim().ToUpper();
            string searchBy = combobxSearchBy.SelectedItem?.ToString();
            string query = "SELECT StudentID, StudentName, StudentEmail, SchoolID, Password, Birthday, Gender, Address FROM StudentAccount";
            string whereClause = "";

            if (!string.IsNullOrEmpty(searchText) && searchText != "SEARCH...")
            {
                if (searchBy == "Student Name")
                {
                    whereClause = " WHERE UCase(StudentName) LIKE @SearchText";
                }
                else if (searchBy == "Student ID")
                {
                    whereClause = " WHERE UCase(SchoolID) LIKE @SearchText";
                }
            }

            query += whereClause;

            using (var connection = new OleDbConnection(accessConnectionString))
            {
                try
                {
                    connection.Open();
                    using (var cmd = new OleDbCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(searchText) && searchText != "SEARCH...")
                        {
                            cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                        }
                        using (var reader = cmd.ExecuteReader())
                        {
                            studentAccounts.Load(reader);
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Error loading student accounts: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            dataGridViewAccount.DataSource = studentAccounts;

            // Set the headers and visibility of the columns
            dataGridViewAccount.Columns["StudentID"].HeaderText = "Student ID";
            dataGridViewAccount.Columns["StudentName"].HeaderText = "Student Name";
            dataGridViewAccount.Columns["SchoolID"].HeaderText = "School ID";
            dataGridViewAccount.Columns["Password"].HeaderText = "Password";

            // Hide the other columns
            if (dataGridViewAccount.Columns.Contains("StudentEmail")) dataGridViewAccount.Columns["StudentEmail"].Visible = false;
            if (dataGridViewAccount.Columns.Contains("Birthday")) dataGridViewAccount.Columns["Birthday"].Visible = false;
            if (dataGridViewAccount.Columns.Contains("Gender")) dataGridViewAccount.Columns["Gender"].Visible = false;
            if (dataGridViewAccount.Columns.Contains("Address")) dataGridViewAccount.Columns["Address"].Visible = false;

            if (dataGridViewAccount.Columns.Contains("Name"))
            {
                dataGridViewAccount.Columns.Remove("Name");
            }
        }

        private void dataGridViewAccount_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAccount.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewAccount.SelectedRows[0];
                int studentID = Convert.ToInt32(selectedRow.Cells["StudentID"].Value); // Get the StudentID

                // Directly populate the textboxes in the "Update and Delete Account" section
                textBoxNewName.Text = selectedRow.Cells["StudentName"].Value?.ToString();
                textBoxNewEmail.Text = selectedRow.Cells["StudentEmail"].Value?.ToString();
                maskedTextBoxNewID.Text = selectedRow.Cells["SchoolID"].Value?.ToString(); // Keep displaying SchoolID
                textBoxNewPass.Text = selectedRow.Cells["Password"].Value?.ToString();

                // Handle Birthday
                if (selectedRow.Cells["Birthday"].Value != DBNull.Value && selectedRow.Cells["Birthday"].Value is DateTime birthday)
                {
                    maskedTextBoxNewBDAY.Text = birthday.ToString("MM/dd/yyyy");
                    maskedTextBoxNewBDAY.ForeColor = SystemColors.WindowText;
                }
                else
                {
                    maskedTextBoxNewBDAY.Text = "";
                    maskedTextBoxNewBDAY.ForeColor = SystemColors.WindowText;
                }

                // Handle Gender
                string gender = selectedRow.Cells["Gender"].Value?.ToString();
                radioButtonNewMale.Checked = !string.IsNullOrEmpty(gender) && gender.Equals("male", StringComparison.OrdinalIgnoreCase);
                radioButtonNewFemale.Checked = !string.IsNullOrEmpty(gender) && gender.Equals("female", StringComparison.OrdinalIgnoreCase);

                textBoxNewAddress.Text = selectedRow.Cells["Address"].Value?.ToString();
                textBoxNewAddress.ForeColor = SystemColors.WindowText;

                // Ensure normal text color for other textboxes as well
                textBoxNewName.ForeColor = SystemColors.WindowText;
                textBoxNewEmail.ForeColor = SystemColors.WindowText;
                maskedTextBoxNewID.ForeColor = SystemColors.WindowText;
                textBoxNewPass.ForeColor = SystemColors.WindowText;
            }
            else
            {
                // Optionally clear the "Update and Delete Account" fields if no row is selected
                textBoxNewName.Clear();
                textBoxNewEmail.Clear();
                maskedTextBoxNewID.Clear();
                textBoxNewPass.Clear();
                maskedTextBoxNewBDAY.Clear();
                radioButtonNewMale.Checked = false;
                radioButtonNewFemale.Checked = false;
                textBoxNewAddress.Clear();
            }
        }

        private void LoadFullStudentDetails(string studentID)
        {
            if (string.IsNullOrEmpty(studentID)) return;

            string query = "SELECT StudentName, StudentEmail, SchoolID, Password, Birthday, Gender, Address FROM StudentAccount WHERE SchoolID = ?";

            using (var connection = new OleDbConnection(accessConnectionString))
            {
                try
                {
                    connection.Open();
                    using (var cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?", studentID);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBoxNewEmail.Text = reader["StudentEmail"].ToString();
                                if (reader["Birthday"] != DBNull.Value && DateTime.TryParse(reader["Birthday"].ToString(), out DateTime birthday))
                                {
                                    maskedTextBoxNewBDAY.Text = birthday.ToString("MM/dd/yyyy"); // Adjust format as needed
                                }
                                string gender = reader["Gender"].ToString();
                                if (!string.IsNullOrEmpty(gender))
                                {
                                    if (gender.ToLower() == "male")
                                    {
                                        radioButtonNewMale.Checked = true;
                                    }
                                    else if (gender.ToLower() == "female")
                                    {
                                        radioButtonNewFemale.Checked = true;
                                    }
                                }
                                textBoxNewAddress.Text = reader["Address"].ToString();
                            }
                            else
                            {
                                // Optional: Handle the case where no student with the given ID is found
                                Console.WriteLine($"Warning: No student found with ID: {studentID}");
                            }
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Error loading student details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dataGridViewAccount.SelectedRows.Count > 0)
            {
                int studentIDToUpdate = Convert.ToInt32(dataGridViewAccount.SelectedRows[0].Cells["StudentID"].Value); // Get StudentID
                if (MessageBox.Show("Are you sure you want to update this student's account?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateStudentAccount(studentIDToUpdate.ToString()); // Pass StudentID
                }
            }
            else
            {
                MessageBox.Show("Please select a student account to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAccount.SelectedRows.Count > 0)
            {
                int studentIDToDelete = Convert.ToInt32(dataGridViewAccount.SelectedRows[0].Cells["StudentID"].Value); // Get StudentID
                if (MessageBox.Show("Are you sure you want to delete this student's account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteStudentAccount(studentIDToDelete.ToString()); // Pass StudentID
                }
            }
            else
            {
                MessageBox.Show("Please select a student account to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateStudentAccount(string studentIDToUpdate)
        {
            if (string.IsNullOrEmpty(studentIDToUpdate)) return;

            string newName = textBoxNewName.Text;
            string newEmail = textBoxNewEmail.Text;
            string newPassword = textBoxNewPass.Text;
            string newAddress = textBoxNewAddress.Text;
            string newGender = radioButtonNewMale.Checked ? "Male" : (radioButtonNewFemale.Checked ? "Female" : null);
            string newSchoolID = maskedTextBoxNewID.Text == maskedTextBoxNewID.Tag?.ToString() ? null : maskedTextBoxNewID.Text;
            string birthdayString = null;

            // Check if the birthday mask is completed and parse it
            if (maskedTextBoxNewBDAY.MaskCompleted && DateTime.TryParse(maskedTextBoxNewBDAY.Text, out DateTime newBirthday))
            {
                // Format the birthday as a string (e.g., "MM/dd/yyyy")
                birthdayString = newBirthday.ToString("MM/dd/yyyy");
            }

            string query = "UPDATE StudentAccount SET [StudentName] = @StudentName, [StudentEmail] = @StudentEmail, [SchoolID] = @SchoolID, [Password] = @Password, [Birthday] = @Birthday, [Gender] = @Gender, [Address] = @Address WHERE [StudentID] = @StudentID";

            using (var connection = new OleDbConnection(accessConnectionString))
            {
                try
                {
                    connection.Open();
                    using (var cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.Add("@StudentName", OleDbType.VarWChar).Value = newName;
                        cmd.Parameters.Add("@StudentEmail", OleDbType.VarWChar).Value = newEmail;
                        cmd.Parameters.Add("@SchoolID", OleDbType.VarWChar).Value = string.IsNullOrEmpty(newSchoolID) ? DBNull.Value : (object)newSchoolID;
                        cmd.Parameters.Add("@Password", OleDbType.VarWChar).Value = newPassword;
                        cmd.Parameters.Add("@Birthday", OleDbType.VarWChar).Value = string.IsNullOrEmpty(birthdayString) ? DBNull.Value : (object)birthdayString; // Pass as string
                        cmd.Parameters.Add("@Gender", OleDbType.VarWChar).Value = string.IsNullOrEmpty(newGender) ? DBNull.Value : (object)newGender;
                        cmd.Parameters.Add("@Address", OleDbType.VarWChar).Value = string.IsNullOrEmpty(newAddress) ? DBNull.Value : (object)newAddress;
                        cmd.Parameters.Add("@StudentID", OleDbType.Integer).Value = int.Parse(studentIDToUpdate);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAccountData(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to update student account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Database Error during update: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteStudentAccount(string studentIDToDelete) // Changed parameter name to be clearer
        {
            if (string.IsNullOrEmpty(studentIDToDelete)) return;

            string query = "DELETE FROM StudentAccount WHERE StudentID = ?"; // Use StudentID

            using (var connection = new OleDbConnection(accessConnectionString))
            {
                try
                {
                    connection.Open();
                    using (var cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("?", studentIDToDelete);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Student account deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAccountData(); // Refresh the DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete student account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Database Error during deletion: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}