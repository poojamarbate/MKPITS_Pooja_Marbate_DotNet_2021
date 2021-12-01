using System;

namespace H_Nov26_Employee_Class
{
    class Program
    {
        static void Main(string[] args)
        {
           Employee e1= new Employee();
            e1.Show();
            Gross_Sal(15000);

            Employee e2 = new Employee(102, "Jay Kumar", "Hr", 18000, new Date(12, 5, 2020));
            e2.Show();
            Gross_Sal(18000);

        }

        public static void Gross_Sal(int salary)
        {
            Console.WriteLine("Gross Salary : ");
            Console.WriteLine(salary+666);
        }

    }
}
