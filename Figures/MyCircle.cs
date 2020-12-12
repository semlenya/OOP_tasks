using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class MyCircle : MyFigure
    {
        public int radius;

        public MyCircle()
        { }

        public MyCircle(int X, int Y, int Radius)
        {
            x = X;
            y = Y;
            radius = Radius;
        }
        public override void Draw(Pen pen, Brush brush, Graphics graph)
        {
            //graph.DrawEllipse(pen, x - radius, y - radius,  2 * radius, 2 * radius);
            Rectangle ellipse = new Rectangle(x - radius, y - radius, 2 * radius, 2 * radius);
            graph.FillEllipse(brush, ellipse);
        }
    }
}
