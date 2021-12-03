using System;
using System.Collections.Generic;
using System.Text;

namespace H_Nov26_Employee_Class
{
    class Employee
    {
          int ID;
          string Name;
          string designation;
          decimal salary;
          Date doj;

        public Employee()
        {
            ID = 101;
            Name = "Rajesh Sharma";
            designation = "Maintances";
            salary = 15000;
            doj = new Date();
        }
        public Employee(int ID,string Name,string designation,decimal salary,Date doj)
        {
            this.ID = ID;
            this.Name = Name;
            this.designation = designation;
            this.salary = salary;
            this.doj = doj;

        }

        

        public void Show()
        {
            Console.WriteLine( ID+" "+Name+" "+designation+" "+salary+" "+doj);
           doj. Display();
        }
                    
    }
}
