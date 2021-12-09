using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec9_WatchTime_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec, min, hr, temp, temp2;
            Console.WriteLine("Enter time in second ");
            sec = Convert.ToInt32(Console.ReadLine());
            hr = sec / 3600;
            temp = sec % 3600;
            min = temp / 60;
            temp2 = temp % 60;
            Console.Write("watch time : ");
            Console.Write(hr+" hr "+min+" min "+sec+" sec");
            Console.ReadKey();

        }
    }
}
