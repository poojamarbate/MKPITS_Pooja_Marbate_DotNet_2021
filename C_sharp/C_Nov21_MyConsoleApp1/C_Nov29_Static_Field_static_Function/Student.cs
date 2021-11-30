using System;
using System.Collections.Generic;
using System.Text;

namespace C_Nov29_Static_Field_static_Function
{
    class Student
    {
        //auto implimented properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int marks { get; set; }
        public static int count { get; set; }
        public Student()
        {
            Id = 1;
            Name = "Billu";
            marks = 88;
            count++; //shared field by all objects
        }

        public Student(int Id,string Name,int marks)
        {
            this.Id = Id;
            this.Name = Name;
            this.marks = marks;
            count++;

        }

        //object method:it is called with object 
        public void ShowResult()
        {
            if(marks>=50)
                Console.WriteLine(Name+" is pass");
            else
                Console.WriteLine(Name+" is Fail");
        }

        //static method: its called with class ex..student.showcount()

        public static void ShowCount()
        {
            Console.WriteLine("Total number of student Objects = "+count);
        }

    }
}
