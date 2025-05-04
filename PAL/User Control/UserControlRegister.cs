using System;
using System.Data.OleDb;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Final_Project.PAL.User_Control
{
    public partial class UserControlRegister : UserControl
    {
        private string accessConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Database Files\Attendance Management\DatabaseHere.accdb";

        public UserControlRegister()
        {
            InitializeComponent();
            InitializeValidation();
            InitializePlaceholders();
        }

        // Update the InitializePlaceholders method to use the updated SetPlaceholder
        private void InitializePlaceholders()
        {
            SetPlaceholder(textBoxEmail, "juandelacruz@email.com");
            SetPlaceholder(textBoxStudentID, "0000-0000000-0"); // Now supports MaskedTextBox
        }

        // Update the SetPlaceholder method to handle MaskedTextBox separately
        private void SetPlaceholder(Control control, string placeholderText)
        {
            if (control is TextBox textBox)
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = SystemColors.GrayText;
                textBox.Tag = placeholderText; // Store original placeholder

                textBox.Enter += (sender, e) => RemovePlaceholder(textBox);
                textBox.Leave += (sender, e) => AddPlaceholder(textBox);
            }
            else if (control is MaskedTextBox maskedTextBox)
            {
                maskedTextBox.Text = placeholderText;
                maskedTextBox.ForeColor = SystemColors.GrayText;
                maskedTextBox.Tag = placeholderText; // Store original placeholder

                maskedTextBox.Enter += (sender, e) => RemovePlaceholder(maskedTextBox);
                maskedTextBox.Leave += (sender, e) => AddPlaceholder(maskedTextBox);
            }
        }

        private void RemovePlaceholder(Control control)
        {
            if (control is TextBox textBox && textBox.Text == textBox.Tag?.ToString())
            {
                textBox.Text = "";
                textBox.ForeColor = SystemColors.WindowText;
            }
            else if (control is MaskedTextBox maskedTextBox && maskedTextBox.Text == maskedTextBox.Tag?.ToString())
            {
                maskedTextBox.Text = "";
                maskedTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        private void AddPlaceholder(Control control)
        {
            if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag?.ToString();
                textBox.ForeColor = SystemColors.GrayText;
            }
            else if (control is MaskedTextBox maskedTextBox && string.IsNullOrWhiteSpace(maskedTextBox.Text))
            {
                maskedTextBox.Text = maskedTextBox.Tag?.ToString();
                maskedTextBox.ForeColor = SystemColors.GrayText;
            }
        }

        private void InitializeValidation()
        {
            HideErrorPic();
            textBoxEmail.TextChanged += TextBoxEmail_TextChanged;
            textBoxStudentID.TextChanged += TextBoxStudentID_TextChanged;
            dateTimePickerDOB.TextChanged += DateTimePickerDOB_TextChanged;
            dateTimePickerDOB.TextChanged += DateTimePickerDOB_ValueChanged;
        }

        public void HideErrorPic()
        {
            pictureBoxErrorDateofBirth.Visible = false;
            pictureBoxErrorEmail.Visible = false;
            pictureBoxErrorID.Visible = false;
        }

        public void ClearTextBox()
        {
            // Clear text normally
            textBoxFullName.Clear();
            textBoxEmail.Clear();
            textBoxPassword.Clear();
            textBoxStudentID.Clear();
            textBoxAddress.Clear();

            // Reset placeholders
            SetPlaceholder(textBoxFullName, "Enter full name");
            SetPlaceholder(textBoxEmail, "example@email.com");
            SetPlaceholder(textBoxStudentID, "0000-0000000-0");
            SetPlaceholder(textBoxAddress, "Enter address");
            SetPlaceholder(textBoxPassword, "Enter password");

            // Reset other controls
            dateTimePickerDOB.Text = DateTime.Now.ToShortDateString(); // Reset to current date
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            HideErrorPic();
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            pictureBoxErrorEmail.Visible = !IsValidEmail(textBoxEmail.Text);
        }

        private void TextBoxStudentID_TextChanged(object sender, EventArgs e)
        {
            pictureBoxErrorID.Visible = !IsValidStudentID(textBoxStudentID.Text);
        }

        private void DateTimePickerDOB_TextChanged(object sender, EventArgs e)
        {
            ValidateDateOfBirth();
        }

        private void DateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {
            ValidateDateOfBirth();
        }

        private void ValidateDateOfBirth()
        {
            try
            {
                var dob = DateTime.Parse(dateTimePickerDOB.Text);
                pictureBoxErrorDateofBirth.Visible = dob > DateTime.Today;
            }
            catch
            {
                pictureBoxErrorDateofBirth.Visible = true;
            }
        }

        private bool IsValidEmail(string email)
        {
            // Skip validation if it's just the placeholder text
            if (email == "example@email.com" || string.IsNullOrWhiteSpace(email))
                return false;

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

        private bool IsValidStudentID(string id)
        {
            // Skip validation if it's just the placeholder text
            if (id == "0000-0000000-0" || string.IsNullOrWhiteSpace(id))
                return true;

            return Regex.IsMatch(id, @"^\d{4}-\d{7}-\d$");
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                RegisterStudent();
                MessageBox.Show("Student registered successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error registering student: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            // Required fields validation (ignoring placeholders)
            if (textBoxFullName.Text == "Enter full name" || string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                textBoxEmail.Text == "example@email.com" || string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                textBoxPassword.Text == "Enter password" || string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Name, Email, and Password are required fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Email validation
            if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pictureBoxErrorEmail.Visible = true;
                return false;
            }

            // Student ID validation
            if (textBoxStudentID.Text != "0000-0000000-0" &&
                !string.IsNullOrWhiteSpace(textBoxStudentID.Text) &&
                !IsValidStudentID(textBoxStudentID.Text))
            {
                MessageBox.Show("Student ID must be in format: 0000-0000000-0", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pictureBoxErrorID.Visible = true;
                return false;
            }

            // Date of birth validation
            try
            {
                if (DateTime.Parse(dateTimePickerDOB.Text) > DateTime.Today)
                {
                    MessageBox.Show("Date of birth cannot be in the future.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pictureBoxErrorDateofBirth.Visible = true;
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid date of birth.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pictureBoxErrorDateofBirth.Visible = true;
                return false;
            }

            return true;
        }

        private void RegisterStudent()
        {
            using (var connection = new OleDbConnection(accessConnectionString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var userId = InsertUserRecord(connection, transaction);
                        InsertStudentDetails(connection, transaction, userId);
                        transaction.Commit();
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        private long InsertUserRecord(OleDbConnection connection, OleDbTransaction transaction)
        {
            const string query = @"INSERT INTO [Users] 
                                ([Username], [Password], [Role], [CreatedDate], [IsActive]) 
                                VALUES (?, ?, ?, ?, ?)";

            using (var cmd = new OleDbCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@Username", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                cmd.Parameters.AddWithValue("@Role", "Student");
                cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@IsActive", true);
                cmd.ExecuteNonQuery();
            }

            using (var cmd = new OleDbCommand("SELECT @@IDENTITY", connection, transaction))
            {
                return Convert.ToInt64(cmd.ExecuteScalar());
            }
        }

        private void InsertStudentDetails(OleDbConnection connection, OleDbTransaction transaction, long userId)
        {
            const string query = @"INSERT INTO [StudentDetails] 
                                ([UserID], [FullName], [StudentID], [DateOfBirth], [Gender], [Address]) 
                                VALUES (?, ?, ?, ?, ?, ?)";

            var gender = radioButtonMale.Checked ? "Male" :
                        (radioButtonFemale.Checked ? "Female" : "");

            using (var cmd = new OleDbCommand(query, connection, transaction))
            {
                cmd.Parameters.AddWithValue("@UserID", userId);
                cmd.Parameters.AddWithValue("@FullName", textBoxFullName.Text);
                cmd.Parameters.AddWithValue("@StudentID",
                    textBoxStudentID.Text == "0000-0000000-0" ? "" : textBoxStudentID.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(dateTimePickerDOB.Text));
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Address",
                    textBoxAddress.Text == "Enter address" ? "" : textBoxAddress.Text);
                cmd.ExecuteNonQuery();
            }
        }
    }
}