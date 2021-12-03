using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec3_Exception_Handing
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax error -programming
            //logical error -testing
            //run time error - can not be removed(avoided)
            //Exception handling
            try
            {
                int x = 10, y = 0;
                Console.WriteLine(x / y);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            string[] names = new string[9];
            object[] obj = names;//covariance
        }
    }
}
