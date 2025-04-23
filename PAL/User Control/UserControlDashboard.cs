using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project.PAL.User_Control
{
    public partial class UserControlDashboard : UserControl
    {
        private string accessConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                          Data Source=C:\Database Files\Attendance Management\Attendance Management.accdb;";


        public UserControlDashboard()
        {
            InitializeComponent();
        }
        public void Count()
        {
            // TODO: Implement the actual logic for the Count method.
            Console.WriteLine("Count method called.");
        }
    }
}
