using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relational_OR_ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //(==,!=,>,<,>=,<=) -----------return true false 
            int a = 30, b = 20;
            //  bool c = a == b;
            //bool c = a != b;
            // bool c = a > b;
            // bool c = a < b;
            bool c = a >= b;
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
