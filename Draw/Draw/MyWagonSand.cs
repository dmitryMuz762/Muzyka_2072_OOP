using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Draw
{
    class MyWagonSand : MyWagon
    {
        Point p1;
        Point p2;
        Point p3;
        public MyWagonSand(int x, int y, int width, int height) :
            base(x, y + 2 * height / 10, width, 6 * height / 10)
        {
            p1 = new Point(x - width / 2, y - height / 10);
            p2 = new Point(x + width / 2, y - height / 10);
            p3 = new Point(x, y - height / 2);
        }
        public override void draw(Graphics instrument, Color a)
        {
            base.draw(instrument, a);
            Point[] points = { p1, p2, p3 };
            instrument.FillPolygon(Brushes.Yellow, points);
        }
    }
}
