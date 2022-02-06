using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //check range
            Console.WriteLine(int.MaxValue); //property
            Console.WriteLine(int.MinValue);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(byte.MaxValue);




            int a = 78;
            int b = 98;
            bool c = a < b;
            Console.WriteLine(c);



            float num1 = 23.369f;
            double num2 = 567.6543d;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.ReadLine();
        }
    }
}
