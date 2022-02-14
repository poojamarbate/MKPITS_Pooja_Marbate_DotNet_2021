using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Application_In_Csharp
{
    class Program
    {
        //*,/,+,-
        public static void Addition(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("Addition:"+result);
        }
        public static void Subtration(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtration:" + result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication:" + result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division:" + result);
        }
        static void Main(string[] args)
        {
            //how to create a calculator application
            /*
             * methods
             * decision making statements (if else if)
             * conditional operators
             */
            Console.WriteLine("Enter a first number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("which type of operation you want to perform(+,-,*,/)  ???");
            string op = Console.ReadLine();

            if(op.Equals("+"))//op=="+"
            {
                Program.Addition(num1, num2);
            }

           else if (op.Equals("-"))//op=="+"
            {
                Program.Subtration(num1, num2);
            }

            else if (op.Equals("*"))//op=="+"
            {
                Program.Multiplication(num1, num2);
            }

           else if (op.Equals("/"))//op=="+"
            {
                Program.Division(num1, num2);
            }

            else
            {
                Console.WriteLine("Invalid operator");
            }


            Console.ReadLine();
        }
    }
}
