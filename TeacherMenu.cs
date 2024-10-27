using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsTutor
{
    public partial class frmTeacher : Form
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {   // When the Edit Details button is pressed this code will display the Edit Details Form
            Form EditDetails = new frmEdit();
            EditDetails.ShowDialog();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {   // When the Student Menu button is pressed this code will display the Student Menu Form
            Form Students = new frmMainMenu();
            Students.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {   // This code will close the current Form when the Exit button is pressed and open the Login Form
            this.Close();
            Form Login = new frmLogin();
            Login.ShowDialog();
        }
    }
}
