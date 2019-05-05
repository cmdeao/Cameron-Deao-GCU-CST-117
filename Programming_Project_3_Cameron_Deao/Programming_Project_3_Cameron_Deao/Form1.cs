using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Programming_Project_3_Cameron_Deao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Using the OpenFileDialog to allow the user to browse for a file.
            OpenFileDialog dlg = new OpenFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                //Reads the contents of the file.
                StreamReader reader = new StreamReader(dlg.FileName, Encoding.Default);
                string readingString = reader.ReadToEnd();
                //Converting everything read into lowercase.
                string lowerString = readingString.ToLower();
                lowerCaseBox.Text = lowerString.ToString();

                //Creating an array to split each string within the file.
                string[] words = readingString.Split(new[] { " " }, StringSplitOptions.None);
                //Variables are created that will be used to complete the tasks for the assignment.
                string word = null;
                string vowelWord = null;
                string firstWord = null;
                string lastWord = null;
                int maxVowels = 0;
                int counter = 0;
                //Iterates through the array to find the longest word and sets a string variable to
                //the longest word found based on the counter.
                foreach(String str in words)
                {
                    if (str.Length > counter)
                    {
                        word = str;
                        counter = str.Length;
                    }
                }
                //Iterates through the array to find the word with the most vowels.
                foreach(String s in words)
                {
                    int vowelCounter = 0;
                    word = word.ToLower();
                    //A for loop checks each index of a word against all the vowels. If one is found 
                    //the counter iterates up.
                    for(int i = 0; i < word.Length; i++)
                    {
                        if(word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                        {
                            vowelCounter++;
                        }
                    }
                    //When a new max vowel string has been found the max int variable is set to the correct
                    //amount and a string variable is set to the word that contained the most vowels.
                    if(vowelCounter > maxVowels)
                    {
                        maxVowels = vowelCounter;
                        vowelWord = word;
                    }
                }
                //Sorts the entire string array into alphabetical order for use.
                var sortedWords = from w in words orderby w select w;
                //With each string being stored at an individual index of the array the two strings variables are assigned
                //to the first and last index of the array.
                firstWord = sortedWords.First();
                lastWord = sortedWords.Last();
                //Outputting statistics into the windows form application.
                firstAndLastBox.Text = firstWord.ToString() + " " + lastWord.ToString();
                vowelBox.Text = vowelWord.ToString() + " Total Vowels: " + maxVowels.ToString();
                longestWordBox.Text = vowelWord.ToString();
                //Closing the reader.
                reader.Close();
            }
            //Created a StreamWriter to output the statistics into a file.
            StreamWriter outputFile;
            //Creating the text file to store the data.
            outputFile = File.CreateText("Statistics.txt");
            //Outputting each statistic into the file.
            outputFile.WriteLine("Words in lowercase: " + lowerCaseBox.Text);
            outputFile.WriteLine("First and last word alphabetically: " + firstAndLastBox.Text);
            outputFile.WriteLine("Longest word: " + longestWordBox.Text);
            outputFile.WriteLine("Word with most vowels: " + vowelBox.Text);
            //Closing the output file.
            outputFile.Close();
            //Displosing of the diaglog.
            dlg.Dispose();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}