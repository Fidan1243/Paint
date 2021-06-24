using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        IFactory FigureFactory { get; set; }
        public Form1()
        {
            InitializeComponent();
            List<string> figures = new List<string> { "rectangle", "triangle", "circle" };
            FigureComboBox.Items.AddRange(figures.ToArray());
            FigureComboBox.SelectedIndex = 0;
        }
        List<IFigure> Figures = new List<IFigure>();
        private void FigureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = FigureComboBox.SelectedItem.ToString();
            if (item == "triangle")
            {
                FigureFactory = new TriangleFact();
            }
            else if (item == "circle")
            {
                FigureFactory = new CircleFact();
            }
            else if (item == "rectangle")
            {
                FigureFactory = new RectangleFact();
            }
        }
        interface IFigure
        {
            Point Point { get; set; }
            Size Size { get; set; }
            Color Color { get; set; }
            bool IsFilled { get; set; }
        }
        class Rectangle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
            public bool IsFilled { get; set; }
        }
        class Circle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
            public bool IsFilled { get; set; }
        }
        class Triangle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
            public bool IsFilled { get; set; }
        }
        interface IFactory
        {
            IFigure GetFigure();
        }
        class CircleFact : IFactory
        {
            public IFigure GetFigure()
            {
                return new Circle();
            }
        }
        class RectangleFact : IFactory
        {
            public IFigure GetFigure()
            {
                return new Rectangle();
            }
        }
        class TriangleFact : IFactory
        {
            public IFigure GetFigure()
            {
                return new Triangle();
            }
        }
        public Color FigureColor { get; set; }

        private void colorbtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (FigureFactory.GetFigure() is Rectangle rect)
            {
                rect.Color = FigureColor;
                rect.Point = e.Location;
                
                if (fillbtn.Checked)
                {
                    rect.IsFilled = true;
                }
                else
                {
                    rect.IsFilled = false;
                }
                Figures.Add(rect);
            }
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(FigureColor,3);
            SolidBrush brush = new SolidBrush(FigureColor);
            using(var a = e.Graphics)
            {
                foreach (var item in Figures)
                {
                    if (item is Rectangle rect)
                    {
                        if (rect.IsFilled)
                        {
                            a.FillRectangle(brush, rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);
                        }
                        else
                        {
                            a.DrawRectangle(pen, rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);
                        }
                    }
                }
            }
        }

        private void colorbtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                FigureColor = colorDialog1.Color;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (FigureFactory.GetFigure() is Rectangle rect)
            {
                rect.Size = new Size(e.X - rect.Point.X, e.Y - rect.Point.Y);
            }
            this.Refresh();
        }
    }
}
