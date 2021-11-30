using System;
using System.Collections.Generic;
using System.Text;

namespace H_Nov26_Book_Class
{
    class Date
    {
        int day, month, year;

        public Date()
        {
            day = 26;
            month = 9;
            year = 2021;
        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;

        }

        public void Display()
        {
            Console.WriteLine("Published Date : " + day + "/" + month + "/" + year);
        }
    }
}
