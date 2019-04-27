namespace ProgrammingExercise2_Cameron_Deao
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
            this.nameBox = new System.Windows.Forms.CheckBox();
            this.housingList = new System.Windows.Forms.ListBox();
            this.dollarButton = new System.Windows.Forms.RadioButton();
            this.euroButton = new System.Windows.Forms.RadioButton();
            this.dateBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dollarLabel = new System.Windows.Forms.Label();
            this.euroLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Location = new System.Drawing.Point(12, 312);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(89, 17);
            this.nameBox.TabIndex = 1;
            this.nameBox.Text = "Show Choice";
            this.nameBox.UseVisualStyleBackColor = true;
            // 
            // housingList
            // 
            this.housingList.FormattingEnabled = true;
            this.housingList.Items.AddRange(new object[] {
            "Apartment",
            "House",
            "Van Down By The River"});
            this.housingList.Location = new System.Drawing.Point(12, 128);
            this.housingList.Name = "housingList";
            this.housingList.Size = new System.Drawing.Size(129, 95);
            this.housingList.TabIndex = 2;
            // 
            // dollarButton
            // 
            this.dollarButton.AutoSize = true;
            this.dollarButton.Location = new System.Drawing.Point(12, 240);
            this.dollarButton.Name = "dollarButton";
            this.dollarButton.Size = new System.Drawing.Size(52, 17);
            this.dollarButton.TabIndex = 0;
            this.dollarButton.TabStop = true;
            this.dollarButton.Text = "Dollar";
            this.dollarButton.UseVisualStyleBackColor = true;
            this.dollarButton.CheckedChanged += new System.EventHandler(this.dollarButton_CheckedChanged);
            // 
            // euroButton
            // 
            this.euroButton.AutoSize = true;
            this.euroButton.Location = new System.Drawing.Point(12, 263);
            this.euroButton.Name = "euroButton";
            this.euroButton.Size = new System.Drawing.Size(47, 17);
            this.euroButton.TabIndex = 3;
            this.euroButton.TabStop = true;
            this.euroButton.Text = "Euro";
            this.euroButton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.euroButton.UseVisualStyleBackColor = true;
            this.euroButton.CheckedChanged += new System.EventHandler(this.euroButton_CheckedChanged);
            // 
            // dateBox
            // 
            this.dateBox.AutoSize = true;
            this.dateBox.Location = new System.Drawing.Point(12, 335);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(86, 17);
            this.dateBox.TabIndex = 4;
            this.dateBox.Text = "Current Date";
            this.dateBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "View average cost of housing. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please make your selection and hit submit.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dollarLabel
            // 
            this.dollarLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dollarLabel.Location = new System.Drawing.Point(104, 234);
            this.dollarLabel.Name = "dollarLabel";
            this.dollarLabel.Size = new System.Drawing.Size(100, 23);
            this.dollarLabel.TabIndex = 10;
            // 
            // euroLabel
            // 
            this.euroLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.euroLabel.Location = new System.Drawing.Point(104, 264);
            this.euroLabel.Name = "euroLabel";
            this.euroLabel.Size = new System.Drawing.Size(100, 23);
            this.euroLabel.TabIndex = 11;
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Location = new System.Drawing.Point(104, 306);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 12;
            // 
            // dateLabel
            // 
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLabel.Location = new System.Drawing.Point(104, 329);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(100, 23);
            this.dateLabel.TabIndex = 13;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(104, 382);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.euroLabel);
            this.Controls.Add(this.dollarLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.euroButton);
            this.Controls.Add(this.housingList);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.dollarButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox nameBox;
        private System.Windows.Forms.ListBox housingList;
        private System.Windows.Forms.RadioButton dollarButton;
        private System.Windows.Forms.RadioButton euroButton;
        private System.Windows.Forms.CheckBox dateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dollarLabel;
        private System.Windows.Forms.Label euroLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

