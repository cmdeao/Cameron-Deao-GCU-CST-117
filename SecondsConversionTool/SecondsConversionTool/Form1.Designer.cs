namespace SecondsConversionTool
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
            this.label1 = new System.Windows.Forms.Label();
            this.secondsBox = new System.Windows.Forms.TextBox();
            this.conversionButton = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of seconds elapsed:";
            // 
            // secondsBox
            // 
            this.secondsBox.Location = new System.Drawing.Point(368, 45);
            this.secondsBox.Name = "secondsBox";
            this.secondsBox.Size = new System.Drawing.Size(100, 20);
            this.secondsBox.TabIndex = 1;
            this.secondsBox.TextChanged += new System.EventHandler(this.secondsBox_TextChanged);
            // 
            // conversionButton
            // 
            this.conversionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionButton.Location = new System.Drawing.Point(368, 102);
            this.conversionButton.Name = "conversionButton";
            this.conversionButton.Size = new System.Drawing.Size(100, 32);
            this.conversionButton.TabIndex = 2;
            this.conversionButton.Text = "Convert";
            this.conversionButton.UseVisualStyleBackColor = true;
            this.conversionButton.Click += new System.EventHandler(this.conversionButton_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayLabel.Location = new System.Drawing.Point(23, 112);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(276, 23);
            this.displayLabel.TabIndex = 3;
            this.displayLabel.UseMnemonic = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 204);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.conversionButton);
            this.Controls.Add(this.secondsBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Seconds Conversion Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secondsBox;
        private System.Windows.Forms.Button conversionButton;
        private System.Windows.Forms.Label displayLabel;
    }
}

