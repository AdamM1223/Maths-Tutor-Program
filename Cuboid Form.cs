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
    public partial class frmCuboid : Form
    {
        public frmCuboid()
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
            /* The values within the 3 TextBoxes will be put through Validation methods declared within another class,
             * this will check the Data is valid in 3 different ways. If Data is valid, a Cuboid object will be created with
             * the corresponding values. The Form labels of Description and Area will be changed using values of the Cuboid object
             */

            if (Validation.IsValidData(txtHeight, "Height") && (Validation.IsValidData(txtLength, "Length")) && (Validation.IsValidData(txtWidth, "Width")))
            {
                double length = Convert.ToDouble(txtLength.Text);
                double width = Convert.ToDouble(txtWidth.Text);
                double height = Convert.ToDouble(txtHeight.Text);
                Cuboid c3 = new Cuboid("Cuboid: Volume = Length x Width x Height", length, width, height);
                lblDescription.Text = c3.getDescription();
                lblVolume.Text = "Volume = " + length + " * " + width + " * " + height + " = " + Convert.ToString(c3.calculateVolume());
            }

        }
    }
}
