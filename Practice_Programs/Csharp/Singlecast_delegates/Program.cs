using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_delegates
{
    class Program
    {
        public delegate void Calculation(int num1, int num2);
        public static void Addition(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition result is:{0}",result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Addition);
            obj(5, 8);
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
