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

        int cl = 0;
        private void Addition_Click(object sender, EventArgs e)
        {
            cl = 1;
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;
            string t4 = textBox4.Text;
            ErrorPr(cl, t1, t2, t3, t4, textBox5, textBox6);
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            cl = 2;
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;
            string t4 = textBox4.Text;
            ErrorPr(cl, t1, t2, t3, t4, textBox5, textBox6);
        }

        private void Miltiplication_Click(object sender, EventArgs e)
        {
            cl = 3;
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;
            string t4 = textBox4.Text;
            ErrorPr(cl, t1, t2, t3, t4, textBox5, textBox6);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            cl = 4;
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;
            string t4 = textBox4.Text;
            ErrorPr(cl, t1, t2, t3, t4, textBox5, textBox6);
        }
        static void ErrorPr (int cl, string t1, string t2, string t3, string t4, TextBox t5, TextBox t6)
        {
            Rational dr1;
            Rational dr2;
            if (t2 == "0" || t4 == "0")
            {
                MessageBox.Show("Denumerator = 0");
            }
            else
            {
                try
                {
                    dr1 = new Rational(int.Parse(t1), int.Parse(t2));
                    dr2 = new Rational(int.Parse(t3), int.Parse(t4));

                    
                    if (cl == 1)
                    {
                        Rational dr3 = dr1 + dr2;
                        if (dr3.chis == dr3.znam)
                        {
                            dr3.chis = 1;
                            dr3.znam = 1;
                        }
                        else
                        {
                            int c = dr3.chis, z = dr3.znam;
                            while (c != 0 && z != 0)
                            {
                                if (c > z)
                                    c %= z;
                                else
                                    z %= c;
                            }
                            dr3.chis /= c + z;
                            dr3.znam /= c + z;
                        }
                        //Sokr(dr3.chis, dr3.znam);
                        t5.Text = Convert.ToString(dr3.chis);
                        if (dr3.znam != 1)
                            t6.Text = Convert.ToString(dr3.znam);
                        else
                            t6.Text = "";
                    }
                    else if (cl == 2)
                    {
                        Rational dr3 = dr1 - dr2;
                        if (dr3.chis == dr3.znam)
                        {
                            dr3.chis = 1;
                            dr3.znam = 1;
                        }
                        else
                        {
                            int c = dr3.chis, z = dr3.znam;
                            while (c != 0 && z != 0)
                            {
                                if (c > z)
                                    c %= z;
                                else
                                    z %= c;
                            }
                            dr3.chis /= c + z;
                            dr3.znam /= c + z;
                        }
                        t5.Text = Convert.ToString(dr3.chis);
                        if (dr3.znam != 1)
                            t6.Text = Convert.ToString(dr3.znam);
                        else
                            t6.Text = "";
                    }
                    else if (cl == 3)
                    {
                        Rational dr3 = dr1 * dr2;
                        if (dr3.chis == dr3.znam)
                        {
                            dr3.chis = 1;
                            dr3.znam = 1;
                        }
                        else
                        {
                            int c = dr3.chis, z = dr3.znam;
                            while (c != 0 && z != 0)
                            {
                                if (c > z)
                                    c %= z;
                                else
                                    z %= c;
                            }
                            dr3.chis /= c + z;
                            dr3.znam /= c + z;
                        }
                        t5.Text = Convert.ToString(dr3.chis);
                        if (dr3.znam != 1)
                            t6.Text = Convert.ToString(dr3.znam);
                        else
                            t6.Text = "";
                    }
                    else if (cl == 4)
                    {
                        Rational dr3 = dr1 / dr2;
                        if (dr3.chis == dr3.znam)
                        {
                            dr3.chis = 1;
                            dr3.znam = 1;
                        }
                        else
                        {
                            int c = dr3.chis, z = dr3.znam;
                            while (c != 0 && z != 0)
                            {
                                if (c > z)
                                    c %= z;
                                else
                                    z %= c;
                            }
                            dr3.chis /= c + z;
                            dr3.znam /= c + z;
                        }
                        t5.Text = Convert.ToString(dr3.chis);
                        if (dr3.znam != 1)
                            t6.Text = Convert.ToString(dr3.znam);
                        else
                            t6.Text = "";
                    }
                    
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
        //static void Sokr(int ch, int zn)
        //{
        //    if (ch == zn)
        //    {
        //        ch = 1;
        //        zn = 1;
        //    }
        //    else
        //    {
        //        int c = ch, z = zn;
        //        while (c != 0 && z != 0)
        //        {
        //            if (c > z)
        //                c %= z;
        //            else
        //                z %= c;
        //        }
        //        ch /= c + z;
        //        zn /= c + z;
        //    }

        //}
    }
}
