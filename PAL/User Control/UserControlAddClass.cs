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
    public partial class UserControlAddClass : UserControl
    {
        private string accessConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;
                                          Data Source=C:\Database Files\Attendance Management\Attendance Management.accdb;";

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
    }
}
