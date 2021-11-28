using System;

namespace C_Nov26_Class_with_Object_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Date obj= new Date();
            obj.Display();
            Student S1 = new Student();
            S1.ShowDetails();

            Student obj1 = new Student(1, "Pooja", "Marbate", 45000, 5, 6, 1998);
            obj1.ShowDetails();

        }
    }
}
