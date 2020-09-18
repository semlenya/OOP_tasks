using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rational_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Addition_Click(object sender, EventArgs e)
        {
            Rational dr1 = new Rational();
            Rational dr2 = new Rational();
            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || textBox2.Text == "0" || textBox4.Text == "0")
            {
                MessageBox.Show("Error");
            }
            else
            {
                try
                {
                    Rational dr3 = dr1 + dr2;

                }
                catch
                {

                }
            }
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {

        }

        private void Miltiplication_Click(object sender, EventArgs e)
        {

        }

        private void Division_Click(object sender, EventArgs e)
        {

        }
    }
}
