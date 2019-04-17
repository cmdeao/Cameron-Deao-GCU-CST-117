using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameronDeao_Excercise_1
{
    public partial class Form1 : Form
    {
        public decimal price;
        public decimal taxRate;
        public decimal finalPrice;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            price = decimal.Parse(boxPrice.Text);
            taxRate = decimal.Parse(taxBox.Text);
            finalPrice = price + (price * taxRate);
            finalLabel.Text = finalPrice.ToString("c");
        }

        private void boxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            boxPrice.Text = "";
            taxBox.Text = "";
            finalLabel.Text = "";
        }
    }
}
