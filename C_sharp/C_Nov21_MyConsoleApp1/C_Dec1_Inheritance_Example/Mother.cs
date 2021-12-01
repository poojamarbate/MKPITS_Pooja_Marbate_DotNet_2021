using System;
using System.Collections.Generic;
using System.Text;

namespace C_Dec1_Inheritance_Example
{
    class Mother
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Mother()
        {
            Age = 45;
            Name = "Kavita";
        }

        public Mother(int Age,string Name)
        {
            this.Age = Age;
            this.Name = Name;
            Console.WriteLine("Mother's object created");
        }

        public override string ToString()
        {
            return "Mother's Name  "+Name+" Age "+Age;
        }

    }
}
