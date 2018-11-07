using System;
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
        List<Shape> selectedShape = null;
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
            selectedShape = new List<Shape>();
            foreColorPicker1.bindedShape = selectedShape;
            backColorPicker1.bindedShape = selectedShape;
            listLayers.DataSource = shapes; 
            viewport = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private Rectangle getRectangle(Point start, Point end)
        {
            return new Rectangle(start, end);
        }

        public void UpdateViewport()
        {
            viewport = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            for (int i = 0; i < shapes.Count; i++)
                shapes[i].Draw(viewport);
            pictureBox1.Image = viewport;
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
                        selectedShape.Clear();
                        selectedShape.Add(shapes[i]);
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
                    case "Ellipse":
                        Ellipse ellipse = new Ellipse(start, end);
                        addShapesToViewPort(ellipse);
                        break;
                    case "Parallelogram":
                        Parallelogram parallelogram = new Parallelogram(start, end);
                        addShapesToViewPort(parallelogram);
                        break;
                    case "Text":
                        TextBox contentTextbox = new TextBox();
                        contentTextbox.Location = new Point(start.X + pictureBox1.Location.X, start.Y + pictureBox1.Location.Y);
                        this.Controls.Add(contentTextbox);
                        this.ActiveControl = contentTextbox;
                        contentTextbox.BringToFront();
                        contentTextbox.KeyDown += TextToolEditor_KeyDown;
                        contentTextbox.LostFocus += TextToolEditor_LostFocus;
                        break;
                }
            }
        }

        private void TextToolEditor_LostFocus(object sender, EventArgs e)
        {
            this.Controls.Remove((Control)sender);
        }

        private void TextToolEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TextBox textToolEditorTextBox = (TextBox)sender;
                TextDrawing text = new TextDrawing(start, textToolEditorTextBox.Text);
                this.Controls.Remove(textToolEditorTextBox);
                addShapesToViewPort(text);
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
                    case "Parallelogram":
                        Parallelogram parallelogram = new Parallelogram(start, end);
                        drawShapeOnViewPort(parallelogram, viewport_tmp);
                        break;
                    case "Circle":
                        Circle circle = new Circle(start, end);
                        drawShapeOnViewPort(circle, viewport_tmp);
                        break;
                    case "Ellipse":
                        Ellipse ellipse = new Ellipse(start, end);
                        drawShapeOnViewPort(ellipse, viewport_tmp);
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

        private void btnText_Click(object sender, EventArgs e)
        {
            selectedTool = "Text";
        }

        private void listLayers_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedShape.Clear();
            for(int x = 0; x < shapes.Count; x++)
            {
                if (listLayers.GetSelected(x))
                    selectedShape.Add(shapes[x]);
            }

            if (selectedShape.Count > 0)
            {
                viewport_tmp = (Bitmap)viewport.Clone();
                selectIndicator.Select(selectedShape.ToArray());
                selectIndicator.Show(viewport_tmp);
                pictureBox1.Image = viewport_tmp;

                chkFill.Checked = selectedShape[0].bFill;
                foreColorPicker1.changeColor(selectedShape[0].ForeColor);
                backColorPicker1.changeColor(selectedShape[0].BackColor);
            }
            else
                pictureBox1.Image = viewport;
        }

        private void btnParallelogram_Click(object sender, EventArgs e)
        {
            selectedTool = "Parallelogram";
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            selectedTool = "Ellipse";
        private void chkFill_CheckedChanged(object sender, EventArgs e)
        {
            backColorPicker1.Enabled = chkFill.Checked;
            foreach(Shape shape in selectedShape)
            {
                shape.bFill = chkFill.Checked;
                UpdateViewport();
            }
        }
    }
}
