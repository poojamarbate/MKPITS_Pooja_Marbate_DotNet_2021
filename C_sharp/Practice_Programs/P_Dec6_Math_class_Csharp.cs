using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Class_In_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100,y=376;

            Console.WriteLine("Value Of X = "+x+"   Value of Y = "+y);

            Console.WriteLine("Max Number : "+Math.Max(x,y));
            Console.WriteLine("Min Number : "+Math.Min(x,y));
            Console.WriteLine("Square Root of X : "+Math.Sqrt(x));
            Console.WriteLine("Absolute Positive value (-4.7) : "+Math.Abs(-4.7));
            Console.WriteLine("Math.Round(9.99)  : "+Math.Round(9.99));

        }
    }
}
