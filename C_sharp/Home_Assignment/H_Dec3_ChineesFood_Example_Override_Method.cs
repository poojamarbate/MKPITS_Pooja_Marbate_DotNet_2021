using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec3_ChineesFood_Example_Override_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ChineeseFood c = new ChineeseFood();
            c.Taste();

            Rice r = new Rice();
            r.Taste();

            Manchurian m = new Manchurian();
            m.Taste();

            Noodles n = new Noodles();
            n.Taste();


            Console.ReadKey();
        }
    }
}
