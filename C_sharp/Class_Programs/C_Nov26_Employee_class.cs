using System;
using System.Collections.Generic;
using System.Text;

namespace C_Nov26_Class_Object_Example
{
    class Employee
    {//private,public,protected,internal
       private int id;
       public string firstname, lastname;
        public decimal salary;


        public Employee(string n,string l,decimal s)
        {
            firstname = n;
            lastname = l;
            salary = s;

        }

        public void Show()
        {
            Console.WriteLine(firstname+" "+lastname+" "+salary);
        }
    }
}
