using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_OR_Conditional_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // tenary operator --( ? : )
            //alternate of if --else
            //syntax:
            //Boolean Expression? 1st statement:2nd statement
            //int a = 20;
            //string b = (a > 30) ? "A is grater" : "A is less";
            //Console.WriteLine(b);
            int a = int.Parse(Console.ReadLine());
            string b = (a >= 18) ? "You are eligible to vote" : "You are not eligible to vote";

            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
