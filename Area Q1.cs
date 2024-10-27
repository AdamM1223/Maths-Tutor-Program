using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsTutor
{
    public partial class frmAQ1 : Form
    {
        public frmAQ1()
        {
            InitializeComponent();
        }
        // Public static variables are declared to store a changing score, and to store the results within an int List, allowing manipulation through multiple Forms
        public static int score = 0;

        public static List<int> results = new List<int>();
       
        private void btnNext_Click(object sender, EventArgs e)
        {   // This code will run once the Next Question button has been pressed 
            score = 0;

            /* Score will be reset to 0 once this has been pressed as this is the first question, as the score could still be from the previous attempt.
             * Code below is an IF statement which is used to check if there has been an answer given by checking if all radio buttons are empty,
             * if all 4 are unchecked the user will be shown a MessageBox telling them to select an answer */

            if (rdoAnswer1.Checked == false && rdoAnswer2.Checked == false && rdoAnswer3.Checked == false && rdoAnswer4.Checked == false)
                { MessageBox.Show("Please select an answer"); }

            /* If one of the answers is checked the code will continue to the ELSE IF, this will check if the correct answer has been checked,
             * if the user selected the correct answer, this will display a MessageBox telling the User they were correct and the score variable will be incremented. 
             * This will follow through and continue to Question 2 Form, closing the current Form. As well as appending the results int list with -1, 
             * to help us with future validation when checking the scores. */

            else if (rdoAnswer3.Checked == true){
                    score += 1;
                MessageBox.Show("CORRECT ANSWER");
                Form Q2 = new frmAQ2();
                this.Hide();
                Q2.Show();
                results.Append(-1);

            }

            /* If one of the radio buttons was selected, and it is not the correct answer, the code will continue to the ELSE part of this IF statement,
             * this will display a MessageBox telling the User what the correct answer was, continuing onto the Question 2 Form, closing the current Form.
             */

            else
            {
                MessageBox.Show("INCORRECT ANSWER");
                MessageBox.Show("The Correct Answer was" + lblAnswer3.Text);
                Form Q2 = new frmAQ2();
                this.Hide();
                Q2.Show();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {   // The following code will run when the Exit Button has been pressed and will close the current Form
            this.Close();
        }

        private void frmAQ1_Load(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {   // When the Help button is pressed this code will display the Help Form
            Form Help = new frmHelp();
            Help.Show();
        }
    }
}
