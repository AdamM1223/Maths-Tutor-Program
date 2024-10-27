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
    public partial class frmPast : Form
    {
        public frmPast()
        {
            InitializeComponent();
        }


        private void frmPast_Load(object sender, EventArgs e)
        {

        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            /* The following IF statement is used to ensure there is at least 1 stored Area Result before the code
             * can change the label that is displayed to the user. If there is not at least 1 result in the list 
             * the label will be kept the same, displaying as N/A */
            if (frmAQ1.results.Count > 0)
            {
                lblAreaResults.Text = "Your past Area Results (out of 5) are: ";
                /* For loop is used to iterate through the number of stored area results, adding the results to a label which will display
                 * the results to the user. This code also utilises a number already existing in the list to check which result is the last one in the list.
                 * This is used for presentation purposes, deciding which punctuation to use after the current result. */
                for (int i = 0; i < frmAQ1.results.Count; i++)
                {
                    lblAreaResults.Text += frmAQ1.results[i];
                    try
                    {
                        if (frmAQ1.results[i + 1] != -1)
                        {
                            lblAreaResults.Text += ", ";
                        }
                        else
                        {
                            lblAreaResults.Text += ".";
                        }

                    }
                    catch (Exception E)
                    {

                    }
                }
            }
            /* The following IF statement is used to ensure there is at least 1 stored Volume Result before the code
             * can change the label that is displayed to the user. If there is not at least 1 result in the list 
             * the label will be kept the same, displaying as N/A */
            if (frmVQ1.volumeResults.Count > 0)
            {
                lblVolumeResults.Text = "Your past Volume Results (out of 5) are: ";
                /* For loop is used to iterate through the number of stored volume results, adding the results to a label which will display
                 * the results to the user. This code also utilises a number already existing in the list to check which result is the last one in the list.
                 * This is used for presentation purposes, deciding which punctuation to use after the current result. */
                for (int i = 0; i < frmVQ1.volumeResults.Count; i++)
                {
                    lblVolumeResults.Text += frmVQ1.volumeResults[i];
                    try
                    {
                        if (frmVQ1.volumeResults[i + 1] != -1)
                        {
                            lblVolumeResults.Text += ", ";
                        }
                        else
                        {
                            lblVolumeResults.Text += ".";
                        }

                    }
                    catch (Exception E)
                    {

                    }
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            // This code closes the current Form
        }
    }
}
