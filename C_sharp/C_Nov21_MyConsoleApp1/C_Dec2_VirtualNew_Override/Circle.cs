using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec2_VirtualNew_Override
{
    class Circle:Shape
    {
        public int radius { get; set; }
       
        //public override void Area()
        //{
        //    Console.WriteLine("Area of circle = "+Math.PI*radius*radius);
        //}
        public new void Area()
        {
            Console.WriteLine("Area of circle = " + Math.PI * radius * radius);
        }
        public Circle()
        {
            radius = 3;
        }
    }
}
