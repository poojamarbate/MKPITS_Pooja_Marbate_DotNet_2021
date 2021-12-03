using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec3_Inheritance_Multiple
{
    class Point
    {
      protected int x { get; set; }
        public int y { get; set; }
        public Point()
        {
            x = 10;
            y = 20;
        }

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
