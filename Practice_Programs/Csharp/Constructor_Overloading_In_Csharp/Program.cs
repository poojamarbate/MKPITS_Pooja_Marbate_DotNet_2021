using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Overloading_In_Csharp
{
    class Program
    {
        //same name but different signature. 
        public Program()
        {
            Console.WriteLine("This is a default constructor....");
        }
        public Program(int a,int b)
        {
            Console.WriteLine("This is a second constructor....{0}",(a+b));
        }

        public Program(int a, int b,int c)
        {
            Console.WriteLine("This is a third  constructor....{0}", (a + b+c));
        }


        static void Main(string[] args)
        {
            //constructor overloading
            //decide in complie time which constructor is call.
            Program p = new Program();
            Program e= new Program(20,30);
            Program q = new Program(20,30,40);
            Console.ReadLine();
        }
    }
}
