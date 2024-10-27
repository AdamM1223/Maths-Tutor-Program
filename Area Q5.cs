﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsTutor
{
    public partial class frmAQ5 : Form
    {
        public frmAQ5()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            /* Code below is an IF statement which is used to check if there has been an answer given by checking if all radio buttons are empty,
             * if all 4 are unchecked the user will be shown a MessageBox telling them to select an answer */

            if (rdoAnswer1.Checked == false && rdoAnswer2.Checked == false && rdoAnswer3.Checked == false && rdoAnswer4.Checked == false)
            { MessageBox.Show("Please select an answer"); }

            /* If one of the answers is checked the code will continue to the ELSE IF, this will check if the correct answer has been checked,
             * if the user selected the correct answer,this will display a MessageBox telling the User they were correct and the score variable from frmAQ1 will be incremented, 
             * since this is the final Question, this will be the final Score, this result is added to the frmAQ1.results int list, which can be viewed by the users. 
             * This will then hide the current Form */

            else if (rdoAnswer3.Checked == true)
            {
                frmAQ1.score += 1;
                MessageBox.Show("CORRECT ANSWER");
                MessageBox.Show("Your Scores so far: " + frmAQ1.score);
                frmAQ1.results.Add(frmAQ1.score);
                this.Hide();
            }
            /* If one of the radio buttons was selected, and it is not the correct answer, the code will continue to the ELSE part of this IF statement,
             * this will display a MessageBox telling the User what the correct answer was, since this is the final Question
             * this will be the final Score, this result is added to the frmAQ1.results int list, which can be viewed by the users. This will then hide the current Form 
             */

            else
            {
                MessageBox.Show("INCORRECT ANSWER");
                MessageBox.Show("The Correct Answer was" + lblAnswer3.Text);
                MessageBox.Show("Your Scores so far: " + frmAQ1.score);
                frmAQ1.results.Add(frmAQ1.score);
                this.Hide();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {   // The following code will run when the Exit Button has been pressed and will close the current Form
            this.Close();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {   // When the Help button is pressed this code will display the Help Form
            Form Help = new frmHelp();
            Help.Show();
        }
    }
}
