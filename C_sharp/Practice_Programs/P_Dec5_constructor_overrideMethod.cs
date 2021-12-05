using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec5_Constructor_Override_Method
{
    class Program
    {
        static void Main(string[] args)
        {   
            Derived d1 = new Derived();
            Console.WriteLine();
            Derived d2 = new Derived(25, 35);
            d2.Swap();

            Console.ReadKey();
        }
    }
}
