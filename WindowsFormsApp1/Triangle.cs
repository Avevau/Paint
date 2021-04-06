using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp1
{
    class Triangle
    {
        public Point[] kodkodim;
        public Color color;
        public bool fill;
        public int size;

        public Triangle()
        {
            this.kodkodim = new Point[3];
        }
        public Triangle(Point point) 
        {
            this.kodkodim = new Point[3];
        }

        public Triangle(Point[] kod , Color color,bool isfilled, int size)
        {
            this.kodkodim = new Point[3];
            this.color = color;
            this.fill = isfilled;
            this.size = size;
        }


    }
}
