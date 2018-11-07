namespace ComputerGraphic2D
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkStroke = new System.Windows.Forms.CheckBox();
            this.chkFill = new System.Windows.Forms.CheckBox();
            this.foreColorPicker1 = new ComputerGraphic2D.ForeColorPicker();
            this.backColorPicker1 = new ComputerGraphic2D.BackColorPicker();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnParallelogram = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listLayers = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnParabol = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foreColorPicker1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backColorPicker1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkStroke);
            this.panel1.Controls.Add(this.chkFill);
            this.panel1.Controls.Add(this.foreColorPicker1);
            this.panel1.Controls.Add(this.backColorPicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 75);
            this.panel1.TabIndex = 0;
            // 
            // chkStroke
            // 
            this.chkStroke.AutoSize = true;
            this.chkStroke.Location = new System.Drawing.Point(569, 15);
            this.chkStroke.Name = "chkStroke";
            this.chkStroke.Size = new System.Drawing.Size(57, 17);
            this.chkStroke.TabIndex = 3;
            this.chkStroke.Text = "Stroke";
            this.chkStroke.UseVisualStyleBackColor = true;
            this.chkStroke.CheckedChanged += new System.EventHandler(this.chkStroke_CheckedChanged);
            // 
            // chkFill
            // 
            this.chkFill.AutoSize = true;
            this.chkFill.Location = new System.Drawing.Point(569, 38);
            this.chkFill.Name = "chkFill";
            this.chkFill.Size = new System.Drawing.Size(38, 17);
            this.chkFill.TabIndex = 3;
            this.chkFill.Text = "Fill";
            this.chkFill.UseVisualStyleBackColor = true;
            this.chkFill.CheckedChanged += new System.EventHandler(this.chkFill_CheckedChanged);
            // 
            // foreColorPicker1
            // 
            this.foreColorPicker1.Image = ((System.Drawing.Image)(resources.GetObject("foreColorPicker1.Image")));
            this.foreColorPicker1.Location = new System.Drawing.Point(684, 25);
            this.foreColorPicker1.Name = "foreColorPicker1";
            this.foreColorPicker1.Size = new System.Drawing.Size(30, 30);
            this.foreColorPicker1.TabIndex = 2;
            this.foreColorPicker1.TabStop = false;
            // 
            // backColorPicker1
            // 
            this.backColorPicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backColorPicker1.Image = ((System.Drawing.Image)(resources.GetObject("backColorPicker1.Image")));
            this.backColorPicker1.Location = new System.Drawing.Point(637, 25);
            this.backColorPicker1.Name = "backColorPicker1";
            this.backColorPicker1.Size = new System.Drawing.Size(30, 30);
            this.backColorPicker1.TabIndex = 1;
            this.backColorPicker1.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 310);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(12, 64);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(75, 23);
            this.btnCircle.TabIndex = 2;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(12, 35);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(75, 23);
            this.btnRect.TabIndex = 1;
            this.btnRect.Text = "Rectangle";
            this.btnRect.UseVisualStyleBackColor = true;
            this.btnRect.Click += new System.EventHandler(this.btnRect_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(12, 6);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 23);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnParabol);
            this.panel2.Controls.Add(this.btnEllipse);
            this.panel2.Controls.Add(this.btnParallelogram);
            this.panel2.Controls.Add(this.btnSelect);
            this.panel2.Controls.Add(this.btnLine);
            this.panel2.Controls.Add(this.btnText);
            this.panel2.Controls.Add(this.btnRect);
            this.panel2.Controls.Add(this.btnCircle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 360);
            this.panel2.TabIndex = 1;
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(13, 153);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(75, 23);
            this.btnEllipse.TabIndex = 5;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnParallelogram
            // 
            this.btnParallelogram.Location = new System.Drawing.Point(12, 123);
            this.btnParallelogram.Name = "btnParallelogram";
            this.btnParallelogram.Size = new System.Drawing.Size(75, 23);
            this.btnParallelogram.TabIndex = 4;
            this.btnParallelogram.Text = "Parallelogram";
            this.btnParallelogram.UseVisualStyleBackColor = true;
            this.btnParallelogram.Click += new System.EventHandler(this.btnParallelogram_Click);
            // 
            // btnText
            // 
            this.btnText.Location = new System.Drawing.Point(12, 93);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(75, 23);
            this.btnText.TabIndex = 2;
            this.btnText.Text = "Text";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listLayers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(593, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 360);
            this.panel3.TabIndex = 2;
            // 
            // listLayers
            // 
            this.listLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLayers.FormattingEnabled = true;
            this.listLayers.Location = new System.Drawing.Point(0, 0);
            this.listLayers.Name = "listLayers";
            this.listLayers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listLayers.Size = new System.Drawing.Size(168, 360);
            this.listLayers.TabIndex = 0;
            this.listLayers.SelectedValueChanged += new System.EventHandler(this.listLayers_SelectedValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(102, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 360);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnParabol
            // 
            this.btnParabol.Location = new System.Drawing.Point(13, 183);
            this.btnParabol.Name = "btnParabol";
            this.btnParabol.Size = new System.Drawing.Size(75, 23);
            this.btnParabol.TabIndex = 6;
            this.btnParabol.Text = "Parabol";
            this.btnParabol.UseVisualStyleBackColor = true;
            this.btnParabol.Click += new System.EventHandler(this.btnParabol_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(761, 435);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "2D Drawing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foreColorPicker1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backColorPicker1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listLayers;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnParallelogram;
        private System.Windows.Forms.Button btnEllipse;
        private BackColorPicker backColorPicker1;
        private ForeColorPicker foreColorPicker1;
        private System.Windows.Forms.CheckBox chkFill;
        private System.Windows.Forms.CheckBox chkStroke;
        private System.Windows.Forms.Button btnParabol;
    }
}

