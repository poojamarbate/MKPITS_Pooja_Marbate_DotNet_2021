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

            Employee e3 = new Employee(3,"Simmi Mothghare",11000);
            e3.ShowResult();
            Employee e4 = new Employee(4,"Sarita Joshi",14000);
            e4.ShowResult();
            Employee e5 = new Employee(5,"sunhash Pandey",16000);
            e5.ShowResult();
            Employee e6 = new Employee(6,"suraj marbate",38000);
            e6.ShowResult();

            Employee.ShowCount();



            Employee[] employees = new Employee[6];
            //employees[0] = e1;
            employees[1] = e2;
            employees[2] = e3;
            employees[3] = e4;
            employees[4] = e5;
            employees[6] = e6;

            for (int i=0;i<5;i++)
            {
                employees[i].ShowResult();
            }

            Console.ReadKey();

        }
    }
}
