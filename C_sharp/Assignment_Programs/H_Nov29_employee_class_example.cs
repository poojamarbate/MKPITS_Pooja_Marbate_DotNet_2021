using System;

namespace H_Nov29_Employee_Class_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee e1 = new Employee();
            //e1.ShowResult();
            //Employee.ShowCount();

            Employee e2 = new Employee(2,"Rohini Gill",23000);
            e2.ShowResult();
            Console.WriteLine("The Gross Salary : {0:C}",e2.GrossSalary());
            Employee.ShowCount();

            Employee e3, e4, e5, e6;

            e3 = new Employee(3,"Simmi Mothghare",11000);
        
            e4 = new Employee(4,"Sarita Joshi",14000);
           
           e5 = new Employee(5,"sunhash Pandey",16000);
           
           e6 = new Employee(6,"suraj marbate",38000);
           
          
            Employee.ShowCount();

            Console.ReadKey();

        }
    }
}
