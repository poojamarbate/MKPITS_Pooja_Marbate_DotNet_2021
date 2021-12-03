using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec3_AbstractClass_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shape s = new Shape(); no object abstract class
            //Circle c = new Circle();//instance of circle
            //c.Area();
            //c.ShowColor();

            //Shape s = new Circle();
            //s.Area();

            Shape[] shapes = new Shape[4];
            shapes[0] = new Circle();
            shapes[1] = new Rectangle(12, 24);
            shapes[2] = new Rectangle(100, 25);
            shapes[3] = new Rectangle(45, 60);

            foreach(Shape s in shapes)
            {
                s.Area();
            }

            Console.ReadKey();
        
        }
       
    }
}
