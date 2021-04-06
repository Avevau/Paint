using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Line> listLine = new List<Line>();
        List<Square> listSquare = new List<Square>();
        List<Circle> listCircle = new List<Circle>();
        List<Triangle> listTriangle = new List<Triangle>();
        List<Hexagon> listHexagon = new List<Hexagon>();

        Line curLine = new Line();
        Square curSquare = new Square();
        Circle curCircle = new Circle();
        Triangle curTriangle = new Triangle();
        Hexagon curHexagon = new Hexagon();

        public bool CanDrawLine, CanDrawSquare, CanDrawCircle, CanDrawTriangle, CanDrawHexgaon;
        public bool LinePressed, SquarePressed, CirclePressed, TrianglePressed, HexagonPressed;
        Stack<string> whatorem = new Stack<string>();

        int StartX, StartY;
        private void pencil_Click(object sender, EventArgs e)
        {
            LinePressed = true;
            SquarePressed = false;
            CirclePressed = false;
            TrianglePressed = false;
            HexagonPressed = false;
        }

        private void square_Click(object sender, EventArgs e)
        {
            LinePressed = false;
            CirclePressed = false;
            TrianglePressed = false;
            HexagonPressed = false;
            SquarePressed = true;
        }

        private void circle_Click(object sender, EventArgs e)
        {
            CirclePressed = true;
            LinePressed = false;
            SquarePressed = false;
            TrianglePressed = false;
            HexagonPressed = false;
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            TrianglePressed = true;
            LinePressed = false;
            SquarePressed = false;
            CirclePressed = false;
            HexagonPressed = false;
        }

        private void penplus_Click(object sender, EventArgs e)
        {
            Size++;
            Refresh();
        }

        private void penmin_Click(object sender, EventArgs e)
        {
            Size--;
            Refresh();
        }

        private void fill_Click(object sender, EventArgs e)
        {
            Filled = !Filled;//every click Switch
            Refresh();
        }

        private void color_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            MyPen.Color = dialog.Color;
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            listCircle.Clear();
            listSquare.Clear();
            listTriangle.Clear();
            listLine.Clear();
            listHexagon.Clear();
            Refresh();
            
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            string WhatToRemove = "None";
            if (whatorem.Count > 0)
                WhatToRemove = whatorem.Pop();

            if (WhatToRemove.Equals("Line"))
            {
                if (listLine.Count() > 0)
                    listLine.RemoveAt(listLine.Count() - 1);
              
                Refresh();
            }
            if (WhatToRemove.Equals("Square"))
            {
                if (listSquare.Count() > 0)
                    listSquare.RemoveAt(listSquare.Count() - 1);
               
                Refresh();
            }
            if (WhatToRemove.Equals("Circle"))
            {
                if (listCircle.Count() > 0)
                    listCircle.RemoveAt(listCircle.Count() - 1);
                
                Refresh();
            }
            if (WhatToRemove.Equals("Triangle"))
            {
                if (listTriangle.Count() > 0)
                    listTriangle.RemoveAt(listTriangle.Count() - 1);
               
                Refresh();
            }

            if (WhatToRemove.Equals("Hexagon"))
            {
                if (listHexagon.Count() > 0)
                    listHexagon.RemoveAt(listHexagon.Count() - 1);
               
                Refresh();
            }
            Refresh();
        }

        private void hexagon_Click(object sender, EventArgs e)
        {
            HexagonPressed = true;
            LinePressed = false;
            SquarePressed = false;
            CirclePressed = false;
            TrianglePressed = false;
        }

        public static bool Filled=false;
        public static int Size = 4;
        public static Color curColor=Color.Black;
        public Pen MyPen = new Pen(curColor, Size);
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (Filled)
                fill.BackColor = MyPen.Color;
            else fill.BackColor = Color.Transparent;
            sizeLbl.Text = Size.ToString();
            if (LinePressed)
            {
                e.Graphics.DrawLine(MyPen, curLine.startPoint, curLine.lastPoint);
                
            }
            foreach (Line temp in listLine)
            {
                e.Graphics.DrawLine(new Pen(temp.color, temp.size),temp.startPoint,temp.lastPoint);
            }


            if (SquarePressed)
            {
                if (Filled)
                {
                    e.Graphics.DrawRectangle(MyPen, curSquare.startPoint.X, curSquare.startPoint.Y, curSquare.width, curSquare.height);
                    e.Graphics.FillRectangle(new SolidBrush(MyPen.Color), curSquare.startPoint.X, curSquare.startPoint.Y, curSquare.width, curSquare.height);
                }
                else
                    e.Graphics.DrawRectangle(MyPen, curSquare.startPoint.X, curSquare.startPoint.Y, curSquare.width, curSquare.height);
            }
            foreach(Square temp in listSquare)
            {
                if (temp.fill)
                {
                    e.Graphics.DrawRectangle(new Pen(temp.color,temp.size), temp.startPoint.X, temp.startPoint.Y, temp.width, temp.height);
                    e.Graphics.FillRectangle(new SolidBrush(temp.color), temp.startPoint.X, temp.startPoint.Y,temp.width, temp.height);
                }
                else e.Graphics.DrawRectangle(new Pen(temp.color, temp.size), temp.startPoint.X, temp.startPoint.Y, temp.width, temp.height);
            }
            if(CirclePressed)
            {
                if(Filled)
                {
                    e.Graphics.DrawEllipse(MyPen, curCircle.startPoint.X, curCircle.startPoint.Y, curCircle.Radius, curCircle.Radius);
                    e.Graphics.FillEllipse(new SolidBrush(MyPen.Color), curCircle.startPoint.X, curCircle.startPoint.Y, curCircle.Radius, curCircle.Radius);
                }
                else
                    e.Graphics.DrawEllipse(MyPen, curCircle.startPoint.X, curCircle.startPoint.Y, curCircle.Radius, curCircle.Radius);
            }
            foreach (Circle temp in listCircle)
            {
                if(temp.fill)
                {
                    e.Graphics.DrawEllipse(new Pen(temp.color,temp.size), temp.startPoint.X, temp.startPoint.Y, temp.Radius, temp.Radius);
                    e.Graphics.FillEllipse(new SolidBrush(temp.color), temp.startPoint.X, temp.startPoint.Y, temp.Radius, temp.Radius);
                }
                else
                    e.Graphics.DrawEllipse(new Pen(temp.color, temp.size), temp.startPoint.X, temp.startPoint.Y, temp.Radius, temp.Radius);
            }
            if (TrianglePressed)
            {
                if (Filled)
                {
                    e.Graphics.DrawPolygon(MyPen,curTriangle.kodkodim);
                    e.Graphics.FillPolygon(new SolidBrush(MyPen.Color),curTriangle.kodkodim);
                }
                else
                    e.Graphics.DrawPolygon(MyPen,curTriangle.kodkodim);
            }
            
            foreach (Triangle temp in listTriangle)
            {
                if (temp.fill)
                {
                    e.Graphics.DrawPolygon(new Pen(temp.color,temp.size),temp.kodkodim);
                    e.Graphics.FillPolygon(new SolidBrush(temp.color),temp.kodkodim);
                }
                else
                    e.Graphics.DrawPolygon(new Pen(temp.color,temp.size),temp.kodkodim);
            }

            if (HexagonPressed)
            {
                if (Filled)
                {
                    e.Graphics.DrawPolygon(MyPen, curHexagon.kodkodim);
                    e.Graphics.FillPolygon(new SolidBrush(MyPen.Color), curHexagon.kodkodim);
                }
                else
                    e.Graphics.DrawPolygon(MyPen, curHexagon.kodkodim);
            }
            foreach (Hexagon temp in listHexagon)
            {
                if (temp.fill)
                {
                    e.Graphics.DrawPolygon(new Pen(temp.col, temp.size), temp.kodkodim);
                    e.Graphics.FillPolygon(new SolidBrush(temp.col), temp.kodkodim);
                }
                else
                    e.Graphics.DrawPolygon(new Pen(temp.col, temp.size), temp.kodkodim);
            }
        
        }

        

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            StartX = e.X;
            StartY = e.Y;
            if(LinePressed)
            {
                CanDrawLine = true;
                CanDrawSquare = false;
                CanDrawCircle = false;
                CanDrawTriangle = false;
                CanDrawHexgaon = false;
            }
            if(SquarePressed)
            {
                CanDrawLine = false;
                CanDrawSquare = true;
                CanDrawCircle = false;
                CanDrawTriangle = false;
                CanDrawHexgaon = false;
            }

            if(CirclePressed)
            {
                CanDrawLine = false;
                CanDrawSquare = false;
                CanDrawCircle = true;
                CanDrawTriangle = false;
                CanDrawHexgaon = false;
            }
            if(TrianglePressed)
            {
                CanDrawLine = false;
                CanDrawSquare = false;
                CanDrawCircle = false;
                CanDrawTriangle = !false;
                CanDrawHexgaon = false;
            }
            if(HexagonPressed)
            {
                CanDrawLine = false;
                CanDrawSquare = true;
                CanDrawCircle = false;
                CanDrawTriangle = false;
                CanDrawHexgaon = !false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (CanDrawLine)
            {
                curLine.startPoint = new Point(StartX, StartY);
                curLine.lastPoint = new Point(e.X, e.Y);
                Refresh();
            }

            if (CanDrawSquare)
            {
                
                int orech = Math.Max(e.X, StartX) - Math.Min(e.X, StartX);
                int rohav = Math.Max(e.Y, StartY) - Math.Min(e.Y, StartY); ;
                curSquare.width = orech;
                curSquare.startPoint.X = StartX;
                curSquare.startPoint.Y = StartY;
                curSquare.height = rohav;
                Refresh();
            }
            if (CanDrawCircle)
            {
                int Radius= Math.Max(e.X, StartX) - Math.Min(e.X, StartX);
                curCircle.startPoint = new Point(StartX, StartY);
                curCircle.Radius = Radius;
                Refresh();

            }
            if (CanDrawTriangle)
            {
                int x = Math.Min(StartX, e.X);
                int y = Math.Min(StartY, e.Y);
                int width = Math.Max(StartX, e.X) - Math.Min(StartX, e.X);
                int height = Math.Max(StartY, e.Y) - Math.Min(StartY, e.Y);
                int Gova = (width - height);

                curTriangle.kodkodim[0] = new Point(x + Gova, y - Gova);
                curTriangle.kodkodim[1] = new Point(x, y); 
                curTriangle.kodkodim[2] = new Point(x + 2 * Gova, y); 
                curTriangle.fill = Filled ? true : false;
                curTriangle.size = Size;
                Refresh();

            }
            if (CanDrawHexgaon)
            {
                int x = Math.Min(StartX, e.X);
                int y = Math.Min(StartX, e.Y);
                int width = Math.Max(StartX, e.X) - Math.Min(StartX, e.X);
                int height = Math.Max(StartY, e.Y) - Math.Min(StartY, e.Y);
                int Gova = Math.Abs(width - height);

                curHexagon.kodkodim[0] = new Point(x, y);
                curHexagon.kodkodim[1] = new Point(x, y + Gova);
                curHexagon.kodkodim[2] = new Point(x + Gova, y + 2 * Gova);
                curHexagon.kodkodim[3] = new Point(x + 2 * Gova, y + Gova);
                curHexagon.kodkodim[4] = new Point(x + 2 * Gova, y);
                curHexagon.kodkodim[5] = new Point(x + Gova, y - Gova);
                curHexagon.fill = Filled ? true : false;
                curHexagon.size = Size;
                Refresh();
            }
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            CanDrawLine = false;
            CanDrawSquare = false;
            CanDrawCircle = false;
            CanDrawTriangle = false;
            CanDrawHexgaon = false;
            Refresh();
            if(LinePressed)
            listLine.Add(new Line(curLine.startPoint,curLine.lastPoint,MyPen.Color,Size));
            whatorem.Push("Line");
            if (SquarePressed)
            {
                if(Filled)
                listSquare.Add(new Square(curSquare.startPoint.X, curSquare.startPoint.Y, curSquare.width, curSquare.height, MyPen.Color, Size, true));
                else
                 listSquare.Add(new Square(curSquare.startPoint.X, curSquare.startPoint.Y, curSquare.width, curSquare.height, MyPen.Color, Size, false));
                whatorem.Push("Square");
            }
            if(CirclePressed)
            {
                    listCircle.Add(new Circle(curCircle.startPoint, curCircle.Radius, MyPen.Color, Filled? true:false , Size));
                whatorem.Push("Circle");
            }
            Refresh();
            if (TrianglePressed)
            {
                if (Filled)
                    listTriangle.Add(new Triangle(curTriangle.kodkodim, MyPen.Color, true, Size));
                else
                    listTriangle.Add(new Triangle(curTriangle.kodkodim, MyPen.Color, false, Size));
                whatorem.Push("Triangle");
            }
            Refresh();
            if (HexagonPressed)
            {
                listHexagon.Add(new Hexagon(curHexagon.kodkodim, MyPen.Color, Filled ? true : false, Size));
                whatorem.Push("Hexagon");
            }
            
        }
    }
}
