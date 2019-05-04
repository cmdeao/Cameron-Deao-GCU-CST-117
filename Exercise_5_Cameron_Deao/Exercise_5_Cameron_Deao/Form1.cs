using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_5_Cameron_Deao
{
    public partial class Pi : Form
    {
        //Global variables established to be used in the program.
        double overFour;
        int inputTerms;

        public Pi()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Setting all fields to correct values for the users to avoid 
            //adding onto an existing approximation.
            overFour = 0;
            double sign = 1;
            messageLabel.Text = "";
            resultsLabel.Text = "";
            //Exception handling to avoid incorrect data from being entered.
            try
            {
                inputTerms = int.Parse(termsInput.Text);
            }
            catch
            {
                MessageBox.Show("Please enter numeric values only.");
            }
            //The for loop creates an initialization expression and iterates through the loop
            //based on the test expression. After a single loop the update expression is 
            //called and increments the initialization expression up a single count.
            //When the initialization expression reaches the test expression total the 
            //for loop concludes.
            for (int term = 0; term < inputTerms; term++)
            {
                //Mathematical expression that occurs for each term that is passed 
                //into the for loop.
                overFour += sign / (term * 2 + 1);
                sign *= -1;
            }
            //Calculates the final value that will be displayed to the user.
            double pi = 4 * overFour;
            messageLabel.Text = "Approximate value of pi after " + inputTerms + " terms";
            resultsLabel.Text = "= " + pi.ToString();
        }
    }
}