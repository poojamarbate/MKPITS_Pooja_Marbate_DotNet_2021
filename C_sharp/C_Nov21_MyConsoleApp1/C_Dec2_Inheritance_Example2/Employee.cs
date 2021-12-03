using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec2_Inheritance_Example2
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Basic_sal { get; set; }
        public Employee()
        {
            Id = 1;
            Name = "Pooja";
            Basic_sal = 35000;
        }
        public Employee(int id, string name, decimal basic)
        {
            Id = id;
            Name = name;
            Basic_sal = basic;

        }
        //virtual method can be overriden in child class
        //public virtual void GrossSalary()
        //{
        //    Console.WriteLine("Gross Salary is " + Basic_sal);

        //}
        public virtual decimal GrossSalary()
        {

            return Basic_sal;
        }
        public static void ShowNetSalary(Employee emp)
        {
            Console.WriteLine(emp.GrossSalary()-1000);

        }
    }
}
