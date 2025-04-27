using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.OleDb;

namespace Final_Project.PAL.User_Control
{
    public partial class UserControlAddClass : UserControl
    {
        OleDbConnection myConn;
        OleDbCommand cmd;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= ""C:\Database Files\Attendance Management\Attendance Management.accdb""";

        // Public properties to store selected class data
        public static string SelectedClassName { get; set; }
        public static string SelectedQuantity { get; set; }
        public static string SelectedMale { get; set; }
        public static string SelectedFemale { get; set; }
        public static int SelectedClassID { get; set; }

        public UserControlAddClass()
        {
            InitializeComponent();
            LoadClass();

            // Populate input fields if data was previously selected
            if (!string.IsNullOrEmpty(SelectedClassName))
            {
                textBoxName.Text = SelectedClassName;
                textBoxHmStudents.Text = SelectedQuantity;
                textBoxMale.Text = SelectedMale;
                textBoxFemale.Text = SelectedFemale;
            }
        }

        private void pictureBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxSearch, "Search");
        }

        // This method is empty and not used. Consider removing it.


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string addInfo = "INSERT INTO Class (UserID, ClassName, QuantityStudents, MaleNumber, FemaleNumber) VALUES (?, ?, ?, ?, ?)";
            myConn = new OleDbConnection(connectionString);

            try
            {
                myConn.Open();
                cmd = new OleDbCommand(addInfo, myConn);

                string name = textBoxName.Text.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Please enter a Class Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(textBoxHmStudents.Text, out int quantity) ||
                    !int.TryParse(textBoxMale.Text, out int maleCount) ||
                    !int.TryParse(textBoxFemale.Text, out int femaleCount))
                {
                    MessageBox.Show("Please enter valid numbers for student quantities.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (maleCount + femaleCount != quantity)
                {
                    MessageBox.Show("Total students must equal the sum of male and female students.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                cmd.Parameters.AddWithValue("@UserID", 1); // Assuming a default UserID for now
                cmd.Parameters.AddWithValue("@ClassName", name);
                cmd.Parameters.AddWithValue("@QuantityStudents", quantity);
                cmd.Parameters.AddWithValue("@MaleNumber", maleCount);
                cmd.Parameters.AddWithValue("@FemaleNumber", femaleCount);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Class Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadClass(); // Refresh the grid
                ClearInputFields();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"Error adding class: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (myConn != null && myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }

        private void LoadClass()
        {
            string query = @"SELECT ClassID, Users.FullName, Class.ClassName, Class.QuantityStudents, Class.MaleNumber, Class.FemaleNumber
                             FROM Users INNER JOIN Class ON Users.UserID = Class.UserID";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewClass.Columns.Clear();
                    dataGridViewClass.DataSource = dt;

                    // Rename columns for better readability
                    if (dataGridViewClass.Columns.Contains("ClassID")) dataGridViewClass.Columns["ClassID"].HeaderText = "Class ID";
                    if (dataGridViewClass.Columns.Contains("FullName")) dataGridViewClass.Columns["FullName"].HeaderText = "Teacher Name";
                    if (dataGridViewClass.Columns.Contains("ClassName")) dataGridViewClass.Columns["ClassName"].HeaderText = "Class Name";
                    if (dataGridViewClass.Columns.Contains("QuantityStudents")) dataGridViewClass.Columns["QuantityStudents"].HeaderText = "Total Students";
                    if (dataGridViewClass.Columns.Contains("MaleNumber")) dataGridViewClass.Columns["MaleNumber"].HeaderText = "Male Students";
                    if (dataGridViewClass.Columns.Contains("FemaleNumber")) dataGridViewClass.Columns["FemaleNumber"].HeaderText = "Female Students";
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Error loading classes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a class to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dataGridViewClass.SelectedRows[0].Cells["ClassID"].Value == null)
            {
                MessageBox.Show("Could not retrieve the Class ID for updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int classIDToUpdate = Convert.ToInt32(dataGridViewClass.SelectedRows[0].Cells["ClassID"].Value);

            string newClassName = textBoxName.Text.Trim();
            if (string.IsNullOrEmpty(newClassName))
            {
                MessageBox.Show("Please enter a Class Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBoxHmStudents.Text, out int newQuantity) ||
                !int.TryParse(textBoxMale.Text, out int newMaleNum) ||
                !int.TryParse(textBoxFemale.Text, out int newFemaleNum))
            {
                MessageBox.Show("Please enter valid numbers for student quantities.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newMaleNum + newFemaleNum != newQuantity)
            {
                MessageBox.Show("Total students must equal the sum of male and female students.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string updateQuery = "UPDATE Class SET ClassName = ?, QuantityStudents = ?, MaleNumber = ?, FemaleNumber = ? WHERE ClassID = ?";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ClassName", newClassName);
                        command.Parameters.AddWithValue("@QuantityStudents", newQuantity);
                        command.Parameters.AddWithValue("@MaleNumber", newMaleNum);
                        command.Parameters.AddWithValue("@FemaleNumber", newFemaleNum);
                        command.Parameters.AddWithValue("@ClassID", classIDToUpdate);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Class Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadClass(); // Refresh the DataGridView
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("No records were updated. Please try again.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Error updating class: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExamineTableStructure()
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    DataTable schema = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, "Class", null });

                    string tableInfo = "Class Table Structure:\n";
                    foreach (DataRow row in schema.Rows)
                    {
                        tableInfo += $"Column: {row["COLUMN_NAME"]}, Type: {row["DATA_TYPE"]}, Nullable: {row["IS_NULLABLE"]}\n";
                    }

                    DataTable primaryKeys = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, new object[] { null, null, "Class" });

                    if (primaryKeys != null && primaryKeys.Rows.Count > 0)
                    {
                        tableInfo += "\nPrimary Keys:\n";
                        foreach (DataRow row in primaryKeys.Rows)
                        {
                            tableInfo += $"Column: {row["COLUMN_NAME"]}\n";
                        }
                    }
                    else
                    {
                        tableInfo += "\nNo primary key found.\n";
                    }

                    MessageBox.Show(tableInfo, "Table Structure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Error examining table structure: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonExamineDB_Click(object sender, EventArgs e)
        {
            ExamineTableStructure();
        }

        private void dataGridViewClass_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewClass.SelectedRows.Count > 0)
            {
                // Populate text boxes with selected row data
                textBoxName.Text = dataGridViewClass.SelectedRows[0].Cells["ClassName"]?.Value?.ToString();
                textBoxHmStudents.Text = dataGridViewClass.SelectedRows[1].Cells["QuantityStudents"]?.Value?.ToString();
                textBoxMale.Text = dataGridViewClass.SelectedRows[2].Cells["MaleNumber"]?.Value?.ToString();
                textBoxFemale.Text = dataGridViewClass.SelectedRows[3].Cells["FemaleNumber"]?.Value?.ToString();

                // Store ClassID if available
                if (dataGridViewClass.SelectedRows[0].Cells["ClassID"]?.Value != null)
                {
                    SelectedClassID = Convert.ToInt32(dataGridViewClass.SelectedRows[0].Cells["ClassID"].Value);
                }
                else
                {
                    SelectedClassID = 0; // Or handle appropriately if ClassID is missing
                }
            }
        }

        private void ClearInputFields()
        {
            textBoxName.Clear();
            textBoxHmStudents.Clear();
            textBoxMale.Clear();
            textBoxFemale.Clear();
        }

        private void ClearSelectedClassData()
        {
            SelectedClassName = null;
            SelectedQuantity = null;
            SelectedMale = null;
            SelectedFemale = null;
            SelectedClassID = 0;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewClass.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a class to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dataGridViewClass.SelectedRows[0].Cells["ClassID"].Value == null)
            {
                MessageBox.Show("Could not retrieve the Class ID for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int classIDToDelete = Convert.ToInt32(dataGridViewClass.SelectedRows[0].Cells["ClassID"].Value);
            string classNameToDelete = dataGridViewClass.SelectedRows[0].Cells["ClassName"]?.Value?.ToString();

            DialogResult result = MessageBox.Show($"Are you sure you want to delete class '{classNameToDelete}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string deleteInfo = "DELETE FROM Class WHERE ClassID = ?";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        using (OleDbCommand command = new OleDbCommand(deleteInfo, connection))
                        {
                            command.Parameters.AddWithValue("@ClassID", classIDToDelete);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Class '{classNameToDelete}' deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadClass(); // Refresh the DataGridView
                                ClearInputFields();
                            }
                            else
                            {
                                MessageBox.Show("No class was deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show($"Error deleting class: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dataGridViewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewClass.Rows[e.RowIndex];

                // Populate text boxes with selected cell data
                textBoxName.Text = selectedRow.Cells["ClassName"]?.Value?.ToString();
                textBoxHmStudents.Text = selectedRow.Cells["QuantityStudents"]?.Value?.ToString();
                textBoxMale.Text = selectedRow.Cells["MaleNumber"]?.Value?.ToString();
                textBoxFemale.Text = selectedRow.Cells["FemaleNumber"]?.Value?.ToString();

                // Store ClassID if available
                if (selectedRow.Cells["ClassID"]?.Value != null)
                {
                    SelectedClassID = Convert.ToInt32(selectedRow.Cells["ClassID"].Value);
                }
                else
                {
                    SelectedClassID = 0; // Or handle appropriately if ClassID is missing
                }
            }
        }

        private void dataGridViewClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewClass.SelectedRows.Count > 0)
            {
                // Populate text boxes with selected row data
                textBoxName.Text = dataGridViewClass.SelectedRows[0].Cells["ClassName"]?.Value?.ToString();
                textBoxHmStudents.Text = dataGridViewClass.SelectedRows[1].Cells["QuantityStudents"]?.Value?.ToString();
                textBoxMale.Text = dataGridViewClass.SelectedRows[2].Cells["MaleNumber"]?.Value?.ToString();
                textBoxFemale.Text = dataGridViewClass.SelectedRows[3].Cells["FemaleNumber"]?.Value?.ToString();

                // Store ClassID if available
                if (dataGridViewClass.SelectedRows[0].Cells["ClassID"]?.Value != null)
                {
                    SelectedClassID = Convert.ToInt32(dataGridViewClass.SelectedRows[0].Cells["ClassID"].Value);
                }
                else
                {
                    SelectedClassID = 0; // Or handle appropriately if ClassID is missing
                }
            }
        }

        private void labelTotalClass_Click(object sender, EventArgs e)
        {
            string query = "SELECT COUNT(*) FROM Class";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        int totalClasses = (int)command.ExecuteScalar();
                        labelTotalClass.Text = totalClasses.ToString(); // Display only the number  
                    }
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"Error retrieving total class count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}