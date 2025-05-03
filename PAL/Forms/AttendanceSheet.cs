using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Final_Project.PAL.Forms
{
    public partial class AttendanceSheet : Form
    {
        public string StudentNameValue { get; set; }
        public string StatusValue { get; set; }
        public string DateTextBoxValue { get; set; }
        public string ClassNameValue { get; set; }

        public AttendanceSheet()
        {
            InitializeComponent();
        }

        private void AttendanceSheet_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(StudentNameValue))
            {
                textBoxStudentName.Text = StudentNameValue;
            }

            if (!string.IsNullOrEmpty(StatusValue))
            {
                textBoxStatus.Text = StatusValue;
            }

            if (!string.IsNullOrEmpty(ClassNameValue))
            {
                textBoxClassName.Text = ClassNameValue;
            }

            if (DateTime.TryParse(DateTextBoxValue, out DateTime parsedDate))
            {
                textBoxDate.Text = parsedDate.ToShortDateString(); // Display date in short format
            }
            else if (!string.IsNullOrEmpty(DateTextBoxValue))
            {
                MessageBox.Show("Invalid date format received.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDate.Text = DateTextBoxValue; // Display the invalid input
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            // Add code here to save the changes made in the form
            Close();
        }

        // Consider handling TextChanged events if you need real-time updates or validation
        // private void textBoxStatus_TextChanged(object sender, EventArgs e) { }
        // private void textBoxDate_TextChanged(object sender, EventArgs e) { }
        // private void textBoxStudentName_TextChanged(object sender, EventArgs e) { }
        // private void textBoxClassName_TextChanged(object sender, EventArgs e) { }
    }
}