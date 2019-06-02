namespace Programming_Project_5_Cameron_Deao
{
    partial class DataEntry
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
            this.birthYearBox = new System.Windows.Forms.ComboBox();
            this.monthDropDown = new System.Windows.Forms.ComboBox();
            this.birthDayComboBox = new System.Windows.Forms.ComboBox();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.birthYearLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // birthYearBox
            // 
            this.birthYearBox.FormattingEnabled = true;
            this.birthYearBox.Location = new System.Drawing.Point(162, 30);
            this.birthYearBox.Name = "birthYearBox";
            this.birthYearBox.Size = new System.Drawing.Size(121, 21);
            this.birthYearBox.TabIndex = 0;
            // 
            // monthDropDown
            // 
            this.monthDropDown.FormattingEnabled = true;
            this.monthDropDown.Location = new System.Drawing.Point(162, 79);
            this.monthDropDown.Name = "monthDropDown";
            this.monthDropDown.Size = new System.Drawing.Size(121, 21);
            this.monthDropDown.TabIndex = 1;
            this.monthDropDown.SelectedIndexChanged += new System.EventHandler(this.monthDropDown_SelectedIndexChanged);
            // 
            // birthDayComboBox
            // 
            this.birthDayComboBox.FormattingEnabled = true;
            this.birthDayComboBox.Location = new System.Drawing.Point(162, 134);
            this.birthDayComboBox.Name = "birthDayComboBox";
            this.birthDayComboBox.Size = new System.Drawing.Size(121, 21);
            this.birthDayComboBox.TabIndex = 2;
            // 
            // colorComboBox
            // 
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Location = new System.Drawing.Point(162, 185);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorComboBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Get Your Lucky Number!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // birthYearLabel
            // 
            this.birthYearLabel.AutoSize = true;
            this.birthYearLabel.Location = new System.Drawing.Point(12, 33);
            this.birthYearLabel.Name = "birthYearLabel";
            this.birthYearLabel.Size = new System.Drawing.Size(104, 13);
            this.birthYearLabel.TabIndex = 5;
            this.birthYearLabel.Text = "Enter your birth year:";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(12, 82);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(113, 13);
            this.monthLabel.TabIndex = 6;
            this.monthLabel.Text = "Enter your birth month:";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(12, 137);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(101, 13);
            this.dayLabel.TabIndex = 7;
            this.dayLabel.Text = "Enter your birth day:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(12, 188);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(122, 13);
            this.colorLabel.TabIndex = 8;
            this.colorLabel.Text = "Enter your favorite color:";
            // 
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 284);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.birthYearLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.birthDayComboBox);
            this.Controls.Add(this.monthDropDown);
            this.Controls.Add(this.birthYearBox);
            this.Name = "DataEntry";
            this.Text = "Lucky Numbers!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox birthYearBox;
        private System.Windows.Forms.ComboBox monthDropDown;
        private System.Windows.Forms.ComboBox birthDayComboBox;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label birthYearLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label colorLabel;
    }
}

