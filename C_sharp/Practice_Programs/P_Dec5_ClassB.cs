using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Dec5_baseClass_constructor_fromDerivedClass
{
    public class ClassB:ClassA
    {
        public ClassB() : base() { } //default 

        public ClassB(int i,int j) : base(i, j) { }
    }
}
