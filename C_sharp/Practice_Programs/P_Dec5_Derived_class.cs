using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec5_MethodOveriding_wihout_Virtual
{
    class Derived:base_Class
    {
        new public void Show()
        {
            Console.WriteLine("Derived Class");
        }
    }
}
