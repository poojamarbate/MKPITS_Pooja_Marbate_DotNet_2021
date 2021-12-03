using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec3_AbstractClass_Interface
{//concrete class circle
    class Circle:Shape
    {
        public int Radius { get; set; }

        public Circle()
        {
            Radius = 10;
        }
        //abstract method is overriden in this class . Area()

        public override void Area()
        {
            Console.WriteLine("Area of Circle = "+Math.PI*Radius*Radius);
        }
    }
}
