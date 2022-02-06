using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA_TYPE_CONVERSION
{
    class Program
    {
        static void Main(string[] args)
        {
          //float a = 20.2345f;
            // int b = a;//implicit data type conversion
            // int b = (int)a;//explicit conversion
          //  int b = Convert.ToInt32(a);
            //Console.WriteLine(b);

            //string num1 = "67";
           // string num2 = "68";
            //int c = Convert.ToInt32(num1) + Convert.ToInt32(b);
           // Console.WriteLine(c);


            Console.WriteLine("Enter first number!!!!!");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number!!!!!");
            float b = float.Parse(Console.ReadLine());

            float c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();


        }
    }
}
