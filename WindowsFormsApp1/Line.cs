using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Line
    {
        public Point startPoint;
        public Point lastPoint;
        public Color color;
        public int size;
        public Line() { }
        public Line(Point p1, Point p2, Color c,int size)
        {
            startPoint = p1;
            lastPoint = p2;
            color = c;
            this.size = size;
        }


    }
}
