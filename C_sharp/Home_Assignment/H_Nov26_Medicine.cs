using System;
using System.Collections.Generic;
using System.Text;

namespace H_Nov26_Class_Medicine
{
    class Medicine
    {
        int ID;
        string Medicine_Name;
        string Medicine_Type;
        double  price;
        Date expiry;

        public Medicine()
        {
            ID = 11056;
            Medicine_Name = "Omee";
            Medicine_Type = "Acidity";
            price = 10.65;
            expiry = new Date();
        }

        public Medicine(int ID,string Medicine_Name,string Medicine_Type,double price,Date expiry)
        {
            this.ID = ID;
            this.Medicine_Name = Medicine_Name;
            this.Medicine_Type = Medicine_Type;
            this.price = price;


        }

        public void Show_Details()
        {
            Console.WriteLine("MedicineID : "+ID);
            Console.WriteLine("Medicine Name : "+Medicine_Name);
            Console.WriteLine("Medicine Type : "+Medicine_Type);
            Console.WriteLine("Price : "+price+" Rs/-");

            expiry.Display();

            
        }


    }
}
