using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_in_inheritance
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("This is a constructor of Base class");
        }
        //parameterzied constructor
        public Base(string message)
        {
            Console.WriteLine(message);
        }
    }
    class Derived:Base
    {
        public Derived():base("Hello C sharp")
        {
            Console.WriteLine("This is a constructor of derive class");      
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            Console.ReadLine();
        }
    }
}
