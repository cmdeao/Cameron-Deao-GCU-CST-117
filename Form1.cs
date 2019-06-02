//Cameron Deao
//CST-117
//Robert Loy
//6/1/2019

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
        MovieInventory storedMovie = null;
        //Created a list to store the movies within the inventory.
        List<MovieInventory> listInventory = new List<MovieInventory>();
        private void button1_Click(object sender, EventArgs e)
        {
            //Exception handling for user input.
            try
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
                //Updating an additional label to showcase all the values
                //that were added from the text boxes and the create button.
                displayLabel.Text = "Created Movie!" + Environment.NewLine + "Title: " + movie.MovieTitle + Environment.NewLine + "Director: " + movie.Director +
                    Environment.NewLine + "Rating: " + movie.Rating + Environment.NewLine + "Rental Price: " + movie.RentalPrice + Environment.NewLine + "Length: "
                    + movie.Length + Environment.NewLine + "Release Year: " + movie.ReleaseYear;
                listInventory.Add(movie);
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
            //Finding and setting the list index based on the user input.
            listInventory[choiceIndex].InventoryCount = quanity;
            movieNumberLabel.Visible = false;
            quantityLabel.Visible = false;
            restockMovieNumber.Visible = false;
            restockQuantityBox.Visible = false;
            restockConfirmButton.Visible = false;
            //Displaying a message showcasing the movie selected with a new inventory count.
            MessageBox.Show(listInventory[choiceIndex].MovieTitle + " " + listInventory[choiceIndex].InventoryCount);
        }

        //Displaying the entire inventory.
        private void displayButton_Click(object sender, EventArgs e)
        {
            //Resetting the text field.
            displayBox.ResetText();
            //Iterating through the list and displaying all values.
            for(int i = 0; i < listInventory.Count; i++)
            {
                displayBox.Text += "Title: " + listInventory[i].MovieTitle.ToString() + " Director: " + listInventory[i].Director.ToString() +
                        " Rating: " + listInventory[i].Rating.ToString() + " Rental Price: " + listInventory[i].RentalPrice.ToString() +
                        " Length: " + listInventory[i].Length.ToString() + " Release Year: " + listInventory[i].ReleaseYear.ToString() + " Quantity: " +
                        listInventory[i].InventoryCount.ToString();
                    displayBox.Text += Environment.NewLine;
            }
        }

        //Searching the list based on string input.
        private void searchButton_Click(object sender, EventArgs e)
        {
            //Creating a new instance of MovieInventory.
            MovieInventory searchedMovie = new MovieInventory();
            //Bool to check if search was successful.
            bool movieFound = false;
            //Iterating through the list with a for-each loop.
            foreach(MovieInventory mi in listInventory)
            {
                //Checking if an iteration matches the text input
                //by the user.
                if(mi.MovieTitle == searchBox.Text)
                {
                    MessageBox.Show("MOVIE FOUND");
                    movieFound = true;
                    searchedMovie = mi;
                    displayBox.Text = "Title: " + searchedMovie.MovieTitle + " Director: " + searchedMovie.Director + " Rating: " + searchedMovie.Rating +
                    " Rental Price: " + searchedMovie.RentalPrice.ToString() + " Length: " + searchedMovie.Length.ToString() + " Release Year: " +
                    searchedMovie.ReleaseYear.ToString() + " Quantity: " + searchedMovie.InventoryCount.ToString();
                }
            }
            //Displaying a message if no match was found.
            if(movieFound == false)
            {
                MessageBox.Show("No movie was found.");
            }
        }

        //Searching the list based on int input.
        private void quantitySearch_Click(object sender, EventArgs e)
        {
            //Created a new instance of MovieInventory.
            MovieInventory searchedMovie = new MovieInventory();
            //Bool to check if search was successful.
            bool movieFound = false;
            //Iterating through the list with a for-each loop.
            foreach(MovieInventory mi in listInventory)
            {
                //Checking if an iteration matches the int value 
                //input by the user.
                if (mi.InventoryCount == int.Parse(searchBox.Text))
                {
                    MessageBox.Show("MOVIE FOUND");
                    movieFound = true;
                    searchedMovie = mi;
                    displayBox.Text = "Title: " + searchedMovie.MovieTitle + " Director: " + searchedMovie.Director + " Rating: " + searchedMovie.Rating +
                   " Rental Price: " + searchedMovie.RentalPrice.ToString() + " Length: " + searchedMovie.Length.ToString() + " Release Year: " +
                   searchedMovie.ReleaseYear.ToString() + " Quantity: " + searchedMovie.InventoryCount.ToString();
                }
            }
            //Displaying a message if no match was found.
            if (movieFound == false)
            {
                MessageBox.Show("No movie was found.");
            }
        }

        //Displaying the appropriate fields.
        private void deleteMovieButton_Click(object sender, EventArgs e)
        {
            deleteLabel.Visible = true;
            deleteConfirmButton.Visible = true;
            deleteTextBox.Visible = true;
            cancelDelete.Visible = true;
        }

        //Taking user input to delete an item.
        private void deleteConfirmButton_Click(object sender, EventArgs e)
        {
            //Exception handling that checks if the value input exists
            //and can be deleted.
            try
            {
                listInventory.RemoveAt(int.Parse(deleteTextBox.Text));
                MessageBox.Show("Movie # " + int.Parse(deleteTextBox.Text) + " was deleted.");
                deleteLabel.Visible = false;
                deleteConfirmButton.Visible = false;
                deleteTextBox.Visible = false;
                cancelDelete.Visible = false;
            }
            catch
            {
                MessageBox.Show("No value was input to delete.");
            }
        }

        //Added functionality to cancel out of deleting a movie product.
        private void cancelDelete_Click(object sender, EventArgs e)
        {
            deleteLabel.Visible = false;
            deleteConfirmButton.Visible = false;
            deleteTextBox.Visible = false;
            cancelDelete.Visible = false;
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