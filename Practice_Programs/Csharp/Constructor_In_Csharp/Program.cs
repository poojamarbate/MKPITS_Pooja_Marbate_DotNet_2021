using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_In_Csharp
{
    class Program
    {
        //no need to call constructor.
        //default constructor.
        public Program()
        {
            Console.WriteLine("Constructor invokes !!!");
        }

        //parameterized constructor
        
        static void Main(string[] args)
        {
            Program p = new Program();
            Employees e = new Employees(1, "Jayesh Kumar", 34);
            Console.WriteLine("Employee Id : {0}",e.getID());
            Console.WriteLine("Employee Name : {0}", e.getName());
            Console.WriteLine("Employee  Age : {0}", e.getAge());

            Console.ReadLine();
        }
    }
}
