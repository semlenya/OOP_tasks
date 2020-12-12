using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class MyWagonCoal : MyWagon
    {
        int delta = 2;
        public int cargoWeight;
        public int cargoHeight;
        Brush cargoBrush = Brushes.Black;
        public MyWagonCoal()
        { }
        public MyWagonCoal(int X, int Y, int Weight, int Height)
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
            Rectangle cargo = new Rectangle(x + delta, y - cargoHeight, cargoWeight, cargoHeight);
            graph.FillRectangle(cargoBrush, cargo);
        }
    }
    
}
