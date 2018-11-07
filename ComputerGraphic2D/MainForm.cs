﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGraphic2D
{
    public partial class MainForm : Form
    {
        Bitmap viewport;
        Bitmap viewport_tmp;
        bool bDrag = false;
        Point start;
        Point end;
        BindingList<Shape> shapes;
        Shape selectedShape = null;
        string selectedTool = "Line";
        SelectIndicator selectIndicator = new SelectIndicator();

        private void addShapesToViewPort(Shape shape)
        {            
            shape.RegisterAnObject();
            shapes.Add(shape);
            drawShapeOnViewPort(shape, viewport);
        }

        private void drawShapeOnViewPort(Shape shape, Bitmap vp)
        {
            shape.Draw(vp);
            pictureBox1.Image = vp;
        }

        public MainForm()
        {
            InitializeComponent();
            shapes = new BindingList<Shape>();
            listLayers.DataSource = shapes; 
            viewport = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private Rectangle getRectangle(Point start, Point end)
        {
            return new Rectangle(start, end);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(selectedTool != "Select")
            {
                bDrag = true;
                start = e.Location;
            }
            else
            {
                bool any = false;
                for(int i = shapes.Count - 1;i >= 0; i--)
                {
                    if (shapes[i].isSelected(e.X, e.Y))
                    {
                        selectIndicator.Select(shapes[i]);
                        any = true;
                        break;
                    }
                }

                if (any)
                {
                    viewport_tmp = (Bitmap)viewport.Clone();
                    selectIndicator.Show(viewport_tmp);
                    pictureBox1.Image = viewport_tmp;
                }
                else
                    pictureBox1.Image = viewport;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (bDrag)
            {
                bDrag = false;
                end = e.Location;

                switch (selectedTool)
                {
                    case "Line":
                        Line line = new Line(start, end);
                        addShapesToViewPort(line);
                        break;
                    case "Rectangle":
                        Rectangle rectangle = getRectangle(start, end);
                        addShapesToViewPort(rectangle);
                        break;
                    case "Circle":
                        Circle circle = new Circle(start, end);
                        addShapesToViewPort(circle);
                        break;
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bDrag)
            {
                end = e.Location;
                viewport_tmp = (Bitmap)viewport.Clone();

                switch (selectedTool)
                {
                    case "Line":
                        Line line = new Line(start, end);
                        drawShapeOnViewPort(line, viewport_tmp);
                        break;
                    case "Rectangle":
                        Rectangle rectangle = getRectangle(start, end);
                        drawShapeOnViewPort(rectangle, viewport_tmp);
                        break;
                    case "Circle":
                        Circle circle = new Circle(start, end);
                        drawShapeOnViewPort(circle, viewport_tmp);
                        break;
                }
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            selectedTool = "Line";
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            selectedTool = "Rectangle";
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            selectedTool = "Circle";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            selectedTool = "Select";
        }
    }
}