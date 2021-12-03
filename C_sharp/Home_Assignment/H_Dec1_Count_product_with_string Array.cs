using System;

namespace H_Dec1_Count_Product_with_stringArray
{
    class Program
    {
        static void Main(string[] args)
        {


            CountProducts("Soap","FaceWash","Cream");
            Console.WriteLine("Following Fruits are : ");
            CountProducts("Mango", "Apple", "Orange","Berry");

            GetDetails(Name: "Pooja", designation: "Software developer", id: 3);
            
         
        }
         public static void CountProducts(params string[]products)
        {
            foreach(string P in products)
            {
                Console.WriteLine(P+ " ");

            }
            Console.WriteLine("Product count : "+products.Length);
        

        }

        public static void  GetDetails(int id,string Name,string designation)
        {
            Console.WriteLine(" Id : "+id+"  Name : "+Name+" designation : "+designation);

        }
       

    }
}
