using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_instance_memebers_of_class
{
    class Student
    {
        public int rollno;//instance variable
        public string first_name;
        public string last_name;
        public int standard;

        //static value means :same values for all objects
        public static string schoolName = "ABC school";
        public static int Fees=4000;
       
        public void PrintFullname()//instance method
        {
            string fullname = this.first_name + " " + this.last_name;
            Console.WriteLine("your fullname is {0}", fullname);
        }

        //static method
        //no need to create any object
        //only access static variable
        public static int GetFees()
        {
            return Fees;
        }

        public static int GetFeesAnnualIncre(int fee)
        {
            return fee/10;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
            Student ram = new Student();
            ram.rollno = 23;
            ram.first_name = "Ram";
            ram.last_name = "Kapoor";
            

            Student Abhi = new Student();
            Abhi.rollno = 05;
            Abhi.first_name = "Abhimanyu";
            Abhi.last_name = "Birla";
            Abhi.standard = 11;
           

            Console.WriteLine(ram.rollno);
            Console.WriteLine(ram.first_name);
            Console.WriteLine(ram.last_name);
            Console.WriteLine(ram.standard);
            Console.WriteLine(Student.schoolName);

            ram.PrintFullname();


            Console.WriteLine("________________________");
            Console.WriteLine(Abhi.rollno);
            Console.WriteLine(Abhi.first_name);
            Console.WriteLine(Abhi.last_name);
            Console.WriteLine(Abhi.standard);
            Console.WriteLine(Student.schoolName);
            Console.WriteLine(Student.GetFees());
            Console.WriteLine(Student.GetFeesAnnualIncre(7000));
            Abhi.PrintFullname();
            Console.ReadLine();
        }
    }
}
