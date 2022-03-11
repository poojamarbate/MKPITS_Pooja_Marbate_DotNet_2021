using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Function_csharp
{
    public delegate int Mydelegate(int num);
    class Program
    {

        /* anonymous:no name
         * always use with delegates
         * signtaure of method and delegate will be same 
         * no name only Body in anonymous function
         * 
         * 
         * return type of delegate and anonymous are same
         * no need to use access modifier
         * its not static and instance
         * 
         * 
         * 
         * Advantagess::less typing work
                      :: code volume less
                      
        limitations: it can not conatin go,breaK,CONTINUE
                   :ref or out parameter not use


      Point to remember:anomous method can be define using delegate keyword.
                       :must to asign delegates.
                       :can be pass as a parameter.
                           
                       


         */

        //public static void Mydele(int a)
        //{
        //    a += 10;
        //    Console.WriteLine(a);
        //}
        static void Main(string[] args)
        {
            Mydelegate m = delegate (int a)
            {
                //anomous method 
                a += 10;
                return a;
            };
            Console.WriteLine(m(5));
            Console.ReadLine();
        }
    }
}
