using System;

namespace C_Dec1_Convert_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            char rainbowcolor; 
            Console.WriteLine("Enter color code ");
            rainbowcolor = Convert.ToChar(Console.ReadLine());
          //"R" and 'R' are not same

          decimal price;
          Console.WriteLine("enter price");
          price = Convert.ToDecimal(Console.ReadLine());
          Console.WriteLine(" price = {0:C}",price);


            

            DateTime today;
            Console.WriteLine("enter date");
            today = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Today Date : "+today);

            bool ans=true;
            Console.WriteLine("Enter answer true/false");
            ans = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("yes i want to repeat "+ans);



        }

    }
}
