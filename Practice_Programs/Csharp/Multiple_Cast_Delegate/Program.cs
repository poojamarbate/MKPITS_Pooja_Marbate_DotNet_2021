using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Cast_Delegate
{
    public delegate void Show();
    public delegate void calculation(int num1, int num2);
    public delegate void SquareANDCube(int a);
   
    class Program
    {
        public static void Cube(int a)
        {
            Console.WriteLine("cube of number:{0}", (a * a * a));
        }

        public static void Square(int a)
        {
            Console.WriteLine("square of number:"+(a*a));
        }

        //multiple delegates 
        public static void Addition(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Adddition is:{0}",result);
        }
        public static void multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("multiplication is:{0}", result);
        }
        public static void Subtration(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("Subtration is:{0}", result);
        }
        public static void division(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine("division is:{0}", result);
        }
        public static void Show()
        {
            Console.WriteLine("Show method.......................");
        }
        static void Main(string[] args)
        {
            SquareANDCube q = new SquareANDCube(Square);
            q.Invoke(4);
            q = Cube;
            q.Invoke(4);
            //CubeRootOFNumber r = new CubeRootOFNumber(Cube);
            //r(2);

            Show s = new Show(Show);
            s.Invoke();

            calculation c = new calculation(Addition);
            c.Invoke(12, 12);
            c = Subtration;
            c.Invoke(100, 50);
            c = multiplication;
            c.Invoke(2, 10);
            c = division;
            c.Invoke(6, 3);
            Console.ReadLine();
        }
    }
}
