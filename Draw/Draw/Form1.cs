using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Figs
        {
            None,
            circle,
            rect,
            wagon,
            train,
            coal,
            sand
        }
        Figs fig = Figs.circle;

        private void Circle_Click(object sender, EventArgs e)
        {
            fig = Figs.circle;
        }

        private void Rec_Click(object sender, EventArgs e)
        {
            fig = Figs.rect;
        }

      

        private void Coal_Click(object sender, EventArgs e)
        {
            fig = Figs.coal;
        }

        private void Sand_Click(object sender, EventArgs e)
        {
            fig = Figs.sand;
        }
        private bool IsInt(string str)
        {
            return Int32.TryParse(str, out int a);
        }
        private void Train_Click(object sender, EventArgs e)
        {
            fig = Figs.train;
        }
        List<Figures> figures = new List<Figures>();

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            if (fig == Figs.circle && IsInt(Radius.Text))
            {
                figures.Add(new MyCircle(x, y, Convert.ToInt32(Radius.Text)));
            }
            if (fig == Figs.rect && IsInt(width.Text) && IsInt(height.Text))
            {
                figures.Add(new MyRectangle(x, y, Convert.ToInt32(width.Text), Convert.ToInt32(height.Text)));
            }
            if (fig == Figs.wagon && IsInt(width.Text) && IsInt(height.Text))
            {
                figures.Add(new MyWagon(x, y, Convert.ToInt32(width.Text), Convert.ToInt32(height.Text)));
            }
            if (fig == Figs.coal && IsInt(width.Text) && IsInt(height.Text))
            {
                figures.Add(new MyWagonCoal(x, y, Convert.ToInt32(width.Text), Convert.ToInt32(height.Text)));
            }
            if (fig == Figs.sand && IsInt(width.Text) && IsInt(height.Text))
            {
                figures.Add(new MyWagonSand(x, y, Convert.ToInt32(width.Text), Convert.ToInt32(height.Text)));
            }
            if (fig == Figs.train && IsInt(width.Text) && IsInt(height.Text) && IsInt(Count.Text))
            {
                figures.Add(new MyTrain(x, y, Convert.ToInt32(width.Text), Convert.ToInt32(height.Text), Convert.ToInt32(Count.Text)));
            }

            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics instrument = panel1.CreateGraphics();
            foreach (Figures figure in figures)
                figure.draw(instrument, a.Color);
        }

        private void Wagon_Click(object sender, EventArgs e)
        {
            fig = Figs.wagon;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            figures = new List<Figures>();
            panel1.Refresh();
        }
        Pen a = new Pen(Color.Black);

        private void Orangered_Click(object sender, EventArgs e)
        {
            a = new Pen(Color.OrangeRed);
        }

        private void Lime_Click(object sender, EventArgs e)
        {
            a = new Pen(Color.Lime);
        }

        private void DarkViolet_Click(object sender, EventArgs e)
        {
            a = new Pen(Color.DarkViolet);
        }
    }
}
