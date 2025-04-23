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

        public UserControlAddClass()
        {
            InitializeComponent();
        }
        private void pictureBoxSearch_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxSearch, "Search");
        }
        public void Count()
        {
            Count();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string addInfo = "INSERT INTO Class (UserID,ClassName, QuantityStudents, MaleNumber, FemaleNumber) VALUES (?, ?, ?, ?, ?)";
            myConn = new OleDbConnection(connectionString);
            myConn.Open();

            cmd = new OleDbCommand(addInfo, myConn);
            string name = textBoxName.Text;
            int quant;
            int maleNum;
            int femaleNum;

            if (!int.TryParse(textBoxHmStudents.Text, out quant) ||
                !int.TryParse(textBoxMale.Text, out maleNum) ||
                !int.TryParse(textBoxFemale.Text, out femaleNum))
            {
                MessageBox.Show("Please enter valid numbers for student quantities!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int sum = maleNum + femaleNum;
            if (sum != quant)
            {
                MessageBox.Show("Total quantity does not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Clear();
                textBoxHmStudents.Clear();
                textBoxMale.Clear();
                textBoxFemale.Clear();
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please fill in all fields correctly!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmd.Parameters.AddWithValue("@UserID", 1);
            cmd.Parameters.AddWithValue("@ClassName", name);
            cmd.Parameters.AddWithValue("@QuantityStudents", quant);
            cmd.Parameters.AddWithValue("@MaleNumber", maleNum);
            cmd.Parameters.AddWithValue("@FemaleNumber", femaleNum);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Class Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            myConn.Close();

            textBoxName.Clear();
            textBoxHmStudents.Clear();
            textBoxMale.Clear();
            textBoxFemale.Clear();
        }
        private void LoadClass()
        {
            string query = "SELECT * FROM ClassAdded";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewClass.Columns.Clear(); // 🔥 This line fixes the duplication
                    dataGridViewClass.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

    }
}
