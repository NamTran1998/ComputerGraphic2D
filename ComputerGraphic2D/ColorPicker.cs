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
            
        }

        private void ColorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
        }
    }
}
