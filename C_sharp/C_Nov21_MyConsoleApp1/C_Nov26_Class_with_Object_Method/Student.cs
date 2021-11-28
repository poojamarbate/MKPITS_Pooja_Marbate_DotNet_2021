using System;
using System.Collections.Generic;
using System.Text;

namespace C_Nov26_Class_with_Object_Method
{
    class Student
    {//containtment
        public int StudentId;
        public string FirstName, Lastname;
        public int Marks;
        public Date dob; //object of date class use as propertries

       public Student()  //default constructor
        {
            StudentId = 1;
            FirstName = "Student of MKPITS";
            Lastname = "I's Batch";
            Marks = 50;
            dob = new Date(); //it take default date from Date class


        }

        public Student(int StudentId,string FirstName,string Lastname,int Marks,int day,int month,int year)  //parameterized constructor
        {
            this.StudentId = StudentId;
            this.FirstName = FirstName;
            this.Lastname = Lastname;
           this.Marks = Marks;
            dob = new Date(day,month,year);
        }

        public void ShowDetails()
        {
            Console.WriteLine("Students details : "+StudentId+" "+FirstName+" "+Lastname+" "+Marks);
            Console.WriteLine("Date of birth :");
            dob.Display();
        }





    }

}
 