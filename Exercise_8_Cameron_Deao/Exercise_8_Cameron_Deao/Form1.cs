using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_8_Cameron_Deao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Setting the results box to read only.
            resultsBox.ReadOnly = true;
        }
        //Creating a new instance of the FatAndCarbohyrdates class.
        FatAndCarbohydrates conversion = new FatAndCarbohydrates();

        //Buttons that will be used in the program.
        private void fatGramsButton_Click(object sender, EventArgs e)
        {
            //Exception handling from user input.
            try
            {
                int fatGrams = int.Parse(fatGramsBox.Text);
                //Updating the results box based off of the user input.
                //Passing the user input value into the method and displaying
                //the returned result.
                resultsBox.Text = conversion.FatCalories(fatGrams).ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a numerical value in the appropriate field.");
            }
        }
        private void carbGramsButton_Click(object sender, EventArgs e)
        {
            //Exception handling from user input.
            try
            {
                int carbGrams = int.Parse(carbsGramsBox.Text);
                //Updating the results box based off of the user input.
                //Passing the user input value into the method and displaying
                //the returned result.
                resultsBox.Text = conversion.CarbCalories(carbGrams).ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a numerical value in the appropriate field.");
            }
        }
    }
}

//New class that was created to convert the data.
class FatAndCarbohydrates
{
    //Function takes an int and returns an int.
    public int FatCalories(int fatGrams)
    {
        //Conversion formula.
        int result = fatGrams * 9;
        //Returing the result.
        return result;
    }

    //Function takes an int and returns an int.
    public int CarbCalories(int carbGrams)
    {
        //Conversion formula.
        int result = carbGrams * 4;
        //Returning result.
        return result;
    }
}

