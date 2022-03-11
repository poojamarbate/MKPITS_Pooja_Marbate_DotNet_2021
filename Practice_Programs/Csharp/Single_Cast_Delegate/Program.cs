using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Cast_Delegate
{
    public delegate void Calculation(int num1, int num2);
    class Program
    {
        public static void Addition(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Addition result:{0}",result);
        }
        static void Main(string[] args)
        {
            Calculation c = new Calculation(Addition);
            c(100, 50);
            Console.ReadLine();
        }
    }
}
