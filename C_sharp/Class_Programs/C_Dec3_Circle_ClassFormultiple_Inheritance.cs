using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec3_Inheritance_Multiple
{//this is an example of multi level inheritance
    class Circle:Point
    {
        protected int Radius { get; set; }

        public Circle()
        {
            Radius = 10;   
        }

        public Circle(int radius,int x,int y):base(x,y)
        {
            Radius = radius;

        }
        public virtual double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
