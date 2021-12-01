using System;
using System.Collections.Generic;
using System.Text;

namespace H_Nov26_Book_Class
{
    class Book
    {
        int BookID;
        string BookName;
        string Author;
        string Subject;
        double price;
        int NumberOFpages;
        string Publisher;
        Date publish_date;


        public Book()
        {
            BookID = 001;
            BookName = "A Time To Kill";
            Author = "John Grisham";
            price = 674.99;
            NumberOFpages = 555;
            Publisher = "Thomas";
            publish_date = new Date(5, 6, 1998);
        }

        public void Show_details()
        {
            Console.WriteLine(BookID +" "+BookName+" "+Author+" "+price+" "+NumberOFpages+" "+Publisher);
            publish_date.Display();

        }

    }
}
