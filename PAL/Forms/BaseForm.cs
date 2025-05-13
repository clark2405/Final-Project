using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.PAL.Forms
{
    using System;
    using System.Data.OleDb;
    using System.Security.Cryptography;
    using System.Text;
    using System.Windows.Forms;

        public partial class BaseForm : Form

        {
            protected string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Database Files\Attendance Management\DatabaseHere (Final).accdb";
            public BaseForm()

            {

                InitializeComponent();

            }
            protected string HashPassword(string password)

            {
                using (SHA256 sha256 = SHA256.Create())

                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                    StringBuilder builder = new StringBuilder();
                    foreach (byte b in bytes)
                    {
                        builder.Append(b.ToString("x2")); // hexadecimal format
                    }

                    return builder.ToString();

                }

            }

            protected bool IsEmailRegistered(string email)
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM Users WHERE Email = ?";

                    using (OleDbCommand cmd = new OleDbCommand(query, connection))

                    {
                        cmd.Parameters.AddWithValue("?", email); // Use positional parameters with OleDb
                        connection.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }

                }

            }

        }
 }


