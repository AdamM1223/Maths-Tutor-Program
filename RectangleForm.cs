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
    public partial class frmRectangle : Form
    {
        public frmRectangle()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            // The following code will run when the Area Button has been pressed.
             /* The values within the 2 TextBoxes will be put through Validation methods declared within another class,
              * this will check the Data is valid in 3 different ways. If Data is valid, a Rectangle object will be created with
              * the corresponding values. The Form labels of Description and Area will be changed using values of the Rectangle object
              */
            if ((Validation.IsValidData(txtBreadth, "Breadth") && Validation.IsValidData(txtLength, "Length")))
            {
                double length = Convert.ToDouble(txtLength.Text);
                double breadth = Convert.ToDouble(txtBreadth.Text);
                Rectangle r = new Rectangle("Rectangle: Area = Length * Breadth", length, breadth);
                lblDescription.Text = r.getDescription();
                lblArea.Text = "Area = " + length + " * " + breadth + " = " + Convert.ToString(r.calculateArea());
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
