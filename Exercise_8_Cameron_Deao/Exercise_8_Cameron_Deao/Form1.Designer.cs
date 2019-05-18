namespace Exercise_8_Cameron_Deao
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
            this.fatGramsButton = new System.Windows.Forms.Button();
            this.fatGramsBox = new System.Windows.Forms.TextBox();
            this.carbsGramsBox = new System.Windows.Forms.TextBox();
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.carbGramsButton = new System.Windows.Forms.Button();
            this.fatLabel = new System.Windows.Forms.Label();
            this.carbsLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fatGramsButton
            // 
            this.fatGramsButton.Location = new System.Drawing.Point(44, 197);
            this.fatGramsButton.Name = "fatGramsButton";
            this.fatGramsButton.Size = new System.Drawing.Size(114, 23);
            this.fatGramsButton.TabIndex = 0;
            this.fatGramsButton.Text = "Calories from Fat";
            this.fatGramsButton.UseVisualStyleBackColor = true;
            this.fatGramsButton.Click += new System.EventHandler(this.fatGramsButton_Click);
            // 
            // fatGramsBox
            // 
            this.fatGramsBox.Location = new System.Drawing.Point(178, 40);
            this.fatGramsBox.Name = "fatGramsBox";
            this.fatGramsBox.Size = new System.Drawing.Size(100, 20);
            this.fatGramsBox.TabIndex = 1;
            // 
            // carbsGramsBox
            // 
            this.carbsGramsBox.Location = new System.Drawing.Point(178, 95);
            this.carbsGramsBox.Name = "carbsGramsBox";
            this.carbsGramsBox.Size = new System.Drawing.Size(100, 20);
            this.carbsGramsBox.TabIndex = 2;
            // 
            // resultsBox
            // 
            this.resultsBox.Location = new System.Drawing.Point(178, 153);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(100, 20);
            this.resultsBox.TabIndex = 3;
            // 
            // carbGramsButton
            // 
            this.carbGramsButton.Location = new System.Drawing.Point(164, 197);
            this.carbGramsButton.Name = "carbGramsButton";
            this.carbGramsButton.Size = new System.Drawing.Size(114, 23);
            this.carbGramsButton.TabIndex = 4;
            this.carbGramsButton.Text = "Calories from Carbs";
            this.carbGramsButton.UseVisualStyleBackColor = true;
            this.carbGramsButton.Click += new System.EventHandler(this.carbGramsButton_Click);
            // 
            // fatLabel
            // 
            this.fatLabel.AutoSize = true;
            this.fatLabel.Location = new System.Drawing.Point(27, 43);
            this.fatLabel.Name = "fatLabel";
            this.fatLabel.Size = new System.Drawing.Size(136, 13);
            this.fatLabel.TabIndex = 5;
            this.fatLabel.Text = "Enter number of Fat Grams:";
            // 
            // carbsLabel
            // 
            this.carbsLabel.AutoSize = true;
            this.carbsLabel.Location = new System.Drawing.Point(27, 98);
            this.carbsLabel.Name = "carbsLabel";
            this.carbsLabel.Size = new System.Drawing.Size(148, 13);
            this.carbsLabel.TabIndex = 6;
            this.carbsLabel.Text = "Enter number of Carbs Grams:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(27, 156);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(45, 13);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "Results:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 267);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.carbsLabel);
            this.Controls.Add(this.fatLabel);
            this.Controls.Add(this.carbGramsButton);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.carbsGramsBox);
            this.Controls.Add(this.fatGramsBox);
            this.Controls.Add(this.fatGramsButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fatGramsButton;
        private System.Windows.Forms.TextBox fatGramsBox;
        private System.Windows.Forms.TextBox carbsGramsBox;
        private System.Windows.Forms.TextBox resultsBox;
        private System.Windows.Forms.Button carbGramsButton;
        private System.Windows.Forms.Label fatLabel;
        private System.Windows.Forms.Label carbsLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

