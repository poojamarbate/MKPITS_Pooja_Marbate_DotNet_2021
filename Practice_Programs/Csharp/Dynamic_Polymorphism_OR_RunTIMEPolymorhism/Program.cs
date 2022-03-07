using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Polymorphism_OR_RunTIMEPolymorhism
{
    class parent
    {
       public virtual void print()
        {
            Console.WriteLine("THIS IS A MEHOD OF PARENT CLASS");
        }
    }
    class child:parent
    {
        public override void print() //apni hissab se implementation
        {
            //    Console.WriteLine("THIS IS A MEHOD OF CHILD CLASS");
            base.print();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //child c = new child();
            //c.print();
           
            parent p = new child();
            p.print();
            Console.ReadLine();
        }
    }
}
