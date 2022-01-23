using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection
{
   
    class Program
    {
        static void Main(string[] args)
        {

            List<Item> Items = new List<Item>();
            List<decimal> Amounts = new List<decimal>();
     
            Console.WriteLine("How many items you want to purchase : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter ItemID: ");
                int ID = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter Product Name : ");
                string product = Console.ReadLine();

                Console.WriteLine("Enter Price : ");
                decimal Price = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter Qty : ");
                int Qty = Convert.ToInt32(Console.ReadLine());
               
                Item I= new Item(ID, Price, product);

                Items.Add(I);

                Amounts.Add(I.GetAmount(Qty));
            }

            foreach (object obj in Items)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("");
            Console.WriteLine("Amounts are as follows :");
            foreach (decimal amt in Amounts)
            {
                Console.WriteLine(amt);
            }

            Console.ReadKey();
        }

        
    }
}
