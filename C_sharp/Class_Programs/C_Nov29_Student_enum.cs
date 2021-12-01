using System;

namespace C_Nov29_Student_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.WriteLine(s1);

            Student s2 = new Student(2, "Ishant Sharma", 9, new Date(30, 6, 2021), House.Yellow);
            Console.WriteLine(s2);

        }
    }
}
