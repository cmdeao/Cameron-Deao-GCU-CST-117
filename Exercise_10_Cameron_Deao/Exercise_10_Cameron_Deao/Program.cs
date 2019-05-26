using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exercise_10_Cameron_Deao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable used to count the number of appropriate characters.
            int counter = 0;
            //Exception handling.
            try
            {
                //Reads in a specified text file from the debug folder.
                StreamReader sReader = new StreamReader("Example.txt");
                //Inputting the text file into a string.
                string inputString = sReader.ReadToEnd();
                //Displaying the text file string.
                Console.WriteLine(inputString + " ");
                //Removing punctuation from the string. 
                string finalString = Regex.Replace(inputString, @"[^\w\s]", "");
                //Splitting each word into the array.
                string[] fileWords = finalString.Split(new[] { " " }, StringSplitOptions.None);
                //For-each loop iterates through the array and checks each ending character.
                foreach (string str in fileWords)
                {
                    //Temp string.
                    string temp = str;
                    //Removes final character from each string.
                    string finalChar = str.Substring(temp.Length - 1, 1);
                    //Checking the final character against the specified characters to count.
                    if(finalChar == "T" || finalChar == "t" || finalChar == "e" || finalChar == "E")
                    {
                        //Incrementing the counter up.
                        counter++;
                    }
                }
                //Displaying the final result.
                Console.WriteLine("There are " + counter + " words that end in t or e.");
                Console.WriteLine("Press any key to continue...");
                //Pausing the console from closing.
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Please input a text file into the debug folder.");
            }
        }
    }
}
