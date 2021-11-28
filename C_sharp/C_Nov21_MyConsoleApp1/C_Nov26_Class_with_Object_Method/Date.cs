using System;
using System.Collections.Generic;
using System.Text;

namespace C_Nov26_Class_with_Object_Method
{
    class Date
    {
        public int day, month, year;

        public Date() //default constructor
        {
            day = 25;
            month = 12;
            year = 1980;

        }
        public Date(int d,int m,int y)  //parameteried constructor
        {
            day = d;
            month = m;
            year = y;
        }

        public void Display()
        {
            Console.WriteLine(day+"/"+month+"/"+year);
        }
             
    }
}
