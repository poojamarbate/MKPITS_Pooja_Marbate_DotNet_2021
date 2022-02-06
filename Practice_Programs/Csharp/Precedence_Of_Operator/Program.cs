using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Precedence_Of_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8 / 2 - 3 + 2 * 2;
            /*
             *  4-3+2*3
             *  4-3+4
             *  1+4
             *  =5
             */ 
            Console.WriteLine(a);
            Console.ReadLine();
            //highest level ---  () ,/ *,+ -
        }
    }
}
