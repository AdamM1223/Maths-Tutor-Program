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
    public partial class frmSquare : Form
    {
        public frmSquare()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            // The following code will run when the Area Button has been pressed.
            /* The values within the TextBox will be put through Validation methods declared within another class,
             * this will check the Data is valid in 3 different ways. If Data is valid, a Square object will be created with
             * the corresponding values. The Form labels of Description and Area will be changed using values of the Square object
             */
            if (Validation.IsValidData(txtLength, "Length"))
            {
                double length = Convert.ToDouble(txtLength.Text);
                Square s = new Square("Square - All sides are equal. Area = length*2", length);
                lblDescription.Text = s.getDescription();
                lblArea.Text = "Area = " + Convert.ToString(s.calculateArea());
            }

        }

        private void frmSquare_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // The following code will run when the Exit Button has been pressed.
            this.Close();
            Form Area = new frmArea();
            Area.ShowDialog();
            // This code will close the current Form and show the previous Menu Form
        }
    }
}
