using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ComputerGraphic2D
{
    abstract class Shape
    {
        public Point Center;
        public Point TopLeft, BottomRight;
        public Color BackColor = Color.White;
        public Color ForeColor = Color.Black;
        public bool bFill = false;
        public int width = 1;

        public string Name { get; set; }
        public Shape()
        {
            //Do nothing
        }

        public abstract void Draw(Bitmap bitmap);

        public override string ToString()
        {
            return Name;
        }

        public abstract void RegisterAnObject();

        protected void CalculateCenter()
        {
            Center.X = (TopLeft.X + BottomRight.X) / 2;
            Center.Y = (TopLeft.Y + BottomRight.Y) / 2;
        }

        // use MinX, MinY, MaxX, MaxY to set TopLeft and BottomRight from 2 Points
        protected virtual void SetTopLeftAndBottomRight(Point Start, Point End)
        {
            TopLeft.X = Start.X < End.X ? Start.X : End.X;
            TopLeft.Y = Start.Y < End.Y ? Start.Y : End.Y;
            BottomRight.X = Start.X < End.X ? End.X : Start.X;
            BottomRight.Y = Start.Y < End.Y ? End.Y : Start.Y;
        }

        public abstract bool isSelected(int x, int y);
    }
}
