using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ComputerGraphic2D
{
    class Line : Shape
    {
        Point start;
        Point end;
        private static int nLine = 0;

        public Line(Point Start, Point End)
        {
            start = Start;
            end = End;

            SetTopLeftAndBottomRight(start, end);
            CalculateCenter();
        }        

        public override void Draw(Bitmap bitmap)
        {
            Graphics.FromImage(bitmap).DrawLine(new Pen(Color.Black, 1), start, end);
        }

        public override void RegisterAnObject()
        {
            nLine++;
            Name = "Line" + nLine.ToString();
        }

        public override bool isSelected(int x, int y)
        {
            return false;
        }
    }
}
