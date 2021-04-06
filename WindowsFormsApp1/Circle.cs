using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp1
{
    class Circle
    {
        public Point startPoint;
        public int Radius;
        public Color color;
        public bool fill;
        public int size;
        public Circle() { }
        public Circle(Point s, int r, Color c, bool f, int siz)
        {
            startPoint = new Point();
            startPoint = s;
            Radius = r;
            color = c;
            fill = f;
            size = siz;
        }

    }
}

