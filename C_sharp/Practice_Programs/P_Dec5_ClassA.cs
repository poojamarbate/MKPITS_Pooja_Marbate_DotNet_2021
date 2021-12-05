using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec5_baseClass_constructor_fromDerivedClass
{
    public class ClassA
    {
        int n1, n2;
        public ClassA()
        {
            Console.WriteLine("default constructor");     
        }
        public ClassA(int i, int j)
        {
            n1 = i;
            n2 = j;
            Console.WriteLine("Parameterized Constructor Invoked");
            Console.WriteLine("values are: "+n1+" and "+n2);
        }
    }
}
