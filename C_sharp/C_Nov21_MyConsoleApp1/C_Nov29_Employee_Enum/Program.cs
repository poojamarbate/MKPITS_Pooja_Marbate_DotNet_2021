using System;

namespace C_Nov29_Employee_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Date d1 = new Date();
            ////d1.Day=29;if set is not written the property is read only
            ////and this statement is not allowed
            //Console.WriteLine(d1.Day);
            //Console.WriteLine(d1.ToString());

            ////Employee e1 = new Employee();
            ////Console.WriteLine(e1.Name);
            ////Console.WriteLine(e1.ToString());

            Employee obj = new Employee(1, "Rakhi", 45000,new Date(12,3,2021), Department.HR);
            Console.WriteLine(obj.ToString());


            Employee e1 = new Employee(2, "Jay", 50000, new Date(14,5,2020), Department.CSE);
            Console.WriteLine(e1);
        }
    }
}
