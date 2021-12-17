using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Draw
{
    class MyWagon : MyRectangle
    {
        public int width;
        public int height;
        MyCircle wheel1;
        MyCircle wheel2;
        public MyWagon(int x, int y, int width, int height) : base(x, y - 2 * height / 10, width, 3 * height / 5)
        {
            this.width = width;
            this.height = height;

            wheel1 = new MyCircle(x - width / 4, y + height / 3, height / 6);
            wheel2 = new MyCircle(x + width / 4, y + height / 3, height / 6);
        }
        public override void draw(Graphics instrument, Color a)
        {
            base.draw(instrument, a);
            wheel1.draw(instrument, a);
            wheel2.draw(instrument, a);
        }

    }
}
