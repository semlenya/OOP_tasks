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
            Rational dr1;
            Rational dr2;
            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || textBox2.Text == "0" || textBox4.Text == "0")
            {
                MessageBox.Show("Error");
            }
            else
            {
                try
                {
                    dr1 = new Rational(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                    dr2 = new Rational(int.Parse(textBox3.Text), int.Parse(textBox4.Text));

                    Rational dr3 = dr1 + dr2;
                    textBox5.Text = Convert.ToString(dr3.chis);
                    textBox6.Text = Convert.ToString(dr3.znam);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            Rational dr1;
            Rational dr2;
            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || textBox2.Text == "0" || textBox4.Text == "0")
            {
                MessageBox.Show("Error");
            }
            else
            {
                try
                {
                    dr1 = new Rational(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                    dr2 = new Rational(int.Parse(textBox3.Text), int.Parse(textBox4.Text));

                    Rational dr3 = dr1 - dr2;
                    textBox5.Text = Convert.ToString(dr3.chis);
                    textBox6.Text = Convert.ToString(dr3.znam);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void Miltiplication_Click(object sender, EventArgs e)
        {
            Rational dr1;
            Rational dr2;
            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || textBox2.Text == "0" || textBox4.Text == "0")
            {
                MessageBox.Show("Error");
            }
            else
            {
                try
                {
                    dr1 = new Rational(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                    dr2 = new Rational(int.Parse(textBox3.Text), int.Parse(textBox4.Text));

                    Rational dr3 = dr1 * dr2;
                    textBox5.Text = Convert.ToString(dr3.chis);
                    textBox6.Text = Convert.ToString(dr3.znam);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void Division_Click(object sender, EventArgs e)
        {
            Rational dr1;
            Rational dr2;
            if (textBox1.Text == null || textBox2.Text == null || textBox3.Text == null || textBox4.Text == null || textBox2.Text == "0" || textBox4.Text == "0")
            {
                MessageBox.Show("Error");
            }
            else
            {
                try
                {
                    dr1 = new Rational(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                    dr2 = new Rational(int.Parse(textBox3.Text), int.Parse(textBox4.Text));

                    Rational dr3 = dr1 / dr2;
                    textBox5.Text = Convert.ToString(dr3.chis);
                    textBox6.Text = Convert.ToString(dr3.znam);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
