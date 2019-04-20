namespace Cameron_Deao_Excercise_3
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
            this.poundLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kgLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.kgButton = new System.Windows.Forms.Button();
            this.poundsLabel = new System.Windows.Forms.Label();
            this.labelPound = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // poundLabel
            // 
            this.poundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poundLabel.Location = new System.Drawing.Point(12, 56);
            this.poundLabel.Name = "poundLabel";
            this.poundLabel.Size = new System.Drawing.Size(263, 42);
            this.poundLabel.TabIndex = 0;
            this.poundLabel.Text = "Enter your weight in a format of your choosing:";
            this.poundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(300, 69);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(141, 20);
            this.inputBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your weight in kilograms";
            // 
            // kgLabel
            // 
            this.kgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgLabel.Location = new System.Drawing.Point(300, 123);
            this.kgLabel.Name = "kgLabel";
            this.kgLabel.Size = new System.Drawing.Size(141, 23);
            this.kgLabel.TabIndex = 3;
            this.kgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(178, 308);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(141, 51);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert to Kilograms";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(31, 309);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(141, 50);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear Weight Fields";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // kgButton
            // 
            this.kgButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgButton.Location = new System.Drawing.Point(325, 310);
            this.kgButton.Name = "kgButton";
            this.kgButton.Size = new System.Drawing.Size(141, 49);
            this.kgButton.TabIndex = 6;
            this.kgButton.Text = "Convert to Pounds";
            this.kgButton.UseVisualStyleBackColor = true;
            this.kgButton.Click += new System.EventHandler(this.kgButton_Click);
            // 
            // poundsLabel
            // 
            this.poundsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poundsLabel.Location = new System.Drawing.Point(31, 184);
            this.poundsLabel.Name = "poundsLabel";
            this.poundsLabel.Size = new System.Drawing.Size(200, 35);
            this.poundsLabel.TabIndex = 7;
            this.poundsLabel.Text = "Your weight in pounds";
            // 
            // labelPound
            // 
            this.labelPound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPound.Location = new System.Drawing.Point(300, 184);
            this.labelPound.Name = "labelPound";
            this.labelPound.Size = new System.Drawing.Size(141, 23);
            this.labelPound.TabIndex = 8;
            this.labelPound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(178, 389);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(141, 49);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit Program";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 461);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.labelPound);
            this.Controls.Add(this.poundsLabel);
            this.Controls.Add(this.kgButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.kgLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.poundLabel);
            this.Name = "Form1";
            this.Text = "Weight Conversion Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label poundLabel;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kgLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button kgButton;
        private System.Windows.Forms.Label poundsLabel;
        private System.Windows.Forms.Label labelPound;
        private System.Windows.Forms.Button exitButton;
    }
}

