namespace Programming_Project_3_Cameron_Deao
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.fileContentsLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.lowerCaseBox = new System.Windows.Forms.TextBox();
            this.longestWordBox = new System.Windows.Forms.TextBox();
            this.longestWord = new System.Windows.Forms.Label();
            this.alphabeticalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vowelBox = new System.Windows.Forms.TextBox();
            this.firstAndLastBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileContentsLabel
            // 
            this.fileContentsLabel.AutoSize = true;
            this.fileContentsLabel.Location = new System.Drawing.Point(71, 47);
            this.fileContentsLabel.Name = "fileContentsLabel";
            this.fileContentsLabel.Size = new System.Drawing.Size(80, 13);
            this.fileContentsLabel.TabIndex = 5;
            this.fileContentsLabel.Text = "Contents of File";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(119, 325);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // lowerCaseBox
            // 
            this.lowerCaseBox.Location = new System.Drawing.Point(38, 63);
            this.lowerCaseBox.Multiline = true;
            this.lowerCaseBox.Name = "lowerCaseBox";
            this.lowerCaseBox.Size = new System.Drawing.Size(156, 256);
            this.lowerCaseBox.TabIndex = 14;
            // 
            // longestWordBox
            // 
            this.longestWordBox.Location = new System.Drawing.Point(200, 177);
            this.longestWordBox.Name = "longestWordBox";
            this.longestWordBox.Size = new System.Drawing.Size(273, 20);
            this.longestWordBox.TabIndex = 12;
            // 
            // longestWord
            // 
            this.longestWord.AutoSize = true;
            this.longestWord.Location = new System.Drawing.Point(197, 160);
            this.longestWord.Name = "longestWord";
            this.longestWord.Size = new System.Drawing.Size(74, 13);
            this.longestWord.TabIndex = 4;
            this.longestWord.Text = "Longest Word";
            // 
            // alphabeticalLabel
            // 
            this.alphabeticalLabel.AutoSize = true;
            this.alphabeticalLabel.Location = new System.Drawing.Point(197, 83);
            this.alphabeticalLabel.Name = "alphabeticalLabel";
            this.alphabeticalLabel.Size = new System.Drawing.Size(167, 13);
            this.alphabeticalLabel.TabIndex = 6;
            this.alphabeticalLabel.Text = "First and Last Word Alphabetically";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Word With The  Most Vowels";
            // 
            // vowelBox
            // 
            this.vowelBox.Location = new System.Drawing.Point(200, 260);
            this.vowelBox.Name = "vowelBox";
            this.vowelBox.Size = new System.Drawing.Size(273, 20);
            this.vowelBox.TabIndex = 11;
            // 
            // firstAndLastBox
            // 
            this.firstAndLastBox.Location = new System.Drawing.Point(200, 113);
            this.firstAndLastBox.Name = "firstAndLastBox";
            this.firstAndLastBox.Size = new System.Drawing.Size(273, 20);
            this.firstAndLastBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.lowerCaseBox);
            this.Controls.Add(this.firstAndLastBox);
            this.Controls.Add(this.longestWordBox);
            this.Controls.Add(this.vowelBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alphabeticalLabel);
            this.Controls.Add(this.fileContentsLabel);
            this.Controls.Add(this.longestWord);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label fileContentsLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox lowerCaseBox;
        private System.Windows.Forms.TextBox longestWordBox;
        private System.Windows.Forms.Label longestWord;
        private System.Windows.Forms.Label alphabeticalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vowelBox;
        private System.Windows.Forms.TextBox firstAndLastBox;
    }
}

