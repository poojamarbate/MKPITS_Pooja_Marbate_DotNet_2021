using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec3_Bird_withOverrideMethod_Example
{
    class Crow:BirdClass
    {
        public Crow(string c,int w) : base(c, w) { }//parameterized constructor

        public override void Voice()
        {
            base.Voice();
            Console.WriteLine("Caw Caww...... "+" \ncolor of bird : "+color+ " \nweight of bird : "+ weight+" gm ");
        }


    }
}
