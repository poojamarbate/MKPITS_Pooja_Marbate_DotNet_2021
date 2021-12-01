using System;

namespace C_Dec1_Var_Ref_Out_Param
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10; //inference as x is int
            var price = 80m;
            var r = 5.689;
            var name = "Pooja";
            Console.WriteLine(" x= "+x+" Price = "+price+" r = "+r+" Name = "+name);


            x = 'r'; //ascii code of r

            int a = 200, b = 100;
            //Console.WriteLine("a = "+a+"  b = "+b+"  before calling swap function ");
            //Swap(ref a, ref b);  //call by reference

            //swap(a, b); // call by value
            //Console.WriteLine("a = " + a + "  b = " + b + " After calling swap function ");

            int radius = 7;
            double ar;
            Area(ref radius, out ar);
            Console.WriteLine("area of circle = "+ar);


            int len = 5 , brd=4 ,area;
            Rect_Area(ref len, ref brd, out area);
            Console.WriteLine(" len = "+len+"  brd= "+brd+ "  Area of rectangle = "+area);

            viewnames('g', 3, "Pooja", "Kajal", "Nikita");
            

        }
        public static void Swap(ref int x,ref int y) // ref : reference of varible
        {
            int temp = x;
            x = y;
            y = temp;

        }

        public static void swap(int x,int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void Area(ref int r,out double a)
        {
            a = Math.PI * r * r;
        }

        public static void Rect_Area(ref int l,ref int b,out int a)
        {
            a = l * b;
        }

      //parameters

        static void viewnames(char x, int n ,params string[] names)
        {
            if(x == 'g')
            {
                Console.WriteLine("Girls present in my class are : ");
                for(int i=0;i<n;i++)
                    Console.WriteLine(names[i]);
            }
            else if (x == 'b')
            {
                Console.WriteLine("Boyes present in my class  :");
                for(int i=0;i<n;i++)
                    Console.WriteLine(names[i]);
            }
        }
            
    }
}
