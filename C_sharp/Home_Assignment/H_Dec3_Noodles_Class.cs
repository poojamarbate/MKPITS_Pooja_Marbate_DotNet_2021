using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec3_ChineesFood_Example_Override_Method
{
    class Noodles:ChineeseFood
    {
        public override void Taste()
        {
            Console.WriteLine("Yippeeeeeeeeeeee");
        }
    }
}
