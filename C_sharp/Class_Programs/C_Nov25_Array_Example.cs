using System;

namespace C_Nov25_Array_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] fruits = new string[5];//array class
            ////datatype[] name of array = new datatype[size];
            ////int myarray[6];-------in c language

            //Console.WriteLine( "enter names of fruits" );
            //for(int i=0;i<5;i++)
            //{
            //    fruits[i] = Console.ReadLine();
            //}

            //Console.WriteLine("following are the fruits u entered");

            //for(int i=0;i<5;i++)
            //{
            //    Console.WriteLine(fruits[i]);//output loop
            //}

            //int[] marks = new int[5];
            //Console.WriteLine("enter five  number");
            //int sum = 0;
            //for(int i=0;i<5;i++)
            //{
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("following nubers are :");
            //for(int i=0;i<5;i++)
            //{
            //    Console.WriteLine(marks[i]);
            //    sum +=marks[i];
            //}
            //Console.WriteLine("sum of marks = "+sum);
            //Console.ReadKey();

            string[] friends = {"Rani" ,"Kshamta", "Vani", "navneet", "sumit", "snhehal" };
            Console.WriteLine("Friends names : ");
            foreach(string f in friends)
            {
                Console.Write(f+" ");//output in single line
            }
            Console.WriteLine(" size of array "+friends.Length);

            Array.Sort(friends);
            Console.WriteLine(" sorted array of friends name :");
            foreach(string f in friends)
            {
                Console.Write(f+ " ");
            }

            Array.Reverse(friends);
             Console.WriteLine("Reveres order in names : " );
            foreach(string f in friends)
                {
                Console.Write(f+" ");
                }
            Console.ReadKey();

        }
    }
}
