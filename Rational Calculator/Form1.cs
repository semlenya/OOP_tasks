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
            ProcessOperation("Addition", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5, textBox6);
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            ProcessOperation("Subtraction", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5, textBox6);
        }

        private void Miltiplication_Click(object sender, EventArgs e)
        {
            ProcessOperation("Multiplication", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5, textBox6);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            ProcessOperation("Division", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5, textBox6);
        }
        static void ProcessOperation (string operation, string t1, string t2, string t3, string t4, TextBox t5, TextBox t6)
        {
            Rational dr1;
            Rational dr2;
            Rational dr3 = new Rational(0, 0);
            
            if (t2 == "0" || t4 == "0")
            {
                MessageBox.Show("Denumerator = 0");
            }
            try
            {
                dr1 = new Rational(int.Parse(t1), int.Parse(t2));
                dr2 = new Rational(int.Parse(t3), int.Parse(t4));


                if (operation == "Addition")
                {
                    dr3 = dr1 + dr2;
                }
                else if (operation == "Subtraction")
                {
                    dr3 = dr1 - dr2;
                }
                else if (operation == "Multiplication")
                {
                    dr3 = dr1 * dr2;
                }
                else if (operation == "Division")
                {
                    dr3 = dr1 / dr2;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
            t5.Text = Convert.ToString(dr3.chis);
            if (dr3.znam != 1)
                t6.Text = Convert.ToString(dr3.znam);
            else
                t6.Text = "";
        }
    }
}
