using System;
using System.Collections.Generic;
using System.Text;

namespace C_Nov29_Employee_Enum
{
    enum Department { IT, HR, CSE, CIVIL, PRODUCTION, EE };

    class Employee
    {
        int id;
        string name;
        Department department;
        decimal salary;
        Date doj;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public decimal Salary { get => salary; set => salary = value; }
        internal Department Department { get => department; set => department = value; }
        internal Date Doj { get => doj; set => doj = value; }

        public Employee()
        {
            id = 1;
            name = "Ram";
            department = Department.EE;
            salary = 35000;
            doj = new Date();
        }
        public Employee(int id,string name,decimal salary,Date doj,Department department)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.doj=doj;
            this.department = department;

                
        }

        public override string ToString()
        {
            return Id+" "+Name+" "+salary+" "+department+" "+doj;
        }
    }
}
