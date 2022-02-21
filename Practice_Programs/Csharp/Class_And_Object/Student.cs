using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_And_Object
{
    class Student
    {
        int rollno;
        string name;
        int age;
        int standard;
        public void setStudent(int rollno,string name,int age,int std)
        {
            this.rollno = rollno;
            this.name = name;
            this.age = age;
            this.standard = std;
        }
        public void getStudent()
        {
            Console.WriteLine("Your rollno:{0}", this.rollno);
            Console.WriteLine("Your name :{0}", this.name);
            Console.WriteLine("Age:{0}", this.age);
            Console.WriteLine("Class:{0}", this.standard);
      
     
        }
        static void Main(string[] args)
        {
            //    int rollno;
            //    string name;
            //    int age;
            //    int standards;

            Console.WriteLine("Enter rollno:");
            int roll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter class");
            int std = int.Parse(Console.ReadLine());
            Student s = new Student();
            s.setStudent(roll,name,age,std);
            s.getStudent();

            Console.ReadLine();

        }
    }
}
