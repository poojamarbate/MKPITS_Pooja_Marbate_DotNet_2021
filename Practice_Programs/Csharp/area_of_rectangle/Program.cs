using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_of_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, b, area;

            Console.WriteLine("enter length of rectangle: ");
            l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter breath of rectangle ");
            b = Convert.ToInt32(Console.ReadLine());

            area = l * b;
            Console.WriteLine("area of rectangle: "+area);

            Console.ReadLine();
        }
    }
}
