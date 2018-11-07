using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ComputerGraphic2D
{
    class SelectIndicator
    {
        List<Shape> SelectedShapes;
        public SelectIndicator()
        {
            SelectedShapes = new List<Shape>();
        }

        public void Select(Shape shape)
        {
            ClearSelected();
            SelectedShapes.Add(shape);
        }

        public void Select(Shape[] shapes)
        {
            ClearSelected();
            SelectedShapes.AddRange(shapes);
        }

        private void ClearSelected()
        {
            SelectedShapes.Clear();
        }

        public void Show(Bitmap bitmap)
        {
            if (SelectedShapes.Count == 0)
                return;

            int xmin, xmax, ymin, ymax;
            GetTopLeftAndBottomRight(out xmin, out xmax, out ymin, out ymax);

            int r = 2;
            Circle[] controls =
            {                
                new Circle(new Point(xmin, ymin), r),
                new Circle(new Point(xmin, ymax), r),
                new Circle(new Point(xmax, ymin), r),
                new Circle(new Point(xmax, ymax), r)
            };

            Rectangle rectangle = new Rectangle(new Point(xmin, ymin), new Point(xmax, ymax));
            rectangle.strokeStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            rectangle.Draw(bitmap);

            for (int i = 0; i < 4; i++)
            {
                controls[i].Fill(bitmap);
                controls[i].Draw(bitmap);
            }
        }

        private void GetTopLeftAndBottomRight(out int xmin, out int xmax, out int ymin, out int ymax)
        {
            xmin = SelectedShapes[0].TopLeft.X;
            ymin = SelectedShapes[0].TopLeft.Y;
            xmax = SelectedShapes[0].BottomRight.X;
            ymax = SelectedShapes[0].BottomRight.Y;

            for (int i = 1; i < SelectedShapes.Count; i++)
            {
                if (SelectedShapes[i].TopLeft.X < xmin)
                    xmin = SelectedShapes[i].TopLeft.X;
                if (SelectedShapes[i].TopLeft.Y < ymin)
                    ymin = SelectedShapes[i].TopLeft.Y;
                if (SelectedShapes[i].BottomRight.X > xmax)
                    xmax = SelectedShapes[i].BottomRight.X;
                if (SelectedShapes[i].BottomRight.Y > ymax)
                    ymax = SelectedShapes[i].BottomRight.Y;
            }
        }
    }
}
