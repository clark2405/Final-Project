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
using MailKit.Security;
using MimeKit;

// Add this reference
using System.Data.Common;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Final_Project.PAL.Forms
{
    public partial class FormForgotPassword : BaseForm
    {
        private string verificationCode;
        private string userEmail;
        int cd = 30;

        public FormForgotPassword()
        {
            InitializeComponent();
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

            if (!IsEmailRegistered(textBoxEmail.Text) || textBoxEmail.Text == "juandelacruz@gmail.com")
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

            if (!IsEmailRegistered(textBoxEmail.Text) || textBoxEmail.Text == "juandelacruz@gmail.com")
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
            if (textBox1.Text == verificationCode)
            {
                MessageBox.Show("Code verified. You can now reset your password.");
                ChangePassword change = new ChangePassword();
                change.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect verification code.");
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
            //string email = textBoxEmail.Text.Trim();

            //if (string.IsNullOrEmpty(email) || email == "juandelacruz@gmail.com" || !IsValidEmail(email))
            //{
            //  MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // return;
            //  }
            //Countdown();

            userEmail = textBoxEmail.Text.Trim();

            if (string.IsNullOrEmpty(userEmail))
            {
                MessageBox.Show("Please enter your registered email.");
                return;
            }

            if (IsEmailRegistered(userEmail)) // Use inherited method
            {
                verificationCode = GenerateVerificationCode();
                if (SendVerificationEmail(userEmail, verificationCode))
                {
                    MessageBox.Show("A verification code has been sent to your email.");
                }
                else
                {
                    MessageBox.Show("Failed to send email. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("This email is not registered.");
            }
        }

        private string GenerateVerificationCode()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString();
        }

        private bool SendVerificationEmail(string recipientEmail, string verificationCode)
        {
            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("CheckPoint Support", "@yeshahahhaa@gmail.com"));
                message.To.Add(MailboxAddress.Parse(recipientEmail));
                message.Subject = "CheckPoint Password Reset Code";

                message.Body = new TextPart("plain")
                {
                    Text = $"Hello,\n\nYour password reset verification code is: {verificationCode}\n\nIf you did not request this, please ignore this email.\n\n- CheckPoint Team"
                };

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                    // IMPORTANT: Replace this with your Gmail App Password (not your actual Gmail password)
                    client.Authenticate("yesshahahhaa@gmail.com", "czob ysvj bosb tiek");

                    client.Send(message);
                    client.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Email sending failed:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        
    }
}
