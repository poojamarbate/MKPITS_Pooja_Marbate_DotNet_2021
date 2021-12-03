using System;
using System.Collections.Generic;
using System.Text;

namespace H_Nov29_Class_with_object_method
{
    class Date
    {
        public int day,month,year;


        public  Date()               //constructor
        {
            day = 4;
            month = 12;
            year = 1999;

        }

        public Date(int d,int  m,int y)        //parameterized constructor
        {
            day = d;
            month = m;
            year = y;
        }


        //public void Show()
        //{
        //    Console.WriteLine(day+"-"+month+"-"+year);
        //}
        //ToString() method is coming from object class
        //GetHashCode()
        //GetType()
        //Equals()
        //what is overriding
        //function  signature is same but body is different

        public override string ToString()
        {
            return day + "/" + month + "/" + year;
        }

    }
}
