using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2022;
            //boxing
            object obj = num;

            //unboxing 
            int i = (int)obj;

            //value of num to be change 
            num = 100;
            Console.WriteLine("value-type of num is:{0}",num);
            Console.WriteLine("object -type value of obj is:{0}",obj);
            Console.WriteLine("values of i : "+i);

            
            Console.ReadKey();

        }
    }
}
