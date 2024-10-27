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
    public partial class frmAQ4 : Form
    {
        public frmAQ4()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {


        }

        private void btnExit_Click(object sender, EventArgs e)
        {   // The following code will run when the Exit Button has been pressed and will close the current Form
            this.Close();
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            /* Code below is an IF statement which is used to check if there has been an answer given by checking if all radio buttons are empty,
             * if all 4 are unchecked the user will be shown a MessageBox telling them to select an answer */

            if (rdoAnswer1.Checked == false && rdoAnswer2.Checked == false && rdoAnswer3.Checked == false && rdoAnswer4.Checked == false)
            { MessageBox.Show("Please select an answer"); }

            /* If one of the answers is checked the code will continue to the ELSE IF, this will check if the correct answer has been checked,
             * if the user selected the correct answer,this will display a MessageBox telling the User they were correct and the score variable from frmAQ1 will be incremented. 
             * This will follow through and continue to Question 5 Form, closing the current Form. */

            else if (rdoAnswer3.Checked == true)
            {
                frmAQ1.score += 1;
                MessageBox.Show("CORRECT ANSWER");
                Form Q5 = new frmAQ5();
                this.Hide();
                Q5.Show();

            }

            /* If one of the radio buttons was selected, and it is not the correct answer, the code will continue to the ELSE part of this IF statement,
             * this will display a MessageBox telling the User what the correct answer was, continuing onto the Question 5 Form, closing the current Form.
             */

            else
            {
                MessageBox.Show("INCORRECT ANSWER");
                MessageBox.Show("The Correct Answer was" + lblAnswer3.Text);
                Form Q5 = new frmAQ5();
                this.Hide();
                Q5.Show();
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {   // When the Help button is pressed this code will display the Help Form
            Form Help = new frmHelp();
            Help.Show();
        }
    }
}
