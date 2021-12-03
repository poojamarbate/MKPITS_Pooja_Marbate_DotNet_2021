using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec3_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            students[0] = new Student(23, "Pooja", 2020);
            students[1] = new Student(3, "Akash", 2019);
            students[2] = new Student(7, "Nilesh sir",2017);
            students[3] = new Student(45, "Nikhil", 2019);
            students[4] = new Student(29, "Kajal", 2020);
            foreach(Student s in students)
                Console.WriteLine(s);

            Array.Sort(students);
            Console.WriteLine("..................");
            foreach(Student s in students)
                Console.WriteLine(s);

        }
    }
}
