using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_And_Function_2
{
    class Program
    {
       
        //method return type int
        public static int @Add(int a,int b) //declare
        {
            int result = a + b;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Program.@Add(10, 20)); //calling method

            /* Ram (randam access memeory)
             * two types in ram
             * 1)hip
             * 2)stack
             */ 
            Console.ReadLine();
        }
    }
}
