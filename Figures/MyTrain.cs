using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    class MyTrain : MyFigure
    {
        public int wagons;
        public int weight;
        public int height;
        public int radius;
        int between = 10;
        MyWagon[] wagon;
        Random random = new Random();
        public MyTrain() 
        { }
        public MyTrain(int X, int Y, int Weight, int Height, int Wagons)
        {
            x = X;
            y = Y;
            weight = (Weight - between * (Wagons - 1)) / Wagons;
            height = Height;
            radius = weight / 5;
            wagons = Wagons;
            wagon = new MyWagon[wagons];
            for (int i = 0; i < wagons; i++)
            {
                int rnd = random.Next(0, 3);
                switch (rnd)
                {
                    case 0:
                        wagon[i] = new MyWagon(x + (weight + between) * i, y, weight, height);
                        break;
                    case 1:
                        wagon[i] = new MyWagonCoal(x + (weight + between) * i, y, weight, height);
                        break;
                    case 2:
                        wagon[i] = new MyWagonSand(x + (weight + between) * i, y, weight, height);
                        break;
                }
            }
            
        }
        public override void Draw(Pen pen, Brush brush, Graphics graph)
        {
            for (int i = 0; i < wagons; i++)
            {
                wagon[i].Draw(pen, brush, graph);
            }
        }
    }
}
