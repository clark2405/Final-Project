using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; // Ensure this reference is added
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Add this reference
using System.Data.Common;

namespace Final_Project.PAL.Forms
{
    public partial class FormForgotPassword : Form
    {

        int cd = 30;

        public FormForgotPassword()
        {
            InitializeComponent();
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

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "juandelacruz@gmail.com")
            {
                textBoxEmail.Clear();
                textBoxEmail.ForeColor = Color.Black;
            }

            if (!IsValidEmail(textBoxEmail.Text) || textBoxEmail.Text == "juandelacruz@gmail.com")
                pictureBoxError.Show();
            else
                pictureBoxError.Hide();
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == string.Empty)
            {
                textBoxEmail.Text = "juandelacruz@gmail.com";
                textBoxEmail.ForeColor = Color.DarkGray;
            }

            if (!IsValidEmail(textBoxEmail.Text) || textBoxEmail.Text == "juandelacruz@gmail.com")
                pictureBoxError.Show();
            else
                pictureBoxError.Hide();
        }

        private void pictureBoxError_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxError, "Invalid Email");
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();

            if (!IsValidEmail(email) || email == "juandelacruz@gmail.com")
            {
                MessageBox.Show("Invalid Email!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if email exists in database
            try
            {
                using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=YourDatabasePath.accdb;"))
                {
                    connection.Open();
                    string query = "SELECT UserID, Username FROM Users WHERE Email = @Email";

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);

                        using (DbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Email exists in database
                                int userId = Convert.ToInt32(reader["UserID"]);
                                string username = reader["Username"]?.ToString() ?? string.Empty;

                                // In a real application, you would:
                                // 1. Generate a password reset token
                                // 2. Store it in the database with an expiration time
                                // 3. Send an email with a reset link

                                // For this demo, we'll just show a success message
                                MessageBox.Show($"Password reset instructions sent to {email} for user: {username}",
                                    "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Close();
                            }
                            else
                            {
                                // Email not found
                                MessageBox.Show("No account found with this email address.",
                                    "Email Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error verifying email: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Countdown()
        {
            buttonsend.Enabled = false;
            timer1.Start();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
        }

        private void FormForgotPassword_Load(object sender, EventArgs e)
        {
            pictureBoxError.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cd > 0)
            {
                label2.TextAlign = ContentAlignment.MiddleCenter;
                label2.Text = $"Resend OTP is in:";
                label3.Text = TimeSpan.FromSeconds(cd).ToString(@"mm\:ss");
                cd--;
            }
            else if (cd < 1)
            {
                timer1.Stop();
                buttonsend.Enabled = true;
                label2.TextAlign = ContentAlignment.MiddleCenter;
                label3.Text = "00:00";
                label2.Text = "New OTP is ready";
            }
        }

        private void buttonsend_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();

            if (string.IsNullOrEmpty(email) || email == "juandelacruz@gmail.com" || !IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Countdown();
        }
    }
}
