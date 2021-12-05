using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_Dec3_Bird_withOverrideMethod_Example
{
    class Sparrow:BirdClass
    {
        public Sparrow(string c,int w) : base(c, w) { }

        public override void Voice()
        {
            base.Voice();
            Console.WriteLine("Chirp Chirp...."+"\ncolor of bird : "+color+"\nweight of bird: "+weight+" gm ");
        }
    }
}
