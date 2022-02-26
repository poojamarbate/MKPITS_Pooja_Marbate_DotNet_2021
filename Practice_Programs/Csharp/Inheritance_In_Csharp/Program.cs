using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_In_Csharp
{
    class VistingEmployee:Employee
    {
        public int vistingSal;
        public int vistingHours;
    }
    class PermanentEmployee:Employee
    {
        public int permanentSal;
        public int permanentHours;
    }

    class Employee
    {
        public int EmpId;
        public string Empname;
        public int Empage;
        public int contactno;

        public void Show()
        {
            Console.WriteLine("this a method of Base class");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployee p = new PermanentEmployee();
            p.EmpId = 3;
            
            VistingEmployee v = new VistingEmployee();
            v.Empname = "Rajveer";

            Console.WriteLine(p.EmpId);
            p.Show();
            Console.WriteLine(v.Empname);

            Console.ReadLine();
        }
    }
}
