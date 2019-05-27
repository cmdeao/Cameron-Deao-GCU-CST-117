//Cameron Deao
//CST-117
//Robert Loy
//5/26/2019

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cameron_Deao_Milestone_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Disabled visiblity for a button until required later in the program.
            saveButton.Visible = false;
        }
        //Created a global instance of a movie to be edited if desired. 
        public static int inventoryCount = 5;
        MovieInventory storedMovie = null;
        MovieInventory[] inventory = new MovieInventory[inventoryCount];
        public int counter = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //Exception handling for user input.
            try
            {
                //Checking if the max has been reached for inputting movies.
                if (counter < inventory.Length)
                {
                    MovieInventory movie = new MovieInventory();
                    //Editing all variables of the movie instance from the 
                    //user input in the program.
                    movie.MovieTitle = movieTitleBox.Text;
                    movie.Director = directorBox.Text;
                    movie.Rating = ratingBox.Text;
                    movie.RentalPrice = double.Parse(rentalPriceBox.Text);
                    movie.Length = int.Parse(lengthBox.Text);
                    movie.ReleaseYear = int.Parse(releaseYearBox.Text);
                    movie.InventoryCount = int.Parse(stockCount.Text);
                    //Setting the global variable to the local movie instance 
                    //to allow editing of the values.
                    storedMovie = movie;
                    //Disabling the ability to add additional movies.
                    //createMovie.Visible = false;
                    //Updating an additional label to showcase all the values
                    //that were added from the text boxes and the create button.
                    displayLabel.Text = "Created Movie!" + Environment.NewLine + "Title: " + movie.MovieTitle + Environment.NewLine + "Director: " + movie.Director +
                        Environment.NewLine + "Rating: " + movie.Rating + Environment.NewLine + "Rental Price: " + movie.RentalPrice + Environment.NewLine + "Length: "
                        + movie.Length + Environment.NewLine + "Release Year: " + movie.ReleaseYear;
                    inventory[counter] = movie;
                    //Incrementing the counter.
                    counter++;
                }
                //Breaks if the counter is met.
                else if (counter == inventory.Length)
                {
                    MessageBox.Show("No more films can be added.");
                }
            }
            catch
            {
                MessageBox.Show("Please input values in the correct format.");
            }
        }

        private void editMovie_Click(object sender, EventArgs e)
        {
            //Checks if the global variable is null and kicks
            //the user out if the variable is null.
            if(storedMovie == null)
            {
                MessageBox.Show("No movie exists within the inventory. Please create one.");
            }
            else
            {
                //Turning on the ability to edit all
                //of the text boxes for editing.
                movieTitleBox.ReadOnly = false;
                directorBox.ReadOnly = false;
                ratingBox.ReadOnly = false;
                rentalPriceBox.ReadOnly = false;
                lengthBox.ReadOnly = false;
                releaseYearBox.ReadOnly = false;
                //Setting the save button to visible for the user.
                saveButton.Visible = true;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Editing all variables of the movie instance from the 
            //user input in the program.
            storedMovie.MovieTitle = movieTitleBox.Text;
            storedMovie.Director = directorBox.Text;
            storedMovie.Rating = ratingBox.Text;
            storedMovie.RentalPrice = double.Parse(rentalPriceBox.Text);
            storedMovie.Length = int.Parse(lengthBox.Text);
            storedMovie.ReleaseYear = int.Parse(releaseYearBox.Text);
            //Hiding the save button after use.
            saveButton.Visible = false;
            //Updating the additional label to showcase all the values
            //that were added from the text boxes and the save button.
            displayLabel.Text = "Edited Movie!" + Environment.NewLine + "Title: " + storedMovie.MovieTitle + Environment.NewLine + "Director: " + storedMovie.Director +
                    Environment.NewLine + "Rating: " + storedMovie.Rating + Environment.NewLine + "Rental Price: " + storedMovie.RentalPrice + Environment.NewLine + "Length: "
                    + storedMovie.Length + Environment.NewLine + "Release Year: " + storedMovie.ReleaseYear;
        }

        //Enabling all the appropriate fields for restocking.
        private void restockButton_Click(object sender, EventArgs e)
        {
            movieNumberLabel.Visible = true;
            quantityLabel.Visible = true;
            restockMovieNumber.Visible = true;
            restockQuantityBox.Visible = true;
            restockConfirmButton.Visible = true;
        }

        //Restocking a movie based on user input.
        private void restockConfirmButton_Click(object sender, EventArgs e)
        {
            //Saving user input.
            int choiceIndex = int.Parse(restockMovieNumber.Text);
            int quanity = int.Parse(restockQuantityBox.Text);
            //Finding and setting array index based on the user input.
            inventory[choiceIndex].InventoryCount = quanity;
            movieNumberLabel.Visible = false;
            quantityLabel.Visible = false;
            restockMovieNumber.Visible = false;
            restockQuantityBox.Visible = false;
            restockConfirmButton.Visible = false;
            MessageBox.Show(inventory[choiceIndex].MovieTitle + " " + inventory[choiceIndex].InventoryCount);
        }

        //Displaying the entire inventory.
        private void displayButton_Click(object sender, EventArgs e)
        {
            //Resetting the text field.
            displayBox.ResetText();
            //Iterating through the array and displaying all values that are not null.
            for (int i = 0; i < inventory.Length; i++)
            {
                if (inventory[i] != null)
                {
                    displayBox.Text += "Title: " + inventory[i].MovieTitle.ToString() + " Director: " + inventory[i].Director.ToString() +
                        " Rating: " + inventory[i].Rating.ToString() + " Rental Price: " + inventory[i].RentalPrice.ToString() +
                        " Length: " + inventory[i].Length.ToString() + " Release Year: " + inventory[i].ReleaseYear.ToString();
                    displayBox.Text += Environment.NewLine;
                }
            }
        }

        //Searching the array based on string input.
        private void searchButton_Click(object sender, EventArgs e)
        {
            //Iterating through the array.
            int index = Array.FindIndex(inventory, (x) => (x.MovieTitle == searchBox.Text));
            //Setting a new object to the index.
            MovieInventory display = inventory[index];
            MessageBox.Show("MOVIE FOUND");
            //Displaying the result.
            displayBox.Text = "Title: " + display.MovieTitle + " Director: " + display.Director + " Rating: " + display.Rating +
                " Rental Price: " + display.RentalPrice.ToString() + " Length: " + display.Length.ToString() + " Release Year: " +
                display.ReleaseYear.ToString() + " Quantity: " + display.InventoryCount.ToString();
        }

        //Searching the array based on int input.
        private void quantitySearch_Click(object sender, EventArgs e)
        {
            //Iterating through the array.
            int index = Array.FindIndex(inventory, (x) => (x.InventoryCount == int.Parse(searchBox.Text)));
            //Setting a new object to the index.
            MovieInventory display = inventory[index];
            MessageBox.Show("MOVIE FOUND");
            //Displaying the result.
            displayBox.Text = "Title: " + display.MovieTitle + " Director: " + display.Director + " Rating: " + display.Rating +
                " Rental Price: " + display.RentalPrice.ToString() + " Length: " + display.Length.ToString() + " Release Year: " +
                display.ReleaseYear.ToString() + " Quantity: " + display.InventoryCount.ToString();
        }

        //Displaying the appropriate fields.
        private void deleteMovieButton_Click(object sender, EventArgs e)
        {
            deleteLabel.Visible = true;
            deleteConfirmButton.Visible = true;
            deleteTextBox.Visible = true;
        }

        //Taking user input to delete an item.
        private void deleteConfirmButton_Click(object sender, EventArgs e)
        {
            inventory = RemoveAt(inventory, int.Parse(deleteTextBox.Text));
            //Incrementing the global counter down.
            counter--;
            MessageBox.Show("Movie # " + int.Parse(deleteTextBox.Text) + " was deleted.");
            deleteLabel.Visible = false;
            deleteConfirmButton.Visible = false;
            deleteTextBox.Visible = false;
        }

        //Deleting a movie at the index from the user.
        private MovieInventory[] RemoveAt(MovieInventory[] inventory, int remove)
        {
            //Creating a new array with a smaller size than the previous one.
            MovieInventory[] newInventory = new MovieInventory[inventory.Length - 1];
            //Iterating through and populating the new array with the old data
            //except the index that was chosen.
            int i = 0;
            int j = 0;
            for (i = 0; i < inventory.Length; i++)
            {
                if (i != remove)
                {
                    newInventory[j] = inventory[i];
                    j++;
                }
            }
            //Returning the new array.
            return newInventory;
        }
    }
}

class MovieInventory
{
    //Creating all variables that will
    //be available within the object.
    private string movieTitle;
    private string director;
    private string rating;
    private double rentalPrice;
    private int length;
    private int releaseYear;
    private int inventoryCount;

    public MovieInventory()
    {
        //Initializing all variables to dummy values.
        movieTitle = "";
        director = "";
        rating = "";
        rentalPrice = 1.0;
        length = 1234;
        releaseYear = 1994;
        inventoryCount = 1;
    }

    //Created getters and setters for all of the 
    //values of a movie object.
    public string MovieTitle
    {
        get { return movieTitle; }
        set { movieTitle = value; }
    }
    public string Director
    {
        get { return director; }
        set { director = value; }
    }
    public string Rating
    {
        get { return rating; }
        set { rating = value; }
    }
    public double RentalPrice
    {
        get { return rentalPrice; }
        set { rentalPrice = value; }
    }
    public int Length
    {
        get { return length; }
        set { length = value; }
    }
    public int ReleaseYear
    {
        get { return releaseYear; }
        set { releaseYear = value; }
    }

    public int InventoryCount
    {
        get { return inventoryCount; }
        set { inventoryCount = value; }
    }
}