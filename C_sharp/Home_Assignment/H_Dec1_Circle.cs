using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec1_Shape_inheritance
{
    class Circle:Shape
    {
        public int radius { get; set; }
        public double Area { get; set; }

        

        public Circle()
        {
            radius = 5;
            Area = Math.PI * radius * radius;
            Console.WriteLine("Area of Circle = "+Area);
        }

        public Circle(int radius,string shape_name,string Shape_para):base(shape_name,Shape_para)
        {
            //double Area;
            this.radius = radius;
            Area = Math.PI * radius * radius;
            Console.WriteLine("Area of Circle = " , Area);

        }

        public override string ToString()
        {
            return base.ToString()+" Radius = "+ radius +" Area of circle = "+Area;
        }
    }
}
