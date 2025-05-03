using System;
using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Final_Project.PAL.User_Control
{
    public partial class UserControlRegister : UserControl
    {
        private readonly string accessConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                                      Data Source=C:\Database Files\Attendance Management\Attendance Management.accdb;";

        public UserControlRegister()
        {
            InitializeComponent();
            buttonAdd.Click += ButtonAdd_Click;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            string studentId = maskedTextBoxID.Text.Trim();
            string name = textBoxName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPass.Text.Trim();
            string gender = radioButtonMale.Checked ? "Male" : "Female";
            string address = textBoxAddress.Text.Trim();

            AddUser(studentId, name, email, password, gender, address);
        }

        private bool ValidateInputs()
        {
            // Validate ID format (0000-0000000-0)
            if (!Regex.IsMatch(maskedTextBoxID.Text, @"^\d{4}-\d{7}-\d$"))
            {
                MessageBox.Show("Invalid ID format. Please use 0000-0000000-0 format.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter student name.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate email format
            if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate password (minimum 6 characters)
            if (textBoxPass.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public void AddUser(string studentId, string name, string email, string password, string gender, string address)
        {
            try
            {
                using (var connection = new OleDbConnection(accessConnectionString))
                {
                    connection.Open();

                    // Check if student exists in AddStudent table
                    if (!StudentExists(connection, studentId))
                    {
                        MessageBox.Show("Student is not registered in the database. Please register the student first.",
                                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if email already exists
                    if (EmailExists(connection, email))
                    {
                        MessageBox.Show("An account with this email already exists. Please use a different email.",
                                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insert new user
                    if (InsertUser(connection, studentId, name, email, password, gender, address))
                    {
                        MessageBox.Show("Student account created successfully!",
                                      "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create student account. Please try again.",
                                      "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool StudentExists(OleDbConnection connection, string studentId)
        {
            const string query = "SELECT COUNT(*) FROM AddStudent WHERE StudentID = @StudentID";
            using (var cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private bool EmailExists(OleDbConnection connection, string email)
        {
            const string query = "SELECT COUNT(*) FROM Users WHERE Email = @Email";
            using (var cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        private bool InsertUser(OleDbConnection connection, string studentId, string name,
                              string email, string password, string gender, string address)
        {
            const string query = @"INSERT INTO Users ([StudentID], [Name], [Email], [Password], 
                                 [Gender], [Address], [Role]) 
                                 VALUES (@StudentID, @Name, @Email, @Password, @Gender, @Address, 'Student')";

            using (var cmd = new OleDbCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Address", address);

                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private void ClearForm()
        {
            maskedTextBoxID.Clear();
            textBoxName.Clear();
            textBoxEmail.Clear();
            textBoxPass.Clear();
            textBoxAddress.Clear();
            radioButtonMale.Checked = true;
        }
    }
}