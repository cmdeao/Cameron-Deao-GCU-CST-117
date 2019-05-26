using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Programming_Project_4_Cameron_Deao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Determing the 2D array values.
        const int rows = 3;
        const int cols = 3;
        //Initializing the 2D array.
        int[,] board = new int[rows, cols];
        //Array to store the labels to be updated.
        Label[] labels = new Label[9];
        //Variables that will be used throughout the program.
        int index = 0;
        int EMPTY = 2;
        int rowChoice = 0;
        int colChoice = 0;
        int winner = 2;
        //Creating the random.
        Random boardRoll = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Adding all the labels into an array.
            labels[0] = piece1;
            labels[1] = piece2;
            labels[2] = piece3;
            labels[3] = piece4;
            labels[4] = piece5;
            labels[5] = piece6;
            labels[6] = piece7;
            labels[7] = piece8;
            labels[8] = piece9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Setting the index to zero for each game.
            index = 0;
            //Filling the array with dummy values.
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int x = 0; x < board.GetLength(1); x++)
                {
                    board[i, x] = EMPTY;
                }
            }
            //Determining which player will go first.
            int firstPlayer = boardRoll.Next(0, 2);
            //Bool to check if a winner has been found.
            bool foundWinner = false;
            //For loop used to populate the array.
            for (int i = firstPlayer; i < (board.GetLength(0) * board.GetLength(1)) + firstPlayer; i++)
            {
                //Determining which index position will be chosen.
                rowChoice = boardRoll.Next(0, 3);
                colChoice = boardRoll.Next(0, 3);
                //While loop to check if a dummy value is in the index.
                while (board[rowChoice, colChoice] != EMPTY)
                {
                    rowChoice = boardRoll.Next(0, 3);
                    colChoice = boardRoll.Next(0, 3);
                }
                //Setting the input with the use of a modulo.
                board[rowChoice, colChoice] = i % 2;
                //Checking if their is a winner.
                foundWinner = CheckAndSetWinner();
                //If winner is found the for loop breaks.
                if (foundWinner)
                {
                    break;
                }
            }
            //Outputting each value into the console.
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int x = 0; x < board.GetLength(1); x++)
                {
                    Console.WriteLine("INDEX VALUE: " + board[i,x].ToString());
                }
            }
            //Updating the labels based on the 2D index values.
            for(int i = 0; i < rows; i++)
            {
                for(int x = 0; x < cols; x++)
                {
                    if(board[i,x] == 0)
                    {
                        labels[index].Text = "O";
                    }
                    if (board[i, x] == 1)
                    {
                        labels[index].Text = "X";
                    }
                    else if (board[i, x] == 2)
                    {
                        labels[index].Text = "";
                    }
                    index += 1;
                }
            }
            //Updating the textbox based on the winner.
            if (foundWinner)
            {
                conditionTextBox.Text = "Winner is Team ";
                conditionTextBox.Text += winner == 0 ? "X!" : "O!";
            }
            else
            {
                conditionTextBox.Text = "Tie Game!";
            }
        }
        
        //Logic used to check win conditions.
        private bool CheckAndSetWinner()
        {
            bool foundWinner = false;
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == 0 && board[i, 1] == 0 && board[i, 2] == 0)
                {
                    winner = 1;
                    foundWinner = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == 0 && board[1, i] == 0 && board[2, i] == 0)
                {
                    winner = 1;
                    foundWinner = true;
                }
            }
            if (board[0, 0] == 0 && board[1, 1] == 0 && board[2, 2] == 0)
            {
                winner = 1;
                foundWinner = true;
            }
            if (board[0, 2] == 0 && board[1, 1] == 0 && board[2, 0] == 0)
            {
                winner = 1;
                foundWinner = true;
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == 1 && board[i, 1] == 1 && board[i, 2] == 1)
                {
                    winner = 0;
                    foundWinner = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == 1 && board[1, i] == 1 && board[2, i] == 1)
                {
                    winner = 0;
                    foundWinner = true;
                }
            }
            if (board[0, 0] == 1 && board[1, 1] == 1 && board[2, 2] == 1)
            {
                winner = 0;
                foundWinner = true;
            }
            if (board[0, 2] == 1 && board[1, 1] == 1 && board[2, 0] == 1)
            {
                winner = 0;
                foundWinner = true;
            }
            //Returns a bool value if winner is found.
            return foundWinner;
        }
        //Close the application.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
