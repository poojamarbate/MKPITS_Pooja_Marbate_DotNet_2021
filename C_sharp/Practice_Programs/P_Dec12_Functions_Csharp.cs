using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec12_Functions_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = -5, x = 2, y = 8;
            while(c<=250)
            {
                c = c + DoMath(x, y);
            }



            static void DoMath(int a, int b)
            {
                int variable = 52;
                int variable1 = a + b + variable;
                variable1 = variable1 * 2
;
                return variable;
            }
        }
    }
}
