using System;
using Telephony.Models;
using Telephony.Models.Contracts;

namespace Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine()
            .Split();
            string[] url = Console.ReadLine()
            .Split();
            ICall calling = null;
            foreach (var item in numbers)
            {
                if (item.Length == 10)
                {
                    calling = new Smartphone();
                    calling.Call(item);
                }
                else
                {
                    calling = new StationaryPhone();
                    calling.Call(item);
                }
            }
            foreach (var item in url)
            {
                IBrowse browse = new Smartphone();
                browse.Browse(item);
            }
        }
       
    }
    
}
