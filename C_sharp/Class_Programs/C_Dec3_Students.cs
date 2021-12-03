using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec3_IComparable
{
    class Student:IComparable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int year { get; set; }

        public Student()
        {
            ID = 1;
            Name = "Bill";
            year = 1990;
        }

        public Student(int id,string name,int year)
        {
            ID = id;
            Name = name;
            this.year = year;

        }
        //s1.compareTo(s2)
        //public int CompareTo(object obj)
        //{
        //    Student s = (Student)obj;//typecasting
        //    if (this.ID < s.ID)
        //        return -1;
        //    else
        //        if (this.ID > s.ID)
        //        return +1;
        //    else
        //        return 0;
        
        //}

        public override string ToString()
        {
            return ID+" "+Name+" "+year;
        }

        public int CompareTo(object obj)
        {
            Student s = (Student)obj;
            if (this.year < s.year)
                return -1;
            else
                if (this.year > s.year)
                return +1;
            else
                return 0;
        }
    }
}
