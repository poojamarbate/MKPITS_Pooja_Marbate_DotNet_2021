using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types_Of_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //single dimensional arrays
            //multi dimesional arrays
            int[] arr = new int[3];
            arr[0] = 23;
            arr[1] = 33;  //single dimensional array
            arr[2] = 43;


            //rectangle multi dimensional array
            int[,] my_arry = new int[3, 4]
                                 //[row,column]
            {
                { 1,2,3,6},//0 index store
                { 2,7,9,8},//1 index store
                {6,8,9,2 } //2 index store

                //if i want to acces 2(1,0);
            };
            Console.WriteLine(my_arry.GetLength(0));//dimension return

            Console.WriteLine(my_arry.GetLength(1));
            Console.WriteLine("Rank:"+my_arry.Rank);//property[i,j]


            Console.WriteLine("----------------------------------------------");
            for (int i = 0; i < my_arry.GetLength(0); i++)
            {
                for (int j = 0; j < my_arry.GetLength(1); j++)
                {
                    Console.Write(my_arry[i, j] + " " + "");
                }
                Console.WriteLine();
            }


            Console.WriteLine("--------------foreach loop------------------");

            foreach (int item in my_arry)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n\n\n------------jagged Array---------");
            //jagged array
            int[][] my_Array = new int[3][];

            my_Array[0] = new[] { 11, 22, 33, 44,09 };
            my_Array[1] = new[] { 55, 22, 88, 44 };
            my_Array[2] = new[] { 10, 12};

            for (int i = 0; i < my_Array.GetLength(0); i++)
            {
                for (int j = 0; j < my_Array[i].Length; j++)
                {
                    Console.Write(my_Array[i][j] + " ");
                }
                Console.WriteLine();
            }





            Console.ReadLine();
            
        }
    }
}
