﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ComputerGraphic2D
{
    class Circle : Shape
    {
        private int Radius;
        private static int nCircle = 0;

        public Circle(Point center, int radius)
        {
            Center = center;
            Radius = radius;

            TopLeft.X = Center.X - Radius;
            TopLeft.Y = Center.Y - Radius;
            BottomRight.X = Center.X - Radius;
            BottomRight.Y = Center.Y - Radius;
        }

        public Circle(Point start, Point end)
        {
            // Create a square that contain the Circle
            SetTopLeftAndBottomRight(start, end);

            Radius = (BottomRight.X - TopLeft.X) / 2;
            CalculateCenter();
        }

        public override void Draw(Bitmap bitmap)
        {
            Graphics.FromImage(bitmap).DrawEllipse(new Pen(Color.Black, 1), TopLeft.X, TopLeft.Y, Radius * 2, Radius * 2);
        }

        public void Fill(Bitmap bitmap)
        {
            Graphics.FromImage(bitmap).FillEllipse(Brushes.White, TopLeft.X, TopLeft.Y, Radius * 2, Radius * 2);
        }

        public override void RegisterAnObject()
        {
            nCircle++;
            Name = "Circle" + nCircle.ToString();
        }

        public override bool isSelected(int x, int y)
        {
            //TODO: finish this function
            return false;
        }

        protected override void SetTopLeftAndBottomRight(Point Start, Point End)
        {
            Point d = new Point(End.X - Start.X, End.Y - Start.Y);
            int absDx = d.X > 0 ? d.X : -d.X;
            int absDy = d.Y > 0 ? d.Y : -d.Y;
            int minD = absDx < absDy ? absDx : absDy;

            // From left to right
            if(d.X > 0)
            {
                TopLeft.X = Start.X;
                BottomRight.X = TopLeft.X + minD;
            }
            else
            {
                BottomRight.X = Start.X;
                TopLeft.X = BottomRight.X - minD;
            }

            // From top to bottom
            if(d.Y > 0)
            {
                TopLeft.Y = Start.Y;
                BottomRight.Y = TopLeft.Y + minD;
            }
            else
            {
                BottomRight.Y = Start.Y;
                TopLeft.Y = BottomRight.Y - minD;
            }
        }
    }
}