using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp1
{
    class Square
    {
        public Point startPoint;
        public int width;
        public int height;
        public Color color;
        public bool fill;
        public int size;
        public Square() { }
        public Square(int x, int y, int w, int h, Color c,int size,bool fill)
        {
            startPoint = new Point(x, y);
            width = w;
            height = h;
            color = c;
            this.size = size;
            this.fill = fill;

        }


    }
}
