using System;
using System.Collections.Generic;
using System.Text;

namespace H_Nov29_Employee_Class_Example
{
    class Employee
    {
        public int id { get; set; }
        public string Fullname { get; set; }
        public decimal salary { get; set; }

        public static int count { get; set; }


        public Employee()
        {
            id = 1;
            Fullname = "Priya Sharma";
            salary = 15000;
            count++;
        }
        public Employee(int id,string Fullname,decimal salary)
        {
            this.id = id;
            this.Fullname = Fullname;
            this.salary = salary;
            count++;
        }

        public void ShowResult()
        {
            Console.WriteLine(id+" "+Fullname+" "+salary);
        }

        public static void ShowCount()
        {
            Console.WriteLine("Totol Employees : "+count);
        }
    }
}
