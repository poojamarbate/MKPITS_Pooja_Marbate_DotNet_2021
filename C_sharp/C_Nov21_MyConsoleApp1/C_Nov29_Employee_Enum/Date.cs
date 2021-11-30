using System;
using System.Collections.Generic;
using System.Text;

namespace C_Nov29_Employee_Enum
{
    //this code is just for understanding of get or set
    class Date
    {
        int day, month, year;//private
        //get is special function to retrieve value
        //set is special function to st new value of feild(day or month or year)

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        public Date()
        {
            day = 14;
            month = 5;
            year = 1998;
        }
        public Date(int day, int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;

        }

        public override string ToString()
        {
            return day+"-"+month+"-"+year;
        }


    }
}
