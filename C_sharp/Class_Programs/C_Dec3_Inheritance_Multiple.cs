using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec3_Inheritance_Multiple
{
    class Program
    {
        //access modifiers are used to achieve Encapsualtion
        //private,protected,public,internal
        static void Main(string[] args)
        {
            Point p = new Point();
            //p.x = 12;  as it is protected 

            Circle c = new Circle();
            //c.R as it is protected 
            Console.WriteLine("Area of Circle = "+c.Area());
            Cylinder cy = new Cylinder();
            Console.WriteLine("Area of Cylinder = "+cy.Area());

            Cylinder c1 = new Cylinder(25, 12, 0, 0);
            Console.WriteLine("Surface Area = "+c1.Area());

            Circle s = c1;
            Console.WriteLine("Base Circle Area = "+s.Area());

            Console.ReadKey();

        }
    }
}
