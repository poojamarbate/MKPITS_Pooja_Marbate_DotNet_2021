using System;
using System.Collections.Generic;
using System.Text;

namespace C_Dec1_Inheritance_Example
{
    class Daughter:Mother
    {
        public int D_age { get; set; }
        public string D_Name { get; set; }

        public Daughter():base()
        {
            D_age = 12;
            D_Name = "Pooja";
        }

        public Daughter(int D_age,string D_Name,int mage,string mname):base( mage, mname)
        {
            this.D_age=D_age;
            this.D_Name = D_Name;
            Console.WriteLine("Daughter Object created");
            
        }

        public override string ToString()
        {
            return base.ToString() + " Daughter's Name " + D_Name + " " + " Age "+D_age;
        }

    }
}
