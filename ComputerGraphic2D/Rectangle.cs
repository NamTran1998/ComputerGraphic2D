using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ComputerGraphic2D
{
    class Rectangle : Shape
    {
        private static int nRect = 0;

        public Rectangle(Point start, Point end)
        {
            SetTopLeftAndBottomRight(start, end);
            CalculateCenter();
        }

        public override void Draw(Bitmap bitmap)
        {
            Graphics.FromImage(bitmap).DrawRectangle(new Pen(Color.Black, 1), TopLeft.X, TopLeft.Y, BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y);
        }

        public override void RegisterAnObject()
        {
            nRect++;
            Name = "Rectangle" + nRect.ToString();
        }

        public override bool isSelected(int x, int y)
        {
            if (x == TopLeft.X && y < BottomRight.Y && y > TopLeft.Y)
                return true;
            if (x == BottomRight.X && y < BottomRight.Y && y > TopLeft.Y)
                return true;
            if (y == TopLeft.Y && x < BottomRight.X && x > TopLeft.X)
                return true;
            if (y == BottomRight.Y && x < BottomRight.X && x > TopLeft.X)
                return true;

            return false;
        }
    }
}
