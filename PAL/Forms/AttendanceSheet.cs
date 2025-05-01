using System;
using System.Windows.Forms;

namespace Final_Project.PAL.Forms
{
    public partial class AttendanceSheet : Form
    {
        public string StudentNameValue { get; set; }
        public string StatusValue { get; set; }
        public string DateTextBoxValue { get; set; }
        public string ClassNameValue { get; set; }

        // Add these new properties to get the updated values. Crucial for passing data back.
        public string NewStatusValue { get; set; }
        public DateTime NewDateValue { get; set; } // To pass the date back


        public AttendanceSheet()
        {
            InitializeComponent();
        }

        private void AttendanceSheet_Load(object sender, EventArgs e)
        {
            // Populate the form's controls with the data passed from the main form.
            textBoxStudentName.Text = StudentNameValue;
            textBoxClassName.Text = ClassNameValue;
            if (DateTime.TryParse(DateTextBoxValue, out DateTime parsedDate))
            {
                textBoxDate.Text = parsedDate.ToShortDateString();
            }
            else
            {
                textBoxDate.Text = DateTextBoxValue;
            }
            comboBoxStatus.Text = StatusValue; // Set the ComboBox
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            // The user clicked "Cancel". No data is passed back.
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            // The user clicked "Confirm". Pass the updated values back.
            NewStatusValue = comboBoxStatus.Text;
            if (DateTime.TryParse(textBoxDate.Text, out DateTime parsedDate))
            {
                NewDateValue = parsedDate.Date; // Ensure only the date part is passed back
            }
            else
            {
                MessageBox.Show("Invalid date format. Please enter a valid date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // prevent the form from closing with invalid data
            }
            DialogResult = DialogResult.OK; // Set the DialogResult to OK.
            Close(); // Close the form, returning to the main form.
        }


        private void textBoxDate_TextChanged(object sender, EventArgs e)
        {
            // You might want to add validation here to ensure the date format is correct
        }

        private void textBoxClassName_TextChanged(object sender, EventArgs e)
        {
            // No specific action needed here for the current functionality
        }

        private void textBoxStudentName_TextChanged(object sender, EventArgs e)
        {
            // The student name is likely for display and not editing
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No specific action needed here for the current functionality
        }
    }
}