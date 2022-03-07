using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{
   sealed class Base
    {
       public void Show()
        {
            Console.WriteLine("Method of Base class");
        }
    }
    class Derived
    {
        public void Show1()
        {
            Console.WriteLine("Method of Dervie class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.Show1();
            Console.ReadLine();

        }
    }
}
