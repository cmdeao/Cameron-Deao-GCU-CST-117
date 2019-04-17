namespace CameronDeao_Excercise_1
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
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.finalLabel = new System.Windows.Forms.Label();
            this.boxPrice = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(13, 214);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(95, 214);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear Fields";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(177, 213);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit Program";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(13, 13);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(61, 13);
            this.inputLabel.TabIndex = 3;
            this.inputLabel.Text = "Input Price:";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(16, 57);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(81, 13);
            this.labelTax.TabIndex = 4;
            this.labelTax.Text = "Input Tax Rate:";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(19, 117);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(61, 13);
            this.total.TabIndex = 5;
            this.total.Text = "Total Price:";
            // 
            // finalLabel
            // 
            this.finalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finalLabel.Location = new System.Drawing.Point(136, 116);
            this.finalLabel.Name = "finalLabel";
            this.finalLabel.Size = new System.Drawing.Size(100, 23);
            this.finalLabel.TabIndex = 6;
            // 
            // boxPrice
            // 
            this.boxPrice.Location = new System.Drawing.Point(136, 13);
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.Size = new System.Drawing.Size(100, 20);
            this.boxPrice.TabIndex = 7;
            this.boxPrice.TextChanged += new System.EventHandler(this.boxPrice_TextChanged);
            // 
            // taxBox
            // 
            this.taxBox.Location = new System.Drawing.Point(136, 57);
            this.taxBox.Name = "taxBox";
            this.taxBox.Size = new System.Drawing.Size(100, 20);
            this.taxBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.boxPrice);
            this.Controls.Add(this.finalLabel);
            this.Controls.Add(this.total);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.TextBox taxRateBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label finalLabel;
        private System.Windows.Forms.TextBox boxPrice;
        private System.Windows.Forms.TextBox taxBox;
    }
}

