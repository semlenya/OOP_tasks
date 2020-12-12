using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class MyWagonSand : MyWagon
    {
        int delta = 2;
        public int cargoWeight;
        public int cargoHeight;
        Brush cargoBrush = Brushes.Yellow;
        public MyWagonSand()
        { }
        public MyWagonSand(int X, int Y, int Weight, int Height)
        {
            x = X;
            y = Y;
            weight = Weight;
            height = Height;
            radius = weight / 5;
            cargoWeight = weight - 2 * delta;
            cargoHeight = height / 2;
        }
        public override void Draw(Pen pen, Brush brush, Graphics graph)
        {
            base.Draw(pen, brush, graph);
            Point[] points = { new Point(x + weight / 2, y - cargoHeight), new Point(x + delta, y), new Point(x + cargoWeight, y) };
            graph.FillPolygon(cargoBrush, points);
        }
    }
}
