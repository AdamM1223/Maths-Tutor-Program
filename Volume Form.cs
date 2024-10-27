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
    public partial class frmVolume : Form
    {
        public frmVolume()
        {
            InitializeComponent();
        }

        private void btnCube_Click(object sender, EventArgs e)
        {   // When the Cube button is pressed this code will display the Cube Volume Form and hide the current Form
            Form Cube1 = new frmCube();
            this.Hide();
            Cube1.Show();
        }

        private void btnCylinder_Click(object sender, EventArgs e)
        {   // When the Cylinder button is pressed this code will display the Cylinder Volume Form and hide the current Form
            Form Cylinder1 = new frmCylinder();
            this.Hide();
            Cylinder1.Show();
        }

        private void btnSphere_Click(object sender, EventArgs e)
        {   // When the Sphere button is pressed this code will display the Sphere Volume Form and hide the current Form
            Form Sphere1 = new frmSphere();
            this.Hide();
            Sphere1.Show();
        }

        private void btnCuboid_Click(object sender, EventArgs e)
        {   // When the Cuboid button is pressed this code will display the Cuboid Volume Form and hide the current Form
            Form Cuboid1 = new frmCuboid();
            this.Hide();
            Cuboid1.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {   // This code will close the current Form when the Exit button is pressed and show the previous Menu
            this.Close();
            Form MainMenu = new frmMainMenu();
            MainMenu.Show();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {   // When the Volume Quiz button is pressed this code will display the Volume Quiz Form and hide the current Form
            Form VolumeQuiz = new frmVQ1();
            this.Hide();
            VolumeQuiz.Show();
        }

        private void frmVolume_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {   // This code will close the current Form when the Exit button is pressed and show the previous Menu
            this.Close();
            Form MainMenu = new frmMainMenu();
            MainMenu.Show();
        }
    }
}
