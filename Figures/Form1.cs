using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class Form1 : Form
    {
        List<MyFigure> figures = new List<MyFigure>();
        MyFigure MoveFigure;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "Circle", "Rectangle" , "Wagon", "Train"});
            comboBox1.SelectedIndex = 0;
            comboBox2.Items.AddRange(new string[] { "1", "2", "3", "4", "5"});
            comboBox2.SelectedIndex = 0;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            gr.Clear(Color.LavenderBlush);
            figures.Clear();
            ClearTextBoxes();
        }

        public void ClearTextBoxes()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ClearTextBoxes();
                textBox1.Text = Convert.ToString(e.X);
                textBox2.Text = Convert.ToString(e.Y);
            }
            else if (e.Button == MouseButtons.Right)
            {
                textBox1.Text = Convert.ToString(e.X);
                textBox2.Text = Convert.ToString(e.Y);
                int i = figures.Count - 1;
                bool flag = false;
                while (i >= 0 && !flag)
                {
                    MyFigure figure = (MyFigure)figures[i];
                    if (figure.IsPointInside(e.X, e.Y))
                    {
                        MoveFigure = figure;
                        figures.Remove(figure);
                        flag = true;
                        return;
                    }
                    i--;
                }
                if (comboBox1.SelectedIndex == 0)
                {
                    MyCircle circ = new MyCircle();
                    
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    
                }
                else if (comboBox1.SelectedIndex == 3)
                {

                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    int Radius = 0;
                    int X = Convert.ToInt32(textBox1.Text);
                    int Y = Convert.ToInt32(textBox2.Text);

                    if (e.X > X)
                    {
                        if (e.Y > Y)
                        {
                            if (e.X - X > e.Y - Y)
                            {
                                Radius = e.X - X;
                            }
                            else
                            {
                                Radius = e.Y - Y;
                            }
                        }
                        else if (e.Y < Y)
                        {

                            if (e.X - X > Y - e.Y)
                            {
                                Radius = e.X - X;
                            }
                            else
                            {
                                Radius = Y - e.Y;
                            }
                        }
                    }
                    else
                    {
                        if (e.Y > Y)
                        {
                            if (X - e.X > e.Y - Y)
                            {
                                Radius = X - e.X;
                            }
                            else
                            {
                                Radius = e.Y - Y;
                            }
                        }
                        else if (e.Y < Y)
                        {
                            if (X - e.X > Y - e.Y)
                            {
                                Radius = X - e.X;
                            }
                            else
                            {
                                Radius = Y - e.Y;
                            }
                        }
                    }
                    textBox5.Text = Convert.ToString(Radius);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    int X = Convert.ToInt32(textBox1.Text);
                    int Y = Convert.ToInt32(textBox2.Text);
                    int Weight = 0;
                    int Height = 0;
                    if (e.X > X)
                    {
                        if (e.Y > Y)
                        {
                            Weight = e.X - X;
                            Height = e.Y - Y;
                        }
                        else if (e.Y < Y)
                        {
                            Weight = e.X - X;
                            Height = Y - e.Y;
                        }
                    }
                    else
                    {
                        if (e.Y > Y)
                        {
                            Weight = X - e.X;
                            Height = e.Y - Y;
                        }
                        else
                        {
                            Weight = X - e.X;
                            Height = Y - e.Y;
                        }
                    }
                    textBox3.Text = Convert.ToString(Weight);
                    textBox4.Text = Convert.ToString(Height);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    int X = Convert.ToInt32(textBox1.Text);
                    int Y = Convert.ToInt32(textBox2.Text);
                    int Weight = 0;
                    int Height = 0;
                    if (e.X > X)
                    {
                        if (e.Y > Y)
                        {
                            Weight = e.X - X;
                            Height = e.Y - Y;
                        }
                        else if (e.Y < Y)
                        {
                            Weight = e.X - X;
                            Height = Y - e.Y;
                        }
                    }
                    else
                    {
                        if (e.Y > Y)
                        {
                            Weight = X - e.X;
                            Height = e.Y - Y;
                        }
                        else if (e.Y < Y)
                        {
                            Weight = X - e.X;
                            Height = Y - e.Y;
                        }
                    }
                    textBox3.Text = Convert.ToString(Weight);
                    textBox4.Text = Convert.ToString(Height);
                    textBox5.Text = Convert.ToString(Weight / 5);
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    int Wagons = comboBox2.SelectedIndex + 1;
                    int X = Convert.ToInt32(textBox1.Text);
                    int Y = Convert.ToInt32(textBox2.Text);
                    int Weight = 0;
                    int Height = 0;
                    if (e.X > X)
                    {
                        if (e.Y > Y)
                        {
                            Weight = e.X - X;
                            Height = e.Y - Y;
                        }
                        else if (e.Y < Y)
                        {
                            Weight = e.X - X;
                            Height = Y - e.Y;
                        }
                    }
                    else
                    {
                        if (e.Y > Y)
                        {
                            Weight = X - e.X;
                            Height = e.Y - Y;
                        }
                        else if (e.Y < Y)
                        {
                            Weight = X - e.X;
                            Height = Y - e.Y;
                        }
                    }
                    Weight = (Weight - (Wagons - 1) * 10) / Wagons;
                    textBox3.Text = Convert.ToString(Weight);
                    textBox4.Text = Convert.ToString(Height);
                    textBox5.Text = Convert.ToString(Weight / 5);
                }
            }
            if (e.Button == MouseButtons.Right)
            {
            //    textBox1.Text = Convert.ToString(e.X);
            //    textBox2.Text = Convert.ToString(e.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    MyCircle circ = new MyCircle();
                    int Radius = Convert.ToInt32(textBox5.Text);
                    int X = Convert.ToInt32(textBox1.Text);
                    int Y = Convert.ToInt32(textBox2.Text);
                    if (e.X > X)
                    {
                        if (e.Y > Y)
                        {
                            if (e.X - X > e.Y - Y)
                            {
                                Radius = e.X - X;
                            }
                            else
                            {
                                Radius = e.Y - Y;
                            }
                        }
                        else if (e.Y < Y)
                        {

                            if (e.X - X > Y - e.Y)
                            {
                                Radius = e.X - X;
                            }
                            else
                            {
                                Radius = Y - e.Y;
                            }
                        }
                    }
                    else
                    {
                        if (e.Y > Y)
                        {
                            if (X - e.X > e.Y - Y)
                            {
                                Radius = X - e.X;
                            }
                            else
                            {
                                Radius = e.Y - Y;
                            }
                        }
                        else if (e.Y < Y)
                        {
                            if (X - e.X > Y - e.Y)
                            {
                                Radius = X - e.X;
                            }
                            else
                            {
                                Radius = Y - e.Y;
                            }
                        }
                    }
                    circ = new MyCircle(X, Y, Radius);
                    
                    figures.Add(circ);
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    MyRectangle rect = new MyRectangle();
                    int X = Convert.ToInt32(textBox1.Text);
                    int Y = Convert.ToInt32(textBox2.Text);
                    int Weight = 0;
                    int Height = 0;
                    if (e.X > X)
                    {
                        if (e.Y > Y)
                        {
                            Weight = e.X -  X;
                            Height = e.Y -  Y;
                            rect = new MyRectangle(X, Y, Weight, Height);
                        }
                        else if (e.Y < Y)
                        {
                            Weight = e.X -  X;
                            Height = Y -  e.Y;
                            rect = new MyRectangle(X, e.Y, Weight, Height);
                        }
                    }
                    else
                    {
                        if (e.Y > Y)
                        {
                            Weight = X -  e.X;
                            Height = e.Y -  Y;
                            rect = new MyRectangle(e.X, Y, Weight, Height);
                        }
                        else if (e.Y < Y)
                        {
                            Weight = X - e.X;
                            Height = Y - e.Y;
                            rect = new MyRectangle(e.X, e.Y, Weight, Height);
                        }
                    }

                    textBox3.Text = Convert.ToString(Weight);
                    textBox4.Text = Convert.ToString(Height);
                    figures.Add(rect);
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    MyWagon wagon = new MyWagon();
                    int X = Convert.ToInt32(textBox1.Text);
                    int Y = Convert.ToInt32(textBox2.Text);
                    int Weight = 0;
                    int Height = 0;
                    if (e.X > X)
                    {
                        if (e.Y > Y)
                        {
                            Weight = e.X - X;
                            Height = e.Y - Y;
                            wagon = new MyWagon(X, Y, Weight, Height);
                        }
                        else if (e.Y < Y)
                        {
                            Weight = e.X - X;
                            Height = Y - e.Y;
                            wagon = new MyWagon(X, e.Y, Weight, Height);
                        }
                    }
                    else
                    {
                        if (e.Y > Y)
                        {
                            Weight = X - e.X;
                            Height = e.Y - Y;
                            wagon = new MyWagon(e.X, Y, Weight, Height);
                        }
                        else if (e.Y < Y)
                        {
                            Weight = X - e.X;
                            Height = Y - e.Y;
                            wagon = new MyWagon(e.X, e.Y, Weight, Height);
                        }
                    }
                    textBox3.Text = Convert.ToString(Weight);
                    textBox4.Text = Convert.ToString(Height);
                    textBox5.Text = Convert.ToString(Weight / 5);
                    figures.Add(wagon);
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    MyTrain train = new MyTrain();
                    int X = Convert.ToInt32(textBox1.Text);
                    int Y = Convert.ToInt32(textBox2.Text);
                    int Weight = 0;
                    int Height = 0;
                    int Wagons = comboBox2.SelectedIndex + 1;
                    if (e.X > X)
                    {
                        if (e.Y > Y)
                        {
                            Weight = e.X - X;
                            Height = e.Y - Y;
                            train = new MyTrain(X, Y, Weight, Height, Wagons);
                        }
                        else if (e.Y < Y)
                        {
                            Weight = e.X - X;
                            Height = Y - e.Y;
                            train = new MyTrain(X, e.Y, Weight, Height, Wagons);
                        }
                    }
                    else
                    {
                        if (e.Y > Y)
                        {
                            Weight = X - e.X;
                            Height = e.Y - Y;
                            train = new MyTrain(e.X, Y, Weight, Height, Wagons);
                        }
                        else if (e.Y < Y)
                        {
                            Weight = X - e.X;
                            Height = Y - e.Y;
                            train = new MyTrain(e.X, e.Y, Weight, Height, Wagons);
                        }
                    }
                    Weight = (Weight - (Wagons - 1) * 10) / Wagons;
                    textBox3.Text = Convert.ToString(Weight);
                    textBox4.Text = Convert.ToString(Height);
                    textBox5.Text = Convert.ToString(Weight / 5);
                    figures.Add(train);
                }
                this.Refresh();
            }
            if (e.Button == MouseButtons.Right)
            {

            }
        }
        
        void UpdateFigures ()
        {
            Pen pen = new Pen(Brushes.Black, 4);
            Brush brush = Brushes.LightSkyBlue;
            Graphics gr = this.CreateGraphics();
            foreach (MyFigure F in figures)
            {
                F.Draw(pen, brush, gr);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            UpdateFigures();
        }
    }
}
