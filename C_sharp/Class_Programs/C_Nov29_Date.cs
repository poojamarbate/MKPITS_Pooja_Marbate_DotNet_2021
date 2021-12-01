using System;
using System.Collections.Generic;
using System.Text;

namespace C_Nov29_Student_Enum
{
    class Date
    {
        int day, month, year;

        public int Day { get => day; set => day = value; }
        public int Month { get => month; set => month = value; }
        public int Year { get => year; set => year = value; }

        public Date()
        {
            day = 26;
            month = 6;
            year = 2021;
        }
        public Date(int day,int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public override string ToString()
        {
            return day+"/"+month+"/"+year;
        }
    }
}
