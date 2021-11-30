using System;
using System.Collections.Generic;
using System.Text;

namespace C_Nov29_Student_Enum
{
    enum House{Blue,Green,Yellow,Red}; // keyword to giving the label OR number
    class Student
    {
        int rollno;
        string fullname;
        int std;
        Date doj;
        House house;

        public int Rollno { get => rollno; set => rollno = value; }
        public string Fullname { get => fullname; set => fullname = value; }
        public int Std { get => std; set => std = value; }

        //access modifier
        //public
        //private
        //protected
        //internal

        public Student()
        {
            rollno = 1;
            fullname = "Kirshna sharma";
            std = 10;
            doj = new Date();
            house = House.Blue;

        }
        public Student(int rollno,string fullname,int std,Date doj,House house)
        {
            this.rollno = rollno;
            this.fullname = fullname;
            this.std = std;
            this.doj = doj;
            this.house = house;
        }

        public override string ToString()
        {
            return Rollno +"  "+ Fullname +"  "+ std +"  "+doj+"  "+house;
        }
    }
}
