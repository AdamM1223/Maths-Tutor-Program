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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {   // When the Area Menu button is pressed this code will display the Area Menu Form
            Form Area = new frmArea();
            this.Hide();
            Area.Show();

         }

        private void btnExit_Click(object sender, EventArgs e)
        {   // This code will close the current Form when the Exit button is pressed and open the Login Form
            this.Close();
            Form Login = new frmLogin();
            Login.ShowDialog();

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {   // When the Area Menu button is pressed this code will display the Area Menu Form
            Form Volume = new frmVolume();
            this.Hide();
            Volume.Show();
        }

        private void btnPast_Click(object sender, EventArgs e)
        {   // When the Past Quizzes button is pressed this code will display the Past Quizzes Form
            Form Past = new frmPast();
            this.Hide();
            Past.Show();
        }

    }
}
