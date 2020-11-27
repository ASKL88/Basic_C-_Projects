using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions314
{
    public class NoNegative : Exception
    {
        public NoNegative()
            : base() { }
        public NoNegative(string message) 
            : base(message) { } 
    }


}
