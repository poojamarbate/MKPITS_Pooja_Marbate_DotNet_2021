using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec3_ChineesFood_Example_Override_Method
{
    class ChineeseFood
    {
        public string content { get; set; }
        public string Type { get; set; }

        public virtual void Taste()
        {
            Console.WriteLine("Taste of Food ");
        }
    }
}
