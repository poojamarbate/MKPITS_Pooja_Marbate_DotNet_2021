using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec3_Interface_Example
{
   abstract class Vehicle
    {
        public int Speed { get; set; }

        public abstract void ShowSpeed();
    }
}
