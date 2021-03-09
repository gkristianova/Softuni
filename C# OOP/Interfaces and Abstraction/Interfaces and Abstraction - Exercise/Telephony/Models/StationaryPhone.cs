using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Models.Contracts;

namespace Telephony.Models
{
    class StationaryPhone : ICall
    {
        private const string DIALING_MESSAGE = "Dialing... {0}";
        private const string INVALID_NUMBER = "Invalid number!";

        public void Call(string number)
        {
            if (number.All(char.IsDigit))
            {
                Console.WriteLine(string.Format(DIALING_MESSAGE, number));
            }
            else
            {
                Console.WriteLine(INVALID_NUMBER);
            }
        }
    }
}
