using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmatic_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            //arithmatic operators is binary operator bez they work with two operands
            // (+ ,- , /,*,% )-------arithamatic operator

            int a = 10, b = 5,c,d,e,f,g;
            c = a + b;
            d = a - b;
            e = a / b;
            f = a * b;
            g=a % b; //modulus =remanider
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.ReadLine();

        }
    }
}
