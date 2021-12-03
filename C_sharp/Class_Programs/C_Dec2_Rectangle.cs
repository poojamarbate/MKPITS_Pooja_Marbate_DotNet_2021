using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec2_VirtualNew_Override
{
    class Rectangle:Shape
    {
     public int L { get; set; }
        public int B { get; set; }
        public Rectangle()
        {
            L = 10;
            B = 2;
        }
        public new void Area()
        {
            Console.WriteLine("Area of Rectangle =  "+L*B);
        }
    }
}
