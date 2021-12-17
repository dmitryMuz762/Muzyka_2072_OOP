using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Draw
{
    abstract class Figures
    {
        public int x;
        public int y;

       
        public Figures(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void draw(Graphics instrument, Color a)
        {
            
        }
    }
}
