using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHinding2_Inheritance
{
    class Employee
    {
        public string firstname;
        public string Lastname;
        public void PrintFullName()
        {
            Console.WriteLine("Employeee name :"+firstname+" "+Lastname);
        }

    }
    class PartTimeEmployee:Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine("Employeee name :" + firstname + " " + Lastname+" PTE");
        }

    }
    class FullTimeEmployee:Employee
    {
        public new void PrintFullName()
        {
            Console.WriteLine("Employeee name :" + firstname + " " + Lastname+" FTE");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.firstname = "Ishant";
            PTE.Lastname = "Sharma";
            PTE.PrintFullName();//method hidding

            Console.ReadLine();
        }
    }
}
