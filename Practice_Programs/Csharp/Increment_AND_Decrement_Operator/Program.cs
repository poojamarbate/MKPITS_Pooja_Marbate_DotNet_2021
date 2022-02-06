using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increment_AND_Decrement_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   (++) (--)    uninary
             *   incresing or decrement the value  by 1
             */
            int a = 5;
            Console.WriteLine(a++); //Post-increment
            Console.WriteLine(a);

            Console.WriteLine(++a);//pre-increment
            Console.ReadLine();
        }
    }
}
