using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates1
{
    public delegate void Calculation(int num1, int num2);
    class Program
    {
        public static void Addition(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition result is :{0}",result);
        }
        public static void Subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("Subtraction result is :{0}", result);
        }
        public static void Division(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine("Division result is :{0}", result);
        }
        public static void Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("Multiplication result is :{0}", result);
        }
        static void Main(string[] args)
        {
            Calculation cal = new Calculation(Addition);
            cal += Subtraction;
            cal += Multiplication;
            cal -= Division;
            cal(150, 100);//150 result
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
