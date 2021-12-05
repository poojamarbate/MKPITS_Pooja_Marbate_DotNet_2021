using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec5_methodOverriding_usingVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            baseClass obj;
            obj = new baseClass();
            obj.Show();
            obj = new Derived();
            obj.Show();
            Console.ReadKey();

        }
    }
}
