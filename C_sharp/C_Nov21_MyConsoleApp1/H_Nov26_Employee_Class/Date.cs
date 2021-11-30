using System;
using System.Collections.Generic;
using System.Text;

namespace H_Nov26_Employee_Class
{
    class Date
    {
        int day, month, year;
        public Date()
        {
            day = 12;
            month = 3;
            year = 2021;
        }
        public Date(int day,int month,int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void Display()
        {
            Console.WriteLine("Date : "+day+"/"+month+"/"+year);
        }
    }
}
    