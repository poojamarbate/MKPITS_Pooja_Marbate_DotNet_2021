using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squareofarea_andPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareheight, area, perimeter;
            Console.WriteLine("enter the height of square: ");
            squareheight = Convert.ToInt32(Console.ReadLine());

            area = squareheight * squareheight;
            perimeter = 4 * squareheight;

            Console.WriteLine("Area:{0}\nPerimeter:{1}",area,perimeter);
            Console.ReadLine();
        }
    }
}
