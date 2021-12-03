using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec3_AbstractClass_Interface
{
    class Rectangle:Shape
    {
        public int L { get; set; }
        public int B { get; set; }

        public Rectangle()
        {
            L = 20;
            B = 10;
        }

        public Rectangle(int l,int b)
        {
            L = l;
            B = b;

        }

        public override void Area()
        {
            Console.WriteLine("Area of rectangle = "+L*B);
        }

    }
}
