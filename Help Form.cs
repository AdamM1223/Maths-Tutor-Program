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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {   // When the Exit button has been pressed, this code will close the current Form
            this.Close();
        }

        private void btnArea_Click(object sender, EventArgs e)
        { /* When the Area Help button is pressed, the 4 Help labels will be changed to display the
           * 4 different Area formulae that will be required, to give the student a helping hand for their revision */

            lblHelp1.Text = "A square has 4 equal sides. Length * Length";
            lblHelp2.Text = "A circle needs a radius. PI * Radius^2";
            lblHelp3.Text = "A rectangle has 2 pairs of equal sides, Length * Breadth";
            lblHelp4.Text = "A triangle needs base and height, 0.5 * (Base * Height)";
        }

        private void btnVolume_Click(object sender, EventArgs e)
        { /* When the Volume Help button is pressed, the 4 Help labels will be changed to display the
           * 4 different Volume formulae that will be required, to give the student a helping hand for their revision */

            lblHelp1.Text = "A cube has equal sides. Length * Length * Length";
            lblHelp2.Text = "A cuboid has 3 pairs of equal sides, Length * Breadth * Height";
            lblHelp3.Text = "A cylinder needs 2 inputs. Radius + Height, PI * Radius^2 * Height";
            lblHelp4.Text = "A sphere only requires radius, 4/3 * PI * Radius^3";
        }
    }
}
