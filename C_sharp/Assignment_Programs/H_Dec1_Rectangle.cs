using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec1_Shape_inheritance
{
    class Rectangle:Shape
    {
        public int length { get; set; }

        public int breath { get; set; }

        public int Area { get; set; }

        public Rectangle()
        {
            
                length = 4;
                breath = 3;
            Area = length * breath;
        }

        public Rectangle(int length,int breath,string Shape_name,string Shape_para):base(Shape_name,Shape_para)
        {
            //int Area;
            this.length = length;
            this.breath = breath;
           Area = length * breath;
            Console.WriteLine("Area of Rectangle = "+Area);
        }
        public override string ToString()
        {
            return base.ToString()+" lenghth= "+length+" breath = "+breath+" Area of Rectangle = "+Area;
        }
    }
}
