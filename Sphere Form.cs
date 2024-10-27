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
    public partial class frmSphere : Form
    {
        public frmSphere()
        {
            InitializeComponent();
        }


        private void btnVolume_Click(object sender, EventArgs e)
        {
            // The following code will run when the Volume Button has been pressed.
            /* The values within the TextBox will be put through Validation methods declared within another class,
             * this will check the Data is valid in 3 different ways. If Data is valid, a Sphere object will be created with
             * the corresponding values. The Form labels of Description and Area will be changed using values of the Sphere object
             */
            if (Validation.IsValidData(txtRadius, "Radius"))
            {
                double radius = Convert.ToDouble(txtRadius.Text);
                Sphere s1 = new Sphere("Sphere: Volume = 4/3 * Pi * radius^3", radius);
                lblDescription.Text = s1.getDescription();
                lblVolume.Text = "Volume = 4/3" + " * " + Math.Round(Math.PI, 3) + " * " + Math.Pow(radius, 3) + " = " + Convert.ToString(s1.calculateVolume());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // The following code will run when the Exit Button has been pressed.
            this.Close();
            Form Volume = new frmVolume();
            Volume.ShowDialog();
            // This code will close the current Form and open the previous Volume Menu
        }

        private void lblRadius_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblVolume_Click(object sender, EventArgs e)
        {

        }
    }
}
