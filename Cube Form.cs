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
    public partial class frmCube : Form
    {
        public frmCube()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // The following code will run when the Exit Button has been pressed.
            this.Close();
            Form Volume = new frmVolume();
            Volume.ShowDialog();
            // This code will close the current Form and open the previous Volume Menu
        }

        private void lblArea_Click(object sender, EventArgs e)
        {

        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            // The following code will run when the Volume Button has been pressed.
            /* The values within the TextBox will be put through Validation methods declared within another class,
             * this will check the Data is valid in 3 different ways. If Data is valid, a Cube object will be created with
             * the corresponding values. The Form labels of Description and Area will be changed using values of the Cube object
             */
            if (Validation.IsValidData(txtLength, "Length"))
            {
                double length = Convert.ToDouble(txtLength.Text);
                Cube c1 = new Cube("Cube - All lengths are equal. Volume = length*3", length);
                lblDescription.Text = c1.getDescription();
                lblVolume.Text = "Volume = " + Convert.ToString(c1.calculateVolume());
            }
        }
    }
}
