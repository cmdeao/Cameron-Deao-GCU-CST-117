using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_7_Cameron_Deao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

class MeasurementConversion
{
    //Method takes 2 ints and displays their sum.
    public void intSum(int firstNum, int secondNum)
    {
        //Adds the 2 int variables.
        int sum = firstNum + secondNum;
        Console.WriteLine("The sum of the 2 numbers is: " + sum);
    }

    //Method takes 5 doubles and returns their average.
    public double doubleAverage(double firstNum, double secondNum, double thirdNum, double fourthNum, double fifthNum)
    {
        //Calculating average.
        double average = firstNum + secondNum + thirdNum + fourthNum + fifthNum / 5;
        return average;
    }

    //Method returns the sum of 2 random int numbers.
    public int randomIntSum()
    {
        //Creating a new random.
        Random randomRoll = new Random();
        //Randoming 2 ints.
        int firstRoll = randomRoll.Next();
        int secondRoll = randomRoll.Next();
        //Adding the 2 random ints and returning the value.
        int randomSum = firstRoll + secondRoll;
        return randomSum;
    }

    //Methods takes 3 ints and returns if they are divisible by 3.
    public bool divisible(int firstNum, int secondNum, int thirdNum)
    {
        //Creating a return boolean.
        bool isDivisible = false;
        int total = firstNum + secondNum + thirdNum;
        //If-else statement checks if divisible by 3. 
        //Returns true if yes and false if no.
        if(total % 3 == 0)
        {
            isDivisible = true;
        }
        else
        {
            isDivisible = false;
        }
        return isDivisible;
    }

    //Method takes 2 stringss and displays the string with the fewest characters.
    public void shortestString(string firstString, string secondString)
    {
        //Putting each string into a char array.
        char[] firstWord = firstString.ToCharArray();
        char[] secondWord = secondString.ToCharArray();
        //Creating two counter variables.
        int firstCounter = 0;
        int secondCounter = 0;
        //Foreach loops iterate through each array an increments the appropriate counter.
        foreach(char ch in firstWord)
        {
            firstCounter++;
        }
        foreach(char ch in secondWord)
        {
            secondCounter++;
        }
        //If-else statement checks each counter and writes the shortest string based on 
        //which is shorter.
        if(firstCounter < secondCounter)
        {
            Console.WriteLine(firstString);
        }
        else
        {
            Console.WriteLine(secondString);
        }
    }

    //Method takes a double array and returns the largest value in the array.
    public double doubleArray(double[] values)
    {
        //Find the max value in the array and returns it.
        double maxValue = values.Max();
        return maxValue;
    }

    //Method generates an array of 50 random ints and returns the array.
    public int[] generateArray()
    {
        //Creating a new random.
        Random randomNumber = new Random();
        //Creating an array with a size of 50.
        int[] values = new int[50];
        //For loop iterates through the array and adds a random number with
        //each iteration.
        for(int i = 0; i < values.Length; i++)
        {
            values[i] = randomNumber.Next();
        }
        //Returning the array.
        return values;
    }

    //Method takes 2 booleans and checks if they have the same value and
    //returns the result.
    public bool sameValue(bool checkOne, bool checkTwo)
    {
        bool isSame;
        //Checks if the boolean values match.
        isSame = checkOne.Equals(checkTwo);
        //If-else statement sets a bool value to true or false
        //depending on the result of the previous check.
        if(isSame == true)
        {
            isSame = true;
        }
        else
        {
            isSame = false;
        }
        return isSame;
    }

    //Method takes an int and a double and returns their product.
    public double product(int firstValue, double secondValue)
    {
        //Calucating the product of the int and the double.
        double result = firstValue * secondValue;
        return result;
    }

    //Method takes a 2D array of ints and returns the average of the entries.
    public int averageEntries(int[,] array)
    {
        //Creating variables that will be used in the method.
        int finalResult = 0;
        int sum = 0;
        int counter = 0;
        //Creating the appropriate int variables and setting rowLength and columnLength
        //to a specific portion of the 2D array.
        int i, j, rowLength = array.GetLength(0), columnLength = array.GetLength(1);
        //Double for loop iterates through the array and gets the sum.
        for(j = 0; j < columnLength; j++)
        {
            for(i = 0; i < rowLength; i++)
            {
                sum = sum + array[i,j];
                counter++;
            }
        }
        //Dividing the sum by the counter.
        finalResult = sum / counter;
        //Returning the result.
        return finalResult;
    }
}