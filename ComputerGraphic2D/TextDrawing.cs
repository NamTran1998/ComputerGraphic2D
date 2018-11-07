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
        private static int nText = 0;

        public TextDrawing(Point TopLeft, string content)
        {
            Content = content;
            this.TopLeft = TopLeft;
            font = new Font("Tahoma", 16);
        }

        public override void Draw(Bitmap bitmap)
        {

            Graphics.FromImage(bitmap).DrawString(
                Content,
                font,
                Brushes.Black,
                TopLeft.X,
                TopLeft.Y
            );
        }

        public override bool isSelected(int x, int y)
        {
            return false;
        }

        public override void RegisterAnObject()
        {
            nText++;
            Name = "Text" + nText.ToString();
        }
    }
}
