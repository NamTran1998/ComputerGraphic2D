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
            if (bFill)
                Fill(bitmap);
            if (bStroke)
                Stroke(bitmap);
        }

        private void Stroke(Bitmap bitmap)
        {
            Pen pen = new Pen(ForeColor, width);
            Graphics.FromImage(bitmap).DrawRectangle(pen, TopLeft.X, TopLeft.Y, BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y);
        }

        public void Fill(Bitmap bitmap)
        {
            SolidBrush brush = new SolidBrush(BackColor);
            Graphics.FromImage(bitmap).FillRectangle(brush, TopLeft.X, TopLeft.Y, BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y);
        }

        public override void RegisterAnObject()
        {
            nRect++;
            Name = "Rectangle" + nRect.ToString();
        }

        public override bool isSelected(int x, int y)
        {
            if (y < BottomRight.Y && y > TopLeft.Y)
                if (x < TopLeft.X + 2 && x > TopLeft.X - 2)
                    return true;
            if (y < BottomRight.Y && y > TopLeft.Y)
                if (x < BottomRight.X + 2 && x > BottomRight.X - 2)
                    return true;
            if (x < BottomRight.X && x > TopLeft.X)
                if (y < TopLeft.Y + 2 && y > TopLeft.Y - 2)
                    return true;
            if (x < BottomRight.X && x > TopLeft.X)
                if (y < BottomRight.Y + 2 && y > BottomRight.Y - 2)
                    return true;

            return false;
        }
    }
}
