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
        public Point TopRight, BottomLeft;

        public Parallelogram(Point topLeft, Point topRight, Point bottomRight)
        {
            SetTopLeftAndBottomRight(topLeft, bottomRight);
            TopRight = topRight;
            BottomLeft.X = 2 * Center.X - TopRight.X;
            BottomLeft.Y = 2 * Center.X - TopRight.Y;
            CalculateCenter();
        }

        public override void Draw(Bitmap bitmap)
        {
            Point[] pointArray = new Point[4];
            pointArray[0] = TopLeft;
            pointArray[1] = TopRight;
            pointArray[2] = BottomRight;
            pointArray[3] = BottomLeft;
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
