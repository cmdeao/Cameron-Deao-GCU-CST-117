using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingExercise2_Cameron_Deao
{
    public partial class Form1 : Form
    {
        public int currency;
        public bool dollarSelected = false;
        public bool vanSelected = false;
        string housingChoice;

        public Form1()
        {
            InitializeComponent();
        }

        private void dollarButton_CheckedChanged(object sender, EventArgs e)
        {
            if (dollarButton.Checked)
            {
                dollarSelected = true;
            }
        }

        private void euroButton_CheckedChanged(object sender, EventArgs e)
        {
            if(euroButton.Checked)
            {
                dollarSelected = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (housingList.SelectedIndex != -1)
            {
                housingChoice = housingList.SelectedItem.ToString();

                switch (housingChoice)
                {
                    case "Apartment":
                        vanSelected = false;
                        if (dollarSelected == true)
                        {
                            currency = 1405;
                            dollarLabel.Text = currency.ToString();
                            euroLabel.Text = "";
                        }
                        if (dollarSelected == false)
                        {
                            currency = 2555;
                            euroLabel.Text = currency.ToString();
                            dollarLabel.Text = "";
                        }
                        break;
                    case "House":
                        vanSelected = false;
                        if (dollarSelected == true)
                        {
                            currency = 188900;
                            dollarLabel.Text = currency.ToString();
                            euroLabel.Text = "";
                        }
                        if (dollarSelected == false)
                        {
                            currency = 106000;
                            euroLabel.Text = currency.ToString();
                            dollarLabel.Text = "";
                        }
                        break;
                    case "Van Down By The River":
                        dollarLabel.AutoSize = true;
                        euroLabel.AutoSize = true;
                        nameLabel.AutoSize = true;
                        dateLabel.AutoSize = true;
                        vanSelected = true;
                        dollarLabel.Text = "My name is Matt Foley";
                        euroLabel.Text = "I am a Motivational Speaker";
                        nameLabel.Text = "And I live in a van";
                        dateLabel.Text = "down by the river!";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Select a housing option");
            }

            if (nameBox.Checked && vanSelected == false)
            {
                nameLabel.Text = housingChoice.ToString();
            }

            if(dateBox.Checked && vanSelected == false)
            {
                dateLabel.Text = DateTime.Now.ToShortDateString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}