using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec4_Collections
{
    class Student
    {
        public int rollnumber { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return "Rollnumber : "+rollnumber + " Name: " + Name;
        }
    }
}
