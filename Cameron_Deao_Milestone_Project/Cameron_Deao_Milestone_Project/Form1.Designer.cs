namespace Cameron_Deao_Milestone_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createMovie = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.editMovie = new System.Windows.Forms.Button();
            this.movieTitleBox = new System.Windows.Forms.TextBox();
            this.directorBox = new System.Windows.Forms.TextBox();
            this.ratingBox = new System.Windows.Forms.TextBox();
            this.rentalPriceBox = new System.Windows.Forms.TextBox();
            this.lengthBox = new System.Windows.Forms.TextBox();
            this.releaseYearBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.rentalLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.releaseYearLabel = new System.Windows.Forms.Label();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createMovie
            // 
            this.createMovie.Location = new System.Drawing.Point(21, 50);
            this.createMovie.Name = "createMovie";
            this.createMovie.Size = new System.Drawing.Size(121, 38);
            this.createMovie.TabIndex = 0;
            this.createMovie.Text = "Create Movie";
            this.createMovie.UseVisualStyleBackColor = true;
            this.createMovie.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(201, 53);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(62, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Movie Title:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(201, 79);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(79, 13);
            this.directorLabel.TabIndex = 2;
            this.directorLabel.Text = "Movie Director:";
            // 
            // editMovie
            // 
            this.editMovie.Location = new System.Drawing.Point(21, 94);
            this.editMovie.Name = "editMovie";
            this.editMovie.Size = new System.Drawing.Size(121, 38);
            this.editMovie.TabIndex = 3;
            this.editMovie.Text = "Edit Movie";
            this.editMovie.UseVisualStyleBackColor = true;
            this.editMovie.Click += new System.EventHandler(this.editMovie_Click);
            // 
            // movieTitleBox
            // 
            this.movieTitleBox.Location = new System.Drawing.Point(286, 50);
            this.movieTitleBox.Name = "movieTitleBox";
            this.movieTitleBox.Size = new System.Drawing.Size(100, 20);
            this.movieTitleBox.TabIndex = 4;
            // 
            // directorBox
            // 
            this.directorBox.Location = new System.Drawing.Point(286, 76);
            this.directorBox.Name = "directorBox";
            this.directorBox.Size = new System.Drawing.Size(100, 20);
            this.directorBox.TabIndex = 5;
            // 
            // ratingBox
            // 
            this.ratingBox.Location = new System.Drawing.Point(286, 102);
            this.ratingBox.Name = "ratingBox";
            this.ratingBox.Size = new System.Drawing.Size(100, 20);
            this.ratingBox.TabIndex = 6;
            // 
            // rentalPriceBox
            // 
            this.rentalPriceBox.Location = new System.Drawing.Point(286, 128);
            this.rentalPriceBox.Name = "rentalPriceBox";
            this.rentalPriceBox.Size = new System.Drawing.Size(100, 20);
            this.rentalPriceBox.TabIndex = 7;
            // 
            // lengthBox
            // 
            this.lengthBox.Location = new System.Drawing.Point(286, 154);
            this.lengthBox.Name = "lengthBox";
            this.lengthBox.Size = new System.Drawing.Size(100, 20);
            this.lengthBox.TabIndex = 8;
            // 
            // releaseYearBox
            // 
            this.releaseYearBox.Location = new System.Drawing.Point(286, 180);
            this.releaseYearBox.Name = "releaseYearBox";
            this.releaseYearBox.Size = new System.Drawing.Size(100, 20);
            this.releaseYearBox.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(21, 50);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 38);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(201, 107);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(73, 13);
            this.ratingLabel.TabIndex = 11;
            this.ratingLabel.Text = "Movie Rating:";
            // 
            // rentalLabel
            // 
            this.rentalLabel.AutoSize = true;
            this.rentalLabel.Location = new System.Drawing.Point(201, 131);
            this.rentalLabel.Name = "rentalLabel";
            this.rentalLabel.Size = new System.Drawing.Size(68, 13);
            this.rentalLabel.TabIndex = 12;
            this.rentalLabel.Text = "Rental Price:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(201, 157);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(75, 13);
            this.lengthLabel.TabIndex = 13;
            this.lengthLabel.Text = "Movie Length:";
            // 
            // releaseYearLabel
            // 
            this.releaseYearLabel.AutoSize = true;
            this.releaseYearLabel.Location = new System.Drawing.Point(201, 183);
            this.releaseYearLabel.Name = "releaseYearLabel";
            this.releaseYearLabel.Size = new System.Drawing.Size(74, 13);
            this.releaseYearLabel.TabIndex = 14;
            this.releaseYearLabel.Text = "Release Year:";
            // 
            // displayLabel
            // 
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(448, 50);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(193, 150);
            this.displayLabel.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 231);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.releaseYearLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.rentalLabel);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.releaseYearBox);
            this.Controls.Add(this.lengthBox);
            this.Controls.Add(this.rentalPriceBox);
            this.Controls.Add(this.ratingBox);
            this.Controls.Add(this.directorBox);
            this.Controls.Add(this.movieTitleBox);
            this.Controls.Add(this.editMovie);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.createMovie);
            this.Name = "Form1";
            this.Text = "Movie Inventory Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createMovie;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Button editMovie;
        private System.Windows.Forms.TextBox movieTitleBox;
        private System.Windows.Forms.TextBox directorBox;
        private System.Windows.Forms.TextBox ratingBox;
        private System.Windows.Forms.TextBox rentalPriceBox;
        private System.Windows.Forms.TextBox lengthBox;
        private System.Windows.Forms.TextBox releaseYearBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.Label rentalLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label releaseYearLabel;
        private System.Windows.Forms.Label displayLabel;
    }
}

