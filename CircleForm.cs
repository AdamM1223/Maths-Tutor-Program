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
    public partial class frmCircle : Form
    {
        public frmCircle()
        {
            InitializeComponent();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            // The following code will run when the Area Button has been pressed.
            /* The values within the TextBox will be put through Validation methods declared within another class,
             * this will check the Data is valid in 3 different ways. If Data is valid, a Circle object will be created with
             * the corresponding values. The Form labels of Description and Area will be changed using values of the Circle object
             */
            if (Validation.IsValidData(txtRadius, "Radius"))
            {
                double radius = Convert.ToDouble(txtRadius.Text);
                Circle c = new Circle("Circle: Area = PI x radius x radius", radius);
                lblDescription.Text = c.getDescription();
                lblArea.Text = "Area = 3.14 * " + radius + " x " + radius + " = " + Convert.ToString(c.calculateArea());
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

        private void frmCircle_Load(object sender, EventArgs e)
        {

        }
    }
}
