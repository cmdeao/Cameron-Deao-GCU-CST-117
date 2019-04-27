using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondsConversionTool
{
    public partial class Form1 : Form
    {
        double seconds;
        double minute = 60;
        double hour = 3600;
        double day = 86400;
        double display;
        public Form1()
        {
            InitializeComponent();
        }

        private void secondsBox_TextChanged(object sender, EventArgs e)
        {
            //Exception handling to account for correct input of data.
            try
            {
                seconds = double.Parse(secondsBox.Text);
            }
            catch
            {
                MessageBox.Show("Incorrect format. Please enter seconds in a numerical format.");
            }
        }

        //The "seconds" variable is used for the user input and the "display" variable will be used
        //to display the conversion that occurred based on the number input by the user.
        private void conversionButton_Click(object sender, EventArgs e)
        {
            //Conversion of seconds to minutes.
            if (seconds >= minute)
            {
                display = seconds / minute;
                displayLabel.Text = "Seconds converted to number of minutes: " + display.ToString();
            }
            //Conversion of seconds to hours.
            if (seconds >= hour)
            {
                display = seconds / hour;
                displayLabel.Text = "Seconds converted to number of hours: " + display.ToString();
            }
            //Conversion of seconds to days.
            if (seconds >= day)
            {
                display = seconds / day;
                displayLabel.Text = "Seconds converted to number of days: " + display.ToString();
            }
        }
    }
}