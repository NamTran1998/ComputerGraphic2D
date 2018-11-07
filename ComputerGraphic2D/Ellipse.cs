using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ComputerGraphic2D
{
    class Ellipse: Shape
    {
        private int A,B;
        private static int nEllipse = 0;

        public Ellipse(Point center, int a, int b)
        {
            Center = center;
            A = a; B = b;

            TopLeft.X = Center.X - A;
            TopLeft.Y = Center.Y - B;
            BottomRight.X = Center.X - A;
            BottomRight.Y = Center.Y - B;
        }

        public Ellipse(Point start, Point end)
        {
            SetTopLeftAndBottomRight(start, end);

            A = (BottomRight.X - TopLeft.X) / 2;
            B = (BottomRight.Y - TopLeft.Y) / 2;
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
            Graphics.FromImage(bitmap).DrawEllipse(pen, TopLeft.X, TopLeft.Y, A * 2, B * 2);
        }

        public void Fill(Bitmap bitmap)
        {
            SolidBrush brush = new SolidBrush(BackColor);
            Graphics.FromImage(bitmap).FillEllipse(brush, TopLeft.X, TopLeft.Y, A * 2, B * 2);
        }

        public override void RegisterAnObject()
        {
            nEllipse++;
            Name = "Ellipse" + nEllipse.ToString();
        }

        public override bool isSelected(int x, int y)
        {
            return false;
        }

        
    }
}
