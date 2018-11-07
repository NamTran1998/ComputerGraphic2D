using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ComputerGraphic2D
{
    class Parallelogram: Shape
    {
        private static int nParall = 0;
        public Point[] pointArray = new Point[4];


        public Parallelogram(Point start, Point end)
        {
            // Đường chéo góc hướng xuống
            if ((start.X - end.X) * (start.Y - end.Y) > 0) 
            {
                if(start.X > end.X) // start.X luôn nhỏ hơn end.X
                {
                    Point temp = start;
                    start = end;
                    end = temp;
                }

                // SetTopLeftAndBottomRight
                TopLeft.X = start.X; TopLeft.Y = start.Y;
                BottomRight.X = end.X; BottomRight.Y = end.Y;

                pointArray[0] = start;
                pointArray[2] = end;
                Center.X = (pointArray[0].X + pointArray[2].X) / 2;
                Center.Y = (pointArray[0].Y + pointArray[2].Y) / 2;
                pointArray[1].X = pointArray[0].X + 2 * (pointArray[2].X - pointArray[0].X) / 3;
                pointArray[1].Y = pointArray[0].Y;
                pointArray[3].X = 2 * Center.X - pointArray[1].X;
                pointArray[3].Y = pointArray[2].Y;
            }
            // Đường chéo hướng lên
            else
            {
                if(start.X > end.X) // start.X luôn nhỏ hơn end.X
                {
                    Point temp = start;
                    start = end;
                    end = temp;
                }

                // SetTopLeftAndBottomRight
                TopLeft.X = start.X; TopLeft.Y = end.Y;
                BottomRight.X = end.X; BottomRight.Y = start.Y;

                pointArray[3] = start;
                pointArray[1] = end;
                Center.X = (pointArray[1].X + pointArray[3].X) / 2;
                Center.Y = (pointArray[1].Y + pointArray[3].Y) / 2;
                pointArray[0].X = pointArray[1].X - 2 * (pointArray[1].X - pointArray[3].X) / 3;
                pointArray[0].Y = pointArray[1].Y;
                pointArray[2].X = 2 * Center.X - pointArray[0].X;
                pointArray[2].Y = pointArray[3].Y;
            }
        }

        public override void Draw(Bitmap bitmap)
        {
            Graphics.FromImage(bitmap).DrawPolygon(new Pen(Color.Black, 1),pointArray);
        }
        public override void RegisterAnObject()
        {
            nParall++;
            Name = "Parallelogram" + nParall.ToString();
        }

        public override bool isSelected(int x, int y)
        {
            
            return false;
        }
    }
}
