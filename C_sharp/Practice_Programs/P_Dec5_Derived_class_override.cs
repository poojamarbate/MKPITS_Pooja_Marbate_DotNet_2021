using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec5_methodOverriding_usingVirtual
{
    class Derived:baseClass
    {
        public override void Show()
        {
            Console.WriteLine("Derived class");
        }
    }
}
