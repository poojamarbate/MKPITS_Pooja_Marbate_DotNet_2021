using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec2_VirtualNew_Override
{
    class Shape
    {
        public string Color;
        public virtual void Area()
        {
            Console.WriteLine("Area of Shape");
        }
        public Shape()
        {
            Color = "Blue";

        }
    }
}
