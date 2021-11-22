using System;//header file

namespace C_Nov21_MyConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Hello World!");//cursor stay in same line
            // Console.WriteLine("Hello ! I am Pooja dot net devlepoer");//cursor goes  to next
            //code 2 :
            int x = 10, y = 5;
            double pi = 3.14;
            char color = 'r';
            decimal price = 45.50m;//m for money
            string name = "Pooja";
            Console.WriteLine("x = " + x + "y = " + y + "color code is "+color);
            //write cw and press tab key
            //select code and press control kc for comment and ^ku for undo comment
            //string format of writeline
            //Console.WriteLine("pi = "+pi+ "price "+price);
            //Console.WriteLine("My name is " + name);

            //formated output of numeric data
            //Console.WriteLine(" x ={0} y={1} pi ={2:F2} Price{3:c}"x,y,pi,price);

            //code 3: input statement
            //string Name;
            //Console.WriteLine("Enter your name :");
            //Name = Console.ReadLine();
            //Console.WriteLine(" My name is "+name);
            //Console.WriteLine(" enter value of x");
            //x = Convert.ToInt32(Console.ReadLine()); //"10"

            //Console.WriteLine(" enter value of y");

            //y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("x + y = " + (x + y));

            // area of circle
            Console.WriteLine("Enter radius :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("formated output of area is ={0:F2}",(pi*x*x));
            double Area = Math.PI * x * x;

            Console.WriteLine("area of circle  = "+Area);










            Console.ReadKey();
        }
    }
}
