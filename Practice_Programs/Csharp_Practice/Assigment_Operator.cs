using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * there are two types of assigment operator
             * simple opeator =
             * compound operator (combination of simple operator or arithmatic operator)
             *    +=
             *    -=
             *    *=
             *    /=
             *    %=
             */

            int a = 10;
            //a += 1;
            //a -= 1;
            //a *= 2;
            //a /= 5;
            a %= 5;
            Console.WriteLine(a);//a=a+1
            Console.ReadLine();
            
        }
    }
}
