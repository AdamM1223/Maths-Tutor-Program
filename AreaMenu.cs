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
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {   // When the Square button is pressed this code will display the Square Form and hide the current Form
            Form Square1 = new frmSquare();
            this.Hide();
            Square1.Show();
        }

        private void frmArea_Load(object sender, EventArgs e)
        {

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {   // When the Circle button is pressed this code will display the Circle Form and hide the current Form
            Form Circle1 = new frmCircle();
            this.Hide();
            Circle1.Show();
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {   // When the Rectangle button is pressed this code will display the Rectangle Form and hide the current Form
            Form Rectangle1 = new frmRectangle();
            this.Hide();
            Rectangle1.Show();
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {   // When the Triangle button is pressed this code will display the Triangle Form and hide the current Form
            Form Triangle1 = new frmTriangle();
            this.Hide();
            Triangle1.Show();
        }

        private void btnQuiz_Click(object sender, EventArgs e)
        {   // When the Area Quiz button is pressed this code will display the Area Quiz Form and hide the current Form
            Form AreaQuiz = new frmAQ1();
            this.Hide();
            AreaQuiz.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {   // This code will close the current Form when the Exit button is pressed and show the previous Menu
            this.Close();
            Form MainMenu = new frmMainMenu();
            MainMenu.Show();
        }
    }
}
