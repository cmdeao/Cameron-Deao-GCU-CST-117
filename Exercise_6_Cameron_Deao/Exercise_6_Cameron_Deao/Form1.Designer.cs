namespace Exercise_6_Cameron_Deao
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
            this.rollButton = new System.Windows.Forms.Button();
            this.diceLabel1 = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.sidesLabel = new System.Windows.Forms.Label();
            this.diceLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.Location = new System.Drawing.Point(12, 102);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(138, 99);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll Dice";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // diceLabel1
            // 
            this.diceLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceLabel1.Location = new System.Drawing.Point(176, 104);
            this.diceLabel1.Name = "diceLabel1";
            this.diceLabel1.Size = new System.Drawing.Size(80, 97);
            this.diceLabel1.TabIndex = 2;
            this.diceLabel1.Text = "0";
            // 
            // counterLabel
            // 
            this.counterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counterLabel.Location = new System.Drawing.Point(178, 259);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(178, 42);
            this.counterLabel.TabIndex = 3;
            // 
            // sidesLabel
            // 
            this.sidesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sidesLabel.Location = new System.Drawing.Point(178, 202);
            this.sidesLabel.Name = "sidesLabel";
            this.sidesLabel.Size = new System.Drawing.Size(178, 57);
            this.sidesLabel.TabIndex = 4;
            // 
            // diceLabel2
            // 
            this.diceLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceLabel2.Location = new System.Drawing.Point(277, 104);
            this.diceLabel2.Name = "diceLabel2";
            this.diceLabel2.Size = new System.Drawing.Size(80, 97);
            this.diceLabel2.TabIndex = 5;
            this.diceLabel2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(470, 358);
            this.Controls.Add(this.diceLabel2);
            this.Controls.Add(this.sidesLabel);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.diceLabel1);
            this.Controls.Add(this.rollButton);
            this.Name = "Form1";
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label diceLabel1;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Label sidesLabel;
        private System.Windows.Forms.Label diceLabel2;
    }
}

