using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsTutor
{
    public class Validation
    {
        public static bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field");
                textBox.Focus();
                return false;
            } // if
            return true;
        } // IsPresent method is used to ensure the TextBox value is not left empty, if the value is empty
          // the user will be shown a MessageBox telling them this field is a required field.

        public static bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            } // try
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal number. ");
                textBox.Clear();
                textBox.Focus();
                return false;
            } // catch
        } // IsDecimal method is used to convert user input to a decimal value, as with the IsInteger method, this also uses
          // a try catch block to ensure it can handle any exceptions being thrown. The user will be shown a MessageBox if there are any errors.

        public static bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
        {

            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between the values of " + min + " - " + max, "Entry Error");
                textBox.Clear();
                textBox.Focus();
                return false;
            } // if  
            return true;
            // else

        } // IsWithinRange Method takes an upper and lower parameter and checks these against the user's input
          // if the value is not within this range the user will be shown a MessageBox telling them the issue.

        public static bool IsValidData(TextBox textBox, string name)
        {
            if 
            (IsPresent(textBox, name) &&
            IsDecimal(textBox, name) &&
            IsWithinRange(textBox, name, 0, 150)){
                return true;
            }
            else
            {
                return false;
            }

        } // IsValidData is used to call upon all validation methods from above, this is called when the calculate button
          // is clicked, this ensures that all values are valid before carrying onto the calculation for the Future Value.

    }
}
