using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figures
{
    
    class MyFigure
    {
        public int x;
        public int y;
        public virtual void Draw(Pen pen, Brush brush, Graphics gr)
        {

        }
        public virtual bool IsPointInside(int x, int y)
        {
            return true;
        }
    }
}
