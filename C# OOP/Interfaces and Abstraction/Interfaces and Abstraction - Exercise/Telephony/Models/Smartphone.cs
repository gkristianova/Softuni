using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Telephony.Models.Contracts;

namespace Telephony.Models
{
    public class Smartphone : ICall, IBrowse
    {
        private const string CALLING_MESSAGE = "Calling... {0}";
        private const string INVALID_URL_MESSAGE = "Invalid URL!";
        private const string BROWSE_MESSAGE = "Browsing: {0}!";
        private const string INVALID_NUMBER = "Invalid number!";


        public void Browse(string url)
        {
            if (!url.Any(char.IsDigit))
            {
                Console.WriteLine(string.Format(BROWSE_MESSAGE, url));
            }
            else
            {
                Console.WriteLine(INVALID_URL_MESSAGE);
            }
        }

        public void Call(string number)
        {
            if (number.All(char.IsDigit))
            {
                Console.WriteLine(string.Format(CALLING_MESSAGE, number));
            }
            else
            {
                Console.WriteLine(INVALID_NUMBER);
            }
        }
    }
}
