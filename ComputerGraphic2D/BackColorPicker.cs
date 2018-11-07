using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ComputerGraphic2D
{
    class BackColorPicker : PictureBox
    {
        public Color pickedColor;
        public List<Shape> bindedShape = new List<Shape>();

        public BackColorPicker(Color color)
        {
            Size = new Size(30, 30);
            pickedColor = color;
            viewColor();
            this.Click += ColorPicker_Click;
        }

        public BackColorPicker()
        {
            Size = new Size(30, 30);
            pickedColor = Color.White;
            viewColor();
            this.Click += ColorPicker_Click;
        }

        private void viewColor()
        {
            Bitmap bitmap = new Bitmap(30, 30);
            SolidBrush brush = new SolidBrush(pickedColor);
            Graphics.FromImage(bitmap).FillRectangle(brush, 0, 0, 30, 30);
            this.Image = bitmap;
        }

        public void changeColor(Color color)
        {
            pickedColor = color;
            viewColor();
        }

        private void ColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                pickedColor = colorDialog.Color;
                viewColor();
                if (bindedShape.Count > 0)
                    for(int i=0;i<bindedShape.Count;i++)
                        bindedShape[i].BackColor = pickedColor;
                ((MainForm)this.Parent.Parent).UpdateViewport();
            }
        }
    }
}
