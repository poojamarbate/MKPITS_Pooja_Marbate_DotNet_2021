using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec5_baseClass_constructor_fromDerivedClass
{
    class Program
    {
        //
        static void Main(string[] args)
        {
            ClassB d = new ClassB();

            Console.WriteLine();

            ClassB d1 = new ClassB(10, 20);

            Console.ReadKey();
        }
    }
}
