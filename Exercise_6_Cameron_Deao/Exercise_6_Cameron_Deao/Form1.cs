using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_6_Cameron_Deao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
         
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Establishing an instance of the dice class.
            Dice dice = new Dice();
            //Creating variables to determine the number of sides
            //on the dice and the number of rolls counter.
            int sides = 0;
            int counter = 0;
            //Creating the randomizer to determine the number of 
            //sides on the dice.
            Random setSides = new Random();
            //Setting the number of sides of the dice randomly between
            //4 and 20.
            sides = setSides.Next(4, 21);
            dice.setSides(sides);
            //Updating the label to showcase the number of sides
            //on the dice.
            sidesLabel.Text = "Number of sides on the dice: " + sides;
            //Creating the variables used to display the results.
            int firstDiceResult;
            int secondDiceResult;
            //The while loop iterates until the condition of both results
            //equals 1.
            while (true)
            {
                //Calling the function within dice to roll both dice.
                firstDiceResult = dice.rollDie();
                secondDiceResult = dice.rollDie2();
                //Incrementing the counter up to count the number of rolls.
                counter++;
                //Showcasing each roll of the dice within the console.
                Console.WriteLine(firstDiceResult + " " + secondDiceResult);
                //Updating the labels to display current rolls.
                diceLabel1.Text = firstDiceResult.ToString();
                diceLabel2.Text = secondDiceResult.ToString();
                diceLabel1.Update();
                diceLabel2.Update();
                //The while loop break condition to stop the rolls when
                //double 1's is achieved.
                if(firstDiceResult == 1 && secondDiceResult == 1)
                {
                    break;
                }
            }
            //Updating dice label to the final results.
            diceLabel1.Text = firstDiceResult.ToString();
            diceLabel2.Text = secondDiceResult.ToString();
            //Updating the counter label to the final results.
            counterLabel.Text = "It took " + counter.ToString() + " rolls to get snake eyes!";

            //Created the message box capability of displaying
            //the number of rolls taken to achieve snake eyes.
            //Left the code commented out to showcase that both will work in the program.
            //MessageBox.Show("It took " + counter.ToString() + " rolls to get snake eyes!");
        }
    }

    class Dice
    {
        //Randomizer used for the dice rolls.
        Random randomRoll = new Random();
        //Private int used to establish the number
        //of sides on the dice.
        private int sidesOfDice;
        //Seperate int results for dice 1 and dice 2.
        public int firstDiceResults = 0;
        public int secondDiceResults = 0;
        //Function used to set the number of sides on the dice.
        public void setSides(int sides)
        {
            sidesOfDice = sides;
        }
        //Function used to roll the first dice.
        public int rollDie()
        {  
            //Rolling the dice and returning the results.
            firstDiceResults = randomRoll.Next(1, sidesOfDice + 1);
            return firstDiceResults;
        }
        //Function used to roll the second dice.
        public int rollDie2()
        {
            //Rolling the dice and returning the results.
            secondDiceResults = randomRoll.Next(1, sidesOfDice - 1);
            return secondDiceResults;
        }
    }
}