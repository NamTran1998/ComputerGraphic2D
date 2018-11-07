using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ComputerGraphic2D
{
    class ColorPicker : PictureBox
    {
        public Color pickedColor;

        public ColorPicker(Color color)
        {
            Size = new Size(30, 30);
            pickedColor = color;
            this.Click += ColorPicker_Click;
            viewColor();
        }

        public ColorPicker()
        {
            Size = new Size(30, 30);
            pickedColor = Color.White;
            this.Click += ColorPicker_Click;
            viewColor();
        }

        private void viewColor()
        {
            Bitmap bitmap = new Bitmap(30, 30);
            SolidBrush brush = new SolidBrush(pickedColor);
            Graphics.FromImage(bitmap).FillRectangle(brush, 0, 0, 30, 30);
        }

        private void ColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
        }
    }
}
