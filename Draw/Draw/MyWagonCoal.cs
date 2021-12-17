using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Draw
{
    class MyWagonCoal : MyWagon
    {
        MyRectangle coal;
        public MyWagonCoal(int x, int y, int width, int height) :
            base(x, y + 2 * height / 10, width, 6 * height / 10)
        {
            coal = new MyRectangle(x, y - 3 * height / 10, 8 * width / 10, 4 * height / 10);
        }
        public override void draw(Graphics instrument, Color a)
        {
            base.draw(instrument, a);
            coal.draw(instrument, a);
        }
    }
}
