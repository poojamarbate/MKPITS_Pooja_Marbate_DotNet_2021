using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Class_IN_csharp
{
    static class Product
    {
        public static int ProductId;
        public static string Productname;
        public static int Price;
        static Product()  //static constructor
        {
            ProductId = 1;
            Productname = "Guitar";
            Price = 7000;
        }
        public static void GetproductDetail()
        {
            Console.WriteLine("ID: "+ProductId+" Productname: "+Productname+" Price"+Price);
        }

        public static void GetDiscount()
        {
            int d_amount = Price / 10;
            Console.WriteLine("your discount amount :{0}",d_amount);
            Console.WriteLine("Total cost of product:{0}",(Price-d_amount));
        }
    }

    //class item:Product
    //{

    //}
    class Program
    {
        static void Main(string[] args)
        {
            // Product p = new Product();
            Product.GetproductDetail();
            Product.GetDiscount();
            


            Console.ReadLine();
        }
    }
}
