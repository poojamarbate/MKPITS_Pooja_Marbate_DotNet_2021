using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec1_Shape_inheritance
{
    class Triangle:Shape
    {
        public int Tri_base { get; set; }

        public int Height { get; set; }

        public double Area { get; set; }

        public Triangle()
        {
            Tri_base = 10;
            Height = 20;
            Area = 0.5 * 10 * 20;
        }
        public Triangle(int Tri_base,int Height,string Shape_name,string Shape_para):base(Shape_name,Shape_para)
        {
            this.Tri_base = Tri_base;
            this.Height = Height;
            Area = 0.5 * Tri_base * Height;
            Console.WriteLine("Area of Triangle = "+Area);

        }

        public override string ToString()
        {
            return base.ToString()+" Base = "+Tri_base+" Height = "+Height+" Area of Triangle = "+Area;
        }
    }
}
