using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Final_Project.PAL.User_Control
{
    public partial class UserControlAttendance: UserControl
    {
        OleDbConnection myConn;
        OleDbCommand cmd;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Database Files\Attendance Management\Attendance Management.accdb";

        public UserControlAttendance()
        {
            InitializeComponent();
        }
    }
}
