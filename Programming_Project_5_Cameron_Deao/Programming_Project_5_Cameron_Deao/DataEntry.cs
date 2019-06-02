using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Project_5_Cameron_Deao
{
    public partial class DataEntry : Form
    {
        public DataEntry()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Iterating through and adding years into the combobox.
            //Setting the total number of years to the past 100 years.
            int startingYear = 1919;
            for(int i = 0; i < 101; i++)
            {
                birthYearBox.Items.Add(startingYear);
                startingYear++;
            }

            //Adding all the months into a combobox.
            monthDropDown.Items.Add("January");
            monthDropDown.Items.Add("February");
            monthDropDown.Items.Add("March");
            monthDropDown.Items.Add("April");
            monthDropDown.Items.Add("May");
            monthDropDown.Items.Add("June");
            monthDropDown.Items.Add("July");
            monthDropDown.Items.Add("August");
            monthDropDown.Items.Add("September");
            monthDropDown.Items.Add("October");
            monthDropDown.Items.Add("November");
            monthDropDown.Items.Add("December");

            //Adding all the color choices into a combobox.
            colorComboBox.Items.Add("Green");
            colorComboBox.Items.Add("Yellow");
            colorComboBox.Items.Add("Orange");
            colorComboBox.Items.Add("Red");
            colorComboBox.Items.Add("Purple");
            colorComboBox.Items.Add("Blue");
        }

        private void monthDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Setting the days combobox based on which month was chosen.
            Object selectedMonth = monthDropDown.SelectedItem;
            if(selectedMonth.ToString() == "January" || selectedMonth.ToString() == "March" || selectedMonth.ToString() == "May" ||
                selectedMonth.ToString() == "July" || selectedMonth.ToString() == "August" || selectedMonth.ToString() == "October" ||
                selectedMonth.ToString() == "December")
            {
                birthDayComboBox.Items.Clear();
                for (int i = 1; i < 32; i++)
                {
                    birthDayComboBox.Items.Add(i);
                }
            }
            if(selectedMonth.ToString() == "April" || selectedMonth.ToString() == "June" || selectedMonth.ToString() == "September" ||
                selectedMonth.ToString() == "November")
            {
                birthDayComboBox.Items.Clear();
                for (int i = 1; i < 31; i++)
                {
                    birthDayComboBox.Items.Add(i);
                }
            }
            else if(selectedMonth.ToString() == "February")
            {
                birthDayComboBox.Items.Clear();
                for (int i = 1; i < 29; i++)
                {
                    birthDayComboBox.Items.Add(i);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Variables used to perform math to establish lucky number.
            int luckyNumber = 0;
            int masterValue = 0;
            int subValue1 = 0;
            int subValue2 = 0;

            int year = (int)birthYearBox.SelectedItem;
            //Splitting the year choice into 4 individual variables to use.
            byte[] yearArray = year.ToString().ToCharArray().Select(c => byte.Parse(c.ToString())).ToArray();
            int year1 = yearArray[0];
            int year2 = yearArray[1];
            int year3 = yearArray[2];
            int year4 = yearArray[3];
            int yearSum = 0;

            int month = monthDropDown.SelectedIndex + 1;
            int monthNum1 = 0;
            int monthNum2 = 0;
            int monthSum = 0;

            int day = birthDayComboBox.SelectedIndex + 1;
            int day1 = 0;
            int day2 = 0;
            int daySum = 0;

            //Splitting the month into two separate variables.
            byte[] monthArray = month.ToString().ToCharArray().Select(c => byte.Parse(c.ToString())).ToArray();
            //Checking if the length is greater than one.
            if (monthArray.Length > 1)
            {
                monthNum1 = monthArray[0];
                monthNum2 = monthArray[1];
            }
            else
            {
                monthNum1 = monthArray[0];
            }
            month = monthNum1 + monthNum2;

            //Spliitng the day into two separate variables.
            byte[] dayArray = day.ToString().ToCharArray().Select(c => byte.Parse(c.ToString())).ToArray();
            //Checking if the length is greater than one.
            if(dayArray.Length > 1)
            {
                day1 = dayArray[0];
                day2 = dayArray[1];
            }
            else
            {
                day1 = dayArray[0];
            }

            //Establishing the lucky number based on selections from the user.
            monthSum = monthNum1 + monthNum2;
            daySum = day1 + day2;
            yearSum = year1 + year2 + year3 + year4;
            byte[] yearValue = yearSum.ToString().ToCharArray().Select(c => byte.Parse(c.ToString())).ToArray();
            year1 = yearValue[0];
            year2 = yearValue[1];
            yearSum = year1 + year2;
            masterValue = yearSum + monthSum + daySum;
            byte[] master = masterValue.ToString().ToCharArray().Select(c => byte.Parse(c.ToString())).ToArray();
            subValue1 = master[0];
            if (master.Length > 1)
            {
                subValue2 = master[1];
            }
            int selectedColorIndex = colorComboBox.SelectedIndex + 1;
            luckyNumber = subValue1 + subValue2 + selectedColorIndex;

            //Getting access to the second form.
            LuckyNumberForm luckyForm = new LuckyNumberForm();

            //Updating the label within the second form to showcase the lucky number.
            luckyForm.numberLabel.Text = luckyNumber.ToString();
            //Setting the backcolor on the label based on the user selection.
            if(selectedColorIndex == 1)
            {
                luckyForm.numberLabel.BackColor = Color.Green;
            }
            if(selectedColorIndex == 2)
            {
                luckyForm.numberLabel.BackColor = Color.Yellow;
            }
            if (selectedColorIndex == 3)
            {
                luckyForm.numberLabel.BackColor = Color.Orange;
            }
            if (selectedColorIndex == 4)
            {
                luckyForm.numberLabel.BackColor = Color.Red;
            }
            if (selectedColorIndex == 5)
            {
                luckyForm.numberLabel.BackColor = Color.Purple;
            }
            if (selectedColorIndex == 6)
            {
                luckyForm.numberLabel.BackColor = Color.Blue;
            }
            //Showcasing the second form.
            luckyForm.ShowDialog();
        }
    }
}