using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec4_Methods_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            Console.WriteLine(Addition(5, 8));
            Console.WriteLine(Addition(11, 8));
            Console.WriteLine(Addition(56, 8));

            int myNum1 = PlusMethodInt(8, 5);
            double myNum2 = PlusMethodDouble(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);

            Console.ReadKey();
        }

        //static void Add()
        //{
        //    int a = 20,b=56;
        //    Console.WriteLine("Addition of a and b = "+(a+b));

        //}

        static int Addition(int x, int y)
        {
            return x + y;
        }

        static int PlusMethodInt(int x, int y)
        {
            return x + y;
        }

        static double PlusMethodDouble(double x, double y)
        {
            return x + y;
        }
    }
}
