using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Cast_Delegate
{
    public delegate void Calcultion(int a, int b);
    class Program
    {
        public static void Add(int a,int b)
        {
            int c = a + b;
            Console.WriteLine("Addition= "+c);
        }
        public static void Sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Subtraction= " + c);
        }
        public static void Mul (int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Multiplication= " + c);
        }
        public static void div(int a, int b)
        {
            int c = a / b;
            Console.WriteLine("Division= " + c);
        }
        static void Main(string[] args)
        {
            Calcultion c = new Calcultion(Add);
           
            //refernces
            c += Sub;
            c += Mul;
            c -= div;//div method not print
            c(6, 3);
            Console.ReadLine();
        }
    }
}
