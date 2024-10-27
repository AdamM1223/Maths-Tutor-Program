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
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        { /* Once the edit details button is clicked, the code will store the input of the two Textboxes, these will be ran through a IsPresent Validation method
           *  to ensure there is valid data entered. If data is not valid the user will be returned a MessageBox telling them they must enter data. */

            string username = (txtUsername.Text);
            string password = Convert.ToString(txtPassword.Text);
            int errorHandle = 0;

            if (Validation.IsPresent(txtUsername, "Username") && (Validation.IsPresent(txtPassword, "Password")))
            {

                /* For Loop is used to loop through the total number of Student Detail keys in the Dictionary, for each one the user inputted Username will be 
                 * compared to the value currently stored in the Dictonary. If the username entered does indeed match, this will store a new value for password using
                 * the key value within the Dictionary as well as setting the errorHandle variable to 1, to stop any error messages being returned.
                 * The Staff Member will be shown a MessageBox confirming what the new password is. */

                for (int i = 0; i < frmLogin.userLogins.Count; i++)
                {
                    string userCheck = frmLogin.userLogins.Keys.ElementAt(i);
                    if (userCheck.ToLower() == username.ToLower())
                    {
                        frmLogin.userLogins[userCheck] = password;
                        MessageBox.Show("Change Succesful\n\n Password " + frmLogin.userLogins.Values.ElementAt(i));
                        errorHandle = 1;
                        break;
                    }
                }
                // If no username matches are found this if statement will run, showing an error message, as the variable is initially declared as 0
                if (errorHandle == 0)
                {
                    MessageBox.Show("Invalid Username - Please try again.");
                }
            }
        }
    }
}

