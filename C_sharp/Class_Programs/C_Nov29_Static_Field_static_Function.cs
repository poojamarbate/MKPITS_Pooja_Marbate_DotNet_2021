using System;

namespace C_Nov29_Static_Field_static_Function
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Student s1 = new Student();
            //Console.WriteLine("count = "+Student.count);
            Student s2 = new Student(2, "pooja", 78);
            Student s3 = new Student(3, "Nilesh sir", 45);
            Student s4= new Student(4, "Akash", 43);
            //s1.ShowResult();
            //Student.ShowCount();
            Student[] students = new Student[5];//array for object
            students[0] = s1;
            students[1] = s2;
            students[3] = s3;
            students[4] = s4;
            Console.WriteLine("Result of students is as follows :");
            for(int i=0;i<5;i++)
            {
                students[i].ShowResult();
            }

            Console.ReadKey();



        }
    }
}
