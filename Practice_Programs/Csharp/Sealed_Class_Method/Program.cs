using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class_Method
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("This is A class method");
        }
    }
    class B:A
    {
        public sealed override void Print()
        {
            Console.WriteLine("This is B class method");
        }
    }
    class C : B
    {
        public override void Print()
        {
            Console.WriteLine("This is C class method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c  = new C();
            c.Print();
            Console.ReadLine();
        }
    }
}
