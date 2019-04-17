using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cameron_Deao_Excercise_3
{
    public partial class Form1 : Form
    {
        double pounds;
        double kilograms;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pounds = double.Parse(poundsBox.Text);
            kilograms = pounds * 0.45359237;
            kgLabel.Text = kilograms.ToString("n");
        }
    }
}
