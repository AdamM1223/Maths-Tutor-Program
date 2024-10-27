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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // This code initialises the Dictionary of Login Details, which this Form will use as a comparison tool
        public static Dictionary<string, string> userLogins = new Dictionary<string, string>
        {
            {"amcc", "pass1" },
            {"c", "1" },
            {"e", "2"},
            {"g", "3"},
            {"f", "4"},
            {"kl", "5"},
        };
        // This code initialises a Dictionary of Staff Login Details, which will be used to validate Logins
        private Dictionary<int, int> staffLogins = new Dictionary<int, int>
        {
            { 1, 101 },
            { 2, 202 },
            { 3, 303 },
            { 4, 404 },
            { 0, 0 }
        };

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            // This code will close the current Form
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            /* The following code will take the input from the 2 Login Detail Textboxes and work through the existing userLogins Dictionary to
             * compare the values, finding if there is a valid match. If there is a match, the Main Menu Form will be shown, otherwise a MessageBox
             * will be displayed, telling the user to check Login Details */

                string username = (txtUsername.Text);
                string password = Convert.ToString(txtPassword.Text);
            // Variable used to determine if the user requires an Error Message, set to 0
                int errorHandle = 0;

            /* For Loop to iterate through the different Log in details in the Dictionary, the details from the Dictionary will be stored as a variable, allowing
             * a comparison to be made for each member of the Dictionary. The username will be compared first, if a match is found, the corresponding value in the Dict
             * will be used to compare against the user input. If a match is found for the details, the user will be welcomed with a MessageBox and brought forward 
             * to the Main Menu Screen, with the Login Form being hidden from view.
             */
            if (Validation.IsPresent(txtUsername, "Username") && (Validation.IsPresent(txtPassword, "Password")))
            {
                for (int i = 0; i < userLogins.Count; i++)
                {
                    string userCheck = userLogins.Keys.ElementAt(i);
                    string passCheck = userLogins.Values.ElementAt(i);
                    if (userCheck.ToLower() == username.ToLower())
                    {
                        if (passCheck.ToLower() == password.ToLower())
                        {
                            MessageBox.Show("Login Succesful\n\n Welcome " + username);
                            Form MainMenu = new frmMainMenu();
                            MainMenu.Show();
                            this.Hide();
                            errorHandle = 1;
                            // If no erros found with Login details, this variable will be set to 1, to avoid the Validation technique used here

                            break;
                        }
                        else
                        {
                        }
                    }
                }
                try
                {
                    int staffUser = Convert.ToInt16(txtUsername.Text);
                    int staffPass = Convert.ToInt16(txtPassword.Text);
                    for (int i = 0; i < staffLogins.Count; i++)
                    {
                        int userCheck = staffLogins.Keys.ElementAt(i);
                        int passCheck = staffLogins.Values.ElementAt(i);
                        if (userCheck == staffUser)
                        {
                            if (passCheck == staffPass)
                            {
                                MessageBox.Show("Login Succesful\n\n Welcome " + username);
                                Form Teacher = new frmTeacher();
                                Teacher.Show();
                                this.Hide();
                                errorHandle = 1;
                                // If no erros found with Login details, this variable will be set to 1, to avoid the Validation technique used here

                                break;
                            }
                            else
                            {
                            }
                        }
                    }
                }
                catch { Exception ex1; }
                /* If the details were not a match, the IF statement will continue through to this IF statement, using the initially declared variable errorHandle,
                 * the program will display a MessageBox telling the User to check the Login details. If there has been a match, the user will not be shown this Message */
                if (errorHandle == 0)
                {
                    MessageBox.Show("Error, please check Login details");
                }
            }
        }

    }
}
    

