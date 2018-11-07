using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ComputerGraphic2D
{
    class TextDrawing : Shape
    {
        public string Content;
        public Font font;
        private SizeF Region;
        private static int nText = 0;

        public TextDrawing(Point TopLeft, string content)
        {
            Content = content;
            this.TopLeft = TopLeft;
            font = new Font("Tahoma", 16);
        }

        public override void Draw(Bitmap bitmap)
        {
            if (bStroke)
                Stroke(bitmap);

            TextRegion(bitmap);
            SetTopLeftAndBottomRight();
        }

        private void Stroke(Bitmap bitmap)
        {
            SolidBrush brush = new SolidBrush(ForeColor);
            Graphics.FromImage(bitmap).DrawString(
                            Content,
                            font,
                            brush,
                            TopLeft.X,
                            TopLeft.Y
            );
        }

        private void SetTopLeftAndBottomRight()
        {
            BottomRight = new Point(TopLeft.X + (int)Region.Width, TopLeft.Y + (int)Region.Height);
        }

        public override bool isSelected(int x, int y)
        {
            if (x > TopLeft.X && x < BottomRight.X && y > TopLeft.Y && y < BottomRight.Y)
                return true;
            return false;
        }

        private SizeF TextRegion(Bitmap bitmap)
        {
            return Region = Graphics.FromImage(bitmap).MeasureString(Content, font);
        }

        public override void RegisterAnObject()
        {
            nText++;
            Name = "Text" + nText.ToString();
        }
    }
}
