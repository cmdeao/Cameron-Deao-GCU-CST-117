using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cameron_Deao_Excercise_3
{
    public partial class Form1 : Form
    {
        decimal pounds;
        decimal kilograms;
        double conversion = 0.45359237; //Variable used to convert weight values.
        int threeDecimalFormat = 1000; //Variable used to round output to three decimal places.

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exception handling to avoid an invalid data format from being entered.
            try
            {
                //Receiving user input when button is pressed. 
                pounds = decimal.Parse(inputBox.Text);
                //Converting user input to the appropriate value.
                kilograms = pounds * (decimal)conversion;
                //Formats the output to three decimal places.
                kilograms = Math.Truncate(kilograms * threeDecimalFormat) / threeDecimalFormat;
                pounds = Math.Truncate(pounds * threeDecimalFormat) / threeDecimalFormat;
                //Updating both text labels based on user selection and input.
                kgLabel.Text = kilograms.ToString();
                labelPound.Text = pounds.ToString();
            }
            catch
            {
                //Popup box will display with an error message.
                MessageBox.Show("Invalid format. Please enter data in numerical format.");
            }
        }

        //Button used to clear the data from all fields of the program.
        private void clearButton_Click(object sender, EventArgs e)
        {
            inputBox.Text = "";
            kgLabel.Text = "";
            labelPound.Text = "";
        }

        private void kgButton_Click(object sender, EventArgs e)
        {
            //Exception handling to avoid an invalid data format from being entered.
            try
            {
                //Receiving user input when button is pressed. 
                kilograms = decimal.Parse(inputBox.Text);
                //Converting user input to the appropriate value.
                pounds = kilograms / (decimal)conversion;
                //Formats the output to three decimal places.
                pounds = Math.Truncate(pounds * threeDecimalFormat) / threeDecimalFormat;
                kilograms = Math.Truncate(kilograms * threeDecimalFormat) / threeDecimalFormat;
                //Updating both text labels based on user selection and input.
                kgLabel.Text = kilograms.ToString();
                labelPound.Text = pounds.ToString();
            }
            catch
            {
                //Popup box will display with an error message.
                MessageBox.Show("Invalid format. Please enter data in numerical format.");
            }
        }

        //Button to close the program.
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
