using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ComputerGraphic2D
{
    class Parabol: Shape // Parabol có dạng y = Ax^2 (A là số thực)
    {
        Point start;
        Point end;
        Point edge1;
        Point edge2;
        float A;
        List<Point> points1 = new List<Point>(); 
        List<Point> points2 = new List<Point>();
        List<Point> points3 = new List<Point>();
        List<Point> points4 = new List<Point>();
        private static int nPar = 0;

        public Parabol(Point Start, Point End)
        {
            start = Start;
            end = End;
            Center.X = (start.X + end.X) / 2;
            Center.Y = start.Y;
            if(start.X < end.X) // edge1.X luôn nhỏ hơn edge2.X
            {
                edge1.X = start.X;
                edge2.X = end.X;
            }
            else
            {
                edge2.X = start.X;
                edge1.X = end.X;
            }
            edge1.Y = end.Y; edge2.Y = end.Y;
            A = (edge1.Y - Center.Y) / ((edge1.X - Center.X) * (edge1.X - Center.X));
            if(A>0) // Parabol hướng lên
            {
                for (int x = 0, y = 0; 2 * A * x <= 1; x++) // Khi vẽ parabol theo x
                {
                    if (x > edge2.X - Center.X) return;
                    points1.Add(new Point(Center.X - x, Center.Y + (int)(A * x * x + 0.5)));
                    points2.Add(new Point(Center.X + x, Center.Y + (int)(A * x * x + 0.5)));
                }
                for (int x = edge2.X - Center.X, y = edge2.Y - Center.Y; 2 * A * x > 1; y--) // vẽ parabol theo y
                {
                    if (y < 0) return;
                    points3.Add(new Point(Center.X - (int)(Math.Sqrt(y / A) + 0.5), Center.Y + y));
                    points4.Add(new Point(Center.X + (int)(Math.Sqrt(y / A) + 0.5), Center.Y + y));
                }
            }
            else // Parabol hướng xuống
            {
                for (int x = 0, y = 0; 2 * A * x >= -1; x++) // Khi vẽ parabol theo x
                {
                    if (x > edge2.X - Center.X) return;
                    points1.Add(new Point(Center.X - x, Center.Y + (int)(A * x * x + 0.5)));
                    points2.Add(new Point(Center.X + x, Center.Y + (int)(A * x * x + 0.5)));
                }
                for (int x = edge2.X - Center.X, y = edge2.Y - Center.Y; 2 * A * x < -1; y++) // vẽ parabol theo y
                {
                    if (y > 0) return;
                    points3.Add(new Point(Center.X - (int)(Math.Sqrt(y / A) + 0.5), Center.Y + y));
                    points4.Add(new Point(Center.X + (int)(Math.Sqrt(y / A) + 0.5), Center.Y + y));
                }
            }
        }

        public override void Draw(Bitmap bitmap)
        {
            Pen pen = new Pen(ForeColor, width);
            Graphics.FromImage(bitmap).DrawCurve(pen, points1.ToArray());
            Graphics.FromImage(bitmap).DrawCurve(pen, points2.ToArray());
            Graphics.FromImage(bitmap).DrawCurve(pen, points3.ToArray());
            Graphics.FromImage(bitmap).DrawCurve(pen, points4.ToArray());
        }

        public override void RegisterAnObject()
        {
            nPar++;
            Name = "Parabol" + nPar.ToString();
        }

        public override bool isSelected(int x, int y)
        {
            return false;
        }
    }
}
