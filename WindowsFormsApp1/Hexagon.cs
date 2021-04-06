using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp1
{
    class Hexagon
    {
        public Point[] kodkodim;
        public Color col;
        public bool fill;
        public int size;
     
        public Hexagon()
        {
            this.kodkodim = new Point[6];
        }
        public Hexagon(Point[] kod, Color color, bool isfilled, int size)
        {
            this.kodkodim = new Point[6];
            this.col = color;
            this.fill = isfilled;
            this.size = size;
        }
    }
}
