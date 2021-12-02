using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec1_Shape_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape s = new Shape();
            //Console.WriteLine(s);

            //Circle c = new Circle();
            //Console.WriteLine(c);

            //Rectangle r = new Rectangle();
            //Console.WriteLine(r);

            //Triangle t = new Triangle();
            //Console.WriteLine(t);

            Shape s = new Shape("Trignometic Shape", " Shape parameters");
            Console.WriteLine(s);

            Circle c = new Circle(7, "Circle", "Radius");
            Console.WriteLine(c);

            Rectangle r = new Rectangle(50, 20, "Rectangle", "legth , Breath ");
            Console.WriteLine(r);

            Triangle t = new Triangle(20, 40, "Triangle", "Base , Height");
            Console.WriteLine(t);
        }
    }
}
