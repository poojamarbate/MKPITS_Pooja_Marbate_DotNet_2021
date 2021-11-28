using System;
using System.Collections.Generic;
using System.Text;

namespace C_Nov26_Class_Object_Example
{
    class Date    //user defined data type
    {


        public int day, month, year;  //togatherness of 3 values

        // special feature of constructor
        //1 name of constructor is same as a class
        //2 it does not return any data even not void
        public Date() //default Constructor
        {
            day = 5;
            month = 6;
            year = 1998;
        }
        public Date(int d,int m,int y)
        {
            day = d;
            month = m;
            year = y;
        }
        public void Display()
        {
            Console.WriteLine(day + "-" + month + "-" +year);

        }




    }
}
