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
    public partial class frmCylinder : Form
    {
        public frmCylinder()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            // The following code will run when the Exit Button has been pressed.
            this.Close();
            Form Volume = new frmVolume();
            Volume.ShowDialog();
            // This code will close the current Form and open the previous Volume Menu
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            // The following code will run when the Volume Button has been pressed.
            /* The values within the 2 TextBoxes will be put through Validation methods declared within another class,
             * this will check the Data is valid in 3 different ways. If Data is valid, a Cylinder object will be created with
             * the corresponding values. The Form labels of Description and Area will be changed using values of the Cylinder object
             */

            if ((Validation.IsValidData(txtRadius, "Radius") && Validation.IsValidData(txtHeight, "Height")))
            {
                double radius = Convert.ToDouble(txtRadius.Text);
                double height = Convert.ToDouble(txtHeight.Text);
                Cylinder c2 = new Cylinder("Cylinder: Volume = PI * Radius^2 * Height", radius, height);
                lblDescription.Text = c2.getDescription();
                lblVolume.Text = "Volume = " + Math.Round(Math.PI, 3) + " * " + Math.Pow(radius, 2) + " * " + height + " = " + Convert.ToString(c2.calculateVolume());
            }

        }
    }
}
