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

        private void button1_Click(object sender, EventArgs e)
        {
            //Created a local instance of a movie from the MovieInventory class.
            MovieInventory movie = new MovieInventory();
            //Exception handling for user input.
            try
            {
                //Editing all variables of the movie instance from the 
                //user input in the program.
                movie.MovieTitle = movieTitleBox.Text;
                movie.Director = directorBox.Text;
                movie.Rating = ratingBox.Text;
                movie.RentalPrice = double.Parse(rentalPriceBox.Text);
                movie.Length = int.Parse(lengthBox.Text);
                movie.ReleaseYear = int.Parse(releaseYearBox.Text);
                //Making all of the text boxes non-interactable.
                movieTitleBox.ReadOnly = true;
                directorBox.ReadOnly = true;
                ratingBox.ReadOnly = true;
                rentalPriceBox.ReadOnly = true;
                lengthBox.ReadOnly = true;
                releaseYearBox.ReadOnly = true;
                //Setting the global variable to the local movie instance 
                //to allow editing of the values.
                storedMovie = movie;
                //Disabling the ability to add additional movies.
                createMovie.Visible = false;
                //Updating an additional label to showcase all the values
                //that were added from the text boxes and the create button.
                displayLabel.Text = "Created Movie!" + Environment.NewLine + "Title: " + movie.MovieTitle + Environment.NewLine + "Director: " + movie.Director + 
                    Environment.NewLine + "Rating: " + movie.Rating + Environment.NewLine + "Rental Price: " + movie.RentalPrice + Environment.NewLine + "Length: "
                    + movie.Length + Environment.NewLine + "Release Year: " + movie.ReleaseYear;
            }
            catch
            {
                MessageBox.Show("Please enter data in the correct format.");
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
            //Making all of the text boxes non-interactable.
            movieTitleBox.ReadOnly = true;
            directorBox.ReadOnly = true;
            ratingBox.ReadOnly = true;
            rentalPriceBox.ReadOnly = true;
            lengthBox.ReadOnly = true;
            releaseYearBox.ReadOnly = true;
            //Hiding the save button after use.
            saveButton.Visible = false;
            //Updating the additional label to showcase all the values
            //that were added from the text boxes and the save button.
            displayLabel.Text = "Edited Movie!" + Environment.NewLine + "Title: " + storedMovie.MovieTitle + Environment.NewLine + "Director: " + storedMovie.Director +
                    Environment.NewLine + "Rating: " + storedMovie.Rating + Environment.NewLine + "Rental Price: " + storedMovie.RentalPrice + Environment.NewLine + "Length: "
                    + storedMovie.Length + Environment.NewLine + "Release Year: " + storedMovie.ReleaseYear;
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

    public MovieInventory()
    {
        //Initializing all variables to dummy values.
        movieTitle = "";
        director = "";
        rating = "";
        rentalPrice = 1.0;
        length = 1234;
        releaseYear = 1994;
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
}