using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programto_ComputeQuotientand_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int dividend = 50,divisor=8;
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("dividend:{0} divisor:{1}",dividend,divisor);
            Console.WriteLine("Quotient= "+quotient);
            Console.WriteLine("Remainder= "+remainder);
            Console.ReadLine();
        }
    }
}
