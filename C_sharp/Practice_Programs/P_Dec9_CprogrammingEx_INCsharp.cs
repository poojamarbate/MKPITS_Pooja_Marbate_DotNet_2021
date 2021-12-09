using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec9_CprogrammingExample2_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\'hello\'");
            //  Console.WriteLine("\n welcome home");.......it already print in new line because of writeline method
            // find Area of rectangle

            int l,b;
            Console.WriteLine("Enter length and breath");
            l = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area = "+(l*b));


            Console.ReadKey();
        }
    }
}
