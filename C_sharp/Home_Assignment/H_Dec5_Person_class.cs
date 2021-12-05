using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec5_Override_method
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
       public virtual void Work()
        {
            Console.WriteLine("It Works....");
        }
    }

}
