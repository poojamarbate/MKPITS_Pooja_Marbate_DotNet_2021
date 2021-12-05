using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec5_Override_method
{
    class Employee:Person
    {
        public double Salary { get; set; }
        public string Designation { get; set; }
        public override void Work()
        {
            Console.WriteLine("It earns....");
        }
    }
}
