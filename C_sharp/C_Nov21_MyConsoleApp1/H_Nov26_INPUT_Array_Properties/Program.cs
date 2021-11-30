using System;

namespace H_Nov26_INPUT_Array_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[10];
            Console.WriteLine("Enter ten Numbers");
            for(int i=0;i<10;i++)
            {
                Numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The following Numbers Are : ");
            for(int i=0;i<10;i++)
            {
                Console.WriteLine(Numbers[i]);
            }
            Console.WriteLine("Size Of Array : "+Numbers.Length);
            
            Array.Sort(Numbers);
            Console.WriteLine("The Sorted Array : ");
            foreach(int n in Numbers)
            {
                Console.WriteLine(n + " ");
            }
            Array.Reverse(Numbers);
            Console.WriteLine("Reverse Array :");
            foreach(int n in Numbers)
            {
                Console.WriteLine(n +" ");
            }
            Console.ReadKey();
        }
    }
}
