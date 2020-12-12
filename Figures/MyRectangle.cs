using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Figures
{
    class MyRectangle : MyFigure
    {
        public int weight;
        public int height;
        public MyRectangle()
        { }
        public MyRectangle(int X, int Y, int Weight, int Height)
        {
            x = X;
            y = Y;
            weight = Weight;
            height = Height;
        }
        public override void Draw(Pen pen, Brush brush, Graphics graph)
        {
            //graph.DrawRectangle(pen, x, y, weight, height);
            Rectangle rectangle = new Rectangle(x, y, weight, height);
            graph.FillRectangle(brush, rectangle);
        }
    }
}
