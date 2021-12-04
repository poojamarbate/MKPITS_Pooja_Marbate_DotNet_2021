using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Dec4_CustomException_Throw
{
    public class MYCustomException : ApplicationException
    {
        public MYCustomException(string msg) : base(msg)
        {

        }
    }
}

