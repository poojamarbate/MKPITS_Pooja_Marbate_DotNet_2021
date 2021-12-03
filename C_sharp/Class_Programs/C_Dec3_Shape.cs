using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec3_AbstractClass_Interface
{
    abstract class Shape
    {
        public string color { get; set; }

        public abstract void Area();//method or function 

        //(abstract - override) (virtual-override not compulsory)
        //(virtual-new)

        public virtual void ShowColor()
        {
            Console.WriteLine("Color of Shape");
        }
    }
}
