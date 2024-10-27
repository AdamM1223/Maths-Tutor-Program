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
    public partial class frmTriangle : Form
    {
        public frmTriangle()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            // The following code will run when the Area Button has been pressed.
            /* The values within the 2 TextBoxes will be put through Validation methods declared within another class,
             * this will check the Data is valid in 3 different ways. If Data is valid, a Triangle object will be created with
             * the corresponding values. The Form labels of Description and Area will be changed using values of the Triangle object
             */
            if ((Validation.IsValidData(txtHeight, "Height") && Validation.IsValidData(txtBase, "Base")))
            {
                double Base = Convert.ToDouble(txtBase.Text);
                double height = Convert.ToDouble(txtHeight.Text);
                Triangle t = new Triangle("Triangle: Area = 0.5 * (Base * Height)", Base, height);
                lblDescription.Text = t.getDescription();
                lblArea.Text = "Area = 0.5 *" + Base + " * " + height + " = " + Convert.ToString(t.calculateArea());
            }

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
