using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_Constructor
{
    class Example 
    {
        public static int a;
        public string firstname;

        public Example(string fname)
        {
            this.firstname = fname;
        }
        private Example() //private constructor
        {
        }
       
        public static int GetIncrement()
        {
            return ++a;
        }

        public static void getTime()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Example.getTime();
            Example.a = 20;
            Console.WriteLine(Example.GetIncrement());

            Example e = new Example("Ram");
            
            Console.ReadLine();
        }
    }
}
