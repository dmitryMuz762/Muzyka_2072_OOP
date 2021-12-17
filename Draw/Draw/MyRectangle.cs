using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Draw
{
    class MyRectangle : Figures
    {
        int width, height;

        public MyRectangle(int x, int y, int width, int height) : base(x, y)
        {

            this.width = width;
            this.height = height;
        }
        public override void draw(Graphics instrument, Color a)
        {
            instrument.DrawRectangle(new Pen(a), x - width / 2, y - height / 2, width, height);

        }


    }


}
