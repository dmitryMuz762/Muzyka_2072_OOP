using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Draw
{
    class MyCircle : Figures
    {
        public int rad;

        public MyCircle(int x, int y, int rad) : base(x, y)
        {

            this.rad = rad;

        }
        public override void draw(Graphics instrument, Color a)
        {
            instrument.DrawEllipse(new Pen(a), x - rad, y - rad, rad * 2, rad * 2);
        }
    }
}
