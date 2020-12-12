using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class MyWagon : MyRectangle
    {
        public int radius;
        MyCircle wheel1 = new MyCircle();
        MyCircle wheel2 = new MyCircle();
        public MyWagon()
        { }
        
        public MyWagon(int X, int Y, int Weight, int Height)
        {
            x = X;
            y = Y;
            weight = Weight;
            height = Height;
            radius = weight / 5;
        }
        public override void Draw(Pen pen, Brush brush, Graphics graph)
        {
            base.Draw(pen, brush, graph);
            wheel1 = new MyCircle(x + radius, y + height + radius, radius);
            wheel2 = new MyCircle(x + weight - 2 * radius + radius, y + height + radius, radius);
            wheel1.Draw(pen, brush, graph);
            wheel2.Draw(pen, brush, graph);
        }
    }
}
