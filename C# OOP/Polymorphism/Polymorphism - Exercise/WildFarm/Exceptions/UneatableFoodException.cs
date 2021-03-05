using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Exceptions
{
    class UneatableFoodException : Exception
    {
       

        public UneatableFoodException(string message) : base(message)
        {
        }
    }
}
